Imports System.Collections.ObjectModel

'Imports Pabo.Calendar
Module Klase

#Region "Globalne promenljive"
    Public Enum Statusi As Integer
        Radni_Dan = 1
        Neradni_Dan_Placeno = 2
        Neradni_Dan_Neplaceno = 3
        Godisnji_Odmor = 4
        Bolovanje = 5
        Slobodan_Dan_Placeno = 6
        Slobodan_Dan_Neplaceno = 7
    End Enum

    Public Enum BojeStatusa
        Radni_Dan = &H7171D3&
        Neradni_Dan_Placeno = &HDB536D&
        Neradni_Dan_Neplaceno = &H8448A3&
        Godisnji_Odmor = &HCCAA48&
        Bolovanje = &H3434B7&
        Slobodan_Dan_Placeno = &H5CC659&
        Slobodan_Dan_Neplaceno = &H24A08E&
    End Enum
#End Region

#Region "Klasa Lista"
    Public Class Lista
        'Implements ICloneable

        Public Property IzbaciPasivne As Boolean = True
        Public Property BojenjeRedova As Boolean
        Public Property CrveniRed As String = ""
        Public Property HighLightRed As String = ""
        Public Property VrednostHighLightReda As String = ""
        Public Property BojaCrvenogReda As Color
        Public Property PrvaBoja As Color
        Public Property DrugaBoja As Color
        Public Property HighLight As Color
        Public Property KolikoVidljivihRedova As Integer = 5
        Public Property DinamickaVisina As Boolean = False
        Public Property Upit As String = ""
        Public Property FreezIndex As Boolean = True
        Public Property VrednostCrvenogReda As Boolean = True
        Public Property KolonaPotrazuje As String = "Potrazuje"
        Public Property KolonaDuguje As String = "Duguje"
        Public Property KolonaSaldo As String = "Saldo"
        Public Property RacunanjeSalda As Boolean = False

        Private mGrid As DataGridView
        Public Property Grid() As DataGridView
            Get
                Return mGrid
            End Get
            Set(ByVal value As DataGridView)
                mGrid = value
                GridKolone.Clear()
            End Set
        End Property

        Private rsLista As New DataTable
        Private Napunjen As Boolean = False
        Private Filterisan As Boolean = False
        Private Redovi() As DataRow
        Private rsListaFilter As New DataTable
        Private GridKolone As New Collection(Of DataGridViewColumn)
        Private Boja As Boolean

        Public Sub Puni()
            rsLista = New DataTable

            rsLista = GetData(Upit)

            If RacunanjeSalda Then
                Dim MedjuSaldo As Double = 0

                For n = 0 To rsLista.Rows.Count - 1
                    rsLista(n).Item(KolonaSaldo) = (rsLista(n).Item(KolonaDuguje) - rsLista(n).Item(KolonaPotrazuje)) + MedjuSaldo
                    MedjuSaldo += (rsLista(n).Item(KolonaDuguje) - rsLista(n).Item(KolonaPotrazuje))
                Next
            End If

            Napunjen = True
        End Sub

        Public Sub ReFill()
            If IsNothing(Grid) Then Exit Sub
            Filterisan = False
            Puni()
            DajSve()
        End Sub

        Public Function Trazi(Sta As String) As DataTable
            For n = 0 To rsLista.Columns.Count - 1
                If IsNumeric(Sta) And (rsLista.Columns(n).DataType = Type.GetType("System.Int32")) Then
                    Redovi = rsLista.Select(rsLista.Columns(n).ColumnName & Sta)
                    If Redovi.Count > 0 Then
                        Exit For
                    End If
                End If
                If rsLista.Columns(n).DataType = Type.GetType("System.String") Then
                    Redovi = rsLista.Select(rsLista.Columns(n).ColumnName & " LIKE '%" & Sta & "%'")
                    If Redovi.Count > 0 Then
                        Exit For
                    End If
                End If
            Next

            If Redovi.Count > 0 Then
                Return Redovi.CopyToDataTable
            Else
                Return Nothing
            End If

        End Function

        Public Sub Filter(sFilter As String)
            If IsNothing(Grid) Then Exit Sub
            rsLista = rsLista.Select(sFilter).CopyToDataTable
            GridLista(rsLista)
        End Sub

        Public Sub Clear()
            mGrid.DataSource = Nothing
            mGrid.Rows.Clear()

        End Sub

        Public Function Trazi(Sta As String, UGrid As Boolean, Optional Kolona As String = "", Optional Redosled As Collection(Of String) = Nothing, Optional SaLeveStrane As Boolean = False) As DataTable
            Dim Upit As String = ""

            If Napunjen = True And Filterisan = False Then
                Filterisan = True

                If IzbaciPasivne Then
                    If Upit = "" Then
                        rsListaFilter = rsLista.Select("Pasivan=False").CopyToDataTable
                    Else
                        rsListaFilter = rsLista.Select(Upit & " AND Pasivan=False").CopyToDataTable
                    End If
                Else
                    If Upit = "" Then
                        rsListaFilter = rsLista
                    Else
                        rsListaFilter = rsLista.Select(Upit).CopyToDataTable
                    End If

                End If
            End If

            If Kolona = "" Then
                If Redosled Is Nothing Then
                    For n = 0 To rsListaFilter.Columns.Count - 1
                        If IsNumeric(Sta) = True And Sta.StartsWith("0") = False And (rsListaFilter.Columns(n).DataType = Type.GetType("System.Int32")) And Sta.EndsWith("-") = False Then
                            Sta = Sta.Replace(",", ".")
                            Redovi = rsListaFilter.Select(rsListaFilter.Columns(n).ColumnName & "=" & Sta)
                            If Redovi.Count > 0 Then
                                Exit For
                            End If
                        End If

                        If IsNumeric(Sta) And Sta.StartsWith("0") = False And (rsListaFilter.Columns(n).DataType = Type.GetType("System.Int64")) And Sta.EndsWith("-") = False Then
                            Sta = Sta.Replace(",", ".")
                            Redovi = rsListaFilter.Select(rsListaFilter.Columns(n).ColumnName & "=" & Sta)
                            If Redovi.Count > 0 Then
                                Exit For
                            End If
                        End If

                        If rsListaFilter.Columns(n).DataType = Type.GetType("System.String") Then
                            If SaLeveStrane Then
                                Redovi = rsListaFilter.Select(rsListaFilter.Columns(n).ColumnName & " LIKE '" & Trim(Sta) & "%'")
                            Else
                                Redovi = rsListaFilter.Select(rsListaFilter.Columns(n).ColumnName & " LIKE '%" & Trim(Sta) & "%'")
                            End If
                            'Redovi = rsListaFilter.Select(rsListaFilter.Columns(n).ColumnName & " LIKE '%" & Trim(Sta) & "%'")
                            If Redovi.Count = 0 Then
                                If SaLeveStrane Then
                                    Redovi = rsListaFilter.Select(rsListaFilter.Columns(n).ColumnName & " LIKE '" & Trim(Sta) & "%'")
                                Else
                                    Redovi = rsListaFilter.Select(rsListaFilter.Columns(n).ColumnName & " LIKE '%" & Trim(Sta) & "%'")
                                End If
                                'Redovi = rsListaFilter.Select(rsListaFilter.Columns(n).ColumnName & " LIKE '%" & Trim(Sta) & "%'")
                                If Redovi.Count > 0 Then Exit For
                            Else
                                Exit For
                            End If
                        End If

                        If rsListaFilter.Columns(n).DataType = Type.GetType("System.DateTime") Then
                            If IsDate(Sta) Then
                                Redovi = rsListaFilter.Select(rsListaFilter.Columns(n).ColumnName & " = #" & Format(CDate(Sta), FormatDatuma) & "#")
                                If Redovi.Count = 0 Then
                                    'Redovi = rsListaFilter.Select(rsListaFilter.Columns(n).ColumnName & " LIKE '%" & Trim(Sta) & "%'")
                                    If Redovi.Count > 0 Then Exit For
                                Else
                                    Exit For
                                End If
                            End If

                        End If
                    Next
                Else
                    Dim SveKolone As String = ""
                    For r = 0 To Redosled.Count - 1
                        Select Case DajVrstuKolone(Redosled(r))
                            Case "Numerik"
                                If (IsNumeric(Sta) = True) And (InStr(Sta, ",") = 0) Then
                                    SveKolone += Redosled(r) & "=" & Sta
                                    If r < Redosled.Count - 1 Then
                                        SveKolone += " OR "
                                    End If
                                End If
                            Case "Tekst"
                                SveKolone += Redosled(r) & " LIKE '%" & Trim(Sta) & "%'"
                                If r < Redosled.Count - 1 Then
                                    SveKolone += " OR "
                                End If
                        End Select
                    Next
                    SveKolone = ProveraUpitaTrazenja(SveKolone)
                    Redovi = rsListaFilter.Select(SveKolone)
                End If
            Else
                If IsNumeric(Sta) And Sta.StartsWith("0") = False And (rsListaFilter.Columns(Kolona).DataType = Type.GetType("System.Int32")) Then
                    Redovi = rsListaFilter.Select(Kolona & "=" & Sta)
                End If

                If rsListaFilter.Columns(Kolona).DataType = Type.GetType("System.String") Then
                    If SaLeveStrane Then
                        Redovi = rsListaFilter.Select(Kolona & " LIKE '" & Trim(Sta) & "%'")
                    Else
                        Redovi = rsListaFilter.Select(Kolona & " LIKE '%" & Trim(Sta) & "%'")
                    End If
                    'Redovi = rsListaFilter.Select(Kolona & " LIKE '%" & Trim(Sta) & "%'")
                    If Redovi.Count = 0 Then
                        If SaLeveStrane Then
                            Redovi = rsListaFilter.Select(Kolona & " LIKE '" & Trim(Sta) & "%'")
                        Else
                            Redovi = rsListaFilter.Select(Kolona & " LIKE '%" & Trim(Sta) & "%'")
                        End If
                        'Redovi = rsListaFilter.Select(Kolona & " LIKE '%" & Trim(Sta) & "%'")
                    End If
                End If
            End If



            If UGrid Then
                Dim rsResp As DataTable
                If Redovi.Count = 0 Then
                    rsResp = New DataTable
                Else
                    rsResp = Redovi.CopyToDataTable
                End If
                If RacunanjeSalda Then
                    Dim MedjuSaldo As Double = 0

                    For n = 0 To rsResp.Rows.Count - 1
                        rsResp(n).Item(KolonaSaldo) = (rsResp(n).Item(KolonaDuguje) - rsResp(n).Item(KolonaPotrazuje)) + MedjuSaldo
                        MedjuSaldo += (rsResp(n).Item(KolonaDuguje) - rsResp(n).Item(KolonaPotrazuje))
                    Next
                End If
                GridLista(rsResp)
            End If

            If Redovi.Count > 0 Then
                Return Redovi.CopyToDataTable
            Else
                Return Nothing
            End If

        End Function

        Function ProveraUpitaTrazenja(Upit As String) As String
            Dim Resp As String = Upit

            Dim o As Integer = InStrRev(Upit, "OR")
            If o = Upit.Length - 2 Then
                Resp = Mid(Upit, 1, o - 1)
            End If

            Return Resp
        End Function

        Function DajVrstuKolone(Kolona As String) As String
            Dim Resp As String = ""

            For n = 0 To rsListaFilter.Columns.Count - 1
                If rsListaFilter.Columns(n).ColumnName = Kolona Then
                    If rsListaFilter.Columns(n).DataType = Type.GetType("System.String") Then
                        Resp = "Tekst"
                    End If
                    If rsListaFilter.Columns(n).DataType = Type.GetType("System.Int32") Then
                        Resp = "Numerik"
                    End If
                    If rsListaFilter.Columns(n).DataType = Type.GetType("System.Int64") Then
                        Resp = "Numerik"
                    End If
                    If rsListaFilter.Columns(n).DataType = Type.GetType("System.DateTime") Then
                        Resp = "DatumVreme"
                    End If
                End If
            Next
            Return Resp
        End Function

        Sub GridLista(rsGrid As DataTable)
            Dim Sirina As Integer

            If IsNothing(mGrid.DataSource) = False Then mGrid.DataSource = Nothing

            If rsGrid.Rows.Count = 0 Then
                Exit Sub
            End If

            If KolikoVidljivihRedova > 0 Then Grid.RowCount = KolikoVidljivihRedova
            mGrid.DataSource = rsGrid

            For n = 0 To Grid.Columns.Count - 1
                mGrid.Columns(n).Visible = False
            Next

            For n = 0 To GridKolone.Count - 1
                mGrid.Columns(GridKolone(n).Name).HeaderText = GridKolone(n).HeaderText
                mGrid.Columns(GridKolone(n).Name).DefaultCellStyle = GridKolone(n).DefaultCellStyle
                mGrid.Columns(GridKolone(n).Name).Width = GridKolone(n).Width
                mGrid.Columns(GridKolone(n).Name).Visible = GridKolone(n).Visible
                mGrid.Columns(GridKolone(n).Name).DisplayIndex = GridKolone(n).DisplayIndex
                Sirina += mGrid.Columns(GridKolone(n).Name).Width
            Next

            If KolikoVidljivihRedova > 0 Then mGrid.Width = Sirina + 60
            If DinamickaVisina Then
                If rsGrid.Rows.Count < KolikoVidljivihRedova Then
                    mGrid.Height = mGrid.RowTemplate.Height * (rsGrid.Rows.Count + 1)
                Else
                    mGrid.Height = mGrid.RowTemplate.Height * (KolikoVidljivihRedova + 1)
                End If

            Else
                If KolikoVidljivihRedova > 0 Then
                    mGrid.Height = mGrid.RowTemplate.Height * (KolikoVidljivihRedova + 1)
                End If

            End If

            ObojRedove()
        End Sub

        Public Sub DodajKolonuZaGrid(Kolona As DataGridViewColumn)
            GridKolone.Add(Kolona)
        End Sub

        Public Sub DajSve()
            GridLista(rsLista)
        End Sub

        Public Function DajStatus() As String
            Return "Zaposleni"
        End Function

        Public Function DajListu() As DataTable
            Return rsLista.Copy
        End Function

        Public Sub ObojRedove()
            For n = 0 To mGrid.RowCount - 1
                If BojenjeRedova Then
                    If Boja = False Then
                        mGrid.Rows(n).DefaultCellStyle.BackColor = PrvaBoja
                        Boja = True
                    Else
                        mGrid.Rows(n).DefaultCellStyle.BackColor = DrugaBoja
                        Boja = False
                    End If
                End If

                If CrveniRed <> "" Then
                    If mGrid.Rows(n).Cells(CrveniRed).Value = VrednostCrvenogReda Then
                        mGrid.Rows(n).DefaultCellStyle.BackColor = BojaCrvenogReda
                    End If
                End If

                If HighLightRed <> "" Then
                    If mGrid.Rows(n).Cells(HighLightRed).Value.ToString = VrednostHighLightReda Then
                        mGrid.Rows(n).DefaultCellStyle.BackColor = HighLight
                    End If
                End If
            Next
        End Sub

        Public Function GetRows(Uslov As String) As DataTable
            Dim Resp As New DataTable

            Dim rows() As DataRow = rsLista.Select(Uslov)
            Resp = rows.CopyToDataTable
            Return Resp
        End Function

        'Public Function Clone() As Object Implements ICloneable.Clone
        '    Return New Lista With {.rsLista = rsLista, .Grid = Grid}
        'End Function
    End Class


#End Region

#Region "Klasa Dan"
    Public Class Dan
        Public Property IDZaposlenog As Integer
        Public Property Datum As Date
        Public Property UlasciIzlasci As New Collection(Of Enters)
        Public Property Status As Statusi
        Public Property BrojKartice As Long


        Private mUkupnoMinuta As Integer
        Public Property UkupnoMinuta() As Integer
            Get
                If UlasciIzlasci.Count > 0 Then mUkupnoMinuta = 0

                For n = 0 To UlasciIzlasci.Count - 1
                    Dim ent As Enters = UlasciIzlasci(n)
                    If ent.Kompletirano Then
                        mUkupnoMinuta += DateDiff(DateInterval.Minute, ent.Izlazak, ent.Ulazak)
                    End If
                Next

                Return mUkupnoMinuta
            End Get
            Set(value As Integer)
                mUkupnoMinuta = value
            End Set

        End Property

        Public Structure Enters
            Dim Ulazak As Date
            Dim Izlazak As Date
            Dim Kompletirano As Boolean
        End Structure

        Public Sub AddUlazIzlaz(Ulaz As Date, Izlaz As Date)
            Dim ents As Enters
            ents.Ulazak = Ulaz
            ents.Izlazak = Izlaz
            UlasciIzlasci.Add(ents)
        End Sub
    End Class
#End Region


#Region "Klasa sifarnik"

    Public Class Sifarnik
        Public Property KontrolaZaPrikaz As Control
        Public Property KolonaSifra As String = "Sifra"
        Public Property KolonaNaziv As String = "Naziv"

        Private rsSifarnik As DataTable
        Private Napunjen As Boolean = False
        Private qUpit As String
        Private Filterisan As Boolean = False
        Private Redovi() As DataRow
        Private rsListaFilter As New DataTable

        Public Sub Puni(Upit As String)
            rsSifarnik = GetData(Upit)
            qUpit = Upit
            Napunjen = True
        End Sub

        Public Sub PuniKontrolu()
            If TypeOf KontrolaZaPrikaz Is ComboBox Then
                Dim kombo As ComboBox = DirectCast(KontrolaZaPrikaz, ComboBox)

                kombo.DisplayMember = KolonaNaziv
                kombo.ValueMember = KolonaSifra
                kombo.DataSource = rsSifarnik
            End If
            If TypeOf KontrolaZaPrikaz Is ListBox Then
                Dim kombo As ListBox = DirectCast(KontrolaZaPrikaz, ListBox)
                kombo.DataSource = rsSifarnik
                kombo.DisplayMember = KolonaNaziv
                kombo.ValueMember = KolonaSifra
            End If

            If TypeOf KontrolaZaPrikaz Is DataGridView Then
                Dim grd As DataGridView = DirectCast(KontrolaZaPrikaz, DataGridView)
                grd.DataSource = rsSifarnik
            End If
        End Sub

        Public Sub Refresh()
            rsSifarnik = GetData(qUpit)
            PuniKontrolu()
        End Sub

        Public Function Trazi(Sta As String) As DataTable
            Dim rs As New DataTable
            If IsNothing(rsSifarnik) Then
                Return rs
            End If

            Dim Redovi() As DataRow = rsSifarnik.Select(Sta)
            If Redovi.Count = 0 Then
                Return rs
            Else
                Return Redovi.CopyToDataTable
            End If

        End Function

        Public Function Trazi(Sta As String, UGrid As Boolean, Optional Kolona As String = "") As DataTable
            Dim Upit As String = ""
            Dim rs As New DataTable

            If Napunjen = True And Filterisan = False Then
                Filterisan = True

                If Upit = "" Then
                    rsListaFilter = rsSifarnik
                Else
                    rsListaFilter = rsSifarnik.Select(Upit).CopyToDataTable
                End If
            End If

            If Kolona = "" Then
                For n = 0 To rsListaFilter.Columns.Count - 1
                    If IsNumeric(Sta) And Sta.StartsWith("0") = False And (rsListaFilter.Columns(n).DataType = Type.GetType("System.Int32")) Then
                        Redovi = rsListaFilter.Select(rsListaFilter.Columns(n).ColumnName & "=" & Sta)
                        If Redovi.Count > 0 Then
                            Exit For
                        End If
                    End If

                    If IsNumeric(Sta) And Sta.StartsWith("0") = False And (rsListaFilter.Columns(n).DataType = Type.GetType("System.Int64")) Then
                        Redovi = rsListaFilter.Select(rsListaFilter.Columns(n).ColumnName & "=" & Sta)
                        If Redovi.Count > 0 Then
                            Exit For
                        End If
                    End If

                    If rsListaFilter.Columns(n).DataType = Type.GetType("System.String") Then
                        Redovi = rsListaFilter.Select(rsListaFilter.Columns(n).ColumnName & " LIKE '" & Trim(Sta) & "%'")
                        If Redovi.Count = 0 Then
                            Redovi = rsListaFilter.Select(rsListaFilter.Columns(n).ColumnName & " LIKE '%" & Trim(Sta) & "%'")
                            If Redovi.Count > 0 Then Exit For
                        Else
                            Exit For
                        End If
                    End If

                    If rsListaFilter.Columns(n).DataType = Type.GetType("System.DateTime") Then
                        If IsDate(Sta) Then
                            Redovi = rsListaFilter.Select(rsListaFilter.Columns(n).ColumnName & " = #" & Format(CDate(Sta), FormatDatuma) & "#")
                            If Redovi.Count = 0 Then
                                'Redovi = rsListaFilter.Select(rsListaFilter.Columns(n).ColumnName & " LIKE '%" & Trim(Sta) & "%'")
                                If Redovi.Count > 0 Then Exit For
                            Else
                                Exit For
                            End If
                        End If

                    End If
                Next
            Else
                If IsNumeric(Sta) And Sta.StartsWith("0") = False And (rsListaFilter.Columns(Kolona).DataType = Type.GetType("System.Int32")) Then
                    Redovi = rsListaFilter.Select(Kolona & "=" & Sta)
                End If

                If rsListaFilter.Columns(Kolona).DataType = Type.GetType("System.String") Then
                    Redovi = rsListaFilter.Select(Kolona & " LIKE '" & Trim(Sta) & "%'")
                    If Redovi.Count = 0 Then
                        Redovi = rsListaFilter.Select(Kolona & " LIKE '%" & Trim(Sta) & "%'")
                    End If
                End If
            End If

            If UGrid Then
                Dim rsResp As DataTable
                If Redovi.Count = 0 Then
                    rsResp = New DataTable
                Else
                    rsResp = Redovi.CopyToDataTable
                End If
                PuniKontrolu()
            End If

            If Redovi.Count > 0 Then
                Return rs
            Else
                Return Redovi.CopyToDataTable
            End If

        End Function
    End Class
#End Region

End Module
