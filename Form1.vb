Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.Text = "My first App in 2023"
        Me.BackColor = Color.Red
        Me.MaximizeBox = True
        Me.MinimizeBox = False
        Me.Size = New Size(800, 800)
        Me.Opacity = 0.901    ' makes it a bit transparent
        Me.CenterToParent()   'centers the execution box

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Close()


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnEvansFundra.Click



        MsgBox("this is Evans",, "Greeting") 'this is to make the lil box have a Hi instead of default words



    End Sub
End Class
