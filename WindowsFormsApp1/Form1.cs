using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FileDialog fileDialog = new OpenFileDialog();
            fileDialog.ShowDialog(this);
            string imageFile = fileDialog.FileName;
            if (imageFile == string.Empty) return;
            pictureBox1.Image = Image.FromFile(imageFile);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            process toBlackWhite = new process();
            Bitmap image = new Bitmap(pictureBox1.Image);
            toBlackWhite.blackWhite(image);
            pictureBox2.Image = image;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(pictureBox2.Image);
            int whiteColor = 0;
            int blackColor = 0;
            for (int x = 0; x < bmp.Width; x++)
            {
                for (int y = 0; y < bmp.Height; y++)
                {
                    Color color = bmp.GetPixel(x, y);

                    if (color.ToArgb() == Color.White.ToArgb())
                    {
                        whiteColor++;
                    }

                    else
                        if (color.ToArgb() == Color.Black.ToArgb())
                    {
                        blackColor++;
                    }
                }

            }
            textBox1.Text = Convert.ToString(whiteColor);
            textBox2.Text = Convert.ToString(blackColor);

            int c1 = Int32.Parse(textBox1.Text);
            double c2 = c1 * 0.26458333;
            textBox13.Text = c2.ToString();

            int d1 = Int32.Parse(textBox2.Text);
            double d2 = d1 * 0.26458333;
            textBox14.Text = d2.ToString();

            double e1 = double.Parse(textBox9.Text);
            double e2 = double.Parse(textBox13.Text);
            double e3 = double.Parse(textBox14.Text);
            double e4 = e2 * e1;
            double e5 = e3 * e1;
            textBox15.Text = e4.ToString();
            textBox16.Text = e5.ToString();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        static int i = 0;
        private void pictureBox2_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (i == 0)
            {
                base.OnMouseClick(e);
                textBox3.Text = e.X.ToString();
                textBox4.Text = e.Y.ToString();
                i = i + 1;
            }
            else if (i == 1)
            {
                base.OnMouseClick(e);
                textBox5.Text = e.X.ToString();
                textBox6.Text = e.Y.ToString();
            }

        }

        private void pictureBox2_MouseMove(object sender, MouseEventArgs e)
        {
            textBox11.Text = e.X.ToString();
            textBox12.Text = e.Y.ToString();
        }

        private void pictureBox2_MouseEnter(object sender, EventArgs e)
        {
            Cursor = Cursors.Cross;
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Arrow;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int a1 = Int32.Parse(textBox3.Text);
            int a2 = Int32.Parse(textBox4.Text);
            int a3 = Int32.Parse(textBox5.Text);
            int a4 = Int32.Parse(textBox6.Text);
            double a5 = (a3 - a1) * (a3 - a1);
            double a6 = (a4 - a2) * (a4 - a2);
            double a7 = Math.Sqrt(a5 + a6);
            double a8 = a7 * 0.26458333;
            textBox7.Text = a8.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            double b1 = double.Parse(textBox7.Text);
            double b2 = double.Parse(textBox8.Text);
            double b3 = b2 / b1;
            textBox9.Text = b3.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            double f1 = double.Parse(textBox10.Text);
            double f2 = double.Parse(textBox15.Text);
            double f3 = double.Parse(textBox16.Text);
            double f4 = f2 * f1;
            double f5 = f3 * f1;
            textBox17.Text = f4.ToString();
            textBox18.Text = f5.ToString();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.Show();
        }
    }
}
