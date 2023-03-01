Imports System.Collections.ObjectModel
Imports System.Data.SqlClient
Imports System.Globalization


Module Globalne

#Region "Promenjljive"

    Public Veza As SqlConnection

    Public Operater As String
    Public UserID As Integer
    Public UserLevel As Integer
    Public MinusID As Integer
    Public Lozinka As String
    Public ProgramID As Integer

    Public FormatDatuma As String = "M/dd/yyyy"
    Public DocStatus As String
    Public ImeSQLServera As String = "MOHOK-SERVER\MOHOKSQL"
    Public NazivPrograma As String

    Public Godina As Integer
    Public TekucaGodina As Integer
    Public TekuciMagacin As Integer

    Public Selektovano As Long

    Public Manjak As Boolean
    Public ArtikalUMagacinu As Boolean
    Public Pretrazivanje As Boolean

    Public Komitenti As Lista
    Public KomitentiAktivni As Lista
    Public KupciAktivni As Lista
    Public DobavljaciAktivni As Lista
    Public Artikli As Lista
    Public ArtikliStavke As Lista
    Public ArtikliRN As Lista
    Public RobneGrupe As Lista
    Public Magacini As Lista

    Public Prijemnice As Lista
    Public Otpremnice As Lista
    Public Prenosnice As Lista
    Public PovracajRobeDobavljacu As Lista
    Public Rashodi As Lista
    Public Popis As Lista
    Public PocetnoStanje As Lista

    Public Trebovanja As Lista
    Public Predajnice As Lista

    Public Kupci As Sifarnik
    Public Dobavljaci As Sifarnik
    Public SifarnikRobnihGrupa As Sifarnik
    Public SifarnikVrstaArtikala As Sifarnik
    Public SifarnikMagacina As Sifarnik
    Public SIfarnikGlavniMagacin As Sifarnik
    Public SifarnikUMagacin As Sifarnik
    Public SifarnikNacinaIsporike As Sifarnik
    Public SifarnikDrzava As Sifarnik
    Public SifarnikMeseca As Sifarnik

    Public Structure ReturningComplet
        Dim Poruka As String
        Dim Lista As Collection(Of DataRow)
    End Structure

#End Region


#Region "Parametri"

    Structure Paramet
        Dim ID As Long
        Dim Broj As Long
        Dim BrojString As String
        Dim BrojDokumenta As Long

        Dim Sifra As Long
        Dim SifraArtikla As Long
        Dim Komitent As Long
        Dim Kupac As Long
        Dim Dobavljac As Long

        Dim PravoPristupa As Integer
        Dim VrstaArtikla As Integer
        Dim RBR As Integer
        Dim Poreklo As Integer

        Dim DatumOd As Date
        Dim DatumDo As Date
        Dim Datum As Date

        Dim Novi As Boolean
        Dim NoviDokument As Boolean
        Dim NovaRobnaGrupa As Boolean
        Dim NovaDrzava As Boolean
        Dim Azurirano As Boolean

        Dim Naziv As String

        Dim Izvestaj As Integer
        Dim NazivIzvestaja As String
        Dim ModulIzvestaja As String

        Dim Sortiranje As String

    End Structure
    Public Parametri As Paramet
#End Region


#Region "GetData/InsertData"
    Function GetData(sqlCommand As String) As DataTable
        Dim table As New DataTable
        Dim cmd As SqlCommand
        Dim da As New SqlDataAdapter

        cmd = New SqlCommand(sqlCommand, Veza)
        da.SelectCommand = cmd
        table.Locale = CultureInfo.InvariantCulture

        da.Fill(table)
        da.Dispose()
        cmd.Dispose()

        Return table
        table.Dispose()
    End Function
    Sub InsertData(sqlCommand As String, Optional Parametar As SqlParameter = Nothing)
        Dim cmd As SqlCommand

        If IsNothing(Parametar) = False Then
            cmd = New SqlCommand(sqlCommand, Veza)
            cmd.Parameters.Add(Parametar)
        Else
            cmd = New SqlCommand(sqlCommand, Veza)
        End If


        cmd.ExecuteNonQuery()
        cmd.Dispose()
    End Sub

#End Region


#Region "Funkcije grida"
    Sub GridZaListuStavkiArtikala(KojiGrid As DataGridView)
        ArtikliStavke.Grid = KojiGrid
        ArtikliStavke.KolikoVidljivihRedova = 0
        ArtikliStavke.DinamickaVisina = False
        ArtikliStavke.BojenjeRedova = False

        Dim kk As DataGridViewColumn

        kk = New DataGridViewColumn
        kk.Name = "Sifra"
        kk.HeaderText = "ŠIFRA"
        kk.Width = 80
        'kk.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        kk.DisplayIndex = 0
        ArtikliStavke.DodajKolonuZaGrid(kk)

        kk = New DataGridViewColumn
        kk.Name = "Naziv"
        kk.HeaderText = "NAZIV"
        kk.Width = 260
        'kk.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        kk.DisplayIndex = 1
        ArtikliStavke.DodajKolonuZaGrid(kk)

        kk = New DataGridViewColumn
        kk.Name = "JedinicaMere"
        kk.HeaderText = "Jed.mere"
        kk.Width = 60
        kk.DisplayIndex = 2
        ArtikliStavke.DodajKolonuZaGrid(kk)

        kk = New DataGridViewColumn
        kk.Name = "KataloskiBroj"
        kk.HeaderText = "Kataloški br"
        kk.Width = 100
        kk.DisplayIndex = 3
        ArtikliStavke.DodajKolonuZaGrid(kk)

        kk = New DataGridViewColumn
        kk.Name = "Oznaka"
        kk.HeaderText = "Oznaka"
        kk.Width = 100
        kk.DisplayIndex = 4
        ArtikliStavke.DodajKolonuZaGrid(kk)

    End Sub
    Sub GridZaListuKomitenta(KojiGrid As DataGridView, ListaKomitenata As Lista)
        ListaKomitenata.Grid = KojiGrid
        ListaKomitenata.KolikoVidljivihRedova = 0
        ListaKomitenata.DinamickaVisina = False
        ListaKomitenata.BojenjeRedova = False

        Dim kk As DataGridViewColumn

        kk = New DataGridViewColumn
        kk.Name = "Sifra"
        kk.HeaderText = "ŠIFRA"
        kk.Width = 50
        'kk.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        kk.DisplayIndex = 0
        ListaKomitenata.DodajKolonuZaGrid(kk)

        kk = New DataGridViewColumn
        kk.Name = "Naziv"
        kk.HeaderText = "NAZIV"
        kk.Width = 200
        'kk.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        kk.DisplayIndex = 1
        ListaKomitenata.DodajKolonuZaGrid(kk)

        kk = New DataGridViewColumn
        kk.Name = "Mesto"
        kk.HeaderText = "MESTO"
        kk.Width = 150
        kk.DisplayIndex = 2
        ListaKomitenata.DodajKolonuZaGrid(kk)

        kk = New DataGridViewColumn
        kk.Name = "PIB"
        kk.HeaderText = "PIB"
        kk.Width = 90
        kk.DisplayIndex = 3
        ListaKomitenata.DodajKolonuZaGrid(kk)

        kk = New DataGridViewColumn
        kk.Name = "MaticniBroj"
        kk.HeaderText = "MAT. BR"
        kk.Width = 90
        kk.DisplayIndex = 4
        ListaKomitenata.DodajKolonuZaGrid(kk)

    End Sub


    Sub PostaviSirineKolona(Tabela As String, KojiGrid As DataGridView)
        Dim Kolone(,) As String
        If KojiGrid.Columns.Count = 0 Then Exit Sub

        Kolone = GetAllSettings(My.Application.Info.Title, Tabela)
        If IsNothing(Kolone) Then Exit Sub

        For n = LBound(Kolone, 1) To UBound(Kolone, 1)
            If IsNumeric(Kolone(n, 1)) Then
                KojiGrid.Columns.Item(Kolone(n, 0)).Width = Kolone(n, 1)
            End If
        Next
    End Sub
    Sub SnimiSirineKolona(Tabela As String, KojiGrid As DataGridView)
        For n = 0 To KojiGrid.Columns.Count - 1
            SaveSetting(My.Application.Info.Title, Tabela, KojiGrid.Columns(n).Name, KojiGrid.Columns(n).Width)
        Next
    End Sub

    Function NumerickaProveraKolonaGrida(Grid As myDataGridView, Red As Integer, Optional KojeKolone As String = "") As Boolean
        Dim Resp As Boolean = True
        Dim Kolone() = KojeKolone.Split(",")

        If KojeKolone = "" Then
            If Red = -1 Then
                For r = 0 To Grid.Rows.Count - 1
                    For n = Grid.PrvaKolona To Grid.PoslednjaKolona

                        If IsNumeric(Grid.Rows(r).Cells(n).Value) = False Then
                            Return False
                        End If
                    Next
                Next
            Else
                For n = 0 To Grid.Columns.Count - 1
                    If IsNumeric(Grid.Rows(Red).Cells(n).Value) = False Then
                        Return False
                    End If
                Next
            End If
        Else
            If Red = -1 Then
                For r = 0 To Grid.Rows.Count - 1
                    For n = 0 To Grid.Columns.Count - 1
                        For k = 0 To Kolone.Count - 1
                            If IsNumeric(Kolone(k)) Then
                                If n = CInt(Kolone(k)) Then
                                    If IsNumeric(Grid.Rows(r).Cells(n).Value) = False Then
                                        Return False
                                    End If
                                End If
                            Else
                                If Kolone(k) = Grid.Columns(n).Name Then
                                    If IsNumeric(Grid.Rows(r).Cells(Kolone(k)).Value) = False Then
                                        Return False
                                    End If
                                End If
                            End If
                        Next
                    Next
                Next
            Else
                For n = 0 To Grid.Columns.Count - 1
                    For k = 0 To Kolone.Count - 1
                        If IsNumeric(Kolone(k)) Then
                            If n = CInt(Kolone(k)) Then
                                If IsNumeric(Grid.Rows(Red).Cells(n).Value) = False Then
                                    Return False
                                End If
                            End If
                        Else
                            If Kolone(k) = Grid.Columns(n).Name Then
                                If IsNumeric(Grid.Rows(Red).Cells(Kolone(k)).Value) = False Then
                                    Return False
                                End If
                            End If
                        End If
                    Next
                Next
            End If
        End If


        Return Resp
    End Function


    Sub GridDesniKlik(sender As Object, e As MouseEventArgs, Mnu As ContextMenuStrip, Grid As DataGridView)
        Dim hit As DataGridView.HitTestInfo = Grid.HitTest(e.X, e.Y)

        If hit.RowIndex > Grid.RowCount - 1 Or hit.RowIndex < 0 Then Exit Sub

        If IsDBNull(Grid.Rows(hit.RowIndex).Cells(0).Value) Then Exit Sub

        If e.Button = MouseButtons.Right Then
            For n = 0 To Grid.SelectedRows.Count - 1
                If n > Grid.SelectedRows.Count Then Exit For
                Grid.SelectedRows(n).Selected = False
            Next

            For n = 0 To Grid.SelectedCells.Count - 1
                If n > Grid.SelectedCells.Count - 1 Then Exit For
                Grid.SelectedCells(n).Selected = False
            Next

            Dim Kolona As Integer = 0
            If hit.ColumnIndex > -1 Then
                Kolona = hit.ColumnIndex
            End If

            Parametri.Sortiranje = Grid.Columns(Kolona).Name
            Grid.Rows(hit.RowIndex).Selected = True
            Grid.Columns(Kolona).Selected = True
            Mnu.Show(Grid, e.X, e.Y)
        End If
    End Sub

#End Region





#Region "DajVrednost i stanja"
    Public Function DajKurs(Valuta As String) As Double
        Dim rs As DataTable
        Dim VrednostFunkcije As Double

        If Valuta = "" Then
            VrednostFunkcije = 1
        Else
            rs = GetData("SELECT * FROM Kurs WHERE Valuta='" & Valuta & "' ORDER BY ID DESC")

            If rs.Rows.Count > 0 Then
                VrednostFunkcije = rs(0)!Iznos
            Else
                VrednostFunkcije = 1
            End If
        End If

        Return VrednostFunkcije
    End Function
    Public Function DajStanje(Sifra As Long, Magacin As Integer, TekucaGodina As Integer, Optional Poruka As Boolean = True) As Double
        Dim VrednostFunkcije As Double
        Dim rs As DataTable

        If TekucaGodina = Godina Then
            rs = GetData("SELECT * FROM Zaliha WHERE Sifra=" & Sifra & " And Magacin=" & Magacin)
        Else
            rs = GetData("SELECT PopisStavke.NovoStanje AS Zaliha FROM Popis INNER JOIN PopisStavke ON Popis.Magacin = PopisStavke.Magacin 
                        AND Popis.Broj = PopisStavke.BrojPopisa AND Popis.Godina = PopisStavke.Godina
                        WHERE Popis.Magacin =" & Magacin & " AND PopisStavke.SifraArtikla =" & Sifra & " AND Popis.Godina =" & Godina & " AND Popis.ZavrsniPopis = 'True'")
        End If

        If rs.Rows.Count = 0 Then
            'If Poruka Then
            '    If TekucaGodina = Godina Then
            '        MsgBox("Artikal se ne nalazi u izabranom magacinu", MsgBoxStyle.Exclamation)
            '    Else
            '        MsgBox("Artikal nije pronađen u završnom popisu za " & Godina & ". godinu", MsgBoxStyle.Exclamation)
            '    End If
            'End If
            VrednostFunkcije = 0
        Else
            If IsNumeric(rs.Rows(0)!Zaliha) = False Then
                VrednostFunkcije = 0
            Else
                VrednostFunkcije = rs.Rows(0)!Zaliha
            End If
        End If

        Return VrednostFunkcije
    End Function


    Public Function ProveraStanja(BrojT As Integer, Magacin As Integer, StavkeZaStanje As DataTable) As Boolean
        Dim rsZ As DataTable

        Manjak = False

        InsertData("DELETE FROM IzvestajStanja WHERE IDOperatera=" & UserID)

        For n = 0 To StavkeZaStanje.Rows.Count - 1
            rsZ = GetData("SELECT * FROM Zaliha WHERE Sifra=" & StavkeZaStanje.Rows(n)!SifraArtikla & " And Magacin=" & Magacin)
            If rsZ.Rows.Count > 0 Then
                If rsZ(0)!Zaliha < StavkeZaStanje.Rows(n)!Kolicina Then
                    InsertData("INSERT INTO IzvestajStanja VALUES(" & StavkeZaStanje.Rows(n)!SifraArtikla & ",'" & StavkeZaStanje.Rows(n)!NazivArtikla & "'," & rsZ(0)!Zaliha & "," & StavkeZaStanje.Rows(n)!Kolicina & "," & UserID & ")")
                    Manjak = True
                End If
            Else
                InsertData("INSERT INTO IzvestajStanja VALUES(" & StavkeZaStanje.Rows(n)!SifraArtikla & ",'" & StavkeZaStanje.Rows(n)!NazivArtikla & "',0," & StavkeZaStanje.Rows(n)!Kolicina & "," & UserID & ")")
                Manjak = True
            End If
            rsZ.Dispose()
        Next

        Return Manjak

    End Function
    Public Function ProveraArtikalaUMagacinu(BrojT As Integer, Magacin As Integer, StavkeZaStanje As DataTable) As Boolean
        Dim rsZ As DataTable

        ArtikalUMagacinu = True
        InsertData("DELETE FROM IzvestajStanja WHERE IDOperatera=" & UserID)

        For n = 0 To StavkeZaStanje.Rows.Count - 1
            rsZ = GetData("SELECT * FROM Zaliha WHERE Sifra=" & StavkeZaStanje.Rows(n)!SifraArtikla & " And Magacin=" & Magacin)
            If rsZ.Rows.Count = 0 Then
                InsertData("INSERT INTO IzvestajStanja VALUES(" & StavkeZaStanje.Rows(n)!SifraArtikla & ",'" & StavkeZaStanje.Rows(n)!NazivArtikla & "',0,0," & UserID & ")")
                ArtikalUMagacinu = False
            End If
            rsZ.Dispose()
        Next

        Return ArtikalUMagacinu
    End Function

#End Region




#Region "Ostale globalne funkcije"

    Public Function DajRacunar() As String

        DajRacunar = SystemInformation.ComputerName

    End Function
    Public Function ProveraPristupaModulu(IDOperatera As Integer, IDPrograma As Integer, Modul As String) As Integer
        Dim rs As DataTable
        Dim IDModula As Integer

        rs = GetData("SELECT * FROM ProgramskiModuli WHERE Modul='" & Modul & "' AND IDPrograma=" & IDPrograma)
        If rs.Rows.Count > 0 Then
            IDModula = rs(0)!IDModula
        Else
            IDModula = 0
        End If
        rs = GetData("SELECT * FROM ProgramiOperateri WHERE Operater=" & IDOperatera & " AND Program=" & IDPrograma & " AND ProgramskiModul=" & IDModula)
        ProveraPristupaModulu = 0
        If rs.Rows.Count > 0 Then
            If rs(0)!Citaj Then
                ProveraPristupaModulu = 1
            End If

            If rs(0)!Pisi Then
                ProveraPristupaModulu = 2
            End If

            If rs(0)!Administrator Then
                ProveraPristupaModulu = 3
            End If
        End If

        ProveraPristupaModulu = 2

        If My.Computer.Name = "MOHOK-MAJA" Or My.Computer.Name = "ADLER" Then ProveraPristupaModulu = 2
    End Function


    Public Function BrisiTackuUDatumu(Datum As String) As Date
        Dim VrednostFunkcije As Date
        Dim Tacka As Integer = InStrRev(Datum, ".")

        If Tacka > 0 Then
            VrednostFunkcije = CDate(Mid(Datum, 1, Tacka - 1))
        Else
            VrednostFunkcije = CDate(Datum)
        End If

        Return VrednostFunkcije
    End Function
    Sub DajPeriod(Mesec As String, nGodina As Integer)

        Select Case Trim(Mesec)
            Case "Januar"
                Parametri.DatumOd = "01/01/" & nGodina
                Parametri.DatumDo = "31/01/" & nGodina
            Case "Februar"
                If Date.IsLeapYear(nGodina) Then
                    Parametri.DatumOd = "01/02/" & nGodina
                    Parametri.DatumDo = "29/02/" & nGodina
                Else
                    Parametri.DatumOd = "01/02/" & nGodina
                    Parametri.DatumDo = "28/02/" & nGodina
                End If
            Case "Mart"
                Parametri.DatumOd = "01/03/" & nGodina
                Parametri.DatumDo = "31/03/" & nGodina
            Case "April"
                Parametri.DatumOd = "01/04/" & nGodina
                Parametri.DatumDo = "30/04/" & nGodina
            Case "Maj"
                Parametri.DatumOd = "01/05/" & nGodina
                Parametri.DatumDo = "31/05/" & nGodina
            Case "Jun"
                Parametri.DatumOd = "01/06/" & nGodina
                Parametri.DatumDo = "30/06/" & nGodina
            Case "Jul"
                Parametri.DatumOd = "01/07/" & nGodina
                Parametri.DatumDo = "31/07/" & nGodina
            Case "Avgust"
                Parametri.DatumOd = "01/08/" & nGodina
                Parametri.DatumDo = "31/08/" & nGodina
            Case "Septembar"
                Parametri.DatumOd = "01/09/" & nGodina
                Parametri.DatumDo = "30/09/" & nGodina
            Case "Oktobar"
                Parametri.DatumOd = "01/10/" & nGodina
                Parametri.DatumDo = "31/10/" & nGodina
            Case "Novembar"
                Parametri.DatumOd = "01/11/" & nGodina
                Parametri.DatumDo = "30/11/" & nGodina
            Case "Decembar"
                Parametri.DatumOd = "01/12/" & nGodina
                Parametri.DatumDo = "31/12/" & nGodina
            Case "Ceo period"
                Parametri.DatumOd = "01/01/" & nGodina
                If Godina <> TekucaGodina Then
                    Parametri.DatumDo = "31/12/" & Godina
                Else
                    Parametri.DatumDo = Now.Date
                End If
        End Select

        Parametri.DatumOd = CDate(Format(Parametri.DatumOd, "dd/M/yyyy"))
        Parametri.DatumDo = CDate(Format(Parametri.DatumDo, "dd/M/yyyy"))
    End Sub
    Public Function DajNedeljuUGodini(Datum As Date) As Integer
        Dim dfi = DateTimeFormatInfo.CurrentInfo
        Dim calendar = dfi.Calendar

        Dim weekOfyear = calendar.GetWeekOfYear(Datum, dfi.CalendarWeekRule, DayOfWeek.Monday)

        Return weekOfyear
    End Function







#End Region







End Module
