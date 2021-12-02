
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
            this.generateE = new System.Windows.Forms.Button();
            this.Sn_Text = new System.Windows.Forms.TextBox();
            this.D_text = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.NhapQ = new System.Windows.Forms.TextBox();
            this.alert_M = new System.Windows.Forms.Label();
            this.alert_Q = new System.Windows.Forms.Label();
            this.alert_P = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button_Crypt = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CipherTextBox = new System.Windows.Forms.RichTextBox();
            this.plainTextBox = new System.Windows.Forms.RichTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.NhapP = new System.Windows.Forms.TextBox();
            this.NhapE = new System.Windows.Forms.TextBox();
            this.NhapN = new System.Windows.Forms.TextBox();
            this.radio_HandInput = new System.Windows.Forms.RadioButton();
            this.radio_Random = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // generateE
            // 
            this.generateE.Location = new System.Drawing.Point(474, 267);
            this.generateE.Name = "generateE";
            this.generateE.Size = new System.Drawing.Size(87, 23);
            this.generateE.TabIndex = 33;
            this.generateE.Text = "generate e";
            this.generateE.UseVisualStyleBackColor = true;
            this.generateE.Click += new System.EventHandler(this.generateE_Click);
            // 
            // Sn_Text
            // 
            this.Sn_Text.Location = new System.Drawing.Point(657, 239);
            this.Sn_Text.Name = "Sn_Text";
            this.Sn_Text.Size = new System.Drawing.Size(100, 22);
            this.Sn_Text.TabIndex = 32;
            // 
            // D_text
            // 
            this.D_text.Location = new System.Drawing.Point(657, 284);
            this.D_text.Name = "D_text";
            this.D_text.Size = new System.Drawing.Size(100, 22);
            this.D_text.TabIndex = 31;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(437, 243);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(20, 17);
            this.label11.TabIndex = 30;
            this.label11.Text = "e:";
            // 
            // NhapQ
            // 
            this.NhapQ.Location = new System.Drawing.Point(463, 186);
            this.NhapQ.Margin = new System.Windows.Forms.Padding(4);
            this.NhapQ.Name = "NhapQ";
            this.NhapQ.Size = new System.Drawing.Size(100, 22);
            this.NhapQ.TabIndex = 29;
            // 
            // alert_M
            // 
            this.alert_M.AutoSize = true;
            this.alert_M.ForeColor = System.Drawing.Color.Red;
            this.alert_M.Location = new System.Drawing.Point(568, 102);
            this.alert_M.Name = "alert_M";
            this.alert_M.Size = new System.Drawing.Size(157, 17);
            this.alert_M.TabIndex = 28;
            this.alert_M.Text = "This fill cannot be blank";
            this.alert_M.Visible = false;
            // 
            // alert_Q
            // 
            this.alert_Q.AutoSize = true;
            this.alert_Q.ForeColor = System.Drawing.Color.Red;
            this.alert_Q.Location = new System.Drawing.Point(568, 189);
            this.alert_Q.Name = "alert_Q";
            this.alert_Q.Size = new System.Drawing.Size(157, 17);
            this.alert_Q.TabIndex = 27;
            this.alert_Q.Text = "This fill cannot be blank";
            this.alert_Q.Visible = false;
            // 
            // alert_P
            // 
            this.alert_P.AutoSize = true;
            this.alert_P.ForeColor = System.Drawing.Color.Red;
            this.alert_P.Location = new System.Drawing.Point(272, 189);
            this.alert_P.Name = "alert_P";
            this.alert_P.Size = new System.Drawing.Size(157, 17);
            this.alert_P.TabIndex = 26;
            this.alert_P.Text = "This fill cannot be blank";
            this.alert_P.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(59, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 17);
            this.label7.TabIndex = 25;
            this.label7.Text = "Decrypt";
            // 
            // button_Crypt
            // 
            this.button_Crypt.Location = new System.Drawing.Point(622, 373);
            this.button_Crypt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_Crypt.Name = "button_Crypt";
            this.button_Crypt.Size = new System.Drawing.Size(79, 28);
            this.button_Crypt.TabIndex = 24;
            this.button_Crypt.Text = "Decrypt";
            this.button_Crypt.UseVisualStyleBackColor = true;
            this.button_Crypt.Click += new System.EventHandler(this.button_Crypt_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(45, 92);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 17);
            this.label6.TabIndex = 23;
            this.label6.Text = "CipherText";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 388);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 17);
            this.label3.TabIndex = 22;
            this.label3.Text = "plainText";
            // 
            // CipherTextBox
            // 
            this.CipherTextBox.Location = new System.Drawing.Point(138, 63);
            this.CipherTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CipherTextBox.Name = "CipherTextBox";
            this.CipherTextBox.Size = new System.Drawing.Size(425, 96);
            this.CipherTextBox.TabIndex = 21;
            this.CipherTextBox.Text = "";
            // 
            // plainTextBox
            // 
            this.plainTextBox.Location = new System.Drawing.Point(143, 373);
            this.plainTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.plainTextBox.Name = "plainTextBox";
            this.plainTextBox.Size = new System.Drawing.Size(425, 96);
            this.plainTextBox.TabIndex = 20;
            this.plainTextBox.Text = "";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(614, 290);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(20, 17);
            this.label8.TabIndex = 19;
            this.label8.Text = "d:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(614, 242);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 17);
            this.label5.TabIndex = 18;
            this.label5.Text = "Sn:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(437, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 17);
            this.label2.TabIndex = 17;
            this.label2.Text = "q:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(140, 243);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 17);
            this.label4.TabIndex = 16;
            this.label4.Text = "n:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(140, 189);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 17);
            this.label1.TabIndex = 15;
            this.label1.Text = "p:";
            // 
            // NhapP
            // 
            this.NhapP.Location = new System.Drawing.Point(167, 186);
            this.NhapP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NhapP.Name = "NhapP";
            this.NhapP.Size = new System.Drawing.Size(100, 22);
            this.NhapP.TabIndex = 13;
            // 
            // NhapE
            // 
            this.NhapE.Location = new System.Drawing.Point(463, 240);
            this.NhapE.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NhapE.Name = "NhapE";
            this.NhapE.Size = new System.Drawing.Size(100, 22);
            this.NhapE.TabIndex = 14;
            // 
            // NhapN
            // 
            this.NhapN.Location = new System.Drawing.Point(167, 239);
            this.NhapN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NhapN.Name = "NhapN";
            this.NhapN.Size = new System.Drawing.Size(100, 22);
            this.NhapN.TabIndex = 12;
            // 
            // radio_HandInput
            // 
            this.radio_HandInput.AutoSize = true;
            this.radio_HandInput.Location = new System.Drawing.Point(659, 138);
            this.radio_HandInput.Name = "radio_HandInput";
            this.radio_HandInput.Size = new System.Drawing.Size(98, 21);
            this.radio_HandInput.TabIndex = 34;
            this.radio_HandInput.TabStop = true;
            this.radio_HandInput.Text = "Hand Input";
            this.radio_HandInput.UseVisualStyleBackColor = true;
            this.radio_HandInput.CheckedChanged += new System.EventHandler(this.radio_HandInput_CheckedChanged);
            // 
            // radio_Random
            // 
            this.radio_Random.AutoSize = true;
            this.radio_Random.Location = new System.Drawing.Point(659, 165);
            this.radio_Random.Name = "radio_Random";
            this.radio_Random.Size = new System.Drawing.Size(82, 21);
            this.radio_Random.TabIndex = 34;
            this.radio_Random.TabStop = true;
            this.radio_Random.Text = "Random";
            this.radio_Random.UseVisualStyleBackColor = true;
            this.radio_Random.CheckedChanged += new System.EventHandler(this.radio_Random_CheckedChanged);
            // 
            // Decrypt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 515);
            this.Controls.Add(this.radio_Random);
            this.Controls.Add(this.radio_HandInput);
            this.Controls.Add(this.generateE);
            this.Controls.Add(this.Sn_Text);
            this.Controls.Add(this.D_text);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.NhapQ);
            this.Controls.Add(this.alert_M);
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
            this.Controls.Add(this.NhapN);
            this.Name = "Decrypt";
            this.Text = "Decrypt";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button generateE;
        private System.Windows.Forms.TextBox Sn_Text;
        private System.Windows.Forms.TextBox D_text;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox NhapQ;
        private System.Windows.Forms.Label alert_M;
        private System.Windows.Forms.Label alert_Q;
        private System.Windows.Forms.Label alert_P;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button_Crypt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox CipherTextBox;
        private System.Windows.Forms.RichTextBox plainTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NhapP;
        private System.Windows.Forms.TextBox NhapE;
        private System.Windows.Forms.TextBox NhapN;
        private System.Windows.Forms.RadioButton radio_HandInput;
        private System.Windows.Forms.RadioButton radio_Random;
    }
}