Public Class Categoria
    Private _Nombre As String
    Private _Url As String
    Private _Paginas As List(Of Pagina)
    Private _Estado As EstadoProcesado

    ''' <summary>
    ''' Creamos una categoría con un nombre y una URL
    ''' </summary>
    ''' <param name="n">Nombre de la categoría</param>
    ''' <param name="u">URL de la categoría</param>
    Sub New(n As String, u As String)
        _Nombre = n
        _Url = u
    End Sub

    ''' <summary>
    ''' Devuelve el nomnre de la categoría
    ''' </summary>
    ''' <returns></returns>
    Public ReadOnly Property Nombre As String
        Get
            Return _Nombre
        End Get
    End Property

    ''' <summary>
    ''' Devuelve la URL de la categoría
    ''' </summary>
    ''' <returns></returns>
    Public ReadOnly Property Url As String
        Get
            Return _Url
        End Get

    End Property

    ''' <summary>
    ''' Devuelve una coleccion con las páginas de la categoría
    ''' </summary>
    ''' <returns></returns>
    Public ReadOnly Property Paginas As List(Of Pagina)
        Get
            Return _Paginas
        End Get
    End Property


    ''' <summary>
    ''' Devuelve el estado de la categoria
    ''' </summary>
    ''' <returns></returns>
    Public ReadOnly Property Estado As EstadoProcesado
        Get
            Return _Estado
        End Get
    End Property


    ''' <summary>
    ''' Obtiene las páginas y los productos de la categoría
    ''' </summary>
    Public Sub ActualizarCategoria()

    End Sub

    Public Sub BorrarCategoria()

    End Sub
End Class
