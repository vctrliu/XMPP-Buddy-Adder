Imports Matrix
Imports Matrix.Xmpp.Client
Imports Microsoft.VisualBasic.FileIO.TextFieldParser
Imports Kent.Boogaart.KBCsv
Imports System.Text.RegularExpressions
Imports System.DirectoryServices




Public Class frmMain

    Dim xclient As New Matrix.Xmpp.Client.XmppClient
    Dim sFilePath As String
    Dim isConnected As Boolean
    Dim sEmails() As String

    Private Sub Connect()

        If isConnected Then
            tick("Please disconnect first")
            Exit Sub
        End If

        Dim sUser As String
        Dim sPw As String
        sUser = txtUser.Text
        sPw = txtPW.Text

        If sUser = "" Or sPw = "" Then
            tick("ERROR: No user or password entered")
            Exit Sub
        End If

        If InStr(sUser, "@", vbTextCompare) Then
            sUser = sUser.Remove(InStr(sUser, "@", vbTextCompare) - 1)
            txtUser.Text = sUser
        End If

        'Assign credentials
        With xclient
            .Username = sUser
            .Password = sPw
        End With

        'Connect
        xclient.XmppDomain = "fluid.com"
        xclient.Hostname = "talk.google.com"
        xclient.StartTls = True
        xclient.Status = "Fluid IT is populating my chat list"
        xclient.Open()
        tick("Connecting with: " & xclient.Username & "@" & xclient.XmppDomain)
        tick("Changing status to """ & xclient.Status & """")


        isConnected = True

    End Sub

    Private Sub tick(ByVal Input As String)
        TextBox2.AppendText(Input & vbCrLf)

    End Sub

    Private Sub TestSubscribe()

        If Not isConnected Then
            tick("ERROR: Not connected")
            Exit Sub
        End If

        Dim pm As New Matrix.Xmpp.Client.PresenceManager
        pm.XmppClient = xclient
        Dim sRecipient As String
        sRecipient = InputBox("Enter an email", "Test Message", "you@fluid.com")
        pm.Subscribe(sRecipient)
        pm = Nothing

    End Sub

    Private Sub CloseConnection()
        If Not (isConnected) Then
            Exit Sub
        End If

        'Close Connection
        xclient.Close()
        xclient.Dispose()

        'Clear Textboxes
        txtUser.Text = ""
        txtPW.Text = ""

        tick("Connection closed for " & xclient.Username)

        isConnected = False

    End Sub

    Private Sub TestMessage()
        If Not isConnected Then
            tick("ERROR: Not connected")
            Exit Sub
        End If

        Dim sRecipient As String
        sRecipient = InputBox("Enter an email", "Test Message", "you@fluid.com")
        Dim xmsg As New Matrix.Xmpp.Client.Message(sRecipient, "Test XMPP Message")
        xclient.Send(xmsg)
    End Sub

    Private Sub LoadCSV()

        'Select the CSV File
        OpenFileDialog1.ShowDialog()
        If IsNothing(sFilePath) Then
            Exit Sub
        End If

        tick("Using " & sFilePath)
        OpenFileDialog1.Dispose()

        'Create the CSV reader
        Dim kReader As New CsvReader(sFilePath)
        Dim iEmailIndex As Integer

        Dim lCtr As Long
        Dim lErrCtr As Long
        lctr = 0

        'Check to see if the csv file has an "email" field.
        kReader.ReadHeaderRecord()
        If Not IsNothing(kReader.HeaderRecord("email")) Then
            iEmailIndex = kReader.HeaderRecord("email")
            tick("Email field is in column " & iEmailIndex)
        Else
            tick("ERROR: CSV File doesn't contain a header with an email field")
            kReader = Nothing
            Exit Sub
        End If

        'Extract all the emails and insert into an array
        Dim kRecord As DataRecord
        kRecord = kReader.ReadDataRecord()

        While (Not kRecord Is Nothing)
            Dim stemp As String
            stemp = kRecord(iEmailIndex)

            Dim m As Match
            m = Regex.Match(stemp, "@fluid\.com$", RegexOptions.IgnoreCase)
            If m.Success Then
                ReDim Preserve sEmails(lCtr)
                sEmails(lCtr) = stemp
                lctr = lctr + 1
            Else
                tick("ERROR: " & stemp & " is not a fluid.com email address")
                lErrCtr = lErrCtr + 1

            End If
            kRecord = kReader.ReadDataRecord

        End While

        kReader.Close()
        kReader = Nothing
        kRecord = Nothing

        tick("CSV File loaded")
        tick("   " & lCtr & " emails were loaded")
        tick("   " & lErrCtr & " emails were not fluid.com email addresses, they were not loaded")
    


    End Sub

    Private Sub AddContacts()
        'New Stuff here: Roster Manager
        Dim rm As New Xmpp.Client.RosterManager
        rm.XmppClient = xclient
        '*************


        If Not isConnected Then
            tick("ERROR: You are not connected")
            Exit Sub

        End If

        'Create the presence manager
        Dim pm As New Matrix.Xmpp.Client.PresenceManager
        Dim lctr As Long
        pm.XmppClient = xclient

        'Subscribe to all Jabber IDS/emails in the array
        If sEmails Is Nothing Then
            tick("ERROR: No emails have been loaded")
            pm = Nothing
            Exit Sub
        Else
            lctr = sEmails.Count
            For ctr = 0 To lctr - 1
                pm.Subscribe(sEmails(ctr))
                'New Stuff!
                rm.Add(sEmails(ctr), (sEmails(ctr)), "Fluid-All")


                '****************
                tick("Adding " & sEmails(ctr))
                System.Threading.Thread.Sleep(1000)

            Next
        End If

        pm = Nothing
        tick(lctr & " emails were added to the chat list")

    End Sub

    Private Sub butt_Connect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butt_Connect.Click
        Call Connect()

    End Sub

    Private Sub butt_Close_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butt_Close.Click
        Call CloseConnection()

    End Sub

    Private Sub butt_Subscribe_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butt_Subscribe.Click
        Call TestSubscribe()


    End Sub

    Private Sub butt_TestMessage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butt_TestMessage.Click
        Call TestMessage()

    End Sub

    Private Sub OpenFileDialog1_FileOk(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk
        sFilePath = OpenFileDialog1.FileName.ToString


    End Sub

    Private Sub butt_SelectFile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butt_SelectFile.Click
        Call LoadCSV()

    End Sub

    Private Sub butt_AddContacts_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butt_AddContacts.Click
        Call AddContacts()

    End Sub


    'LDAP Test stuff
    Private Sub LDAPQuery()
        Dim oRoot As New DirectoryEntry("LDAP://ldap.fluid.com/ou=Employees,dc=fluid,dc=com")
        Dim oSearcher As New DirectorySearcher(oRoot)
        Dim oResults As SearchResultCollection
        Dim oResult As SearchResult
        Dim sEmails() As String
        Dim lCtr As Long
        Dim sLDAPPW As String

        lCtr = 0
        sLDAPPW = InputBox("LDAP Password?")
        'If sLDAPPW = "" Then
        'Exit Sub
        'End If

        oRoot.Password = sLDAPPW
        oRoot.Username = "cn=Manager,dn=fluid,dn=com"
        oSearcher.PropertiesToLoad.Add("email")
        Try
            tick("Querying LDAP... if the application pauses it probably didn't work. Just give it a minute to return the error and then quit")
            oResults = oSearcher.FindAll
            For Each oResult In oResults
                ReDim Preserve sEmails(lCtr)
                sEmails(lCtr) = oResult.ToString()
                lCtr = lCtr + 1
            Next
        Catch ex As Exception
            tick("Unhandled LDAP Error...")
        End Try




    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Call LDAPQuery()

    End Sub
End Class
