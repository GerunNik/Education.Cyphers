namespace CipherTest
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmbCyphers = new System.Windows.Forms.ComboBox();
            this.txtEncode = new System.Windows.Forms.RichTextBox();
            this.txtEncodedText = new System.Windows.Forms.RichTextBox();
            this.txtKey = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbCyphers
            // 
            this.cmbCyphers.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmbCyphers.FormattingEnabled = true;
            this.cmbCyphers.Location = new System.Drawing.Point(380, 56);
            this.cmbCyphers.Name = "cmbCyphers";
            this.cmbCyphers.Size = new System.Drawing.Size(121, 21);
            this.cmbCyphers.TabIndex = 0;
            this.cmbCyphers.SelectedIndexChanged += new System.EventHandler(this.cmbCyphers_SelectedIndexChanged);
            // 
            // txtEncode
            // 
            this.txtEncode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtEncode.Location = new System.Drawing.Point(20, 56);
            this.txtEncode.Name = "txtEncode";
            this.txtEncode.Size = new System.Drawing.Size(354, 274);
            this.txtEncode.TabIndex = 1;
            this.txtEncode.Text = "";
            this.txtEncode.TextChanged += new System.EventHandler(this.txtEncode_TextChanged);
            // 
            // txtEncodedText
            // 
            this.txtEncodedText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEncodedText.Location = new System.Drawing.Point(507, 56);
            this.txtEncodedText.Name = "txtEncodedText";
            this.txtEncodedText.ReadOnly = true;
            this.txtEncodedText.Size = new System.Drawing.Size(354, 274);
            this.txtEncodedText.TabIndex = 2;
            this.txtEncodedText.Text = "";
            // 
            // txtKey
            // 
            this.txtKey.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtKey.Location = new System.Drawing.Point(380, 121);
            this.txtKey.Name = "txtKey";
            this.txtKey.Size = new System.Drawing.Size(121, 20);
            this.txtKey.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Decoded Text";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(507, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Encoded Text";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(380, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Cipher";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(380, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Key";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 358);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtKey);
            this.Controls.Add(this.txtEncodedText);
            this.Controls.Add(this.txtEncode);
            this.Controls.Add(this.cmbCyphers);
            this.MinimumSize = new System.Drawing.Size(909, 397);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbCyphers;
        private System.Windows.Forms.RichTextBox txtEncode;
        private System.Windows.Forms.RichTextBox txtEncodedText;
        private System.Windows.Forms.TextBox txtKey;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

