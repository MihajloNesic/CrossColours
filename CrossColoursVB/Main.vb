Public Class Main

    Private CCGreen As Color = Color.FromArgb(255, 51, 255, 0)

    Private ButtonMatrix(,) As Button

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CreateGame(6, 6)
    End Sub

    Private Sub btn_reset_Click(sender As Object, e As EventArgs) Handles btn_reset.Click
        For i As Integer = 0 To tlp_game.RowCount - 1
            For j As Integer = 0 To tlp_game.ColumnCount - 1
                ButtonMatrix(i, j).BackColor = Color.Red
            Next
        Next
    End Sub

    Private Sub btn_generate_Click(sender As Object, e As EventArgs) Handles btn_generate.Click
        Dim r As Integer = Convert.ToInt32(nud_rows.Value)
        Dim c As Integer = Convert.ToInt32(nud_cols.Value)
        CreateGame(r, c)
    End Sub

    Private Sub pcb_logo_Click(sender As Object, e As EventArgs) Handles pcb_logo.Click
        System.Diagnostics.Process.Start("https://www.brainbashers.com/crosscolours.asp")
        System.Diagnostics.Process.Start("https://mihajlonesic.gitlab.io/")
    End Sub

    Private Sub CreateGame(ByVal row As Integer, ByVal col As Integer)
        tlp_game.Controls.Clear()

        tlp_game.RowStyles.Clear()
        tlp_game.ColumnStyles.Clear()

        tlp_game.RowCount = row
        tlp_game.ColumnCount = col

        ButtonMatrix = New Button(row - 1, col - 1) {}

        For i As Integer = 0 To row - 1
            For j As Integer = 0 To col - 1
                ButtonMatrix(i, j) = New Button()
                ButtonMatrix(i, j).BackColor = Color.Red
                ButtonMatrix(i, j).Padding = New Padding(0)
                ButtonMatrix(i, j).Margin = New Padding(0)
                ButtonMatrix(i, j).Anchor = (AnchorStyles.Bottom Or AnchorStyles.Top Or AnchorStyles.Right Or AnchorStyles.Left)
                AddHandler ButtonMatrix(i, j).Click, AddressOf CCButtonClickHandler
                tlp_game.Controls.Add(ButtonMatrix(i, j), j, i)
            Next
        Next

        For i As Integer = 1 To tlp_game.RowCount
            tlp_game.RowStyles.Add(New RowStyle(SizeType.Percent, 1))
        Next

        For i As Integer = 1 To tlp_game.ColumnCount
            tlp_game.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 1))
        Next
    End Sub

    Private Sub CCButtonClickHandler(ByVal sender As Object, ByVal e As EventArgs)
        Dim b As Button = CType(sender, Button)

        If b IsNot Nothing Then
            ToggleColor(b)

            Dim pos As TableLayoutPanelCellPosition = tlp_game.GetCellPosition(b)

            If pos.Row < (tlp_game.RowCount) Then
                Dim neig1 As Button = CType(tlp_game.GetControlFromPosition(pos.Column, pos.Row + 1), Button)
                If neig1 IsNot Nothing Then ToggleColor(neig1)

                If pos.Row > 0 Then
                    Dim neig2 As Button = CType(tlp_game.GetControlFromPosition(pos.Column, pos.Row - 1), Button)
                    If neig2 IsNot Nothing Then ToggleColor(neig2)
                End If
            End If

            If pos.Column < (tlp_game.ColumnCount) Then
                Dim neig3 As Button = CType(tlp_game.GetControlFromPosition(pos.Column + 1, pos.Row), Button)
                If neig3 IsNot Nothing Then ToggleColor(neig3)

                If pos.Column > 0 Then
                    Dim neig4 As Button = CType(tlp_game.GetControlFromPosition(pos.Column - 1, pos.Row), Button)
                    If neig4 IsNot Nothing Then ToggleColor(neig4)
                End If
            End If
        End If

        If Win() Then MessageBox.Show("You are victorious!", "Win", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub ToggleColor(ByVal b As Button)
        If b.BackColor = Color.Red Then
            b.BackColor = CCGreen
        Else
            b.BackColor = Color.Red
        End If
    End Sub

    Private Function Win() As Boolean
        For i As Integer = 0 To tlp_game.RowCount - 1
            For j As Integer = 0 To tlp_game.ColumnCount - 1
                If ButtonMatrix(i, j).BackColor <> CCGreen Then Return False
            Next
        Next
        Return True
    End Function
End Class
