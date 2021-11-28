﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace RSA_Cryptool
{
    public partial class Encrypt : Form
    {
        string plaintext;
        List<double> C, M;
        int P, Q, X;
        double N =-1, E=-1, Sn=-1, D=-1;

        private  Random _random = new Random();

        public Encrypt()
        {
            InitializeComponent();            
        }

        #region Check_and_Execute
        private void button_Crypt_Click(object sender, EventArgs e)
        {
            /*bool Check_Value_flag = Check_Value();
            bool Check_Prime_P_flag = Check_Prime(P);
            bool Check_Prime_Q_flag = Check_Prime(Q);
            if (Check_Value_flag == false ||
                Check_Prime_P_flag == false ||
                Check_Prime_Q_flag == false)
            {
                MessageBox.Show("Your inputs are not suitable!");
            }
            else
            {
                
            }*/
            Check_Value();

            Do_Encrypt();
            MessageBox.Show(Tinh_D().ToString());
        }

        private bool Check_Prime(int n)
        {
            if (n < 2) //n nho hon 2 -> khong la so nguyen to
            {
                return false;
            }
            int count = 0;
            for (int i = 2; i <= Math.Sqrt(n); i++)//kieem tra tu khoang 2->can 2 cua n
            {
                if (n % i == 0)
                {
                    count++;
                }
            }
            if (count == 0) 
            {
                return true;//khong co so chia het -> so nguyen to
            }
            else
            {
                return false;   
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
            byte[] bytes = Encoding.ASCII.GetBytes(s);
            int numChar = bytes.Length;
            List<double> temp = new List<double>();
            for (int i=0; i<s.Length;i++)
            {
                temp.Add(Convert.ToInt32(((double)bytes[i]))); 
            }
            return temp;
            /*byte[] bytes = Encoding.ASCII.GetBytes(plaintext);
            int numChar = bytes.Length;
            double h=0;
            double[] k =  new double[numChar];
            string g=null;
            for (int i = 0; i < numChar; i++)
            {
                h = Convert.ToInt32(((double)bytes[i]));
                k[i] = h;
                g = g +" "+ Convert.ToInt32(((double)bytes[i]));
            }*/
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
            plaintext = plainTextBox.Text;

            M = Convert_toASCII(plaintext);
            string g = null;
            for (int i = 0; i < M.Count(); i++)
            {
                double h = M[i];
                double f = Math.Pow(h, E) % N;
                
                g = g + " " + f.ToString();
            }
            CipherTextBox.Text = g.ToString();
            //string hexString = BitConverter.ToString(bytes);
            //hexString = hexString.Replace("-", " ");
            //CipherTextBox.Text = hexString;
            //string[] a = hexString.Split('-');


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
            P = int.Parse(NhapP.Text);
            Q = int.Parse(NhapQ.Text);
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
        public double Generrate_E()
        {

            List<double> e = null;
            for(ulong i = 0; i < Sn; i++)
            {
               if( GCD((ulong)Sn, i) == 1 && Check_STN(GCD((ulong)Sn, i)) == true) { 
                    e.Add(GCD((ulong)Sn, i));
                }
            }
            int j = _random.Next(e.Count());
            return e[j];
            
        }
        private static ulong GCD(ulong a, ulong b)
        {
            while (a != 0 && b != 0)
            {
                if (a > b)
                    a %= b;
                else
                    b %= a;
            }

            return a | b;
        }
        // Generates a random number within a range.      
        public double RandomNumber(int min, int max)
        {
            return _random.Next(min, max);
        }
        public double Tinh_D()
        {
            for(int k=1; k <= int.MaxValue; k++)
            {
                D = (1 + k * Sn) / E;
                if(Check_STN(D) == true) break;
            }
            return D;
        }
        bool Check_STN(double s)
        {
            if (s == (int)Math.Abs(s))
                return true;
            return false;
        }
        #endregion
    }
}
