<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Consultar
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
        Dim CODIGO_ELabel As System.Windows.Forms.Label
        Dim SECCIONLabel As System.Windows.Forms.Label
        Dim DOCUMENTO_DE_IDENTIDADLabel As System.Windows.Forms.Label
        Dim NOMBRESLabel As System.Windows.Forms.Label
        Dim APELLIDOSLabel As System.Windows.Forms.Label
        Dim EDADLabel As System.Windows.Forms.Label
        Dim TRATAMIENTO_POR_REALIZARLabel As System.Windows.Forms.Label
        Dim FECHALabel As System.Windows.Forms.Label
        Dim N__CITAS_CUMPLIDASLabel As System.Windows.Forms.Label
        Dim TRATAMIENTOLabel As System.Windows.Forms.Label
        Dim OBSERVACIONESLabel As System.Windows.Forms.Label
        Dim INCAPACIDAD__DIAS_Label As System.Windows.Forms.Label
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.CODIGO_ETextBox = New System.Windows.Forms.TextBox()
        Me.SECCIONTextBox = New System.Windows.Forms.TextBox()
        Me.DOCUMENTO_DE_IDENTIDADTextBox = New System.Windows.Forms.TextBox()
        Me.NOMBRESTextBox = New System.Windows.Forms.TextBox()
        Me.APELLIDOSTextBox = New System.Windows.Forms.TextBox()
        Me.EDADTextBox = New System.Windows.Forms.TextBox()
        Me.TRATAMIENTO_POR_REALIZARTextBox = New System.Windows.Forms.TextBox()
        Me.FECHADateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.N__CITAS_CUMPLIDASTextBox = New System.Windows.Forms.TextBox()
        Me.TRATAMIENTOTextBox = New System.Windows.Forms.TextBox()
        Me.OBSERVACIONESTextBox = New System.Windows.Forms.TextBox()
        Me.INCAPACIDAD__DIAS_TextBox = New System.Windows.Forms.TextBox()
        Me.BUS = New System.Windows.Forms.Button()
        Me.NUEVO = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MENUToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ESTUDIANTEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ANAMNESISToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DIAGNOSTICOToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EXAMENFISICOESTOMATOLOGICOToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ODOTOGRAMAToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.REGISTRODIARIOToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SALIRToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.T1 = New System.Windows.Forms.Timer(Me.components)
        Me.fh = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
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
        Me.MS = New System.Windows.Forms.ToolTip(Me.components)
        Me.CONSULTADataGridView = New System.Windows.Forms.DataGridView()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.TB = New System.Windows.Forms.ToolStripMenuItem()
        CODIGO_ELabel = New System.Windows.Forms.Label()
        SECCIONLabel = New System.Windows.Forms.Label()
        DOCUMENTO_DE_IDENTIDADLabel = New System.Windows.Forms.Label()
        NOMBRESLabel = New System.Windows.Forms.Label()
        APELLIDOSLabel = New System.Windows.Forms.Label()
        EDADLabel = New System.Windows.Forms.Label()
        TRATAMIENTO_POR_REALIZARLabel = New System.Windows.Forms.Label()
        FECHALabel = New System.Windows.Forms.Label()
        N__CITAS_CUMPLIDASLabel = New System.Windows.Forms.Label()
        TRATAMIENTOLabel = New System.Windows.Forms.Label()
        OBSERVACIONESLabel = New System.Windows.Forms.Label()
        INCAPACIDAD__DIAS_Label = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.MenuStrip2.SuspendLayout()
        CType(Me.CONSULTADataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'CODIGO_ELabel
        '
        CODIGO_ELabel.AutoSize = True
        CODIGO_ELabel.Location = New System.Drawing.Point(378, 197)
        CODIGO_ELabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        CODIGO_ELabel.Name = "CODIGO_ELabel"
        CODIGO_ELabel.Size = New System.Drawing.Size(64, 15)
        CODIGO_ELabel.TabIndex = 1
        CODIGO_ELabel.Text = "CODIGO E:"
        '
        'SECCIONLabel
        '
        SECCIONLabel.AutoSize = True
        SECCIONLabel.Location = New System.Drawing.Point(384, 246)
        SECCIONLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        SECCIONLabel.Name = "SECCIONLabel"
        SECCIONLabel.Size = New System.Drawing.Size(59, 15)
        SECCIONLabel.TabIndex = 3
        SECCIONLabel.Text = "SECCION:"
        '
        'DOCUMENTO_DE_IDENTIDADLabel
        '
        DOCUMENTO_DE_IDENTIDADLabel.AutoSize = True
        DOCUMENTO_DE_IDENTIDADLabel.Location = New System.Drawing.Point(378, 297)
        DOCUMENTO_DE_IDENTIDADLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        DOCUMENTO_DE_IDENTIDADLabel.Name = "DOCUMENTO_DE_IDENTIDADLabel"
        DOCUMENTO_DE_IDENTIDADLabel.Size = New System.Drawing.Size(164, 15)
        DOCUMENTO_DE_IDENTIDADLabel.TabIndex = 5
        DOCUMENTO_DE_IDENTIDADLabel.Text = "DOCUMENTO DE IDENTIDAD:"
        '
        'NOMBRESLabel
        '
        NOMBRESLabel.AutoSize = True
        NOMBRESLabel.Location = New System.Drawing.Point(387, 346)
        NOMBRESLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        NOMBRESLabel.Name = "NOMBRESLabel"
        NOMBRESLabel.Size = New System.Drawing.Size(65, 15)
        NOMBRESLabel.TabIndex = 7
        NOMBRESLabel.Text = "NOMBRES:"
        '
        'APELLIDOSLabel
        '
        APELLIDOSLabel.AutoSize = True
        APELLIDOSLabel.Location = New System.Drawing.Point(380, 408)
        APELLIDOSLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        APELLIDOSLabel.Name = "APELLIDOSLabel"
        APELLIDOSLabel.Size = New System.Drawing.Size(69, 15)
        APELLIDOSLabel.TabIndex = 9
        APELLIDOSLabel.Text = "APELLIDOS:"
        '
        'EDADLabel
        '
        EDADLabel.AutoSize = True
        EDADLabel.Location = New System.Drawing.Point(378, 459)
        EDADLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        EDADLabel.Name = "EDADLabel"
        EDADLabel.Size = New System.Drawing.Size(40, 15)
        EDADLabel.TabIndex = 11
        EDADLabel.Text = "EDAD:"
        '
        'TRATAMIENTO_POR_REALIZARLabel
        '
        TRATAMIENTO_POR_REALIZARLabel.AutoSize = True
        TRATAMIENTO_POR_REALIZARLabel.Location = New System.Drawing.Point(813, 203)
        TRATAMIENTO_POR_REALIZARLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        TRATAMIENTO_POR_REALIZARLabel.Name = "TRATAMIENTO_POR_REALIZARLabel"
        TRATAMIENTO_POR_REALIZARLabel.Size = New System.Drawing.Size(170, 15)
        TRATAMIENTO_POR_REALIZARLabel.TabIndex = 13
        TRATAMIENTO_POR_REALIZARLabel.Text = "TRATAMIENTO POR REALIZAR:"
        '
        'FECHALabel
        '
        FECHALabel.AutoSize = True
        FECHALabel.Location = New System.Drawing.Point(816, 252)
        FECHALabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        FECHALabel.Name = "FECHALabel"
        FECHALabel.Size = New System.Drawing.Size(47, 15)
        FECHALabel.TabIndex = 15
        FECHALabel.Text = "FECHA:"
        '
        'N__CITAS_CUMPLIDASLabel
        '
        N__CITAS_CUMPLIDASLabel.AutoSize = True
        N__CITAS_CUMPLIDASLabel.Location = New System.Drawing.Point(826, 303)
        N__CITAS_CUMPLIDASLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        N__CITAS_CUMPLIDASLabel.Name = "N__CITAS_CUMPLIDASLabel"
        N__CITAS_CUMPLIDASLabel.Size = New System.Drawing.Size(124, 15)
        N__CITAS_CUMPLIDASLabel.TabIndex = 17
        N__CITAS_CUMPLIDASLabel.Text = "N  CITAS CUMPLIDAS:"
        '
        'TRATAMIENTOLabel
        '
        TRATAMIENTOLabel.AutoSize = True
        TRATAMIENTOLabel.Location = New System.Drawing.Point(824, 347)
        TRATAMIENTOLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        TRATAMIENTOLabel.Name = "TRATAMIENTOLabel"
        TRATAMIENTOLabel.Size = New System.Drawing.Size(89, 15)
        TRATAMIENTOLabel.TabIndex = 19
        TRATAMIENTOLabel.Text = "TRATAMIENTO:"
        '
        'OBSERVACIONESLabel
        '
        OBSERVACIONESLabel.AutoSize = True
        OBSERVACIONESLabel.Location = New System.Drawing.Point(824, 411)
        OBSERVACIONESLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        OBSERVACIONESLabel.Name = "OBSERVACIONESLabel"
        OBSERVACIONESLabel.Size = New System.Drawing.Size(100, 15)
        OBSERVACIONESLabel.TabIndex = 21
        OBSERVACIONESLabel.Text = "OBSERVACIONES:"
        '
        'INCAPACIDAD__DIAS_Label
        '
        INCAPACIDAD__DIAS_Label.AutoSize = True
        INCAPACIDAD__DIAS_Label.Location = New System.Drawing.Point(827, 466)
        INCAPACIDAD__DIAS_Label.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        INCAPACIDAD__DIAS_Label.Name = "INCAPACIDAD__DIAS_Label"
        INCAPACIDAD__DIAS_Label.Size = New System.Drawing.Size(123, 15)
        INCAPACIDAD__DIAS_Label.TabIndex = 23
        INCAPACIDAD__DIAS_Label.Text = "INCAPACIDAD (DIAS):"
        '
        'CODIGO_ETextBox
        '
        Me.CODIGO_ETextBox.Location = New System.Drawing.Point(457, 194)
        Me.CODIGO_ETextBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.CODIGO_ETextBox.Name = "CODIGO_ETextBox"
        Me.CODIGO_ETextBox.Size = New System.Drawing.Size(116, 23)
        Me.CODIGO_ETextBox.TabIndex = 2
        '
        'SECCIONTextBox
        '
        Me.SECCIONTextBox.Location = New System.Drawing.Point(457, 242)
        Me.SECCIONTextBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.SECCIONTextBox.Name = "SECCIONTextBox"
        Me.SECCIONTextBox.Size = New System.Drawing.Size(116, 23)
        Me.SECCIONTextBox.TabIndex = 4
        '
        'DOCUMENTO_DE_IDENTIDADTextBox
        '
        Me.DOCUMENTO_DE_IDENTIDADTextBox.Location = New System.Drawing.Point(572, 293)
        Me.DOCUMENTO_DE_IDENTIDADTextBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.DOCUMENTO_DE_IDENTIDADTextBox.Name = "DOCUMENTO_DE_IDENTIDADTextBox"
        Me.DOCUMENTO_DE_IDENTIDADTextBox.Size = New System.Drawing.Size(116, 23)
        Me.DOCUMENTO_DE_IDENTIDADTextBox.TabIndex = 6
        '
        'NOMBRESTextBox
        '
        Me.NOMBRESTextBox.Location = New System.Drawing.Point(469, 343)
        Me.NOMBRESTextBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.NOMBRESTextBox.Name = "NOMBRESTextBox"
        Me.NOMBRESTextBox.Size = New System.Drawing.Size(116, 23)
        Me.NOMBRESTextBox.TabIndex = 8
        '
        'APELLIDOSTextBox
        '
        Me.APELLIDOSTextBox.Location = New System.Drawing.Point(468, 405)
        Me.APELLIDOSTextBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.APELLIDOSTextBox.Name = "APELLIDOSTextBox"
        Me.APELLIDOSTextBox.Size = New System.Drawing.Size(116, 23)
        Me.APELLIDOSTextBox.TabIndex = 10
        '
        'EDADTextBox
        '
        Me.EDADTextBox.Location = New System.Drawing.Point(432, 456)
        Me.EDADTextBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.EDADTextBox.Name = "EDADTextBox"
        Me.EDADTextBox.Size = New System.Drawing.Size(116, 23)
        Me.EDADTextBox.TabIndex = 12
        '
        'TRATAMIENTO_POR_REALIZARTextBox
        '
        Me.TRATAMIENTO_POR_REALIZARTextBox.Location = New System.Drawing.Point(1018, 200)
        Me.TRATAMIENTO_POR_REALIZARTextBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TRATAMIENTO_POR_REALIZARTextBox.Name = "TRATAMIENTO_POR_REALIZARTextBox"
        Me.TRATAMIENTO_POR_REALIZARTextBox.Size = New System.Drawing.Size(116, 23)
        Me.TRATAMIENTO_POR_REALIZARTextBox.TabIndex = 14
        '
        'FECHADateTimePicker
        '
        Me.FECHADateTimePicker.CalendarFont = New System.Drawing.Font("MS Outlook", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.FECHADateTimePicker.CalendarForeColor = System.Drawing.Color.White
        Me.FECHADateTimePicker.CalendarMonthBackground = System.Drawing.Color.White
        Me.FECHADateTimePicker.CalendarTitleBackColor = System.Drawing.Color.White
        Me.FECHADateTimePicker.CalendarTitleForeColor = System.Drawing.Color.White
        Me.FECHADateTimePicker.CalendarTrailingForeColor = System.Drawing.Color.White
        Me.FECHADateTimePicker.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.FECHADateTimePicker.Location = New System.Drawing.Point(875, 247)
        Me.FECHADateTimePicker.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.FECHADateTimePicker.Name = "FECHADateTimePicker"
        Me.FECHADateTimePicker.Size = New System.Drawing.Size(233, 23)
        Me.FECHADateTimePicker.TabIndex = 16
        '
        'N__CITAS_CUMPLIDASTextBox
        '
        Me.N__CITAS_CUMPLIDASTextBox.Location = New System.Drawing.Point(973, 300)
        Me.N__CITAS_CUMPLIDASTextBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.N__CITAS_CUMPLIDASTextBox.Name = "N__CITAS_CUMPLIDASTextBox"
        Me.N__CITAS_CUMPLIDASTextBox.Size = New System.Drawing.Size(116, 23)
        Me.N__CITAS_CUMPLIDASTextBox.TabIndex = 18
        '
        'TRATAMIENTOTextBox
        '
        Me.TRATAMIENTOTextBox.Location = New System.Drawing.Point(933, 344)
        Me.TRATAMIENTOTextBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TRATAMIENTOTextBox.Name = "TRATAMIENTOTextBox"
        Me.TRATAMIENTOTextBox.Size = New System.Drawing.Size(116, 23)
        Me.TRATAMIENTOTextBox.TabIndex = 20
        '
        'OBSERVACIONESTextBox
        '
        Me.OBSERVACIONESTextBox.Location = New System.Drawing.Point(948, 407)
        Me.OBSERVACIONESTextBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.OBSERVACIONESTextBox.Name = "OBSERVACIONESTextBox"
        Me.OBSERVACIONESTextBox.Size = New System.Drawing.Size(116, 23)
        Me.OBSERVACIONESTextBox.TabIndex = 22
        '
        'INCAPACIDAD__DIAS_TextBox
        '
        Me.INCAPACIDAD__DIAS_TextBox.Location = New System.Drawing.Point(969, 463)
        Me.INCAPACIDAD__DIAS_TextBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.INCAPACIDAD__DIAS_TextBox.Name = "INCAPACIDAD__DIAS_TextBox"
        Me.INCAPACIDAD__DIAS_TextBox.Size = New System.Drawing.Size(116, 23)
        Me.INCAPACIDAD__DIAS_TextBox.TabIndex = 24
        '
        'BUS
        '
        Me.BUS.BackColor = System.Drawing.Color.Black
        Me.BUS.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BUS.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BUS.ForeColor = System.Drawing.Color.White
        Me.BUS.Location = New System.Drawing.Point(511, 522)
        Me.BUS.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.BUS.Name = "BUS"
        Me.BUS.Size = New System.Drawing.Size(133, 32)
        Me.BUS.TabIndex = 25
        Me.BUS.Text = "BUSCAR"
        Me.BUS.UseVisualStyleBackColor = False
        '
        'NUEVO
        '
        Me.NUEVO.BackColor = System.Drawing.Color.Black
        Me.NUEVO.Cursor = System.Windows.Forms.Cursors.Hand
        Me.NUEVO.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.NUEVO.ForeColor = System.Drawing.Color.White
        Me.NUEVO.Location = New System.Drawing.Point(747, 522)
        Me.NUEVO.Margin = New System.Windows.Forms.Padding(0)
        Me.NUEVO.Name = "NUEVO"
        Me.NUEVO.Size = New System.Drawing.Size(145, 32)
        Me.NUEVO.TabIndex = 26
        Me.NUEVO.Text = "NUEVO"
        Me.NUEVO.UseVisualStyleBackColor = False
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
        Me.MenuStrip1.Location = New System.Drawing.Point(40, 16)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(4, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(72, 24)
        Me.MenuStrip1.TabIndex = 56
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MENUToolStripMenuItem
        '
        Me.MENUToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ESTUDIANTEToolStripMenuItem, Me.ANAMNESISToolStripMenuItem, Me.DIAGNOSTICOToolStripMenuItem, Me.EXAMENFISICOESTOMATOLOGICOToolStripMenuItem, Me.ODOTOGRAMAToolStripMenuItem, Me.REGISTRODIARIOToolStripMenuItem, Me.SALIRToolStripMenuItem})
        Me.MENUToolStripMenuItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.MENUToolStripMenuItem.Name = "MENUToolStripMenuItem"
        Me.MENUToolStripMenuItem.Size = New System.Drawing.Size(59, 20)
        Me.MENUToolStripMenuItem.Text = "MENU"
        '
        'ESTUDIANTEToolStripMenuItem
        '
        Me.ESTUDIANTEToolStripMenuItem.Name = "ESTUDIANTEToolStripMenuItem"
        Me.ESTUDIANTEToolStripMenuItem.Size = New System.Drawing.Size(303, 22)
        Me.ESTUDIANTEToolStripMenuItem.Text = "ESTUDIANTE"
        '
        'ANAMNESISToolStripMenuItem
        '
        Me.ANAMNESISToolStripMenuItem.Name = "ANAMNESISToolStripMenuItem"
        Me.ANAMNESISToolStripMenuItem.Size = New System.Drawing.Size(303, 22)
        Me.ANAMNESISToolStripMenuItem.Text = "ANAMNESIS"
        '
        'DIAGNOSTICOToolStripMenuItem
        '
        Me.DIAGNOSTICOToolStripMenuItem.Name = "DIAGNOSTICOToolStripMenuItem"
        Me.DIAGNOSTICOToolStripMenuItem.Size = New System.Drawing.Size(303, 22)
        Me.DIAGNOSTICOToolStripMenuItem.Text = "DIAGNOSTICO"
        '
        'EXAMENFISICOESTOMATOLOGICOToolStripMenuItem
        '
        Me.EXAMENFISICOESTOMATOLOGICOToolStripMenuItem.Name = "EXAMENFISICOESTOMATOLOGICOToolStripMenuItem"
        Me.EXAMENFISICOESTOMATOLOGICOToolStripMenuItem.Size = New System.Drawing.Size(303, 22)
        Me.EXAMENFISICOESTOMATOLOGICOToolStripMenuItem.Text = "EXAMEN FISICO ESTOMATOLOGICO"
        '
        'ODOTOGRAMAToolStripMenuItem
        '
        Me.ODOTOGRAMAToolStripMenuItem.Name = "ODOTOGRAMAToolStripMenuItem"
        Me.ODOTOGRAMAToolStripMenuItem.Size = New System.Drawing.Size(303, 22)
        Me.ODOTOGRAMAToolStripMenuItem.Text = "ODOTOGRAMA"
        '
        'REGISTRODIARIOToolStripMenuItem
        '
        Me.REGISTRODIARIOToolStripMenuItem.Name = "REGISTRODIARIOToolStripMenuItem"
        Me.REGISTRODIARIOToolStripMenuItem.Size = New System.Drawing.Size(303, 22)
        Me.REGISTRODIARIOToolStripMenuItem.Text = "REGISTRO DIARIO"
        '
        'SALIRToolStripMenuItem
        '
        Me.SALIRToolStripMenuItem.Name = "SALIRToolStripMenuItem"
        Me.SALIRToolStripMenuItem.Size = New System.Drawing.Size(303, 22)
        Me.SALIRToolStripMenuItem.Text = "SALIR"
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(612, 28)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(201, 37)
        Me.Label1.TabIndex = 57
        Me.Label1.Text = "CONSULTA"
        '
        'T1
        '
        Me.T1.Enabled = True
        '
        'fh
        '
        Me.fh.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem
        Me.fh.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.fh.Location = New System.Drawing.Point(877, 247)
        Me.fh.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.fh.Name = "fh"
        Me.fh.Size = New System.Drawing.Size(270, 23)
        Me.fh.TabIndex = 58
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(1172, 83)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 15)
        Me.Label2.TabIndex = 59
        '
        'MenuStrip2
        '
        Me.MenuStrip2.BackColor = System.Drawing.Color.Transparent
        Me.MenuStrip2.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1})
        Me.MenuStrip2.Location = New System.Drawing.Point(234, 47)
        Me.MenuStrip2.Name = "MenuStrip2"
        Me.MenuStrip2.Padding = New System.Windows.Forms.Padding(7, 2, 0, 2)
        Me.MenuStrip2.Size = New System.Drawing.Size(158, 26)
        Me.MenuStrip2.TabIndex = 129
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
        Me.CONSULTADataGridView.Location = New System.Drawing.Point(136, 628)
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
        Me.CONSULTADataGridView.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.CONSULTADataGridView.ShowEditingIcon = False
        Me.CONSULTADataGridView.Size = New System.Drawing.Size(1186, 103)
        Me.CONSULTADataGridView.TabIndex = 129
        Me.CONSULTADataGridView.VirtualMode = True
        Me.CONSULTADataGridView.Visible = False
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TB})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(147, 26)
        '
        'TB
        '
        Me.TB.Name = "TB"
        Me.TB.Size = New System.Drawing.Size(146, 22)
        Me.TB.Text = "Mostrar Tabla"
        '
        'Consultar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1370, 772)
        Me.ContextMenuStrip = Me.ContextMenuStrip1
        Me.Controls.Add(Me.CONSULTADataGridView)
        Me.Controls.Add(Me.MenuStrip2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.fh)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.NUEVO)
        Me.Controls.Add(Me.BUS)
        Me.Controls.Add(INCAPACIDAD__DIAS_Label)
        Me.Controls.Add(Me.INCAPACIDAD__DIAS_TextBox)
        Me.Controls.Add(OBSERVACIONESLabel)
        Me.Controls.Add(Me.OBSERVACIONESTextBox)
        Me.Controls.Add(TRATAMIENTOLabel)
        Me.Controls.Add(Me.TRATAMIENTOTextBox)
        Me.Controls.Add(N__CITAS_CUMPLIDASLabel)
        Me.Controls.Add(Me.N__CITAS_CUMPLIDASTextBox)
        Me.Controls.Add(FECHALabel)
        Me.Controls.Add(Me.FECHADateTimePicker)
        Me.Controls.Add(TRATAMIENTO_POR_REALIZARLabel)
        Me.Controls.Add(Me.TRATAMIENTO_POR_REALIZARTextBox)
        Me.Controls.Add(EDADLabel)
        Me.Controls.Add(Me.EDADTextBox)
        Me.Controls.Add(APELLIDOSLabel)
        Me.Controls.Add(Me.APELLIDOSTextBox)
        Me.Controls.Add(NOMBRESLabel)
        Me.Controls.Add(Me.NOMBRESTextBox)
        Me.Controls.Add(DOCUMENTO_DE_IDENTIDADLabel)
        Me.Controls.Add(Me.DOCUMENTO_DE_IDENTIDADTextBox)
        Me.Controls.Add(SECCIONLabel)
        Me.Controls.Add(Me.SECCIONTextBox)
        Me.Controls.Add(CODIGO_ELabel)
        Me.Controls.Add(Me.CODIGO_ETextBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "Consultar"
        Me.Text = "Form1"
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
    Friend WithEvents CODIGO_ETextBox As System.Windows.Forms.TextBox
    Friend WithEvents SECCIONTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DOCUMENTO_DE_IDENTIDADTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NOMBRESTextBox As System.Windows.Forms.TextBox
    Friend WithEvents APELLIDOSTextBox As System.Windows.Forms.TextBox
    Friend WithEvents EDADTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TRATAMIENTO_POR_REALIZARTextBox As System.Windows.Forms.TextBox
    Friend WithEvents FECHADateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents N__CITAS_CUMPLIDASTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TRATAMIENTOTextBox As System.Windows.Forms.TextBox
    Friend WithEvents OBSERVACIONESTextBox As System.Windows.Forms.TextBox
    Friend WithEvents INCAPACIDAD__DIAS_TextBox As System.Windows.Forms.TextBox
    Friend WithEvents BUS As System.Windows.Forms.Button
    Friend WithEvents NUEVO As System.Windows.Forms.Button
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents MENUToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents REGISTRODIARIOToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ESTUDIANTEToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ANAMNESISToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EXAMENFISICOESTOMATOLOGICOToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ODOTOGRAMAToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DIAGNOSTICOToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SALIRToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents T1 As System.Windows.Forms.Timer
    Friend WithEvents fh As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
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
    Friend WithEvents MS As System.Windows.Forms.ToolTip
    Friend WithEvents CONSULTADataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents TB As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CODIGOEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SECCIONDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DOCUMENTODEIDENTIDADDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NOMBRESDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents APELLIDOSDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EDADDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TRATAMIENTOPORREALIZARDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FECHADataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NCITASCUMPLIDASDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TRATAMIENTODataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents OBSERVACIONESDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents INCAPACIDADDIASDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
