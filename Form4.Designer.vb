<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtN1 = New System.Windows.Forms.TextBox()
        Me.txtN2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnSomar = New System.Windows.Forms.Button()
        Me.btnSubtrair = New System.Windows.Forms.Button()
        Me.btnMultiplicar = New System.Windows.Forms.Button()
        Me.btnDividir = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(35, 51)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(369, 32)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Por favor indicar o Primeiro Valor:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(35, 108)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(376, 32)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Por favor indicar o Segundo Valor:"
        '
        'txtN1
        '
        Me.txtN1.Location = New System.Drawing.Point(419, 48)
        Me.txtN1.Margin = New System.Windows.Forms.Padding(4)
        Me.txtN1.Name = "txtN1"
        Me.txtN1.Size = New System.Drawing.Size(277, 39)
        Me.txtN1.TabIndex = 11
        '
        'txtN2
        '
        Me.txtN2.Location = New System.Drawing.Point(419, 105)
        Me.txtN2.Margin = New System.Windows.Forms.Padding(4)
        Me.txtN2.Name = "txtN2"
        Me.txtN2.Size = New System.Drawing.Size(277, 39)
        Me.txtN2.TabIndex = 12
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(419, 244)
        Me.TextBox3.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(277, 39)
        Me.TextBox3.TabIndex = 13
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(253, 251)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(151, 32)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Resultado ->"
        '
        'btnSomar
        '
        Me.btnSomar.Location = New System.Drawing.Point(35, 458)
        Me.btnSomar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSomar.Name = "btnSomar"
        Me.btnSomar.Size = New System.Drawing.Size(203, 39)
        Me.btnSomar.TabIndex = 15
        Me.btnSomar.Text = "Somar"
        Me.btnSomar.UseVisualStyleBackColor = True
        '
        'btnSubtrair
        '
        Me.btnSubtrair.Location = New System.Drawing.Point(274, 458)
        Me.btnSubtrair.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSubtrair.Name = "btnSubtrair"
        Me.btnSubtrair.Size = New System.Drawing.Size(203, 39)
        Me.btnSubtrair.TabIndex = 16
        Me.btnSubtrair.Text = "Subtrair"
        Me.btnSubtrair.UseVisualStyleBackColor = True
        '
        'btnMultiplicar
        '
        Me.btnMultiplicar.Location = New System.Drawing.Point(510, 458)
        Me.btnMultiplicar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnMultiplicar.Name = "btnMultiplicar"
        Me.btnMultiplicar.Size = New System.Drawing.Size(203, 39)
        Me.btnMultiplicar.TabIndex = 17
        Me.btnMultiplicar.Text = "Multiplicar"
        Me.btnMultiplicar.UseVisualStyleBackColor = True
        '
        'btnDividir
        '
        Me.btnDividir.Location = New System.Drawing.Point(749, 458)
        Me.btnDividir.Margin = New System.Windows.Forms.Padding(4)
        Me.btnDividir.Name = "btnDividir"
        Me.btnDividir.Size = New System.Drawing.Size(203, 39)
        Me.btnDividir.TabIndex = 18
        Me.btnDividir.Text = "Dividir"
        Me.btnDividir.UseVisualStyleBackColor = True
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(13.0!, 32.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1058, 576)
        Me.Controls.Add(Me.btnDividir)
        Me.Controls.Add(Me.btnMultiplicar)
        Me.Controls.Add(Me.btnSubtrair)
        Me.Controls.Add(Me.btnSomar)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.txtN2)
        Me.Controls.Add(Me.txtN1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form4"
        Me.Text = "Form4"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtN1 As TextBox
    Friend WithEvents txtN2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btnSomar As Button
    Friend WithEvents btnSubtrair As Button
    Friend WithEvents btnMultiplicar As Button
    Friend WithEvents btnDividir As Button
End Class
