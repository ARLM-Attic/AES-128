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
            this.tb_roundKey.Size = new System.Drawing.Size(490, 144);
            this.tb_roundKey.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 383);
            this.Controls.Add(this.tb_roundKey);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_generate);
            this.Controls.Add(this.tb_key);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_key;
        private System.Windows.Forms.Button btn_generate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_roundKey;
    }
}

