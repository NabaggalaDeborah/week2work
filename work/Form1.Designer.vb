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
        lblName = New Label()
        lblAge = New Label()
        txtName = New TextBox()
        txtAge = New TextBox()
        Button1 = New Button()
        lblFavoritecolor = New Label()
        txtFavoritecolor = New TextBox()
        SuspendLayout()
        ' 
        ' lblName
        ' 
        lblName.AutoSize = True
        lblName.Location = New Point(188, 72)
        lblName.Name = "lblName"
        lblName.Size = New Size(39, 15)
        lblName.TabIndex = 0
        lblName.Text = "Name"
        ' 
        ' lblAge
        ' 
        lblAge.AutoSize = True
        lblAge.Location = New Point(188, 132)
        lblAge.Name = "lblAge"
        lblAge.Size = New Size(28, 15)
        lblAge.TabIndex = 1
        lblAge.Text = "Age"
        ' 
        ' txtName
        ' 
        txtName.Location = New Point(336, 64)
        txtName.Name = "txtName"
        txtName.Size = New Size(182, 23)
        txtName.TabIndex = 2
        ' 
        ' txtAge
        ' 
        txtAge.Location = New Point(339, 124)
        txtAge.Name = "txtAge"
        txtAge.Size = New Size(179, 23)
        txtAge.TabIndex = 3
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(281, 244)
        Button1.Name = "Button1"
        Button1.Size = New Size(139, 35)
        Button1.TabIndex = 4
        Button1.Text = "click"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' lblFavoritecolor
        ' 
        lblFavoritecolor.AutoSize = True
        lblFavoritecolor.Location = New Point(188, 189)
        lblFavoritecolor.Name = "lblFavoritecolor"
        lblFavoritecolor.Size = New Size(79, 15)
        lblFavoritecolor.TabIndex = 5
        lblFavoritecolor.Text = "Favorite color"
        ' 
        ' txtFavoritecolor
        ' 
        txtFavoritecolor.Location = New Point(339, 181)
        txtFavoritecolor.Name = "txtFavoritecolor"
        txtFavoritecolor.Size = New Size(179, 23)
        txtFavoritecolor.TabIndex = 6
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(txtFavoritecolor)
        Controls.Add(lblFavoritecolor)
        Controls.Add(Button1)
        Controls.Add(txtAge)
        Controls.Add(txtName)
        Controls.Add(lblAge)
        Controls.Add(lblName)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblName As Label
    Friend WithEvents lblAge As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtAge As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents lblFavoritecolor As Label
    Friend WithEvents txtFavoritecolor As TextBox

End Class
