Imports System.Net

Public Class Pagina
    Private _Numero As Integer
    Private _Produtos As List(Of Producto)
    Private _Estado As EstadoProcesado
    Private _Pagina As WebResponse
    Private _PaginaSiguiente As String

    ''' <summary>
    ''' Crea un objeto página con su número de página y la página como un objeto WebResponse
    ''' </summary>
    ''' <param name="n">Numero de la página detro de la categoría</param>
    ''' <param name="p">Página completa como un objeto WebResponse</param>
    Sub New(n As Integer, p As WebResponse)
        _Numero = n
        _Pagina = p
    End Sub


    ''' <summary>
    ''' Devuelve y establece el número de página
    ''' </summary>
    ''' <returns></returns>
    Public Property Numero As Integer
        Get
            Return _Numero
        End Get
        Set(value As Integer)
            _Numero = value
        End Set
    End Property

    ''' <summary>
    ''' Devuelve los productos de la página
    ''' </summary>
    ''' <returns></returns>
    Public ReadOnly Property Productos As List(Of Producto)
        Get
            Return _Produtos
        End Get
    End Property

    ''' <summary>
    ''' Devuelve el estado de esta página.
    ''' </summary>
    ''' <returns>
    '''         SinProcesar, no se ha procesado aún
    '''         Procesada, ya se ha procesado y obtenido todos los productos
    '''         Procesando, se está procesando
    ''' </returns>
    Public ReadOnly Property Estado As EstadoProcesado
        Get
            Return _Estado
        End Get
    End Property


    ''' <summary>
    ''' Establece o devuelve la página copleta mediante un objeto WebResponse
    ''' </summary>
    ''' <returns></returns>
    Public Property Pagina As WebResponse
        Get
            Return _Pagina
        End Get
        Set(value As WebResponse)
            _Pagina = value
        End Set
    End Property

    ''' <summary>
    ''' Establece o devulve la URL de la página siguiente
    ''' </summary>
    ''' <returns></returns>
    Public Property PaginaSiguiente As String
        Get
            Return _PaginaSiguiente

        End Get
        Set(value As String)
            _PaginaSiguiente = value
        End Set
    End Property

    Public Sub Ripear()

    End Sub
End Class
