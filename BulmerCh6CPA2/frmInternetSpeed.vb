' Program Name:     Internet Speed Test Survey
' Author:           Mark Bulmer
' Date:             3/27/2022
' Purpose:          The Internet Speed Test Survey program enters the Internet Speed
'                   from 10 user values. It displays each
'                   Internet Speed value. After all internet speed values have been entered, 
'                   it displays the average internet speed.

Option Strict On
Public Class frmInternetSpeed
    Private Sub btnInternetSpeed_Click(sender As Object, e As EventArgs) Handles btnInternetSpeed.Click
        ' The btnInternetSpeed_click event accepts and displays up to 12 Internet Speed values
        ' and then calculates and displays the average Internet Speed

        ' Declare and initialize variables
        Dim strInternetSpeed As String
        Dim decInternetSpeed As Decimal
        Dim decAverageInternetSpeed As Decimal
        Dim decTotalInternetSpeed As Decimal = 0D
        Dim strInputMessage As String = "Enter the Internet Speed for user #"
        Dim strInputHeading As String = "Internet Speed"
        Dim strNormalMessage As String = "Enter the Internet Speed for user #"
        Dim strNonNumericError As String = "Error - Enter a number for the Internet Speed of user #"
        Dim strNegativeError As String = "Error - Enter a positive number for the Internet Speed of user #"

        ' Declare and initialize loop variables
        Dim strCancelClicked As String = ""
        Dim intMaxNumberOfEntries As Integer = 10
        Dim intNumberOfEntries As Integer = 1

        ' This loop allows the user to enter the Internet Speed of up to 10 users.
        ' The loop terminates when the user has entered 10 Internet Speed values or the user
        ' clicks the Cancel button or the Close button in the InputBox
        strInternetSpeed = InputBox(strInputMessage & intNumberOfEntries, strInputHeading, " ")

        Do Until intNumberOfEntries > intMaxNumberOfEntries Or strInternetSpeed = strCancelClicked
            If IsNumeric(strInternetSpeed) Then
                decInternetSpeed = Convert.ToDecimal(strInternetSpeed)
                If decInternetSpeed > 0 Then
                    lstInternetSpeed.Items.Add(decInternetSpeed)
                    decTotalInternetSpeed += decInternetSpeed
                    intNumberOfEntries += 1
                    strInputMessage = strNormalMessage
                Else
                    strInputMessage = strNegativeError
                End If
            Else
                strInputMessage = strNonNumericError
            End If
            If intNumberOfEntries <= intMaxNumberOfEntries Then
                strInternetSpeed = InputBox(strInputMessage & intNumberOfEntries, strInputHeading, " ")
            End If
        Loop

        ' Calculates and displays average Internet Speed
        If intNumberOfEntries > 1 Then
            lblAverageInternetSpeed.Visible = True
            decAverageInternetSpeed = decTotalInternetSpeed / (intNumberOfEntries - 1)
            lblAverageInternetSpeed.Text = "Average Internet Speed: " &
                decAverageInternetSpeed.ToString("F1") & " Mbps"
        Else
            MsgBox("No Internet Speed value entered")
        End If

        ' Disables the InternetSpeed button
        btnInternetSpeed.Enabled = False
    End Sub

    Private Sub mnuClear_Click(sender As Object, e As EventArgs) Handles mnuClear.Click
        ' The mnuClear click event clears the ListBox object and hides 
        ' the average Internet Speed label. It also enables the InternetSpeed button

        lstInternetSpeed.Items.Clear()
        lblAverageInternetSpeed.Visible = False
        btnInternetSpeed.Enabled = True
    End Sub

    Private Sub mnuExit_Click(sender As Object, e As EventArgs) Handles mnuExit.Click
        ' The mnuExit click event closes the window and exits the application

        Close()
    End Sub
End Class
