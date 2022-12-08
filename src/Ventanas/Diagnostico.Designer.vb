<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Diagnostico
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
        Dim CODIGO_DIAGNOSTICOLabel As System.Windows.Forms.Label
        Dim TRATAMIENTO_POR_REALIZARLabel As System.Windows.Forms.Label
        Dim DIENTES_PARA_TRATAMIENTOLabel As System.Windows.Forms.Label
        Dim FECHALabel As System.Windows.Forms.Label
        Dim NOMBRE_ODONTOLOGALabel As System.Windows.Forms.Label
        Dim CODIGO_ELabel As System.Windows.Forms.Label
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CODIGO_DIAGNOSTICOTextBox = New System.Windows.Forms.TextBox()
        Me.TRATAMIENTO_POR_REALIZARTextBox = New System.Windows.Forms.TextBox()
        Me.DIENTES_PARA_TRATAMIENTOTextBox = New System.Windows.Forms.TextBox()
        Me.FECHADateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.NOMBRE_ODONTOLOGATextBox = New System.Windows.Forms.TextBox()
        Me.CODIGO_ETextBox = New System.Windows.Forms.TextBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MENUToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CONSULTA = New System.Windows.Forms.ToolStripMenuItem()
        Me.ESTUDIANTEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ANAMNESIS = New System.Windows.Forms.ToolStripMenuItem()
        Me.EXAMENFISICOESTOMATOLOGICOToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ODOTOGRAMAToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.REGISTRODIARIOToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SALIRToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.INSERTAR = New System.Windows.Forms.Button()
        Me.EDITAR = New System.Windows.Forms.Button()
        Me.ELIMINAR = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.L = New System.Windows.Forms.OpenFileDialog()
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
        Me.TIB = New System.Windows.Forms.ToolStripMenuItem()
        CODIGO_DIAGNOSTICOLabel = New System.Windows.Forms.Label()
        TRATAMIENTO_POR_REALIZARLabel = New System.Windows.Forms.Label()
        DIENTES_PARA_TRATAMIENTOLabel = New System.Windows.Forms.Label()
        FECHALabel = New System.Windows.Forms.Label()
        NOMBRE_ODONTOLOGALabel = New System.Windows.Forms.Label()
        CODIGO_ELabel = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.MenuStrip2.SuspendLayout()
        CType(Me.CONSULTADataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TB.SuspendLayout()
        Me.SuspendLayout()
        '
        'CODIGO_DIAGNOSTICOLabel
        '
        CODIGO_DIAGNOSTICOLabel.AutoSize = True
        CODIGO_DIAGNOSTICOLabel.BackColor = System.Drawing.Color.Transparent
        CODIGO_DIAGNOSTICOLabel.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        CODIGO_DIAGNOSTICOLabel.Location = New System.Drawing.Point(366, 224)
        CODIGO_DIAGNOSTICOLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        CODIGO_DIAGNOSTICOLabel.Name = "CODIGO_DIAGNOSTICOLabel"
        CODIGO_DIAGNOSTICOLabel.Size = New System.Drawing.Size(137, 15)
        CODIGO_DIAGNOSTICOLabel.TabIndex = 60
        CODIGO_DIAGNOSTICOLabel.Text = "CODIGO DIAGNOSTICO:"
        '
        'TRATAMIENTO_POR_REALIZARLabel
        '
        TRATAMIENTO_POR_REALIZARLabel.AutoSize = True
        TRATAMIENTO_POR_REALIZARLabel.BackColor = System.Drawing.Color.Transparent
        TRATAMIENTO_POR_REALIZARLabel.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        TRATAMIENTO_POR_REALIZARLabel.Location = New System.Drawing.Point(366, 292)
        TRATAMIENTO_POR_REALIZARLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        TRATAMIENTO_POR_REALIZARLabel.Name = "TRATAMIENTO_POR_REALIZARLabel"
        TRATAMIENTO_POR_REALIZARLabel.Size = New System.Drawing.Size(177, 15)
        TRATAMIENTO_POR_REALIZARLabel.TabIndex = 61
        TRATAMIENTO_POR_REALIZARLabel.Text = "TRATAMIENTO POR REALIZAR:"
        '
        'DIENTES_PARA_TRATAMIENTOLabel
        '
        DIENTES_PARA_TRATAMIENTOLabel.AutoSize = True
        DIENTES_PARA_TRATAMIENTOLabel.BackColor = System.Drawing.Color.Transparent
        DIENTES_PARA_TRATAMIENTOLabel.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        DIENTES_PARA_TRATAMIENTOLabel.Location = New System.Drawing.Point(366, 363)
        DIENTES_PARA_TRATAMIENTOLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        DIENTES_PARA_TRATAMIENTOLabel.Name = "DIENTES_PARA_TRATAMIENTOLabel"
        DIENTES_PARA_TRATAMIENTOLabel.Size = New System.Drawing.Size(175, 15)
        DIENTES_PARA_TRATAMIENTOLabel.TabIndex = 62
        DIENTES_PARA_TRATAMIENTOLabel.Text = "DIENTES PARA TRATAMIENTO:"
        '
        'FECHALabel
        '
        FECHALabel.AutoSize = True
        FECHALabel.BackColor = System.Drawing.Color.Transparent
        FECHALabel.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        FECHALabel.Location = New System.Drawing.Point(794, 224)
        FECHALabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        FECHALabel.Name = "FECHALabel"
        FECHALabel.Size = New System.Drawing.Size(47, 15)
        FECHALabel.TabIndex = 63
        FECHALabel.Text = "FECHA:"
        '
        'NOMBRE_ODONTOLOGALabel
        '
        NOMBRE_ODONTOLOGALabel.AutoSize = True
        NOMBRE_ODONTOLOGALabel.BackColor = System.Drawing.Color.Transparent
        NOMBRE_ODONTOLOGALabel.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        NOMBRE_ODONTOLOGALabel.Location = New System.Drawing.Point(794, 292)
        NOMBRE_ODONTOLOGALabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        NOMBRE_ODONTOLOGALabel.Name = "NOMBRE_ODONTOLOGALabel"
        NOMBRE_ODONTOLOGALabel.Size = New System.Drawing.Size(145, 15)
        NOMBRE_ODONTOLOGALabel.TabIndex = 64
        NOMBRE_ODONTOLOGALabel.Text = "NOMBRE ODONTOLOGA:"
        '
        'CODIGO_ELabel
        '
        CODIGO_ELabel.AutoSize = True
        CODIGO_ELabel.BackColor = System.Drawing.Color.Transparent
        CODIGO_ELabel.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        CODIGO_ELabel.Location = New System.Drawing.Point(794, 362)
        CODIGO_ELabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        CODIGO_ELabel.Name = "CODIGO_ELabel"
        CODIGO_ELabel.Size = New System.Drawing.Size(65, 15)
        CODIGO_ELabel.TabIndex = 65
        CODIGO_ELabel.Text = "CODIGO E:"
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Modern No. 20", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(629, 22)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(236, 34)
        Me.Label1.TabIndex = 59
        Me.Label1.Text = "DIAGNOSTICO"
        '
        'CODIGO_DIAGNOSTICOTextBox
        '
        Me.CODIGO_DIAGNOSTICOTextBox.Location = New System.Drawing.Point(524, 220)
        Me.CODIGO_DIAGNOSTICOTextBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.CODIGO_DIAGNOSTICOTextBox.Name = "CODIGO_DIAGNOSTICOTextBox"
        Me.CODIGO_DIAGNOSTICOTextBox.Size = New System.Drawing.Size(116, 23)
        Me.CODIGO_DIAGNOSTICOTextBox.TabIndex = 61
        '
        'TRATAMIENTO_POR_REALIZARTextBox
        '
        Me.TRATAMIENTO_POR_REALIZARTextBox.Location = New System.Drawing.Point(572, 288)
        Me.TRATAMIENTO_POR_REALIZARTextBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TRATAMIENTO_POR_REALIZARTextBox.Name = "TRATAMIENTO_POR_REALIZARTextBox"
        Me.TRATAMIENTO_POR_REALIZARTextBox.Size = New System.Drawing.Size(116, 23)
        Me.TRATAMIENTO_POR_REALIZARTextBox.TabIndex = 62
        '
        'DIENTES_PARA_TRATAMIENTOTextBox
        '
        Me.DIENTES_PARA_TRATAMIENTOTextBox.Location = New System.Drawing.Point(572, 360)
        Me.DIENTES_PARA_TRATAMIENTOTextBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.DIENTES_PARA_TRATAMIENTOTextBox.Name = "DIENTES_PARA_TRATAMIENTOTextBox"
        Me.DIENTES_PARA_TRATAMIENTOTextBox.Size = New System.Drawing.Size(116, 23)
        Me.DIENTES_PARA_TRATAMIENTOTextBox.TabIndex = 63
        '
        'FECHADateTimePicker
        '
        Me.FECHADateTimePicker.Location = New System.Drawing.Point(854, 219)
        Me.FECHADateTimePicker.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.FECHADateTimePicker.Name = "FECHADateTimePicker"
        Me.FECHADateTimePicker.Size = New System.Drawing.Size(233, 23)
        Me.FECHADateTimePicker.TabIndex = 64
        '
        'NOMBRE_ODONTOLOGATextBox
        '
        Me.NOMBRE_ODONTOLOGATextBox.Location = New System.Drawing.Point(960, 288)
        Me.NOMBRE_ODONTOLOGATextBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.NOMBRE_ODONTOLOGATextBox.Name = "NOMBRE_ODONTOLOGATextBox"
        Me.NOMBRE_ODONTOLOGATextBox.Size = New System.Drawing.Size(116, 23)
        Me.NOMBRE_ODONTOLOGATextBox.TabIndex = 65
        '
        'CODIGO_ETextBox
        '
        Me.CODIGO_ETextBox.Location = New System.Drawing.Point(874, 359)
        Me.CODIGO_ETextBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.CODIGO_ETextBox.Name = "CODIGO_ETextBox"
        Me.CODIGO_ETextBox.Size = New System.Drawing.Size(116, 23)
        Me.CODIGO_ETextBox.TabIndex = 66
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
        Me.MenuStrip1.Location = New System.Drawing.Point(59, 22)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(4, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(67, 24)
        Me.MenuStrip1.TabIndex = 67
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MENUToolStripMenuItem
        '
        Me.MENUToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CONSULTA, Me.ESTUDIANTEToolStripMenuItem, Me.ANAMNESIS, Me.EXAMENFISICOESTOMATOLOGICOToolStripMenuItem, Me.ODOTOGRAMAToolStripMenuItem, Me.REGISTRODIARIOToolStripMenuItem, Me.SALIRToolStripMenuItem})
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
        Me.INSERTAR.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.INSERTAR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.INSERTAR.Cursor = System.Windows.Forms.Cursors.Hand
        Me.INSERTAR.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.INSERTAR.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
        Me.INSERTAR.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.INSERTAR.ForeColor = System.Drawing.Color.Black
        Me.INSERTAR.Location = New System.Drawing.Point(812, 456)
        Me.INSERTAR.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.INSERTAR.Name = "INSERTAR"
        Me.INSERTAR.Size = New System.Drawing.Size(120, 37)
        Me.INSERTAR.TabIndex = 116
        Me.INSERTAR.Text = "INSERTAR"
        Me.INSERTAR.UseVisualStyleBackColor = False
        '
        'EDITAR
        '
        Me.EDITAR.AutoSize = True
        Me.EDITAR.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.EDITAR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.EDITAR.Cursor = System.Windows.Forms.Cursors.Hand
        Me.EDITAR.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.EDITAR.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
        Me.EDITAR.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.EDITAR.ForeColor = System.Drawing.Color.Black
        Me.EDITAR.Location = New System.Drawing.Point(649, 456)
        Me.EDITAR.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.EDITAR.Name = "EDITAR"
        Me.EDITAR.Size = New System.Drawing.Size(120, 37)
        Me.EDITAR.TabIndex = 115
        Me.EDITAR.Text = "EDITAR"
        Me.EDITAR.UseVisualStyleBackColor = False
        '
        'ELIMINAR
        '
        Me.ELIMINAR.AutoSize = True
        Me.ELIMINAR.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ELIMINAR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ELIMINAR.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ELIMINAR.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.ELIMINAR.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
        Me.ELIMINAR.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.ELIMINAR.ForeColor = System.Drawing.Color.Black
        Me.ELIMINAR.Location = New System.Drawing.Point(954, 456)
        Me.ELIMINAR.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.ELIMINAR.Name = "ELIMINAR"
        Me.ELIMINAR.Size = New System.Drawing.Size(120, 37)
        Me.ELIMINAR.TabIndex = 114
        Me.ELIMINAR.Text = "ELIMINAR"
        Me.ELIMINAR.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.AutoSize = True
        Me.Button2.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
        Me.Button2.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Button2.ForeColor = System.Drawing.Color.Black
        Me.Button2.Location = New System.Drawing.Point(492, 456)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(120, 37)
        Me.Button2.TabIndex = 113
        Me.Button2.Text = "LIMPIAR"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.AutoSize = True
        Me.Button1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
        Me.Button1.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Location = New System.Drawing.Point(348, 456)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(120, 37)
        Me.Button1.TabIndex = 112
        Me.Button1.Text = "BUSCAR"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'L
        '
        Me.L.FileName = "OpenFileDialog1"
        '
        'MenuStrip2
        '
        Me.MenuStrip2.BackColor = System.Drawing.Color.Transparent
        Me.MenuStrip2.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1})
        Me.MenuStrip2.Location = New System.Drawing.Point(246, 22)
        Me.MenuStrip2.Name = "MenuStrip2"
        Me.MenuStrip2.Padding = New System.Windows.Forms.Padding(7, 2, 0, 2)
        Me.MenuStrip2.Size = New System.Drawing.Size(152, 27)
        Me.MenuStrip2.TabIndex = 117
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
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaption
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
        Me.CONSULTADataGridView.Location = New System.Drawing.Point(204, 579)
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
        Me.CONSULTADataGridView.Size = New System.Drawing.Size(1011, 67)
        Me.CONSULTADataGridView.TabIndex = 131
        Me.CONSULTADataGridView.VirtualMode = True
        Me.CONSULTADataGridView.Visible = False
        '
        'TB
        '
        Me.TB.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TIB})
        Me.TB.Name = "TB"
        Me.TB.Size = New System.Drawing.Size(168, 26)
        '
        'TIB
        '
        Me.TIB.Name = "TIB"
        Me.TIB.Size = New System.Drawing.Size(167, 22)
        Me.TIB.Text = "MOSTRAR TABLA"
        '
        'Diagnostico
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
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
        Me.Controls.Add(CODIGO_ELabel)
        Me.Controls.Add(Me.CODIGO_ETextBox)
        Me.Controls.Add(NOMBRE_ODONTOLOGALabel)
        Me.Controls.Add(Me.NOMBRE_ODONTOLOGATextBox)
        Me.Controls.Add(FECHALabel)
        Me.Controls.Add(Me.FECHADateTimePicker)
        Me.Controls.Add(DIENTES_PARA_TRATAMIENTOLabel)
        Me.Controls.Add(Me.DIENTES_PARA_TRATAMIENTOTextBox)
        Me.Controls.Add(TRATAMIENTO_POR_REALIZARLabel)
        Me.Controls.Add(Me.TRATAMIENTO_POR_REALIZARTextBox)
        Me.Controls.Add(CODIGO_DIAGNOSTICOLabel)
        Me.Controls.Add(Me.CODIGO_DIAGNOSTICOTextBox)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "Diagnostico"
        Me.Text = "Form4"
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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CODIGO_DIAGNOSTICOTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TRATAMIENTO_POR_REALIZARTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DIENTES_PARA_TRATAMIENTOTextBox As System.Windows.Forms.TextBox
    Friend WithEvents FECHADateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents NOMBRE_ODONTOLOGATextBox As System.Windows.Forms.TextBox
    Friend WithEvents CODIGO_ETextBox As System.Windows.Forms.TextBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents MENUToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CONSULTA As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents REGISTRODIARIOToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ESTUDIANTEToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EXAMENFISICOESTOMATOLOGICOToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ODOTOGRAMAToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ANAMNESIS As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SALIRToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents INSERTAR As System.Windows.Forms.Button
    Friend WithEvents EDITAR As System.Windows.Forms.Button
    Friend WithEvents ELIMINAR As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents L As System.Windows.Forms.OpenFileDialog
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
    Friend WithEvents CODIGODIAGNOSTICODataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TRATAMIENTOPORREALIZARDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DIENTESPARATRATAMIENTODataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FECHADataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NOMBREODONTOLOGADataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CODIGOEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TB As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents TIB As System.Windows.Forms.ToolStripMenuItem
End Class
