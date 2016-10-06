Public Class Form1

    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyCode
            Case Keys.Up
                Timer1.Enabled = True
                C1.Top -= 7
                C2.Top -= 7
                C3.Top -= 7
                C4.Top -= 7
                C5.Top -= 7
                C6.Top -= 7
                C7.Top -= 7

            Case Keys.Down
                Timer1.Enabled = True
                C1.Top += 7
                C2.Top += 7
                C3.Top += 7
                C4.Top += 7
                C5.Top += 7
                C6.Top += 7
                C7.Top += 7

            Case Keys.Left
                Timer1.Enabled = True
                C1.Left -= 7
                C2.Left -= 7
                C3.Left -= 7
                C4.Left -= 7
                C5.Left -= 7
                C6.Left -= 7
                C7.Left -= 7

            Case Keys.Right
                Timer1.Enabled = True
                C1.Left += 7
                C2.Left += 7
                C3.Left += 7
                C4.Left += 7
                C5.Left += 7
                C6.Left += 7
                C7.Left += 7
        End Select
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        If C1.Visible = True Then
            C1.Visible = False
            C2.Visible = True
            C4.Visible = False
            C6.Visible = False
            C7.Visible = False
            C5.Visible = False
            C3.Visible = False

        ElseIf C2.Visible = True Then
            C2.Visible = False
            C3.Visible = True
            C4.Visible = False
            C5.Visible = False
            C6.Visible = False
            C7.Visible = False
        ElseIf C3.Visible = True Then
            C1.Visible = False
            C2.Visible = False
            C3.Visible = False
            C4.Visible = True
            C5.Visible = False
            C6.Visible = False
            C7.Visible = False
        ElseIf C4.Visible = True Then
            C1.Visible = False
            C2.Visible = False
            C3.Visible = False
            C4.Visible = False
            C5.Visible = True
            C6.Visible = False
            C7.Visible = False
        ElseIf C5.Visible = True Then
            C1.Visible = False
            C2.Visible = False
            C3.Visible = False
            C4.Visible = False
            C5.Visible = False
            C6.Visible = True
            C7.Visible = False
        ElseIf C6.Visible = True Then
            C6.Visible = False
            C7.Visible = True
            C1.Visible = False
            C2.Visible = False
            C3.Visible = False
            C4.Visible = False
            C5.Visible = False

        End If

    End Sub

    Private Sub C6_Click(sender As Object, e As EventArgs) Handles C6.Click

    End Sub
End Class
