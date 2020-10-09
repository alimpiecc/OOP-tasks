using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rectangles
{
    public partial class form1 : Form
    {
        public form1()
        {
            InitializeComponent();
        }
        private Random r = new Random();
        private int x1;
        private int y1;
        private int x2;
        private int y2;
        private bool f = false;
        private bool key = false;
        private Color c = Color.Black;
        private Point center;
        private Point c1;
        private Point c2;

        private int selected;

        private int num = 1;
        List<Figure> figures = new List<Figure>();
        private Font font = new Font("Arial", 16);
        SolidBrush brush = new SolidBrush(Color.Black);

        private Graphics g;
        private Pen p;

        private void Form1_Load(object sender, EventArgs e)
        {
            this.DoubleBuffered = true;
            g = this.CreateGraphics();
            comboBox1.SelectedIndex = 0;
            comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.KeyPreview = true;
        }


        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            f = true;
            x1 = e.X;
            y1 = e.Y;
            c1 = e.Location;
    }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            if (key && IsFigureSelected(c1))
            {
                c2 = e.Location;
                figures[selected].Move(c2);
                g.Clear(Color.White);
                Redraw(g);
            }
            else if (!key)
            {
                x2 = e.X;
                y2 = e.Y;
                if (f && x1 != x2 && y1 != y2)
                {
                    center.X = (x1 + x2) / 2;
                    center.Y = (y1 + y2) / 2;
                    if (comboBox1.SelectedIndex == 0)
                    {
                        int width = Math.Abs(x1 - x2);
                        int height = Math.Abs(y1 - y2);
                        if (button2.Text == "цвет рандом выкл")
                        {
                            c = Color.FromArgb(r.Next(0, 255), r.Next(0, 255), r.Next(0, 255));
                        }
                        else
                        {
                            c = Color.Black;
                        }


                        if (Int32.TryParse(textBox1.Text, out int penwidh))
                        {
                            p = new Pen(c, penwidh);
                            rectangle re = new rectangle(width, height, center, p);
                            re.Draw(g);
                            listBox1.Items.Add($"прямоугольник:{num} размер:({width} x {height}) ");
                            g.DrawString(Convert.ToString(num), font, brush, center);
                            num++;
                            figures.Add(re);
                        }
                        else
                        {
                            p = new Pen(c, 5);
                            rectangle re = new rectangle(width, height, center, p);
                            re.Draw(g);
                            listBox1.Items.Add($"прямоугольник:{num} размер:({width} x {height}) ");
                            g.DrawString(Convert.ToString(num), font, brush, center);
                            num++;
                            figures.Add(re);
                        }
                    }
                    else
                    {
                        int width = Convert.ToInt32(Math.Sqrt(Math.Pow(x1 - x2, 2.0) + Math.Pow(y1 - y2, 2.0)));
                        int height = Convert.ToInt32(Math.Sqrt(Math.Pow(x1 - x2, 2.0) + Math.Pow(y1 - y2, 2.0)));
                        if (button2.Text == "цвет рандом выкл")
                        {
                            c = Color.FromArgb(r.Next(0, 255), r.Next(0, 255), r.Next(0, 255));
                        }
                        else
                        {
                            c = Color.Black;
                        }


                        if (Int32.TryParse(textBox1.Text, out int penwidh))
                        {
                            p = new Pen(c, penwidh);
                            Circle ci = new Circle(width, height, center, p);
                            ci.Draw(g);
                            listBox1.Items.Add($"круг:{num} радиус: {width} ");
                            g.DrawString(Convert.ToString(num), font, brush, center);
                            num++;
                            figures.Add(ci);
                        }
                        else
                        {
                            p = new Pen(c, 5);
                            Circle ci = new Circle(width, height, center, p);
                            ci.Draw(g);
                            listBox1.Items.Add($"круг:{num} радиус: {width} ");
                            g.DrawString(Convert.ToString(num), font, brush, center);
                            num++;
                            figures.Add(ci);
                        }
                    }


                }
            }
            
        }

        private bool IsFigureSelected(Point cursor)
        {
            bool f = false;
            for (int i = figures.Count-1; i >= 0; i--)
            {
                if (figures[i].IsPointInside(cursor))
                {
                    selected = i;
                    f = true;
                    break;
                }
            }
            return f;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Brush b = new SolidBrush(Color.White);

            g.FillRectangle(b, 0, 0, this.Width, this.Height);
            listBox1.Items.Clear();
            listBox1.Items.Clear();
            num = 1;
            figures.Clear();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (button2.Text == "цвет рандом выкл")
            {
                button2.Text = "цвет рандом вкл";
            }
            else
            {
                button2.Text = "цвет рандом выкл";
            }
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            g = this.CreateGraphics();

            Redraw(g);
        }

        private void Redraw(Graphics g)
        {

            for (int i = 0; i < figures.Count; i++)
            {
                figures[i].Draw(g);

                g.DrawString(Convert.ToString(i + 1), font, brush, figures[i].center);
            }
        }

        private void Form1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            center.X = e.X;
            center.Y = e.Y;
            if (comboBox1.SelectedIndex == 0)
            {
                int width = r.Next(50, 200);
                int height = width;
                if (button2.Text == "цвет рандом выкл")
                {
                    c = Color.FromArgb(r.Next(0, 255), r.Next(0, 255), r.Next(0, 255));
                }
                else
                {
                    c = Color.Black;
                }


                if (Int32.TryParse(textBox1.Text, out int penwidh))
                {
                    p = new Pen(c, penwidh);
                    rectangle re = new rectangle(width, height, center, p);
                    re.Draw(g);
                    listBox1.Items.Add($"прямоугольник:{num} размер:({width} x {height}) ");
                    g.DrawString(Convert.ToString(num), font, brush, center);
                    num++;
                    figures.Add(re);
                }
                else
                {
                    p = new Pen(c, 5);
                    rectangle re = new rectangle(width, height, center, p);
                    re.Draw(g);
                    listBox1.Items.Add($"прямоугольник:{num} размер:({width} x {height}) ");
                    g.DrawString(Convert.ToString(num), font, brush, center);
                    num++;
                    figures.Add(re);
                }
            }
            else
            {
                int width = r.Next(50, 200);
                int height = width;
                if (button2.Text == "цвет рандом выкл")
                {
                    c = Color.FromArgb(r.Next(0, 255), r.Next(0, 255), r.Next(0, 255));
                }
                else
                {
                    c = Color.Black;
                }


                if (Int32.TryParse(textBox1.Text, out int penwidh))
                {
                    p = new Pen(c, penwidh);
                    Circle ci = new Circle(width, height, center, p);
                    ci.Draw(g);
                    listBox1.Items.Add($"круг:{num} радиус: {width} ");
                    g.DrawString(Convert.ToString(num), font, brush, center);
                    num++;
                    figures.Add(ci);
                }
                else
                {
                    p = new Pen(c, 5);
                    Circle ci = new Circle(width, height, center, p);
                    ci.Draw(g);
                    listBox1.Items.Add($"круг:{num} радиус: {width} ");
                    g.DrawString(Convert.ToString(num), font, brush, center);
                    num++;
                    figures.Add(ci);
                }
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndices.Count != 2)
            {
                MessageBox.Show("Выберете 2 элемента!");
                return;
            }

            int ind1 = listBox1.SelectedIndices[0];
            int ind2 = listBox1.SelectedIndices[1];
            Figure f1 = figures[ind1];
            Figure f2 = figures[ind2];
            Sravn(f1, f2, ind1+1, ind2+1);
        }

        private void Sravn (Figure f1, Figure f2, int fi1, int fi2)
        {
            int project1x = f1.center.X - f1.width/2;
            int project1y = f1.center.Y - f1.height / 2;
            int project2x = f2.center.X - f2.width / 2;
            int project2y = f2.center.Y - f1.height / 2;

            bool flag1 = true;
            bool flag2 = true;
            bool flag3 = true;
            bool flag4 = true;
            bool flag5 = true;

            if (project1x < project2x)
            {
                if(project1x + f1.width < project2x)
                {
                    MessageBox.Show("фигуры не пересекаются");
                    flag1 = false;
                }
            }
            if (project2x < project1x)
            {
                if (project2x + f2.width < project1x)
                {
                    MessageBox.Show("фигуры не пересекаются");
                    flag2 = false;
                }
            }
            if (project1y < project2y)
            {
                if (project1y + f1.height < project2y)
                {
                    MessageBox.Show("фигуры не пересекаются");
                    flag3 = false;
                }
            }
            if (project2y < project1y)
            {
                if (project2y + f2.height < project1y)
                {
                    MessageBox.Show("фигуры не пересекаются");
                    flag4 = false;
                }
            }
            if(project1x > project2x && project1x + f1.width < project2x + f2.width && project1y > project2y && project1y + f1.height < project2y + f2.height)
            {
                MessageBox.Show($"фигура {fi1} находится в фигуре {fi2}");
                flag5 = false;
            }
            if (project1x < project2x && project1x + f1.width > project2x + f2.width && project1y < project2y && project1y + f1.height > project2y + f2.height)
            {
                MessageBox.Show($"фигура {fi2} находится в фигуре {fi1}");
                flag5 = false;
            }
            if (flag1 && flag2 && flag3 && flag4 && flag5)
            {
                MessageBox.Show("фигуры пересекаются");
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control)
            {
                key = true;
                label2.Text = "True";
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            key = false;
            label2.Text = "false";
        }

        private void Button1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control)
            {
                key = true;
                label2.Text = "True";
            }
        }

        private void Button1_KeyUp(object sender, KeyEventArgs e)
        {
            key = false;
            label2.Text = "false";
        }
    }
}
