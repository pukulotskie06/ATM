Public Class Functionality
    Public con As New OleDb.OleDbConnection
    Public ad As OleDb.OleDbDataAdapter
    Dim ds As DataSet


    'Deposit goes here
    Public Sub Deposit()
        Dim amount As Integer
        AccessATM(x, amount, "amount", "deposit")

    End Sub


    'To access the database go here...
    Public Sub AccessATM(ByRef row As Integer, ByVal amount As Double, ByRef myItem As String, ByVal status As String)
        Dim paths As String = "Data Source=" & Environment.CurrentDirectory & "\ATM.accdb;Persist Security Info=True;User ID=admin"
        Dim builder As New OleDb.OleDbCommandBuilder


        con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;" & paths

        ad = New OleDb.OleDbDataAdapter("SELECT * from MyATM", con)
        Dim db As New OleDb.OleDbCommandBuilder(ad)
        con.Open()

        ds = New DataSet
        ad.Fill(ds, "atmKo")

        If status = "withdraw" Then
            'Wthdraw savings here
            Dim temp As Decimal = ds.Tables("atmKo").Rows(row).Item(myItem)
            Dim prev As Decimal = temp
            If amount <= temp Then
                temp = temp - amount
                ds.Tables("atmKo").Rows(row).Item(myItem) = temp
                ad.Update(ds, "atmKo")
                Form1.lblDisplay.Text = vbCrLf & vbCrLf & vbCrLf & vbCrLf & vbCrLf & "Previous balance is : Php " & Format(prev, "Standard") _
                    & vbCrLf & vbCrLf & "Current balance is Php " & Format(ds.Tables("atmKo").Rows(row).Item(myItem), "Standard")
                con.Close()
                Choice()
                Form1.txtWithdraw.Clear()
                EnableButton()
                Form1.btnW.Enabled = False

            ElseIf amount > temp Then

                Form1.lblDisplay.Text = vbCrLf & vbCrLf & vbCrLf & vbCrLf & vbCrLf & "You are trying to withdraw the amount" _
                    & vbCrLf & vbCrLf & " greater than your balance!!! "
                Choice()
                con.Close()
                Form1.txtWithdraw.Clear()
                EnableButton()
                Form1.btnW.Enabled = False
            End If

        ElseIf status = "balance" Then
            'Check balance here
            Dim ctr As Integer = 0
            Dim temp As String = ds.Tables("atmKo").Rows(row).Item(myItem).ToString

            Form1.lblDisplay.Text = vbCrLf & vbCrLf & vbCrLf & vbCrLf & vbCrLf & vbCrLf & vbCrLf & "Your balance is : Php " & Format(temp, "Standard")
            Choice()
            con.Close()
            EnableButton()
            Form1.btnB.Enabled = False

        ElseIf status = "changePin" Then

            ds.Tables("atmKo").Rows(row).Item(myItem) = amount
            ad.Update(ds, "atmKo")
            con.Close()
            Form1.lblDisplay.Text = vbCrLf & vbCrLf & vbCrLf & vbCrLf & vbCrLf & vbCrLf & vbCrLf

            EnableButton()
            Choice()
        ElseIf status = "deposit" Then

        End If

        con.Close()
    End Sub

    'Disable the yes and no button
    Public Sub DisableButton()
        Form1.btnYes.Enabled = False
        Form1.btnNo.Enabled = False
    End Sub
    'Enable the yes and no button
    Public Sub EnableButton()
        Form1.btnYes.Enabled = True
        Form1.btnNo.Enabled = True
    End Sub
    'Always displayed after every transaction
    'The user has the Option To have another transaction Or Not
    'If yes, Then transaction available will be displayed
    'If no, Then opening scene will be displayed


    Public Sub Choice()
        Form1.lblDisplay.Text &= vbCrLf & vbCrLf & vbCrLf & vbCrLf & vbCrLf & vbCrLf & "Transaction Completed!" & vbCrLf & vbCrLf & vbCrLf & "Do you want another transaction? Y/N"

    End Sub
    Public Function Display(ByVal x As String)


        If UCase(x) = "Y" Then
            MyMenu()
            Return 1

        ElseIf UCase(x) = "N" Then
            Form1.Timer1.Start()
            Return -1
        End If
        Return 0
    End Function

    'Inputted PIN matched With the PIN stored In the datbase
    'Only three attempts Is allowed
    'After three attempts, PIN cannot be entered
    'Can update/change PIN
    Dim x As Integer
    Public Function Pin(ByVal myPin As String, ByRef attempt As Integer)

        If attempt = 3 Then
            Form1.txtPin.Visible = False
            Form1.lblDisplay.Text = vbCrLf & vbCrLf & vbCrLf & "You have entered an Ivalid PIN 3 consecutive times."
            Return 0
        End If


        Dim paths As String = "Data Source=" & Environment.CurrentDirectory & "\ATM.accdb;Persist Security Info=True;User ID=admin"
        'MsgBox(paths)

        con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;" & paths
        ad = New OleDb.OleDbDataAdapter("SELECT * from MyATM", con)
        con.Open()
        'MsgBox("Database is now open")
        ds = New DataSet
        ad.Fill(ds, "atmKo")
        For x = 0 To ds.Tables("atmKo").Rows.Count - 1
            If (ds.Tables("atmKo").Rows(x).Item("pin")) = myPin Then
                Exit For
            End If
        Next

        Try
            If (ds.Tables("atmKo").Rows(x).Item("pin")) = myPin Then
                'MsgBox(ds.Tables("atmKo").Rows(x).Item("ID"))
                'MsgBox(ds.Tables("atmKo").Rows(x).Item("amount"))
                'MsgBox(ds.Tables("atmKo").Rows(x).Item("pin"))
                'MsgBox(ds.Tables("atmKo").Rows(x).Item("userName"))
                Form1.txtPin.Visible = False
                MyMenu()
                attempt = 0
                con.Close()
                Return myPin
            End If
        Catch
            attempt += 1
            con.Close()
        End Try
        con.Close()
        'MsgBox("Database is now close")
        Return 0
    End Function


    'The current balance from the database must be displayed.
    'After withdrawal, the updated balance must be displayed.
    'The displayed balance should be in currency format
    'After displaying the balance a confirmation will be displayed
    Public Function BalanceInquiry()
        AccessATM(x, 0, "amount", "balance")

        Return 0
    End Function


    'The user can withdraw from the deposited amount
    'The withdrawn amount was deducted from the deposited amount.
    'The user cannot withdraw amount that exceeds the depisted amount
    'After withdrawal a confirmation will be displayed
    Public Function Withdrawal()
        Form1.lblDisplay.Text = vbCrLf & vbCrLf & vbCrLf & vbCrLf & vbCrLf & vbCrLf & vbCrLf _
                & "                     Enter amount to withdraw"
        Form1.txtWithdraw.Location = New Point(150, 185)
        Form1.txtWithdraw.Visible = True
        Return 0
    End Function

    'When enter button is pressed and the amount has been entered then do this
    Public Sub CallWithdraw()
        AccessATM(x, Val(Form1.txtWithdraw.Text), "amount", "withdraw")
    End Sub



    'Change pin
    Public Function ChangePin()

        AccessATM(x, Form1.txtNew.Text, "pin", "changePin")

        Return 0
    End Function

    '----------------------------------------------------------------
    '------------------------MENU------------------------------------
    'Withdraw
    'Balance
    'Change PIN
    Public Sub MyMenu()
        Form1.lblDisplay.Text = vbCrLf &
              "                                     CASH WITHDRAWAL" & vbCrLf & vbCrLf & vbCrLf & vbCrLf _
            & "                                      BALANCE INQUIRY" & vbCrLf & vbCrLf & vbCrLf & vbCrLf _
            & "                                              CHANGE PIN"
        Form1.btnW.Enabled = True
        Form1.btnB.Enabled = True
        Form1.btnC.Enabled = True

    End Sub
End Class
