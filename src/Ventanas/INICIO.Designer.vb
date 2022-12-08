<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class INICIO
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(INICIO))
        Me.Pb = New System.Windows.Forms.ProgressBar()
        Me.T1 = New System.Windows.Forms.Timer(Me.components)
        Me.T2 = New System.Windows.Forms.Timer(Me.components)
        Me.Lb = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Pb
        '
        Me.Pb.BackColor = System.Drawing.Color.LightGray
        Me.Pb.Cursor = System.Windows.Forms.Cursors.AppStarting
        Me.Pb.ForeColor = System.Drawing.Color.Transparent
        Me.Pb.Location = New System.Drawing.Point(169, 306)
        Me.Pb.Margin = New System.Windows.Forms.Padding(0)
        Me.Pb.Name = "Pb"
        Me.Pb.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Pb.Size = New System.Drawing.Size(626, 30)
        Me.Pb.TabIndex = 0
        '
        'T1
        '
        '
        'T2
        '
        '
        'Lb
        '
        Me.Lb.AutoSize = True
        Me.Lb.BackColor = System.Drawing.Color.Silver
        Me.Lb.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Lb.Location = New System.Drawing.Point(384, 336)
        Me.Lb.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Lb.Name = "Lb"
        Me.Lb.Size = New System.Drawing.Size(0, 18)
        Me.Lb.TabIndex = 1
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(150, 28)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(650, 400)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'INICIO
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(987, 434)
        Me.Controls.Add(Me.Lb)
        Me.Controls.Add(Me.Pb)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "INICIO"
        Me.Text = "INICIO"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Public WithEvents Pb As System.Windows.Forms.ProgressBar
    Friend WithEvents T1 As System.Windows.Forms.Timer
    Friend WithEvents T2 As System.Windows.Forms.Timer
    Friend WithEvents Lb As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
