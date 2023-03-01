Imports System.Globalization
Imports System.Threading
Imports System.Collections.ObjectModel



Public Class FrmMain
    Dim SelektovanaKolona As String


#Region "FrmMain"
    Private Sub FrmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim rs As DataTable
        Dim lFont As Font

        lFont = New Font("Poppins", 11, FontStyle.Regular, GraphicsUnit.Point)
        GrdMain.ColumnHeadersDefaultCellStyle.Font = lFont
        lFont = New Font("Poppins", 9.75, FontStyle.Regular, GraphicsUnit.Point)
        GrdMain.RowsDefaultCellStyle.Font = lFont

        GrdMain.EnableHeadersVisualStyles = False
        GrdMain.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(79, 109, 122)
        GrdMain.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(241, 246, 248)

        ProgramID = GetSetting(My.Application.Info.Title, "Settings", "ProgramID", 1)
        FormatDatuma = GetSetting(My.Application.Info.Title, "Settings", "FormatDatuma", "M/dd/yyyy")
        ImeSQLServera = GetSetting(My.Application.Info.Title, "Settings", "ImeSQLServera", "MSI-NINO\SQLEXPRESS")

        rs = GetData("SELECT * FROM Programi WHERE ID=" & ProgramID)
        If rs.Rows.Count > 0 Then
            NazivPrograma = rs(0)!Naziv.ToString
        Else
            NazivPrograma = ""
        End If

        If Godina <> TekucaGodina Then
            LblGodina.Text = Godina & ". godina"
        Else
            LblGodina.Text = ""
        End If

        Dim myCI As New CultureInfo("en-US", True)

        myCI.DateTimeFormat.ShortDatePattern = "dd/M/yyyy"
        myCI.NumberFormat.CurrencyDecimalSeparator = "."
        myCI.NumberFormat.NumberDecimalSeparator = "."
        myCI.NumberFormat.NumberGroupSeparator = ","
        myCI.DateTimeFormat.TimeSeparator = ":"

        Thread.CurrentThread.CurrentUICulture = myCI
        Thread.CurrentThread.CurrentCulture = myCI

        Komitenti = New Lista
        Komitenti.Upit = "SELECT * FROM SifarnikKomitenti ORDER BY Naziv"
        Komitenti.Puni()

        KomitentiAktivni = New Lista
        KomitentiAktivni.Upit = "SELECT * FROM SifarnikKomitenti WHERE Pasivan='False' ORDER BY Naziv"
        KomitentiAktivni.Puni()

        KupciAktivni = New Lista
        KupciAktivni.Upit = "SELECT * FROM SifarnikKomitenti WHERE Kupac='True' AND Pasivan='False' ORDER BY Naziv"
        KupciAktivni.Puni()

        DobavljaciAktivni = New Lista
        DobavljaciAktivni.Upit = "SELECT * FROM SifarnikKomitenti WHERE Dobavljac='True' AND Pasivan='False' ORDER BY Naziv"
        DobavljaciAktivni.Puni()

        Artikli = New Lista
        Artikli.Upit = "SELECT dbo.SifarnikArtikli.Sifra, dbo.SifarnikArtikli.KataloskiBroj, dbo.SifarnikArtikli.Naziv, dbo.SifarnikArtikli.Oznaka, dbo.SifarnikArtikli.JedinicaMere, 
                         dbo.SifarnikArtikliRobneGrupe.Naziv AS RobnaGrupa, dbo.SifarnikArtikli.Napomena, dbo.SifarnikArtikli.Pasivan, dbo.SifarnikArtikli.BarCod 
                         FROM dbo.SifarnikArtikli INNER JOIN
                         dbo.SifarnikArtikliRobneGrupe ON dbo.SifarnikArtikli.Grupa = dbo.SifarnikArtikliRobneGrupe.Sifra
                         ORDER BY dbo.SifarnikArtikli.Naziv"
        Artikli.Puni()

        ArtikliStavke = New Lista
        ArtikliStavke.Upit = "SELECT * FROM SifarnikArtikli WHERE Pasivan='False' ORDER BY Naziv"
        ArtikliStavke.Puni()

        ArtikliRN = New Lista
        ArtikliRN.Upit = "SELECT * FROM SifarnikArtikli WHERE Pasivan='False' ORDER BY Naziv"
        ArtikliRN.Puni()

        RobneGrupe = New Lista
        RobneGrupe.Upit = "SELECT * FROM SifarnikArtikliRobneGrupe ORDER BY Naziv"
        RobneGrupe.Puni()


        Kupci = New Sifarnik
        Kupci.Puni("SELECT * FROM SifarnikKomitenti WHERE Kupac='True' AND Pasivan='False' ORDER BY Naziv")

        Dobavljaci = New Sifarnik
        Dobavljaci.Puni("SELECT * FROM SifarnikKomitenti WHERE Dobavljac='True' AND Pasivan='False' ORDER BY Naziv")

        SifarnikRobnihGrupa = New Sifarnik
        'SifarnikRobnihGrupa.Puni("SELECT * FROM SifarnikArtikliRobneGrupe WHERE Pasivan='False' ORDER BY Naziv")

        SifarnikVrstaArtikala = New Sifarnik
        SifarnikVrstaArtikala.Puni("SELECT * FROM SifarnikArtikliVrste ORDER BY Naziv")

        Magacini = New Lista
        Magacini.Upit = "SELECT dbo.SifarnikMagacini.Sifra, dbo.SifarnikMagacini.Naziv, dbo.SifarnikArtikliVrste.Naziv As VrstaArtikla, dbo.SifarnikMagacini.Pasivan
                            FROM dbo.SifarnikMagacini INNER JOIN dbo.SifarnikArtikliVrste ON dbo.SifarnikMagacini.VrstaArtikla = dbo.SifarnikArtikliVrste.Sifra
                            ORDER BY dbo.SifarnikMagacini.Sifra"
        Magacini.Puni()

        SifarnikDrzava = New Sifarnik
        SifarnikDrzava.Puni("SELECT * FROM SifarnikDrzave ORDER BY Naziv")

        SifarnikMagacina = New Sifarnik
        SifarnikMagacina.Puni("SELECT * FROM SifarnikMagacini ORDER BY Naziv")

        SIfarnikGlavniMagacin = New Sifarnik
        SIfarnikGlavniMagacin.Puni("SELECT * FROM SifarnikMagacini ORDER BY Naziv")

        SifarnikUMagacin = New Sifarnik
        SifarnikUMagacin.Puni("SELECT * FROM SifarnikMagacini ORDER BY Naziv")

        SifarnikMeseca = New Sifarnik
        SifarnikMeseca.Puni("SELECT * FROM SifarnikMeseca ORDER BY Sifra")
        SifarnikMeseca.KolonaSifra = "Sifra"
        SifarnikMeseca.KolonaNaziv = "Naziv"

    End Sub
    Private Sub FrmMain_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        If WindowState <> FormWindowState.Minimized Then

            SaveSetting(My.Application.Info.Title, "Settings", "ProgramID", ProgramID)
            SaveSetting(My.Application.Info.Title, "Settings", "FormatDatuma", FormatDatuma)
            SaveSetting(My.Application.Info.Title, "Settings", "ImeSQLServera", ImeSQLServera)
        End If

    End Sub

    Private Sub CmbMagacin_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles CmbMagacin.SelectionChangeCommitted

        If CmbMagacin.SelectedIndex = -1 Then
            TekuciMagacin = 0
            Exit Sub
        End If

        TekuciMagacin = CmbMagacin.SelectedValue

        'PanelModula()
        GrdMain.Visible = False
        LblLista.Text = ""

    End Sub

#End Region


#Region "Tasteri"

    '***Glavni panel (PanelMain)***
    Private Sub CmdSifarnici_Click(sender As Object, e As EventArgs) Handles CmdSifarnici.Click

        DocStatus = "Sifarnici"

        Parametri.PravoPristupa = ProveraPristupaModulu(UserID, ProgramID, DocStatus)
        If Parametri.PravoPristupa = 0 Then
            MsgBox("Pritup modulu onemogućen!", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        PanelGlavni(CmdSifarnici, PanelSifarnici, PanelMain)

        CmbMagacin.SelectedIndex = -1
        PanelMagacin.Enabled = False

        GrdMain.Visible = False
        LblLista.Text = ""

    End Sub
    Private Sub CmdMagacinskiDokumenti_Click(sender As Object, e As EventArgs) Handles CmdMagacinskiDokumenti.Click

        DocStatus = "MagacinskiDokumenti"

        Parametri.PravoPristupa = ProveraPristupaModulu(UserID, ProgramID, DocStatus)
        If Parametri.PravoPristupa = 0 Then
            MsgBox("Pritup modulu onemogućen!", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        PanelMagacin.Enabled = True
        SifarnikMagacina.KontrolaZaPrikaz = CmbMagacin
        SifarnikMagacina.PuniKontrolu()
        CmbMagacin.SelectedIndex = -1


        PanelGlavni(CmdMagacinskiDokumenti, PanelMagacinskaDokumentacija, PanelMain)

        GrdMain.Visible = False
        LblLista.Text = ""

    End Sub
    Private Sub CmdProizvodnja_Click(sender As Object, e As EventArgs) Handles CmdProizvodnja.Click

        DocStatus = "Proizvodnja"

        Parametri.PravoPristupa = ProveraPristupaModulu(UserID, ProgramID, DocStatus)
        If Parametri.PravoPristupa = 0 Then
            MsgBox("Pritup modulu onemogućen!", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        PanelMagacin.Enabled = True
        SifarnikMagacina.KontrolaZaPrikaz = CmbMagacin
        SifarnikMagacina.PuniKontrolu()
        CmbMagacin.SelectedIndex = -1

        PanelGlavni(CmdProizvodnja, PanelProizvodnja, PanelMain)

        GrdMain.Visible = False
        LblLista.Text = ""

    End Sub
    Private Sub CmdOperateri_Click(sender As Object, e As EventArgs)

        '    If ProveraPristupaModulu(UserID, ProgramID, "Operateri") > 2 Then
        '        FrmOperateri.Dispose()
        '        Hide()
        '        FrmOperateri.ShowDialog()
        '        Show()

        '    Else
        '        MsgBox("Korisnik nema pravo pristupa!", MsgBoxStyle.Critical)
        '        Exit Sub
        '    End If

        '    GrdMain.Visible = False
        '    LblLista.Text = ""
        '    PanelModula()

    End Sub
    Private Sub CmdPodesavanja_Click(sender As Object, e As EventArgs)
        'Dim rs As DataTable
        'Dim rs2700 As DataTable
        'Dim rs4350 As DataTable


        ''rs = GetData("SELECT Opis, VrstaNaloga, Oznaka FROM dbo.FinansijskiNalogStavke
        ''                GROUP BY Opis, VrstaNaloga, Oznaka HAVING VrstaNaloga = 'KU' AND (Oznaka = 1)")

        ''For n = 0 To rs.Rows.Count - 1
        ''    rs4350 = GetData("SELECT * FROM FinansijskiNalogStavke WHERE Opis='" & rs.Rows(n)!Opis & "' AND Konto='4350'")

        ''    InsertData("UPDATE FinansijskiNalogStavke SET Dokument='" & rs4350.Rows(0)!Dokument & "' WHERE Opis='" & rs.Rows(n)!Opis & "' AND Konto='2700'")
        ''Next


        '    'DocStatus = "Podesavanja"
        '    'Parametri.PravoPristupa = ProveraPristupaModulu(UserID, ProgramID, DocStatus)

        '    'If Parametri.PravoPristupa = 0 Then
        '    '    MsgBox("Pritup modulu onemogućen!", MsgBoxStyle.Exclamation)
        '    '    Exit Sub
        '    'End If

        '    'FrmPodesavanja.ShowDialog()

        '    'Cursor = Cursors.WaitCursor

        '    'Dim rs As DataTable = GetData("SELECT * FROM SifarnikArtikli")

        '    'For n = 0 To rs.Rows.Count - 1
        '    '    'Replace(rs(n)!Naziv, ",", ".")
        '    '    InsertData("INSERT INTO Zaliha VALUES(" & TekuciMagacin & ",'" & rs(n)!Sifra & "','',0,0)")
        '    '    InsertData("INSERT INTO Cenovnik VALUES(" & TekuciMagacin & "," & rs(n)!Sifra & ",'" & rs(n)!Naziv & "',0,0,0) ")


        '    'Next

        'MsgBox("ok")

        '    '    Cursor = Cursors.Default
    End Sub



    '****Sifarnici******
    Private Sub CmdKomitenti_Click(sender As Object, e As EventArgs) Handles CmdKomitenti.Click

        DocStatus = "Komitenti"
        PanelModula(PanelSifarnici, CmdKomitenti)

        Parametri.PravoPristupa = ProveraPristupaModulu(UserID, ProgramID, DocStatus)
        If Parametri.PravoPristupa = 0 Then
            MsgBox("Pritup modulu onemogućen!", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        Cursor = Cursors.WaitCursor

        Komitenti.Puni()
        GridKomitenti()
        Komitenti.DajSve()

        GrdMain.Visible = True
        LblLista.Text = "Lista komitenata:"

        Cursor = Cursors.Default

    End Sub
    Private Sub CmdArtikli_Click(sender As Object, e As EventArgs) Handles CmdArtikli.Click

        DocStatus = "Artikli"
        PanelModula(PanelSifarnici, CmdArtikli)

        Parametri.PravoPristupa = ProveraPristupaModulu(UserID, ProgramID, DocStatus)
        If Parametri.PravoPristupa = 0 Then
            MsgBox("Pritup modulu onemogućen!", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        Cursor = Cursors.WaitCursor

        Artikli.Puni()
        GridArtikli()
        Artikli.DajSve()

        GrdMain.Visible = True
        LblLista.Text = "Lista artikala:"

        Cursor = Cursors.Default

    End Sub
    Private Sub CmdRobneGrupe_Click(sender As Object, e As EventArgs) Handles CmdRobneGrupe.Click

        DocStatus = "RobneGrupe"
        PanelModula(PanelSifarnici, CmdRobneGrupe)

        Parametri.PravoPristupa = ProveraPristupaModulu(UserID, ProgramID, DocStatus)
        If Parametri.PravoPristupa = 0 Then
            MsgBox("Pritup modulu onemogućen!", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        Cursor = Cursors.WaitCursor

        RobneGrupe.Puni()
        GridRobneGrupe()
        RobneGrupe.DajSve()

        GrdMain.Visible = True
        LblLista.Text = "Lista robnih grupa artikala:"

        Cursor = Cursors.Default

    End Sub
    Private Sub CmdMagacini_Click(sender As Object, e As EventArgs) Handles CmdMagacini.Click

        DocStatus = "Magacini"
        PanelModula(PanelSifarnici, CmdMagacini)

        Parametri.PravoPristupa = ProveraPristupaModulu(UserID, ProgramID, DocStatus)
        If Parametri.PravoPristupa = 0 Then
            MsgBox("Pritup modulu onemogućen!", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        Cursor = Cursors.WaitCursor

        Magacini.Puni()
        GridMagacini()
        Magacini.DajSve()

        GrdMain.Visible = True
        LblLista.Text = "Lista magacina:"

        Cursor = Cursors.Default

    End Sub






    '    '****MagacinskiDokumenti******
    Private Sub CmdPrijemnica_Click(sender As Object, e As EventArgs) Handles CmdPrijemnica.Click

        DocStatus = "Prijemnica"
        PanelModula(PanelMagacinskaDokumentacija, CmdPrijemnica)

        Parametri.PravoPristupa = ProveraPristupaModulu(UserID, ProgramID, DocStatus)
        If Parametri.PravoPristupa = 0 Then
            MsgBox("Pritup modulu onemogućen!", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        If TekuciMagacin = 0 Or CmbMagacin.Text = "" Then
            MsgBox("Morate izabrati magacin!", MsgBoxStyle.Exclamation, "Magacin")
            PanelModula(PanelMagacinskaDokumentacija)
            Exit Sub
        End If

        Cursor = Cursors.WaitCursor

        Prijemnice = New Lista
        Prijemnice.Upit = "SELECT dbo.Prijemnica.Broj, dbo.Prijemnica.Datum, dbo.SifarnikKomitenti.Naziv AS Dobavljac, dbo.Prijemnica.BrojUlaznogDokumenta, 
                                    dbo.Prijemnica.DatumUlaznogDokumenta, dbo.Prijemnica.BrojKalkulacije, dbo.Prijemnica.Knjizeno
                                    FROM  dbo.SifarnikKomitenti INNER JOIN dbo.Prijemnica ON dbo.SifarnikKomitenti.Sifra = dbo.Prijemnica.Dobavljac
                                    WHERE dbo.Prijemnica.Magacin =" & TekuciMagacin & " AND dbo.Prijemnica.Godina =" & Godina & " ORDER BY dbo.Prijemnica.Broj DESC"
        Prijemnice.Puni()
        GridPrijemnice()
        Prijemnice.DajSve()

        GrdMain.Visible = True
        LblLista.Text = "Lista PRIJEMNICA za " & CmbMagacin.Text

        Cursor = Cursors.Default

    End Sub
    Private Sub CmdOtpremnica_Click(sender As Object, e As EventArgs) Handles CmdOtpremnica.Click

        DocStatus = "Otpremnica"
        PanelModula(PanelMagacinskaDokumentacija, CmdOtpremnica)

        Parametri.PravoPristupa = ProveraPristupaModulu(UserID, ProgramID, DocStatus)
        If Parametri.PravoPristupa = 0 Then
            MsgBox("Pritup modulu onemogućen!", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        If TekuciMagacin = 0 Or CmbMagacin.Text = "" Then
            MsgBox("Morate izabrati magacin!", MsgBoxStyle.Exclamation, "Magacin")
            PanelModula(PanelMagacinskaDokumentacija)
            Exit Sub
        End If

        Cursor = Cursors.WaitCursor

        Otpremnice = New Lista
        Otpremnice.Upit = "SELECT dbo.Otpremnica.Broj, dbo.Otpremnica.Datum, dbo.SifarnikKomitenti.Naziv AS Kupac, dbo.Otpremnica.RacunUradjen, 
                                    dbo.Otpremnica.BrojRacuna, dbo.Otpremnica.Izvoz, dbo.Otpremnica.Knjizeno
                                    FROM  dbo.SifarnikKomitenti INNER JOIN dbo.Otpremnica ON dbo.SifarnikKomitenti.Sifra = dbo.Otpremnica.Kupac
                                    WHERE dbo.Otpremnica.Magacin =" & TekuciMagacin & " AND dbo.Otpremnica.Godina =" & Godina & " ORDER BY dbo.Otpremnica.Broj DESC"

        Otpremnice.Puni()
        GridOtpremnice()
        Otpremnice.DajSve()

        GrdMain.Visible = True
        LblLista.Text = "Lista OTPREMNICA za " & CmbMagacin.Text

        Cursor = Cursors.Default

    End Sub
    Private Sub CmdPrenosnica_Click(sender As Object, e As EventArgs) Handles CmdPrenosnica.Click

        DocStatus = "Prenosnica"
        PanelModula(PanelMagacinskaDokumentacija, CmdPrenosnica)

        Parametri.PravoPristupa = ProveraPristupaModulu(UserID, ProgramID, DocStatus)
        If Parametri.PravoPristupa = 0 Then
            MsgBox("Pritup modulu onemogućen!", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        If TekuciMagacin = 0 Or CmbMagacin.Text = "" Then
            MsgBox("Morate izabrati magacin!", MsgBoxStyle.Exclamation, "Magacin")
            PanelModula(PanelMagacinskaDokumentacija)
            Exit Sub
        End If

        Cursor = Cursors.WaitCursor

        Prenosnice = New Lista
        Prenosnice.Upit = "Select Prenosnica.Broj, Prenosnica.Datum, SifarnikMagacini.Naziv As IzMagacina, SifarnikMagacini_1.Naziv As UMagacin, Prenosnica.Knjizeno 
                            FROM (Prenosnica INNER JOIN SifarnikMagacini On Prenosnica.IzMagacina = SifarnikMagacini.Sifra) 
                            INNER JOIN SifarnikMagacini As SifarnikMagacini_1 On Prenosnica.UMagacin = SifarnikMagacini_1.Sifra 
                            WHERE Prenosnica.Godina=" & Godina & " And Prenosnica.IzMagacina=" & TekuciMagacin & " ORDER BY Broj DESC"
        Prenosnice.Puni()
        GridPrenosnice()
        Prenosnice.DajSve()

        GrdMain.Visible = True
        LblLista.Text = "Lista PRENOSNICA za " & CmbMagacin.Text

        Cursor = Cursors.Default

    End Sub
    Private Sub CmdRashod_Click(sender As Object, e As EventArgs) Handles CmdRashod.Click

        DocStatus = "Rashod"
        PanelModula(PanelMagacinskaDokumentacija, CmdRashod)

        Parametri.PravoPristupa = ProveraPristupaModulu(UserID, ProgramID, DocStatus)
        If Parametri.PravoPristupa = 0 Then
            MsgBox("Pritup modulu onemogućen!", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        If TekuciMagacin = 0 Or CmbMagacin.Text = "" Then
            MsgBox("Morate izabrati magacin!", MsgBoxStyle.Exclamation, "Magacin")
            PanelModula(PanelMagacinskaDokumentacija)
            Exit Sub
        End If

        Cursor = Cursors.WaitCursor

        Rashodi = New Lista
        Rashodi.Upit = "SELECT * FROM Rashod WHERE Godina=" & Godina & " And Magacin=" & TekuciMagacin & " ORDER BY Broj DESC"

        Rashodi.Puni()
        GridRashodi()
        Rashodi.DajSve()

        GrdMain.Visible = True
        LblLista.Text = "Lista RASHODA za " & CmbMagacin.Text

        Cursor = Cursors.Default

    End Sub
    Private Sub CmdPopis_Click(sender As Object, e As EventArgs) Handles CmdPopis.Click

        DocStatus = "Popis"
        PanelModula(PanelMagacinskaDokumentacija, CmdPopis)

        Parametri.PravoPristupa = ProveraPristupaModulu(UserID, ProgramID, DocStatus)
        If Parametri.PravoPristupa = 0 Then
            MsgBox("Pritup modulu onemogućen!", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        If TekuciMagacin = 0 Or CmbMagacin.Text = "" Then
            MsgBox("Morate izabrati magacin!", MsgBoxStyle.Exclamation, "Magacin")
            PanelModula(PanelMagacinskaDokumentacija)
            Exit Sub
        End If

        Cursor = Cursors.WaitCursor

        Popis = New Lista
        Popis.Upit = "SELECT Broj, Datum, Knjizeno FROM dbo.Popis WHERE Magacin =" & TekuciMagacin & " AND Godina=" & Godina & "  ORDER BY Broj DESC"
        Popis.Puni()
        GridPopis()
        Popis.DajSve()

        GrdMain.Visible = True
        LblLista.Text = "Lista POPISA za " & CmbMagacin.Text

        Cursor = Cursors.Default

    End Sub
    Private Sub CmdPocetnoStanje_Click(sender As Object, e As EventArgs) Handles CmdPocetnoStanje.Click

        DocStatus = "PocetnoStanje"
        PanelModula(PanelMagacinskaDokumentacija, CmdPocetnoStanje)

        Parametri.PravoPristupa = ProveraPristupaModulu(UserID, ProgramID, DocStatus)
        If Parametri.PravoPristupa = 0 Then
            MsgBox("Pritup modulu onemogućen!", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        If TekuciMagacin = 0 Or CmbMagacin.Text = "" Then
            MsgBox("Morate izabrati magacin!", MsgBoxStyle.Exclamation, "Magacin")
            PanelModula()
            Exit Sub
        End If

        Cursor = Cursors.WaitCursor

        PocetnoStanje = New Lista
        PocetnoStanje.Upit = "SELECT SifraArtikla, NazivArtikla, Kolicina FROM PocetnoStanjeArtikala WHERE Magacin =" & TekuciMagacin & " AND Godina=" & Godina & " ORDER BY NazivArtikla"


        PocetnoStanje.Puni()
        GridPocetnogStanja()
        PocetnoStanje.DajSve()

        GrdMain.Visible = True
        LblLista.Text = "POČETNO STANJE ARTIKALA ZA " & CmbMagacin.Text

        Cursor = Cursors.Default

    End Sub
    Private Sub CmdKarticaArtiklaMagacinska_Click(sender As Object, e As EventArgs) Handles CmdKarticaArtiklaMagacinska.Click

        PanelModula(PanelMagacinskaDokumentacija, CmdKarticaArtiklaMagacinska)

        Parametri.PravoPristupa = ProveraPristupaModulu(UserID, ProgramID, DocStatus)
        If Parametri.PravoPristupa = 0 Then
            MsgBox("Pritup modulu onemogućen!", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        If TekuciMagacin = 0 Or CmbMagacin.Text = "" Then
            MsgBox("Morate izabrati magacin!", MsgBoxStyle.Exclamation, "Magacin")
            PanelModula(PanelMagacinskaDokumentacija)
            Exit Sub
        End If

        GrdMain.Visible = False
        LblLista.Text = ""

        'FrmKarticaArtiklaMagacinska.Dispose()
        'FrmKarticaArtiklaMagacinska.ShowDialog()

        PanelModula(PanelMagacinskaDokumentacija)

    End Sub
    Private Sub CmdStanjeArtikala_Click(sender As Object, e As EventArgs) Handles CmdStanjeArtikala.Click

        PanelModula(PanelMagacinskaDokumentacija, CmdStanjeArtikala)

        Parametri.PravoPristupa = ProveraPristupaModulu(UserID, ProgramID, DocStatus)
        If Parametri.PravoPristupa = 0 Then
            MsgBox("Pritup modulu onemogućen!", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        If TekuciMagacin = 0 Or CmbMagacin.Text = "" Then
            MsgBox("Morate izabrati magacin!", MsgBoxStyle.Exclamation, "Magacin")
            PanelModula(PanelMagacinskaDokumentacija)
            Exit Sub
        End If

        GrdMain.Visible = False
        LblLista.Text = ""

        'FrmStanjeArtikala.Dispose()
        'FrmStanjeArtikala.ShowDialog()

        PanelModula(PanelMagacinskaDokumentacija)

    End Sub
    Private Sub CmdLagerLista_Click(sender As Object, e As EventArgs) Handles CmdLagerLista.Click

        PanelModula(PanelMagacinskaDokumentacija, CmdLagerLista)

        Parametri.PravoPristupa = ProveraPristupaModulu(UserID, ProgramID, DocStatus)
        If Parametri.PravoPristupa = 0 Then
            MsgBox("Pritup modulu onemogućen!", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        If Godina <> TekucaGodina Then
            MsgBox("Program nije startovan u tekućoj godini! " & vbCrLf & vbCrLf & "Pogledajte završni popis!", MsgBoxStyle.Exclamation)
            Exit Sub
        Else
            If TekuciMagacin = 0 Or CmbMagacin.Text = "" Then
                MsgBox("Morate izabrati magacin!", MsgBoxStyle.Exclamation, "Magacin")
                PanelModula(PanelMagacinskaDokumentacija)
                Exit Sub
            End If

            GrdMain.Visible = False
            LblLista.Text = ""

            'FrmLagerLista.Dispose()
            'FrmLagerLista.ShowDialog()
        End If

        PanelModula(PanelMagacinskaDokumentacija)

    End Sub


#End Region


#Region "KomandniPanel i Pretrazivanje"
    Private Sub CmdNovi_Click(sender As Object, e As EventArgs) Handles CmdNovi.Click

        If Godina <> TekucaGodina Then
            If MsgBox("Program nije startovan u tekućoj godini! " & vbCrLf & vbCrLf & "Nastavljate?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub
        End If

        Cursor = Cursors.WaitCursor

        Select Case DocStatus
            Case "Komitenti"
                Parametri.Novi = True
                FrmSifarnikKomitenti.Dispose()
                Hide()
                FrmSifarnikKomitenti.ShowDialog()
                Komitenti.ReFill()
                KomitentiAktivni.ReFill()
                KupciAktivni.ReFill()
                DobavljaciAktivni.ReFill()
                Show()
            Case "Artikli"
                Parametri.Novi = True
                FrmSifarnikArtikli.Dispose()
                Hide()
                FrmSifarnikArtikli.ShowDialog()
                Artikli.ReFill()
                ArtikliStavke.ReFill()
                'ArtikliRN.ReFill()
                'SifarnikArtikala.Refresh()
                Show()
            Case "RobneGrupe"
                Parametri.NovaRobnaGrupa = True
                FrmSifarnikArtikliRobneGrupe.Dispose()
                Hide()
                FrmSifarnikArtikliRobneGrupe.ShowDialog()
                RobneGrupe.ReFill()
                'SifarnikRobnihGrupa.Refresh()
                Show()
            Case "Magacini"
                Parametri.Novi = True
                FrmSifarnikMagacini.Dispose()
                Hide()
                FrmSifarnikMagacini.ShowDialog()
                Magacini.ReFill()
                SifarnikMagacina.Refresh()
                SifarnikUMagacin.Refresh()
                Show()

            Case "Prijemnica"
                Parametri.Novi = True
                frmPrijemnica.Dispose()
                Hide()
                frmPrijemnica.ShowDialog()
                Prijemnice.ReFill()
                Show()
            Case "Otpremnica"
                Parametri.Novi = True
                FrmOtpremnica.Dispose()
                Hide()
                FrmOtpremnica.ShowDialog()
                Otpremnice.ReFill()
                Show()
            Case "Prenosnica"
                Parametri.Novi = True
                frmPrenosnica.Dispose()
                Hide()
                frmPrenosnica.ShowDialog()
                Prenosnice.ReFill()
                Show()
            Case "Rashod"
                Parametri.Novi = True
                frmRashod.Dispose()
                Hide()
                frmRashod.ShowDialog()
                Rashodi.ReFill()
                Show()
            Case "Popis"
                Parametri.Novi = True
                frmPopis.Dispose()
                Hide()
                frmPopis.ShowDialog()
                Popis.ReFill()
                Show()

        End Select

        Cursor = Cursors.Default

greska:
        Show()
    End Sub
    Private Sub CmdNadji_Click(sender As Object, e As EventArgs) Handles CmdNadji.Click

        Select Case DocStatus
            Case "Banke", "Drzave", "Magacini", "KursnaLista", "Popis", "Prenosnica", "Rashod", "Povracaj"
                MsgBox("Pretraživanje nije omogućeno!", MsgBoxStyle.Exclamation)
                Pretrazivanje = False
                Exit Sub
            Case Else
                Pretrazivanje = True

                TxtNadji.Visible = True
                TxtNadji.Text = ""
                TxtNadji.Focus()

        End Select

    End Sub
    Private Sub TxtNadji_TextChanged(sender As Object, e As EventArgs) Handles TxtNadji.TextChanged
        Dim Kolone As New Collection(Of String)

        If Pretrazivanje Then
            If TxtNadji.Text = "" Then
                SelektovanaKolona = ""
                Select Case DocStatus
                    Case "Komitenti"
                        Komitenti.DajSve()
                    Case "Artikli"
                        Artikli.DajSve()
                    Case "RobneGrupe"
                        RobneGrupe.DajSve()
                    Case "Prijemnica"
                        Prijemnice.DajSve()
                    Case "Otpremnica"
                        Otpremnice.DajSve()
                    Case "PocetnoStanje"
                        PocetnoStanje.DajSve()
                End Select
                Exit Sub
            Else
                Select Case DocStatus
                    Case "Komitenti"
                        Komitenti.Trazi(TxtNadji.Text, True, SelektovanaKolona)
                    Case "Artikli"
                        Artikli.Trazi(TxtNadji.Text, True, SelektovanaKolona)
                    Case "RobneGrupe"
                        RobneGrupe.Trazi(TxtNadji.Text, True, SelektovanaKolona)
                    Case "Prijemnica"
                        Prijemnice.Trazi(TxtNadji.Text, True, SelektovanaKolona)
                    Case "Otpremnica"
                        Otpremnice.Trazi(TxtNadji.Text, True, SelektovanaKolona)
                    Case "PocetnoStanje"
                        PocetnoStanje.Trazi(TxtNadji.Text, True, SelektovanaKolona)

                End Select
            End If
        End If
    End Sub

    Private Sub cmdBack_Click(sender As Object, e As EventArgs) Handles cmdBack.Click
        PanelGlavni(CmdSifarnici, PanelMain, PanelMain)
        LblPanel.Text = ""

        GrdMain.Visible = False
        LblLista.Text = ""

    End Sub
#End Region


#Region "Funkcije"

    ''***Sifarnici***
    Sub GridKomitenti()
        Komitenti.Grid = GrdMain
        Komitenti.KolikoVidljivihRedova = 0
        Komitenti.DinamickaVisina = False
        'Komitenti.PrvaBoja = Color.FromArgb(232, 232, 232)
        'Komitenti.DrugaBoja = Color.FromArgb(183, 208, 229)
        Komitenti.BojenjeRedova = False
        Komitenti.CrveniRed = "Pasivan"
        Komitenti.BojaCrvenogReda = Color.FromArgb(237, 150, 130)

        Dim kk As DataGridViewColumn

        kk = New DataGridViewColumn
        kk.Name = "Sifra"
        kk.HeaderText = "ŠIFRA"
        kk.Width = 80
        'kk.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        kk.DisplayIndex = 0
        Komitenti.DodajKolonuZaGrid(kk)

        kk = New DataGridViewColumn
        kk.Name = "Naziv"
        kk.HeaderText = "NAZIV"
        kk.Width = 400
        'kk.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        kk.DisplayIndex = 1
        Komitenti.DodajKolonuZaGrid(kk)

        kk = New DataGridViewColumn
        kk.Name = "Mesto"
        kk.HeaderText = "MESTO"
        kk.Width = 300
        kk.DisplayIndex = 2
        Komitenti.DodajKolonuZaGrid(kk)

        kk = New DataGridViewColumn
        kk.Name = "PIB"
        kk.HeaderText = "PIB"
        kk.Width = 150
        kk.DisplayIndex = 3
        Komitenti.DodajKolonuZaGrid(kk)

        kk = New DataGridViewColumn
        kk.Name = "MaticniBroj"
        kk.HeaderText = "MATIČNI BR"
        kk.Width = 150
        kk.DisplayIndex = 4
        Komitenti.DodajKolonuZaGrid(kk)

        kk = New DataGridViewCheckBoxColumn
        kk.Name = "Kupac"
        kk.HeaderText = "KUPAC"
        kk.Width = 100
        kk.DisplayIndex = 5
        Komitenti.DodajKolonuZaGrid(kk)

        kk = New DataGridViewCheckBoxColumn
        kk.Name = "Dobavljac"
        kk.HeaderText = "DOBAVLJAČ"
        kk.Width = 100
        kk.DisplayIndex = 6
        Komitenti.DodajKolonuZaGrid(kk)

        kk = New DataGridViewCheckBoxColumn
        kk.Name = "Pasivan"
        kk.HeaderText = "PASIVAN"
        kk.Width = 100
        kk.DisplayIndex = 7
        Komitenti.DodajKolonuZaGrid(kk)

    End Sub
    Sub GridArtikli()
        Artikli.Grid = GrdMain
        Artikli.KolikoVidljivihRedova = 0
        Artikli.DinamickaVisina = False
        'Artikli.PrvaBoja = Color.FromArgb(232, 232, 232)
        'Artikli.DrugaBoja = Color.FromArgb(183, 208, 229)
        Artikli.BojenjeRedova = False
        Artikli.CrveniRed = "Pasivan"
        Artikli.BojaCrvenogReda = Color.FromArgb(237, 150, 130)

        Dim kk As DataGridViewColumn

        kk = New DataGridViewColumn
        kk.Name = "Sifra"
        kk.HeaderText = "ŠIFRA"
        kk.Width = 80
        'kk.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        kk.DisplayIndex = 0
        Artikli.DodajKolonuZaGrid(kk)

        kk = New DataGridViewColumn
        kk.Name = "KataloskiBroj"
        kk.HeaderText = "KATALOŠKI BROJ"
        kk.Width = 200
        kk.DisplayIndex = 1
        Artikli.DodajKolonuZaGrid(kk)

        kk = New DataGridViewColumn
        kk.Name = "Naziv"
        kk.HeaderText = "NAZIV"
        kk.Width = 500
        'kk.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        kk.DisplayIndex = 2
        Artikli.DodajKolonuZaGrid(kk)

        kk = New DataGridViewColumn
        kk.Name = "BarCod"
        kk.HeaderText = "BARCOD"
        kk.Width = 100
        kk.DisplayIndex = 3
        Artikli.DodajKolonuZaGrid(kk)

        kk = New DataGridViewColumn
        kk.Name = "Oznaka"
        kk.HeaderText = "OZNAKA / OPIS"
        kk.Width = 200
        kk.DisplayIndex = 4
        Artikli.DodajKolonuZaGrid(kk)

        kk = New DataGridViewColumn
        kk.Name = "JedinicaMere"
        kk.HeaderText = "JM"
        kk.Width = 50
        kk.DisplayIndex = 5
        Artikli.DodajKolonuZaGrid(kk)

        kk = New DataGridViewColumn
        kk.Name = "Napomena"
        kk.HeaderText = "NAPOMENA"
        kk.Width = 250
        kk.DisplayIndex = 6
        Artikli.DodajKolonuZaGrid(kk)

        kk = New DataGridViewCheckBoxColumn
        kk.Name = "Pasivan"
        kk.HeaderText = "PASIVAN"
        kk.Width = 100
        kk.DisplayIndex = 7
        Artikli.DodajKolonuZaGrid(kk)

    End Sub
    Sub GridRobneGrupe()
        RobneGrupe.Grid = GrdMain
        RobneGrupe.KolikoVidljivihRedova = 0
        RobneGrupe.DinamickaVisina = False
        'RobneGrupe.PrvaBoja = Color.FromArgb(232, 232, 232)
        'RobneGrupe.DrugaBoja = Color.FromArgb(183, 208, 229)
        RobneGrupe.BojenjeRedova = False
        RobneGrupe.CrveniRed = "Pasivan"
        RobneGrupe.BojaCrvenogReda = Color.FromArgb(237, 150, 130)

        Dim kk As DataGridViewColumn

        kk = New DataGridViewColumn
        kk.Name = "Sifra"
        kk.HeaderText = "ŠIFRA"
        kk.Width = 80
        'kk.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        kk.DisplayIndex = 0
        RobneGrupe.DodajKolonuZaGrid(kk)

        kk = New DataGridViewColumn
        kk.Name = "Naziv"
        kk.HeaderText = "NAZIV"
        kk.Width = 250
        'kk.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        kk.DisplayIndex = 1
        RobneGrupe.DodajKolonuZaGrid(kk)

        kk = New DataGridViewColumn
        kk.Name = "Napomena"
        kk.HeaderText = "NAPOMENA"
        kk.Width = 150
        'kk.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        kk.DisplayIndex = 2
        RobneGrupe.DodajKolonuZaGrid(kk)

        kk = New DataGridViewCheckBoxColumn
        kk.Name = "Pasivan"
        kk.HeaderText = "PASIVAN"
        kk.Width = 100
        kk.DisplayIndex = 3
        RobneGrupe.DodajKolonuZaGrid(kk)

    End Sub
    Sub GridMagacini()
        Magacini.Grid = GrdMain
        Magacini.KolikoVidljivihRedova = 0
        Magacini.DinamickaVisina = False
        'Magacini.PrvaBoja = Color.FromArgb(232, 232, 232)
        'Magacini.DrugaBoja = Color.FromArgb(183, 208, 229)
        Magacini.BojenjeRedova = False
        Magacini.CrveniRed = "Pasivan"
        Magacini.BojaCrvenogReda = Color.FromArgb(237, 150, 130)

        Dim kk As DataGridViewColumn

        kk = New DataGridViewColumn
        kk.Name = "Sifra"
        kk.HeaderText = "ŠIFRA"
        kk.Width = 80
        'kk.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        kk.DisplayIndex = 0
        Magacini.DodajKolonuZaGrid(kk)

        kk = New DataGridViewColumn
        kk.Name = "Naziv"
        kk.HeaderText = "NAZIV"
        kk.Width = 300
        'kk.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        kk.DisplayIndex = 1
        Magacini.DodajKolonuZaGrid(kk)

        kk = New DataGridViewColumn
        kk.Name = "VrstaArtikla"
        kk.HeaderText = "VRSTA ARTIKLA U MAGACINU"
        kk.Width = 250
        'kk.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        kk.DisplayIndex = 2
        Magacini.DodajKolonuZaGrid(kk)

        'kk = New DataGridViewColumn
        'kk.Name = "VrstaCenovnika"
        'kk.HeaderText = "CENOVNIK U MAGACINU"
        'kk.Width = 250
        ''kk.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        'kk.DisplayIndex = 3
        'Magacini.DodajKolonuZaGrid(kk)

        'kk = New DataGridViewColumn
        'kk.Name = "Konto"
        'kk.HeaderText = "KONTO"
        'kk.Width = 100
        ''kk.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        'kk.DisplayIndex = 4
        'Magacini.DodajKolonuZaGrid(kk)

        kk = New DataGridViewCheckBoxColumn
        kk.Name = "Pasivan"
        kk.HeaderText = "PASIVAN"
        kk.Width = 100
        kk.DisplayIndex = 3
        Magacini.DodajKolonuZaGrid(kk)

    End Sub


    ''****EvidencijaMagacina******
    Sub GridPrijemnice()
        Prijemnice.Grid = GrdMain
        Prijemnice.KolikoVidljivihRedova = 0
        Prijemnice.DinamickaVisina = False
        'Prijemnice.PrvaBoja = Color.FromArgb(232, 232, 232)
        'Prijemnice.DrugaBoja = Color.FromArgb(183, 208, 229)
        Prijemnice.BojenjeRedova = False
        Prijemnice.IzbaciPasivne = False
        Prijemnice.CrveniRed = "Knjizeno"
        Prijemnice.VrednostCrvenogReda = False
        Prijemnice.BojaCrvenogReda = Color.FromArgb(237, 150, 130)

        Dim kk As DataGridViewColumn

        kk = New DataGridViewColumn
        kk.Name = "Broj"
        kk.HeaderText = "BROJ"
        kk.Width = 50
        'kk.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        kk.DisplayIndex = 0
        Prijemnice.DodajKolonuZaGrid(kk)

        kk = New DataGridViewColumn
        kk.Name = "Datum"
        kk.HeaderText = "DATUM"
        kk.Width = 100
        'kk.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        kk.DisplayIndex = 1
        Prijemnice.DodajKolonuZaGrid(kk)

        kk = New DataGridViewColumn
        kk.Name = "Dobavljac"
        kk.HeaderText = "DOBAVLJAČ"
        kk.Width = 400
        kk.DisplayIndex = 2
        Prijemnice.DodajKolonuZaGrid(kk)

        kk = New DataGridViewColumn
        kk.Name = "BrojUlaznogDokumenta"
        kk.HeaderText = "ULAZNI DOKUMENT"
        kk.Width = 200
        kk.DisplayIndex = 3
        Prijemnice.DodajKolonuZaGrid(kk)

        kk = New DataGridViewColumn
        kk.Name = "DatumUlaznogDokumenta"
        kk.HeaderText = "DATUM ULAZA"
        kk.Width = 200
        kk.DisplayIndex = 4
        Prijemnice.DodajKolonuZaGrid(kk)

        'kk = New DataGridViewColumn
        'kk.Name = "BrojKalkulacije"
        'kk.HeaderText = "KALKULACIJA"
        'kk.Width = 120
        'kk.DisplayIndex = 5
        'Prijemnice.DodajKolonuZaGrid(kk)

        kk = New DataGridViewCheckBoxColumn
        kk.Name = "Knjizeno"
        kk.HeaderText = "KNJIŽENO"
        kk.Width = 100
        kk.DisplayIndex = 5
        Prijemnice.DodajKolonuZaGrid(kk)

    End Sub
    Sub GridOtpremnice()
        Otpremnice.Grid = GrdMain
        Otpremnice.KolikoVidljivihRedova = 0
        Otpremnice.DinamickaVisina = False
        'Otpremnice.PrvaBoja = Color.FromArgb(232, 232, 232)
        'Otpremnice.DrugaBoja = Color.FromArgb(183, 208, 229)
        Otpremnice.BojenjeRedova = False
        Otpremnice.IzbaciPasivne = False
        Otpremnice.CrveniRed = "Knjizeno"
        Otpremnice.VrednostCrvenogReda = False
        Otpremnice.BojaCrvenogReda = Color.FromArgb(237, 150, 130)

        Dim kk As DataGridViewColumn

        kk = New DataGridViewColumn
        kk.Name = "Broj"
        kk.HeaderText = "BROJ"
        kk.Width = 50
        'kk.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        kk.DisplayIndex = 0
        Otpremnice.DodajKolonuZaGrid(kk)

        kk = New DataGridViewColumn
        kk.Name = "Datum"
        kk.HeaderText = "DATUM"
        kk.Width = 100
        'kk.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        kk.DisplayIndex = 1
        Otpremnice.DodajKolonuZaGrid(kk)

        kk = New DataGridViewColumn
        kk.Name = "Kupac"
        kk.HeaderText = "KUPAC"
        kk.Width = 300
        kk.DisplayIndex = 2
        Otpremnice.DodajKolonuZaGrid(kk)

        kk = New DataGridViewCheckBoxColumn
        kk.Name = "RacunUradjen"
        kk.HeaderText = "RAČUN"
        kk.Width = 100
        kk.DisplayIndex = 3
        Otpremnice.DodajKolonuZaGrid(kk)

        kk = New DataGridViewColumn
        kk.Name = "BrojRacuna"
        kk.HeaderText = "BROJ RAČUNA"
        kk.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        kk.Width = 150
        kk.DisplayIndex = 4
        Otpremnice.DodajKolonuZaGrid(kk)

        kk = New DataGridViewCheckBoxColumn
        kk.Name = "Izvoz"
        kk.HeaderText = "IZVOZ"
        kk.Width = 100
        kk.DisplayIndex = 5
        Otpremnice.DodajKolonuZaGrid(kk)

        kk = New DataGridViewCheckBoxColumn
        kk.Name = "Knjizeno"
        kk.HeaderText = "KNJIŽENO"
        kk.Width = 100
        kk.DisplayIndex = 6
        Otpremnice.DodajKolonuZaGrid(kk)

    End Sub
    Sub GridPrenosnice()
        Prenosnice.Grid = GrdMain
        Prenosnice.KolikoVidljivihRedova = 0
        Prenosnice.DinamickaVisina = False
        Prenosnice.PrvaBoja = Color.FromArgb(232, 232, 232)
        Prenosnice.DrugaBoja = Color.FromArgb(183, 208, 229)
        Prenosnice.BojenjeRedova = False
        Prenosnice.CrveniRed = "Knjizeno"
        Prenosnice.VrednostCrvenogReda = False
        Prenosnice.BojaCrvenogReda = Color.FromArgb(237, 150, 130)

        Dim kk As DataGridViewColumn

        kk = New DataGridViewColumn
        kk.Name = "Broj"
        kk.HeaderText = "BROJ"
        kk.Width = 50
        'kk.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        kk.DisplayIndex = 0
        Prenosnice.DodajKolonuZaGrid(kk)

        kk = New DataGridViewColumn
        kk.Name = "Datum"
        kk.HeaderText = "DATUM"
        kk.Width = 100
        'kk.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        kk.DisplayIndex = 1
        Prenosnice.DodajKolonuZaGrid(kk)

        kk = New DataGridViewColumn
        kk.Name = "IzMagacina"
        kk.HeaderText = "Iz magacina"
        kk.Width = 300
        kk.DisplayIndex = 2
        Prenosnice.DodajKolonuZaGrid(kk)

        kk = New DataGridViewColumn
        kk.Name = "UMagacin"
        kk.HeaderText = "U magacin"
        kk.Width = 200
        kk.DisplayIndex = 3
        Prenosnice.DodajKolonuZaGrid(kk)


        kk = New DataGridViewCheckBoxColumn
        kk.Name = "Knjizeno"
        kk.HeaderText = "KNJIŽENO"
        kk.Width = 100
        kk.DisplayIndex = 4
        Prenosnice.DodajKolonuZaGrid(kk)

    End Sub
    Sub GridRashodi()
        Rashodi.Grid = GrdMain
        Rashodi.KolikoVidljivihRedova = 0
        Rashodi.DinamickaVisina = False
        Rashodi.PrvaBoja = Color.FromArgb(232, 232, 232)
        Rashodi.DrugaBoja = Color.FromArgb(183, 208, 229)
        Rashodi.BojenjeRedova = False
        Rashodi.CrveniRed = "Knjizeno"
        Rashodi.VrednostCrvenogReda = False
        Rashodi.BojaCrvenogReda = Color.FromArgb(237, 150, 130)

        Dim kk As DataGridViewColumn

        kk = New DataGridViewColumn
        kk.Name = "Broj"
        kk.HeaderText = "BROJ"
        kk.Width = 50
        'kk.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        kk.DisplayIndex = 0
        Rashodi.DodajKolonuZaGrid(kk)

        kk = New DataGridViewColumn
        kk.Name = "Datum"
        kk.HeaderText = "DATUM"
        kk.Width = 100
        'kk.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        kk.DisplayIndex = 1
        Rashodi.DodajKolonuZaGrid(kk)

        kk = New DataGridViewCheckBoxColumn
        kk.Name = "Knjizeno"
        kk.HeaderText = "KNJIŽENO"
        kk.Width = 100
        kk.DisplayIndex = 2
        Rashodi.DodajKolonuZaGrid(kk)

    End Sub
    Sub GridPopis()
        Popis.Grid = GrdMain
        Popis.KolikoVidljivihRedova = 0
        Popis.DinamickaVisina = False
        'Popis.PrvaBoja = Color.FromArgb(232, 232, 232)
        'Popis.DrugaBoja = Color.FromArgb(183, 208, 229)
        Popis.BojenjeRedova = False
        Popis.IzbaciPasivne = False
        Popis.CrveniRed = "Knjizeno"
        Popis.VrednostCrvenogReda = False
        Popis.BojaCrvenogReda = Color.FromArgb(237, 150, 130)

        Dim kk As DataGridViewColumn

        kk = New DataGridViewColumn
        kk.Name = "Broj"
        kk.HeaderText = "BROJ"
        kk.Width = 50
        'kk.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        kk.DisplayIndex = 0
        Popis.DodajKolonuZaGrid(kk)

        kk = New DataGridViewColumn
        kk.Name = "Datum"
        kk.HeaderText = "DATUM"
        kk.Width = 100
        'kk.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        kk.DisplayIndex = 1
        Popis.DodajKolonuZaGrid(kk)

        kk = New DataGridViewCheckBoxColumn
        kk.Name = "Knjizeno"
        kk.HeaderText = "KNJIŽENO"
        kk.Width = 100
        kk.DisplayIndex = 2
        Popis.DodajKolonuZaGrid(kk)

    End Sub
    Sub GridPocetnogStanja()
        PocetnoStanje.Grid = GrdMain
        PocetnoStanje.KolikoVidljivihRedova = 0
        PocetnoStanje.DinamickaVisina = False
        'PocetnoStanje.PrvaBoja = Color.FromArgb(232, 232, 232)
        'PocetnoStanje.DrugaBoja = Color.FromArgb(183, 208, 229)
        PocetnoStanje.BojenjeRedova = False
        PocetnoStanje.IzbaciPasivne = False

        Dim kk As DataGridViewColumn

        kk = New DataGridViewColumn
        kk.Name = "SifraArtikla"
        kk.HeaderText = "ŠIFRA"
        kk.Width = 80
        'kk.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        kk.DisplayIndex = 0
        PocetnoStanje.DodajKolonuZaGrid(kk)

        kk = New DataGridViewColumn
        kk.Name = "NazivArtikla"
        kk.HeaderText = "NAZIV"
        kk.Width = 200
        'kk.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        kk.DisplayIndex = 1
        PocetnoStanje.DodajKolonuZaGrid(kk)


        kk = New DataGridViewColumn
        kk.Name = "NabavnaCena"
        kk.HeaderText = "NABAVNA CENA"
        kk.Width = 140
        kk.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        kk.DefaultCellStyle.Format = "###,###,##0.00"
        kk.DisplayIndex = 2
        PocetnoStanje.DodajKolonuZaGrid(kk)

        kk = New DataGridViewColumn
        kk.Name = "ProdajnaCena"
        kk.HeaderText = "PRODAJNA CENA"
        kk.Width = 140
        kk.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        kk.DefaultCellStyle.Format = "###,###,##0.00"
        kk.DisplayIndex = 3
        PocetnoStanje.DodajKolonuZaGrid(kk)

        kk = New DataGridViewColumn
        kk.Name = "Kolicina"
        kk.HeaderText = "KOLIČINA"
        kk.Width = 120
        kk.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        kk.DefaultCellStyle.Format = "###,###,##0.00"
        kk.DisplayIndex = 4
        PocetnoStanje.DodajKolonuZaGrid(kk)

        kk = New DataGridViewColumn
        kk.Name = "NabavniIznos"
        kk.HeaderText = "NABAVNA VREDNOST"
        kk.Width = 170
        kk.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        kk.DefaultCellStyle.Format = "###,###,##0.00"
        kk.DisplayIndex = 5
        PocetnoStanje.DodajKolonuZaGrid(kk)

        kk = New DataGridViewColumn
        kk.Name = "ProdajniIznos"
        kk.HeaderText = "PRODAJNA VREDNOST"
        kk.Width = 170
        kk.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        kk.DefaultCellStyle.Format = "###,###,##0.00"
        kk.DisplayIndex = 6
        PocetnoStanje.DodajKolonuZaGrid(kk)

    End Sub



    '***Panel tasteri***
    Sub PanelModula(Optional ByVal KojiPanel As Panel = Nothing, Optional ByVal Taster As Button = Nothing)
        For Each cmd In KojiPanel.Controls
            'For Each cmd In pnl.Controls
            If TypeOf cmd Is Button Then
                cmd.BackColor = Color.Transparent
                cmd.ForeColor = Color.FromArgb(241, 246, 248)
            End If
            'Next
        Next

        If Not Taster Is Nothing Then
            Taster.ForeColor = Color.FromArgb(241, 246, 248)
            Taster.BackColor = Color.FromArgb(97, 133, 148)
        End If

        'Pretrazivanje = False
        'TxtNadji.Text = ""
        'TxtNadji.Visible = False


    End Sub
    Sub PanelGlavni(ByVal Taster As Button, KojiPanel As Panel, MainPanel As Panel)

        For Each cc In Panel.Controls
            If TypeOf cc Is Panel Then
                cc.visible = False
            End If
        Next
        KojiPanel.Visible = True
        KojiPanel.Left = 30
        KojiPanel.Top = 140
        KojiPanel.Height = Panel.Height


        For Each cmd In KojiPanel.Controls
            If TypeOf cmd IsNot ComboBox Then
                cmd.ForeColor = Color.FromArgb(241, 246, 248)
                cmd.BackColor = Color.Transparent
            End If
        Next

        'Taster.ForeColor = Color.Black
        'Taster.BackColor = Color.FromArgb(97, 133, 148)

        PanelBlackHorse.Visible = True
        PanelMohokSoft.Visible = True

        LblPanel.Text = Taster.Text

        TxtNadji.Text = ""
    End Sub

#End Region


#Region "GrdMain"
    Private Sub GrdMain_MouseClick(sender As Object, e As MouseEventArgs) Handles GrdMain.MouseClick
        Dim hit As DataGridView.HitTestInfo = GrdMain.HitTest(e.X, e.Y)

        'On Error GoTo greska

        If hit.RowIndex > -1 Then

            If e.Button = MouseButtons.Right Then
                For n = 0 To GrdMain.SelectedRows.Count - 1
                    If n > GrdMain.SelectedRows.Count Then
                        Exit For
                    End If
                    GrdMain.SelectedRows(n).Selected = False
                Next

            End If

            GrdMain.Rows(hit.RowIndex).Selected = True

            Select Case DocStatus
                Case "Komitenti", "Artikli", "RobneGrupe", "Magacini", "Banke", "Drzave", "Zaposleni", "VrsteTroskova"
                    Parametri.Sifra = CLng(GrdMain.Rows(hit.RowIndex).Cells("Sifra").Value)
                Case "Prijemnica", "Otpremnica", "KalkulacijaMaloprodaja", "KalkulacijaVeleprodaja", "Prenosnica", "Rashod", "FiskalniRacun", "DnevniIzvestaj", "NalogZaIspravku",
                    "RacunDomaci", "FinansijskiNalog", "Odjava", "PovracajRobe"
                    Parametri.Broj = CLng(GrdMain.Rows(hit.RowIndex).Cells("Broj").Value)

            End Select

        End If

        Exit Sub
greska:
    End Sub
    Private Sub GrdMain_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles GrdMain.MouseDoubleClick
        Dim hit As DataGridView.HitTestInfo = GrdMain.HitTest(e.X, e.Y)

        'On Error GoTo greska
        If hit.RowIndex < 0 Then Exit Sub
        Parametri.Novi = False

        Cursor = Cursors.WaitCursor

        Select Case DocStatus
            Case "Komitenti"
                Parametri.Sifra = CLng(GrdMain.Rows(hit.RowIndex).Cells("Sifra").Value)
                FrmSifarnikKomitenti.Dispose()
                Hide()
                FrmSifarnikKomitenti.ShowDialog()
                Komitenti.ReFill()
                KomitentiAktivni.ReFill()
                KupciAktivni.ReFill()
                DobavljaciAktivni.ReFill()
                Kupci.Refresh()
                Dobavljaci.Refresh()
                'SifarnikKomitenata.Refresh()
                Show()
            Case "Artikli"
                Parametri.Sifra = CLng(GrdMain.Rows(hit.RowIndex).Cells("Sifra").Value)
                FrmSifarnikArtikli.Dispose()
                'Hide()
                FrmSifarnikArtikli.ShowDialog()
                Artikli.ReFill()
                ArtikliStavke.ReFill()
                'ArtikliRN.ReFill()
                'SifarnikArtikala.Refresh()
                'Show()
            Case "RobneGrupe"
                Parametri.Sifra = CLng(GrdMain.Rows(hit.RowIndex).Cells("Sifra").Value)
                FrmSifarnikArtikliRobneGrupe.Dispose()
                Hide()
                FrmSifarnikArtikliRobneGrupe.ShowDialog()
                RobneGrupe.ReFill()
                'SifarnikRobnihGrupa.Refresh()
                Show()
            Case "Magacini"
                Parametri.Sifra = CLng(GrdMain.Rows(hit.RowIndex).Cells("Sifra").Value)
                FrmSifarnikMagacini.Dispose()
                Hide()
                FrmSifarnikMagacini.ShowDialog()
                Magacini.ReFill()
                SifarnikMagacina.Refresh()
                SifarnikUMagacin.Refresh()
                Show()

            Case "Prijemnica"
                Parametri.Broj = CLng(GrdMain.Rows(hit.RowIndex).Cells("Broj").Value)
                frmPrijemnica.Dispose()
                Hide()
                frmPrijemnica.ShowDialog()
                Prijemnice.ReFill()
                Show()
            Case "Otpremnica"
                Parametri.Broj = CLng(GrdMain.Rows(hit.RowIndex).Cells("Broj").Value)
                FrmOtpremnica.Dispose()
                Hide()
                FrmOtpremnica.ShowDialog()
                Otpremnice.ReFill()
                Show()
            Case "Prenosnica"
                Parametri.Broj = CLng(GrdMain.Rows(hit.RowIndex).Cells("Broj").Value)
                frmPrenosnica.Dispose()
                Hide()
                frmPrenosnica.ShowDialog()
                Prenosnice.ReFill()
                Show()
            Case "Rashod"
                Parametri.Broj = CLng(GrdMain.Rows(hit.RowIndex).Cells("Broj").Value)
                frmRashod.Dispose()
                Hide()
                frmRashod.ShowDialog()
                Rashodi.ReFill()
                Show()
            Case "Popis"
                Parametri.Broj = CLng(GrdMain.Rows(hit.RowIndex).Cells("Broj").Value)
                frmPopis.Dispose()
                Hide()
                frmPopis.ShowDialog()
                Popis.ReFill()
                Show()




        End Select

        TxtNadji.Text = ""

        Cursor = Cursors.Default
        Exit Sub
greska:
        MsgBox(Err.Description)
        Cursor = Cursors.Default
        Show()
    End Sub
    Private Sub GrdMain_ColumnHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles GrdMain.ColumnHeaderMouseClick

        Select Case DocStatus
            Case "Komitenti"
                Komitenti.ObojRedove()
            Case "Artikli"
                Artikli.ObojRedove()
            Case "RobneGrupe"
                RobneGrupe.ObojRedove()
            Case "Prijemnica"
                Prijemnice.ObojRedove()
            Case "Otpremnica"
                Otpremnice.ObojRedove()
            Case "Prenosnica"
                Prenosnice.ObojRedove()
            Case "Rashod"
                Rashodi.ObojRedove()
                Prenosnice.ObojRedove()
            Case "Rashod"
                Rashodi.ObojRedove()

        End Select
    End Sub
    Private Sub GrdMain_ColumnWidthChanged(sender As Object, e As DataGridViewColumnEventArgs)
        'If Razvlacenje Then
        '    SnimiSirineKolona(DocStatus, GrdMain)
        '    Razvlacenje = False
        'End If

    End Sub
    Private Sub GrdMain_MouseDown(sender As Object, e As MouseEventArgs)
        'Razvlacenje = True
    End Sub

    Private Sub CmdMagacin2D_Click(sender As Object, e As EventArgs) Handles CmdMagacin2D.Click
        Dim mag As New GrafickiPrikazApp.WareHouse
        mag.show()
    End Sub



#End Region







End Class
