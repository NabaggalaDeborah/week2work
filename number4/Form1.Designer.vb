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
        Me.lblMultiplicationTableFrom1to10 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.btnshow = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblMultiplicationTableFrom1to10
        '
        Me.lblMultiplicationTableFrom1to10.AutoSize = True
        Me.lblMultiplicationTableFrom1to10.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.1!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMultiplicationTableFrom1to10.Location = New System.Drawing.Point(193, 23)
        Me.lblMultiplicationTableFrom1to10.Name = "lblMultiplicationTableFrom1to10"
        Me.lblMultiplicationTableFrom1to10.Size = New System.Drawing.Size(405, 31)
        Me.lblMultiplicationTableFrom1to10.TabIndex = 0
        Me.lblMultiplicationTableFrom1to10.Text = "Multiplication Table From 1 to 10"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(251, 76)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(272, 189)
        Me.TextBox1.TabIndex = 1
        '
        'btnshow
        '
        Me.btnshow.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnshow.Location = New System.Drawing.Point(315, 294)
        Me.btnshow.Name = "btnshow"
        Me.btnshow.Size = New System.Drawing.Size(157, 35)
        Me.btnshow.TabIndex = 2
        Me.btnshow.Text = "Show"
        Me.btnshow.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnshow)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.lblMultiplicationTableFrom1to10)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblMultiplicationTableFrom1to10 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents btnshow As Button
End Class
