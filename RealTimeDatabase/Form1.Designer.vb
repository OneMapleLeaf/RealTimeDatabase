<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.gender_combo = New System.Windows.Forms.ComboBox()
        Me.address_txt = New System.Windows.Forms.TextBox()
        Me.contNum_txt = New System.Windows.Forms.TextBox()
        Me.lName_txt = New System.Windows.Forms.TextBox()
        Me.fName_txt = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.confirm_btn = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tungsten Bold", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(4, 0)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(205, 60)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Registration"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.confirm_btn)
        Me.Panel1.Controls.Add(Me.gender_combo)
        Me.Panel1.Controls.Add(Me.address_txt)
        Me.Panel1.Controls.Add(Me.contNum_txt)
        Me.Panel1.Controls.Add(Me.lName_txt)
        Me.Panel1.Controls.Add(Me.fName_txt)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Location = New System.Drawing.Point(16, 15)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1035, 524)
        Me.Panel1.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Tungsten Bold", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(4, 474)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(233, 46)
        Me.Button1.TabIndex = 13
        Me.Button1.Text = "View Data"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'gender_combo
        '
        Me.gender_combo.Font = New System.Drawing.Font("Tungsten Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gender_combo.FormattingEnabled = True
        Me.gender_combo.Items.AddRange(New Object() {"Male", "Female"})
        Me.gender_combo.Location = New System.Drawing.Point(413, 331)
        Me.gender_combo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.gender_combo.Name = "gender_combo"
        Me.gender_combo.Size = New System.Drawing.Size(391, 37)
        Me.gender_combo.TabIndex = 11
        '
        'address_txt
        '
        Me.address_txt.Font = New System.Drawing.Font("Tungsten Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.address_txt.Location = New System.Drawing.Point(413, 288)
        Me.address_txt.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.address_txt.Name = "address_txt"
        Me.address_txt.Size = New System.Drawing.Size(312, 36)
        Me.address_txt.TabIndex = 10
        '
        'contNum_txt
        '
        Me.contNum_txt.Font = New System.Drawing.Font("Tungsten Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.contNum_txt.Location = New System.Drawing.Point(413, 249)
        Me.contNum_txt.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.contNum_txt.Name = "contNum_txt"
        Me.contNum_txt.Size = New System.Drawing.Size(312, 36)
        Me.contNum_txt.TabIndex = 9
        '
        'lName_txt
        '
        Me.lName_txt.Font = New System.Drawing.Font("Tungsten Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lName_txt.Location = New System.Drawing.Point(413, 209)
        Me.lName_txt.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lName_txt.Name = "lName_txt"
        Me.lName_txt.Size = New System.Drawing.Size(312, 36)
        Me.lName_txt.TabIndex = 8
        '
        'fName_txt
        '
        Me.fName_txt.Font = New System.Drawing.Font("Tungsten Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fName_txt.Location = New System.Drawing.Point(413, 170)
        Me.fName_txt.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.fName_txt.Name = "fName_txt"
        Me.fName_txt.Size = New System.Drawing.Size(312, 36)
        Me.fName_txt.TabIndex = 7
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tungsten Bold", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(191, 325)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(87, 41)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Gender"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tungsten Bold", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(191, 286)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(99, 41)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Address"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tungsten Bold", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(191, 207)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(120, 41)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Last Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tungsten Bold", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(191, 246)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(176, 41)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Contact Number"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tungsten Bold", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(191, 167)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(123, 41)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "First Name"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Teal
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1035, 58)
        Me.Panel2.TabIndex = 1
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Tungsten Bold", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(798, 474)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(233, 46)
        Me.Button2.TabIndex = 14
        Me.Button2.Text = "Balance"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'confirm_btn
        '
        Me.confirm_btn.BackColor = System.Drawing.Color.Transparent
        Me.confirm_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.confirm_btn.Font = New System.Drawing.Font("Tungsten Bold", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.confirm_btn.Image = Global.RealTimeDatabase.My.Resources.Resources.confirm
        Me.confirm_btn.Location = New System.Drawing.Point(429, 377)
        Me.confirm_btn.Margin = New System.Windows.Forms.Padding(4)
        Me.confirm_btn.Name = "confirm_btn"
        Me.confirm_btn.Size = New System.Drawing.Size(217, 87)
        Me.confirm_btn.TabIndex = 12
        Me.confirm_btn.Text = "Confirm"
        Me.confirm_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.confirm_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.confirm_btn.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1067, 554)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents confirm_btn As Button
    Friend WithEvents gender_combo As ComboBox
    Friend WithEvents address_txt As TextBox
    Friend WithEvents contNum_txt As TextBox
    Friend WithEvents lName_txt As TextBox
    Friend WithEvents fName_txt As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
