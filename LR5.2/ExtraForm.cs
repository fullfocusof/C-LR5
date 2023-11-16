using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;

namespace LR5._2
{
    public partial class ExtraForm : Form
    {
        int choice;
        Graphics g;
        Random rand;
        Pen MyPen;
        SolidBrush MyBrush;

        Rectangle sun;
        List<Cloud> cls = new List<Cloud>();

        public ExtraForm(int ch)
        {
            InitializeComponent();
            g = CreateGraphics();
            rand = new Random();
            choice = ch;
        }

        public class Cloud
        {
            public int X { get; set; }
            public int Y { get; set; }
            public int Width { get; set; }
            public int Height { get; set; }
            public int Speed { get; set; }
            public Rectangle Bounds => new Rectangle(X, Y, Width, Height);
            public int Direction { get; set; }
            public Cloud(int x, int y, int width, int height, int speed, int dir)
            {
                X = x;
                Y = y;
                Width = width;
                Height = height;
                Speed = speed;
                Direction = dir;
            }
        }

        private Cloud GenerateRandomCloud()
        {
            int cloudWidth = rand.Next(10, 150);
            int cloudHeight = rand.Next(10, 70);
            int cloudY = rand.Next(30, ClientSize.Height / 4);
            int cloudSpeed = rand.Next(1, 25);
            int dir = rand.Next(0, 2);
            int cloudX = dir == 0 ? -cloudWidth : ClientSize.Width + cloudWidth;

            return new Cloud(cloudX, cloudY, cloudWidth, cloudHeight, cloudSpeed, dir);
        }

        private void timerSun_Tick(object sender, EventArgs e)
        {
            g.Clear(BackColor);
            g.FillEllipse(Brushes.Yellow, sun);

            MyPen = new Pen(Brushes.Yellow, 3);

            double rSun = Math.Max(sun.Width, sun.Height) / 2;
            for (int i = 0; i < 360; i += 45)
            {
                double angle = i * Math.PI / 180;
                int rayEndX = (int)(sun.X + rSun + Math.Sin(angle) * rSun * 4);
                int rayEndY = (int)(sun.Y + rSun + Math.Cos(angle) * rSun * 4);
                int rayStartX = (int)(sun.X + rSun + Math.Sin(angle) * rSun * 2);
                int rayStartY = (int)(sun.Y + rSun + Math.Cos(angle) * rSun * 2);
                g.DrawLine(MyPen, rayStartX, rayStartY, rayEndX, rayEndY);
            }

            for (int i = 0; i < cls.Count; i++)
            {
                if (cls[i].Direction == 0)
                {
                    cls[i].X += cls[i].Speed;
                }
                else
                {
                    cls[i].X -= cls[i].Speed;
                }

                g.FillEllipse(Brushes.Gray, cls[i].Bounds);
            }

            if(cls.Count < 5) // 40% rand.Next(0,10) < 4
            {
                Cloud newCloud = GenerateRandomCloud();
                cls.Add(newCloud);
            }

            for (int i = cls.Count - 1; i >= 0; i--)
            {
                if (cls[i].X < -150 || cls[i].X > ClientSize.Width + 100)
                {
                    cls.RemoveAt(i);
                }
            }

            if (sun.Y < 30)
            {
                timerSunUp.Stop();
                timerSunDown.Start();
            }
            
            sun.Y -= 10;
            sun.Width += 1;
            sun.Height += 1;
        }

        private void timerSunDown_Tick(object sender, EventArgs e)
        {
            g.Clear(BackColor);
            g.FillEllipse(Brushes.Yellow, sun);

            MyPen = new Pen(Brushes.Yellow, 3);

            double rSun = Math.Max(sun.Width, sun.Height) / 2;
            for (int i = 0; i < 360; i += 45)
            {
                double angle = i * Math.PI / 180;
                int rayEndX = (int)(sun.X + rSun + Math.Sin(angle) * rSun * 4);
                int rayEndY = (int)(sun.Y + rSun + Math.Cos(angle) * rSun * 4);
                int rayStartX = (int)(sun.X + rSun + Math.Sin(angle) * rSun * 2);
                int rayStartY = (int)(sun.Y + rSun + Math.Cos(angle) * rSun * 2);
                g.DrawLine(MyPen, rayStartX, rayStartY, rayEndX, rayEndY);
            }

            for (int i = 0; i < cls.Count; i++)
            {
                if (cls[i].Direction == 0)
                {
                    cls[i].X += cls[i].Speed;
                }
                else
                {
                    cls[i].X -= cls[i].Speed;
                }

                g.FillEllipse(Brushes.Gray, cls[i].Bounds);
            }

            if (cls.Count < 5) // 40% rand.Next(0, 10) < 4
            {
                Cloud newCloud = GenerateRandomCloud();
                cls.Add(newCloud);
            }

            for (int i = cls.Count - 1; i >= 0; i--)
            {
                if (cls[i].X < -150 || cls[i].X > ClientSize.Width + 100)
                {
                    cls.RemoveAt(i);
                }
            }

            if (sun.Y > ClientSize.Height + 30)
            {
                timerSunDown.Stop();
                timerSunUp.Start();
            }

            sun.Y += 10;
            sun.Width -= 1;
            sun.Height -= 1;
        }








        private void buttonRecSquare_Click(object sender, EventArgs e)
        {
            g.Clear(BackColor);

            if (textBoxRecSquareLength.Text == "" || textBoxRecSquareCnt.Text == "")
            {
                MessageBox.Show("Введите данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int length = int.Parse(textBoxRecSquareLength.Text);
                int cnt = int.Parse(textBoxRecSquareCnt.Text);

                if (length > 800 || length < 1 || cnt < 0)
                {
                    MessageBox.Show("Введите верные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Point[] points =
                    {
                    new Point(ClientSize.Width / 2 - length, ClientSize.Height / 2 - length),
                    new Point(ClientSize.Width / 2 + length, ClientSize.Height / 2 - length),
                    new Point(ClientSize.Width / 2 + length, ClientSize.Height / 2 + length),
                    new Point(ClientSize.Width / 2 - length, ClientSize.Height / 2 + length),
                    };

                    MyPen = new Pen(Brushes.Black, 3);
                    while (cnt >= 0)
                    {
                        g.DrawPolygon(MyPen, points);
                        cnt--;

                        Point[] newpoints =
                        {
                        new Point((points[0].X + points[1].X) / 2, (points[0].Y + points[1].Y) / 2),
                        new Point((points[1].X + points[2].X) / 2, (points[1].Y + points[2].Y) / 2),
                        new Point((points[2].X + points[3].X) / 2, (points[2].Y + points[3].Y) / 2),
                        new Point((points[0].X + points[3].X) / 2, (points[0].Y + points[3].Y) / 2),
                        };

                        points = newpoints;
                    }
                }
            }

        }






        private void drawSinX()
        {
            g.Clear(BackColor);

            MyPen = new Pen(Color.Blue, 3);
            MyPen.EndCap = System.Drawing.Drawing2D.LineCap.ArrowAnchor;
            g.DrawLine(MyPen, 0, ClientSize.Height / 2, ClientSize.Width, ClientSize.Height / 2);
            g.DrawLine(MyPen, ClientSize.Width / 2, ClientSize.Height, ClientSize.Width / 2, 0);

            Font MyFont = new Font("Arial", 12);
            StringFormat format = new StringFormat();
            format.Alignment = StringAlignment.Center;
            format.LineAlignment = StringAlignment.Center;

            g.DrawString("X", MyFont, Brushes.Black, ClientSize.Width - 20, ClientSize.Height / 2 - 30);
            g.DrawString("Y", MyFont, Brushes.Black, ClientSize.Width / 2 + 10, 10);


            float step = 5f;
            float scale = (ClientSize.Height / 2 - 10) / 30f;

            for (float x = -30; x <= 30; x += step)
            {
                int pixelX = ClientSize.Width / 2 + (int)(x * scale);
                g.DrawLine(MyPen, pixelX, ClientSize.Height / 2 - 5, pixelX, ClientSize.Height / 2 + 5);
                g.DrawString(x.ToString(), MyFont, Brushes.Black, pixelX - 10, ClientSize.Height / 2 + 10);
            }
            for (float y = -30; y <= 30; y += step)
            {
                int pixelY = ClientSize.Height / 2 - (int)(y * scale);
                g.DrawLine(MyPen, ClientSize.Width / 2 - 5, pixelY, ClientSize.Width / 2 + 5, pixelY);
                if(y != 0)
                {
                    g.DrawString(y.ToString(), MyFont, Brushes.Black, ClientSize.Width / 2 - 40, pixelY - 10);
                }      
            }

            MyPen.Color = Color.Red;

            for (float x = -30; x <= 30; x += 0.1f)
            {
                float y = (float)(Math.Sin(x) * scale);
                int pixelX = ClientSize.Width / 2 + (int)(x * scale);
                int pixelY = ClientSize.Height / 2 - (int)y;
                g.DrawRectangle(MyPen, pixelX, pixelY, 1, 1);
            }
        }







        private void buttonSnowFlakeRec_Click(object sender, EventArgs e)
        {
            g.Clear(BackColor);

            if (textBoxRecSquareLength.Text == "" || textBoxRecSquareCnt.Text == "")
            {
                MessageBox.Show("Введите данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int length = int.Parse(textBoxRecSquareLength.Text);
                int cnt = int.Parse(textBoxRecSquareCnt.Text);

                if (length > 800 || length < 1 || cnt < 0)
                {
                    MessageBox.Show("Введите верные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    DrawSnowflake(cnt, length, ClientSize.Width / 2, ClientSize.Height / 2);
                }
            }
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



        Color[] colors = { Color.Red, Color.Blue, Color.Green, Color.Yellow };

        private void DrawRecEllipse(int level, int size, int centerX, int centerY, int clrID)
        {
            if (level == -1) return;

            MyBrush = new SolidBrush(colors[clrID]);
            MyPen = new Pen(Color.Black, 2);

            int smallEllipseSize = size / 2;

            for (int angle = 0; angle < 360; angle += 90)
            {
                double radians = Math.PI * angle / 180.0;
                int newX = centerX + (int)(size * 3 * Math.Cos(radians));
                int newY = centerY + (int)(size * 3 * Math.Sin(radians));

                g.FillEllipse(MyBrush, centerX - size / 2 , centerY - size / 2, size, size);
                g.DrawEllipse(MyPen, centerX - size / 2, centerY - size / 2, size + 1, size + 1);

                DrawRecEllipse(level - 1, smallEllipseSize, newX, newY, clrID - 1);
            }
        }




        private void ExtraForm_Shown(object sender, EventArgs e)
        {
            switch (choice)
            {
                case 1:
                    {
                        Text = "Солнце и облака";

                        sun = new Rectangle(ClientSize.Width / 2 - 15, ClientSize.Height + 15, 30, 30);

                        timerSunUp.Start();
                    }
                    break;

                case 2:
                    {
                        Text = "Рекурсивный квадрат";

                        labelRecSquareCnt.Visible = true;
                        labelRecSquareLength.Visible = true;
                        textBoxRecSquareCnt.Visible = true;
                        textBoxRecSquareLength.Visible = true;
                        buttonRecSquare.Visible = true;

                    }
                    break;

                case 3:
                    {
                        int squareSize = 50, boardSize = 8;

                        Text = "Шахматная доска";
                        ClientSize = new Size(boardSize * squareSize + 200, boardSize * squareSize + 200);
                        
                        for (int i = 0; i < boardSize; i++)
                        {
                            for (int j = 0; j < boardSize; j++)
                            {
                                bool isEvenRow = i % 2 == 0;
                                bool isEvenCol = j % 2 == 0;
                                bool isWhite = (isEvenRow && isEvenCol) || (!isEvenRow && !isEvenCol);

                                PictureBox sq = new PictureBox();
                                sq.Size = new Size(squareSize, squareSize);
                                sq.Location = new Point(j * squareSize + squareSize, i * squareSize + squareSize);
                                sq.BackColor = isWhite ? Color.White : Color.Black;

                                if (i == 0 || j == 0)
                                {
                                    Label lb = new Label();
                                    lb.Text = i == 0 ? ((char)('a' + j)).ToString() : (boardSize - i).ToString();
                                    lb.AutoSize = true;
                                    lb.BackColor = Color.Transparent;
                                    lb.ForeColor = Color.Black;
                                    lb.Font = new Font("Arial", squareSize / 4);
                                    lb.Location = i == 0 ? new Point((squareSize + squareSize / 4) + j * squareSize, squareSize / 2) : new Point(squareSize / 2 - 10, (squareSize + squareSize / 4) + i * squareSize);

                                    Controls.Add(lb);

                                    if (i == 0 && j == 0)
                                    {
                                        Label lbtemp = new Label();
                                        lbtemp.Text = (boardSize - i).ToString();
                                        lbtemp.AutoSize = true;
                                        lbtemp.BackColor = Color.Transparent;
                                        lbtemp.ForeColor = Color.Black;
                                        lbtemp.Font = new Font("Arial", squareSize / 4);
                                        lbtemp.Location = new Point(squareSize / 2 - 10, (squareSize + squareSize / 4) + i * squareSize);
                                        Controls.Add(lbtemp);
                                    }
                                }

                                Controls.Add(sq);
                            }
                        }
                    }
                    break;

                case 4:
                    {
                        Text = "График sin(x)";

                        drawSinX();
                    }
                    break;

                case 5:
                    {
                        Text = "Рисование снежинки";

                        labelRecSquareCnt.Visible = true;
                        labelRecSquareLength.Visible = true;
                        textBoxRecSquareCnt.Visible = true;
                        textBoxRecSquareLength.Visible = true;
                        buttonSnowFlakeRec.Visible = true;
                    }
                    break;

                case 6:
                    {
                        Text = "Рекурсивные круги";

                        DrawRecEllipse(3, 80, ClientSize.Width / 2, ClientSize.Height / 2, 3);

                    }
                    break;
            }
        }

        
    }
}
