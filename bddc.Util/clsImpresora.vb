Public Class clsImpresora

    Private Function ImpresoraEstado(ByVal pImpresoraEstado As Util.Enumeracion.enmImpresoraEstado) As String

        Select Case pImpresoraEstado
            Case Enumeracion.enmImpresoraEstado.PrinterIdle
                Return "Habilitada"
            Case Enumeracion.enmImpresoraEstado.PrinterPrinting
                Return "Imprimiendo"
            Case Enumeracion.enmImpresoraEstado.PrinterWarmingUp
                Return "warmup"
            Case Enumeracion.enmImpresoraEstado.PrinterOffline
                Return "Impresora apagada!"
            Case Else
                Return "Impresora no habilitada. Revisar!"
        End Select

    End Function

    Public Function ImpresoraEvaluacion(ByVal strTerminal As String, ByVal strImpresoraBuscar As String, ByVal strPaginaBuscar As String) As Integer

        Dim WMIObject As String
        Dim PrinterSet As Object
        Dim Printer, PrinterDefault As Object
        Dim bolHalladoPrinter As Boolean = False
        Dim bolHalladoPage As Boolean = False

        Try
            WMIObject = "winmgmts://" & strTerminal
            PrinterSet = GetObject(WMIObject).InstancesOf("win32_Printer")
            PrinterDefault = Nothing

            '2. Buscar Impresora específica:
            For Each Printer In PrinterSet
                If Printer.Name = strImpresoraBuscar Then
                    bolHalladoPrinter = True

                    'Printer.SetDefaultPrinter()

                    '2.2. Buscar tamaño de Página específica:
                    For k As Integer = 0 To CType(Printer.PrinterPaperNames, IList).Count - 1
                        If Printer.PrinterPaperNames(k) = strPaginaBuscar Then
                            bolHalladoPage = True
                            Exit For
                        End If
                    Next

                    If Not bolHalladoPage Then
                        MsgBox(Util.Constante.Msj_ImpresoraDimensionPaginaERR & strPaginaBuscar, MsgBoxStyle.Exclamation, Util.Constante.Msj_SistemaTitulo)
                        Return Util.Enumeracion.enmResultadoOperacion.NONE
                    Else

                        If Printer.PrinterStatus = Util.Enumeracion.enmImpresoraEstado.PrinterIdle Then
                            Return Util.Enumeracion.enmResultadoOperacion.OK
                        Else
                            MsgBox(strImpresoraBuscar & ": " & ImpresoraEstado(Printer.PrinterStatus), MsgBoxStyle.Exclamation, Util.Constante.Msj_SistemaTitulo)
                            Return Util.Enumeracion.enmResultadoOperacion.NONE
                        End If

                    End If

                End If

                'Else
                'MsgBox(Util.Constante.Msj_ImpresoraPredeterminadaERR, MsgBoxStyle.Exclamation, Util.Constante.Msj_SistemaTitulo)
                'Return Util.Enumeracion.enmResultadoOperacion.NONE

                'End If
            Next

            If Not bolHalladoPrinter Then
                MsgBox(strImpresoraBuscar & ":" & Util.Constante.Msj_ImpresoraInstaladaERR, MsgBoxStyle.Exclamation, Util.Constante.Msj_SistemaTitulo)
                Return Util.Enumeracion.enmResultadoOperacion.NONE
            End If

        Catch ex As Exception
            MsgBox(strImpresoraBuscar & ":" & ex.Message, MsgBoxStyle.Critical, Util.Constante.Msj_SistemaTitulo)
            Return Util.Enumeracion.enmResultadoOperacion.ERR

        End Try

    End Function

    Public Function ImpresoraGetDefault(ByVal strTerminal As String) As String

        Dim WMIObject As String
        Dim PrinterSet As Object
        Dim Printer, PrinterDefault As Object
        Dim strImpresora As String = ""

        WMIObject = "winmgmts://" & strTerminal
        PrinterSet = GetObject(WMIObject).InstancesOf("win32_Printer")
        PrinterDefault = Nothing

        If PrinterSet IsNot Nothing Then
            'Buscar Impresora predeterminada:
            For Each Printer In PrinterSet
                If Printer.Default = True Then
                    strImpresora = Printer.Name
                    Exit For
                End If
            Next
        End If

        Return strImpresora

    End Function

    Public Sub ImpresoraSetDefault(ByVal strTerminal As String, ByVal strImpresora As String)

        Dim WMIObject As String
        Dim PrinterSet As Object
        Dim Printer As Object

        WMIObject = "winmgmts://" & strTerminal
        PrinterSet = GetObject(WMIObject).InstancesOf("win32_Printer")

        'Buscar Impresora predeterminada:
        If PrinterSet IsNot Nothing Then
            For Each Printer In PrinterSet
                If Printer.Default = False And Printer.Name = strImpresora Then
                    'Hacerlo Predeterminada temporalmente:
                    Printer.SetDefaultPrinter()
                    Exit For
                End If
            Next
        End If

    End Sub

End Class
