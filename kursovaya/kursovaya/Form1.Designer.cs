namespace kursovaya
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.фильтрыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.инверсияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.логарифмическийToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.степеннойToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.кусочнаяФункцияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.измененияГистограммыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.эквализацияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.приведениеГистограммыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.локальнаяГистограммнаяОбработкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.теорияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сложениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вычитаниеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.умножениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.делениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.фильтрыToolStripMenuItem,
            this.измененияГистограммыToolStripMenuItem,
            this.теорияToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1208, 36);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.MenuStrip1_ItemClicked);
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(69, 32);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(184, 34);
            this.открытьToolStripMenuItem.Text = "Открыть";
            this.открытьToolStripMenuItem.Click += new System.EventHandler(this.ОткрытьToolStripMenuItem_Click);
            // 
            // фильтрыToolStripMenuItem
            // 
            this.фильтрыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.инверсияToolStripMenuItem,
            this.логарифмическийToolStripMenuItem,
            this.степеннойToolStripMenuItem,
            this.кусочнаяФункцияToolStripMenuItem});
            this.фильтрыToolStripMenuItem.Name = "фильтрыToolStripMenuItem";
            this.фильтрыToolStripMenuItem.Size = new System.Drawing.Size(100, 32);
            this.фильтрыToolStripMenuItem.Text = "Фильтры";
            // 
            // инверсияToolStripMenuItem
            // 
            this.инверсияToolStripMenuItem.Name = "инверсияToolStripMenuItem";
            this.инверсияToolStripMenuItem.Size = new System.Drawing.Size(265, 34);
            this.инверсияToolStripMenuItem.Text = "Инверсия";
            this.инверсияToolStripMenuItem.Click += new System.EventHandler(this.ИнверсияToolStripMenuItem_Click);
            // 
            // логарифмическийToolStripMenuItem
            // 
            this.логарифмическийToolStripMenuItem.Name = "логарифмическийToolStripMenuItem";
            this.логарифмическийToolStripMenuItem.Size = new System.Drawing.Size(265, 34);
            this.логарифмическийToolStripMenuItem.Text = "Логарифмический";
            this.логарифмическийToolStripMenuItem.Click += new System.EventHandler(this.ЛогарифмическийToolStripMenuItem_Click);
            // 
            // степеннойToolStripMenuItem
            // 
            this.степеннойToolStripMenuItem.Name = "степеннойToolStripMenuItem";
            this.степеннойToolStripMenuItem.Size = new System.Drawing.Size(265, 34);
            this.степеннойToolStripMenuItem.Text = "Степенной";
            this.степеннойToolStripMenuItem.Click += new System.EventHandler(this.СтепеннойToolStripMenuItem_Click);
            // 
            // кусочнаяФункцияToolStripMenuItem
            // 
            this.кусочнаяФункцияToolStripMenuItem.Name = "кусочнаяФункцияToolStripMenuItem";
            this.кусочнаяФункцияToolStripMenuItem.Size = new System.Drawing.Size(265, 34);
            this.кусочнаяФункцияToolStripMenuItem.Text = "Кусочная функция";
            this.кусочнаяФункцияToolStripMenuItem.Click += new System.EventHandler(this.КусочнаяФункцияToolStripMenuItem_Click);
            // 
            // измененияГистограммыToolStripMenuItem
            // 
            this.измененияГистограммыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.эквализацияToolStripMenuItem,
            this.приведениеГистограммыToolStripMenuItem,
            this.локальнаяГистограммнаяОбработкаToolStripMenuItem});
            this.измененияГистограммыToolStripMenuItem.Name = "измененияГистограммыToolStripMenuItem";
            this.измененияГистограммыToolStripMenuItem.Size = new System.Drawing.Size(233, 32);
            this.измененияГистограммыToolStripMenuItem.Text = "Изменения гистограммы";
            // 
            // эквализацияToolStripMenuItem
            // 
            this.эквализацияToolStripMenuItem.Name = "эквализацияToolStripMenuItem";
            this.эквализацияToolStripMenuItem.Size = new System.Drawing.Size(422, 34);
            this.эквализацияToolStripMenuItem.Text = "Эквализация";
            this.эквализацияToolStripMenuItem.Click += new System.EventHandler(this.ЭквализацияToolStripMenuItem_Click);
            // 
            // приведениеГистограммыToolStripMenuItem
            // 
            this.приведениеГистограммыToolStripMenuItem.Name = "приведениеГистограммыToolStripMenuItem";
            this.приведениеГистограммыToolStripMenuItem.Size = new System.Drawing.Size(422, 34);
            this.приведениеГистограммыToolStripMenuItem.Text = "Приведение гистограммы";
            // 
            // локальнаяГистограммнаяОбработкаToolStripMenuItem
            // 
            this.локальнаяГистограммнаяОбработкаToolStripMenuItem.Name = "локальнаяГистограммнаяОбработкаToolStripMenuItem";
            this.локальнаяГистограммнаяОбработкаToolStripMenuItem.Size = new System.Drawing.Size(422, 34);
            this.локальнаяГистограммнаяОбработкаToolStripMenuItem.Text = "Локальная гистограммная обработка";
            // 
            // теорияToolStripMenuItem
            // 
            this.теорияToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сложениеToolStripMenuItem,
            this.вычитаниеToolStripMenuItem,
            this.умножениеToolStripMenuItem,
            this.делениеToolStripMenuItem});
            this.теорияToolStripMenuItem.Name = "теорияToolStripMenuItem";
            this.теорияToolStripMenuItem.Size = new System.Drawing.Size(310, 32);
            this.теорияToolStripMenuItem.Text = "Арифметические преобразования";
            this.теорияToolStripMenuItem.Click += new System.EventHandler(this.ТеорияToolStripMenuItem_Click);
            // 
            // сложениеToolStripMenuItem
            // 
            this.сложениеToolStripMenuItem.Name = "сложениеToolStripMenuItem";
            this.сложениеToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.сложениеToolStripMenuItem.Text = "Сложение";
            // 
            // вычитаниеToolStripMenuItem
            // 
            this.вычитаниеToolStripMenuItem.Name = "вычитаниеToolStripMenuItem";
            this.вычитаниеToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.вычитаниеToolStripMenuItem.Text = "Вычитание";
            // 
            // умножениеToolStripMenuItem
            // 
            this.умножениеToolStripMenuItem.Name = "умножениеToolStripMenuItem";
            this.умножениеToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.умножениеToolStripMenuItem.Text = "Умножение";
            // 
            // делениеToolStripMenuItem
            // 
            this.делениеToolStripMenuItem.Name = "делениеToolStripMenuItem";
            this.делениеToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.делениеToolStripMenuItem.Text = "Деление";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(29, 55);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(342, 283);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(593, 55);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(388, 283);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 362);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "r1 =";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 403);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "r2 = ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(163, 362);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "s1 = ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(163, 403);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "s2 = ";
            this.label4.Click += new System.EventHandler(this.Label4_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(42, 356);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 26);
            this.textBox1.TabIndex = 7;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(42, 397);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 26);
            this.textBox2.TabIndex = 8;
            this.textBox2.TextChanged += new System.EventHandler(this.TextBox2_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(212, 356);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 26);
            this.textBox3.TabIndex = 9;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(212, 397);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 26);
            this.textBox4.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(377, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 20);
            this.label5.TabIndex = 11;
            this.label5.Click += new System.EventHandler(this.Label5_Click);
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.Location = new System.Drawing.Point(722, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 37);
            this.button1.TabIndex = 12;
            this.button1.Text = "Теория";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(340, 356);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 20);
            this.label6.TabIndex = 13;
            this.label6.Visible = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(29, 429);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(348, 253);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 14;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Location = new System.Drawing.Point(593, 429);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(386, 253);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 15;
            this.pictureBox4.TabStop = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(431, 177);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(117, 66);
            this.button2.TabIndex = 16;
            this.button2.Text = "Поменять местами";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1208, 712);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Градационные преобразования изображений";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem фильтрыToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ToolStripMenuItem инверсияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem логарифмическийToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem степеннойToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem кусочнаяФункцияToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ToolStripMenuItem измененияГистограммыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem эквализацияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem теорияToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ToolStripMenuItem приведениеГистограммыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem локальнаяГистограммнаяОбработкаToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ToolStripMenuItem сложениеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вычитаниеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem умножениеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem делениеToolStripMenuItem;
    }
}

