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
        double n, e, sn, d;

        private void button_Crypt_Click(object sender, EventArgs e)
        {
            bool flag = Check_Value();
            if (flag==false)
            {
                MessageBox.Show("Your inputs are not suitable!");
                return;
            }
            else
            {

            }
           
        }

        public Form1()
        {
            InitializeComponent();
           
          
        }
        
        private bool Check_Value()
        {
            bool flag = true;
            if (NhapE != null) alert_e.Visible = false; else { alert_e.Visible = true; flag = false; }
            if (NhapP == null || NhapQ == null)
            {
                if (plainTextBox.Text != "") alert_M.Visible = false; else { alert_M.Visible = true; flag = false; }
                if (NhapN != null) alert_n.Visible = false; else { alert_n.Visible = true; flag = false; }

                if (alert_n != null && alert_e != null && alert_M != null)
                {
                    EXtract_form_TxtBox();
                }
            }
            else
            {
                Tinh_n();
            }
            return flag;
        }
        public List<char> toASCII(string aString) //pending...Txt to ASCII
        {
            C[0] = 'q';  
            return C;
        }

        private void NhapN_KeyPress(object sender, KeyPressEventArgs e) //number only
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)){
                e.Handled = true;   
            }
        }

        private void NhapE_KeyPress(object sender, KeyPressEventArgs e) //number only
        {
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        public void EXtract_form_TxtBox()  //take information from textBox
        {
            M = plainTextBox.Text.Trim();
            n = Int32.Parse(NhapN.Text);
            e = Int32.Parse(NhapE.Text);
        }
        public double Tinh_n() //cal n
        {
            n = (double)p*q;
            NhapN.Text = n.ToString();
            return n;
        }
        public double Tinh_sn()  //cal sn
        {
            sn = (double)(p - 1) * (q - 1);
            return sn;
        }
        public int Tim_X() //find X
        {

            return X;
        }
        
        
    }
}
