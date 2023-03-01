Public Class FrmSifarnikKomitenti
    Dim RetCom As ReturningComplet

#Region "FORMA"
    Private Sub FrmSifarnikKomitenata_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        SifarnikDrzava.KontrolaZaPrikaz = CmbDrzava
        SifarnikDrzava.PuniKontrolu()
        CmbDrzava.SelectedValue = 1


        If Parametri.Novi Then
            BrisiPolja()
            AutoSifra()
            CmdNovi.Enabled = False
        Else
            DajKomitenta(Parametri.Sifra)
            CmdNovi.Enabled = True
        End If

    End Sub
    Private Sub FrmSifarnikKomitenti_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Parametri.Novi = False
    End Sub
#End Region


#Region "TXT polja"
    Private Sub TxtPunNaziv_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtPunNaziv.KeyDown
        If e.KeyCode = Keys.Enter Then
            TxtNaziv.Select()
        End If
    End Sub
    Private Sub txtNaziv_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtNaziv.KeyDown

        If e.KeyCode = Keys.Enter Then
            If TxtPunNaziv.Text = "" Then
                TxtPunNaziv.Text = TxtNaziv.Text
            End If

        End If
    End Sub
    Private Sub TxtAdresa_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtAdresa.KeyDown

        If e.KeyCode = Keys.Enter Then
            If TxtDestinacija.Text = "" Then
                TxtDestinacija.Text = TxtAdresa.Text
            End If

        End If
    End Sub
    Private Sub TxtDestinacija_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtDestinacija.KeyDown

        If e.KeyCode = Keys.Enter Then
            If TxtDestinacija.Text = "" Then
                TxtDestinacija.Text = TxtAdresa.Text
            End If

        End If
    End Sub

    Private Sub TextBox_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles _
                TxtSifra.KeyDown, TxtNaziv.KeyDown, TxtAdresa.KeyDown, TxtDestinacija.KeyDown, TxtPTT.KeyDown, TxtMesto.KeyDown, TxtTelefon.KeyDown,
                TxtMobilni.KeyDown, TxtMail.KeyDown, TxtLiceZaKontakt.KeyDown, TxtPIB.KeyDown, TxtMaticniBroj.KeyDown,
                TxtRegistarskiBroj.KeyDown, TxtSifraDelatnosti.KeyDown, TxtZiroRacun1.KeyDown, TxtZiroRacun2.KeyDown,
                TxtValuta.KeyDown, TxtRabat.KeyDown, TxtKoeficijentProdajneCene.KeyDown

        Dim TekuciTag As Integer, SledeciTag As Integer
        Dim Izlaz As Boolean

        If e.KeyCode = Keys.Enter Then
            For Each thisControl As Control In Controls
                If thisControl.Focused Then
                    If IsNumeric(thisControl.Tag) Then
                        TekuciTag = CInt(thisControl.Tag)
                        SledeciTag = TekuciTag + 1
                        If SledeciTag > 22 Then
                            SledeciTag = 0
                            Snimi()
                            TxtSifra.Focus()
                            Exit For
                        End If
                        For Each ttBox As Control In Controls
                            If IsNumeric(ttBox.Tag) Then
                                If CInt(ttBox.Tag) = SledeciTag Then
                                    ttBox.Select()
                                    Izlaz = True
                                    Exit For
                                End If
                            End If
                        Next
                    End If
                End If
                If Izlaz Then Exit For
            Next thisControl

        End If


    End Sub
#End Region


#Region "FUNKCIJE"
    Sub AutoSifra()
        Dim rs As DataTable

        rs = GetData("SELECT MAX(Sifra) AS Novi FROM SifarnikKomitenti")
        If rs.Rows.Count = 0 Or IsDBNull(rs(0)!Novi) Then
            TxtSifra.Text = "1"
        Else
            TxtSifra.Text = rs.Rows(0)!Novi + 1
        End If

    End Sub
    Sub BrisiPolja()
        For Each tt In Controls
            If TypeOf tt Is TextBox Then
                tt.Text = ""
            End If
        Next

        ChkPravnoLice.Checked = True
        ChkKupac.Checked = False
        ChkDobavljac.Checked = False
        ChkPasivan.Checked = False
        ChkPasivan.ForeColor = Color.Black

        CmbDrzava.SelectedValue = 1
        cmbReferent.SelectedValue = 2
        CmbPodreferent.SelectedValue = 2

        TxtPunNaziv.Select()

    End Sub
    Sub DajKomitenta(Komitent As Long)
        Dim rs As DataTable

        rs = GetData("SELECT * FROM SifarnikKomitenti WHERE Sifra=" & Komitent)

        If rs.Rows.Count = 0 Then Exit Sub

        TxtSifra.Text = rs(0)!Sifra.ToString
        TxtPunNaziv.Text = rs(0)!PunNaziv.ToString
        TxtNaziv.Text = rs(0)!Naziv
        TxtAdresa.Text = rs(0)!Adresa.ToString
        TxtDestinacija.Text = rs(0)!Destinacija.ToString
        TxtPTT.Text = rs(0)!PTT.ToString
        TxtMesto.Text = rs(0)!Mesto.ToString
        CmbDrzava.SelectedValue = rs(0)!Drzava
        TxtTelefon.Text = rs(0)!Telefon.ToString
        TxtMobilni.Text = rs(0)!Mobilni.ToString
        TxtMail.Text = rs(0)!Mail.ToString
        TxtLiceZaKontakt.Text = rs(0)!LiceZaKontakt.ToString
        TxtPIB.Text = rs(0)!PIB.ToString
        TxtMaticniBroj.Text = rs(0)!MaticniBroj.ToString
        TxtRegistarskiBroj.Text = rs(0)!RegistarskiBroj.ToString
        TxtSifraDelatnosti.Text = rs(0)!SifraDelatnosti.ToString
        TxtZiroRacun1.Text = rs(0)!ZiroRacun1.ToString
        TxtZiroRacun2.Text = rs(0)!ZiroRacun2.ToString
        TxtValuta.Text = rs(0)!Valuta.ToString
        TxtRabat.Text = rs(0)!Rabat.ToString
        TxtKoeficijentProdajneCene.Text = rs(0)!KoeficijentProdajneCene.ToString
        TxtNapomena.Text = rs(0)!Napomena.ToString
        cmbReferent.SelectedValue = rs(0)!Referent
        CmbPodreferent.SelectedValue = rs(0)!Podreferent
        ChkPravnoLice.Checked = rs(0)!PravnoLice
        ChkKupac.Checked = rs(0)!Kupac
        ChkDobavljac.Checked = rs(0)!Dobavljac
        ChkPasivan.Checked = rs(0)!Pasivan

        If ChkPasivan.Checked = True Then
            MsgBox("Komitent ima status NEAKTIVAN/PASIVAN!", MsgBoxStyle.Information)
            ChkPasivan.ForeColor = Color.FromArgb(220, 150, 90)
            Exit Sub
        Else
            ChkPasivan.ForeColor = Color.Black
        End If

    End Sub
    Sub Snimi()
        Dim rs As DataTable
        Dim rsPIB As DataTable

        If Parametri.PravoPristupa >= 2 Then

            ProveraObaveznihPolja()
            If RetCom.Poruka = "Greška" Then Exit Sub

            rs = GetData("SELECT * FROM SifarnikKomitenti WHERE Sifra=" & CLng(TxtSifra.Text))
            If rs.Rows.Count > 0 And Parametri.Novi Then
                MsgBox("Komitent sa ovom šifrom već postoji! Unesite neku drugu šifru.", MsgBoxStyle.Exclamation)
                TxtSifra.Select()
                Exit Sub
            End If
            rs.Dispose()

            rs = GetData("SELECT * FROM SifarnikKomitenti WHERE Naziv='" & TxtNaziv.Text & "'")
            If rs.Rows.Count > 0 And Parametri.Novi Then
                MsgBox("Komitent sa ovim nazivom već postoji!.", MsgBoxStyle.Exclamation)
                TxtNaziv.Select()
                Exit Sub
            End If

            If TxtPIB.Text <> "" Then
                rsPIB = GetData("SELECT * FROM SifarnikKomitenti WHERE PIB='" & TxtPIB.Text & "' AND Drzava='1' AND Pasivan='False'")
                If rsPIB.Rows.Count > 0 And Parametri.Novi Then
                    MsgBox("Aktivan komitent sa ovim PIB-om već postoji!.", MsgBoxStyle.Exclamation)
                    TxtPIB.Select()
                    Exit Sub
                End If
            Else
                If CmbDrzava.SelectedValue = 1 Then
                    MsgBox("PIB - obavezan unos!.", MsgBoxStyle.Exclamation)
                    TxtPIB.Select()
                    Exit Sub
                End If
            End If


            If ChkKupac.Checked = False And ChkDobavljac.Checked = False Then
                MsgBox("Komitent mora biti definisan kao kupac, dobavljač ili oba!", MsgBoxStyle.Exclamation)
                Exit Sub
            End If

            If IsNumeric(TxtValuta.Text) = False Then TxtValuta.Text = 0
            If IsNumeric(TxtRabat.Text) = False Then TxtRabat.Text = 0
            If IsNumeric(TxtKoeficijentProdajneCene.Text) = False Then TxtKoeficijentProdajneCene.Text = 1
            If TxtKoeficijentProdajneCene.Text = 0 Then TxtKoeficijentProdajneCene.Text = 1

            If Parametri.Novi Then
                InsertData("INSERT INTO SifarnikKomitenti VALUES(" & CInt(TxtSifra.Text) & ",'" & TxtPunNaziv.Text & "','" & TxtNaziv.Text & "','" & TxtAdresa.Text & "','" _
                       & TxtDestinacija.Text & "','" & TxtPTT.Text & "','" & TxtMesto.Text & "'," & CmbDrzava.SelectedValue & ",'" & TxtTelefon.Text & "','" & TxtMobilni.Text _
                       & "','" & TxtMail.Text & "','" & TxtLiceZaKontakt.Text & "','" & TxtPIB.Text _
                       & "','" & TxtMaticniBroj.Text & "','" & TxtRegistarskiBroj.Text & "','" & TxtSifraDelatnosti.Text & "','" & TxtZiroRacun1.Text & "','" & TxtZiroRacun2.Text _
                       & "'," & CInt(TxtValuta.Text) & "," & FormatNumber(cdbl(TxtRabat.Text), 2,,, TriState.False) & "," & FormatNumber(cdbl(TxtKoeficijentProdajneCene.Text), 2,,, False) _
                       & "," & cmbReferent.SelectedValue & "," & CmbPodreferent.SelectedValue & ",'" & TxtNapomena.Text _
                       & "','" & ChkPravnoLice.Checked & "','" & ChkKupac.Checked & "','" & ChkDobavljac.Checked & "','" & ChkPasivan.Checked & "')")

                InsertData("INSERT INTO Log VALUES('" & Operater & "','" & NazivPrograma & "','" & DajRacunar() & "','" & Format(Date.Now, FormatDatuma) & "','" & TimeOfDay _
                           & "','Novi komitent','" & DocStatus & "'," & TxtSifra.Text & ",'" & TxtNaziv.Text & "')")

            Else
                InsertData("UPDATE SifarnikKomitenti SET PunNaziv='" & TxtPunNaziv.Text & "' WHERE Sifra=" & CInt(TxtSifra.Text))
                InsertData("UPDATE SifarnikKomitenti SET Naziv='" & TxtNaziv.Text & "' WHERE Sifra=" & CInt(TxtSifra.Text))
                InsertData("UPDATE SifarnikKomitenti SET Adresa='" & TxtAdresa.Text & "' WHERE Sifra=" & CInt(TxtSifra.Text))
                InsertData("UPDATE SifarnikKomitenti SET Destinacija='" & TxtDestinacija.Text & "' WHERE Sifra=" & CInt(TxtSifra.Text))
                InsertData("UPDATE SifarnikKomitenti SET PTT='" & TxtPTT.Text & "' WHERE Sifra=" & CInt(TxtSifra.Text))
                InsertData("UPDATE SifarnikKomitenti SET Mesto='" & TxtMesto.Text & "' WHERE Sifra=" & CInt(TxtSifra.Text))
                InsertData("UPDATE SifarnikKomitenti SET Drzava=" & CmbDrzava.SelectedValue & " WHERE Sifra=" & CInt(TxtSifra.Text))
                InsertData("UPDATE SifarnikKomitenti SET Telefon='" & TxtTelefon.Text & "' WHERE Sifra=" & CInt(TxtSifra.Text))
                InsertData("UPDATE SifarnikKomitenti SET Mobilni='" & TxtMobilni.Text & "' WHERE Sifra=" & CInt(TxtSifra.Text))
                InsertData("UPDATE SifarnikKomitenti SET Mail='" & TxtMail.Text & "' WHERE Sifra=" & CInt(TxtSifra.Text))
                InsertData("UPDATE SifarnikKomitenti SET LiceZaKontakt='" & TxtLiceZaKontakt.Text & "' WHERE Sifra=" & CInt(TxtSifra.Text))
                InsertData("UPDATE SifarnikKomitenti SET PIB='" & TxtPIB.Text & "' WHERE Sifra=" & CInt(TxtSifra.Text))
                InsertData("UPDATE SifarnikKomitenti SET MaticniBroj='" & TxtMaticniBroj.Text & "' WHERE Sifra=" & CInt(TxtSifra.Text))
                InsertData("UPDATE SifarnikKomitenti SET RegistarskiBroj='" & TxtRegistarskiBroj.Text & "' WHERE Sifra=" & CInt(TxtSifra.Text))
                InsertData("UPDATE SifarnikKomitenti SET SifraDelatnosti='" & TxtSifraDelatnosti.Text & "' WHERE Sifra=" & CInt(TxtSifra.Text))
                InsertData("UPDATE SifarnikKomitenti SET ZiroRacun1='" & TxtZiroRacun1.Text & "' WHERE Sifra=" & CInt(TxtSifra.Text))
                InsertData("UPDATE SifarnikKomitenti SET ZiroRacun2='" & TxtZiroRacun2.Text & "' WHERE Sifra=" & CInt(TxtSifra.Text))
                InsertData("UPDATE SifarnikKomitenti SET Valuta=" & CInt(TxtValuta.Text) & " WHERE Sifra=" & CInt(TxtSifra.Text))
                InsertData("UPDATE SifarnikKomitenti SET Rabat=" & FormatNumber(cdbl(TxtRabat.Text), 2,,, TriState.False) & " WHERE Sifra=" & CInt(TxtSifra.Text))
                InsertData("UPDATE SifarnikKomitenti SET KoeficijentProdajneCene=" & FormatNumber(cdbl(TxtKoeficijentProdajneCene.Text), 2,,, TriState.False) & " WHERE Sifra=" & CInt(TxtSifra.Text))
                InsertData("UPDATE SifarnikKomitenti SET Referent='" & cmbReferent.SelectedValue & "' WHERE Sifra=" & CInt(TxtSifra.Text))
                InsertData("UPDATE SifarnikKomitenti SET Podreferent='" & CmbPodreferent.SelectedValue & "' WHERE Sifra=" & CInt(TxtSifra.Text))
                InsertData("UPDATE SifarnikKomitenti SET Napomena='" & TxtNapomena.Text & "' WHERE Sifra=" & CInt(TxtSifra.Text))
                InsertData("UPDATE SifarnikKomitenti SET PravnoLice='" & ChkPravnoLice.Checked & "' WHERE Sifra=" & CInt(TxtSifra.Text))
                InsertData("UPDATE SifarnikKomitenti SET Kupac='" & ChkKupac.Checked & "' WHERE Sifra=" & CInt(TxtSifra.Text))
                InsertData("UPDATE SifarnikKomitenti SET Dobavljac='" & ChkDobavljac.Checked & "' WHERE Sifra=" & CInt(TxtSifra.Text))
                InsertData("UPDATE SifarnikKomitenti SET Pasivan='" & ChkPasivan.Checked & "' WHERE Sifra=" & CInt(TxtSifra.Text))

                InsertData("INSERT INTO Log VALUES('" & Operater & "','" & NazivPrograma & "','" & DajRacunar() & "','" & Format(Date.Now, FormatDatuma) & "','" & TimeOfDay _
                           & "','Korekcija komitenta','" & DocStatus & "'," & TxtSifra.Text & ",'" & TxtNaziv.Text & "')")
            End If


            'PnlOK.Visible = True
            CmdSnimi.Enabled = False
            CmdNovi.Enabled = False

            tmrDelay.Enabled = True
            Parametri.Novi = False

            If ChkPasivan.Checked = True Then
                ChkPasivan.ForeColor = Color.FromArgb(220, 150, 90)
                Exit Sub
            Else
                ChkPasivan.ForeColor = Color.Black
            End If
            Else
                MsgBox("Korisnik nema pravo snimanja i korekcije!", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

    End Sub
    Sub ProveraObaveznihPolja()
        RetCom.Poruka = "OK"

        If IsNumeric(TxtSifra.Text) = False Then
            RetCom.Poruka = "Greška"
            erpIndikatorGreske.SetError(TxtSifra, "Greška pri unosu šifre")
        End If

        If TxtNaziv.Text = "" Then
            RetCom.Poruka = "Greška"
            erpIndikatorGreske.SetError(TxtNaziv, "Obavezan unos")
        End If

        If TxtMesto.Text = "" Then
            RetCom.Poruka = "Greška"
            erpIndikatorGreske.SetError(TxtMesto, "Obavezan unos")
        End If

        If TxtPunNaziv.Text = "" Then
            TxtPunNaziv.Text = TxtNaziv.Text
        End If

        If CmbDrzava.SelectedIndex = -1 Or IsNumeric(CmbDrzava.SelectedValue) = False Or CmbDrzava.Text = "" Then
            RetCom.Poruka = "Greška"
            erpIndikatorGreske.SetError(CmbDrzava, "Izaberite državu")
        End If

        If cmbReferent.SelectedIndex = -1 Or cmbReferent.Text = "" Then
            RetCom.Poruka = "Greška"
            erpIndikatorGreske.SetError(cmbReferent, "Izaberite referenta")
        End If

        If CmbPodreferent.SelectedIndex = -1 Or CmbPodreferent.Text = "" Then
            RetCom.Poruka = "Greška"
            erpIndikatorGreske.SetError(CmbPodreferent, "Izaberite podreferenta")
        End If

        If IsNumeric(TxtRabat.Text) = False Then
            TxtRabat.Text = "0"
        End If
        If IsNumeric(TxtValuta.Text) = False Then
            TxtValuta.Text = "0"
        End If


        TmrIndikatorGreske.Enabled = True

    End Sub

    Private Sub tmrDelay_Tick(ByVal sender As Object, ByVal e As EventArgs) Handles tmrDelay.Tick
        'PnlOK.Visible = False
        CmdSnimi.Enabled = True
        CmdNovi.Enabled = True

        tmrDelay.Enabled = False

    End Sub
    Private Sub TmrIndikatorGreske_Tick(sender As Object, e As EventArgs) Handles TmrIndikatorGreske.Tick

        erpIndikatorGreske.SetError(TxtSifra, "")
        erpIndikatorGreske.SetError(TxtNaziv, "")
        erpIndikatorGreske.SetError(TxtMesto, "")

        erpIndikatorGreske.SetError(CmbDrzava, "")
        erpIndikatorGreske.SetError(cmbReferent, "")
        erpIndikatorGreske.SetError(CmbPodreferent, "")

        TmrIndikatorGreske.Enabled = False

    End Sub
#End Region


#Region "TASTERI"
    Private Sub CmdNovaDrzava_Click(sender As Object, e As EventArgs)

        Parametri.NovaDrzava = True

        FrmSifarnikDrzava.Dispose()
        FrmSifarnikDrzava.ShowDialog()

        SifarnikDrzava.Refresh()
        SifarnikDrzava.PuniKontrolu()
        CmbDrzava.DroppedDown = True

    End Sub
    Private Sub cmdNovi_Click(sender As Object, e As EventArgs)

        BrisiPolja()
        AutoSifra()

        Parametri.Novi = True
        CmdNovi.Enabled = False
        TxtPunNaziv.Select()

    End Sub
    Private Sub cmdSnimi_Click(sender As Object, e As EventArgs)
        Snimi()
    End Sub
    Private Sub cmdIzlaz_Click(sender As Object, e As EventArgs)
        Close()
    End Sub
#End Region



End Class