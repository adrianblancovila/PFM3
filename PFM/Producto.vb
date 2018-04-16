Public Class Producto
    Private _Nombre As String
    Private _Precio As Decimal

    Sub New(n As String, p As Decimal)
        _Nombre = n
        _Precio = p
    End Sub
    ''' <summary>
    ''' Devuelve y establece el nombre del producto
    ''' </summary>
    ''' <returns></returns>
    Public Property Nombre As String
        Get
            Return _Nombre
        End Get
        Set(value As String)
            _Nombre = value
        End Set
    End Property

    ''' <summary>
    ''' Devuelve y establece el precio del producto
    ''' </summary>
    ''' <returns></returns>
    Public Property Precio As Decimal
        Get
            Return _Precio
        End Get
        Set(value As Decimal)
            _Precio = value
        End Set
    End Property
End Class
