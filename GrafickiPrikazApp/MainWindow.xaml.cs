using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Linq;

namespace GrafickiPrikazApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        WareHouse Magacin = new WareHouse();
        ClickedPallete tekucaPaleta = new ClickedPallete();
        //static string Konekcija = "Data Source=MOHOK-SERVER\\MOHOKSQL;Initial Catalog=SOLUTION_MG_BlackHorse;Persist Security Info=True;User ID=sa;Password=TakiTasa032;MultipleActiveResultSets=True";
        static string Konekcija = "Data Source=MOHOK-NINO\\SQLEXPRESS;Initial Catalog=SOLUTION_MG_BlackHorse;Persist Security Info=True;User ID=sa;Password=TakiTasa032;MultipleActiveResultSets=True";
        static bool PrenosPalete = false;

        public MainWindow()
        {
            InitializeComponent();
        }

        #region "Forma"
        private void sizeChanged(object sender, SizeChangedEventArgs e)
        {

            Magacin.drawingContext = canMain;
            if (Width < 1024) Width = 1024;
            if (Height < 820) Height = 820;
            if(e.WidthChanged == true) canMain.Width = ActualWidth * 0.85;
            if (e.HeightChanged == true) canMain.Height = ActualHeight;

            canMain.Children.Clear();
            Magacin.Refresh();
        }

        private void winLoaded(object sender, RoutedEventArgs e)
        {
            Magacin.drawingContext = canMain;
            Magacin.BojaOkviraVertikale = Color.FromRgb(54, 84, 38);
            Magacin.BojaOkviraPalete = Color.FromRgb(187, 217, 171);
            Magacin.DebljinaOkvira = 1;
            Magacin.DebljinaOkviraSegmenta = 2;
            Magacin.DebljinaOkviraPalete = 2F;
            Magacin.BojaOkviraSegmenta = Color.FromRgb(97, 133, 148);
            Magacin.BojaNumeracije = Color.FromRgb(241, 246, 248);
            //Magacin.FormirajMagacin();
            cmbStatus.SelectedIndex = 0;

            DBtool dbtool = new DBtool(Konekcija);
            List<Lokacija> pal = new List<Lokacija>();

            pal = dbtool.DajSvePalete();

            foreach (var p in pal)
            {
                Magacin.SetPalet(p.LokacijaPalete, p.SifraArtikla, p.Naziv, p.Oznaka, p.JM, p.Kolicina, p.Status);
            }
            Magacin.Refresh();
        }

        private void canvasMouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if ((e.LeftButton == System.Windows.Input.MouseButtonState.Pressed) || (e.RightButton == System.Windows.Input.MouseButtonState.Pressed))
            {
                chkTrazi.IsChecked = false;
                Point p = e.GetPosition(canMain);
                ClickedPallete tmptekucaPaleta = new ClickedPallete();
                tmptekucaPaleta = Magacin.Kliked(p);

                if (PrenosPalete == true)
                {
                    PrenosPalete = false;
                    UnosPalete(tmptekucaPaleta.ID, Convert.ToInt32(tekucaPaleta.Sifra), tekucaPaleta.Naziv, tekucaPaleta.Oznaka, tekucaPaleta.JM, tekucaPaleta.Kolicina, tekucaPaleta.Status);
                    canMain.Cursor = System.Windows.Input.Cursors.Arrow;
                }

                if(tekucaPaleta != null)
                {
                    if(tekucaPaleta.Selektovana == true)
                    {
                        List<FrameworkElement> child = (from FrameworkElement c in canMain.Children where c.Tag.ToString() == "Selekted" select c).ToList();

                        foreach (var c in child)
                        {
                            canMain.Children.Remove(c);
                        }
                    }
                }
                tekucaPaleta = tmptekucaPaleta;
                if(tekucaPaleta.Kliked == true)
                {
                    txtSifra.Text = tekucaPaleta.Sifra;
                    txtNaziv.Text = tekucaPaleta.Naziv;
                    txtOznaka.Text = tekucaPaleta.Oznaka;
                    txtID.Text = tekucaPaleta.ID;
                    txtKolicina.Text = tekucaPaleta.Kolicina.ToString();
                    txtJM.Text = tekucaPaleta.JM;

                    List<Lokacija> loks = new List<Lokacija>();
                    DBtool dbtool = new DBtool(Konekcija);
                    loks = dbtool.DajPaletu(txtID.Text);

                    grdPalete.ItemsSource= loks;

                    tekucaPaleta.Selektovana = true;

                    Magacin.Refresh();

                    if (e.RightButton == System.Windows.Input.MouseButtonState.Pressed)
                    {
                        var pMenu = (System.Windows.Controls.ContextMenu)this.Resources["mnuPaleta"];
                        pMenu.IsOpen = true;
                    }
                }
                else
                {
                    tekucaPaleta.Selektovana = false;
                    List<FrameworkElement> child = (from FrameworkElement c in canMain.Children where c.Tag.ToString() == "Selekted" select c).ToList();

                    foreach(var c in child)
                    {
                        canMain.Children.Remove(c);
                    }

                    tekucaPaleta = null;
                    
                    Magacin.Refresh();
                }
            }

            
        }
        #endregion

        #region "Pop-Up meni za paletu
        private void mnuBrisanjePalete_Click(object sender, RoutedEventArgs e)
        {
            BrisiPaletu(Convert.ToInt32(txtSifra.Text), txtID.Text);
        }

        private void mnuUnosPalete_Click(object sender, RoutedEventArgs e)
        {
            frmPaleta frmP = new frmPaleta();
            frmP.ShowDialog();
        }

        private void mnuPrenosPalete_Click(object sender, RoutedEventArgs e)
        {
            PrenosPalete = true;
            canMain.Cursor = System.Windows.Input.Cursors.Hand;

            BrisiPaletu(Convert.ToInt32(tekucaPaleta.Sifra), tekucaPaleta.ID);
        }

        #endregion

        #region "Kontrole sa forme"

        private void cmdUnos_Click(object sender, RoutedEventArgs e)
        {
            UnosPalete(tekucaPaleta.ID, Convert.ToInt32(txtSifra.Text), txtNaziv.Text, txtOznaka.Text, txtJM.Text, float.Parse(txtKolicina.Text, CultureInfo.InvariantCulture.NumberFormat), cmbStatus.Text);
        }
        private void txtSifra_TextChanged(object sender, TextChangedEventArgs e)
        {
            DBtool dbtool = new DBtool(Konekcija);
            
            if (int.TryParse(txtSifra.Text, out _))
            {
                if(chkTrazi.IsChecked == true)
                {
                    NadjiPalete(Convert.ToInt32(txtSifra.Text));
                }
                else
                {
                    Artikal art = dbtool.GetArtikal(Convert.ToInt32(txtSifra.Text));
                    txtNaziv.Text = art.Naziv;
                    txtOznaka.Text = art.Oznaka;
                    txtJM.Text = art.JM;
                }
            }
            else
            {
                ResetujNadjenePalete();
                txtNaziv.Text = "";
                txtOznaka.Text = "";
                txtJM.Text = "";
            }
        }

        private void cmdUnosSve_Click(object sender, RoutedEventArgs e)
        {
            List<string> lokacije = new List<string>();
            List<Artikal> arts = new List<Artikal>();
            DBtool dbtool = new DBtool(Konekcija);

            lokacije = Magacin.DajSveLokacije();
            arts = dbtool.DajSveArtikle();
            Random rndart = new Random();
            Random rndkol = new Random();
            //Random rndlok = new Random();

            foreach (string s in lokacije)
            {
                int n = rndart.Next(0, arts.Count);
                dbtool.InsertPalete(arts[n].Sifra, arts[n].Oznaka, "Puna", s, (float)Convert.ToDecimal(rndkol.Next(10,50)));
            }
        }

        private void cmdBrisi_Click(object sender, RoutedEventArgs e)
        {
            BrisiPaletu(Convert.ToInt32(txtSifra.Text), txtID.Text);
        }

        private void chkTrazi_Click(object sender, RoutedEventArgs e)
        {
            if (chkTrazi.IsChecked == false)
            {
                ResetujNadjenePalete();
            }
            else
            {
                ResetujNadjenePalete();
                if (int.TryParse(txtSifra.Text, out _))
                {
                    NadjiPalete(Convert.ToInt32(txtSifra.Text));
                }
            }
        }

        #endregion

        #region "Pomocne funkcije"

        void NadjiPalete(int sifra)
        {
            List<string> listaNadjenih = new List<string>();
            listaNadjenih = Magacin.DajPaletePoSifri(sifra);
            if (listaNadjenih.Count > 0)
            {
                foreach (var p in listaNadjenih)
                {
                    Magacin.SetPaletFinded(p);
                }
                Magacin.Refresh();
            }
        }

        void ResetujNadjenePalete()
        {
            Magacin.ResetFinded();
            Magacin.Refresh();
        }

        void BrisiPaletu(int Sifra,string Lokacija)
        {
            DBtool dbtool = new DBtool(Konekcija);

            dbtool.BrisiPaletu(Sifra, Lokacija);

            Magacin.SetPalet(tekucaPaleta.ID, 0, "", "", "", 0, "Prazna");
            Magacin.Refresh();
        }

        void UnosPalete(string Lokacija,int Sifra,string Naziv,string Oznaka,string JM,float Kolicina,string Status)
        {
            Magacin.SetPalet(Lokacija, Sifra, Naziv, Oznaka, JM, Kolicina, Status);
            DBtool dbtool = new DBtool(Konekcija);
            dbtool.InsertPalete(Sifra, Oznaka, Status, Lokacija, Kolicina);
            Magacin.Refresh();
        }
        #endregion

        
    }
}
