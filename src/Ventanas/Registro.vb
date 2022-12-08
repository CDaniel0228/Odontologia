
Imports System.Text
Imports System.IO
Public Class Registro

    Dim lastPath As String
    Dim a As String = 0

    Private Sub REGISTRO_DIARIOBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        'Me.REGISTRO_DIARIOBindingSource.EndEdit()
        'Me.TableAdapterManager.UpdateAll(Me.CONSULTORIO_ODONTOLOGICODataSet)

    End Sub
    Private Sub Form8_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'CONSULTORIO_ODONTOLOGICODataSet.REGISTRO_DIARIO' table. You can move, or remove it, as needed.
        'Me.REGISTRO_DIARIOTableAdapter.Fill(Me.CONSULTORIO_ODONTOLOGICODataSet.REGISTRO_DIARIO)
        textos()
        cargar()
        ContextMenuStrip1.Enabled = False
    End Sub

    Private Sub textos()

        CODIGO_REGISTRO_DIARIOTextBox.Text = ""
        NUMEROTextBox.Text = ""
        FECHADateTimePicker.Text = ""
        NOMBRE_ESTUDIANTETextBox.Text = ""
        TRATAMIENTOTextBox.Text = ""
        CONDUCTOSTextBox.Text = ""
        RADICULARESTextBox.Text = ""
        EXODONCIASTextBox.Text = ""
        INCAPACIDAD__DIAS_TextBox.Text = ""
        INTERCONSULTATextBox.Text = ""
        OTROSTextBox.Text = ""
        TRATAMIENTO_I___FTextBox.Text = ""
        N__CITAS_CUMPLIDASTextBox.Text = ""
        PREESCRIPCIONESTextBox.Text = ""
        OBSERVACIONESTextBox.Text = ""
    End Sub
    Public Sub guardar()
        Dim save As String = "./F7.txt"
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
        Dim save As String = "./F7.txt"
        lastPath = My.Computer.FileSystem.ReadAllText("C:\Users\familiar\Documents\BASE DE DATOS\cod2\bin\Debug\F7.txt")
        If lastPath <> "" Then

            cargarImagen(False)
        End If

    End Sub


    Private Sub Buscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If CODIGO_REGISTRO_DIARIOTextBox.Text <> String.Empty Then
            'Me.REGISTRO_DIARIOTableAdapter.FillBy(Me.CONSULTORIO_ODONTOLOGICODataSet.REGISTRO_DIARIO, CODIGO_REGISTRO_DIARIOTextBox.Text)
            ContextMenuStrip1.Enabled = True
            If NOMBRE_ESTUDIANTETextBox.Text = "" Then
                MessageBox.Show("Codigo No Existe")

            End If
        Else
            MessageBox.Show("digite un codigo valido")

        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        textos()
    End Sub

    Private Sub EDITAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EDITAR.Click
        Try

            If Me.ValidateChildren And CODIGO_REGISTRO_DIARIOTextBox.Text <> String.Empty And NUMEROTextBox.Text <> String.Empty And FECHADateTimePicker.Text <> String.Empty And NOMBRE_ESTUDIANTETextBox.Text <> String.Empty And TRATAMIENTOTextBox.Text <> String.Empty And CONDUCTOSTextBox.Text <> String.Empty And RADICULARESTextBox.Text <> String.Empty And EXODONCIASTextBox.Text <> String.Empty And INCAPACIDAD__DIAS_TextBox.Text <> String.Empty And INTERCONSULTATextBox.Text <> String.Empty And OTROSTextBox.Text <> String.Empty And TRATAMIENTO_I___FTextBox.Text <> String.Empty And N__CITAS_CUMPLIDASTextBox.Text <> String.Empty And PREESCRIPCIONESTextBox.Text <> String.Empty And OBSERVACIONESTextBox.Text <> String.Empty Then

                'Me.REGISTRO_DIARIOTableAdapter.EDITAR(CODIGO_REGISTRO_DIARIOTextBox.Text, NUMEROTextBox.Text, FECHADateTimePicker.Text, NOMBRE_ESTUDIANTETextBox.Text, TRATAMIENTOTextBox.Text, CONDUCTOSTextBox.Text, RADICULARESTextBox.Text, EXODONCIASTextBox.Text, INCAPACIDAD__DIAS_TextBox.Text, INTERCONSULTATextBox.Text, OTROSTextBox.Text, TRATAMIENTO_I___FTextBox.Text, N__CITAS_CUMPLIDASTextBox.Text, PREESCRIPCIONESTextBox.Text, OBSERVACIONESTextBox.Text, CODIGO_REGISTRO_DIARIOTextBox.Text)
                'Me.REGISTRO_DIARIOTableAdapter.Fill(Me.CONSULTORIO_ODONTOLOGICODataSet.REGISTRO_DIARIO)

                MessageBox.Show("se a editado con exito")
                textos()

            Else
                MessageBox.Show("No se permiten campos vacios", "error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub INSERTAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles INSERTAR.Click

        Try

            If Me.ValidateChildren And CODIGO_REGISTRO_DIARIOTextBox.Text <> String.Empty And NUMEROTextBox.Text <> String.Empty And FECHADateTimePicker.Text <> String.Empty And NOMBRE_ESTUDIANTETextBox.Text <> String.Empty And TRATAMIENTOTextBox.Text <> String.Empty And CONDUCTOSTextBox.Text <> String.Empty And RADICULARESTextBox.Text <> String.Empty And EXODONCIASTextBox.Text <> String.Empty And INCAPACIDAD__DIAS_TextBox.Text <> String.Empty And INTERCONSULTATextBox.Text <> String.Empty And OTROSTextBox.Text <> String.Empty And TRATAMIENTO_I___FTextBox.Text <> String.Empty And N__CITAS_CUMPLIDASTextBox.Text <> String.Empty And PREESCRIPCIONESTextBox.Text <> String.Empty And OBSERVACIONESTextBox.Text <> String.Empty Then

                'Me.REGISTRO_DIARIOTableAdapter.wey(CODIGO_REGISTRO_DIARIOTextBox.Text, NUMEROTextBox.Text, FECHADateTimePicker.Text, NOMBRE_ESTUDIANTETextBox.Text, TRATAMIENTOTextBox.Text, CONDUCTOSTextBox.Text, RADICULARESTextBox.Text, EXODONCIASTextBox.Text, INCAPACIDAD__DIAS_TextBox.Text, INTERCONSULTATextBox.Text, OTROSTextBox.Text, TRATAMIENTO_I___FTextBox.Text, N__CITAS_CUMPLIDASTextBox.Text, PREESCRIPCIONESTextBox.Text, OBSERVACIONESTextBox.Text)
                'Me.REGISTRO_DIARIOTableAdapter.Fill(Me.CONSULTORIO_ODONTOLOGICODataSet.REGISTRO_DIARIO)

                MessageBox.Show("se a agragado con exito")
                textos()

            Else
                MessageBox.Show("No se permiten campos vacios", "error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ELIMINAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ELIMINAR.Click
        Try

            If Me.ValidateChildren And CODIGO_REGISTRO_DIARIOTextBox.Text <> String.Empty And NUMEROTextBox.Text <> String.Empty And FECHADateTimePicker.Text <> String.Empty And NOMBRE_ESTUDIANTETextBox.Text <> String.Empty And TRATAMIENTOTextBox.Text <> String.Empty And CONDUCTOSTextBox.Text <> String.Empty And RADICULARESTextBox.Text <> String.Empty And EXODONCIASTextBox.Text <> String.Empty And INCAPACIDAD__DIAS_TextBox.Text <> String.Empty And INTERCONSULTATextBox.Text <> String.Empty And OTROSTextBox.Text <> String.Empty And TRATAMIENTO_I___FTextBox.Text <> String.Empty And N__CITAS_CUMPLIDASTextBox.Text <> String.Empty And PREESCRIPCIONESTextBox.Text <> String.Empty And OBSERVACIONESTextBox.Text <> String.Empty Then
                Dim opcion As DialogResult
                opcion = MessageBox.Show("Realmende desea Eliminar",
                                        "ELIMINAR",
                                        MessageBoxButtons.YesNo,
                                        MessageBoxIcon.Question)
                If (opcion = DialogResult.Yes) Then
                    'Me.REGISTRO_DIARIOTableAdapter.eliminar(CODIGO_REGISTRO_DIARIOTextBox.Text)
                    'Me.REGISTRO_DIARIOTableAdapter.Fill(Me.CONSULTORIO_ODONTOLOGICODataSet.REGISTRO_DIARIO)

                    MessageBox.Show("se a eliminado con exito")
                    textos()
                End If
            Else
                MessageBox.Show("No se permiten campos vacios", "error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub CONSULTA_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CONSULTA.Click
        Consultar.Show()
        Me.Hide()
    End Sub

    Private Sub ESTUDIANTEToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ESTUDIANTEToolStripMenuItem.Click
        Estudiante.Show()
        Me.Hide()
    End Sub

    Private Sub ANAMNESIS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ANAMNESIS.Click
        'Form3.Show()
        Me.Hide()
    End Sub

    Private Sub DIAGNOSTICO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DIAGNOSTICO.Click
        'Form4.Show()
        Me.Hide()
    End Sub

    Private Sub EXAMENFISICOESTOMATOLOGICOToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EXAMENFISICOESTOMATOLOGICOToolStripMenuItem.Click
        'Form5.Show()
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

    Private Sub CambiarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CambiarToolStripMenuItem.Click
        cargarImagen(True)
    End Sub

    Private Sub GUARDARCAMBIOSToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GUARDARCAMBIOSToolStripMenuItem.Click
        guardar()
    End Sub

    Private Sub OCULTARToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OCULTARToolStripMenuItem.Click
        Me.WindowState = FormWindowState.Minimized
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

    Private Sub REGISTRODIARIOToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles REGISTRODIARIOToolStripMenuItem.Click
        'Form6.Show()
        Me.Hide()
    End Sub

    Private Sub TB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TB.Click
        If a = 0 Then
            Me.CONSULTADataGridView.Visible = True
            TB.Text = "OcultarTabla"
            a = 1
        Else
            If a = 1 Then
                Me.CONSULTADataGridView.Visible = False
                TB.Text = "Mostrar Tabla"

                a = 0
            End If

        End If
    End Sub
End Class




