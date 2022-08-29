Imports Solmicro.Expertis.Business.BusinessEnum
Public Class frmFacturacionProvisional
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
    Friend WithEvents cmbCancel As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents cmbOK As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents jngDatos As Solmicro.Expertis.Engine.UI.Grid
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim GridEXLayout1 As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Me.Panel1 = New Solmicro.Expertis.Engine.UI.Panel
        Me.cmbCancel = New Solmicro.Expertis.Engine.UI.Button
        Me.cmbOK = New Solmicro.Expertis.Engine.UI.Button
        Me.jngDatos = New Solmicro.Expertis.Engine.UI.Grid
        Me.Panel1.suspendlayout()
        CType(Me.jngDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.cmbCancel)
        Me.Panel1.Controls.Add(Me.cmbOK)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 341)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(768, 48)
        Me.Panel1.TabIndex = 5
        '
        'cmbCancel
        '
        Me.cmbCancel.Location = New System.Drawing.Point(390, 7)
        Me.cmbCancel.Name = "cmbCancel"
        Me.cmbCancel.Size = New System.Drawing.Size(119, 34)
        Me.cmbCancel.TabIndex = 4
        Me.cmbCancel.Text = "Cancelar"
        '
        'cmbOK
        '
        Me.cmbOK.Location = New System.Drawing.Point(259, 7)
        Me.cmbOK.Name = "cmbOK"
        Me.cmbOK.Size = New System.Drawing.Size(119, 34)
        Me.cmbOK.TabIndex = 3
        Me.cmbOK.Text = "Aceptar"
        '
        'jngDatos
        '
        Me.jngDatos.AdvSearchColumns = New Solmicro.Expertis.Engine.UI.AdvSearchColumns(New Solmicro.Expertis.Engine.UI.AdvSearchColumn() {New Solmicro.Expertis.Engine.UI.AdvSearchColumn("IDCliente", "Cliente", "IDCliente", New Solmicro.Expertis.Engine.UI.ASSelectedColumns(New Solmicro.Expertis.Engine.UI.ASSelectedColumn() {New Solmicro.Expertis.Engine.UI.ASSelectedColumn("RazonSocial", "RazonSocial"), New Solmicro.Expertis.Engine.UI.ASSelectedColumn("CifCliente", "CifCliente"), New Solmicro.Expertis.Engine.UI.ASSelectedColumn("Direccion", "Direccion"), New Solmicro.Expertis.Engine.UI.ASSelectedColumn("CodPostal", "CodPostal"), New Solmicro.Expertis.Engine.UI.ASSelectedColumn("Poblacion", "Poblacion"), New Solmicro.Expertis.Engine.UI.ASSelectedColumn("Provincia", "Provincia"), New Solmicro.Expertis.Engine.UI.ASSelectedColumn("IDPais", "IDPais"), New Solmicro.Expertis.Engine.UI.ASSelectedColumn("IDZona", "IDZona"), New Solmicro.Expertis.Engine.UI.ASSelectedColumn("IDDiaPago", "IDDiaPago")}), "tbMaestroCliente")})
        Me.jngDatos.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.False
        GridEXLayout1.LayoutString = "<GridEXLayoutData><RootTable><Columns Collection=""true""><Column0 ID=""NFactura""><C" & _
        "aption>Nº. Factura</Caption><DataMember>NFactura</DataMember><EditType>NoEdit</E" & _
        "ditType><Key>NFactura</Key><Position>0</Position><TextAlignment>Far</TextAlignme" & _
        "nt><Width>81</Width></Column0><Column1 ID=""FechaFactura""><Caption>Fecha Factura<" & _
        "/Caption><DataMember>FechaFactura</DataMember><EditType>CalendarCombo</EditType>" & _
        "<Key>FechaFactura</Key><Position>1</Position><TextAlignment>Near</TextAlignment>" & _
        "<Width>86</Width></Column1><Column2 ID=""IDCliente""><Caption>Cliente</Caption><Da" & _
        "taMember>IDCliente</DataMember><EditType>NoEdit</EditType><Key>IDCliente</Key><P" & _
        "osition>2</Position><TextAlignment>Near</TextAlignment><Width>71</Width></Column" & _
        "2><Column3 ID=""IDContador""><Caption>Contador</Caption><DataMember>IDContador</Da" & _
        "taMember><EditType>NoEdit</EditType><Key>IDContador</Key><Position>3</Position><" & _
        "TextAlignment>Near</TextAlignment><Width>60</Width></Column3><Column4 ID=""IDMone" & _
        "da""><Caption>Moneda</Caption><DataMember>IDMoneda</DataMember><EditType>NoEdit</" & _
        "EditType><Key>IDMoneda</Key><Position>4</Position><TextAlignment>Near</TextAlign" & _
        "ment><Width>53</Width></Column4><Column5 ID=""IDFormaPago""><Caption>F. Pago</Capt" & _
        "ion><DataMember>IDFormaPago</DataMember><EditType>NoEdit</EditType><Key>IDFormaP" & _
        "ago</Key><Position>5</Position><TextAlignment>Near</TextAlignment><Width>52</Wid" & _
        "th></Column5><Column6 ID=""IDCondicionPago""><Caption>C. Pago</Caption><DataMember" & _
        ">IDCondicionPago</DataMember><EditType>NoEdit</EditType><Key>IDCondicionPago</Ke" & _
        "y><Position>6</Position><TextAlignment>Near</TextAlignment><Width>52</Width></Co" & _
        "lumn6><Column7 ID=""IDEjercicio""><Caption>IDEjercicio</Caption><DataMember>IDEjer" & _
        "cicio</DataMember><EditType>NoEdit</EditType><Key>IDEjercicio</Key><Position>7</" & _
        "Position><TextAlignment>Near</TextAlignment><Visible>False</Visible></Column7><C" & _
        "olumn8 ID=""BaseImponible""><Caption>Base Imponible</Caption><DataMember>BaseImpon" & _
        "ible</DataMember><EditType>NoEdit</EditType><HeaderLineAlignment>Far</HeaderLine" & _
        "Alignment><Key>BaseImponible</Key><Position>8</Position><TextAlignment>Near</Tex" & _
        "tAlignment><Width>101</Width></Column8><Column9 ID=""ImpIVA""><Caption>IVA</Captio" & _
        "n><DataMember>ImpIVA</DataMember><EditType>NoEdit</EditType><HeaderAlignment>Far" & _
        "</HeaderAlignment><Key>ImpIVA</Key><Position>9</Position><TextAlignment>Near</Te" & _
        "xtAlignment><Width>60</Width></Column9><Column10 ID=""ImpTotal""><Caption>Importe " & _
        "Total</Caption><DataMember>ImpTotal</DataMember><EditType>NoEdit</EditType><Head" & _
        "erAlignment>Far</HeaderAlignment><Key>ImpTotal</Key><Position>10</Position><Text" & _
        "Alignment>Near</TextAlignment><Width>87</Width></Column10><Column11 ID=""ImpTotal" & _
        "A""><Caption>Importe Total A</Caption><DataMember>ImpTotalA</DataMember><EditType" & _
        ">NoEdit</EditType><HeaderAlignment>Far</HeaderAlignment><Key>ImpTotalA</Key><Pos" & _
        "ition>11</Position><TextAlignment>Near</TextAlignment><Width>87</Width></Column1" & _
        "1><Column12 ID=""IDDireccion""><Caption>IDDireccion</Caption><DataMember>IDDirecci" & _
        "on</DataMember><EditType>NoEdit</EditType><Key>IDDireccion</Key><Position>12</Po" & _
        "sition><Visible>False</Visible></Column12><Column13 ID=""RazonSocial""><Caption>Ra" & _
        "zón Social</Caption><DataMember>RazonSocial</DataMember><EditType>NoEdit</EditTy" & _
        "pe><Key>RazonSocial</Key><Position>13</Position></Column13><Column14 ID=""CifClie" & _
        "nte""><Caption>CIF Cliente</Caption><DataMember>CifCliente</DataMember><EditType>" & _
        "NoEdit</EditType><Key>CifCliente</Key><Position>14</Position><Width>81</Width></" & _
        "Column14><Column15 ID=""Direccion""><Caption>Dirección</Caption><DataMember>Direcc" & _
        "ion</DataMember><EditType>NoEdit</EditType><Key>Direccion</Key><Position>15</Pos" & _
        "ition><Width>124</Width></Column15><Column16 ID=""CodPostal""><Caption>C.P. </Capt" & _
        "ion><DataMember>CodPostal</DataMember><EditType>NoEdit</EditType><Key>CodPostal<" & _
        "/Key><Position>16</Position><Width>57</Width></Column16><Column17 ID=""Poblacion""" & _
        "><Caption>Población</Caption><DataMember>Poblacion</DataMember><EditType>NoEdit<" & _
        "/EditType><Key>Poblacion</Key><Position>17</Position></Column17><Column18 ID=""Pr" & _
        "ovincia""><Caption>Provincia</Caption><DataMember>Provincia</DataMember><EditType" & _
        ">NoEdit</EditType><Key>Provincia</Key><Position>18</Position></Column18><Column1" & _
        "9 ID=""IDPais""><Caption>País</Caption><DataMember>IDPais</DataMember><EditType>No" & _
        "Edit</EditType><Key>IDPais</Key><Position>19</Position><Width>53</Width></Column" & _
        "19><Column20 ID=""IDZona""><Caption>Zona</Caption><DataMember>IDZona</DataMember><" & _
        "EditType>NoEdit</EditType><Key>IDZona</Key><Position>20</Position><Width>64</Wid" & _
        "th></Column20><Column21 ID=""IDDiaPago""><Caption>Día Pago</Caption><DataMember>ID" & _
        "DiaPago</DataMember><EditType>NoEdit</EditType><Key>IDDiaPago</Key><Position>21<" & _
        "/Position><Width>63</Width></Column21><Column22 ID=""IDClienteBanco""><Caption>Cli" & _
        "ente Banco</Caption><DataMember>IDClienteBanco</DataMember><EditType>NoEdit</Edi" & _
        "tType><Key>IDClienteBanco</Key><Position>22</Position><Width>89</Width></Column2" & _
        "2><Column23 ID=""IDClienteInicial""><Caption>Cliente Inicial</Caption><DataMember>" & _
        "IDClienteInicial</DataMember><EditType>NoEdit</EditType><Key>IDClienteInicial</K" & _
        "ey><Position>23</Position><Width>93</Width></Column23><Column24 ID=""FechaParaDec" & _
        "laracion""><Caption>Fecha Para Declaración</Caption><DataMember>FechaParaDeclarac" & _
        "ion</DataMember><EditType>NoEdit</EditType><Key>FechaParaDeclaracion</Key><Posit" & _
        "ion>24</Position></Column24></Columns><GroupCondition ID="""" /></RootTable></Grid" & _
        "EXLayoutData>"
        Me.jngDatos.DesignTimeLayout = GridEXLayout1
        Me.jngDatos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.jngDatos.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        Me.jngDatos.EntityName = Nothing
        Me.jngDatos.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.jngDatos.FrozenColumns = 3
        Me.jngDatos.Location = New System.Drawing.Point(0, 0)
        Me.jngDatos.Name = "jngDatos"
        Me.jngDatos.PrimaryDataFields = Nothing
        Me.jngDatos.SecondaryDataFields = Nothing
        Me.jngDatos.Size = New System.Drawing.Size(768, 341)
        Me.jngDatos.TabIndex = 6
        Me.jngDatos.Tag = "IdRec=5773:4961:4352:6679:6680:4398:4758:6681:4681:4999:5047:5767:;"
        Me.jngDatos.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.jngDatos.ViewName = Nothing
        '
        'frmFacturacionProvisional
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(768, 389)
        Me.Controls.Add(Me.jngDatos)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmFacturacionProvisional"
        Me.Text = "Datos Provisionales de Facturación"
        Me.Panel1.ResumeLayout(False)
        CType(Me.jngDatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private mblnCancel As Boolean

#Region " Load "

    Private Sub frmFacturacionProvisional_Activate()
        jngDatos.Focus()
        cmbOK.Enabled = (jngDatos.RowCount > 0)
    End Sub

    Public Function AbrirFormulario(ByRef dtFacturas As DataTable) As DialogResult
        jngDatos.HoldFields()
        jngDatos.DataSource = dtFacturas

        Return Me.ShowDialog()
    End Function

#End Region

    Private Sub cmbOK_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbOK.Click

        If jngDatos.DataChanged Then jngDatos.Update()

        'Recuperar los datos
        If Not jngDatos.DataSource Is Nothing Then
            Dim dt As DataTable = jngDatos.DataSource
            For Each oRw As DataRow In dt.Rows
                If oRw.IsNull("FechaFactura") Then
                    ExpertisApp.GenerateMessage("Datos incompletos.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    jngDatos.Focus()
                    Exit Sub
                Else
                    'Hay que saber si la facturación es normal o del proceso B

                    If New NegocioGeneral().ContadorB(oRw("IdContador")) Then
                        Dim IDEjercicio As String = ExpertisApp.ExecuteTask(Of Date, String)(AddressOf EjercicioContable.PredeterminadoB, oRw("FechaFactura"))
                        If Length(IDEjercicio) > 0 Then
                            oRw("IDEjercicio") = IDEjercicio
                        Else
                            ExpertisApp.GenerateMessage("No está configurado correctamente el Ejercicio de la fecha:| .|Por favor, revise los datos del ejercicio.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, oRw("FechaFactura"), vbNewLine)
                            Exit Sub
                        End If
                    Else
                        Dim IDEjercicio As String = ExpertisApp.ExecuteTask(Of Date, String)(AddressOf EjercicioContable.Predeterminado, oRw("FechaFactura"))
                        If Length(IDEjercicio) > 0 Then
                            oRw("IDEjercicio") = IDEjercicio
                        Else
                            ExpertisApp.GenerateMessage("No está configurado correctamente el Ejercicio de la fecha:| .|Por favor, revise los datos del ejercicio.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, oRw("FechaFactura"), vbNewLine)
                            Exit Sub
                        End If
                    End If
                End If
            Next
            Me.DialogResult = DialogResult.OK
        End If
    End Sub

    Private Sub cmbCancel_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbCancel.Click
        mblnCancel = False
        Me.DialogResult = DialogResult.Cancel
    End Sub

    Private Sub jngDatos_UpdatingCell(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.UpdatingCellEventArgs) Handles jngDatos.UpdatingCell
        With jngDatos
            Select Case e.Column.Key
                Case "FechaFactura"
                    jngDatos.EntityName = GetType(FacturaVentaCabecera).Name
                    jngDatos.InvokeBusinessRules("FechaFactura", e.Value, .Value("FechaFactura"))
                    jngDatos.EntityName = Nothing
                    'TODO:El Cliente no es editable
                    'Case "IDCliente"
                    '    If Length(e.Value) > 0 Then
                    '        .Value("IDClienteInicial") = e.InitialValue
                    '        Dim cb As New ClienteBanco
                    '        Dim intBancoPred As Integer = ExpertisApp.ExecuteTask(Of String, Integer)(AddressOf cb.GetBancoPredeterminado, e.Value)
                    '        If intBancoPred > 0 Then
                    '            .Value("IDClienteBanco") = intBancoPred
                    '        Else
                    '            .Value("IDClienteBanco") = System.DBNull.Value
                    '        End If

                    '        Dim cd As New ClienteDireccion
                    '        Dim dtCliente As DataTable = cd.ObtenerDireccionEnvio(e.Value, enumcdTipoDireccion.cdDireccionFactura)
                    '        If Not dtCliente Is Nothing AndAlso dtCliente.Rows.Count > 0 Then
                    '            .Value("IDDireccion") = dtCliente.Rows(0)("IDDireccion")
                    '        End If
                    '    Else
                    '        e.Cancel = True
                    '        e.Value = e.InitialValue
                    '    End If
            End Select
        End With
    End Sub

    Private Sub frmFacturacionProvisional_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        e.Cancel = mblnCancel
    End Sub

End Class