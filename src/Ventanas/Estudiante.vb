Imports System.Text
Imports System.IO
Public Class Estudiante
    Dim lastPath As String
    Dim a As String = 0


    Private Sub ESTUDIANTEBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        ' Me.TableAdapterManager.UpdateAll(Me.CONSULTORIO_ODONTOLOGICODataSet)

    End Sub

    Private Sub TEXTOS()
        CODIGO_ETextBox.Text = ""
        SECCIONTextBox.Text = ""
        DOCUMENTO_DE_IDENTIDADTextBox.Text = ""
        NOMBRESTextBox.Text = ""
        APELLIDOSTextBox.Text = ""
        LUGAR_DE_NACIMIENTOTextBox.Text = ""
        FECHA_DE_NACIMIENTODateTimePicker.Text = ""
        EDADTextBox.Text = ""
        RHTextBox.Text = ""
        EPSTextBox.Text = ""
        GENEROTextBox.Text = ""
        TELEFONOTextBox.Text = ""
        DIRECCIONTextBox.Text = ""
        NOMBRE_DEL_PADRETextBox.Text = ""
        NOMBRE_DE_LA_MADRETextBox.Text = ""
        OCUPACION_DEL_PADRETextBox.Text = ""
        OCUPACION_DE_LA_MADRETextBox.Text = ""
        CODIG_ANAMNESISTextBox.Text = ""
        CODIGO_EXAMENTextBox.Text = ""
        CODIGO_REGISTRO_DIARIOTextBox.Text = ""
    End Sub
    Public Sub guardar()
        Dim save As String = "./F2.txt"
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
        Dim save As String = "./F2.txt"
        lastPath = My.Computer.FileSystem.ReadAllText("C:\Users\familiar\Documents\BASE DE DATOS\cod2\bin\Debug\F2.txt")
        If lastPath <> "" Then

            cargarImagen(False)
        End If

    End Sub
    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'CONSULTORIO_ODONTOLOGICODataSet.ESTUDIANTE' Puede moverla o quitarla según sea necesario.
        'Me.ESTUDIANTETableAdapter.Fill(Me.CONSULTORIO_ODONTOLOGICODataSet.ESTUDIANTE)
        TEXTOS()
        cargar()
        Me.TB.Enabled = False
    End Sub

    Private Sub BUSCAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If CODIGO_ETextBox.Text <> String.Empty Then
            'Me.ESTUDIANTETableAdapter.FillBy(Me.CONSULTORIO_ODONTOLOGICODataSet.ESTUDIANTE, CODIGO_ETextBox.Text)
            Me.TB.Enabled = True

            If NOMBRESTextBox.Text = "" Then
                MessageBox.Show("Codigo No Existe")

            End If
        Else
            MessageBox.Show("ingrese un codigo valido")

        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        TEXTOS()
    End Sub

    Private Sub INSERTAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles INSERTAR.Click
        Try

            If Me.ValidateChildren And CODIGO_ETextBox.Text <> String.Empty And SECCIONTextBox.Text <> String.Empty And DOCUMENTO_DE_IDENTIDADTextBox.Text <> String.Empty And NOMBRESTextBox.Text <> String.Empty And APELLIDOSTextBox.Text <> String.Empty And LUGAR_DE_NACIMIENTOTextBox.Text <> String.Empty And FECHA_DE_NACIMIENTODateTimePicker.Text <> String.Empty And EDADTextBox.Text <> String.Empty And RHTextBox.Text <> String.Empty And EPSTextBox.Text <> String.Empty And GENEROTextBox.Text <> String.Empty And TELEFONOTextBox.Text <> String.Empty And DIRECCIONTextBox.Text <> String.Empty And NOMBRE_DEL_PADRETextBox.Text <> String.Empty And NOMBRE_DE_LA_MADRETextBox.Text <> String.Empty And OCUPACION_DEL_PADRETextBox.Text <> String.Empty And OCUPACION_DE_LA_MADRETextBox.Text <> String.Empty And CODIG_ANAMNESISTextBox.Text <> String.Empty And CODIGO_EXAMENTextBox.Text <> String.Empty And CODIGO_REGISTRO_DIARIOTextBox.Text <> String.Empty And CODIGO_ETextBox.Text <> String.Empty Then
                '  Dim opcion As DialogResult
                ' opcion = MessageBox.Show("desea eliminar los datos",
                '                         "ELIMINAR",
                '                        MessageBoxButtons.YesNo,
                '                       MessageBoxIcon.Question)
                'If (opcion = DialogResult.Yes) Then


                'Me.ESTUDIANTETableAdapter.INSERTAR(CODIGO_ETextBox.Text, SECCIONTextBox.Text, DOCUMENTO_DE_IDENTIDADTextBox.Text, NOMBRESTextBox.Text, APELLIDOSTextBox.Text, LUGAR_DE_NACIMIENTOTextBox.Text, FECHA_DE_NACIMIENTODateTimePicker.Text, EDADTextBox.Text, RHTextBox.Text, EPSTextBox.Text, GENEROTextBox.Text, TELEFONOTextBox.Text, DIRECCIONTextBox.Text, NOMBRE_DEL_PADRETextBox.Text, OCUPACION_DEL_PADRETextBox.Text, NOMBRE_DE_LA_MADRETextBox.Text, OCUPACION_DE_LA_MADRETextBox.Text, CODIG_ANAMNESISTextBox.Text, CODIGO_EXAMENTextBox.Text, CODIGO_REGISTRO_DIARIOTextBox.Text)
                'Me.ESTUDIANTETableAdapter.Fill(Me.CONSULTORIO_ODONTOLOGICODataSet.ESTUDIANTE)
                MessageBox.Show("Se han agragados nuevos datos")
                TEXTOS()
                ' End If
            Else
                MessageBox.Show("No se permiten campos vacios", "error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub EDITAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EDITAR.Click


        Try

            If Me.ValidateChildren And CODIGO_ETextBox.Text <> String.Empty And SECCIONTextBox.Text <> String.Empty And DOCUMENTO_DE_IDENTIDADTextBox.Text <> String.Empty And NOMBRESTextBox.Text <> String.Empty And APELLIDOSTextBox.Text <> String.Empty And LUGAR_DE_NACIMIENTOTextBox.Text <> String.Empty And FECHA_DE_NACIMIENTODateTimePicker.Text <> String.Empty And EDADTextBox.Text <> String.Empty And RHTextBox.Text <> String.Empty And EPSTextBox.Text <> String.Empty And GENEROTextBox.Text <> String.Empty And TELEFONOTextBox.Text <> String.Empty And DIRECCIONTextBox.Text <> String.Empty And NOMBRE_DEL_PADRETextBox.Text <> String.Empty And NOMBRE_DE_LA_MADRETextBox.Text <> String.Empty And OCUPACION_DEL_PADRETextBox.Text <> String.Empty And OCUPACION_DE_LA_MADRETextBox.Text <> String.Empty And CODIG_ANAMNESISTextBox.Text <> String.Empty And CODIGO_EXAMENTextBox.Text <> String.Empty And CODIGO_REGISTRO_DIARIOTextBox.Text <> String.Empty And CODIGO_ETextBox.Text <> String.Empty Then
                ' Dim opcion As DialogResult
                ' opcion = MessageBox.Show("desea eliminar los datos",
                '  "ELIMINAR",
                ' MessageBoxButtons.YesNo,
                ' MessageBoxIcon.Question)
                ' If (opcion = DialogResult.Yes) Then


                'Me.ESTUDIANTETableAdapter.EDITAR(CODIGO_ETextBox.Text, SECCIONTextBox.Text, DOCUMENTO_DE_IDENTIDADTextBox.Text, NOMBRESTextBox.Text, APELLIDOSTextBox.Text, LUGAR_DE_NACIMIENTOTextBox.Text, FECHA_DE_NACIMIENTODateTimePicker.Text, EDADTextBox.Text, RHTextBox.Text, EPSTextBox.Text, GENEROTextBox.Text, TELEFONOTextBox.Text, DIRECCIONTextBox.Text, NOMBRE_DEL_PADRETextBox.Text, OCUPACION_DEL_PADRETextBox.Text, NOMBRE_DE_LA_MADRETextBox.Text, OCUPACION_DE_LA_MADRETextBox.Text, CODIG_ANAMNESISTextBox.Text, CODIGO_EXAMENTextBox.Text, CODIGO_REGISTRO_DIARIOTextBox.Text, CODIGO_ETextBox.Text)
                'Me.ESTUDIANTETableAdapter.Fill(Me.CONSULTORIO_ODONTOLOGICODataSet.ESTUDIANTE)
                MessageBox.Show("Se han cambiado los datos")
                TEXTOS()
                'End If
            Else
                MessageBox.Show("No se permiten campos vacios", "error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ELIMINAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ELIMINAR.Click
        Try

            If Me.ValidateChildren And CODIGO_ETextBox.Text <> String.Empty And SECCIONTextBox.Text <> String.Empty And DOCUMENTO_DE_IDENTIDADTextBox.Text <> String.Empty And NOMBRESTextBox.Text <> String.Empty And APELLIDOSTextBox.Text <> String.Empty And LUGAR_DE_NACIMIENTOTextBox.Text <> String.Empty And FECHA_DE_NACIMIENTODateTimePicker.Text <> String.Empty And EDADTextBox.Text <> String.Empty And RHTextBox.Text <> String.Empty And EPSTextBox.Text <> String.Empty And GENEROTextBox.Text <> String.Empty And TELEFONOTextBox.Text <> String.Empty And DIRECCIONTextBox.Text <> String.Empty And NOMBRE_DEL_PADRETextBox.Text <> String.Empty And NOMBRE_DE_LA_MADRETextBox.Text <> String.Empty And OCUPACION_DEL_PADRETextBox.Text <> String.Empty And OCUPACION_DE_LA_MADRETextBox.Text <> String.Empty And CODIG_ANAMNESISTextBox.Text <> String.Empty And CODIGO_EXAMENTextBox.Text <> String.Empty And CODIGO_REGISTRO_DIARIOTextBox.Text <> String.Empty And CODIGO_ETextBox.Text <> String.Empty Then
                Dim opcion As DialogResult
                opcion = MessageBox.Show("desea eliminar los datos",
                                         "ELIMINAR",
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question)
                If (opcion = DialogResult.Yes) Then


                    'Me.ESTUDIANTETableAdapter.ELIMINAR(CODIGO_ETextBox.Text, SECCIONTextBox.Text, DOCUMENTO_DE_IDENTIDADTextBox.Text, NOMBRESTextBox.Text, APELLIDOSTextBox.Text, LUGAR_DE_NACIMIENTOTextBox.Text, FECHA_DE_NACIMIENTODateTimePicker.Text, EDADTextBox.Text, RHTextBox.Text, EPSTextBox.Text, GENEROTextBox.Text, TELEFONOTextBox.Text, DIRECCIONTextBox.Text, NOMBRE_DEL_PADRETextBox.Text, OCUPACION_DEL_PADRETextBox.Text, NOMBRE_DE_LA_MADRETextBox.Text, OCUPACION_DE_LA_MADRETextBox.Text, CODIG_ANAMNESISTextBox.Text, CODIGO_EXAMENTextBox.Text, CODIGO_REGISTRO_DIARIOTextBox.Text)
                    'Me.ESTUDIANTETableAdapter.Fill(Me.CONSULTORIO_ODONTOLOGICODataSet.ESTUDIANTE)
                    MessageBox.Show("Se han eliminado los datos")
                    TEXTOS()
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

    Private Sub ANAMNESISToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ANAMNESISToolStripMenuItem.Click
        'Form3.Show()
        Me.Hide()
    End Sub

    Private Sub DIAGNOSTICOToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DIAGNOSTICOToolStripMenuItem.Click
        'Form4.Show()
        Me.Hide()
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub MENUToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MENUToolStripMenuItem.Click

    End Sub

    Private Sub ABRIRTABLAToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TB.Click

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

    Private Sub CambiarToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CambiarToolStripMenuItem.Click
        cargarImagen(True)
    End Sub

    Private Sub GUARDARCAMBIOSToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GUARDARCAMBIOSToolStripMenuItem.Click
        guardar()
    End Sub

    Private Sub OCULTARToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OCULTARToolStripMenuItem.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub CENTROToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CENTROToolStripMenuItem.Click
        Me.BackgroundImageLayout = ImageLayout.Center
    End Sub

    Private Sub COMPLETAToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles COMPLETAToolStripMenuItem.Click
        Me.BackgroundImageLayout = ImageLayout.Stretch
    End Sub

    Private Sub ZOOMToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ZOOMToolStripMenuItem.Click
        Me.BackgroundImageLayout = ImageLayout.Zoom
    End Sub

    Private Sub CODIGO_ETextBox_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles CODIGO_ETextBox.MouseHover
        MS.SetToolTip(CODIGO_ETextBox, "DIGITE EL CODIGO DEL ESTUDIANTE")
        MS.ToolTipTitle = "codigo"
        MS.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub CODIGO_ETextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CODIGO_ETextBox.TextChanged

    End Sub
End Class