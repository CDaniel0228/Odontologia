Imports System.Text
Imports System.IO
Public Class Estomatologico
    Dim lastPath As String
    Dim a As String = 0
    Private Sub EXAMEN_FISICOBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        'Me.TableAdapterManager.UpdateAll(Me.CONSULTORIO_ODONTOLOGICODataSet)

    End Sub
    Private Sub textos()
        CODIGO_EXAMENTextBox.Text = ""
        HIGIENE_ORALTextBox.Text = ""
        PROBLEMA_DENTALTextBox.Text = ""
        SEDA_DENTALTextBox.Text = ""
        OBSERVACIONESTextBox.Text = ""
        CODIGO_ODONTOGRAMATextBox.Text = ""
    End Sub
    Public Sub guardar()
        Dim save As String = "./F5.txt"
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
        Dim save As String = "./F5.txt"
        lastPath = My.Computer.FileSystem.ReadAllText("C:\Users\familiar\Documents\BASE DE DATOS\cod2\bin\Debug\F5.txt")
        If lastPath <> "" Then

            cargarImagen(False)
        End If

    End Sub


    Private Sub Form5_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'CONSULTORIO_ODONTOLOGICODataSet.EXAMEN_FISICO' Puede moverla o quitarla según sea necesario.
        'Me.EXAMEN_FISICOTableAdapter.Fill(Me.CONSULTORIO_ODONTOLOGICODataSet.EXAMEN_FISICO)
        textos()
        cargar()
        TB.Enabled = False
    End Sub

    Private Sub Buscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If CODIGO_EXAMENTextBox.Text <> String.Empty Then
            'Me.EXAMEN_FISICOTableAdapter.FillBy(Me.CONSULTORIO_ODONTOLOGICODataSet.EXAMEN_FISICO, CODIGO_EXAMENTextBox.Text)
            TB.Enabled = True
            If HIGIENE_ORALTextBox.Text = "" Then
                MessageBox.Show("Codigo No Existe")

            End If

        Else
            MessageBox.Show("digite un codigo correcto")
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Textos()
    End Sub

    Private Sub EDITAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EDITAR.Click
       
        Try

            If Me.ValidateChildren And CODIGO_EXAMENTextBox.Text <> String.Empty And HIGIENE_ORALTextBox.Text <> String.Empty And PROBLEMA_DENTALTextBox.Text <> String.Empty And SEDA_DENTALTextBox.Text <> String.Empty And OBSERVACIONESTextBox.Text <> String.Empty And CODIGO_ODONTOGRAMATextBox.Text <> String.Empty Then

                'Me.EXAMEN_FISICOTableAdapter.EDITAR(CODIGO_EXAMENTextBox.Text, HIGIENE_ORALTextBox.Text, PROBLEMA_DENTALTextBox.Text, SEDA_DENTALTextBox.Text, OBSERVACIONESTextBox.Text, CODIGO_ODONTOGRAMATextBox.Text, CODIGO_EXAMENTextBox.Text)
                'Me.EXAMEN_FISICOTableAdapter.Fill(Me.CONSULTORIO_ODONTOLOGICODataSet.EXAMEN_FISICO)

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

            If Me.ValidateChildren And CODIGO_EXAMENTextBox.Text <> String.Empty And HIGIENE_ORALTextBox.Text <> String.Empty And PROBLEMA_DENTALTextBox.Text <> String.Empty And SEDA_DENTALTextBox.Text <> String.Empty And OBSERVACIONESTextBox.Text <> String.Empty And CODIGO_ODONTOGRAMATextBox.Text <> String.Empty Then

                'Me.EXAMEN_FISICOTableAdapter.INSERTAR(CODIGO_EXAMENTextBox.Text, HIGIENE_ORALTextBox.Text, PROBLEMA_DENTALTextBox.Text, SEDA_DENTALTextBox.Text, OBSERVACIONESTextBox.Text, CODIGO_ODONTOGRAMATextBox.Text)
                'Me.EXAMEN_FISICOTableAdapter.Fill(Me.CONSULTORIO_ODONTOLOGICODataSet.EXAMEN_FISICO)

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

            If Me.ValidateChildren And CODIGO_EXAMENTextBox.Text <> String.Empty And HIGIENE_ORALTextBox.Text <> String.Empty And PROBLEMA_DENTALTextBox.Text <> String.Empty And SEDA_DENTALTextBox.Text <> String.Empty And OBSERVACIONESTextBox.Text <> String.Empty And CODIGO_ODONTOGRAMATextBox.Text <> String.Empty Then
                Dim opcion As DialogResult
                opcion = MessageBox.Show("Realmende desea Eliminar",
                                        "ELIMINAR",
                                        MessageBoxButtons.YesNo,
                                        MessageBoxIcon.Question)
                If (opcion = DialogResult.Yes) Then
                    'Me.EXAMEN_FISICOTableAdapter.ELIMINAR(CODIGO_EXAMENTextBox.Text, HIGIENE_ORALTextBox.Text, PROBLEMA_DENTALTextBox.Text, SEDA_DENTALTextBox.Text, OBSERVACIONESTextBox.Text, CODIGO_ODONTOGRAMATextBox.Text)
                    'Me.EXAMEN_FISICOTableAdapter.Fill(Me.CONSULTORIO_ODONTOLOGICODataSet.EXAMEN_FISICO)

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

    Private Sub DIAGNOSTICOToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DIAGNOSTICOToolStripMenuItem.Click
        Diagnostico.Show()
        Me.Hide()
    End Sub

    Private Sub ANAMNESIS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ANAMNESIS.Click
        'Form3.Show()
        Me.Hide()
    End Sub

    Private Sub REGISTRODIARIOToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles REGISTRODIARIOToolStripMenuItem.Click
        'Form8.Show()
        Me.Hide()
    End Sub

    Private Sub ODOTOGRAMAToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ODOTOGRAMAToolStripMenuItem.Click
        'Form6.Show()
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

    Private Sub PROBLEMA_DENTALLabel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub ZOOMToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.BackgroundImageLayout = ImageLayout.Zoom
    End Sub

    Private Sub COMPLETAToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.BackgroundImageLayout = ImageLayout.Stretch
    End Sub

    Private Sub CENTROToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.BackgroundImageLayout = ImageLayout.Center
    End Sub

    Private Sub CambiarToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CambiarToolStripMenuItem.Click
        cargarImagen(True)
    End Sub

    Private Sub GUARDARCAMBIOSToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GUARDARCAMBIOSToolStripMenuItem.Click
        guardar()
    End Sub

    Private Sub OCULTARToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OCULTARToolStripMenuItem.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    
    Private Sub MOSTRARTABLAToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MOSTRARTABLAToolStripMenuItem.Click
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