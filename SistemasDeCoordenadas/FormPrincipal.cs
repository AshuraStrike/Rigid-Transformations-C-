using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

using MathNet.Numerics.LinearAlgebra;
using MathNet.Numerics.LinearAlgebra.Double;

namespace SistemasDeCoordenadas
{
    public partial class FormPrincipal : Form
    {

        Punto puntoInicial;
        Punto puntoFinal;

        Graphics graphicsPanel;
        Brush brush;
        Rectangle rectanglePanel;

        int X_OFFSET;
        int Y_OFFSET;

        List<Punto> listaPuntos;
        List<Punto> listaPuntosO;

        Color alphaBlu;
        Color alphaGreen;
        Color alphaRed;
        Color alphaPurple;
        Color alphaOrange;
        Color alphaMagenta;

        public FormPrincipal()
        {
            InitializeComponent();
            lblCheck.Text = "";
            puntoInicial = new Punto();
            puntoFinal = new Punto();
            graphicsPanel = panel1.CreateGraphics();
            brush = new SolidBrush(Color.White);
            rectanglePanel = new Rectangle(0, 0, panel1.Width, panel1.Height);

            X_OFFSET = panel1.Width / 2;
            Y_OFFSET = panel1.Height / 2;

            listaPuntos = new List<Punto>();
            listaPuntosO = new List<Punto>();

            int intensidad = 70;

            alphaBlu = Color.FromArgb(intensidad, Color.Blue);
            alphaGreen = Color.FromArgb(intensidad, Color.Green);
            alphaRed = Color.FromArgb(intensidad, Color.Red);
            alphaPurple = Color.FromArgb(intensidad, Color.Purple);
            alphaOrange = Color.FromArgb(intensidad, Color.Orange);
            alphaMagenta = Color.FromArgb(intensidad, Color.Magenta);

        }

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            int x = e.X;
            int y = e.Y;

            if (e.Button == MouseButtons.Left)
            {
                puntoInicial.x = x;
                puntoInicial.y = y;
                lblCheck.Text = (x - X_OFFSET) + "," + ((y - Y_OFFSET)*-1);

                DrawPoint(x,y,Color.Red);

                listaPuntosO.Add(new Punto(x - X_OFFSET, (y - Y_OFFSET) * -1));

                listBoxPuntos.Items.Add(lblCheck.Text);
            }

        }

        public void DrawPoint(int x, int y, Color color)
        {
            Graphics g = this.panel1.CreateGraphics();
            SolidBrush pen = new SolidBrush(color);
            if (x < panel1.Width && x > -1 && y < panel1.Height && y > -1)
            {
                g.FillRectangle(pen, x, y, 1, 1);
            }
        }

        public string DDA(Punto inicial, Punto final, Color color)
        {
            TimeSpan timeDDA = new TimeSpan(DateTime.Now.Ticks);

            int x0 = inicial.drawableX(X_OFFSET);
            int y0 = inicial.drawableY(Y_OFFSET);
            int x1 = final.drawableX(X_OFFSET);
            int y1 = final.drawableY(Y_OFFSET);

            int dx = x1 - x0;
            int dy = y1 - y0;

            DrawPoint(x0, y0, Color.FromArgb(50, color));
            if (Math.Abs(dx) > Math.Abs(dy))
            {   // pendiente < 1
                float m = (float)dy / (float)dx;
                float b = y0 - m * x0;
                if (dx < 0)
                    dx = -1;
                else
                    dx = 1;
                while (x0 != x1)
                {
                    x0 += dx;
                    y0 = (int)Math.Round(m * x0 + b);
                    DrawPoint(x0, y0, color);
                }
            }
            else
            if (dy != 0)
            {   //pendiente > 1
                float m = (float)dx / (float)dy;
                float b = x0 - m * y0;
                if (dy < 0)
                    dy = -1;
                else
                    dy = 1;
                while (y0 != y1)
                {
                    y0 += dy;
                    x0 = (int)Math.Round(m * y0 + b);
                    DrawPoint(x0, (y0), color);
                }
            }

            TimeSpan stop = new TimeSpan(DateTime.Now.Ticks);

            return stop.Subtract(timeDDA).TotalMilliseconds.ToString();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = this.panel1.CreateGraphics();
            Pen pen = new Pen(Color.Black);
            g.DrawLine(pen, X_OFFSET, 0, X_OFFSET, panel1.Height);
            g.DrawLine(pen, 0, Y_OFFSET, panel1.Width, Y_OFFSET);
        }

        public void drawFigure(Color color)
        {
            for(int i = 0; i < listaPuntos.Count; i++)
            {
                if (i + 1 == listaPuntos.Count)
                {
                    DDA(listaPuntos[0], listaPuntos[i],color);
                }
                else
                {
                    DDA(listaPuntos[i], listaPuntos[i + 1],color);
                }
            }
        }

        private void buttonDraw_Click(object sender, EventArgs e)
        {
            if (listaPuntosO.Count == 0)
            {
                MessageBox.Show("Elije coordenadas");
            }
            else
            {
                listaPuntos.Clear();
                for (int i = 0; i < listaPuntosO.Count; i++)
                {
                    listaPuntos.Add(new Punto(listaPuntosO[i].x, listaPuntosO[i].y));
                }

                drawFigure(alphaBlu);

                Punto centroide = moverAlCentro();

                drawFigure(alphaGreen);

                rotateFigure();

                drawFigure(alphaRed);

                escalarFigura(Convert.ToSingle(numericUpDownSX.Value), Convert.ToSingle(numericUpDownSY.Value));

                drawFigure(alphaPurple);

                moverAlCentroide(centroide);

                drawFigure(alphaOrange);

                trasladarFigura(new Punto(Convert.ToInt32(numericUpDownTX.Value),Convert.ToInt32(numericUpDownTY.Value)));

                drawFigure(alphaMagenta);
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            listaPuntosO.Clear();
            listaPuntos.Clear();
            panel1.Refresh();
            listBoxPuntos.Items.Clear();
            lblCheck.Text = "";
        }

        Punto moverAlCentro()
        {
            //Traslación al origen
            //Calcular el centroide

            float promedioXF = 0.0f;
            float promedioYF = 0.0f;

            for (int i = 0; i < listaPuntos.Count; i++)
            {
                promedioXF += listaPuntos[i].x;
                promedioYF += listaPuntos[i].y;
            }

            promedioXF = promedioXF / listaPuntos.Count;
            promedioYF = promedioYF / listaPuntos.Count;

            int promedioX = Convert.ToInt32(promedioXF);
            int promedioY = Convert.ToInt32(promedioYF);

            //Dibuja centroide
            DrawPoint(promedioX + X_OFFSET, (promedioY - Y_OFFSET) * -1, Color.Red);

            //Mover al centro

            for (int i = 0; i < listaPuntos.Count; i++)
            {
                listaPuntos[i].x -= promedioX;
                listaPuntos[i].y -= promedioY;
            }

            return new Punto(promedioX,promedioY);
        }

        void moverAlCentroide(Punto centroide)
        {
            //Mover a donde estaba
            for (int i = 0; i < listaPuntos.Count; i++)
            {
                listaPuntos[i].x += centroide.x;
                listaPuntos[i].y += centroide.y;
            }
        }

        public void rotateFigure()
        {
            double grados = Convert.ToDouble(numericUpDownGrados.Value)*Math.PI/180;

            Matrix<double> matrizRotacion = DenseMatrix.OfArray(new double[,]
                {
                    {Math.Cos(grados), -Math.Sin(grados)},
                    {Math.Sin(grados), Math.Cos(grados)}
                });

            for (int i = 0; i < listaPuntos.Count; i++)
            {
                Matrix<double> matrizPunto = DenseMatrix.OfArray(new double[,]
                {
                    {Convert.ToDouble(listaPuntos[i].x),Convert.ToDouble(listaPuntos[i].y)}
                });

                matrizPunto = matrizPunto.Multiply(matrizRotacion);

                listaPuntos[i].x = Convert.ToInt32(matrizPunto[0, 0]);
                listaPuntos[i].y = Convert.ToInt32(matrizPunto[0, 1]);
            }
        }

        public void trasladarFigura(Punto t)
        {
            Matrix<double> matrizTraslacion = DenseMatrix.OfArray(new double[,]
                {
                    {1,0,0},
                    {0,1,0},
                    {t.x,t.y,1}
                });

            for (int i = 0; i < listaPuntos.Count; i++)
            {
                Matrix<double> matrizPunto = DenseMatrix.OfArray(new double[,]
                {
                    {Convert.ToDouble(listaPuntos[i].x),Convert.ToDouble(listaPuntos[i].y),1 }
                });

                matrizPunto = matrizPunto.Multiply(matrizTraslacion);

                listaPuntos[i].x = Convert.ToInt32(matrizPunto[0, 0]);
                listaPuntos[i].y = Convert.ToInt32(matrizPunto[0, 1]);
            }
        }

        public void escalarFigura(float s1,float s2)
        {
            Matrix<double> matrizEscalamiento = DenseMatrix.OfArray(new double[,]
                {
                    {s1,0,0},
                    {0,s2,0},
                    {0,0,1}
                });

            for (int i = 0; i < listaPuntos.Count; i++)
            {
                Matrix<double> matrizPunto = DenseMatrix.OfArray(new double[,]
                {
                    {Convert.ToDouble(listaPuntos[i].x),Convert.ToDouble(listaPuntos[i].y),1 }
                });

                matrizPunto = matrizPunto.Multiply(matrizEscalamiento);

                listaPuntos[i].x = Convert.ToInt32(matrizPunto[0, 0]);
                listaPuntos[i].y = Convert.ToInt32(matrizPunto[0, 1]);
            }
        }

        private void buttonClean_Click(object sender, EventArgs e)
        {
            panel1.Refresh();
        }
    }
}
