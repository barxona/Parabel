using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Mathix.Parabel
{
    public partial class ParabelForm : Form
    {


        private int strich = 32;
        private int pospanely = 169;
        private Point[] parabel = new Point[41];


        public ParabelForm()
        {
            InitializeComponent();
        }

        private void ParabelForm_Load(object sender, EventArgs e)
        {
        }
        private void panel3_Paint(object sender, PaintEventArgs e)
        {   
        }

        private void panel3_Paint_1(object sender, PaintEventArgs e)
        {
            var p = sender as Panel;
            var g = e.Graphics;




            /////////////////////////////////////////////////

            //              Berechnung

            /////////////////////////////////////////////////
            int pointy;
            int pointx = 252;
            double x = -20;

            for (int i = 0; i < 41; i++)
            {

                // X + 100 | Y + 51

                // x^2+x+0 Berechnung
                double xerg = 0;
                xerg = ((x * x) + x + 0) * -1 + pospanely;

                // Für den Y punkt
                pointy = Convert.ToInt32(xerg);
                parabel[i] = new Point(pointx, pointy);

                x = x + 1;
                pointx = pointx + 6;
            }




            /////////////////////////////////////////////////

            //              Zeichnung

            /////////////////////////////////////////////////
            // Keuz
            int posx =504;
            int posy =339;


            Pen pen2 = new Pen(Color.LightGray, 1);
            g.DrawLine(pen2, posx - posx, posy / 2, posx, posy / 2); // X
            g.DrawLine(pen2, posx / 2, posy - posy, posx / 2, posy); // Y
            // Strich Y
            int kreuzy = posy / 2;
            for (int i = 0; i < 40; i++)
            {
                g.DrawLine(pen2, 252 - 6, kreuzy, 252 + 5, kreuzy);
                kreuzy = kreuzy + strich;
            }
            kreuzy = posy / 2;
            for (int i = 0; i < 40; i++)
            {
                g.DrawLine(pen2, 252 - 6, kreuzy, 252 + 5, kreuzy);
                kreuzy = kreuzy - strich;
            }
            // Strich X
            int kreuzx = posx / 2;
            for (int i = 0; i < 40; i++)
            {
                g.DrawLine(pen2, kreuzx, 169 - 6, kreuzx, 169 + 6);
                kreuzx = kreuzx - strich;
            }
            kreuzx = posx / 2;
            for (int i = 0; i < 40; i++)
            {
                g.DrawLine(pen2, kreuzx, 169 - 6, kreuzx, 169 + 6);
                kreuzx = kreuzx + strich;
            }
            // Parabel

            //////////////////////////////////
            //               Farbe für die Parabel               Pen(Color.FARBE, GRÖßE);
            //////////////////////////////////
            Pen pen = new Pen(Color.Blue, 1);
            g.DrawCurve(pen, parabel);
        }
    }
}
