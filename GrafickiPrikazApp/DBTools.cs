using System.Collections.Generic;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;


namespace GrafickiPrikazApp
{
    public class DBtool
    {
        SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
        SqlConnection connection;

        public DBtool(string conn)
        {
            builder.ConnectionString = conn;
            connection = new SqlConnection(builder.ConnectionString);
        }


        public Artikal GetArtikal(int Sifra)
        {
            Artikal resp = new Artikal();
            SqlDataReader reader;
            SqlCommand cmd;
            try
            {
                connection.Open();

                cmd = new SqlCommand("SELECT * FROM SifarnikArtikli WHERE Sifra = " + Sifra, connection);

                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    resp.Sifra = (int)reader["Sifra"];
                    resp.JM = reader["JedinicaMere"].ToString();
                    resp.Naziv = reader["Naziv"].ToString();
                    resp.Oznaka = reader["Oznaka"].ToString();
                }
                reader.Close();
            }
            finally
            {
                connection.Close();
            }

            return resp;
        }

        public Artikal GetArtikal(string Naziv)
        {
            Artikal resp = new Artikal();
            SqlDataReader reader;
            SqlCommand cmd;
            try
            {
                connection.Open();

                cmd = new SqlCommand("SELECT * FROM SifarnikArtikli WHERE Naziv LIKE '" + Naziv + "%'" , connection);

                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    resp.Sifra = (int)reader["Sifra"];
                    resp.JM = reader["JedinicaMere"].ToString();
                    resp.Naziv = reader["Naziv"].ToString();
                    resp.Oznaka = reader["Oznaka"].ToString();
                }
                reader.Close();
            }
            finally
            {
                connection.Close();
            }

            return resp;
        }

        public List<Lokacija> DajPaletu(string Lokacija)
        {
            List<Lokacija> sifre = new List<Lokacija>();
            SqlDataReader reader;
            SqlCommand cmd;

            try
            {
                connection.Open();

                cmd = new SqlCommand("SELECT * FROM Palete WHERE Lokacija = '" + Lokacija + "'", connection);

                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Lokacija lok = new Lokacija();
                    lok.SifraArtikla = (int)reader["SifraArtikla"];
                    lok.LokacijaPalete = reader["Lokacija"].ToString();
                    lok.Oznaka = reader["Oznaka"].ToString();
                    lok.Status = reader["Status"].ToString();
                    lok.Kolicina = (float)Convert.ToDecimal(reader["Kolicina"].ToString());
                    sifre.Add( lok );
                }
                reader.Close();
            }
            finally
            {
                connection.Close();
            }

            return sifre;
        }

        public string InsertPalete(int Sifra,string Oznaka,string Status,string Lokacija,float Kolicina)
        {
            string resp = "Paleta uspesno uneta u sistem.";
            try
            {
                connection.Open();

                SqlCommand cmd = new SqlCommand("INSERT INTO Palete (SifraArtikla,Oznaka,Status,Lokacija,Kolicina) VALUES(" + Sifra 
                    + ",'" + Oznaka + "','" + Status + "','" + Lokacija + "'," + Kolicina + ")", connection);
                cmd.ExecuteNonQuery();

            }
            catch(Exception e)
            {
                resp = e.Message;
            }
            finally
            {
                connection.Close();
            }

            return resp;
        }

        public List<Lokacija> DajSvePalete()
        {
            List<Lokacija> resp = new List<Lokacija>();
            SqlDataReader reader;

            connection.Open();

            SqlCommand cmdq = new SqlCommand("SELECT dbo.Palete.ID, dbo.Palete.SifraArtikla, dbo.Palete.Oznaka, dbo.Palete.Status, dbo.Palete.Lokacija, "
                + "dbo.Palete.Kolicina, dbo.SifarnikArtikli.Naziv, dbo.SifarnikArtikli.JedinicaMere FROM dbo.Palete INNER JOIN dbo.SifarnikArtikli ON "
                + "dbo.Palete.SifraArtikla = dbo.SifarnikArtikli.Sifra", connection);
            reader = cmdq.ExecuteReader();

            while (reader.Read() == true)
            {
                Lokacija pal = new Lokacija();

                pal.SifraArtikla = Convert.ToInt16(reader["SifraArtikla"]);
                pal.Status = reader["Status"].ToString();
                pal.LokacijaPalete = reader["Lokacija"].ToString();
                pal.Oznaka = reader["Oznaka"].ToString();
                pal.ID = reader["ID"].ToString();
                pal.Kolicina = (float)Convert.ToDecimal(reader["Kolicina"].ToString());
                pal.Naziv = reader["Naziv"].ToString();
                pal.JM = reader["JedinicaMere"].ToString();
                resp.Add(pal);
            }
            reader.Close();
            connection.Close();

            return resp;
        }

        public List<Artikal> DajSveArtikle()
        {
            List<Artikal> resp = new List<Artikal>();
            SqlDataReader reader;

            connection.Open();

            SqlCommand cmdq = new SqlCommand("SELECT * FROM SifarnikArtikli",connection);
            reader = cmdq.ExecuteReader();
            while (reader.Read() == true)
            {
                Artikal art = new Artikal();    
                //art.ID = reader["ID"].ToString();
                art.Sifra = (int)reader["Sifra"];
                art.Naziv = reader["Naziv"].ToString();

                resp.Add(art);
            }
            return resp;
        }

        public void BrisiPaletu(int sifra,string lokacija)
        {
            try
            {
                connection.Open();

                SqlCommand cmd = new SqlCommand("DELETE FROM Palete WHERE Lokacija = '" + lokacija + "' AND SifraArtikla = " + sifra, connection);
                cmd.ExecuteNonQuery();
            }
            finally { connection.Close(); }
        }
    }
}