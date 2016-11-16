using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AES
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            byte[] test = { 0x19, 0xa0, 0x9a, 0xe9, 0x3d, 0xf4, 0xc6, 0xf8, 0xe3, 0xe2, 0x8d, 0x48, 0xbe, 0x2b, 0x2a, 0x08 };
            for (var i = 0; i < test.Length; i++)
            {
                test[i] = Aes.SubBytes(test[i]);
            }

        }

        private byte[] StringToByte(string str)
        {
            return Array.ConvertAll<string, byte>(str.Split('-'), s => Convert.ToByte(s, 16));
        }

        private void btn_generate_Click(object sender, EventArgs e)
        {
            byte[] generation128 = new byte[16];
            Random rnd = new Random();
            rnd.NextBytes(generation128);

            Aes test = new Aes(generation128);
            tb_roundKey.Text = BitConverter.ToString(test.KeyExpansion());

            tb_key.Text = BitConverter.ToString(generation128);
        }
    }
}
