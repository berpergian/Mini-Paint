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
using System.Threading;

namespace Mini_Paint
{
    public partial class Form1 : Form
    {
        delegate void SetTextCallback(string text);

        int dx,dy;
        double x,y;
        Point tstart, tend, tpusat,InputStart,InputEnd;
        Graphics g;
        Bitmap bmp = new Bitmap(725, 258);
        Color warna;
        bool mousedown = false;

        public Form1()
        {
            InitializeComponent();
            //g = pictureBox1.CreateGraphics();
            g = Graphics.FromImage(bmp);
        }

        /* ==============================*/

        void PutPixel(int x, int y, Color clr)
        {
            using (Pen Pen = new Pen(clr))
                g.DrawLine(Pen, tstart.X, tstart.Y, x, y);
        }

        void DrawNew()
        {
            g.Clear(Color.White);
            if (rbtnDDA.Checked == true)
            {
                DDA(tstart,tend);
            }
            else if (rbtnNaive.Checked == true)
            {
                Naive();
            }
            else if (rbtnBresenham.Checked == true)
            {
                Bresenham();
            }
            else if (rbtnLingkaran.Checked == true)
            {
                BuatLingkaran();
            }
            else if (rbtnElips.Checked == true)
            {
                BuatElips();
            }
            else if (rbtnBintang.Checked == true)
            {
                BuatBintang();
            }
            else if (rbtnNGon.Checked == true)
            {
                BuatNGon();
            }
        }

        private void DrawTPusat()
        {
            InputStart.X = tpusat.X;
            InputStart.Y = 0;
            InputEnd.X = tpusat.X;
            InputEnd.Y = tpusat.Y * 2;
            DDA(InputStart,InputEnd);

            InputStart.X = 0;
            InputStart.Y = tpusat.Y;
            InputEnd.X = tpusat.X * 2;
            InputEnd.Y = tpusat.Y;
            DDA(InputStart, InputEnd);
        }

        private void DoTransformation(Matrix M)
        {
            Point[] points = { new Point(tstart.X - tpusat.X,tpusat.Y - tstart.Y),
                               new Point(tend.X - tpusat.X,tpusat.Y - tend.Y) };
            M.TransformVectors(points);
            tstart = new Point(points[0].X + tpusat.X, tpusat.Y - points[0].Y);
            tend = new Point(points[1].X + tpusat.X, tpusat.Y - points[1].Y);
            DrawNew();
        }
        /* ==============================*/
        /*==================== Shape =====================*/
        private void DDA(Point A, Point B)
        {
            dx = B.X - A.X;
            dy = B.Y - A.Y;
            x = Convert.ToDouble(A.X);
            y = Convert.ToDouble(A.Y);
            warna = Color.Black;

            int steps = Math.Max(Math.Abs(dx), Math.Abs(dy));

            double xIncrement = (double)dx / steps;
            double yIncrement = (double)dy / steps;


            while (steps > 0)
            {
                PutPixel((int)Math.Floor(x+0.5F), (int)Math.Floor(y + 0.5F), warna);
                x += xIncrement;
                y += yIncrement;
                steps--;
            }
        }

        private void Naive()
        {
            dx = tend.X - tstart.X;
            dy = tend.Y - tstart.Y;
            x = Convert.ToDouble(tstart.X);
            y = Convert.ToDouble(tstart.Y);

            double gradien = (double)dy / dx;
            double c = tstart.Y - gradien * tstart.X;

            if (Math.Abs(dx) > Math.Abs(dy))
            {
                int xMulai = Math.Min(tstart.X, tend.X);
                int xSelesai = Math.Max(tstart.X, tend.X);

                for (x = xMulai; x <= xSelesai; x++)
                {
                    y = (gradien * x + c);
                    PutPixel((int)x, (int)y, Color.Red);
                }
            }
            else
            {
                int yStart = Math.Min(tstart.Y, tend.Y);
                int yEnd = Math.Max(tstart.Y, tend.Y);

                for (y = yStart; y <= yEnd; y++)
                {
                    if(dx == 0)
                    {
                        x = tstart.X;
                    }
                    else
                    {
                        x = ((y - c) / gradien);
                    }

                    PutPixel((int)x, (int)y, Color.Red);
                }
            }
        }

        private void Bresenham()
        {
            dx = Math.Abs(tend.X - tstart.X);
            dy = Math.Abs(tend.Y - tstart.Y);

            int xIncrement = tstart.X < tend.X ? 1 : -1;
            int yIncrement = tstart.Y < tend.Y ? 1 : -1;

            int P = (dx > dy ? dx : -dy) / 2;
            x = tstart.X;
            y = tstart.Y;

            while (x != tend.X && y != tend.Y)
            {
                PutPixel((int)x, (int)y, Color.Blue);
                if(P > -dx)
                {
                    P -= dy;
                    x += xIncrement;
                }
                if(P < dy)
                {
                    P += dx;
                    y += yIncrement;
                }
            }
        }

        private void BuatLingkaran()
        {
            int jari2 = (int)Math.Sqrt(Math.Pow(tend.X - tstart.X, 2) + Math.Pow(tend.Y - tstart.Y, 2));

            x = 0;
            y = jari2;
            int Pk = 1 - jari2;

            while(x <= y)
            {
                GambarLingkaran((int)x + tstart.X, (int)y + tstart.Y);
                GambarLingkaran(tstart.X + ((int)x * -1), (int)y + tstart.Y);
                GambarLingkaran((int)x + tstart.X, tstart.Y + ((int)y * -1));
                GambarLingkaran(tstart.X + ((int)x * -1), tstart.Y + ((int)y * -1));
                GambarLingkaran((int)y + tstart.X, (int)x + tstart.Y);
                GambarLingkaran(tstart.X + ((int)y * -1), (int)x + tstart.Y);
                GambarLingkaran((int)y + tstart.X, tstart.Y + ((int)x * -1));
                GambarLingkaran(tstart.X + ((int)y * -1), tstart.Y + ((int)x * -1));

                if (Pk<0)
                {
                    Pk = Pk + (2 * (int)x + 2 + 1);
                }
                else
                {
                    Pk = Pk + (2 * (int)x + 2 + 1) - (2 * (int)y - 2);
                    y--;
                }
                x++;
            }
        }

        private void GambarLingkaran(int x, int y)
        {
            Pen P = new Pen(Color.Green);
            g.DrawRectangle(P, x, y, 1, 1);
        }

        private void BuatElips()
        {
            double ry = Math.Abs(Convert.ToDouble(tend.Y - tstart.Y));
            double rx = Math.Abs(Convert.ToDouble(tend.X - tstart.X));

            double rxSq = rx * rx;
            double rySq = ry * ry;
            x = 0;
            y = ry;
            double px = 0, py = 2 * rxSq * y, p;

            GambarElips(tstart.X + (int)x, tstart.Y + (int)y);
            GambarElips(tstart.X - (int)x, tstart.Y + (int)y);
            GambarElips(tstart.X + (int)x, tstart.Y - (int)y);
            GambarElips(tstart.X - (int)x, tstart.Y - (int)y);

            //Region 1
            p = rySq - (rxSq * ry) + (0.25 * rxSq);
            while (px < py)
            {
                x++;
                px = px + 2 * rySq;
                if (p < 0)
                    p = p + rySq + px;
                else
                {
                    y--;
                    py = py - 2 * rxSq;
                    p = p + rySq + px - py;
                }
                GambarElips(tstart.X + (int)x, tstart.Y + (int)y);
                GambarElips(tstart.X - (int)x, tstart.Y + (int)y);
                GambarElips(tstart.X + (int)x, tstart.Y - (int)y);
                GambarElips(tstart.X - (int)x, tstart.Y - (int)y);
            }

            //Region 2
            p = rySq * (x + 0.5) * (x + 0.5) + rxSq * (y - 1) * (y - 1) - rxSq * rySq;
            while (y > 0)
            {
                y--;
                py = py - 2 * rxSq;
                if (p > 0)
                    p = p + rxSq - py;
                else
                {
                    x++;
                    px = px + 2 * rySq;
                    p = p + rxSq - py + px;
                }
                GambarElips(tstart.X + (int)x, tstart.Y + (int)y);
                GambarElips(tstart.X - (int)x, tstart.Y + (int)y);
                GambarElips(tstart.X + (int)x, tstart.Y - (int)y);
                GambarElips(tstart.X - (int)x, tstart.Y - (int)y);
            }
        }

        private void GambarElips(int x, int y)
        {
            Pen P = new Pen(Color.Purple);
            g.DrawRectangle(P, x, y, 1, 1);
        }

        private void BuatBintang()
        {
            Point A = tstart;
            Point B = tend;
            int jari2 = (int)Math.Sqrt(Math.Pow(B.X - A.X, 2) + Math.Pow(B.Y - A.Y, 2));

            int i = 1, n = 5;
            x = Convert.ToDouble(A.X);
            y = Convert.ToDouble(A.Y);
            double alpha = (2 * Math.PI / n);

            Pen color = new Pen(Color.Brown);
            /*Point pAwal = new Point();
            Point pAkhir = new Point();*/
            
            while (i<=n)
            {
                A.X = (int)x + (int)(jari2 * Math.Cos(alpha * i /*+ Math.PI / n*/));
                A.Y = (int)y + (int)(jari2 * Math.Sin(alpha * i /*+ Math.PI / n*/));

                B.X = (int)x + (int)(jari2 * Math.Cos(alpha * (i + 2) /*+ Math.PI / n*/));
                B.Y = (int)y + (int)(jari2 * Math.Sin(alpha * (i + 2) /*+ Math.PI / n*/));

                /*pAwal.X = tstart.X;
                pAwal.Y = tstart.Y;
                pAkhir.X = tend.X;
                pAkhir.Y = tend.Y;*/

                g.DrawLine(color, A, B);
                i = i + 1;
            }
        }

        private void BuatNGon()
        {
            Point A = tstart;
            Point B = tend;
            int jari2 = (int)Math.Sqrt(Math.Pow(B.X - A.X, 2) + Math.Pow(B.Y - A.Y, 2));

            int i = 1, n = Convert.ToInt32(txtN.Text);
            x = Convert.ToDouble(A.X);
            y = Convert.ToDouble(A.Y);
            double alpha = (2 * Math.PI / n);

            Pen color = new Pen(Color.Gold);
            /*Point pAwal = new Point();
            Point pAkhir = new Point();*/

            while (i <= n)
            {
                A.X = (int)x + (int)(jari2 * Math.Cos(alpha * i + Math.PI / n));
                A.Y = (int)y + (int)(jari2 * Math.Sin(alpha * i + Math.PI / n));

                B.X = (int)x + (int)(jari2 * Math.Cos(alpha * (i + 1) + Math.PI / n));
                B.Y = (int)y + (int)(jari2 * Math.Sin(alpha * (i + 1) + Math.PI / n));

                /*pAwal.X = tstart.X;
                pAwal.Y = tstart.Y;
                pAkhir.X = tend.X;
                pAkhir.Y = tend.Y;*/

                g.DrawLine(color, A, B);
                i = i + 1;
            }
        }
        /*===============================================*/
        /*===============================================*/
        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            tpusat.X = pictureBox1.Width / 2;
            tpusat.Y = pictureBox1.Height / 2;
            txtXA.Text = Convert.ToString(e.X - tpusat.X);
            txtYA.Text = Convert.ToString(tpusat.Y - e.Y);
            tstart.X = e.X;
            tstart.Y = e.Y;
            mousedown = true;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mousedown == true)
            {
                txtXB.Text = Convert.ToString(e.X - tpusat.X);
                txtYB.Text = Convert.ToString(tpusat.Y - e.Y);
                tend.X = e.X;
                tend.Y = e.Y;
                //g.Clear(Color.White);
                Refresh();
                if (rbtnDDA.Checked == true)
                {
                    DDA(tstart,tend);
                }
                else if (rbtnNaive.Checked == true)
                {
                    Naive();
                }
                else if (rbtnBresenham.Checked == true)
                {
                    Bresenham();
                }
                else if (rbtnLingkaran.Checked == true)
                {
                    BuatLingkaran();
                }
                else if (rbtnElips.Checked == true)
                {
                    BuatElips();
                }
                else if (rbtnBintang.Checked == true)
                {
                    BuatBintang();
                }
                else if (rbtnNGon.Checked == true)
                {
                    BuatNGon();
                }
            }
        }
        /*===============================================*/

        /*================= Transformation ==============*/


        private void btnTranslate_Click(object sender, EventArgs e)
        {
            Point[] points = { new Point(tstart.X - tpusat.X,tpusat.Y - tstart.Y),
                               new Point(tend.X - tpusat.X,tpusat.Y - tend.Y) };

            Point A = new Point(points[0].X + Convert.ToInt32(txtDeltaX.Text), 
                                points[0].Y + Convert.ToInt32(txtDeltaY.Text));
            Point B = new Point(points[1].X + Convert.ToInt32(txtDeltaX.Text),
                                points[1].Y + Convert.ToInt32(txtDeltaY.Text));
            //MessageBox.Show(Convert.ToString(A), Convert.ToString(B));
            txtXA.Text = Convert.ToString(A.X);
            txtYA.Text = Convert.ToString(A.Y);
            txtXB.Text = Convert.ToString(B.X);
            txtYB.Text = Convert.ToString(B.Y);
            tstart = new Point(A.X + tpusat.X, tpusat.Y - A.Y);
            tend = new Point(B.X + tpusat.X, tpusat.Y - B.Y);
            DrawNew();
        }

        private void btnScale_Click(object sender, EventArgs e)
        {
            Matrix Scale = new Matrix(float.Parse(txtScale.Text), 0, 0, float.Parse(txtScale.Text), 0, 0);
            DoTransformation(Scale);
            //MessageBox.Show(Convert.ToString(tstart), Convert.ToString(tend));
        }

        private void btnRotate_Click(object sender, EventArgs e)
        {
            Matrix Rotate = new Matrix((float)Math.Cos(float.Parse(txtRotate.Text) / 360 * 2 * Math.PI),
                                        (float)Math.Sin(float.Parse(txtRotate.Text) / 360 * 2 * Math.PI),
                                       -(float)Math.Sin(float.Parse(txtRotate.Text) / 360 * 2 * Math.PI),
                                        (float)Math.Cos(float.Parse(txtRotate.Text) / 360 * 2 * Math.PI),
                                        0, 0);
            DoTransformation(Rotate);
        }

        private void btnReflectX_Click(object sender, EventArgs e)
        {
            Matrix Reflexsi = new Matrix(1, 0, 0, -1, 0, 0);
            DoTransformation(Reflexsi);
        }

        private void btnReflectY_Click(object sender, EventArgs e)
        {
            Matrix Reflexsi = new Matrix(-1, 0, 0, 1, 0, 0);
            DoTransformation(Reflexsi);
        }

        private void btnReflectYX_Click(object sender, EventArgs e)
        {
            Matrix Reflexsi = new Matrix(0, 1, 1, 0, 0, 0);
            DoTransformation(Reflexsi);
        }

        private void btnReflectYminX_Click(object sender, EventArgs e)
        {
            Matrix Reflexsi = new Matrix(0, -1, -1, 0, 0, 0);
            DoTransformation(Reflexsi);
        }

        private void btnShearing_Click(object sender, EventArgs e)
        {
            Point[] points = { new Point(tstart.X - tpusat.X,tpusat.Y - tstart.Y),
                               new Point(tend.X - tpusat.X,tpusat.Y - tend.Y) };
            Point A = new Point(points[0].X + (Convert.ToInt32(txtShX.Text)*points[0].Y), 
                                (Convert.ToInt32(txtShY.Text)*points[0].X)+points[0].Y);
            Point B = new Point(points[1].X + (Convert.ToInt32(txtShX.Text) * points[1].Y),
                                (Convert.ToInt32(txtShY.Text) * points[1].X) + points[1].Y);

            txtXA.Text = Convert.ToString(A.X);
            txtYA.Text = Convert.ToString(A.Y);
            txtXB.Text = Convert.ToString(B.X);
            txtYB.Text = Convert.ToString(B.Y);
            tstart = new Point(A.X + tpusat.X, tpusat.Y - A.Y);
            tend = new Point(B.X + tpusat.X, tpusat.Y - B.Y);
            DrawNew();
        }

        /*===============================================*/
        /*=================== Mewarnai ==================*/

        private void BoundaryFill()
        {

        }

        private void FloodFill(int x, int y, Color oldcolor, Color newcolor)
        {
            //Bitmap image = new Bitmap(pictureBox1.Image);

            /*if (image.GetPixel(x, y) == oldcolor)
            {
                image.SetPixel(x, y, newcolor);
                FloodFill(x + 1, y, oldcolor, newcolor);
                FloodFill(x, y + 1, oldcolor, newcolor);
                FloodFill(x - 1, y, oldcolor, newcolor);
                FloodFill(x, y - 1, oldcolor, newcolor);
            }
            pictureBox1.Image = image;*/
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            //DrawTPusat();
        }

        private void btnWarnai_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(pictureBox1.ClientSize.Width, pictureBox1.Height);
            //FloodFill(tstart.X, tstart.Y,Color.White,fill);
        }

        /*===============================================*/
        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            if(colorDialog.ShowDialog() == DialogResult.OK)
            {
                btnColor.BackColor = colorDialog.Color;
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            mousedown = false;
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
    }
}
