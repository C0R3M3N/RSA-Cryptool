using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Numerics;

namespace RSA_Cryptool
{
    public partial class Decrypt : Form
    {
        public static readonly int[] primesBelow2000 = {
        2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47, 53, 59, 61, 67, 71, 73, 79, 83, 89, 97,
        101, 103, 107, 109, 113, 127, 131, 137, 139, 149, 151, 157, 163, 167, 173, 179, 181, 191, 193, 197, 199,
    211, 223, 227, 229, 233, 239, 241, 251, 257, 263, 269, 271, 277, 281, 283, 293,
    307, 311, 313, 317, 331, 337, 347, 349, 353, 359, 367, 373, 379, 383, 389, 397,
    401, 409, 419, 421, 431, 433, 439, 443, 449, 457, 461, 463, 467, 479, 487, 491, 499,
    503, 509, 521, 523, 541, 547, 557, 563, 569, 571, 577, 587, 593, 599,
    601, 607, 613, 617, 619, 631, 641, 643, 647, 653, 659, 661, 673, 677, 683, 691,
    701, 709, 719, 727, 733, 739, 743, 751, 757, 761, 769, 773, 787, 797,
    809, 811, 821, 823, 827, 829, 839, 853, 857, 859, 863, 877, 881, 883, 887,
    907, 911, 919, 929, 937, 941, 947, 953, 967, 971, 977, 983, 991, 997,
    1009, 1013, 1019, 1021, 1031, 1033, 1039, 1049, 1051, 1061, 1063, 1069, 1087, 1091, 1093, 1097,
    1103, 1109, 1117, 1123, 1129, 1151, 1153, 1163, 1171, 1181, 1187, 1193,
    1201, 1213, 1217, 1223, 1229, 1231, 1237, 1249, 1259, 1277, 1279, 1283, 1289, 1291, 1297,
    1301, 1303, 1307, 1319, 1321, 1327, 1361, 1367, 1373, 1381, 1399,
    1409, 1423, 1427, 1429, 1433, 1439, 1447, 1451, 1453, 1459, 1471, 1481, 1483, 1487, 1489, 1493, 1499,
    1511, 1523, 1531, 1543, 1549, 1553, 1559, 1567, 1571, 1579, 1583, 1597,
    1601, 1607, 1609, 1613, 1619, 1621, 1627, 1637, 1657, 1663, 1667, 1669, 1693, 1697, 1699,
    1709, 1721, 1723, 1733, 1741, 1747, 1753, 1759, 1777, 1783, 1787, 1789,
    1801, 1811, 1823, 1831, 1847, 1861, 1867, 1871, 1873, 1877, 1879, 1889,
    1901, 1907, 1913, 1931, 1933, 1949, 1951, 1973, 1979, 1987, 1993, 1997, 1999 };

        string plaintext, ciphertext;
        List<BigInteger> C, M;
        //int P, Q, X;
        //double N = -1, E = -1, Sn = -1, D = -1;
        public BigInteger D = new BigInteger();
        public BigInteger N = new BigInteger();
        public BigInteger E = new BigInteger();
        public BigInteger Sn = new BigInteger();
        public BigInteger P = new BigInteger();
        public BigInteger Q = new BigInteger();
        
        private Random _random = new Random();
        public Decrypt()
        {
            InitializeComponent();

            Sn_Text.ReadOnly = true;
            D_text.ReadOnly = true;
            generateE.Visible = false;
            
        }
        #region Check_and_Execute
        private void button_Crypt_Click(object sender, EventArgs e)
        {
            plainTextBox.Clear();
            bool Check_Value_flag = Check_Value();
            if (Check_Value_flag)
            {
                EXtract_form_TxtBox();
                bool Check_Prime_P_flag = Check_Prime(P);
                bool Check_Prime_Q_flag = Check_Prime(Q);
                if (!Check_Prime_P_flag || !Check_Prime_Q_flag)
                {
                    MessageBox.Show("Your inputs P or Q are not Prime!");
                }
                else
                {
                    //Check_Value();
                    Tinh_n();
                    Tinh_Sn();
                    //if (NhapE.Text == "") Tinh_E();
                    Tinh_D();
                    Do_Decrypt();
                }
            }
        }
        
        /*public static bool Check_Prime(BigInteger number)
        {

            BigInteger d;
            var n = number - 1;
            var s = BigInteger.(n, out d);
            BigInteger a = 2;
            BigInteger y = BigInteger.ModPow(a, d, number);  //a^d mod number
            if (y != BigInteger.One && y != n)
            {
                for (var r = 1; r <= s - 1; r++)
                {
                    y = BigInteger.ModPow(y, 2, number);
                    if (y == 1)
                        return false;
                }

                if (y != n)
                    return false;
            }
            return true; //it is probably prime
        }*/
        private bool Check_Prime(BigInteger n)
        {
            if (n < 2) //n nho hon 2 -> khong la so nguyen to
            {
                return false;
            }
            int count = 0;
            for (int i = 2; i <= (n-1); i++)//kieem tra tu khoang 2->n-1
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
            alert_Q.Visible = false;
            alert_M.Visible = false;
            alert_P.Visible = false;
            if (CipherTextBox.Text == "") { flag = false; alert_M.Visible = true; }
            if (NhapP.Text == "") { flag = false; alert_P.Visible = true; }
            if (NhapQ.Text == "") { flag = false; alert_Q.Visible = true; }
            return flag;
        }
        #endregion

        #region Convert_and_Encrypt
        private List<double> Convert_toASCII(string s) //String to ASCII
        {
            byte[] bytes = Encoding.ASCII.GetBytes(s);
            int numChar = bytes.Length;
            List<double> temp = new List<double>();
            for (int i = 0; i < s.Length; i++)
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
        private string Convert_toString(List<BigInteger> list)
        {
            string temp = "";
            byte[] bytes = new byte[list.Count()];
            for (int i = 0; i < list.Count(); i++)
            {
                bytes = BitConverter.GetBytes((double)list[i]);
                temp = temp + Encoding.ASCII.GetString(bytes);
            }
            return temp;
        }
        private List<BigInteger> Convert_toDouble(string s)
        {
            string[] a = ciphertext.Split(' ');
            //for (int i = 0; i < a.Length; i++) { C[i] = Convert.ToDouble(a[i]); }
            List<BigInteger> temp = new List<BigInteger>();
            for (int i = 0; i < a.Length; i++)
            {
                double k = Convert.ToDouble(a[i]);
                temp.Add((BigInteger)k);
            }
            return temp;
        }
        private void Do_Decrypt()
        {
            ciphertext = CipherTextBox.Text;
            //string[] a = ciphertext.Split(' ');
            //for(int i = 0; i < a.Length; i++) { C[i]=Convert.ToDouble(a[i]); }
            C = Convert_toDouble(ciphertext);
            MessageBox.Show("ok");
            string g = null;
            for (int i = 0; i < C.Count(); i++)
            {
                BigInteger h = C[i];
                BigInteger f = BigInteger.ModPow(h,D,N);
                g += ASCIIEncoding.ASCII.GetString(f.ToByteArray());
                
            }
            NhapN.Text = N.ToString();
            Sn_Text.Text = Sn.ToString();
            NhapE.Text = E.ToString();
            D_text.Text = D.ToString();
            plainTextBox.Text = g.ToString();
            //string hexString = BitConverter.ToString(bytes);
            //hexString = hexString.Replace("-", " ");
            //CipherTextBox.Text = hexString;
            //string[] a = hexString.Split('-');


        }

        #endregion

        #region Others
        private void NhapN_KeyPress(object sender, KeyPressEventArgs e) //number only
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        #region Number Only
        private void NhapE_KeyPress(object sender, KeyPressEventArgs e) //number only
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void NhapP_KeyPress(object sender, KeyPressEventArgs e) //number only
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void NhapQ_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void label7_Click(object sender, EventArgs e)
        {

        }
        #endregion
        public void EXtract_form_TxtBox()  //take information from textBox
        {
            plaintext = plainTextBox.Text.Trim();
            P = int.Parse(NhapP.Text);
            Q = int.Parse(NhapQ.Text);
            //N = Double.Parse(NhapN.Text);
            E = BigInteger.Parse(NhapE.Text);
        }
        public BigInteger Tinh_n() //cal n
        {
            N = (BigInteger)P * Q;
            return N;
        }
        public BigInteger Tinh_Sn()  //cal sn
        {
            Sn = (BigInteger)(P - 1) * (Q - 1);
            return Sn;
        }

        private BigInteger randomPrimeNum() {
            Random rand = new Random();
            int i = rand.Next(primesBelow2000.Length);
            int ra = primesBelow2000[i];
            return ra;
        
        }
        private void generateE_Click(object sender, EventArgs e)
        {
            //EXtract_form_TxtBox();
            P = randomPrimeNum();
            Q = randomPrimeNum();
            /*bool Check_Prime_P_flag = Check_Prime(P);
            bool Check_Prime_Q_flag = Check_Prime(Q);
            if (!Check_Prime_P_flag || !Check_Prime_Q_flag)
            {
                MessageBox.Show("Your inputs P or Q are not Prime!");
            }
            else
            {
            }*/

            Tinh_Sn();
            E = Generrate_E();
            NhapP.Text = P.ToString();
            NhapQ.Text = Q.ToString();
            NhapE.Text = E.ToString();
        }


        public BigInteger Generrate_E()
        {
            List<double> e = new List<double>();
            for (ulong i = 2; i < Sn; i++)
            {
                if (GCD((ulong)Sn, i) == 1 && Check_STN(GCD((ulong)Sn, i)) == true)
                {
                    e.Add(i);
                }
            }
            int f = _random.Next(e.Count());
            BigInteger g = (BigInteger)e[f];
            return g;

        }
        public BigInteger Tinh_E()
        {
            
            ulong k = 0;
            for (ulong i = 2; i < Sn; i++)
            {
                if (GCD((ulong)Sn, i) == 1)
                {
                    k = i;
                    break;
                }
            }
            E = (BigInteger)k;
            return E;
        }
        public BigInteger Tinh_D()
        {
            double h = -1, a, b;
            for (int k = 1; k <= int.MaxValue; k++)
            {
                a = (double)Sn;
                b = (double)E;
                h = (1 + k * a) / b;
                if (Check_STN(h) == true) break;
            }
            D = (int)h;
            return D;
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
        private void textClear()
        {
            NhapQ.Text = null;
            NhapP.Text = null;
            NhapN.Text = null;
            NhapE.Text = null;
            Sn_Text.Text = null;
            D_text.Text = null;
        }
        private void radio_HandInput_CheckedChanged(object sender, EventArgs e)
        {
            NhapE.ReadOnly = false;
            NhapN.ReadOnly = false;
            NhapP.ReadOnly = false;
            NhapQ.ReadOnly = false;
            generateE.Visible = false;
        }

        private void radio_Random_CheckedChanged(object sender, EventArgs e)
        {
            textClear();
            NhapE.ReadOnly = true;
            NhapN.ReadOnly = true;
            NhapP.ReadOnly = true;
            NhapQ.ReadOnly = true;
            generateE.Visible = true;
        }

        // Generates a random number within a range.      
        public double RandomNumber(int min, int max)
        {
            return _random.Next(min, max);
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
