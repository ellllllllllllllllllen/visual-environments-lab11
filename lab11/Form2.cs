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

namespace lab11
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 f = new Form3();
            f.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Pen pn = new Pen(Color.Black, 5);  // Перо для рисования
            Graphics g = CreateGraphics();
            //g.DrawEllipse(pn, 100, 100, 200, 100);  //200, 200 - координаты верхнего левого угла прямоугольника, 
                                                    //300, 200 - его ширина и высота. Сюда вписывается эллипс.     
            g.FillEllipse(Brushes.Green, 100, 100, 200, 100);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Pen pn = new Pen(Color.Black, 5);  // Перо для рисования
            Graphics g = CreateGraphics();
            //g.DrawEllipse(pn, 300, 250, 100, 100);  //200, 200 - координаты верхнего левого угла прямоугольника, 
                                                    //300, 200 - его ширина и высота. Сюда вписывается эллипс.  
            
            g.FillEllipse(Brushes.Red, 300, 250, 100, 100);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Pen pn = new Pen(Color.Black, 5);
            Graphics g = CreateGraphics();
            g.DrawLine(pn, new Point(1, 1), new Point(1, 50));
            g.DrawLine(pn, new Point(1, 50), new Point(50, 50));
            g.DrawLine(pn, new Point(50, 50), new Point(50, 1));
            g.DrawLine(pn, new Point(1, 1), new Point(50, 1));
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Pen pn = new Pen(Color.Black, 5);
            Graphics g = CreateGraphics();
            g.DrawLine(pn, new Point(50, 300), new Point(50, 400));
            g.DrawLine(pn, new Point(50, 400), new Point(400, 400));
            g.DrawLine(pn, new Point(400, 400), new Point(400, 300));
            g.DrawLine(pn, new Point(50, 300), new Point(400, 300));
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Pen pn = new Pen(Color.Black, 5);
            Graphics g = CreateGraphics();
            
            g.FillEllipse(Brushes.Red, 100, 100, 50, 50);
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            Pen pn = new Pen(Color.Pink, 3);
            Graphics g = CreateGraphics();
            g.DrawLine(pn, new Point(187, 233), new Point(187, 150));
            g.DrawLine(pn, new Point(187, 150), new Point(272, 111));
            g.DrawLine(pn, new Point(272, 111), new Point(355, 150));
            g.DrawLine(pn, new Point(355, 150), new Point(355, 233));
            g.DrawLine(pn, new Point(355, 233), new Point(272, 275));
            g.DrawLine(pn, new Point(272, 275), new Point(187, 233));
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Pen pn = new Pen(Color.Black, 5);  // Перо для рисования
            Graphics g = CreateGraphics();
            //g.DrawEllipse(pn, 300, 250, 200, 100);
            //Pen pn2 = new Pen(Color.White, 100);
            g.DrawArc(pn, 300, 250, 200, 100, 300, );
            //g.DrawLine(pn2, new Point(298, 248), new Point(298, 355));


        }
    }
}
