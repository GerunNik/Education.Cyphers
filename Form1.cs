namespace CipherTest
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Security.Cryptography;
    using System.Text;
    using System.Windows.Forms;
    public partial class Form1 : Form
    {
        static int firstEnigmaWheelConfig = 0;
        static int secondEnigmaWheelConfig = 0;
        static int thirdEnigmaWheelConfig = 0;

        static int amountOfRevolutionsForSecondWheelTurnConfig = 26;
        static int amountOfRevolutionsForThirdWheelTurnConfig = 26;

        int firstEnigmaWheel;
        int secondEnigmaWheel;
        int thirdEnigmaWheel;

        int amountOfRevolutionsForSecondWheelTurn;
        int amountOfRevolutionsForThirdWheelTurn;

        public Form1()
        {
            InitializeComponent();
            var ListOfCiphers = new List<string>();
            ListOfCiphers.Add("Caesar Cipher");
            ListOfCiphers.Add("Vigenère Cipher");
            ListOfCiphers.Add("Enigma Code");
            ListOfCiphers.Add("XOR");
            ListOfCiphers.Add("AES");

            FillCombo(ListOfCiphers);
            ResetEnigma();
        }

        void FillCombo(List<string> AllCyphers)
        {
            foreach (var item in AllCyphers)
            {
                cmbCyphers.Items.Add(item);
            }
        }

        private void txtEncode_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtEncode.Text))
            {
                switch (cmbCyphers.Text)
                {
                    case "Caesar Cipher":
                        EncryptCaesar();
                        break;

                    case "Vigenère Cipher":
                        EncryptVigenere();
                        break;

                    case "Enigma Code":
                        EncryptEnigma();
                        break;

                    case "XOR":
                        EncryptXOR();
                        break;

                    case "AES":
                        EncryptAES();
                        break;
                        
                    default:
                        EncryptEnigma();
                        break;

                }
            }
        }

        void EncryptCaesar()
        {
            string encrypted = string.Empty;

            if (txtKey.Text == string.Empty)
            {
                txtKey.Text = "0";
            }
            
            foreach (char item in txtEncode.Text)
            {
                encrypted += Cipher(item, Convert.ToInt32(txtKey.Text));
            }

            txtEncodedText.Text = encrypted;
        }

        void EncryptVigenere()
        {
            txtKey.Text = txtKey.Text.ToUpper();
            
            string encrypted = string.Empty;

            if (txtKey.Text == string.Empty)
            {
                txtKey.Text = "Test";
            }

            var toEncrypt = new List<char>();
            var keyToEncrypt = new List<char>();

            int charCounter = 0;

            foreach (char item in txtEncode.Text)
            {
                toEncrypt.Add(item);
                keyToEncrypt.Add(txtKey.Text[charCounter % (txtKey.TextLength)]);
                charCounter++;
            }

            for (int i = 0; i < txtEncode.TextLength; i++)
            {
                encrypted += Cipher(toEncrypt[i], keyToEncrypt[i]);
            }

            txtEncodedText.Text = encrypted;
        }

        void EncryptEnigma()
        {
            string encrypted = string.Empty;

            foreach (var item in txtEncode.Text)
            {
                char firstRotation = Cipher(item, firstEnigmaWheel % 26 + secondEnigmaWheel % 26 + thirdEnigmaWheel % 26);

                firstEnigmaWheel++;

                if (firstEnigmaWheel % amountOfRevolutionsForSecondWheelTurn == 0)
                {
                    secondEnigmaWheel++;
                }

                if (secondEnigmaWheel % amountOfRevolutionsForThirdWheelTurn == 0)
                {
                    thirdEnigmaWheel++;
                }
                encrypted += Cipher(firstRotation, firstEnigmaWheel % 26 + secondEnigmaWheel % 26 + thirdEnigmaWheel % 26);
            }
            txtEncodedText.Text = encrypted;

            ResetEnigma();
        }
        
        void EncryptXOR()
        {
            StringBuilder szInputStringBuild = new StringBuilder(txtEncode.Text);
            StringBuilder szOutStringBuild = new StringBuilder(txtEncode.Text.Length);
            char Textch;
            for (int iCount = 0; iCount < txtEncode.Text.Length; iCount++)
            {
                Textch = szInputStringBuild[iCount];
                Textch = (char)(Textch ^ Convert.ToInt32(txtKey.Text));
                szOutStringBuild.Append(Textch);
            }
            txtEncodedText.Text = szOutStringBuild.ToString();
        }
        
        void EncryptAES()
        {
            byte[] encrypted;
            AesManaged aes = new AesManaged();
            MemoryStream ms = new MemoryStream();
            ICryptoTransform encryptor = aes.CreateEncryptor();

            using (CryptoStream cs = new CryptoStream(ms, encryptor, CryptoStreamMode.Write))
            {
                using (StreamWriter sw = new StreamWriter(cs))
                {
                    sw.Write(txtEncode.Text);
                }

                encrypted = ms.ToArray();
                txtEncodedText.Text = Encoding.UTF8.GetString(encrypted);
            }   
        }

        void ResetEnigma()
        {
            firstEnigmaWheel = firstEnigmaWheelConfig;
            secondEnigmaWheel = secondEnigmaWheelConfig;
            thirdEnigmaWheel = thirdEnigmaWheelConfig;

            amountOfRevolutionsForSecondWheelTurn = amountOfRevolutionsForSecondWheelTurnConfig;
            amountOfRevolutionsForThirdWheelTurn = amountOfRevolutionsForThirdWheelTurnConfig;
        }

        public char Cipher(char ch, int key)
        {
            if (cmbCyphers.SelectedItem?.ToString() == "Vigenère Cipher")
            {
                key -= 65;
            }

            if (!char.IsLetter(ch))
            {
                return ch;
            }

            char d = char.IsUpper(ch) ? 'A' : 'a';
            return (char)((((ch + key) - d) % 26) + d);
        }

        void FormatKeyValueCorrectly()
        {
            switch (cmbCyphers.SelectedItem)
            {
                case "Caesar Cipher":
                    txtKey.Text = "13";
                    txtKey.Enabled = true;
                break;

                case "Vigenère Cipher":
                    txtKey.Text = "TEST";
                    txtKey.Enabled = true;
                    break;

                case "Enigma Code":
                    txtKey.Text = string.Empty;
                    txtKey.Enabled = false;
                    break;

                case "XOR":
                    txtKey.Text = "111";
                    txtKey.Enabled = true;
                    break;

                case "AES":
                    txtKey.Text = "111";
                    txtKey.Enabled = true;
                    break;
            }
        }

        private void cmbCyphers_SelectedIndexChanged(object sender, EventArgs e)
        {
            FormatKeyValueCorrectly();
            txtEncode_TextChanged(new object(), new EventArgs());
        }
    }
}
