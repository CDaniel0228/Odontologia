<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Estomatologico
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
        Dim CODIGO_EXAMENLabel As System.Windows.Forms.Label
        Dim HIGIENE_ORALLabel As System.Windows.Forms.Label
        Dim PROBLEMA_DENTALLabel As System.Windows.Forms.Label
        Dim SEDA_DENTALLabel As System.Windows.Forms.Label
        Dim OBSERVACIONESLabel As System.Windows.Forms.Label
        Dim CODIGO_ODONTOGRAMALabel As System.Windows.Forms.Label
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.CODIGO_EXAMENTextBox = New System.Windows.Forms.TextBox()
        Me.HIGIENE_ORALTextBox = New System.Windows.Forms.TextBox()
        Me.PROBLEMA_DENTALTextBox = New System.Windows.Forms.TextBox()
        Me.SEDA_DENTALTextBox = New System.Windows.Forms.TextBox()
        Me.OBSERVACIONESTextBox = New System.Windows.Forms.TextBox()
        Me.CODIGO_ODONTOGRAMATextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MENUToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CONSULTA = New System.Windows.Forms.ToolStripMenuItem()
        Me.ESTUDIANTEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ANAMNESIS = New System.Windows.Forms.ToolStripMenuItem()
        Me.DIAGNOSTICOToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
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
        Me.GUARDARCAMBIOSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OCULTARToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CONSULTADataGridView = New System.Windows.Forms.DataGridView()
        Me.TB = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.MOSTRARTABLAToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CODIGO_EXAMENLabel = New System.Windows.Forms.Label()
        HIGIENE_ORALLabel = New System.Windows.Forms.Label()
        PROBLEMA_DENTALLabel = New System.Windows.Forms.Label()
        SEDA_DENTALLabel = New System.Windows.Forms.Label()
        OBSERVACIONESLabel = New System.Windows.Forms.Label()
        CODIGO_ODONTOGRAMALabel = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.MenuStrip2.SuspendLayout()
        CType(Me.CONSULTADataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TB.SuspendLayout()
        Me.SuspendLayout()
        '
        'CODIGO_EXAMENLabel
        '
        CODIGO_EXAMENLabel.AutoSize = True
        CODIGO_EXAMENLabel.BackColor = System.Drawing.Color.Transparent
        CODIGO_EXAMENLabel.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        CODIGO_EXAMENLabel.Location = New System.Drawing.Point(467, 255)
        CODIGO_EXAMENLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        CODIGO_EXAMENLabel.Name = "CODIGO_EXAMENLabel"
        CODIGO_EXAMENLabel.Size = New System.Drawing.Size(106, 15)
        CODIGO_EXAMENLabel.TabIndex = 1
        CODIGO_EXAMENLabel.Text = "CODIGO EXAMEN:"
        '
        'HIGIENE_ORALLabel
        '
        HIGIENE_ORALLabel.AutoSize = True
        HIGIENE_ORALLabel.BackColor = System.Drawing.Color.Transparent
        HIGIENE_ORALLabel.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        HIGIENE_ORALLabel.Location = New System.Drawing.Point(465, 329)
        HIGIENE_ORALLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        HIGIENE_ORALLabel.Name = "HIGIENE_ORALLabel"
        HIGIENE_ORALLabel.Size = New System.Drawing.Size(89, 15)
        HIGIENE_ORALLabel.TabIndex = 3
        HIGIENE_ORALLabel.Text = "HIGIENE ORAL:"
        '
        'PROBLEMA_DENTALLabel
        '
        PROBLEMA_DENTALLabel.AutoSize = True
        PROBLEMA_DENTALLabel.BackColor = System.Drawing.Color.Transparent
        PROBLEMA_DENTALLabel.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        PROBLEMA_DENTALLabel.Location = New System.Drawing.Point(467, 412)
        PROBLEMA_DENTALLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        PROBLEMA_DENTALLabel.Name = "PROBLEMA_DENTALLabel"
        PROBLEMA_DENTALLabel.Size = New System.Drawing.Size(122, 15)
        PROBLEMA_DENTALLabel.TabIndex = 5
        PROBLEMA_DENTALLabel.Text = "PROBLEMA DENTAL:"
        AddHandler PROBLEMA_DENTALLabel.Click, AddressOf Me.PROBLEMA_DENTALLabel_Click
        '
        'SEDA_DENTALLabel
        '
        SEDA_DENTALLabel.AutoSize = True
        SEDA_DENTALLabel.BackColor = System.Drawing.Color.Transparent
        SEDA_DENTALLabel.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        SEDA_DENTALLabel.Location = New System.Drawing.Point(862, 255)
        SEDA_DENTALLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        SEDA_DENTALLabel.Name = "SEDA_DENTALLabel"
        SEDA_DENTALLabel.Size = New System.Drawing.Size(88, 15)
        SEDA_DENTALLabel.TabIndex = 7
        SEDA_DENTALLabel.Text = "SEDA DENTAL:"
        '
        'OBSERVACIONESLabel
        '
        OBSERVACIONESLabel.AutoSize = True
        OBSERVACIONESLabel.BackColor = System.Drawing.Color.Transparent
        OBSERVACIONESLabel.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        OBSERVACIONESLabel.Location = New System.Drawing.Point(862, 329)
        OBSERVACIONESLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        OBSERVACIONESLabel.Name = "OBSERVACIONESLabel"
        OBSERVACIONESLabel.Size = New System.Drawing.Size(108, 15)
        OBSERVACIONESLabel.TabIndex = 9
        OBSERVACIONESLabel.Text = "OBSERVACIONES:"
        '
        'CODIGO_ODONTOGRAMALabel
        '
        CODIGO_ODONTOGRAMALabel.AutoSize = True
        CODIGO_ODONTOGRAMALabel.BackColor = System.Drawing.Color.Transparent
        CODIGO_ODONTOGRAMALabel.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        CODIGO_ODONTOGRAMALabel.Location = New System.Drawing.Point(862, 412)
        CODIGO_ODONTOGRAMALabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        CODIGO_ODONTOGRAMALabel.Name = "CODIGO_ODONTOGRAMALabel"
        CODIGO_ODONTOGRAMALabel.Size = New System.Drawing.Size(150, 15)
        CODIGO_ODONTOGRAMALabel.TabIndex = 11
        CODIGO_ODONTOGRAMALabel.Text = "CODIGO ODONTOGRAMA:"
        '
        'CODIGO_EXAMENTextBox
        '
        Me.CODIGO_EXAMENTextBox.Location = New System.Drawing.Point(590, 252)
        Me.CODIGO_EXAMENTextBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.CODIGO_EXAMENTextBox.Name = "CODIGO_EXAMENTextBox"
        Me.CODIGO_EXAMENTextBox.Size = New System.Drawing.Size(116, 23)
        Me.CODIGO_EXAMENTextBox.TabIndex = 2
        '
        'HIGIENE_ORALTextBox
        '
        Me.HIGIENE_ORALTextBox.Location = New System.Drawing.Point(573, 325)
        Me.HIGIENE_ORALTextBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.HIGIENE_ORALTextBox.Name = "HIGIENE_ORALTextBox"
        Me.HIGIENE_ORALTextBox.Size = New System.Drawing.Size(116, 23)
        Me.HIGIENE_ORALTextBox.TabIndex = 4
        '
        'PROBLEMA_DENTALTextBox
        '
        Me.PROBLEMA_DENTALTextBox.Location = New System.Drawing.Point(608, 408)
        Me.PROBLEMA_DENTALTextBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.PROBLEMA_DENTALTextBox.Name = "PROBLEMA_DENTALTextBox"
        Me.PROBLEMA_DENTALTextBox.Size = New System.Drawing.Size(116, 23)
        Me.PROBLEMA_DENTALTextBox.TabIndex = 6
        '
        'SEDA_DENTALTextBox
        '
        Me.SEDA_DENTALTextBox.Location = New System.Drawing.Point(968, 252)
        Me.SEDA_DENTALTextBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.SEDA_DENTALTextBox.Name = "SEDA_DENTALTextBox"
        Me.SEDA_DENTALTextBox.Size = New System.Drawing.Size(116, 23)
        Me.SEDA_DENTALTextBox.TabIndex = 8
        '
        'OBSERVACIONESTextBox
        '
        Me.OBSERVACIONESTextBox.Location = New System.Drawing.Point(987, 325)
        Me.OBSERVACIONESTextBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.OBSERVACIONESTextBox.Name = "OBSERVACIONESTextBox"
        Me.OBSERVACIONESTextBox.Size = New System.Drawing.Size(116, 23)
        Me.OBSERVACIONESTextBox.TabIndex = 10
        '
        'CODIGO_ODONTOGRAMATextBox
        '
        Me.CODIGO_ODONTOGRAMATextBox.Location = New System.Drawing.Point(1035, 407)
        Me.CODIGO_ODONTOGRAMATextBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.CODIGO_ODONTOGRAMATextBox.Name = "CODIGO_ODONTOGRAMATextBox"
        Me.CODIGO_ODONTOGRAMATextBox.Size = New System.Drawing.Size(116, 23)
        Me.CODIGO_ODONTOGRAMATextBox.TabIndex = 12
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Modern No. 20", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(438, 32)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(583, 34)
        Me.Label1.TabIndex = 60
        Me.Label1.Text = "EXAMEN FISICO ESTOMATOLOGICO"
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
        Me.MenuStrip1.Location = New System.Drawing.Point(55, 39)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(4, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(67, 24)
        Me.MenuStrip1.TabIndex = 68
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MENUToolStripMenuItem
        '
        Me.MENUToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CONSULTA, Me.ESTUDIANTEToolStripMenuItem, Me.ANAMNESIS, Me.DIAGNOSTICOToolStripMenuItem, Me.ODOTOGRAMAToolStripMenuItem, Me.REGISTRODIARIOToolStripMenuItem, Me.SALIRToolStripMenuItem})
        Me.MENUToolStripMenuItem.Name = "MENUToolStripMenuItem"
        Me.MENUToolStripMenuItem.Size = New System.Drawing.Size(54, 20)
        Me.MENUToolStripMenuItem.Text = "MENU"
        '
        'CONSULTA
        '
        Me.CONSULTA.Name = "CONSULTA"
        Me.CONSULTA.Size = New System.Drawing.Size(177, 22)
        Me.CONSULTA.Text = "CONSULTA"
        '
        'ESTUDIANTEToolStripMenuItem
        '
        Me.ESTUDIANTEToolStripMenuItem.Name = "ESTUDIANTEToolStripMenuItem"
        Me.ESTUDIANTEToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.ESTUDIANTEToolStripMenuItem.Text = "ESTUDIANTE"
        '
        'ANAMNESIS
        '
        Me.ANAMNESIS.Name = "ANAMNESIS"
        Me.ANAMNESIS.Size = New System.Drawing.Size(177, 22)
        Me.ANAMNESIS.Text = "ANAMNESIS"
        '
        'DIAGNOSTICOToolStripMenuItem
        '
        Me.DIAGNOSTICOToolStripMenuItem.Name = "DIAGNOSTICOToolStripMenuItem"
        Me.DIAGNOSTICOToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.DIAGNOSTICOToolStripMenuItem.Text = "DIAGNOSTICO"
        '
        'ODOTOGRAMAToolStripMenuItem
        '
        Me.ODOTOGRAMAToolStripMenuItem.Name = "ODOTOGRAMAToolStripMenuItem"
        Me.ODOTOGRAMAToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.ODOTOGRAMAToolStripMenuItem.Text = "ODOTOGRAMA"
        '
        'REGISTRODIARIOToolStripMenuItem
        '
        Me.REGISTRODIARIOToolStripMenuItem.Name = "REGISTRODIARIOToolStripMenuItem"
        Me.REGISTRODIARIOToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.REGISTRODIARIOToolStripMenuItem.Text = "REGISTRO DIARIO"
        '
        'SALIRToolStripMenuItem
        '
        Me.SALIRToolStripMenuItem.Name = "SALIRToolStripMenuItem"
        Me.SALIRToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.SALIRToolStripMenuItem.Text = "SALIR"
        '
        'INSERTAR
        '
        Me.INSERTAR.AutoSize = True
        Me.INSERTAR.BackColor = System.Drawing.Color.MidnightBlue
        Me.INSERTAR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.INSERTAR.Cursor = System.Windows.Forms.Cursors.Hand
        Me.INSERTAR.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.INSERTAR.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
        Me.INSERTAR.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.INSERTAR.ForeColor = System.Drawing.Color.White
        Me.INSERTAR.Location = New System.Drawing.Point(890, 532)
        Me.INSERTAR.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.INSERTAR.Name = "INSERTAR"
        Me.INSERTAR.Size = New System.Drawing.Size(120, 37)
        Me.INSERTAR.TabIndex = 121
        Me.INSERTAR.Text = "INSERTAR"
        Me.INSERTAR.UseVisualStyleBackColor = False
        '
        'EDITAR
        '
        Me.EDITAR.AutoSize = True
        Me.EDITAR.BackColor = System.Drawing.Color.MidnightBlue
        Me.EDITAR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.EDITAR.Cursor = System.Windows.Forms.Cursors.Hand
        Me.EDITAR.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.EDITAR.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
        Me.EDITAR.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.EDITAR.ForeColor = System.Drawing.Color.White
        Me.EDITAR.Location = New System.Drawing.Point(727, 532)
        Me.EDITAR.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.EDITAR.Name = "EDITAR"
        Me.EDITAR.Size = New System.Drawing.Size(120, 37)
        Me.EDITAR.TabIndex = 120
        Me.EDITAR.Text = "EDITAR"
        Me.EDITAR.UseVisualStyleBackColor = False
        '
        'ELIMINAR
        '
        Me.ELIMINAR.AutoSize = True
        Me.ELIMINAR.BackColor = System.Drawing.Color.MidnightBlue
        Me.ELIMINAR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ELIMINAR.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ELIMINAR.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.ELIMINAR.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
        Me.ELIMINAR.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.ELIMINAR.ForeColor = System.Drawing.Color.White
        Me.ELIMINAR.Location = New System.Drawing.Point(1032, 532)
        Me.ELIMINAR.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.ELIMINAR.Name = "ELIMINAR"
        Me.ELIMINAR.Size = New System.Drawing.Size(120, 37)
        Me.ELIMINAR.TabIndex = 119
        Me.ELIMINAR.Text = "ELIMINAR"
        Me.ELIMINAR.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.AutoSize = True
        Me.Button2.BackColor = System.Drawing.Color.MidnightBlue
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
        Me.Button2.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(570, 532)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(120, 37)
        Me.Button2.TabIndex = 118
        Me.Button2.Text = "LIMPIAR"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.AutoSize = True
        Me.Button1.BackColor = System.Drawing.Color.MidnightBlue
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
        Me.Button1.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(426, 532)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(120, 37)
        Me.Button1.TabIndex = 117
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
        Me.MenuStrip2.Location = New System.Drawing.Point(162, 32)
        Me.MenuStrip2.Name = "MenuStrip2"
        Me.MenuStrip2.Padding = New System.Windows.Forms.Padding(7, 2, 0, 2)
        Me.MenuStrip2.Size = New System.Drawing.Size(152, 27)
        Me.MenuStrip2.TabIndex = 122
        Me.MenuStrip2.Text = "MenuStrip2"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.BackColor = System.Drawing.Color.Transparent
        Me.ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.IMAGENDEFONDOToolStripMenuItem, Me.GUARDARCAMBIOSToolStripMenuItem, Me.OCULTARToolStripMenuItem})
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
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.MidnightBlue
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
        Me.CONSULTADataGridView.Location = New System.Drawing.Point(346, 674)
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
        Me.CONSULTADataGridView.Size = New System.Drawing.Size(915, 83)
        Me.CONSULTADataGridView.TabIndex = 131
        Me.CONSULTADataGridView.VirtualMode = True
        Me.CONSULTADataGridView.Visible = False
        '
        'TB
        '
        Me.TB.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MOSTRARTABLAToolStripMenuItem})
        Me.TB.Name = "TB"
        Me.TB.Size = New System.Drawing.Size(168, 26)
        '
        'MOSTRARTABLAToolStripMenuItem
        '
        Me.MOSTRARTABLAToolStripMenuItem.Name = "MOSTRARTABLAToolStripMenuItem"
        Me.MOSTRARTABLAToolStripMenuItem.Size = New System.Drawing.Size(167, 22)
        Me.MOSTRARTABLAToolStripMenuItem.Text = "MOSTRAR TABLA"
        '
        'Estomatologico
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1370, 772)
        Me.ContextMenuStrip = Me.TB
        Me.Controls.Add(Me.CONSULTADataGridView)
        Me.Controls.Add(Me.MenuStrip2)
        Me.Controls.Add(Me.INSERTAR)
        Me.Controls.Add(Me.EDITAR)
        Me.Controls.Add(Me.ELIMINAR)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(CODIGO_ODONTOGRAMALabel)
        Me.Controls.Add(Me.CODIGO_ODONTOGRAMATextBox)
        Me.Controls.Add(OBSERVACIONESLabel)
        Me.Controls.Add(Me.OBSERVACIONESTextBox)
        Me.Controls.Add(SEDA_DENTALLabel)
        Me.Controls.Add(Me.SEDA_DENTALTextBox)
        Me.Controls.Add(PROBLEMA_DENTALLabel)
        Me.Controls.Add(Me.PROBLEMA_DENTALTextBox)
        Me.Controls.Add(HIGIENE_ORALLabel)
        Me.Controls.Add(Me.HIGIENE_ORALTextBox)
        Me.Controls.Add(CODIGO_EXAMENLabel)
        Me.Controls.Add(Me.CODIGO_EXAMENTextBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "Estomatologico"
        Me.Text = "Form5"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.MenuStrip2.ResumeLayout(False)
        Me.MenuStrip2.PerformLayout()
        CType(Me.CONSULTADataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TB.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CODIGO_EXAMENTextBox As System.Windows.Forms.TextBox
    Friend WithEvents HIGIENE_ORALTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PROBLEMA_DENTALTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SEDA_DENTALTextBox As System.Windows.Forms.TextBox
    Friend WithEvents OBSERVACIONESTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CODIGO_ODONTOGRAMATextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents MENUToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CONSULTA As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ESTUDIANTEToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents REGISTRODIARIOToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ANAMNESIS As System.Windows.Forms.ToolStripMenuItem
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
    Friend WithEvents OCULTARToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CONSULTADataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents CODIGOEXAMENDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HIGIENEORALDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PROBLEMADENTALDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SEDADENTALDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents OBSERVACIONESDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CODIGOODONTOGRAMADataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TB As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents MOSTRARTABLAToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
