<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.txtConfirm = New System.Windows.Forms.TextBox()
        Me.txtNew = New System.Windows.Forms.TextBox()
        Me.txtCurrent = New System.Windows.Forms.TextBox()
        Me.txtBal = New System.Windows.Forms.TextBox()
        Me.txtWithdraw = New System.Windows.Forms.TextBox()
        Me.txtPin = New System.Windows.Forms.TextBox()
        Me.btnNo = New System.Windows.Forms.Button()
        Me.btnYes = New System.Windows.Forms.Button()
        Me.btnC = New System.Windows.Forms.Button()
        Me.btnB = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnEnter = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.lblDisplay = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.btnW = New System.Windows.Forms.Button()
        Me.myFlash = New AxShockwaveFlashObjects.AxShockwaveFlash()
        Me.btnDeposit = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.myFlash, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtConfirm
        '
        Me.txtConfirm.Enabled = False
        Me.txtConfirm.Location = New System.Drawing.Point(552, 378)
        Me.txtConfirm.MaxLength = 4
        Me.txtConfirm.Name = "txtConfirm"
        Me.txtConfirm.Size = New System.Drawing.Size(126, 20)
        Me.txtConfirm.TabIndex = 27
        Me.txtConfirm.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtConfirm.UseSystemPasswordChar = True
        Me.txtConfirm.Visible = False
        '
        'txtNew
        '
        Me.txtNew.Location = New System.Drawing.Point(545, 293)
        Me.txtNew.MaxLength = 4
        Me.txtNew.Name = "txtNew"
        Me.txtNew.Size = New System.Drawing.Size(126, 20)
        Me.txtNew.TabIndex = 25
        Me.txtNew.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtNew.UseSystemPasswordChar = True
        Me.txtNew.Visible = False
        '
        'txtCurrent
        '
        Me.txtCurrent.Enabled = False
        Me.txtCurrent.Location = New System.Drawing.Point(557, 350)
        Me.txtCurrent.MaxLength = 4
        Me.txtCurrent.Name = "txtCurrent"
        Me.txtCurrent.Size = New System.Drawing.Size(126, 20)
        Me.txtCurrent.TabIndex = 37
        Me.txtCurrent.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtCurrent.UseSystemPasswordChar = True
        Me.txtCurrent.Visible = False
        '
        'txtBal
        '
        Me.txtBal.Location = New System.Drawing.Point(559, 311)
        Me.txtBal.MaxLength = 254
        Me.txtBal.Name = "txtBal"
        Me.txtBal.Size = New System.Drawing.Size(126, 20)
        Me.txtBal.TabIndex = 36
        Me.txtBal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtBal.Visible = False
        '
        'txtWithdraw
        '
        Me.txtWithdraw.Location = New System.Drawing.Point(569, 279)
        Me.txtWithdraw.MaxLength = 254
        Me.txtWithdraw.Name = "txtWithdraw"
        Me.txtWithdraw.Size = New System.Drawing.Size(126, 20)
        Me.txtWithdraw.TabIndex = 35
        Me.txtWithdraw.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtWithdraw.Visible = False
        '
        'txtPin
        '
        Me.txtPin.Location = New System.Drawing.Point(553, 185)
        Me.txtPin.MaxLength = 4
        Me.txtPin.Name = "txtPin"
        Me.txtPin.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPin.Size = New System.Drawing.Size(126, 20)
        Me.txtPin.TabIndex = 34
        Me.txtPin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtPin.UseSystemPasswordChar = True
        Me.txtPin.Visible = False
        '
        'btnNo
        '
        Me.btnNo.Enabled = False
        Me.btnNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNo.Location = New System.Drawing.Point(410, 324)
        Me.btnNo.Name = "btnNo"
        Me.btnNo.Size = New System.Drawing.Size(88, 35)
        Me.btnNo.TabIndex = 33
        Me.btnNo.Text = "NO"
        Me.btnNo.UseVisualStyleBackColor = True
        '
        'btnYes
        '
        Me.btnYes.Enabled = False
        Me.btnYes.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnYes.Location = New System.Drawing.Point(410, 250)
        Me.btnYes.Name = "btnYes"
        Me.btnYes.Size = New System.Drawing.Size(88, 35)
        Me.btnYes.TabIndex = 32
        Me.btnYes.Text = "YES"
        Me.btnYes.UseVisualStyleBackColor = True
        '
        'btnC
        '
        Me.btnC.Enabled = False
        Me.btnC.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnC.Location = New System.Drawing.Point(410, 176)
        Me.btnC.Name = "btnC"
        Me.btnC.Size = New System.Drawing.Size(88, 35)
        Me.btnC.TabIndex = 31
        Me.btnC.UseVisualStyleBackColor = True
        '
        'btnB
        '
        Me.btnB.Enabled = False
        Me.btnB.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnB.Location = New System.Drawing.Point(410, 96)
        Me.btnB.Name = "btnB"
        Me.btnB.Size = New System.Drawing.Size(88, 35)
        Me.btnB.TabIndex = 30
        Me.btnB.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnEnter)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.btnCancel)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 389)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(493, 71)
        Me.GroupBox1.TabIndex = 28
        Me.GroupBox1.TabStop = False
        '
        'btnEnter
        '
        Me.btnEnter.BackColor = System.Drawing.Color.Lime
        Me.btnEnter.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEnter.Location = New System.Drawing.Point(335, 19)
        Me.btnEnter.Name = "btnEnter"
        Me.btnEnter.Size = New System.Drawing.Size(152, 35)
        Me.btnEnter.TabIndex = 4
        Me.btnEnter.TabStop = False
        Me.btnEnter.Text = "ENTER"
        Me.btnEnter.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Yellow
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(164, 19)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(165, 35)
        Me.Button2.TabIndex = 3
        Me.Button2.TabStop = False
        Me.Button2.Text = "CLEAR"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.Red
        Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(6, 19)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(152, 35)
        Me.btnCancel.TabIndex = 2
        Me.btnCancel.TabStop = False
        Me.btnCancel.Text = "EXIT"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'lblDisplay
        '
        Me.lblDisplay.BackColor = System.Drawing.SystemColors.ControlLight
        Me.lblDisplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDisplay.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDisplay.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblDisplay.Location = New System.Drawing.Point(5, 5)
        Me.lblDisplay.Name = "lblDisplay"
        Me.lblDisplay.Size = New System.Drawing.Size(379, 370)
        Me.lblDisplay.TabIndex = 26
        Me.lblDisplay.Visible = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'btnW
        '
        Me.btnW.Enabled = False
        Me.btnW.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnW.Location = New System.Drawing.Point(410, 14)
        Me.btnW.Name = "btnW"
        Me.btnW.Size = New System.Drawing.Size(88, 35)
        Me.btnW.TabIndex = 29
        Me.btnW.UseVisualStyleBackColor = True
        '
        'myFlash
        '
        Me.myFlash.Enabled = True
        Me.myFlash.Location = New System.Drawing.Point(541, -11)
        Me.myFlash.Name = "myFlash"
        Me.myFlash.OcxState = CType(resources.GetObject("myFlash.OcxState"), System.Windows.Forms.AxHost.State)
        Me.myFlash.Size = New System.Drawing.Size(379, 370)
        Me.myFlash.TabIndex = 38
        '
        'btnDeposit
        '
        Me.btnDeposit.Enabled = False
        Me.btnDeposit.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeposit.Location = New System.Drawing.Point(410, 213)
        Me.btnDeposit.Name = "btnDeposit"
        Me.btnDeposit.Size = New System.Drawing.Size(88, 35)
        Me.btnDeposit.TabIndex = 39
        Me.btnDeposit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(512, 475)
        Me.Controls.Add(Me.btnDeposit)
        Me.Controls.Add(Me.myFlash)
        Me.Controls.Add(Me.txtConfirm)
        Me.Controls.Add(Me.txtNew)
        Me.Controls.Add(Me.txtCurrent)
        Me.Controls.Add(Me.txtBal)
        Me.Controls.Add(Me.txtWithdraw)
        Me.Controls.Add(Me.txtPin)
        Me.Controls.Add(Me.btnNo)
        Me.Controls.Add(Me.btnYes)
        Me.Controls.Add(Me.btnC)
        Me.Controls.Add(Me.btnB)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lblDisplay)
        Me.Controls.Add(Me.btnW)
        Me.Name = "Form1"
        Me.Text = "ATM"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.myFlash, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtConfirm As System.Windows.Forms.TextBox
    Friend WithEvents txtNew As System.Windows.Forms.TextBox
    Friend WithEvents txtCurrent As System.Windows.Forms.TextBox
    Friend WithEvents txtBal As System.Windows.Forms.TextBox
    Friend WithEvents txtWithdraw As System.Windows.Forms.TextBox
    Friend WithEvents txtPin As System.Windows.Forms.TextBox
    Friend WithEvents btnNo As System.Windows.Forms.Button
    Friend WithEvents btnYes As System.Windows.Forms.Button
    Friend WithEvents btnC As System.Windows.Forms.Button
    Friend WithEvents btnB As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnEnter As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents lblDisplay As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents btnW As System.Windows.Forms.Button
    Friend WithEvents myFlash As AxShockwaveFlashObjects.AxShockwaveFlash
    Friend WithEvents btnDeposit As System.Windows.Forms.Button

End Class
