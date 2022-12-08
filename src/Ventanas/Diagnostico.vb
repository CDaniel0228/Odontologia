Imports System.Text
Imports System.IO
Public Class Diagnostico
    Dim lastPath As String
    Dim a As String = 0
    Private Sub DIAGNOSTICOBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        'Me.TableAdapterManager.UpdateAll(Me.CONSULTORIO_ODONTOLOGICODataSet)

    End Sub
    Public Sub guardar()
        Dim save As String = "./F4.txt"
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
        Dim save As String = "./F4.txt"
        lastPath = My.Computer.FileSystem.ReadAllText("C:\Users\familiar\Documents\BASE DE DATOS\cod2\bin\Debug\F4.txt")
        If lastPath <> "" Then

            cargarImagen(False)
        End If

    End Sub
    Private Sub Textos()
        CODIGO_DIAGNOSTICOTextBox.Text = ""
        TRATAMIENTO_POR_REALIZARTextBox.Text = ""
        DIENTES_PARA_TRATAMIENTOTextBox.Text = ""
        FECHADateTimePicker.Text = ""
        NOMBRE_ODONTOLOGATextBox.Text = ""
        CODIGO_ETextBox.Text = ""
    End Sub

    Private Sub Form4_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'CONSULTORIO_ODONTOLOGICODataSet.DIAGNOSTICO' Puede moverla o quitarla según sea necesario.
        'Me.DIAGNOSTICOTableAdapter.Fill(Me.CONSULTORIO_ODONTOLOGICODataSet.DIAGNOSTICO)
        Textos()
        cargar()
        TB.Enabled = False
    End Sub

    Private Sub INSERTAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles INSERTAR.Click
       
        Try

            If Me.ValidateChildren And CODIGO_DIAGNOSTICOTextBox.Text <> String.Empty And TRATAMIENTO_POR_REALIZARTextBox.Text <> String.Empty And DIENTES_PARA_TRATAMIENTOTextBox.Text <> String.Empty And FECHADateTimePicker.Text <> String.Empty And NOMBRE_ODONTOLOGATextBox.Text <> String.Empty And CODIGO_ETextBox.Text <> String.Empty Then

                'Me.DIAGNOSTICOTableAdapter.INSERTAR(CODIGO_DIAGNOSTICOTextBox.Text, TRATAMIENTO_POR_REALIZARTextBox.Text, DIENTES_PARA_TRATAMIENTOTextBox.Text, FECHADateTimePicker.Text, NOMBRE_ODONTOLOGATextBox.Text, CODIGO_ETextBox.Text)
                'Me.DIAGNOSTICOTableAdapter.Fill(Me.CONSULTORIO_ODONTOLOGICODataSet.DIAGNOSTICO)
                MessageBox.Show("se a guardado con exito")
                Textos()

            Else
                MessageBox.Show("No se permiten campos vacios", "error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Textos()
    End Sub

    Private Sub ELIMINAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ELIMINAR.Click
        Try

            If Me.ValidateChildren And CODIGO_DIAGNOSTICOTextBox.Text <> String.Empty And TRATAMIENTO_POR_REALIZARTextBox.Text <> String.Empty And DIENTES_PARA_TRATAMIENTOTextBox.Text <> String.Empty And FECHADateTimePicker.Text <> String.Empty And NOMBRE_ODONTOLOGATextBox.Text <> String.Empty And CODIGO_ETextBox.Text <> String.Empty Then
                Dim opcion As DialogResult
                opcion = MessageBox.Show("Realmende desea Eliminar",
                                         "ELIMINAR",
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question)
                If (opcion = DialogResult.Yes) Then

                    'Me.DIAGNOSTICOTableAdapter.ELIMINAR(CODIGO_DIAGNOSTICOTextBox.Text, TRATAMIENTO_POR_REALIZARTextBox.Text, DIENTES_PARA_TRATAMIENTOTextBox.Text, FECHADateTimePicker.Text, NOMBRE_ODONTOLOGATextBox.Text, CODIGO_ETextBox.Text)
                    'Me.DIAGNOSTICOTableAdapter.Fill(Me.CONSULTORIO_ODONTOLOGICODataSet.DIAGNOSTICO)
                    MessageBox.Show("se a Eliminado con exito")
                    Textos()
                End If
            Else
                MessageBox.Show("No se permiten campos vacios", "error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub EDITAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EDITAR.Click
        Try

            If Me.ValidateChildren And CODIGO_DIAGNOSTICOTextBox.Text <> String.Empty And TRATAMIENTO_POR_REALIZARTextBox.Text <> String.Empty And DIENTES_PARA_TRATAMIENTOTextBox.Text <> String.Empty And FECHADateTimePicker.Text <> String.Empty And NOMBRE_ODONTOLOGATextBox.Text <> String.Empty And CODIGO_ETextBox.Text <> String.Empty Then

                'Me.DIAGNOSTICOTableAdapter.EDITAR(CODIGO_DIAGNOSTICOTextBox.Text, TRATAMIENTO_POR_REALIZARTextBox.Text, DIENTES_PARA_TRATAMIENTOTextBox.Text, FECHADateTimePicker.Text, NOMBRE_ODONTOLOGATextBox.Text, CODIGO_ETextBox.Text, CODIGO_DIAGNOSTICOTextBox.Text)
                'Me.DIAGNOSTICOTableAdapter.Fill(Me.CONSULTORIO_ODONTOLOGICODataSet.DIAGNOSTICO)
                MessageBox.Show("se a cambiado con exito")
                Textos()

            Else
                MessageBox.Show("No se permiten campos vacios", "error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BUSCAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If CODIGO_DIAGNOSTICOTextBox.Text <> String.Empty Then

            'Me.DIAGNOSTICOTableAdapter.FillBy(Me.CONSULTORIO_ODONTOLOGICODataSet.DIAGNOSTICO, CODIGO_DIAGNOSTICOTextBox.Text)
            TB.Enabled = True
            If TRATAMIENTO_POR_REALIZARTextBox.Text = "" Then
                MessageBox.Show("Codigo No Existe")

            End If

        Else
            MessageBox.Show("digite un codigo correcto")

        End If
    End Sub

    Private Sub CONSULTA_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CONSULTA.Click
        Consultar.Show()
        Me.Hide()
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

    Private Sub REGISTRODIARIOToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles REGISTRODIARIOToolStripMenuItem.Click
        'Form8.Show()
        Me.Hide()
    End Sub

    Private Sub ODOTOGRAMAToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ODOTOGRAMAToolStripMenuItem.Click
        'Form6.Show()
        Me.Hide()
    End Sub

    Private Sub EXAMENFISICOESTOMATOLOGICOToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EXAMENFISICOESTOMATOLOGICOToolStripMenuItem.Click
        'Form5.Show()
        Me.Hide()
    End Sub

    Private Sub ANAMNESIS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ANAMNESIS.Click
        'Form3.Show()
        Me.Hide()
    End Sub

    Private Sub OCULTARToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OCULTARToolStripMenuItem.Click
        Me.WindowState = FormWindowState.Minimized
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

    Private Sub MOSTRARTABLAToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TIB.Click
        If a = 0 Then
            Me.CONSULTADataGridView.Visible = True
            TIB.Text = "OcultarTabla"
            a = 1
        Else
            If a = 1 Then
                Me.CONSULTADataGridView.Visible = False
                TIB.Text = "Mostrar Tabla"

                a = 0
            End If

        End If
    End Sub
End Class