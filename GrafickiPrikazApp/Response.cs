using GrafickiPrikazApp;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System;

public class ClickedPallete
{
    public ClickedPallete() 
    {
        paleta = new Paleta();
    }
    public Paleta paleta;

    public string Oznaka { get; set; }
    public string Sifra { get; set; }
    public bool Kliked { get; set; } = false;
    public string Status { get; set; }
    public string ID { get; set; }
    public string Naziv { get; set; }
    public float Kolicina { get; set; }
    public string JM { get; set; }
    public bool Selektovana { get; set; }
    public int SelIndex { get; set; }

}

public class Artikal
{
    public string Oznaka { get; set; }
    public int Sifra { get; set; }
    public string ID { get; set; }
    public string Naziv { get; set; }
    public string JM { get; set; }
}

public class Lokacija
{
    public string Oznaka { get; set; }
    public int SifraArtikla { get; set;}
    public string ID { get; set; }
    public string Status { get; set;}
    public string LokacijaPalete { get; set; }
    public string Naziv { get; set; }
    public float Kolicina { get; set; }
    public string JM { get; set; }
}