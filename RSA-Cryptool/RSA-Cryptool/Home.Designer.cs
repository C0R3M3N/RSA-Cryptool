
namespace RSA_Cryptool
{
    partial class Home
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
            this.Decrypt_button = new System.Windows.Forms.Button();
            this.EnCrypt_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Decrypt_button
            // 
            this.Decrypt_button.Location = new System.Drawing.Point(430, 176);
            this.Decrypt_button.Name = "Decrypt_button";
            this.Decrypt_button.Size = new System.Drawing.Size(75, 23);
            this.Decrypt_button.TabIndex = 0;
            this.Decrypt_button.Text = "Decryt";
            this.Decrypt_button.UseVisualStyleBackColor = true;
            this.Decrypt_button.Click += new System.EventHandler(this.Decrypt_button_Click);
            // 
            // EnCrypt_Button
            // 
            this.EnCrypt_Button.Location = new System.Drawing.Point(207, 176);
            this.EnCrypt_Button.Name = "EnCrypt_Button";
            this.EnCrypt_Button.Size = new System.Drawing.Size(75, 23);
            this.EnCrypt_Button.TabIndex = 0;
            this.EnCrypt_Button.Text = "Encryt";
            this.EnCrypt_Button.UseVisualStyleBackColor = true;
            this.EnCrypt_Button.Click += new System.EventHandler(this.EnCrypt_Button_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.EnCrypt_Button);
            this.Controls.Add(this.Decrypt_button);
            this.Name = "Home";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Decrypt_button;
        private System.Windows.Forms.Button EnCrypt_Button;
    }
}