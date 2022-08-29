Imports System.Math
Public Module NumberToString

    Public Function MesTexto(ByVal intMes As Integer) As String
        Dim strMes As String = String.Empty
        Select Case intMes
            Case 1
                strMes = "Enero"
            Case 2
                strMes = "Febrero"
            Case 3
                strMes = "Marzo"
            Case 4
                strMes = "Abril"
            Case 5
                strMes = "Mayo"
            Case 6
                strMes = "Junio"
            Case 7
                strMes = "Julio"
            Case 8
                strMes = "Agosto"
            Case 9
                strMes = "Septiembre"
            Case 10
                strMes = "Octubre"
            Case 11
                strMes = "Noviembre"
            Case 12
                strMes = "Diciembre"
        End Select

        Return ExpertisApp.Traslate(strMes)
    End Function

    Public Function ImporteTexto(ByVal dblCifra As Double) As String
        Dim strCifraAbs As String = Format(Abs(dblCifra), "0.00")
        Dim strParteEntera As String = Int(strCifraAbs)
        Dim intPosicionComa As Integer = InStr(strCifraAbs, ",")
        Dim strParteDecimal As String = String.Empty
        If intPosicionComa <> 0 Then
            strParteDecimal = Mid(strCifraAbs, intPosicionComa + 1, Len(strCifraAbs) - intPosicionComa)
        End If

        Dim strTexto As String = Convertir(strParteEntera)

        If CInt(strParteDecimal) <> 0 Then strTexto = strTexto & " con " & Convertir(strParteDecimal)
        If Mid(strTexto, 1, 7) = "un mil" Then strTexto = Mid(strTexto, 4, Len(strTexto))

        Return ExpertisApp.Traslate(UCase(strTexto))
    End Function

    Private Function Convertir(ByVal strCifra As String) As String
        Dim strVALOR As String = String.Empty
        Dim strTexto As String = String.Empty

        strCifra = Int(strCifra)
        If Len(strCifra) > 6 Then
            If Len(strCifra) = 7 And Left(strCifra, 1) = 1 Then
                strTexto = strTexto & "un millón de"
            Else
                strVALOR = ConvertirParcial(Int(strCifra / 1000000))
                strTexto = strTexto & strVALOR & "millones de"
            End If
            strCifra = -(Int(strCifra / 1000000) * 1000000 - strCifra)
        End If

        If Len(strCifra) > 3 Then
            strVALOR = ConvertirParcial(Int(strCifra / 1000))
            strTexto = strTexto & strVALOR & "mil "
            strCifra = -(Int(strCifra / 1000) * 1000 - strCifra)
        End If

        If strCifra = 0 And Len(strTexto) = 0 Then
            strVALOR = "cero"
            strTexto = strTexto & strVALOR
        Else
            strVALOR = ConvertirParcial(strCifra)
            If Len(strVALOR) > 0 Then strTexto = strTexto & strVALOR
        End If

        If Mid(strTexto, 1, 7) = "un mil" Then strTexto = Mid(strTexto, 4, Len(strTexto))

        Return ExpertisApp.Traslate(strTexto)
    End Function

    Private Function ConvertirParcial(ByVal dblCifra As Double) As String
        Dim strTexto As String = String.Empty

        If Left(dblCifra, 1) = "," Then dblCifra = Right(dblCifra & "0", 2) 'Si sólamente tiene un decimal
        dblCifra = Int(dblCifra)

        Dim strValor1 As String = Left(dblCifra, 1)
        If dblCifra > 100 Then
            strTexto = strTexto & Centenas(strValor1) & " "
            dblCifra = Mid(dblCifra, 2, Len(CStr(dblCifra)) - 1)
            If dblCifra = 1 Then strTexto = strTexto & "un"
        End If
        If dblCifra = 100 Then
            strTexto = strTexto & "Cien"
        Else
            If dblCifra > 9 Then
                strTexto = strTexto & Numero(dblCifra)
            Else
                If dblCifra > 1 Then strTexto = strTexto & Unidades(dblCifra)
            End If
        End If

        Return ExpertisApp.Traslate(strTexto) & " "
    End Function

    Public Function Numero(ByVal dblCifra As Double) As String
        Dim strTexto As String = String.Empty
        Dim strValor1 As String = Left(dblCifra, 1)
        Dim strValor2 As String = Mid(dblCifra, Len(CStr(dblCifra)), 1)

        Dim intValor1, intValor2 As Integer
        If Len(strValor1) > 0 Then intValor1 = CInt(strValor1)
        If Len(strValor2) > 0 Then intValor2 = CInt(strValor2)
        If intValor1 = 1 Then
            Select Case intValor2
                Case 0
                    strTexto = strTexto & "diez"
                Case 1
                    strTexto = strTexto & "once"
                Case 2
                    strTexto = strTexto & "doce"
                Case 3
                    strTexto = strTexto & "trece"
                Case 4
                    strTexto = strTexto & "catorce"
                Case 5
                    strTexto = strTexto & "quince"
                Case Else
                    strTexto = strTexto & "dieci" & Unidades(intValor2)
            End Select
        ElseIf intValor1 = 2 Then
            If intValor2 = 1 Then
                strTexto = strTexto & "veintiun"
            Else
                strTexto = strTexto & IIf(intValor2 = 0, "veinte", "veinti" & Unidades(intValor2))
            End If
        ElseIf intValor1 >= 3 Then
            strTexto = strTexto & Decenas(intValor1)
            If intValor2 > 0 Then strTexto = strTexto & " y " & Unidades(intValor2)
        End If

        Return ExpertisApp.Traslate(strTexto)
    End Function

    Public Function Unidades(ByVal intNumero As Integer) As String
        Dim strUnidades As String = String.Empty
        Select Case intNumero
            Case 1
                strUnidades = "uno"
            Case 2
                strUnidades = "dos"
            Case 3
                strUnidades = "tres"
            Case 4
                strUnidades = "cuatro"
            Case 5
                strUnidades = "cinco"
            Case 6
                strUnidades = "seis"
            Case 7
                strUnidades = "siete"
            Case 8
                strUnidades = "ocho"
            Case 9
                strUnidades = "nueve"
        End Select

        Return ExpertisApp.Traslate(strUnidades)
    End Function

    Public Function Decenas(ByVal intNumero As Integer) As String
        Dim strDecenas As String = String.Empty
        Select Case intNumero
            Case 1
                strDecenas = "diez"
            Case 2
                strDecenas = "veinte"
            Case 3
                strDecenas = "treinta"
            Case 4
                strDecenas = "cuarenta"
            Case 5
                strDecenas = "cincuenta"
            Case 6
                strDecenas = "sesenta"
            Case 7
                strDecenas = "setenta"
            Case 8
                strDecenas = "ochenta"
            Case 9
                strDecenas = "noventa"
        End Select

        Return ExpertisApp.Traslate(strDecenas)
    End Function

    Public Function Centenas(ByVal intNumero As Integer) As String
        Dim strCentenas As String = String.Empty
        Select Case intNumero
            Case 1
                strCentenas = "ciento"
            Case 2
                strCentenas = "doscientos"
            Case 3
                strCentenas = "trescientos"
            Case 4
                strCentenas = "cuatrocientos"
            Case 5
                strCentenas = "quinientos"
            Case 6
                strCentenas = "seiscientos"
            Case 7
                strCentenas = "setecientos"
            Case 8
                strCentenas = "ochocientos"
            Case 9
                strCentenas = "novecientos"
        End Select

        Return ExpertisApp.Traslate(strCentenas)
    End Function

#Region "idiomas"
    Public Function MesTexto(ByVal intMes As Integer, ByVal strIDIdioma As String) As String
        Dim MesesES() As String = {"Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre"}
        Dim MesesPT() As String = {"Janeiro", "Fevereiro", "Março", "Abril", "Maio", "Junho", "Julho", "Agosto", "Setembro", "Outubro", "Novembro", "Dezembro"}
        Select Case strIDIdioma
            Case "ES"
                Return MesesES(intMes - 1)
            Case "PT"
                Return MesesPT(intMes - 1)
            Case Else
                Return String.Empty
        End Select
    End Function

    Public Function ImporteTexto(ByVal dblCifra As Double, ByVal strIDIdioma As String) As String
        Dim strCifraAbs As String = Format(Abs(dblCifra), "0.00")
        Dim strParteEntera As String = Int(strCifraAbs)
        Dim intPosicionComa As Integer = InStr(strCifraAbs, ",")
        Dim strParteDecimal As String = String.Empty
        If intPosicionComa <> 0 Then
            strParteDecimal = Mid(strCifraAbs, intPosicionComa + 1, Len(strCifraAbs) - intPosicionComa)
        End If
        Dim strTexto As String = Convertir(strParteEntera, strIDIdioma)
        If CInt(strParteDecimal) <> 0 Then strTexto = strTexto & " con " & Convertir(strParteDecimal, strIDIdioma)
        Select Case strIDIdioma
            Case "ES"
                If Mid(strTexto, 1, 7) = "un mil" Then strTexto = Mid(strTexto, 4, Len(strTexto))
            Case "PT"
                If Mid(strTexto, 1, 7) = "mil" Then strTexto = Mid(strTexto, 4, Len(strTexto))
        End Select
        Return UCase(strTexto)
    End Function

    Private Function Convertir(ByVal strCifra As String, ByVal strIDIdioma As String) As String
        Dim strVALOR As String = String.Empty
        Dim strTexto As String = String.Empty
        strCifra = Int(strCifra)
        If Len(strCifra) > 6 Then
            If Len(strCifra) = 7 And Left(strCifra, 1) = 1 Then
                Select Case strIDIdioma
                    Case "ES"
                        strTexto = strTexto & "un millón de"
                    Case "PT"
                        strTexto = strTexto & "um milhão de"
                End Select

            Else
                strVALOR = ConvertirParcial(Int(strCifra / 1000000), strIDIdioma)
                Select Case strIDIdioma
                    Case "ES"
                        strTexto = strTexto & strVALOR & "millones de"
                    Case "PT"
                        strTexto = strTexto & strVALOR & "milhões de"
                End Select
            End If
            strCifra = -(Int(strCifra / 1000000) * 1000000 - strCifra)
        End If

        If Len(strCifra) > 3 Then
            strVALOR = ConvertirParcial(Int(strCifra / 1000), strIDIdioma)
            strTexto = strTexto & strVALOR & "mil "
            strCifra = -(Int(strCifra / 1000) * 1000 - strCifra)
        End If

        If strCifra = 0 And Len(strTexto) = 0 Then
            Select Case strIDIdioma
                Case "ES"
                    strVALOR = "cero"
                Case "PT"
                    strVALOR = "zero"
            End Select
            strTexto = strTexto & strVALOR
        Else
            strVALOR = ConvertirParcial(strCifra, strIDIdioma)
            If Len(strVALOR) > 0 Then strTexto = strTexto & strVALOR
        End If
        Select Case strIDIdioma
            Case "ES"
                If Mid(strTexto, 1, 7) = "un mil" Then strTexto = Mid(strTexto, 4, Len(strTexto))
            Case "PT"
                If Mid(strTexto, 1, 7) = "mil" Then strTexto = Mid(strTexto, 4, Len(strTexto))
        End Select
        Return strTexto
    End Function

    Private Function ConvertirParcial(ByVal dblCifra As Double, ByVal strIDIdioma As String) As String
        Dim strTexto As String = String.Empty

        If Left(dblCifra, 1) = "," Then dblCifra = Right(dblCifra & "0", 2) 'Si sólamente tiene un decimal
        dblCifra = Int(dblCifra)

        Dim strValor1 As String = Left(dblCifra, 1)
        If dblCifra > 100 Then
            strTexto = strTexto & Centenas(strValor1, strIDIdioma) & " "
            dblCifra = Mid(dblCifra, 2, Len(CStr(dblCifra)) - 1)
        End If
        If dblCifra = 100 Then
            Select Case strIDIdioma
                Case "ES"
                    strTexto = strTexto & "Cien"
                Case "PT"
                    strTexto = strTexto & "Cem"
            End Select
        Else
            If dblCifra > 9 Then
                strTexto = strTexto & Numero(dblCifra, strIDIdioma)
            Else
                If dblCifra > 1 Then strTexto = strTexto & Unidades(dblCifra, strIDIdioma)
            End If
        End If

        Return strTexto & " "
    End Function

    Public Function Numero(ByVal dblCifra As Double, ByVal strIDIdioma As String) As String
        Dim strTexto As String = String.Empty
        Dim strValor1 As String = Left(dblCifra, 1)
        Dim strValor2 As String = Mid(dblCifra, Len(CStr(dblCifra)), 1)

        Dim intValor1, intValor2 As Integer
        If Len(strValor1) > 0 Then intValor1 = CInt(strValor1)
        If Len(strValor2) > 0 Then intValor2 = CInt(strValor2)
        If intValor1 = 1 Then
            Select Case intValor2
                Case 0
                    Select Case strIDIdioma
                        Case "ES"
                            strTexto = strTexto & "diez"
                        Case "PT"
                            strTexto = strTexto & "dez"
                    End Select

                Case 1
                    Select Case strIDIdioma
                        Case "ES"
                            strTexto = strTexto & "once"
                        Case "PT"
                            strTexto = strTexto & "onze"
                    End Select
                Case 2
                    Select Case strIDIdioma
                        Case "ES"
                            strTexto = strTexto & "doze"
                        Case "PT"
                            strTexto = strTexto & "doze"
                    End Select
                Case 3
                    Select Case strIDIdioma
                        Case "ES"
                            strTexto = strTexto & "trece"
                        Case "PT"
                            strTexto = strTexto & "treze"
                    End Select
                Case 4
                    Select Case strIDIdioma
                        Case "ES"
                            strTexto = strTexto & "catorce"
                        Case "PT"
                            strTexto = strTexto & "catorze"
                    End Select
                Case 5
                    Select Case strIDIdioma
                        Case "ES"
                            strTexto = strTexto & "quince"
                        Case "PT"
                            strTexto = strTexto & "quinze"
                    End Select
                Case Else
                    Select Case strIDIdioma
                        Case "ES"
                            strTexto = strTexto & "dieci " & Unidades(intValor2, strIDIdioma)
                        Case "PT"
                            strTexto = strTexto & "deza " & Unidades(intValor2, strIDIdioma)
                    End Select
            End Select
        ElseIf intValor1 = 2 Then
            Select Case strIDIdioma
                Case "ES"
                    strTexto = strTexto & IIf(intValor2 = 0, "veinte", "veinti" & Unidades(intValor2))
                Case "PT"
                    strTexto = strTexto & IIf(intValor2 = 0, "vinte", "vinte" & Unidades(intValor2))
            End Select
        ElseIf intValor1 >= 3 Then
            strTexto = strTexto & Decenas(intValor1, strIDIdioma)
            Select Case strIDIdioma
                Case "ES"
                    If intValor2 > 0 Then strTexto = strTexto & " y " & Unidades(intValor2, strIDIdioma)
                Case "PT"
                    If intValor2 > 0 Then strTexto = strTexto & " e " & Unidades(intValor2, strIDIdioma)
            End Select
        End If


        Return strTexto
    End Function

    Public Function Unidades(ByVal intNumero As Integer, ByVal strIDIdioma As String) As String
        Dim UnidadesES() As String = {String.Empty, "uno", "dos", "tres", "cuatro", "cinco", "seis", "siete", "ocho", "nueve"}
        Dim UnidadesPT() As String = {String.Empty, "um", "dois", "tres", "quatro", "cinco", "seis", "sete", "oito", "nove"}
        Select Case strIDIdioma
            Case "ES"
                Return UnidadesES(intNumero)
            Case "PT"
                Return UnidadesPT(intNumero)
            Case Else
                Return String.Empty
        End Select
    End Function

    Public Function Decenas(ByVal intNumero As Integer, ByVal strIDIdioma As String) As String
        Dim DecenasES() As String = {String.Empty, "diez", "veinte", "treinta", "cuarenta", "cincuenta", "sesenta", "setenta", "ochenta", "noventa"}
        Dim DecenasPT() As String = {String.Empty, "dez", "vinte", "trinta", "quarenta", "cincuenta", "sessenta", "setenta", "oitenta", "noventa"}
        Select Case strIDIdioma
            Case "ES"
                Return DecenasES(intNumero)
            Case "PT"
                Return DecenasPT(intNumero)
            Case Else
                Return String.Empty
        End Select
    End Function

    Public Function Centenas(ByVal intNumero As Integer, ByVal strIDIdioma As String) As String
        Dim CentenasES() As String = {String.Empty, "ciento", "doscientos", "trescientos", "cuatrocientos", "quinientos", "seiscientos", "setecientos", "ochocientos", "novecientos"}
        Dim CentenasPT() As String = {String.Empty, "cento", "duzentos", "trezentos", "quatrocentos", "quinhentos", "seiscentos", "setecentos", "oitocentos", "novecentos"}
        Select Case strIDIdioma
            Case "ES"
                Return CentenasES(intNumero)
            Case "PT"
                Return CentenasPT(intNumero)
            Case Else
                Return String.Empty
        End Select
    End Function
#End Region

#Region "Number2String-idiomas"
    Public Function ObtenerTextoNumero(ByVal curnumero As Double, Optional ByVal strIDIdioma As String = "") As String
        Select Case strIDIdioma
            Case "PT"
                Return NroEnLetras_PT(curnumero)
            Case Else
                Return NroEnLetras(curnumero)
        End Select
    End Function
    Public Function NroEnLetras(ByVal curNumero As Double, Optional ByVal blnO_Final As Boolean = True) As String
        'Devuelve un número expresado en letras
        'El parámetro blnO_Final se utiliza en la recursión para saber si se dbe colocar la "O" final cuando
        'la palabra es UN(O)
        Dim dblCentavos As Double
        Dim lngContDec As Long
        Dim lngContCent As Long
        Dim lngContMil As Long
        Dim lngContMillon As Long
        Dim strNumLetras As String = String.Empty
        Dim strNumero() As String = {String.Empty, "UN", "DOS", "TRES", "CUATRO", "CINCO", "SEIS", "SIETE", "OCHO", "NUEVE", _
                                    "DIEZ", "ONCE", "DOCE", "TRECE", "CATORCE", "QUINCE", "DIECISEIS", "DIECISIETE", "DIECIOCHO", _
                                    "DIECINUEVE", "VEINTE"}
        Dim strDecenas() As String = {String.Empty, String.Empty, "VEINTI", "TREINTA", "CUARENTA", "CINCUENTA", "SESENTA", "SETENTA", _
                                    "OCHENTA", "NOVENTA", "CIEN"}
        Dim strCentenas() As String = {String.Empty, "CIENTO", "DOSCIENTOS", "TRESCIENTOS", "CUATROCIENTOS", "QUINIENTOS", "SEISCIENTOS", "SETECIENTOS", _
                                    "OCHOCIENTOS", "NOVECIENTOS"}
        Dim blnNegativo As Boolean
        Dim blnPlural As Boolean
        Try

            If Int(curNumero) = 0 Then
                strNumLetras = "CERO"
            End If
            If curNumero < 0 Then
                blnNegativo = True
                curNumero = Math.Abs(curNumero)
            End If
            If Int(curNumero) <> curNumero Then
                dblCentavos = Math.Abs(curNumero - Int(curNumero))
                curNumero = Int(curNumero)
            End If
            Do While curNumero > 1000000
                lngContMillon = lngContMillon + 1
                curNumero = curNumero - 1000000
            Loop
            Do While curNumero > 1000
                lngContMil = lngContMil + 1
                curNumero = curNumero - 1000
            Loop
            Do While curNumero > 100
                lngContCent = lngContCent + 1
                curNumero = curNumero - 100
            Loop
            If Not (curNumero > 10 And curNumero <= 20) Then
                Do While curNumero >= 10
                    lngContDec = lngContDec + 1
                    curNumero = curNumero - 10
                Loop
            End If
            If lngContMillon > 0 Then
                If lngContMillon >= 1 Then 'si el numero es mayor de 1000000 usa recursividad
                    strNumLetras = NroEnLetras(lngContMillon, False)
                    If Not blnPlural Then blnPlural = (lngContMillon > 1)
                    lngContMillon = 0
                End If
                strNumLetras = Trim(strNumLetras) & strNumero(lngContMillon) & " MILLON" & IIf(blnPlural, "ES ", " ")
            End If
            If lngContMil > 0 Then
                If lngContMil > 1 Then 'si el numero es >100000 usa recursividad
                    strNumLetras = strNumLetras & NroEnLetras(lngContMil, False)
                    lngContMil = 0
                    strNumLetras = Trim(strNumLetras) & strNumero(lngContMil) & " MIL "
                Else
                    strNumLetras = Trim(strNumLetras) & " MIL "
                End If

            End If
            If lngContCent > 0 Then
                If lngContCent = 1 And lngContDec = 0 And curNumero = 0 Then
                    strNumLetras = strNumLetras & " CIEN "
                Else
                    strNumLetras = strNumLetras & strCentenas(lngContCent) & " "
                End If
            End If
            If lngContDec >= 1 Then
                If lngContDec = 1 Then
                    strNumLetras = strNumLetras & strNumero(10)
                Else
                    strNumLetras = strNumLetras & strDecenas(lngContDec)
                End If
                If lngContDec >= 3 And curNumero > 0 Then
                    strNumLetras = strNumLetras & " Y "
                End If
            Else
                If curNumero >= 0 And curNumero <= 20 Then
                    strNumLetras = strNumLetras & strNumero(curNumero)
                    If curNumero = 1 And blnO_Final Then
                        strNumLetras = strNumLetras & "O"
                    End If
                    If dblCentavos > 0 Then
                        strNumLetras = Trim(strNumLetras) & " EUROS CON " & NroEnLetrasDec(CInt(Round(dblCentavos, 2) * 100))
                    End If
                    Return strNumLetras
                    Exit Function
                End If
            End If
            If curNumero > 0 Then
                strNumLetras = strNumLetras & strNumero(curNumero)
                If curNumero = 1 And blnO_Final Then
                    strNumLetras = strNumLetras & "O"
                End If
            End If
            If dblCentavos > 0 Then
                strNumLetras = strNumLetras & " EUROS CON " & NroEnLetrasDec(CInt(Round(dblCentavos, 2) * 100))
            End If
            Return IIf(blnNegativo, "(" & strNumLetras & ")", strNumLetras)
        Catch ex As Exception
            ExpertisApp.GenerateMessage("Se ha producido un error")
            Return String.Empty
        End Try
    End Function
    Public Function NroEnLetras_PT(ByVal curNumero As Double, Optional ByVal blnO_Final As Boolean = True) As String
        'Devuelve un número expresado en letras
        'El parámetro blnO_Final se utiliza en la recursión para saber si se dbe colocar la "O" final cuando
        'la palabra es UN(O)
        Dim dblCentavos As Double
        Dim lngContDec As Long
        Dim lngContCent As Long
        Dim lngContMil As Long
        Dim lngContMillon As Long
        Dim strNumLetras As String = String.Empty
        Dim strNumero() As String = {String.Empty, "UM", "DOIS", "TRES", "QUATRO", "CINCO", "SEIS", "SETE", "OITO", "NOVE", _
                                    "DEZ", "ONZE", "DOCE", "TREZE", "QUATORZE", "QUINZE", "DEZESSEIS", "DEZESSETE", "DEZOITO", _
                                    "DEZENOVE", "VINTE"}
        Dim strDecenas() As String = {String.Empty, String.Empty, "VINTE", "TRINTA", "QUARENTA", "CINCUENTA", "SESSENTA", "SETENTA", _
                                    "OITENTA", "NOVENTA", "CEM"}
        Dim strCentenas() As String = {String.Empty, "CENTO", "DUZENTOS", "TREZENTOS", "QUATROCENTOS", "QUINHENTOS", "SEISCENTOS", "SETECENTOS", _
                                    "OITOCENTOS", "NOVECENTOS"}
        Dim blnNegativo As Boolean
        Dim blnPlural As Boolean
        Try

            If Int(curNumero) = 0 Then
                strNumLetras = "ZERO"
            End If
            If curNumero < 0 Then
                blnNegativo = True
                curNumero = Math.Abs(curNumero)
            End If
            If Int(curNumero) <> curNumero Then
                dblCentavos = Math.Abs(curNumero - Int(curNumero))
                curNumero = Int(curNumero)
            End If
            Do While curNumero > 1000000
                lngContMillon = lngContMillon + 1
                curNumero = curNumero - 1000000
            Loop
            Do While curNumero > 1000
                lngContMil = lngContMil + 1
                curNumero = curNumero - 1000
            Loop
            Do While curNumero > 100
                lngContCent = lngContCent + 1
                curNumero = curNumero - 100
            Loop
            If Not (curNumero > 10 And curNumero <= 20) Then
                Do While curNumero >= 10
                    lngContDec = lngContDec + 1
                    curNumero = curNumero - 10
                Loop
            End If
            If lngContMillon > 0 Then
                If lngContMillon >= 1 Then 'si el numero es mayor de 1000000 usa recursividad
                    strNumLetras = NroEnLetras_PT(lngContMillon, False)
                    If Not blnPlural Then blnPlural = (lngContMillon > 1)
                    lngContMillon = 0
                End If
                strNumLetras = Trim(strNumLetras) & strNumero(lngContMillon) & IIf(blnPlural, "MILHÕES ", "MILHÃO ")
            End If
            If lngContMil > 0 Then
                If lngContMil > 1 Then 'si el numero es >100000 usa recursividad
                    strNumLetras = strNumLetras & NroEnLetras_PT(lngContMil, False)
                    lngContMil = 0
                    strNumLetras = Trim(strNumLetras) & strNumero(lngContMil) & " MIL "
                Else
                    strNumLetras = Trim(strNumLetras) & " MIL "
                End If

            End If
            If lngContCent > 0 Then
                If lngContCent = 1 And lngContDec = 0 And curNumero = 0 Then
                    strNumLetras = strNumLetras & " CEM "
                Else
                    strNumLetras = strNumLetras & strCentenas(lngContCent) & " "
                End If
            End If
            If lngContDec >= 1 Then
                If lngContDec = 1 Then
                    strNumLetras = strNumLetras & strNumero(10)
                Else
                    strNumLetras = strNumLetras & strDecenas(lngContDec)
                End If
                If lngContDec >= 3 And curNumero > 0 Then
                    strNumLetras = strNumLetras & " E "
                End If
            Else
                If curNumero >= 0 And curNumero <= 20 Then
                    strNumLetras = strNumLetras & strNumero(curNumero)
                    'If curNumero = 1 And blnO_Final Then
                    '   strNumLetras = strNumLetras & "O"
                    'End If
                    If dblCentavos > 0 Then
                        strNumLetras = Trim(strNumLetras) & " EUROS COM " & NroEnLetrasDec_PT(CInt(Round(dblCentavos, 2) * 100))
                    End If
                    Return strNumLetras
                    Exit Function
                End If
            End If
            If curNumero > 0 Then
                strNumLetras = strNumLetras & strNumero(curNumero)
                If curNumero = 1 And blnO_Final Then
                    strNumLetras = strNumLetras & "O"
                End If
            End If
            If dblCentavos > 0 Then
                strNumLetras = strNumLetras & " EUROS COM " & NroEnLetrasDec_PT(CInt(Round(dblCentavos, 2) * 100))
            End If
            Return IIf(blnNegativo, "(" & strNumLetras & ")", strNumLetras)
        Catch ex As Exception
            ExpertisApp.GenerateMessage("Se ha producido un error")
            Return String.Empty
        End Try
    End Function
    Public Function NroEnLetrasDec(ByVal dblParteDecimal As Double) As String
        Try
            Dim lngLongitud As Long = Length(dblParteDecimal.ToString & String.Empty)
            Return NroEnLetras(dblParteDecimal, False) & IIf(dblParteDecimal = 1, " CÉNTIMO", " CÉNTIMOS")
        Catch ex As Exception
            ExpertisApp.GenerateMessage("Se ha producido un error")
            Return String.Empty
        End Try
    End Function
    Public Function NroEnLetrasDec_PT(ByVal dblParteDecimal As Double) As String
        Try
            Dim lngLongitud As Long = Length(dblParteDecimal.ToString & String.Empty)
            Return NroEnLetras(dblParteDecimal, False) & IIf(dblParteDecimal = 1, " CENTIMO", " CENTIMOS")
        Catch ex As Exception
            ExpertisApp.GenerateMessage("Se ha producido un error")
            Return String.Empty
        End Try
    End Function
#End Region

End Module
