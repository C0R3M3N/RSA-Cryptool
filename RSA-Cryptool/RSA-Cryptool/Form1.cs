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
    public partial class Form1 : Form
    {
        string M;
        List<char> C;
        int p, q, X;
        double n, sn, d;

        private void button_Crypt_Click(object sender, EventArgs e)
        {
            if (plainTextBox.Text != "") label10.Visible = false; else label10.Visible = true;
            if (textBox1 != null) label8.Visible = false; else label8.Visible = true;
            if (textBox2 != null) label9.Visible = false; else label9.Visible = true;
            
            if (label8 != null && label9 != null && label10 != null) 
            {
                EXtract_form_TxtBox();
                n = Tinh_n(); 
            }
        }

        public Form1()
        {
            InitializeComponent();
            textBox3.ReadOnly = true;
            textBox4.ReadOnly = true;
        }
        
        public List<char> toASCII(string aString) //pending...Txt to ASCII
        {
            C[0] = 'q';  
            return C;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e) //number only
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)){
                e.Handled = true;   
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e) //number only
        {
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        public void EXtract_form_TxtBox()  //take information from textBox
        {
            M = plainTextBox.Text.Trim();
            p = Int32.Parse(textBox1.Text);
            q = Int32.Parse(textBox2.Text);
        }
        public double Tinh_n() //cal n
        {
            double c = (double)p*q;
            textBox3.Text = c.ToString();
            return n;
        }
        public double Tinh_sn()  //cal sn
        {
            double d = (double)(p - 1) * (q - 1);
            return sn;
        }
        public int Tim_X() //find X
        {

            return X;
        }
        
        
    }
}
