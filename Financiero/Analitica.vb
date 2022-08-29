Public Class Analitica
    Inherits Solmicro.Expertis.Engine.UI.FormBase

    'Me.jngAnalitica.AdvSearchColumns = New Solmicro.Expertis.Engine.UI.AdvSearchColumns(New Solmicro.Expertis.Engine.UI.AdvSearchColumn() {New Solmicro.Expertis.Engine.UI.AdvSearchColumn("IDCentroCoste", "CentroCoste", "IDCentroCoste", New Solmicro.Expertis.Engine.UI.ASSelectedColumns(New Solmicro.Expertis.Engine.UI.ASSelectedColumn() {New Solmicro.Expertis.Engine.UI.ASSelectedColumn("DescCentroCoste", "DescCentroCoste")}))})

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
    Friend WithEvents BottomPanel As Solmicro.Expertis.Engine.UI.Panel
    Friend WithEvents TopPanel As Solmicro.Expertis.Engine.UI.Panel
    Public WithEvents jngAnalitica As Solmicro.Expertis.Engine.UI.Grid
    Friend WithEvents Label2 As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents Label1 As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents CommandPanel As Solmicro.Expertis.Engine.UI.Panel
    Public WithEvents TopFrame As Solmicro.Expertis.Engine.UI.Frame
    Public WithEvents IdArticulo As Solmicro.Expertis.Engine.UI.TextBox
    Public WithEvents ImporteLinea As Solmicro.Expertis.Engine.UI.NumericTextBox
    Public WithEvents DescArticulo As Solmicro.Expertis.Engine.UI.TextBox
    Public WithEvents TotalFrame As Solmicro.Expertis.Engine.UI.Frame
    Public WithEvents PorcentajeAsignado As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents Diferencia As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents ImporteAsignado As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents UnderLineLabel3 As Solmicro.Expertis.Engine.UI.UnderLineLabel
    Public WithEvents UnderLineLabel2 As Solmicro.Expertis.Engine.UI.UnderLineLabel
    Public WithEvents UnderLineLabel1 As Solmicro.Expertis.Engine.UI.UnderLineLabel
    Public WithEvents ButtonCancel As Solmicro.Expertis.Engine.UI.Button
    Public WithEvents ButtonOK As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents SubGrid As Solmicro.Expertis.Engine.UI.Grid
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim SubGrid_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Analitica))
        Dim jngAnalitica_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Me.BottomPanel = New Solmicro.Expertis.Engine.UI.Panel
        Me.TotalFrame = New Solmicro.Expertis.Engine.UI.Frame
        Me.PorcentajeAsignado = New Solmicro.Expertis.Engine.UI.Label
        Me.Diferencia = New Solmicro.Expertis.Engine.UI.Label
        Me.ImporteAsignado = New Solmicro.Expertis.Engine.UI.Label
        Me.UnderLineLabel3 = New Solmicro.Expertis.Engine.UI.UnderLineLabel
        Me.UnderLineLabel2 = New Solmicro.Expertis.Engine.UI.UnderLineLabel
        Me.UnderLineLabel1 = New Solmicro.Expertis.Engine.UI.UnderLineLabel
        Me.CommandPanel = New Solmicro.Expertis.Engine.UI.Panel
        Me.ButtonCancel = New Solmicro.Expertis.Engine.UI.Button
        Me.ButtonOK = New Solmicro.Expertis.Engine.UI.Button
        Me.SubGrid = New Solmicro.Expertis.Engine.UI.Grid
        Me.TopPanel = New Solmicro.Expertis.Engine.UI.Panel
        Me.jngAnalitica = New Solmicro.Expertis.Engine.UI.Grid
        Me.TopFrame = New Solmicro.Expertis.Engine.UI.Frame
        Me.IdArticulo = New Solmicro.Expertis.Engine.UI.TextBox
        Me.ImporteLinea = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.DescArticulo = New Solmicro.Expertis.Engine.UI.TextBox
        Me.Label2 = New Solmicro.Expertis.Engine.UI.Label
        Me.Label1 = New Solmicro.Expertis.Engine.UI.Label
        Me.BottomPanel.suspendlayout()
        Me.TotalFrame.SuspendLayout()
        Me.CommandPanel.suspendlayout()
        CType(Me.SubGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TopPanel.suspendlayout()
        CType(Me.jngAnalitica, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TopFrame.SuspendLayout()
        Me.SuspendLayout()
        '
        'BottomPanel
        '
        Me.BottomPanel.Controls.Add(Me.TotalFrame)
        Me.BottomPanel.Controls.Add(Me.CommandPanel)
        Me.BottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BottomPanel.Location = New System.Drawing.Point(0, 257)
        Me.BottomPanel.Name = "BottomPanel"
        Me.BottomPanel.Size = New System.Drawing.Size(588, 126)
        Me.BottomPanel.TabIndex = 6
        '
        'TotalFrame
        '
        Me.TotalFrame.Controls.Add(Me.PorcentajeAsignado)
        Me.TotalFrame.Controls.Add(Me.Diferencia)
        Me.TotalFrame.Controls.Add(Me.ImporteAsignado)
        Me.TotalFrame.Controls.Add(Me.UnderLineLabel3)
        Me.TotalFrame.Controls.Add(Me.UnderLineLabel2)
        Me.TotalFrame.Controls.Add(Me.UnderLineLabel1)
        Me.TotalFrame.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TotalFrame.Location = New System.Drawing.Point(0, 0)
        Me.TotalFrame.Name = "TotalFrame"
        Me.TotalFrame.Size = New System.Drawing.Size(588, 66)
        Me.TotalFrame.TabIndex = 7
        Me.TotalFrame.TabStop = False
        '
        'PorcentajeAsignado
        '
        Me.PorcentajeAsignado.Location = New System.Drawing.Point(448, 39)
        Me.PorcentajeAsignado.Name = "PorcentajeAsignado"
        Me.PorcentajeAsignado.Size = New System.Drawing.Size(48, 13)
        Me.PorcentajeAsignado.TabIndex = 8
        Me.PorcentajeAsignado.Text = "85,5 %"
        '
        'Diferencia
        '
        Me.Diferencia.Location = New System.Drawing.Point(279, 39)
        Me.Diferencia.Name = "Diferencia"
        Me.Diferencia.Size = New System.Drawing.Size(46, 13)
        Me.Diferencia.TabIndex = 7
        Me.Diferencia.Text = "254,38"
        '
        'ImporteAsignado
        '
        Me.ImporteAsignado.Location = New System.Drawing.Point(97, 39)
        Me.ImporteAsignado.Name = "ImporteAsignado"
        Me.ImporteAsignado.Size = New System.Drawing.Size(35, 13)
        Me.ImporteAsignado.TabIndex = 6
        Me.ImporteAsignado.Text = "1500"
        '
        'UnderLineLabel3
        '
        Me.UnderLineLabel3.Location = New System.Drawing.Point(406, 15)
        Me.UnderLineLabel3.Name = "UnderLineLabel3"
        Me.UnderLineLabel3.Size = New System.Drawing.Size(129, 14)
        Me.UnderLineLabel3.TabIndex = 5
        Me.UnderLineLabel3.Text = "Porcentaje asignado"
        Me.UnderLineLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'UnderLineLabel2
        '
        Me.UnderLineLabel2.Location = New System.Drawing.Point(220, 15)
        Me.UnderLineLabel2.Name = "UnderLineLabel2"
        Me.UnderLineLabel2.Size = New System.Drawing.Size(162, 14)
        Me.UnderLineLabel2.TabIndex = 4
        Me.UnderLineLabel2.Text = "Diferencia"
        Me.UnderLineLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'UnderLineLabel1
        '
        Me.UnderLineLabel1.Location = New System.Drawing.Point(40, 15)
        Me.UnderLineLabel1.Name = "UnderLineLabel1"
        Me.UnderLineLabel1.Size = New System.Drawing.Size(153, 14)
        Me.UnderLineLabel1.TabIndex = 2
        Me.UnderLineLabel1.Text = "Importe asignado"
        Me.UnderLineLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CommandPanel
        '
        Me.CommandPanel.Controls.Add(Me.ButtonCancel)
        Me.CommandPanel.Controls.Add(Me.ButtonOK)
        Me.CommandPanel.Controls.Add(Me.SubGrid)
        Me.CommandPanel.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.CommandPanel.Location = New System.Drawing.Point(0, 66)
        Me.CommandPanel.Name = "CommandPanel"
        Me.CommandPanel.Size = New System.Drawing.Size(588, 60)
        Me.CommandPanel.TabIndex = 6
        '
        'ButtonCancel
        '
        Me.ButtonCancel.Location = New System.Drawing.Point(307, 12)
        Me.ButtonCancel.Name = "ButtonCancel"
        Me.ButtonCancel.Size = New System.Drawing.Size(102, 33)
        Me.ButtonCancel.TabIndex = 1
        Me.ButtonCancel.Text = "Cancelar"
        '
        'ButtonOK
        '
        Me.ButtonOK.Location = New System.Drawing.Point(189, 12)
        Me.ButtonOK.Name = "ButtonOK"
        Me.ButtonOK.Size = New System.Drawing.Size(102, 33)
        Me.ButtonOK.TabIndex = 0
        Me.ButtonOK.Text = "Aceptar"
        '
        'SubGrid
        '
        Me.SubGrid.CellSelectionMode = Janus.Windows.GridEX.CellSelectionMode.SingleCell
        SubGrid_DesignTimeLayout.LayoutString = resources.GetString("SubGrid_DesignTimeLayout.LayoutString")
        Me.SubGrid.DesignTimeLayout = SubGrid_DesignTimeLayout
        Me.SubGrid.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        Me.SubGrid.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.SubGrid.EntityName = Nothing
        Me.SubGrid.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.SubGrid.Location = New System.Drawing.Point(9, 12)
        Me.SubGrid.Name = "SubGrid"
        Me.SubGrid.PrimaryDataFields = Nothing
        Me.SubGrid.ScrollBars = Janus.Windows.GridEX.ScrollBars.None
        Me.SubGrid.SecondaryDataFields = Nothing
        Me.SubGrid.Size = New System.Drawing.Size(165, 21)
        Me.SubGrid.TabIndex = 9
        Me.SubGrid.ViewName = Nothing
        Me.SubGrid.Visible = False
        '
        'TopPanel
        '
        Me.TopPanel.Controls.Add(Me.jngAnalitica)
        Me.TopPanel.Controls.Add(Me.TopFrame)
        Me.TopPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TopPanel.Location = New System.Drawing.Point(0, 0)
        Me.TopPanel.Name = "TopPanel"
        Me.TopPanel.Size = New System.Drawing.Size(588, 257)
        Me.TopPanel.TabIndex = 7
        '
        'jngAnalitica
        '
        jngAnalitica_DesignTimeLayout.LayoutString = resources.GetString("jngAnalitica_DesignTimeLayout.LayoutString")
        Me.jngAnalitica.DesignTimeLayout = jngAnalitica_DesignTimeLayout
        Me.jngAnalitica.Dock = System.Windows.Forms.DockStyle.Fill
        Me.jngAnalitica.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.jngAnalitica.EntityName = ""
        Me.jngAnalitica.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.jngAnalitica.Location = New System.Drawing.Point(0, 80)
        Me.jngAnalitica.Name = "jngAnalitica"
        Me.jngAnalitica.PrimaryDataFields = ""
        Me.jngAnalitica.SecondaryDataFields = ""
        Me.jngAnalitica.Size = New System.Drawing.Size(588, 177)
        Me.jngAnalitica.TabIndex = 7
        Me.jngAnalitica.Tag = ""
        Me.jngAnalitica.ViewName = ""
        '
        'TopFrame
        '
        Me.TopFrame.Controls.Add(Me.IdArticulo)
        Me.TopFrame.Controls.Add(Me.ImporteLinea)
        Me.TopFrame.Controls.Add(Me.DescArticulo)
        Me.TopFrame.Controls.Add(Me.Label2)
        Me.TopFrame.Controls.Add(Me.Label1)
        Me.TopFrame.Dock = System.Windows.Forms.DockStyle.Top
        Me.TopFrame.Location = New System.Drawing.Point(0, 0)
        Me.TopFrame.Name = "TopFrame"
        Me.TopFrame.Size = New System.Drawing.Size(588, 80)
        Me.TopFrame.TabIndex = 6
        Me.TopFrame.TabStop = False
        Me.TopFrame.Tag = ""
        '
        'IdArticulo
        '
        Me.IdArticulo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TryDataBinding(IdArticulo, New System.Windows.Forms.Binding("Text", Me, "IDArticulo", True))
        Me.IdArticulo.DisabledBackColor = System.Drawing.Color.White
        Me.IdArticulo.Enabled = False
        Me.IdArticulo.Location = New System.Drawing.Point(61, 14)
        Me.IdArticulo.Name = "IdArticulo"
        Me.IdArticulo.Size = New System.Drawing.Size(117, 21)
        Me.IdArticulo.TabIndex = 9
        '
        'ImporteLinea
        '
        Me.ImporteLinea.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TryDataBinding(ImporteLinea, New System.Windows.Forms.Binding("Value", Me, "Importe", True))
        Me.ImporteLinea.DisabledBackColor = System.Drawing.Color.White
        Me.ImporteLinea.Enabled = False
        Me.ImporteLinea.Location = New System.Drawing.Point(61, 46)
        Me.ImporteLinea.Name = "ImporteLinea"
        Me.ImporteLinea.Size = New System.Drawing.Size(117, 21)
        Me.ImporteLinea.TabIndex = 11
        '
        'DescArticulo
        '
        Me.DescArticulo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TryDataBinding(DescArticulo, New System.Windows.Forms.Binding("Text", Me, "DescArticulo", True))
        Me.DescArticulo.DisabledBackColor = System.Drawing.Color.White
        Me.DescArticulo.Enabled = False
        Me.DescArticulo.Location = New System.Drawing.Point(176, 14)
        Me.DescArticulo.Name = "DescArticulo"
        Me.DescArticulo.Size = New System.Drawing.Size(403, 21)
        Me.DescArticulo.TabIndex = 19
        '
        'Label2
        '
        Me.Label2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.Location = New System.Drawing.Point(8, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 12
        Me.Label2.Tag = ""
        Me.Label2.Text = "Importe"
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.Location = New System.Drawing.Point(8, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 13)
        Me.Label1.TabIndex = 10
        Me.Label1.Tag = "IdRec=337;"
        Me.Label1.Text = "Artículo"
        '
        'Analitica
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(588, 383)
        Me.Controls.Add(Me.TopPanel)
        Me.Controls.Add(Me.BottomPanel)
        Me.CreateTransaction = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.HelpButton = False
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Analitica"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Analítica"
        Me.BottomPanel.ResumeLayout(False)
        Me.TotalFrame.ResumeLayout(False)
        Me.TotalFrame.PerformLayout()
        Me.CommandPanel.ResumeLayout(False)
        CType(Me.SubGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TopPanel.ResumeLayout(False)
        CType(Me.jngAnalitica, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TopFrame.ResumeLayout(False)
        Me.TopFrame.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

#End Region


#Region "Variables Privadas"

    Private Const NumericFormatString As String = "#,0.0###"
    Private Const cnLENGTH_NIVELES_ANALITICA As Integer = 3
    Private mQueryOnclose As Boolean
    Private mPendingUpdate As Boolean
    Private mReadOnly As Boolean
    Private mIDLinea As Long
    Private mImporteLinea As Double
    Private mIDMoneda As String
    Private mFecha As Date
    Private mCambioA As Double
    Private mCambioB As Double
    Private mMoneda As MonedaInfo

    Private MIntNiveles As Integer

    Private WithEvents sctIDAnalitica1 As AdvancedSearch
    Private WithEvents sctIDAnalitica2 As AdvancedSearch
    Private WithEvents sctIDAnalitica3 As AdvancedSearch
    Private WithEvents sctIDAnalitica4 As AdvancedSearch
    Private WithEvents sctIDAnalitica5 As AdvancedSearch

#End Region

#Region "Propiedades Publicas"

    Public WriteOnly Property IDMoneda() As String
        Set(ByVal Value As String)
            mIDMoneda = Value
            If Len(mIDMoneda) Then
                Dim m As New Moneda
                Dim StDatos As New Moneda.DatosObtenerMoneda
                StDatos.IDMoneda = mIDMoneda
                mMoneda = ExpertisApp.ExecuteTask(Of Moneda.DatosObtenerMoneda, MonedaInfo)(AddressOf Business.General.Moneda.ObtenerMoneda, StDatos)
            End If
        End Set
    End Property

    Public WriteOnly Property Moneda() As MonedaInfo
        Set(ByVal Value As MonedaInfo)
            mMoneda = Value
        End Set
    End Property

    Public WriteOnly Property Fecha() As Date
        Set(ByVal Value As Date)
            mFecha = Value
        End Set
    End Property

    Public WriteOnly Property CambioA() As Double
        Set(ByVal Value As Double)
            mCambioA = Value
        End Set
    End Property

    Public WriteOnly Property CambioB() As Double
        Set(ByVal Value As Double)
            mCambioB = Value
        End Set
    End Property


    Public WriteOnly Property SoloLectura() As Boolean
        Set(ByVal Value As Boolean)
            mReadOnly = Value
        End Set
    End Property

#End Region

#Region "Funciones Privadas"

    Private Function SumaImporte() As Double
        Dim colImp As GridEXColumn = jngAnalitica.Columns("Importe")
        Dim colImpA As GridEXColumn = jngAnalitica.Columns("ImporteA")
        Dim colImpB As GridEXColumn = jngAnalitica.Columns("ImporteB")

        Dim s As Double = Suma(colImp)
        colImp.DefaultValue = xRound(mImporteLinea - s, mMoneda.NDecimalesImporte)
        colImpA.DefaultValue = colImp.DefaultValue * mCambioA
        colImpB.DefaultValue = colImp.DefaultValue * mCambioB
        Return xRound(s, mMoneda.NDecimalesImporte)
    End Function

    Private Function SumaPorcentaje() As Double
        Dim c As GridEXColumn = jngAnalitica.Columns("Porcentaje")
        Dim s As Double = Suma(c)
        c.DefaultValue = 100 - s
        Return s
    End Function

    Private Function Suma(ByVal c As GridEXColumn) As Double
        Dim t As Double

        'If jngAnalitica.Row = jngAnalitica.newTopRowPosition Then
        '    If IsNumeric(jngAnalitica.GetRow.Cells(c).Value) Then
        '        t = jngAnalitica.GetRow.Cells(c).Value
        '    End If
        'End If
        For Each r As GridEXRow In jngAnalitica.GetRows
            If IsNumeric(r.Cells(c).Value) Then
                t = t + r.Cells(c).Value
            End If
        Next
        Return t
    End Function

    Private Sub Totales()
        Dim dblSuma As Double = SumaImporte()
        Dim dblPorcentaje As Double = SumaPorcentaje()

        ImporteAsignado.Text = Format(dblSuma, NumericFormatString)
        PorcentajeAsignado.Text = Format(dblPorcentaje, NumericFormatString) & " %"

        AparienciaControlDiferencia(Math.Abs(dblSuma) - Math.Abs(mImporteLinea))
    End Sub

    Private Sub AparienciaControlDiferencia(ByVal dif As Double)
        Select Case dif
            Case Is > 0
                Diferencia.ForeColor = System.Drawing.Color.Red
                Diferencia.Text = " + " & Format(dif, NumericFormatString)
            Case Is = 0
                Diferencia.ForeColor = System.Drawing.Color.Blue
                Diferencia.Text = Format(dif, NumericFormatString)
            Case Is < 0
                Diferencia.ForeColor = System.Drawing.Color.Red
                Diferencia.Text = " - " & Format(Math.Abs(dif), NumericFormatString)
        End Select
    End Sub

    Private Sub LoadColumns()
        MIntNiveles = New Parametro().NivelesDeAnalitica
        If MIntNiveles <> EnumNivelesAnalitica.Nivel0 Then
            jngAnalitica.Columns("IDCentroCoste").EditType = EditType.Custom

            SubGrid.Columns("IDAnalitica1").MaxLength = cnLENGTH_NIVELES_ANALITICA
            SubGrid.Columns("IDAnalitica1").InputMask = New String("A", cnLENGTH_NIVELES_ANALITICA)
            SubGrid.Columns("IDAnalitica2").MaxLength = cnLENGTH_NIVELES_ANALITICA
            SubGrid.Columns("IDAnalitica2").InputMask = New String("A", cnLENGTH_NIVELES_ANALITICA)
            SubGrid.Columns("IDAnalitica3").MaxLength = cnLENGTH_NIVELES_ANALITICA
            SubGrid.Columns("IDAnalitica3").InputMask = New String("A", cnLENGTH_NIVELES_ANALITICA)
            SubGrid.Columns("IDAnalitica4").MaxLength = cnLENGTH_NIVELES_ANALITICA
            SubGrid.Columns("IDAnalitica4").InputMask = New String("A", cnLENGTH_NIVELES_ANALITICA)
            SubGrid.Columns("IDAnalitica5").MaxLength = cnLENGTH_NIVELES_ANALITICA
            SubGrid.Columns("IDAnalitica5").InputMask = New String("A", cnLENGTH_NIVELES_ANALITICA)

            Select Case MIntNiveles
                Case 1
                    SubGrid.Columns("IDAnalitica2").Visible = False : SubGrid.Columns("IDAnalitica2").EditType = EditType.NoEdit : SubGrid.Columns("IDAnalitica2").ButtonStyle = ButtonStyle.NoButton
                    SubGrid.Columns("IDAnalitica3").Visible = False : SubGrid.Columns("IDAnalitica3").EditType = EditType.NoEdit : SubGrid.Columns("IDAnalitica3").ButtonStyle = ButtonStyle.NoButton
                    SubGrid.Columns("IDAnalitica4").Visible = False : SubGrid.Columns("IDAnalitica4").EditType = EditType.NoEdit : SubGrid.Columns("IDAnalitica4").ButtonStyle = ButtonStyle.NoButton
                    SubGrid.Columns("IDAnalitica5").Visible = False : SubGrid.Columns("IDAnalitica5").EditType = EditType.NoEdit : SubGrid.Columns("IDAnalitica5").ButtonStyle = ButtonStyle.NoButton
                Case 2
                    SubGrid.Columns("IDAnalitica3").Visible = False : SubGrid.Columns("IDAnalitica3").EditType = EditType.NoEdit : SubGrid.Columns("IDAnalitica3").ButtonStyle = ButtonStyle.NoButton
                    SubGrid.Columns("IDAnalitica4").Visible = False : SubGrid.Columns("IDAnalitica4").EditType = EditType.NoEdit : SubGrid.Columns("IDAnalitica4").ButtonStyle = ButtonStyle.NoButton
                    SubGrid.Columns("IDAnalitica5").Visible = False : SubGrid.Columns("IDAnalitica5").EditType = EditType.NoEdit : SubGrid.Columns("IDAnalitica5").ButtonStyle = ButtonStyle.NoButton
                Case 3
                    SubGrid.Columns("IDAnalitica4").Visible = False : SubGrid.Columns("IDAnalitica4").EditType = EditType.NoEdit : SubGrid.Columns("IDAnalitica4").ButtonStyle = ButtonStyle.NoButton
                    SubGrid.Columns("IDAnalitica5").Visible = False : SubGrid.Columns("IDAnalitica5").EditType = EditType.NoEdit : SubGrid.Columns("IDAnalitica5").ButtonStyle = ButtonStyle.NoButton
                Case 4
                    SubGrid.Columns("IDAnalitica5").Visible = False : SubGrid.Columns("IDAnalitica5").EditType = EditType.NoEdit : SubGrid.Columns("IDAnalitica5").ButtonStyle = ButtonStyle.NoButton
            End Select

            jngAnalitica.Columns("IDCentroCoste").Width = MIntNiveles * 80
        Else
            jngAnalitica.Columns("IDCentroCoste").EditType = EditType.TextBox
            jngAnalitica.AdvSearchColumns.Add("CentroCosteAnalitica", "IDCentroCoste", "IDCentroCoste")
            Dim AssCol As New Engine.UI.ASSelectedColumn("DescCentroCoste", "DescCentroCoste")
            jngAnalitica.AdvSearchColumns(0).SelectedColumns.Add(AssCol)
            Dim AdvIcon As New Icon(Engine.UI.Resources.AdvSearchIcon, 16, 16)
            jngAnalitica.Columns("IDCentroCoste").ButtonStyle = ButtonStyle.Image
            jngAnalitica.Columns("IDCentroCoste").ButtonImage = AdvIcon.ToBitmap
            jngAnalitica.Columns("IDCentroCoste").Width = 100
        End If
    End Sub

    Private Function CalcularIDCoste() As String
        Dim StrIDCoste As String = String.Empty
        Dim IntCuenta As Integer = 0
        For i As Integer = 1 To MIntNiveles
            If Length(SubGrid.GetValue("IDAnalitica" & i)) = 0 Then
                IntCuenta += 1
            End If
        Next
        If IntCuenta = MIntNiveles Then
            StrIDCoste = String.Empty
        Else
            For j As Integer = 1 To MIntNiveles
                If Length(SubGrid.GetValue("IDAnalitica" & j)) = 0 Then
                    SubGrid.SetValue("IDAnalitica" & j, New String("@", MIntNiveles))
                End If
                jngAnalitica.SetValue("IDAnalitica" & j, SubGrid.GetValue("IDAnalitica" & j))
                StrIDCoste &= SubGrid.GetValue("IDAnalitica" & j)
            Next
        End If
        Return StrIDCoste
    End Function

    Private Sub LoadAdvSearchSettings()
        If MIntNiveles <> CInt(EnumNivelesAnalitica.Nivel0) Then
            Dim AdvIcon As New Icon(Engine.UI.Resources.AdvSearchIcon, 16, 16)
            sctIDAnalitica1 = New AdvancedSearch
            sctIDAnalitica1.EntityName = "AnaliticaNivel1"
            SubGrid.Columns("IDAnalitica1").ButtonImage = AdvIcon.ToBitmap

            Dim f As Filter
            sctIDAnalitica2 = New AdvancedSearch
            Dim dtR12 As DataTable = New AnaliticaR12().Filter(f, , "TOP 1 *")
            If Not dtR12 Is Nothing AndAlso dtR12.Rows.Count > 0 Then
                sctIDAnalitica2.EntityName = "AnaliticaR12"
                sctIDAnalitica2.ViewName = "vFrmAnaliticaR12"
            Else
                sctIDAnalitica2.EntityName = "AnaliticaNivel2"
            End If
            SubGrid.Columns("IDAnalitica2").ButtonImage = AdvIcon.ToBitmap

            sctIDAnalitica3 = New AdvancedSearch
            Dim dtR23 As DataTable = New AnaliticaR23().Filter(f, , "TOP 1 *")
            If Not dtR23 Is Nothing AndAlso dtR23.Rows.Count > 0 Then
                sctIDAnalitica3.EntityName = "AnaliticaR23"
                sctIDAnalitica3.ViewName = "vFrmAnaliticaR23"
            Else
                sctIDAnalitica3.EntityName = "AnaliticaNivel3"
            End If
            SubGrid.Columns("IDAnalitica3").ButtonImage = AdvIcon.ToBitmap

            sctIDAnalitica4 = New AdvancedSearch
            Dim dtR34 As DataTable = New AnaliticaR34().Filter(f, , "TOP 1 *")
            If Not dtR34 Is Nothing AndAlso dtR34.Rows.Count > 0 Then
                sctIDAnalitica4.EntityName = "AnaliticaR34"
                sctIDAnalitica4.ViewName = "vFrmAnaliticaR34"
            Else
                sctIDAnalitica4.EntityName = "AnaliticaNivel4"
            End If
            SubGrid.Columns("IDAnalitica4").ButtonImage = AdvIcon.ToBitmap

            sctIDAnalitica5 = New AdvancedSearch
            Dim dtR45 As DataTable = New AnaliticaR45().Filter(f, , "TOP 1 *")
            If Not dtR45 Is Nothing AndAlso dtR45.Rows.Count > 0 Then
                sctIDAnalitica5.EntityName = "AnaliticaR45"
                sctIDAnalitica5.ViewName = "vFrmAnaliticaR45"
            Else
                sctIDAnalitica5.EntityName = "AnaliticaNivel5"
            End If
            SubGrid.Columns("IDAnalitica5").ButtonImage = AdvIcon.ToBitmap
        End If
    End Sub

    Private Sub ComprobarIDCoste()
        Dim ClsCoste As New CentroCosteAnalitica
        Dim DtCoste As DataTable
        Dim DtCosteFinal As DataTable = ClsCoste.AddNew
        Dim DtGrid As DataTable = jngAnalitica.DataSource

        For Each Dr As DataRow In DtGrid.Select
            DtCoste = ClsCoste.SelOnPrimaryKey(Dr("IDCentroCoste"))
            If DtCoste Is Nothing OrElse DtCoste.Rows.Count = 0 Then
                Dim DrNew As DataRow = DtCosteFinal.NewRow
                DrNew("IDCentroCoste") = Dr("IDCentroCoste")
                'DrNew("DescCentroCoste") = "Desc. Centro: " & Dr("IDCentroCoste")
                'If MIntNiveles >= 1 Then
                '    DrNew("IDAnalitica1") = DrNew("IDCentroCoste").Substring(0, cnLENGTH_NIVELES_ANALITICA)
                'End If
                'If MIntNiveles >= 2 Then
                '    DrNew("IDAnalitica2") = DrNew("IDCentroCoste").Substring(cnLENGTH_NIVELES_ANALITICA, cnLENGTH_NIVELES_ANALITICA)
                'End If
                'If MIntNiveles >= 3 Then
                '    DrNew("IDAnalitica3") = DrNew("IDCentroCoste").Substring((2 * cnLENGTH_NIVELES_ANALITICA), cnLENGTH_NIVELES_ANALITICA)
                'End If
                'If MIntNiveles >= 4 Then
                '    DrNew("IDAnalitica4") = DrNew("IDCentroCoste").Substring((3 * cnLENGTH_NIVELES_ANALITICA), cnLENGTH_NIVELES_ANALITICA)
                'End If
                'If MIntNiveles >= 5 Then
                '    DrNew("IDAnalitica5") = DrNew("IDCentroCoste").Substring((4 * cnLENGTH_NIVELES_ANALITICA), cnLENGTH_NIVELES_ANALITICA)
                'End If
                DrNew("IDCentroCoste") = Dr("IDCentroCoste")
                Dim strDescCentroCoste As String
                If MIntNiveles >= 1 Then
                    DrNew("IDAnalitica1") = DrNew("IDCentroCoste").Substring(0, NegocioGeneral.cnLENGTH_NIVELES_ANALITICA)
                    Dim ClsAnalitica As New AnaliticaNivel1
                    Dim DtAnalitica As DataTable = ClsAnalitica.SelOnPrimaryKey(DrNew("IDAnalitica1"))
                    If DtAnalitica.Rows.Count > 0 Then
                        strDescCentroCoste = DtAnalitica.Rows(0)("DescAnalitica1")
                    End If
                End If
                If MIntNiveles >= 2 Then
                    DrNew("IDAnalitica2") = DrNew("IDCentroCoste").Substring(NegocioGeneral.cnLENGTH_NIVELES_ANALITICA, NegocioGeneral.cnLENGTH_NIVELES_ANALITICA)
                    Dim ClsAnalitica As New AnaliticaNivel2
                    Dim DtAnalitica As DataTable = ClsAnalitica.SelOnPrimaryKey(DrNew("IDAnalitica2"))
                    If DtAnalitica.Rows.Count > 0 Then
                        strDescCentroCoste = strDescCentroCoste & " - " & DtAnalitica.Rows(0)("DescAnalitica2")
                    End If
                End If
                If MIntNiveles >= 3 Then
                    DrNew("IDAnalitica3") = DrNew("IDCentroCoste").Substring((2 * NegocioGeneral.cnLENGTH_NIVELES_ANALITICA), NegocioGeneral.cnLENGTH_NIVELES_ANALITICA)
                    Dim ClsAnalitica As New AnaliticaNivel3
                    Dim DtAnalitica As DataTable = ClsAnalitica.SelOnPrimaryKey(DrNew("IDAnalitica3"))
                    If DtAnalitica.Rows.Count > 0 Then
                        strDescCentroCoste = strDescCentroCoste & " - " & DtAnalitica.Rows(0)("DescAnalitica3")
                    End If
                End If
                If MIntNiveles >= 4 Then
                    DrNew("IDAnalitica4") = DrNew("IDCentroCoste").Substring((3 * NegocioGeneral.cnLENGTH_NIVELES_ANALITICA), NegocioGeneral.cnLENGTH_NIVELES_ANALITICA)
                    Dim ClsAnalitica As New AnaliticaNivel4
                    Dim DtAnalitica As DataTable = ClsAnalitica.SelOnPrimaryKey(DrNew("IDAnalitica4"))
                    If DtAnalitica.Rows.Count > 0 Then
                        strDescCentroCoste = strDescCentroCoste & " - " & DtAnalitica.Rows(0)("DescAnalitica4")
                    End If
                End If
                If MIntNiveles >= 5 Then
                    DrNew("IDAnalitica5") = DrNew("IDCentroCoste").Substring((4 * NegocioGeneral.cnLENGTH_NIVELES_ANALITICA), NegocioGeneral.cnLENGTH_NIVELES_ANALITICA)
                    Dim ClsAnalitica As New AnaliticaNivel5
                    Dim DtAnalitica As DataTable = ClsAnalitica.SelOnPrimaryKey(DrNew("IDAnalitica5"))
                    If DtAnalitica.Rows.Count > 0 Then
                        strDescCentroCoste = strDescCentroCoste & " - " & DtAnalitica.Rows(0)("DescAnalitica5")
                    End If
                End If
                DrNew("DescCentroCoste") = strDescCentroCoste
                DtCosteFinal.Rows.Add(DrNew)
            End If
        Next
        If DtCosteFinal.Rows.Count > 0 Then ClsCoste.Update(DtCosteFinal)
    End Sub

    Private Function ComprobarIDAnalitica(ByVal IntLevel As Integer) As Boolean
        If IntLevel = 0 Then Exit Function
        Dim ClsObj As BE.BusinessHelper
        Select Case IntLevel
            Case 1
                ClsObj = New AnaliticaNivel1
            Case 2
                ClsObj = New AnaliticaNivel2
            Case 3
                ClsObj = New AnaliticaNivel3
            Case 4
                ClsObj = New AnaliticaNivel4
            Case 5
                ClsObj = New AnaliticaNivel5
        End Select
        Dim DtAnalit As DataTable = ClsObj.SelOnPrimaryKey(SubGrid.GetValue("IDAnalitica" & IntLevel))
        If DtAnalit Is Nothing OrElse DtAnalit.Rows.Count = 0 Then
            ExpertisApp.GenerateMessage("El Código introducido no existe.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            SubGrid.SetValue("IDAnalitica" & IntLevel, String.Empty)
            Return False
        Else
            Dim FilBE As New Filter
            Dim DtBE As DataTable
            Dim ClsBE As New BE.DataEngine
            Select Case IntLevel
                Case 2
                    FilBE.Add("IDAnalitica1", FilterOperator.Equal, SubGrid.GetValue("IDAnalitica1"))
                    FilBE.Add("IDAnalitica2", FilterOperator.Equal, SubGrid.GetValue("IDAnalitica2"))
                    DtBE = ClsBE.Filter("vFrmAnaliticaR12", FilBE)
                    If DtBE Is Nothing OrElse DtBE.Rows.Count = 0 Then
                        DtBE = ClsBE.Filter("vFrmAnaliticaR12", "", "")
                        If Not DtBE Is Nothing AndAlso DtBE.Rows.Count > 0 Then
                            ExpertisApp.GenerateMessage("El Código introducido no existe.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                            SubGrid.SetValue("IDAnalitica" & IntLevel, String.Empty)
                            Return False
                        End If
                    End If
                Case 3
                    FilBE.Add("IDAnalitica2", FilterOperator.Equal, SubGrid.GetValue("IDAnalitica2"))
                    FilBE.Add("IDAnalitica3", FilterOperator.Equal, SubGrid.GetValue("IDAnalitica3"))
                    DtBE = ClsBE.Filter("vFrmAnaliticaR23", FilBE)
                    If DtBE Is Nothing OrElse DtBE.Rows.Count = 0 Then
                        DtBE = ClsBE.Filter("vFrmAnaliticaR23", "", "")
                        If Not DtBE Is Nothing AndAlso DtBE.Rows.Count > 0 Then
                            ExpertisApp.GenerateMessage("El Código introducido no existe.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                            SubGrid.SetValue("IDAnalitica" & IntLevel, String.Empty)
                            Return False
                        End If
                    End If
                Case 4
                    FilBE.Add("IDAnalitica3", FilterOperator.Equal, SubGrid.GetValue("IDAnalitica3"))
                    FilBE.Add("IDAnalitica4", FilterOperator.Equal, SubGrid.GetValue("IDAnalitica4"))
                    DtBE = ClsBE.Filter("vFrmAnaliticaR34", FilBE)
                    If DtBE Is Nothing OrElse DtBE.Rows.Count = 0 Then
                        DtBE = ClsBE.Filter("vFrmAnaliticaR34", "", "")
                        If Not DtBE Is Nothing AndAlso DtBE.Rows.Count > 0 Then
                            ExpertisApp.GenerateMessage("El Código introducido no existe.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                            SubGrid.SetValue("IDAnalitica" & IntLevel, String.Empty)
                            Return False
                        End If
                    End If
                Case 5
                    FilBE.Add("IDAnalitica4", FilterOperator.Equal, SubGrid.GetValue("IDAnalitica4"))
                    FilBE.Add("IDAnalitica5", FilterOperator.Equal, SubGrid.GetValue("IDAnalitica5"))
                    DtBE = ClsBE.Filter("vFrmAnaliticaR45", FilBE)
                    If DtBE Is Nothing OrElse DtBE.Rows.Count = 0 Then
                        DtBE = ClsBE.Filter("vFrmAnaliticaR45", "", "")
                        If Not DtBE Is Nothing AndAlso DtBE.Rows.Count > 0 Then
                            ExpertisApp.GenerateMessage("El Código introducido no existe.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                            SubGrid.SetValue("IDAnalitica" & IntLevel, String.Empty)
                            Return False
                        End If
                    End If
            End Select
        End If
        Return True
    End Function

    Private Sub BuscarDescripcion(ByVal StrIDCentro As String)
        Dim DtCentro As DataTable = New CentroCosteAnalitica().SelOnPrimaryKey(StrIDCentro)
        If Not DtCentro Is Nothing AndAlso DtCentro.Rows.Count > 0 Then
            jngAnalitica.SetValue("DescCentroCoste", DtCentro.Rows(0)("DescCentroCoste"))
        End If
    End Sub

    Private Sub LimpiarIDAnaliticas(ByVal IntLevelDesde As Integer)
        For i As Integer = IntLevelDesde To MIntNiveles
            SubGrid.SetValue("IDAnalitica" & i, String.Empty)
        Next
    End Sub

#End Region

#Region "Eventos Analitica"

#Region "Eventos Formulario"

    Private Sub Form_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ImporteAsignado.Text = String.Empty
        PorcentajeAsignado.Text = String.Empty
        Diferencia.Text = String.Empty
        mFecha = Today

        Me.NavigationFields = jngAnalitica.PrimaryDataFields
        If Not IsNothing(Me.CurrentData) AndAlso Me.CurrentData.Rows.Count Then
            mIDLinea = Me.CurrentData.Rows(0)(jngAnalitica.PrimaryDataFields)
            mImporteLinea = Me.CurrentData.Rows(0)("Importe")

            With jngAnalitica
                Dim c As GridEXColumn
                c = .Columns.Add(.PrimaryDataFields, ColumnType.Text, EditType.TextBox)
                c.Visible = False
                If mReadOnly Then
                    .RowHeaders = InheritableBoolean.False
                    .AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.False
                    .AllowDelete = Janus.Windows.GridEX.InheritableBoolean.False
                    .AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False
                Else
                    .Columns(.PrimaryDataFields).DefaultValue = mIDLinea
                    .Columns("Porcentaje").DefaultValue = 0
                    .Columns("Importe").DefaultValue = 0
                    .Columns("ImporteA").DefaultValue = 0
                    .Columns("ImporteB").DefaultValue = 0
                End If
            End With

            Totales()
        End If
        LoadColumns()
        LoadAdvSearchSettings()
    End Sub

    Private Sub Analitica_BusinessCalling(ByVal sender As Object, ByVal e As Engine.UI.BusinessCallingEventArgs) Handles MyBase.BusinessCalling
        Try
            Dim context As New BusinessData
            e.Data.Context.Clear()
            Select Case e.EntityName
                Case jngAnalitica.EntityName
                    context("ImporteLinea") = Me.CurrentData.Rows(0)("Importe")
                    context("IDMoneda") = mMoneda.ID
                    context("CambioA") = mCambioA
                    context("CambioB") = mCambioB
                    context("Fecha") = mFecha
            End Select
            e.Data.Context = context
        Catch ex As Exception
            e.Cancel = True
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Analitica_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        If mQueryOnclose Then
            e.Cancel = (ExpertisApp.GenerateMessage("¿Desea realmente perder el desglose realizado?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = DialogResult.No)
        End If
    End Sub

#End Region

#Region "Eventos DataGrid"

    Private Sub jngAnalitica_CellValueChanged(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles jngAnalitica.CellValueChanged
        mQueryOnclose = True
        mPendingUpdate = True
    End Sub

    Private Sub jngAnalitica_CellUpdated(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles jngAnalitica.CellUpdated
        If e.Column.Key = "Importe" Or e.Column.Key = "Porcentaje" Then
            Totales()
        End If
    End Sub

    Private Sub jngAnalitica_RecordUpdated(ByVal sender As Object, ByVal e As System.EventArgs) Handles jngAnalitica.RecordUpdated
        Totales()
    End Sub

    Private Sub jngAnalitica_RecordAdded(ByVal sender As Object, ByVal e As System.EventArgs) Handles jngAnalitica.RecordAdded
        Totales()
    End Sub

    Private Sub jngAnalitica_RecordsDeleted(ByVal sender As Object, ByVal e As System.EventArgs) Handles jngAnalitica.RecordsDeleted
        Totales()
        mPendingUpdate = True
    End Sub

    Private Sub jngAnalitica_RowEditCanceled(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles jngAnalitica.RowEditCanceled
        Totales()
    End Sub

    Private Sub jngAnalitica_EditingCell(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.EditingCellEventArgs) Handles jngAnalitica.EditingCell
        If Not mReadOnly Then
            With jngAnalitica
                Select Case e.Column.Key
                    Case "IDCentroCoste"
                        If .Row = Grid.newTopRowPosition Then
                            If MIntNiveles = EnumNivelesAnalitica.Nivel0 Then
                                e.Column.EditType = EditType.TextBox
                                e.Column.ButtonStyle = ButtonStyle.Image
                            Else
                                e.Column.EditType = EditType.Custom
                            End If
                        Else
                            e.Cancel = True
                        End If
                End Select
            End With
        Else
            e.Cancel = True
            e.Column.ButtonStyle = ButtonStyle.NoButton
        End If
    End Sub

    Private Sub jngAnalitica_InitCustomEdit(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.InitCustomEditEventArgs) Handles jngAnalitica.InitCustomEdit
        Dim DtNew As New DataTable
        DtNew.Columns.Add("IDAnalitica1", GetType(String))
        DtNew.Columns.Add("IDAnalitica2", GetType(String))
        DtNew.Columns.Add("IDAnalitica3", GetType(String))
        DtNew.Columns.Add("IDAnalitica4", GetType(String))
        DtNew.Columns.Add("IDAnalitica5", GetType(String))

        SubGrid.DataSource = DtNew
        e.EditControl = SubGrid
        SubGrid.Row = Grid.newTopRowPosition

        Dim StrCoste As String = Nz(e.Value, String.Empty)
        If Length(StrCoste) > 0 Then
            Dim IntLenTotal As Integer = 0
            If MIntNiveles >= 1 Then IntLenTotal += cnLENGTH_NIVELES_ANALITICA
            If MIntNiveles >= 2 Then IntLenTotal += cnLENGTH_NIVELES_ANALITICA
            If MIntNiveles >= 3 Then IntLenTotal += cnLENGTH_NIVELES_ANALITICA
            If MIntNiveles >= 4 Then IntLenTotal += cnLENGTH_NIVELES_ANALITICA
            If MIntNiveles = 5 Then IntLenTotal += cnLENGTH_NIVELES_ANALITICA

            If Len(StrCoste) = IntLenTotal Then
                If MIntNiveles >= 1 Then
                    SubGrid.SetValue("IDAnalitica1", StrCoste.Substring(0, cnLENGTH_NIVELES_ANALITICA))
                End If
                If MIntNiveles >= 2 Then
                    SubGrid.SetValue("IDAnalitica2", StrCoste.Substring(cnLENGTH_NIVELES_ANALITICA, cnLENGTH_NIVELES_ANALITICA))
                End If
                If MIntNiveles >= 3 Then
                    SubGrid.SetValue("IDAnalitica3", StrCoste.Substring((2 * cnLENGTH_NIVELES_ANALITICA), cnLENGTH_NIVELES_ANALITICA))
                End If
                If MIntNiveles >= 4 Then
                    SubGrid.SetValue("IDAnalitica4", StrCoste.Substring((3 * cnLENGTH_NIVELES_ANALITICA), cnLENGTH_NIVELES_ANALITICA))
                End If
                If MIntNiveles >= 5 Then
                    SubGrid.SetValue("IDAnalitica5", StrCoste.Substring((4 * cnLENGTH_NIVELES_ANALITICA), cnLENGTH_NIVELES_ANALITICA))
                End If
            End If
        End If
    End Sub

    Private Sub jngAnalitica_EndCustomEdit(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.EndCustomEditEventArgs) Handles jngAnalitica.EndCustomEdit
        Dim StrIDCoste As String = CalcularIDCoste()
        If Len(StrIDCoste) > 0 Then
            e.Value = StrIDCoste
            BuscarDescripcion(e.Value)
        End If
    End Sub

    Private Sub SubGrid_CellValueChanged(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles SubGrid.CellValueChanged
        If (e.Column.Index + 1) >= 0 AndAlso (e.Column.Index + 1) <= 4 Then
            If Len(CStr(SubGrid.GetValue("IDAnalitica" & (e.Column.Index + 1)))) = cnLENGTH_NIVELES_ANALITICA Then
                If ComprobarIDAnalitica(e.Column.Index + 1) Then
                    LimpiarIDAnaliticas(e.Column.Index + 2)
                    If e.Column.Index + 1 = MIntNiveles Then
                        jngAnalitica.Col = 1
                    Else : SubGrid.Col += 1
                    End If
                Else
                    LimpiarIDAnaliticas(e.Column.Index + 2)
                End If
            End If
        Else
            If Len(CStr(SubGrid.GetValue("IDAnalitica5"))) = cnLENGTH_NIVELES_ANALITICA Then
                ComprobarIDAnalitica(e.Column.Index + 1)
                jngAnalitica.Col = 1
            End If
        End If
    End Sub

    Private Sub SubGrid_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles SubGrid.Click
        Dim hit As GridArea
        With SubGrid
            hit = .HitTest()
            If hit = GridArea.CellButton Then
                Dim c As GridEXColumn = .ColumnFromPoint()
                If Not IsNothing(c) Then
                    Select Case c.Key
                        Case "IDAnalitica1"
                            sctIDAnalitica1.Open()
                        Case "IDAnalitica2"
                            sctIDAnalitica2.Open()
                        Case "IDAnalitica3"
                            sctIDAnalitica3.Open()
                        Case "IDAnalitica4"
                            sctIDAnalitica4.Open()
                        Case "IDAnalitica5"
                            sctIDAnalitica5.Open()
                    End Select
                End If
            End If
        End With
    End Sub

    Private Sub SubGrid_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles SubGrid.KeyUp
        If e.KeyCode = Keys.F4 Then
            Select Case SubGrid.Col
                Case SubGrid.Columns("IDAnalitica1").Index
                    sctIDAnalitica1.Open()
                Case SubGrid.Columns("IDAnalitica2").Index
                    sctIDAnalitica2.Open()
                Case SubGrid.Columns("IDAnalitica3").Index
                    sctIDAnalitica3.Open()
                Case SubGrid.Columns("IDAnalitica4").Index
                    sctIDAnalitica4.Open()
                Case SubGrid.Columns("IDAnalitica5").Index
                    sctIDAnalitica5.Open()
            End Select
        End If
    End Sub

    Private Sub SubGrid_AddingRecord(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles SubGrid.AddingRecord
        e.Cancel = True
    End Sub

#End Region

#Region "Eventos Buttons"

    Private Sub ButtonOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonOK.Click
        Dim close As Boolean = True
        Dim dblSumaImporte As Double

        If Not mReadOnly Then
            dblSumaImporte = SumaImporte()
            If dblSumaImporte <> 0 AndAlso dblSumaImporte <> mImporteLinea Then
                close = False
                ExpertisApp.GenerateMessage("El desglose analitico no es del 100%", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Else
                close = True
                mQueryOnclose = False
                If mPendingUpdate Then
                    ComprobarIDCoste()
                    Me.UpdateData()
                End If
            End If
        End If

        If close Then
            mQueryOnclose = False
            Me.Close()
        End If
    End Sub

    Private Sub ButtonCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonCancel.Click
        Me.Close()
    End Sub

#End Region

#Region "Eventos AdvSearch"

    Private Sub sctIDAnalitica1_SelectionChanged(ByVal sender As Object, ByVal e As Engine.UI.AdvSearchSelectionChangedEventArgs) Handles sctIDAnalitica1.SelectionChanged
        SubGrid.SetValue("IDAnalitica1", e.Selected.Rows(0)("IDAnalitica1"))
    End Sub

    Private Sub sctIDAnalitica2_SelectionChanged(ByVal sender As Object, ByVal e As Engine.UI.AdvSearchSelectionChangedEventArgs) Handles sctIDAnalitica2.SelectionChanged
        SubGrid.SetValue("IDAnalitica2", e.Selected.Rows(0)("IDAnalitica2"))
    End Sub

    Private Sub sctIDAnalitica3_SelectionChanged(ByVal sender As Object, ByVal e As Engine.UI.AdvSearchSelectionChangedEventArgs) Handles sctIDAnalitica3.SelectionChanged
        SubGrid.SetValue("IDAnalitica3", e.Selected.Rows(0)("IDAnalitica3"))
    End Sub

    Private Sub sctIDAnalitica4_SelectionChanged(ByVal sender As Object, ByVal e As Engine.UI.AdvSearchSelectionChangedEventArgs) Handles sctIDAnalitica4.SelectionChanged
        SubGrid.SetValue("IDAnalitica4", e.Selected.Rows(0)("IDAnalitica4"))
    End Sub

    Private Sub sctIDAnalitica5_SelectionChanged(ByVal sender As Object, ByVal e As Engine.UI.AdvSearchSelectionChangedEventArgs) Handles sctIDAnalitica5.SelectionChanged
        SubGrid.SetValue("IDAnalitica5", e.Selected.Rows(0)("IDAnalitica5"))
    End Sub

    Private Sub sctIDAnalitica2_SetPredefinedFilter(ByVal sender As Object, ByVal e As Engine.UI.AdvSearchFilterEventArgs) Handles sctIDAnalitica2.SetPredefinedFilter
        If sctIDAnalitica2.EntityName = GetType(AnaliticaR12).Name Then
            If Length(SubGrid.GetValue("IDAnalitica1")) > 0 Then
                e.Filter.Add("IDAnalitica1", FilterOperator.Equal, SubGrid.GetValue("IDAnalitica1"))
            End If
        End If
    End Sub

    Private Sub sctIDAnalitica3_SetPredefinedFilter(ByVal sender As Object, ByVal e As Engine.UI.AdvSearchFilterEventArgs) Handles sctIDAnalitica3.SetPredefinedFilter
        If sctIDAnalitica3.EntityName = GetType(AnaliticaR23).Name Then
            If Length(SubGrid.GetValue("IDAnalitica2")) > 0 Then
                e.Filter.Add("IDAnalitica2", FilterOperator.Equal, SubGrid.GetValue("IDAnalitica2"))
            End If
        End If
    End Sub

    Private Sub sctIDAnalitica4_SetPredefinedFilter(ByVal sender As Object, ByVal e As Engine.UI.AdvSearchFilterEventArgs) Handles sctIDAnalitica4.SetPredefinedFilter
        If sctIDAnalitica4.EntityName = GetType(AnaliticaR34).Name Then
            If Length(SubGrid.GetValue("IDAnalitica3")) > 0 Then
                e.Filter.Add("IDAnalitica3", FilterOperator.Equal, SubGrid.GetValue("IDAnalitica3"))
            End If
        End If
    End Sub

    Private Sub sctIDAnalitica5_SetPredefinedFilter(ByVal sender As Object, ByVal e As Engine.UI.AdvSearchFilterEventArgs) Handles sctIDAnalitica5.SetPredefinedFilter
        If sctIDAnalitica5.EntityName = GetType(AnaliticaR45).Name Then
            If Length(SubGrid.GetValue("IDAnalitica4")) > 0 Then
                e.Filter.Add("IDAnalitica4", FilterOperator.Equal, SubGrid.GetValue("IDAnalitica4"))
            End If
        End If
    End Sub

#End Region

#End Region

End Class