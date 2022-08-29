Public Class FormularioTexto
    'TODO: ForeColor
    'TODO: Font
    'TODO: CharacterCasing

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
    Friend WithEvents Label1 As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents Label2 As Solmicro.Expertis.Engine.UI.Label
    Private WithEvents advObservaciones As Solmicro.Expertis.Engine.UI.AdvSearch
    Private WithEvents cboEntidad As Solmicro.Expertis.Engine.UI.ComboBox
    Friend WithEvents pnlBotones As Solmicro.Expertis.Engine.UI.Panel
    Public WithEvents pnlEntidad As Solmicro.Expertis.Engine.UI.Panel
    Public WithEvents btnCrearObservacion As Solmicro.Expertis.Engine.UI.Button
    Public WithEvents ButtonCancel As Solmicro.Expertis.Engine.UI.Button
    Public WithEvents ButtonOK As Solmicro.Expertis.Engine.UI.Button
    Public WithEvents TextBox As Solmicro.Expertis.Engine.UI.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim cboEntidad_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormularioTexto))
        Me.pnlBotones = New Solmicro.Expertis.Engine.UI.Panel
        Me.ButtonCancel = New Solmicro.Expertis.Engine.UI.Button
        Me.ButtonOK = New Solmicro.Expertis.Engine.UI.Button
        Me.btnCrearObservacion = New Solmicro.Expertis.Engine.UI.Button
        Me.pnlEntidad = New Solmicro.Expertis.Engine.UI.Panel
        Me.cboEntidad = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.advObservaciones = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.Label2 = New Solmicro.Expertis.Engine.UI.Label
        Me.Label1 = New Solmicro.Expertis.Engine.UI.Label
        Me.TextBox = New Solmicro.Expertis.Engine.UI.TextBox
        Me.pnlBotones.suspendlayout()
        Me.pnlEntidad.suspendlayout()
        CType(Me.cboEntidad, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlBotones
        '
        Me.pnlBotones.Controls.Add(Me.ButtonCancel)
        Me.pnlBotones.Controls.Add(Me.ButtonOK)
        Me.pnlBotones.Controls.Add(Me.btnCrearObservacion)
        Me.pnlBotones.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlBotones.Location = New System.Drawing.Point(0, 237)
        Me.pnlBotones.Name = "pnlBotones"
        Me.pnlBotones.Size = New System.Drawing.Size(493, 54)
        Me.pnlBotones.TabIndex = 0
        '
        'ButtonCancel
        '
        Me.ButtonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.ButtonCancel.Location = New System.Drawing.Point(186, 11)
        Me.ButtonCancel.Name = "ButtonCancel"
        Me.ButtonCancel.Size = New System.Drawing.Size(102, 33)
        Me.ButtonCancel.TabIndex = 17
        Me.ButtonCancel.Text = "Cancelar"
        '
        'ButtonOK
        '
        Me.ButtonOK.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.ButtonOK.Location = New System.Drawing.Point(78, 11)
        Me.ButtonOK.Name = "ButtonOK"
        Me.ButtonOK.Size = New System.Drawing.Size(102, 33)
        Me.ButtonOK.TabIndex = 16
        Me.ButtonOK.Text = "Aceptar"
        '
        'btnCrearObservacion
        '
        Me.btnCrearObservacion.Location = New System.Drawing.Point(293, 11)
        Me.btnCrearObservacion.Name = "btnCrearObservacion"
        Me.btnCrearObservacion.Size = New System.Drawing.Size(120, 33)
        Me.btnCrearObservacion.TabIndex = 13
        Me.btnCrearObservacion.Text = "Crear observación"
        Me.btnCrearObservacion.Visible = False
        '
        'pnlEntidad
        '
        Me.pnlEntidad.Controls.Add(Me.cboEntidad)
        Me.pnlEntidad.Controls.Add(Me.advObservaciones)
        Me.pnlEntidad.Controls.Add(Me.Label2)
        Me.pnlEntidad.Controls.Add(Me.Label1)
        Me.pnlEntidad.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlEntidad.Location = New System.Drawing.Point(0, 0)
        Me.pnlEntidad.Name = "pnlEntidad"
        Me.pnlEntidad.Size = New System.Drawing.Size(493, 39)
        Me.pnlEntidad.TabIndex = 5
        Me.pnlEntidad.Visible = False
        '
        'cboEntidad
        '
        cboEntidad_DesignTimeLayout.LayoutString = resources.GetString("cboEntidad_DesignTimeLayout.LayoutString")
        Me.cboEntidad.DesignTimeLayout = cboEntidad_DesignTimeLayout
        Me.cboEntidad.DisabledBackColor = System.Drawing.Color.White
        Me.cboEntidad.DisplayMember = "Entidad"
        Me.cboEntidad.Location = New System.Drawing.Point(56, 8)
        Me.cboEntidad.Name = "cboEntidad"
        Me.cboEntidad.SelectedIndex = -1
        Me.cboEntidad.SelectedItem = Nothing
        Me.cboEntidad.Size = New System.Drawing.Size(224, 21)
        Me.cboEntidad.TabIndex = 0
        Me.cboEntidad.ValueMember = "Entidad"
        '
        'advObservaciones
        '
        Me.advObservaciones.DisabledBackColor = System.Drawing.Color.White
        Me.advObservaciones.Location = New System.Drawing.Point(376, 8)
        Me.advObservaciones.Name = "advObservaciones"
        Me.advObservaciones.Size = New System.Drawing.Size(112, 23)
        Me.advObservaciones.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(296, 10)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Observación"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(8, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Entidad"
        '
        'TextBox
        '
        Me.TextBox.AcceptsReturn = True
        Me.TextBox.AcceptsTab = True
        Me.TextBox.DisabledBackColor = System.Drawing.Color.White
        Me.TextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBox.Location = New System.Drawing.Point(0, 39)
        Me.TextBox.Multiline = True
        Me.TextBox.Name = "TextBox"
        Me.TextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBox.Size = New System.Drawing.Size(493, 198)
        Me.TextBox.TabIndex = 2
        '
        'FormularioTexto
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(493, 291)
        Me.Controls.Add(Me.TextBox)
        Me.Controls.Add(Me.pnlEntidad)
        Me.Controls.Add(Me.pnlBotones)
        Me.Name = "FormularioTexto"
        Me.Text = "Texto"
        Me.pnlBotones.ResumeLayout(False)
        Me.pnlEntidad.ResumeLayout(False)
        Me.pnlEntidad.PerformLayout()
        CType(Me.cboEntidad, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private mEntidadInicial As String
    Private mReadOnly As Boolean
    Private mLongitudMaxima As Short

#Region " Propiedades "
    Public Property Texto() As String
        Get
            Return TextBox.Text
        End Get
        Set(ByVal Value As String)
            TextBox.Text = Value
        End Set
    End Property

    Public Property EntidadInicial() As String
        Get
            Return mEntidadInicial
        End Get
        Set(ByVal Value As String)
            mEntidadInicial = Value
        End Set
    End Property

    Public Property SoloLectura() As Boolean
        Get
            Return TextBox.ReadOnly
        End Get
        Set(ByVal Value As Boolean)
            mReadOnly = Value
            TextBox.ReadOnly = mReadOnly
            cboEntidad.Enabled = Not mReadOnly
            advObservaciones.Enabled = Not mReadOnly
            btnCrearObservacion.Enabled = Not mReadOnly
        End Set
    End Property

    Public Property LongitudMaxima() As Short
        Get
            Return TextBox.MaxLength
        End Get
        Set(ByVal Value As Short)
            mLongitudMaxima = Value
            TextBox.MaxLength = mLongitudMaxima
        End Set
    End Property

    Public Property CrearObservaciones() As Boolean
        Get
            Return pnlEntidad.Visible
        End Get
        Set(ByVal Value As Boolean)
            btnCrearObservacion.Visible = Value
            pnlEntidad.Visible = Value
        End Set
    End Property

#End Region

    Private Sub FormularioTexto_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If pnlEntidad.Visible Then
            advObservaciones.EntityName = "Observacion"
            advObservaciones.SecondaryDataFields = "IDObservacion"
            Dim dt As DataTable = ExpertisApp.ExecuteTask(Of Object, DataTable)(AddressOf ClienteObservacion.ObtenerEntidades, New Object)
            cboEntidad.SetDataBinding(dt, String.Empty)

            If mEntidadInicial <> "" Then
                cboEntidad.Value = mEntidadInicial
            End If
        Else
            ButtonOK.Location = New Point(142, 11)
            ButtonCancel.Location = New Point(249, 11)
            TextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        End If
    End Sub

    Private Sub btnCrearObservacion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCrearObservacion.Click
        Try
            Dim oObservacion As New Observacion
            Dim dt As DataTable = oObservacion.AddNewForm
            dt.Rows(0)("IDObservacion") = ""
            dt.Rows(0)("DescObservacion") = TextBox.Text
            dt.Rows(0)("Entidad") = cboEntidad.Text
            dt.Rows(0)("ImprimirSiempre") = False
            oObservacion.Update(dt)
            Me.DialogResult = DialogResult.OK

        Catch ex As Exception
            ExpertisApp.GenerateMessage(ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub advObservaciones_SetPredefinedFilter(ByVal sender As Object, ByVal e As Engine.UI.AdvSearchFilterEventArgs) Handles advObservaciones.SetPredefinedFilter
        If cboEntidad.SelectedIndex <> -1 And cboEntidad.Value <> "" Then
            e.Filter.Add(New StringFilterItem("Entidad", FilterOperator.Equal, cboEntidad.Value))
        End If
    End Sub

    Private Sub advObservaciones_SelectionChanged(ByVal sender As Object, ByVal e As Engine.UI.AdvSearchSelectionChangedEventArgs) Handles advObservaciones.SelectionChanged
        If Not e.Selected Is Nothing Then
            If e.Selected.Rows.Count > 0 Then
                If e.Selected.Columns.Contains("DescObservacion") AndAlso _
                    e.Selected.Rows(0)("DescObservacion").ToString.Length > 0 Then
                    If TextBox.Text.Trim <> "" Then
                        TextBox.AppendText(ControlChars.CrLf)
                        TextBox.AppendText(e.Selected.Rows(0)("DescObservacion").ToString())
                    Else
                        TextBox.Text = e.Selected.Rows(0)("DescObservacion".ToString())
                    End If
                    advObservaciones.Text = ""
                End If
            End If
        End If
    End Sub

End Class