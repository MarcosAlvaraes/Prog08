<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form3
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtComprimento = New System.Windows.Forms.TextBox()
        Me.txtLargura = New System.Windows.Forms.TextBox()
        Me.txtAltura = New System.Windows.Forms.TextBox()
        Me.txtResult = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(327, 64)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(364, 32)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Calcular o volume de um tanque"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(72, 184)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(185, 32)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Comprimento ="
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(141, 247)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(116, 32)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Largura ="
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(157, 308)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 32)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Altura ="
        '
        'txtComprimento
        '
        Me.txtComprimento.Location = New System.Drawing.Point(265, 177)
        Me.txtComprimento.Margin = New System.Windows.Forms.Padding(4)
        Me.txtComprimento.Name = "txtComprimento"
        Me.txtComprimento.Size = New System.Drawing.Size(277, 39)
        Me.txtComprimento.TabIndex = 10
        '
        'txtLargura
        '
        Me.txtLargura.Location = New System.Drawing.Point(265, 240)
        Me.txtLargura.Margin = New System.Windows.Forms.Padding(4)
        Me.txtLargura.Name = "txtLargura"
        Me.txtLargura.Size = New System.Drawing.Size(277, 39)
        Me.txtLargura.TabIndex = 11
        '
        'txtAltura
        '
        Me.txtAltura.Location = New System.Drawing.Point(265, 301)
        Me.txtAltura.Margin = New System.Windows.Forms.Padding(4)
        Me.txtAltura.Name = "txtAltura"
        Me.txtAltura.Size = New System.Drawing.Size(277, 39)
        Me.txtAltura.TabIndex = 12
        '
        'txtResult
        '
        Me.txtResult.Location = New System.Drawing.Point(265, 411)
        Me.txtResult.Margin = New System.Windows.Forms.Padding(4)
        Me.txtResult.Name = "txtResult"
        Me.txtResult.Size = New System.Drawing.Size(277, 39)
        Me.txtResult.TabIndex = 14
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(54, 411)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(203, 39)
        Me.Button1.TabIndex = 13
        Me.Button1.Text = "Calcular Volume"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(13.0!, 32.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1040, 576)
        Me.Controls.Add(Me.txtResult)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtAltura)
        Me.Controls.Add(Me.txtLargura)
        Me.Controls.Add(Me.txtComprimento)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Form3"
        Me.Text = "Form3"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtComprimento As TextBox
    Friend WithEvents txtLargura As TextBox
    Friend WithEvents txtAltura As TextBox
    Friend WithEvents txtResult As TextBox
    Friend WithEvents Button1 As Button
End Class
