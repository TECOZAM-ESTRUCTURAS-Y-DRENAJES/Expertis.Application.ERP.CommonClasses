Public Class FrmContactoEmpresa
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
    Friend WithEvents FContacto As Solmicro.Expertis.Engine.UI.Frame
    Friend WithEvents FDatosContacto As Solmicro.Expertis.Engine.UI.Frame
    Friend WithEvents lblDatosContacto As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents FCabContacto As Solmicro.Expertis.Engine.UI.Frame
    Friend WithEvents BContacto As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents lblNombreCompleto As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmContactoEmpresa))
        Me.FContacto = New Solmicro.Expertis.Engine.UI.Frame
        Me.FDatosContacto = New Solmicro.Expertis.Engine.UI.Frame
        Me.lblDatosContacto = New Solmicro.Expertis.Engine.UI.Label
        Me.FCabContacto = New Solmicro.Expertis.Engine.UI.Frame
        Me.BContacto = New Solmicro.Expertis.Engine.UI.Button
        Me.lblNombreCompleto = New Solmicro.Expertis.Engine.UI.Label
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.FContacto.SuspendLayout()
        Me.FDatosContacto.SuspendLayout()
        Me.FCabContacto.SuspendLayout()
        Me.SuspendLayout()
        '
        'FContacto
        '
        Me.FContacto.Controls.Add(Me.FDatosContacto)
        Me.FContacto.Controls.Add(Me.FCabContacto)
        Me.FContacto.Location = New System.Drawing.Point(8, 8)
        Me.FContacto.Name = "FContacto"
        Me.FContacto.Size = New System.Drawing.Size(256, 336)
        Me.FContacto.TabIndex = 9
        Me.FContacto.TabStop = False
        '
        'FDatosContacto
        '
        Me.FDatosContacto.Controls.Add(Me.lblDatosContacto)
        Me.FDatosContacto.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FDatosContacto.Location = New System.Drawing.Point(3, 104)
        Me.FDatosContacto.Name = "FDatosContacto"
        Me.FDatosContacto.Size = New System.Drawing.Size(250, 229)
        Me.FDatosContacto.TabIndex = 1
        Me.FDatosContacto.TabStop = False
        '
        'lblDatosContacto
        '
        Me.lblDatosContacto.Location = New System.Drawing.Point(8, 8)
        Me.lblDatosContacto.Name = "lblDatosContacto"
        Me.lblDatosContacto.Size = New System.Drawing.Size(224, 152)
        Me.lblDatosContacto.TabIndex = 5
        Me.lblDatosContacto.Text = "Datos contacto"
        '
        'FCabContacto
        '
        Me.FCabContacto.Controls.Add(Me.BContacto)
        Me.FCabContacto.Controls.Add(Me.lblNombreCompleto)
        Me.FCabContacto.Dock = System.Windows.Forms.DockStyle.Top
        Me.FCabContacto.Location = New System.Drawing.Point(3, 17)
        Me.FCabContacto.Name = "FCabContacto"
        Me.FCabContacto.Size = New System.Drawing.Size(250, 87)
        Me.FCabContacto.TabIndex = 0
        Me.FCabContacto.TabStop = False
        '
        'BContacto
        '
        Me.BContacto.ImageIndex = 0
        Me.BContacto.ImageList = Me.ImageList1
        Me.BContacto.ImageSize = New System.Drawing.Size(40, 40)
        Me.BContacto.Location = New System.Drawing.Point(8, 16)
        Me.BContacto.Name = "BContacto"
        Me.BContacto.Size = New System.Drawing.Size(40, 40)
        Me.BContacto.TabIndex = 5
        '
        'lblNombreCompleto
        '
        Me.lblNombreCompleto.Location = New System.Drawing.Point(8, 64)
        Me.lblNombreCompleto.Name = "lblNombreCompleto"
        Me.lblNombreCompleto.Size = New System.Drawing.Size(49, 17)
        Me.lblNombreCompleto.TabIndex = 4
        Me.lblNombreCompleto.Text = "Nombre"
        '
        'ImageList1
        '
        Me.ImageList1.ImageSize = New System.Drawing.Size(40, 40)
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'FrmContactoEmpresa
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(272, 349)
        Me.Controls.Add(Me.FContacto)
        Me.Name = "FrmContactoEmpresa"
        Me.Text = "Persona de Contacto"
        Me.FContacto.ResumeLayout(False)
        Me.FDatosContacto.ResumeLayout(False)
        Me.FCabContacto.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private mlngIDPersona As Integer
    Private Entidad As String

    Public Property IDPersona() As Integer
        Get
            Return mlngIDPersona
        End Get
        Set(ByVal valor As Integer)
            mlngIDPersona = valor
        End Set
    End Property

    Public Sub AbrirContacto(ByVal strEntidad As String, ByVal OwnerForm As FormBase)
        If IDPersona > 0 Then
            Dim f As New Filter
            f.Add(New NumberFilterItem("IDPersona", IDPersona))
            Dim dtPersona As DataTable = Nothing
            Dim be As New Engine.BE.DataEngine
            Select Case strEntidad
                Case GetType(EmpresaPersona).Name
                    dtPersona = be.Filter("VFrmContactoEmpresa", f)
                Case GetType(ClientePersonaContacto).Name
                    dtPersona = be.Filter("VFrmContactoCliente", f)
            End Select
            If Not dtPersona Is Nothing AndAlso dtPersona.Rows.Count > 0 Then
                Entidad = strEntidad
                Dim drP As DataRow = dtPersona.Rows(0)
                Dim strDatos As String = String.Empty
                Dim strNombreCompleto As String = String.Empty

                If strEntidad = GetType(EmpresaPersona).Name Then
                    If Length(drP("Tratamiento")) > 0 Then strNombreCompleto = drP("Tratamiento") & " "
                    strNombreCompleto = strNombreCompleto & ExpertisApp.ExecuteTask(Of Integer, String)(AddressOf EmpresaPersona.NombreCompleto, drP("IDPersona"))
                Else
                    strNombreCompleto = drP("Nombre") & " "
                End If
                lblNombreCompleto.Text = strNombreCompleto

                If Length(drP("DescCargo")) > 0 Then strDatos = drP("DescCargo") & vbCrLf

                If strEntidad = GetType(EmpresaPersona).Name Then
                    If Length(drP("Puesto")) > 0 Then strDatos = strDatos & drP("Puesto") & vbCrLf
                    If Length(drP("DescDepartamento")) > 0 Then strDatos = strDatos & "DPTO: " & drP("DescDepartamento") & vbCrLf & vbCrLf
                    If Length(drP("TelefonoDirecto")) > 0 Then strDatos = strDatos & "Tel. Directo: " & drP("TelefonoDirecto") & vbCrLf
                    If Length(drP("TelefonoMovil")) > 0 Then strDatos = strDatos & "Tel. Móvil: " & drP("TelefonoMovil") & vbCrLf
                Else
                    If Length(drP("Telefono1")) > 0 Then strDatos = strDatos & "Teléfono1: " & drP("Telefono1") & vbCrLf
                    If Length(drP("Telefono2")) > 0 Then strDatos = strDatos & "Teléfono2: " & drP("Telefono2") & vbCrLf
                    If Length(drP("Fax")) > 0 Then strDatos = strDatos & "Fax: " & drP("Fax") & vbCrLf
                End If
                If Length(drP("Email")) > 0 Then strDatos = strDatos & "Mail: " & drP("Email") & vbCrLf
                lblDatosContacto.Text = strDatos
                Me.ShowDialog()
            End If
        End If
    End Sub

    Private Sub AccionAbrirContacto()
        If Length(IDPersona) > 0 AndAlso IDPersona <> 0 Then
            If Entidad = GetType(EmpresaPersona).Name Then
                Dim ofilter As New Filter
                ofilter.Add(New NumberFilterItem("IDPersona", IDPersona))
                ExpertisApp.OpenForm("MNTOEMPPERS", ofilter)
                Me.Close()
            End If
        End If
    End Sub

    Private Sub BContacto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BContacto.Click
        AccionAbrirContacto()
    End Sub

    Private Sub lblNombreCompleto_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblNombreCompleto.Click
        AccionAbrirContacto()
    End Sub

    Private Sub lblDatosContacto_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblDatosContacto.Click
        AccionAbrirContacto()
    End Sub

End Class
