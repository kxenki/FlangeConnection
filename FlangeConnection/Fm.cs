using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.text.html;
using iTextSharp.text.html.simpleparser;
using System.IO;
using System.Diagnostics;

namespace FlangeConnection
{
    public partial class Fm : Form
    {
        float k = 1; //коэффициент
        float n = 2; //степень графика
        float f = 0; //x+
        float c = 0; //y+
        private System.Drawing.Image bitmap;

        public Fm()
        {
            InitializeComponent();
            picBox1.MouseLeave += PicBox_MouseLeave;
            picBox2.MouseLeave += PicBox_MouseLeave;
            picBox3.MouseLeave += PicBox_MouseLeave;

            picBox1.MouseEnter += PicBox_MouseEnter;
            picBox2.MouseEnter += PicBox_MouseEnter;
            picBox3.MouseEnter += PicBox_MouseEnter;

            createCheckBox();
            createSize();
            this.Resize += (s, e) => createSize();

            tbPress.KeyPress += TbPress_KeyPress;
            tbPress.TextChanged += TbPress_TextChanged;
            tbToDegrees.KeyPress += TbToDegrees_KeyPress;
            tbToDegrees.TextChanged += TbToDegrees_TextChanged;
            tbFromDegrees.KeyPress += TbFromDegrees_KeyPress;
            tbFromDegrees.TextChanged += TbFromDegrees_TextChanged;

            bitmap = new Bitmap(picBoxPaint.Width, picBoxPaint.Height);
            buReport.Click += BuReport_Click;
        }


        private void BuReport_Click(object sender, EventArgs e)
        {
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            var enc1252 = Encoding.GetEncoding(1252);

            string ttf = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Fonts), "ARIAL.TTF");
            var baseFont = BaseFont.CreateFont(ttf, BaseFont.IDENTITY_H, BaseFont.NOT_EMBEDDED);
            var font = new iTextSharp.text.Font(baseFont, iTextSharp.text.Font.DEFAULTSIZE, iTextSharp.text.Font.NORMAL);
            var fontParag = new iTextSharp.text.Font(baseFont, 20);
            var fontTitle = new iTextSharp.text.Font(baseFont, 24);

            Document doc = new Document(PageSize.A4, 10f, 10f, 100f, 0f);

            string pdfFilePath = @"D:/";
            string fullPdfFilePath = pdfFilePath + "MyDocument.pdf";

            var fs = new FileStream(fullPdfFilePath, FileMode.Create);

            doc.NewPage();
            var writer = PdfWriter.GetInstance(doc, fs);

            doc.Open();
            doc.NewPage();

            using (var stream = new FileStream("Test.pdf", FileMode.Create))
            {
                PdfWriter.GetInstance(doc, stream);
                doc.Open();

                doc.Add(new Paragraph("Фланцевое соединение", fontTitle));
                doc.Add(new Paragraph("Параметры:", fontParag));
                doc.Add(new Paragraph($"Материал = {lbMaterial.SelectedItem}", font));
                doc.Add(new Paragraph($"Давление = {tbPress.Text} [кгс/см^2]", font));
                doc.Add(new Paragraph($"Температура = от {tbFromDegrees.Text} до {tbToDegrees.Text} [°C]", font));

                doc.Close();
            }

            MessageBox.Show("Отчет сохранен на диске D");
        }

        private void TbFromDegrees_TextChanged(object sender, EventArgs e)
        {
            if (tbFromDegrees.Text == "" || tbFromDegrees.Text == "-" || Convert.ToInt32(tbFromDegrees.Text) < -270 || Convert.ToInt32(tbFromDegrees.Text) > 650)
                tbFromDegrees.ForeColor = Color.Red;
            else
                tbFromDegrees.ForeColor = Color.Black;
        }

        private void TbToDegrees_TextChanged(object sender, EventArgs e)
        {
            if (tbToDegrees.Text == "" || tbToDegrees.Text == "-" || Convert.ToInt32(tbToDegrees.Text) < -270 || Convert.ToInt32(tbToDegrees.Text) > 650)
                tbToDegrees.ForeColor = Color.Red;
            else
                tbToDegrees.ForeColor = Color.Black;
        }

        private void TbToDegrees_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && (e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != '-')
                e.Handled = true;
        }

        private void TbPress_TextChanged(object sender, EventArgs e)
        {
            if (tbPress.Text != "" && Convert.ToDouble(tbPress.Text) > 250)
                tbPress.ForeColor = Color.Red;
            else
                tbPress.ForeColor = Color.Black;
        }

        private void TbFromDegrees_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && (e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != '-')
                e.Handled = true;
        }


        private void TbPress_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && (e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != ',')
                e.Handled = true;
        }

        private void createSize()
        {
            //локация выбора конструкции
            int picWidth = this.ClientSize.Width / 45 * 10;
            int picHeight = this.ClientSize.Height / 40 * 10;
            picBox1.Size = new Size(picWidth, picHeight);
            picBox2.Size = new Size(picWidth, picHeight);
            picBox3.Size = new Size(picWidth, picHeight);

            picBox1.Location = new Point(15,15);
            picBox2.Location = new Point(15,15 * 3 + picHeight);
            picBox3.Location = new Point(15, 15 * 5 + picHeight*2);

            label1.Location = new Point(15, 15 + picHeight);
            label2.Location = new Point(15, 15 * 3 + picHeight*2);
            label3.Location = new Point(15, 15 * 5 + picHeight * 3);
            

            // локация параметров
            int panelX = this.ClientSize.Width / 35 * 10;
            int panelY = this.ClientSize.Height / 80 * 10-30;
            int panelY5 = this.ClientSize.Height / 80 * 10-60;
            int panelY6 = this.ClientSize.Height / 80 * 10-90;
            panel.Location = new Point(panelX, panelY);
            label5.Location = new Point(panelX, panelY5);
            label6.Location = new Point(panelX, panelY6);

            //локация графика
            int grafX = this.ClientSize.Width / 5 * 3;
            int grafY = this.ClientSize.Height / 80 * 10-30;
            int grafLable = this.ClientSize.Height / 80 * 10-90;
            picBoxPaint.Location = new Point(grafX, grafY);
            label4.Location = new Point(grafX, grafLable);
            int grafWidth = this.ClientSize.Width / 3 ;
            int grafHeight = this.ClientSize.Height / 3 ;
            picBoxPaint.Size = new Size(grafWidth, grafHeight);
            picBoxPaint.Invalidate();
        }

        private void createCheckBox()
        {
            CheckBox checkBox1 = new CheckBox();
            checkBox1.Text = "Вода";
            checkBox1.Size = new Size(230, 30);
            panel.Controls.Add(checkBox1);

            CheckBox checkBox2 = new CheckBox();
            checkBox2.Text = "Воздух";
            checkBox2.Size = new Size(230, 30);
            panel.Controls.Add(checkBox2);

            CheckBox checkBox3 = new CheckBox();
            checkBox3.Text = "Нейтральные расворы солей";
            checkBox3.Size = new Size(230,30);
            panel.Controls.Add(checkBox3);

            CheckBox checkBox4 = new CheckBox();
            checkBox4.Text = "Нейтральные газы";
            checkBox4.Size = new Size(230, 30);
            panel.Controls.Add(checkBox4);

            CheckBox checkBox19 = new CheckBox();
            checkBox19.Text = "Нейтральные пары";
            checkBox19.Size = new Size(230, 30);
            panel.Controls.Add(checkBox19);

            CheckBox checkBox5 = new CheckBox();
            checkBox5.Text = "HSO концентрация до 56%";
            checkBox5.Size = new Size(230, 30);
            panel.Controls.Add(checkBox5);

            CheckBox checkBox6 = new CheckBox();
            checkBox6.Text = "Тяжелые нефтепродукты";
            checkBox6.Size = new Size(230, 30);
            panel.Controls.Add(checkBox6);

            CheckBox checkBox7 = new CheckBox();
            checkBox7.Text = "Керосин";
            checkBox7.Size = new Size(230, 30);
            panel.Controls.Add(checkBox7);

            CheckBox checkBox8 = new CheckBox();
            checkBox8.Text = "Масла";
            checkBox8.Size = new Size(230, 30);
            panel.Controls.Add(checkBox8);

            CheckBox checkBox9 = new CheckBox();
            checkBox9.Text = "Буталон";
            checkBox9.Size = new Size(230, 30);
            panel.Controls.Add(checkBox9);

            CheckBox checkBox10 = new CheckBox();
            checkBox10.Text = "Водяной пар";
            checkBox10.Size = new Size(230, 30);
            panel.Controls.Add(checkBox10);

            CheckBox checkBox11 = new CheckBox();
            checkBox11.Text = "Сухие нейтральные";
            checkBox11.Size = new Size(230, 30);
            panel.Controls.Add(checkBox11);

            CheckBox checkBox20 = new CheckBox();
            checkBox20.Text = "Инертные газы";
            checkBox20.Size = new Size(230, 30);
            panel.Controls.Add(checkBox20);

            CheckBox checkBox12 = new CheckBox();
            checkBox12.Text = "Легкие нефтепродукты";
            checkBox12.Size = new Size(230, 30);
            panel.Controls.Add(checkBox12);

            CheckBox checkBox13 = new CheckBox();
            checkBox13.Text = "Сниженные углеводороды";
            checkBox13.Size = new Size(230, 30);
            panel.Controls.Add(checkBox13);

            CheckBox checkBox14 = new CheckBox();
            checkBox14.Text = "Кислород";
            checkBox14.Size = new Size(230, 30);
            panel.Controls.Add(checkBox14);

            CheckBox checkBox21 = new CheckBox();
            checkBox21.Text = "Азот";
            checkBox21.Size = new Size(230, 30);
            panel.Controls.Add(checkBox21);

            CheckBox checkBox15 = new CheckBox();
            checkBox15.Text = "Коксовый газ";
            checkBox15.Size = new Size(230, 30);
            panel.Controls.Add(checkBox15);

            CheckBox checkBox16 = new CheckBox();
            checkBox16.Text = "Углеводороды жидкие";
            checkBox16.Size = new Size(230, 30);
            panel.Controls.Add(checkBox16);

            CheckBox checkBox22 = new CheckBox();
            checkBox22.Text = "Углеводороды газообразные";
            checkBox22.Size = new Size(230, 30);
            panel.Controls.Add(checkBox22);

            CheckBox checkBox17 = new CheckBox();
            checkBox17.Text = "Растворители";
            checkBox17.Size = new Size(230, 30);
            panel.Controls.Add(checkBox17);

            CheckBox checkBox18 = new CheckBox();
            checkBox18.Text = "Щелочи любой концентрации";
            checkBox18.Size = new Size(230, 30);
            panel.Controls.Add(checkBox18);

            CheckBox checkBox23 = new CheckBox();
            checkBox23.Text = "Кислоты любой концентрации";
            checkBox23.Size = new Size(230, 30);
            panel.Controls.Add(checkBox23);
        }

        private void PicBox_MouseEnter(object sender, EventArgs e)
        {
            if (sender is Control x)
                x.BackColor = Color.Red;
        }

        private void PicBox_MouseLeave(object sender, EventArgs e)
        {
            if (sender is Control x)
                x.BackColor = SystemColors.Control;
        }

        private void picBox_Paint(object sender, PaintEventArgs e)
        {
          
            var count = 100;
            var step = 0.1f;
            var points = Enumerable.Range(0, count)
                .Select(x => step * x - step * count / 2)
                .Select(x => new PointF(x+f , k * (float)Math.Pow(x, n)+c));
            var blackPen = new Pen(Color.Black, 1);
            e.Graphics.TranslateTransform(picBoxPaint.Width / 2, picBoxPaint.Height / 2);
            e.Graphics.ScaleTransform(1, -1);
            e.Graphics.ScaleTransform(e.Graphics.DpiX / 2.54f, e.Graphics.DpiY / 2.54f);
            var penTransform = e.Graphics.Transform.Clone();
            penTransform.Invert();
            blackPen.Transform = penTransform;
            var grayPen = new Pen(Color.LightGray, 1);
            grayPen.Transform = penTransform;

            for (var x = -10; x <= 10; ++x)
            {
                var pen = x == 0 ? blackPen : grayPen;
                e.Graphics.DrawLine(pen, x, -10, x, 10);
                e.Graphics.DrawLine(pen, -10, x, 10, x);
            }
            e.Graphics.DrawLines(blackPen, points.ToArray());
        }

       
    }
}
