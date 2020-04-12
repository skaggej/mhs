<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSplash
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
        Me.btnOk = New System.Windows.Forms.Button()
        Me.lblInfo = New System.Windows.Forms.Label()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.lblInstruct = New System.Windows.Forms.Label()
        Me.lblCompanyProduct = New System.Windows.Forms.Label()
        Me.lblProductName = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'btnOk
        '
        Me.btnOk.Location = New System.Drawing.Point(331, 171)
        Me.btnOk.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(108, 40)
        Me.btnOk.TabIndex = 0
        Me.btnOk.Text = "OK"
        Me.btnOk.UseVisualStyleBackColor = True
        '
        'lblInfo
        '
        Me.lblInfo.AutoSize = True
        Me.lblInfo.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInfo.Location = New System.Drawing.Point(119, 83)
        Me.lblInfo.Name = "lblInfo"
        Me.lblInfo.Size = New System.Drawing.Size(550, 21)
        Me.lblInfo.TabIndex = 1
        Me.lblInfo.Text = "This program to be used only by single people living in the United States."
        Me.lblInfo.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblTime
        '
        Me.lblTime.AutoSize = True
        Me.lblTime.Location = New System.Drawing.Point(306, 281)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(0, 17)
        Me.lblTime.TabIndex = 2
        '
        'lblInstruct
        '
        Me.lblInstruct.AutoSize = True
        Me.lblInstruct.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInstruct.Location = New System.Drawing.Point(195, 130)
        Me.lblInstruct.Name = "lblInstruct"
        Me.lblInstruct.Size = New System.Drawing.Size(394, 17)
        Me.lblInstruct.TabIndex = 3
        Me.lblInstruct.Text = "Click on the OK button to be transferred to the main screen."
        '
        'lblCompanyProduct
        '
        Me.lblCompanyProduct.AutoSize = True
        Me.lblCompanyProduct.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCompanyProduct.Location = New System.Drawing.Point(170, 233)
        Me.lblCompanyProduct.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCompanyProduct.Name = "lblCompanyProduct"
        Me.lblCompanyProduct.Size = New System.Drawing.Size(428, 35)
        Me.lblCompanyProduct.TabIndex = 4
        Me.lblCompanyProduct.Text = "Copyright 1999 by Eric Skaggs"
        '
        'lblProductName
        '
        Me.lblProductName.AutoSize = True
        Me.lblProductName.Font = New System.Drawing.Font("Arial", 32.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProductName.Location = New System.Drawing.Point(187, 22)
        Me.lblProductName.Name = "lblProductName"
        Me.lblProductName.Size = New System.Drawing.Size(402, 61)
        Me.lblProductName.TabIndex = 5
        Me.lblProductName.Text = "The Tax Wizard"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'frmSplash
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(816, 322)
        Me.Controls.Add(Me.lblProductName)
        Me.Controls.Add(Me.lblCompanyProduct)
        Me.Controls.Add(Me.lblInstruct)
        Me.Controls.Add(Me.lblTime)
        Me.Controls.Add(Me.lblInfo)
        Me.Controls.Add(Me.btnOk)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "frmSplash"
        Me.Text = "The Tax Wizard - Welcome"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnOk As Button
    Friend WithEvents lblInfo As Label
    Friend WithEvents lblTime As Label
    Friend WithEvents lblInstruct As Label
    Friend WithEvents lblCompanyProduct As Label
    Friend WithEvents lblProductName As Label
    Friend WithEvents Timer1 As Timer
End Class
