Imports System.IO
Public Class INICIO
    Dim a, b, c, i, txt, tema As String
    Dim opcion As DialogResult
    Dim equipo As String = Application.StartupPath & "\equipo.txt"


    Private Sub INICIO_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        '  opcion = MessageBox.Show("SI / NO",
        '   "NUEVA INSTALACION",
        '   MessageBoxButtons.YesNo,
        '  MessageBoxIcon.Question)
        ' If (opcion = DialogResult.Yes) Then
        'b = InputBox("Digite el nombre del Equipo", "Equipo", "C:\Users\familiar\Documents\BASE DE DATOS\cod2\bin\Debug\F2.txt", 400, 300)
        '  c = b
        '  c = File.ReadLines(equipo)(0)
        ' If b = "" Then
        '  Else

        '  My.Computer.FileSystem.WriteAllText(equipo, c & vbCrLf, False)

        '    c = My.Computer.FileSystem.ReadAllText("C:\Nueva carpeta\punto.txt")



        '   Dim obj As Object
        '   Dim archivo As Object
        '   obj = CreateObject("scripting.fileSystemObject")
        '   archivo = obj.CreateTextfile("C:\Nueva carpeta\punto.txt")

        '  archivo.WriteLine(c)
        '  archivo.close()


        '  End If
        ' End If






        Pb.Value = 0
        Pb.Maximum = 100

        T1.Interval = 100
        T1.Enabled = True
        T2.Interval = 100
        T2.Enabled = True


        With Me
            .Location = New Point(190, 250) 'iniciamos en estas coordenadas
            .BackColor = Color.Green
            '  .BackgroundImageLayout = ImageLayout.None

            .TransparencyKey = Color.Green

        End With


    End Sub


    Private Sub T1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles T1.Tick
        If Pb.Value < 100 Then
            Pb.Value += 5

            Lb.Text = "CARGANDO" & "   " & Pb.Value & "   " & "%"
        Else

            T1.Enabled = False

        End If

    End Sub

    Private Sub T2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles T2.Tick
        a = a + 5
        If a = 105 Then
            Consultar.Show()
            Me.Hide()
        End If
    End Sub


End Class