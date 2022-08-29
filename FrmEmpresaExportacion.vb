Public Class FrmEmpresaExportacion
    Inherits Solmicro.Expertis.Engine.UI.FormBase

#Region " Código generado por el Diseñador de Windows Forms "

    Public Sub New()
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent()

        'Agregar cualquier inicialización después de la llamada a InitializeComponent()

    End Sub

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms requiere el siguiente procedimiento
    'Puede modificarse utilizando el Diseñador de Windows Forms. 
    'No lo modifique con el editor de código.
    Friend WithEvents cbxEmpresa As Solmicro.Expertis.Engine.UI.ComboBox
    Friend WithEvents lblEmpresa As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents Panel1 As Solmicro.Expertis.Engine.UI.Panel
    Friend WithEvents cmbCancelar As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents CmbAceptar As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents cbxEjercicio As Solmicro.Expertis.Engine.UI.ComboBox
    Friend WithEvents lblEjercicio As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents rbBorrar As Solmicro.Expertis.Engine.UI.RadioButton
    Friend WithEvents rbMantener As Solmicro.Expertis.Engine.UI.RadioButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim GridEXLayout1 As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim GridEXLayout2 As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Me.cbxEmpresa = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.lblEmpresa = New Solmicro.Expertis.Engine.UI.Label
        Me.Panel1 = New Solmicro.Expertis.Engine.UI.Panel
        Me.cmbCancelar = New Solmicro.Expertis.Engine.UI.Button
        Me.CmbAceptar = New Solmicro.Expertis.Engine.UI.Button
        Me.cbxEjercicio = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.lblEjercicio = New Solmicro.Expertis.Engine.UI.Label
        Me.rbBorrar = New Solmicro.Expertis.Engine.UI.RadioButton
        Me.rbMantener = New Solmicro.Expertis.Engine.UI.RadioButton
        Me.Panel1.suspendlayout()
        Me.SuspendLayout()
        '
        'cbxEmpresa
        '
        GridEXLayout1.LayoutString = "<GridEXLayoutData><RootTable><Columns Collection=""true""><Column0 ID=""IDBaseDatos""" & _
        "><Caption>IDBaseDatos</Caption><DataMember>IDBaseDatos</DataMember><Key>IDBaseDa" & _
        "tos</Key><Position>0</Position><Visible>False</Visible></Column0><Column1 ID=""Ba" & _
        "seDatos""><Caption>Base Datos</Caption><DataMember>DescBaseDatos</DataMember><Key" & _
        ">BaseDatos</Key><Position>1</Position><Width>150</Width></Column1></Columns><Gro" & _
        "upCondition ID="""" /></RootTable><RowWithErrorsFormatStyle><PredefinedStyle>RowWi" & _
        "thErrorsFormatStyle</PredefinedStyle></RowWithErrorsFormatStyle><LinkFormatStyle" & _
        "><PredefinedStyle>LinkFormatStyle</PredefinedStyle></LinkFormatStyle><CardCaptio" & _
        "nFormatStyle><PredefinedStyle>CardCaptionFormatStyle</PredefinedStyle></CardCapt" & _
        "ionFormatStyle><GroupByBoxInfoFormatStyle><PredefinedStyle>GroupByBoxInfoFormatS" & _
        "tyle</PredefinedStyle></GroupByBoxInfoFormatStyle><GroupRowFormatStyle><Predefin" & _
        "edStyle>GroupRowFormatStyle</PredefinedStyle></GroupRowFormatStyle><HeaderFormat" & _
        "Style><PredefinedStyle>HeaderFormatStyle</PredefinedStyle></HeaderFormatStyle><P" & _
        "reviewRowFormatStyle><PredefinedStyle>PreviewRowFormatStyle</PredefinedStyle></P" & _
        "reviewRowFormatStyle><RowFormatStyle><PredefinedStyle>RowFormatStyle</Predefined" & _
        "Style></RowFormatStyle><SelectedFormatStyle><PredefinedStyle>SelectedFormatStyle" & _
        "</PredefinedStyle></SelectedFormatStyle><SelectedInactiveFormatStyle><Predefined" & _
        "Style>SelectedInactiveFormatStyle</PredefinedStyle></SelectedInactiveFormatStyle" & _
        "><WatermarkImage /><BorderStyle>Flat</BorderStyle><FlatBorderColor>125, 159, 190" & _
        "</FlatBorderColor><ControlStyle><ButtonAppearance>Flat</ButtonAppearance></Contr" & _
        "olStyle><VisualStyle>Standard</VisualStyle><AllowEdit>False</AllowEdit><Expandab" & _
        "leGroups>False</ExpandableGroups><GroupByBoxVisible>False</GroupByBoxVisible><Hi" & _
        "deSelection>Highlight</HideSelection></GridEXLayoutData>"
        Me.cbxEmpresa.DesignTimeLayout = GridEXLayout1
        Me.cbxEmpresa.Location = New System.Drawing.Point(95, 15)
        Me.cbxEmpresa.Name = "cbxEmpresa"
        Me.cbxEmpresa.SelectedIndex = -1
        Me.cbxEmpresa.SelectedItem = Nothing
        Me.cbxEmpresa.Size = New System.Drawing.Size(172, 21)
        Me.cbxEmpresa.TabIndex = 0
        Me.cbxEmpresa.Value = Nothing
        '
        'lblEmpresa
        '
        Me.lblEmpresa.Location = New System.Drawing.Point(29, 15)
        Me.lblEmpresa.Name = "lblEmpresa"
        Me.lblEmpresa.Size = New System.Drawing.Size(54, 17)
        Me.lblEmpresa.TabIndex = 52
        Me.lblEmpresa.Tag = "IdRec=55249;"
        Me.lblEmpresa.Text = "Empresa"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.cmbCancelar)
        Me.Panel1.Controls.Add(Me.CmbAceptar)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 123)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(313, 36)
        Me.Panel1.TabIndex = 51
        '
        'cmbCancelar
        '
        Me.cmbCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmbCancelar.Location = New System.Drawing.Point(160, 2)
        Me.cmbCancelar.Name = "cmbCancelar"
        Me.cmbCancelar.Size = New System.Drawing.Size(94, 29)
        Me.cmbCancelar.TabIndex = 3
        Me.cmbCancelar.Text = "Cancelar"
        '
        'CmbAceptar
        '
        Me.CmbAceptar.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.CmbAceptar.Location = New System.Drawing.Point(60, 2)
        Me.CmbAceptar.Name = "CmbAceptar"
        Me.CmbAceptar.Size = New System.Drawing.Size(94, 29)
        Me.CmbAceptar.TabIndex = 2
        Me.CmbAceptar.Text = "Aceptar"
        '
        'cbxEjercicio
        '
        GridEXLayout2.LayoutString = "<GridEXLayoutData><RootTable><Columns Collection=""true""><Column0 ID=""IDEjercicio""" & _
        "><Caption>Ejercicio</Caption><DataMember>IDEjercicio</DataMember><Key>IDEjercici" & _
        "o</Key><Position>0</Position></Column0><Column1 ID=""DescEjercicio""><Caption>Desc" & _
        "ripción</Caption><DataMember>DescEjercicio</DataMember><Key>DescEjercicio</Key><" & _
        "Position>1</Position></Column1></Columns><GroupCondition ID="""" /></RootTable><Ro" & _
        "wWithErrorsFormatStyle><PredefinedStyle>RowWithErrorsFormatStyle</PredefinedStyl" & _
        "e></RowWithErrorsFormatStyle><LinkFormatStyle><PredefinedStyle>LinkFormatStyle</" & _
        "PredefinedStyle></LinkFormatStyle><CardCaptionFormatStyle><PredefinedStyle>CardC" & _
        "aptionFormatStyle</PredefinedStyle></CardCaptionFormatStyle><GroupByBoxInfoForma" & _
        "tStyle><PredefinedStyle>GroupByBoxInfoFormatStyle</PredefinedStyle></GroupByBoxI" & _
        "nfoFormatStyle><GroupRowFormatStyle><PredefinedStyle>GroupRowFormatStyle</Predef" & _
        "inedStyle></GroupRowFormatStyle><HeaderFormatStyle><PredefinedStyle>HeaderFormat" & _
        "Style</PredefinedStyle></HeaderFormatStyle><PreviewRowFormatStyle><PredefinedSty" & _
        "le>PreviewRowFormatStyle</PredefinedStyle></PreviewRowFormatStyle><RowFormatStyl" & _
        "e><PredefinedStyle>RowFormatStyle</PredefinedStyle></RowFormatStyle><SelectedFor" & _
        "matStyle><PredefinedStyle>SelectedFormatStyle</PredefinedStyle></SelectedFormatS" & _
        "tyle><SelectedInactiveFormatStyle><PredefinedStyle>SelectedInactiveFormatStyle</" & _
        "PredefinedStyle></SelectedInactiveFormatStyle><WatermarkImage /><BorderStyle>Fla" & _
        "t</BorderStyle><FlatBorderColor>125, 159, 190</FlatBorderColor><ControlStyle><Bu" & _
        "ttonAppearance>Flat</ButtonAppearance></ControlStyle><VisualStyle>Standard</Visu" & _
        "alStyle><AllowEdit>False</AllowEdit><ExpandableGroups>False</ExpandableGroups><G" & _
        "roupByBoxVisible>False</GroupByBoxVisible><HideSelection>Highlight</HideSelectio" & _
        "n></GridEXLayoutData>"
        Me.cbxEjercicio.DesignTimeLayout = GridEXLayout2
        Me.cbxEjercicio.Location = New System.Drawing.Point(95, 40)
        Me.cbxEjercicio.Name = "cbxEjercicio"
        Me.cbxEjercicio.SelectedIndex = -1
        Me.cbxEjercicio.SelectedItem = Nothing
        Me.cbxEjercicio.Size = New System.Drawing.Size(172, 21)
        Me.cbxEjercicio.TabIndex = 1
        Me.cbxEjercicio.Value = Nothing
        '
        'lblEjercicio
        '
        Me.lblEjercicio.Location = New System.Drawing.Point(29, 40)
        Me.lblEjercicio.Name = "lblEjercicio"
        Me.lblEjercicio.Size = New System.Drawing.Size(52, 17)
        Me.lblEjercicio.TabIndex = 54
        Me.lblEjercicio.Tag = ""
        Me.lblEjercicio.Text = "Ejercicio"
        '
        'rbBorrar
        '
        Me.rbBorrar.Location = New System.Drawing.Point(31, 91)
        Me.rbBorrar.Name = "rbBorrar"
        Me.rbBorrar.Size = New System.Drawing.Size(202, 23)
        Me.rbBorrar.TabIndex = 58
        Me.rbBorrar.Text = "Borrar Asientos en Destino"
        '
        'rbMantener
        '
        Me.rbMantener.Checked = True
        Me.rbMantener.Location = New System.Drawing.Point(31, 67)
        Me.rbMantener.Name = "rbMantener"
        Me.rbMantener.Size = New System.Drawing.Size(196, 23)
        Me.rbMantener.TabIndex = 57
        Me.rbMantener.TabStop = True
        Me.rbMantener.Text = "Mantener Asientos en Destino"
        '
        'FrmEmpresaExportacion
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(313, 159)
        Me.Controls.Add(Me.rbBorrar)
        Me.Controls.Add(Me.rbMantener)
        Me.Controls.Add(Me.cbxEjercicio)
        Me.Controls.Add(Me.lblEjercicio)
        Me.Controls.Add(Me.lblEmpresa)
        Me.Controls.Add(Me.cbxEmpresa)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FrmEmpresaExportacion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Datos necesario para la exportación"
        Me.WindowState = System.Windows.Forms.FormWindowState.Normal
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private mstrEmpresa As String
    Private mstrEjercicio As String
    Private blnBorrar As Boolean

#Region " Property's "
    Public Property Empresa() As String
        Get
            Return mstrEmpresa
        End Get
        Set(ByVal Value As String)
            mstrEmpresa = Value
        End Set
    End Property
    Public Property Ejercicio() As String
        Get
            Return mstrEjercicio
        End Get
        Set(ByVal Value As String)
            mstrEjercicio = Value
        End Set
    End Property
    Public ReadOnly Property Borrar() As Boolean
        Get
            Return blnBorrar
        End Get
    End Property
#End Region

    Private Sub FrmEmpresaExportacion_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim dt As DataTable = New Business.General.Comunes().GetBDsEmpresa
        cbxEmpresa.DataSource = dt

        cbxEmpresa.DisplayMember = "DescBaseDatos"
        cbxEmpresa.ValueMember = "IDBaseDatos"
    End Sub

    Private Sub CmbAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbAceptar.Click
        Dim strBaseDatos As String = String.Empty
        If Not IsNothing(cbxEmpresa.SelectedItem) Then
            strBaseDatos = cbxEmpresa.SelectedItem("BaseDatos")
        End If
        If Length(strBaseDatos) > 0 And Length(cbxEjercicio.Text) > 0 Then
            Me.DialogResult = DialogResult.OK
            mstrEmpresa = strBaseDatos
            mstrEjercicio = cbxEjercicio.Text
            If Me.rbBorrar.Checked Then
                If ExpertisApp.GenerateMessage("Todos los Asientos del Ejercicio Destino serán Eliminados. ¿Estas seguro?", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                    blnBorrar = True
                    Me.DialogResult = DialogResult.OK
                    Me.Close()
                Else
                    Me.DialogResult = DialogResult.Cancel
                    Me.Close()
                End If
            Else
                Me.DialogResult = DialogResult.OK
                blnBorrar = False
                Me.Close()
            End If
        Else
            ExpertisApp.GenerateMessage("Es necesario indicar la Empresa y el Ejercicio a la que se quiere hacer la exportación.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub cmbCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbCancelar.Click
        Me.DialogResult = DialogResult.Cancel
        mstrEmpresa = String.Empty
        Me.Close()
    End Sub

    Private Sub FrmEmpresaExportacion_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        Dim strBaseDatos As String = String.Empty
        If Not IsNothing(cbxEmpresa.SelectedItem) Then
            strBaseDatos = cbxEmpresa.SelectedItem("BaseDatos")
        End If
        If (Length(strBaseDatos) = 0 Or Length(cbxEjercicio.Text) = 0) And Me.DialogResult <> DialogResult.Cancel Then e.Cancel = True
    End Sub

    Private Sub cbxEmpresa_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbxEmpresa.ValueChanged
        Dim strBaseDatos As String = String.Empty
        If Not IsNothing(cbxEmpresa.SelectedItem) Then
            strBaseDatos = cbxEmpresa.SelectedItem("BaseDatos")
        End If
        If Length(strBaseDatos) > 0 Then
            Dim dt As DataTable = New Business.General.Comunes().GetEjerciciosEmpresa(strBaseDatos)
            Dim objFilter As New Filter
            objFilter.Clear()
            'No saque el ejercicio actual de la Empresa seleccionada
            If strBaseDatos = mstrEmpresa Then
                objFilter.Add(New StringFilterItem("IdEjercicio", FilterOperator.NotEqual, mstrEjercicio))
            End If
            objFilter.Add(New BooleanFilterItem("VisibleDiario", True))
            dt.DefaultView.RowFilter = objFilter.Compose(New AdoFilterComposer)
            cbxEjercicio.DataSource = dt.DefaultView

            cbxEjercicio.DisplayMember = "IDEjercicio"
            cbxEjercicio.ValueMember = "IDEjercicio"
        Else
            cbxEjercicio.DataSource = Nothing
        End If
    End Sub
End Class
