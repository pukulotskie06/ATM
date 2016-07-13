Public Class Form1
    Dim func As New Functionality
    'The following transactions (balance inquiry, withdrawal And change PIN) are available
    'Each transacton Is functional
    'Each transaction has accurate response
    'No other information are available (Hence the user cannot deposit)
    Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        myFlash.Movie = Application.StartupPath & "\ATM.swf"
        myFlash.Location = New Point(12, 20)
        Timer1.Start()
        txtPin.Location = New Point(150, 185)


    End Sub



    'Import a flash file
    'Flash file runs automatically
    'Related to the concept of the project
    'Displayed for five seconds
    Dim x As Integer = 0
    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As EventArgs) Handles Timer1.Tick

        If x = 5 Then
            x = 0
            Timer1.Stop()
            myFlash.Stop()
            myFlash.Visible = False
            lblDisplay.Visible = True
            lblDisplay.Text = vbCrLf & vbCrLf & vbCrLf & vbCrLf & vbCrLf & vbCrLf & vbCrLf _
                & "                     Enter your 4 digit PIN"
            txtPin.Visible = True

        Else

            lblDisplay.Visible = False
            myFlash.Play()
            myFlash.Visible = True
            txtPin.Visible = False

            x += 1
        End If

    End Sub

    Private Sub btnCancel_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub



    Private Sub btnEnter_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnEnter.Click
        'call this when the withdrawn is available
        If txtWithdraw.Visible.Equals(True) And txtWithdraw.Text <> Nothing And Val(txtWithdraw.Text) Mod 100 = 0 Then

            func.CallWithdraw()
            txtWithdraw.Visible = False

        End If
    End Sub

    Private Sub btnYes_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnYes.Click
        func.Display(btnYes.Text.Substring(0, 1))
        func.DisableButton()
    End Sub

    Private Sub btnNo_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnNo.Click
        func.Display(btnNo.Text.Substring(0, 1))
        func.DisableButton()
    End Sub

    Dim myPin As Integer
    Dim attempt As Integer = 1
    Private Sub TextBox1_KeyUp(ByVal sender As Object, ByVal e As KeyEventArgs) Handles txtPin.KeyUp

        If txtPin.Text.Length = 4 Then

            myPin = func.Pin(txtPin.Text, attempt)
            txtPin.Clear()
            'MsgBox(attempt)
        End If



    End Sub


    Private Sub allEvent(ByVal sender As Object, ByVal e As KeyPressEventArgs)

    End Sub

    Private Sub btnW_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnW.Click
        btnW.Enabled = False
        btnB.Enabled = False
        btnC.Enabled = False
        func.Withdrawal()

    End Sub

    Private Sub Button2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button2.Click
        txtWithdraw.Clear()
        txtPin.Clear()

        If txtNew.Enabled.Equals(True) And txtNew.Visible.Equals(True) Then
            txtNew.Clear()
        End If

        If txtCurrent.Enabled.Equals(True) And txtCurrent.Visible.Equals(True) Then
            txtCurrent.Clear()
        End If

        If txtConfirm.Enabled.Equals(True) And txtConfirm.Visible.Equals(True) Then
            txtConfirm.Clear()
        End If

    End Sub

    Private Sub btnB_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnB.Click
        btnW.Enabled = False
        btnC.Enabled = False
        func.BalanceInquiry()
    End Sub

    Private Sub lblDisplay_Click(ByVal sender As Object, ByVal e As EventArgs) Handles lblDisplay.Click

    End Sub

    'Disabled character other than numbers and back space
    Public Sub OnlyNumbers(ByVal e As KeyPressEventArgs)

        If Asc(e.KeyChar) = 8 Or Asc(e.KeyChar) > 47 And Asc(e.KeyChar) < 58 Then
            e.Handled = False
        Else
            e.Handled = True


        End If
    End Sub





    Private Sub txtPin_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtPin.KeyPress
        OnlyNumbers(e)
    End Sub

    Private Sub txtWithdraw_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtWithdraw.KeyPress
        OnlyNumbers(e)
    End Sub

    Private Sub txtBal_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtBal.KeyPress
        OnlyNumbers(e)
    End Sub

    Private Sub txtCurrent_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtCurrent.KeyPress
        OnlyNumbers(e)
    End Sub

    Private Sub txtNew_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtNew.KeyPress
        OnlyNumbers(e)
    End Sub

    Private Sub txtConfirm_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtConfirm.KeyPress
        OnlyNumbers(e)
    End Sub

    Private Sub btnC_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnC.Click
        btnC.Enabled = False
        txtNew.Location = New Point(150, 100)
        txtNew.Visible = True
        lblDisplay.Text = vbCrLf & vbCrLf & vbCrLf & "                  Enter your new 4 digit PIN" & vbCrLf

        lblDisplay.Text &= vbCrLf & vbCrLf & vbCrLf & "                  Re-enter your new 4 digit PIN" & vbCrLf
        txtConfirm.Location = New Point(150, 180)
        txtConfirm.Visible = True

    End Sub

    Private Sub btnC_KeyUp(ByVal sender As Object, ByVal e As KeyEventArgs) Handles btnC.KeyUp

    End Sub

    Private Sub txtNew_KeyUp(ByVal sender As Object, ByVal e As KeyEventArgs) Handles txtNew.KeyUp
        If txtNew.TextLength = 4 Then
            txtNew.Enabled = False
            txtConfirm.Enabled = True
        End If
    End Sub

    Private Sub txtConfirm_KeyUp(ByVal sender As Object, ByVal e As KeyEventArgs) Handles txtConfirm.KeyUp
        If txtConfirm.TextLength = 4 Then
            If txtNew.Text = txtConfirm.Text Then
                ''call current text
                txtNew.Visible = False
                txtConfirm.Visible = False
                lblDisplay.Text = vbCrLf & vbCrLf & vbCrLf & vbCrLf & vbCrLf & vbCrLf & vbCrLf _
                                & "                         Enter your old PIN"
                txtCurrent.Location = New Point(150, 185)
                txtCurrent.Visible = True
                txtCurrent.Enabled = True

            Else

                ''PIN did not match
                txtConfirm.Clear()
                txtConfirm.Enabled = False
                txtNew.Clear()
                txtNew.Enabled = True

            End If

        End If
    End Sub

    Private Sub txtCurrent_KeyUp(ByVal sender As Object, ByVal e As KeyEventArgs) Handles txtCurrent.KeyUp
        If txtCurrent.TextLength = 4 Then
            If txtCurrent.Text = myPin Then

                func.ChangePin()
                txtCurrent.Clear()
                txtCurrent.Visible = False

            Else
                txtCurrent.Clear()
                MsgBox("You have entered the wrong PIN")
            End If

        End If
    End Sub

    Private Sub btnDeposit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDeposit.Click
        func.Deposit()
    End Sub
End Class
