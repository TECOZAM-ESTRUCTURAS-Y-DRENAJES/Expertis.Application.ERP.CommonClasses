Imports Solmicro.Expertis.Engine.BE

Public Class frmdatostransporte
    Inherits Solmicro.Expertis.Engine.UI.FormBase

    Private _Data As DataRow
    Friend WithEvents lblDestallesEnvio As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents cmbDetalles As Solmicro.Expertis.Engine.UI.ComboBox
    Private FwiIDFormaEnvioOld As String

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
    Friend WithEvents lblfwiAlbaranDesde As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents FwiNumAlbaran As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents FwiConductor As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents LblConductor As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents LbLDNIConductor As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents FwiDNIConductor As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents FwiNContenedor As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents FwiMatricula As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents LblContenedor As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents LbLMatricula As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents FwiVehiculo As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents LblVehiculo As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents FwiPrecinto As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents LblPrecinto As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents Panel1 As Solmicro.Expertis.Engine.UI.Panel
    Friend WithEvents cmdCancelar As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents cmdAceptar As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents LblEmpresa As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents FwiEmpresa As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents Label1 As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents FwiCifTransp As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents lblFwiIDFormaEnvio As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents FwiIDFormaEnvio As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents fwiPesoNetoManual As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents Label3 As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents fwiPesoBrutoManual As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents lblFwiPesoNeto As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents FwiPesoNeto As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents lblFwiPesoBruto As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents FwiPesoBruto As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents lblFwiNContenedores As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents FwiNContenedores As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents lblFwiNoBultos As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents FwiNoBultos As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents chcCreditoCaucion As Solmicro.Expertis.Engine.UI.CheckBox
    Friend WithEvents lblDepartamento As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents Departamento As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents lblSucursal As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents LblRemolque As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents txtRemolque As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents Label2 As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents Sucursal As Solmicro.Expertis.Engine.UI.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim cmbDetalles_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmdatostransporte))
        Me.lblfwiAlbaranDesde = New Solmicro.Expertis.Engine.UI.Label
        Me.FwiNumAlbaran = New Solmicro.Expertis.Engine.UI.TextBox
        Me.FwiConductor = New Solmicro.Expertis.Engine.UI.TextBox
        Me.LblConductor = New Solmicro.Expertis.Engine.UI.Label
        Me.FwiDNIConductor = New Solmicro.Expertis.Engine.UI.TextBox
        Me.LbLDNIConductor = New Solmicro.Expertis.Engine.UI.Label
        Me.FwiNContenedor = New Solmicro.Expertis.Engine.UI.TextBox
        Me.LblContenedor = New Solmicro.Expertis.Engine.UI.Label
        Me.FwiMatricula = New Solmicro.Expertis.Engine.UI.TextBox
        Me.LbLMatricula = New Solmicro.Expertis.Engine.UI.Label
        Me.FwiVehiculo = New Solmicro.Expertis.Engine.UI.TextBox
        Me.LblVehiculo = New Solmicro.Expertis.Engine.UI.Label
        Me.FwiPrecinto = New Solmicro.Expertis.Engine.UI.TextBox
        Me.LblPrecinto = New Solmicro.Expertis.Engine.UI.Label
        Me.Panel1 = New Solmicro.Expertis.Engine.UI.Panel
        Me.cmdCancelar = New Solmicro.Expertis.Engine.UI.Button
        Me.cmdAceptar = New Solmicro.Expertis.Engine.UI.Button
        Me.FwiEmpresa = New Solmicro.Expertis.Engine.UI.TextBox
        Me.LblEmpresa = New Solmicro.Expertis.Engine.UI.Label
        Me.FwiCifTransp = New Solmicro.Expertis.Engine.UI.TextBox
        Me.Label1 = New Solmicro.Expertis.Engine.UI.Label
        Me.lblFwiIDFormaEnvio = New Solmicro.Expertis.Engine.UI.Label
        Me.FwiIDFormaEnvio = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.fwiPesoNetoManual = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.Label3 = New Solmicro.Expertis.Engine.UI.Label
        Me.fwiPesoBrutoManual = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblFwiPesoNeto = New Solmicro.Expertis.Engine.UI.Label
        Me.FwiPesoNeto = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblFwiPesoBruto = New Solmicro.Expertis.Engine.UI.Label
        Me.FwiPesoBruto = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblFwiNContenedores = New Solmicro.Expertis.Engine.UI.Label
        Me.FwiNContenedores = New Solmicro.Expertis.Engine.UI.TextBox
        Me.lblFwiNoBultos = New Solmicro.Expertis.Engine.UI.Label
        Me.FwiNoBultos = New Solmicro.Expertis.Engine.UI.TextBox
        Me.chcCreditoCaucion = New Solmicro.Expertis.Engine.UI.CheckBox
        Me.lblDepartamento = New Solmicro.Expertis.Engine.UI.Label
        Me.Departamento = New Solmicro.Expertis.Engine.UI.TextBox
        Me.lblSucursal = New Solmicro.Expertis.Engine.UI.Label
        Me.Sucursal = New Solmicro.Expertis.Engine.UI.TextBox
        Me.LblRemolque = New Solmicro.Expertis.Engine.UI.Label
        Me.txtRemolque = New Solmicro.Expertis.Engine.UI.TextBox
        Me.Label2 = New Solmicro.Expertis.Engine.UI.Label
        Me.lblDestallesEnvio = New Solmicro.Expertis.Engine.UI.Label
        Me.cmbDetalles = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.Panel1.suspendlayout()
        CType(Me.cmbDetalles, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblfwiAlbaranDesde
        '
        Me.lblfwiAlbaranDesde.Location = New System.Drawing.Point(7, 10)
        Me.lblfwiAlbaranDesde.Name = "lblfwiAlbaranDesde"
        Me.lblfwiAlbaranDesde.Size = New System.Drawing.Size(100, 13)
        Me.lblfwiAlbaranDesde.TabIndex = 8
        Me.lblfwiAlbaranDesde.Tag = "IdRec=5105;"
        Me.lblfwiAlbaranDesde.Text = "Número Albarán"
        '
        'FwiNumAlbaran
        '
        Me.FwiNumAlbaran.DisabledBackColor = System.Drawing.Color.White
        Me.FwiNumAlbaran.Enabled = False
        Me.FwiNumAlbaran.Location = New System.Drawing.Point(114, 6)
        Me.FwiNumAlbaran.Name = "FwiNumAlbaran"
        Me.FwiNumAlbaran.Size = New System.Drawing.Size(120, 21)
        Me.FwiNumAlbaran.TabIndex = 0
        '
        'FwiConductor
        '
        Me.FwiConductor.DisabledBackColor = System.Drawing.Color.White
        Me.FwiConductor.Location = New System.Drawing.Point(114, 104)
        Me.FwiConductor.Name = "FwiConductor"
        Me.FwiConductor.Size = New System.Drawing.Size(349, 21)
        Me.FwiConductor.TabIndex = 5
        '
        'LblConductor
        '
        Me.LblConductor.Location = New System.Drawing.Point(7, 108)
        Me.LblConductor.Name = "LblConductor"
        Me.LblConductor.Size = New System.Drawing.Size(66, 13)
        Me.LblConductor.TabIndex = 10
        Me.LblConductor.Tag = "IdRec=5105;"
        Me.LblConductor.Text = "Conductor"
        '
        'FwiDNIConductor
        '
        Me.FwiDNIConductor.DisabledBackColor = System.Drawing.Color.White
        Me.FwiDNIConductor.Location = New System.Drawing.Point(114, 128)
        Me.FwiDNIConductor.Name = "FwiDNIConductor"
        Me.FwiDNIConductor.Size = New System.Drawing.Size(349, 21)
        Me.FwiDNIConductor.TabIndex = 6
        '
        'LbLDNIConductor
        '
        Me.LbLDNIConductor.Location = New System.Drawing.Point(7, 132)
        Me.LbLDNIConductor.Name = "LbLDNIConductor"
        Me.LbLDNIConductor.Size = New System.Drawing.Size(92, 13)
        Me.LbLDNIConductor.TabIndex = 12
        Me.LbLDNIConductor.Tag = "IdRec=5105;"
        Me.LbLDNIConductor.Text = "DNI Conductor"
        '
        'FwiNContenedor
        '
        Me.FwiNContenedor.DisabledBackColor = System.Drawing.Color.White
        Me.FwiNContenedor.Location = New System.Drawing.Point(114, 200)
        Me.FwiNContenedor.Name = "FwiNContenedor"
        Me.FwiNContenedor.Size = New System.Drawing.Size(349, 21)
        Me.FwiNContenedor.TabIndex = 8
        '
        'LblContenedor
        '
        Me.LblContenedor.Location = New System.Drawing.Point(7, 204)
        Me.LblContenedor.Name = "LblContenedor"
        Me.LblContenedor.Size = New System.Drawing.Size(74, 13)
        Me.LblContenedor.TabIndex = 16
        Me.LblContenedor.Tag = "IdRec=5105;"
        Me.LblContenedor.Text = "Contenedor"
        '
        'FwiMatricula
        '
        Me.FwiMatricula.DisabledBackColor = System.Drawing.Color.White
        Me.FwiMatricula.Location = New System.Drawing.Point(114, 152)
        Me.FwiMatricula.Name = "FwiMatricula"
        Me.FwiMatricula.Size = New System.Drawing.Size(349, 21)
        Me.FwiMatricula.TabIndex = 7
        '
        'LbLMatricula
        '
        Me.LbLMatricula.Location = New System.Drawing.Point(7, 156)
        Me.LbLMatricula.Name = "LbLMatricula"
        Me.LbLMatricula.Size = New System.Drawing.Size(58, 13)
        Me.LbLMatricula.TabIndex = 14
        Me.LbLMatricula.Tag = "IdRec=5105;"
        Me.LbLMatricula.Text = "Matrícula"
        '
        'FwiVehiculo
        '
        Me.FwiVehiculo.DisabledBackColor = System.Drawing.Color.White
        Me.FwiVehiculo.Location = New System.Drawing.Point(114, 248)
        Me.FwiVehiculo.Name = "FwiVehiculo"
        Me.FwiVehiculo.Size = New System.Drawing.Size(349, 21)
        Me.FwiVehiculo.TabIndex = 10
        '
        'LblVehiculo
        '
        Me.LblVehiculo.Location = New System.Drawing.Point(7, 252)
        Me.LblVehiculo.Name = "LblVehiculo"
        Me.LblVehiculo.Size = New System.Drawing.Size(55, 13)
        Me.LblVehiculo.TabIndex = 20
        Me.LblVehiculo.Tag = "IdRec=5105;"
        Me.LblVehiculo.Text = "Vehículo"
        '
        'FwiPrecinto
        '
        Me.FwiPrecinto.DisabledBackColor = System.Drawing.Color.White
        Me.FwiPrecinto.Location = New System.Drawing.Point(114, 224)
        Me.FwiPrecinto.Name = "FwiPrecinto"
        Me.FwiPrecinto.Size = New System.Drawing.Size(349, 21)
        Me.FwiPrecinto.TabIndex = 9
        '
        'LblPrecinto
        '
        Me.LblPrecinto.Location = New System.Drawing.Point(7, 228)
        Me.LblPrecinto.Name = "LblPrecinto"
        Me.LblPrecinto.Size = New System.Drawing.Size(53, 13)
        Me.LblPrecinto.TabIndex = 18
        Me.LblPrecinto.Tag = "IdRec=5105;"
        Me.LblPrecinto.Text = "Precinto"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.cmdCancelar)
        Me.Panel1.Controls.Add(Me.cmdAceptar)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 416)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(473, 41)
        Me.Panel1.TabIndex = 32
        '
        'cmdCancelar
        '
        Me.cmdCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdCancelar.Location = New System.Drawing.Point(239, 7)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(99, 27)
        Me.cmdCancelar.TabIndex = 4
        Me.cmdCancelar.Text = "Cancelar"
        '
        'cmdAceptar
        '
        Me.cmdAceptar.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.cmdAceptar.Location = New System.Drawing.Point(135, 7)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.Size = New System.Drawing.Size(99, 27)
        Me.cmdAceptar.TabIndex = 0
        Me.cmdAceptar.Text = "Aceptar"
        '
        'FwiEmpresa
        '
        Me.FwiEmpresa.DisabledBackColor = System.Drawing.Color.White
        Me.FwiEmpresa.Location = New System.Drawing.Point(114, 56)
        Me.FwiEmpresa.Name = "FwiEmpresa"
        Me.FwiEmpresa.Size = New System.Drawing.Size(349, 21)
        Me.FwiEmpresa.TabIndex = 3
        '
        'LblEmpresa
        '
        Me.LblEmpresa.Location = New System.Drawing.Point(7, 60)
        Me.LblEmpresa.Name = "LblEmpresa"
        Me.LblEmpresa.Size = New System.Drawing.Size(57, 13)
        Me.LblEmpresa.TabIndex = 23
        Me.LblEmpresa.Tag = "IdRec=5105;"
        Me.LblEmpresa.Text = "Empresa"
        '
        'FwiCifTransp
        '
        Me.FwiCifTransp.DisabledBackColor = System.Drawing.Color.White
        Me.FwiCifTransp.Location = New System.Drawing.Point(114, 80)
        Me.FwiCifTransp.Name = "FwiCifTransp"
        Me.FwiCifTransp.Size = New System.Drawing.Size(349, 21)
        Me.FwiCifTransp.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(7, 84)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 13)
        Me.Label1.TabIndex = 25
        Me.Label1.Tag = "IdRec=5105;"
        Me.Label1.Text = "Cif Transportista"
        '
        'lblFwiIDFormaEnvio
        '
        Me.lblFwiIDFormaEnvio.Location = New System.Drawing.Point(7, 34)
        Me.lblFwiIDFormaEnvio.Name = "lblFwiIDFormaEnvio"
        Me.lblFwiIDFormaEnvio.Size = New System.Drawing.Size(78, 13)
        Me.lblFwiIDFormaEnvio.TabIndex = 27
        Me.lblFwiIDFormaEnvio.Tag = ""
        Me.lblFwiIDFormaEnvio.Text = "Forma Envío"
        '
        'FwiIDFormaEnvio
        '
        Me.FwiIDFormaEnvio.DisabledBackColor = System.Drawing.Color.White
        Me.FwiIDFormaEnvio.EntityName = "FormaEnvio"
        Me.FwiIDFormaEnvio.Location = New System.Drawing.Point(114, 30)
        Me.FwiIDFormaEnvio.Name = "FwiIDFormaEnvio"
        Me.FwiIDFormaEnvio.PrimaryDataFields = "IDFormaEnvio"
        Me.FwiIDFormaEnvio.SecondaryDataFields = "IDFormaEnvio"
        Me.FwiIDFormaEnvio.Size = New System.Drawing.Size(88, 23)
        Me.FwiIDFormaEnvio.TabIndex = 1
        Me.FwiIDFormaEnvio.ViewName = "vfrmformaenvio"
        '
        'fwiPesoNetoManual
        '
        Me.fwiPesoNetoManual.DisabledBackColor = System.Drawing.Color.White
        Me.fwiPesoNetoManual.Location = New System.Drawing.Point(114, 392)
        Me.fwiPesoNetoManual.Name = "fwiPesoNetoManual"
        Me.fwiPesoNetoManual.Size = New System.Drawing.Size(112, 21)
        Me.fwiPesoNetoManual.TabIndex = 16
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(7, 348)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 13)
        Me.Label3.TabIndex = 109
        Me.Label3.Tag = ""
        Me.Label3.Text = "Peso Manual"
        '
        'fwiPesoBrutoManual
        '
        Me.fwiPesoBrutoManual.DisabledBackColor = System.Drawing.Color.White
        Me.fwiPesoBrutoManual.Location = New System.Drawing.Point(114, 344)
        Me.fwiPesoBrutoManual.Name = "fwiPesoBrutoManual"
        Me.fwiPesoBrutoManual.Size = New System.Drawing.Size(112, 21)
        Me.fwiPesoBrutoManual.TabIndex = 14
        '
        'lblFwiPesoNeto
        '
        Me.lblFwiPesoNeto.Location = New System.Drawing.Point(7, 372)
        Me.lblFwiPesoNeto.Name = "lblFwiPesoNeto"
        Me.lblFwiPesoNeto.Size = New System.Drawing.Size(64, 13)
        Me.lblFwiPesoNeto.TabIndex = 104
        Me.lblFwiPesoNeto.Tag = "IdRec=4440;"
        Me.lblFwiPesoNeto.Text = "Peso Neto"
        '
        'FwiPesoNeto
        '
        Me.FwiPesoNeto.DisabledBackColor = System.Drawing.Color.White
        Me.FwiPesoNeto.Enabled = False
        Me.FwiPesoNeto.Location = New System.Drawing.Point(114, 368)
        Me.FwiPesoNeto.Name = "FwiPesoNeto"
        Me.FwiPesoNeto.Size = New System.Drawing.Size(112, 21)
        Me.FwiPesoNeto.TabIndex = 15
        '
        'lblFwiPesoBruto
        '
        Me.lblFwiPesoBruto.Location = New System.Drawing.Point(7, 324)
        Me.lblFwiPesoBruto.Name = "lblFwiPesoBruto"
        Me.lblFwiPesoBruto.Size = New System.Drawing.Size(69, 13)
        Me.lblFwiPesoBruto.TabIndex = 107
        Me.lblFwiPesoBruto.Tag = "IdRec=4441;"
        Me.lblFwiPesoBruto.Text = "Peso Bruto"
        '
        'FwiPesoBruto
        '
        Me.FwiPesoBruto.DisabledBackColor = System.Drawing.Color.White
        Me.FwiPesoBruto.Enabled = False
        Me.FwiPesoBruto.Location = New System.Drawing.Point(114, 320)
        Me.FwiPesoBruto.Name = "FwiPesoBruto"
        Me.FwiPesoBruto.Size = New System.Drawing.Size(112, 21)
        Me.FwiPesoBruto.TabIndex = 13
        '
        'lblFwiNContenedores
        '
        Me.lblFwiNContenedores.Location = New System.Drawing.Point(281, 348)
        Me.lblFwiNContenedores.Name = "lblFwiNContenedores"
        Me.lblFwiNContenedores.Size = New System.Drawing.Size(75, 13)
        Me.lblFwiNContenedores.TabIndex = 112
        Me.lblFwiNContenedores.Tag = ""
        Me.lblFwiNContenedores.Text = "Num. Palets"
        '
        'FwiNContenedores
        '
        Me.FwiNContenedores.DisabledBackColor = System.Drawing.Color.White
        Me.FwiNContenedores.Location = New System.Drawing.Point(359, 344)
        Me.FwiNContenedores.Name = "FwiNContenedores"
        Me.FwiNContenedores.Size = New System.Drawing.Size(104, 21)
        Me.FwiNContenedores.TabIndex = 18
        Me.FwiNContenedores.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
        '
        'lblFwiNoBultos
        '
        Me.lblFwiNoBultos.Location = New System.Drawing.Point(281, 324)
        Me.lblFwiNoBultos.Name = "lblFwiNoBultos"
        Me.lblFwiNoBultos.Size = New System.Drawing.Size(76, 13)
        Me.lblFwiNoBultos.TabIndex = 115
        Me.lblFwiNoBultos.Tag = ""
        Me.lblFwiNoBultos.Text = "Num. Bultos"
        '
        'FwiNoBultos
        '
        Me.FwiNoBultos.DisabledBackColor = System.Drawing.Color.White
        Me.FwiNoBultos.Location = New System.Drawing.Point(359, 320)
        Me.FwiNoBultos.Name = "FwiNoBultos"
        Me.FwiNoBultos.Size = New System.Drawing.Size(104, 21)
        Me.FwiNoBultos.TabIndex = 17
        Me.FwiNoBultos.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
        '
        'chcCreditoCaucion
        '
        Me.chcCreditoCaucion.Location = New System.Drawing.Point(286, 368)
        Me.chcCreditoCaucion.Name = "chcCreditoCaucion"
        Me.chcCreditoCaucion.Size = New System.Drawing.Size(120, 23)
        Me.chcCreditoCaucion.TabIndex = 19
        Me.chcCreditoCaucion.Text = "CreditoyCaucion"
        '
        'lblDepartamento
        '
        Me.lblDepartamento.Location = New System.Drawing.Point(7, 276)
        Me.lblDepartamento.Name = "lblDepartamento"
        Me.lblDepartamento.Size = New System.Drawing.Size(89, 13)
        Me.lblDepartamento.TabIndex = 117
        Me.lblDepartamento.Tag = ""
        Me.lblDepartamento.Text = "Departamento"
        '
        'Departamento
        '
        Me.Departamento.DisabledBackColor = System.Drawing.Color.White
        Me.Departamento.Location = New System.Drawing.Point(114, 272)
        Me.Departamento.Name = "Departamento"
        Me.Departamento.Size = New System.Drawing.Size(349, 21)
        Me.Departamento.TabIndex = 11
        '
        'lblSucursal
        '
        Me.lblSucursal.Location = New System.Drawing.Point(7, 300)
        Me.lblSucursal.Name = "lblSucursal"
        Me.lblSucursal.Size = New System.Drawing.Size(56, 13)
        Me.lblSucursal.TabIndex = 119
        Me.lblSucursal.Tag = "IdRec=5105;"
        Me.lblSucursal.Text = "Sucursal"
        '
        'Sucursal
        '
        Me.Sucursal.DisabledBackColor = System.Drawing.Color.White
        Me.Sucursal.Location = New System.Drawing.Point(114, 296)
        Me.Sucursal.Name = "Sucursal"
        Me.Sucursal.Size = New System.Drawing.Size(349, 21)
        Me.Sucursal.TabIndex = 12
        '
        'LblRemolque
        '
        Me.LblRemolque.Location = New System.Drawing.Point(7, 180)
        Me.LblRemolque.Name = "LblRemolque"
        Me.LblRemolque.Size = New System.Drawing.Size(64, 13)
        Me.LblRemolque.TabIndex = 120
        Me.LblRemolque.Tag = "IdRec=8935;"
        Me.LblRemolque.Text = "Remolque"
        '
        'txtRemolque
        '
        Me.txtRemolque.DisabledBackColor = System.Drawing.Color.White
        Me.txtRemolque.Location = New System.Drawing.Point(114, 176)
        Me.txtRemolque.Name = "txtRemolque"
        Me.txtRemolque.Size = New System.Drawing.Size(349, 21)
        Me.txtRemolque.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(7, 396)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(108, 13)
        Me.Label2.TabIndex = 121
        Me.Label2.Tag = ""
        Me.Label2.Text = "Peso Neto Manual"
        '
        'lblDestallesEnvio
        '
        Me.lblDestallesEnvio.Location = New System.Drawing.Point(236, 34)
        Me.lblDestallesEnvio.Name = "lblDestallesEnvio"
        Me.lblDestallesEnvio.Size = New System.Drawing.Size(88, 13)
        Me.lblDestallesEnvio.TabIndex = 122
        Me.lblDestallesEnvio.Text = "Detalles Envio"
        '
        'cmbDetalles
        '
        Me.TryDataBinding(cmbDetalles, New System.Windows.Forms.Binding("Text", Me.cmbDetalles, "Conductor", True))
        cmbDetalles_DesignTimeLayout.LayoutString = resources.GetString("cmbDetalles_DesignTimeLayout.LayoutString")
        Me.cmbDetalles.DesignTimeLayout = cmbDetalles_DesignTimeLayout
        Me.cmbDetalles.DisabledBackColor = System.Drawing.Color.White
        Me.cmbDetalles.EntityName = "FormaEnvioDetalle"
        Me.cmbDetalles.Location = New System.Drawing.Point(330, 29)
        Me.cmbDetalles.Name = "cmbDetalles"
        Me.cmbDetalles.PrimaryDataFields = "IDFormaEnvioDetalle"
        Me.cmbDetalles.SecondaryDataFields = "FormaEnvioDetalle"
        Me.cmbDetalles.SelectedIndex = -1
        Me.cmbDetalles.SelectedItem = Nothing
        Me.cmbDetalles.Size = New System.Drawing.Size(19, 21)
        Me.cmbDetalles.TabIndex = 123
        '
        'frmdatostransporte
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(473, 457)
        Me.Controls.Add(Me.cmbDetalles)
        Me.Controls.Add(Me.lblDestallesEnvio)
        Me.Controls.Add(Me.LblRemolque)
        Me.Controls.Add(Me.txtRemolque)
        Me.Controls.Add(Me.lblSucursal)
        Me.Controls.Add(Me.Sucursal)
        Me.Controls.Add(Me.lblDepartamento)
        Me.Controls.Add(Me.Departamento)
        Me.Controls.Add(Me.chcCreditoCaucion)
        Me.Controls.Add(Me.lblFwiNContenedores)
        Me.Controls.Add(Me.FwiNContenedores)
        Me.Controls.Add(Me.lblFwiNoBultos)
        Me.Controls.Add(Me.FwiNoBultos)
        Me.Controls.Add(Me.fwiPesoNetoManual)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.fwiPesoBrutoManual)
        Me.Controls.Add(Me.lblFwiPesoNeto)
        Me.Controls.Add(Me.FwiPesoNeto)
        Me.Controls.Add(Me.lblFwiPesoBruto)
        Me.Controls.Add(Me.FwiPesoBruto)
        Me.Controls.Add(Me.lblFwiIDFormaEnvio)
        Me.Controls.Add(Me.FwiIDFormaEnvio)
        Me.Controls.Add(Me.FwiCifTransp)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LblEmpresa)
        Me.Controls.Add(Me.LblVehiculo)
        Me.Controls.Add(Me.LblPrecinto)
        Me.Controls.Add(Me.LblContenedor)
        Me.Controls.Add(Me.LbLMatricula)
        Me.Controls.Add(Me.LbLDNIConductor)
        Me.Controls.Add(Me.LblConductor)
        Me.Controls.Add(Me.lblfwiAlbaranDesde)
        Me.Controls.Add(Me.FwiEmpresa)
        Me.Controls.Add(Me.FwiVehiculo)
        Me.Controls.Add(Me.FwiPrecinto)
        Me.Controls.Add(Me.FwiNContenedor)
        Me.Controls.Add(Me.FwiMatricula)
        Me.Controls.Add(Me.FwiDNIConductor)
        Me.Controls.Add(Me.FwiConductor)
        Me.Controls.Add(Me.FwiNumAlbaran)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label2)
        Me.EntityName = "FormaEnvio"
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.HelpButton = False
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmdatostransporte"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Datos relacionados con el Transporte"
        Me.Panel1.ResumeLayout(False)
        CType(Me.cmbDetalles, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Public Sub SetData(ByVal rwAvc As DataRow)

        _Data = rwAvc

        FwiNumAlbaran.Text = _Data("NALBARAN")
        If Not _Data.IsNull("MATRICULA") Then FwiMatricula.Text = _Data("MATRICULA")
        If Not _Data.IsNull("NCONTENEDOR") Then FwiNContenedor.Text = _Data("NCONTENEDOR")
        If Not _Data.IsNull("PRECINTO") Then FwiPrecinto.Text = _Data("PRECINTO")
        If Not _Data.IsNull("VEHICULO") Then FwiVehiculo.Text = _Data("VEHICULO")
        If Not _Data.IsNull("CONDUCTOR") Then FwiConductor.Text = _Data("CONDUCTOR")
        If Not _Data.IsNull("DNICONDUCTOR") Then FwiDNIConductor.Text = _Data("DNICONDUCTOR")
        If Not _Data.IsNull("EmpresaTransp") Then FwiEmpresa.Text = _Data("EmpresaTransp")
        If Not _Data.IsNull("CifTransportista") Then FwiCifTransp.Text = _Data("CifTransportista")
        If Not _Data.IsNull("IdFormaEnvio") Then FwiIDFormaEnvioOld = _Data("IdFormaEnvio")
        If Not _Data.IsNull("IdFormaEnvio") Then FwiIDFormaEnvio.Text = _Data("IdFormaEnvio")
        If Not _Data.IsNull("PesoBruto") Then FwiPesoBruto.Text = _Data("PesoBruto")
        If Not _Data.IsNull("PesoBrutoManual") Then fwiPesoBrutoManual.Text = _Data("PesoBrutoManual")
        If Not _Data.IsNull("PesoNeto") Then FwiPesoNeto.Text = _Data("PesoNeto")
        If Not _Data.IsNull("PesoNetoManual") Then fwiPesoNetoManual.Text = _Data("PesoNetoManual")
        If Not _Data.IsNull("NBultos") Then FwiNoBultos.Text = _Data("NBultos")
        If Not _Data.IsNull("NContenedores") Then FwiNContenedores.Text = _Data("NContenedores")
        If Not _Data.IsNull("EnviadaEntidadAseguradora") Then chcCreditoCaucion.Checked = _Data("EnviadaEntidadAseguradora")
        If Not _Data.IsNull("Departamento") Then Departamento.Text = _Data("Departamento")
        If Not _Data.IsNull("Sucursal") Then Sucursal.Text = _Data("Sucursal")
        If Not _Data.IsNull("Remolque") Then txtRemolque.Text = _Data("Remolque")
    End Sub

    Private Sub cmdAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click
        _Data("MATRICULA") = FwiMatricula.Text
        _Data("NCONTENEDOR") = FwiNContenedor.Text
        _Data("PRECINTO") = FwiPrecinto.Text
        _Data("VEHICULO") = FwiVehiculo.Text
        _Data("CONDUCTOR") = FwiConductor.Text
        _Data("DNICONDUCTOR") = FwiDNIConductor.Text
        _Data("EmpresaTransp") = FwiEmpresa.Text
        _Data("CifTransportista") = FwiCifTransp.Text
        _Data("IdFormaEnvio") = FwiIDFormaEnvio.Text
        _Data("PesoBrutoManual") = Nz(fwiPesoBrutoManual.Text, 0)
        _Data("PesoNetoManual") = Nz(fwiPesoNetoManual.Text, 0)
        _Data("NBultos") = FwiNoBultos.Text
        _Data("NContenedores") = FwiNContenedores.Text
        _Data("EnviadaEntidadAseguradora") = chcCreditoCaucion.Checked
        _Data("Departamento") = Departamento.Text
        _Data("Sucursal") = Sucursal.Text
        _Data("Remolque") = txtRemolque.Text
    End Sub

    Private Sub chcCreditoCaucion_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chcCreditoCaucion.CheckedChanged
        'If chcCreditoCaucion.CheckedValue = False Then
        '    chcCreditoCaucion.CheckedValue = True
        'Else : chcCreditoCaucion.CheckedValue = False
        'End If
    End Sub

    Private Sub FwiIDFormaEnvio_SelectionChanged(ByVal sender As Object, ByVal e As Engine.UI.AdvSearchSelectionChangedEventArgs) Handles FwiIDFormaEnvio.SelectionChanged
        Try
            Dim oRw As DataRow = e.Selected.Rows(0)
            CargarDesplegableDetalles()
            FwiIDFormaEnvio.Text = oRw("IdFormaEnvio")
            If FwiIDFormaEnvioOld <> oRw("IdFormaEnvio") Then
                Dim bsnAlbaranVenta As New AlbaranVentaCabecera
                Dim bdRow As New BusinessData(_Data)
                bdRow = bsnAlbaranVenta.ApplyBusinessRule("IdFormaEnvio", FwiIDFormaEnvio.Value, bdRow)
                FwiEmpresa.Text = bdRow("EmpresaTransp").ToString
                FwiCifTransp.Text = bdRow("CifTransportista").ToString
                FwiConductor.Text = bdRow("CONDUCTOR").ToString
                FwiDNIConductor.Text = bdRow("DNICONDUCTOR").ToString
                FwiMatricula.Text = bdRow("MATRICULA").ToString
                txtRemolque.Text = bdRow("Remolque").ToString
                cmbDetalles.Text = bdRow("CONDUCTOR").ToString
                'FwiEmpresa.Text = oRw("DescFormaEnvio")
                'If Not oRw.IsNull("IDProveedor") Then
                '    Dim strID As String = oRw("IDProveedor")
                '    Dim oProv As Proveedor = New Proveedor
                '    Dim dtProv As DataTable = oProv.SelOnPrimaryKey(strID)
                '    FwiCifTransp.Text = dtProv.Rows(0)("CifProveedor")
                'Else
                '    FwiCifTransp.Text = vbNullString
                'End If
                FwiIDFormaEnvioOld = oRw("IdFormaEnvio")
            End If
        Catch
        End Try
    End Sub

    Private Sub frmdatostransporte_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        FwiIDFormaEnvio.Text = FwiIDFormaEnvioOld
        CargarDesplegableDetalles()
    End Sub

    Public Sub CargarDesplegableDetalles()
        If Length(FwiIDFormaEnvio.Value) > 0 Then
            Dim detalle As New FormaEnvioDetalle
            Dim dt As DataTable
            Dim filtro As New Filter
            filtro.Add("IDFormaEnvio", FilterOperator.Equal, FwiIDFormaEnvio.Value)
            dt = detalle.Filter(filtro)
            cmbDetalles.DataSource = dt
        End If
    End Sub

    Private Sub cmbDestalles_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbDetalles.ValueChanged
        Dim dr As DataRowView = cmbDetalles.SelectedItem()
        FwiConductor.Text = dr("Conductor")
        FwiDNIConductor.Text = dr("DNIConductor")
        FwiMatricula.Text = dr("Matricula")
        txtRemolque.Text = dr("Remolque")
        FwiEmpresa.Focus()
    End Sub
End Class
