Imports System.Text
Imports System.IO
Public Class Odontograma
    Dim lastPath As String
    Dim a As String = 0
    Private Sub ODONTOGRAMABindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        'Me.TableAdapterManager.UpdateAll(Me.CONSULTORIO_ODONTOLOGICODataSet)

    End Sub

    Private Sub textos()
        CODIGO_ODONTOGRAMATextBox.Text = ""
        DIENTES_SANOSTextBox.Text = ""
        DIENTES_CARIADOSTextBox.Text = ""
        DIENTES_OBTURADOSTextBox.Text = ""
        DIENTES_PERDIDOSTextBox.Text = ""
        OTROSTextBox.Text = ""
    End Sub
    Public Sub guardar()
        Dim save As String = "./F6.txt"
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
        Dim save As String = "./F6.txt"
        lastPath = My.Computer.FileSystem.ReadAllText("C:\Users\familiar\Documents\BASE DE DATOS\cod2\bin\Debug\F6.txt")
        If lastPath <> "" Then

            cargarImagen(False)
        End If

    End Sub
    Private Sub Form6_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'CONSULTORIO_ODONTOLOGICODataSet.ODONTOGRAMA' Puede moverla o quitarla según sea necesario.
        'Me.ODONTOGRAMATableAdapter.Fill(Me.CONSULTORIO_ODONTOLOGICODataSet.ODONTOGRAMA)
        textos()
        cargar()
        TB.Enabled = False
    End Sub

    Private Sub Buscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If CODIGO_ODONTOGRAMATextBox.Text <> String.Empty Then
            'Me.ODONTOGRAMATableAdapter.FillBy(Me.CONSULTORIO_ODONTOLOGICODataSet.ODONTOGRAMA, CODIGO_ODONTOGRAMATextBox.Text)
            TB.Enabled = True
            If DIENTES_SANOSTextBox.Text = "" Then
                MessageBox.Show("Codigo No Existe")

            End If
        Else
            MessageBox.Show("ingrese un codigo valido")

        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        textos()
    End Sub

    Private Sub EDITAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EDITAR.Click
        Try

            If Me.ValidateChildren And CODIGO_ODONTOGRAMATextBox.Text <> String.Empty And DIENTES_SANOSTextBox.Text <> String.Empty And DIENTES_CARIADOSTextBox.Text <> String.Empty And DIENTES_OBTURADOSTextBox.Text <> String.Empty And DIENTES_PERDIDOSTextBox.Text <> String.Empty And OTROSTextBox.Text <> String.Empty Then

                'Me.ODONTOGRAMATableAdapter.EDITAR(CODIGO_ODONTOGRAMATextBox.Text, DIENTES_SANOSTextBox.Text, DIENTES_CARIADOSTextBox.Text, DIENTES_OBTURADOSTextBox.Text, DIENTES_PERDIDOSTextBox.Text, OTROSTextBox.Text, CODIGO_ODONTOGRAMATextBox.Text)
                'Me.ODONTOGRAMATableAdapter.Fill(Me.CONSULTORIO_ODONTOLOGICODataSet.ODONTOGRAMA)

                MessageBox.Show("se a cambiado con exito")
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

            If Me.ValidateChildren And CODIGO_ODONTOGRAMATextBox.Text <> String.Empty And DIENTES_SANOSTextBox.Text <> String.Empty And DIENTES_CARIADOSTextBox.Text <> String.Empty And DIENTES_OBTURADOSTextBox.Text <> String.Empty And DIENTES_PERDIDOSTextBox.Text <> String.Empty And OTROSTextBox.Text <> String.Empty Then

                'Me.ODONTOGRAMATableAdapter.INSERTAR(CODIGO_ODONTOGRAMATextBox.Text, DIENTES_SANOSTextBox.Text, DIENTES_CARIADOSTextBox.Text, DIENTES_OBTURADOSTextBox.Text, DIENTES_PERDIDOSTextBox.Text, OTROSTextBox.Text)
                'Me.ODONTOGRAMATableAdapter.Fill(Me.CONSULTORIO_ODONTOLOGICODataSet.ODONTOGRAMA)

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

            If Me.ValidateChildren And CODIGO_ODONTOGRAMATextBox.Text <> String.Empty And DIENTES_SANOSTextBox.Text <> String.Empty And DIENTES_CARIADOSTextBox.Text <> String.Empty And DIENTES_OBTURADOSTextBox.Text <> String.Empty And DIENTES_PERDIDOSTextBox.Text <> String.Empty And OTROSTextBox.Text <> String.Empty Then
                Dim opcion As DialogResult
                opcion = MessageBox.Show("Realmende desea Eliminar",
                                        "ELIMINAR",
                                        MessageBoxButtons.YesNo,
                                        MessageBoxIcon.Question)
                If (opcion = DialogResult.Yes) Then
                    'Me.ODONTOGRAMATableAdapter.ELIMINAR(CODIGO_ODONTOGRAMATextBox.Text, DIENTES_SANOSTextBox.Text, DIENTES_CARIADOSTextBox.Text, DIENTES_OBTURADOSTextBox.Text, DIENTES_PERDIDOSTextBox.Text, OTROSTextBox.Text)
                    'Me.ODONTOGRAMATableAdapter.Fill(Me.CONSULTORIO_ODONTOLOGICODataSet.ODONTOGRAMA)

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

    Private Sub REGISTRODIARIOToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles REGISTRODIARIOToolStripMenuItem.Click
        'Form8.Show()
        Me.Hide()
    End Sub

    Private Sub CambiarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CambiarToolStripMenuItem.Click
        cargarImagen(True)
    End Sub

    Private Sub GUARDARCAMBIOSToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GUARDARCAMBIOSToolStripMenuItem.Click
        guardar()
    End Sub

   
    Private Sub LUGARToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LUGARToolStripMenuItem.Click

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