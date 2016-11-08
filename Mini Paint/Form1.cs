using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        Graphics g;
        bool mousedown = false;

        public Form1()
        {
            InitializeComponent();
            g = pictureBox1.CreateGraphics();
            /*if (rbtnNGon.Checked == true)
            {
                txtN.Enabled = true;
            }*/
        }

        /* Proses Cetak ke Steps, X Tambah, Y Tambah, dll...*/
        private void SetTextSteps(string text)
        {
            if (InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetTextSteps);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                this.txtSteps.Text = text;
            }
        }

        private void SetTextX(string text)
        {
            if (InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetTextX);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                this.txtXTambah.Text = text;
            }
        }

        private void SetTextY(string text)
        {
            if (InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetTextY);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                this.txtYTambah.Text = text;
            }
        }

        private void SetTextG(string text)
        {
            if (InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetTextG);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                this.txtGradien.Text = text;
            }
        }

        private void SetTextC(string text)
        {
            if (InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetTextC);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                this.txtC.Text = text;
            }
        }

        private void SetTextJari2(string text)
        {
            if (InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetTextJari2);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                this.txtJari2.Text = text;
            }
        }

        /* ===============================*/

        void PutPixel(int x, int y, Color clr)
        {

            /* using (SolidBrush brush = new SolidBrush(clr))
                g.FillRectangle(brush, x, y, 1, 1);*/

            using (Pen Pen = new Pen(clr))
                g.DrawLine(Pen, Convert.ToInt32(txtXA.Text), Convert.ToInt32(txtYA.Text), x, y);
        }

        private void DDA()
        {
            dx = Convert.ToInt32(txtXB.Text) - Convert.ToInt32(txtXA.Text);
            dy = Convert.ToInt32(txtYB.Text) - Convert.ToInt32(txtYA.Text);
            x = Convert.ToDouble(txtXA.Text);
            y = Convert.ToDouble(txtYA.Text);

            int steps= Math.Max(Math.Abs(dx), Math.Abs(dy));

            double xIncrement = (double)dx / steps;
            double yIncrement = (double)dy / steps;

            SetTextSteps(Convert.ToString(steps));
            SetTextX(Convert.ToString(xIncrement));
            SetTextY(Convert.ToString(yIncrement));

            while (steps > 0)
            {
                PutPixel((int)Math.Floor(x+0.5F), (int)Math.Floor(y + 0.5F), Color.Red);
                x += xIncrement;
                y += yIncrement;
                steps--;
            }
        }

        private void Naive()
        {
            int xAwal, yAwal, xAkhir, yAkhir;

            xAwal = Convert.ToInt32(txtXA.Text);
            yAwal = Convert.ToInt32(txtYA.Text);
            xAkhir = Convert.ToInt32(txtXB.Text);
            yAkhir = Convert.ToInt32(txtYB.Text);

            dx = xAkhir - xAwal;
            dy = yAkhir - yAwal;
            x = (double)xAwal;
            y = (double)yAwal;
            double gradien = (double)dy / dx;
            double c = yAwal - gradien * xAwal;

            SetTextG(Convert.ToString(gradien));
            SetTextC(Convert.ToString(c));

            if (Math.Abs(dx) > Math.Abs(dy))
            {
                int xMulai = Math.Min(xAwal, xAkhir);
                int xSelesai = Math.Max(xAwal, xAkhir);

                for (x = xMulai; x <= xSelesai; x++)
                {
                    y = (gradien * x + c);
                    PutPixel((int)x, (int)y, Color.Black);
                }
            }
            else
            {
                int yStart = Math.Min(yAwal, yAkhir);
                int yEnd = Math.Max(yAwal, yAkhir);

                for (y = yStart; y <= yEnd; y++)
                {
                    if(dx == 0)
                    {
                        x = xAwal;
                    }
                    else
                    {
                        x = ((y - c) / gradien);
                    }

                    PutPixel((int)x, (int)y, Color.Black);
                }
            }
        }

        private void Bresenham()
        {
            dx = Math.Abs(Convert.ToInt32(txtXB.Text) - Convert.ToInt32(txtXA.Text));
            dy = Math.Abs(Convert.ToInt32(txtYB.Text) - Convert.ToInt32(txtYA.Text));

            /*if(Convert.ToInt32(txtXA.Text) > Convert.ToInt32(txtXB.Text))
            {
                x = Convert.ToDouble(txtXB.Text);
                y = Convert.ToDouble(txtYB.Text);
                xEnd = Convert.ToInt32(txtXA.Text);
            }
            else
            {
                x = Convert.ToDouble(txtXA.Text);
                y = Convert.ToDouble(txtYA.Text);
                xEnd = Convert.ToInt32(txtXB.Text);
            }*/
            int xIncrement = Convert.ToInt32(txtXA.Text) < Convert.ToInt32(txtXB.Text) ? 1 : -1;
            int yIncrement = Convert.ToInt32(txtYA.Text) < Convert.ToInt32(txtYB.Text) ? 1 : -1;

            int P = (dx > dy ? dx : -dy) / 2;
            x = Convert.ToInt32(txtXA.Text);
            y = Convert.ToInt32(txtYA.Text);

            while (x != Convert.ToInt32(txtXB.Text) && y != Convert.ToInt32(txtYB.Text))
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
            int xAwal = Convert.ToInt32(txtXA.Text);
            int yAwal = Convert.ToInt32(txtYA.Text);
            int xAkhir = Convert.ToInt32(txtXB.Text);
            int yAkhir = Convert.ToInt32(txtYB.Text);

            int jari2 = (int)Math.Sqrt(Math.Pow(xAkhir - xAwal, 2) + Math.Pow(yAkhir - yAwal, 2));
            SetTextJari2(Convert.ToString(jari2));

            x = 0;
            y = jari2;
            int Pk = 1 - jari2;

            while(x <= y)
            {
                GambarLingkaran((int)x + xAwal, (int)y + yAwal);
                GambarLingkaran(xAwal + ((int)x * -1), (int)y + yAwal);
                GambarLingkaran((int)x + xAwal, yAwal + ((int)y * -1));
                GambarLingkaran(xAwal + ((int)x * -1), yAwal + ((int)y * -1));
                GambarLingkaran((int)y + xAwal, (int)x + yAwal);
                GambarLingkaran(xAwal + ((int)y * -1), (int)x + yAwal);
                GambarLingkaran((int)y + xAwal, yAwal + ((int)x * -1));
                GambarLingkaran(xAwal + ((int)y * -1), yAwal + ((int)x * -1));

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
            /*int xAwal = Convert.ToInt32(txtXA.Text);
            int yAwal = Convert.ToInt32(txtYA.Text);
            int xAkhir = Convert.ToInt32(txtXB.Text);
            int yAkhir = Convert.ToInt32(txtYB.Text);

            int ry = Math.Abs(yAkhir - yAwal);
            int rx = Math.Abs(xAkhir - xAwal);

            x = 0;
            y = ry;

            double P1 = Math.Pow(ry, 2) - Math.Pow(rx, 2) * ry + (0.25 * Math.Pow(rx, 2));
            double P2 = Math.Pow(ry, 2) * Math.Pow((x + 0.5), 2) + Math.Pow(rx, 2) * Math.Pow((y - 1), 2) - Math.Pow(rx, 2) * Math.Pow(ry, 2);

            //Bagian Pertama
            while(2* Math.Pow(ry, 2)*x>2* Math.Pow(rx, 2)*y)
            {
                GambarElips(xAwal + (int)x, yAwal + (int)y);
                GambarElips(xAwal - (int)x, yAwal + (int)y);
                GambarElips(xAwal + (int)x, yAwal - (int)y);
                GambarElips(xAwal - (int)x, yAwal - (int)y);
                if (P1<0)
                {
                    x = x + 1;
                    P1 = P1 + 2 * Math.Pow(ry, 2) * x + Math.Pow(ry, 2);
                }
                else
                {
                    x = x + 1;
                    y = y - 1;
                    P1 = P1 + 2 * (Math.Pow(ry, 2) * x + Math.Pow(ry, 2)) - 2 * (Math.Pow(rx, 2) * y - Math.Pow(rx, 2)) + Math.Pow(ry, 2);
                }
            }

            //Bagian Kedua
            while(y<=0)
            {
                GambarElips(xAwal + (int)x, yAwal + (int)y);
                GambarElips(xAwal - (int)x, yAwal + (int)y);
                GambarElips(xAwal + (int)x, yAwal - (int)y);
                GambarElips(xAwal - (int)x, yAwal - (int)y);
                if (P2>0)
                {
                    y = y - 1;
                    P2 = P2 - 2 * (Math.Pow(rx, 2) * y) + Math.Pow(rx, 2);
                }
                else
                {
                    x = x + 1;
                    y = y - 1;
                    P2 = P2 + 2 * (Math.Pow(ry, 2) * x - 2 * (Math.Pow(rx, 2) * y));
                }
            }*/

            /*int a2 = rx * rx;
            int b2 = ry * ry;
            int fa2 = 4 * a2, fb2 = 4 * b2;
            int sigma = 2 * b2 + a2 * (1 - 2 * ry);

            x = 0;
            y = ry;

            //first half 
            for (x = 0, y = ry, sigma = 2 * b2 + a2 * (1 - 2 * ry); b2 * x <= a2 * y; x++)
            //while(b2 * x <= a2 * y)
            {
                GambarElips(xAwal + (int)x, yAwal + (int)y);
                GambarElips(xAwal - (int)x, yAwal + (int)y);
                GambarElips(xAwal + (int)x, yAwal - (int)y);
                GambarElips(xAwal - (int)x, yAwal - (int)y);
                if (sigma >= 0)
                {
                    sigma += fa2 * (1 - (int)y);
                    y = y - 1;
                }
                sigma += b2 * ((4 * (int)x) + 6);
                //x = x + 1;
            }

            //second half
            for (x = ry, y = 0, sigma = 2 * a2 + b2 * (1 - 2 * ry); a2 * y <= b2 * x; y++)
            {
                GambarElips(xAwal + (int)x, yAwal + (int)y);
                GambarElips(xAwal - (int)x, yAwal + (int)y);
                GambarElips(xAwal + (int)x, yAwal - (int)y);
                GambarElips(xAwal - (int)x, yAwal - (int)y);
                if (sigma >= 0)
                {
                    sigma += fb2 * (1 - (int)x);
                    x--;
                }
                sigma += a2 * ((4 * (int)y) + 6);
            }*/

            double xAwal = Convert.ToDouble(txtXA.Text);
            double yAwal = Convert.ToDouble(txtYA.Text);
            double xAkhir = Convert.ToDouble(txtXB.Text);
            double yAkhir = Convert.ToDouble(txtYB.Text);

            double ry = Math.Abs(yAkhir - yAwal);
            double rx = Math.Abs(xAkhir - xAwal);

            double rxSq = rx * rx;
            double rySq = ry * ry;
            x = 0;
            y = ry;
            double px = 0, py = 2 * rxSq * y, p;

            GambarElips((int)xAwal + (int)x, (int)yAwal + (int)y);
            GambarElips((int)xAwal - (int)x, (int)yAwal + (int)y);
            GambarElips((int)xAwal + (int)x, (int)yAwal - (int)y);
            GambarElips((int)xAwal - (int)x, (int)yAwal - (int)y);

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
                GambarElips((int)xAwal + (int)x, (int)yAwal + (int)y);
                GambarElips((int)xAwal - (int)x, (int)yAwal + (int)y);
                GambarElips((int)xAwal + (int)x, (int)yAwal - (int)y);
                GambarElips((int)xAwal - (int)x, (int)yAwal - (int)y);
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
                GambarElips((int)xAwal + (int)x, (int)yAwal + (int)y);
                GambarElips((int)xAwal - (int)x, (int)yAwal + (int)y);
                GambarElips((int)xAwal + (int)x, (int)yAwal - (int)y);
                GambarElips((int)xAwal - (int)x, (int)yAwal - (int)y);
            }
        }

        private void GambarElips(int x, int y)
        {
            Pen P = new Pen(Color.Purple);
            g.DrawRectangle(P, x, y, 1, 1);
        }

        private void BuatBintang()
        {
            int xAwal = Convert.ToInt32(txtXA.Text);
            int yAwal = Convert.ToInt32(txtYA.Text);
            int xAkhir = Convert.ToInt32(txtXB.Text);
            int yAkhir = Convert.ToInt32(txtYB.Text);

            int jari2 = (int)Math.Sqrt(Math.Pow(xAkhir - xAwal, 2) + Math.Pow(yAkhir - yAwal, 2));
            SetTextJari2(Convert.ToString(jari2));

            int i = 1, n = 5;
            x = Convert.ToDouble(txtXA.Text);
            y = Convert.ToDouble(txtYA.Text);
            double alpha = (2 * Math.PI / n);

            Pen color = new Pen(Color.Brown);
            Point pAwal = new Point();
            Point pAkhir = new Point();
            
            while (i<=n)
            {
                xAwal = (int)x + (int)(jari2 * Math.Cos(alpha * i /*+ Math.PI / n*/));
                yAwal = (int)y + (int)(jari2 * Math.Sin(alpha * i /*+ Math.PI / n*/));

                xAkhir = (int)x + (int)(jari2 * Math.Cos(alpha * (i + 2) /*+ Math.PI / n*/));
                yAkhir = (int)y + (int)(jari2 * Math.Sin(alpha * (i + 2) /*+ Math.PI / n*/));

                pAwal.X = xAwal;
                pAwal.Y = yAwal;
                pAkhir.X = xAkhir;
                pAkhir.Y = yAkhir;

                g.DrawLine(color, pAwal, pAkhir);
                i = i + 1;
            }
        }

        private void BuatNGon()
        {
            int xAwal = Convert.ToInt32(txtXA.Text);
            int yAwal = Convert.ToInt32(txtYA.Text);
            int xAkhir = Convert.ToInt32(txtXB.Text);
            int yAkhir = Convert.ToInt32(txtYB.Text);

            int jari2 = (int)Math.Sqrt(Math.Pow(xAkhir - xAwal, 2) + Math.Pow(yAkhir - yAwal, 2));
            SetTextJari2(Convert.ToString(jari2));

            int i = 1, n = Convert.ToInt32(txtN.Text);
            x = Convert.ToDouble(txtXA.Text);
            y = Convert.ToDouble(txtYA.Text);
            double alpha = (2 * Math.PI / n);

            Pen color = new Pen(Color.Gold);
            Point pAwal = new Point();
            Point pAkhir = new Point();

            while (i <= n)
            {
                xAwal = (int)x + (int)(jari2 * Math.Cos(alpha * i + Math.PI / n));
                yAwal = (int)y + (int)(jari2 * Math.Sin(alpha * i + Math.PI / n));

                xAkhir = (int)x + (int)(jari2 * Math.Cos(alpha * (i + 1) + Math.PI / n));
                yAkhir = (int)y + (int)(jari2 * Math.Sin(alpha * (i + 1) + Math.PI / n));

                pAwal.X = xAwal;
                pAwal.Y = yAwal;
                pAkhir.X = xAkhir;
                pAkhir.Y = yAkhir;

                g.DrawLine(color, pAwal, pAkhir);
                i = i + 1;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            txtXA.Text = Convert.ToString(e.X);
            txtYA.Text = Convert.ToString(e.Y);
            mousedown = true;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mousedown == true)
            {
                txtXB.Text = Convert.ToString(e.X);
                txtYB.Text = Convert.ToString(e.Y);
                g.Clear(Color.White);
                if (rbtnDDA.Checked == true)
                {
                    DDA();
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

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            /*txtXB.Text = Convert.ToString(e.X);
            txtYB.Text = Convert.ToString(e.Y);
            if (rbtnDDA.Checked == true)
            {
                DDA();
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
            }*/
            mousedown = false;
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
    }
}
