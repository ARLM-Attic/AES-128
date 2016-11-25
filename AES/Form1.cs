using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace AES
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            for (var i = 1; i < 16; i++)
                cb_sizeBlock.Items.Add(i.ToString());
            cb_sizeBlock.SelectedIndex = 1;
            tb_pathInputText.Text = "input.txt";
            tb_pathOutputText.Text = "output.bin";
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

        private void Message(string message)
        {
            MessageBox.Show(message, "Error!");
        }

        private void btn_genInitVect_Click(object sender, EventArgs e)
        {
            byte[] generation128 = new byte[16];
            Random rnd = new Random();
            rnd.NextBytes(generation128);
            tb_initVector.Text = BitConverter.ToString(generation128);
        }

        private void btn_dInputText_Click(object sender, EventArgs e)
        {
            try
            {
                var file = BitConverter.ToString(File.ReadAllBytes(tb_pathInputText.Text));

                if (check_Сiphertext.Checked)
                {
                    tb_initVector.Text = file.Substring(0, 47);
                    tb_plainText.Text = file.Substring(48, file.Length - 48);
                }
                else
                    tb_plainText.Text = file;


            }
            catch
            {
                Message("Error input file!");
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                if(check_Сiphertext.Checked)
                    File.WriteAllBytes(tb_pathOutputText.Text, StringToByte(tb_initVector.Text + '-' + tb_ciphertext.Text));
                else
                    File.WriteAllBytes(tb_pathOutputText.Text, StringToByte(tb_ciphertext.Text));
            }
            catch
            {
                Message("Error save file!");
            }
        }

        private void btn_Go_Click(object sender, EventArgs e)
        {
            try
            {
                var input = StringToByte(tb_plainText.Text);
                var ofb = new OFB(StringToByte(tb_key.Text), StringToByte(tb_initVector.Text), int.Parse(cb_sizeBlock.SelectedItem.ToString()));
                tb_ciphertext.Text = BitConverter.ToString(ofb.Decode(StringToByte(tb_plainText.Text)));
            }
            catch
            {
                Message("Error decode!");
            }
        }

        private void btn_swap_Click(object sender, EventArgs e)
        {
            var temp = tb_plainText.Text;
            tb_plainText.Text = tb_ciphertext.Text;
            tb_ciphertext.Text = temp;
        }
    }
}
