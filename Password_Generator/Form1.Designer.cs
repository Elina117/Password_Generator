namespace Password_Generator
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        public System.ComponentModel.IContainer components = null;

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
        public void InitializeComponent()
        {
            this.checkBox_abc = new System.Windows.Forms.CheckBox();
            this.checkBox_high_ABC = new System.Windows.Forms.CheckBox();
            this.checkBox_123 = new System.Windows.Forms.CheckBox();
            this.checkBox_symbols = new System.Windows.Forms.CheckBox();
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.button_generate = new System.Windows.Forms.Button();
            this.linkLabel_remember = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label_length_of_password = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox_copy = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_copy)).BeginInit();
            this.SuspendLayout();
            // 
            // checkBox_abc
            // 
            this.checkBox_abc.AutoSize = true;
            this.checkBox_abc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox_abc.Location = new System.Drawing.Point(41, 543);
            this.checkBox_abc.Name = "checkBox_abc";
            this.checkBox_abc.Size = new System.Drawing.Size(104, 41);
            this.checkBox_abc.TabIndex = 0;
            this.checkBox_abc.Text = "abc";
            this.checkBox_abc.UseVisualStyleBackColor = true;
            // 
            // checkBox_high_ABC
            // 
            this.checkBox_high_ABC.AutoSize = true;
            this.checkBox_high_ABC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox_high_ABC.Location = new System.Drawing.Point(151, 543);
            this.checkBox_high_ABC.Name = "checkBox_high_ABC";
            this.checkBox_high_ABC.Size = new System.Drawing.Size(118, 41);
            this.checkBox_high_ABC.TabIndex = 2;
            this.checkBox_high_ABC.Text = "ABC";
            this.checkBox_high_ABC.UseVisualStyleBackColor = true;
            // 
            // checkBox_123
            // 
            this.checkBox_123.AutoSize = true;
            this.checkBox_123.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox_123.Location = new System.Drawing.Point(293, 543);
            this.checkBox_123.Name = "checkBox_123";
            this.checkBox_123.Size = new System.Drawing.Size(104, 41);
            this.checkBox_123.TabIndex = 3;
            this.checkBox_123.Text = "123";
            this.checkBox_123.UseVisualStyleBackColor = true;
            // 
            // checkBox_symbols
            // 
            this.checkBox_symbols.AutoSize = true;
            this.checkBox_symbols.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox_symbols.Location = new System.Drawing.Point(429, 543);
            this.checkBox_symbols.Name = "checkBox_symbols";
            this.checkBox_symbols.Size = new System.Drawing.Size(118, 41);
            this.checkBox_symbols.TabIndex = 4;
            this.checkBox_symbols.Text = "#$@";
            this.checkBox_symbols.UseVisualStyleBackColor = true;
            // 
            // textBox_password
            // 
            this.textBox_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_password.Location = new System.Drawing.Point(606, 319);
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.Size = new System.Drawing.Size(645, 47);
            this.textBox_password.TabIndex = 5;
            // 
            // button_generate
            // 
            this.button_generate.BackColor = System.Drawing.Color.RoyalBlue;
            this.button_generate.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.button_generate.Location = new System.Drawing.Point(1261, 310);
            this.button_generate.Name = "button_generate";
            this.button_generate.Size = new System.Drawing.Size(186, 67);
            this.button_generate.TabIndex = 7;
            this.button_generate.Text = "Сгенерировать";
            this.button_generate.UseVisualStyleBackColor = false;
            this.button_generate.Click += new System.EventHandler(this.button_generate_Click);
            // 
            // linkLabel_remember
            // 
            this.linkLabel_remember.AutoSize = true;
            this.linkLabel_remember.Location = new System.Drawing.Point(1316, 384);
            this.linkLabel_remember.Name = "linkLabel_remember";
            this.linkLabel_remember.Size = new System.Drawing.Size(121, 25);
            this.linkLabel_remember.TabIndex = 8;
            this.linkLabel_remember.TabStop = true;
            this.linkLabel_remember.Text = "Запомнить";
            this.linkLabel_remember.Visible = false;
            this.linkLabel_remember.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_remember_LinkClicked);
            this.linkLabel_remember.Click += new System.EventHandler(this.linkLabel_remember_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(689, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(600, 37);
            this.label2.TabIndex = 10;
            this.label2.Text = "НАДЕЖНЫЙ ГЕНЕРАТОР ПАРОЛЕЙ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(601, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(782, 25);
            this.label3.TabIndex = 11;
            this.label3.Text = "Установите длину, необходимые критерии и бесплатный генератор паролей";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(860, 547);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(236, 37);
            this.label4.TabIndex = 12;
            this.label4.Text = "Длина пароля:";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Password_Generator.Properties.Resources.plus;
            this.pictureBox3.Location = new System.Drawing.Point(1195, 533);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(115, 65);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 14;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click_1);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Password_Generator.Properties.Resources.minus;
            this.pictureBox2.Location = new System.Drawing.Point(723, 533);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(115, 65);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Password_Generator.Properties.Resources.password_padlock;
            this.pictureBox1.Location = new System.Drawing.Point(32, 77);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(527, 407);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label_length_of_password
            // 
            this.label_length_of_password.AutoSize = true;
            this.label_length_of_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_length_of_password.Location = new System.Drawing.Point(1121, 547);
            this.label_length_of_password.Name = "label_length_of_password";
            this.label_length_of_password.Size = new System.Drawing.Size(53, 37);
            this.label_length_of_password.TabIndex = 15;
            this.label_length_of_password.Text = "16";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(828, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(299, 25);
            this.label1.TabIndex = 16;
            this.label1.Text = "выдаст подходящий вариант";
            // 
            // pictureBox_copy
            // 
            this.pictureBox_copy.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox_copy.Image = global::Password_Generator.Properties.Resources.copy;
            this.pictureBox_copy.Location = new System.Drawing.Point(1195, 319);
            this.pictureBox_copy.Name = "pictureBox_copy";
            this.pictureBox_copy.Size = new System.Drawing.Size(60, 46);
            this.pictureBox_copy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_copy.TabIndex = 17;
            this.pictureBox_copy.TabStop = false;
            this.pictureBox_copy.Click += new System.EventHandler(this.pictureBox_copy_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1449, 708);
            this.Controls.Add(this.pictureBox_copy);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_length_of_password);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.linkLabel_remember);
            this.Controls.Add(this.button_generate);
            this.Controls.Add(this.textBox_password);
            this.Controls.Add(this.checkBox_symbols);
            this.Controls.Add(this.checkBox_123);
            this.Controls.Add(this.checkBox_high_ABC);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.checkBox_abc);
            this.Name = "Form1";
            this.Text = "Password Generator";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_copy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.CheckBox checkBox_abc;
        public System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.CheckBox checkBox_high_ABC;
        public System.Windows.Forms.CheckBox checkBox_123;
        public System.Windows.Forms.CheckBox checkBox_symbols;
        public System.Windows.Forms.TextBox textBox_password;
        public System.Windows.Forms.Button button_generate;
        public System.Windows.Forms.LinkLabel linkLabel_remember;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.PictureBox pictureBox2;
        public System.Windows.Forms.PictureBox pictureBox3;
        public System.Windows.Forms.Label label_length_of_password;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.PictureBox pictureBox_copy;
    }
}

