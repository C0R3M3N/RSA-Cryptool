using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RSA_Cryptool
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void EnCrypt_Button_Click(object sender, EventArgs e)
        {
            Encrypt encrypt = new Encrypt();
            encrypt.Show();
        }

        private void Decrypt_button_Click(object sender, EventArgs e)
        {
            Decrypt decrypt = new Decrypt();
            decrypt.Show();
        }
    }
}
