Imports System.Net
Imports System.Globalization

Public Class MainMenu

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtCompName.TextChanged
        My.Settings.CompName = txtCompName.Text
        My.Settings.Save()
    End Sub

    Private Sub txtCompID_TextChanged(sender As Object, e As EventArgs) Handles txtCompID.TextChanged
        My.Settings.CompID = txtCompID.Text
        My.Settings.Save()
    End Sub

    Private Sub btnInfoCompID_Click(sender As Object, e As EventArgs) Handles btnInfoCompID.Click
        Dim txt As String = ""
        txt = txt & "Enter the competition ID in this field." & vbCrLf
        txt = txt & "Note that CompID is case sensitive." & vbCrLf & vbCrLf
        txt = txt & "You can find the CompID by printing or previewing the Score Records." & vbCrLf
        txt = txt & "It is the text following ID= through to the text &PN=" & vbCrLf & vbCrLf
        txt = txt & "You can also find the CompID by going to" & vbCrLf
        txt = txt & "Reports -> Pilot Reports -> Pilot Master File." & vbCrLf
        txt = txt & "Select 'QR Code String'and preview the report." & vbCrLf & vbCrLf
        txt = txt & "You can Disable this field to prevent any accidental changes."
        MessageBox.Show(txt, "About CompID")
    End Sub

    Private Sub btnUserForm_Click(sender As Object, e As EventArgs) Handles btnUserForm.Click
        Cursor = Cursors.WaitCursor
        If CheckForNetwork(0) = False Then
            MsgBox("Internet connection is not available. Please check and try again.")
            Cursor = Cursors.Default
            Exit Sub
        End If

        If txtCompID.Text = "" Then
            MsgBox("Please enter the CompID.")
            Cursor = Cursors.Default
            Exit Sub
        End If

        Dim _WebRequest As WebRequest = Nothing
        Dim _WebResponse As WebResponse
        Dim ResponseFromServer As String
        Dim QueryString As String = ""
        Dim msg As String = ""
        Dim previousBackupExists As Boolean = False

        QueryString = "ACTION=ValidateCompID" & "&ID=" & txtCompID.Text & "&RD=-1" & "&GR=-1" & "&TK=-1" & "&DT=" & Now()
        _WebRequest = WebRequest.Create("http://www.gliderscore.com/scoringdatamanage.aspx?" & QueryString)
        _WebResponse = _WebRequest.GetResponse
        ResponseFromServer = ExtractWebResponse(_WebResponse)
        _WebResponse.Close()
        Cursor = Cursors.Default
        Select Case ResponseFromServer
            Case "InvalidCompID"
                msg = "This CompID does not exist on the server." & vbCrLf & "CompID is case sensitive. Please check."
                Cursor = Cursors.Default
                MsgBox(msg) : Exit Sub
            Case "ValidCompID"
                ' this is OK, just proceed
        End Select
        Cursor = Cursors.Default
        Me.Hide()

        Dim frm As New UserForm
        frm.ShowDialog()

        Me.Close()
    End Sub

    Private Sub MainMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' get screen dimensions to centralize windows
        varScreenWidth = Screen.PrimaryScreen.WorkingArea.Width
        varScreenHeight = Screen.PrimaryScreen.WorkingArea.Height
        CentraliseFormOnScreen(Me)
        txtCompName.Text = My.Settings.CompName
        txtCompID.Text = My.Settings.CompID
    End Sub
End Class