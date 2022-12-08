<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Anamnesis
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
        Dim CODIG_ANAMNESISLabel As System.Windows.Forms.Label
        Dim TRATAMIENTO_MEDICOLabel As System.Windows.Forms.Label
        Dim ENFERMEDADLabel As System.Windows.Forms.Label
        Dim INGESTION_DE_MEDICAMENTOSLabel As System.Windows.Forms.Label
        Dim OBSERVACIONESLabel As System.Windows.Forms.Label
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.CODIGO_ANAMNESISTextBox = New System.Windows.Forms.TextBox()
        Me.TRATAMIENTO_MEDICOTextBox = New System.Windows.Forms.TextBox()
        Me.ENFERMEDADTextBox = New System.Windows.Forms.TextBox()
        Me.INGESTION_DE_MEDICAMENTOSTextBox = New System.Windows.Forms.TextBox()
        Me.OBSERVACIONESTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MENUToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CONSULTA = New System.Windows.Forms.ToolStripMenuItem()
        Me.ESTUDIANTEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DIAGNOSTICOToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EXAMENFISICOESTOMATOLOGICOToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ODOTOGRAMAToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.REGISTRODIARIOToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SALIRToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.INSERTAR = New System.Windows.Forms.Button()
        Me.EDITAR = New System.Windows.Forms.Button()
        Me.ELIMINAR = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.l = New System.Windows.Forms.OpenFileDialog()
        Me.MenuStrip2 = New System.Windows.Forms.MenuStrip()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.IMAGENDEFONDOToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CambiarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LUGARToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CENTROToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.COMPLETAToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ZOOMToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CAMBIARPOSICIONToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TITULO = New System.Windows.Forms.ToolStripMenuItem()
        Me.GUARDARCAMBIOSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OCULTARToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CONSULTADataGridView = New System.Windows.Forms.DataGridView()
        Me.DERH = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.TB = New System.Windows.Forms.ToolStripMenuItem()
        CODIG_ANAMNESISLabel = New System.Windows.Forms.Label()
        TRATAMIENTO_MEDICOLabel = New System.Windows.Forms.Label()
        ENFERMEDADLabel = New System.Windows.Forms.Label()
        INGESTION_DE_MEDICAMENTOSLabel = New System.Windows.Forms.Label()
        OBSERVACIONESLabel = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.MenuStrip2.SuspendLayout()
        CType(Me.CONSULTADataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DERH.SuspendLayout()
        Me.SuspendLayout()
        '
        'CODIG_ANAMNESISLabel
        '
        CODIG_ANAMNESISLabel.AutoSize = True
        CODIG_ANAMNESISLabel.BackColor = System.Drawing.Color.Transparent
        CODIG_ANAMNESISLabel.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        CODIG_ANAMNESISLabel.ForeColor = System.Drawing.Color.Black
        CODIG_ANAMNESISLabel.Location = New System.Drawing.Point(586, 144)
        CODIG_ANAMNESISLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        CODIG_ANAMNESISLabel.Name = "CODIG_ANAMNESISLabel"
        CODIG_ANAMNESISLabel.Size = New System.Drawing.Size(126, 15)
        CODIG_ANAMNESISLabel.TabIndex = 1
        CODIG_ANAMNESISLabel.Text = "CODIGO ANAMNESIS:"
        AddHandler CODIG_ANAMNESISLabel.Click, AddressOf Me.CODIG_ANAMNESISLabel_Click
        '
        'TRATAMIENTO_MEDICOLabel
        '
        TRATAMIENTO_MEDICOLabel.AutoSize = True
        TRATAMIENTO_MEDICOLabel.BackColor = System.Drawing.Color.Transparent
        TRATAMIENTO_MEDICOLabel.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        TRATAMIENTO_MEDICOLabel.ForeColor = System.Drawing.Color.Black
        TRATAMIENTO_MEDICOLabel.Location = New System.Drawing.Point(323, 249)
        TRATAMIENTO_MEDICOLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        TRATAMIENTO_MEDICOLabel.Name = "TRATAMIENTO_MEDICOLabel"
        TRATAMIENTO_MEDICOLabel.Size = New System.Drawing.Size(138, 15)
        TRATAMIENTO_MEDICOLabel.TabIndex = 3
        TRATAMIENTO_MEDICOLabel.Text = "TRATAMIENTO MEDICO:"
        '
        'ENFERMEDADLabel
        '
        ENFERMEDADLabel.AutoSize = True
        ENFERMEDADLabel.BackColor = System.Drawing.Color.Transparent
        ENFERMEDADLabel.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        ENFERMEDADLabel.ForeColor = System.Drawing.Color.Black
        ENFERMEDADLabel.Location = New System.Drawing.Point(323, 307)
        ENFERMEDADLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        ENFERMEDADLabel.Name = "ENFERMEDADLabel"
        ENFERMEDADLabel.Size = New System.Drawing.Size(87, 15)
        ENFERMEDADLabel.TabIndex = 5
        ENFERMEDADLabel.Text = "ENFERMEDAD:"
        '
        'INGESTION_DE_MEDICAMENTOSLabel
        '
        INGESTION_DE_MEDICAMENTOSLabel.AutoSize = True
        INGESTION_DE_MEDICAMENTOSLabel.BackColor = System.Drawing.Color.Transparent
        INGESTION_DE_MEDICAMENTOSLabel.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        INGESTION_DE_MEDICAMENTOSLabel.ForeColor = System.Drawing.Color.Black
        INGESTION_DE_MEDICAMENTOSLabel.Location = New System.Drawing.Point(820, 249)
        INGESTION_DE_MEDICAMENTOSLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        INGESTION_DE_MEDICAMENTOSLabel.Name = "INGESTION_DE_MEDICAMENTOSLabel"
        INGESTION_DE_MEDICAMENTOSLabel.Size = New System.Drawing.Size(185, 15)
        INGESTION_DE_MEDICAMENTOSLabel.TabIndex = 7
        INGESTION_DE_MEDICAMENTOSLabel.Text = "INGESTION DE MEDICAMENTOS:"
        '
        'OBSERVACIONESLabel
        '
        OBSERVACIONESLabel.AutoSize = True
        OBSERVACIONESLabel.BackColor = System.Drawing.Color.Transparent
        OBSERVACIONESLabel.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        OBSERVACIONESLabel.ForeColor = System.Drawing.Color.Black
        OBSERVACIONESLabel.Location = New System.Drawing.Point(820, 307)
        OBSERVACIONESLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        OBSERVACIONESLabel.Name = "OBSERVACIONESLabel"
        OBSERVACIONESLabel.Size = New System.Drawing.Size(108, 15)
        OBSERVACIONESLabel.TabIndex = 9
        OBSERVACIONESLabel.Text = "OBSERVACIONES:"
        '
        'CODIGO_ANAMNESISTextBox
        '
        Me.CODIGO_ANAMNESISTextBox.Location = New System.Drawing.Point(730, 141)
        Me.CODIGO_ANAMNESISTextBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.CODIGO_ANAMNESISTextBox.Name = "CODIGO_ANAMNESISTextBox"
        Me.CODIGO_ANAMNESISTextBox.Size = New System.Drawing.Size(116, 23)
        Me.CODIGO_ANAMNESISTextBox.TabIndex = 2
        '
        'TRATAMIENTO_MEDICOTextBox
        '
        Me.TRATAMIENTO_MEDICOTextBox.Location = New System.Drawing.Point(485, 246)
        Me.TRATAMIENTO_MEDICOTextBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TRATAMIENTO_MEDICOTextBox.Name = "TRATAMIENTO_MEDICOTextBox"
        Me.TRATAMIENTO_MEDICOTextBox.Size = New System.Drawing.Size(152, 23)
        Me.TRATAMIENTO_MEDICOTextBox.TabIndex = 4
        '
        'ENFERMEDADTextBox
        '
        Me.ENFERMEDADTextBox.Location = New System.Drawing.Point(430, 303)
        Me.ENFERMEDADTextBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.ENFERMEDADTextBox.Name = "ENFERMEDADTextBox"
        Me.ENFERMEDADTextBox.Size = New System.Drawing.Size(207, 23)
        Me.ENFERMEDADTextBox.TabIndex = 6
        '
        'INGESTION_DE_MEDICAMENTOSTextBox
        '
        Me.INGESTION_DE_MEDICAMENTOSTextBox.Location = New System.Drawing.Point(1034, 246)
        Me.INGESTION_DE_MEDICAMENTOSTextBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.INGESTION_DE_MEDICAMENTOSTextBox.Name = "INGESTION_DE_MEDICAMENTOSTextBox"
        Me.INGESTION_DE_MEDICAMENTOSTextBox.Size = New System.Drawing.Size(116, 23)
        Me.INGESTION_DE_MEDICAMENTOSTextBox.TabIndex = 8
        '
        'OBSERVACIONESTextBox
        '
        Me.OBSERVACIONESTextBox.Location = New System.Drawing.Point(945, 303)
        Me.OBSERVACIONESTextBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.OBSERVACIONESTextBox.Name = "OBSERVACIONESTextBox"
        Me.OBSERVACIONESTextBox.Size = New System.Drawing.Size(205, 23)
        Me.OBSERVACIONESTextBox.TabIndex = 10
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Modern No. 20", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(610, -6)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(208, 34)
        Me.Label1.TabIndex = 58
        Me.Label1.Text = "ANAMNESIS"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MenuStrip1.BackColor = System.Drawing.Color.Transparent
        Me.MenuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.MenuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MENUToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(61, 32)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(4, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(67, 24)
        Me.MenuStrip1.TabIndex = 59
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MENUToolStripMenuItem
        '
        Me.MENUToolStripMenuItem.BackColor = System.Drawing.Color.Transparent
        Me.MENUToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CONSULTA, Me.ESTUDIANTEToolStripMenuItem, Me.DIAGNOSTICOToolStripMenuItem, Me.EXAMENFISICOESTOMATOLOGICOToolStripMenuItem, Me.ODOTOGRAMAToolStripMenuItem, Me.REGISTRODIARIOToolStripMenuItem, Me.SALIRToolStripMenuItem})
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
        'DIAGNOSTICOToolStripMenuItem
        '
        Me.DIAGNOSTICOToolStripMenuItem.Name = "DIAGNOSTICOToolStripMenuItem"
        Me.DIAGNOSTICOToolStripMenuItem.Size = New System.Drawing.Size(272, 22)
        Me.DIAGNOSTICOToolStripMenuItem.Text = "DIAGNOSTICO"
        '
        'EXAMENFISICOESTOMATOLOGICOToolStripMenuItem
        '
        Me.EXAMENFISICOESTOMATOLOGICOToolStripMenuItem.Name = "EXAMENFISICOESTOMATOLOGICOToolStripMenuItem"
        Me.EXAMENFISICOESTOMATOLOGICOToolStripMenuItem.Size = New System.Drawing.Size(272, 22)
        Me.EXAMENFISICOESTOMATOLOGICOToolStripMenuItem.Text = "EXAMEN FISICO ESTOMATOLOGICO"
        '
        'ODOTOGRAMAToolStripMenuItem
        '
        Me.ODOTOGRAMAToolStripMenuItem.Name = "ODOTOGRAMAToolStripMenuItem"
        Me.ODOTOGRAMAToolStripMenuItem.Size = New System.Drawing.Size(272, 22)
        Me.ODOTOGRAMAToolStripMenuItem.Text = "ODOTOGRAMA"
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
        'INSERTAR
        '
        Me.INSERTAR.AutoSize = True
        Me.INSERTAR.BackColor = System.Drawing.Color.SteelBlue
        Me.INSERTAR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.INSERTAR.Cursor = System.Windows.Forms.Cursors.Hand
        Me.INSERTAR.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.INSERTAR.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
        Me.INSERTAR.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.INSERTAR.ForeColor = System.Drawing.Color.White
        Me.INSERTAR.Location = New System.Drawing.Point(868, 422)
        Me.INSERTAR.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.INSERTAR.Name = "INSERTAR"
        Me.INSERTAR.Size = New System.Drawing.Size(120, 37)
        Me.INSERTAR.TabIndex = 111
        Me.INSERTAR.Text = "INSERTAR"
        Me.INSERTAR.UseVisualStyleBackColor = False
        '
        'EDITAR
        '
        Me.EDITAR.AutoSize = True
        Me.EDITAR.BackColor = System.Drawing.Color.SteelBlue
        Me.EDITAR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.EDITAR.Cursor = System.Windows.Forms.Cursors.Hand
        Me.EDITAR.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.EDITAR.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
        Me.EDITAR.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.EDITAR.ForeColor = System.Drawing.Color.White
        Me.EDITAR.Location = New System.Drawing.Point(674, 422)
        Me.EDITAR.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.EDITAR.Name = "EDITAR"
        Me.EDITAR.Size = New System.Drawing.Size(120, 37)
        Me.EDITAR.TabIndex = 110
        Me.EDITAR.Text = "EDITAR"
        Me.EDITAR.UseVisualStyleBackColor = False
        '
        'ELIMINAR
        '
        Me.ELIMINAR.AutoSize = True
        Me.ELIMINAR.BackColor = System.Drawing.Color.SteelBlue
        Me.ELIMINAR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ELIMINAR.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ELIMINAR.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.ELIMINAR.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
        Me.ELIMINAR.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.ELIMINAR.ForeColor = System.Drawing.Color.White
        Me.ELIMINAR.Location = New System.Drawing.Point(1091, 422)
        Me.ELIMINAR.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.ELIMINAR.Name = "ELIMINAR"
        Me.ELIMINAR.Size = New System.Drawing.Size(120, 37)
        Me.ELIMINAR.TabIndex = 109
        Me.ELIMINAR.Text = "ELIMINAR"
        Me.ELIMINAR.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.AutoSize = True
        Me.Button2.BackColor = System.Drawing.Color.SteelBlue
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
        Me.Button2.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(470, 422)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(120, 37)
        Me.Button2.TabIndex = 108
        Me.Button2.Text = "LIMPIAR"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.AutoSize = True
        Me.Button1.BackColor = System.Drawing.Color.SteelBlue
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
        Me.Button1.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(271, 422)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(120, 37)
        Me.Button1.TabIndex = 107
        Me.Button1.Text = "BUSCAR"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'l
        '
        Me.l.FileName = "OpenFileDialog1"
        '
        'MenuStrip2
        '
        Me.MenuStrip2.BackColor = System.Drawing.Color.Transparent
        Me.MenuStrip2.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1})
        Me.MenuStrip2.Location = New System.Drawing.Point(234, 32)
        Me.MenuStrip2.Name = "MenuStrip2"
        Me.MenuStrip2.Padding = New System.Windows.Forms.Padding(7, 2, 0, 2)
        Me.MenuStrip2.Size = New System.Drawing.Size(152, 27)
        Me.MenuStrip2.TabIndex = 113
        Me.MenuStrip2.Text = "MenuStrip2"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.BackColor = System.Drawing.Color.Transparent
        Me.ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.IMAGENDEFONDOToolStripMenuItem, Me.CAMBIARPOSICIONToolStripMenuItem, Me.GUARDARCAMBIOSToolStripMenuItem, Me.OCULTARToolStripMenuItem})
        Me.ToolStripMenuItem1.Font = New System.Drawing.Font("Bell MT", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(143, 23)
        Me.ToolStripMenuItem1.Text = "HERRAMIENTAS"
        '
        'IMAGENDEFONDOToolStripMenuItem
        '
        Me.IMAGENDEFONDOToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CambiarToolStripMenuItem, Me.LUGARToolStripMenuItem})
        Me.IMAGENDEFONDOToolStripMenuItem.Name = "IMAGENDEFONDOToolStripMenuItem"
        Me.IMAGENDEFONDOToolStripMenuItem.Size = New System.Drawing.Size(228, 24)
        Me.IMAGENDEFONDOToolStripMenuItem.Text = "IMAGEN DE FONDO"
        '
        'CambiarToolStripMenuItem
        '
        Me.CambiarToolStripMenuItem.Name = "CambiarToolStripMenuItem"
        Me.CambiarToolStripMenuItem.Size = New System.Drawing.Size(148, 24)
        Me.CambiarToolStripMenuItem.Text = "CAMBIAR"
        '
        'LUGARToolStripMenuItem
        '
        Me.LUGARToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CENTROToolStripMenuItem, Me.COMPLETAToolStripMenuItem, Me.ZOOMToolStripMenuItem})
        Me.LUGARToolStripMenuItem.Name = "LUGARToolStripMenuItem"
        Me.LUGARToolStripMenuItem.Size = New System.Drawing.Size(148, 24)
        Me.LUGARToolStripMenuItem.Text = "LUGAR"
        '
        'CENTROToolStripMenuItem
        '
        Me.CENTROToolStripMenuItem.Name = "CENTROToolStripMenuItem"
        Me.CENTROToolStripMenuItem.Size = New System.Drawing.Size(164, 24)
        Me.CENTROToolStripMenuItem.Text = "CENTRO"
        '
        'COMPLETAToolStripMenuItem
        '
        Me.COMPLETAToolStripMenuItem.Name = "COMPLETAToolStripMenuItem"
        Me.COMPLETAToolStripMenuItem.Size = New System.Drawing.Size(164, 24)
        Me.COMPLETAToolStripMenuItem.Text = "COMPLETA"
        '
        'ZOOMToolStripMenuItem
        '
        Me.ZOOMToolStripMenuItem.Name = "ZOOMToolStripMenuItem"
        Me.ZOOMToolStripMenuItem.Size = New System.Drawing.Size(164, 24)
        Me.ZOOMToolStripMenuItem.Text = "ZOOM"
        '
        'CAMBIARPOSICIONToolStripMenuItem
        '
        Me.CAMBIARPOSICIONToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TITULO})
        Me.CAMBIARPOSICIONToolStripMenuItem.Name = "CAMBIARPOSICIONToolStripMenuItem"
        Me.CAMBIARPOSICIONToolStripMenuItem.Size = New System.Drawing.Size(228, 24)
        Me.CAMBIARPOSICIONToolStripMenuItem.Text = "CAMBIAR POSICION"
        Me.CAMBIARPOSICIONToolStripMenuItem.Visible = False
        '
        'TITULO
        '
        Me.TITULO.Name = "TITULO"
        Me.TITULO.Size = New System.Drawing.Size(139, 24)
        Me.TITULO.Text = "TITULO"
        '
        'GUARDARCAMBIOSToolStripMenuItem
        '
        Me.GUARDARCAMBIOSToolStripMenuItem.Name = "GUARDARCAMBIOSToolStripMenuItem"
        Me.GUARDARCAMBIOSToolStripMenuItem.Size = New System.Drawing.Size(228, 24)
        Me.GUARDARCAMBIOSToolStripMenuItem.Text = "GUARDAR CAMBIOS"
        '
        'OCULTARToolStripMenuItem
        '
        Me.OCULTARToolStripMenuItem.Name = "OCULTARToolStripMenuItem"
        Me.OCULTARToolStripMenuItem.Size = New System.Drawing.Size(228, 24)
        Me.OCULTARToolStripMenuItem.Text = "OCULTAR"
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
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.HotTrack
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        Me.CONSULTADataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.CONSULTADataGridView.ColumnHeadersHeight = 20
        Me.CONSULTADataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.CONSULTADataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.CONSULTADataGridView.EnableHeadersVisualStyles = False
        Me.CONSULTADataGridView.GridColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.CONSULTADataGridView.Location = New System.Drawing.Point(324, 583)
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
        Me.CONSULTADataGridView.Size = New System.Drawing.Size(872, 72)
        Me.CONSULTADataGridView.TabIndex = 131
        Me.CONSULTADataGridView.VirtualMode = True
        Me.CONSULTADataGridView.Visible = False
        '
        'DERH
        '
        Me.DERH.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TB})
        Me.DERH.Name = "DERH"
        Me.DERH.Size = New System.Drawing.Size(168, 26)
        '
        'TB
        '
        Me.TB.Name = "TB"
        Me.TB.Size = New System.Drawing.Size(167, 22)
        Me.TB.Text = "MOSTRAR TABLA"
        '
        'Anamnesis
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1358, 772)
        Me.ContextMenuStrip = Me.DERH
        Me.Controls.Add(Me.CONSULTADataGridView)
        Me.Controls.Add(Me.INSERTAR)
        Me.Controls.Add(Me.EDITAR)
        Me.Controls.Add(Me.ELIMINAR)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.MenuStrip2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(OBSERVACIONESLabel)
        Me.Controls.Add(Me.OBSERVACIONESTextBox)
        Me.Controls.Add(INGESTION_DE_MEDICAMENTOSLabel)
        Me.Controls.Add(Me.INGESTION_DE_MEDICAMENTOSTextBox)
        Me.Controls.Add(ENFERMEDADLabel)
        Me.Controls.Add(Me.ENFERMEDADTextBox)
        Me.Controls.Add(TRATAMIENTO_MEDICOLabel)
        Me.Controls.Add(Me.TRATAMIENTO_MEDICOTextBox)
        Me.Controls.Add(CODIG_ANAMNESISLabel)
        Me.Controls.Add(Me.CODIGO_ANAMNESISTextBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MainMenuStrip = Me.MenuStrip2
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "Anamnesis"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.MenuStrip2.ResumeLayout(False)
        Me.MenuStrip2.PerformLayout()
        CType(Me.CONSULTADataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DERH.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CODIGO_ANAMNESISTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TRATAMIENTO_MEDICOTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ENFERMEDADTextBox As System.Windows.Forms.TextBox
    Friend WithEvents INGESTION_DE_MEDICAMENTOSTextBox As System.Windows.Forms.TextBox
    Friend WithEvents OBSERVACIONESTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents MENUToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CONSULTA As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents REGISTRODIARIOToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ESTUDIANTEToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EXAMENFISICOESTOMATOLOGICOToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ODOTOGRAMAToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DIAGNOSTICOToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SALIRToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents INSERTAR As System.Windows.Forms.Button
    Friend WithEvents EDITAR As System.Windows.Forms.Button
    Friend WithEvents ELIMINAR As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents l As System.Windows.Forms.OpenFileDialog
    Friend WithEvents MenuStrip2 As System.Windows.Forms.MenuStrip
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents IMAGENDEFONDOToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CambiarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LUGARToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CENTROToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents COMPLETAToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ZOOMToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GUARDARCAMBIOSToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CAMBIARPOSICIONToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TITULO As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OCULTARToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CONSULTADataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents CODIGOANAMNESISDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TRATAMIENTOMEDICODataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ENFERMEDADDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents INGESTIONDEMEDICAMENTOSDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents OBSERVACIONESDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DERH As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents TB As System.Windows.Forms.ToolStripMenuItem
End Class
