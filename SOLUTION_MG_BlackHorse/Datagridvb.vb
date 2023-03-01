
Imports System.ComponentModel
Imports System.Windows.Forms

Class myDataGridView

    Inherits DataGridView
    Private m_PrvaKolona As Int16
    Private m_PoslednjaKolona As Int16
    Private m_VertSBVidljiv As Boolean = False
    Private CAPTIONHEIGHT As Integer = 21
    Private BORDERWIDTH As Integer = 2

    Public Sub New()
        VerticalScrollBar.Visible = m_VertSBVidljiv
        AddHandler VerticalScrollBar.VisibleChanged, AddressOf ShowScrollBars
    End Sub

    Private Sub ShowScrollBars(sender As Object, e As EventArgs)
        If m_VertSBVidljiv Then
            Dim width As Integer = VerticalScrollBar.Width
            VerticalScrollBar.Location = New Point(ClientRectangle.Width - width - BORDERWIDTH, CAPTIONHEIGHT)
            VerticalScrollBar.Size = New Size(width, ClientRectangle.Height - CAPTIONHEIGHT - BORDERWIDTH)
            VerticalScrollBar.Show()
        End If
    End Sub

    Protected Overloads Overrides Function ProcessDialogKey(ByVal keyData As Keys) As Boolean

        If keyData = Keys.Enter Then

            Dim col As Integer = CurrentCell.ColumnIndex

            Dim row As Integer = CurrentCell.RowIndex

            If Not (row = NewRowIndex) Then

                If col = m_PoslednjaKolona Then

                    'col = -1
                    col = m_PrvaKolona - 1

                    row += 1
                    If row < Rows.Count Then
                        CurrentCell = Me(col + 1, row)
                    Else
                        CurrentCell = Me(col + 1, 0)
                    End If
                Else
                    For n = col To Columns.Count - 1
                        If n = Columns.Count - 1 Then Exit For
                        If Columns(n + 1).Visible And col >= m_PrvaKolona Then
                            CurrentCell = Me(n + 1, row)
                            Exit For
                        End If
                    Next
                End If

                'Me.CurrentCell = Me(col + 1, row)


            End If

            Return True

        End If

        Return MyBase.ProcessDialogKey(keyData)

    End Function

    Protected Overloads Overrides Sub OnKeyDown(ByVal e As KeyEventArgs)

        If e.KeyData = Keys.Enter Then

            Dim col As Integer = CurrentCell.ColumnIndex

            Dim row As Integer = CurrentCell.RowIndex

            If Not (row = NewRowIndex) Then

                If col = m_PoslednjaKolona Then

                    col = m_PrvaKolona - 1

                    row += 1
                    If row < Rows.Count Then
                        CurrentCell = Me(col + 1, row)
                    Else
                        CurrentCell = Me(col + 1, 0)
                    End If

                Else
                    For n = col To Columns.Count - 1
                        If n = Columns.Count - 1 Then Exit For
                        If Columns(n + 1).Visible And col >= m_PrvaKolona Then
                            CurrentCell = Me(n + 1, row)
                            Exit For
                        End If
                    Next
                End If


                'If Me.CurrentCell.Visible = False Then
                '    Me.CurrentCell = Me(col + 2, row)
                'Else
                '    Me.CurrentCell = Me(col + 1, row)
                'End If

            End If

            e.Handled = True

        End If

        MyBase.OnKeyDown(e)

    End Sub

    Public Property PrvaKolona() As Int16
        Get
            Return m_PrvaKolona
        End Get
        Set(ByVal value As Int16)
            m_PrvaKolona = value
        End Set
    End Property

    Public Property PoslednjaKolona() As Int16
        Get
            Return m_PoslednjaKolona
        End Get
        Set(ByVal value As Int16)
            m_PoslednjaKolona = value
        End Set
    End Property

    Public Property VertikalniSBUvekVidljiv() As Boolean
        Get
            Return m_VertSBVidljiv
        End Get
        Set(ByVal value As Boolean)
            m_VertSBVidljiv = value
            VerticalScrollBar.Visible = value
        End Set
    End Property

    Public Sub SortiranjeAZ(NazivKolone As String)

        For Each kolona As DataGridViewColumn In Me.Columns
            If NazivKolone = kolona.Name Then
                Sort(kolona, ListSortDirection.Ascending)
            End If
        Next
    End Sub

    Public Sub SortiranjeZA(NazivKolone As String)

        For Each kolona As DataGridViewColumn In Me.Columns
            If NazivKolone = kolona.Name Then
                Sort(kolona, ListSortDirection.Descending)
            End If
        Next
    End Sub

End Class

