Public Class frmPrincipal
    Dim Categorias As List(Of Categoria)

    Private Sub ProductoBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.ProductoBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.PfmDataSet)

    End Sub

    Private Sub frmPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim Fila As DataRow
        Dim Cat As Categoria

        'TODO: esta línea de código carga datos en la tabla 'PfmDataSet.Categoria'
        Me.CategoriaTableAdapter.Fill(Me.PfmDataSet.Categoria)

        'Una vez leidas las categorías de la BD las cargamos en el ComboBox
        For Each Fila In Me.PfmDataSet.Categoria.Rows
            cmbCategorias.Items.Add(Fila.Item("Nombre").ToString)
        Next

        'TODO: Crear la categoría
        Cat = New Categoria(Fila.Item("Nombre").ToString, Fila.Item("Url").ToString)

        'TODO: esta línea de código carga datos en la tabla 'PfmDataSet.Producto' Puede moverla o quitarla según sea necesario.
        Me.ProductoTableAdapter.Fill(Me.PfmDataSet.Producto)

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        frmAddCategoria.Show(Me)
    End Sub

End Class
