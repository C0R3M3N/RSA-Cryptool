
namespace RSA_Cryptool
{
    partial class Decrypt
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
            this.label11 = new System.Windows.Forms.Label();
            this.NhapQ = new System.Windows.Forms.TextBox();
            this.alert_M = new System.Windows.Forms.Label();
            this.alert_e = new System.Windows.Forms.Label();
            this.alert_n = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button_Crypt = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CipherTextBox = new System.Windows.Forms.RichTextBox();
            this.plainTextBox = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.NhapP = new System.Windows.Forms.TextBox();
            this.NhapE = new System.Windows.Forms.TextBox();
            this.NhapN = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(440, 201);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(20, 17);
            this.label11.TabIndex = 25;
            this.label11.Text = "e:";
            // 
            // NhapQ
            // 
            this.NhapQ.Location = new System.Drawing.Point(466, 254);
            this.NhapQ.Margin = new System.Windows.Forms.Padding(4);
            this.NhapQ.Name = "NhapQ";
            this.NhapQ.Size = new System.Drawing.Size(100, 22);
            this.NhapQ.TabIndex = 24;
            // 
            // alert_M
            // 
            this.alert_M.AutoSize = true;
            this.alert_M.ForeColor = System.Drawing.Color.Red;
            this.alert_M.Location = new System.Drawing.Point(571, 114);
            this.alert_M.Name = "alert_M";
            this.alert_M.Size = new System.Drawing.Size(157, 17);
            this.alert_M.TabIndex = 23;
            this.alert_M.Text = "This fill cannot be blank";
            this.alert_M.Visible = false;
            // 
            // alert_e
            // 
            this.alert_e.AutoSize = true;
            this.alert_e.ForeColor = System.Drawing.Color.Red;
            this.alert_e.Location = new System.Drawing.Point(571, 201);
            this.alert_e.Name = "alert_e";
            this.alert_e.Size = new System.Drawing.Size(157, 17);
            this.alert_e.TabIndex = 22;
            this.alert_e.Text = "This fill cannot be blank";
            this.alert_e.Visible = false;
            // 
            // alert_n
            // 
            this.alert_n.AutoSize = true;
            this.alert_n.ForeColor = System.Drawing.Color.Red;
            this.alert_n.Location = new System.Drawing.Point(275, 201);
            this.alert_n.Name = "alert_n";
            this.alert_n.Size = new System.Drawing.Size(157, 17);
            this.alert_n.TabIndex = 21;
            this.alert_n.Text = "This fill cannot be blank";
            this.alert_n.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(62, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 17);
            this.label7.TabIndex = 20;
            this.label7.Text = "Decrypt";
            // 
            // button_Crypt
            // 
            this.button_Crypt.Location = new System.Drawing.Point(620, 351);
            this.button_Crypt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_Crypt.Name = "button_Crypt";
            this.button_Crypt.Size = new System.Drawing.Size(79, 28);
            this.button_Crypt.TabIndex = 19;
            this.button_Crypt.Text = "Decrypt";
            this.button_Crypt.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(46, 338);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 17);
            this.label6.TabIndex = 18;
            this.label6.Text = "PlainText";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 17);
            this.label3.TabIndex = 17;
            this.label3.Text = "CipherText";
            // 
            // CipherTextBox
            // 
            this.CipherTextBox.Location = new System.Drawing.Point(140, 86);
            this.CipherTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CipherTextBox.Name = "CipherTextBox";
            this.CipherTextBox.Size = new System.Drawing.Size(425, 96);
            this.CipherTextBox.TabIndex = 16;
            this.CipherTextBox.Text = "";
            // 
            // plainTextBox
            // 
            this.plainTextBox.Location = new System.Drawing.Point(141, 313);
            this.plainTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.plainTextBox.Name = "plainTextBox";
            this.plainTextBox.Size = new System.Drawing.Size(425, 96);
            this.plainTextBox.TabIndex = 15;
            this.plainTextBox.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(440, 257);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "q:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(143, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "n:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(143, 257);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "p:";
            // 
            // NhapP
            // 
            this.NhapP.Location = new System.Drawing.Point(170, 254);
            this.NhapP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NhapP.Name = "NhapP";
            this.NhapP.Size = new System.Drawing.Size(100, 22);
            this.NhapP.TabIndex = 10;
            // 
            // NhapE
            // 
            this.NhapE.Location = new System.Drawing.Point(466, 198);
            this.NhapE.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NhapE.Name = "NhapE";
            this.NhapE.Size = new System.Drawing.Size(100, 22);
            this.NhapE.TabIndex = 11;
            // 
            // NhapN
            // 
            this.NhapN.Location = new System.Drawing.Point(170, 198);
            this.NhapN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NhapN.Name = "NhapN";
            this.NhapN.Size = new System.Drawing.Size(100, 22);
            this.NhapN.TabIndex = 9;
            // 
            // Decrypt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.NhapQ);
            this.Controls.Add(this.alert_M);
            this.Controls.Add(this.alert_e);
            this.Controls.Add(this.alert_n);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button_Crypt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CipherTextBox);
            this.Controls.Add(this.plainTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NhapP);
            this.Controls.Add(this.NhapE);
            this.Controls.Add(this.NhapN);
            this.Name = "Decrypt";
            this.Text = "Decrypt";
            this.Load += new System.EventHandler(this.Decrypt_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox NhapQ;
        private System.Windows.Forms.Label alert_M;
        private System.Windows.Forms.Label alert_e;
        private System.Windows.Forms.Label alert_n;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button_Crypt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox CipherTextBox;
        private System.Windows.Forms.RichTextBox plainTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NhapP;
        private System.Windows.Forms.TextBox NhapE;
        private System.Windows.Forms.TextBox NhapN;
    }
}