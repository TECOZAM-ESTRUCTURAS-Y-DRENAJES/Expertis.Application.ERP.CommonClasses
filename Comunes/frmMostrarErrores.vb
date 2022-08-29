Public Class frmMostrarErrores

#Region " Propiedades "

    Private mPreguntaContinuar As Boolean
    Public Property PreguntaContinuar() As Boolean
        Get
            Return mPreguntaContinuar
        End Get
        Set(ByVal value As Boolean)
            mPreguntaContinuar = value
        End Set
    End Property

    Private mTextoCabecera As String
    Public Property TextoCabecera() As String
        Get
            Return mTextoCabecera
        End Get
        Set(ByVal value As String)
            mTextoCabecera = value
        End Set
    End Property

    Private mErrores() As ClassErrors
    Public Property Errores() As ClassErrors()
        Get
            Return mErrores
        End Get
        Set(ByVal value As ClassErrors())
            mErrores = value
        End Set
    End Property

#End Region



#Region " Carga del formulario "

    Public Function Abrir(ByVal Errores() As ClassErrors, Optional ByVal TextoCabecera As String = "", Optional ByVal PreguntaContinuar As Boolean = False) As DialogResult
        Dim frmLog As New frmMostrarErrores
        frmLog.PreguntaContinuar = PreguntaContinuar
        frmLog.Errores = Errores
        frmLog.TextoCabecera = TextoCabecera
        Return frmLog.ShowDialog()
    End Function


    Private Sub MostrarErrores_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not Me.DesignMode Then
            SettingForm()

            Dim dtLog As DataTable = CrearErroresDataSource()
            TratarSoloErrores(Errores, dtLog)
            Grid1.DataSource = dtLog
        End If
    End Sub

    Private Sub SettingForm()
        pnlTop.Visible = (Length(mTextoCabecera) > 0)
        Me.lblTexto.Text = mTextoCabecera
        Me.pnlTop.Height = Me.lblTexto.Height + 20
        pnlContinuar.Visible = mPreguntaContinuar
        pnlAceptar.Visible = Not mPreguntaContinuar
    End Sub


    Public Function CrearErroresDataSource() As DataTable
        Dim dt As New DataTable
        dt.Columns.Add("LocationError", GetType(String))
        dt.Columns.Add("Message", GetType(String))
        Return dt
    End Function

    Private Sub TratarSoloErrores(ByVal Errores() As ClassErrors, ByVal dtLog As DataTable)
        If Not Errores Is Nothing AndAlso Errores.Length > 0 Then

            If dtLog Is Nothing Then Exit Sub
            For Each Err As ClassErrors In Errores
                Dim dr As DataRow = dtLog.NewRow
                dr("LocationError") = Err.Elements
                dr("Message") = ExpertisApp.Traslate(Err.MessageError)
                dtLog.Rows.Add(dr)
            Next
        End If
    End Sub



#End Region



#Region " Grid "

    Private Sub Grid1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Grid1.Click
        With Grid1
            Dim c As GridEXColumn = .ColumnFromPoint()
            If Not IsNothing(c) Then
                Dim hit As GridArea = .HitTest()
                If hit = GridArea.Cell Or hit = GridArea.NewRowCell Then
                    Select Case c.Key
                        Case "LocationError", "Message"
                            Dim frm As New FormularioTexto
                            frm.Texto = .Value(c.Key) & String.Empty
                            frm.SoloLectura = True
                            frm.ShowDialog()
                    End Select
                End If
            End If
        End With
    End Sub

    'Private Sub Grid1_FormattingRow(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowLoadEventArgs) Handles Grid1.FormattingRow
    '    If Length(e.Row.Cells("LocationError").Value) = 0 Then
    '        e.Row.Cells("Icon").ImageIndex = IconIndex.ProcessOK
    '    Else
    '        e.Row.Cells("Icon").ImageIndex = IconIndex.ProcessNotOK
    '    End If
    'End Sub

#End Region

#Region " Aceptar/Si/No "

    Private Sub cmdAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub

    Private Sub cmdSi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSi.Click
        Me.DialogResult = Windows.Forms.DialogResult.Yes
    End Sub

    Private Sub cmdNo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNo.Click
        Me.DialogResult = Windows.Forms.DialogResult.No
    End Sub

#End Region


End Class