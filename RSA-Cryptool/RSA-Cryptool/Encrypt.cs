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
    public partial class Encrypt : Form
    {
        string M;
        List<int> C;
        int p, q, X;
        double n, e, sn, d;

        private void button_Crypt_Click(object sender, EventArgs e)
        {
            bool flag = Check_Value();
            if (flag==false)
            {
                MessageBox.Show("Your inputs are not suitable!");
            }
            else
            {

            }
        }

        public Encrypt()
        {
            InitializeComponent();            
        }
        
        private bool Check_Value()
        {
            bool flag = true;
            if (NhapE.Text != "") 
                alert_e.Visible = false; 
            else 
            { 
                alert_e.Visible = true; 
                flag = false; 
            }
            if (NhapP.Text == "" || NhapQ.Text == "")
            {
                if (plainTextBox.Text != "" ) 
                    alert_M.Visible = false; 
                else 
                { 
                    alert_M.Visible = true; 
                    flag = false; 
                }
                if (NhapN.Text != "") 
                    alert_n.Visible = false; 
                else 
                { 
                    alert_n.Visible = true; 
                    flag = false; 
                }

                if (NhapN.Text != "" && NhapE.Text != "" && plainTextBox.Text != "")
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
        private List<int> Convert_toASCII(string s) //pending...Txt to ASCII
        {
            byte[] bytes = Encoding.ASCII.GetBytes(s); ;
            List<int> temp = new List<int>(s.Length);
            for (int i=0; i<s.Length;i++)
            {
                temp[i] = BitConverter.ToInt32(bytes, i);
            }
            return temp;
        }

        private void Do_Encrypt()
        {

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
            n = Double.Parse(NhapN.Text);
            e = Double.Parse(NhapE.Text);
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
        private 
        
    }
}
