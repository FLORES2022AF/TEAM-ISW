Imports System.Text
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports System.IO
Imports Oracle.DataAccess.Client


Public Class generarPrelistaDeArticulos
    Private Sub generarPrelistaDeArticulos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim datos As New OracleDataAdapter("SELECT * FROM PRODUCTOS WHERE CANTIDAD <= CANTIDADS”, Cone)
        Dim ds As New DataSet

        datos.Fill(ds, "Productos")
        Me.tablaDePreListaDeProductos.DataSource = ds.Tables(0)

    End Sub
    Public Function GetColumnasSize(ByVal dg As DataGridView) As Single()
        'funcion para obtener el tamaño de la columas del datagridview
        Dim values As Single() = New Single(dg.ColumnCount - 1) {}

        For i As Integer = 0 To dg.ColumnCount - 1
            values(i) = CSng(dg.Columns(i).Width)
        Next
        Return values
    End Function

    Public Sub ExportarDatosPDF(ByVal document As Document)
        'Se crea un objeto PDFTable con el numero de columnas del DataGridView. 
        Dim datatable As New PdfPTable(tablaDePreListaDeProductos.ColumnCount)
        'Se asignan algunas propiedades para el diseño del PDF.
        datatable.DefaultCell.Padding = 3
        Dim headerwidths As Single() = GetColumnasSize(tablaDePreListaDeProductos) ' Aqui se realiza una llamada a la funcion GetColumnasSize y le pasamos como parametro nuestro datagridview
        datatable.SetWidths(headerwidths) 'Pasamos como parametro el array que contiene los ancho de columna, a la propiedad "SetWidths"
        datatable.WidthPercentage = 50
        datatable.DefaultCell.BorderWidth = 2
        datatable.DefaultCell.HorizontalAlignment = Element.ALIGN_CENTER
        'Se crea el encabezado en el PDF. 
        Dim encabezado As New Paragraph("LA TIPICA", New Font(Font.Name = "Tahoma", 20, Font.Bold))

        'Se crea el texto abajo del encabezado.
        Dim texto As New Phrase("PRELISTA DE PRODUCTOS:" + Now.Date(), New Font(Font.Name = "Tahoma", 14, Font.Bold))

        'Se capturan los nombres de las columnas del DataGridView.
        For i As Integer = 0 To tablaDePreListaDeProductos.ColumnCount - 1
            datatable.AddCell(tablaDePreListaDeProductos.Columns(i).HeaderText)
        Next

        datatable.HeaderRows = 1
        datatable.DefaultCell.BorderWidth = 1

        'Se generan las columnas del DataGridView. 
        For i As Integer = 0 To tablaDePreListaDeProductos.RowCount - 1 'Recorre la filas del datagridview
            For j As Integer = 0 To tablaDePreListaDeProductos.ColumnCount - 1 'Recorre las columnas del datagridview

                datatable.AddCell(tablaDePreListaDeProductos(j, i).Value.ToString())


            Next
            datatable.CompleteRow()
        Next
        'Se agrega el PDFTable al documento.
        document.Add(encabezado)
        document.Add(texto)
        document.Add(datatable)
    End Sub
    Private Sub iconoGenerarPreListaPDF_Click(sender As Object, e As EventArgs) 

    End Sub

    Private Sub botonGenerarPreListaPDF_Click(sender As Object, e As EventArgs) 
        Try
            'Intentar generar el documento.
            Dim doc As New Document(PageSize.A4.Rotate(), 10, 10, 10, 10)

            'Path que guarda el reporte en el escritorio de windows (Desktop).
            Dim filename As String = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\PrelistaProductos.pdf"

            Dim file As New FileStream(filename, FileMode.Create, FileAccess.Write, FileShare.ReadWrite)
            PdfWriter.GetInstance(doc, file)
            doc.Open()
            ExportarDatosPDF(doc)
            doc.Close()
            Process.Start(filename)
        Catch ex As Exception
            'Si el intento es fallido, mostrar MsgBox.
            MessageBox.Show("No se puede generar el documento PDF.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub tablaDePreListaDeProductos_CellContentClick(sender As Object, e As DataGridView)

    End Sub

    Private Sub botonRegresarAGestionarInventario_Click(sender As Object, e As EventArgs) 
        menuDueno.Show()
        Me.Close()
    End Sub
End Class