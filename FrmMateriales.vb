Imports Solmicro.Expertis.Business.Mnto

Public Class FrmMateriales
    Inherits Solmicro.Expertis.Engine.UI.FormBase

#Region " Código generado por el Diseñador de Windows Forms "

    Public Sub New()
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent()

        'Agregar cualquier inicialización después de la llamada a InitializeComponent()
        Me.jngArticulos.RelationMode = RelationMode.NoRelation
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
    Friend WithEvents jngArticulos As Solmicro.Expertis.Engine.UI.Grid
    Friend WithEvents btnAceptar As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents btnCancelar As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents txtIDPreventivo As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents lbltxtIDPreventivo As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents txtDescPreventivo As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents txtDescActivo As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents txtIDActivo As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents lbltxtIDActivo As Solmicro.Expertis.Engine.UI.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim GridEXLayout1 As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmMateriales))
        Me.jngArticulos = New Solmicro.Expertis.Engine.UI.Grid
        Me.txtIDPreventivo = New Solmicro.Expertis.Engine.UI.TextBox
        Me.lbltxtIDPreventivo = New Solmicro.Expertis.Engine.UI.Label
        Me.txtDescPreventivo = New Solmicro.Expertis.Engine.UI.TextBox
        Me.txtDescActivo = New Solmicro.Expertis.Engine.UI.TextBox
        Me.txtIDActivo = New Solmicro.Expertis.Engine.UI.TextBox
        Me.lbltxtIDActivo = New Solmicro.Expertis.Engine.UI.Label
        Me.btnAceptar = New Solmicro.Expertis.Engine.UI.Button
        Me.btnCancelar = New Solmicro.Expertis.Engine.UI.Button
        CType(Me.jngArticulos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'jngArticulos
        '
        Me.jngArticulos.AdvSearchColumns = New Solmicro.Expertis.Engine.UI.AdvSearchColumns(New Solmicro.Expertis.Engine.UI.AdvSearchColumn() {New Solmicro.Expertis.Engine.UI.AdvSearchColumn("IDArticulo", "Articulo", "IDArticulo", New Solmicro.Expertis.Engine.UI.ASSelectedColumns(New Solmicro.Expertis.Engine.UI.ASSelectedColumn() {New Solmicro.Expertis.Engine.UI.ASSelectedColumn("DescArticulo", "DescArticulo")}))})
        GridEXLayout1.LayoutReferences.AddRange(New Janus.Windows.Common.Layouts.JanusLayoutReference() {New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column2.ButtonImage", CType(resources.GetObject("resource"), System.Drawing.Bitmap))})
        GridEXLayout1.LayoutString = "<GridEXLayoutData><RootTable><Columns Collection=""true""><Column0 ID=""IDLineaArtic" & _
        "ulo""><Caption>IDLineaArticulo</Caption><DataMember>IDLineaArticulo</DataMember><" & _
        "Key>IDLineaArticulo</Key><Position>0</Position><TextAlignment>Far</TextAlignment" & _
        "><Visible>False</Visible></Column0><Column1 ID=""IDLineaActivo""><Caption>IDLineaA" & _
        "ctivo</Caption><DataMember>IDLineaActivo</DataMember><Key>IDLineaActivo</Key><Po" & _
        "sition>1</Position><TextAlignment>Far</TextAlignment><Visible>False</Visible></C" & _
        "olumn1><Column2 ID=""IDArticulo""><ButtonImage Reference=""GridEXLayoutData.RootTab" & _
        "le.Columns.Column2.ButtonImage"" /><ButtonStyle>Image</ButtonStyle><Caption>Artíc" & _
        "ulo</Caption><DataMember>IDArticulo</DataMember><Key>IDArticulo</Key><Position>2" & _
        "</Position><TextAlignment>Near</TextAlignment><Width>80</Width></Column2><Column" & _
        "3 ID=""DescArticulo""><Caption>Desc. Artículo</Caption><DataMember>DescArticulo</D" & _
        "ataMember><EditType>NoEdit</EditType><Key>DescArticulo</Key><Position>3</Positio" & _
        "n><TextAlignment>Near</TextAlignment><Width>167</Width></Column3><Column4 ID=""QC" & _
        "antidad""><Caption>Cantidad</Caption><DataMember>QCantidad</DataMember><EditTarge" & _
        "t>Text</EditTarget><FormatString>#,0.0#######</FormatString><Key>QCantidad</Key>" & _
        "<Position>4</Position><TextAlignment>Far</TextAlignment><Width>72</Width><Defaul" & _
        "tValue>1</DefaultValue></Column4><Column5 ID=""Precio""><Caption>Precio</Caption><" & _
        "DataMember>Precio</DataMember><EditTarget>Text</EditTarget><FormatString>#,0.0##" & _
        "#####</FormatString><Key>Precio</Key><Position>5</Position><TextAlignment>Far</T" & _
        "extAlignment><Width>67</Width><DefaultValue>0</DefaultValue></Column5><Column6 I" & _
        "D=""Propios""><Caption>Propios</Caption><ColumnType>CheckBox</ColumnType><DataMemb" & _
        "er>Propios</DataMember><EditType>CheckBox</EditType><Key>Propios</Key><Position>" & _
        "6</Position><TextAlignment>Near</TextAlignment><Width>61</Width><DefaultValue>Tr" & _
        "ue</DefaultValue></Column6></Columns><GroupCondition ID="""" /></RootTable></GridE" & _
        "XLayoutData>"
        Me.jngArticulos.DesignTimeLayout = GridEXLayout1
        Me.jngArticulos.EntityName = ""
        Me.jngArticulos.Location = New System.Drawing.Point(7, 55)
        Me.jngArticulos.Name = "jngArticulos"
        Me.jngArticulos.PrimaryDataFields = "IDLineaArticulo"
        Me.jngArticulos.SecondaryDataFields = "IDLineaArticulo"
        Me.jngArticulos.Size = New System.Drawing.Size(489, 225)
        Me.jngArticulos.TabIndex = 0
        Me.jngArticulos.ViewName = ""
        '
        'txtIDPreventivo
        '
        Me.txtIDPreventivo.Enabled = False
        Me.txtIDPreventivo.Location = New System.Drawing.Point(80, 4)
        Me.txtIDPreventivo.Name = "txtIDPreventivo"
        Me.txtIDPreventivo.ReadOnly = True
        Me.txtIDPreventivo.Size = New System.Drawing.Size(112, 21)
        Me.txtIDPreventivo.TabIndex = 4
        '
        'lbltxtIDPreventivo
        '
        Me.lbltxtIDPreventivo.Location = New System.Drawing.Point(10, 6)
        Me.lbltxtIDPreventivo.Name = "lbltxtIDPreventivo"
        Me.lbltxtIDPreventivo.Size = New System.Drawing.Size(64, 17)
        Me.lbltxtIDPreventivo.TabIndex = 1
        Me.lbltxtIDPreventivo.Text = "Preventivo"
        '
        'txtDescPreventivo
        '
        Me.txtDescPreventivo.Enabled = False
        Me.txtDescPreventivo.Location = New System.Drawing.Point(195, 4)
        Me.txtDescPreventivo.Name = "txtDescPreventivo"
        Me.txtDescPreventivo.ReadOnly = True
        Me.txtDescPreventivo.Size = New System.Drawing.Size(301, 21)
        Me.txtDescPreventivo.TabIndex = 3
        '
        'txtDescActivo
        '
        Me.txtDescActivo.Enabled = False
        Me.txtDescActivo.Location = New System.Drawing.Point(195, 27)
        Me.txtDescActivo.Name = "txtDescActivo"
        Me.txtDescActivo.ReadOnly = True
        Me.txtDescActivo.Size = New System.Drawing.Size(301, 21)
        Me.txtDescActivo.TabIndex = 2
        '
        'txtIDActivo
        '
        Me.txtIDActivo.Enabled = False
        Me.txtIDActivo.Location = New System.Drawing.Point(80, 27)
        Me.txtIDActivo.Name = "txtIDActivo"
        Me.txtIDActivo.ReadOnly = True
        Me.txtIDActivo.Size = New System.Drawing.Size(112, 21)
        Me.txtIDActivo.TabIndex = 1
        '
        'lbltxtIDActivo
        '
        Me.lbltxtIDActivo.Location = New System.Drawing.Point(10, 29)
        Me.lbltxtIDActivo.Name = "lbltxtIDActivo"
        Me.lbltxtIDActivo.Size = New System.Drawing.Size(39, 17)
        Me.lbltxtIDActivo.TabIndex = 5
        Me.lbltxtIDActivo.Text = "Activo"
        '
        'btnAceptar
        '
        Me.btnAceptar.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.btnAceptar.Location = New System.Drawing.Point(151, 288)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(96, 30)
        Me.btnAceptar.TabIndex = 6
        Me.btnAceptar.Text = "Guardar"
        '
        'btnCancelar
        '
        Me.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancelar.Location = New System.Drawing.Point(258, 288)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(96, 30)
        Me.btnCancelar.TabIndex = 7
        Me.btnCancelar.Text = "Cancelar"
        '
        'FrmMateriales
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(504, 325)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.jngArticulos)
        Me.Controls.Add(Me.lbltxtIDPreventivo)
        Me.Controls.Add(Me.lbltxtIDActivo)
        Me.Controls.Add(Me.txtIDPreventivo)
        Me.Controls.Add(Me.txtDescPreventivo)
        Me.Controls.Add(Me.txtDescActivo)
        Me.Controls.Add(Me.txtIDActivo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "FrmMateriales"
        Me.NavigationFields = ""
        Me.Text = "Materiales"
        CType(Me.jngArticulos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region " Propiedades "

    Public Property IDPreventivo() As String
        Get
            Return txtIDPreventivo.Text
        End Get
        Set(ByVal Value As String)
            txtIDPreventivo.Text = Value
        End Set
    End Property
    Public Property DescPreventivo() As String
        Get
            Return txtDescPreventivo.Text
        End Get
        Set(ByVal Value As String)
            txtDescPreventivo.Text = Value
        End Set
    End Property
    Public Property IDActivo() As String
        Get
            Return txtIDActivo.Text
        End Get
        Set(ByVal Value As String)
            txtIDActivo.Text = Value
        End Set
    End Property
    Public Property DescActivo() As String
        Get
            Return txtDescActivo.Text
        End Get
        Set(ByVal Value As String)
            txtDescActivo.Text = Value
        End Set
    End Property

    Private mintIDLineaActivo As Integer
    Public Property IDLineaActivo() As Integer
        Get
            Return mintIDLineaActivo
        End Get
        Set(ByVal Value As Integer)
            mintIDLineaActivo = Value
        End Set
    End Property

#End Region

    Public Overrides ReadOnly Property RequeryRecords() As Engine.RequeryMode
        Get
            Return RequeryMode.AllRecords
        End Get
    End Property

    Private mblnCancel As Boolean

    Public Sub AbrirMateriales()
        With jngArticulos
            .EntityName = "PreventivoMaterial"
            .ViewName = "vFrmMntoPreventivoMateriales"

            .Columns("IDLineaActivo").DefaultValue = IDLineaActivo

            Dim f As New Filter
            f.Add(New NumberFilterItem("IDLineaActivo", FilterOperator.Equal, IDLineaActivo))
            .Filter = f

            Me.ShowDialog()
        End With
    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        '//NOTA: Este try-catch es necesario para que no se cierre la ventan cuando hay un error al hacer el Update.
        Try
            mblnCancel = False
            Me.UpdateData()
        Catch ex As Exception
            mblnCancel = True
            ExpertisApp.GenerateMessage(ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub FrmMateriales_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        e.Cancel = mblnCancel
        mblnCancel = False
    End Sub

End Class

