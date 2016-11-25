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
            this.tb_plainText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Go = new System.Windows.Forms.Button();
            this.tb_initVector = new System.Windows.Forms.TextBox();
            this.btn_genInitVect = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_ciphertext = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cb_sizeBlock = new System.Windows.Forms.ComboBox();
            this.btn_dInputText = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_pathOutputText = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.check_Сiphertext = new System.Windows.Forms.CheckBox();
            this.tb_pathInputText = new System.Windows.Forms.TextBox();
            this.btn_save = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
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
            this.btn_generate.Location = new System.Drawing.Point(461, 8);
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
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Init Vector:";
            // 
            // tb_plainText
            // 
            this.tb_plainText.Location = new System.Drawing.Point(79, 151);
            this.tb_plainText.Multiline = true;
            this.tb_plainText.Name = "tb_plainText";
            this.tb_plainText.Size = new System.Drawing.Size(493, 144);
            this.tb_plainText.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Plain text:";
            // 
            // btn_Go
            // 
            this.btn_Go.Location = new System.Drawing.Point(79, 480);
            this.btn_Go.Name = "btn_Go";
            this.btn_Go.Size = new System.Drawing.Size(493, 40);
            this.btn_Go.TabIndex = 13;
            this.btn_Go.Text = "Go!";
            this.btn_Go.UseVisualStyleBackColor = true;
            this.btn_Go.Click += new System.EventHandler(this.btn_Go_Click);
            // 
            // tb_initVector
            // 
            this.tb_initVector.Location = new System.Drawing.Point(79, 38);
            this.tb_initVector.Name = "tb_initVector";
            this.tb_initVector.Size = new System.Drawing.Size(373, 20);
            this.tb_initVector.TabIndex = 15;
            // 
            // btn_genInitVect
            // 
            this.btn_genInitVect.Location = new System.Drawing.Point(461, 36);
            this.btn_genInitVect.Name = "btn_genInitVect";
            this.btn_genInitVect.Size = new System.Drawing.Size(111, 23);
            this.btn_genInitVect.TabIndex = 16;
            this.btn_genInitVect.Text = "Generation";
            this.btn_genInitVect.UseVisualStyleBackColor = true;
            this.btn_genInitVect.Click += new System.EventHandler(this.btn_genInitVect_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 333);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Сiphertext:";
            // 
            // tb_ciphertext
            // 
            this.tb_ciphertext.Location = new System.Drawing.Point(79, 330);
            this.tb_ciphertext.Multiline = true;
            this.tb_ciphertext.Name = "tb_ciphertext";
            this.tb_ciphertext.Size = new System.Drawing.Size(493, 144);
            this.tb_ciphertext.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "SizeBlock:";
            // 
            // cb_sizeBlock
            // 
            this.cb_sizeBlock.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_sizeBlock.FormattingEnabled = true;
            this.cb_sizeBlock.Location = new System.Drawing.Point(79, 64);
            this.cb_sizeBlock.Name = "cb_sizeBlock";
            this.cb_sizeBlock.Size = new System.Drawing.Size(121, 21);
            this.cb_sizeBlock.TabIndex = 18;
            // 
            // btn_dInputText
            // 
            this.btn_dInputText.Location = new System.Drawing.Point(461, 89);
            this.btn_dInputText.Name = "btn_dInputText";
            this.btn_dInputText.Size = new System.Drawing.Size(111, 23);
            this.btn_dInputText.TabIndex = 21;
            this.btn_dInputText.Text = "Download";
            this.btn_dInputText.UseVisualStyleBackColor = true;
            this.btn_dInputText.Click += new System.EventHandler(this.btn_dInputText_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Input file:";
            // 
            // tb_pathOutputText
            // 
            this.tb_pathOutputText.Location = new System.Drawing.Point(79, 117);
            this.tb_pathOutputText.Name = "tb_pathOutputText";
            this.tb_pathOutputText.Size = new System.Drawing.Size(373, 20);
            this.tb_pathOutputText.TabIndex = 23;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 120);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "Output file:";
            // 
            // check_Сiphertext
            // 
            this.check_Сiphertext.AutoSize = true;
            this.check_Сiphertext.Location = new System.Drawing.Point(222, 66);
            this.check_Сiphertext.Name = "check_Сiphertext";
            this.check_Сiphertext.Size = new System.Drawing.Size(73, 17);
            this.check_Сiphertext.TabIndex = 25;
            this.check_Сiphertext.Text = "Сiphertext";
            this.check_Сiphertext.UseVisualStyleBackColor = true;
            // 
            // tb_pathInputText
            // 
            this.tb_pathInputText.Location = new System.Drawing.Point(79, 91);
            this.tb_pathInputText.Name = "tb_pathInputText";
            this.tb_pathInputText.Size = new System.Drawing.Size(373, 20);
            this.tb_pathInputText.TabIndex = 20;
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(461, 115);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(112, 23);
            this.btn_save.TabIndex = 26;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(79, 301);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(493, 23);
            this.button2.TabIndex = 27;
            this.button2.Text = "Swap";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 543);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.check_Сiphertext);
            this.Controls.Add(this.tb_pathOutputText);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btn_dInputText);
            this.Controls.Add(this.tb_pathInputText);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cb_sizeBlock);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_genInitVect);
            this.Controls.Add(this.tb_initVector);
            this.Controls.Add(this.btn_Go);
            this.Controls.Add(this.tb_ciphertext);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_plainText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_generate);
            this.Controls.Add(this.tb_key);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "AES-128";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_key;
        private System.Windows.Forms.Button btn_generate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_plainText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_Go;
        private System.Windows.Forms.TextBox tb_initVector;
        private System.Windows.Forms.Button btn_genInitVect;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_ciphertext;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cb_sizeBlock;
        private System.Windows.Forms.Button btn_dInputText;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_pathOutputText;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox check_Сiphertext;
        private System.Windows.Forms.TextBox tb_pathInputText;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button button2;
    }
}

