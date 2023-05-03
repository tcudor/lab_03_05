using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab3
{
   
    
    public partial class Form1 : Form
    {
        private Bitmap bitmap;
        private Graphics graphics;

        public Form1()
        {
            InitializeComponent();
        }


        private void load_img(object sender, EventArgs e)
        {
            bitmap =new Bitmap(Width,Height);
            graphics = Graphics.FromImage(bitmap);
        }


        private void paint_img(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(bitmap,0,0);
        }


        private void button1_Click(object sender, EventArgs e)
        {
            int num1=0,num2=0,num3=0,num4=0,num5=0;
            int y = 300;
            bool ok;
            try
            {
                ok=int.TryParse(textBox1.Text, out num1);
                if (ok == false)
                {
                    throw new Exception();
                }
                ok=int.TryParse(textBox2.Text, out num2);
                if (ok == false)
                {
                    throw new Exception();
                }
                ok =int.TryParse(textBox3.Text, out num3);
                if (ok == false)
                {
                    throw new Exception();
                }
                ok = int.TryParse(textBox4.Text, out num4);
                if (ok == false)
                {
                    throw new Exception();
                }
                ok = int.TryParse(textBox5.Text, out num5);
                if (ok == false)
                {
                    throw new Exception();
                }

                SolidBrush myBrush = new System.Drawing.SolidBrush(System.Drawing.Color.Red);
                graphics = this.CreateGraphics();
                Rectangle Rect = new Rectangle(50, y - num1, 90, num1);
                Rectangle Rect2 = new Rectangle(200, y - num2, 90, num2);
                Rectangle Rect3 = new Rectangle(350, y - num3, 90, num3);
                Rectangle Rect4 = new Rectangle(500, y - num4, 90, num4);
                Rectangle Rect5 = new Rectangle(650, y - num5, 90, num5);
                graphics.FillRectangle(myBrush, Rect);
                graphics.FillRectangle(myBrush, Rect2);
                graphics.FillRectangle(myBrush, Rect3);
                graphics.FillRectangle(myBrush, Rect4);
                graphics.FillRectangle(myBrush, Rect5);
                myBrush.Dispose();
                graphics.Dispose();
            }
            catch (Exception)
            {
                MessageBox.Show("Nu ati introdus un numar valid");
            }
            
            
        }
    }
}

