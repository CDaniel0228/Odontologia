Imports System.Text
Imports System.IO
Public Class Anamnesis
    Dim y, x, a As String
    Dim point As New System.Drawing.Point
    Dim lastPath As String
    Dim DATOS As String = Application.StartupPath & "\DATOS.txt"
    Dim a1, b2 As String
    Dim an As String = 0

    Private Sub ANAMNESISBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        'Me.TableAdapterManager.UpdateAll(Me.CONSULTORIO_ODONTOLOGICODataSet)

    End Sub

    Private Sub Textos()
        CODIGO_ANAMNESISTextBox.Text = ""
        TRATAMIENTO_MEDICOTextBox.Text = ""
        ENFERMEDADTextBox.Text = ""
        INGESTION_DE_MEDICAMENTOSTextBox.Text = ""
        OBSERVACIONESTextBox.Text = ""
    End Sub

    Public Sub guardar()
        Dim save As String = "./docs.txt"
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
        Dim save As String = "./docs.txt"
        lastPath = My.Computer.FileSystem.ReadAllText("C:\Users\familiar\Documents\BASE DE DATOS\cod2\bin\Debug\docs.txt")
        If lastPath <> "" Then

            cargarImagen(False)
        End If

    End Sub

    Private Sub Form3_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        My.Computer.FileSystem.WriteAllText(DATOS, a1 & vbCrLf &
            b2 & vbCrLf, False)
    End Sub


    Private Sub Form3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'CONSULTORIO_ODONTOLOGICODataSet.ANAMNESIS' Puede moverla o quitarla según sea necesario.
        'Me.ANAMNESISTableAdapter.Fill(Me.CONSULTORIO_ODONTOLOGICODataSet.ANAMNESIS)

        Textos()
        cargar()
        TB.Enabled = False

        Try
            a1 = File.ReadLines(DATOS)(0)
            b2 = File.ReadLines(DATOS)(1)


        Catch ex As Exception
        End Try

        If a1 <> String.Empty And b2 <> String.Empty Then

            Label1.Location = New Point(a1, b2)

        End If
    End Sub

    Private Sub INSERTAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles INSERTAR.Click
        Try

            If Me.ValidateChildren And CODIGO_ANAMNESISTextBox.Text <> String.Empty And TRATAMIENTO_MEDICOTextBox.Text <> String.Empty And ENFERMEDADTextBox.Text <> String.Empty And INGESTION_DE_MEDICAMENTOSTextBox.Text <> String.Empty And OBSERVACIONESTextBox.Text <> String.Empty Then

                'Me.ANAMNESISTableAdapter.INSERTAR(CODIGO_ANAMNESISTextBox.Text, TRATAMIENTO_MEDICOTextBox.Text, ENFERMEDADTextBox.Text, INGESTION_DE_MEDICAMENTOSTextBox.Text, OBSERVACIONESTextBox.Text)
                'Me.ANAMNESISTableAdapter.Fill(Me.CONSULTORIO_ODONTOLOGICODataSet.ANAMNESIS)
                MessageBox.Show("se a guardado con exito")
                Textos()

            Else
                MessageBox.Show("No se permiten campos vacios", "error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub limiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Textos()
    End Sub

    Private Sub ELIMINAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ELIMINAR.Click
        Try

            If Me.ValidateChildren And CODIGO_ANAMNESISTextBox.Text <> String.Empty And TRATAMIENTO_MEDICOTextBox.Text <> String.Empty And ENFERMEDADTextBox.Text <> String.Empty And INGESTION_DE_MEDICAMENTOSTextBox.Text <> String.Empty And OBSERVACIONESTextBox.Text <> String.Empty Then
                Dim opcion As DialogResult
                opcion = MessageBox.Show("desea eliminar los datos",
                                         "ELIMINAR",
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question)
                If (opcion = DialogResult.Yes) Then


                    'Me.ANAMNESISTableAdapter.ELIMINAR(CODIGO_ANAMNESISTextBox.Text, TRATAMIENTO_MEDICOTextBox.Text, ENFERMEDADTextBox.Text, INGESTION_DE_MEDICAMENTOSTextBox.Text, OBSERVACIONESTextBox.Text)
                    'Me.ANAMNESISTableAdapter.Fill(Me.CONSULTORIO_ODONTOLOGICODataSet.ANAMNESIS)
                    MessageBox.Show("Se han eliminado los datos")
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

            If Me.ValidateChildren And CODIGO_ANAMNESISTextBox.Text <> String.Empty And TRATAMIENTO_MEDICOTextBox.Text <> String.Empty And ENFERMEDADTextBox.Text <> String.Empty And INGESTION_DE_MEDICAMENTOSTextBox.Text <> String.Empty And OBSERVACIONESTextBox.Text <> String.Empty And CODIGO_ANAMNESISTextBox.Text <> String.Empty Then

                'Me.ANAMNESISTableAdapter.EDITAR(CODIGO_ANAMNESISTextBox.Text, TRATAMIENTO_MEDICOTextBox.Text, ENFERMEDADTextBox.Text, INGESTION_DE_MEDICAMENTOSTextBox.Text, OBSERVACIONESTextBox.Text, CODIGO_ANAMNESISTextBox.Text)
                'Me.ANAMNESISTableAdapter.Fill(Me.CONSULTORIO_ODONTOLOGICODataSet.ANAMNESIS)
                MessageBox.Show("se a editado con exito")
                Textos()
            Else
                MessageBox.Show("No se permiten campos vacios", "error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Buscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If CODIGO_ANAMNESISTextBox.Text <> String.Empty Then
            'Me.ANAMNESISTableAdapter.FillBy(Me.CONSULTORIO_ODONTOLOGICODataSet.ANAMNESIS, CODIGO_ANAMNESISTextBox.Text)
            TB.Enabled = True
            If ENFERMEDADTextBox.Text = "" Then
                MessageBox.Show("Codigo No Existe")

            End If
        Else
            MessageBox.Show("introdusca un codigo existente")

        End If
    End Sub

    Private Sub CONSULTA_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CONSULTA.Click
        Consultar.Show()
        Me.Hide()
    End Sub

    Private Sub ESTUDIANTEToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ESTUDIANTEToolStripMenuItem.Click
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

    Private Sub DIAGNOSTICOToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DIAGNOSTICOToolStripMenuItem.Click
        'Form4.Show()
        Me.Hide()
    End Sub

    Private Sub CambiarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CambiarToolStripMenuItem.Click
        cargarImagen(True)
    End Sub

    Private Sub GUARDARCAMBIOSToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GUARDARCAMBIOSToolStripMenuItem.Click
        My.Computer.FileSystem.WriteAllText(DATOS, a1 & vbCrLf &
       b2 & vbCrLf, False)
        guardar()
        a = 1
    End Sub

    Private Sub ZOOMToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ZOOMToolStripMenuItem.Click
        Me.BackgroundImageLayout = ImageLayout.Zoom
    End Sub

    Private Sub COMPLETAToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles COMPLETAToolStripMenuItem.Click
        Me.BackgroundImageLayout = ImageLayout.Stretch
    End Sub

    Private Sub CENTROToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CENTROToolStripMenuItem.Click
        Me.BackgroundImageLayout = ImageLayout.Center
    End Sub



    Private Sub Titulo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TITULO.Click

        If a = 0 Then
            a = 1
        Else
            a = a + 1
        End If

        If a = 2 Then
            a = 0
        End If

        If a = 1 Then
            TITULO.Text = "PAUSA"
        Else
            TITULO.Text = "INICIO"
        End If

    End Sub

    Private Sub Label1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label1.MouseDown
        If a = 1 Then

            x = Control.MousePosition.X - Label1.Location.X
            y = Control.MousePosition.Y - Label1.Location.Y

        End If
    End Sub


    Private Sub Label1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label1.MouseMove
        If e.Button = Windows.Forms.MouseButtons.Left And a = 1 Then

            Point = Control.MousePosition
            Point.X = Point.X - (x)
            Point.Y = Point.Y - (y)
            Label1.Location = point

            ' T1.Text = pt.Location.X
            ' yt.Text = pt.Location.Y
            a1 = Label1.Location.X
            b2 = Label1.Location.Y
        End If
    End Sub


    Private Sub OCULTARToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OCULTARToolStripMenuItem.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub


    Private Sub CODIG_ANAMNESISLabel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub MOSTRARTABLAToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TB.Click
        If an = 0 Then
            Me.CONSULTADataGridView.Visible = True
            TB.Text = "OcultarTabla"
            an = 1
        Else
            If an = 1 Then
                Me.CONSULTADataGridView.Visible = False
                TB.Text = "Mostrar Tabla"

                an = 0
            End If

        End If
    End Sub
End Class