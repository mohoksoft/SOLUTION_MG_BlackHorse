using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.RightsManagement;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace GrafickiPrikazApp
{
    internal class Segment
    {
        private int mMaxVertikala = 3;
        public List<VerticalRow> Vertikale; 
        public Segment() 
        {
            Vertikale = new List<VerticalRow>();

            for(int n = 0;n < mMaxVertikala;n++)
            {
                VerticalRow v = new VerticalRow();
                Vertikale.Add(v);
            }
        }
        public Color BojaOkvira { get; set; }
        public Color BojaOkviraVertikale { get; set; }
        public Color BojaOkviraPalete { get; set; }
        public Color BojaNumeracije { get; set; }
        public int Sirina { get; set; }
        public int Visina { get; set; }
        public int XLevo { get; set; }
        public int YGore { get; set; }
        public float DebljinaOkvira { get; set; } = 2F;
        public int GapPalete { get; set; } = 0;
        public bool OkvirPalete { get; set; } = false;
        public float DebljinaOkviraPalete { get; set; } = 2F;
        public int MaxVertikala
        {
            get { return mMaxVertikala; }
            set { mMaxVertikala = value; }
        }
        public Canvas drawingContext { get; set; }
        public bool Numeracija { get; set; } = true;
        public string ID { get; set; } = "";

        public ClickedPallete Kliked(Point hitPoint)
        {
            ClickedPallete cp = new ClickedPallete();

            foreach (var p in Vertikale)
            {
                cp = p.Kliked(hitPoint);
                if (cp.Kliked == true) break;
            }
            return cp;
        }

        public void Crtaj()
        {
            Vertikale[0].XLevo = XLevo;
            Vertikale[0].YGore = YGore;
            Vertikale[0].drawingContext = drawingContext;
            Vertikale[0].Sirina = Sirina / mMaxVertikala;
            Vertikale[0].Visina = Visina;
            Vertikale[0].BojaOkviraVertikale = BojaOkviraVertikale;
            Vertikale[0].BojaOkviraPalete = BojaOkviraPalete;
            Vertikale[0].BojaNumeracije = BojaNumeracije;
            Vertikale[0].DebljinaOkviraPalete = DebljinaOkviraPalete;
            Vertikale[0].Numeracija = Numeracija;
            Vertikale[0].ID = ID + "V1";
            Vertikale[0].Crtaj();

            Vertikale[1].XLevo = XLevo + (Sirina / mMaxVertikala);
            Vertikale[1].YGore = YGore;
            Vertikale[1].drawingContext = drawingContext;
            Vertikale[1].Sirina = Sirina / mMaxVertikala;
            Vertikale[1].Visina = Visina;
            Vertikale[1].BojaOkviraVertikale = BojaOkviraVertikale;
            Vertikale[1].BojaOkviraPalete = BojaOkviraPalete;
            Vertikale[1].BojaNumeracije = BojaNumeracije;
            Vertikale[1].DebljinaOkviraPalete = DebljinaOkviraPalete;
            Vertikale[1].Numeracija = Numeracija;
            Vertikale[1].ID = ID + "V2";
            Vertikale[1].Crtaj();

            Vertikale[2].XLevo = XLevo + (2 * (Sirina / mMaxVertikala));
            Vertikale[2].YGore = YGore;
            Vertikale[2].drawingContext = drawingContext;
            Vertikale[2].Sirina = Sirina / mMaxVertikala;
            Vertikale[2].Visina = Visina;
            Vertikale[2].BojaOkviraVertikale = BojaOkviraVertikale;
            Vertikale[2].BojaOkviraPalete = BojaOkviraPalete;
            Vertikale[2].BojaNumeracije = BojaNumeracije;
            Vertikale[2].DebljinaOkviraPalete = DebljinaOkviraPalete;
            Vertikale[2].Numeracija = Numeracija;
            Vertikale[2].ID = ID + "V3";
            Vertikale[2].Crtaj();

            RectangleGeometry rect = new RectangleGeometry();
            rect.Rect = new Rect(XLevo, YGore, Sirina, Visina);
            Path rectPath = new Path
            {
                Stroke = new SolidColorBrush(BojaOkvira),
                StrokeThickness = DebljinaOkvira,
                Data = rect
            };
            rectPath.Tag = "Segemnt";
            drawingContext.Children.Add(rectPath);
        }
    }
}
