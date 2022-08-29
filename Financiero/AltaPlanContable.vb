Public Class AltaPlanContable

    Public Function AltaCuenta(ByVal pIdEjercicioActual As String, _
                              ByVal pIDEjercicioAnterior As String, _
                              ByVal pIDEjercicioSiguiente As String, _
                              ByVal strCuentaAlta As String, _
                              Optional ByVal strDescCuenta As String = "", _
                              Optional ByVal blnGrupo As Boolean = False, _
                              Optional ByVal IDDivisa As String = "") As Boolean

        AltaCuenta = False

        Dim dtEjercicios As New DataTable
        With dtEjercicios
            .Columns.Add("IDEjercicio", GetType(String))
            .Columns.Add("DigitosAuxiliar", GetType(Integer))
            .Columns.Add("Actual", GetType(Integer))
            .Columns.Add("Anterior", GetType(Integer))
            .Columns.Add("Siguiente", GetType(Integer))
            .Columns.Add("ActualTributario", GetType(Integer))
        End With

        Dim drNewRow As DataRow
        Dim dtDatos As DataTable
        Dim objNegEjercicio As New EjercicioContable
        If Length(pIdEjercicioActual) > 0 Then
            Dim IDEjercicioComplementario As String
            Dim DigitosAuxiliarComplementario As Integer
            drNewRow = dtEjercicios.NewRow
            drNewRow("IDEjercicio") = pIdEjercicioActual
            dtDatos = objNegEjercicio.SelOnPrimaryKey(pIdEjercicioActual)
            If Not IsNothing(dtDatos) AndAlso dtDatos.Rows.Count > 0 Then
                drNewRow("DigitosAuxiliar") = dtDatos.Rows(0)("DigitosAuxiliar")
                Dim p As New Parametro
                If p.ContabilidadMultiple Then
                    If Not Nz(dtDatos.Rows(0)("EjercicioTributario"), False) Then
                        IDEjercicioComplementario = dtDatos.Rows(0)("IDEjercicioTributario") & String.Empty
                    Else
                        Dim fNIIF As New Filter
                        fNIIF.Add(New StringFilterItem("IDEjercicioTributario", pIdEjercicioActual))
                        fNIIF.Add(New BooleanFilterItem("EjercicioTributario", False))
                        Dim dtEjNIIF As DataTable = New EjercicioContable().Filter(fNIIF)
                        If dtEjNIIF.Rows.Count > 0 Then
                            IDEjercicioComplementario = dtEjNIIF.Rows(0)("IDEjercicio")
                        End If
                    End If
                    If Length(IDEjercicioComplementario) > 0 Then
                        Dim dtDatosTributario As DataTable = objNegEjercicio.SelOnPrimaryKey(IDEjercicioComplementario)
                        If Not dtDatosTributario Is Nothing AndAlso dtDatosTributario.Rows.Count > 0 Then
                            DigitosAuxiliarComplementario = dtDatosTributario.Rows(0)("DigitosAuxiliar")
                            If Nz(dtDatosTributario.Rows(0)("EjercicioCerrado"), False) Then
                                IDEjercicioComplementario = String.Empty
                            Else
                                Dim dtCCActualTributario As DataTable = New PlanContable().SelOnPrimaryKey(IDEjercicioComplementario, strCuentaAlta)
                                If Not dtCCActualTributario Is Nothing AndAlso dtCCActualTributario.Rows.Count > 0 Then IDEjercicioComplementario = String.Empty
                            End If
                        End If
                    End If

                End If

            End If
            drNewRow("Actual") = 1
            dtEjercicios.Rows.Add(drNewRow)

            If Length(IDEjercicioComplementario) > 0 Then
                drNewRow = dtEjercicios.NewRow
                drNewRow("IDEjercicio") = IDEjercicioComplementario
                drNewRow("DigitosAuxiliar") = DigitosAuxiliarComplementario
                drNewRow("ActualTributario") = 1
                dtEjercicios.Rows.Add(drNewRow)
            End If
        End If

        If Length(pIDEjercicioAnterior) > 0 Then
            drNewRow = dtEjercicios.NewRow
            drNewRow("IDEjercicio") = pIDEjercicioAnterior
            dtDatos = objNegEjercicio.SelOnPrimaryKey(pIDEjercicioAnterior)
            If Not IsNothing(dtDatos) AndAlso dtDatos.Rows.Count > 0 Then
                drNewRow("DigitosAuxiliar") = dtDatos.Rows(0)("DigitosAuxiliar")
            End If
            drNewRow("Anterior") = 1
            dtEjercicios.Rows.Add(drNewRow)
        End If

        If Length(pIDEjercicioSiguiente) > 0 Then
            drNewRow = dtEjercicios.NewRow
            drNewRow("IDEjercicio") = pIDEjercicioSiguiente
            dtDatos = objNegEjercicio.SelOnPrimaryKey(pIDEjercicioSiguiente)
            If Not IsNothing(dtDatos) AndAlso dtDatos.Rows.Count > 0 Then
                drNewRow("DigitosAuxiliar") = dtDatos.Rows(0)("DigitosAuxiliar")
            End If
            drNewRow("Siguiente") = 1
            dtEjercicios.Rows.Add(drNewRow)
        End If

        If Not IsNothing(dtEjercicios) AndAlso dtEjercicios.Rows.Count > 0 Then
            Dim frmAltaCContable As New frmAltaCuenta
            frmAltaCContable.Ejercicios = dtEjercicios
            frmAltaCContable.CuentaAlta = strCuentaAlta
            frmAltaCContable.DescCuentaAlta = Strings.Left(strDescCuenta, 99)
            frmAltaCContable.Grupo = blnGrupo
            frmAltaCContable.IDDivisa = IDDivisa
            frmAltaCContable.ShowDialog()
            AltaCuenta = frmAltaCContable.AltaOK
        End If

    End Function


    Public Function AltaCContableEnEjercicios(ByVal pEjercicioActual As String, _
                                           ByVal pIdCContable As String, _
                                           Optional ByVal pDescCuentaContable As String = "", _
                                           Optional ByVal blnGrupo As Boolean = False, _
                                           Optional ByVal IDDivisa As String = "") As Boolean

        Dim r As DataRestriccionesEntidad = GetPermisosEntidad(GetType(PlanContable).Name)
        If r.DenegadoInserccion Then
            ExpertisApp.GenerateMessage("No tiene permisos para dar de alta Cuentas Contables.", MessageBoxButtons.OK, MessageBoxIcon.Information, ExpertisApp.Title)
        Else
            Dim objNegPlanContable As New PlanContable
            Dim strIDEjercicioAnterior As String
            Dim strIDEjercicioSiguiente As String

            'Si la Cuenta Contable introducida no existe se da automaticamente de alta en el Plan Contable
            AltaCContableEnEjercicios = False
            If pEjercicioActual <> String.Empty Then
                Dim objNegEjercicio As New EjercicioContable

                Dim dtEjercicioActual As DataTable = objNegEjercicio.SelOnPrimaryKey(pEjercicioActual)

                If Not IsNothing(dtEjercicioActual) AndAlso dtEjercicioActual.Rows.Count > 0 Then
                    '//Comprobamos si el Ejercicio Anterior está cerrado.
                    If Length(dtEjercicioActual.Rows(0)("IDEjercicioAnterior")) > 0 Then
                        Dim dtEjercicioAnterior As DataTable = objNegEjercicio.SelOnPrimaryKey(dtEjercicioActual.Rows(0)("IDEjercicioAnterior"))
                        If Not IsNothing(dtEjercicioAnterior) AndAlso dtEjercicioAnterior.Rows.Count > 0 Then
                            If Not Nz(dtEjercicioAnterior.Rows(0)("EjercicioCerrado"), False) Then
                                strIDEjercicioAnterior = dtEjercicioActual.Rows(0)("IDEjercicioAnterior")
                            Else
                                strIDEjercicioAnterior = String.Empty
                            End If
                        Else
                            strIDEjercicioAnterior = String.Empty
                        End If
                    Else
                        strIDEjercicioAnterior = String.Empty
                    End If

                    '//Obtenemos el cual es Ejercicio Siguiente y comprobamos si está cerrado.
                    Dim objFilter As New Filter
                    objFilter.Add(New BooleanFilterItem("Predeterminado", True))
                    objFilter.Add(New StringFilterItem("IDEjercicioAnterior", pEjercicioActual))
                    objFilter.Add(New BooleanFilterItem("EjercicioCerrado", False))
                    Dim dtEjerSiguiente As DataTable = objNegEjercicio.Filter(objFilter)
                    If Not IsNothing(dtEjerSiguiente) AndAlso dtEjerSiguiente.Rows.Count > 0 Then
                        strIDEjercicioSiguiente = dtEjerSiguiente.Rows(0)("IDEjercicio")
                    Else
                        strIDEjercicioSiguiente = String.Empty
                    End If

                    '//Miramos si existe la cuenta en los TRES Ejercicios: 
                    '//Si el Ejercicio está cerrado o si ya existe la C.Contable, no tratamos el EjercicioActual.
                    If Not objNegEjercicio.EjercicioCerrado(pEjercicioActual) Then
                        Dim dtCCActual As DataTable = objNegPlanContable.SelOnPrimaryKey(pEjercicioActual, pIdCContable)
                        If Not IsNothing(dtCCActual) AndAlso dtCCActual.Rows.Count > 0 Then pEjercicioActual = String.Empty
                    Else
                        pEjercicioActual = String.Empty
                    End If

                    '//Si el Ejercicio está cerrado o si ya existe la C.Contable, no tratamos el EjercicioAnterior.
                    If strIDEjercicioAnterior <> String.Empty Then
                        Dim dtCCAnterior As DataTable = objNegPlanContable.SelOnPrimaryKey(strIDEjercicioAnterior, pIdCContable)
                        If Not IsNothing(dtCCAnterior) AndAlso dtCCAnterior.Rows.Count > 0 Then strIDEjercicioAnterior = String.Empty
                    End If

                    '//Si el Ejercicio está cerrado o si ya existe la C.Contable, no tratamos el EjercicioSiguiente.
                    If strIDEjercicioSiguiente <> String.Empty Then
                        Dim dtCCSiguiente As DataTable = objNegPlanContable.SelOnPrimaryKey(strIDEjercicioSiguiente, pIdCContable)
                        If Not IsNothing(dtCCSiguiente) AndAlso dtCCSiguiente.Rows.Count > 0 Then strIDEjercicioSiguiente = String.Empty
                    End If

                    '//Si no existe en el EjercicioActual, lo damos de alta.
                    If pEjercicioActual <> String.Empty Then
                        AltaCContableEnEjercicios = AltaCuenta(pEjercicioActual, strIDEjercicioAnterior, _
                                           strIDEjercicioSiguiente, pIdCContable, _
                                           pDescCuentaContable, blnGrupo, IDDivisa)
                    Else
                        AltaCContableEnEjercicios = True
                    End If
                End If
            Else
                ExpertisApp.GenerateMessage("No existe ningún Ejercicio Predeterminado para dar de Alta a una Cuenta.", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Function


    Public Function ValidaCuentaContable(ByVal strCuenta As String, ByVal strEjercicioActual As String, _
                                         Optional ByRef strDescCuenta As String = "", Optional ByVal blnGrupo As Boolean = False, _
                                         Optional ByVal IDDivisa As String = "") As Boolean
        Dim ValidaCuenta As enumCuenta = New EjercicioContable().ValidaCuentaAuxiliar(strEjercicioActual, strCuenta)
        Select Case ValidaCuenta
            Case enumCuenta.cAuxiliar
                ValidaCuentaContable = True
            Case enumCuenta.cNoAuxiliar
                ValidaCuentaContable = False
                ExpertisApp.GenerateMessage("La Cuenta | es incorrecta.", MessageBoxButtons.OK, MessageBoxIcon.Error, strCuenta)
            Case enumCuenta.cNoExisteEnPlan
                If ExpertisApp.GenerateMessage("La cuenta | no existe. ¿Desea crearla?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, strCuenta) = DialogResult.Yes Then
                    If AltaCContableEnEjercicios(strEjercicioActual, strCuenta, strDescCuenta, blnGrupo, IDDivisa) = False Then
                        ValidaCuentaContable = False
                    Else
                        ValidaCuentaContable = True
                    End If
                Else
                    ValidaCuentaContable = False
                End If
            Case enumCuenta.cVacia
                ExpertisApp.GenerateMessage("La Cuenta está vacía.", MessageBoxButtons.OK, MessageBoxIcon.Error)
                ValidaCuentaContable = False
        End Select
    End Function

    Public Function ValidaCuentaContableActualizacion(ByVal strCuenta As String, ByVal strEjercicioActual As String, _
                                         Optional ByRef strDescCuenta As String = "", Optional ByVal blnGrupo As Boolean = False) As Boolean

        Dim ValidaCuenta As enumCuenta = New EjercicioContable().ValidaCuentaAuxiliar(strEjercicioActual, strCuenta)
        Select Case ValidaCuenta
            Case enumCuenta.cAuxiliar
                ValidaCuentaContableActualizacion = True
            Case enumCuenta.cNoAuxiliar
                ValidaCuentaContableActualizacion = False
                ExpertisApp.GenerateMessage("La Cuenta | es incorrecta.", MessageBoxButtons.OK, MessageBoxIcon.Error, strCuenta)
            Case enumCuenta.cNoExisteEnPlan
                If ExpertisApp.GenerateMessage("La cuenta | no existe. ¿Desea crearla?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, strCuenta) = DialogResult.Yes Then
                    If AltaCContableEnEjercicios(strEjercicioActual, strCuenta, strDescCuenta, blnGrupo) = False Then
                        ValidaCuentaContableActualizacion = False
                    Else
                        ValidaCuentaContableActualizacion = True
                    End If
                Else
                    ValidaCuentaContableActualizacion = False
                End If
            Case enumCuenta.cVacia
                ExpertisApp.GenerateMessage("La Cuenta está vacía.", MessageBoxButtons.OK, MessageBoxIcon.Error)
                ValidaCuentaContableActualizacion = False
        End Select
    End Function

End Class
