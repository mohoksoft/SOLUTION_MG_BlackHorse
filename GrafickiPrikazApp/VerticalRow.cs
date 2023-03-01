using System;
using System.Collections.Generic;
using System.Windows.Media;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows;
using System.Windows.Shapes;

namespace GrafickiPrikazApp
{
    internal class VerticalRow
    {
        private int mMaxPaleta = 4;
        private int mGap = 0;

        public VerticalRow() 
        {
            Palete = new List<Paleta>();
            for(int n= 0;n < mMaxPaleta; n++)
            {
                Paleta paleta = new Paleta();
                Palete.Add(paleta);

                Palete[n].Boja = Color.FromRgb(0, 0, 0);
            }
        }

        public List<Paleta> Palete;

        public Canvas drawingContext { get; set; }
        public int MaxPaleta
        {
            get { return mMaxPaleta; }
            set { mMaxPaleta = value; }
        }
        public int Gap
        {
            get { return mGap; }
            set { mGap = value; }
        }
        public Color BojaOkviraPalete { get; set; }
        public Color BojaOkviraVertikale { get; set; }
        public Color BojaNumeracije { get; set; }
        public int XLevo { get; set; }
        public int YGore { get; set; }
        public int Sirina { get; set; }
        public int Visina { get; set; }
        public bool Okvir { get; set; } = true;
        public float DebljinaOkviraPalete { get; set; } = 0.5F;
        public bool Numeracija { get; set; } = false;
        public string ID { get; set; }

        public ClickedPallete Kliked(Point hitPoint)
        {
            ClickedPallete cp = new ClickedPallete();

            foreach(var p in Palete)
            {
                cp = p.MisNaPaleti(hitPoint, true);
                if (cp.Kliked == true) break;
            }
            return cp;
        }
        public void Crtaj()
        {
            Palete[0].drawingContext = drawingContext;
            Palete[0].XLevo = XLevo;
            Palete[0].YGore = YGore;
            Palete[0].Boja = BojaOkviraPalete;
            Palete[0].BojaNumeracije = BojaNumeracije;
            Palete[0].Debljina = DebljinaOkviraPalete;
            Palete[0].Sirina = (Sirina / 2) - (mGap / 2);
            Palete[0].Visina = Visina/2;
            Palete[0].ID = ID + "P1";
            if (Numeracija == true) Palete[0].Numeracija = 1; 
            Palete[0].Crtaj();

            Palete[1].drawingContext = drawingContext;
            Palete[1].XLevo = XLevo + (Sirina / 2) + (mGap / 2);
            Palete[1].YGore = YGore;
            Palete[1].Boja = BojaOkviraPalete;
            Palete[1].BojaNumeracije = BojaNumeracije;
            Palete[1].Debljina = DebljinaOkviraPalete;
            Palete[1].Sirina = (Sirina / 2) - (mGap / 2);
            Palete[1].Visina = Visina/2;
            Palete[1].ID = ID + "P2";
            if (Numeracija == true) Palete[1].Numeracija = 2;
            Palete[1].Crtaj();

            Palete[2].drawingContext = drawingContext;
            Palete[2].XLevo = XLevo;
            Palete[2].Boja = BojaOkviraPalete;
            Palete[2].BojaNumeracije = BojaNumeracije;
            Palete[2].Debljina = DebljinaOkviraPalete;
            Palete[2].YGore = YGore + (Visina / 2) + (mGap / 2);
            Palete[2].Sirina = (Sirina / 2) - (mGap / 2);
            Palete[2].Visina = Visina / 2;
            Palete[2].ID = ID + "P3";
            if (Numeracija == true) Palete[2].Numeracija = 3;
            Palete[2].Crtaj();

            Palete[3].drawingContext = drawingContext;
            Palete[3].XLevo = XLevo + (Sirina / 2) + (mGap / 2);
            Palete[3].YGore = YGore + (Visina / 2) + (mGap / 2);
            Palete[3].Boja = BojaOkviraPalete;
            Palete[3].BojaNumeracije = BojaNumeracije;
            Palete[3].Debljina = DebljinaOkviraPalete;
            Palete[3].Sirina = (Sirina / 2) - (mGap / 2);
            Palete[3].Visina = Visina / 2;
            Palete[3].ID = ID + "P4";
            if (Numeracija == true) Palete[3].Numeracija = 4;
            Palete[3].Crtaj();

            if(Okvir == true)
            {
                RectangleGeometry rect = new RectangleGeometry();
                rect.Rect = new Rect(XLevo, YGore, Sirina, Visina);
                Path rectPath = new Path
                {
                    Stroke = new SolidColorBrush(BojaOkviraVertikale),
                    StrokeThickness = DebljinaOkviraPalete,
                    Data = rect
                };
                rectPath.Tag = "Okvir";
                drawingContext.Children.Add(rectPath);
            }
        }
    }
}
