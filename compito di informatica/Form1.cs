using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace compito_di_informatica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int diametro = this.ClientSize.Height - 20;
            int raggio = diametro / 2;
            int xc = this.ClientSize.Width / 2;
            int yc = this.ClientSize.Height / 2;

            //CENTRO
            Graphics c = this.CreateGraphics();
            c.FillEllipse(Brushes.Black, xc - 5, yc - 5, 50, 50);
            //SBIANCAMENTO
            Graphics g = this.CreateGraphics();
            g.Clear(Color.White);

            //CIRCONFERENZA
            Pen spessore = new Pen(Color.Black, 4);
            Graphics crf = this.CreateGraphics();
            crf.DrawEllipse(spessore, xc - raggio, yc - raggio, diametro, diametro);

            //ACQUISIZIONE ORA
            DateTime adesso = DateTime.Now;
            int minuti = adesso.Minute;
            int ore = adesso.Hour;
            int secondi = adesso.Second;
            if (ore > 12)
            {
                ore = ore - 12;
            }

            //ORE
            double ore2 = (minuti / 60) + (secondi / 3600);
            double alpha = -((ore) * (Math.PI / 6));
            double beta = (alpha + Math.PI / 2);
            int px = xc + (int)((raggio - 150) * Math.Cos(beta + ore2));
            int py = yc - (int)((raggio - 150) * Math.Sin(beta + ore2));
            Pen spessoreore = new Pen(Color.Black, 3);
            Graphics lancettaore = this.CreateGraphics();
            lancettaore.DrawLine(spessoreore, xc, yc, px, py);

            //MINUTI
            double minuti2 = secondi / 60;
            double alpha2 = -(minuti * (Math.PI / 30));
            double gamma = (alpha2 + Math.PI / 2);
            int px2 = xc + (int)((raggio - 100) * Math.Cos(gamma + minuti2));
            int py2 = yc - (int)((raggio - 100) * Math.Sin(gamma + minuti2));
            Pen spessoreminuti = new Pen(Color.Black, 2);
            Graphics lancettaminuti = this.CreateGraphics();
            lancettaminuti.DrawLine(spessoreminuti, xc, yc, px2, py2);

            //SECONDI
            double alpha3 = -(secondi * (Math.PI / 30));
            double teta = (alpha3 + Math.PI / 2);
            int px3 = xc + (int)((raggio - 50) * Math.Cos(teta));
            int py3 = yc - (int)((raggio - 50) * Math.Sin(teta));
            Pen spessoresecondi = new Pen(Color.Black, 1);
            Graphics lancettasecondi = this.CreateGraphics();
            lancettasecondi.DrawLine(spessoresecondi, xc, yc, px3, py3);

            //NUMERO12
            Graphics n = this.CreateGraphics();
            string numero = "12";
            Font font = new Font("Arial", 18);
            Brush brush = Brushes.Black;
            PointF posizione = new PointF(xc - 15, (yc - 10) - (raggio - 10));
            n.DrawString(numero, font, brush, posizione);

            //NUMERO3
            Graphics n2 = this.CreateGraphics();
            string numero2 = "3";
            Font font2 = new Font("Arial", 18);
            Brush brush2 = Brushes.Black;
            PointF posizione2 = new PointF((xc + raggio - 20), yc - 10);
            n2.DrawString(numero2, font2, brush2, posizione2);

            //NUMERO6
            Graphics n3 = this.CreateGraphics();
            string numero3 = "6";
            Font font3 = new Font("Arial", 18);
            Brush brush3 = Brushes.Black;
            PointF posizione3 = new PointF(xc - 5, (yc - 10) + (raggio - 15));
            n3.DrawString(numero3, font3, brush3, posizione3);

            //NUMERO9
            Graphics n4 = this.CreateGraphics();
            string numero4 = "9";
            Font font4 = new Font("Arial", 18);
            Brush brush4 = Brushes.Black;
            PointF posizione4 = new PointF(xc - raggio, yc - 10);
            n4.DrawString(numero4, font4, brush4, posizione4);

            //RETTANGOLO-DATA
            Pen spessorerettangolo = new Pen(Color.Black, 1);
            Graphics rettangolo = this.CreateGraphics();
            rettangolo.DrawRectangle(spessorerettangolo, xc + (raggio / 2), yc, 35, 15);

            //DATA
            Graphics n5 = this.CreateGraphics();
            int giorno = adesso.Day;
            int mese = adesso.Month;
            string data = giorno + "/" + mese;
            Font font5 = new Font("Arial", 10);
            Brush brush5 = Brushes.Black;
            PointF posizione5 = new PointF((xc + (raggio / 2)), yc);
            n5.DrawString(data, font5, brush5, posizione5);
        }
    }
}
