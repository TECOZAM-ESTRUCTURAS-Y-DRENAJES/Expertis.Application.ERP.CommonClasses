Public Class GridAnaliticaNivel
    Inherits Solmicro.Expertis.Engine.UI.GridMnto
    Private GridEXLayout1 As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
    Private GridEXLayout2 As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
    Private GridEXLayout3 As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
    Private GridEXLayout4 As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
    Private GridEXLayout5 As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout

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
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim Grid_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        CType(Me.UiCommandManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Toolbar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MenuBar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MainPanel.suspendlayout()
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Toolbar
        '
        Me.Toolbar.Size = New System.Drawing.Size(465, 28)
        '
        'MenuBar
        '
        Me.MenuBar.Location = New System.Drawing.Point(0, 28)
        Me.MenuBar.Size = New System.Drawing.Size(544, 26)
        '
        'MainPanel
        '
        Me.MainPanel.Size = New System.Drawing.Size(512, 269)
        '
        'Grid
        '
        Me.Grid.ColumnAutoResize = False
        Me.Grid.DataSource = Nothing
        Grid_DesignTimeLayout.LayoutString = "<GridEXLayoutData><RootTable><GroupCondition /></RootTable></GridEXLayoutData>"
        Me.Grid.DesignTimeLayout = Grid_DesignTimeLayout
        Me.Grid.EntityName = "AnaliticaNivel1"
        Me.Grid.Size = New System.Drawing.Size(512, 269)
        Me.Grid.ViewName = "tbAnaliticaNivel1"
        '
        'GridAnaliticaNivel
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(544, 357)
        Me.EntityName = "AnaliticaNivel1"
        Me.Name = "GridAnaliticaNivel"
        Me.Text = "GridAnaliticaNivel"
        Me.ViewName = "tbAnaliticaNivel1"
        CType(Me.UiCommandManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Toolbar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MenuBar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MainPanel.ResumeLayout(False)
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Variables Privadas"

    Private MIntNiveles, MIntLevelActual As Integer
    Private MIntLenAnalit1, MIntLenAnalit2, MIntLenAnalit3, _
    MIntLenAnalit4, MIntLenAnalit5 As Integer
    Private MBlnNiveles As Boolean = False

#End Region

#Region "Funciones Privadas"

    Private Sub LoadLayouts()
        If MBlnNiveles Then
            GridEXLayout1.LayoutString = "<GridEXLayoutData><RootTable><Columns Collection=""true""><Column0 ID=""IDAnalitica1" & _
           """><Caption>IDAnalitica1</Caption><DataMember>IDAnalitica1</DataMember><Key>IDAna" & _
           "litica1</Key><Position>0</Position><Width>115</Width></Column0><Column1 ID=""Desc" & _
           "Analitica1""><Caption>DescAnalitica1</Caption><DataMember>DescAnalitica1</DataMem" & _
           "ber><Key>DescAnalitica1</Key><Position>1</Position><Width>246</Width></Column1><" & _
           "/Columns><GroupCondition ID="""" /></RootTable></GridEXLayoutData>"
            GridEXLayout2.LayoutString = "<GridEXLayoutData><RootTable><Columns Collection=""true""><Column0 ID=""IDAnalitica1" & _
           """><Caption>IDAnalitica2</Caption><DataMember>IDAnalitica2</DataMember><Key>IDAna" & _
           "litica2</Key><Position>0</Position><Width>115</Width></Column0><Column1 ID=""Desc" & _
           "Analitica2""><Caption>DescAnalitica2</Caption><DataMember>DescAnalitica2</DataMem" & _
           "ber><Key>DescAnalitica1</Key><Position>1</Position><Width>246</Width></Column1><" & _
           "/Columns><GroupCondition ID="""" /></RootTable></GridEXLayoutData>"
            GridEXLayout3.LayoutString = "<GridEXLayoutData><RootTable><Columns Collection=""true""><Column0 ID=""IDAnalitica1" & _
           """><Caption>IDAnalitica3</Caption><DataMember>IDAnalitica3</DataMember><Key>IDAna" & _
           "litica3</Key><Position>0</Position><Width>115</Width></Column0><Column1 ID=""Desc" & _
           "Analitica3""><Caption>DescAnalitica3</Caption><DataMember>DescAnalitica3</DataMem" & _
           "ber><Key>DescAnalitica3</Key><Position>1</Position><Width>246</Width></Column1><" & _
           "/Columns><GroupCondition ID="""" /></RootTable></GridEXLayoutData>"
            GridEXLayout4.LayoutString = "<GridEXLayoutData><RootTable><Columns Collection=""true""><Column0 ID=""IDAnalitica1" & _
           """><Caption>IDAnalitica4</Caption><DataMember>IDAnalitica4</DataMember><Key>IDAna" & _
           "litica4</Key><Position>0</Position><Width>115</Width></Column0><Column1 ID=""Desc" & _
           "Analitica4""><Caption>DescAnalitica4</Caption><DataMember>DescAnalitica4</DataMem" & _
           "ber><Key>DescAnalitica4</Key><Position>1</Position><Width>246</Width></Column1><" & _
           "/Columns><GroupCondition ID="""" /></RootTable></GridEXLayoutData>"
            GridEXLayout5.LayoutString = "<GridEXLayoutData><RootTable><Columns Collection=""true""><Column0 ID=""IDAnalitica1" & _
           """><Caption>IDAnalitica5</Caption><DataMember>IDAnalitica5</DataMember><Key>IDAna" & _
           "litica5</Key><Position>0</Position><Width>115</Width></Column0><Column1 ID=""Desc" & _
           "Analitica5""><Caption>DescAnalitica5</Caption><DataMember>DescAnalitica5</DataMem" & _
           "ber><Key>DescAnalitica5</Key><Position>1</Position><Width>246</Width></Column1><" & _
           "/Columns><GroupCondition ID="""" /></RootTable></GridEXLayoutData>"
        End If
    End Sub

    Private Sub LoadParams()
        MIntNiveles = New Parametro().NivelesDeAnalitica
        If MIntNiveles <> 0 Then
            MBlnNiveles = True
            Dim ClsBE As New BE.DataEngine
            Dim DtAnalit1 As DataTable = ClsBE.GetPrimaryKey("AnaliticaNivel1")
            MIntLenAnalit1 = cnLENGTH_NIVELES_ANALITICA  'DtAnalit1.Columns(0).MaxLength
            Dim DtAnalit2 As DataTable = ClsBE.GetPrimaryKey("AnaliticaNivel2")
            MIntLenAnalit2 = cnLENGTH_NIVELES_ANALITICA  'DtAnalit2.Columns(0).MaxLength
            Dim DtAnalit3 As DataTable = ClsBE.GetPrimaryKey("AnaliticaNivel3")
            MIntLenAnalit3 = cnLENGTH_NIVELES_ANALITICA  'DtAnalit3.Columns(0).MaxLength
            Dim DtAnalit4 As DataTable = ClsBE.GetPrimaryKey("AnaliticaNivel4")
            MIntLenAnalit4 = cnLENGTH_NIVELES_ANALITICA  'DtAnalit4.Columns(0).MaxLength
            Dim DtAnalit5 As DataTable = ClsBE.GetPrimaryKey("AnaliticaNivel5")
            MIntLenAnalit5 = cnLENGTH_NIVELES_ANALITICA  'DtAnalit5.Columns(0).MaxLength
        Else
            ExpertisApp.GenerateMessage("No se pueden configurar niveles de analitica.|El Parámetro no estará creado correctamente o con valor en Nivel 0.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, vbNewLine)
            MBlnNiveles = False
        End If
    End Sub

    Private Sub LoadFormActions()
        If MBlnNiveles Then
            For i As Integer = 1 To MIntNiveles
                Select Case i
                    Case 1
                        Me.FormActions.Add("Analitica Nivel " & i, AddressOf CargarNivel1)
                    Case 2
                        Me.FormActions.Add("Analitica Nivel " & i, AddressOf CargarNivel2)
                    Case 3
                        Me.FormActions.Add("Analitica Nivel " & i, AddressOf CargarNivel3)
                    Case 4
                        Me.FormActions.Add("Analitica Nivel " & i, AddressOf CargarNivel4)
                    Case 5
                        Me.FormActions.Add("Analitica Nivel " & i, AddressOf CargarNivel5)
                End Select
            Next
            'ADDLineaToExecuteActions(Me.UiCommandManager1)
            Me.FormActions.Add("Ver Relaciones", AddressOf CargarRelaciones)
            If MIntNiveles = 1 Then
                Me.UiCommandManager1.Commands("ExecuteActions").Commands("Ver Relaciones").Visible = Janus.Windows.UI.InheritableBoolean.False
            End If
        End If
    End Sub

    Private Sub LoadNeededData(ByVal Level As Integer)
        If MBlnNiveles Then
            MIntLevelActual = Level
            Me.EntityName = "AnaliticaNivel" & MIntLevelActual
            Me.ViewName = "tbAnaliticaNivel" & MIntLevelActual
            Me.Grid.EntityName = "AnaliticaNivel" & MIntLevelActual
            Me.Grid.ViewName = "tbAnaliticaNivel" & MIntLevelActual
            For i As Integer = 1 To MIntNiveles
                Me.UiCommandManager1.Commands("ExecuteActions").Commands("Ver Relaciones").Visible = Janus.Windows.UI.InheritableBoolean.True
                If Me.UiCommandManager1.Commands("ExecuteActions").Commands(i - 1).Text = "Analitica Nivel " & MIntLevelActual Then
                    Me.UiCommandManager1.Commands("ExecuteActions").Commands(i - 1).Checked = Janus.Windows.UI.InheritableBoolean.True
                    If i = MIntNiveles Then
                        Me.UiCommandManager1.Commands("ExecuteActions").Commands("Ver Relaciones").Visible = Janus.Windows.UI.InheritableBoolean.False
                    End If
                Else
                    Me.UiCommandManager1.Commands("ExecuteActions").Commands(i - 1).Checked = Janus.Windows.UI.InheritableBoolean.False
                End If
            Next
            Select Case MIntLevelActual
                Case 1
                    Me.Grid.DesignTimeLayout = GridEXLayout1
                    Me.Grid.Columns("IDAnalitica1").InputMask = New String("A", MIntLenAnalit1)
                Case 2
                    Me.Grid.DesignTimeLayout = GridEXLayout2
                    Me.Grid.Columns("IDAnalitica2").InputMask = New String("A", MIntLenAnalit2)
                Case 3
                    Me.Grid.DesignTimeLayout = GridEXLayout3
                    Me.Grid.Columns("IDAnalitica3").InputMask = New String("A", MIntLenAnalit3)
                Case 4
                    Me.Grid.DesignTimeLayout = GridEXLayout4
                    Me.Grid.Columns("IDAnalitica4").InputMask = New String("A", MIntLenAnalit4)
                Case 5
                    Me.Grid.DesignTimeLayout = GridEXLayout5
                    Me.Grid.Columns("IDAnalitica5").InputMask = New String("A", MIntLenAnalit5)
            End Select
            Me.Requery.InvokeOnClick()
        End If
    End Sub

    Private Sub CargarNivel1()
        LoadNeededData(1)
    End Sub
    Private Sub CargarNivel2()
        LoadNeededData(2)
    End Sub
    Private Sub CargarNivel3()
        LoadNeededData(3)
    End Sub
    Private Sub CargarNivel4()
        LoadNeededData(4)
    End Sub
    Private Sub CargarNivel5()
        LoadNeededData(5)
    End Sub

    Private Sub CargarRelaciones()
        Dim FrmRelaciones As New FrmRelacionesAnaliticaNiveles
        FrmRelaciones.Text = "Relaciones Niveles: " & MIntLevelActual & " - " & MIntLevelActual + 1
        FrmRelaciones.LevelActual = MIntLevelActual
        FrmRelaciones.LoadForm()
    End Sub

#End Region

#Region "Eventos GridAnaliticaNivel"

    Private Sub GridAnaliticaNivel_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Not Me.DesignMode Then
            LoadParams()
            LoadLayouts()
            LoadFormActions()
            LoadNeededData(1)
        End If
    End Sub

    Private Sub Grid_EditingCell(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.EditingCellEventArgs) Handles Grid.EditingCell
        If e.Column.Key = "IDAnalitica" & MIntLevelActual Then
            If Grid.Row <> Grid.newTopRowPosition Then
                e.Cancel = True
            End If
        End If
    End Sub

#End Region

End Class