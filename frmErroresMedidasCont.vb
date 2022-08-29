Public Class frmErroresMedidasCont
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
    Friend WithEvents GridErrores As Solmicro.Expertis.Engine.UI.Grid
    Friend WithEvents lblErrores As Solmicro.Expertis.Engine.UI.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim GridEXLayout1 As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Me.GridErrores = New Solmicro.Expertis.Engine.UI.Grid
        Me.lblErrores = New Solmicro.Expertis.Engine.UI.Label
        CType(Me.GridErrores, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GridErrores
        '
        Me.GridErrores.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.False
        Me.GridErrores.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.False
        Me.GridErrores.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False
        GridEXLayout1.LayoutString = "<GridEXLayoutData><RootTable><Columns Collection=""true""><Column0 ID=""Contador""><C" & _
        "aption>Contador</Caption><DataMember>Contador</DataMember><EditType>NoEdit</Edit" & _
        "Type><Key>Contador</Key><Position>0</Position></Column0><Column1 ID=""MsgError""><" & _
        "Caption>Descripción del Error</Caption><DataMember>MsgError</DataMember><EditTyp" & _
        "e>NoEdit</EditType><Key>MsgError</Key><Position>1</Position><Width>520</Width></" & _
        "Column1></Columns><GroupCondition ID="""" /><SortKeys Collection=""true""><SortKey0 " & _
        "ID=""SortKey0""><ColIndex>1</ColIndex><SortOrder>Descending</SortOrder></SortKey0>" & _
        "</SortKeys></RootTable></GridEXLayoutData>"
        Me.GridErrores.DesignTimeLayout = GridEXLayout1
        Me.GridErrores.EntityName = Nothing
        Me.GridErrores.Location = New System.Drawing.Point(8, 30)
        Me.GridErrores.Name = "GridErrores"
        Me.GridErrores.PrimaryDataFields = Nothing
        Me.GridErrores.SecondaryDataFields = Nothing
        Me.GridErrores.Size = New System.Drawing.Size(664, 318)
        Me.GridErrores.TabIndex = 0
        Me.GridErrores.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.GridErrores.ViewName = Nothing
        '
        'lblErrores
        '
        Me.lblErrores.Location = New System.Drawing.Point(8, 8)
        Me.lblErrores.Name = "lblErrores"
        Me.lblErrores.Size = New System.Drawing.Size(162, 17)
        Me.lblErrores.TabIndex = 1
        Me.lblErrores.Text = "Contadores no Actualizados"
        '
        'frmErroresMedidasCont
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(682, 357)
        Me.Controls.Add(Me.lblErrores)
        Me.Controls.Add(Me.GridErrores)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmErroresMedidasCont"
        Me.Text = "Errores en Medidas de Contadores"
        CType(Me.GridErrores, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region


    Public Property DataSource() As DataTable
        Get
            Return Me.GridErrores.DataSource
        End Get
        Set(ByVal Value As DataTable)
            Me.GridErrores.DataSource = Value
        End Set
    End Property

End Class
