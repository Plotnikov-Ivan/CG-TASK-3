using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CG_TASK_3_NEW
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            // Bitmap bmp = new Bitmap(1500, 600);
            // Graphics g = Graphics.FromImage(bmp);


            InitializeComponent();
  
        }


        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Graphics g;
            IntPtr hwnd = this.Handle;
            g = Graphics.FromHwnd(hwnd);
            g.SmoothingMode = SmoothingMode.AntiAlias;
            Point point1 = new Point(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox8.Text));
            Point point2 = new Point(Convert.ToInt32(textBox7.Text), Convert.ToInt32(textBox6.Text));
            Point point3 = new Point(Convert.ToInt32(textBox5.Text), Convert.ToInt32(textBox4.Text));
            Point point4 = new Point(Convert.ToInt32(textBox3.Text), Convert.ToInt32(textBox2.Text));

            Point[] pm = { point1, point2, point3, point4 };

            Pen pen = new Pen(Color.Black, 3);

            g.DrawCurve(pen, pm);

        }



        public void button2_Click(object sender, EventArgs e)
        {

            //timer1.Start();
            timer1.Enabled = true;
        }



        int TextBox1 = 0;
        int TextBox8 = 0;
        int TextBox7 = 0;
        int TextBox6 = 0;
        int TextBox5 = 0;
        int TextBox4 = 0;
        int TextBox3 = 0;
        int TextBox2 = 0;
        int ck = 0;
        Point point9 = new Point(0,0);
        Point point10 = new Point(0, 0);
        Point point11 = new Point(0, 0);
        Point point12 = new Point(0, 0);
        private void timer1_Tick(object sender, EventArgs e)
        {
            Graphics g;
            IntPtr hwnd = this.Handle;
            g = Graphics.FromHwnd(hwnd);
            g.SmoothingMode = SmoothingMode.AntiAlias;
            int p = 2;

         
            if ( ck == 0)
            {
                 TextBox1 = Convert.ToInt32(textBox1.Text);
                 TextBox8 = Convert.ToInt32(textBox8.Text);
                 TextBox7 = Convert.ToInt32(textBox7.Text);
                 TextBox6 = Convert.ToInt32(textBox6.Text);
                 TextBox5 = Convert.ToInt32(textBox5.Text);
                 TextBox4 = Convert.ToInt32(textBox4.Text);
                 TextBox3 = Convert.ToInt32(textBox3.Text);
                 TextBox2 = Convert.ToInt32(textBox2.Text);
                Point point9 = new Point(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox8.Text));
                Point point10 = new Point(Convert.ToInt32(textBox7.Text), Convert.ToInt32(textBox6.Text));
                Point point11 = new Point(Convert.ToInt32(textBox5.Text), Convert.ToInt32(textBox4.Text));
            }
            ck++;

  
            Pen pen = new Pen(Color.Black, 3);
            Pen pen1 = new Pen(Color.White, 5);

            Point point1 = new Point(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox8.Text));
            Point point2 = new Point(Convert.ToInt32(textBox7.Text), Convert.ToInt32(textBox6.Text));
            Point point3 = new Point(Convert.ToInt32(textBox5.Text), Convert.ToInt32(textBox4.Text));
            Point point4 = new Point(Convert.ToInt32(textBox3.Text), Convert.ToInt32(textBox2.Text));




            Point point5 = new Point(Convert.ToInt32(textBox9.Text), Convert.ToInt32(textBox10.Text));
            Point point6 = new Point(Convert.ToInt32(textBox11.Text), Convert.ToInt32(textBox12.Text));
            Point point7 = new Point(Convert.ToInt32(textBox13.Text), Convert.ToInt32(textBox14.Text));
            Point point8 = new Point(Convert.ToInt32(textBox15.Text), Convert.ToInt32(textBox16.Text));





            Point[] pm = { point9, point10, point11, point12 };
            g.DrawCurve(pen1, pm);


            if (ck == 2)
            {
                g.FillRectangle(new SolidBrush(SystemColors.ControlLightLight), ClientRectangle);    
            }


            if (TextBox1 <= (Convert.ToInt32(textBox9.Text)) & TextBox8 <= (Convert.ToInt32(textBox10.Text)))
            {
                 point9 = new Point(TextBox1 += p, TextBox8 += p);
            }
            if (TextBox1 >= (Convert.ToInt32(textBox9.Text)) & TextBox8 >= (Convert.ToInt32(textBox10.Text)))
            {
                 point9 = new Point(TextBox1 -= p, TextBox8 -= p);
            }
            if (TextBox1 >= (Convert.ToInt32(textBox9.Text)) & TextBox8 <= (Convert.ToInt32(textBox10.Text)))
            {
                 point9 = new Point(TextBox1 -= p, TextBox8 += p);
            }
            if (TextBox1 <= (Convert.ToInt32(textBox9.Text)) & TextBox8 >= (Convert.ToInt32(textBox10.Text)))
            {
                 point9 = new Point(TextBox1 += p, TextBox8 -= p);
            }

             if (TextBox7 <= (Convert.ToInt32(textBox11.Text)) & TextBox6 <= (Convert.ToInt32(textBox12.Text)))
             {
                 point10 = new Point(TextBox7 += p, TextBox6 += p);
             }
             if (TextBox7 >= (Convert.ToInt32(textBox11.Text)) & TextBox6 >= (Convert.ToInt32(textBox12.Text)))
             {
                 point10 = new Point(TextBox7 -= p, TextBox6 -= p);
             }
             if (TextBox7 >= (Convert.ToInt32(textBox11.Text)) & TextBox6 <= (Convert.ToInt32(textBox12.Text)))
             {
                 point10 = new Point(TextBox7 -= p, TextBox6 += p);
             }
             if (TextBox7 <= (Convert.ToInt32(textBox11.Text)) & TextBox6 >= (Convert.ToInt32(textBox12.Text)))
             {
                 point10 = new Point(TextBox7 += p, TextBox6 -= p);
             }


            if (TextBox5 <= (Convert.ToInt32(textBox13.Text)) & TextBox4 <= (Convert.ToInt32(textBox14.Text)))
            {
                point11 = new Point(TextBox5 += p, TextBox4 += p);
            }
            if (TextBox5 >= (Convert.ToInt32(textBox13.Text)) & TextBox4 >= (Convert.ToInt32(textBox14.Text)))
            {
                point11 = new Point(TextBox5 -= p, TextBox4 -= p);
            }
            if (TextBox5 >= (Convert.ToInt32(textBox13.Text)) & TextBox4 <= (Convert.ToInt32(textBox14.Text)))
            {
                point11 = new Point(TextBox5 -= p, TextBox4 += p);
            }
            if (TextBox5 <= (Convert.ToInt32(textBox13.Text)) & TextBox4 >= (Convert.ToInt32(textBox14.Text)))
            {
                point11 = new Point(TextBox5 += p, TextBox4 -= p);
            }



            if (TextBox3 <= (Convert.ToInt32(textBox15.Text)) & TextBox2 <= (Convert.ToInt32(textBox16.Text)))
            {
                point12 = new Point(TextBox3 += p, TextBox2 += p);
            }
            if (TextBox3 >= (Convert.ToInt32(textBox15.Text)) & TextBox2 >= (Convert.ToInt32(textBox16.Text)))
            {
                point12 = new Point(TextBox3 -= p, TextBox2 -= p);
            }
            if (TextBox3 >= (Convert.ToInt32(textBox15.Text)) & TextBox2 <= (Convert.ToInt32(textBox16.Text)))
            {
                point12 = new Point(TextBox3 -= p, TextBox2 += p);
            }
            if (TextBox3 <= (Convert.ToInt32(textBox15.Text)) & TextBox2 >= (Convert.ToInt32(textBox16.Text)))
            {
                point12 = new Point(TextBox3 += p, TextBox2 -= p);
            }



   


            Point[] pm1 = { point9, point10, point11, point12 };
            g.DrawCurve(pen, pm1);




            if (((TextBox1 == Convert.ToInt32(textBox9.Text)) & (TextBox7 == Convert.ToInt32(textBox11.Text))) & ((TextBox5 == Convert.ToInt32(textBox13.Text)) & (TextBox3 == Convert.ToInt32(textBox15.Text))))
            {
                timer1.Enabled = false;
            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Очистить_Click(object sender, EventArgs e)
        {
            Graphics g = CreateGraphics();
            g.FillRectangle(new SolidBrush(SystemColors.ControlLightLight), ClientRectangle);
            g.Dispose();
        }
    }
}
