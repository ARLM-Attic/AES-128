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
        Aes aes;

        public Form1()
        {
            InitializeComponent();
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
            tb_key.Text = BitConverter.ToString(generation128);

            //Aes test = new Aes(new byte[] { 0x2b, 0x28, 0xab, 0x09, 0x7e, 0xae, 0xf7, 0xcf, 0x15, 0xd2, 0x15, 0x4f, 0x16, 0xa6, 0x88, 0x3c });
            //var result = test.Encrypt(new byte[] { 0x32, 0x88, 0x31, 0xe0, 0x43, 0x5a, 0x31, 0x37, 0xf6, 0x30, 0x98, 0x07, 0xa8, 0x8d, 0xa2, 0x34 });
            //var result2 = test.Decrypt(result);
        }

        private void btn_genInitVect_Click(object sender, EventArgs e)
        {
            byte[] generation128 = new byte[16];
            Random rnd = new Random();
            rnd.NextBytes(generation128);
            tb_initVector.Text = BitConverter.ToString(generation128);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_encrypt_Click(object sender, EventArgs e)
        {
            var aes = new Aes(StringToByte(tb_key.Text));
            var plainText = StringToByte(tb_binPlainText.Text);
            var initVector = aes.Encrypt(StringToByte(tb_initVector.Text));

            if (plainText.Length % 16 != 0)
            {
                var temp = new byte[plainText.Length + (16 - plainText.Length % 16)];
                Array.Copy(plainText, temp, plainText.Length);
                plainText = temp;
            }

            var output = new List<byte>();

            for(var state = 0; state < plainText.Length; state += 16)
            {
                for(var i = 0; i < 16; i++)
                {
                    output.Add((byte)(plainText[i + state] ^ initVector[i]));
                }

                initVector = aes.Encrypt(initVector);
            }

            tb_binCipherText.Text = BitConverter.ToString(output.ToArray());

        }

        private void btn_decrypt_Click(object sender, EventArgs e)
        {
            //var aes = new Aes(StringToByte(tb_key.Text));
            ////tb_roundKey.Text = BitConverter.ToString(aes.KeyExpansion());

            //var input = StringToByte(tb_binCipherText.Text);

            //if (input.Length % 16 != 0)
            //{
            //    var temp = new byte[input.Length + (16 - input.Length % 16)];
            //    Array.Copy(input, temp, input.Length);
            //    input = temp;
            //}

            var aes = new Aes(StringToByte(tb_key.Text));
            var CipherText = StringToByte(tb_binCipherText.Text);
            var initVector = aes.Encrypt(StringToByte(tb_initVector.Text));

            if (CipherText.Length % 16 != 0)
            {
                var temp = new byte[CipherText.Length + (16 - CipherText.Length % 16)];
                Array.Copy(CipherText, temp, CipherText.Length);
                CipherText = temp;
            }

            var output = new List<byte>();

            for (var state = 0; state < CipherText.Length; state += 16)
            {
                for (var i = 0; i < 16; i++)
                {
                    output.Add((byte)(CipherText[i + state] ^ initVector[i]));
                }

                initVector = aes.Encrypt(initVector);
            }

            tb_plainText.Text = Encoding.ASCII.GetString(output.ToArray());
        }

        private void tb_plainText_TextChanged(object sender, EventArgs e)
        {
            //tb_binPlainText.Text = BitConverter.ToString(Encoding.UTF8.GetBytes(tb_plainText.Text));
            tb_binPlainText.Text = BitConverter.ToString(Encoding.ASCII.GetBytes(tb_plainText.Text));
        }

        private void tb_binCipherText_TextChanged(object sender, EventArgs e)
        {
            try
            {
                tb_ciphertext.Text = Convert.ToBase64String(StringToByte(tb_binCipherText.Text));
            }
            catch
            {
                if(tb_binCipherText.Text.Length == 0)
                {
                    tb_ciphertext.Text = "";
                }
                return;
            }
            
        }


    }
}
