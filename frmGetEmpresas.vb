'Imports Solmicro.Expertis.Business

Public Class frmGetEmpresas
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
    Friend WithEvents Panel1 As Solmicro.Expertis.Engine.UI.Panel
    Friend WithEvents lblEmpresa As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents cbxEmpresa As Solmicro.Expertis.Engine.UI.ComboBox
    Friend WithEvents cmbCancelar As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents CmbAceptar As Solmicro.Expertis.Engine.UI.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim GridEXLayout1 As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Me.Panel1 = New Solmicro.Expertis.Engine.UI.Panel
        Me.cmbCancelar = New Solmicro.Expertis.Engine.UI.Button
        Me.CmbAceptar = New Solmicro.Expertis.Engine.UI.Button
        Me.lblEmpresa = New Solmicro.Expertis.Engine.UI.Label
        Me.cbxEmpresa = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.Panel1.suspendlayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.cmbCancelar)
        Me.Panel1.Controls.Add(Me.CmbAceptar)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 60)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(315, 32)
        Me.Panel1.TabIndex = 7
        '
        'cmbCancelar
        '
        Me.cmbCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmbCancelar.Location = New System.Drawing.Point(160, 2)
        Me.cmbCancelar.Name = "cmbCancelar"
        Me.cmbCancelar.Size = New System.Drawing.Size(94, 29)
        Me.cmbCancelar.TabIndex = 8
        Me.cmbCancelar.Text = "Cancelar"
        '
        'CmbAceptar
        '
        Me.CmbAceptar.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.CmbAceptar.Location = New System.Drawing.Point(60, 2)
        Me.CmbAceptar.Name = "CmbAceptar"
        Me.CmbAceptar.Size = New System.Drawing.Size(94, 29)
        Me.CmbAceptar.TabIndex = 9
        Me.CmbAceptar.Text = "Aceptar"
        '
        'lblEmpresa
        '
        Me.lblEmpresa.Location = New System.Drawing.Point(29, 20)
        Me.lblEmpresa.Name = "lblEmpresa"
        Me.lblEmpresa.Size = New System.Drawing.Size(54, 17)
        Me.lblEmpresa.TabIndex = 49
        Me.lblEmpresa.Tag = "IdRec=55249;"
        Me.lblEmpresa.Text = "Empresa"
        '
        'cbxEmpresa
        '
        GridEXLayout1.LayoutString = "<GridEXLayoutData><RootTable><Columns Collection=""true""><Column0 ID=""IDBaseDatos""" & _
        "><Caption>IDBaseDatos</Caption><DataMember>IDBaseDatos</DataMember><Key>IDBaseDa" & _
        "tos</Key><Position>0</Position><Visible>False</Visible></Column0><Column1 ID=""Ba" & _
        "seDatos""><Caption>Base Datos</Caption><DataMember>BaseDatos</DataMember><Key>Bas" & _
        "eDatos</Key><Position>1</Position></Column1></Columns><GroupCondition ID="""" /></" & _
        "RootTable><RowWithErrorsFormatStyle><PredefinedStyle>RowWithErrorsFormatStyle</P" & _
        "redefinedStyle></RowWithErrorsFormatStyle><LinkFormatStyle><PredefinedStyle>Link" & _
        "FormatStyle</PredefinedStyle></LinkFormatStyle><CardCaptionFormatStyle><Predefin" & _
        "edStyle>CardCaptionFormatStyle</PredefinedStyle></CardCaptionFormatStyle><GroupB" & _
        "yBoxInfoFormatStyle><PredefinedStyle>GroupByBoxInfoFormatStyle</PredefinedStyle>" & _
        "</GroupByBoxInfoFormatStyle><GroupRowFormatStyle><PredefinedStyle>GroupRowFormat" & _
        "Style</PredefinedStyle></GroupRowFormatStyle><HeaderFormatStyle><PredefinedStyle" & _
        ">HeaderFormatStyle</PredefinedStyle></HeaderFormatStyle><PreviewRowFormatStyle><" & _
        "PredefinedStyle>PreviewRowFormatStyle</PredefinedStyle></PreviewRowFormatStyle><" & _
        "RowFormatStyle><PredefinedStyle>RowFormatStyle</PredefinedStyle></RowFormatStyle" & _
        "><SelectedFormatStyle><PredefinedStyle>SelectedFormatStyle</PredefinedStyle></Se" & _
        "lectedFormatStyle><SelectedInactiveFormatStyle><PredefinedStyle>SelectedInactive" & _
        "FormatStyle</PredefinedStyle></SelectedInactiveFormatStyle><WatermarkImage /><Bo" & _
        "rderStyle>Flat</BorderStyle><FlatBorderColor>125, 159, 190</FlatBorderColor><Con" & _
        "trolStyle><ButtonAppearance>Flat</ButtonAppearance></ControlStyle><VisualStyle>S" & _
        "tandard</VisualStyle><AllowEdit>False</AllowEdit><ExpandableGroups>False</Expand" & _
        "ableGroups><GroupByBoxVisible>False</GroupByBoxVisible><HideSelection>Highlight<" & _
        "/HideSelection></GridEXLayoutData>"
        Me.cbxEmpresa.DesignTimeLayout = GridEXLayout1
        Me.cbxEmpresa.Location = New System.Drawing.Point(95, 20)
        Me.cbxEmpresa.Name = "cbxEmpresa"
        Me.cbxEmpresa.SelectedIndex = -1
        Me.cbxEmpresa.SelectedItem = Nothing
        Me.cbxEmpresa.Size = New System.Drawing.Size(135, 21)
        Me.cbxEmpresa.TabIndex = 50
        Me.cbxEmpresa.Value = Nothing
        '
        'frmGetEmpresas
        '
        Me.AcceptButton = Me.CmbAceptar
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.CancelButton = Me.cmbCancelar
        Me.ClientSize = New System.Drawing.Size(315, 92)
        Me.Controls.Add(Me.cbxEmpresa)
        Me.Controls.Add(Me.lblEmpresa)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmGetEmpresas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Selección de la empresa donde exportar "
        Me.WindowState = System.Windows.Forms.FormWindowState.Normal
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private mstrEmpresa As String
    Public ReadOnly Property Empresa() As String
        Get
            Return mstrEmpresa
        End Get
    End Property

    Private Sub frmEmpresa_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim dt As DataTable = New Business.General.Comunes().GetBDsEmpresa
        cbxEmpresa.DataSource = dt

        cbxEmpresa.DisplayMember = "BaseDatos"
        cbxEmpresa.ValueMember = "IDBaseDatos"
    End Sub

    Private Sub CmbAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbAceptar.Click
        If Length(cbxEmpresa.SelectedText) > 0 Then
            Me.DialogResult = DialogResult.OK
            mstrEmpresa = cbxEmpresa.SelectedText
            Me.Close()
        Else
            ExpertisApp.GenerateMessage("Es necesario indicar la Empresa a la que se quiere hacer la exportación.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub cmbCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbCancelar.Click
        Me.DialogResult = DialogResult.Cancel
        mstrEmpresa = String.Empty
        Me.Close()
    End Sub

    Private Sub frmEmpresa_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        If Length(cbxEmpresa.SelectedText) = 0 And Me.DialogResult <> DialogResult.Cancel Then e.Cancel = True
    End Sub
End Class
