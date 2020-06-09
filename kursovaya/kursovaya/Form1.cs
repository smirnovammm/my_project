using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace kursovaya
{
    public partial class Form1 : Form
    {
        Bitmap Image;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void MenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void ОткрытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Image files | *.png; *.jpg; *.jpeg; *.bmp | All Files (*.*) | *.* ";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                Image = new Bitmap(dialog.FileName);
                pictureBox1.Image = Image;
                pictureBox1.Refresh();
            }
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void ИнверсияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label6.Visible = false;
            label5.Text = "Негативное преобразование".ToString();
            InvertFilter filter = new InvertFilter();
            Bitmap resultImage = filter.processImage(Image, 0, 0, 0, 0);
            pictureBox2.Image = resultImage;
            pictureBox2.Refresh();
            label6.Text = "Преобразование изображения в негатив осуществляется с яркостями в диапазоне  [0, L - 1]. \n s = (L - 1) - r \n Данный переворот уровней яркости изображения создает эквивалент фотографического негатива. ".ToString();


        }

        private void ЛогарифмическийToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label6.Visible = false;
            label5.Text = "Логарифмическое преобразование".ToString();
            LogarifmFilter filter = new LogarifmFilter();
            Bitmap resultImage = filter.processImage(Image, 0, 0, 0, 0);
            pictureBox2.Image = resultImage;
            pictureBox2.Refresh();
            label6.Text = "s = c*lg(1+r)".ToString();
        }

        private void СтепеннойToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label6.Visible = false;
            label5.Text = "Степенное преобразование".ToString();
            StepenFilter filter = new StepenFilter();
            Bitmap resultImage = filter.processImage(Image, 0, 0, 0, 0);
            pictureBox2.Image = resultImage;
            pictureBox2.Refresh();
            label6.Text = "s = c*r^γ".ToString();
        }

        private void КусочнаяФункцияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label6.Visible = false;
            if (textBox1.Text == null | textBox1.Text == null | textBox1.Text == null | textBox1.Text == null) { 

                label6.Text = "Введите значения параметров".ToString();
        }
        else{
            label5.Text = "Кусочно - линейное преобразование".ToString();
        int r1 = Int32.Parse(textBox1.Text);
        int r2 = Int32.Parse(textBox2.Text);
        int s1 = Int32.Parse(textBox3.Text);
        int s2 = Int32.Parse(textBox4.Text);
        kuski filter = new kuski();
        Bitmap resultImage = filter.processImage(Image, r1, r2, s1, s2);
        pictureBox2.Image = resultImage;
            pictureBox2.Refresh();}
            label6.Text = "Промежуточные значения (r1, s1) и (r2, s2) \n обеспечивают различные степени растяжения уровней яркости на результирующем изображении, \n меняя тем самым его контраст. ".ToString();
        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void ЭквализацияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label6.Visible = false;
            gys filter = new gys();
            Bitmap resultImage = gys.equalizing(Image);
            pictureBox2.Image = resultImage;
            pictureBox2.Refresh();
            label5.Text = "Эквализация гистограммы".ToString();
            label6.Text = "p ( rk ) =	nk	/n,  k = 0,1,..., L −1,".ToString();
            //pictureBox4.Image = filter.gystogramma(resultImage);
            pictureBox4.Refresh();
            gys gyst = new gys();
            //pictureBox3.Image = gyst.gystogramma(Image);
            pictureBox3.Refresh();

        }

        private void ТеорияToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            label6.Visible = true;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            
            pictureBox1.Image = pictureBox2.Image;
            pictureBox1.Refresh();
        }
    } 
}
