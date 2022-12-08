Public Class Persona
    Private nombre As String
    Private edad As Integer
    Private altura As Double
    Private peso As Double

    Public Sub New(nombre As String, edad As Integer, altura As Double, peso As Double)
        Me.nombre = nombre
        Me.edad = edad
        Me.altura = altura
        Me.peso = peso
    End Sub

    Public Property PropNombre() As String
        Get
            Return nombre
        End Get
        Set(value As String)
            nombre = value
        End Set
    End Property

    Public Property PropEdad() As Integer
        Get
            Return edad
        End Get
        Set(value As Integer)
            edad = value
        End Set
    End Property

    Public Property PropAltura() As Double
        Get
            Return altura
        End Get
        Set(value As Double)
            altura = value
        End Set
    End Property

    Public Property PropPeso() As Double
        Get
            Return peso
        End Get
        Set(value As Double)
            peso = value
        End Set
    End Property

End Class
