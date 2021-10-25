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
        string plaintext;
        List<double> C, M;
        int P, Q, X;
        double N, E, Sn, D;

        public Encrypt()
        {
            InitializeComponent();            
        }

        #region Check_and_Execute
        private void button_Crypt_Click(object sender, EventArgs e)
        {
            bool flag = Check_Value();
            if (flag == false)
            {
                MessageBox.Show("Your inputs are not suitable!");
            }
            else
            {
                Do_Encrypt();
            }
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
                EXtract_form_TxtBox();
            }
            return flag;
        }
        #endregion

        #region Convert_and_Encrypt
        private List<double> Convert_toASCII(string s) //pending...Txt to ASCII
        {
            byte[] bytes = Encoding.ASCII.GetBytes(s); ;
            List<double> temp = new List<double>(s.Length);
            for (int i=0; i<s.Length;i++)
            {
                temp[i] = BitConverter.ToDouble(bytes,0);
            }
            return temp;
        }
        private string Convert_toString(List<double> list)
        {
            string temp="";
            byte[] bytes= new byte[list.Count()];
            for (int i=0;i<list.Count();i++)
            {
                bytes = BitConverter.GetBytes(list[i]);
                temp = Encoding.ASCII.GetString(bytes);
            }
            return temp;
        }
        private void Do_Encrypt()
        {
            M = Convert_toASCII(plaintext);
            for (int i = 0; i < M.Count(); i++)
            {
                C[i] = Math.Pow(M[i], E) % N;
            }
            CipherTextBox.Text = Convert_toString(C);
        }
        #endregion

        #region Others
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
            plaintext = plainTextBox.Text.Trim();
            N = Double.Parse(NhapN.Text);
            E = Double.Parse(NhapE.Text);
        }
        public double Tinh_n() //cal n
        {
            N = (double)P*Q;
            NhapN.Text = N.ToString();
            return N;
        }
        public double Tinh_Sn()  //cal sn
        {
            Sn = (double)(P - 1) * (Q - 1);
            return Sn;
        }
        #endregion
    }
}
