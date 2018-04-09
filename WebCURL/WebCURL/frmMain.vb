Imports System.String 
Imports Microsoft.VisualBasic

Public Class WebCURL
    Private _webClient As System.Net.WebClient
    Private strIpAddress As String = "192.168.0.1"

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        sLabel.Text = "Waiting to enable."
        _webClient = new System.Net.WebClient
        txtIP.text = strIpAddress
    End Sub

    Public Function GetCurlData() as string             
        Try
            Return  _webClient.DownloadString("http://" & strIpAddress)
        Catch ex as System.Net.WebException
            Return  "... Error:" & ex.InnerException.ToString
        End try

    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Timer1.Enabled = not Timer1.Enabled
        sLabel.Text = IIf(Timer1.Enabled, "Enabled","Disabled")
        sLabel2.Text = "Started"
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim strData = GetCurlData
        txtCurl.Text = txtCurl.Text & getTimestamp & vbTab & strData & Environment.NewLine
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Application.Exit
    End Sub

    Private function getTimestamp()  As String 
        Dim myTime As DateTime = DateTime.Now
        Dim strTimeStamp = Microsoft.VisualBasic.Right ("00" & myTime.Hour, 2 ) & ":" & _
            Microsoft.VisualBasic.Right ("00" & myTime.Minute, 2) & ":" & _
            Microsoft.VisualBasic.Right ("00" & myTime.Second, 2) & "." & _
            Microsoft.VisualBasic.Right( "000" & myTime.Millisecond,3) 

        Return strTimeStamp
    End function


     Private Sub txtIP_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtIP.KeyPress
        If Char.IsDigit(e.KeyChar) Or e.KeyChar = "." Or Asc(e.KeyChar) = Keys.Delete Or _
           Asc(e.KeyChar) = Keys.Right Or Asc(e.KeyChar) = Keys.Left Or Asc(e.KeyChar) = Keys.Delete Or Asc(e.KeyChar) = Keys.Back Then
            Return
        End If
        e.Handled = True
    End Sub

    Private Sub txtIP_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtIP.LostFocus
        Dim IP() As String = txtIP.Text.Split(".")
        Dim Test As Integer
        If IP.Length = 4 Then 'If 3 "."
            Dim Proper As Boolean = True
            For I As Integer = 0 To 3
                Test = Integer.Parse(IP(I)) 'Parse the string for an integer, if its not return -1
                If Test < 0 Or Test > 255 Then 'If not between 0-255 then the ip is not a proper format
                    MsgBox("IP Address is not in a proper format! All numbers entered must be between 0 - 255")
                    txtIP.Focus()
                    txtIP.SelectionStart = txtIP.Text.Length
                    Return
                End If
            Next
        Else
            MsgBox("IP Address is not in a proper format! There must be 4 numbers entered, in XXX.XXX.XXX.XXX format")
            txtIP.Focus()
            txtIP.SelectionStart = txtIP.Text.Length
        End If
    End Sub

    Private Sub btnIPEnter_Click(sender As Object, e As EventArgs) Handles btnIPEnter.Click
        strIpAddress = txtIP.Text
    End Sub
End Class
