﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormLogin
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
        Me.lcircus = New System.Windows.Forms.Label()
        Me.labelpassword = New System.Windows.Forms.Label()
        Me.labelakun = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.btnlogin = New System.Windows.Forms.Button()
        Me.labelkangsirkus = New System.Windows.Forms.Label()
        Me.pbbatas = New System.Windows.Forms.PictureBox()
        Me.pb1 = New System.Windows.Forms.PictureBox()
        Me.btnmember = New System.Windows.Forms.Button()
        Me.btnguest = New System.Windows.Forms.Button()
        Me.labelcostumer = New System.Windows.Forms.Label()
        CType(Me.pbbatas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pb1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lcircus
        '
        Me.lcircus.AutoSize = True
        Me.lcircus.CausesValidation = False
        Me.lcircus.Enabled = False
        Me.lcircus.Font = New System.Drawing.Font("Ravie", 15.0!)
        Me.lcircus.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lcircus.Location = New System.Drawing.Point(203, 229)
        Me.lcircus.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lcircus.Name = "lcircus"
        Me.lcircus.Size = New System.Drawing.Size(282, 35)
        Me.lcircus.TabIndex = 27
        Me.lcircus.Text = "The Vera Circus"
        '
        'labelpassword
        '
        Me.labelpassword.AutoSize = True
        Me.labelpassword.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelpassword.Location = New System.Drawing.Point(373, 348)
        Me.labelpassword.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.labelpassword.Name = "labelpassword"
        Me.labelpassword.Size = New System.Drawing.Size(98, 23)
        Me.labelpassword.TabIndex = 26
        Me.labelpassword.Text = "Password"
        '
        'labelakun
        '
        Me.labelakun.AutoSize = True
        Me.labelakun.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelakun.Location = New System.Drawing.Point(373, 315)
        Me.labelakun.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.labelakun.Name = "labelakun"
        Me.labelakun.Size = New System.Drawing.Size(53, 23)
        Me.labelakun.TabIndex = 25
        Me.labelakun.Text = "Akun"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(479, 348)
        Me.TextBox2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(132, 22)
        Me.TextBox2.TabIndex = 24
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(479, 316)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(132, 22)
        Me.TextBox1.TabIndex = 23
        '
        'btnlogin
        '
        Me.btnlogin.Location = New System.Drawing.Point(479, 380)
        Me.btnlogin.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnlogin.Name = "btnlogin"
        Me.btnlogin.Size = New System.Drawing.Size(105, 28)
        Me.btnlogin.TabIndex = 22
        Me.btnlogin.Text = "Login"
        Me.btnlogin.UseVisualStyleBackColor = True
        '
        'labelkangsirkus
        '
        Me.labelkangsirkus.AutoSize = True
        Me.labelkangsirkus.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelkangsirkus.Location = New System.Drawing.Point(372, 277)
        Me.labelkangsirkus.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.labelkangsirkus.Name = "labelkangsirkus"
        Me.labelkangsirkus.Size = New System.Drawing.Size(115, 24)
        Me.labelkangsirkus.TabIndex = 21
        Me.labelkangsirkus.Text = "Kang Sirkus :"
        '
        'pbbatas
        '
        Me.pbbatas.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.pbbatas.Location = New System.Drawing.Point(351, 277)
        Me.pbbatas.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.pbbatas.Name = "pbbatas"
        Me.pbbatas.Size = New System.Drawing.Size(13, 134)
        Me.pbbatas.TabIndex = 20
        Me.pbbatas.TabStop = False
        '
        'pb1
        '
        Me.pb1.ErrorImage = Global.TugasKelompokVB.My.Resources.Resources._1kooza
        Me.pb1.Image = Global.TugasKelompokVB.My.Resources.Resources._2corteo
        Me.pb1.Location = New System.Drawing.Point(1, 0)
        Me.pb1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.pb1.Name = "pb1"
        Me.pb1.Size = New System.Drawing.Size(705, 270)
        Me.pb1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pb1.TabIndex = 19
        Me.pb1.TabStop = False
        '
        'btnmember
        '
        Me.btnmember.Location = New System.Drawing.Point(199, 338)
        Me.btnmember.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnmember.Name = "btnmember"
        Me.btnmember.Size = New System.Drawing.Size(100, 49)
        Me.btnmember.TabIndex = 18
        Me.btnmember.Text = "Create Member"
        Me.btnmember.UseVisualStyleBackColor = True
        '
        'btnguest
        '
        Me.btnguest.Location = New System.Drawing.Point(65, 338)
        Me.btnguest.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnguest.Name = "btnguest"
        Me.btnguest.Size = New System.Drawing.Size(100, 49)
        Me.btnguest.TabIndex = 17
        Me.btnguest.Text = "Guest"
        Me.btnguest.UseVisualStyleBackColor = True
        '
        'labelcostumer
        '
        Me.labelcostumer.AutoSize = True
        Me.labelcostumer.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelcostumer.Location = New System.Drawing.Point(133, 294)
        Me.labelcostumer.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.labelcostumer.Name = "labelcostumer"
        Me.labelcostumer.Size = New System.Drawing.Size(95, 24)
        Me.labelcostumer.TabIndex = 16
        Me.labelcostumer.Text = "Costumer :"
        '
        'FormLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(705, 418)
        Me.Controls.Add(Me.lcircus)
        Me.Controls.Add(Me.labelpassword)
        Me.Controls.Add(Me.labelakun)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.btnlogin)
        Me.Controls.Add(Me.labelkangsirkus)
        Me.Controls.Add(Me.pbbatas)
        Me.Controls.Add(Me.pb1)
        Me.Controls.Add(Me.btnmember)
        Me.Controls.Add(Me.btnguest)
        Me.Controls.Add(Me.labelcostumer)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "FormLogin"
        Me.Text = "FormLogin"
        CType(Me.pbbatas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pb1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lcircus As Label
    Friend WithEvents labelpassword As Label
    Friend WithEvents labelakun As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents btnlogin As Button
    Friend WithEvents labelkangsirkus As Label
    Friend WithEvents pbbatas As PictureBox
    Friend WithEvents pb1 As PictureBox
    Friend WithEvents btnmember As Button
    Friend WithEvents btnguest As Button
    Friend WithEvents labelcostumer As Label
End Class
