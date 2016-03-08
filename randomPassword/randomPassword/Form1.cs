using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace randomPassword
{
    public partial class Form1 : Form
    {
        private RNGCryptoServiceProvider rngp = new RNGCryptoServiceProvider();
        private byte[] rb = new byte[4];
        public Form1()
        {
            InitializeComponent();
        }
        private int Next()
        {
            rngp.GetBytes(rb);
            int value = BitConverter.ToInt32(rb, 0);
            if (value < 0) value = -value;
            return value;
        }
        private int Next(int max)
        {
            rngp.GetBytes(rb);
            int value = BitConverter.ToInt32(rb, 0);
            value = value % (max + 1);
            if (value < 0) value = -value;
            return value;
        }
        private int Next(int min, int max)
        {
            int value = Next(max - min) + min;
            return value;
        }
        //public string GetRandomFirstTittle(int length)
        //{
        //    StringBuilder sb = new StringBuilder();
        //    char[] chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
        //    for (int i = 0; i < length; i++)
        //    {
        //        sb.Append(chars[this.Next(chars.Length - 1)]);
        //    }
        //    string Password = sb.ToString();
        //    return Password;
        //}
        //public string GetRandomSendtoForth(int length)
        //{
        //    StringBuilder sb = new StringBuilder();
        //    char[] chars = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
        //    for (int i = 0; i < length; i++)
        //    {
        //        sb.Append(chars[this.Next(chars.Length - 1)]);
        //    }
        //    string Password = sb.ToString();
        //    return Password;
        //}
        //public string GetRandomSendFinalNum(int length)
        //{
        //    StringBuilder sb = new StringBuilder();
        //    char[] chars = "0123456789".ToCharArray();
        //    for (int i = 0; i < length; i++)
        //    {
        //        sb.Append(chars[this.Next(chars.Length - 1)]);
        //    }
        //    string Password = sb.ToString();
        //    return Password;
        //}
        public string getRanTypeAndRan(int type,int length)
        {
            StringBuilder sb = new StringBuilder();
            char[] chars="".ToCharArray();
            switch(type){
                case 1:
                    chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
                    break;
                case 2:
                    chars = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
                    break;
                case 3:
                    chars = "0123456789".ToCharArray();
                    break;
            }
            for (int i = 0; i < length; i++)
            {
                sb.Append(chars[this.Next(chars.Length - 1)]);
            }
            string Password = sb.ToString();
            return Password;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = getRanTypeAndRan(1, 1) + getRanTypeAndRan(2, 3) + getRanTypeAndRan(3,4) + Environment.NewLine;
            textBox1.Text += getRanTypeAndRan(1, 1) + getRanTypeAndRan(2,3) + getRanTypeAndRan(3,4) + Environment.NewLine;
            textBox1.Text += getRanTypeAndRan(1, 1) + getRanTypeAndRan(2,3) + getRanTypeAndRan(3,4) + Environment.NewLine;
            textBox1.Text += getRanTypeAndRan(1, 1) + getRanTypeAndRan(2,3) + getRanTypeAndRan(3,4) + Environment.NewLine;
            textBox1.Text += getRanTypeAndRan(1, 1) + getRanTypeAndRan(2,3) + getRanTypeAndRan(3,4);

        }
    }
}
