<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Odontograma
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim CODIGO_ODONTOGRAMALabel As System.Windows.Forms.Label
        Dim DIENTES_SANOSLabel As System.Windows.Forms.Label
        Dim DIENTES_CARIADOSLabel As System.Windows.Forms.Label
        Dim DIENTES_OBTURADOSLabel As System.Windows.Forms.Label
        Dim DIENTES_PERDIDOSLabel As System.Windows.Forms.Label
        Dim OTROSLabel As System.Windows.Forms.Label
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CODIGO_ODONTOGRAMATextBox = New System.Windows.Forms.TextBox()
        Me.DIENTES_SANOSTextBox = New System.Windows.Forms.TextBox()
        Me.DIENTES_CARIADOSTextBox = New System.Windows.Forms.TextBox()
        Me.DIENTES_OBTURADOSTextBox = New System.Windows.Forms.TextBox()
        Me.DIENTES_PERDIDOSTextBox = New System.Windows.Forms.TextBox()
        Me.OTROSTextBox = New System.Windows.Forms.TextBox()
        Me.INSERTAR = New System.Windows.Forms.Button()
        Me.EDITAR = New System.Windows.Forms.Button()
        Me.ELIMINAR = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MENUToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CONSULTA = New System.Windows.Forms.ToolStripMenuItem()
        Me.ESTUDIANTEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ANAMNESIS = New System.Windows.Forms.ToolStripMenuItem()
        Me.EXAMENFISICOESTOMATOLOGICOToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DIAGNOSTICO = New System.Windows.Forms.ToolStripMenuItem()
        Me.REGISTRODIARIOToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SALIRToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip2 = New System.Windows.Forms.MenuStrip()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.IMAGENDEFONDOToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CambiarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LUGARToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CENTROToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.COMPLETAToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ZOOMToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GUARDARCAMBIOSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OCULTARToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.l = New System.Windows.Forms.OpenFileDialog()
        Me.CONSULTADataGridView = New System.Windows.Forms.DataGridView()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.TB = New System.Windows.Forms.ToolStripMenuItem()
        CODIGO_ODONTOGRAMALabel = New System.Windows.Forms.Label()
        DIENTES_SANOSLabel = New System.Windows.Forms.Label()
        DIENTES_CARIADOSLabel = New System.Windows.Forms.Label()
        DIENTES_OBTURADOSLabel = New System.Windows.Forms.Label()
        DIENTES_PERDIDOSLabel = New System.Windows.Forms.Label()
        OTROSLabel = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.MenuStrip2.SuspendLayout()
        CType(Me.CONSULTADataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'CODIGO_ODONTOGRAMALabel
        '
        CODIGO_ODONTOGRAMALabel.AutoSize = True
        CODIGO_ODONTOGRAMALabel.BackColor = System.Drawing.Color.Transparent
        CODIGO_ODONTOGRAMALabel.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        CODIGO_ODONTOGRAMALabel.Location = New System.Drawing.Point(372, 223)
        CODIGO_ODONTOGRAMALabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        CODIGO_ODONTOGRAMALabel.Name = "CODIGO_ODONTOGRAMALabel"
        CODIGO_ODONTOGRAMALabel.Size = New System.Drawing.Size(150, 15)
        CODIGO_ODONTOGRAMALabel.TabIndex = 61
        CODIGO_ODONTOGRAMALabel.Text = "CODIGO ODONTOGRAMA:"
        '
        'DIENTES_SANOSLabel
        '
        DIENTES_SANOSLabel.AutoSize = True
        DIENTES_SANOSLabel.BackColor = System.Drawing.Color.Transparent
        DIENTES_SANOSLabel.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        DIENTES_SANOSLabel.Location = New System.Drawing.Point(376, 314)
        DIENTES_SANOSLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        DIENTES_SANOSLabel.Name = "DIENTES_SANOSLabel"
        DIENTES_SANOSLabel.Size = New System.Drawing.Size(102, 15)
        DIENTES_SANOSLabel.TabIndex = 62
        DIENTES_SANOSLabel.Text = "DIENTES SANOS:"
        '
        'DIENTES_CARIADOSLabel
        '
        DIENTES_CARIADOSLabel.AutoSize = True
        DIENTES_CARIADOSLabel.BackColor = System.Drawing.Color.Transparent
        DIENTES_CARIADOSLabel.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        DIENTES_CARIADOSLabel.Location = New System.Drawing.Point(376, 402)
        DIENTES_CARIADOSLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        DIENTES_CARIADOSLabel.Name = "DIENTES_CARIADOSLabel"
        DIENTES_CARIADOSLabel.Size = New System.Drawing.Size(121, 15)
        DIENTES_CARIADOSLabel.TabIndex = 63
        DIENTES_CARIADOSLabel.Text = "DIENTES CARIADOS:"
        '
        'DIENTES_OBTURADOSLabel
        '
        DIENTES_OBTURADOSLabel.AutoSize = True
        DIENTES_OBTURADOSLabel.BackColor = System.Drawing.Color.Transparent
        DIENTES_OBTURADOSLabel.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        DIENTES_OBTURADOSLabel.Location = New System.Drawing.Point(784, 218)
        DIENTES_OBTURADOSLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        DIENTES_OBTURADOSLabel.Name = "DIENTES_OBTURADOSLabel"
        DIENTES_OBTURADOSLabel.Size = New System.Drawing.Size(134, 15)
        DIENTES_OBTURADOSLabel.TabIndex = 64
        DIENTES_OBTURADOSLabel.Text = "DIENTES OBTURADOS:"
        '
        'DIENTES_PERDIDOSLabel
        '
        DIENTES_PERDIDOSLabel.AutoSize = True
        DIENTES_PERDIDOSLabel.BackColor = System.Drawing.Color.Transparent
        DIENTES_PERDIDOSLabel.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        DIENTES_PERDIDOSLabel.Location = New System.Drawing.Point(798, 310)
        DIENTES_PERDIDOSLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        DIENTES_PERDIDOSLabel.Name = "DIENTES_PERDIDOSLabel"
        DIENTES_PERDIDOSLabel.Size = New System.Drawing.Size(120, 15)
        DIENTES_PERDIDOSLabel.TabIndex = 65
        DIENTES_PERDIDOSLabel.Text = "DIENTES PERDIDOS:"
        '
        'OTROSLabel
        '
        OTROSLabel.AutoSize = True
        OTROSLabel.BackColor = System.Drawing.Color.Transparent
        OTROSLabel.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        OTROSLabel.Location = New System.Drawing.Point(819, 398)
        OTROSLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        OTROSLabel.Name = "OTROSLabel"
        OTROSLabel.Size = New System.Drawing.Size(51, 15)
        OTROSLabel.TabIndex = 66
        OTROSLabel.Text = "OTROS:"
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(573, 12)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(287, 37)
        Me.Label1.TabIndex = 60
        Me.Label1.Text = "ODONTOGRAMA"
        '
        'CODIGO_ODONTOGRAMATextBox
        '
        Me.CODIGO_ODONTOGRAMATextBox.Location = New System.Drawing.Point(544, 219)
        Me.CODIGO_ODONTOGRAMATextBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.CODIGO_ODONTOGRAMATextBox.Name = "CODIGO_ODONTOGRAMATextBox"
        Me.CODIGO_ODONTOGRAMATextBox.Size = New System.Drawing.Size(116, 23)
        Me.CODIGO_ODONTOGRAMATextBox.TabIndex = 62
        '
        'DIENTES_SANOSTextBox
        '
        Me.DIENTES_SANOSTextBox.Location = New System.Drawing.Point(496, 310)
        Me.DIENTES_SANOSTextBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.DIENTES_SANOSTextBox.Name = "DIENTES_SANOSTextBox"
        Me.DIENTES_SANOSTextBox.Size = New System.Drawing.Size(116, 23)
        Me.DIENTES_SANOSTextBox.TabIndex = 63
        '
        'DIENTES_CARIADOSTextBox
        '
        Me.DIENTES_CARIADOSTextBox.Location = New System.Drawing.Point(517, 398)
        Me.DIENTES_CARIADOSTextBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.DIENTES_CARIADOSTextBox.Name = "DIENTES_CARIADOSTextBox"
        Me.DIENTES_CARIADOSTextBox.Size = New System.Drawing.Size(116, 23)
        Me.DIENTES_CARIADOSTextBox.TabIndex = 64
        '
        'DIENTES_OBTURADOSTextBox
        '
        Me.DIENTES_OBTURADOSTextBox.Location = New System.Drawing.Point(940, 215)
        Me.DIENTES_OBTURADOSTextBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.DIENTES_OBTURADOSTextBox.Name = "DIENTES_OBTURADOSTextBox"
        Me.DIENTES_OBTURADOSTextBox.Size = New System.Drawing.Size(116, 23)
        Me.DIENTES_OBTURADOSTextBox.TabIndex = 65
        '
        'DIENTES_PERDIDOSTextBox
        '
        Me.DIENTES_PERDIDOSTextBox.Location = New System.Drawing.Point(940, 307)
        Me.DIENTES_PERDIDOSTextBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.DIENTES_PERDIDOSTextBox.Name = "DIENTES_PERDIDOSTextBox"
        Me.DIENTES_PERDIDOSTextBox.Size = New System.Drawing.Size(116, 23)
        Me.DIENTES_PERDIDOSTextBox.TabIndex = 66
        '
        'OTROSTextBox
        '
        Me.OTROSTextBox.Location = New System.Drawing.Point(882, 395)
        Me.OTROSTextBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.OTROSTextBox.Name = "OTROSTextBox"
        Me.OTROSTextBox.Size = New System.Drawing.Size(116, 23)
        Me.OTROSTextBox.TabIndex = 67
        '
        'INSERTAR
        '
        Me.INSERTAR.AutoSize = True
        Me.INSERTAR.BackColor = System.Drawing.Color.MediumPurple
        Me.INSERTAR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.INSERTAR.Cursor = System.Windows.Forms.Cursors.Hand
        Me.INSERTAR.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.INSERTAR.FlatAppearance.BorderSize = 0
        Me.INSERTAR.FlatAppearance.CheckedBackColor = System.Drawing.Color.Blue
        Me.INSERTAR.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.INSERTAR.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.INSERTAR.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.INSERTAR.ForeColor = System.Drawing.Color.White
        Me.INSERTAR.Location = New System.Drawing.Point(814, 509)
        Me.INSERTAR.Margin = New System.Windows.Forms.Padding(0)
        Me.INSERTAR.Name = "INSERTAR"
        Me.INSERTAR.Size = New System.Drawing.Size(120, 37)
        Me.INSERTAR.TabIndex = 121
        Me.INSERTAR.Text = "INSERTAR"
        Me.INSERTAR.UseVisualStyleBackColor = False
        '
        'EDITAR
        '
        Me.EDITAR.AutoSize = True
        Me.EDITAR.BackColor = System.Drawing.Color.MediumPurple
        Me.EDITAR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.EDITAR.Cursor = System.Windows.Forms.Cursors.Hand
        Me.EDITAR.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.EDITAR.FlatAppearance.BorderSize = 0
        Me.EDITAR.FlatAppearance.CheckedBackColor = System.Drawing.Color.Blue
        Me.EDITAR.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.EDITAR.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.EDITAR.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.EDITAR.ForeColor = System.Drawing.Color.White
        Me.EDITAR.Location = New System.Drawing.Point(651, 509)
        Me.EDITAR.Margin = New System.Windows.Forms.Padding(0)
        Me.EDITAR.Name = "EDITAR"
        Me.EDITAR.Size = New System.Drawing.Size(120, 37)
        Me.EDITAR.TabIndex = 120
        Me.EDITAR.Text = "EDITAR"
        Me.EDITAR.UseVisualStyleBackColor = False
        '
        'ELIMINAR
        '
        Me.ELIMINAR.AutoSize = True
        Me.ELIMINAR.BackColor = System.Drawing.Color.MediumPurple
        Me.ELIMINAR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ELIMINAR.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ELIMINAR.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.ELIMINAR.FlatAppearance.BorderSize = 0
        Me.ELIMINAR.FlatAppearance.CheckedBackColor = System.Drawing.Color.Blue
        Me.ELIMINAR.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.ELIMINAR.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ELIMINAR.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.ELIMINAR.ForeColor = System.Drawing.Color.White
        Me.ELIMINAR.Location = New System.Drawing.Point(957, 509)
        Me.ELIMINAR.Margin = New System.Windows.Forms.Padding(0)
        Me.ELIMINAR.Name = "ELIMINAR"
        Me.ELIMINAR.Size = New System.Drawing.Size(120, 37)
        Me.ELIMINAR.TabIndex = 119
        Me.ELIMINAR.Text = "ELIMINAR"
        Me.ELIMINAR.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.AutoSize = True
        Me.Button2.BackColor = System.Drawing.Color.MediumPurple
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatAppearance.CheckedBackColor = System.Drawing.Color.Blue
        Me.Button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button2.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(495, 509)
        Me.Button2.Margin = New System.Windows.Forms.Padding(0)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(120, 37)
        Me.Button2.TabIndex = 118
        Me.Button2.Text = "LIMPIAR"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.AutoSize = True
        Me.Button1.BackColor = System.Drawing.Color.MediumPurple
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.CheckedBackColor = System.Drawing.Color.Blue
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button1.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(350, 509)
        Me.Button1.Margin = New System.Windows.Forms.Padding(0)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(120, 37)
        Me.Button1.TabIndex = 117
        Me.Button1.Text = "BUSCAR"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.MenuStrip1.BackColor = System.Drawing.Color.Transparent
        Me.MenuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.MenuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MENUToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(21, 21)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(4, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(67, 24)
        Me.MenuStrip1.TabIndex = 122
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MENUToolStripMenuItem
        '
        Me.MENUToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CONSULTA, Me.ESTUDIANTEToolStripMenuItem, Me.ANAMNESIS, Me.EXAMENFISICOESTOMATOLOGICOToolStripMenuItem, Me.DIAGNOSTICO, Me.REGISTRODIARIOToolStripMenuItem, Me.SALIRToolStripMenuItem})
        Me.MENUToolStripMenuItem.Name = "MENUToolStripMenuItem"
        Me.MENUToolStripMenuItem.Size = New System.Drawing.Size(54, 20)
        Me.MENUToolStripMenuItem.Text = "MENU"
        '
        'CONSULTA
        '
        Me.CONSULTA.Name = "CONSULTA"
        Me.CONSULTA.Size = New System.Drawing.Size(272, 22)
        Me.CONSULTA.Text = "CONSULTA"
        '
        'ESTUDIANTEToolStripMenuItem
        '
        Me.ESTUDIANTEToolStripMenuItem.Name = "ESTUDIANTEToolStripMenuItem"
        Me.ESTUDIANTEToolStripMenuItem.Size = New System.Drawing.Size(272, 22)
        Me.ESTUDIANTEToolStripMenuItem.Text = "ESTUDIANTE"
        '
        'ANAMNESIS
        '
        Me.ANAMNESIS.Name = "ANAMNESIS"
        Me.ANAMNESIS.Size = New System.Drawing.Size(272, 22)
        Me.ANAMNESIS.Text = "ANAMNESIS"
        '
        'EXAMENFISICOESTOMATOLOGICOToolStripMenuItem
        '
        Me.EXAMENFISICOESTOMATOLOGICOToolStripMenuItem.Name = "EXAMENFISICOESTOMATOLOGICOToolStripMenuItem"
        Me.EXAMENFISICOESTOMATOLOGICOToolStripMenuItem.Size = New System.Drawing.Size(272, 22)
        Me.EXAMENFISICOESTOMATOLOGICOToolStripMenuItem.Text = "EXAMEN FISICO ESTOMATOLOGICO"
        '
        'DIAGNOSTICO
        '
        Me.DIAGNOSTICO.Name = "DIAGNOSTICO"
        Me.DIAGNOSTICO.Size = New System.Drawing.Size(272, 22)
        Me.DIAGNOSTICO.Text = "DIAGNOSTICO"
        '
        'REGISTRODIARIOToolStripMenuItem
        '
        Me.REGISTRODIARIOToolStripMenuItem.Name = "REGISTRODIARIOToolStripMenuItem"
        Me.REGISTRODIARIOToolStripMenuItem.Size = New System.Drawing.Size(272, 22)
        Me.REGISTRODIARIOToolStripMenuItem.Text = "REGISTRO DIARIO"
        '
        'SALIRToolStripMenuItem
        '
        Me.SALIRToolStripMenuItem.Name = "SALIRToolStripMenuItem"
        Me.SALIRToolStripMenuItem.Size = New System.Drawing.Size(272, 22)
        Me.SALIRToolStripMenuItem.Text = "SALIR"
        '
        'MenuStrip2
        '
        Me.MenuStrip2.BackColor = System.Drawing.Color.Transparent
        Me.MenuStrip2.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1})
        Me.MenuStrip2.Location = New System.Drawing.Point(226, 35)
        Me.MenuStrip2.Name = "MenuStrip2"
        Me.MenuStrip2.Padding = New System.Windows.Forms.Padding(7, 2, 0, 2)
        Me.MenuStrip2.Size = New System.Drawing.Size(158, 26)
        Me.MenuStrip2.TabIndex = 123
        Me.MenuStrip2.Text = "MenuStrip2"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.BackColor = System.Drawing.Color.Transparent
        Me.ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.IMAGENDEFONDOToolStripMenuItem, Me.GUARDARCAMBIOSToolStripMenuItem, Me.OCULTARToolStripMenuItem})
        Me.ToolStripMenuItem1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(149, 22)
        Me.ToolStripMenuItem1.Text = "HERRAMIENTAS"
        '
        'IMAGENDEFONDOToolStripMenuItem
        '
        Me.IMAGENDEFONDOToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CambiarToolStripMenuItem, Me.LUGARToolStripMenuItem})
        Me.IMAGENDEFONDOToolStripMenuItem.Name = "IMAGENDEFONDOToolStripMenuItem"
        Me.IMAGENDEFONDOToolStripMenuItem.Size = New System.Drawing.Size(237, 22)
        Me.IMAGENDEFONDOToolStripMenuItem.Text = "IMAGEN DE FONDO"
        '
        'CambiarToolStripMenuItem
        '
        Me.CambiarToolStripMenuItem.Name = "CambiarToolStripMenuItem"
        Me.CambiarToolStripMenuItem.Size = New System.Drawing.Size(149, 22)
        Me.CambiarToolStripMenuItem.Text = "CAMBIAR"
        '
        'LUGARToolStripMenuItem
        '
        Me.LUGARToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CENTROToolStripMenuItem, Me.COMPLETAToolStripMenuItem, Me.ZOOMToolStripMenuItem})
        Me.LUGARToolStripMenuItem.Name = "LUGARToolStripMenuItem"
        Me.LUGARToolStripMenuItem.Size = New System.Drawing.Size(149, 22)
        Me.LUGARToolStripMenuItem.Text = "LUGAR"
        '
        'CENTROToolStripMenuItem
        '
        Me.CENTROToolStripMenuItem.Name = "CENTROToolStripMenuItem"
        Me.CENTROToolStripMenuItem.Size = New System.Drawing.Size(166, 22)
        Me.CENTROToolStripMenuItem.Text = "CENTRO"
        '
        'COMPLETAToolStripMenuItem
        '
        Me.COMPLETAToolStripMenuItem.Name = "COMPLETAToolStripMenuItem"
        Me.COMPLETAToolStripMenuItem.Size = New System.Drawing.Size(166, 22)
        Me.COMPLETAToolStripMenuItem.Text = "COMPLETA"
        '
        'ZOOMToolStripMenuItem
        '
        Me.ZOOMToolStripMenuItem.Name = "ZOOMToolStripMenuItem"
        Me.ZOOMToolStripMenuItem.Size = New System.Drawing.Size(166, 22)
        Me.ZOOMToolStripMenuItem.Text = "ZOOM"
        '
        'GUARDARCAMBIOSToolStripMenuItem
        '
        Me.GUARDARCAMBIOSToolStripMenuItem.Name = "GUARDARCAMBIOSToolStripMenuItem"
        Me.GUARDARCAMBIOSToolStripMenuItem.Size = New System.Drawing.Size(237, 22)
        Me.GUARDARCAMBIOSToolStripMenuItem.Text = "GUARDAR CAMBIOS"
        '
        'OCULTARToolStripMenuItem
        '
        Me.OCULTARToolStripMenuItem.Name = "OCULTARToolStripMenuItem"
        Me.OCULTARToolStripMenuItem.Size = New System.Drawing.Size(237, 22)
        Me.OCULTARToolStripMenuItem.Text = "OCULTAR"
        '
        'l
        '
        Me.l.FileName = "OpenFileDialog1"
        '
        'CONSULTADataGridView
        '
        Me.CONSULTADataGridView.AllowUserToAddRows = False
        Me.CONSULTADataGridView.AllowUserToDeleteRows = False
        Me.CONSULTADataGridView.AllowUserToResizeColumns = False
        Me.CONSULTADataGridView.AllowUserToResizeRows = False
        Me.CONSULTADataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.CONSULTADataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.CONSULTADataGridView.BackgroundColor = System.Drawing.Color.White
        Me.CONSULTADataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.CONSULTADataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.CONSULTADataGridView.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable
        Me.CONSULTADataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.LightSteelBlue
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.HotTrack
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        Me.CONSULTADataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.CONSULTADataGridView.ColumnHeadersHeight = 20
        Me.CONSULTADataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.CONSULTADataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.CONSULTADataGridView.EnableHeadersVisualStyles = False
        Me.CONSULTADataGridView.GridColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.CONSULTADataGridView.Location = New System.Drawing.Point(252, 680)
        Me.CONSULTADataGridView.Margin = New System.Windows.Forms.Padding(0)
        Me.CONSULTADataGridView.Name = "CONSULTADataGridView"
        Me.CONSULTADataGridView.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CONSULTADataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        Me.CONSULTADataGridView.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.CONSULTADataGridView.RowHeadersVisible = False
        Me.CONSULTADataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        Me.CONSULTADataGridView.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.CONSULTADataGridView.ShowEditingIcon = False
        Me.CONSULTADataGridView.Size = New System.Drawing.Size(933, 80)
        Me.CONSULTADataGridView.TabIndex = 131
        Me.CONSULTADataGridView.VirtualMode = True
        Me.CONSULTADataGridView.Visible = False
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TB})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(168, 26)
        '
        'TB
        '
        Me.TB.Name = "TB"
        Me.TB.Size = New System.Drawing.Size(167, 22)
        Me.TB.Text = "MOSTRAR TABLA"
        '
        'Odontograma
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1256, 772)
        Me.ContextMenuStrip = Me.ContextMenuStrip1
        Me.Controls.Add(Me.CONSULTADataGridView)
        Me.Controls.Add(Me.MenuStrip2)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.INSERTAR)
        Me.Controls.Add(Me.EDITAR)
        Me.Controls.Add(Me.ELIMINAR)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(OTROSLabel)
        Me.Controls.Add(Me.OTROSTextBox)
        Me.Controls.Add(DIENTES_PERDIDOSLabel)
        Me.Controls.Add(Me.DIENTES_PERDIDOSTextBox)
        Me.Controls.Add(DIENTES_OBTURADOSLabel)
        Me.Controls.Add(Me.DIENTES_OBTURADOSTextBox)
        Me.Controls.Add(DIENTES_CARIADOSLabel)
        Me.Controls.Add(Me.DIENTES_CARIADOSTextBox)
        Me.Controls.Add(DIENTES_SANOSLabel)
        Me.Controls.Add(Me.DIENTES_SANOSTextBox)
        Me.Controls.Add(CODIGO_ODONTOGRAMALabel)
        Me.Controls.Add(Me.CODIGO_ODONTOGRAMATextBox)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "Odontograma"
        Me.Text = "Form6"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.MenuStrip2.ResumeLayout(False)
        Me.MenuStrip2.PerformLayout()
        CType(Me.CONSULTADataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CODIGO_ODONTOGRAMATextBox As System.Windows.Forms.TextBox
    Friend WithEvents DIENTES_SANOSTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DIENTES_CARIADOSTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DIENTES_OBTURADOSTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DIENTES_PERDIDOSTextBox As System.Windows.Forms.TextBox
    Friend WithEvents OTROSTextBox As System.Windows.Forms.TextBox
    Friend WithEvents INSERTAR As System.Windows.Forms.Button
    Friend WithEvents EDITAR As System.Windows.Forms.Button
    Friend WithEvents ELIMINAR As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents MENUToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CONSULTA As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ESTUDIANTEToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents REGISTRODIARIOToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EXAMENFISICOESTOMATOLOGICOToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DIAGNOSTICO As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ANAMNESIS As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SALIRToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuStrip2 As System.Windows.Forms.MenuStrip
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents IMAGENDEFONDOToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CambiarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LUGARToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CENTROToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents COMPLETAToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ZOOMToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GUARDARCAMBIOSToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OCULTARToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents l As System.Windows.Forms.OpenFileDialog
    Friend WithEvents CONSULTADataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents TB As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CODIGOODONTOGRAMADataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DIENTESSANOSDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DIENTESCARIADOSDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DIENTESOBTURADOSDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DIENTESPERDIDOSDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents OTROSDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
