using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace LR5._2
{
    public partial class FallSnowflakeForm : Form
    {
        Graphics g;
        Random rand;
        Pen MyPen;
        bool visible = false;

        public FallSnowflakeForm()
        {
            InitializeComponent();
            g = CreateGraphics();
            rand = new Random();
        }

        private void DrawSnowflake(int level, int size, int centerX, int centerY)
        {
            if (level == -1) return;

            MyPen = new Pen(Color.Black, 1 * level);

            int smallSnowflakeRad = size / 3;

            for (int angle = 0; angle < 360; angle += 45)
            {
                double radians = Math.PI * angle / 180.0;
                int startX = centerX;
                int startY = centerY;
                int endX = centerX + (int)(size * Math.Cos(radians));
                int endY = centerY + (int)(size * Math.Sin(radians));

                g.DrawLine(MyPen, startX, startY, endX, endY);

                DrawSnowflake(level - 1, smallSnowflakeRad, endX, endY);
            }
        }

        private void FallSnowflakeForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (MouseButtons == MouseButtons.Left && !visible)
            {
                visible = true;
                int startX = e.X, startY = e.Y;
                int size = rand.Next(10, 50);

                DrawSnowflake(2, size, startX, startY);

                while (startY < ClientSize.Height + size * 2)
                {
                    g.Clear(BackColor);
                    startY += 30;
                    DrawSnowflake(2, size, startX, startY);
                    Thread.Sleep(100);
                }

                visible = false;
            }
        }
    }
}
