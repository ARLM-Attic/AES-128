namespace AES
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.tb_key = new System.Windows.Forms.TextBox();
            this.btn_generate = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_roundKey = new System.Windows.Forms.TextBox();
            this.tb_plainText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_ciphertext = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_binPlainText = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_binCipherText = new System.Windows.Forms.TextBox();
            this.btn_encrypt = new System.Windows.Forms.Button();
            this.btn_decrypt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cipher key:";
            // 
            // tb_key
            // 
            this.tb_key.Location = new System.Drawing.Point(79, 10);
            this.tb_key.Name = "tb_key";
            this.tb_key.Size = new System.Drawing.Size(373, 20);
            this.tb_key.TabIndex = 1;
            // 
            // btn_generate
            // 
            this.btn_generate.Location = new System.Drawing.Point(458, 8);
            this.btn_generate.Name = "btn_generate";
            this.btn_generate.Size = new System.Drawing.Size(111, 23);
            this.btn_generate.TabIndex = 2;
            this.btn_generate.Text = "Generation";
            this.btn_generate.UseVisualStyleBackColor = true;
            this.btn_generate.Click += new System.EventHandler(this.btn_generate_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Round key:";
            // 
            // tb_roundKey
            // 
            this.tb_roundKey.Location = new System.Drawing.Point(79, 38);
            this.tb_roundKey.Multiline = true;
            this.tb_roundKey.Name = "tb_roundKey";
            this.tb_roundKey.Size = new System.Drawing.Size(783, 80);
            this.tb_roundKey.TabIndex = 4;
            // 
            // tb_plainText
            // 
            this.tb_plainText.Location = new System.Drawing.Point(79, 124);
            this.tb_plainText.Multiline = true;
            this.tb_plainText.Name = "tb_plainText";
            this.tb_plainText.Size = new System.Drawing.Size(373, 144);
            this.tb_plainText.TabIndex = 6;
            this.tb_plainText.TextChanged += new System.EventHandler(this.tb_plainText_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Plain text:";
            // 
            // tb_ciphertext
            // 
            this.tb_ciphertext.Location = new System.Drawing.Point(79, 274);
            this.tb_ciphertext.Multiline = true;
            this.tb_ciphertext.Name = "tb_ciphertext";
            this.tb_ciphertext.Size = new System.Drawing.Size(373, 144);
            this.tb_ciphertext.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 277);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Сiphertext:";
            // 
            // tb_binPlainText
            // 
            this.tb_binPlainText.Location = new System.Drawing.Point(489, 124);
            this.tb_binPlainText.Multiline = true;
            this.tb_binPlainText.Name = "tb_binPlainText";
            this.tb_binPlainText.Size = new System.Drawing.Size(373, 144);
            this.tb_binPlainText.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(458, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Bin:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(458, 277);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Bin:";
            // 
            // tb_binCipherText
            // 
            this.tb_binCipherText.Location = new System.Drawing.Point(489, 274);
            this.tb_binCipherText.Multiline = true;
            this.tb_binCipherText.Name = "tb_binCipherText";
            this.tb_binCipherText.Size = new System.Drawing.Size(373, 144);
            this.tb_binCipherText.TabIndex = 11;
            this.tb_binCipherText.TextChanged += new System.EventHandler(this.tb_binCipherText_TextChanged);
            // 
            // btn_encrypt
            // 
            this.btn_encrypt.Location = new System.Drawing.Point(79, 429);
            this.btn_encrypt.Name = "btn_encrypt";
            this.btn_encrypt.Size = new System.Drawing.Size(373, 40);
            this.btn_encrypt.TabIndex = 13;
            this.btn_encrypt.Text = "Encrypt";
            this.btn_encrypt.UseVisualStyleBackColor = true;
            this.btn_encrypt.Click += new System.EventHandler(this.btn_encrypt_Click);
            // 
            // btn_decrypt
            // 
            this.btn_decrypt.Location = new System.Drawing.Point(489, 429);
            this.btn_decrypt.Name = "btn_decrypt";
            this.btn_decrypt.Size = new System.Drawing.Size(373, 40);
            this.btn_decrypt.TabIndex = 14;
            this.btn_decrypt.Text = "Decrypt";
            this.btn_decrypt.UseVisualStyleBackColor = true;
            this.btn_decrypt.Click += new System.EventHandler(this.btn_decrypt_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 497);
            this.Controls.Add(this.btn_decrypt);
            this.Controls.Add(this.btn_encrypt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tb_binCipherText);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tb_binPlainText);
            this.Controls.Add(this.tb_ciphertext);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_plainText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_roundKey);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_generate);
            this.Controls.Add(this.tb_key);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "AES-128";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_key;
        private System.Windows.Forms.Button btn_generate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_roundKey;
        private System.Windows.Forms.TextBox tb_plainText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_ciphertext;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_binPlainText;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_binCipherText;
        private System.Windows.Forms.Button btn_encrypt;
        private System.Windows.Forms.Button btn_decrypt;
    }
}

