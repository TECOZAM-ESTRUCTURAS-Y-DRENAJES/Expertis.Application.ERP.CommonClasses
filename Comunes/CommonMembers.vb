Imports System.Xml
Imports System.Security.Cryptography
Imports System.Security.Cryptography.Xml
Imports System.Security.Cryptography.X509Certificates
Imports Expertis.Business.Pisos

Public Module CommonMembers

    Public Function NumberToText(ByVal dblCifra As Double) As String
        Return ObtenerTextoNumero(dblCifra)
    End Function

#Region " Marcar/Desmarcar Registro"

    Public Class DataComprobarBloqReg
        Public IDEnlace As String
        Public TipoFiltro As Engine.FilterType

        Public Sub New()
        End Sub
        Public Sub New(ByVal IDEnlace As String, ByVal TipoFiltro As Engine.FilterType)
            Me.IDEnlace = IDEnlace
            Me.TipoFiltro = TipoFiltro
        End Sub
    End Class

    Public Function BloquearRegistro(ByVal Data As DataComprobarBloqReg) As Guid
        Dim StrSource As String = String.Empty
        Select Case Data.TipoFiltro
            Case Engine.FilterType.Numeric
                StrSource = "xNumericCheck"
            Case Engine.FilterType.DateTime, Engine.FilterType.Guid, Engine.FilterType.String, Engine.FilterType.Boolean
                StrSource = "xTextCheck"
        End Select
        Dim DtChecks As DataTable = New BE.DataEngine().Filter(StrSource, New FilterItem("IDEnlace", FilterOperator.Equal, Data.IDEnlace))
        If Not DtChecks Is Nothing AndAlso DtChecks.Rows.Count > 0 Then
            ExpertisApp.GenerateMessage("El registro que se está intentando marcar ya está en uso por otro usuario.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return Nothing
        Else
            Return MarcarRegistro(Data.IDEnlace, Data.TipoFiltro, False)
        End If
    End Function

    Public Function ComprobarBloqueoRegistro(ByVal Data As DataComprobarBloqReg) As Boolean
        Dim StrSource As String = String.Empty
        Select Case Data.TipoFiltro
            Case Engine.FilterType.Numeric
                StrSource = "xNumericCheck"
            Case Engine.FilterType.DateTime, Engine.FilterType.Guid, Engine.FilterType.String, Engine.FilterType.Boolean
                StrSource = "xTextCheck"
        End Select
        Dim DtChecks As DataTable = New BE.DataEngine().Filter(StrSource, New FilterItem("IDEnlace", FilterOperator.Equal, Data.IDEnlace))
        If Not DtChecks Is Nothing AndAlso DtChecks.Rows.Count > 0 Then
            ExpertisApp.GenerateMessage("El registro está en uso por otro usuario.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return True
        Else
            Return False
        End If
    End Function

    Public Function MarcarRegistro(ByVal strIDEnlace As String, _
                                   ByVal FilterType As Solmicro.Expertis.Engine.FilterType, _
                                   Optional ByVal blnPrint As Boolean = False) As Guid
        Dim gGuid As New Guid
        Dim dt As DataTable
        Dim G As Guid = Guid.NewGuid()

        
        dt = CreateCheckDataTable(FilterType)
        Dim NR As DataRow
        NR = dt.NewRow()
        gGuid = Nothing
        NR("IDProcess") = G
        'NR("IDEnlace") = strIDEnlace
        If blnPrint Then
            NR("NumericLink") = strIDEnlace
        Else
            NR("IDEnlace") = strIDEnlace
        End If
        dt.Rows.Add(NR)

        Dim AppService As New BE.DataEngine
        AppService.SaveServerChecks(dt)
        MarcarRegistro = G
    End Function

    Public Function MarcarRegistro(ByVal htIDEnlace As Hashtable, _
                                   ByVal FilterType As Solmicro.Expertis.Engine.FilterType, _
                                   Optional ByVal blnPrint As Boolean = False) As Guid
        Dim NR As DataRow
        Dim gGuid As New Guid
        Dim dt As DataTable
        Dim G As Guid = Guid.NewGuid()
        Dim i As Integer
        gGuid = Nothing

        If Not IsNothing(htIDEnlace) AndAlso htIDEnlace.Count > 0 Then
            dt = CreateCheckDataTable(FilterType)

            i = 0
            While i <= htIDEnlace.Count - 1
                NR = dt.NewRow()
                NR("IDProcess") = G
                If blnPrint Then
                    NR("NumericLink") = htIDEnlace("NumericLink" & i)
                Else
                    NR("IDEnlace") = htIDEnlace("IDEnlace" & i)
                End If
                dt.Rows.Add(NR)

                i = i + 1
            End While

            Dim AppService As New BE.DataEngine
            AppService.SaveServerChecks(dt)
        End If
        MarcarRegistro = G
    End Function

    Public Function MarcarRegistro(ByVal ID() As Object, ByVal FilterType As Solmicro.Expertis.Engine.FilterType, Optional ByVal blnPrint As Boolean = False) As Guid
        Dim NR As DataRow
        Dim dt As DataTable
        Dim G As Guid = Guid.NewGuid()

        If Not ID Is Nothing AndAlso ID.Length > 0 Then
            dt = CreateCheckDataTable(FilterType)

            For i As Integer = 0 To ID.Length - 1
                NR = dt.NewRow()
                NR("IDProcess") = G
                If blnPrint Then
                    NR("NumericLink") = ID(i)
                Else
                    NR("IDEnlace") = ID(i)
                End If
                dt.Rows.Add(NR)
            Next

            Dim AppService As New BE.DataEngine
            AppService.SaveServerChecks(dt)
        End If
        MarcarRegistro = G
    End Function

    Public Sub DesmarcarRegistro(ByVal G As Guid, ByVal FilterType As Solmicro.Expertis.Engine.FilterType)
        Dim AppService As New BE.DataEngine
        AppService.DeleteServerChecks(G, FilterType)
    End Sub

#End Region

#Region " RellenarComboAños "

    Public Enum enumTipoGeneracionAños
        AmbasDirecciones
        IncrementarAños
        DecrementarAños
    End Enum

    Public Sub RellenarComboAños(ByRef cbxAño As Solmicro.Expertis.Engine.UI.ComboBox, ByVal intNumAños As Integer, _
                                 Optional ByVal blnLineaVacia As Boolean = True, _
                                 Optional ByVal TipoGeneracion As enumTipoGeneracionAños = enumTipoGeneracionAños.AmbasDirecciones)

        Dim intAñoActual As Integer = Date.Today.Year

        Dim dt As New DataTable
        dt.Columns.Add("Año", GetType(Integer))

        Dim dr As DataRow
        If blnLineaVacia Then
            dr = dt.NewRow()
            dr("Año") = System.DBNull.Value
            dt.Rows.Add(dr)
        End If

        Dim intNumAñosIncremento As Integer = intNumAños
        Dim intNumAñosDecremento As Integer = intNumAños

        If TipoGeneracion = enumTipoGeneracionAños.DecrementarAños Then
            intNumAñosDecremento = 0
        End If
        If TipoGeneracion = enumTipoGeneracionAños.IncrementarAños Then
            intNumAñosIncremento = 0
        End If
        For i As Integer = intAñoActual - intNumAñosIncremento To intAñoActual + intNumAñosDecremento
            dr = dt.NewRow()
            dr("Año") = i
            dt.Rows.Add(dr)
        Next i
        dt.AcceptChanges()

        cbxAño.SetDataBinding(dt, "")
    End Sub

    Public Sub RellenarComboAños(ByRef cbxAño As Solmicro.Expertis.Engine.UI.ComboBox)
        RellenarComboAños(cbxAño, 20)
    End Sub

#End Region

#Region " Financiero "

    Public Function PuntoPorCero(ByVal pCuenta As String, ByVal pNDigitos As Integer, ByVal strEjercicio As String) As String
        Dim strCeros As String
        Dim strC As String = String.Empty

        If InStr(pCuenta, ".") Then
            strC = "."
        ElseIf InStr(pCuenta, ",") Then
            strC = ","
        End If

        If Len(strEjercicio) > 0 Then
            If Len(strC) Then
                strCeros = New String("0", pNDigitos - Len(pCuenta) + 1)
                pCuenta = Replace(pCuenta, strC, strCeros, , 1)
            End If
            If InStr(pCuenta, ".") Then pCuenta = Replace(pCuenta, ".", "0")
            If InStr(pCuenta, ",") Then pCuenta = Replace(pCuenta, ",", "0")
        End If
        PuntoPorCero = pCuenta
    End Function

    Public Class DataComprobarCContablesDestino
        Public IDEjercicio As String
        Public dt As DataTable
        Public OK As Boolean
        Public MensajeError As String

        Public Sub New(ByVal IDEjercicio As String, ByVal dt As DataTable)
            Me.IDEjercicio = IDEjercicio
            Me.dt = dt

            Me.OK = True
        End Sub
    End Class
    Public Function ComprobarCContablesDestino(ByVal data As DataComprobarCContablesDestino) As DataComprobarCContablesDestino
        '//Comprobamos si cada una de las cuentas destino están en ese Plan Contable.
        data.OK = True
        Dim CuentasNoExisten As New List(Of String)
        Dim f As New Filter : Dim PC As New PlanContable
        For Each drRow As DataRow In data.dt.Rows
            f.Clear()
            f.Add(New StringFilterItem("IDEjercicio", data.IDEjercicio))
            f.Add(New StringFilterItem("IDCContable", drRow("IDCCDestino")))
            Dim dtPC As DataTable = PC.Filter(f)
            If dtPC Is Nothing OrElse dtPC.Rows.Count = 0 Then
                If Not CuentasNoExisten.Contains(drRow("IDCCDestino")) Then
                    CuentasNoExisten.Add(drRow("IDCCDestino"))
                End If
            End If
        Next

        '//Preparamos el mensaje de error.
        If Not CuentasNoExisten Is Nothing AndAlso CuentasNoExisten.Count > 0 Then
            data.OK = False
            Dim strCuentas As String = Join(CuentasNoExisten.ToArray, ",")
            data.MensajeError = ExpertisApp.Traslate("La Cuenta Contable | no existe.", strCuentas)
        End If

        Return data
    End Function


    Public Function DescripcionCContable(ByVal strIdEjercicio As String, ByVal strCContable As String) As String
        Dim strDescripcion As String = String.Empty

        If Len(strCContable) > 0 Then
            Dim Pc As New PlanContable
            Dim dtPlanContable As DataTable = Pc.SelOnPrimaryKey(strIdEjercicio, strCContable)
            If Not dtPlanContable Is Nothing AndAlso dtPlanContable.Rows.Count > 0 Then
                strDescripcion = dtPlanContable.Rows(0)("DescCContable") & String.Empty
            End If
        End If

        Return strDescripcion
    End Function

    Public Function GeneraCContable(ByVal strCodigo As String, ByVal strEjercicio As String, ByVal TipoCodigo As enumTipoCodigo) As String
        Dim datCta As New PlanContable.DataGeneraCContable(strCodigo, strEjercicio, TipoCodigo)
        Dim strCuenta As String = ExpertisApp.ExecuteTask(Of PlanContable.DataGeneraCContable, String)(AddressOf PlanContable.GeneraCContable, datCta)
        Return strCuenta
    End Function


    Public Function ComprobarAnaliticaCuentas(ByVal StrCContable As String, ByVal StrEjercicio As String) As Boolean
        Dim IntAnalitT As Integer = New Parametro().CAnaliticTipo
        Dim FilPlan As New Filter
        FilPlan.Add("IDEjercicio", FilterOperator.Equal, StrEjercicio, FilterType.String)
        FilPlan.Add("IDCContable", FilterOperator.Equal, StrCContable, FilterType.String)
        Dim DtPlan As DataTable = New PlanContable().Filter(FilPlan)
        If Not DtPlan Is Nothing AndAlso DtPlan.Rows.Count > 0 AndAlso DtPlan.Rows(0)("Analitica") Then
            Return True
        Else
            If IntAnalitT = enumGestionAnalitica.CCNoAnalitica Then
                Return True
            ElseIf IntAnalitT = enumGestionAnalitica.CCAnalitica Then
                Return False
            End If
        End If
    End Function

    Public Function ConstruirEnumeradoTipoApunte(Optional ByVal blnMostrarAbrev As Boolean = False) As DataView
        '//Recogemos los distintos tipos de apuntes definidos.
        Dim f As New Filter
        Dim objNegTipoApunte As New TipoApunte
        Dim dtTipoApunteAux As DataTable = objNegTipoApunte.Filter(f)
        objNegTipoApunte = Nothing

        '//Construimos un "enumerado virtual" para tener los valores de la table tbMaestroTipoApunte en un enumrado.
        Dim dtTipoApunte As New DataTable
        dtTipoApunte.Columns.Add("IDTipoApunte", GetType(Integer))
        dtTipoApunte.Columns.Add("DescTipoApunte", GetType(String))
        If blnMostrarAbrev Then dtTipoApunte.Columns.Add("Abreviatura", GetType(String))
        Dim drTipoApunte As DataRow

        For Each drTipoApunteAux As DataRow In dtTipoApunteAux.Rows
            drTipoApunte = dtTipoApunte.NewRow
            drTipoApunte("IDTipoApunte") = drTipoApunteAux("IDTipoApunte")
            drTipoApunte("DescTipoApunte") = drTipoApunteAux("DescTipoApunte")
            If blnMostrarAbrev Then drTipoApunte("Abreviatura") = drTipoApunteAux("Abreviatura")
            dtTipoApunte.Rows.Add(drTipoApunte)
        Next

        Return dtTipoApunte.DefaultView
    End Function

#End Region

    Public Function RecuperarDescripcionEnumerado(ByVal strEnum As String, ByVal intValueEnum As Integer) As String
        Dim objItemActual As Object
        ' Se recorre el enumerado para obtener la descripción del enumerado.
        Dim dv As DataView = EnumData.EnumView(strEnum)
        Dim objEnumerador As IEnumerator = dv.GetEnumerator
        objEnumerador.Reset()
        Do While objEnumerador.MoveNext
            objItemActual = objEnumerador.Current()
            If CType(objItemActual.Row, DataRow)("Value") = intValueEnum Then
                Return CType(objItemActual.Row, DataRow)("Text")
            End If
        Loop
        Return String.Empty
    End Function

    Public Function TratarSimbolosEspeciales(ByVal StrCadena As String) As String
        ''1º Grupo de Simbolos Especiales
        'For i As Integer = 33 To 47
        '    StrCadena = Strings.Replace(StrCadena, Chr(i), "")
        'Next
        ''2º Grupo de Simbolos Especiales
        'For i As Integer = 58 To 64
        '    StrCadena = Strings.Replace(StrCadena, Chr(i), "")
        'Next
        ''3º Grupo de Simbolos Especiales
        'For i As Integer = 91 To 96
        '    StrCadena = Strings.Replace(StrCadena, Chr(i), "")
        'Next
        ''4º Grupo de Simbolos Especiales
        'For i As Integer = 123 To 126
        '    StrCadena = Strings.Replace(StrCadena, Chr(i), "")
        'Next
        ''Simbolo de la Ñ (164-165)
        'StrCadena = Strings.Replace(StrCadena, "ñ", "n")
        'StrCadena = Strings.Replace(StrCadena, "Ñ", "N")
        'Caracteres con Acentos en mayusculas
        StrCadena = Strings.Replace(StrCadena, "Á", "A") : StrCadena = Strings.Replace(StrCadena, "á", "a")
        StrCadena = Strings.Replace(StrCadena, "É", "E") : StrCadena = Strings.Replace(StrCadena, "é", "e")
        StrCadena = Strings.Replace(StrCadena, "Í", "I") : StrCadena = Strings.Replace(StrCadena, "í", "i")
        StrCadena = Strings.Replace(StrCadena, "Ó", "O") : StrCadena = Strings.Replace(StrCadena, "ó", "o")
        StrCadena = Strings.Replace(StrCadena, "Ú", "U") : StrCadena = Strings.Replace(StrCadena, "ú", "u")
        ''Últimos símbolos sueltos de la tabla Ascii
        'For i As Integer = 128 To 255
        '    StrCadena = Strings.Replace(StrCadena, Chr(i), "")
        'Next
        Return StrCadena
    End Function

#Region " OpenDocumentoWord "

    Public Sub AbrirFicheroDoc(ByVal strPath() As String)
        If Not IsNothing(strPath) Then
            Dim i As Integer
            For i = 0 To UBound(strPath)
                AbrirFicheroDoc(strPath(i))
            Next i
        End If
    End Sub

    Public Sub AbrirFicheroDoc(ByVal strPath As String)
        If Len(strPath) > 0 Then
            If System.IO.File.Exists(strPath) Then
                Dim FichPrc As New ProcessStartInfo(strPath)
                FichPrc.WindowStyle = ProcessWindowStyle.Maximized
                Process.Start(FichPrc)
            Else
                ExpertisApp.GenerateMessage("No se ha podido encontrar la ruta del archivo especificado.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        Else
            ExpertisApp.GenerateMessage("No hay ningún documento Word asociado.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

#End Region

#Region " BloquearInformacion. Metodos que bloquean todos los controles que estén contenidos en el control que se pasa en el parámetro"

    Public Sub BloquearInformacion(ByVal c As Control, ByVal blnEnabled As Boolean)
        BloquearInformacion(c, blnEnabled, Nothing)
    End Sub

    Public Sub BloquearInformacion(ByVal c As Control, ByVal blnEnabled As Boolean, _
                                   ByVal ParamArray ControlesNoBloquedos() As Object)
        For Each ctl As Control In c.Controls
            If TypeOf ctl Is Janus.Windows.UI.Tab.UITabPage _
              Or TypeOf ctl Is Solmicro.Expertis.Engine.UI.Tab _
              Or TypeOf ctl Is Solmicro.Expertis.Engine.UI.Panel _
              Or TypeOf ctl Is Solmicro.Expertis.Engine.UI.Frame _
              Or TypeOf ctl Is SplitterPanel Then
                BloquearInformacion(ctl, blnEnabled, ControlesNoBloquedos)
            End If
            If TypeOf ctl Is SplitContainer Then
                BloquearInformacion(CType(ctl, SplitContainer).Panel1, blnEnabled, ControlesNoBloquedos)
                BloquearInformacion(CType(ctl, SplitContainer).Panel2, blnEnabled, ControlesNoBloquedos)
            End If
            If TypeOf ctl Is Solmicro.Expertis.Engine.UI.AdvSearch _
              Or TypeOf ctl Is Solmicro.Expertis.Engine.UI.CounterTextBox _
              Or TypeOf ctl Is Solmicro.Expertis.Engine.UI.Button _
              Or TypeOf ctl Is Solmicro.Expertis.Engine.UI.ComboBox _
              Or TypeOf ctl Is Solmicro.Expertis.Engine.UI.NumericTextBox _
              Or TypeOf ctl Is Solmicro.Expertis.Engine.UI.TextBox _
              Or TypeOf ctl Is Solmicro.Expertis.Engine.UI.CheckBox _
              Or TypeOf ctl Is Solmicro.Expertis.Engine.UI.RadioButton _
              Or TypeOf ctl Is Solmicro.Expertis.Engine.UI.CalendarBox Then
                If Bloquear(ctl, ControlesNoBloquedos) Then
                    ctl.Enabled = Not blnEnabled
                End If
            End If
            If TypeOf ctl Is Solmicro.Expertis.Engine.UI.Grid Then
                Dim g As Grid = CType(ctl, Grid)
                If Bloquear(ctl, ControlesNoBloquedos) Then
                    If blnEnabled Then
                        g.AllowDelete = InheritableBoolean.False
                        g.AllowAddNew = InheritableBoolean.False
                    Else
                        g.AllowDelete = InheritableBoolean.True
                        g.AllowAddNew = InheritableBoolean.True
                    End If
                End If
            End If
        Next
    End Sub

    Private Function Bloquear(ByVal ctl As Control, ByVal ParamArray ControlesNoBloquedos() As Object) As Boolean
        Bloquear = True
        If ControlesNoBloquedos Is Nothing Then
        Else
            For i As Integer = 0 To ControlesNoBloquedos.Length - 1
                If ctl.Name = ControlesNoBloquedos(i).Name Then
                    Bloquear = False
                    Exit For
                End If
            Next
        End If
    End Function

#End Region

#Region " ANALITICA "

    Public Overloads Function AbrirFormularioDiarioAnalitica(ByVal intTipoAnalitica As enumtaTipoAnalitica, _
                                                        ByVal blnCCAnalitica As Boolean, _
                                                        ByVal strIDCContable As String, _
                                                        ByVal strDescApunte As String, _
                                                        ByVal dblImpApunteA As Double, _
                                                        ByVal strDH As String, _
                                                        ByVal dtAnalitica As DataTable, _
                                                        Optional ByVal dFechaApunte As Date = CDate(#12:00:00 AM#), _
                                                        Optional ByVal strIDEnlace As String = "", _
                                                        Optional ByVal blnMostrarRepartoCG As Boolean = True, _
                                                        Optional ByVal blnReadOnly As Boolean = False) As DataTable


        Return AbrirFormularioDiarioAnalitica(intTipoAnalitica, _
                                              blnCCAnalitica, _
                                              strIDCContable, _
                                              strDescApunte, _
                                              dblImpApunteA, _
                                              strDH, _
                                              dtAnalitica, _
                                              Nothing, _
                                              dFechaApunte, _
                                              strIDEnlace, _
                                              blnMostrarRepartoCG, _
                                              blnReadOnly)

    End Function

    Public Overloads Function AbrirFormularioDiarioAnalitica(ByVal intTipoAnalitica As enumtaTipoAnalitica, _
                                                       ByVal blnCCAnalitica As Boolean, _
                                                       ByVal strIDCContable As String, _
                                                       ByVal strDescApunte As String, _
                                                       ByVal dblImpApunteA As Double, _
                                                       ByVal strDH As String, _
                                                       ByVal dtAnalitica As DataTable, _
                                                       ByVal strTitulo As String, _
                                                       Optional ByVal dFechaApunte As Date = CDate(#12:00:00 AM#), _
                                                       Optional ByVal strIDEnlace As String = "", _
                                                       Optional ByVal blnMostrarRepartoCG As Boolean = True, _
                                                       Optional ByVal blnReadOnly As Boolean = False) As DataTable

        If (Length(strIDEnlace) > 0) OrElse _
            (Length(strIDEnlace) = 0 AndAlso intTipoAnalitica = enumtaTipoAnalitica.AsientoNuevo) Then
            Dim frmAnalitica As New DiarioAnalitica
            With frmAnalitica
                .ReadOnlyAnalitica = blnReadOnly
                .TipoAnalitica = intTipoAnalitica
                .CCAnalitica = blnCCAnalitica
                .CuentaContable = strIDCContable
                .DescripcionAnalitica = strDescApunte
                .FechaAnalitica = dFechaApunte
                .ImporteAnalitica = dblImpApunteA ' Math.Abs(dblImpApunteA)
                If Length(strDH) = 0 Then strDH = "D"
                .DH = strDH
                If Length(strIDEnlace) > 0 Then
                    .IDEnlace = strIDEnlace
                Else
                    .IDEnlace = -1
                End If
                .DTAnalitica = dtAnalitica
                .MostrarRepartoCG = blnMostrarRepartoCG
                If Length(strTitulo) > 0 Then .Title = strTitulo
                .ShowDialog()
                Return .DTAnalitica
            End With
            frmAnalitica = Nothing
        Else
            If intTipoAnalitica <> enumtaTipoAnalitica.AsientoNuevo Then
                Throw New Exception("Debe salvar los datos antes de introducir la analítica.")
            End If
        End If

    End Function
#End Region

    Public Function TiempoOperacion(ByVal dblTiempo As Double, ByVal UdTiempo As enumstdUdTiempo) As Double
        Select Case UdTiempo
            Case enumstdUdTiempo.Dias
                TiempoOperacion = dblTiempo * 24
            Case enumstdUdTiempo.Horas
                TiempoOperacion = dblTiempo
            Case enumstdUdTiempo.Minutos
                TiempoOperacion = dblTiempo / 60
            Case enumstdUdTiempo.Segundos
                TiempoOperacion = dblTiempo / 3600
        End Select
    End Function

    Public Function TratarSecuencias(ByVal dt As DataTable, ByVal idColumna As String, ByVal Ultimo As Boolean) As DataTable
        Dim intContadorSecuencia As Integer = 10
        If Not Ultimo Then
            For Each dr As DataRow In dt.Select("", idColumna & " ASC")
                dr(idColumna) = intContadorSecuencia
                intContadorSecuencia += 10
            Next
        Else
            Dim SecuenciaMaxima As Integer = 0
            For Each dr As DataRow In dt.Select("", idColumna & " DESC")
                If Length(dr(idColumna)) > 0 Then
                    SecuenciaMaxima = dr(idColumna)
                    Exit For
                End If
            Next
            For Each dr As DataRow In dt.Select("", idColumna & " ASC")
                If Length(dr(idColumna)) = 0 Then
                    dr(idColumna) = SecuenciaMaxima + 10
                    Exit For
                Else
                    dr(idColumna) = intContadorSecuencia
                    intContadorSecuencia += 10
                End If
            Next
        End If
        Return dt
    End Function

    Public Function TratarOrdenesLinea(ByVal dt As DataTable, ByVal idColumna As String, ByVal Ultimo As Boolean) As DataTable
        Dim intContadorSecuencia As Integer = 1
        If Not Ultimo Then
            For Each dr As DataRow In dt.Select("", idColumna & " ASC")
                dr(idColumna) = intContadorSecuencia
                intContadorSecuencia += 1
            Next
        Else
            Dim SecuenciaMaxima As Integer = 0
            For Each dr As DataRow In dt.Select("", idColumna & " DESC")
                If Length(dr(idColumna)) > 0 Then
                    SecuenciaMaxima = dr(idColumna)
                    Exit For
                End If
            Next
            For Each dr As DataRow In dt.Select("", idColumna & " ASC")
                If Length(dr(idColumna)) = 0 Then
                    dr(idColumna) = SecuenciaMaxima + 1
                    Exit For
                Else
                    dr(idColumna) = intContadorSecuencia
                    intContadorSecuencia += 1
                End If
            Next
        End If
        Return dt
    End Function

    Public Function NumeroDecimales(ByVal dblNumero As Double) As Integer
        Dim intDec As Integer = Strings.InStrRev(CStr(dblNumero), ",")
        Return Length(CStr(dblNumero)) - intDec
    End Function
    
#Region " Tratamiento de log de un proceso "

    Public Sub TratarLog(ByVal log As LogProcess, ByVal TipoDocumento As enumTipoDocumentoCreado, Optional ByVal MostrarPantallaLog As Boolean = False, Optional ByVal AbrirMnto As Boolean = False, Optional ByVal StockLog() As StockUpdateData = Nothing)
        If log Is Nothing Then ExpertisApp.GenerateMessage("Ha ocurrido un error al realizar el proceso. No se ha creado el log.")

        Dim params(-1) As Object
        Dim FirstID As Object
        Dim strMessage As String = String.Empty

        Dim dtLog As DataTable = CrearLogDataSource()
        FirstID = TratarElementoCreados(TipoDocumento, log, strMessage, MostrarPantallaLog, dtLog, params)
        TratarErrores(TipoDocumento, log, strMessage, MostrarPantallaLog, dtLog)

        If MostrarPantallaLog Then
            '//Mostramos pantalla log (para procesos masivos)
            Dim frmLog As New LogProcesos
            frmLog.DataSource = dtLog
            frmLog.ShowDialog()
            strMessage = String.Empty
        End If

        If Not StockLog Is Nothing AndAlso StockLog.Length > 0 Then
            Dim frm As New DetalleActualizacionStock
            frm.DataSource = StockLog
            frm.ShowDialog()
            'strMessage = String.Empty
        End If

        If AbrirMnto AndAlso Length(FirstID) > 0 Then
            AbrirTipoDocumento(TipoDocumento, FirstID, strMessage, params)
        ElseIf Len(strMessage) > 0 Then
            ExpertisApp.GenerateMessage(strMessage, MessageBoxButtons.OK, MessageBoxIcon.Information, params)
        End If
    End Sub

    Public Sub TratarLog(ByVal log As AlbaranLogProcess, ByVal TipoDocumento As enumTipoDocumentoCreado, Optional ByVal MostrarPantallaLog As Boolean = False, Optional ByVal AbrirMnto As Boolean = False)
        If log Is Nothing Then
            ExpertisApp.GenerateMessage("Ha ocurrido un error al realizar el proceso. No se ha creado el log.")
            Exit Sub
        End If
        If TipoDocumento <> enumTipoDocumentoCreado.AlbaranCompra AndAlso TipoDocumento <> enumTipoDocumentoCreado.AlbaranVenta Then
            ExpertisApp.GenerateMessage("El Tipo de Documento debe ser Albarán Compra o Albarán Venta.")
        Else
            TratarLog(log.CreateData, TipoDocumento, MostrarPantallaLog, AbrirMnto, log.StockUpdateData)
        End If
    End Sub

    Public Function CrearLogDataSource() As DataTable
        Dim dt As New DataTable
        dt.Columns.Add("ElementsCreated", GetType(String))
        dt.Columns.Add("LocationError", GetType(String))
        dt.Columns.Add("Message", GetType(String))
        Return dt
    End Function

    Private Function TratarElementoCreados(ByVal TipoDocumento As enumTipoDocumentoCreado, ByVal log As LogProcess, ByRef strMessage As String, ByVal MostrarPantallaLog As Boolean, ByVal dtLog As DataTable, ByRef params() As Object) As Object
        If Not log Is Nothing AndAlso log.CreatedElements.Length > 0 Then
            Dim Ns(-1) As String
            Dim FirstID As String = String.Empty
            For Each Element As CreateElement In log.CreatedElements
                ReDim Preserve Ns(UBound(Ns) + 1)
                Ns(UBound(Ns)) = Element.NElement
                If Length(FirstID) = 0 Then
                    If Element.IDElement > 0 Then
                        FirstID = Element.IDElement
                    ElseIf Element.IDElement = 0 AndAlso Length(Element.NElement) > 0 Then
                        '//Para elementos cuyo ID es String. (P.Ej: OfertaCompra)
                        FirstID = Element.NElement
                    End If
                End If
            Next

            Dim strElemento As String = String.Empty
            Dim strElementos As String = String.Empty
            Dim OmitirMensajeInicial As Boolean = False
            Select Case TipoDocumento
                Case enumTipoDocumentoCreado.PedidoCompra, enumTipoDocumentoCreado.PedidoVenta
                    strElemento = ExpertisApp.Traslate("el Pedido") : strElementos = ExpertisApp.Traslate("los Pedidos")
                Case enumTipoDocumentoCreado.AlbaranCompra, enumTipoDocumentoCreado.AlbaranVenta, enumTipoDocumentoCreado.AlbaranVentaAlquiler
                    strElemento = ExpertisApp.Traslate("el Albarán") : strElementos = ExpertisApp.Traslate("los Albaranes")
                Case enumTipoDocumentoCreado.FacturaCompra, enumTipoDocumentoCreado.FacturaVenta
                    strElemento = ExpertisApp.Traslate("la Factura") : strElementos = ExpertisApp.Traslate("las Facturas")
                Case enumTipoDocumentoCreado.OrdenFabricacion
                    strElemento = ExpertisApp.Traslate("la Orden de Fabricación") : strElementos = ExpertisApp.Traslate("las Ordenes de Fabricación")
                Case enumTipoDocumentoCreado.Articulo
                    strElemento = ExpertisApp.Traslate("el Artículo") : strElementos = ExpertisApp.Traslate("los Artículos")
                Case -1
                    OmitirMensajeInicial = True
            End Select

            If Not MostrarPantallaLog Then
                If Not OmitirMensajeInicial Then
                    If log.CreatedElements.Length = 1 Then
                        strMessage = ExpertisApp.Traslate("Se ha generado") & " " & strElemento & " {0}."
                    Else
                        strMessage = ExpertisApp.Traslate("Se han generado") & " " & strElementos & " {0}."
                    End If
                Else
                    strMessage = "{0}"
                End If
            Else
                If Not OmitirMensajeInicial Then
                    'If log.CreatedElements.Length = 1 Then
                    strMessage = ExpertisApp.Traslate("Se ha generado") & " " & strElemento & ": {0}"
                    'Else
                    '    strMessage = ExpertisApp.Traslate("Se han generado") & " " & strElementos & ": {0}"
                    'End If
                Else
                    strMessage = "{0}"
                End If
                If Ns.Length > 0 Then
                    If dtLog Is Nothing Then Return FirstID

                    For Each N As String In Ns
                        Dim dr As DataRow = dtLog.NewRow
                        dr("ElementsCreated") = ExpertisApp.Traslate(strMessage, N) 'Strings.Join(Ns, cnFieldSeparator))
                        dtLog.Rows.Add(dr)
                    Next
                End If

            End If

            ReDim Preserve params(UBound(params) + 1)
            params(UBound(params)) = Strings.Join(Ns, cnFieldSeparator)

            Return FirstID
        End If
        Return String.Empty
    End Function

    Private Sub TratarErrores(ByVal TipoDocumento As enumTipoDocumentoCreado, ByVal log As LogProcess, ByRef strMessage As String, ByVal MostrarPantallaLog As Boolean, ByVal dtLog As DataTable)
        If Not log Is Nothing AndAlso log.Errors.Length > 0 Then
            Dim strElemento As String = String.Empty
            Select Case TipoDocumento
                Case enumTipoDocumentoCreado.PedidoCompra, enumTipoDocumentoCreado.PedidoVenta
                    strElemento = ExpertisApp.Traslate("Pedido")
                Case enumTipoDocumentoCreado.AlbaranCompra, enumTipoDocumentoCreado.AlbaranVenta, enumTipoDocumentoCreado.AlbaranVentaAlquiler
                    strElemento = ExpertisApp.Traslate("Albarán")
                Case enumTipoDocumentoCreado.FacturaCompra, enumTipoDocumentoCreado.FacturaVenta
                    strElemento = ExpertisApp.Traslate("Factura")
                Case enumTipoDocumentoCreado.OrdenFabricacion
                    strElemento = ExpertisApp.Traslate("Orden Fabricación")
                Case enumTipoDocumentoCreado.Articulo
                    strElemento = ExpertisApp.Traslate("Artículo")
            End Select
            If Not MostrarPantallaLog Then
                If Length(strMessage) > 0 Then strMessage = strMessage & vbCrLf
                If Length(log.Errors(0).Elements) > 0 Then strMessage = strMessage & ExpertisApp.Traslate("No se ha podido generar el " & strElemento & " del " & log.Errors(0).Elements & "." & vbCrLf)
                strMessage = ExpertisApp.Traslate(strMessage & ExpertisApp.Traslate("Se produjo el siguiente error: " & vbCrLf) & log.Errors(0).MessageError)
            Else
                If dtLog Is Nothing Then Exit Sub
                For Each Err As ClassErrors In log.Errors
                    Dim dr As DataRow = dtLog.NewRow
                    dr("ElementsCreated") = ExpertisApp.Traslate("Ha ocurrido un error en el proceso.")
                    dr("LocationError") = Err.Elements
                    dr("Message") = ExpertisApp.Traslate(Err.MessageError)
                    dtLog.Rows.Add(dr)
                Next
            End If
        End If
    End Sub

    Public Sub AbrirTipoDocumento(ByVal TipoDocumento As enumTipoDocumentoCreado, ByVal ID As Object, ByVal strMessage As String, ByVal param() As Object)
        Dim strQuestion As String = String.Empty
        If Len(strMessage) > 0 Then strQuestion = strMessage & vbCrLf
        Dim strAliasMnto As String = String.Empty
        Dim PrimaryKeyField As String = String.Empty
        Select Case TipoDocumento
            Case enumTipoDocumentoCreado.PedidoCompra
                strQuestion += ExpertisApp.Traslate("¿Desea abrir el primer Pedido generado?.")
                strAliasMnto = "MPEDC"
                PrimaryKeyField = "IDPedido"
            Case enumTipoDocumentoCreado.PedidoVenta
                strQuestion += ExpertisApp.Traslate("¿Desea abrir el primer Pedido generado?.")
                strAliasMnto = "MPED"
                PrimaryKeyField = "IDPedido"
            Case enumTipoDocumentoCreado.AlbaranCompra
                strQuestion += ExpertisApp.Traslate("¿Desea abrir el primer Albarán generado?.")
                strAliasMnto = "MALBC"
                PrimaryKeyField = "IDAlbaran"
            Case enumTipoDocumentoCreado.AlbaranVenta, enumTipoDocumentoCreado.AlbaranVentaAlquiler
                strQuestion += ExpertisApp.Traslate("¿Desea abrir el primer Albarán generado?.")
                strAliasMnto = "MALB"
                If TipoDocumento = enumTipoDocumentoCreado.AlbaranVentaAlquiler Then strAliasMnto = "MALBALQ"
                PrimaryKeyField = "IDAlbaran"
            Case enumTipoDocumentoCreado.FacturaCompra
                strQuestion += ExpertisApp.Traslate("¿Desea abrir la primera Factura generada?.")
                strAliasMnto = "MFACC"
                PrimaryKeyField = "IDFactura"
            Case enumTipoDocumentoCreado.FacturaCompraPiso
                strQuestion += ExpertisApp.Traslate("¿Desea abrir la ultima Factura de Compra generada?.")
                strAliasMnto = "MFACC"
                PrimaryKeyField = "IDFactura"
            Case enumTipoDocumentoCreado.FacturaVenta
                strQuestion += ExpertisApp.Traslate("¿Desea abrir la primera Factura generada?.")
                strAliasMnto = "MFACTV"
                PrimaryKeyField = "IDFactura"
            Case enumTipoDocumentoCreado.OrdenFabricacion
                strQuestion += ExpertisApp.Traslate("¿Desea abrir la primera orden de fabricación generada?.")
                strAliasMnto = "MORDFABR"
                PrimaryKeyField = "IDOrden"
            Case enumTipoDocumentoCreado.OfertaCompra
                strQuestion += ExpertisApp.Traslate("¿Desea abrir la primera Oferta generada?.")
                strAliasMnto = "MNTOOFCOMP"
                PrimaryKeyField = "IDOferta"
            Case enumTipoDocumentoCreado.SolicitudCompra
                strQuestion += ExpertisApp.Traslate("¿Desea abrir la primera Solicitud generada?.")
                strAliasMnto = "MntoSolici"
                PrimaryKeyField = "IDSolicitud"
            Case enumTipoDocumentoCreado.Articulo
                strQuestion += ExpertisApp.Traslate("¿Desea abrir el primer Artículo generado?.")
                strAliasMnto = "MARTICULO"
                PrimaryKeyField = "IDArticulo"
        End Select
        If ExpertisApp.GenerateMessage(ExpertisApp.Traslate(strQuestion), MessageBoxButtons.YesNo, MessageBoxIcon.Question, param) = DialogResult.Yes Then
            If ExpertisApp.IsFormOpen(strAliasMnto) Then ExpertisApp.CloseForm(strAliasMnto)
            ExpertisApp.OpenForm(strAliasMnto, New FilterItem(PrimaryKeyField, FilterOperator.Equal, ID))
        End If
    End Sub

#End Region

    '#Region "Envio de Correos"

    '    Public Function SendMail(ByVal data As MailOptionsInfo) As LogProcess
    '        Dim Log As New LogProcess
    '        Dim IntPosCreate As Integer = 0
    '        Dim IntPosError As Integer = 0

    '        If data.SmtpServerConfig Is Nothing Then
    '            data.SmtpServerConfig = ExpertisApp.ExecuteTask(Of Object, SmtpServerInfo)(AddressOf Correos.LoadSmtpServerInfo, New Object)
    '        End If

    '        Dim ServerMail As New Mail.SmtpClient
    '        ServerMail.Host = data.SmtpServerConfig.SmtpServerName
    '        ServerMail.Port = data.SmtpServerConfig.SmtpServerPort
    '        ServerMail.EnableSsl = data.SmtpServerConfig.UseSSL

    '        Dim CredUser As New NetworkCredential
    '        CredUser.UserName = data.SmtpServerConfig.UserID
    '        CredUser.Password = data.SmtpServerConfig.UserPassword

    '        ServerMail.Credentials = CredUser

    '        For Each MailUser As EmailInfo In data.Mails
    '            Dim NewMail As New Net.Mail.MailMessage(data.SmtpServerConfig.UserMail, MailUser.Email)
    '            If Length(MailUser.FicheroMensaje) > 0 Then
    '                TratarBodyMailHtml(NewMail, MailUser)
    '            Else : NewMail.Body = MailUser.Mensaje
    '            End If
    '            NewMail.Subject = MailUser.Asunto
    '            If Length(MailUser.FicheroAdjunto) > 0 Then NewMail.Attachments.Add(New Net.Mail.Attachment(MailUser.FicheroAdjunto))
    '            Try
    '                NewMail.BodyEncoding = System.Text.Encoding.Default
    '                ServerMail.Send(NewMail)
    '                ReDim Preserve Log.CreatedElements(IntPosCreate)
    '                Log.CreatedElements(IntPosCreate) = New CreateElement
    '                Log.CreatedElements(IntPosCreate).NElement = MailUser.Email
    '                Log.CreatedElements(IntPosCreate).ExtraInfo = MailUser.FicheroAdjunto
    '                IntPosCreate += 1
    '            Catch ex As System.Net.Mail.SmtpException
    '                ReDim Preserve Log.Errors(IntPosError)
    '                Log.Errors(IntPosError) = New ClassErrors
    '                Log.Errors(IntPosError).Elements = MailUser.Email
    '                If Not ex.InnerException Is Nothing Then
    '                    Log.Errors(IntPosError).MessageError = ex.InnerException.Message
    '                Else : Log.Errors(IntPosError).MessageError = ex.Message
    '                End If
    '                IntPosError += 1
    '            End Try
    '            NewMail.Dispose()
    '        Next
    '        Return Log
    '    End Function

    '    Private Sub TratarBodyMailHtml(ByRef NewMail As Net.Mail.MailMessage, ByVal MailInfo As EmailInfo)
    '        NewMail.IsBodyHtml = True
    '        Dim fichero As New System.IO.StreamReader(MailInfo.FicheroMensaje, System.Text.Encoding.Default, True)
    '        Dim Line As String
    '        Dim StrMensaje As String = String.Empty
    '        Do
    '            Line = fichero.ReadLine()
    '            If Not Line Is Nothing Then TratarCaracteresLinea(Line)
    '            StrMensaje = StrMensaje & Line & vbNewLine
    '        Loop Until Line Is Nothing
    '        fichero.Close()
    '        NewMail.Body = StrMensaje
    '    End Sub

    '    Private Sub TratarCaracteresLinea(ByRef StrLinea As String)
    '        If StrLinea.Contains("Á") Then StrLinea = StrLinea.Replace("Á", "&Aacute;")
    '        If StrLinea.Contains("á") Then StrLinea = StrLinea.Replace("á", "&aacute;")
    '        If StrLinea.Contains("É") Then StrLinea = StrLinea.Replace("É", "&Eacute;")
    '        If StrLinea.Contains("é") Then StrLinea = StrLinea.Replace("é", "&eacute;")
    '        If StrLinea.Contains("Í") Then StrLinea = StrLinea.Replace("Í", "&Iacute;")
    '        If StrLinea.Contains("í") Then StrLinea = StrLinea.Replace("í", "&iacute;")
    '        If StrLinea.Contains("Ó") Then StrLinea = StrLinea.Replace("Ó", "&Oacute;")
    '        If StrLinea.Contains("ó") Then StrLinea = StrLinea.Replace("ó", "&oacute;")
    '        If StrLinea.Contains("Ñ") Then StrLinea = StrLinea.Replace("Ñ", "&Ntilde;")
    '        If StrLinea.Contains("ñ") Then StrLinea = StrLinea.Replace("ñ", "&ntilde;")
    '        If StrLinea.Contains("Ú") Then StrLinea = StrLinea.Replace("Ú", "&Uacute;")
    '        If StrLinea.Contains("ú") Then StrLinea = StrLinea.Replace("ú", "&uacute;")
    '        If StrLinea.Contains("Ü") Then StrLinea = StrLinea.Replace("Ü", "&Uuml;")
    '        If StrLinea.Contains("ü") Then StrLinea = StrLinea.Replace("ü", "&uuml;")
    '        If StrLinea.Contains("¡") Then StrLinea = StrLinea.Replace("¡", "&iexcl;")
    '        If StrLinea.Contains("ª") Then StrLinea = StrLinea.Replace("ª", "&ordf;")
    '        If StrLinea.Contains("¿") Then StrLinea = StrLinea.Replace("¿", "&iquest;")
    '        If StrLinea.Contains("º") Then StrLinea = StrLinea.Replace("º", "&ordm;")
    '    End Sub

    '    Public Function SendTestMail(ByVal data As SmtpServerInfo) As LogProcess
    '        Dim MailTest As New MailOptionsInfo
    '        MailTest.SmtpServerConfig = data
    '        ReDim MailTest.Mails(0)
    '        MailTest.Mails(0) = New EmailInfo
    '        MailTest.Mails(0).Asunto = "Mail de Envio de Prueba Expertis"
    '        MailTest.Mails(0).Mensaje = "Prueba de Envio de configuración de datos de servidor smtp de Expertis"
    '        MailTest.Mails(0).Email = data.UserMail
    '        Return SendMail(MailTest)
    '    End Function

    '#End Region

    '#Region "Tratamiento de Log de Mails"

    '    Public Sub TratarMailLog(ByVal LogPrc As LogProcess)
    '        Dim DtLog As DataTable = CrearLogDataSource()
    '        'Mensaje de Exito
    '        For Each Elm As CreateElement In LogPrc.CreatedElements
    '            Dim DrNew As DataRow = DtLog.NewRow
    '            DrNew("ElementsCreated") = "Correo enviado a: " & Elm.NElement
    '            DtLog.Rows.Add(DrNew)
    '        Next
    '        'Mensajes de Error
    '        For Each Err As ClassErrors In LogPrc.Errors
    '            Dim DrNewEr As DataRow = DtLog.NewRow
    '            DrNewEr("ElementsCreated") = "Fallo de envío en la dirección: " & Err.Elements
    '            DrNewEr("LocationError") = Err.Elements
    '            DrNewEr("Message") = Err.MessageError
    '            DtLog.Rows.Add(DrNewEr)
    '        Next
    '        Dim FrmLog As New LogProcesos
    '        FrmLog.DataSource = DtLog
    '        FrmLog.ShowDialog()
    '    End Sub

    '#End Region

    '#Region "Tratamiento de Log de Firmas de PDF"

    '    Public Sub TratarFirmasLog(ByVal LogPrc As LogProcess)
    '        Dim DtLog As DataTable = CrearLogDataSource()
    '        'Mensaje de Exito
    '        If Not LogPrc.CreatedElements Is Nothing Then
    '            For Each Elm As CreateElement In LogPrc.CreatedElements
    '                Dim DrNew As DataRow = DtLog.NewRow
    '                DrNew("ElementsCreated") = "Fichero Firmado Correctamente: " & Elm.NElement
    '                DtLog.Rows.Add(DrNew)
    '            Next
    '        End If
    '        'Mensajes de Error
    '        If Not LogPrc.Errors Is Nothing Then
    '            For Each Err As ClassErrors In LogPrc.Errors
    '                Dim DrNewEr As DataRow = DtLog.NewRow
    '                DrNewEr("ElementsCreated") = "Fallo de Firma de fichero: " & Err.Elements
    '                DrNewEr("LocationError") = Err.Elements
    '                DrNewEr("Message") = Err.MessageError
    '                DtLog.Rows.Add(DrNewEr)
    '            Next
    '        End If
    '        Dim FrmLog As New LogProcesos
    '        FrmLog.DataSource = DtLog
    '        FrmLog.ShowDialog()
    '    End Sub

    '#End Region

    '#Region "Tratamiento de Log de Facturas PDF Electronicas"

    '    Public Sub TratarGenerarFacturasElecLog(ByVal LogPrc As LogProcess)
    '        Dim DtLog As DataTable = CrearLogDataSource()
    '        'Mensaje de Exito
    '        For Each Elm As CreateElement In LogPrc.CreatedElements
    '            Dim DrNew As DataRow = DtLog.NewRow
    '            DrNew("ElementsCreated") = "Fichero Pdf de factura: " & Elm.NElement & ", creado correctamente."
    '            DtLog.Rows.Add(DrNew)
    '        Next
    '        'Mensajes de Error
    '        For Each Err As ClassErrors In LogPrc.Errors
    '            Dim DrNewEr As DataRow = DtLog.NewRow
    '            DrNewEr("ElementsCreated") = "Fallo en el proceso de generación del fichero pdf de la factura: " & Err.Elements
    '            DrNewEr("LocationError") = Err.Elements
    '            DrNewEr("Message") = Err.MessageError
    '            DtLog.Rows.Add(DrNewEr)
    '        Next
    '        Dim FrmLog As New LogProcesos
    '        FrmLog.DataSource = DtLog
    '        FrmLog.ShowDialog()
    '    End Sub

    '#End Region

    '#Region "Tratamiento de Log de Facturas XML Electronicas"

    '    Public Sub TratarGenerarClientesFacturaElecLog(ByVal LogPrc As LogProcess)
    '        Dim DtLog As DataTable = CrearLogDataSource()
    '        'Mensaje de Exito
    '        For Each Elm As CreateElement In LogPrc.CreatedElements
    '            Dim DrNew As DataRow = DtLog.NewRow
    '            DrNew("ElementsCreated") = "Fichero XML de Factura/s Cliente: " & Elm.NElement & ", creado correctamente."
    '            DtLog.Rows.Add(DrNew)
    '        Next
    '        'Mensajes de Error
    '        For Each Err As ClassErrors In LogPrc.Errors
    '            Dim DrNewEr As DataRow = DtLog.NewRow
    '            DrNewEr("ElementsCreated") = "Fallo en el proceso de generación del fichero xml de factura/s de Cliente: " & Err.Elements
    '            DrNewEr("LocationError") = Err.Elements
    '            DrNewEr("Message") = Err.MessageError
    '            DtLog.Rows.Add(DrNewEr)
    '        Next
    '        Dim FrmLog As New LogProcesos
    '        FrmLog.DataSource = DtLog
    '        FrmLog.ShowDialog()
    '    End Sub

    '#End Region

    '#Region "Generación y firma de facturas electronicas"

    '    Public Sub GenerarFirmarEnviarFacturaPDF(ByVal DtDatos As DataTable, ByVal StrCampoPrimaryKey As String, ByVal StrCampoMail As String, ByVal StrCampoFactura As String, ByVal StrCampoFacturaElec As String)
    '        Dim StrDir As String = New Parametro().DirectorioFactElec
    '        Dim Formato_Fecha As String = "ddMMyyyy"
    '        Dim StrFecha As String = Format(Today, Formato_Fecha)
    '        If Not Strings.Right(StrDir, 1) = "\" Then StrDir &= "\"
    '        Dim StrDirPend As String = StrDir & "Pendientes\" & Today.Year() & "\"
    '        Dim StrDirEnv As String = StrDir & "Enviados\" & Today.Year() & "\"

    '        Dim Log As New LogProcess
    '        Dim IntPosCreate As Integer = 0
    '        Dim IntPosError As Integer = 0

    '        If Not IO.Directory.Exists(StrDirPend) Then IO.Directory.CreateDirectory(StrDirPend)
    '        Dim InfFirma As New SignatureInfo
    '        Dim Dr As DataRow = DtDatos.Rows(0)
    '        If Dr(StrCampoFacturaElec) Then
    '            If Length(Dr(StrCampoMail)) > 0 Then
    '                'Mete control de Fechas
    '                'mirar el año que coincida con el año actual
    '                If Not IO.File.Exists(StrDirPend & StrFecha & "_" & Dr(StrCampoFactura) & ".pdf") AndAlso Not IO.File.Exists(StrDirPend & StrFecha & "_" & Dr(StrCampoFactura) & ".S.pdf") Then
    '                    Dim RptFacts As New Report("IFVELEC")
    '                    Dim FilRpt As New Filter
    '                    FilRpt.Add("IDFactura", FilterOperator.Equal, Dr(StrCampoPrimaryKey))
    '                    RptFacts.Filter.Add(FilRpt)
    '                    RptFacts.ExportOptions.ExportType = ReportExportDestinationType.DiskFile
    '                    RptFacts.ExportOptions.FormatType = ReportExportFormatType.PDF
    '                    RptFacts.ExportOptions.ExportToDiskFile.DiskFileName = StrDirPend & StrFecha & "_" & Dr(StrCampoFactura)
    '                    Try
    '                        'Creamos Fichero pdf en sí y creamos el fichero direc asociado con la dirección de correo electrónico.
    '                        If Not IO.File.Exists(RptFacts.ExportOptions.ExportToDiskFile.DiskFileName & ".S.pdf") Then ExpertisApp.OpenReport(RptFacts)
    '                        If Not IO.File.Exists(StrDirPend & "\" & Dr(StrCampoFactura) & "_" & Dr(StrCampoMail) & ".direc") Then
    '                            Dim aa As IO.FileStream = IO.File.Create(StrDirPend & "\" & Dr(StrCampoFactura) & "_" & Dr(StrCampoMail) & ".direc")
    '                            IO.File.SetAttributes(StrDirPend & "\" & Dr(StrCampoFactura) & "_" & Dr(StrCampoMail) & ".direc", IO.FileAttributes.Hidden)
    '                            aa.Close()
    '                        End If
    '                        ''Firmamos el fichero pdf.
    '                        Dim StrNomFichero As String = RptFacts.ExportOptions.ExportToDiskFile.DiskFileName & ".pdf"
    '                        If Not IO.File.Exists(RptFacts.ExportOptions.ExportToDiskFile.DiskFileName & ".S.pdf") Then
    '                            InfFirma.FicheroFirmarOrigen = RptFacts.ExportOptions.ExportToDiskFile.DiskFileName & ".pdf"
    '                            InfFirma.FicheroFirmarDestino = RptFacts.ExportOptions.ExportToDiskFile.DiskFileName & ".S.pdf"
    '                            Dim StrResul As String = FirmarPDF(InfFirma)
    '                            If Length(StrResul) > 0 Then
    '                                ReDim Preserve Log.Errors(IntPosError)
    '                                Log.Errors(IntPosError) = New ClassErrors
    '                                Log.Errors(IntPosError).Elements = Dr(StrCampoFactura)
    '                                Log.Errors(IntPosError).MessageError = "El fichero de la factura: " & Dr(StrCampoFactura) & ".Error: " & StrResul
    '                                IntPosError += 1
    '                            Else
    '                                IO.File.Delete(InfFirma.FicheroFirmarOrigen)
    '                                StrNomFichero = InfFirma.FicheroFirmarDestino

    '                                'Damos de alta el nuevo documento en la gestión documental
    '                                If Not AltaGDFactura(Dr(StrCampoPrimaryKey), "Factura Electrónica: " & Dr(StrCampoFactura), StrNomFichero) Then
    '                                    ReDim Preserve Log.Errors(IntPosError)
    '                                    Log.Errors(IntPosError) = New ClassErrors
    '                                    Log.Errors(IntPosError).Elements = Dr(StrCampoFactura)
    '                                    Log.Errors(IntPosError).MessageError = "No se ha podido dar de alta en la Gestión documental el documento de la factura: " & Dr(StrCampoFactura)
    '                                    IntPosError += 1
    '                                Else
    '                                    If ExpertisApp.GenerateMessage("¿Desea enviar la factura por correo electrónico?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
    '                                        Dim FrmMail As New frmSendMail
    '                                        FrmMail.Asunto = "Factura Electrónica: "
    '                                        FrmMail.VerAdjunto = False
    '                                        FrmMail.MensajeConObservacion = "FacturaVentaCabecera"
    '                                        FrmMail.VerPara = True : FrmMail.Para = Dr(StrCampoMail)
    '                                        If FrmMail.ShowDialog() = Windows.Forms.DialogResult.OK Then
    '                                            Dim Data As New MailOptionsInfo
    '                                            Data.SmtpServerConfig = ExpertisApp.ExecuteTask(Of Object, SmtpServerInfo)(AddressOf Business.General.Correos.LoadSmtpServerInfo, New Object)
    '                                            Dim FrmPass As New FrmPassword
    '                                            FrmPass.DatosInfo = Data.SmtpServerConfig
    '                                            FrmPass.Text = "Introduzca Usuario y Contraseña de la cuenta de correo"
    '                                            If FrmPass.ShowDialog = DialogResult.OK Then
    '                                                'Preparamos la información de correos para enviar
    '                                                Data.SmtpServerConfig = FrmPass.DatosInfo
    '                                                Dim IntPosMail As Integer = 0
    '                                                ReDim Preserve Data.Mails(IntPosMail)
    '                                                Data.Mails(IntPosMail) = New EmailInfo
    '                                                Data.Mails(IntPosMail).Email = Dr(StrCampoMail)
    '                                                Data.Mails(IntPosMail).Asunto = FrmMail.Asunto & Dr(StrCampoFactura)
    '                                                Data.Mails(IntPosMail).Mensaje = FrmMail.Mensaje & Dr(StrCampoFactura)
    '                                                Data.Mails(IntPosMail).FicheroAdjunto = StrNomFichero
    '                                                Data.Mails(IntPosMail).FicheroMensaje = FrmMail.FicheroMensaje
    '                                                IntPosMail += 1

    '                                                'hacemos el envio de los ficheros
    '                                                Dim LogPrc As LogProcess = SendMail(Data)
    '                                                'Borramos los ficheros correctos del origen de pendientes
    '                                                TareasPendientesEnvioCorreoPDF(LogPrc, StrDir)

    '                                                TratarMailLog(LogPrc)
    '                                                Exit Sub
    '                                            End If
    '                                        End If
    '                                    End If
    '                                    ReDim Preserve Log.CreatedElements(IntPosCreate)
    '                                    Log.CreatedElements(IntPosCreate) = New CreateElement
    '                                    Log.CreatedElements(IntPosCreate).NElement = Dr(StrCampoFactura)
    '                                    IntPosCreate += 1
    '                                End If
    '                            End If
    '                        End If
    '                    Catch ex As Exception
    '                        ReDim Preserve Log.Errors(IntPosError)
    '                        Log.Errors(IntPosError) = New ClassErrors
    '                        Log.Errors(IntPosError).Elements = Dr(StrCampoFactura)
    '                        Log.Errors(IntPosError).MessageError = ex.Message
    '                        IntPosError += 1
    '                    End Try
    '                Else
    '                    ReDim Preserve Log.Errors(IntPosError)
    '                    Log.Errors(IntPosError) = New ClassErrors
    '                    Log.Errors(IntPosError).Elements = Dr(StrCampoFactura)
    '                    Log.Errors(IntPosError).MessageError = "El Fichero de la factura:" & Dr(StrCampoFactura) & " ya existe en el directorio de pendientes."
    '                    IntPosError += 1
    '                End If
    '            Else
    '                ReDim Preserve Log.Errors(IntPosError)
    '                Log.Errors(IntPosError) = New ClassErrors
    '                Log.Errors(IntPosError).Elements = Dr(StrCampoFactura)
    '                Log.Errors(IntPosError).MessageError = "Cliente: " & Dr("IDCliente") & " sin especificar su correo electrónico."
    '                IntPosError += 1
    '            End If
    '        Else
    '            ReDim Preserve Log.Errors(IntPosError)
    '            Log.Errors(IntPosError) = New ClassErrors
    '            Log.Errors(IntPosError).Elements = Dr(StrCampoFactura)
    '            Log.Errors(IntPosError).MessageError = "Cliente: " & Dr("IDCliente") & " sin marca de factura electrónica en: Ficheros PDF o en Ambos."
    '            IntPosError += 1
    '        End If
    '        TratarGenerarFacturasElecLog(Log)
    '    End Sub

    '    Public Sub GenerarFirmarEnviarFacturaXML(ByVal DtDatos As DataTable, ByVal StrCampoPrimaryKey As String, ByVal StrCampoMail As String, ByVal StrCampoFactura As String, ByVal StrCampoFacturaElec As String)
    '        Dim DtFich As DataTable = New FicherosModeloDetalle().Filter(New FilterItem("IDTipoFichero", FilterOperator.Equal, "FACTURAE"))
    '        Dim StrDir As String = DtFich.Rows(0)("RutaFichero")
    '        Dim StrFecha As String = CStr(IIf(Today.Date.Day.ToString.Length = 2, String.Empty, "0") & Today.Date.Day.ToString & IIf(Today.Date.Month.ToString.Length = 2, String.Empty, "0") & Today.Date.Month.ToString & Today.Date.Year)
    '        If Not Strings.Right(StrDir, 1) = "\" Then StrDir &= "\"
    '        Dim StrDirPend As String = StrDir & "Pendientes\" & Today.Year() & "\"

    '        Dim Log As New LogProcess
    '        Dim IntPosCreate As Integer = 0
    '        Dim IntPosError As Integer = 0

    '        If Not IO.Directory.Exists(StrDirPend) Then IO.Directory.CreateDirectory(StrDirPend)
    '        Dim ClsParam As New FicheroParametros
    '        Dim DtParamFich As DataTable = ClsParam.Filter
    '        DtParamFich.Rows(0)("ModalidadFacturae") = IIf(DtDatos.Rows.Count > 1, "L", "I")
    '        ClsParam.Update(DtParamFich)

    '        Dim FilFact As New Filter(FilterUnionOperator.Or)
    '        Dim FilSel As New Filter(FilterUnionOperator.Or)
    '        FilSel.Add(StrCampoFacturaElec, FilterOperator.Equal, CInt(enumPermisoFactElec.Ambos))
    '        FilSel.Add(StrCampoFacturaElec, FilterOperator.Equal, CInt(enumPermisoFactElec.SoloFacturaXML))
    '        Dim FilUnion As New Filter
    '        FilUnion.Add(FilSel)
    '        FilUnion.Add(New IsNullFilterItem(StrCampoMail, False))
    '        Dim DtFil As DataTable = DtDatos.Clone
    '        Dim DrSel() As DataRow = DtDatos.Select(FilUnion.Compose(New AdoFilterComposer))
    '        For Each Dr As DataRow In DrSel
    '            DtFil.Rows.Add(Dr.ItemArray)
    '            FilFact.Add("IDFactura", FilterOperator.Equal, Dr("IDFactura"))
    '        Next
    '        DtFil.AcceptChanges()
    '        If FilFact.Count > 0 AndAlso DtFil.Rows.Count > 0 Then
    '            If Not IO.File.Exists(StrDirPend & StrFecha & "_" & DtFil.Rows(0)(StrCampoFactura) & ".xml") AndAlso Not IO.File.Exists(StrDirPend & StrFecha & "_" & DtFil.Rows(0)(StrCampoFactura) & ".S.xml") Then
    '                Try
    '                    If Not IO.File.Exists(StrDirPend & StrFecha & "_" & DtDatos.Rows(0)(StrCampoFactura) & ".S.xml") Then
    '                        Dim StDatos As New FicherosModeloDetalle.EstFinalDataFile
    '                        StDatos.IDTipoFichero = "FACTURAE"
    '                        StDatos.TipoSalida = enumTipoSalidaFicheroDeclaracion.FicheroXML
    '                        StDatos.FiltroFacturae = FilFact
    '                        Dim StDatosFichero As FicherosModeloDetalle.EstDatosFichero = ExpertisApp.ExecuteTask(Of FicherosModeloDetalle.EstFinalDataFile, FicherosModeloDetalle.EstDatosFichero)(AddressOf FicherosModeloDetalle.GenerarFicheroModelo, StDatos)
    '                        StDatosFichero.StrRutaFichero = StrDirPend & StrFecha & "_" & DtFil.Rows(0)(StrCampoFactura) & ".xml"
    '                        CrearXML(StDatosFichero.StrRutaFichero, StDatosFichero.XmlDoc)
    '                        Dim TbParam As DataTable = New FicheroParametros().Filter()
    '                        Dim StrRead As New IO.StreamReader(StDatosFichero.StrRutaFichero)
    '                        Dim StrContenido As String = StrRead.ReadToEnd()
    '                        StrRead.Close()
    '                        StrContenido = StrContenido.Insert(19, " " & TbParam.Rows(0)("EncodingXML"))
    '                        Dim IntPos As Integer = StrContenido.IndexOf("<" & DtFich.Rows(0)("NombreCampo") & ">", 0)
    '                        IntPos += Len(DtFich.Rows(0)("NombreCampo")) + 1
    '                        StrContenido = StrContenido.Insert(IntPos, " " & DtFich.Rows(0)("Expresion"))
    '                        If StrContenido.Contains("<->") Then StrContenido = StrContenido.Replace("<->", "") : StrContenido = StrContenido.Replace("</->", "")
    '                        If StrContenido.Contains("Facturae") Then StrContenido = StrContenido.Replace("<Facturae ", "<fe:Facturae ") : StrContenido = StrContenido.Replace("</Facturae>", "</fe:Facturae>")
    '                        IO.File.Delete(StDatosFichero.StrRutaFichero)
    '                        Dim StrFile As IO.FileStream = IO.File.Create(StDatosFichero.StrRutaFichero)
    '                        StrFile.Close()
    '                        Dim FilXml As New IO.StreamWriter(StDatosFichero.StrRutaFichero)
    '                        FilXml.Write(StrContenido)
    '                        FilXml.Close()
    '                    End If
    '                    If Not IO.File.Exists(StrDirPend & DtFil.Rows(0)(StrCampoFactura) & "_" & DtFil.Rows(0)(StrCampoMail) & ".xml.direc") Then
    '                        Dim aa As IO.FileStream = IO.File.Create(StrDirPend & "\" & DtFil.Rows(0)(StrCampoFactura) & "_" & DtFil.Rows(0)(StrCampoMail) & ".xml.direc")
    '                        IO.File.SetAttributes(StrDirPend & DtFil.Rows(0)(StrCampoFactura) & "_" & DtFil.Rows(0)(StrCampoMail) & ".xml.direc", IO.FileAttributes.Hidden)
    '                        aa.Close()
    '                    End If
    '                    ''Firmamos el fichero xml.
    '                    Dim StrNomFichero As String = StrDirPend & StrFecha & "_" & DtFil.Rows(0)(StrCampoFactura) & ".xml"
    '                    If Not IO.File.Exists(StrDirPend & StrFecha & "_" & DtFil.Rows(0)(StrCampoFactura) & ".S.xml") Then
    '                        Dim StrResul As String = FirmarXmlFacturae(StrDirPend & "\" & StrFecha & "_" & DtFil.Rows(0)(StrCampoFactura) & ".xml")
    '                        If Length(StrResul) > 0 Then
    '                            ReDim Preserve Log.Errors(IntPosError)
    '                            Log.Errors(IntPosError) = New ClassErrors
    '                            Log.Errors(IntPosError).Elements = DtFil.Rows(0)(StrCampoFactura)
    '                            Log.Errors(IntPosError).MessageError = "El fichero de la factura: " & DtFil.Rows(0)(StrCampoFactura) & ".Error: " & StrResul
    '                            IntPosError += 1
    '                        Else
    '                            'Damos de alta el nuevo documento en la gestión documental
    '                            If Not AltaGDFactura(DtFil.Rows(0)(StrCampoPrimaryKey), "Factura Electrónica: " & DtFil.Rows(0)(StrCampoFactura), StrNomFichero) Then
    '                                ReDim Preserve Log.Errors(IntPosError)
    '                                Log.Errors(IntPosError) = New ClassErrors
    '                                Log.Errors(IntPosError).Elements = DtFil.Rows(0)(StrCampoFactura)
    '                                Log.Errors(IntPosError).MessageError = "No se ha podido dar de alta en la Gestión documental el documento de la factura: " & DtFil.Rows(0)(StrCampoFactura)
    '                                IntPosError += 1
    '                            Else
    '                                If ExpertisApp.GenerateMessage("¿Desea enviar la factura por correo electrónico?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
    '                                    Dim FrmMail As New frmSendMail
    '                                    FrmMail.Asunto = "Factura Electrónica: "
    '                                    FrmMail.VerFichero = False
    '                                    FrmMail.VerPara = True : FrmMail.Para = DtFil.Rows(0)(StrCampoMail)
    '                                    FrmMail.MensajeConObservacion = "FacturaVentaCabecera"
    '                                    If FrmMail.ShowDialog() = Windows.Forms.DialogResult.OK Then
    '                                        Dim Data As New MailOptionsInfo
    '                                        Data.SmtpServerConfig = ExpertisApp.ExecuteTask(Of Object, SmtpServerInfo)(AddressOf Business.General.Correos.LoadSmtpServerInfo, New Object)
    '                                        Dim FrmPass As New FrmPassword
    '                                        FrmPass.DatosInfo = Data.SmtpServerConfig
    '                                        FrmPass.Text = "Introduzca Usuario y Contraseña de la cuenta de correo"
    '                                        If FrmPass.ShowDialog = DialogResult.OK Then
    '                                            'Preparamos la información de correos para enviar
    '                                            Data.SmtpServerConfig = FrmPass.DatosInfo
    '                                            Dim IntPosMail As Integer = 0
    '                                            ReDim Preserve Data.Mails(IntPosMail)
    '                                            Data.Mails(IntPosMail) = New EmailInfo
    '                                            Data.Mails(IntPosMail).Email = DtFil.Rows(0)(StrCampoMail)
    '                                            Data.Mails(IntPosMail).Asunto = FrmMail.Asunto & DtFil.Rows(0)(StrCampoFactura)
    '                                            Data.Mails(IntPosMail).Mensaje = FrmMail.Mensaje & DtFil.Rows(0)(StrCampoFactura)
    '                                            Data.Mails(IntPosMail).FicheroAdjunto = StrNomFichero
    '                                            Data.Mails(IntPosMail).FicheroMensaje = FrmMail.FicheroMensaje
    '                                            IntPosMail += 1

    '                                            'hacemos el envio de los ficheros
    '                                            Dim LogPrc As LogProcess = SendMail(Data)
    '                                            'Borramos los ficheros correctos del origen de pendientes
    '                                            TareasPendientesEnvioCorreoXML(LogPrc, StrDir)

    '                                            TratarMailLog(LogPrc)
    '                                            Exit Sub
    '                                        End If
    '                                    End If
    '                                End If
    '                                ReDim Preserve Log.CreatedElements(IntPosCreate)
    '                                Log.CreatedElements(IntPosCreate) = New CreateElement
    '                                Log.CreatedElements(IntPosCreate).NElement = DtFil.Rows(0)(StrCampoFactura)
    '                                IntPosCreate += 1
    '                            End If
    '                        End If
    '                    End If
    '                Catch ex As Exception
    '                    ReDim Preserve Log.Errors(IntPosError)
    '                    Log.Errors(IntPosError) = New ClassErrors
    '                    Log.Errors(IntPosError).Elements = DtFil.Rows(0)(StrCampoFactura)
    '                    Log.Errors(IntPosError).MessageError = ex.Message
    '                    IntPosError += 1
    '                End Try
    '            Else
    '                ReDim Preserve Log.Errors(IntPosError)
    '                Log.Errors(IntPosError) = New ClassErrors
    '                Log.Errors(IntPosError).Elements = DtFil.Rows(0)(StrCampoFactura)
    '                Log.Errors(IntPosError).MessageError = "El Fichero de la factura:" & DtFil.Rows(0)(StrCampoFactura) & " ya existe en el directorio de pendientes."
    '                IntPosError += 1
    '            End If
    '        Else




    '        End If
    '        TratarGenerarClientesFacturaElecLog(Log)
    '    End Sub

    '    Private Sub TareasPendientesEnvioCorreoPDF(ByVal LogPrc As LogProcess, ByVal MStrDirFact As String)
    '        For Each Elm As CreateElement In LogPrc.CreatedElements
    '            If IO.File.Exists(Elm.ExtraInfo) Then
    '                'Movemos el fichero a pendientes y borramos el fichero .direc asociado para no dejar restos de información
    '                Dim StrDirEnv As String = Strings.Replace(Elm.ExtraInfo, "Pendientes", "Enviados")
    '                If Not IO.Directory.Exists(MStrDirFact & "Enviados\" & Today.Date.Year & "\") Then IO.Directory.CreateDirectory(MStrDirFact & "Enviados\" & Today.Date.Year & "\")
    '                IO.File.Move(Elm.ExtraInfo, StrDirEnv)
    '                Dim StrFactura As String = Elm.ExtraInfo.Substring(Elm.ExtraInfo.IndexOf("_") + 1, (Elm.ExtraInfo.LastIndexOf(".S.") - Elm.ExtraInfo.IndexOf("_")) - 1)
    '                IO.File.Delete(IO.Directory.GetFiles(Elm.ExtraInfo.Substring(0, Elm.ExtraInfo.LastIndexOf("\")), StrFactura & "*.direc")(0))
    '                'Modificamos los datos de la gestión documental
    '                Dim DtFact As DataTable = New FacturaVentaCabecera().Filter(New FilterItem("NFactura", FilterOperator.Equal, StrFactura), "FechaFactura DESC")
    '                If Not DtFact Is Nothing AndAlso DtFact.Rows.Count > 0 Then
    '                    ModificarGDFactura(DtFact.Rows(0)("IDFactura"), Elm.ExtraInfo)
    '                End If
    '                'Modificamos la cabecera de la factura para registrar el fichero en un campo y asi verificar que no volvamos a generar el mismo fichero otra vez.
    '                Dim DirecInfo As New FacturaVentaCabecera.DirectFactElecInfo
    '                DirecInfo.DtFact = DtFact
    '                DirecInfo.StrCampoDirec = "DirecFacturaPDF"
    '                DirecInfo.StrRuta = StrDirEnv
    '                ExpertisApp.ExecuteTask(Of FacturaVentaCabecera.DirectFactElecInfo)(AddressOf FacturaVentaCabecera.ActualizarDirecFactElec, DirecInfo)
    '            End If
    '        Next
    '    End Sub

    '    Private Sub TareasPendientesEnvioCorreoXML(ByVal LogPrc As LogProcess, ByVal MStrDirFact As String)
    '        For Each Elm As CreateElement In LogPrc.CreatedElements
    '            If IO.File.Exists(Elm.ExtraInfo) Then
    '                'Movemos el fichero a pendientes y borramos el fichero .direc asociado para no dejar restos de información
    '                Dim StrDirEnv As String = Strings.Replace(Elm.ExtraInfo, "Pendientes", "Enviados")
    '                If Not IO.Directory.Exists(MStrDirFact & "Enviados\" & Today.Year) Then IO.Directory.CreateDirectory(MStrDirFact & "Enviados\" & Today.Year)
    '                IO.File.Move(Elm.ExtraInfo, StrDirEnv)
    '                Dim StrFactura As String = Elm.ExtraInfo.Substring(Elm.ExtraInfo.IndexOf("_") + 1, (Elm.ExtraInfo.LastIndexOf(".S.") - Elm.ExtraInfo.IndexOf("_")) - 1)
    '                IO.File.Delete(IO.Directory.GetFiles(Elm.ExtraInfo.Substring(0, Elm.ExtraInfo.LastIndexOf("\")), StrFactura & "*.xml.direc")(0))
    '                'Modificamos los datos de la gestión documental
    '                Dim DtFact As DataTable = New FacturaVentaCabecera().Filter(New FilterItem("NFactura", FilterOperator.Equal, StrFactura), "FechaFactura DESC")
    '                If Not DtFact Is Nothing AndAlso DtFact.Rows.Count > 0 Then
    '                    ModificarGDFactura(DtFact.Rows(0)("IDFactura"), Elm.ExtraInfo)
    '                End If
    '                'Modificamos la cabecera de la factura para registrar el fichero en un campo y asi verificar que no volvamos a generar el mismo fichero otra vez.
    '                Dim DirecInfo As New FacturaVentaCabecera.DirectFactElecInfo
    '                DirecInfo.DtFact = DtFact
    '                DirecInfo.StrCampoDirec = "DirecFacturaXML"
    '                DirecInfo.StrRuta = StrDirEnv
    '                ExpertisApp.ExecuteTask(Of FacturaVentaCabecera.DirectFactElecInfo)(AddressOf FacturaVentaCabecera.ActualizarDirecFactElec, DirecInfo)
    '            End If
    '        Next
    '    End Sub

    '    Public Sub GenerarFirmarFacturasPDF(ByVal DtDatos As DataTable, ByVal StrCampoPrimaryKey As String, ByVal StrCampoMail As String, ByVal StrCampoFactura As String, ByVal StrCampoFacturaElec As String)
    '        Dim StrDir As String = New Parametro().DirectorioFactElec
    '        Dim StrFecha As String = CStr(IIf(Today.Date.Day.ToString.Length = 2, String.Empty, "0") & Today.Date.Day.ToString & IIf(Today.Date.Month.ToString.Length = 2, String.Empty, "0") & Today.Date.Month.ToString & Today.Date.Year)
    '        If Not Strings.Right(StrDir, 1) = "\" Then StrDir &= "\"
    '        StrDir &= "Pendientes\" & Today.Year() & "\"

    '        Dim Log As New LogProcess
    '        Dim IntPosCreate As Integer = 0
    '        Dim IntPosError As Integer = 0

    '        If Not IO.Directory.Exists(StrDir) Then IO.Directory.CreateDirectory(StrDir)
    '        Dim InfFirma As New SignatureInfo

    '        Dim StrCert As String = ExpertisApp.ExecuteTask(Of Object, String)(AddressOf FacturaElec.GetLastCerID, New Object)
    '        Dim store As New X509Store("MY", StoreLocation.CurrentUser)
    '        store.Open(OpenFlags.ReadOnly)
    '        Dim Selec As X509CertificateCollection
    '        If Length(StrCert) = 0 Then
    '            Selec = X509Certificates.X509Certificate2UI.SelectFromCollection(store.Certificates, "Certificados Instalados", "Seleccione un Certificado", X509SelectionFlag.SingleSelection)
    '        Else : Selec = store.Certificates.Find(X509FindType.FindBySerialNumber, StrCert, False)
    '        End If
    '        If Not Selec Is Nothing AndAlso Selec.Count > 0 Then
    '            Dim StrMsg As String = VerificarCertificado(Selec(0), False)
    '            If Length(StrMsg) = 0 Then
    '                If ExpertisApp.ExecuteTask(Of Object, Boolean)(AddressOf FacturaElec.GetUseLastCert, New Object) Then
    '                    Dim Cert As New X509Certificate2(Selec(0))
    '                    ExpertisApp.ExecuteTask(Of String)(AddressOf FacturaElec.SaveLastCerID, Cert.SerialNumber)
    '                End If
    '                For Each Dr As DataRow In DtDatos.Select("NOT EMail is NULL")
    '                    If Dr(StrCampoFacturaElec) Then
    '                        If Length(Dr(StrCampoMail)) > 0 Then
    '                            If Not IO.File.Exists(StrDir & StrFecha & "_" & Dr(StrCampoFactura) & ".pdf") AndAlso Not IO.File.Exists(StrDir & StrFecha & "_" & Dr(StrCampoFactura) & ".S.pdf") Then
    '                                Dim RptFacts As New Report("IFVELEC")
    '                                Dim FilRpt As New Filter
    '                                FilRpt.Add("IDFactura", FilterOperator.Equal, Dr(StrCampoPrimaryKey))
    '                                RptFacts.Filter.Add(FilRpt)
    '                                RptFacts.ExportOptions.ExportType = ReportExportDestinationType.DiskFile
    '                                RptFacts.ExportOptions.FormatType = ReportExportFormatType.PDF
    '                                RptFacts.ExportOptions.ExportToDiskFile.DiskFileName = StrDir & StrFecha & "_" & Dr(StrCampoFactura)
    '                                Try
    '                                    'Creamos Fichero pdf en sí y creamos el fichero direc asociado con la dirección de correo electrónico.
    '                                    If Not IO.File.Exists(RptFacts.ExportOptions.ExportToDiskFile.DiskFileName & ".S.pdf") Then ExpertisApp.OpenReport(RptFacts)
    '                                    If Not IO.File.Exists(StrDir & "\" & Dr(StrCampoFactura) & "_" & Dr(StrCampoMail) & ".direc") Then
    '                                        Dim FilePdfDirec As New IO.FileInfo(StrDir & "\" & Dr(StrCampoFactura) & "_" & Dr(StrCampoMail) & ".direc")
    '                                        FilePdfDirec.Create()
    '                                        FilePdfDirec.Attributes = IO.FileAttributes.Hidden
    '                                        FilePdfDirec.Refresh()
    '                                    End If
    '                                    ''Firmamos el fichero pdf.
    '                                    Dim StrNomFichero As String = RptFacts.ExportOptions.ExportToDiskFile.DiskFileName & ".pdf"
    '                                    If Not IO.File.Exists(RptFacts.ExportOptions.ExportToDiskFile.DiskFileName & ".S.pdf") Then
    '                                        InfFirma.FicheroFirmarOrigen = RptFacts.ExportOptions.ExportToDiskFile.DiskFileName & ".pdf"
    '                                        InfFirma.FicheroFirmarDestino = RptFacts.ExportOptions.ExportToDiskFile.DiskFileName & ".S.pdf"
    '                                        Dim StrResul As String = FirmarPDFs(InfFirma, Selec(0))
    '                                        If Length(StrResul) > 0 Then
    '                                            ReDim Preserve Log.Errors(IntPosError)
    '                                            Log.Errors(IntPosError) = New ClassErrors
    '                                            Log.Errors(IntPosError).Elements = Dr(StrCampoFactura)
    '                                            Log.Errors(IntPosError).MessageError = "El fichero de la factura: " & Dr(StrCampoFactura) & ".Error: " & StrResul
    '                                            IntPosError += 1
    '                                        Else
    '                                            IO.File.Delete(InfFirma.FicheroFirmarOrigen)
    '                                            StrNomFichero = InfFirma.FicheroFirmarDestino
    '                                            'Damos de alta el nuevo documento en la gestión documental
    '                                            If Not AltaGDFactura(Dr(StrCampoPrimaryKey), "Factura Electrónica: " & Dr(StrCampoFactura), StrNomFichero) Then
    '                                                ReDim Preserve Log.Errors(IntPosError)
    '                                                Log.Errors(IntPosError) = New ClassErrors
    '                                                Log.Errors(IntPosError).Elements = Dr(StrCampoFactura)
    '                                                Log.Errors(IntPosError).MessageError = "No se ha podido dar de alta en la Gestión documental el documento de la factura: " & Dr(StrCampoFactura)
    '                                                IntPosError += 1
    '                                            Else
    '                                                ReDim Preserve Log.CreatedElements(IntPosCreate)
    '                                                Log.CreatedElements(IntPosCreate) = New CreateElement
    '                                                Log.CreatedElements(IntPosCreate).NElement = Dr(StrCampoFactura)
    '                                                IntPosCreate += 1
    '                                            End If
    '                                        End If
    '                                    End If
    '                                Catch ex As Exception
    '                                    ReDim Preserve Log.Errors(IntPosError)
    '                                    Log.Errors(IntPosError) = New ClassErrors
    '                                    Log.Errors(IntPosError).Elements = Dr(StrCampoFactura)
    '                                    Log.Errors(IntPosError).MessageError = ex.Message
    '                                    IntPosError += 1
    '                                End Try
    '                            Else
    '                                ReDim Preserve Log.Errors(IntPosError)
    '                                Log.Errors(IntPosError) = New ClassErrors
    '                                Log.Errors(IntPosError).Elements = Dr(StrCampoFactura)
    '                                Log.Errors(IntPosError).MessageError = "El Fichero de la factura:" & Dr(StrCampoFactura) & " ya existe en el directorio de pendientes."
    '                                IntPosError += 1
    '                            End If
    '                        Else
    '                            ReDim Preserve Log.Errors(IntPosError)
    '                            Log.Errors(IntPosError) = New ClassErrors
    '                            Log.Errors(IntPosError).Elements = Dr(StrCampoFactura)
    '                            Log.Errors(IntPosError).MessageError = "Cliente: " & Dr("IDCliente") & " sin especificar su correo electrónico."
    '                            IntPosError += 1
    '                        End If
    '                    Else
    '                        ReDim Preserve Log.Errors(IntPosError)
    '                        Log.Errors(IntPosError) = New ClassErrors
    '                        Log.Errors(IntPosError).Elements = Dr(StrCampoFactura)
    '                        Log.Errors(IntPosError).MessageError = "Cliente: " & Dr("IDCliente") & " sin marca de factura electrónica en: Fichero PDF o Ambos."
    '                        IntPosError += 1
    '                    End If
    '                Next
    '            Else
    '                ReDim Preserve Log.Errors(IntPosError)
    '                Log.Errors(IntPosError) = New ClassErrors
    '                Log.Errors(IntPosError).Elements = "Firma Digital"
    '                Log.Errors(IntPosError).MessageError = StrMsg
    '                IntPosError += 1
    '            End If
    '        Else
    '            ReDim Preserve Log.Errors(IntPosError)
    '            Log.Errors(IntPosError) = New ClassErrors
    '            Log.Errors(IntPosError).Elements = "Firma Digital"
    '            Log.Errors(IntPosError).MessageError = "No se ha seleccionado una firma digital para el proceso."
    '            IntPosError += 1
    '        End If
    '            TratarGenerarFacturasElecLog(Log)
    '    End Sub

    '    Public Sub GenerarFirmarFacturaXML(ByVal DtDatos As DataTable, ByVal StrCampoPrimaryKey As String, ByVal StrCampoMail As String, ByVal StrCampoFactura As String, ByVal StrCampoFacturaElec As String)
    '        Dim DtFich As DataTable = New FicherosModeloDetalle().Filter(New FilterItem("IDTipoFichero", FilterOperator.Equal, "FACTURAE"))
    '        Dim StrDir As String = DtFich.Rows(0)("RutaFichero")
    '        Dim StrFecha As String = CStr(IIf(Today.Date.Day.ToString.Length = 2, String.Empty, "0") & Today.Date.Day.ToString & IIf(Today.Date.Month.ToString.Length = 2, String.Empty, "0") & Today.Date.Month.ToString & Today.Date.Year)
    '        If Not Strings.Right(StrDir, 1) = "\" Then StrDir &= "\"
    '        Dim StrDirPend As String = StrDir & "Pendientes\" & Today.Year & "\"

    '        Dim Log As New LogProcess
    '        Dim IntPosCreate As Integer = 0
    '        Dim IntPosError As Integer = 0

    '        If Not IO.Directory.Exists(StrDirPend) Then IO.Directory.CreateDirectory(StrDirPend)
    '        Dim ClsParam As New FicheroParametros
    '        Dim DtParamFich As DataTable = ClsParam.Filter
    '        DtParamFich.Rows(0)("ModalidadFacturae") = IIf(DtDatos.Rows.Count > 1, "L", "I")
    '        ClsParam.Update(DtParamFich)

    '        Dim FilFact As New Filter(FilterUnionOperator.Or)
    '        Dim FilSel As New Filter(FilterUnionOperator.Or)
    '        FilSel.Add(StrCampoFacturaElec, FilterOperator.Equal, CInt(enumPermisoFactElec.Ambos))
    '        FilSel.Add(StrCampoFacturaElec, FilterOperator.Equal, CInt(enumPermisoFactElec.SoloFacturaXML))
    '        Dim FilUnion As New Filter
    '        FilUnion.Add(FilSel)
    '        FilUnion.Add(New IsNullFilterItem(StrCampoMail, False))
    '        Dim DtFil As DataTable = DtDatos.Clone
    '        Dim DrSel() As DataRow = DtDatos.Select(FilUnion.Compose(New AdoFilterComposer))
    '        For Each Dr As DataRow In DrSel
    '            DtFil.Rows.Add(Dr.ItemArray)
    '            FilFact.Add("IDFactura", FilterOperator.Equal, Dr("IDFactura"))
    '        Next
    '        DtFil.AcceptChanges()
    '        If FilFact.Count > 0 AndAlso DtFil.Rows.Count > 0 Then
    '            If Not IO.File.Exists(StrDirPend & StrFecha & "_" & DtFil.Rows(0)(StrCampoFactura) & ".xml") AndAlso Not IO.File.Exists(StrDirPend & StrFecha & "_" & DtFil.Rows(0)(StrCampoFactura) & ".S.xml") Then
    '                Try
    '                    'Creamos Fichero pdf en sí y creamos el fichero direc asociado con la dirección de correo electrónico.
    '                    If Not IO.File.Exists(StrDirPend & StrFecha & "_" & DtDatos.Rows(0)(StrCampoFactura) & ".S.xml") Then
    '                        Dim StDatos As New FicherosModeloDetalle.EstFinalDataFile
    '                        StDatos.IDTipoFichero = "FACTURAE"
    '                        StDatos.TipoSalida = enumTipoSalidaFicheroDeclaracion.FicheroXML
    '                        StDatos.FiltroFacturae = FilFact
    '                        Dim StDatosFichero As FicherosModeloDetalle.EstDatosFichero = ExpertisApp.ExecuteTask(Of FicherosModeloDetalle.EstFinalDataFile, FicherosModeloDetalle.EstDatosFichero)(AddressOf FicherosModeloDetalle.GenerarFicheroModelo, StDatos)
    '                        StDatosFichero.StrRutaFichero = StrDirPend & StrFecha & "_" & DtFil.Rows(0)(StrCampoFactura) & ".xml"
    '                        CrearXML(StDatosFichero.StrRutaFichero, StDatosFichero.XmlDoc)

    '                        Dim TbParam As DataTable = New FicheroParametros().Filter()
    '                        Dim StrRead As New IO.StreamReader(StDatosFichero.StrRutaFichero)
    '                        Dim StrContenido As String = StrRead.ReadToEnd()
    '                        StrRead.Close()
    '                        StrContenido = StrContenido.Insert(19, " " & TbParam.Rows(0)("EncodingXML"))
    '                        Dim IntPos As Integer = StrContenido.IndexOf("<" & DtFich.Rows(0)("NombreCampo") & ">", 0)
    '                        IntPos += Len(DtFich.Rows(0)("NombreCampo")) + 1
    '                        StrContenido = StrContenido.Insert(IntPos, " " & DtFich.Rows(0)("Expresion"))
    '                        If StrContenido.Contains("<->") Then StrContenido = StrContenido.Replace("<->", "") : StrContenido = StrContenido.Replace("</->", "")
    '                        If StrContenido.Contains("Facturae") Then StrContenido = StrContenido.Replace("<Facturae ", "<fe:Facturae ") : StrContenido = StrContenido.Replace("</Facturae>", "</fe:Facturae>")
    '                        IO.File.Delete(StDatosFichero.StrRutaFichero)
    '                        Dim StrFile As IO.FileStream = IO.File.Create(StDatosFichero.StrRutaFichero)
    '                        StrFile.Close()
    '                        Dim FilXml As New IO.StreamWriter(StDatosFichero.StrRutaFichero)
    '                        FilXml.Write(StrContenido)
    '                        FilXml.Close()
    '                    End If
    '                    If Not IO.File.Exists(StrDirPend & "\" & DtFil.Rows(0)(StrCampoFactura) & "_" & DtFil.Rows(0)(StrCampoMail) & ".xml.direc") Then
    '                        Dim StrWr As New IO.StreamWriter(CStr(StrDirPend & "\" & DtFil.Rows(0)(StrCampoFactura) & "_" & DtFil.Rows(0)(StrCampoMail) & ".xml.direc"))
    '                        For Each Dr As DataRow In DtFil.Select
    '                            StrWr.WriteLine(Dr("IDFactura"))
    '                        Next
    '                        StrWr.Close()
    '                        IO.File.SetAttributes(CStr(StrDirPend & "\" & DtFil.Rows(0)(StrCampoFactura) & "_" & DtFil.Rows(0)(StrCampoMail) & ".xml.direc"), IO.FileAttributes.Hidden)
    '                    End If
    '                    ''Firmamos el fichero XML
    '                    Dim StrNomFichero As String = StrDirPend & StrFecha & "_" & DtFil.Rows(0)(StrCampoFactura) & ".xml"
    '                    If Not IO.File.Exists(StrDirPend & Today.Date & "_" & DtFil.Rows(0)(StrCampoFactura) & ".S.xml") Then
    '                        Dim StrResul As String = FirmarXmlFacturae(StrDirPend & StrFecha & "_" & DtFil.Rows(0)(StrCampoFactura) & ".xml")
    '                        If Length(StrResul) > 0 Then
    '                            ReDim Preserve Log.Errors(IntPosError)
    '                            Log.Errors(IntPosError) = New ClassErrors
    '                            Log.Errors(IntPosError).Elements = DtFil.Rows(0)(StrCampoFactura)
    '                            Log.Errors(IntPosError).MessageError = "El fichero de la factura: " & DtFil.Rows(0)(StrCampoFactura) & ".Error: " & StrResul
    '                            IntPosError += 1
    '                        Else
    '                            'Damos de alta el nuevo documento en la gestión documental
    '                            For Each DrFact As DataRow In DtFil.Select
    '                                If Not AltaGDFactura(DrFact(StrCampoPrimaryKey), "Factura Electrónica: " & DrFact(StrCampoFactura), StrNomFichero) Then
    '                                    ReDim Preserve Log.Errors(IntPosError)
    '                                    Log.Errors(IntPosError) = New ClassErrors
    '                                    Log.Errors(IntPosError).Elements = DrFact(StrCampoFactura)
    '                                    Log.Errors(IntPosError).MessageError = "No se ha podido dar de alta en la Gestión documental el documento de la factura: " & DtFil.Rows(0)(StrCampoFactura)
    '                                    IntPosError += 1
    '                                End If
    '                            Next
    '                            ReDim Preserve Log.CreatedElements(IntPosCreate)
    '                            Log.CreatedElements(IntPosCreate) = New CreateElement
    '                            Log.CreatedElements(IntPosCreate).NElement = DtFil.Rows(0)(StrCampoFactura)
    '                            IntPosCreate += 1
    '                        End If
    '                    End If
    '                Catch ex As Exception
    '                    ReDim Preserve Log.Errors(IntPosError)
    '                    Log.Errors(IntPosError) = New ClassErrors
    '                    Log.Errors(IntPosError).Elements = DtFil.Rows(0)(StrCampoFactura)
    '                    Log.Errors(IntPosError).MessageError = ex.Message
    '                    IntPosError += 1
    '                End Try
    '            Else
    '                ReDim Preserve Log.Errors(IntPosError)
    '                Log.Errors(IntPosError) = New ClassErrors
    '                Log.Errors(IntPosError).Elements = DtFil.Rows(0)(StrCampoFactura)
    '                Log.Errors(IntPosError).MessageError = "El Fichero de la factura: " & DtFil.Rows(0)(StrCampoFactura) & " ya existe en el directorio de pendientes."
    '                IntPosError += 1
    '            End If
    '        End If
    '        TratarGenerarClientesFacturaElecLog(Log)
    '    End Sub

    '    Private Sub CrearXML(ByVal StrRutaFichero As String, ByVal XmlDoc() As Byte)
    '        Dim FileXml As New IO.FileStream(StrRutaFichero, IO.FileMode.Create)
    '        FileXml.Write(XmlDoc, 0, XmlDoc.Length)
    '        FileXml.Close()
    '    End Sub

    '    Private Function AltaGDFactura(ByVal IntIDFactura As Integer, ByVal StrDescDoc As String, ByVal StrRutaFichero As String) As Boolean
    '        Try
    '            If Not New Parametro().ExpertisSAAS Then
    '                Dim DtDoc As DataTable = New DcmDocumentoEntidad().Filter(New FilterItem("Valor1", FilterOperator.Equal, CStr(IntIDFactura), FilterType.String))
    '                Dim ClsDcmMaestroDoc As New DcmMaestroDocumento
    '                If DtDoc Is Nothing OrElse DtDoc.Rows.Count = 0 Then
    '                    Dim MDtPK As DataTable = New FacturaVentaCabecera().PrimaryKeyTable
    '                    Dim DrNew As DataRow = MDtPK.NewRow
    '                    DrNew("IDFactura") = IntIDFactura
    '                    MDtPK.Rows.Add(DrNew)
    '                    Dim StData As New DcmMaestroDocumento.DataAddDocComplete(StrDescDoc, StrRutaFichero, StrRutaFichero, enumEstadoDoc.Pendiente, -1, Today.Date, MDtPK, "FacturaVentaCabecera")
    '                    ExpertisApp.ExecuteTask(Of DcmMaestroDocumento.DataAddDocComplete, DataTable)(AddressOf DcmMaestroDocumento.AddDocumentoDt, StData)
    '                Else
    '                    Dim DtMaestroDoc As DataTable = ClsDcmMaestroDoc.SelOnPrimaryKey(DtDoc.Rows(0)("IDDocumento"))
    '                    If Not DtMaestroDoc Is Nothing AndAlso DtMaestroDoc.Rows.Count > 0 Then
    '                        Dim StrExtDoc As String = Strings.Right(DtMaestroDoc.Rows(0)("URL"), 4)
    '                        Dim StrExtFile As String = Strings.Right(StrRutaFichero, 4)
    '                        If StrExtDoc <> StrExtFile Then
    '                            Dim MDtPK As DataTable = New FacturaVentaCabecera().PrimaryKeyTable
    '                            Dim DrNew As DataRow = MDtPK.NewRow
    '                            DrNew("IDFactura") = IntIDFactura
    '                            MDtPK.Rows.Add(DrNew)
    '                            Dim StDataDoc As New DcmMaestroDocumento.DataAddDocComplete(StrDescDoc, StrRutaFichero, StrRutaFichero, enumEstadoDoc.Pendiente, -1, Today.Date, MDtPK, "FacturaVentaCabecera")
    '                            ExpertisApp.ExecuteTask(Of DcmMaestroDocumento.DataAddDocComplete, DataTable)(AddressOf DcmMaestroDocumento.AddDocumentoDt, StDataDoc)
    '                        ElseIf StrExtDoc = StrExtFile Then
    '                            DtMaestroDoc.Rows(0)("URL") = StrRutaFichero
    '                            DtMaestroDoc.Rows(0)("URLDestino") = StrRutaFichero
    '                            ClsDcmMaestroDoc.Update(DtMaestroDoc)
    '                        End If
    '                    End If
    '                End If
    '            Else : Return True
    '            End If
    '        Catch ex As Exception
    '            Return False
    '        End Try
    '        Return True
    '    End Function

    '    Public Sub ModificarGDFactura(ByVal IntIDFactura As Integer, ByVal StrURL As String)
    '        If Not New Parametro().ExpertisSAAS Then
    '            Dim FilGD As New Filter
    '            FilGD.Add("Entidad", FilterOperator.Equal, "FacturaVentaCabecera")
    '            FilGD.Add("Campo1", FilterOperator.Equal, "IDFactura")
    '            FilGD.Add("Valor1", FilterOperator.Equal, IntIDFactura, FilterType.String)
    '            Dim DtGD As DataTable = New DcmDocumentoEntidad().Filter(FilGD)
    '            If Not DtGD Is Nothing AndAlso DtGD.Rows.Count > 0 Then
    '                Dim IntIDDoc As Integer = DtGD.Rows(0)("IDDocumento")
    '                Dim ClsDoc As New DcmMaestroDocumento
    '                Dim FilDoc As New Filter
    '                FilDoc.Add("IDDocumento", FilterOperator.Equal, IntIDDoc)
    '                FilDoc.Add("URL", FilterOperator.Equal, StrURL)
    '                Dim DtGDDoc As DataTable = ClsDoc.Filter(FilDoc)
    '                If Not DtGDDoc Is Nothing AndAlso DtGDDoc.Rows.Count > 0 Then
    '                    DtGDDoc.Rows(0)("URL") = Strings.Replace(DtGDDoc.Rows(0)("URL"), "Pendientes", "Enviados")
    '                    DtGDDoc.Rows(0)("URLDestino") = Strings.Replace(DtGDDoc.Rows(0)("URLDestino"), "Pendientes", "Enviados")
    '                    ClsDoc.Update(DtGDDoc)
    '                End If
    '            End If
    '        End If
    '    End Sub

    '    Public Function FirmarFicherosPDF(ByVal Data As DataTable, ByVal StrCampoFichero As String) As LogProcess
    '        Dim LogPrc As New LogProcess
    '        Dim IntPosCreate As Integer = 0
    '        Dim IntPosError As Integer = 0

    '        Dim InfoFirma As New SignatureInfo
    '        For Each Dr As DataRow In Data.Select
    '            InfoFirma.FicheroFirmarOrigen = Dr(StrCampoFichero)
    '            InfoFirma.FicheroFirmarDestino = CStr(Dr(StrCampoFichero)).Replace(".pdf", ".S.pdf")
    '            Dim StrResul As String = FirmarPDF(InfoFirma)
    '            If Length(StrResul) = 0 Then
    '                ReDim Preserve LogPrc.CreatedElements(IntPosCreate)
    '                LogPrc.CreatedElements(IntPosCreate) = New CreateElement
    '                LogPrc.CreatedElements(IntPosCreate).NElement = Dr(StrCampoFichero)
    '                IntPosCreate += 1
    '                IO.File.Delete(InfoFirma.FicheroFirmarOrigen)
    '            Else
    '                ReDim Preserve LogPrc.Errors(IntPosError)
    '                LogPrc.Errors(IntPosError) = New ClassErrors
    '                LogPrc.Errors(IntPosError).Elements = Dr(StrCampoFichero)
    '                LogPrc.Errors(IntPosError).MessageError = "No se ha podido firmar el fichero: " & Dr(StrCampoFichero) & ". " & vbNewLine & StrResul
    '                IntPosError += 1
    '            End If
    '        Next
    '        Return LogPrc
    '    End Function

    '    Public Function FirmarFicherosPDF(ByVal data As String) As LogProcess
    '        If Length(data) > 0 Then
    '            Dim LogPrc As New LogProcess
    '            Dim IntPosCreate As Integer = 0
    '            Dim IntPosError As Integer = 0

    '            Dim StrFicheros() As String = IO.Directory.GetFiles(data, "*.pdf")
    '            Dim InfoFirma As New SignatureInfo
    '            For Each Fich As String In StrFicheros
    '                InfoFirma.FicheroFirmarOrigen = Fich
    '                InfoFirma.FicheroFirmarDestino = Fich.Replace(".pdf", ".S.pdf")
    '                Dim StrResul As String = FirmarPDF(InfoFirma)
    '                If Length(StrResul) = 0 Then
    '                    ReDim Preserve LogPrc.CreatedElements(IntPosCreate)
    '                    LogPrc.CreatedElements(IntPosCreate) = New CreateElement
    '                    LogPrc.CreatedElements(IntPosCreate).NElement = Fich
    '                    IntPosCreate += 1
    '                Else
    '                    ReDim Preserve LogPrc.Errors(IntPosError)
    '                    LogPrc.Errors(IntPosError) = New ClassErrors
    '                    LogPrc.Errors(IntPosError).Elements = Fich
    '                    LogPrc.Errors(IntPosError).MessageError = "No se ha podido firmar el fichero: " & Fich & ". " & vbNewLine & StrResul
    '                    IntPosError += 1
    '                End If
    '            Next
    '            Return LogPrc
    '        End If
    '    End Function

    '    Private Function FirmarPDF(ByVal data As SignatureInfo) As String
    '        Dim StrResul As String = String.Empty
    '        Try
    '            Dim StrCert As String = ExpertisApp.ExecuteTask(Of Object, String)(AddressOf FacturaElec.GetLastCerID, New Object)
    '            Dim store As New X509Store("MY", StoreLocation.CurrentUser)
    '            store.Open(OpenFlags.ReadOnly)
    '            Dim Selec As X509CertificateCollection
    '            If Length(StrCert) = 0 Then
    '                Selec = X509Certificates.X509Certificate2UI.SelectFromCollection(store.Certificates, "Certificados Instalados", "Seleccione un Certificado", X509SelectionFlag.SingleSelection)
    '            Else : Selec = store.Certificates.Find(X509FindType.FindBySerialNumber, StrCert, False)
    '            End If
    '            If Not Selec Is Nothing AndAlso Selec.Count > 0 Then
    '                Dim StrMsg As String = VerificarCertificado(Selec(0), False)
    '                If Length(StrMsg) = 0 Then
    '                    If ExpertisApp.ExecuteTask(Of Object, Boolean)(AddressOf FacturaElec.GetUseLastCert, New Object) Then
    '                        Dim Cert As New X509Certificate2(Selec(0))
    '                        ExpertisApp.ExecuteTask(Of String)(AddressOf FacturaElec.SaveLastCerID, Cert.SerialNumber)
    '                    End If
    '                    Dim ClsSign As New PDFSign
    '                    ClsSign.ResetPDFSignatureStructure()
    '                    ClsSign.SetSigningCertificate(Selec(0))
    '                    ClsSign.SignedBy = data.InfoContactoFirma
    '                    ClsSign.ReasonText = "Factura Electrónica"
    '                    ClsSign.LocationText = data.LocalizacionFirma
    '                    'ClsSign.DateFormat = "dd-MM-yyyy"
    '                    ClsSign.TSAServerURL = "http://timestamping.edelweb.fr/service/tsp"
    '                    ClsSign.CertifyDocument = True
    '                    ClsSign.DoNotSignSignedDocuments = True
    '                    ClsSign.SignPDFFile(data.FicheroFirmarOrigen, data.FicheroFirmarDestino)
    '                    store.Close()
    '                Else
    '                    store.Close()
    '                    Throw New Exception(StrMsg)
    '                End If
    '            Else
    '                store.Close()
    '                Throw New Exception("No se seleccionó ningún certificado del listado de certificados.")
    '            End If
    '        Catch ex As Exception
    '            StrResul = ex.Message
    '        End Try
    '        Return StrResul
    '    End Function

    '    Private Function FirmarPDFs(ByVal data As SignatureInfo, ByVal Cert As X509Certificate2) As String
    '        Dim StrResul As String = String.Empty
    '        Try
    '            If Not Cert Is Nothing Then
    '                Dim StrMsg As String = VerificarCertificado(cert, False)
    '                If Length(StrMsg) = 0 Then
    '                    Dim ClsSign As New PDFSign
    '                    ClsSign.ResetPDFSignatureStructure()
    '                    ClsSign.SetSigningCertificate(cert)
    '                    ClsSign.SignedBy = data.InfoContactoFirma
    '                    ClsSign.ReasonText = "Factura Electrónica"
    '                    ClsSign.LocationText = data.LocalizacionFirma
    '                    'ClsSign.DateFormat = "dd-MM-yyyy"
    '                    ClsSign.TSAServerURL = "http://timestamping.edelweb.fr/service/tsp"
    '                    ClsSign.CertifyDocument = True
    '                    ClsSign.DoNotSignSignedDocuments = True
    '                    ClsSign.SignPDFFile(data.FicheroFirmarOrigen, data.FicheroFirmarDestino)
    '                Else
    '                    Throw New Exception(StrMsg)
    '                End If
    '            End If
    '        Catch ex As Exception
    '            StrResul = ex.Message
    '        End Try
    '        Return StrResul
    '    End Function

    '    Public Function VerificarCertificados()
    '        Dim store As New X509Store("MY", StoreLocation.CurrentUser)
    '        store.Open(OpenFlags.ReadOnly)
    '        Dim StrMsg As String = String.Empty
    '        Dim i As Integer = 1
    '        For Each Cert As X509Certificate In store.Certificates
    '            Dim StrResul As String = VerificarCertificado(New X509Certificate2(Cert))
    '            StrResul = i & ".- Certificado: " & Cert.Subject & ". " & StrResul
    '            StrMsg &= StrResul & vbNewLine & vbNewLine
    '            i += 1
    '        Next
    '        ExpertisApp.GenerateMessage(StrMsg, MessageBoxButtons.OK, MessageBoxIcon.Information)
    '        store.Close()
    '    End Function

    '    Public Sub VerificarCertificadoSelUsuario()
    '        Dim store As New X509Store("MY", StoreLocation.CurrentUser)
    '        store.Open(OpenFlags.ReadOnly)
    '        Dim Selec As X509CertificateCollection = X509Certificates.X509Certificate2UI.SelectFromCollection(store.Certificates, "Certificados Instalados", "Seleccione un Certificado", X509SelectionFlag.SingleSelection)
    '        If Not Selec Is Nothing AndAlso Selec.Count > 0 Then
    '            Dim StrMsg As String = VerificarCertificado(New X509Certificate2(Selec(0)))
    '            ExpertisApp.GenerateMessage(StrMsg, MessageBoxButtons.OK, MessageBoxIcon.Information)
    '        Else
    '            ExpertisApp.GenerateMessage("No se seleccionó ningún certificado del listado de certificados.", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '        End If
    '        store.Close()
    '    End Sub

    '    Private Function VerificarCertificado(ByVal Cert As X509Certificate2, Optional ByVal BlnReturnCorrectMessage As Boolean = True) As String
    '        Dim CS As CertificateStatus = New PDFSign().VerifyCertificate(Cert)
    '        Select Case CS
    '            Case CertificateStatus.NotTimeValid, CertificateStatus.Revoked
    '                Return "Validación de Certificado: " & Cert.Issuer & "." & vbNewLine & vbNewLine & CS.ToString
    '            Case CertificateStatus.ValidButNoCRLFound
    '                If BlnReturnCorrectMessage Then
    '                    Return "Validación de Certificado: " & Cert.Issuer & "." & vbNewLine & vbNewLine & CS.ToString
    '                Else : Return String.Empty
    '                End If
    '            Case CertificateStatus.CRLAndTimeValid
    '                If BlnReturnCorrectMessage Then
    '                    Return "Validación de Certificado: " & Cert.Issuer & "." & vbNewLine & vbNewLine & "CORRECTO"
    '                Else : Return String.Empty
    '                End If
    '        End Select
    '    End Function

    '    Public Function FirmarFicherosXML(ByVal Data As DataTable, ByVal StrCampoFichero As String) As LogProcess
    '        Dim LogPrc As New LogProcess
    '        Dim IntPosCreate As Integer = 0
    '        Dim IntPosError As Integer = 0

    '        For Each Dr As DataRow In Data.Select
    '            Dim StrResul As String = FirmarXmlFacturae(Dr("NombreFichero"))
    '            If Length(StrResul) = 0 Then
    '                ReDim Preserve LogPrc.CreatedElements(IntPosCreate)
    '                LogPrc.CreatedElements(IntPosCreate) = New CreateElement
    '                LogPrc.CreatedElements(IntPosCreate).NElement = Dr(StrCampoFichero)
    '                IntPosCreate += 1
    '            Else
    '                ReDim Preserve LogPrc.Errors(IntPosError)
    '                LogPrc.Errors(IntPosError) = New ClassErrors
    '                LogPrc.Errors(IntPosError).Elements = Dr(StrCampoFichero)
    '                LogPrc.Errors(IntPosError).MessageError = "No se ha podido firmar el fichero: " & Dr(StrCampoFichero) & ". " & vbNewLine & StrResul
    '                IntPosError += 1
    '            End If
    '        Next
    '        Return LogPrc
    '    End Function

    '    Public Function FirmarXmlFacturae(ByRef StrFichero As String) As String
    '        Dim URLTSA As String = "http://timestamping.edelweb.fr/service/tsp"
    '        Dim XmlDoc As New XmlDocument
    '        XmlDoc.PreserveWhitespace = True
    '        XmlDoc.Load(StrFichero)

    '        Dim Role As String = "EM"
    '        Dim SignP As New Xades.XadesSignature
    '        Try
    '            Dim StrCert As String = ExpertisApp.ExecuteTask(Of Object, String)(AddressOf FacturaElec.GetLastCerID, New Object)
    '            Dim store As New X509Store("MY", StoreLocation.CurrentUser)
    '            store.Open(OpenFlags.ReadOnly)
    '            Dim Selec As X509CertificateCollection
    '            If Length(StrCert) = 0 Then
    '                Selec = X509Certificates.X509Certificate2UI.SelectFromCollection(store.Certificates, "Certificados Instalados", "Seleccione un Certificado", X509SelectionFlag.SingleSelection)
    '            Else : Selec = store.Certificates.Find(X509FindType.FindBySerialNumber, StrCert, False)
    '            End If
    '            If Not Selec Is Nothing AndAlso Selec.Count > 0 Then
    '                If ExpertisApp.ExecuteTask(Of Object, Boolean)(AddressOf FacturaElec.GetUseLastCert, New Object) Then
    '                    Dim Cert As New X509Certificate2(Selec(0))
    '                    ExpertisApp.ExecuteTask(Of String)(AddressOf FacturaElec.SaveLastCerID, Cert.SerialNumber)
    '                End If
    '                SignP.XadesXL(XmlDoc, Role, URLTSA, Selec(0), "Expertis")
    '                SignP.XadesValidation(XmlDoc, False)
    '                ExpertisApp.GenerateMessage("Se firmó correctamente el fichero xml.", Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Information)
    '                Dim StrFicheroDestino As String = Strings.Replace(StrFichero, ".xml", ".S.xml")
    '                IO.File.Move(StrFichero, StrFicheroDestino)
    '                StrFichero = StrFicheroDestino
    '            Else : Return "No se seleccionó un certificado del listado de certificados."
    '            End If
    '        Catch ex As Exception
    '            Return "Ocurrió un error en el proceso de Firma: " & ex.Message & "."
    '        End Try
    '        XmlDoc.Save(StrFichero)
    '        Return String.Empty
    '    End Function

    '    Public Function FirmarXmlFacturae(ByRef StrFichero As String, ByVal BlnOption As Boolean) As LogProcess
    '        Dim URLTSA As String = "http://timestamping.edelweb.fr/service/tsp"
    '        Dim XmlDoc As New XmlDocument
    '        XmlDoc.PreserveWhitespace = True
    '        XmlDoc.Load(StrFichero)

    '        Dim Role As String = "EM"
    '        Dim SignP As New Xades.XadesSignature
    '        Try
    '            Dim StrCert As String = ExpertisApp.ExecuteTask(Of Object, String)(AddressOf FacturaElec.GetLastCerID, New Object)
    '            Dim store As New X509Store("MY", StoreLocation.CurrentUser)
    '            store.Open(OpenFlags.ReadOnly)
    '            Dim Selec As X509CertificateCollection
    '            If Length(StrCert) = 0 Then
    '                Selec = X509Certificates.X509Certificate2UI.SelectFromCollection(store.Certificates, "Certificados Instalados", "Seleccione un Certificado", X509SelectionFlag.SingleSelection)
    '            Else : Selec = store.Certificates.Find(X509FindType.FindBySerialNumber, StrCert, False)
    '            End If
    '            If Not Selec Is Nothing AndAlso Selec.Count > 0 Then
    '                If ExpertisApp.ExecuteTask(Of Object, Boolean)(AddressOf FacturaElec.GetUseLastCert, New Object) Then
    '                    Dim Cert As New X509Certificate2(Selec(0))
    '                    ExpertisApp.ExecuteTask(Of String)(AddressOf FacturaElec.SaveLastCerID, Cert.SerialNumber)
    '                End If
    '                SignP.XadesXL(Role, URLTSA, "AA", "AA", XmlDoc, "Expertis")

    '                SignP.XadesXL(XmlDoc, Role, URLTSA, Selec(0), "Expertis")
    '                SignP.XadesValidation(XmlDoc, False)
    '                ExpertisApp.GenerateMessage("Se firmó correctamente el fichero xml.", Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Information)
    '                Dim StrFicheroDestino As String = Strings.Replace(StrFichero, ".xml", ".S.xml")
    '                IO.File.Move(StrFichero, StrFicheroDestino)
    '                StrFichero = StrFicheroDestino
    '            Else
    '                ExpertisApp.GenerateMessage("No se seleccionó un certificado del listado de certificados.", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '                'Return False
    '            End If
    '        Catch ex As Exception
    '            ExpertisApp.GenerateMessage("Ocurrió un error en el proceso de Firma: |.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, ex.Message)
    '            'Return False
    '        End Try
    '        XmlDoc.Save(StrFichero)
    '        'Return True
    '    End Function

    '#End Region

#Region "Acciones Globales"

    Public Sub ActionRefreshSimpleForm(ByVal ProgramID As Guid)
        Dim FrmCall As Form = ExpertisApp.GetForm(ProgramID)
        For Each frm As Form In System.Windows.Forms.Application.OpenForms
            If FrmCall.Name = frm.Name Then
                CType(frm, Solmicro.Expertis.Engine.UI.SimpleMnto).RecordsState = RecordsState.Saved
                CType(frm, Solmicro.Expertis.Engine.UI.SimpleMnto).Requery.InvokeOnClick()
                Exit For
            End If
        Next
    End Sub

    Public Sub ActionRefreshCIForm(ByVal ProgramID As Guid)
        Dim FrmCall As Form = ExpertisApp.GetForm(ProgramID)
        For Each Frm As Form In System.Windows.Forms.Application.OpenForms
            If FrmCall.Name = Frm.Name Then
                If Frm.GetType.BaseType Is GetType(CIMnto) Then
                    CType(Frm, Solmicro.Expertis.Engine.UI.CIMnto).UnCheckAllRecords()
                    CType(Frm, Solmicro.Expertis.Engine.UI.CIMnto).Execute()
                    Exit For
                ElseIf Frm.GetType.BaseType Is GetType(CIMntoBase) Then
                    CType(Frm, Solmicro.Expertis.Engine.UI.CIMntoBase).UnCheckAllRecords()
                    CType(Frm, Solmicro.Expertis.Engine.UI.CIMntoBase).Execute()
                    Exit For
                End If
            End If
        Next
    End Sub

    Public Sub ActionGoToRecordSimpleForm(ByVal ProgramID As Guid, ByVal StrField As String, ByVal IntValue As Integer)
        Dim FrmCall As Form = ExpertisApp.GetForm(ProgramID)
        For Each Frm As Form In System.Windows.Forms.Application.OpenForms
            If FrmCall.Name = Frm.Name Then
                Dim FilRecord As New Filter
                FilRecord.Add(StrField, FilterOperator.Equal, IntValue)
                CType(Frm, Solmicro.Expertis.Engine.UI.SimpleMnto).GotoRecord(DataProviderActions.GoFirst, FilRecord)
                Exit For
            End If
        Next
    End Sub

#End Region

#Region " Permisos "

    Public Class DataRestriccionesEntidad
        Private mNinguna As Boolean
        Private mDenegadoLectura As Boolean
        Private mDenegadoInserccion As Boolean
        Private mDenegadoModificacion As Boolean
        Private mDenegadoDelete As Boolean

        Public Property Ninguna() As Boolean
            Get
                Return mNinguna
            End Get
            Set(ByVal Value As Boolean)
                mNinguna = Value
                If Value Then
                    mDenegadoLectura = False
                    mDenegadoInserccion = False
                    mDenegadoModificacion = False
                    mDenegadoDelete = False
                End If
            End Set
        End Property

        Public Property DenegadoLectura() As Boolean
            Get
                Return mDenegadoLectura
            End Get
            Set(ByVal Value As Boolean)
                mDenegadoLectura = Value
                If Value Then
                    mNinguna = False
                End If
            End Set
        End Property

        Public Property DenegadoInserccion() As Boolean
            Get
                Return mDenegadoInserccion
            End Get
            Set(ByVal Value As Boolean)
                mDenegadoInserccion = Value
                If Value Then
                    mNinguna = False
                End If
            End Set
        End Property

        Public Property DenegadoModificacion() As Boolean
            Get
                Return mDenegadoModificacion
            End Get
            Set(ByVal Value As Boolean)
                mDenegadoModificacion = Value
                If Value Then
                    mNinguna = False
                End If
            End Set
        End Property

        Public Property DenegadoDelete() As Boolean
            Get
                Return mDenegadoDelete
            End Get
            Set(ByVal Value As Boolean)
                mDenegadoDelete = Value
                If Value Then
                    mNinguna = False
                End If
            End Set
        End Property

        Public Sub New()
            Me.Ninguna = True
        End Sub
    End Class

    Public Function GetPermisosEntidad(ByVal EntityName As String) As DataRestriccionesEntidad
        Dim Restriction As EntityRestriction

        If Not ExpertisApp.SessionDescriptor Is Nothing AndAlso ExpertisApp.SessionDescriptor.Security.ContainsKey(EntityName) Then
            Restriction = CType(ExpertisApp.SessionDescriptor.Security(EntityName), EntitySecurity).Restriction
        End If

        Dim datRestricciones As New DataRestriccionesEntidad
        If Restriction <> EntityRestriction.None Then
            If Restriction - EntityRestriction.DenyDelete >= 0 Then
                datRestricciones.DenegadoDelete = True
                Restriction -= EntityRestriction.DenyDelete
            End If
            If Restriction - EntityRestriction.DenyUpdate >= 0 Then
                datRestricciones.DenegadoModificacion = True
                Restriction -= EntityRestriction.DenyUpdate
            End If
            If Restriction - EntityRestriction.DenyInsert >= 0 Then
                datRestricciones.DenegadoInserccion = True
                Restriction -= EntityRestriction.DenyInsert
            End If
            If Restriction - EntityRestriction.DenyRead >= 0 Then
                datRestricciones.DenegadoLectura = True
                Restriction -= EntityRestriction.DenyRead
            End If
        End If
        Return datRestricciones
    End Function

#End Region

#Region " Lectura de Fichero XML (Solid Works)"

    'Public Sub Serializar(ByVal xmlDoc As Xml.XmlDocument)
    '    Dim ser As Xml.Serialization.XmlSerializer = New Xml.Serialization.XmlSerializer(GetType(Xml.XmlDocument))
    '    Dim myWriter As New IO.StreamWriter("file.xml")
    '    ser.Serialize(myWriter, xmlDoc)
    '    myWriter.Close()
    'End Sub

    'Public Sub Deserializar(ByVal xmlDoc As Xml.XmlDocument)
    '    Dim ser As Xml.Serialization.XmlSerializer = New Xml.Serialization.XmlSerializer(GetType(Xml.XmlDocument))
    '    Dim myWriter As New IO.StreamWriter("file.xml")
    '    ser.Deserialize(myWriter)
    '    myWriter.Close()
    'End Sub



    <Serializable()> _
    Public Class DataFicheroSolid
        Public Articulos As DataTable
        Public ArticuloEstructura As DataTable
        Public Caracteristicas As DataTable
        Public ArticuloCaracteristicaValor As DataTable
        Public ArticuloDocumento As DataTable

        Public IDArticuloRaiz As String

        Public Log As LogProcess
    End Class
    Public Function CrearArticulosEstructurasXML(ByVal xmlDoc As XmlDocument) As DataFicheroSolid
        'Dim xmlDoc As New Xml.XmlDocument
        'xmlDoc.LoadXml(xml)
        If Not xmlDoc Is Nothing Then

            Dim logFichero As New DataFicheroSolid

            logFichero.Articulos = New DataTable
            logFichero.Articulos.Columns.Add("IDArticulo", GetType(String))
            logFichero.Articulos.Columns.Add("DescArticulo", GetType(String))

            logFichero.ArticuloEstructura = New DataTable
            logFichero.ArticuloEstructura.Columns.Add("IDArticulo", GetType(String))
            logFichero.ArticuloEstructura.Columns.Add("IDComponente", GetType(String))
            logFichero.ArticuloEstructura.Columns.Add("Cantidad", GetType(Double))

            logFichero.Caracteristicas = New DataTable
            logFichero.Caracteristicas.Columns.Add("IDCaracteristica", GetType(String))
            logFichero.Caracteristicas.Columns.Add("Tipo", GetType(String))

            logFichero.ArticuloCaracteristicaValor = New DataTable
            logFichero.ArticuloCaracteristicaValor.Columns.Add("IDArticulo", GetType(String))
            logFichero.ArticuloCaracteristicaValor.Columns.Add("IDCaracteristica", GetType(String))
            logFichero.ArticuloCaracteristicaValor.Columns.Add("Valor", GetType(String))

            logFichero.ArticuloDocumento = New DataTable
            logFichero.ArticuloDocumento.Columns.Add("IDArticulo", GetType(String))
            logFichero.ArticuloDocumento.Columns.Add("PathDocumento", GetType(String))


            logFichero.Log = New LogProcess
            If logFichero.Log.Errors Is Nothing Then ReDim logFichero.Log.Errors(0)
            If logFichero.Log.CreatedElements Is Nothing Then ReDim logFichero.Log.CreatedElements(0)
            Try
                Dim xmlArticulos As XmlNodeList = xmlDoc.GetElementsByTagName("entity")
                For Each node As XmlNode In xmlArticulos
                    Dim attr As XmlAttributeCollection = node.Attributes
                    If Not attr Is Nothing Then
                        Dim drArticulo As DataRow = logFichero.Articulos.NewRow
                        drArticulo("IDArticulo") = attr.ItemOf("code").Value
                        Dim NodoDesc As XmlNode = node.FirstChild
                        If Length(NodoDesc.InnerText) > 0 Then
                            drArticulo("DescArticulo") = NodoDesc.InnerText
                        Else
                            drArticulo("DescArticulo") = drArticulo("IDArticulo")
                        End If
                        logFichero.Articulos.Rows.Add(drArticulo)


                        '//Caracteristicas del Artículo
                        Dim xmlArticulo As XmlNodeList = node.ChildNodes
                        For Each nodesArt As XmlNode In xmlArticulo
                            Try
                                If nodesArt.Name = "Caracteristica" Then
                                    Dim NodeCaract As XmlNode = nodesArt '("Caracteristica")
                                    If Not NodeCaract Is Nothing Then
                                        Dim IDCaracteristica As String = NodeCaract.InnerText
                                        Dim Valor As String = NodeCaract.Attributes.ItemOf("Valor").Value

                                        logFichero.Caracteristicas.DefaultView.RowFilter = "IDCaracteristica='" & IDCaracteristica & "'"
                                        If logFichero.Caracteristicas.DefaultView.Count = 0 Then
                                            Dim drNewCaracteristica As DataRow = logFichero.Caracteristicas.NewRow
                                            drNewCaracteristica("IDCaracteristica") = IDCaracteristica
                                            logFichero.Caracteristicas.Rows.Add(drNewCaracteristica)
                                        End If
                                        logFichero.Caracteristicas.DefaultView.RowFilter = Nothing

                                        '//Valores de Caracteristicas del Artículo
                                        logFichero.ArticuloCaracteristicaValor.DefaultView.RowFilter = "IDArticulo ='" & drArticulo("IDArticulo") & "' AND IDCaracteristica='" & IDCaracteristica & "' AND Valor='" & Valor & "'"
                                        If logFichero.ArticuloCaracteristicaValor.DefaultView.Count = 0 Then
                                            Dim drNewCaracteristicaValor As DataRow = logFichero.ArticuloCaracteristicaValor.NewRow
                                            drNewCaracteristicaValor("IDArticulo") = drArticulo("IDArticulo")
                                            drNewCaracteristicaValor("IDCaracteristica") = IDCaracteristica
                                            drNewCaracteristicaValor("Valor") = Valor
                                            If UCase(drArticulo("IDArticulo") & String.Empty) = UCase(drArticulo("DescArticulo") & String.Empty) AndAlso (UCase(IDCaracteristica) = UCase("Descripcion") OrElse UCase(IDCaracteristica) = UCase("Descripción")) Then
                                                If Length(Valor) > 0 AndAlso Length(Trim(Valor)) > 0 Then
                                                    drArticulo("DescArticulo") = Trim(Valor)
                                                End If
                                            End If
                                            logFichero.ArticuloCaracteristicaValor.Rows.Add(drNewCaracteristicaValor)
                                        Else
                                            logFichero.ArticuloCaracteristicaValor.DefaultView.RowFilter = Nothing
                                            logFichero.ArticuloCaracteristicaValor.DefaultView.RowFilter = "IDArticulo ='" & drArticulo("IDArticulo") & "' AND IDCaracteristica='" & IDCaracteristica & "'"
                                            If logFichero.ArticuloCaracteristicaValor.DefaultView.Count > 0 Then
                                                logFichero.ArticuloCaracteristicaValor.DefaultView(0).Row("Valor") = Valor
                                            End If
                                        End If
                                        logFichero.ArticuloCaracteristicaValor.DefaultView.RowFilter = Nothing
                                    End If
                                End If
                            Catch ex As Exception
                                ReDim Preserve logFichero.Log.Errors(logFichero.Log.Errors.Length)
                                Dim Err As New ClassErrors(Nothing, "Error Leyendo Características del Artículo " & Quoted(drArticulo("IDArticulo")) & ": " & ex.Message)
                                logFichero.Log.Errors(logFichero.Log.Errors.Length - 1) = Err
                            End Try
                        Next

                        Try
                            '//Documentos adjuntos
                            If Not attr.ItemOf("path") Is Nothing Then
                                Dim pathDoc As String = attr.ItemOf("path").Value
                                logFichero.ArticuloDocumento.DefaultView.RowFilter = "IDArticulo ='" & drArticulo("IDArticulo") & "' AND PathDocumento='" & pathDoc & "'"
                                If logFichero.ArticuloDocumento.DefaultView.Count = 0 Then
                                    Dim drNewDoc As DataRow = logFichero.ArticuloDocumento.NewRow
                                    drNewDoc("IDArticulo") = drArticulo("IDArticulo")
                                    drNewDoc("PathDocumento") = pathDoc
                                    logFichero.ArticuloDocumento.Rows.Add(drNewDoc)
                                End If
                                logFichero.ArticuloDocumento.DefaultView.RowFilter = Nothing
                            End If
                        Catch ex As Exception
                            ReDim Preserve logFichero.Log.Errors(logFichero.Log.Errors.Length)
                            Dim Err As New ClassErrors(Nothing, "Error Leyendo Documentos del Artículo " & Quoted(drArticulo("IDArticulo")) & ": " & ex.Message)
                            logFichero.Log.Errors(logFichero.Log.Errors.Length - 1) = Err
                        End Try
                    End If
                Next
            Catch ex As Exception
                ReDim Preserve logFichero.Log.Errors(logFichero.Log.Errors.Length)
                Dim Err As New ClassErrors(Nothing, "Error Leyendo Artículos: " & vbNewLine & ex.Message)
                logFichero.Log.Errors(logFichero.Log.Errors.Length - 1) = Err
            End Try


            Try
                Dim xmlEstructura As XmlNodeList = xmlDoc.GetElementsByTagName("tree")
                For Each node As XmlNode In xmlEstructura
                    Dim IDArticulo As String = node.Attributes.ItemOf("code").Value
                    If Length(logFichero.IDArticuloRaiz) = 0 Then
                        logFichero.IDArticuloRaiz = IDArticulo
                        Dim drNewCaracteristicaValor As DataRow = logFichero.ArticuloCaracteristicaValor.NewRow
                        drNewCaracteristicaValor("IDArticulo") = logFichero.IDArticuloRaiz
                        drNewCaracteristicaValor("IDCaracteristica") = "MODELO"
                        drNewCaracteristicaValor("Valor") = logFichero.IDArticuloRaiz
                        logFichero.ArticuloCaracteristicaValor.Rows.Add(drNewCaracteristicaValor)
                    End If
                    Dim xmlComponentes As XmlNodeList = node.ChildNodes
                    For Each componente As XmlNode In xmlComponentes
                        Dim drComponente As DataRow = logFichero.ArticuloEstructura.NewRow
                        drComponente("IDArticulo") = IDArticulo
                        drComponente("IDComponente") = componente.Attributes.ItemOf("code").Value
                        drComponente("Cantidad") = componente.Attributes.ItemOf("quantity").Value
                        logFichero.ArticuloEstructura.Rows.Add(drComponente)
                        Dim datNodoComponente As New DataCargarEstructuraComponente(componente, logFichero.ArticuloEstructura)
                        CargarEstructuraComponente(datNodoComponente)
                    Next
                Next
            Catch ex As Exception
                ReDim Preserve logFichero.Log.Errors(logFichero.Log.Errors.Length)
                Dim Err As New ClassErrors(Nothing, "Error Leyendo Estructuras: " & ex.Message)
                logFichero.Log.Errors(logFichero.Log.Errors.Length - 1) = Err
            End Try

            Return logFichero
        End If
    End Function

    <Serializable()> _
    Public Class DataCargarEstructuraComponente
        Public NodoComponente As XmlNode
        Public dtEstructuras As DataTable

        Public Sub New(ByVal NodoComponente As XmlNode, ByVal dtEstructuras As DataTable)
            Me.NodoComponente = NodoComponente
            Me.dtEstructuras = dtEstructuras
        End Sub
    End Class
    Public Sub CargarEstructuraComponente(ByVal data As DataCargarEstructuraComponente)
        Dim IDArticulo As String = data.NodoComponente.Attributes.ItemOf("code").Value
        Dim xmlComponentes As XmlNodeList = data.NodoComponente.ChildNodes
        If xmlComponentes.Count > 0 Then
            For Each componente As XmlNode In xmlComponentes
                Dim drComponente As DataRow = data.dtEstructuras.NewRow
                drComponente("IDArticulo") = IDArticulo
                drComponente("IDComponente") = componente.Attributes.ItemOf("code").Value
                drComponente("Cantidad") = componente.Attributes.ItemOf("quantity").Value
                data.dtEstructuras.Rows.Add(drComponente)

                If componente.ChildNodes.Count > 0 Then
                    For Each componenteNivelX As XmlNode In componente.ChildNodes
                        Dim drComponenteNivelX As DataRow = data.dtEstructuras.NewRow
                        drComponenteNivelX("IDArticulo") = drComponente("IDComponente")
                        drComponenteNivelX("IDComponente") = componenteNivelX.Attributes.ItemOf("code").Value
                        drComponenteNivelX("Cantidad") = componenteNivelX.Attributes.ItemOf("quantity").Value
                        data.dtEstructuras.Rows.Add(drComponenteNivelX)
                        If componenteNivelX.ChildNodes.Count > 0 Then
                            Dim datNodoComponenteNivelX As New DataCargarEstructuraComponente(componenteNivelX, data.dtEstructuras)
                            CargarEstructuraComponente(datNodoComponenteNivelX)
                        End If
                    Next
                End If
            Next
            'Else
            '    Dim drComponente As DataRow = data.dtEstructuras.NewRow
            '    drComponente("IDArticulo") = IDArticulo
            '    drComponente("IDComponente") = data.NodoComponente.Attributes.ItemOf("code").Value
            '    drComponente("Cantidad") = data.NodoComponente.Attributes.ItemOf("quantity").Value
            '    data.dtEstructuras.Rows.Add(drComponente)
        End If
    End Sub

#End Region

#Region " Impuestos en Lineas de Facturas "

    Public Sub Impuestos(ByVal GridLineas As UI.Grid, ByVal CurrentRow As DataRow, ByVal CurrentDataImpuestos As DataTable, ByVal Circuito As Circuito, ByVal EntityName As String, ByVal ViewName As String, ByVal ViewNameLineas As String, ByVal CampoFecha As String, ByVal IDDocKeyField As String, ByVal SoloLectura As Boolean)
        If GridLineas.Row <> Grid.newTopRowPosition AndAlso Length(GridLineas.Value("IDArticulo")) > 0 Then
            Dim IDLineaKeyField As String = GridLineas.KeyField
            Dim frm As New frmImpuestos
            frm.EntityName = GridLineas.EntityName
            frm.IDDocKeyField = IDDocKeyField
            'frm.NavigationFields = IDLineaKeyField
            frm.ViewName = ViewNameLineas
            frm.jngImpuestos.EntityName = EntityName
            frm.jngImpuestos.PrimaryDataFields = IDLineaKeyField
            frm.jngImpuestos.SecondaryDataFields = IDLineaKeyField
            'frm.jngImpuestos.RelationMode = RelationMode.NoRelation
            frm.jngImpuestos.ViewName = ViewName
            frm.Data = CurrentDataImpuestos
            Select Case Circuito
                Case Business.BusinessEnum.Circuito.Ventas
                    frm.IDClienteProveedor = CurrentRow("IDCliente")
                Case Business.BusinessEnum.Circuito.Compras
                    frm.IDClienteProveedor = CurrentRow("IDProveedor")
            End Select

            'frm.SoloLectura = False
            frm.IDMoneda = CurrentRow("IDMoneda")
            frm.Fecha = CurrentRow(CampoFecha)
            frm.FilterCriteria = New NumberFilterItem(IDLineaKeyField, GridLineas.Value(IDLineaKeyField))
            frm.SoloLectura = SoloLectura
            frm.ShowDialog()
        End If
    End Sub

#End Region

  
End Module

Public Class GridFormatStyle
    Public Const FMT_CLAVE_COMUN As String = "FMT"

    Public Enum TipoFormato
        EstadoActivo
        TipoTarea
        Oficio
        RHTipoIT
        RHEstadoContrato
        RHTipoParte
        RHRiesgoEvaluacion
        CRMEstadoVenta
        IncidenciaClasificacion
        TipoActividad
        TipoTurno
        TipoTurnoFestivo
        TipoTurnoVacacion
    End Enum

    Private Shared Function GetCampo(ByVal tipo As TipoFormato) As String
        Select Case tipo
            Case TipoFormato.RHEstadoContrato
                Return "IdEstado"
            Case TipoFormato.RHTipoIT
                Return "IDTipoIT"
            Case TipoFormato.RHTipoParte
                Return "IDTipoParte"
            Case TipoFormato.EstadoActivo
                Return "IDEstadoActivo"
            Case TipoFormato.Oficio
                Return "IDOficio"
            Case TipoFormato.TipoTarea
                Return "IDTipoTarea"
            Case TipoFormato.RHRiesgoEvaluacion
                Return "IDEvaluacion"
            Case TipoFormato.CRMEstadoVenta
                Return "IDEstadoVenta"
            Case TipoFormato.IncidenciaClasificacion
                Return "IDClasificacion"
            Case TipoFormato.TipoActividad
                Return "IDTipoActividad"
            Case TipoFormato.TipoTurno, TipoFormato.TipoTurnoFestivo, TipoFormato.TipoTurnoVacacion
                Return "IDTipoTurno"
        End Select
    End Function

    Public Shared Sub CrearFormatos(ByVal grx As GridEX, ByVal estados As DataTable, ByVal tipo As TipoFormato, Optional ByVal blnGradiente As Boolean = False)
        If Not grx Is Nothing And Not estados Is Nothing Then
            Dim fmt As GridEXFormatStyle
            Dim strCampo As String = GetCampo(tipo)
            For Each estado As DataRow In estados.Rows
                If Length(estado("Color")) > 0 Then
                    fmt = New GridEXFormatStyle
                    fmt.Key = String.Concat(FMT_CLAVE_COMUN, estado(strCampo))
                    If blnGradiente Then fmt.BackgroundGradientMode = BackgroundGradientMode.DiagonalBackwards
                    grx.FormatStyles.Add(fmt)
                    If tipo = TipoFormato.TipoTurnoFestivo Then
                        fmt.ForeColor = ColorTranslator.FromWin32(estado("Color"))
                        fmt.BackColor = Color.Salmon
                        fmt.Key = String.Concat(FMT_CLAVE_COMUN, estado(strCampo) & "F")
                    ElseIf tipo = TipoFormato.TipoTurnoVacacion Then
                        fmt.ForeColor = ColorTranslator.FromWin32(estado("Color"))
                        fmt.BackColor = Color.PaleGreen
                        fmt.Key = String.Concat(FMT_CLAVE_COMUN, estado(strCampo) & "V")
                    ElseIf tipo = TipoFormato.TipoTurno Then
                        fmt.ForeColor = ColorTranslator.FromWin32(estado("Color"))
                    Else
                        fmt.BackColor = ColorTranslator.FromWin32(estado("Color"))
                    End If
                End If
            Next
        End If
    End Sub

    Public Shared Sub CrearFormatos(ByVal grx As GridEX, ByVal tipo As TipoFormato, Optional ByVal blnGradiente As Boolean = False)
        Dim d As New BE.DataEngine
        Select Case tipo
            Case TipoFormato.RHEstadoContrato
                CrearFormatos(grx, d.Filter("tbRHEstadoContrato", Nothing), tipo, blnGradiente)
            Case TipoFormato.RHTipoIT
                CrearFormatos(grx, d.Filter("tbRHTipoIT", Nothing), tipo, blnGradiente)
            Case TipoFormato.RHTipoParte
                CrearFormatos(grx, d.Filter("tbRHTipoParte", Nothing), tipo, blnGradiente)
            Case TipoFormato.EstadoActivo
                CrearFormatos(grx, New MntoEstadoActivo().Filter, tipo, blnGradiente)
            Case TipoFormato.Oficio
                CrearFormatos(grx, New Oficio().Filter, tipo, blnGradiente)
            Case TipoFormato.TipoTarea
                CrearFormatos(grx, New TipoTarea().Filter, tipo, blnGradiente)
            Case TipoFormato.RHRiesgoEvaluacion
                CrearFormatos(grx, d.Filter("tbRHRiesgoEvaluacion", Nothing), tipo, blnGradiente)
            Case TipoFormato.CRMEstadoVenta
                CrearFormatos(grx, d.Filter("tbCRMEstadoVenta", Nothing), tipo, blnGradiente)
            Case TipoFormato.IncidenciaClasificacion
                CrearFormatos(grx, d.Filter("tbCRMIncidenciaClasificacion", Nothing), tipo, blnGradiente)
            Case TipoFormato.TipoActividad
                CrearFormatos(grx, d.Filter("tbMaestroTipoActividad", Nothing), tipo, blnGradiente)
            Case TipoFormato.TipoTurno, TipoFormato.TipoTurnoFestivo, TipoFormato.TipoTurnoVacacion
                CrearFormatos(grx, d.Filter("tbTipoTurno", Nothing), tipo, blnGradiente)
        End Select
    End Sub

    Public Shared Sub ActualizarFormatos(ByVal grx As GridEX, ByVal estados As DataTable, ByVal tipo As TipoFormato)
        If Not grx Is Nothing And Not estados Is Nothing Then
            Dim fmt As GridEXFormatStyle
            Dim key As String
            Dim strCampo As String = GetCampo(tipo)
            For Each estado As DataRow In estados.Rows
                If ExisteFormato(grx, estado(strCampo)) Then
                    key = String.Concat(FMT_CLAVE_COMUN, estado(strCampo))
                    fmt = grx.FormatStyles(key)
                    If Not fmt.BackColor.Equals(ColorTranslator.FromWin32(estado("Color"))) Then
                        'fmt.BackColor = ColorTranslator.FromWin32(estado("Color"))
                        If tipo = TipoFormato.TipoTurnoFestivo Then
                            fmt.ForeColor = ColorTranslator.FromWin32(estado("Color"))
                            fmt.BackColor = Color.Salmon
                        ElseIf tipo = TipoFormato.TipoTurnoVacacion Then
                            fmt.ForeColor = ColorTranslator.FromWin32(estado("Color"))
                            fmt.BackColor = Color.PaleGreen
                        ElseIf tipo = TipoFormato.TipoTurno Then
                            fmt.ForeColor = ColorTranslator.FromWin32(estado("Color"))
                        Else
                            fmt.BackColor = ColorTranslator.FromWin32(estado("Color"))
                        End If
                    End If
                Else
                    '//No existía el formato, lo damos de alta
                    fmt = New GridEXFormatStyle
                    fmt.Key = String.Concat(FMT_CLAVE_COMUN, estado(strCampo))
                    grx.FormatStyles.Add(fmt)
                    If Length(estado("Color")) > 0 Then
                        'fmt.BackColor = ColorTranslator.FromWin32(estado("Color"))
                        If tipo = TipoFormato.TipoTurnoFestivo Then
                            fmt.ForeColor = ColorTranslator.FromWin32(estado("Color"))
                            fmt.BackColor = Color.Salmon
                        ElseIf tipo = TipoFormato.TipoTurnoVacacion Then
                            fmt.ForeColor = ColorTranslator.FromWin32(estado("Color"))
                            fmt.BackColor = Color.PaleGreen
                        ElseIf tipo = TipoFormato.TipoTurno Then
                            fmt.ForeColor = ColorTranslator.FromWin32(estado("Color"))
                        Else
                            fmt.BackColor = ColorTranslator.FromWin32(estado("Color"))
                        End If
                    End If
                End If
            Next
        End If
    End Sub

    Public Shared Sub AplicarFormato(ByVal row As Janus.Windows.GridEX.GridEXRow, ByVal ID As String)
        row.RowStyle = row.GridEX.FormatStyles(String.Concat(FMT_CLAVE_COMUN, ID))
    End Sub

    Public Shared Sub ActualizarFormato(ByVal grx As GridEX, ByVal ID As String, ByVal color As Color, Optional ByVal blnGradiente As Boolean = False)
        If ExisteFormato(grx, ID) Then
            '//Si existe el formato,lo actualizamos
            grx.FormatStyles(String.Concat(FMT_CLAVE_COMUN, ID)).BackColor = color
        Else
            '//Si no existe, lo creamos primero. No existía el formato, lo damos de alta
            Dim fmt As New GridEXFormatStyle
            fmt.Key = String.Concat(FMT_CLAVE_COMUN, ID)
            If blnGradiente Then fmt.BackgroundGradientMode = BackgroundGradientMode.DiagonalBackwards
            grx.FormatStyles.Add(fmt)
            fmt.BackColor = color
        End If
    End Sub

    Public Shared Sub ActualizarFormato(ByVal grx As GridEX, ByVal ID As String, ByVal color As Integer)
        ActualizarFormato(grx, ID, ColorTranslator.FromWin32(color))
    End Sub

    Public Shared Sub EliminarFormato(ByVal grx As GridEX, ByVal ID As String)
        If ExisteFormato(grx, ID) Then
            '//Si existe el formato,lo eliminamos
            grx.FormatStyles.Remove(grx.FormatStyles(String.Concat(FMT_CLAVE_COMUN, ID)))
        End If
    End Sub

    Public Shared Function ExisteFormato(ByVal grid As GridEX, ByVal ID As String) As Boolean
        ExisteFormato = False
        For Each fmt As GridEXFormatStyle In grid.FormatStyles
            If fmt.Key = String.Concat(FMT_CLAVE_COMUN, ID) Then
                ExisteFormato = True
            End If
        Next
    End Function

End Class