Public Class UserForm

    Dim FullURL As String = ""

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        CompName.Text = My.Settings.CompName

        UpdateFullURL()

        CentraliseFormOnScreen(Me)

    End Sub


    Private Sub txtPilotNumber_TextChanged(sender As Object, e As EventArgs) Handles txtPilotNumber.TextChanged

        If txtPilotNumberValidate() Then

            UpdateFullURL()

        End If

    End Sub

    Private Sub txtPilotNumber_Leave(sender As Object, e As EventArgs) Handles txtPilotNumber.Leave
        txtPilotNumberValidate()
    End Sub

    Private Function txtPilotNumberValidate() As Boolean
        If IsNumeric(txtPilotNumber.Text) Or txtPilotNumber.Text = "" Then
            txtPilotNumber.BackColor = Color.White
            Return True
        Else
            txtPilotNumber.BackColor = Color.Pink
            MessageBox.Show("Pilot number must be numeric. Please fix.", "Error")
            txtPilotNumber.Focus()
            Return False
        End If
    End Function




    Private Sub UpdateFullURL()

        FullURL = "http://gliderscore.com/eScoring.aspx" & "?ID=" & My.Settings.CompID & "&P=" & txtPilotNumber.Text

    End Sub



    Private Sub btnConnect_Click(sender As Object, e As EventArgs) Handles btnConnect.Click

        If CheckForNetwork(0) = False Then
            MsgBox("Internet connection is not available. Please check and try again.")
            Exit Sub
        End If

        If txtPilotNumber.Text = "" Then
            MessageBox.Show("Please enter a pilot number and try again.", "Error")
            txtPilotNumber.Focus()
            Exit Sub
        End If
        WebBrowser1.Navigate(New Uri(FullURL))

        txtPilotNumber.Text = ""

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

        WebBrowser1.Url = Nothing

    End Sub
End Class
