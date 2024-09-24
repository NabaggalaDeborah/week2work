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
        Me.lblEnterNumber = New System.Windows.Forms.Label()
        Me.txtEnterNumber = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblEnterNumber
        '
        Me.lblEnterNumber.AutoSize = True
        Me.lblEnterNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEnterNumber.Location = New System.Drawing.Point(323, 31)
        Me.lblEnterNumber.Name = "lblEnterNumber"
        Me.lblEnterNumber.Size = New System.Drawing.Size(189, 32)
        Me.lblEnterNumber.TabIndex = 0
        Me.lblEnterNumber.Text = "Enter Number"
        '
        'txtEnterNumber
        '
        Me.txtEnterNumber.Location = New System.Drawing.Point(356, 86)
        Me.txtEnterNumber.Name = "txtEnterNumber"
        Me.txtEnterNumber.Size = New System.Drawing.Size(122, 20)
        Me.txtEnterNumber.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(356, 157)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(104, 34)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Count to Zero"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtEnterNumber)
        Me.Controls.Add(Me.lblEnterNumber)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblEnterNumber As Label
    Friend WithEvents txtEnterNumber As TextBox
    Friend WithEvents Button1 As Button
End Class
