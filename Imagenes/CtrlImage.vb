Public Class CtrlImage

    Public Shadows Event Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    Public Sub New()
        If Me.DesignMode Then Exit Sub
        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        pbxFoto.SizeMode = PictureBoxSizeMode.CenterImage
    End Sub

#Region "Variables Privadas / Propiedades Públicas"

    Private MIntPos As Integer = 0
    Private MBlnReposicion As Boolean = False
    Private MStrModoPosicion As String

    Public Enum EnumPosicion
        Izquierda = 0
        Derecha = 1
        Arriba = 2
        Abajo = 3
    End Enum

    Private DataFoto As New DatosConfigFotoInfo
    Public WriteOnly Property DatosFotoInfo() As DatosConfigFotoInfo
        Set(ByVal value As DatosConfigFotoInfo)
            DataFoto = value
        End Set
    End Property

    Public WriteOnly Property ReEstablecerPosicion() As Boolean
        Set(ByVal value As Boolean)
            If value Then MIntPos = 0
        End Set
    End Property

    Public Property TipoRedimensionamientoImagen() As PictureBoxSizeMode
        Get
            Return pbxFoto.SizeMode
        End Get
        Set(ByVal value As PictureBoxSizeMode)
            pbxFoto.SizeMode = value
        End Set
    End Property

#End Region

#Region "Funciones Inserción / Edición / Borrado"

    Private Sub AddImage()
        OpenImage.Filter = "Iconos (*.ico) |*.ico|Archivos de Imagen (*.jpg)|*.jpg|Archivos Png (*.png)|*.png |Archivos de mapa de bits (*.bmp) |*.bmp |odos los archivos |*.*"
        OpenImage.FileName = String.Empty
        OpenImage.CheckPathExists = True
        OpenImage.RestoreDirectory = True
        If OpenImage.ShowDialog(Me) = DialogResult.OK Then
            Dim strFicheroImagen As String = OpenImage.FileName
            GuardarImagen(strFicheroImagen)
        End If
    End Sub

    Private Sub ModifyImage()
        OpenImage.Filter = "Iconos (*.ico) |*.ico|Archivos de Imagen (*.jpg)|*.jpg|Archivos Png (*.png)|*.png |Archivos de mapa de bits (*.bmp) |*.bmp |odos los archivos |*.*"
        OpenImage.FileName = String.Empty
        OpenImage.CheckPathExists = True
        OpenImage.RestoreDirectory = True
        If OpenImage.ShowDialog(Me) = DialogResult.OK Then
            Dim strFicheroImagen As String = OpenImage.FileName
            ModificarImagen(strFicheroImagen)
        End If
    End Sub

    Private Sub DeleteImage()
        If DataFoto.DtSource Is Nothing Then Exit Sub
        If ExpertisApp.GenerateMessage("¿Desea eliminar la imagen actual seleccionada?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Dim DtDelete As DataTable = DataFoto.DtSource.Clone
            Dim Dr() As DataRow = DataFoto.DtSource.Select(New FilterItem("IDEntidadFoto", FilterOperator.Equal, DataFoto.DatosEntidad.IDEntidadFoto).Compose(New AdoFilterComposer))
            If Dr.Length > 0 Then
                DtDelete.ImportRow(Dr(0))
            End If
            Dim ClsEntFoto As New EntidadFoto
            ClsEntFoto.Delete(DtDelete)
            MIntPos = 0
            LoadImage()
            Me.LblNumberImage.Text = MIntPos + 1 & " de " & Me.DataFoto.DtSource.Rows.Count
        End If
    End Sub

    Private Sub SaveImage()
        DataFoto.DtSource = New EntidadFoto().Update(DataFoto.DtSource)
        MIntPos = 0
        LoadImage()
        If Not Me.DataFoto.DtSource Is Nothing Then
            Me.LblNumberImage.Text = MIntPos + 1 & " de " & Me.DataFoto.DtSource.Rows.Count
        End If        
    End Sub

    Private Sub ListImages()
        Dim FrmListWindow As New frmListImage
        FrmListWindow.DtSource = DataFoto.DtSource
        If FrmListWindow.ShowDialog = DialogResult.OK Then
            For i As Integer = 0 To DataFoto.DtSource.Rows.Count - 1
                If DataFoto.DtSource.Rows(i)("IDEntidadFoto") = FrmListWindow.IDEntidadFoto Then
                    MIntPos = i
                    Exit For
                End If
            Next
            LoadImage()
            VerifyPos()
            Me.PnlButtons.Visible = False
        End If
    End Sub

    Private Sub GuardarImagen(ByVal strFicheroImagen As String)
        If DataFoto.DtSource Is Nothing Then Exit Sub
        Dim fs As New System.IO.FileStream(strFicheroImagen, IO.FileMode.Open)
        Dim imgByte(fs.Length) As Byte
        fs.Read(imgByte, 0, Convert.ToInt32(fs.Length))

        Dim dr As DataRow = DataFoto.DtSource.NewRow
        dr("Entidad") = DataFoto.DatosEntidad.Entidad
        dr("Clave") = DataFoto.DatosEntidad.Clave
        dr("Foto") = imgByte
        DataFoto.DtSource.Rows.Add(dr)
        pbxFoto.Image = Image.FromStream(fs)
        fs.Close()
    End Sub

    Private Sub ModificarImagen(ByVal StrFicheroImagen As String)
        If DataFoto.DtSource Is Nothing Then Exit Sub
        Dim fs As New System.IO.FileStream(StrFicheroImagen, IO.FileMode.Open)
        Dim imgByte(fs.Length) As Byte
        fs.Read(imgByte, 0, Convert.ToInt32(fs.Length))
        Dim adr() As DataRow = DataFoto.DtSource.Select(New FilterItem("IDEntidadFoto", FilterOperator.Equal, DataFoto.DatosEntidad.IDEntidadFoto).Compose(New AdoFilterComposer))
        adr(0)("Foto") = imgByte
        pbxFoto.Image = Image.FromStream(fs)
        fs.Close()
    End Sub

    Private Sub DefaultImage()
        If Me.UiCtrlPicContextMenu.Commands("Predeterminado").Checked = Janus.Windows.UI.InheritableBoolean.True Then
            ExpertisApp.GenerateMessage("No se puede quitar el predeterminado a esta imagen. Debe existir una imagen predeterminada siempre.|Por favor, eliga otra imagen y asignele la opción de predeterminado.", MessageBoxButtons.OK, MessageBoxIcon.Information, vbNewLine)
        ElseIf Me.UiCtrlPicContextMenu.Commands("Predeterminado").Checked = Janus.Windows.UI.InheritableBoolean.False Then
            If ExpertisApp.GenerateMessage("¿Desea establecer esta imagen como la predeterminada?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                Me.UiCtrlPicContextMenu.Commands("Predeterminado").Checked = Janus.Windows.UI.InheritableBoolean.True
                ExpertisApp.ExecuteTask(Of EntidadFotoInfo)(AddressOf EntidadFoto.GrabarPredeterminado, DataFoto.DatosEntidad)
                MIntPos = 0
                LoadImage()
                VerifyPos()
                Me.PnlButtons.Visible = False
            End If
        End If
    End Sub

#End Region

#Region "Funciones Menú Contextual"

    Private Sub Me_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.Click
        If Not DataFoto.SoloLectura AndAlso CType(e, MouseEventArgs).Button = Windows.Forms.MouseButtons.Right Then
            UiCtrlPicContextMenu.Show()
        End If
    End Sub

    Private Sub UiCtrlPicContextMenu_CommandClick(ByVal sender As System.Object, ByVal e As Janus.Windows.UI.CommandBars.CommandEventArgs) Handles UiCtrlPicContextMenu.CommandClick
        Select Case e.Command.Key
            Case "Add"
                AddImage()
                SaveImage()
            Case "Modify"
                ModifyImage()
                SaveImage()
            Case "Delete"
                DeleteImage()
            Case "List"
                ListImages()
            Case "Predeterminado"
                DefaultImage()
        End Select
    End Sub

    Private Sub pbxFoto_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles pbxFoto.Click
        Me_Click(sender, e)
    End Sub

    Private Sub BtnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBack.Click
        MoveImage("Back")
        VerifyPos()
        LoadImage()
    End Sub

    Private Sub BtnForward_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnForward.Click
        MoveImage("Forward")
        VerifyPos()
        LoadImage()
    End Sub

#End Region

#Region "Funciones de Posición / Carga / Dimensiones"

    Private Sub VerifyDefault()
        If DataFoto.DtSource.Rows(MIntPos)("Predeterminado") Then
            Me.UiCtrlPicContextMenu.Commands("Predeterminado").Checked = Janus.Windows.UI.InheritableBoolean.True
        Else : Me.UiCtrlPicContextMenu.Commands("Predeterminado").Checked = Janus.Windows.UI.InheritableBoolean.False
        End If
    End Sub

    Private Sub VerifyPos()
        If DataFoto.DtSource.Rows.Count = 1 Then
            Me.PnlButtons.Visible = False
        ElseIf DataFoto.DtSource.Rows.Count > 0 Then
            Me.PnlButtons.Visible = True
        End If
        Me.LblNumberImage.Text = MIntPos + 1 & " de " & DataFoto.DtSource.Rows.Count
    End Sub

    'Private Function RedimensionarImagen(ByVal img As System.Drawing.Image) As Image
    '    Return New Bitmap(img, Me.pbxFoto.Width, pbxFoto.Height)
    'End Function

    Public Sub LoadData()
        Me.pbxFoto.InitialImage = DataFoto.InitialImage
        Me.pbxFoto.ErrorImage = DataFoto.ErrorImage
        If Not DataFoto.DtSource Is Nothing AndAlso DataFoto.DtSource.Rows.Count > 0 Then
            Me.LblNumberImage.Text = "1 de " & DataFoto.DtSource.Rows.Count
        End If
    End Sub

    Public Sub LoadImage()
        If Length(DataFoto.DatosEntidad.Clave) > 0 Then
            DataFoto.DtSource = ExpertisApp.ExecuteTask(Of EntidadFotoInfo, DataTable)(AddressOf EntidadFoto.ObtenerFotosEntidad, DataFoto.DatosEntidad)
        End If
        If Length(OpenImage.InitialDirectory) = 0 Then OpenImage.InitialDirectory = ExpertisApp.Path
        If DataFoto.DtSource Is Nothing OrElse DataFoto.DtSource.Rows.Count = 0 Then
            If Not Me.pbxFoto.InitialImage Is Nothing Then
                pbxFoto.Image = Me.pbxFoto.InitialImage
            Else
                pbxFoto.Image = Nothing
            End If
            Me.UiCtrlPicContextMenu.Commands("Modify").Enabled = Janus.Windows.UI.InheritableBoolean.False
            Me.UiCtrlPicContextMenu.Commands("Delete").Enabled = Janus.Windows.UI.InheritableBoolean.False
        Else
            DataFoto.DatosEntidad.IDEntidadFoto = DataFoto.DtSource.Rows(MIntPos)("IDEntidadFoto")
            pbxFoto.Image = ResizePicture(CType(DataFoto.DtSource.Rows(MIntPos)("Foto"), Byte()))
            Me.UiCtrlPicContextMenu.Commands("Modify").Enabled = Janus.Windows.UI.InheritableBoolean.True
            Me.UiCtrlPicContextMenu.Commands("Delete").Enabled = Janus.Windows.UI.InheritableBoolean.True
            VerifyDefault()
        End If
    End Sub

    Private Function ResizePicture(ByVal ImgByte As Byte()) As Image
        Dim ms As New System.IO.MemoryStream(ImgByte)
        Dim pImage As Image = Image.FromStream(ms)

        Dim lnewWidth As Integer, lnewHeight As Integer
        Dim lWidth As Integer = pImage.Width
        Dim lHeight As Integer = pImage.Height

        If lWidth > pbxFoto.Width Then
            lnewWidth = pbxFoto.Width
            lHeight = Convert.ToInt32(lHeight * (lnewWidth / lWidth))
        Else : lnewWidth = lWidth
        End If

        If lHeight > pbxFoto.Height Then
            lnewHeight = pbxFoto.Height
            lnewWidth = Convert.ToInt32(lnewWidth * (lnewHeight / lHeight))
        Else : lnewHeight = lHeight
        End If

        Dim lBitmap As Bitmap = New System.Drawing.Bitmap(lnewWidth, lnewHeight)
        Dim lGr As Graphics = System.Drawing.Graphics.FromImage(lBitmap)
        lGr.DrawImage(pImage, 0, 0, lnewWidth, lnewHeight)
        lGr.Dispose()
        lGr = Nothing
        Return lBitmap
    End Function

    Public Sub ClearData()
        pbxFoto.InitialImage = DataFoto.InitialImage
        pbxFoto.ErrorImage = DataFoto.ErrorImage
        pbxFoto.Image = Nothing
        LblNumberImage.Text = "0 de 0"
    End Sub

    Private Sub MoveImage(ByVal StrMove As String)
        Select Case StrMove
            Case "Back"
                If (MIntPos - 1) <> -1 Then MIntPos -= 1
            Case "Forward"
                If (MIntPos + 1) < DataFoto.DtSource.Rows.Count Then MIntPos += 1
        End Select
        DataFoto.DatosEntidad.IDEntidadFoto = DataFoto.DtSource.Rows(MIntPos)("IDEntidadFoto")
    End Sub

#End Region

#Region "Funciones de Movimiento de Control"

    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Reposicionar("Salida")
        Timer1.Enabled = False
    End Sub

    Private Sub pbxFoto_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles pbxFoto.MouseEnter
        Timer1.Enabled = False
        Reposicionar("Entrada")
    End Sub

    Private Sub PnlButtons_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles SplitButtons.MouseEnter, BtnBack.MouseEnter, BtnForward.MouseEnter, LblNumberImage.MouseEnter
        Timer1.Enabled = False
    End Sub

    Private Sub PnlButtons_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles PnlButtons.MouseLeave, BtnBack.MouseLeave, BtnForward.MouseLeave, LblNumberImage.MouseLeave
        Timer1.Enabled = True
    End Sub

    Private Sub pbxFoto_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles pbxFoto.MouseLeave
        Timer1.Enabled = True
    End Sub

    Private Sub Reposicionar(ByVal StrModo As String)
        Select Case StrModo
            Case "Entrada"
                If Not MBlnReposicion Then
                    If Not DataFoto.DtSource Is Nothing AndAlso DataFoto.DtSource.Rows.Count > 1 Then Me.PnlButtons.Visible = True : Me.pbxFoto.BringToFront()
                    If DataFoto.Reposicionamiento Then
                        MStrModoPosicion = "Entrada"
                        ReposicionarSentido()
                        Me.Width = DataFoto.MaxWidth : Me.Height = DataFoto.MaxHeight
                    End If
                    MBlnReposicion = True
                    Me.pbxFoto.Focus()
                End If
            Case "Salida"
                If MBlnReposicion Then
                    Me.PnlButtons.Visible = False
                    If DataFoto.Reposicionamiento Then
                        MStrModoPosicion = "Salida"
                        ReposicionarSentido()
                        Me.Width = DataFoto.OriginalWidth : Me.Height = DataFoto.OriginalHeight
                    End If
                    MBlnReposicion = False
                End If
        End Select
    End Sub

    Private Sub ReposicionarSentido()
        Select Case MStrModoPosicion
            Case "Entrada"
                Select Case DataFoto.PosicionReposicionamiento
                    Case EnumPosicion.Arriba
                        DataFoto.MPoint.Y -= DataFoto.MaxHeight / 2
                        DataFoto.MPoint.X -= 25
                    Case EnumPosicion.Abajo
                        DataFoto.MPoint.Y += DataFoto.MaxHeight / 2
                        DataFoto.MPoint.X += 25
                    Case EnumPosicion.Derecha
                        DataFoto.MPoint.X += DataFoto.MaxWidth / 2
                    Case EnumPosicion.Izquierda
                        DataFoto.MPoint.X -= DataFoto.MaxWidth / 2
                End Select
            Case "Salida"
                Select Case DataFoto.PosicionReposicionamiento
                    Case EnumPosicion.Arriba
                        DataFoto.MPoint.Y += DataFoto.MaxHeight / 2
                        DataFoto.MPoint.X += 25
                    Case EnumPosicion.Abajo
                        DataFoto.MPoint.Y -= DataFoto.MaxHeight / 2
                        DataFoto.MPoint.Y -= 25
                    Case EnumPosicion.Derecha
                        DataFoto.MPoint.X -= DataFoto.MaxWidth / 2
                    Case EnumPosicion.Izquierda
                        DataFoto.MPoint.X += DataFoto.MaxWidth / 2
                End Select
        End Select
        Me.Location = DataFoto.MPoint
    End Sub

#End Region

End Class

Public Class DatosConfigFotoInfo

    Public DatosEntidad As EntidadFotoInfo
    Public InitialImage As Image
    Public ErrorImage As Image
    Public OriginalWidth As Integer
    Public OriginalHeight As Integer
    Public MaxWidth As Integer
    Public MaxHeight As Integer
    Public SoloLectura As Boolean
    Public MPoint As Point
    Public Reposicionamiento As Boolean
    Public PosicionReposicionamiento As CtrlImage.EnumPosicion
    Public DtSource As DataTable

End Class