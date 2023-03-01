using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Forms.Integration;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Shapes;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Color = System.Windows.Media.Color;
using Point = System.Windows.Point;

namespace GrafickiPrikazApp
{
    public class WareHouse
    {
        public WareHouse() 
        {
            
            
        }

        List<Segment> Segmenti = new List<Segment>();

        // Apsolutne vrednosti u metrima
        private float SirinaSegmenta = 2.8F;
        private float VisinaSegmenta = 1.5F;
        private float DesnaLProlaza = 23.61F;
        private float CentarProlaza = 22.36F;
        private float LevaLProlaza = 21.01F;
        private float VertRazmakSegmenata = 2.7F;
        private PointF GoreLevoA2 = new PointF(12.065F,0.5F);
        private PointF GoreLevoA3 = new PointF(23.944F, 0.5F);
        private float RazmakOdProlaza = 0.434F;

        // Koordinate u pixelima
        private float XLevaLinijaProlaza;
        private float XDesnaLinijaProlaza;
        private float XCentralnaLinijaProlaza;
        private PointF Okvir1GoreLevo = new PointF(7, 15);
        private PointF Okvir2GoreLevo = new PointF(10, 20);
        private PointF Okvir1DoleDesno;
        private PointF Okvir2DoleDesno;
        private float SirinaSegmentaPix;
        private float VisinaSegmentaPix;
        private PointF SPA2;
        private PointF SPA3;
        private float ProlazGap;
        private float VertGapSegmenata;
        private int TopOffset = 25;

        public void show()
        {
            MainWindow mw = new MainWindow();
            ElementHost.EnableModelessKeyboardInterop(mw);
            mw.Show();
        }

        public Canvas drawingContext { get; set; }
        ClickedPallete cp = new ClickedPallete();

        /// <summary>
        /// Apsolutna sirina u m
        /// </summary>
        public float Sirina { get; set; } = 30;

        /// <summary>
        /// Apsolutna duzina u m
        /// </summary>
        public float Duzina { get; set; } = 25;

        public float DebljinaOkvira { get; set; } = 1F;
        public Color BojaOkviraVertikale { get; set; }
        public Color BojaOkviraPalete { get; set; }
        public Color BojaOkviraSegmenta { get; set; }
        public Color BojaNumeracije { get; set; }
        public bool OkvirPalete { get; set; } = true;
        public bool Numeracija { get; set; } = true;
        public float DebljinaOkviraPalete { get; set; } = 1F;
        public float DebljinaOkviraSegmenta { get; set; } = 1F;

        public void SetPalet(string ID,int Sifra,string Naziv,string Oznaka,string JM,float Kolicina,string Status)
        {
            string[] delovi = ID.Split('V');
            string vertikala = ID.Split('P')[0];
            foreach(var s in Segmenti)
            {
                if(s.ID == delovi[0])
                {
                    foreach(var v in s.Vertikale)
                    {
                        if(v.ID == vertikala)
                        {
                            foreach(var p in v.Palete)
                            {
                                if(p.ID == ID)
                                {
                                    p.Sifra = Sifra;
                                    p.Naziv = Naziv;
                                    p.Oznaka = Oznaka;
                                    p.JM = JM;
                                    p.Kolicina = Kolicina;
                                    p.Status = Status;
                                    if (Status == "Prazna") p.Nadjena = false;
                                    //Refresh();
                                }
                            }
                        }
                    }
                }
            }
        }

        public void SetPaletFinded(string ID)
        {
            string[] delovi = ID.Split('V');
            string vertikala = ID.Split('P')[0];
            foreach (var s in Segmenti)
            {
                if (s.ID == delovi[0])
                {
                    foreach (var v in s.Vertikale)
                    {
                        if (v.ID == vertikala)
                        {
                            foreach (var p in v.Palete)
                            {
                                if (p.ID == ID)
                                {
                                    p.Nadjena = true;
                                }
                            }
                        }
                    }
                }
            }
        }

        public void ResetFinded()
        {
            foreach (var s in Segmenti)
            {
                foreach (var v in s.Vertikale)
                {
                    foreach (var p in v.Palete)
                    {
                        p.Nadjena = false;
                    }
                }
            }
        }

        public List<string> DajPaletePoSifri(int sifra)
        {
            List<string> resp = new List<string>();

            foreach (var s in Segmenti)
            {
                foreach (var v in s.Vertikale)
                {
                    foreach (var p in v.Palete)
                    {
                        if(p.Sifra == sifra)
                        {
                            resp.Add(p.ID);
                        }
                    }
                }
            }
            return resp;
        }

        public List<string> DajSveLokacije()
        {
            var list = new List<string>();

            foreach (var s in Segmenti)
            {
                foreach (var v in s.Vertikale)
                {
                    foreach (var p in v.Palete)
                    {
                        list.Add(p.ID);
                    }
                }
            }
            return list;
        }

        public void CrtajSelektovanu(string ID)
        {
            string[] delovi = ID.Split('V');
            string vertikala = ID.Split('P')[0];
            foreach (var s in Segmenti)
            {
                if (s.ID == delovi[0])
                {
                    foreach (var v in s.Vertikale)
                    {
                        if (v.ID == vertikala)
                        {
                            foreach (var p in v.Palete)
                            {
                                if (p.ID == ID)
                                {
                                    p.CrtajSelekciju();
                                }
                            }
                        }
                    }
                }
            }
        }

        public void Refresh()
        {
            RekalkulacijaGeometrije();
            CrtajOkvir();
            CrtajProlaz();
            CrtajA2();
            CrtajA3();
            CrtajB3();
            CrtajB2();
            CrtajC3();
            CrtajD3();
            CrtajE3();
            CrtajF3();
            CrtajC2();
            CrtajD2();
            CrtajE2();
            CrtajF2();

            for (int n = 0; n < Segmenti.Count; n++)
            {
                Segmenti[n].Crtaj();
            }

            if(cp.ID != null) CrtajSelektovanu(cp.ID);
        }

        public void CrtajOkvir()
        {
            RectangleGeometry rect = new RectangleGeometry();
            rect.Rect = new Rect(Okvir1GoreLevo.X, Okvir1GoreLevo.Y, Okvir1DoleDesno.X, Okvir1DoleDesno.Y);
            Path rectPath = new Path
            {
                Stroke = new SolidColorBrush(Color.FromRgb(255, 0, 0)),
                StrokeThickness = DebljinaOkvira,
                Data = rect
            };
            rectPath.Tag = "Okvir";
            drawingContext.Children.Add(rectPath);

            rect = new RectangleGeometry();
            rect.Rect = new Rect(Okvir2GoreLevo.X, Okvir2GoreLevo.Y, Okvir2DoleDesno.X, Okvir2DoleDesno.Y);
            rectPath = new Path
            {
                Stroke = new SolidColorBrush(Color.FromRgb(255,255,255)),
                StrokeThickness = DebljinaOkvira,
                Data = rect
            };
            rectPath.Tag = "Okvir";
            drawingContext.Children.Add(rectPath);
        }

        public void CrtajProlaz()
        {
            LineGeometry line = new LineGeometry();
            line.StartPoint = new Point(XLevaLinijaProlaza, Okvir2GoreLevo.Y);
            line.EndPoint = new Point(XLevaLinijaProlaza, drawingContext.Height - 60);

            Path rectPath = new Path
            {
                Stroke = new SolidColorBrush(Color.FromRgb(255, 255, 0)),
                StrokeThickness = DebljinaOkvira,
                Data = line
            };
            rectPath.Tag = "Prolaz";
            drawingContext.Children.Add(rectPath);

            line = new LineGeometry();
            line.StartPoint = new Point(XDesnaLinijaProlaza, Okvir2GoreLevo.Y);
            line.EndPoint = new Point(XDesnaLinijaProlaza, drawingContext.Height - 60);

            rectPath = new Path
            {
                Stroke = new SolidColorBrush(Color.FromRgb(255, 255, 0)),
                StrokeThickness = DebljinaOkvira,
                Data = line
            };
            rectPath.Tag = "Prolaz";
            drawingContext.Children.Add(rectPath);

            line = new LineGeometry();
            line.StartPoint = new Point(XCentralnaLinijaProlaza, Okvir2GoreLevo.Y);
            line.EndPoint = new Point(XCentralnaLinijaProlaza, drawingContext.Height - 60);

            rectPath = new Path
            {
                Stroke = new SolidColorBrush(Color.FromRgb(0, 255, 0)),
                StrokeThickness = DebljinaOkvira,
                Data = line
            };
            rectPath.Tag = "Prolaz";
            drawingContext.Children.Add(rectPath);
        }

        public void RekalkulacijaGeometrije()
        {
            float SirinaOkvira1;
            float VisinaOkvira1;
            float procenat;

            //Segmenti.Clear();

            Okvir1DoleDesno = new PointF((float)(drawingContext.Width - 14), (float)(drawingContext.Height - 70));
            Okvir2DoleDesno = new PointF((float)drawingContext.Width - 20, (float)drawingContext.Height - 80);

            SirinaOkvira1 = Okvir1DoleDesno.X - Okvir1GoreLevo.X;
            VisinaOkvira1 = Okvir1DoleDesno.Y - Okvir1GoreLevo.Y;

            procenat = 100 / (Sirina / LevaLProlaza);
            XLevaLinijaProlaza = (float)((drawingContext.Width * procenat) / 100);

            procenat = 100 / (Sirina / DesnaLProlaza);
            XDesnaLinijaProlaza = (float)((drawingContext.Width * procenat) / 100);

            procenat = 100 / (Sirina / CentarProlaza);
            XCentralnaLinijaProlaza = (float)((drawingContext.Width * procenat) / 100);

            procenat = 100 / (Sirina / SirinaSegmenta);
            SirinaSegmentaPix = SirinaOkvira1 * procenat / 100;

            procenat = (100 / (Duzina / VisinaSegmenta)) + 1;
            VisinaSegmentaPix = VisinaOkvira1 * procenat / 100;

            procenat = 100 / (Sirina / RazmakOdProlaza);
            ProlazGap = SirinaOkvira1 * procenat / 100;

            SPA2.X = XLevaLinijaProlaza - ProlazGap;

            procenat = 100 / (Duzina / GoreLevoA2.Y);
            SPA2.Y = (float)(drawingContext.Height * procenat / 100);

            SPA3.X = XDesnaLinijaProlaza + ProlazGap;

            procenat = 100 / (Duzina / GoreLevoA3.Y);
            SPA3.Y = (float)(drawingContext.Height * procenat / 100);

            procenat = 100 / (Duzina / VertRazmakSegmenata);
            VertGapSegmenata = (float)(drawingContext.Height * procenat / 100);
        }

        public ClickedPallete Kliked(Point hitPoint)
        {
            //ClickedPallete cp = new ClickedPallete();

            foreach (var p in Segmenti)
            {
                cp = p.Kliked(hitPoint);
                if (cp.Kliked == true) break;
            }
            return cp;
        }

        public void CrtajA2()
        {
            
            Segment i = new Segment();
            i.Sirina = (int)SirinaSegmentaPix;
            i.Visina = (int)VisinaSegmentaPix;
            i.XLevo = (int)(SPA2.X - SirinaSegmentaPix);
            i.YGore = (int)SPA2.Y + TopOffset;
            i.DebljinaOkvira = DebljinaOkviraSegmenta;
            i.BojaOkviraVertikale = BojaOkviraVertikale;
            i.BojaNumeracije = BojaNumeracije;
            i.OkvirPalete = OkvirPalete;
            i.BojaOkviraPalete = BojaOkviraPalete;
            i.BojaOkvira = BojaOkviraSegmenta;
            i.DebljinaOkviraPalete = DebljinaOkviraPalete ;
            i.Numeracija = Numeracija;
            i.drawingContext = drawingContext;
            i.ID = "A21";
            var seg = Segmenti.FirstOrDefault(x => x.ID == "A21");
            if (seg != null)
            {
                seg.Sirina = (int)SirinaSegmentaPix;
                seg.Visina = (int)VisinaSegmentaPix;
                seg.XLevo = (int)(SPA2.X - SirinaSegmentaPix);
                seg.YGore = (int)SPA2.Y + TopOffset;
                seg.DebljinaOkvira = DebljinaOkviraSegmenta;
                seg.BojaOkviraVertikale = BojaOkviraVertikale;
                seg.BojaNumeracije = BojaNumeracije;
                seg.OkvirPalete = OkvirPalete;
                seg.BojaOkviraPalete = BojaOkviraPalete;
                seg.BojaOkvira = BojaOkviraSegmenta;
                seg.DebljinaOkviraPalete = DebljinaOkviraPalete;
                seg.Numeracija = Numeracija;
                seg.drawingContext = drawingContext;
                seg.ID = "A21";
            }
            else    
                Segmenti.Add(i);


            i = new Segment();
            i.Sirina = (int)SirinaSegmentaPix;
            i.Visina = (int)VisinaSegmentaPix;
            i.XLevo = (int)(SPA2.X - (SirinaSegmentaPix * 2));
            i.YGore = (int)SPA2.Y + TopOffset;
            i.DebljinaOkvira = DebljinaOkviraSegmenta;
            i.BojaOkviraVertikale = BojaOkviraVertikale ;
            i.OkvirPalete = OkvirPalete;
            i.BojaOkviraPalete = BojaOkviraPalete;
            i.BojaOkvira = BojaOkviraSegmenta;
            i.BojaNumeracije = BojaNumeracije;
            i.DebljinaOkviraPalete = DebljinaOkviraPalete ;
            i.Numeracija = Numeracija;
            i.drawingContext = drawingContext;
            i.ID = "A22";
            seg = Segmenti.FirstOrDefault(x => x.ID == "A22");
            if (seg != null)
            {
                seg.Sirina = (int)SirinaSegmentaPix;
                seg.Visina = (int)VisinaSegmentaPix;
                seg.XLevo = (int)(SPA2.X - SirinaSegmentaPix * 2);
                seg.YGore = (int)SPA2.Y + TopOffset;
                seg.DebljinaOkvira = DebljinaOkviraSegmenta;
                seg.BojaOkviraVertikale = BojaOkviraVertikale;
                seg.BojaNumeracije = BojaNumeracije;
                seg.OkvirPalete = OkvirPalete;
                seg.BojaOkviraPalete = BojaOkviraPalete;
                seg.BojaOkvira = BojaOkviraSegmenta;
                seg.DebljinaOkviraPalete = DebljinaOkviraPalete;
                seg.Numeracija = Numeracija;
                seg.drawingContext = drawingContext;
                seg.ID = "A22";
            }
            else
                Segmenti.Add(i);

            i = new Segment();
            i.Sirina = (int)SirinaSegmentaPix;
            i.Visina = (int)VisinaSegmentaPix;
            i.XLevo = (int)(SPA2.X - (3 * SirinaSegmentaPix));
            i.YGore = (int)SPA2.Y + TopOffset;
            i.DebljinaOkvira = DebljinaOkviraSegmenta;
            i.BojaOkviraVertikale = BojaOkviraVertikale ;
            i.OkvirPalete = OkvirPalete;
            i.BojaOkviraPalete = BojaOkviraPalete;
            i.BojaOkvira = BojaOkviraSegmenta;
            i.BojaNumeracije = BojaNumeracije;
            i.DebljinaOkviraPalete = DebljinaOkviraPalete ;
            i.Numeracija = Numeracija;
            i.drawingContext = drawingContext;
            i.ID = "A23";
            seg = Segmenti.FirstOrDefault(x => x.ID == "A23");
            if (seg != null)
            {
                seg.Sirina = (int)SirinaSegmentaPix;
                seg.Visina = (int)VisinaSegmentaPix;
                seg.XLevo = (int)(SPA2.X - SirinaSegmentaPix * 3);
                seg.YGore = (int)SPA2.Y + TopOffset;
                seg.DebljinaOkvira = DebljinaOkviraSegmenta;
                seg.BojaOkviraVertikale = BojaOkviraVertikale;
                seg.BojaNumeracije = BojaNumeracije;
                seg.OkvirPalete = OkvirPalete;
                seg.BojaOkviraPalete = BojaOkviraPalete;
                seg.BojaOkvira = BojaOkviraSegmenta;
                seg.DebljinaOkviraPalete = DebljinaOkviraPalete;
                seg.Numeracija = Numeracija;
                seg.drawingContext = drawingContext;
                seg.ID = "A23";
            }
            else
                Segmenti.Add(i);
        }

        public void CrtajA3()
        {
            Segment i = new Segment();
            i.Sirina = (int)SirinaSegmentaPix;
            i.Visina = (int)VisinaSegmentaPix;
            i.XLevo = (int)SPA3.X;
            i.YGore = (int)SPA3.Y + TopOffset;
            i.DebljinaOkvira = DebljinaOkviraSegmenta;
            i.BojaOkviraVertikale = BojaOkviraVertikale ;
            i.OkvirPalete = OkvirPalete;
            i.BojaOkviraPalete = BojaOkviraPalete;
            i.DebljinaOkviraPalete = DebljinaOkviraPalete ;
            i.BojaOkvira = BojaOkviraSegmenta;
            i.BojaNumeracije = BojaNumeracije;
            i.Numeracija = Numeracija;
            i.drawingContext = drawingContext;
            i.ID = "A32";
            var seg = Segmenti.FirstOrDefault(x => x.ID == "A32");
            if (seg != null)
            {
                seg.Sirina = (int)SirinaSegmentaPix;
                seg.Visina = (int)VisinaSegmentaPix;
                seg.XLevo = (int)SPA3.X;
                seg.YGore = (int)SPA3.Y + TopOffset;
                seg.DebljinaOkvira = DebljinaOkviraSegmenta;
                seg.BojaOkviraVertikale = BojaOkviraVertikale;
                seg.BojaNumeracije = BojaNumeracije;
                seg.OkvirPalete = OkvirPalete;
                seg.BojaOkviraPalete = BojaOkviraPalete;
                seg.BojaOkvira = BojaOkviraSegmenta;
                seg.DebljinaOkviraPalete = DebljinaOkviraPalete;
                seg.Numeracija = Numeracija;
                //seg.drawingContext = drawingContext;
            }
            else
                Segmenti.Add(i);

            i = new Segment();
            i.Sirina = (int)SirinaSegmentaPix;
            i.Visina = (int)VisinaSegmentaPix;
            i.XLevo = (int)((int)SPA3.X + SirinaSegmentaPix);
            i.YGore = (int)SPA3.Y + TopOffset;
            i.DebljinaOkvira = DebljinaOkviraSegmenta;
            i.BojaOkviraVertikale = BojaOkviraVertikale ;
            i.BojaOkvira = BojaOkviraSegmenta;
            i.OkvirPalete = OkvirPalete;
            i.BojaOkviraPalete = BojaOkviraPalete;
            i.BojaNumeracije = BojaNumeracije;
            i.DebljinaOkviraPalete = DebljinaOkviraPalete ;
            i.Numeracija = Numeracija;
            i.drawingContext = drawingContext;
            i.ID = "A33";
            seg = Segmenti.FirstOrDefault(x => x.ID == "A33");
            if (seg != null)
            {
                seg.Sirina = (int)SirinaSegmentaPix;
                seg.Visina = (int)VisinaSegmentaPix;
                seg.XLevo = (int)((int)SPA3.X + SirinaSegmentaPix);
                seg.YGore = (int)SPA3.Y + TopOffset;
                seg.DebljinaOkvira = DebljinaOkviraSegmenta;
                seg.BojaOkviraVertikale = BojaOkviraVertikale;
                seg.BojaNumeracije = BojaNumeracije;
                seg.OkvirPalete = OkvirPalete;
                seg.BojaOkviraPalete = BojaOkviraPalete;
                seg.BojaOkvira = BojaOkviraSegmenta;
                seg.DebljinaOkviraPalete = DebljinaOkviraPalete;
                seg.Numeracija = Numeracija;
                //seg.drawingContext = drawingContext;
            }
            else
                Segmenti.Add(i);
        }

        public void CrtajB3()
        {
            Segment i = new Segment();
            i.Sirina = (int)SirinaSegmentaPix;
            i.Visina = (int)VisinaSegmentaPix;
            i.XLevo = (int)SPA3.X;
            i.YGore = (int)((int)SPA3.Y + TopOffset + VertGapSegmenata);
            i.DebljinaOkvira = DebljinaOkviraSegmenta;
            i.BojaOkviraVertikale = BojaOkviraVertikale ;
            i.BojaOkvira = BojaOkviraSegmenta;
            i.OkvirPalete = OkvirPalete;
            i.BojaOkviraPalete = BojaOkviraPalete;
            i.DebljinaOkviraPalete = DebljinaOkviraPalete ;
            i.BojaNumeracije = BojaNumeracije;
            i.Numeracija = Numeracija;
            i.drawingContext = drawingContext;
            i.ID = "B321";
            var seg = Segmenti.FirstOrDefault(x => x.ID == "B321");
            if (seg != null)
            {
                seg.Sirina = (int)SirinaSegmentaPix;
                seg.Visina = (int)VisinaSegmentaPix;
                seg.XLevo = (int)SPA3.X;
                seg.YGore = (int)((int)SPA3.Y + TopOffset + VertGapSegmenata);
                seg.DebljinaOkvira = DebljinaOkviraSegmenta;
                seg.BojaOkviraVertikale = BojaOkviraVertikale;
                seg.BojaOkvira = BojaOkviraSegmenta;
                seg.OkvirPalete = OkvirPalete;
                seg.BojaOkviraPalete = BojaOkviraPalete;
                seg.DebljinaOkviraPalete = DebljinaOkviraPalete;
                seg.BojaNumeracije = BojaNumeracije;
                seg.Numeracija = Numeracija;
                seg.drawingContext = drawingContext;
                seg.ID = "B321";
            }
            else
                Segmenti.Add(i);

            i = new Segment();
            i.Sirina = (int)SirinaSegmentaPix;
            i.Visina = (int)VisinaSegmentaPix;
            i.XLevo = (int)((int)SPA3.X + SirinaSegmentaPix);
            i.YGore = (int)((int)SPA3.Y + TopOffset + VertGapSegmenata);
            i.DebljinaOkvira = DebljinaOkviraSegmenta;
            i.BojaOkviraVertikale = BojaOkviraVertikale ;
            i.BojaOkvira = BojaOkviraSegmenta;
            i.OkvirPalete = OkvirPalete;
            i.BojaOkviraPalete = BojaOkviraPalete;
            i.DebljinaOkviraPalete = DebljinaOkviraPalete ;
            i.BojaNumeracije = BojaNumeracije;
            i.Numeracija = Numeracija;
            i.drawingContext = drawingContext;
            i.ID = "B331";
            seg = Segmenti.FirstOrDefault(x => x.ID == "B331");
            if (seg != null)
            {
                seg.Sirina = (int)SirinaSegmentaPix;
                seg.Visina = (int)VisinaSegmentaPix;
                seg.XLevo = (int)((int)SPA3.X + SirinaSegmentaPix);
                seg.YGore = (int)((int)SPA3.Y + TopOffset + VertGapSegmenata);
                seg.DebljinaOkvira = DebljinaOkviraSegmenta;
                seg.BojaOkviraVertikale = BojaOkviraVertikale;
                seg.BojaOkvira = BojaOkviraSegmenta;
                seg.OkvirPalete = OkvirPalete;
                seg.BojaOkviraPalete = BojaOkviraPalete;
                seg.DebljinaOkviraPalete = DebljinaOkviraPalete;
                seg.BojaNumeracije = BojaNumeracije;
                seg.Numeracija = Numeracija;
                seg.drawingContext = drawingContext;
                seg.ID = "B331";
            }
            else
                Segmenti.Add(i);

            i = new Segment();
            i.Sirina = (int)SirinaSegmentaPix;
            i.Visina = (int)VisinaSegmentaPix;
            i.XLevo = (int)SPA3.X;
            i.YGore = (int)((int)SPA3.Y + TopOffset + VertGapSegmenata + VisinaSegmentaPix);
            i.DebljinaOkvira = DebljinaOkviraSegmenta;
            i.BojaOkviraVertikale = BojaOkviraVertikale ;
            i.BojaOkvira = BojaOkviraSegmenta;
            i.OkvirPalete = OkvirPalete;
            i.BojaOkviraPalete = BojaOkviraPalete;
            i.DebljinaOkviraPalete = DebljinaOkviraPalete ;
            i.BojaNumeracije = BojaNumeracije;
            i.Numeracija = Numeracija;
            i.drawingContext = drawingContext;
            i.ID = "B322";
            seg = Segmenti.FirstOrDefault(x => x.ID == "B322");
            if (seg != null)
            {
                seg.Sirina = (int)SirinaSegmentaPix;
                seg.Visina = (int)VisinaSegmentaPix;
                seg.XLevo = (int)SPA3.X;
                seg.YGore = (int)((int)SPA3.Y + TopOffset + VertGapSegmenata + VisinaSegmentaPix);
                seg.DebljinaOkvira = DebljinaOkviraSegmenta;
                seg.BojaOkviraVertikale = BojaOkviraVertikale;
                seg.BojaOkvira = BojaOkviraSegmenta;
                seg.OkvirPalete = OkvirPalete;
                seg.BojaOkviraPalete = BojaOkviraPalete;
                seg.DebljinaOkviraPalete = DebljinaOkviraPalete;
                seg.BojaNumeracije = BojaNumeracije;
                seg.Numeracija = Numeracija;
                seg.drawingContext = drawingContext;
                seg.ID = "B322";
            }
            else
                Segmenti.Add(i);

            i = new Segment();
            i.Sirina = (int)SirinaSegmentaPix;
            i.Visina = (int)VisinaSegmentaPix;
            i.XLevo = (int)((int)SPA3.X + SirinaSegmentaPix);
            i.YGore = (int)((int)SPA3.Y + TopOffset + VertGapSegmenata + VisinaSegmentaPix);
            i.DebljinaOkvira = DebljinaOkviraSegmenta;
            i.BojaOkviraVertikale = BojaOkviraVertikale ;
            i.OkvirPalete = OkvirPalete;
            i.BojaOkvira = BojaOkviraSegmenta;
            i.BojaOkviraPalete = BojaOkviraPalete;
            i.DebljinaOkviraPalete = DebljinaOkviraPalete ;
            i.BojaNumeracije = BojaNumeracije;
            i.Numeracija = Numeracija;
            i.drawingContext = drawingContext;
            i.ID = "B332";
            seg = Segmenti.FirstOrDefault(x => x.ID == "B332");
            if (seg != null)
            {
                seg.Sirina = (int)SirinaSegmentaPix;
                seg.Visina = (int)VisinaSegmentaPix;
                seg.XLevo = (int)((int)SPA3.X + SirinaSegmentaPix);
                seg.YGore = (int)((int)SPA3.Y + TopOffset + VertGapSegmenata + VisinaSegmentaPix);
                seg.DebljinaOkvira = DebljinaOkviraSegmenta;
                seg.BojaOkviraVertikale = BojaOkviraVertikale;
                seg.OkvirPalete = OkvirPalete;
                seg.BojaOkvira = BojaOkviraSegmenta;
                seg.BojaOkviraPalete = BojaOkviraPalete;
                seg.DebljinaOkviraPalete = DebljinaOkviraPalete;
                seg.BojaNumeracije = BojaNumeracije;
                seg.Numeracija = Numeracija;
                seg.drawingContext = drawingContext;
                seg.ID = "B332";
            }
            else
                Segmenti.Add(i);
        }

        public void CrtajB2()
        {

            Segment i = new Segment();
            i.Sirina = (int)SirinaSegmentaPix;
            i.Visina = (int)VisinaSegmentaPix;
            i.XLevo = (int)(SPA2.X - SirinaSegmentaPix);
            i.YGore = (int)((int)SPA3.Y + TopOffset + VertGapSegmenata);
            i.DebljinaOkvira = DebljinaOkviraSegmenta;
            i.BojaOkviraVertikale = BojaOkviraVertikale ;
            i.OkvirPalete = OkvirPalete;
            i.BojaOkviraPalete = BojaOkviraPalete;
            i.DebljinaOkviraPalete = DebljinaOkviraPalete ;
            i.BojaNumeracije = BojaNumeracije;
            i.BojaOkvira = BojaOkviraSegmenta;
            i.Numeracija = Numeracija;
            i.drawingContext = drawingContext;
            i.ID = "B21";
            var seg = Segmenti.FirstOrDefault(x => x.ID == "B21");
            if (seg != null)
            {
                seg.Sirina = (int)SirinaSegmentaPix;
                seg.Visina = (int)VisinaSegmentaPix;
                seg.XLevo = (int)(SPA2.X - SirinaSegmentaPix);
                seg.YGore = (int)((int)SPA3.Y + TopOffset + VertGapSegmenata);
                seg.DebljinaOkvira = DebljinaOkviraSegmenta;
                seg.BojaOkviraVertikale = BojaOkviraVertikale;
                seg.OkvirPalete = OkvirPalete;
                seg.BojaOkviraPalete = BojaOkviraPalete;
                seg.DebljinaOkviraPalete = DebljinaOkviraPalete;
                seg.BojaNumeracije = BojaNumeracije;
                seg.BojaOkvira = BojaOkviraSegmenta;
                seg.Numeracija = Numeracija;
                seg.drawingContext = drawingContext;
                seg.ID = "B21";
            }
            else
                Segmenti.Add(i);


            i = new Segment();
            i.Sirina = (int)SirinaSegmentaPix;
            i.Visina = (int)VisinaSegmentaPix;
            i.XLevo = (int)(SPA2.X - (SirinaSegmentaPix * 2));
            i.YGore = (int)((int)SPA3.Y + TopOffset + VertGapSegmenata);
            i.DebljinaOkvira = DebljinaOkviraSegmenta;
            i.BojaOkviraVertikale = BojaOkviraVertikale ;
            i.OkvirPalete = OkvirPalete;
            i.BojaOkviraPalete = BojaOkviraPalete;
            i.DebljinaOkviraPalete = DebljinaOkviraPalete ;
            i.BojaNumeracije = BojaNumeracije;
            i.BojaOkvira = BojaOkviraSegmenta;
            i.Numeracija = Numeracija;
            i.drawingContext = drawingContext;
            i.ID = "B22";
            seg = Segmenti.FirstOrDefault(x => x.ID == "B22");
            if (seg != null)
            {
                seg.Sirina = (int)SirinaSegmentaPix;
                seg.Visina = (int)VisinaSegmentaPix;
                seg.XLevo = (int)(SPA2.X - (SirinaSegmentaPix * 2));
                seg.YGore = (int)((int)SPA3.Y + TopOffset + VertGapSegmenata);
                seg.DebljinaOkvira = DebljinaOkviraSegmenta;
                seg.BojaOkviraVertikale = BojaOkviraVertikale;
                seg.OkvirPalete = OkvirPalete;
                seg.BojaOkviraPalete = BojaOkviraPalete;
                seg.DebljinaOkviraPalete = DebljinaOkviraPalete;
                seg.BojaNumeracije = BojaNumeracije;
                seg.BojaOkvira = BojaOkviraSegmenta;
                seg.Numeracija = Numeracija;
                seg.drawingContext = drawingContext;
                seg.ID = "B22";
            }
            else
                Segmenti.Add(i);

            i = new Segment();
            i.Sirina = (int)SirinaSegmentaPix;
            i.Visina = (int)VisinaSegmentaPix;
            i.XLevo = (int)(SPA2.X - (3 * SirinaSegmentaPix));
            i.YGore = (int)((int)SPA3.Y + TopOffset + VertGapSegmenata);
            i.DebljinaOkvira = DebljinaOkviraSegmenta;
            i.BojaOkviraVertikale = BojaOkviraVertikale ;
            i.OkvirPalete = OkvirPalete;
            i.BojaOkviraPalete = BojaOkviraPalete;
            i.DebljinaOkviraPalete = DebljinaOkviraPalete ;
            i.BojaOkvira = BojaOkviraSegmenta;
            i.BojaNumeracije = BojaNumeracije;
            i.Numeracija = Numeracija;
            i.drawingContext = drawingContext;
            i.ID = "B23";
            seg = Segmenti.FirstOrDefault(x => x.ID == "B23");
            if (seg != null)
            {
                seg.Sirina = (int)SirinaSegmentaPix;
                seg.Visina = (int)VisinaSegmentaPix;
                seg.XLevo = (int)(SPA2.X - (3 * SirinaSegmentaPix));
                seg.YGore = (int)((int)SPA3.Y + TopOffset + VertGapSegmenata);
                seg.DebljinaOkvira = DebljinaOkviraSegmenta;
                seg.BojaOkviraVertikale = BojaOkviraVertikale;
                seg.OkvirPalete = OkvirPalete;
                seg.BojaOkviraPalete = BojaOkviraPalete;
                seg.DebljinaOkviraPalete = DebljinaOkviraPalete;
                seg.BojaOkvira = BojaOkviraSegmenta;
                seg.BojaNumeracije = BojaNumeracije;
                seg.Numeracija = Numeracija;
                seg.drawingContext = drawingContext;
                seg.ID = "B23";
            }
            else
                Segmenti.Add(i);

            i = new Segment();
            i.Sirina = (int)SirinaSegmentaPix;
            i.Visina = (int)VisinaSegmentaPix;
            i.XLevo = (int)(SPA2.X - (4 * SirinaSegmentaPix));
            i.YGore = (int)((int)SPA3.Y + TopOffset + VertGapSegmenata);
            i.DebljinaOkvira = DebljinaOkviraSegmenta;
            i.BojaOkviraVertikale = BojaOkviraVertikale ;
            i.OkvirPalete = OkvirPalete;
            i.BojaOkviraPalete = BojaOkviraPalete;
            i.DebljinaOkviraPalete = DebljinaOkviraPalete ;
            i.BojaOkvira = BojaOkviraSegmenta;
            i.BojaNumeracije = BojaNumeracije;
            i.Numeracija = Numeracija;
            i.drawingContext = drawingContext;
            i.ID = "B24";
            seg = Segmenti.FirstOrDefault(x => x.ID == "B24");
            if (seg != null)
            {
                seg.Sirina = (int)SirinaSegmentaPix;
                seg.Visina = (int)VisinaSegmentaPix;
                seg.XLevo = (int)(SPA2.X - (4 * SirinaSegmentaPix));
                seg.YGore = (int)((int)SPA3.Y + TopOffset + VertGapSegmenata);
                seg.DebljinaOkvira = DebljinaOkviraSegmenta;
                seg.BojaOkviraVertikale = BojaOkviraVertikale;
                seg.OkvirPalete = OkvirPalete;
                seg.BojaOkviraPalete = BojaOkviraPalete;
                seg.DebljinaOkviraPalete = DebljinaOkviraPalete;
                seg.BojaOkvira = BojaOkviraSegmenta;
                seg.BojaNumeracije = BojaNumeracije;
                seg.Numeracija = Numeracija;
                seg.drawingContext = drawingContext;
                seg.ID = "B24";
            }
            else
                Segmenti.Add(i);

            i = new Segment();
            i.Sirina = (int)SirinaSegmentaPix;
            i.Visina = (int)VisinaSegmentaPix;
            i.XLevo = (int)(SPA2.X - SirinaSegmentaPix);
            i.YGore = (int)((int)SPA3.Y + TopOffset + VertGapSegmenata + VisinaSegmentaPix);
            i.DebljinaOkvira = DebljinaOkviraSegmenta;
            i.BojaOkviraVertikale = BojaOkviraVertikale ;
            i.OkvirPalete = OkvirPalete;
            i.BojaOkviraPalete = BojaOkviraPalete;
            i.DebljinaOkviraPalete = DebljinaOkviraPalete ;
            i.BojaOkvira = BojaOkviraSegmenta;
            i.BojaNumeracije = BojaNumeracije;
            i.Numeracija = Numeracija;
            i.drawingContext = drawingContext;
            i.ID = "B25";
            seg = Segmenti.FirstOrDefault(x => x.ID == "B25");
            if (seg != null)
            {
                seg.Sirina = (int)SirinaSegmentaPix;
                seg.Visina = (int)VisinaSegmentaPix;
                seg.XLevo = (int)(SPA2.X - SirinaSegmentaPix);
                seg.YGore = (int)((int)SPA3.Y + TopOffset + VertGapSegmenata + VisinaSegmentaPix);
                seg.DebljinaOkvira = DebljinaOkviraSegmenta;
                seg.BojaOkviraVertikale = BojaOkviraVertikale;
                seg.OkvirPalete = OkvirPalete;
                seg.BojaOkviraPalete = BojaOkviraPalete;
                seg.DebljinaOkviraPalete = DebljinaOkviraPalete;
                seg.BojaOkvira = BojaOkviraSegmenta;
                seg.BojaNumeracije = BojaNumeracije;
                seg.Numeracija = Numeracija;
                seg.drawingContext = drawingContext;
                seg.ID = "B25";
            }
            else
                Segmenti.Add(i);


            i = new Segment();
            i.Sirina = (int)SirinaSegmentaPix;
            i.Visina = (int)VisinaSegmentaPix;
            i.XLevo = (int)(SPA2.X - (SirinaSegmentaPix * 2));
            i.YGore = (int)((int)SPA3.Y + TopOffset + VertGapSegmenata + VisinaSegmentaPix);
            i.DebljinaOkvira = DebljinaOkviraSegmenta;
            i.BojaOkviraVertikale = BojaOkviraVertikale ;
            i.OkvirPalete = OkvirPalete;
            i.BojaOkviraPalete = BojaOkviraPalete;
            i.DebljinaOkviraPalete = DebljinaOkviraPalete ;
            i.BojaOkvira = BojaOkviraSegmenta;
            i.BojaNumeracije = BojaNumeracije;
            i.Numeracija = Numeracija;
            i.drawingContext = drawingContext;
            i.ID = "B26";
            seg = Segmenti.FirstOrDefault(x => x.ID == "B26");
            if (seg != null)
            {
                seg.Sirina = (int)SirinaSegmentaPix;
                seg.Visina = (int)VisinaSegmentaPix;
                seg.XLevo = (int)(SPA2.X - (SirinaSegmentaPix * 2));
                seg.YGore = (int)((int)SPA3.Y + TopOffset + VertGapSegmenata + VisinaSegmentaPix);
                seg.DebljinaOkvira = DebljinaOkviraSegmenta;
                seg.BojaOkviraVertikale = BojaOkviraVertikale;
                seg.OkvirPalete = OkvirPalete;
                seg.BojaOkviraPalete = BojaOkviraPalete;
                seg.DebljinaOkviraPalete = DebljinaOkviraPalete;
                seg.BojaOkvira = BojaOkviraSegmenta;
                seg.BojaNumeracije = BojaNumeracije;
                seg.Numeracija = Numeracija;
                seg.drawingContext = drawingContext;
                seg.ID = "B26";
            }
            else
                Segmenti.Add(i);

            i = new Segment();
            i.Sirina = (int)SirinaSegmentaPix;
            i.Visina = (int)VisinaSegmentaPix;
            i.XLevo = (int)(SPA2.X - (3 * SirinaSegmentaPix));
            i.YGore = (int)((int)SPA3.Y + TopOffset + VertGapSegmenata + VisinaSegmentaPix);
            i.DebljinaOkvira = DebljinaOkviraSegmenta;
            i.BojaOkviraVertikale = BojaOkviraVertikale ;
            i.OkvirPalete = OkvirPalete;
            i.BojaOkviraPalete = BojaOkviraPalete;
            i.DebljinaOkviraPalete = DebljinaOkviraPalete ;
            i.BojaOkvira = BojaOkviraSegmenta;
            i.BojaNumeracije = BojaNumeracije;
            i.Numeracija = Numeracija;
            i.drawingContext = drawingContext;
            i.ID = "B27";
            seg = Segmenti.FirstOrDefault(x => x.ID == "B27");
            if (seg != null)
            {
                seg.Sirina = (int)SirinaSegmentaPix;
                seg.Visina = (int)VisinaSegmentaPix;
                seg.XLevo = (int)(SPA2.X - (3 * SirinaSegmentaPix));
                seg.YGore = (int)((int)SPA3.Y + TopOffset + VertGapSegmenata + VisinaSegmentaPix);
                seg.DebljinaOkvira = DebljinaOkviraSegmenta;
                seg.BojaOkviraVertikale = BojaOkviraVertikale;
                seg.OkvirPalete = OkvirPalete;
                seg.BojaOkviraPalete = BojaOkviraPalete;
                seg.DebljinaOkviraPalete = DebljinaOkviraPalete;
                seg.BojaOkvira = BojaOkviraSegmenta;
                seg.BojaNumeracije = BojaNumeracije;
                seg.Numeracija = Numeracija;
                seg.drawingContext = drawingContext;
                seg.ID = "B27";
            }
            else
                Segmenti.Add(i);

            i = new Segment();
            i.Sirina = (int)SirinaSegmentaPix;
            i.Visina = (int)VisinaSegmentaPix;
            i.XLevo = (int)(SPA2.X - (4 * SirinaSegmentaPix));
            i.YGore = (int)((int)SPA3.Y + TopOffset + VertGapSegmenata + VisinaSegmentaPix);
            i.DebljinaOkvira = DebljinaOkviraSegmenta;
            i.BojaOkviraVertikale = BojaOkviraVertikale ;
            i.OkvirPalete = OkvirPalete;
            i.BojaOkviraPalete = BojaOkviraPalete;
            i.DebljinaOkviraPalete = DebljinaOkviraPalete ;
            i.BojaOkvira = BojaOkviraSegmenta;
            i.BojaNumeracije = BojaNumeracije;
            i.Numeracija = Numeracija;
            i.drawingContext = drawingContext;
            i.ID = "B28";
            seg = Segmenti.FirstOrDefault(x => x.ID == "B28");
            if (seg != null)
            {
                seg.Sirina = (int)SirinaSegmentaPix;
                seg.Visina = (int)VisinaSegmentaPix;
                seg.XLevo = (int)(SPA2.X - (4 * SirinaSegmentaPix));
                seg.YGore = (int)((int)SPA3.Y + TopOffset + VertGapSegmenata + VisinaSegmentaPix);
                seg.DebljinaOkvira = DebljinaOkviraSegmenta;
                seg.BojaOkviraVertikale = BojaOkviraVertikale;
                seg.OkvirPalete = OkvirPalete;
                seg.BojaOkviraPalete = BojaOkviraPalete;
                seg.DebljinaOkviraPalete = DebljinaOkviraPalete;
                seg.BojaOkvira = BojaOkviraSegmenta;
                seg.BojaNumeracije = BojaNumeracije;
                seg.Numeracija = Numeracija;
                seg.drawingContext = drawingContext;
                seg.ID = "B28";
            }
            else
                Segmenti.Add(i);
        }

        public void CrtajC2()
        {

            Segment i = new Segment();
            i.Sirina = (int)SirinaSegmentaPix;
            i.Visina = (int)VisinaSegmentaPix;
            i.XLevo = (int)(SPA2.X - SirinaSegmentaPix);
            i.YGore = (int)((int)SPA3.Y + TopOffset + VertGapSegmenata * 2 + VisinaSegmentaPix);
            i.DebljinaOkvira = DebljinaOkviraSegmenta;
            i.BojaOkviraVertikale = BojaOkviraVertikale;
            i.OkvirPalete = OkvirPalete;
            i.BojaOkviraPalete = BojaOkviraPalete;
            i.DebljinaOkviraPalete = DebljinaOkviraPalete;
            i.BojaNumeracije = BojaNumeracije;
            i.BojaOkvira = BojaOkviraSegmenta;
            i.Numeracija = Numeracija;
            i.drawingContext = drawingContext;
            i.ID = "C21";
            var seg = Segmenti.FirstOrDefault(x => x.ID == "C21");
            if (seg != null)
            {
                seg.Sirina = (int)SirinaSegmentaPix;
                seg.Visina = (int)VisinaSegmentaPix;
                seg.XLevo = (int)(SPA2.X - SirinaSegmentaPix);
                seg.YGore = (int)((int)SPA3.Y + TopOffset + VertGapSegmenata * 2 + VisinaSegmentaPix);
                seg.DebljinaOkvira = DebljinaOkviraSegmenta;
                seg.BojaOkviraVertikale = BojaOkviraVertikale;
                seg.OkvirPalete = OkvirPalete;
                seg.BojaOkviraPalete = BojaOkviraPalete;
                seg.DebljinaOkviraPalete = DebljinaOkviraPalete;
                seg.BojaNumeracije = BojaNumeracije;
                seg.BojaOkvira = BojaOkviraSegmenta;
                seg.Numeracija = Numeracija;
                seg.drawingContext = drawingContext;
                seg.ID = "C21";
            }
            else
                Segmenti.Add(i);


            i = new Segment();
            i.Sirina = (int)SirinaSegmentaPix;
            i.Visina = (int)VisinaSegmentaPix;
            i.XLevo = (int)(SPA2.X - (SirinaSegmentaPix * 2));
            i.YGore = (int)((int)SPA3.Y + TopOffset + VertGapSegmenata * 2 + VisinaSegmentaPix);
            i.DebljinaOkvira = DebljinaOkviraSegmenta;
            i.BojaOkviraVertikale = BojaOkviraVertikale;
            i.OkvirPalete = OkvirPalete;
            i.BojaOkviraPalete = BojaOkviraPalete;
            i.DebljinaOkviraPalete = DebljinaOkviraPalete;
            i.BojaNumeracije = BojaNumeracije;
            i.BojaOkvira = BojaOkviraSegmenta;
            i.Numeracija = Numeracija;
            i.drawingContext = drawingContext;
            i.ID = "C22";
            seg = Segmenti.FirstOrDefault(x => x.ID == "C22");
            if (seg != null)
            {
                seg.Sirina = (int)SirinaSegmentaPix;
                seg.Visina = (int)VisinaSegmentaPix;
                seg.XLevo = (int)(SPA2.X - (SirinaSegmentaPix * 2));
                seg.YGore = (int)((int)SPA3.Y + TopOffset + VertGapSegmenata * 2 + VisinaSegmentaPix);
                seg.DebljinaOkvira = DebljinaOkviraSegmenta;
                seg.BojaOkviraVertikale = BojaOkviraVertikale;
                seg.OkvirPalete = OkvirPalete;
                seg.BojaOkviraPalete = BojaOkviraPalete;
                seg.DebljinaOkviraPalete = DebljinaOkviraPalete;
                seg.BojaNumeracije = BojaNumeracije;
                seg.BojaOkvira = BojaOkviraSegmenta;
                seg.Numeracija = Numeracija;
                seg.drawingContext = drawingContext;
                seg.ID = "C22";
            }
            else
                Segmenti.Add(i);

            i = new Segment();
            i.Sirina = (int)SirinaSegmentaPix;
            i.Visina = (int)VisinaSegmentaPix;
            i.XLevo = (int)(SPA2.X - (3 * SirinaSegmentaPix));
            i.YGore = (int)((int)SPA3.Y + TopOffset + VertGapSegmenata * 2 + VisinaSegmentaPix);
            i.DebljinaOkvira = DebljinaOkviraSegmenta;
            i.BojaOkviraVertikale = BojaOkviraVertikale;
            i.OkvirPalete = OkvirPalete;
            i.BojaOkviraPalete = BojaOkviraPalete;
            i.DebljinaOkviraPalete = DebljinaOkviraPalete;
            i.BojaOkvira = BojaOkviraSegmenta;
            i.BojaNumeracije = BojaNumeracije;
            i.Numeracija = Numeracija;
            i.drawingContext = drawingContext;
            i.ID = "C23";
            seg = Segmenti.FirstOrDefault(x => x.ID == "C23");
            if (seg != null)
            {
                seg.Sirina = (int)SirinaSegmentaPix;
                seg.Visina = (int)VisinaSegmentaPix;
                seg.XLevo = (int)(SPA2.X - (3 * SirinaSegmentaPix));
                seg.YGore = (int)((int)SPA3.Y + TopOffset + VertGapSegmenata * 2 + VisinaSegmentaPix);
                seg.DebljinaOkvira = DebljinaOkviraSegmenta;
                seg.BojaOkviraVertikale = BojaOkviraVertikale;
                seg.OkvirPalete = OkvirPalete;
                seg.BojaOkviraPalete = BojaOkviraPalete;
                seg.DebljinaOkviraPalete = DebljinaOkviraPalete;
                seg.BojaOkvira = BojaOkviraSegmenta;
                seg.BojaNumeracije = BojaNumeracije;
                seg.Numeracija = Numeracija;
                seg.drawingContext = drawingContext;
                seg.ID = "C23";
            }
            else
                Segmenti.Add(i);

            i = new Segment();
            i.Sirina = (int)SirinaSegmentaPix;
            i.Visina = (int)VisinaSegmentaPix;
            i.XLevo = (int)(SPA2.X - (4 * SirinaSegmentaPix));
            i.YGore = (int)((int)SPA3.Y + TopOffset + VertGapSegmenata * 2 + VisinaSegmentaPix);
            i.DebljinaOkvira = DebljinaOkviraSegmenta;
            i.BojaOkviraVertikale = BojaOkviraVertikale;
            i.OkvirPalete = OkvirPalete;
            i.BojaOkviraPalete = BojaOkviraPalete;
            i.DebljinaOkviraPalete = DebljinaOkviraPalete;
            i.BojaOkvira = BojaOkviraSegmenta;
            i.BojaNumeracije = BojaNumeracije;
            i.Numeracija = Numeracija;
            i.drawingContext = drawingContext;
            i.ID = "C24";
            seg = Segmenti.FirstOrDefault(x => x.ID == "C24");
            if (seg != null)
            {
                seg.Sirina = (int)SirinaSegmentaPix;
                seg.Visina = (int)VisinaSegmentaPix;
                seg.XLevo = (int)(SPA2.X - (4 * SirinaSegmentaPix));
                seg.YGore = (int)((int)SPA3.Y + TopOffset + VertGapSegmenata * 2 + VisinaSegmentaPix);
                seg.DebljinaOkvira = DebljinaOkviraSegmenta;
                seg.BojaOkviraVertikale = BojaOkviraVertikale;
                seg.OkvirPalete = OkvirPalete;
                seg.BojaOkviraPalete = BojaOkviraPalete;
                seg.DebljinaOkviraPalete = DebljinaOkviraPalete;
                seg.BojaOkvira = BojaOkviraSegmenta;
                seg.BojaNumeracije = BojaNumeracije;
                seg.Numeracija = Numeracija;
                seg.drawingContext = drawingContext;
                seg.ID = "C24";
            }
            else
                Segmenti.Add(i);

            i = new Segment();
            i.Sirina = (int)SirinaSegmentaPix;
            i.Visina = (int)VisinaSegmentaPix;
            i.XLevo = (int)(SPA2.X - SirinaSegmentaPix);
            i.YGore = (int)((int)SPA3.Y + TopOffset + VertGapSegmenata * 2 + VisinaSegmentaPix * 2);
            i.DebljinaOkvira = DebljinaOkviraSegmenta;
            i.BojaOkviraVertikale = BojaOkviraVertikale;
            i.OkvirPalete = OkvirPalete;
            i.BojaOkviraPalete = BojaOkviraPalete;
            i.DebljinaOkviraPalete = DebljinaOkviraPalete;
            i.BojaOkvira = BojaOkviraSegmenta;
            i.BojaNumeracije = BojaNumeracije;
            i.Numeracija = Numeracija;
            i.drawingContext = drawingContext;
            i.ID = "C25";
            seg = Segmenti.FirstOrDefault(x => x.ID == "C25");
            if (seg != null)
            {
                seg.Sirina = (int)SirinaSegmentaPix;
                seg.Visina = (int)VisinaSegmentaPix;
                seg.XLevo = (int)(SPA2.X - SirinaSegmentaPix);
                seg.YGore = (int)((int)SPA3.Y + TopOffset + VertGapSegmenata * 2 + VisinaSegmentaPix * 2);
                seg.DebljinaOkvira = DebljinaOkviraSegmenta;
                seg.BojaOkviraVertikale = BojaOkviraVertikale;
                seg.OkvirPalete = OkvirPalete;
                seg.BojaOkviraPalete = BojaOkviraPalete;
                seg.DebljinaOkviraPalete = DebljinaOkviraPalete;
                seg.BojaOkvira = BojaOkviraSegmenta;
                seg.BojaNumeracije = BojaNumeracije;
                seg.Numeracija = Numeracija;
                seg.drawingContext = drawingContext;
                seg.ID = "C25";
            }
            else
                Segmenti.Add(i);


            i = new Segment();
            i.Sirina = (int)SirinaSegmentaPix;
            i.Visina = (int)VisinaSegmentaPix;
            i.XLevo = (int)(SPA2.X - (SirinaSegmentaPix * 2));
            i.YGore = (int)((int)SPA3.Y + TopOffset + VertGapSegmenata * 2 + VisinaSegmentaPix * 2);
            i.DebljinaOkvira = DebljinaOkviraSegmenta;
            i.BojaOkviraVertikale = BojaOkviraVertikale;
            i.OkvirPalete = OkvirPalete;
            i.BojaOkviraPalete = BojaOkviraPalete;
            i.DebljinaOkviraPalete = DebljinaOkviraPalete;
            i.BojaOkvira = BojaOkviraSegmenta;
            i.BojaNumeracije = BojaNumeracije;
            i.Numeracija = Numeracija;
            i.drawingContext = drawingContext;
            i.ID = "C26";
            seg = Segmenti.FirstOrDefault(x => x.ID == "C26");
            if (seg != null)
            {
                seg.Sirina = (int)SirinaSegmentaPix;
                seg.Visina = (int)VisinaSegmentaPix;
                seg.XLevo = (int)(SPA2.X - (SirinaSegmentaPix * 2));
                seg.YGore = (int)((int)SPA3.Y + TopOffset + VertGapSegmenata * 2 + VisinaSegmentaPix * 2);
                seg.DebljinaOkvira = DebljinaOkviraSegmenta;
                seg.BojaOkviraVertikale = BojaOkviraVertikale;
                seg.OkvirPalete = OkvirPalete;
                seg.BojaOkviraPalete = BojaOkviraPalete;
                seg.DebljinaOkviraPalete = DebljinaOkviraPalete;
                seg.BojaOkvira = BojaOkviraSegmenta;
                seg.BojaNumeracije = BojaNumeracije;
                seg.Numeracija = Numeracija;
                seg.drawingContext = drawingContext;
                seg.ID = "C26";
            }
            else
                Segmenti.Add(i);

            i = new Segment();
            i.Sirina = (int)SirinaSegmentaPix;
            i.Visina = (int)VisinaSegmentaPix;
            i.XLevo = (int)(SPA2.X - (3 * SirinaSegmentaPix));
            i.YGore = (int)((int)SPA3.Y + TopOffset + VertGapSegmenata * 2 + VisinaSegmentaPix * 2);
            i.DebljinaOkvira = DebljinaOkviraSegmenta;
            i.BojaOkviraVertikale = BojaOkviraVertikale;
            i.OkvirPalete = OkvirPalete;
            i.BojaOkviraPalete = BojaOkviraPalete;
            i.DebljinaOkviraPalete = DebljinaOkviraPalete;
            i.BojaOkvira = BojaOkviraSegmenta;
            i.BojaNumeracije = BojaNumeracije;
            i.Numeracija = Numeracija;
            i.drawingContext = drawingContext;
            i.ID = "C27";
            seg = Segmenti.FirstOrDefault(x => x.ID == "C27");
            if (seg != null)
            {
                seg.Sirina = (int)SirinaSegmentaPix;
                seg.Visina = (int)VisinaSegmentaPix;
                seg.XLevo = (int)(SPA2.X - (3 * SirinaSegmentaPix));
                seg.YGore = (int)((int)SPA3.Y + TopOffset + VertGapSegmenata * 2 + VisinaSegmentaPix * 2);
                seg.DebljinaOkvira = DebljinaOkviraSegmenta;
                seg.BojaOkviraVertikale = BojaOkviraVertikale;
                seg.OkvirPalete = OkvirPalete;
                seg.BojaOkviraPalete = BojaOkviraPalete;
                seg.DebljinaOkviraPalete = DebljinaOkviraPalete;
                seg.BojaOkvira = BojaOkviraSegmenta;
                seg.BojaNumeracije = BojaNumeracije;
                seg.Numeracija = Numeracija;
                seg.drawingContext = drawingContext;
                seg.ID = "C27";
            }
            else
                Segmenti.Add(i);

            i = new Segment();
            i.Sirina = (int)SirinaSegmentaPix;
            i.Visina = (int)VisinaSegmentaPix;
            i.XLevo = (int)(SPA2.X - (4 * SirinaSegmentaPix));
            i.YGore = (int)((int)SPA3.Y + TopOffset + VertGapSegmenata * 2 + VisinaSegmentaPix * 2);
            i.DebljinaOkvira = DebljinaOkviraSegmenta;
            i.BojaOkviraVertikale = BojaOkviraVertikale;
            i.OkvirPalete = OkvirPalete;
            i.BojaOkviraPalete = BojaOkviraPalete;
            i.DebljinaOkviraPalete = DebljinaOkviraPalete;
            i.BojaOkvira = BojaOkviraSegmenta;
            i.BojaNumeracije = BojaNumeracije;
            i.Numeracija = Numeracija;
            i.drawingContext = drawingContext;
            i.ID = "C28";
            seg = Segmenti.FirstOrDefault(x => x.ID == "C28");
            if (seg != null)
            {
                seg.Sirina = (int)SirinaSegmentaPix;
                seg.Visina = (int)VisinaSegmentaPix;
                seg.XLevo = (int)(SPA2.X - (4 * SirinaSegmentaPix));
                seg.YGore = (int)((int)SPA3.Y + TopOffset + VertGapSegmenata  * 2 + VisinaSegmentaPix * 2);
                seg.DebljinaOkvira = DebljinaOkviraSegmenta;
                seg.BojaOkviraVertikale = BojaOkviraVertikale;
                seg.OkvirPalete = OkvirPalete;
                seg.BojaOkviraPalete = BojaOkviraPalete;
                seg.DebljinaOkviraPalete = DebljinaOkviraPalete;
                seg.BojaOkvira = BojaOkviraSegmenta;
                seg.BojaNumeracije = BojaNumeracije;
                seg.Numeracija = Numeracija;
                seg.drawingContext = drawingContext;
                seg.ID = "C28";
            }
            else
                Segmenti.Add(i);

            i = new Segment();
            i.Sirina = (int)SirinaSegmentaPix;
            i.Visina = (int)VisinaSegmentaPix;
            i.XLevo = (int)(SPA2.X - (5 * SirinaSegmentaPix));
            i.YGore = (int)((int)SPA3.Y + TopOffset + VertGapSegmenata * 2 + VisinaSegmentaPix * 2);
            i.DebljinaOkvira = DebljinaOkviraSegmenta;
            i.BojaOkviraVertikale = BojaOkviraVertikale;
            i.OkvirPalete = OkvirPalete;
            i.BojaOkviraPalete = BojaOkviraPalete;
            i.DebljinaOkviraPalete = DebljinaOkviraPalete;
            i.BojaOkvira = BojaOkviraSegmenta;
            i.BojaNumeracije = BojaNumeracije;
            i.Numeracija = Numeracija;
            i.drawingContext = drawingContext;
            i.ID = "C29";
            seg = Segmenti.FirstOrDefault(x => x.ID == "C29");
            if (seg != null)
            {
                seg.Sirina = (int)SirinaSegmentaPix;
                seg.Visina = (int)VisinaSegmentaPix;
                seg.XLevo = (int)(SPA2.X - (5 * SirinaSegmentaPix));
                seg.YGore = (int)((int)SPA3.Y + TopOffset + VertGapSegmenata * 2 + VisinaSegmentaPix * 2);
                seg.DebljinaOkvira = DebljinaOkviraSegmenta;
                seg.BojaOkviraVertikale = BojaOkviraVertikale;
                seg.OkvirPalete = OkvirPalete;
                seg.BojaOkviraPalete = BojaOkviraPalete;
                seg.DebljinaOkviraPalete = DebljinaOkviraPalete;
                seg.BojaOkvira = BojaOkviraSegmenta;
                seg.BojaNumeracije = BojaNumeracije;
                seg.Numeracija = Numeracija;
                seg.drawingContext = drawingContext;
                seg.ID = "C29";
            }
            else
                Segmenti.Add(i);

            i = new Segment();
            i.Sirina = (int)SirinaSegmentaPix;
            i.Visina = (int)VisinaSegmentaPix;
            i.XLevo = (int)(SPA2.X - (6 * SirinaSegmentaPix));
            i.YGore = (int)((int)SPA3.Y + TopOffset + VertGapSegmenata * 2 + VisinaSegmentaPix * 2);
            i.DebljinaOkvira = DebljinaOkviraSegmenta;
            i.BojaOkviraVertikale = BojaOkviraVertikale;
            i.OkvirPalete = OkvirPalete;
            i.BojaOkviraPalete = BojaOkviraPalete;
            i.DebljinaOkviraPalete = DebljinaOkviraPalete;
            i.BojaOkvira = BojaOkviraSegmenta;
            i.BojaNumeracije = BojaNumeracije;
            i.Numeracija = Numeracija;
            i.drawingContext = drawingContext;
            i.ID = "C30";
            seg = Segmenti.FirstOrDefault(x => x.ID == "C30");
            if (seg != null)
            {
                seg.Sirina = (int)SirinaSegmentaPix;
                seg.Visina = (int)VisinaSegmentaPix;
                seg.XLevo = (int)(SPA2.X - (6 * SirinaSegmentaPix));
                seg.YGore = (int)((int)SPA3.Y + TopOffset + VertGapSegmenata * 2 + VisinaSegmentaPix * 2);
                seg.DebljinaOkvira = DebljinaOkviraSegmenta;
                seg.BojaOkviraVertikale = BojaOkviraVertikale;
                seg.OkvirPalete = OkvirPalete;
                seg.BojaOkviraPalete = BojaOkviraPalete;
                seg.DebljinaOkviraPalete = DebljinaOkviraPalete;
                seg.BojaOkvira = BojaOkviraSegmenta;
                seg.BojaNumeracije = BojaNumeracije;
                seg.Numeracija = Numeracija;
                seg.drawingContext = drawingContext;
                seg.ID = "C30";
            }
            else
                Segmenti.Add(i);

            i = new Segment();
            i.Sirina = (int)SirinaSegmentaPix;
            i.Visina = (int)VisinaSegmentaPix;
            i.XLevo = (int)(SPA2.X - (7 * SirinaSegmentaPix));
            i.YGore = (int)((int)SPA3.Y + TopOffset + VertGapSegmenata * 2 + VisinaSegmentaPix * 2);
            i.DebljinaOkvira = DebljinaOkviraSegmenta;
            i.BojaOkviraVertikale = BojaOkviraVertikale;
            i.OkvirPalete = OkvirPalete;
            i.BojaOkviraPalete = BojaOkviraPalete;
            i.DebljinaOkviraPalete = DebljinaOkviraPalete;
            i.BojaOkvira = BojaOkviraSegmenta;
            i.BojaNumeracije = BojaNumeracije;
            i.Numeracija = Numeracija;
            i.drawingContext = drawingContext;
            i.ID = "C311";
            seg = Segmenti.FirstOrDefault(x => x.ID == "C311");
            if (seg != null)
            {
                seg.Sirina = (int)SirinaSegmentaPix;
                seg.Visina = (int)VisinaSegmentaPix;
                seg.XLevo = (int)(SPA2.X - (7 * SirinaSegmentaPix));
                seg.YGore = (int)((int)SPA3.Y + TopOffset + VertGapSegmenata * 2 + VisinaSegmentaPix * 2);
                seg.DebljinaOkvira = DebljinaOkviraSegmenta;
                seg.BojaOkviraVertikale = BojaOkviraVertikale;
                seg.OkvirPalete = OkvirPalete;
                seg.BojaOkviraPalete = BojaOkviraPalete;
                seg.DebljinaOkviraPalete = DebljinaOkviraPalete;
                seg.BojaOkvira = BojaOkviraSegmenta;
                seg.BojaNumeracije = BojaNumeracije;
                seg.Numeracija = Numeracija;
                seg.drawingContext = drawingContext;
                seg.ID = "C311";
            }
            else
                Segmenti.Add(i);

            i = new Segment();
            i.Sirina = (int)SirinaSegmentaPix;
            i.Visina = (int)VisinaSegmentaPix;
            i.XLevo = (int)(SPA2.X - (5 * SirinaSegmentaPix));
            i.YGore = (int)((int)SPA3.Y + TopOffset + VertGapSegmenata * 2 + VisinaSegmentaPix);
            i.DebljinaOkvira = DebljinaOkviraSegmenta;
            i.BojaOkviraVertikale = BojaOkviraVertikale;
            i.OkvirPalete = OkvirPalete;
            i.BojaOkviraPalete = BojaOkviraPalete;
            i.DebljinaOkviraPalete = DebljinaOkviraPalete;
            i.BojaOkvira = BojaOkviraSegmenta;
            i.BojaNumeracije = BojaNumeracije;
            i.Numeracija = Numeracija;
            i.drawingContext = drawingContext;
            i.ID = "C321";
            seg = Segmenti.FirstOrDefault(x => x.ID == "C321");
            if (seg != null)
            {
                seg.Sirina = (int)SirinaSegmentaPix;
                seg.Visina = (int)VisinaSegmentaPix;
                seg.XLevo = (int)(SPA2.X - (5 * SirinaSegmentaPix));
                seg.YGore = (int)((int)SPA3.Y + TopOffset + VertGapSegmenata * 2 + VisinaSegmentaPix);
                seg.DebljinaOkvira = DebljinaOkviraSegmenta;
                seg.BojaOkviraVertikale = BojaOkviraVertikale;
                seg.OkvirPalete = OkvirPalete;
                seg.BojaOkviraPalete = BojaOkviraPalete;
                seg.DebljinaOkviraPalete = DebljinaOkviraPalete;
                seg.BojaOkvira = BojaOkviraSegmenta;
                seg.BojaNumeracije = BojaNumeracije;
                seg.Numeracija = Numeracija;
                seg.drawingContext = drawingContext;
                seg.ID = "C321";
            }
            else
                Segmenti.Add(i);

            i = new Segment();
            i.Sirina = (int)SirinaSegmentaPix;
            i.Visina = (int)VisinaSegmentaPix;
            i.XLevo = (int)(SPA2.X - (6 * SirinaSegmentaPix));
            i.YGore = (int)((int)SPA3.Y + TopOffset + VertGapSegmenata * 2 + VisinaSegmentaPix);
            i.DebljinaOkvira = DebljinaOkviraSegmenta;
            i.BojaOkviraVertikale = BojaOkviraVertikale;
            i.OkvirPalete = OkvirPalete;
            i.BojaOkviraPalete = BojaOkviraPalete;
            i.DebljinaOkviraPalete = DebljinaOkviraPalete;
            i.BojaOkvira = BojaOkviraSegmenta;
            i.BojaNumeracije = BojaNumeracije;
            i.Numeracija = Numeracija;
            i.drawingContext = drawingContext;
            i.ID = "C331";
            seg = Segmenti.FirstOrDefault(x => x.ID == "C331");
            if (seg != null)
            {
                seg.Sirina = (int)SirinaSegmentaPix;
                seg.Visina = (int)VisinaSegmentaPix;
                seg.XLevo = (int)(SPA2.X - (6 * SirinaSegmentaPix));
                seg.YGore = (int)((int)SPA3.Y + TopOffset + VertGapSegmenata * 2 + VisinaSegmentaPix);
                seg.DebljinaOkvira = DebljinaOkviraSegmenta;
                seg.BojaOkviraVertikale = BojaOkviraVertikale;
                seg.OkvirPalete = OkvirPalete;
                seg.BojaOkviraPalete = BojaOkviraPalete;
                seg.DebljinaOkviraPalete = DebljinaOkviraPalete;
                seg.BojaOkvira = BojaOkviraSegmenta;
                seg.BojaNumeracije = BojaNumeracije;
                seg.Numeracija = Numeracija;
                seg.drawingContext = drawingContext;
                seg.ID = "C331";
            }
            else
                Segmenti.Add(i);

            i = new Segment();
            i.Sirina = (int)SirinaSegmentaPix;
            i.Visina = (int)VisinaSegmentaPix;
            i.XLevo = (int)(SPA2.X - (7 * SirinaSegmentaPix));
            i.YGore = (int)((int)SPA3.Y + TopOffset + VertGapSegmenata * 2 + VisinaSegmentaPix);
            i.DebljinaOkvira = DebljinaOkviraSegmenta;
            i.BojaOkviraVertikale = BojaOkviraVertikale;
            i.OkvirPalete = OkvirPalete;
            i.BojaOkviraPalete = BojaOkviraPalete;
            i.DebljinaOkviraPalete = DebljinaOkviraPalete;
            i.BojaOkvira = BojaOkviraSegmenta;
            i.BojaNumeracije = BojaNumeracije;
            i.Numeracija = Numeracija;
            i.drawingContext = drawingContext;
            i.ID = "C341";
            seg = Segmenti.FirstOrDefault(x => x.ID == "C341");
            if (seg != null)
            {
                seg.Sirina = (int)SirinaSegmentaPix;
                seg.Visina = (int)VisinaSegmentaPix;
                seg.XLevo = (int)(SPA2.X - (7 * SirinaSegmentaPix));
                seg.YGore = (int)((int)SPA3.Y + TopOffset + VertGapSegmenata * 2 + VisinaSegmentaPix);
                seg.DebljinaOkvira = DebljinaOkviraSegmenta;
                seg.BojaOkviraVertikale = BojaOkviraVertikale;
                seg.OkvirPalete = OkvirPalete;
                seg.BojaOkviraPalete = BojaOkviraPalete;
                seg.DebljinaOkviraPalete = DebljinaOkviraPalete;
                seg.BojaOkvira = BojaOkviraSegmenta;
                seg.BojaNumeracije = BojaNumeracije;
                seg.Numeracija = Numeracija;
                seg.drawingContext = drawingContext;
                seg.ID = "C341";
            }
            else
                Segmenti.Add(i);
        }

        public void CrtajC3()
        {
            Segment i = new Segment();
            i.Sirina = (int)SirinaSegmentaPix;
            i.Visina = (int)VisinaSegmentaPix;
            i.XLevo = (int)SPA3.X;
            i.YGore = (int)((int)SPA3.Y + TopOffset + 2 * VertGapSegmenata + VisinaSegmentaPix);
            i.DebljinaOkvira = DebljinaOkviraSegmenta;
            i.BojaOkviraVertikale = BojaOkviraVertikale ;
            i.OkvirPalete = OkvirPalete;
            i.BojaOkviraPalete = BojaOkviraPalete;
            i.DebljinaOkviraPalete = DebljinaOkviraPalete ;
            i.BojaOkvira = BojaOkviraSegmenta;
            i.BojaNumeracije = BojaNumeracije;
            i.Numeracija = Numeracija;
            i.drawingContext = drawingContext;
            i.ID = "C31";
            var seg = Segmenti.FirstOrDefault(x => x.ID == "C31");
            if (seg != null)
            {
                seg.Sirina = (int)SirinaSegmentaPix;
                seg.Visina = (int)VisinaSegmentaPix;
                seg.XLevo = (int)SPA3.X;
                seg.YGore = (int)((int)SPA3.Y + TopOffset + 2 * VertGapSegmenata + VisinaSegmentaPix);
                seg.DebljinaOkvira = DebljinaOkviraSegmenta;
                seg.BojaOkviraVertikale = BojaOkviraVertikale;
                seg.OkvirPalete = OkvirPalete;
                seg.BojaOkviraPalete = BojaOkviraPalete;
                seg.DebljinaOkviraPalete = DebljinaOkviraPalete;
                seg.BojaOkvira = BojaOkviraSegmenta;
                seg.BojaNumeracije = BojaNumeracije;
                seg.Numeracija = Numeracija;
                seg.drawingContext = drawingContext;
                seg.ID = "C31";
            }
            else
                Segmenti.Add(i);

            i = new Segment();
            i.Sirina = (int)SirinaSegmentaPix;
            i.Visina = (int)VisinaSegmentaPix;
            i.XLevo = (int)((int)SPA3.X + SirinaSegmentaPix);
            i.YGore = (int)((int)SPA3.Y + TopOffset + 2 * VertGapSegmenata + VisinaSegmentaPix);
            i.DebljinaOkvira = DebljinaOkviraSegmenta;
            i.BojaOkviraVertikale = BojaOkviraVertikale ;
            i.BojaOkvira = BojaOkviraSegmenta;
            i.OkvirPalete = OkvirPalete;
            i.BojaOkviraPalete = BojaOkviraPalete;
            i.DebljinaOkviraPalete = DebljinaOkviraPalete ;
            i.Numeracija = Numeracija;
            i.BojaNumeracije = BojaNumeracije;
            i.drawingContext = drawingContext;
            i.ID = "C32";
            seg = Segmenti.FirstOrDefault(x => x.ID == "C32");
            if (seg != null)
            {
                seg.Sirina = (int)SirinaSegmentaPix;
                seg.Visina = (int)VisinaSegmentaPix;
                seg.XLevo = (int)((int)SPA3.X + SirinaSegmentaPix);
                seg.YGore = (int)((int)SPA3.Y + TopOffset + 2 * VertGapSegmenata + VisinaSegmentaPix);
                seg.DebljinaOkvira = DebljinaOkviraSegmenta;
                seg.BojaOkviraVertikale = BojaOkviraVertikale;
                seg.BojaOkvira = BojaOkviraSegmenta;
                seg.OkvirPalete = OkvirPalete;
                seg.BojaOkviraPalete = BojaOkviraPalete;
                seg.DebljinaOkviraPalete = DebljinaOkviraPalete;
                seg.Numeracija = Numeracija;
                seg.BojaNumeracije = BojaNumeracije;
                seg.drawingContext = drawingContext;
                seg.ID = "C32";
            }
            else
                Segmenti.Add(i);

            i = new Segment();
            i.Sirina = (int)SirinaSegmentaPix;
            i.Visina = (int)VisinaSegmentaPix;
            i.XLevo = (int)SPA3.X;
            i.YGore = (int)((int)SPA3.Y + TopOffset + 2 * VertGapSegmenata + (2 * VisinaSegmentaPix));
            i.DebljinaOkvira = DebljinaOkviraSegmenta;
            i.BojaOkviraVertikale = BojaOkviraVertikale ;
            i.OkvirPalete = OkvirPalete;
            i.BojaOkviraPalete = BojaOkviraPalete;
            i.DebljinaOkviraPalete = DebljinaOkviraPalete ;
            i.BojaOkvira = BojaOkviraSegmenta;
            i.Numeracija = Numeracija;
            i.BojaNumeracije = BojaNumeracije;
            i.drawingContext = drawingContext;
            i.ID = "C33";
            seg = Segmenti.FirstOrDefault(x => x.ID == "C33");
            if (seg != null)
            {
                seg.Sirina = (int)SirinaSegmentaPix;
                seg.Visina = (int)VisinaSegmentaPix;
                seg.XLevo = (int)SPA3.X;
                seg.YGore = (int)((int)SPA3.Y + TopOffset + 2 * VertGapSegmenata + (2 * VisinaSegmentaPix));
                seg.DebljinaOkvira = DebljinaOkviraSegmenta;
                seg.BojaOkviraVertikale = BojaOkviraVertikale;
                seg.OkvirPalete = OkvirPalete;
                seg.BojaOkviraPalete = BojaOkviraPalete;
                seg.DebljinaOkviraPalete = DebljinaOkviraPalete;
                seg.BojaOkvira = BojaOkviraSegmenta;
                seg.Numeracija = Numeracija;
                seg.BojaNumeracije = BojaNumeracije;
                seg.drawingContext = drawingContext;
                seg.ID = "C33";
            }
            else
                Segmenti.Add(i);

            i = new Segment();
            i.Sirina = (int)SirinaSegmentaPix;
            i.Visina = (int)VisinaSegmentaPix;
            i.XLevo = (int)((int)SPA3.X + SirinaSegmentaPix);
            i.YGore = (int)((int)SPA3.Y + TopOffset + 2 * VertGapSegmenata + (2 * VisinaSegmentaPix));
            i.DebljinaOkvira = DebljinaOkviraSegmenta;
            i.BojaOkviraVertikale = BojaOkviraVertikale ;
            i.BojaOkvira = BojaOkviraSegmenta;
            i.OkvirPalete = OkvirPalete;
            i.BojaNumeracije = BojaNumeracije;
            i.BojaOkviraPalete = BojaOkviraPalete;
            i.DebljinaOkviraPalete = DebljinaOkviraPalete ;
            i.Numeracija = Numeracija;
            i.drawingContext = drawingContext;
            i.ID = "C34";
            seg = Segmenti.FirstOrDefault(x => x.ID == "C34");
            if (seg != null)
            {
                seg.Sirina = (int)SirinaSegmentaPix;
                seg.Visina = (int)VisinaSegmentaPix;
                seg.XLevo = (int)((int)SPA3.X + SirinaSegmentaPix);
                seg.YGore = (int)((int)SPA3.Y + TopOffset + 2 * VertGapSegmenata + (2 * VisinaSegmentaPix));
                seg.DebljinaOkvira = DebljinaOkviraSegmenta;
                seg.BojaOkviraVertikale = BojaOkviraVertikale;
                seg.BojaOkvira = BojaOkviraSegmenta;
                seg.OkvirPalete = OkvirPalete;
                seg.BojaNumeracije = BojaNumeracije;
                seg.BojaOkviraPalete = BojaOkviraPalete;
                seg.DebljinaOkviraPalete = DebljinaOkviraPalete;
                seg.Numeracija = Numeracija;
                seg.drawingContext = drawingContext;
                seg.ID = "C34";
            }
            else
                Segmenti.Add(i);
        }

        public void CrtajD3()
        {
            Segment i = new Segment();
            i.Sirina = (int)SirinaSegmentaPix;
            i.Visina = (int)VisinaSegmentaPix;
            i.XLevo = (int)SPA3.X;
            i.YGore = (int)((int)SPA3.Y + TopOffset + 3 * VertGapSegmenata + (2 * VisinaSegmentaPix));
            i.DebljinaOkvira = DebljinaOkviraSegmenta;
            i.BojaOkviraVertikale = BojaOkviraVertikale ;
            i.OkvirPalete = OkvirPalete;
            i.BojaOkviraPalete = BojaOkviraPalete;
            i.DebljinaOkviraPalete = DebljinaOkviraPalete ;
            i.BojaOkvira = BojaOkviraSegmenta;
            i.Numeracija = Numeracija;
            i.BojaNumeracije = BojaNumeracije;
            i.drawingContext = drawingContext;
            i.ID = "D31";
            var seg = Segmenti.FirstOrDefault(x => x.ID == "D31");
            if (seg != null)
            {
                seg.Sirina = (int)SirinaSegmentaPix;
                seg.Visina = (int)VisinaSegmentaPix;
                seg.XLevo = (int)SPA3.X;
                seg.YGore = (int)((int)SPA3.Y + TopOffset + 3 * VertGapSegmenata + (2 * VisinaSegmentaPix));
                seg.DebljinaOkvira = DebljinaOkviraSegmenta;
                seg.BojaOkviraVertikale = BojaOkviraVertikale;
                seg.OkvirPalete = OkvirPalete;
                seg.BojaOkviraPalete = BojaOkviraPalete;
                seg.DebljinaOkviraPalete = DebljinaOkviraPalete;
                seg.BojaOkvira = BojaOkviraSegmenta;
                seg.Numeracija = Numeracija;
                seg.BojaNumeracije = BojaNumeracije;
                seg.drawingContext = drawingContext;
                seg.ID = "D31";
            }
            else
                Segmenti.Add(i);

            i = new Segment();
            i.Sirina = (int)SirinaSegmentaPix;
            i.Visina = (int)VisinaSegmentaPix;
            i.XLevo = (int)((int)SPA3.X + SirinaSegmentaPix);
            i.YGore = (int)((int)SPA3.Y + TopOffset + 3 * VertGapSegmenata + (2 * VisinaSegmentaPix));
            i.DebljinaOkvira = DebljinaOkviraSegmenta;
            i.BojaOkviraVertikale = BojaOkviraVertikale ;
            i.OkvirPalete = OkvirPalete;
            i.BojaOkviraPalete = BojaOkviraPalete;
            i.DebljinaOkviraPalete = DebljinaOkviraPalete ;
            i.BojaOkvira = BojaOkviraSegmenta;
            i.Numeracija = Numeracija;
            i.BojaNumeracije = BojaNumeracije;
            i.drawingContext = drawingContext;
            i.ID = "D32";
            seg = Segmenti.FirstOrDefault(x => x.ID == "D32");
            if (seg != null)
            {
                seg.Sirina = (int)SirinaSegmentaPix;
                seg.Visina = (int)VisinaSegmentaPix;
                seg.XLevo = (int)((int)SPA3.X + SirinaSegmentaPix);
                seg.YGore = (int)((int)SPA3.Y + TopOffset + 3 * VertGapSegmenata + (2 * VisinaSegmentaPix));
                seg.DebljinaOkvira = DebljinaOkviraSegmenta;
                seg.BojaOkviraVertikale = BojaOkviraVertikale;
                seg.OkvirPalete = OkvirPalete;
                seg.BojaOkviraPalete = BojaOkviraPalete;
                seg.DebljinaOkviraPalete = DebljinaOkviraPalete;
                seg.BojaOkvira = BojaOkviraSegmenta;
                seg.Numeracija = Numeracija;
                seg.BojaNumeracije = BojaNumeracije;
                seg.drawingContext = drawingContext;
                seg.ID = "D32";
            }
                else
                Segmenti.Add(i);

            i = new Segment();
            i.Sirina = (int)SirinaSegmentaPix;
            i.Visina = (int)VisinaSegmentaPix;
            i.XLevo = (int)SPA3.X;
            i.YGore = (int)((int)SPA3.Y + TopOffset + 3 * VertGapSegmenata + (3 * VisinaSegmentaPix));
            i.DebljinaOkvira = DebljinaOkviraSegmenta;
            i.BojaOkviraVertikale = BojaOkviraVertikale ;
            i.OkvirPalete = OkvirPalete;
            i.BojaOkviraPalete = BojaOkviraPalete;
            i.DebljinaOkviraPalete = DebljinaOkviraPalete ;
            i.BojaOkvira = BojaOkviraSegmenta;
            i.Numeracija = Numeracija;
            i.BojaNumeracije = BojaNumeracije;
            i.drawingContext = drawingContext;
            i.ID = "D33";
            seg = Segmenti.FirstOrDefault(x => x.ID == "D33");
            if (seg != null)
            {
                seg.Sirina = (int)SirinaSegmentaPix;
                seg.Visina = (int)VisinaSegmentaPix;
                seg.XLevo = (int)SPA3.X;
                seg.YGore = (int)((int)SPA3.Y + TopOffset + 3 * VertGapSegmenata + (3 * VisinaSegmentaPix));
                seg.DebljinaOkvira = DebljinaOkviraSegmenta;
                seg.BojaOkviraVertikale = BojaOkviraVertikale;
                seg.OkvirPalete = OkvirPalete;
                seg.BojaOkviraPalete = BojaOkviraPalete;
                seg.DebljinaOkviraPalete = DebljinaOkviraPalete;
                seg.BojaOkvira = BojaOkviraSegmenta;
                seg.Numeracija = Numeracija;
                seg.BojaNumeracije = BojaNumeracije;
                seg.drawingContext = drawingContext;
                seg.ID = "D33";
            }
            else
                Segmenti.Add(i);

            i = new Segment();
            i.Sirina = (int)SirinaSegmentaPix;
            i.Visina = (int)VisinaSegmentaPix;
            i.XLevo = (int)((int)SPA3.X + SirinaSegmentaPix);
            i.YGore = (int)((int)SPA3.Y + TopOffset + 3 * VertGapSegmenata + (3 * VisinaSegmentaPix));
            i.DebljinaOkvira = DebljinaOkviraSegmenta;
            i.BojaOkviraVertikale = BojaOkviraVertikale ;
            i.BojaOkvira = BojaOkviraSegmenta;
            i.OkvirPalete = OkvirPalete;
            i.BojaOkviraPalete = BojaOkviraPalete;
            i.DebljinaOkviraPalete = DebljinaOkviraPalete ;
            i.Numeracija = Numeracija;
            i.BojaNumeracije = BojaNumeracije;
            i.drawingContext = drawingContext;
            i.ID = "D34";
            seg = Segmenti.FirstOrDefault(x => x.ID == "D34");
            if (seg != null)
            {
                seg.Sirina = (int)SirinaSegmentaPix;
                seg.Visina = (int)VisinaSegmentaPix;
                seg.XLevo = (int)((int)SPA3.X + SirinaSegmentaPix);
                seg.YGore = (int)((int)SPA3.Y + TopOffset + 3 * VertGapSegmenata + (3 * VisinaSegmentaPix));
                seg.DebljinaOkvira = DebljinaOkviraSegmenta;
                seg.BojaOkviraVertikale = BojaOkviraVertikale;
                seg.BojaOkvira = BojaOkviraSegmenta;
                seg.OkvirPalete = OkvirPalete;
                seg.BojaOkviraPalete = BojaOkviraPalete;
                seg.DebljinaOkviraPalete = DebljinaOkviraPalete;
                seg.Numeracija = Numeracija;
                seg.BojaNumeracije = BojaNumeracije;
                seg.drawingContext = drawingContext;
                seg.ID = "D34";
            }
            else
                Segmenti.Add(i);
        }

        public void CrtajE3()
        {
            Segment i = new Segment();
            i.Sirina = (int)SirinaSegmentaPix;
            i.Visina = (int)VisinaSegmentaPix;
            i.XLevo = (int)SPA3.X;
            i.YGore = (int)((int)SPA3.Y + TopOffset + 4 * VertGapSegmenata + (3 * VisinaSegmentaPix));
            i.DebljinaOkvira = DebljinaOkviraSegmenta;
            i.BojaOkviraVertikale = BojaOkviraVertikale ;
            i.OkvirPalete = OkvirPalete;
            i.BojaOkviraPalete = BojaOkviraPalete;
            i.DebljinaOkviraPalete = DebljinaOkviraPalete ;
            i.BojaOkvira = BojaOkviraSegmenta;
            i.Numeracija = Numeracija;
            i.BojaNumeracije = BojaNumeracije;
            i.drawingContext = drawingContext;
            i.ID = "E31";
            var seg = Segmenti.FirstOrDefault(x => x.ID == "E31");
            if (seg != null)
            {
                seg.Sirina = (int)SirinaSegmentaPix;
                seg.Visina = (int)VisinaSegmentaPix;
                seg.XLevo = (int)SPA3.X;
                seg.YGore = (int)((int)SPA3.Y + TopOffset + 4 * VertGapSegmenata + (3 * VisinaSegmentaPix));
                seg.DebljinaOkvira = DebljinaOkviraSegmenta;
                seg.BojaOkviraVertikale = BojaOkviraVertikale;
                seg.OkvirPalete = OkvirPalete;
                seg.BojaOkviraPalete = BojaOkviraPalete;
                seg.DebljinaOkviraPalete = DebljinaOkviraPalete;
                seg.BojaOkvira = BojaOkviraSegmenta;
                seg.Numeracija = Numeracija;
                seg.BojaNumeracije = BojaNumeracije;
                seg.drawingContext = drawingContext;
                seg.ID = "E31";
            }
            else
                Segmenti.Add(i);

            i = new Segment();
            i.Sirina = (int)SirinaSegmentaPix;
            i.Visina = (int)VisinaSegmentaPix;
            i.XLevo = (int)((int)SPA3.X + SirinaSegmentaPix);
            i.YGore = (int)((int)SPA3.Y + TopOffset + 4 * VertGapSegmenata + (3 * VisinaSegmentaPix));
            i.DebljinaOkvira = DebljinaOkviraSegmenta;
            i.BojaOkviraVertikale = BojaOkviraVertikale ;
            i.BojaOkvira = BojaOkviraSegmenta;
            i.OkvirPalete = OkvirPalete;
            i.BojaOkviraPalete = BojaOkviraPalete;
            i.DebljinaOkviraPalete = DebljinaOkviraPalete ;
            i.Numeracija = Numeracija;
            i.BojaNumeracije = BojaNumeracije;
            i.drawingContext = drawingContext;
            i.ID = "E32";
            seg = Segmenti.FirstOrDefault(x => x.ID == "E32");
            if (seg != null)
            {
                seg.Sirina = (int)SirinaSegmentaPix;
                seg.Visina = (int)VisinaSegmentaPix;
                seg.XLevo = (int)((int)SPA3.X + SirinaSegmentaPix);
                seg.YGore = (int)((int)SPA3.Y + TopOffset + 4 * VertGapSegmenata + (3 * VisinaSegmentaPix));
                seg.DebljinaOkvira = DebljinaOkviraSegmenta;
                seg.BojaOkviraVertikale = BojaOkviraVertikale;
                seg.BojaOkvira = BojaOkviraSegmenta;
                seg.OkvirPalete = OkvirPalete;
                seg.BojaOkviraPalete = BojaOkviraPalete;
                seg.DebljinaOkviraPalete = DebljinaOkviraPalete;
                seg.Numeracija = Numeracija;
                seg.BojaNumeracije = BojaNumeracije;
                seg.drawingContext = drawingContext;
                seg.ID = "E32";
            }
            else
                Segmenti.Add(i);

            i = new Segment();
            i.Sirina = (int)SirinaSegmentaPix;
            i.Visina = (int)VisinaSegmentaPix;
            i.XLevo = (int)SPA3.X;
            i.YGore = (int)((int)SPA3.Y + TopOffset + 4 * VertGapSegmenata + (4 * VisinaSegmentaPix));
            i.DebljinaOkvira = DebljinaOkviraSegmenta;
            i.BojaOkviraVertikale = BojaOkviraVertikale ;
            i.BojaOkvira = BojaOkviraSegmenta;
            i.OkvirPalete = OkvirPalete;
            i.BojaOkviraPalete = BojaOkviraPalete;
            i.DebljinaOkviraPalete = DebljinaOkviraPalete ;
            i.Numeracija = Numeracija;
            i.BojaNumeracije = BojaNumeracije;
            i.drawingContext = drawingContext;
            i.ID = "E33";
            seg = Segmenti.FirstOrDefault(x => x.ID == "E33");
            if (seg != null)
            {
                seg.Sirina = (int)SirinaSegmentaPix;
                seg.Visina = (int)VisinaSegmentaPix;
                seg.XLevo = (int)SPA3.X;
                seg.YGore = (int)((int)SPA3.Y + TopOffset + 4 * VertGapSegmenata + (4 * VisinaSegmentaPix));
                seg.DebljinaOkvira = DebljinaOkviraSegmenta;
                seg.BojaOkviraVertikale = BojaOkviraVertikale;
                seg.BojaOkvira = BojaOkviraSegmenta;
                seg.OkvirPalete = OkvirPalete;
                seg.BojaOkviraPalete = BojaOkviraPalete;
                seg.DebljinaOkviraPalete = DebljinaOkviraPalete;
                seg.Numeracija = Numeracija;
                seg.BojaNumeracije = BojaNumeracije;
                seg.drawingContext = drawingContext;
                seg.ID = "E33";
            }
            else
                Segmenti.Add(i);

            i = new Segment();
            i.Sirina = (int)SirinaSegmentaPix;
            i.Visina = (int)VisinaSegmentaPix;
            i.XLevo = (int)((int)SPA3.X + SirinaSegmentaPix);
            i.YGore = (int)((int)SPA3.Y + TopOffset + 4 * VertGapSegmenata + (4 * VisinaSegmentaPix));
            i.DebljinaOkvira = DebljinaOkviraSegmenta;
            i.BojaOkviraVertikale = BojaOkviraVertikale ;
            i.BojaOkvira = BojaOkviraSegmenta;
            i.OkvirPalete = OkvirPalete;
            i.BojaOkviraPalete = BojaOkviraPalete;
            i.DebljinaOkviraPalete = DebljinaOkviraPalete ;
            i.Numeracija = Numeracija;
            i.BojaNumeracije = BojaNumeracije;
            i.drawingContext = drawingContext;
            i.ID = "E34";
            seg = Segmenti.FirstOrDefault(x => x.ID == "E34");
            if (seg != null)
            {
                seg.Sirina = (int)SirinaSegmentaPix;
                seg.Visina = (int)VisinaSegmentaPix;
                seg.XLevo = (int)((int)SPA3.X + SirinaSegmentaPix);
                seg.YGore = (int)((int)SPA3.Y + TopOffset + 4 * VertGapSegmenata + (4 * VisinaSegmentaPix));
                seg.DebljinaOkvira = DebljinaOkviraSegmenta;
                seg.BojaOkviraVertikale = BojaOkviraVertikale;
                seg.BojaOkvira = BojaOkviraSegmenta;
                seg.OkvirPalete = OkvirPalete;
                seg.BojaOkviraPalete = BojaOkviraPalete;
                seg.DebljinaOkviraPalete = DebljinaOkviraPalete;
                seg.Numeracija = Numeracija;
                seg.BojaNumeracije = BojaNumeracije;
                seg.drawingContext = drawingContext;
                seg.ID = "E34";
            }
            else
                Segmenti.Add(i);
        }

        public void CrtajF3()
        {
            Segment i = new Segment();
            i.Sirina = (int)SirinaSegmentaPix;
            i.Visina = (int)VisinaSegmentaPix;
            i.XLevo = (int)SPA3.X;
            i.YGore = (int)((int)SPA3.Y + TopOffset + 5 * VertGapSegmenata + (4 * VisinaSegmentaPix));
            i.DebljinaOkvira = DebljinaOkviraSegmenta;
            i.BojaOkviraVertikale = BojaOkviraVertikale ;
            i.OkvirPalete = OkvirPalete;
            i.BojaOkviraPalete = BojaOkviraPalete;
            i.DebljinaOkviraPalete = DebljinaOkviraPalete ;
            i.BojaOkvira = BojaOkviraSegmenta;
            i.Numeracija = Numeracija;
            i.BojaNumeracije = BojaNumeracije;
            i.drawingContext = drawingContext;
            i.ID = "F31";
            var seg = Segmenti.FirstOrDefault(x => x.ID == "F31");
            if (seg != null)
            {
                seg.Sirina = (int)SirinaSegmentaPix;
                seg.Visina = (int)VisinaSegmentaPix;
                seg.XLevo = (int)SPA3.X;
                seg.YGore = (int)((int)SPA3.Y + TopOffset + 5 * VertGapSegmenata + (4 * VisinaSegmentaPix));
                seg.DebljinaOkvira = DebljinaOkviraSegmenta;
                seg.BojaOkviraVertikale = BojaOkviraVertikale;
                seg.OkvirPalete = OkvirPalete;
                seg.BojaOkviraPalete = BojaOkviraPalete;
                seg.DebljinaOkviraPalete = DebljinaOkviraPalete;
                seg.BojaOkvira = BojaOkviraSegmenta;
                seg.Numeracija = Numeracija;
                seg.BojaNumeracije = BojaNumeracije;
                seg.drawingContext = drawingContext;
                seg.ID = "F31";
            }
            else
                Segmenti.Add(i);

            i = new Segment();
            i.Sirina = (int)SirinaSegmentaPix;
            i.Visina = (int)VisinaSegmentaPix;
            i.XLevo = (int)((int)SPA3.X + SirinaSegmentaPix);
            i.YGore = (int)((int)SPA3.Y + TopOffset + 5 * VertGapSegmenata + (4 * VisinaSegmentaPix));
            i.DebljinaOkvira = DebljinaOkviraSegmenta;
            i.BojaOkviraVertikale = BojaOkviraVertikale ;
            i.BojaOkvira = BojaOkviraSegmenta;
            i.OkvirPalete = OkvirPalete;
            i.BojaOkviraPalete = BojaOkviraPalete;
            i.DebljinaOkviraPalete = DebljinaOkviraPalete ;
            i.Numeracija = Numeracija;
            i.BojaNumeracije = BojaNumeracije;
            i.drawingContext = drawingContext;
            i.ID = "F32";
            seg = Segmenti.FirstOrDefault(x => x.ID == "F32");
            if (seg != null)
            {
                seg.Sirina = (int)SirinaSegmentaPix;
                seg.Visina = (int)VisinaSegmentaPix;
                seg.XLevo = (int)((int)SPA3.X + SirinaSegmentaPix);
                seg.YGore = (int)((int)SPA3.Y + TopOffset + 5 * VertGapSegmenata + (4 * VisinaSegmentaPix));
                seg.DebljinaOkvira = DebljinaOkviraSegmenta;
                seg.BojaOkviraVertikale = BojaOkviraVertikale;
                seg.BojaOkvira = BojaOkviraSegmenta;
                seg.OkvirPalete = OkvirPalete;
                seg.BojaOkviraPalete = BojaOkviraPalete;
                seg.DebljinaOkviraPalete = DebljinaOkviraPalete;
                seg.Numeracija = Numeracija;
                seg.BojaNumeracije = BojaNumeracije;
                seg.drawingContext = drawingContext;
                seg.ID = "F32";
            }
            else
                Segmenti.Add(i);
        }

        public void CrtajD2()
        {

            Segment i = new Segment();
            i.Sirina = (int)SirinaSegmentaPix;
            i.Visina = (int)VisinaSegmentaPix;
            i.XLevo = (int)(SPA2.X - SirinaSegmentaPix);
            i.YGore = (int)((int)SPA3.Y + TopOffset + VertGapSegmenata * 3 + VisinaSegmentaPix * 2);
            i.DebljinaOkvira = DebljinaOkviraSegmenta;
            i.BojaOkviraVertikale = BojaOkviraVertikale;
            i.OkvirPalete = OkvirPalete;
            i.BojaOkviraPalete = BojaOkviraPalete;
            i.DebljinaOkviraPalete = DebljinaOkviraPalete;
            i.BojaNumeracije = BojaNumeracije;
            i.BojaOkvira = BojaOkviraSegmenta;
            i.Numeracija = Numeracija;
            i.drawingContext = drawingContext;
            i.ID = "D21";
            var seg = Segmenti.FirstOrDefault(x => x.ID == "D21");
            if (seg != null)
            {
                seg.Sirina = (int)SirinaSegmentaPix;
                seg.Visina = (int)VisinaSegmentaPix;
                seg.XLevo = (int)(SPA2.X - SirinaSegmentaPix);
                seg.YGore = (int)((int)SPA3.Y + TopOffset + VertGapSegmenata * 3 + VisinaSegmentaPix * 2);
                seg.DebljinaOkvira = DebljinaOkviraSegmenta;
                seg.BojaOkviraVertikale = BojaOkviraVertikale;
                seg.OkvirPalete = OkvirPalete;
                seg.BojaOkviraPalete = BojaOkviraPalete;
                seg.DebljinaOkviraPalete = DebljinaOkviraPalete;
                seg.BojaNumeracije = BojaNumeracije;
                seg.BojaOkvira = BojaOkviraSegmenta;
                seg.Numeracija = Numeracija;
                seg.drawingContext = drawingContext;
                seg.ID = "D21";
            }
            else
                Segmenti.Add(i);


            i = new Segment();
            i.Sirina = (int)SirinaSegmentaPix;
            i.Visina = (int)VisinaSegmentaPix;
            i.XLevo = (int)(SPA2.X - (SirinaSegmentaPix * 2));
            i.YGore = (int)((int)SPA3.Y + TopOffset + VertGapSegmenata * 3 + VisinaSegmentaPix * 2);
            i.DebljinaOkvira = DebljinaOkviraSegmenta;
            i.BojaOkviraVertikale = BojaOkviraVertikale;
            i.OkvirPalete = OkvirPalete;
            i.BojaOkviraPalete = BojaOkviraPalete;
            i.DebljinaOkviraPalete = DebljinaOkviraPalete;
            i.BojaNumeracije = BojaNumeracije;
            i.BojaOkvira = BojaOkviraSegmenta;
            i.Numeracija = Numeracija;
            i.drawingContext = drawingContext;
            i.ID = "D22";
            seg = Segmenti.FirstOrDefault(x => x.ID == "D22");
            if (seg != null)
            {
                seg.Sirina = (int)SirinaSegmentaPix;
                seg.Visina = (int)VisinaSegmentaPix;
                seg.XLevo = (int)(SPA2.X - (SirinaSegmentaPix * 2));
                seg.YGore = (int)((int)SPA3.Y + TopOffset + VertGapSegmenata * 3 + VisinaSegmentaPix * 2);
                seg.DebljinaOkvira = DebljinaOkviraSegmenta;
                seg.BojaOkviraVertikale = BojaOkviraVertikale;
                seg.OkvirPalete = OkvirPalete;
                seg.BojaOkviraPalete = BojaOkviraPalete;
                seg.DebljinaOkviraPalete = DebljinaOkviraPalete;
                seg.BojaNumeracije = BojaNumeracije;
                seg.BojaOkvira = BojaOkviraSegmenta;
                seg.Numeracija = Numeracija;
                seg.drawingContext = drawingContext;
                seg.ID = "D22";
            }
            else
                Segmenti.Add(i);

            i = new Segment();
            i.Sirina = (int)SirinaSegmentaPix;
            i.Visina = (int)VisinaSegmentaPix;
            i.XLevo = (int)(SPA2.X - (3 * SirinaSegmentaPix));
            i.YGore = (int)((int)SPA3.Y + TopOffset + VertGapSegmenata * 3 + VisinaSegmentaPix * 2);
            i.DebljinaOkvira = DebljinaOkviraSegmenta;
            i.BojaOkviraVertikale = BojaOkviraVertikale;
            i.OkvirPalete = OkvirPalete;
            i.BojaOkviraPalete = BojaOkviraPalete;
            i.DebljinaOkviraPalete = DebljinaOkviraPalete;
            i.BojaOkvira = BojaOkviraSegmenta;
            i.BojaNumeracije = BojaNumeracije;
            i.Numeracija = Numeracija;
            i.drawingContext = drawingContext;
            i.ID = "D23";
            seg = Segmenti.FirstOrDefault(x => x.ID == "D23");
            if (seg != null)
            {
                seg.Sirina = (int)SirinaSegmentaPix;
                seg.Visina = (int)VisinaSegmentaPix;
                seg.XLevo = (int)(SPA2.X - (3 * SirinaSegmentaPix));
                seg.YGore = (int)((int)SPA3.Y + TopOffset + VertGapSegmenata * 3 + VisinaSegmentaPix * 2);
                seg.DebljinaOkvira = DebljinaOkviraSegmenta;
                seg.BojaOkviraVertikale = BojaOkviraVertikale;
                seg.OkvirPalete = OkvirPalete;
                seg.BojaOkviraPalete = BojaOkviraPalete;
                seg.DebljinaOkviraPalete = DebljinaOkviraPalete;
                seg.BojaOkvira = BojaOkviraSegmenta;
                seg.BojaNumeracije = BojaNumeracije;
                seg.Numeracija = Numeracija;
                seg.drawingContext = drawingContext;
                seg.ID = "D23";
            }
            else
                Segmenti.Add(i);

            i = new Segment();
            i.Sirina = (int)SirinaSegmentaPix;
            i.Visina = (int)VisinaSegmentaPix;
            i.XLevo = (int)(SPA2.X - (4 * SirinaSegmentaPix));
            i.YGore = (int)((int)SPA3.Y + TopOffset + VertGapSegmenata * 3 + VisinaSegmentaPix * 2);
            i.DebljinaOkvira = DebljinaOkviraSegmenta;
            i.BojaOkviraVertikale = BojaOkviraVertikale;
            i.OkvirPalete = OkvirPalete;
            i.BojaOkviraPalete = BojaOkviraPalete;
            i.DebljinaOkviraPalete = DebljinaOkviraPalete;
            i.BojaOkvira = BojaOkviraSegmenta;
            i.BojaNumeracije = BojaNumeracije;
            i.Numeracija = Numeracija;
            i.drawingContext = drawingContext;
            i.ID = "D24";
            seg = Segmenti.FirstOrDefault(x => x.ID == "D24");
            if (seg != null)
            {
                seg.Sirina = (int)SirinaSegmentaPix;
                seg.Visina = (int)VisinaSegmentaPix;
                seg.XLevo = (int)(SPA2.X - (4 * SirinaSegmentaPix));
                seg.YGore = (int)((int)SPA3.Y + TopOffset + VertGapSegmenata * 3 + VisinaSegmentaPix * 2);
                seg.DebljinaOkvira = DebljinaOkviraSegmenta;
                seg.BojaOkviraVertikale = BojaOkviraVertikale;
                seg.OkvirPalete = OkvirPalete;
                seg.BojaOkviraPalete = BojaOkviraPalete;
                seg.DebljinaOkviraPalete = DebljinaOkviraPalete;
                seg.BojaOkvira = BojaOkviraSegmenta;
                seg.BojaNumeracije = BojaNumeracije;
                seg.Numeracija = Numeracija;
                seg.drawingContext = drawingContext;
                seg.ID = "D24";
            }
            else
                Segmenti.Add(i);

            i = new Segment();
            i.Sirina = (int)SirinaSegmentaPix;
            i.Visina = (int)VisinaSegmentaPix;
            i.XLevo = (int)(SPA2.X - SirinaSegmentaPix);
            i.YGore = (int)((int)SPA3.Y + TopOffset + VertGapSegmenata * 3 + VisinaSegmentaPix * 3);
            i.DebljinaOkvira = DebljinaOkviraSegmenta;
            i.BojaOkviraVertikale = BojaOkviraVertikale;
            i.OkvirPalete = OkvirPalete;
            i.BojaOkviraPalete = BojaOkviraPalete;
            i.DebljinaOkviraPalete = DebljinaOkviraPalete;
            i.BojaOkvira = BojaOkviraSegmenta;
            i.BojaNumeracije = BojaNumeracije;
            i.Numeracija = Numeracija;
            i.drawingContext = drawingContext;
            i.ID = "D25";
            seg = Segmenti.FirstOrDefault(x => x.ID == "D25");
            if (seg != null)
            {
                seg.Sirina = (int)SirinaSegmentaPix;
                seg.Visina = (int)VisinaSegmentaPix;
                seg.XLevo = (int)(SPA2.X - SirinaSegmentaPix);
                seg.YGore = (int)((int)SPA3.Y + TopOffset + VertGapSegmenata * 3 + VisinaSegmentaPix * 3);
                seg.DebljinaOkvira = DebljinaOkviraSegmenta;
                seg.BojaOkviraVertikale = BojaOkviraVertikale;
                seg.OkvirPalete = OkvirPalete;
                seg.BojaOkviraPalete = BojaOkviraPalete;
                seg.DebljinaOkviraPalete = DebljinaOkviraPalete;
                seg.BojaOkvira = BojaOkviraSegmenta;
                seg.BojaNumeracije = BojaNumeracije;
                seg.Numeracija = Numeracija;
                seg.drawingContext = drawingContext;
                seg.ID = "D25";
            }
            else
                Segmenti.Add(i);


            i = new Segment();
            i.Sirina = (int)SirinaSegmentaPix;
            i.Visina = (int)VisinaSegmentaPix;
            i.XLevo = (int)(SPA2.X - (SirinaSegmentaPix * 2));
            i.YGore = (int)((int)SPA3.Y + TopOffset + VertGapSegmenata * 3 + VisinaSegmentaPix * 3);
            i.DebljinaOkvira = DebljinaOkviraSegmenta;
            i.BojaOkviraVertikale = BojaOkviraVertikale;
            i.OkvirPalete = OkvirPalete;
            i.BojaOkviraPalete = BojaOkviraPalete;
            i.DebljinaOkviraPalete = DebljinaOkviraPalete;
            i.BojaOkvira = BojaOkviraSegmenta;
            i.BojaNumeracije = BojaNumeracije;
            i.Numeracija = Numeracija;
            i.drawingContext = drawingContext;
            i.ID = "D26";
            seg = Segmenti.FirstOrDefault(x => x.ID == "D26");
            if (seg != null)
            {
                seg.Sirina = (int)SirinaSegmentaPix;
                seg.Visina = (int)VisinaSegmentaPix;
                seg.XLevo = (int)(SPA2.X - (SirinaSegmentaPix * 2));
                seg.YGore = (int)((int)SPA3.Y + TopOffset + VertGapSegmenata * 3 + VisinaSegmentaPix * 3);
                seg.DebljinaOkvira = DebljinaOkviraSegmenta;
                seg.BojaOkviraVertikale = BojaOkviraVertikale;
                seg.OkvirPalete = OkvirPalete;
                seg.BojaOkviraPalete = BojaOkviraPalete;
                seg.DebljinaOkviraPalete = DebljinaOkviraPalete;
                seg.BojaOkvira = BojaOkviraSegmenta;
                seg.BojaNumeracije = BojaNumeracije;
                seg.Numeracija = Numeracija;
                seg.drawingContext = drawingContext;
                seg.ID = "D26";
            }
            else
                Segmenti.Add(i);

            i = new Segment();
            i.Sirina = (int)SirinaSegmentaPix;
            i.Visina = (int)VisinaSegmentaPix;
            i.XLevo = (int)(SPA2.X - (3 * SirinaSegmentaPix));
            i.YGore = (int)((int)SPA3.Y + TopOffset + VertGapSegmenata * 3 + VisinaSegmentaPix * 3);
            i.DebljinaOkvira = DebljinaOkviraSegmenta;
            i.BojaOkviraVertikale = BojaOkviraVertikale;
            i.OkvirPalete = OkvirPalete;
            i.BojaOkviraPalete = BojaOkviraPalete;
            i.DebljinaOkviraPalete = DebljinaOkviraPalete;
            i.BojaOkvira = BojaOkviraSegmenta;
            i.BojaNumeracije = BojaNumeracije;
            i.Numeracija = Numeracija;
            i.drawingContext = drawingContext;
            i.ID = "D27";
            seg = Segmenti.FirstOrDefault(x => x.ID == "D27");
            if (seg != null)
            {
                seg.Sirina = (int)SirinaSegmentaPix;
                seg.Visina = (int)VisinaSegmentaPix;
                seg.XLevo = (int)(SPA2.X - (3 * SirinaSegmentaPix));
                seg.YGore = (int)((int)SPA3.Y + TopOffset + VertGapSegmenata * 3 + VisinaSegmentaPix * 3);
                seg.DebljinaOkvira = DebljinaOkviraSegmenta;
                seg.BojaOkviraVertikale = BojaOkviraVertikale;
                seg.OkvirPalete = OkvirPalete;
                seg.BojaOkviraPalete = BojaOkviraPalete;
                seg.DebljinaOkviraPalete = DebljinaOkviraPalete;
                seg.BojaOkvira = BojaOkviraSegmenta;
                seg.BojaNumeracije = BojaNumeracije;
                seg.Numeracija = Numeracija;
                seg.drawingContext = drawingContext;
                seg.ID = "D27";
            }
            else
                Segmenti.Add(i);

            i = new Segment();
            i.Sirina = (int)SirinaSegmentaPix;
            i.Visina = (int)VisinaSegmentaPix;
            i.XLevo = (int)(SPA2.X - (4 * SirinaSegmentaPix));
            i.YGore = (int)((int)SPA3.Y + TopOffset + VertGapSegmenata * 3 + VisinaSegmentaPix * 3);
            i.DebljinaOkvira = DebljinaOkviraSegmenta;
            i.BojaOkviraVertikale = BojaOkviraVertikale;
            i.OkvirPalete = OkvirPalete;
            i.BojaOkviraPalete = BojaOkviraPalete;
            i.DebljinaOkviraPalete = DebljinaOkviraPalete;
            i.BojaOkvira = BojaOkviraSegmenta;
            i.BojaNumeracije = BojaNumeracije;
            i.Numeracija = Numeracija;
            i.drawingContext = drawingContext;
            i.ID = "D28";
            seg = Segmenti.FirstOrDefault(x => x.ID == "D28");
            if (seg != null)
            {
                seg.Sirina = (int)SirinaSegmentaPix;
                seg.Visina = (int)VisinaSegmentaPix;
                seg.XLevo = (int)(SPA2.X - (4 * SirinaSegmentaPix));
                seg.YGore = (int)((int)SPA3.Y + TopOffset + VertGapSegmenata * 3 + VisinaSegmentaPix * 3);
                seg.DebljinaOkvira = DebljinaOkviraSegmenta;
                seg.BojaOkviraVertikale = BojaOkviraVertikale;
                seg.OkvirPalete = OkvirPalete;
                seg.BojaOkviraPalete = BojaOkviraPalete;
                seg.DebljinaOkviraPalete = DebljinaOkviraPalete;
                seg.BojaOkvira = BojaOkviraSegmenta;
                seg.BojaNumeracije = BojaNumeracije;
                seg.Numeracija = Numeracija;
                seg.drawingContext = drawingContext;
                seg.ID = "D28";
            }
            else
                Segmenti.Add(i);

            i = new Segment();
            i.Sirina = (int)SirinaSegmentaPix;
            i.Visina = (int)VisinaSegmentaPix;
            i.XLevo = (int)(SPA2.X - (5 * SirinaSegmentaPix));
            i.YGore = (int)((int)SPA3.Y + TopOffset + VertGapSegmenata * 3 + VisinaSegmentaPix * 3);
            i.DebljinaOkvira = DebljinaOkviraSegmenta;
            i.BojaOkviraVertikale = BojaOkviraVertikale;
            i.OkvirPalete = OkvirPalete;
            i.BojaOkviraPalete = BojaOkviraPalete;
            i.DebljinaOkviraPalete = DebljinaOkviraPalete;
            i.BojaOkvira = BojaOkviraSegmenta;
            i.BojaNumeracije = BojaNumeracije;
            i.Numeracija = Numeracija;
            i.drawingContext = drawingContext;
            i.ID = "D29";
            seg = Segmenti.FirstOrDefault(x => x.ID == "D29");
            if (seg != null)
            {
                seg.Sirina = (int)SirinaSegmentaPix;
                seg.Visina = (int)VisinaSegmentaPix;
                seg.XLevo = (int)(SPA2.X - (5 * SirinaSegmentaPix));
                seg.YGore = (int)((int)SPA3.Y + TopOffset + VertGapSegmenata * 3 + VisinaSegmentaPix * 3);
                seg.DebljinaOkvira = DebljinaOkviraSegmenta;
                seg.BojaOkviraVertikale = BojaOkviraVertikale;
                seg.OkvirPalete = OkvirPalete;
                seg.BojaOkviraPalete = BojaOkviraPalete;
                seg.DebljinaOkviraPalete = DebljinaOkviraPalete;
                seg.BojaOkvira = BojaOkviraSegmenta;
                seg.BojaNumeracije = BojaNumeracije;
                seg.Numeracija = Numeracija;
                seg.drawingContext = drawingContext;
                seg.ID = "D29";
            }
            else
                Segmenti.Add(i);

            i = new Segment();
            i.Sirina = (int)SirinaSegmentaPix;
            i.Visina = (int)VisinaSegmentaPix;
            i.XLevo = (int)(SPA2.X - (6 * SirinaSegmentaPix));
            i.YGore = (int)((int)SPA3.Y + TopOffset + VertGapSegmenata * 3 + VisinaSegmentaPix * 3);
            i.DebljinaOkvira = DebljinaOkviraSegmenta;
            i.BojaOkviraVertikale = BojaOkviraVertikale;
            i.OkvirPalete = OkvirPalete;
            i.BojaOkviraPalete = BojaOkviraPalete;
            i.DebljinaOkviraPalete = DebljinaOkviraPalete;
            i.BojaOkvira = BojaOkviraSegmenta;
            i.BojaNumeracije = BojaNumeracije;
            i.Numeracija = Numeracija;
            i.drawingContext = drawingContext;
            i.ID = "D30";
            seg = Segmenti.FirstOrDefault(x => x.ID == "D30");
            if (seg != null)
            {
                seg.Sirina = (int)SirinaSegmentaPix;
                seg.Visina = (int)VisinaSegmentaPix;
                seg.XLevo = (int)(SPA2.X - (6 * SirinaSegmentaPix));
                seg.YGore = (int)((int)SPA3.Y + TopOffset + VertGapSegmenata * 3 + VisinaSegmentaPix * 3);
                seg.DebljinaOkvira = DebljinaOkviraSegmenta;
                seg.BojaOkviraVertikale = BojaOkviraVertikale;
                seg.OkvirPalete = OkvirPalete;
                seg.BojaOkviraPalete = BojaOkviraPalete;
                seg.DebljinaOkviraPalete = DebljinaOkviraPalete;
                seg.BojaOkvira = BojaOkviraSegmenta;
                seg.BojaNumeracije = BojaNumeracije;
                seg.Numeracija = Numeracija;
                seg.drawingContext = drawingContext;
                seg.ID = "D30";
            }
            else
                Segmenti.Add(i);

            i = new Segment();
            i.Sirina = (int)SirinaSegmentaPix;
            i.Visina = (int)VisinaSegmentaPix;
            i.XLevo = (int)(SPA2.X - (7 * SirinaSegmentaPix));
            i.YGore = (int)((int)SPA3.Y + TopOffset + VertGapSegmenata * 3 + VisinaSegmentaPix * 3);
            i.DebljinaOkvira = DebljinaOkviraSegmenta;
            i.BojaOkviraVertikale = BojaOkviraVertikale;
            i.OkvirPalete = OkvirPalete;
            i.BojaOkviraPalete = BojaOkviraPalete;
            i.DebljinaOkviraPalete = DebljinaOkviraPalete;
            i.BojaOkvira = BojaOkviraSegmenta;
            i.BojaNumeracije = BojaNumeracije;
            i.Numeracija = Numeracija;
            i.drawingContext = drawingContext;
            i.ID = "D311";
            seg = Segmenti.FirstOrDefault(x => x.ID == "D311");
            if (seg != null)
            {
                seg.Sirina = (int)SirinaSegmentaPix;
                seg.Visina = (int)VisinaSegmentaPix;
                seg.XLevo = (int)(SPA2.X - (7 * SirinaSegmentaPix));
                seg.YGore = (int)((int)SPA3.Y + TopOffset + VertGapSegmenata * 3 + VisinaSegmentaPix * 3);
                seg.DebljinaOkvira = DebljinaOkviraSegmenta;
                seg.BojaOkviraVertikale = BojaOkviraVertikale;
                seg.OkvirPalete = OkvirPalete;
                seg.BojaOkviraPalete = BojaOkviraPalete;
                seg.DebljinaOkviraPalete = DebljinaOkviraPalete;
                seg.BojaOkvira = BojaOkviraSegmenta;
                seg.BojaNumeracije = BojaNumeracije;
                seg.Numeracija = Numeracija;
                seg.drawingContext = drawingContext;
                seg.ID = "D311";
            }
            else
                Segmenti.Add(i);

            i = new Segment();
            i.Sirina = (int)SirinaSegmentaPix;
            i.Visina = (int)VisinaSegmentaPix;
            i.XLevo = (int)(SPA2.X - (5 * SirinaSegmentaPix));
            i.YGore = (int)((int)SPA3.Y + TopOffset + VertGapSegmenata * 3 + VisinaSegmentaPix * 2);
            i.DebljinaOkvira = DebljinaOkviraSegmenta;
            i.BojaOkviraVertikale = BojaOkviraVertikale;
            i.OkvirPalete = OkvirPalete;
            i.BojaOkviraPalete = BojaOkviraPalete;
            i.DebljinaOkviraPalete = DebljinaOkviraPalete;
            i.BojaOkvira = BojaOkviraSegmenta;
            i.BojaNumeracije = BojaNumeracije;
            i.Numeracija = Numeracija;
            i.drawingContext = drawingContext;
            i.ID = "D321";
            seg = Segmenti.FirstOrDefault(x => x.ID == "D321");
            if (seg != null)
            {
                seg.Sirina = (int)SirinaSegmentaPix;
                seg.Visina = (int)VisinaSegmentaPix;
                seg.XLevo = (int)(SPA2.X - (5 * SirinaSegmentaPix));
                seg.YGore = (int)((int)SPA3.Y + TopOffset + VertGapSegmenata * 3 + VisinaSegmentaPix * 2);
                seg.DebljinaOkvira = DebljinaOkviraSegmenta;
                seg.BojaOkviraVertikale = BojaOkviraVertikale;
                seg.OkvirPalete = OkvirPalete;
                seg.BojaOkviraPalete = BojaOkviraPalete;
                seg.DebljinaOkviraPalete = DebljinaOkviraPalete;
                seg.BojaOkvira = BojaOkviraSegmenta;
                seg.BojaNumeracije = BojaNumeracije;
                seg.Numeracija = Numeracija;
                seg.drawingContext = drawingContext;
                seg.ID = "D321";
            }
            else
                Segmenti.Add(i);

            i = new Segment();
            i.Sirina = (int)SirinaSegmentaPix;
            i.Visina = (int)VisinaSegmentaPix;
            i.XLevo = (int)(SPA2.X - (6 * SirinaSegmentaPix));
            i.YGore = (int)((int)SPA3.Y + TopOffset + VertGapSegmenata * 3 + VisinaSegmentaPix * 2);
            i.DebljinaOkvira = DebljinaOkviraSegmenta;
            i.BojaOkviraVertikale = BojaOkviraVertikale;
            i.OkvirPalete = OkvirPalete;
            i.BojaOkviraPalete = BojaOkviraPalete;
            i.DebljinaOkviraPalete = DebljinaOkviraPalete;
            i.BojaOkvira = BojaOkviraSegmenta;
            i.BojaNumeracije = BojaNumeracije;
            i.Numeracija = Numeracija;
            i.drawingContext = drawingContext;
            i.ID = "D331";
            seg = Segmenti.FirstOrDefault(x => x.ID == "D331");
            if (seg != null)
            {
                seg.Sirina = (int)SirinaSegmentaPix;
                seg.Visina = (int)VisinaSegmentaPix;
                seg.XLevo = (int)(SPA2.X - (6 * SirinaSegmentaPix));
                seg.YGore = (int)((int)SPA3.Y + TopOffset + VertGapSegmenata * 3 + VisinaSegmentaPix * 2);
                seg.DebljinaOkvira = DebljinaOkviraSegmenta;
                seg.BojaOkviraVertikale = BojaOkviraVertikale;
                seg.OkvirPalete = OkvirPalete;
                seg.BojaOkviraPalete = BojaOkviraPalete;
                seg.DebljinaOkviraPalete = DebljinaOkviraPalete;
                seg.BojaOkvira = BojaOkviraSegmenta;
                seg.BojaNumeracije = BojaNumeracije;
                seg.Numeracija = Numeracija;
                seg.drawingContext = drawingContext;
                seg.ID = "D331";
            }
            else
                Segmenti.Add(i);

            i = new Segment();
            i.Sirina = (int)SirinaSegmentaPix;
            i.Visina = (int)VisinaSegmentaPix;
            i.XLevo = (int)(SPA2.X - (7 * SirinaSegmentaPix));
            i.YGore = (int)((int)SPA3.Y + TopOffset + VertGapSegmenata * 3 + VisinaSegmentaPix * 2);
            i.DebljinaOkvira = DebljinaOkviraSegmenta;
            i.BojaOkviraVertikale = BojaOkviraVertikale;
            i.OkvirPalete = OkvirPalete;
            i.BojaOkviraPalete = BojaOkviraPalete;
            i.DebljinaOkviraPalete = DebljinaOkviraPalete;
            i.BojaOkvira = BojaOkviraSegmenta;
            i.BojaNumeracije = BojaNumeracije;
            i.Numeracija = Numeracija;
            i.drawingContext = drawingContext;
            i.ID = "D341";
            seg = Segmenti.FirstOrDefault(x => x.ID == "D341");
            if (seg != null)
            {
                seg.Sirina = (int)SirinaSegmentaPix;
                seg.Visina = (int)VisinaSegmentaPix;
                seg.XLevo = (int)(SPA2.X - (7 * SirinaSegmentaPix));
                seg.YGore = (int)((int)SPA3.Y + TopOffset + VertGapSegmenata * 3 + VisinaSegmentaPix * 2);
                seg.DebljinaOkvira = DebljinaOkviraSegmenta;
                seg.BojaOkviraVertikale = BojaOkviraVertikale;
                seg.OkvirPalete = OkvirPalete;
                seg.BojaOkviraPalete = BojaOkviraPalete;
                seg.DebljinaOkviraPalete = DebljinaOkviraPalete;
                seg.BojaOkvira = BojaOkviraSegmenta;
                seg.BojaNumeracije = BojaNumeracije;
                seg.Numeracija = Numeracija;
                seg.drawingContext = drawingContext;
                seg.ID = "D341";
            }
            else
                Segmenti.Add(i);
        }

        public void CrtajE2()
        {

            Segment i = new Segment();
            i.Sirina = (int)SirinaSegmentaPix;
            i.Visina = (int)VisinaSegmentaPix;
            i.XLevo = (int)(SPA2.X - SirinaSegmentaPix);
            i.YGore = (int)((int)SPA3.Y + TopOffset + VertGapSegmenata * 4 + VisinaSegmentaPix * 3);
            i.DebljinaOkvira = DebljinaOkviraSegmenta;
            i.BojaOkviraVertikale = BojaOkviraVertikale;
            i.OkvirPalete = OkvirPalete;
            i.BojaOkviraPalete = BojaOkviraPalete;
            i.DebljinaOkviraPalete = DebljinaOkviraPalete;
            i.BojaNumeracije = BojaNumeracije;
            i.BojaOkvira = BojaOkviraSegmenta;
            i.Numeracija = Numeracija;
            i.drawingContext = drawingContext;
            i.ID = "E21";
            var seg = Segmenti.FirstOrDefault(x => x.ID == "E21");
            if (seg != null)
            {
                seg.Sirina = (int)SirinaSegmentaPix;
                seg.Visina = (int)VisinaSegmentaPix;
                seg.XLevo = (int)(SPA2.X - SirinaSegmentaPix);
                seg.YGore = (int)((int)SPA3.Y + TopOffset + VertGapSegmenata * 4 + VisinaSegmentaPix * 3);
                seg.DebljinaOkvira = DebljinaOkviraSegmenta;
                seg.BojaOkviraVertikale = BojaOkviraVertikale;
                seg.OkvirPalete = OkvirPalete;
                seg.BojaOkviraPalete = BojaOkviraPalete;
                seg.DebljinaOkviraPalete = DebljinaOkviraPalete;
                seg.BojaNumeracije = BojaNumeracije;
                seg.BojaOkvira = BojaOkviraSegmenta;
                seg.Numeracija = Numeracija;
                seg.drawingContext = drawingContext;
                seg.ID = "E21";
            }
            else
                Segmenti.Add(i);


            i = new Segment();
            i.Sirina = (int)SirinaSegmentaPix;
            i.Visina = (int)VisinaSegmentaPix;
            i.XLevo = (int)(SPA2.X - (SirinaSegmentaPix * 2));
            i.YGore = (int)((int)SPA3.Y + TopOffset + VertGapSegmenata * 4 + VisinaSegmentaPix * 3);
            i.DebljinaOkvira = DebljinaOkviraSegmenta;
            i.BojaOkviraVertikale = BojaOkviraVertikale;
            i.OkvirPalete = OkvirPalete;
            i.BojaOkviraPalete = BojaOkviraPalete;
            i.DebljinaOkviraPalete = DebljinaOkviraPalete;
            i.BojaNumeracije = BojaNumeracije;
            i.BojaOkvira = BojaOkviraSegmenta;
            i.Numeracija = Numeracija;
            i.drawingContext = drawingContext;
            i.ID = "E22";
            seg = Segmenti.FirstOrDefault(x => x.ID == "E22");
            if (seg != null)
            {
                seg.Sirina = (int)SirinaSegmentaPix;
                seg.Visina = (int)VisinaSegmentaPix;
                seg.XLevo = (int)(SPA2.X - (SirinaSegmentaPix * 2));
                seg.YGore = (int)((int)SPA3.Y + TopOffset + VertGapSegmenata * 4 + VisinaSegmentaPix * 3);
                seg.DebljinaOkvira = DebljinaOkviraSegmenta;
                seg.BojaOkviraVertikale = BojaOkviraVertikale;
                seg.OkvirPalete = OkvirPalete;
                seg.BojaOkviraPalete = BojaOkviraPalete;
                seg.DebljinaOkviraPalete = DebljinaOkviraPalete;
                seg.BojaNumeracije = BojaNumeracije;
                seg.BojaOkvira = BojaOkviraSegmenta;
                seg.Numeracija = Numeracija;
                seg.drawingContext = drawingContext;
                seg.ID = "E22";
            }
            else
                Segmenti.Add(i);

            i = new Segment();
            i.Sirina = (int)SirinaSegmentaPix;
            i.Visina = (int)VisinaSegmentaPix;
            i.XLevo = (int)(SPA2.X - (3 * SirinaSegmentaPix));
            i.YGore = (int)((int)SPA3.Y + TopOffset + VertGapSegmenata * 4 + VisinaSegmentaPix * 3);
            i.DebljinaOkvira = DebljinaOkviraSegmenta;
            i.BojaOkviraVertikale = BojaOkviraVertikale;
            i.OkvirPalete = OkvirPalete;
            i.BojaOkviraPalete = BojaOkviraPalete;
            i.DebljinaOkviraPalete = DebljinaOkviraPalete;
            i.BojaOkvira = BojaOkviraSegmenta;
            i.BojaNumeracije = BojaNumeracije;
            i.Numeracija = Numeracija;
            i.drawingContext = drawingContext;
            i.ID = "E23";
            seg = Segmenti.FirstOrDefault(x => x.ID == "E23");
            if (seg != null)
            {
                seg.Sirina = (int)SirinaSegmentaPix;
                seg.Visina = (int)VisinaSegmentaPix;
                seg.XLevo = (int)(SPA2.X - (3 * SirinaSegmentaPix));
                seg.YGore = (int)((int)SPA3.Y + TopOffset + VertGapSegmenata * 4 + VisinaSegmentaPix * 3);
                seg.DebljinaOkvira = DebljinaOkviraSegmenta;
                seg.BojaOkviraVertikale = BojaOkviraVertikale;
                seg.OkvirPalete = OkvirPalete;
                seg.BojaOkviraPalete = BojaOkviraPalete;
                seg.DebljinaOkviraPalete = DebljinaOkviraPalete;
                seg.BojaOkvira = BojaOkviraSegmenta;
                seg.BojaNumeracije = BojaNumeracije;
                seg.Numeracija = Numeracija;
                seg.drawingContext = drawingContext;
                seg.ID = "E23";
            }
            else
                Segmenti.Add(i);

            i = new Segment();
            i.Sirina = (int)SirinaSegmentaPix;
            i.Visina = (int)VisinaSegmentaPix;
            i.XLevo = (int)(SPA2.X - (4 * SirinaSegmentaPix));
            i.YGore = (int)((int)SPA3.Y + TopOffset + VertGapSegmenata * 4 + VisinaSegmentaPix * 3);
            i.DebljinaOkvira = DebljinaOkviraSegmenta;
            i.BojaOkviraVertikale = BojaOkviraVertikale;
            i.OkvirPalete = OkvirPalete;
            i.BojaOkviraPalete = BojaOkviraPalete;
            i.DebljinaOkviraPalete = DebljinaOkviraPalete;
            i.BojaOkvira = BojaOkviraSegmenta;
            i.BojaNumeracije = BojaNumeracije;
            i.Numeracija = Numeracija;
            i.drawingContext = drawingContext;
            i.ID = "E24";
            seg = Segmenti.FirstOrDefault(x => x.ID == "E24");
            if (seg != null)
            {
                seg.Sirina = (int)SirinaSegmentaPix;
                seg.Visina = (int)VisinaSegmentaPix;
                seg.XLevo = (int)(SPA2.X - (4 * SirinaSegmentaPix));
                seg.YGore = (int)((int)SPA3.Y + TopOffset + VertGapSegmenata * 4 + VisinaSegmentaPix * 3);
                seg.DebljinaOkvira = DebljinaOkviraSegmenta;
                seg.BojaOkviraVertikale = BojaOkviraVertikale;
                seg.OkvirPalete = OkvirPalete;
                seg.BojaOkviraPalete = BojaOkviraPalete;
                seg.DebljinaOkviraPalete = DebljinaOkviraPalete;
                seg.BojaOkvira = BojaOkviraSegmenta;
                seg.BojaNumeracije = BojaNumeracije;
                seg.Numeracija = Numeracija;
                seg.drawingContext = drawingContext;
                seg.ID = "E24";
            }
            else
                Segmenti.Add(i);

            i = new Segment();
            i.Sirina = (int)SirinaSegmentaPix;
            i.Visina = (int)VisinaSegmentaPix;
            i.XLevo = (int)(SPA2.X - SirinaSegmentaPix);
            i.YGore = (int)((int)SPA3.Y + TopOffset + VertGapSegmenata * 4 + VisinaSegmentaPix * 4);
            i.DebljinaOkvira = DebljinaOkviraSegmenta;
            i.BojaOkviraVertikale = BojaOkviraVertikale;
            i.OkvirPalete = OkvirPalete;
            i.BojaOkviraPalete = BojaOkviraPalete;
            i.DebljinaOkviraPalete = DebljinaOkviraPalete;
            i.BojaOkvira = BojaOkviraSegmenta;
            i.BojaNumeracije = BojaNumeracije;
            i.Numeracija = Numeracija;
            i.drawingContext = drawingContext;
            i.ID = "E25";
            seg = Segmenti.FirstOrDefault(x => x.ID == "E25");
            if (seg != null)
            {
                seg.Sirina = (int)SirinaSegmentaPix;
                seg.Visina = (int)VisinaSegmentaPix;
                seg.XLevo = (int)(SPA2.X - SirinaSegmentaPix);
                seg.YGore = (int)((int)SPA3.Y + TopOffset + VertGapSegmenata * 4 + VisinaSegmentaPix * 4);
                seg.DebljinaOkvira = DebljinaOkviraSegmenta;
                seg.BojaOkviraVertikale = BojaOkviraVertikale;
                seg.OkvirPalete = OkvirPalete;
                seg.BojaOkviraPalete = BojaOkviraPalete;
                seg.DebljinaOkviraPalete = DebljinaOkviraPalete;
                seg.BojaOkvira = BojaOkviraSegmenta;
                seg.BojaNumeracije = BojaNumeracije;
                seg.Numeracija = Numeracija;
                seg.drawingContext = drawingContext;
                seg.ID = "E25";
            }
            else
                Segmenti.Add(i);


            i = new Segment();
            i.Sirina = (int)SirinaSegmentaPix;
            i.Visina = (int)VisinaSegmentaPix;
            i.XLevo = (int)(SPA2.X - (SirinaSegmentaPix * 2));
            i.YGore = (int)((int)SPA3.Y + TopOffset + VertGapSegmenata * 4 + VisinaSegmentaPix * 4);
            i.DebljinaOkvira = DebljinaOkviraSegmenta;
            i.BojaOkviraVertikale = BojaOkviraVertikale;
            i.OkvirPalete = OkvirPalete;
            i.BojaOkviraPalete = BojaOkviraPalete;
            i.DebljinaOkviraPalete = DebljinaOkviraPalete;
            i.BojaOkvira = BojaOkviraSegmenta;
            i.BojaNumeracije = BojaNumeracije;
            i.Numeracija = Numeracija;
            i.drawingContext = drawingContext;
            i.ID = "E26";
            seg = Segmenti.FirstOrDefault(x => x.ID == "E26");
            if (seg != null)
            {
                seg.Sirina = (int)SirinaSegmentaPix;
                seg.Visina = (int)VisinaSegmentaPix;
                seg.XLevo = (int)(SPA2.X - (SirinaSegmentaPix * 2));
                seg.YGore = (int)((int)SPA3.Y + TopOffset + VertGapSegmenata * 4 + VisinaSegmentaPix * 4);
                seg.DebljinaOkvira = DebljinaOkviraSegmenta;
                seg.BojaOkviraVertikale = BojaOkviraVertikale;
                seg.OkvirPalete = OkvirPalete;
                seg.BojaOkviraPalete = BojaOkviraPalete;
                seg.DebljinaOkviraPalete = DebljinaOkviraPalete;
                seg.BojaOkvira = BojaOkviraSegmenta;
                seg.BojaNumeracije = BojaNumeracije;
                seg.Numeracija = Numeracija;
                seg.drawingContext = drawingContext;
                seg.ID = "E26";
            }
            else
                Segmenti.Add(i);

            i = new Segment();
            i.Sirina = (int)SirinaSegmentaPix;
            i.Visina = (int)VisinaSegmentaPix;
            i.XLevo = (int)(SPA2.X - (3 * SirinaSegmentaPix));
            i.YGore = (int)((int)SPA3.Y + TopOffset + VertGapSegmenata * 4 + VisinaSegmentaPix * 4);
            i.DebljinaOkvira = DebljinaOkviraSegmenta;
            i.BojaOkviraVertikale = BojaOkviraVertikale;
            i.OkvirPalete = OkvirPalete;
            i.BojaOkviraPalete = BojaOkviraPalete;
            i.DebljinaOkviraPalete = DebljinaOkviraPalete;
            i.BojaOkvira = BojaOkviraSegmenta;
            i.BojaNumeracije = BojaNumeracije;
            i.Numeracija = Numeracija;
            i.drawingContext = drawingContext;
            i.ID = "E27";
            seg = Segmenti.FirstOrDefault(x => x.ID == "E27");
            if (seg != null)
            {
                seg.Sirina = (int)SirinaSegmentaPix;
                seg.Visina = (int)VisinaSegmentaPix;
                seg.XLevo = (int)(SPA2.X - (3 * SirinaSegmentaPix));
                seg.YGore = (int)((int)SPA3.Y + TopOffset + VertGapSegmenata * 4 + VisinaSegmentaPix * 4);
                seg.DebljinaOkvira = DebljinaOkviraSegmenta;
                seg.BojaOkviraVertikale = BojaOkviraVertikale;
                seg.OkvirPalete = OkvirPalete;
                seg.BojaOkviraPalete = BojaOkviraPalete;
                seg.DebljinaOkviraPalete = DebljinaOkviraPalete;
                seg.BojaOkvira = BojaOkviraSegmenta;
                seg.BojaNumeracije = BojaNumeracije;
                seg.Numeracija = Numeracija;
                seg.drawingContext = drawingContext;
                seg.ID = "E27";
            }
            else
                Segmenti.Add(i);

            i = new Segment();
            i.Sirina = (int)SirinaSegmentaPix;
            i.Visina = (int)VisinaSegmentaPix;
            i.XLevo = (int)(SPA2.X - (4 * SirinaSegmentaPix));
            i.YGore = (int)((int)SPA3.Y + TopOffset + VertGapSegmenata * 4 + VisinaSegmentaPix * 4);
            i.DebljinaOkvira = DebljinaOkviraSegmenta;
            i.BojaOkviraVertikale = BojaOkviraVertikale;
            i.OkvirPalete = OkvirPalete;
            i.BojaOkviraPalete = BojaOkviraPalete;
            i.DebljinaOkviraPalete = DebljinaOkviraPalete;
            i.BojaOkvira = BojaOkviraSegmenta;
            i.BojaNumeracije = BojaNumeracije;
            i.Numeracija = Numeracija;
            i.drawingContext = drawingContext;
            i.ID = "E28";
            seg = Segmenti.FirstOrDefault(x => x.ID == "E28");
            if (seg != null)
            {
                seg.Sirina = (int)SirinaSegmentaPix;
                seg.Visina = (int)VisinaSegmentaPix;
                seg.XLevo = (int)(SPA2.X - (4 * SirinaSegmentaPix));
                seg.YGore = (int)((int)SPA3.Y + TopOffset + VertGapSegmenata * 4 + VisinaSegmentaPix * 4);
                seg.DebljinaOkvira = DebljinaOkviraSegmenta;
                seg.BojaOkviraVertikale = BojaOkviraVertikale;
                seg.OkvirPalete = OkvirPalete;
                seg.BojaOkviraPalete = BojaOkviraPalete;
                seg.DebljinaOkviraPalete = DebljinaOkviraPalete;
                seg.BojaOkvira = BojaOkviraSegmenta;
                seg.BojaNumeracije = BojaNumeracije;
                seg.Numeracija = Numeracija;
                seg.drawingContext = drawingContext;
                seg.ID = "E28";
            }
            else
                Segmenti.Add(i);

            i = new Segment();
            i.Sirina = (int)SirinaSegmentaPix;
            i.Visina = (int)VisinaSegmentaPix;
            i.XLevo = (int)(SPA2.X - (5 * SirinaSegmentaPix));
            i.YGore = (int)((int)SPA3.Y + TopOffset + VertGapSegmenata * 4 + VisinaSegmentaPix * 4);
            i.DebljinaOkvira = DebljinaOkviraSegmenta;
            i.BojaOkviraVertikale = BojaOkviraVertikale;
            i.OkvirPalete = OkvirPalete;
            i.BojaOkviraPalete = BojaOkviraPalete;
            i.DebljinaOkviraPalete = DebljinaOkviraPalete;
            i.BojaOkvira = BojaOkviraSegmenta;
            i.BojaNumeracije = BojaNumeracije;
            i.Numeracija = Numeracija;
            i.drawingContext = drawingContext;
            i.ID = "E29";
            seg = Segmenti.FirstOrDefault(x => x.ID == "E29");
            if (seg != null)
            {
                seg.Sirina = (int)SirinaSegmentaPix;
                seg.Visina = (int)VisinaSegmentaPix;
                seg.XLevo = (int)(SPA2.X - (5 * SirinaSegmentaPix));
                seg.YGore = (int)((int)SPA3.Y + TopOffset + VertGapSegmenata * 4 + VisinaSegmentaPix * 4);
                seg.DebljinaOkvira = DebljinaOkviraSegmenta;
                seg.BojaOkviraVertikale = BojaOkviraVertikale;
                seg.OkvirPalete = OkvirPalete;
                seg.BojaOkviraPalete = BojaOkviraPalete;
                seg.DebljinaOkviraPalete = DebljinaOkviraPalete;
                seg.BojaOkvira = BojaOkviraSegmenta;
                seg.BojaNumeracije = BojaNumeracije;
                seg.Numeracija = Numeracija;
                seg.drawingContext = drawingContext;
                seg.ID = "E29";
            }
            else
                Segmenti.Add(i);

            i = new Segment();
            i.Sirina = (int)SirinaSegmentaPix;
            i.Visina = (int)VisinaSegmentaPix;
            i.XLevo = (int)(SPA2.X - (6 * SirinaSegmentaPix));
            i.YGore = (int)((int)SPA3.Y + TopOffset + VertGapSegmenata * 4 + VisinaSegmentaPix * 4);
            i.DebljinaOkvira = DebljinaOkviraSegmenta;
            i.BojaOkviraVertikale = BojaOkviraVertikale;
            i.OkvirPalete = OkvirPalete;
            i.BojaOkviraPalete = BojaOkviraPalete;
            i.DebljinaOkviraPalete = DebljinaOkviraPalete;
            i.BojaOkvira = BojaOkviraSegmenta;
            i.BojaNumeracije = BojaNumeracije;
            i.Numeracija = Numeracija;
            i.drawingContext = drawingContext;
            i.ID = "E30";
            seg = Segmenti.FirstOrDefault(x => x.ID == "E30");
            if (seg != null)
            {
                seg.Sirina = (int)SirinaSegmentaPix;
                seg.Visina = (int)VisinaSegmentaPix;
                seg.XLevo = (int)(SPA2.X - (6 * SirinaSegmentaPix));
                seg.YGore = (int)((int)SPA3.Y + TopOffset + VertGapSegmenata * 4 + VisinaSegmentaPix * 4);
                seg.DebljinaOkvira = DebljinaOkviraSegmenta;
                seg.BojaOkviraVertikale = BojaOkviraVertikale;
                seg.OkvirPalete = OkvirPalete;
                seg.BojaOkviraPalete = BojaOkviraPalete;
                seg.DebljinaOkviraPalete = DebljinaOkviraPalete;
                seg.BojaOkvira = BojaOkviraSegmenta;
                seg.BojaNumeracije = BojaNumeracije;
                seg.Numeracija = Numeracija;
                seg.drawingContext = drawingContext;
                seg.ID = "E30";
            }
            else
                Segmenti.Add(i);

            i = new Segment();
            i.Sirina = (int)SirinaSegmentaPix;
            i.Visina = (int)VisinaSegmentaPix;
            i.XLevo = (int)(SPA2.X - (7 * SirinaSegmentaPix));
            i.YGore = (int)((int)SPA3.Y + TopOffset + VertGapSegmenata * 4 + VisinaSegmentaPix * 4);
            i.DebljinaOkvira = DebljinaOkviraSegmenta;
            i.BojaOkviraVertikale = BojaOkviraVertikale;
            i.OkvirPalete = OkvirPalete;
            i.BojaOkviraPalete = BojaOkviraPalete;
            i.DebljinaOkviraPalete = DebljinaOkviraPalete;
            i.BojaOkvira = BojaOkviraSegmenta;
            i.BojaNumeracije = BojaNumeracije;
            i.Numeracija = Numeracija;
            i.drawingContext = drawingContext;
            i.ID = "E311";
            seg = Segmenti.FirstOrDefault(x => x.ID == "E311");
            if (seg != null)
            {
                seg.Sirina = (int)SirinaSegmentaPix;
                seg.Visina = (int)VisinaSegmentaPix;
                seg.XLevo = (int)(SPA2.X - (7 * SirinaSegmentaPix));
                seg.YGore = (int)((int)SPA3.Y + TopOffset + VertGapSegmenata * 4 + VisinaSegmentaPix * 4);
                seg.DebljinaOkvira = DebljinaOkviraSegmenta;
                seg.BojaOkviraVertikale = BojaOkviraVertikale;
                seg.OkvirPalete = OkvirPalete;
                seg.BojaOkviraPalete = BojaOkviraPalete;
                seg.DebljinaOkviraPalete = DebljinaOkviraPalete;
                seg.BojaOkvira = BojaOkviraSegmenta;
                seg.BojaNumeracije = BojaNumeracije;
                seg.Numeracija = Numeracija;
                seg.drawingContext = drawingContext;
                seg.ID = "E311";
            }
            else
                Segmenti.Add(i);

            i = new Segment();
            i.Sirina = (int)SirinaSegmentaPix;
            i.Visina = (int)VisinaSegmentaPix;
            i.XLevo = (int)(SPA2.X - (5 * SirinaSegmentaPix));
            i.YGore = (int)((int)SPA3.Y + TopOffset + VertGapSegmenata * 4 + VisinaSegmentaPix * 3);
            i.DebljinaOkvira = DebljinaOkviraSegmenta;
            i.BojaOkviraVertikale = BojaOkviraVertikale;
            i.OkvirPalete = OkvirPalete;
            i.BojaOkviraPalete = BojaOkviraPalete;
            i.DebljinaOkviraPalete = DebljinaOkviraPalete;
            i.BojaOkvira = BojaOkviraSegmenta;
            i.BojaNumeracije = BojaNumeracije;
            i.Numeracija = Numeracija;
            i.drawingContext = drawingContext;
            i.ID = "E321";
            seg = Segmenti.FirstOrDefault(x => x.ID == "E321");
            if (seg != null)
            {
                seg.Sirina = (int)SirinaSegmentaPix;
                seg.Visina = (int)VisinaSegmentaPix;
                seg.XLevo = (int)(SPA2.X - (5 * SirinaSegmentaPix));
                seg.YGore = (int)((int)SPA3.Y + TopOffset + VertGapSegmenata * 4 + VisinaSegmentaPix * 3);
                seg.DebljinaOkvira = DebljinaOkviraSegmenta;
                seg.BojaOkviraVertikale = BojaOkviraVertikale;
                seg.OkvirPalete = OkvirPalete;
                seg.BojaOkviraPalete = BojaOkviraPalete;
                seg.DebljinaOkviraPalete = DebljinaOkviraPalete;
                seg.BojaOkvira = BojaOkviraSegmenta;
                seg.BojaNumeracije = BojaNumeracije;
                seg.Numeracija = Numeracija;
                seg.drawingContext = drawingContext;
                seg.ID = "E321";
            }
            else
                Segmenti.Add(i);

            i = new Segment();
            i.Sirina = (int)SirinaSegmentaPix;
            i.Visina = (int)VisinaSegmentaPix;
            i.XLevo = (int)(SPA2.X - (6 * SirinaSegmentaPix));
            i.YGore = (int)((int)SPA3.Y + TopOffset + VertGapSegmenata * 4 + VisinaSegmentaPix * 3);
            i.DebljinaOkvira = DebljinaOkviraSegmenta;
            i.BojaOkviraVertikale = BojaOkviraVertikale;
            i.OkvirPalete = OkvirPalete;
            i.BojaOkviraPalete = BojaOkviraPalete;
            i.DebljinaOkviraPalete = DebljinaOkviraPalete;
            i.BojaOkvira = BojaOkviraSegmenta;
            i.BojaNumeracije = BojaNumeracije;
            i.Numeracija = Numeracija;
            i.drawingContext = drawingContext;
            i.ID = "E331";
            seg = Segmenti.FirstOrDefault(x => x.ID == "E331");
            if (seg != null)
            {
                seg.Sirina = (int)SirinaSegmentaPix;
                seg.Visina = (int)VisinaSegmentaPix;
                seg.XLevo = (int)(SPA2.X - (6 * SirinaSegmentaPix));
                seg.YGore = (int)((int)SPA3.Y + TopOffset + VertGapSegmenata * 4 + VisinaSegmentaPix * 3);
                seg.DebljinaOkvira = DebljinaOkviraSegmenta;
                seg.BojaOkviraVertikale = BojaOkviraVertikale;
                seg.OkvirPalete = OkvirPalete;
                seg.BojaOkviraPalete = BojaOkviraPalete;
                seg.DebljinaOkviraPalete = DebljinaOkviraPalete;
                seg.BojaOkvira = BojaOkviraSegmenta;
                seg.BojaNumeracije = BojaNumeracije;
                seg.Numeracija = Numeracija;
                seg.drawingContext = drawingContext;
                seg.ID = "E331";
            }
            else
                Segmenti.Add(i);

            i = new Segment();
            i.Sirina = (int)SirinaSegmentaPix;
            i.Visina = (int)VisinaSegmentaPix;
            i.XLevo = (int)(SPA2.X - (7 * SirinaSegmentaPix));
            i.YGore = (int)((int)SPA3.Y + TopOffset + VertGapSegmenata * 4 + VisinaSegmentaPix * 3);
            i.DebljinaOkvira = DebljinaOkviraSegmenta;
            i.BojaOkviraVertikale = BojaOkviraVertikale;
            i.OkvirPalete = OkvirPalete;
            i.BojaOkviraPalete = BojaOkviraPalete;
            i.DebljinaOkviraPalete = DebljinaOkviraPalete;
            i.BojaOkvira = BojaOkviraSegmenta;
            i.BojaNumeracije = BojaNumeracije;
            i.Numeracija = Numeracija;
            i.drawingContext = drawingContext;
            i.ID = "E341";
            seg = Segmenti.FirstOrDefault(x => x.ID == "E341");
            if (seg != null)
            {
                seg.Sirina = (int)SirinaSegmentaPix;
                seg.Visina = (int)VisinaSegmentaPix;
                seg.XLevo = (int)(SPA2.X - (7 * SirinaSegmentaPix));
                seg.YGore = (int)((int)SPA3.Y + TopOffset + VertGapSegmenata * 4 + VisinaSegmentaPix * 3);
                seg.DebljinaOkvira = DebljinaOkviraSegmenta;
                seg.BojaOkviraVertikale = BojaOkviraVertikale;
                seg.OkvirPalete = OkvirPalete;
                seg.BojaOkviraPalete = BojaOkviraPalete;
                seg.DebljinaOkviraPalete = DebljinaOkviraPalete;
                seg.BojaOkvira = BojaOkviraSegmenta;
                seg.BojaNumeracije = BojaNumeracije;
                seg.Numeracija = Numeracija;
                seg.drawingContext = drawingContext;
                seg.ID = "E341";
            }
            else
                Segmenti.Add(i);
        }

        public void CrtajF2()
        {

            Segment i = new Segment();
            i.Sirina = (int)SirinaSegmentaPix;
            i.Visina = (int)VisinaSegmentaPix;
            i.XLevo = (int)(SPA2.X - SirinaSegmentaPix);
            i.YGore = (int)(SPA2.Y + TopOffset + VertGapSegmenata * 5 + VisinaSegmentaPix * 4);
            i.DebljinaOkvira = DebljinaOkviraSegmenta;
            i.BojaOkviraVertikale = BojaOkviraVertikale;
            i.BojaNumeracije = BojaNumeracije;
            i.OkvirPalete = OkvirPalete;
            i.BojaOkviraPalete = BojaOkviraPalete;
            i.BojaOkvira = BojaOkviraSegmenta;
            i.DebljinaOkviraPalete = DebljinaOkviraPalete;
            i.Numeracija = Numeracija;
            i.drawingContext = drawingContext;
            i.ID = "F21";
            var seg = Segmenti.FirstOrDefault(x => x.ID == "F21");
            if (seg != null)
            {
                seg.Sirina = (int)SirinaSegmentaPix;
                seg.Visina = (int)VisinaSegmentaPix;
                seg.XLevo = (int)(SPA2.X - SirinaSegmentaPix);
                seg.YGore = (int)(SPA2.Y + TopOffset + VertGapSegmenata * 5 + VisinaSegmentaPix * 4);
                seg.DebljinaOkvira = DebljinaOkviraSegmenta;
                seg.BojaOkviraVertikale = BojaOkviraVertikale;
                seg.BojaNumeracije = BojaNumeracije;
                seg.OkvirPalete = OkvirPalete;
                seg.BojaOkviraPalete = BojaOkviraPalete;
                seg.BojaOkvira = BojaOkviraSegmenta;
                seg.DebljinaOkviraPalete = DebljinaOkviraPalete;
                seg.Numeracija = Numeracija;
                seg.drawingContext = drawingContext;
                seg.ID = "F21";
            }
            else
                Segmenti.Add(i);


            i = new Segment();
            i.Sirina = (int)SirinaSegmentaPix;
            i.Visina = (int)VisinaSegmentaPix;
            i.XLevo = (int)(SPA2.X - (SirinaSegmentaPix * 2));
            i.YGore = (int)(SPA2.Y + TopOffset + VertGapSegmenata * 5 + VisinaSegmentaPix * 4);
            i.DebljinaOkvira = DebljinaOkviraSegmenta;
            i.BojaOkviraVertikale = BojaOkviraVertikale;
            i.OkvirPalete = OkvirPalete;
            i.BojaOkviraPalete = BojaOkviraPalete;
            i.BojaOkvira = BojaOkviraSegmenta;
            i.BojaNumeracije = BojaNumeracije;
            i.DebljinaOkviraPalete = DebljinaOkviraPalete;
            i.Numeracija = Numeracija;
            i.drawingContext = drawingContext;
            i.ID = "F22";
            seg = Segmenti.FirstOrDefault(x => x.ID == "F22");
            if (seg != null)
            {
                seg.Sirina = (int)SirinaSegmentaPix;
                seg.Visina = (int)VisinaSegmentaPix;
                seg.XLevo = (int)(SPA2.X - SirinaSegmentaPix * 2);
                seg.YGore = (int)(SPA2.Y + TopOffset + VertGapSegmenata * 5 + VisinaSegmentaPix * 4);
                seg.DebljinaOkvira = DebljinaOkviraSegmenta;
                seg.BojaOkviraVertikale = BojaOkviraVertikale;
                seg.BojaNumeracije = BojaNumeracije;
                seg.OkvirPalete = OkvirPalete;
                seg.BojaOkviraPalete = BojaOkviraPalete;
                seg.BojaOkvira = BojaOkviraSegmenta;
                seg.DebljinaOkviraPalete = DebljinaOkviraPalete;
                seg.Numeracija = Numeracija;
                seg.drawingContext = drawingContext;
                seg.ID = "F22";
            }
            else
                Segmenti.Add(i);

            i = new Segment();
            i.Sirina = (int)SirinaSegmentaPix;
            i.Visina = (int)VisinaSegmentaPix;
            i.XLevo = (int)(SPA2.X - (3 * SirinaSegmentaPix));
            i.YGore = (int)(SPA2.Y + TopOffset + VertGapSegmenata * 5 + VisinaSegmentaPix * 4);
            i.DebljinaOkvira = DebljinaOkviraSegmenta;
            i.BojaOkviraVertikale = BojaOkviraVertikale;
            i.OkvirPalete = OkvirPalete;
            i.BojaOkviraPalete = BojaOkviraPalete;
            i.BojaOkvira = BojaOkviraSegmenta;
            i.BojaNumeracije = BojaNumeracije;
            i.DebljinaOkviraPalete = DebljinaOkviraPalete;
            i.Numeracija = Numeracija;
            i.drawingContext = drawingContext;
            i.ID = "F23";
            seg = Segmenti.FirstOrDefault(x => x.ID == "F23");
            if (seg != null)
            {
                seg.Sirina = (int)SirinaSegmentaPix;
                seg.Visina = (int)VisinaSegmentaPix;
                seg.XLevo = (int)(SPA2.X - SirinaSegmentaPix * 3);
                seg.YGore = (int)(SPA2.Y + TopOffset + VertGapSegmenata * 5 + VisinaSegmentaPix * 4);
                seg.DebljinaOkvira = DebljinaOkviraSegmenta;
                seg.BojaOkviraVertikale = BojaOkviraVertikale;
                seg.BojaNumeracije = BojaNumeracije;
                seg.OkvirPalete = OkvirPalete;
                seg.BojaOkviraPalete = BojaOkviraPalete;
                seg.BojaOkvira = BojaOkviraSegmenta;
                seg.DebljinaOkviraPalete = DebljinaOkviraPalete;
                seg.Numeracija = Numeracija;
                seg.drawingContext = drawingContext;
                seg.ID = "F23";
            }
            else
                Segmenti.Add(i);

            i = new Segment();
            i.Sirina = (int)SirinaSegmentaPix;
            i.Visina = (int)VisinaSegmentaPix;
            i.XLevo = (int)(SPA2.X - (4 * SirinaSegmentaPix));
            i.YGore = (int)(SPA2.Y + TopOffset + VertGapSegmenata * 5 + VisinaSegmentaPix * 4);
            i.DebljinaOkvira = DebljinaOkviraSegmenta;
            i.BojaOkviraVertikale = BojaOkviraVertikale;
            i.OkvirPalete = OkvirPalete;
            i.BojaOkviraPalete = BojaOkviraPalete;
            i.BojaOkvira = BojaOkviraSegmenta;
            i.BojaNumeracije = BojaNumeracije;
            i.DebljinaOkviraPalete = DebljinaOkviraPalete;
            i.Numeracija = Numeracija;
            i.drawingContext = drawingContext;
            i.ID = "F24";
            seg = Segmenti.FirstOrDefault(x => x.ID == "F24");
            if (seg != null)
            {
                seg.Sirina = (int)SirinaSegmentaPix;
                seg.Visina = (int)VisinaSegmentaPix;
                seg.XLevo = (int)(SPA2.X - SirinaSegmentaPix * 4);
                seg.YGore = (int)(SPA2.Y + TopOffset + VertGapSegmenata * 5 + VisinaSegmentaPix * 4);
                seg.DebljinaOkvira = DebljinaOkviraSegmenta;
                seg.BojaOkviraVertikale = BojaOkviraVertikale;
                seg.BojaNumeracije = BojaNumeracije;
                seg.OkvirPalete = OkvirPalete;
                seg.BojaOkviraPalete = BojaOkviraPalete;
                seg.BojaOkvira = BojaOkviraSegmenta;
                seg.DebljinaOkviraPalete = DebljinaOkviraPalete;
                seg.Numeracija = Numeracija;
                seg.drawingContext = drawingContext;
                seg.ID = "F24";
            }
            else
                Segmenti.Add(i);

            i = new Segment();
            i.Sirina = (int)SirinaSegmentaPix;
            i.Visina = (int)VisinaSegmentaPix;
            i.XLevo = (int)(SPA2.X - (5 * SirinaSegmentaPix));
            i.YGore = (int)(SPA2.Y + TopOffset + VertGapSegmenata * 5 + VisinaSegmentaPix * 4);
            i.DebljinaOkvira = DebljinaOkviraSegmenta;
            i.BojaOkviraVertikale = BojaOkviraVertikale;
            i.OkvirPalete = OkvirPalete;
            i.BojaOkviraPalete = BojaOkviraPalete;
            i.BojaOkvira = BojaOkviraSegmenta;
            i.BojaNumeracije = BojaNumeracije;
            i.DebljinaOkviraPalete = DebljinaOkviraPalete;
            i.Numeracija = Numeracija;
            i.drawingContext = drawingContext;
            i.ID = "F25";
            seg = Segmenti.FirstOrDefault(x => x.ID == "F25");
            if (seg != null)
            {
                seg.Sirina = (int)SirinaSegmentaPix;
                seg.Visina = (int)VisinaSegmentaPix;
                seg.XLevo = (int)(SPA2.X - SirinaSegmentaPix * 5);
                seg.YGore = (int)(SPA2.Y + TopOffset + VertGapSegmenata * 5 + VisinaSegmentaPix * 4);
                seg.DebljinaOkvira = DebljinaOkviraSegmenta;
                seg.BojaOkviraVertikale = BojaOkviraVertikale;
                seg.BojaNumeracije = BojaNumeracije;
                seg.OkvirPalete = OkvirPalete;
                seg.BojaOkviraPalete = BojaOkviraPalete;
                seg.BojaOkvira = BojaOkviraSegmenta;
                seg.DebljinaOkviraPalete = DebljinaOkviraPalete;
                seg.Numeracija = Numeracija;
                seg.drawingContext = drawingContext;
                seg.ID = "F25";
            }
            else
                Segmenti.Add(i);

            i = new Segment();
            i.Sirina = (int)SirinaSegmentaPix;
            i.Visina = (int)VisinaSegmentaPix;
            i.XLevo = (int)(SPA2.X - (6 * SirinaSegmentaPix));
            i.YGore = (int)(SPA2.Y + TopOffset + VertGapSegmenata * 5 + VisinaSegmentaPix * 4);
            i.DebljinaOkvira = DebljinaOkviraSegmenta;
            i.BojaOkviraVertikale = BojaOkviraVertikale;
            i.OkvirPalete = OkvirPalete;
            i.BojaOkviraPalete = BojaOkviraPalete;
            i.BojaOkvira = BojaOkviraSegmenta;
            i.BojaNumeracije = BojaNumeracije;
            i.DebljinaOkviraPalete = DebljinaOkviraPalete;
            i.Numeracija = Numeracija;
            i.drawingContext = drawingContext;
            i.ID = "F26";
            seg = Segmenti.FirstOrDefault(x => x.ID == "F26");
            if (seg != null)
            {
                seg.Sirina = (int)SirinaSegmentaPix;
                seg.Visina = (int)VisinaSegmentaPix;
                seg.XLevo = (int)(SPA2.X - SirinaSegmentaPix * 6);
                seg.YGore = (int)(SPA2.Y + TopOffset + VertGapSegmenata * 5 + VisinaSegmentaPix * 4);
                seg.DebljinaOkvira = DebljinaOkviraSegmenta;
                seg.BojaOkviraVertikale = BojaOkviraVertikale;
                seg.BojaNumeracije = BojaNumeracije;
                seg.OkvirPalete = OkvirPalete;
                seg.BojaOkviraPalete = BojaOkviraPalete;
                seg.BojaOkvira = BojaOkviraSegmenta;
                seg.DebljinaOkviraPalete = DebljinaOkviraPalete;
                seg.Numeracija = Numeracija;
                seg.drawingContext = drawingContext;
                seg.ID = "F26";
            }
            else
                Segmenti.Add(i);

            i = new Segment();
            i.Sirina = (int)SirinaSegmentaPix;
            i.Visina = (int)VisinaSegmentaPix;
            i.XLevo = (int)(SPA2.X - (7 * SirinaSegmentaPix));
            i.YGore = (int)(SPA2.Y + TopOffset + VertGapSegmenata * 5 + VisinaSegmentaPix * 4);
            i.DebljinaOkvira = DebljinaOkviraSegmenta;
            i.BojaOkviraVertikale = BojaOkviraVertikale;
            i.OkvirPalete = OkvirPalete;
            i.BojaOkviraPalete = BojaOkviraPalete;
            i.BojaOkvira = BojaOkviraSegmenta;
            i.BojaNumeracije = BojaNumeracije;
            i.DebljinaOkviraPalete = DebljinaOkviraPalete;
            i.Numeracija = Numeracija;
            i.drawingContext = drawingContext;
            i.ID = "F27";
            seg = Segmenti.FirstOrDefault(x => x.ID == "F27");
            if (seg != null)
            {
                seg.Sirina = (int)SirinaSegmentaPix;
                seg.Visina = (int)VisinaSegmentaPix;
                seg.XLevo = (int)(SPA2.X - SirinaSegmentaPix * 7);
                seg.YGore = (int)(SPA2.Y + TopOffset + VertGapSegmenata * 5 + VisinaSegmentaPix * 4);
                seg.DebljinaOkvira = DebljinaOkviraSegmenta;
                seg.BojaOkviraVertikale = BojaOkviraVertikale;
                seg.BojaNumeracije = BojaNumeracije;
                seg.OkvirPalete = OkvirPalete;
                seg.BojaOkviraPalete = BojaOkviraPalete;
                seg.BojaOkvira = BojaOkviraSegmenta;
                seg.DebljinaOkviraPalete = DebljinaOkviraPalete;
                seg.Numeracija = Numeracija;
                seg.drawingContext = drawingContext;
                seg.ID = "F27";
            }
            else
                Segmenti.Add(i);
        }
    }
}
