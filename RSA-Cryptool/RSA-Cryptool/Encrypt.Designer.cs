
namespace RSA_Cryptool
{
    partial class Encrypt
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
            this.NhapN = new System.Windows.Forms.TextBox();
            this.NhapE = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.plainTextBox = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.NhapP = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.CipherTextBox = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button_Crypt = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.alert_P = new System.Windows.Forms.Label();
            this.alert_Q = new System.Windows.Forms.Label();
            this.alert_M = new System.Windows.Forms.Label();
            this.NhapQ = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.D_text = new System.Windows.Forms.TextBox();
            this.Sn_Text = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.radio_Random = new System.Windows.Forms.RadioButton();
            this.radio_HandInput = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.Export_butt = new System.Windows.Forms.Button();
            this.alert_E = new System.Windows.Forms.Label();
            this.Pivate_key_lable = new System.Windows.Forms.Label();
            this.Public_key_lable = new System.Windows.Forms.Label();
            this.privateKey_textBox = new System.Windows.Forms.TextBox();
            this.PublicKey_textBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // NhapN
            // 
            this.NhapN.Location = new System.Drawing.Point(171, 251);
            this.NhapN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NhapN.Name = "NhapN";
            this.NhapN.Size = new System.Drawing.Size(100, 22);
            this.NhapN.TabIndex = 0;
            this.NhapN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NhapN_KeyPress);
            // 
            // NhapE
            // 
            this.NhapE.Location = new System.Drawing.Point(467, 252);
            this.NhapE.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NhapE.Name = "NhapE";
            this.NhapE.Size = new System.Drawing.Size(100, 22);
            this.NhapE.TabIndex = 0;
            this.NhapE.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NhapE_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(144, 201);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "p:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(441, 201);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "q:";
            // 
            // plainTextBox
            // 
            this.plainTextBox.Location = new System.Drawing.Point(140, 86);
            this.plainTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.plainTextBox.Name = "plainTextBox";
            this.plainTextBox.Size = new System.Drawing.Size(425, 96);
            this.plainTextBox.TabIndex = 2;
            this.plainTextBox.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "plainText";
            // 
            // NhapP
            // 
            this.NhapP.Location = new System.Drawing.Point(171, 198);
            this.NhapP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NhapP.Name = "NhapP";
            this.NhapP.Size = new System.Drawing.Size(100, 22);
            this.NhapP.TabIndex = 0;
            this.NhapP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NhapP_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(144, 255);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "n:";
            // 
            // CipherTextBox
            // 
            this.CipherTextBox.Location = new System.Drawing.Point(140, 354);
            this.CipherTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CipherTextBox.Name = "CipherTextBox";
            this.CipherTextBox.Size = new System.Drawing.Size(425, 96);
            this.CipherTextBox.TabIndex = 2;
            this.CipherTextBox.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(47, 383);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 17);
            this.label6.TabIndex = 3;
            this.label6.Text = "CipherText";
            // 
            // button_Crypt
            // 
            this.button_Crypt.Location = new System.Drawing.Point(621, 351);
            this.button_Crypt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_Crypt.Name = "button_Crypt";
            this.button_Crypt.Size = new System.Drawing.Size(140, 59);
            this.button_Crypt.TabIndex = 4;
            this.button_Crypt.Text = "Encrypt";
            this.button_Crypt.UseVisualStyleBackColor = true;
            this.button_Crypt.Click += new System.EventHandler(this.button_Crypt_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(63, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 17);
            this.label7.TabIndex = 5;
            this.label7.Text = "Encrypt";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // alert_P
            // 
            this.alert_P.AutoSize = true;
            this.alert_P.ForeColor = System.Drawing.Color.Red;
            this.alert_P.Location = new System.Drawing.Point(276, 201);
            this.alert_P.Name = "alert_P";
            this.alert_P.Size = new System.Drawing.Size(157, 17);
            this.alert_P.TabIndex = 6;
            this.alert_P.Text = "This fill cannot be blank";
            this.alert_P.Visible = false;
            // 
            // alert_Q
            // 
            this.alert_Q.AutoSize = true;
            this.alert_Q.ForeColor = System.Drawing.Color.Red;
            this.alert_Q.Location = new System.Drawing.Point(572, 201);
            this.alert_Q.Name = "alert_Q";
            this.alert_Q.Size = new System.Drawing.Size(157, 17);
            this.alert_Q.TabIndex = 6;
            this.alert_Q.Text = "This fill cannot be blank";
            this.alert_Q.Visible = false;
            // 
            // alert_M
            // 
            this.alert_M.AutoSize = true;
            this.alert_M.ForeColor = System.Drawing.Color.Red;
            this.alert_M.Location = new System.Drawing.Point(572, 114);
            this.alert_M.Name = "alert_M";
            this.alert_M.Size = new System.Drawing.Size(157, 17);
            this.alert_M.TabIndex = 6;
            this.alert_M.Text = "This fill cannot be blank";
            this.alert_M.Visible = false;
            // 
            // NhapQ
            // 
            this.NhapQ.Location = new System.Drawing.Point(467, 198);
            this.NhapQ.Margin = new System.Windows.Forms.Padding(4);
            this.NhapQ.Name = "NhapQ";
            this.NhapQ.Size = new System.Drawing.Size(100, 22);
            this.NhapQ.TabIndex = 7;
            this.NhapQ.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NhapQ_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(441, 255);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(20, 17);
            this.label11.TabIndex = 8;
            this.label11.Text = "e:";
            // 
            // D_text
            // 
            this.D_text.Location = new System.Drawing.Point(811, 297);
            this.D_text.Name = "D_text";
            this.D_text.Size = new System.Drawing.Size(100, 22);
            this.D_text.TabIndex = 9;
            // 
            // Sn_Text
            // 
            this.Sn_Text.Location = new System.Drawing.Point(811, 252);
            this.Sn_Text.Name = "Sn_Text";
            this.Sn_Text.Size = new System.Drawing.Size(100, 22);
            this.Sn_Text.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(768, 255);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "Sn:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(768, 303);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(20, 17);
            this.label8.TabIndex = 1;
            this.label8.Text = "d:";
            // 
            // radio_Random
            // 
            this.radio_Random.AutoSize = true;
            this.radio_Random.Location = new System.Drawing.Point(602, 174);
            this.radio_Random.Name = "radio_Random";
            this.radio_Random.Size = new System.Drawing.Size(82, 21);
            this.radio_Random.TabIndex = 35;
            this.radio_Random.TabStop = true;
            this.radio_Random.Text = "Random";
            this.radio_Random.UseVisualStyleBackColor = true;
            this.radio_Random.CheckedChanged += new System.EventHandler(this.radio_Random_CheckedChanged);
            // 
            // radio_HandInput
            // 
            this.radio_HandInput.AutoSize = true;
            this.radio_HandInput.Location = new System.Drawing.Point(602, 147);
            this.radio_HandInput.Name = "radio_HandInput";
            this.radio_HandInput.Size = new System.Drawing.Size(98, 21);
            this.radio_HandInput.TabIndex = 36;
            this.radio_HandInput.TabStop = true;
            this.radio_HandInput.Text = "Hand Input";
            this.radio_HandInput.UseVisualStyleBackColor = true;
            this.radio_HandInput.CheckedChanged += new System.EventHandler(this.radio_HandInput_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(575, 86);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(30, 23);
            this.button1.TabIndex = 37;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Export_butt
            // 
            this.Export_butt.Location = new System.Drawing.Point(575, 427);
            this.Export_butt.Name = "Export_butt";
            this.Export_butt.Size = new System.Drawing.Size(72, 23);
            this.Export_butt.TabIndex = 37;
            this.Export_butt.Text = "export";
            this.Export_butt.UseVisualStyleBackColor = true;
            this.Export_butt.Click += new System.EventHandler(this.Export_butt_Click);
            // 
            // alert_E
            // 
            this.alert_E.AutoSize = true;
            this.alert_E.ForeColor = System.Drawing.Color.Red;
            this.alert_E.Location = new System.Drawing.Point(573, 254);
            this.alert_E.Name = "alert_E";
            this.alert_E.Size = new System.Drawing.Size(157, 17);
            this.alert_E.TabIndex = 6;
            this.alert_E.Text = "This fill cannot be blank";
            this.alert_E.Visible = false;
            // 
            // Pivate_key_lable
            // 
            this.Pivate_key_lable.AutoSize = true;
            this.Pivate_key_lable.Location = new System.Drawing.Point(84, 300);
            this.Pivate_key_lable.Name = "Pivate_key_lable";
            this.Pivate_key_lable.Size = new System.Drawing.Size(80, 17);
            this.Pivate_key_lable.TabIndex = 38;
            this.Pivate_key_lable.Text = "Private Key";
            // 
            // Public_key_lable
            // 
            this.Public_key_lable.AutoSize = true;
            this.Public_key_lable.Location = new System.Drawing.Point(387, 302);
            this.Public_key_lable.Name = "Public_key_lable";
            this.Public_key_lable.Size = new System.Drawing.Size(74, 17);
            this.Public_key_lable.TabIndex = 38;
            this.Public_key_lable.Text = "Public Key";
            // 
            // privateKey_textBox
            // 
            this.privateKey_textBox.Location = new System.Drawing.Point(171, 295);
            this.privateKey_textBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.privateKey_textBox.Name = "privateKey_textBox";
            this.privateKey_textBox.Size = new System.Drawing.Size(158, 22);
            this.privateKey_textBox.TabIndex = 0;
            this.privateKey_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NhapN_KeyPress);
            // 
            // PublicKey_textBox
            // 
            this.PublicKey_textBox.Location = new System.Drawing.Point(467, 297);
            this.PublicKey_textBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PublicKey_textBox.Name = "PublicKey_textBox";
            this.PublicKey_textBox.Size = new System.Drawing.Size(160, 22);
            this.PublicKey_textBox.TabIndex = 0;
            this.PublicKey_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NhapN_KeyPress);
            // 
            // Encrypt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 488);
            this.Controls.Add(this.Public_key_lable);
            this.Controls.Add(this.Pivate_key_lable);
            this.Controls.Add(this.Export_butt);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.radio_Random);
            this.Controls.Add(this.radio_HandInput);
            this.Controls.Add(this.Sn_Text);
            this.Controls.Add(this.D_text);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.NhapQ);
            this.Controls.Add(this.alert_M);
            this.Controls.Add(this.alert_E);
            this.Controls.Add(this.alert_Q);
            this.Controls.Add(this.alert_P);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button_Crypt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CipherTextBox);
            this.Controls.Add(this.plainTextBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NhapP);
            this.Controls.Add(this.NhapE);
            this.Controls.Add(this.PublicKey_textBox);
            this.Controls.Add(this.privateKey_textBox);
            this.Controls.Add(this.NhapN);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Encrypt";
            this.Text = "0";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NhapN;
        private System.Windows.Forms.TextBox NhapE;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox plainTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox NhapP;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox CipherTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button_Crypt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label alert_P;
        private System.Windows.Forms.Label alert_Q;
        private System.Windows.Forms.Label alert_M;
        private System.Windows.Forms.TextBox NhapQ;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox D_text;
        private System.Windows.Forms.TextBox Sn_Text;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RadioButton radio_Random;
        private System.Windows.Forms.RadioButton radio_HandInput;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Export_butt;
        private System.Windows.Forms.Label alert_E;
        private System.Windows.Forms.Label Pivate_key_lable;
        private System.Windows.Forms.Label Public_key_lable;
        private System.Windows.Forms.TextBox privateKey_textBox;
        private System.Windows.Forms.TextBox PublicKey_textBox;
    }
}

