using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;
using Point = System.Windows.Point;

namespace GrafickiPrikazApp
{
    public class Paleta
    {
        private RectangleGeometry rect = new RectangleGeometry();
        private static int selindex = -1;

        public int Sifra { get; set; }
        public string Oznaka { get; set; }
        public string Naziv { get; set; }
        public string JM { get; set; }
        public float Kolicina { get; set; }
        public int Sirina { get; set; }
        public int Visina { get; set; }
        public string Status { get; set; }
        public string BarCod { get; set; }
        public bool Selektovana { get; set; }
        public bool Nadjena { get; set; }
        public System.Windows.Media.Color Boja { get; set; }
        public System.Windows.Media.Color BojaNumeracije { get; set; }
        public int XLevo { get; set; }
        public int YGore { get; set; }
        public Canvas drawingContext { get; set; }
        public float Debljina { get; set; } = 0.5F;
        public int Numeracija { get; set; } = -1;
        public string ID { get; set; }

        public void Crtaj()
        {
            System.Windows.Media.Color BojaStatusa = System.Windows.Media.Color.FromRgb(97,133,148);
            switch(Status)
            {
                case "Puna":
                    BojaStatusa = System.Windows.Media.Color.FromRgb(237, 150, 130);
                    break;
                case "Naceta":
                    BojaStatusa = System.Windows.Media.Color.FromRgb(0, 255, 255);
                    break;
                case "Prazna":
                    BojaStatusa = System.Windows.Media.Color.FromRgb(97, 133, 148);
                    break;
            }
            if(Nadjena == true)
            {
                BojaStatusa = System.Windows.Media.Color.FromRgb(231, 209, 111);
            }
            rect.Rect = new Rect(XLevo, YGore, Sirina, Visina);
            
            Path rectPath = new Path
            {
                Stroke = new SolidColorBrush(Boja),
                StrokeThickness = Debljina,
                Data = rect,
                Fill = new SolidColorBrush(BojaStatusa)
            };
            rectPath.Tag = ID;
            drawingContext.Children.Add(rectPath);

            if (Numeracija > -1)
            {
                Text(XLevo + (Sirina / 3), YGore + (Visina / 4), Numeracija.ToString(), BojaNumeracije);
            }

        }

        public int GetSelIndex()
        {
            return selindex;
        }

        public void CrtajSelekciju()
        {
            int selw = 10;
            int selh = 10;

            RectangleGeometry sel1 = new RectangleGeometry();
            sel1.Rect = new Rect(XLevo - selw, YGore - selh, selw, selh);
            Path sel1path = new Path
            {
                Stroke = new SolidColorBrush(Colors.White),
                StrokeThickness = 1,
                Data = sel1,
                Fill = new SolidColorBrush(Colors.White)
            };
            sel1path.Tag = "Selekted";
            drawingContext.Children.Add(sel1path);
            selindex = drawingContext.Children.Count - 1;

            RectangleGeometry sel2 = new RectangleGeometry();
            sel2.Rect = new Rect(XLevo + Sirina, YGore - selh, selw, selh);
            Path sel2path = new Path
            {
                Stroke = new SolidColorBrush(Colors.White),
                StrokeThickness = 1,
                Data = sel2,
                Fill = new SolidColorBrush(Colors.White)
            };
            sel2path.Tag = "Selekted";
            drawingContext.Children.Add(sel2path);

            RectangleGeometry sel3 = new RectangleGeometry();
            sel3.Rect = new Rect(XLevo - selw, YGore + Visina, selw, selh);
            Path sel3path = new Path
            {
                Stroke = new SolidColorBrush(Colors.White),
                StrokeThickness = 1,
                Data = sel3,
                Fill = new SolidColorBrush(Colors.White)
            };
            sel3path.Tag = "Selekted";
            drawingContext.Children.Add(sel3path);

            RectangleGeometry sel4 = new RectangleGeometry();
            sel4.Rect = new Rect(XLevo + Sirina, YGore + Visina, selw, selh);
            Path sel4path = new Path
            {
                Stroke = new SolidColorBrush(Colors.White),
                StrokeThickness = 1,
                Data = sel4,
                Fill = new SolidColorBrush(Colors.White)
            };
            sel4path.Tag = "Selekted";
            drawingContext.Children.Add(sel4path);
        }

        private void Text(double x, double y, string text, System.Windows.Media.Color color)
        {
            TextBlock textBlock = new TextBlock();
            textBlock.Text = text;
            textBlock.Foreground = new SolidColorBrush(color);
            Canvas.SetLeft(textBlock, x);
            Canvas.SetTop(textBlock, y);
            textBlock.Tag = "Text";
            drawingContext.Children.Add(textBlock);
        }

        public ClickedPallete MisNaPaleti(Point hitPoint,bool Kliknuto)
        {
            ClickedPallete cp = new ClickedPallete();

            if(rect.FillContains(hitPoint) == true && Kliknuto == true)
            {
                cp.Kliked = true;
                cp.ID = ID;
                cp.Naziv = Naziv;
                cp.Oznaka = Oznaka;
                cp.Sifra = Sifra.ToString();
                cp.Kolicina = Kolicina;
                cp.JM = JM;
                cp.Status = Status;
                cp.Selektovana = true;
                Selektovana = true;
                cp.SelIndex = selindex;
                cp.paleta = this;
            }
            else
            {
                cp.Selektovana = false;
                Selektovana = false;
            }

            return cp;
        }
    }
}
