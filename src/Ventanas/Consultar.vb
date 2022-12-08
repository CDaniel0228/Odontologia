Imports System.IO
Imports System.Text
Public Class Consultar
    Dim a As String
    Dim k As String
    Dim lastPath As String
    Dim ñ As String = 0
    Dim tx As String
    Private Sub textos()
        CODIGO_ETextBox.Text = ""
        SECCIONTextBox.Text = ""
        DOCUMENTO_DE_IDENTIDADTextBox.Text = ""
        NOMBRESTextBox.Text = ""
        APELLIDOSTextBox.Text = ""
        EDADTextBox.Text = ""
        TRATAMIENTO_POR_REALIZARTextBox.Text = ""
        FECHADateTimePicker.Text = ""
        N__CITAS_CUMPLIDASTextBox.Text = ""
        TRATAMIENTOTextBox.Text = ""
        OBSERVACIONESTextBox.Text = ""
        INCAPACIDAD__DIAS_TextBox.Text = ""



    End Sub
    Private Sub bacio(ByRef e As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = True

        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = True
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = True
        Else
            e.Handled = True
        End If
    End Sub
    Private Sub nada()
        SECCIONTextBox.Enabled = False
        DOCUMENTO_DE_IDENTIDADTextBox.Enabled = False
        NOMBRESTextBox.Enabled = False
        APELLIDOSTextBox.Enabled = False
        EDADTextBox.Enabled = False
        TRATAMIENTO_POR_REALIZARTextBox.Enabled = False
        FECHADateTimePicker.Enabled = False
        N__CITAS_CUMPLIDASTextBox.Enabled = False
        TRATAMIENTOTextBox.Enabled = False
        OBSERVACIONESTextBox.Enabled = False
        INCAPACIDAD__DIAS_TextBox.Enabled = False
    End Sub
    Private Sub volver()
        SECCIONTextBox.Enabled = True
        DOCUMENTO_DE_IDENTIDADTextBox.Enabled = True
        NOMBRESTextBox.Enabled = True
        APELLIDOSTextBox.Enabled = True
        EDADTextBox.Enabled = True
        TRATAMIENTO_POR_REALIZARTextBox.Enabled = True
        FECHADateTimePicker.Enabled = True
        N__CITAS_CUMPLIDASTextBox.Enabled = True
        TRATAMIENTOTextBox.Enabled = True
        OBSERVACIONESTextBox.Enabled = True
        INCAPACIDAD__DIAS_TextBox.Enabled = True
    End Sub
    Public Sub guardar()
        Dim save As String = "./F1.txt"
        Dim fs As FileStream = File.Create(save)
        Dim info As Byte() = New UTF8Encoding(True).GetBytes(lastPath)
        fs.Write(info, 0, lastPath.Count)
        fs.Close()
    End Sub
    Public Sub cargarImagen(ByVal opt As Boolean)
        If opt Then
            If l.ShowDialog = Windows.Forms.DialogResult.OK Then
                lastPath = l.FileName
                Me.BackgroundImage = Image.FromFile(lastPath)

            End If
        Else
            Me.BackgroundImage = Image.FromFile(lastPath)
        End If
    End Sub
    Public Sub cargar()
        Dim save As String = "./F1.txt"
        lastPath = My.Computer.FileSystem.ReadAllText("C:\Users\Familiar\Documents\BASE DE DATOS\cod2\bin\Debug\F1.txt")
        If lastPath <> "" Then

            cargarImagen(False)
        End If

    End Sub








    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'CONSULTORIO_ODONTOLOGICODataSet.CONSULTA' Puede moverla o quitarla según sea necesario.
        ' textos()
        'nada()
        'cargar()
        fh.Visible = False


        Me.ContextMenuStrip1.Enabled = False


    End Sub

    Private Sub BUS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BUS.Click

        If CODIGO_ETextBox.Text <> String.Empty Then
            volver()
            FECHADateTimePicker.Visible = False
            fh.Visible = True
            ContextMenuStrip1.Enabled = True
            a = Format(FECHADateTimePicker.Value, "long date")
            fh.Text = a

            If NOMBRESTextBox.Text = "" Then
                MessageBox.Show("Codigo No Existe")
                nada()
                fh.Visible = False
                FECHADateTimePicker.Visible = True
            End If

        Else
            MessageBox.Show("digite un codigo")
            nada()
        End If

    End Sub

    Private Sub NUEVO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NUEVO.Click
        textos()
        nada()
        fh.Visible = False
        FECHADateTimePicker.Visible = True

    End Sub

    Private Sub ESTUDIANTEToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ESTUDIANTEToolStripMenuItem.Click
        Estudiante.Show()
        Me.Hide()
    End Sub


    Private Sub SALIRToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SALIRToolStripMenuItem.Click
        Dim opcion As DialogResult
        opcion = MessageBox.Show("Realmende desea Salir",
                                 "Salir del Programa",
                                 MessageBoxButtons.YesNo,
                                 MessageBoxIcon.Question)
        If (opcion = DialogResult.Yes) Then
            End
        End If
    End Sub

    Private Sub ANAMNESISToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ANAMNESISToolStripMenuItem.Click
        Anamnesis.Show()
        Me.Hide()
    End Sub

    Private Sub DIAGNOSTICOToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DIAGNOSTICOToolStripMenuItem.Click
        Diagnostico.Show()
        Me.Hide()
    End Sub

    Private Sub EXAMENFISICOESTOMATOLOGICOToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EXAMENFISICOESTOMATOLOGICOToolStripMenuItem.Click
        Estomatologico.Show()
        Me.Hide()
    End Sub

    Private Sub ODOTOGRAMAToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ODOTOGRAMAToolStripMenuItem.Click
        Odontograma.Show()
        Me.Hide()
    End Sub

    Private Sub REGISTRODIARIOToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles REGISTRODIARIOToolStripMenuItem.Click
        Registro.Show()
        Me.Hide()
    End Sub

    Private Sub SECCIONTextBox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles SECCIONTextBox.KeyPress
        Call bacio(e)
    End Sub

    Private Sub DOCUMENTO_DE_IDENTIDADTextBox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles DOCUMENTO_DE_IDENTIDADTextBox.KeyPress
        Call bacio(e)
    End Sub

    Private Sub EDADTextBox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles EDADTextBox.KeyPress
        Call bacio(e)
    End Sub

    Private Sub APELLIDOSTextBox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles APELLIDOSTextBox.KeyPress
        Call bacio(e)
    End Sub

    Private Sub NOMBRESTextBox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles NOMBRESTextBox.KeyPress
        Call bacio(e)
    End Sub

    Private Sub N__CITAS_CUMPLIDASTextBox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles N__CITAS_CUMPLIDASTextBox.KeyPress
        Call bacio(e)
    End Sub

    Private Sub INCAPACIDAD__DIAS_TextBox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles INCAPACIDAD__DIAS_TextBox.KeyPress
        Call bacio(e)
    End Sub

    Private Sub OBSERVACIONESTextBox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles OBSERVACIONESTextBox.KeyPress
        Call bacio(e)
    End Sub

    Private Sub TRATAMIENTOTextBox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TRATAMIENTOTextBox.KeyPress
        Call bacio(e)
    End Sub

    Private Sub TRATAMIENTO_POR_REALIZARTextBox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TRATAMIENTO_POR_REALIZARTextBox.KeyPress
        Call bacio(e)
    End Sub

    Private Sub T1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles T1.Tick
        ' Label2.Text = TimeOfDay.TimeOfDay.ToString
        'IDictionary(Of(spanish))

        'k = k + 1
        'If k = 3 Then
        'Dim ad As Object = CreateObject("SAPI.spvoice")
        'ad.volume = 100
        'ad.rate = -4
        'ad.speak("Bienvenido al consultorio Odontologico")
        'T1.Enabled = False
        'End If
        'If k = 4 Then
        'T1.Enabled = False
        'End If


    End Sub

    Private Sub fh_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles fh.KeyPress
        Call bacio(e)
    End Sub

    Private Sub CambiarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CambiarToolStripMenuItem.Click
        cargarImagen(True)
    End Sub

    Private Sub GUARDARCAMBIOSToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GUARDARCAMBIOSToolStripMenuItem.Click
        guardar()
    End Sub

    Private Sub CENTROToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CENTROToolStripMenuItem.Click
        Me.BackgroundImageLayout = ImageLayout.Center
    End Sub

    Private Sub COMPLETAToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles COMPLETAToolStripMenuItem.Click
        Me.BackgroundImageLayout = ImageLayout.Stretch
    End Sub

    Private Sub ZOOMToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ZOOMToolStripMenuItem.Click
        Me.BackgroundImageLayout = ImageLayout.Zoom
    End Sub

    Private Sub OCULTARToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OCULTARToolStripMenuItem.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub fh_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fh.TextChanged

    End Sub

    Private Sub CODIGO_ETextBox_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CODIGO_ETextBox.KeyDown
        If e.KeyCode = Keys.Enter Then
            If CODIGO_ETextBox.Text <> String.Empty Then
                'Me.CONSULTATableAdapter.FillBy(Me.CONSULTORIO_ODONTOLOGICODataSet.CONSULTA, CODIGO_ETextBox.Text)
                volver()
                FECHADateTimePicker.Visible = False
                fh.Visible = True
                ContextMenuStrip1.Enabled = True
                a = Format(FECHADateTimePicker.Value, "long date")
                fh.Text = a

                If NOMBRESTextBox.Text = "" Then
                    MessageBox.Show("Codigo No Existe")
                    nada()
                    fh.Visible = False
                    FECHADateTimePicker.Visible = True
                End If

            Else
                MessageBox.Show("digite un codigo")
                nada()
            End If
        End If
    End Sub

    Private Sub CODIGO_ETextBox_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles CODIGO_ETextBox.MouseHover
        MS.SetToolTip(CODIGO_ETextBox, "DIGITE EL CODIGO DEL ESTUDIANTE")
        MS.ToolTipTitle = "codigo"
        MS.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub CODIGO_ETextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CODIGO_ETextBox.TextChanged
        tx = CODIGO_ETextBox.TextLength
    End Sub

    Private Sub ToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Registro.Show()
        Me.Hide()
    End Sub

    Private Sub CONSULTADataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles CONSULTADataGridView.CellContentClick

    End Sub

    Private Sub MenuStrip2_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles MenuStrip2.ItemClicked

    End Sub

    Private Sub ToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TB.Click

        If ñ = 0 Then
            CONSULTADataGridView.Visible = True
            TB.Text = "OcultarTabla"
            ñ = 1
        Else
            If ñ = 1 Then
                TB.Text = "Mostrar Tabla"
                CONSULTADataGridView.Visible = False
                ñ = 0
            End If

        End If
    End Sub


End Class
