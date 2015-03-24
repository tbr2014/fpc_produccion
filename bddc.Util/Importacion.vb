Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Web
Imports System.Web.SessionState
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports System.Web.UI.HtmlControls
Imports System.Configuration
Imports System.Diagnostics
Imports Microsoft.VisualBasic
Imports System.IO
Imports ITLibrary.Enumeracion
Imports ITLibrary.Constantes

Namespace Importacion

    Public Class clsImporta

#Region "Tesorería Hoteles - LeerArchivoExcel "
        Public Function LeerArchivoExcel(ByVal strNumRUC As String) As IList
            'Dim x, y, i, j, intRecords, intCompleteSheet, intUncompleteSheet As Integer
            'Dim intCantColumnas, intRecordsPerSheet As Integer
            'Dim strSheetName As String
            'Dim strRangoDatos As String

            Dim MyExcel As Excel.Application
            Dim MyWorkBook As Excel.Workbook
            Dim MyWorkSheet As Excel.Worksheet
            'Dim MyWorkSheetAdd As Excel.Worksheet
            'Dim objRangeSel As Excel.Range

            Dim objBEC As BEC.TES.clsPagoProv
            Dim strOrigenRuta As String = ConfigurationSettings.AppSettings.Get("PagoProvRuta")
            Dim strOrigenArchivo As String = ConfigurationSettings.AppSettings.Get("PagoProvArchivo")
            Dim strNombreCompletoOrigen As String = strOrigenRuta & strOrigenArchivo
            Dim arrOrigenConfig() As String = ConfigurationSettings.AppSettings.Get("PagoProvConfig").ToString.Split("|")
            Dim strCadena(), strCabecera As String

            Dim intFilaIni As Integer = ConfigurationSettings.AppSettings.Get("PagoProvFilaIni")
            Dim intFila As Integer = 0
            Dim intColumna As Integer
            Dim arrResultado As New ArrayList

            Try

                MyExcel = New Excel.Application
                'MyExcel.SheetsInNewWorkbook = 1
                MyExcel.Visible = False  'Excel will not open
                'MyExcel.WindowState = Excel.XlWindowState.xlMinimized

                If strNombreCompletoOrigen <> Nothing Then
                    MyWorkBook = MyExcel.Workbooks.Open(strNombreCompletoOrigen)
                    MyWorkSheet = CType(MyWorkBook.ActiveSheet, Excel.Worksheet)

                    Do

                        objBEC = New BEC.TES.clsPagoProv

                        For k As Integer = 0 To arrOrigenConfig.Length - 1
                            strCadena = arrOrigenConfig(k).ToString.Split("-")
                            strCabecera = strCadena(0)
                            intColumna = Convert.ToInt32(strCadena(1))

                            With objBEC

                                Select Case strCabecera
                                    Case "Fecha"
                                        .Fecha = MyWorkSheet.Cells(intFilaIni, intColumna).Value
                                    Case "RUC"
                                        .ProvRUC = MyWorkSheet.Cells(intFilaIni, intColumna).Value
                                    Case "Nombre"
                                        .ProvNombre = MyWorkSheet.Cells(intFilaIni, intColumna).Value
                                    Case "NumDoc"
                                        .ProvNumDoc = MyWorkSheet.Cells(intFilaIni, intColumna).Value
                                    Case "MontoD"
                                        If MyWorkSheet.Cells(intFilaIni, intColumna).Value > 0 Then
                                            .Moneda = "US$"
                                            .Monto = MyWorkSheet.Cells(intFilaIni, intColumna).Value
                                        End If
                                    Case "MontoS"
                                        If MyWorkSheet.Cells(intFilaIni, intColumna).Value > 0 Then
                                            .Moneda = "S/."
                                            .Monto = MyWorkSheet.Cells(intFilaIni, intColumna).Value
                                        End If
                                    Case "Empresa"
                                        .Empresa = MyWorkSheet.Cells(intFilaIni, intColumna).Value
                                End Select

                            End With

                        Next

                        If strNumRUC = IIf(objBEC.ProvRUC Is Nothing, "", objBEC.ProvRUC) Then
                            intFila = intFila + 1
                            objBEC.NroItem = intFila
                            arrResultado.Add(objBEC)
                        End If

                        intFilaIni = intFilaIni + 1

                    Loop Until objBEC.Fecha Is Nothing

                End If

                Return arrResultado

            Catch ex As Exception
                Debug.WriteLine("Error! - " & ex.Message)

                If MyWorkBook IsNot Nothing Then MyWorkBook.Close(False)
                Return Nothing

            Finally
                'Closing Objets
                MyWorkSheet = Nothing
                MyWorkBook = Nothing
                MyExcel.Quit()
                MyExcel = Nothing
                GC.Collect()
            End Try

        End Function

#End Region

#Region "TCPINTRANET - Buscar por persona/anexo"
        Private Function EstructuraDataTable() As DataTable

            Dim myDataTable As DataTable = New DataTable

            Dim myDataColumn As DataColumn

            myDataColumn = New DataColumn
            myDataColumn.DataType = Type.GetType("System.String")
            myDataColumn.ColumnName = "NroItem"
            myDataTable.Columns.Add(myDataColumn)

            myDataColumn = New DataColumn
            myDataColumn.DataType = Type.GetType("System.String")
            myDataColumn.ColumnName = "Nombre"
            myDataTable.Columns.Add(myDataColumn)

            myDataColumn = New DataColumn
            myDataColumn.DataType = Type.GetType("System.String")
            myDataColumn.ColumnName = "Empresa"
            myDataTable.Columns.Add(myDataColumn)

            myDataColumn = New DataColumn
            myDataColumn.DataType = Type.GetType("System.String")
            myDataColumn.ColumnName = "NumAnexo"
            myDataTable.Columns.Add(myDataColumn)

            myDataColumn = New DataColumn
            myDataColumn.DataType = Type.GetType("System.String")
            myDataColumn.ColumnName = "NumDirecto"
            myDataTable.Columns.Add(myDataColumn)

            myDataColumn = New DataColumn
            myDataColumn.DataType = Type.GetType("System.String")
            myDataColumn.ColumnName = "NumRPC"
            myDataTable.Columns.Add(myDataColumn)

            Return myDataTable

        End Function

        Public Function LeerArchivoAnexos(ByVal strBuscar As String, ByVal intTipoOpcion As Integer) As DataTable

            Dim MyExcel As Excel.Application
            Dim MyWorkBook As Excel.Workbook
            Dim MyWorkSheet As Excel.Worksheet
            'Dim MyWorkSheetAdd As Excel.Worksheet
            'Dim objRangeSel As Excel.Range

            Try

                'Dim x, y, i, j, intRecords, intCompleteSheet, intUncompleteSheet As Integer
                'Dim intCantColumnas, intRecordsPerSheet As Integer
                'Dim strSheetName As String
                'Dim strRangoDatos As String

                Dim dt As DataTable = EstructuraDataTable()
                Dim dr As DataRow

                Dim strOrigenRuta As String = ConfigurationSettings.AppSettings.Get("ListaTelefonoRuta")
                Dim strOrigenArchivo As String = ConfigurationSettings.AppSettings.Get("ListaTelefonoArchivo")
                Dim arrOrigenConfig() As String = ConfigurationSettings.AppSettings.Get("ListaTelefonoConfig").ToString.Split("|")
                Dim strNombreCompletoOrigen As String = strOrigenRuta & strOrigenArchivo

                Dim strCadena(), strCabecera As String

                Dim intFilaIni As Integer = 2
                Dim intFila As Integer = intFilaIni
                Dim intColumna As Integer
                Dim arrResultado As New ArrayList
                Dim strCadenaCelda As String
                Dim intNumOcu, intNumFilas As Integer
                Dim bolExiste As Boolean = False

                MyExcel = New Excel.Application
                'MyExcel.SheetsInNewWorkbook = 1
                MyExcel.Visible = False  'Excel will not open
                'MyExcel.WindowState = Excel.XlWindowState.xlMinimized

                If strNombreCompletoOrigen <> Nothing Then

                    Dim f As New IO.FileInfo(strNombreCompletoOrigen)
                    bolExiste = f.Exists()

                    'If bolExiste Then

                    MyWorkBook = MyExcel.Workbooks.Open(strNombreCompletoOrigen)

                    MyWorkSheet = CType(MyWorkBook.Worksheets(2), Excel.Worksheet)

                    intNumFilas = intFilaIni - 1
                    Do
                        intNumFilas += 1
                        strCadenaCelda = MyWorkSheet.Cells(intNumFilas, 1).Value
                    Loop Until strCadenaCelda Is Nothing

                    For intFila = intFilaIni To intNumFilas

                        Select Case intTipoOpcion
                            Case 1
                                strCadenaCelda = MyWorkSheet.Cells(intFila, 1).Value
                            Case 2
                                strCadenaCelda = MyWorkSheet.Cells(intFila, 3).Value & " " & MyWorkSheet.Cells(intFila, 4).Value & " " & MyWorkSheet.Cells(intFila, 5).Value
                                '...
                        End Select

                        If Not strCadenaCelda Is Nothing Then

                            If strCadenaCelda.ToUpper.IndexOf(strBuscar.ToUpper) > -1 Then

                                intNumOcu += 1
                                dr = dt.NewRow
                                dr(0) = intNumOcu.ToString

                                For k As Integer = 0 To arrOrigenConfig.Length - 1
                                    strCadena = arrOrigenConfig(k).ToString.Split("-")
                                    strCabecera = strCadena(0)
                                    intColumna = Convert.ToInt32(strCadena(1))


                                    Select Case strCabecera
                                        Case "Nombre"
                                            dr(intColumna) = MyWorkSheet.Cells(intFila, intColumna).Value
                                        Case "Empresa"
                                            dr(intColumna) = MyWorkSheet.Cells(intFila, intColumna).Value
                                        Case "Anexo"
                                            dr(intColumna) = MyWorkSheet.Cells(intFila, intColumna).Value
                                        Case "Directo"
                                            dr(intColumna) = MyWorkSheet.Cells(intFila, intColumna).Value
                                        Case "RPC"
                                            dr(intColumna) = MyWorkSheet.Cells(intFila, intColumna).Value

                                    End Select

                                Next

                                dt.Rows.Add(dr)

                            End If

                        End If

                    Next

                    Return dt

                Else
                    Throw New DataException("No existe archivo!")
                End If

                'End If


            Catch ex As Exception
                MyWorkBook.Close(False)
                Return Nothing

            Finally
                'Closing Objets
                MyWorkSheet = Nothing
                MyWorkBook = Nothing
                MyExcel.Quit()
                MyExcel = Nothing
                'GC.Collect()
            End Try

        End Function

#End Region

    End Class
End Namespace


