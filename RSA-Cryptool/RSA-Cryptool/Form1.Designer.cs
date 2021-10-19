
namespace RSA_Cryptool
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
            this.NhapN = new System.Windows.Forms.TextBox();
            this.NhapE = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.plainTextBox = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.NhapP = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.CypherTextBox = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button_Crypt = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.alert_n = new System.Windows.Forms.Label();
            this.alert_e = new System.Windows.Forms.Label();
            this.alert_M = new System.Windows.Forms.Label();
            this.NhapQ = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // NhapN
            // 
            this.NhapN.Location = new System.Drawing.Point(128, 161);
            this.NhapN.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.NhapN.Name = "NhapN";
            this.NhapN.Size = new System.Drawing.Size(76, 20);
            this.NhapN.TabIndex = 0;
            this.NhapN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NhapN_KeyPress);
            // 
            // NhapE
            // 
            this.NhapE.Location = new System.Drawing.Point(350, 161);
            this.NhapE.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.NhapE.Name = "NhapE";
            this.NhapE.Size = new System.Drawing.Size(76, 20);
            this.NhapE.TabIndex = 0;
            this.NhapE.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NhapE_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(108, 209);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "p:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(331, 209);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "q:";
            // 
            // plainTextBox
            // 
            this.plainTextBox.Location = new System.Drawing.Point(105, 70);
            this.plainTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.plainTextBox.Name = "plainTextBox";
            this.plainTextBox.Size = new System.Drawing.Size(320, 79);
            this.plainTextBox.TabIndex = 2;
            this.plainTextBox.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 93);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "plainText";
            // 
            // NhapP
            // 
            this.NhapP.Location = new System.Drawing.Point(128, 206);
            this.NhapP.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.NhapP.Name = "NhapP";
            this.NhapP.Size = new System.Drawing.Size(76, 20);
            this.NhapP.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(108, 164);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "n:";
            // 
            // CypherTextBox
            // 
            this.CypherTextBox.Location = new System.Drawing.Point(105, 251);
            this.CypherTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CypherTextBox.Name = "CypherTextBox";
            this.CypherTextBox.Size = new System.Drawing.Size(320, 79);
            this.CypherTextBox.TabIndex = 2;
            this.CypherTextBox.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(35, 275);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "CypherText";
            // 
            // button_Crypt
            // 
            this.button_Crypt.Location = new System.Drawing.Point(466, 285);
            this.button_Crypt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_Crypt.Name = "button_Crypt";
            this.button_Crypt.Size = new System.Drawing.Size(59, 23);
            this.button_Crypt.TabIndex = 4;
            this.button_Crypt.Text = "Crypt";
            this.button_Crypt.UseVisualStyleBackColor = true;
            this.button_Crypt.Click += new System.EventHandler(this.button_Crypt_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(47, 20);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Encrypt";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // alert_n
            // 
            this.alert_n.AutoSize = true;
            this.alert_n.ForeColor = System.Drawing.Color.Red;
            this.alert_n.Location = new System.Drawing.Point(207, 163);
            this.alert_n.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.alert_n.Name = "alert_n";
            this.alert_n.Size = new System.Drawing.Size(119, 13);
            this.alert_n.TabIndex = 6;
            this.alert_n.Text = "This fill cannot be blank";
            this.alert_n.Visible = false;
            // 
            // alert_e
            // 
            this.alert_e.AutoSize = true;
            this.alert_e.ForeColor = System.Drawing.Color.Red;
            this.alert_e.Location = new System.Drawing.Point(429, 163);
            this.alert_e.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.alert_e.Name = "alert_e";
            this.alert_e.Size = new System.Drawing.Size(119, 13);
            this.alert_e.TabIndex = 6;
            this.alert_e.Text = "This fill cannot be blank";
            this.alert_e.Visible = false;
            // 
            // alert_M
            // 
            this.alert_M.AutoSize = true;
            this.alert_M.ForeColor = System.Drawing.Color.Red;
            this.alert_M.Location = new System.Drawing.Point(429, 93);
            this.alert_M.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.alert_M.Name = "alert_M";
            this.alert_M.Size = new System.Drawing.Size(119, 13);
            this.alert_M.TabIndex = 6;
            this.alert_M.Text = "This fill cannot be blank";
            this.alert_M.Visible = false;
            // 
            // NhapQ
            // 
            this.NhapQ.Location = new System.Drawing.Point(350, 206);
            this.NhapQ.Name = "NhapQ";
            this.NhapQ.Size = new System.Drawing.Size(76, 20);
            this.NhapQ.TabIndex = 7;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(331, 163);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(16, 13);
            this.label11.TabIndex = 8;
            this.label11.Text = "e:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.NhapQ);
            this.Controls.Add(this.alert_M);
            this.Controls.Add(this.alert_e);
            this.Controls.Add(this.alert_n);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button_Crypt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CypherTextBox);
            this.Controls.Add(this.plainTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NhapP);
            this.Controls.Add(this.NhapE);
            this.Controls.Add(this.NhapN);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Encryption";
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
        private System.Windows.Forms.RichTextBox CypherTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button_Crypt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label alert_n;
        private System.Windows.Forms.Label alert_e;
        private System.Windows.Forms.Label alert_M;
        private System.Windows.Forms.TextBox NhapQ;
        private System.Windows.Forms.Label label11;
    }
}

