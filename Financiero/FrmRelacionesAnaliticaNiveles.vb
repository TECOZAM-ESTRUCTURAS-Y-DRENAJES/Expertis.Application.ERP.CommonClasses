Public Class FrmRelacionesAnaliticaNiveles
    Inherits Solmicro.Expertis.Engine.UI.FormBase
    Private GridEXLayout1 As New Janus.Windows.GridEX.GridEXLayout
    Private GridEXLayout2 As New Janus.Windows.GridEX.GridEXLayout
    Private GridEXLayout3 As New Janus.Windows.GridEX.GridEXLayout
    Private GridEXLayout4 As New Janus.Windows.GridEX.GridEXLayout

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
    Friend WithEvents FrmRelaciones As Solmicro.Expertis.Engine.UI.Frame
    Friend WithEvents GridRelaciones As Solmicro.Expertis.Engine.UI.Grid
    Friend WithEvents PnlButtons As Solmicro.Expertis.Engine.UI.Panel
    Friend WithEvents BtnCancelar As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents BtnAceptar As Solmicro.Expertis.Engine.UI.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.FrmRelaciones = New Solmicro.Expertis.Engine.UI.Frame
        Me.GridRelaciones = New Solmicro.Expertis.Engine.UI.Grid
        Me.PnlButtons = New Solmicro.Expertis.Engine.UI.Panel
        Me.BtnCancelar = New Solmicro.Expertis.Engine.UI.Button
        Me.BtnAceptar = New Solmicro.Expertis.Engine.UI.Button
        Me.FrmRelaciones.SuspendLayout()
        CType(Me.GridRelaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PnlButtons.suspendlayout()
        Me.SuspendLayout()
        '
        'FrmRelaciones
        '
        Me.FrmRelaciones.Controls.Add(Me.GridRelaciones)
        Me.FrmRelaciones.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FrmRelaciones.Location = New System.Drawing.Point(0, 0)
        Me.FrmRelaciones.Name = "FrmRelaciones"
        Me.FrmRelaciones.Size = New System.Drawing.Size(624, 317)
        Me.FrmRelaciones.TabIndex = 0
        Me.FrmRelaciones.TabStop = False
        Me.FrmRelaciones.Text = "Relaciones"
        '
        'GridRelaciones
        '
        Me.GridRelaciones.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridRelaciones.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        Me.GridRelaciones.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.GridRelaciones.EntityName = Nothing
        Me.GridRelaciones.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.GridRelaciones.Location = New System.Drawing.Point(3, 17)
        Me.GridRelaciones.Name = "GridRelaciones"
        Me.GridRelaciones.PrimaryDataFields = Nothing
        Me.GridRelaciones.SecondaryDataFields = Nothing
        Me.GridRelaciones.Size = New System.Drawing.Size(618, 297)
        Me.GridRelaciones.TabIndex = 0
        Me.GridRelaciones.ViewName = Nothing
        '
        'PnlButtons
        '
        Me.PnlButtons.Controls.Add(Me.BtnCancelar)
        Me.PnlButtons.Controls.Add(Me.BtnAceptar)
        Me.PnlButtons.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PnlButtons.Location = New System.Drawing.Point(0, 317)
        Me.PnlButtons.Name = "PnlButtons"
        Me.PnlButtons.Size = New System.Drawing.Size(624, 48)
        Me.PnlButtons.TabIndex = 1
        '
        'BtnCancelar
        '
        Me.BtnCancelar.Location = New System.Drawing.Point(320, 8)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(88, 32)
        Me.BtnCancelar.TabIndex = 1
        Me.BtnCancelar.Text = "&Cancelar"
        '
        'BtnAceptar
        '
        Me.BtnAceptar.Location = New System.Drawing.Point(216, 8)
        Me.BtnAceptar.Name = "BtnAceptar"
        Me.BtnAceptar.Size = New System.Drawing.Size(88, 32)
        Me.BtnAceptar.TabIndex = 0
        Me.BtnAceptar.Text = "&Aceptar"
        '
        'FrmRelacionesAnaliticaNiveles
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(624, 365)
        Me.Controls.Add(Me.FrmRelaciones)
        Me.Controls.Add(Me.PnlButtons)
        Me.HelpButton = False
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmRelacionesAnaliticaNiveles"
        Me.NavigationFields = ""
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Relaciones"
        Me.FrmRelaciones.ResumeLayout(False)
        CType(Me.GridRelaciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PnlButtons.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region


#Region "Variables Privadas / Propiedades Públicas"

    Private MIntLevelActual As Integer
    Private MBlnUpdate As Boolean

    Public WriteOnly Property LevelActual() As Integer
        Set(ByVal Value As Integer)
            MIntLevelActual = Value
        End Set
    End Property

#End Region

#Region "Funciones Privadas"

    Private Sub LoadLayouts()
        GridEXLayout1.LayoutString = "<GridEXLayoutData><RootTable><Columns Collection=""true""><Column0 ID=""IDAnalitica1" & _
        """><ButtonStyle>Image</ButtonStyle><Caption>IDAnalitica1</Caption><DataMember>IDA" & _
        "nalitica1</DataMember><Key>IDAnalitica1</Key><Position>0</Position></Column0><Co" & _
        "lumn1 ID=""DescAnalitica1""><Caption>DescAnalitica1</Caption><DataMember>DescAnali" & _
        "tica1</DataMember><width>200</width><EditType>NoEdit</EditType><Key>DescAnalitica1</Key><Position>" & _
        "1</Position></Column1><Column2 ID=""IDAnalitica2""><ButtonStyle>Image</ButtonStyle" & _
        "><Caption>IDAnalitica2</Caption><DataMember>IDAnalitica2</DataMember><Key>IDAnal" & _
        "itica2</Key><Position>2</Position></Column2><Column3 ID=""DescAnalitica2""><Captio" & _
        "n>DescAnalitica2</Caption><DataMember>DescAnalitica2</DataMember><width>200</width><EditType>NoEdi" & _
        "t</EditType><Key>DescAnalitica2</Key><Position>3</Position></Column3></Columns><" & _
        "GroupCondition ID="""" /></RootTable></GridEXLayoutData>"
        GridEXLayout2.LayoutString = "<GridEXLayoutData><RootTable><Columns Collection=""true""><Column0 ID=""IDAnalitica2" & _
        """><ButtonStyle>Image</ButtonStyle><Caption>IDAnalitica2</Caption><DataMember>IDA" & _
        "nalitica2</DataMember><Key>IDAnalitica2</Key><Position>0</Position></Column0><Co" & _
        "lumn1 ID=""DescAnalitica2""><Caption>DescAnalitica2</Caption><DataMember>DescAnali" & _
        "tica2</DataMember><width>200</width><EditType>NoEdit</EditType><Key>DescAnalitica2</Key><Position>" & _
        "1</Position></Column1><Column2 ID=""IDAnalitica3""><ButtonStyle>Image</ButtonStyle" & _
        "><Caption>IDAnalitica3</Caption><DataMember>IDAnalitica3</DataMember><Key>IDAnal" & _
        "itica3</Key><Position>2</Position></Column2><Column3 ID=""DescAnalitica3""><Captio" & _
        "n>DescAnalitica3</Caption><DataMember>DescAnalitica3</DataMember><width>200</width><EditType>NoEdi" & _
        "t</EditType><Key>DescAnalitica3</Key><Position>3</Position></Column3></Columns><" & _
        "GroupCondition ID="""" /></RootTable></GridEXLayoutData>"
        GridEXLayout3.LayoutString = "<GridEXLayoutData><RootTable><Columns Collection=""true""><Column0 ID=""IDAnalitica3" & _
        """><ButtonStyle>Image</ButtonStyle><Caption>IDAnalitica3</Caption><DataMember>IDA" & _
        "nalitica3</DataMember><Key>IDAnalitica3</Key><Position>0</Position></Column0><Co" & _
        "lumn1 ID=""DescAnalitica3""><Caption>DescAnalitica3</Caption><DataMember>DescAnali" & _
        "tica3</DataMember><width>200</width><EditType>NoEdit</EditType><Key>DescAnalitica3</Key><Position>" & _
        "1</Position></Column1><Column2 ID=""IDAnalitica4""><ButtonStyle>Image</ButtonStyle" & _
        "><Caption>IDAnalitica4</Caption><DataMember>IDAnalitica4</DataMember><Key>IDAnal" & _
        "itica4</Key><Position>2</Position></Column2><Column3 ID=""DescAnalitica4""><Captio" & _
        "n>DescAnalitica4</Caption><DataMember>DescAnalitica4</DataMember><width>200</width><EditType>NoEdi" & _
        "t</EditType><Key>DescAnalitica4</Key><Position>3</Position></Column3></Columns><" & _
        "GroupCondition ID="""" /></RootTable></GridEXLayoutData>"
        GridEXLayout4.LayoutString = "<GridEXLayoutData><RootTable><Columns Collection=""true""><Column0 ID=""IDAnalitica4" & _
        """><ButtonStyle>Image</ButtonStyle><Caption>IDAnalitica4</Caption><DataMember>IDA" & _
        "nalitica4</DataMember><Key>IDAnalitica4</Key><Position>0</Position></Column0><Co" & _
        "lumn1 ID=""DescAnalitica4""><Caption>DescAnalitica4</Caption><DataMember>DescAnali" & _
        "tica4</DataMember><width>200</width><EditType>NoEdit</EditType><Key>DescAnalitica4</Key><Position>" & _
        "1</Position></Column1><Column2 ID=""IDAnalitica5""><ButtonStyle>Image</ButtonStyle" & _
        "><Caption>IDAnalitica5</Caption><DataMember>IDAnalitica5</DataMember><Key>IDAnal" & _
        "itica5</Key><Position>2</Position></Column2><Column3 ID=""DescAnalitica5""><Captio" & _
        "n>DescAnalitica5</Caption><DataMember>DescAnalitica5</DataMember><width>200</width><EditType>NoEdi" & _
        "t</EditType><Key>DescAnalitica5</Key><Position>3</Position></Column3></Columns><" & _
        "GroupCondition ID="""" /></RootTable></GridEXLayoutData>"
    End Sub

    Public Sub LoadForm()
        Dim DtGrid As New DataTable
        Dim AdvIcon As New Icon(Engine.UI.Resources.AdvSearchIcon, 16, 16)
        LoadLayouts()
        Me.GridRelaciones.EntityName = "AnaliticaR" & MIntLevelActual & MIntLevelActual + 1
        Me.GridRelaciones.ViewName = "vFrmAnaliticaR" & MIntLevelActual & MIntLevelActual + 1
        Select Case MIntLevelActual
            Case 1
                Me.GridRelaciones.DesignTimeLayout = GridEXLayout1
                Dim SelCols As New Expertis.Engine.UI.ASSelectedColumns
                Dim SelCol As New Expertis.Engine.UI.ASSelectedColumn("DescAnalitica1", "DescAnalitica1")
                SelCols.Add(SelCol)
                Me.GridRelaciones.AdvSearchColumns.Add("AnaliticaNivel1", "IDAnalitica1", "IDAnalitica1", SelCols)
                Dim SelCols2 As New Expertis.Engine.UI.ASSelectedColumns
                Dim SelCol2 As New Expertis.Engine.UI.ASSelectedColumn("DescAnalitica2", "DescAnalitica2")
                SelCols2.Add(SelCol2)
                Me.GridRelaciones.AdvSearchColumns.Add("AnaliticaNivel2", "IDAnalitica2", "IDAnalitica2", SelCols2)
            Case 2
                Me.GridRelaciones.DesignTimeLayout = GridEXLayout2
                Dim SelCol As New Expertis.Engine.UI.ASSelectedColumn("DescAnalitica2", "DescAnalitica2")
                Dim SelCols As New Expertis.Engine.UI.ASSelectedColumns
                SelCols.Add(SelCol)
                Me.GridRelaciones.AdvSearchColumns.Add("AnaliticaNivel2", "IDAnalitica2", "IDAnalitica2", SelCols)
                Dim SelCol2 As New Expertis.Engine.UI.ASSelectedColumn("DescAnalitica3", "DescAnalitica3")
                Dim SelCols2 As New Expertis.Engine.UI.ASSelectedColumns
                SelCols2.Add(SelCol2)
                Me.GridRelaciones.AdvSearchColumns.Add("AnaliticaNivel3", "IDAnalitica3", "IDAnalitica3", SelCols2)
            Case 3
                Me.GridRelaciones.DesignTimeLayout = GridEXLayout3
                Dim SelCol As New Expertis.Engine.UI.ASSelectedColumn("DescAnalitica3", "DescAnalitica3")
                Dim SelCols As New Expertis.Engine.UI.ASSelectedColumns
                SelCols.Add(SelCol)
                Me.GridRelaciones.AdvSearchColumns.Add("AnaliticaNivel3", "IDAnalitica3", "IDAnalitica3", SelCols)
                Dim SelCol2 As New Expertis.Engine.UI.ASSelectedColumn("DescAnalitica4", "DescAnalitica4")
                Dim SelCols2 As New Expertis.Engine.UI.ASSelectedColumns
                SelCols2.Add(SelCol2)
                Me.GridRelaciones.AdvSearchColumns.Add("AnaliticaNivel4", "IDAnalitica4", "IDAnalitica4", SelCols2)
            Case 4
                Me.GridRelaciones.DesignTimeLayout = GridEXLayout4
                Dim SelCol As New Expertis.Engine.UI.ASSelectedColumn("DescAnalitica4", "DescAnalitica4")
                Dim SelCols As New Expertis.Engine.UI.ASSelectedColumns
                SelCols.Add(SelCol)
                Me.GridRelaciones.AdvSearchColumns.Add("AnaliticaNivel4", "IDAnalitica4", "IDAnalitica4", SelCols)
                Dim SelCol2 As New Expertis.Engine.UI.ASSelectedColumn("DescAnalitica5", "DescAnalitica5")
                Dim SelCols2 As New Expertis.Engine.UI.ASSelectedColumns
                SelCols2.Add(SelCol2)
                Me.GridRelaciones.AdvSearchColumns.Add("AnaliticaNivel5", "IDAnalitica5", "IDAnalitica5", SelCols2)
        End Select
        DtGrid = New BE.DataEngine().Filter(GridRelaciones.ViewName, Nothing)
        Me.GridRelaciones.DataSource = DtGrid
        Me.GridRelaciones.Columns(0).ButtonImage = AdvIcon.ToBitmap
        Me.GridRelaciones.Columns(1).ButtonImage = AdvIcon.ToBitmap
        Me.ShowDialog()
    End Sub

#End Region

#Region "Eventos FrmRelacionesAnaliticaNiveles"

#Region "Eventos Buttons"

    Private Sub BtnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAceptar.Click
        Select Case MIntLevelActual
            Case 1
                GridRelaciones.EntityName = "AnaliticaR12"
            Case 2
                GridRelaciones.EntityName = "AnaliticaR23"
            Case 3
                GridRelaciones.EntityName = "AnaliticaR34"
            Case 4
                GridRelaciones.EntityName = "AnaliticaR45"
        End Select
        Me.UpdateData()
        Me.Close()
    End Sub

    Private Sub BtnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancelar.Click
        If MBlnUpdate Then
            If ExpertisApp.GenerateMessage("¿Desea cancelar los cambios y Salir?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                Me.Close()
            End If
        Else
            Me.Close()
        End If
    End Sub

#End Region

#Region "Eventos DataGrid"

    Private Sub GridRelaciones_RecordAdded(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridRelaciones.RecordAdded, GridRelaciones.RecordUpdated, GridRelaciones.RecordsDeleted
        MBlnUpdate = True
    End Sub

    Private Sub GridRelaciones_RowEditCanceled(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles GridRelaciones.RowEditCanceled
        MBlnUpdate = False
    End Sub

#End Region

#End Region

End Class