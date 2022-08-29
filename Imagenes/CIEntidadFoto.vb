Public Class CIEntidadFoto

    Private MyIDEntidadFoto As Integer

#Region "Funciones Privadas"

    Private Sub LoadData()
        Me.CmbEntidad.DataSource = ExpertisApp.ExecuteTask(Of Object, DataTable)(AddressOf EntidadFoto.ObtenerEntidades, Nothing)
        Me.CmbEntidad.Text = "Articulo" : Me.CmbEntidad.Value = "tbMaestroArticulo"
        Me.AdvClave.SecondaryDataFields = "IDArticulo"
        Me.AdvClave.EntityName = Me.CmbEntidad.Text : Me.AdvClave.ViewName = Me.CmbEntidad.Value
        Me.AdvClave.Focus()
    End Sub

    Private Sub LoadActions()
        Me.UiCommandManager1.CommandBars(0).Commands("ExecuteActions").Visible = Janus.Windows.UI.InheritableBoolean.False
        Me.UiCommandManager1.CommandBars(0).Commands("Print").Visible = Janus.Windows.UI.InheritableBoolean.False
        Me.UiCommandManager1.CommandBars(0).Commands("Export").Visible = Janus.Windows.UI.InheritableBoolean.False
    End Sub

    Private Sub LoadImages()
        If Length(Me.GrdEntidadFoto.GetValue("Entidad")) > 0 AndAlso Length(Me.GrdEntidadFoto.GetValue("Clave")) > 0 Then
            Dim Data As New EntidadFotoInfo
            If Length(Me.GrdEntidadFoto.GetValue("Entidad")) > 0 Then Data.Entidad = Me.GrdEntidadFoto.GetValue("Entidad")
            If Length(Me.GrdEntidadFoto.GetValue("Clave")) > 0 Then Data.Clave = Me.GrdEntidadFoto.GetValue("Clave")
            Dim DtImages As DataTable = ExpertisApp.ExecuteTask(Of EntidadFotoInfo, DataTable)(AddressOf EntidadFoto.ObtenerFotosEntidad, Data)
            Me.FlowImages.Controls.Clear()
            If Not DtImages Is Nothing AndAlso DtImages.Rows.Count > 0 Then
                For Each Dr As DataRow In DtImages.Select
                    Dim PicImage As New PictureBox
                    If Dr("Predeterminado") Then
                        PicImage.Width = 300 : PicImage.Height = 300
                    Else : PicImage.Width = 150 : PicImage.Height = 150
                    End If
                    PicImage.BorderStyle = Windows.Forms.BorderStyle.FixedSingle
                    PicImage.SizeMode = PictureBoxSizeMode.CenterImage
                    PicImage.Image = ResizePicture(PicImage, Dr("Foto"))
                    PicImage.Tag = Dr("IDEntidadFoto")
                    AddHandler PicImage.Click, AddressOf CTxt_Click
                    Me.FlowImages.Controls.Add(PicImage)
                Next
            End If
        Else : Me.FlowImages.Controls.Clear()
        End If
    End Sub

    Private Function ResizePicture(ByVal PicImage As PictureBox, ByVal ImgByte As Byte()) As Image
        Dim ms As New System.IO.MemoryStream(ImgByte)
        Dim pImage As Image = Image.FromStream(ms)

        Dim lnewWidth As Integer, lnewHeight As Integer
        Dim lWidth As Integer = pImage.Width
        Dim lHeight As Integer = pImage.Height

        If lWidth > PicImage.Width Then
            lnewWidth = PicImage.Width
            lHeight = Convert.ToInt32(lHeight * (lnewWidth / lWidth))
        Else : lnewWidth = lWidth
        End If

        If lHeight > PicImage.Height Then
            lnewHeight = PicImage.Height
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

    Private Sub ExecuteForm()
        Dim Data As New EntidadFotoInfo
        If Length(Me.CmbEntidad.Text) > 0 Then Data.Entidad = Me.CmbEntidad.Text
        If Length(Me.AdvClave.Value) > 0 Then Data.Clave = Me.AdvClave.Value
        Data.Distintos = True
        Dim DtSource As DataTable = ExpertisApp.ExecuteTask(Of EntidadFotoInfo, DataTable)(AddressOf EntidadFoto.ObtenerFotosEntidad, Data)
        If Not DtSource Is Nothing AndAlso DtSource.Rows.Count > 0 Then
            GrdEntidadFoto.DataSource = DtSource
            Me.BindEditEvents(DtSource)
        Else
            Dim DrNew As DataRow = DtSource.NewRow
            DrNew("Entidad") = Me.CmbEntidad.Text
            DrNew("Clave") = Me.AdvClave.Text
            DtSource.Rows.Add(DrNew)
            GrdEntidadFoto.DataSource = DtSource
            Me.BindEditEvents(DtSource)
            Me.FlowImages.Controls.Clear()
        End If
    End Sub

    Private Sub ClearForm()
        Me.AdvClave.EntityName = String.Empty : Me.AdvClave.ViewName = String.Empty
        Me.AdvClave.SecondaryDataFields = String.Empty
        Me.AdvClave.Text = String.Empty : Me.AdvClave.Value = Nothing
        Me.CmbEntidad.Text = String.Empty : Me.CmbEntidad.Value = Nothing
        Me.FlowImages.Controls.Clear()
        Me.GrdEntidadFoto.DataSource = Nothing
    End Sub

    Private Sub AddImage()
        OpenImage.Filter = "Todos los archivos|*.*|Archivos de Imagen (*.jpg)|*.jpg|Archivos Png (*.png)|*.png|Archivos de mapa de bits(*.bmp)|*.bmp|Archivos de Iconos (*.ico)|*.ico"
        OpenImage.FileName = String.Empty
        OpenImage.CheckPathExists = True
        OpenImage.RestoreDirectory = True
        If OpenImage.ShowDialog(Me) = DialogResult.OK Then
            Dim strFicheroImagen As String = OpenImage.FileName
            Dim fs As New System.IO.FileStream(strFicheroImagen, IO.FileMode.Open)
            Dim imgByte(fs.Length) As Byte
            fs.Read(imgByte, 0, Convert.ToInt32(fs.Length))

            Dim ClsEntFoto As New EntidadFoto
            Dim DtEntFoto As DataTable = ClsEntFoto.AddNewForm
            DtEntFoto.Rows(0)("Entidad") = Me.GrdEntidadFoto.GetValue("Entidad")
            DtEntFoto.Rows(0)("Clave") = Me.GrdEntidadFoto.GetValue("Clave")
            DtEntFoto.Rows(0)("Foto") = imgByte
            ClsEntFoto.Update(DtEntFoto)
            fs.Close()
            LoadImages()
        End If
    End Sub

    Private Sub DeleteImage(ByVal IDFoto As Integer)
        If ExpertisApp.GenerateMessage("¿Desea eliminar la imagen seleccionada?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Dim ClsEntFoto As New EntidadFoto
            Dim DtDelete As DataTable = ClsEntFoto.SelOnPrimaryKey(IDFoto)
            ClsEntFoto.Delete(DtDelete)
            LoadImages()
            MyIDEntidadFoto = -1
            If Me.FlowImages.Controls.Count = 0 Then ExecuteForm()
        End If
    End Sub

    Private Sub DefaultImage(ByVal IDFoto As Integer)
        If ExpertisApp.GenerateMessage("¿Desea establecer esta imagen como la predeterminada?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Dim DataFoto As New EntidadFotoInfo
            DataFoto.Clave = Me.GrdEntidadFoto.GetValue("Clave")
            DataFoto.Entidad = Me.GrdEntidadFoto.GetValue("Entidad")
            DataFoto.IDEntidadFoto = IDFoto
            DataFoto.Distintos = False
            DataFoto.FiltrarIDEntidadFoto = True
            ExpertisApp.ExecuteTask(Of EntidadFotoInfo)(AddressOf EntidadFoto.GrabarPredeterminado, DataFoto)
            LoadImages()
            MyIDEntidadFoto = -1
        End If
    End Sub

#End Region

#Region "Eventos CIEntidadFoto"

    Private Sub CIEntidadFoto_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        Me.UiCommandManager1.CommandBars(1).Visible = False
    End Sub

    Private Sub CIEntidadFoto_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not Me.DesignMode Then
            LoadData()
            LoadActions()
        End If
    End Sub

    Private Sub CIEntidadFoto_QueryExecuting(ByVal sender As Object, ByRef e As Engine.UI.QueryExecutingEventArgs) Handles Me.QueryExecuting
        ExecuteForm()
    End Sub

    Private Sub CIEntidadFoto_FilterCleared(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.FilterCleared
        ClearForm()
    End Sub

    Private Sub GrdEntidadFoto_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles GrdEntidadFoto.SelectionChanged
        LoadImages()
    End Sub

    Private Sub CmbEntidad_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles CmbEntidad.Validated
        Me.AdvClave.Text = String.Empty : Me.AdvClave.Value = Nothing
        If Length(CmbEntidad.Text) > 0 Then
            Dim DtExistEnt As DataTable = New BE.DataEngine().Filter("xEntity", New FilterItem("Entidad", FilterOperator.Equal, Me.CmbEntidad.Text), , , , True)
            If Not DtExistEnt Is Nothing AndAlso DtExistEnt.Rows.Count > 0 Then
                Dim DtPK As DataTable = ExpertisApp.ExecuteTask(Of String, DataTable)(AddressOf EntidadFoto.GetPrimaryKeyTable, Me.CmbEntidad.Text)
                Dim StrPK As String = String.Empty
                For Each Dc As DataColumn In DtPK.Columns
                    If StrPK.Length > 0 Then StrPK &= ", "
                    StrPK &= Dc.ColumnName
                Next
                Me.AdvClave.SecondaryDataFields = StrPK
                Me.AdvClave.EntityName = Me.CmbEntidad.Text : Me.AdvClave.ViewName = Me.CmbEntidad.Value
            End If
        End If
    End Sub

    Private Sub AdvClave_OpenningAdvSearch(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles AdvClave.OpenningAdvSearch
        If Length(AdvClave.EntityName) = 0 Then
            ExpertisApp.GenerateMessage("Debe seleccionar antes una entidad para buscar su clave.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            e.Cancel = True
        End If
    End Sub

    Private Sub AdvClave_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles AdvClave.Validated
        If Length(AdvClave.Text) > 0 AndAlso Length(Me.CmbEntidad.Text) > 0 Then
            ExecuteForm()
        End If
    End Sub

    Private Sub CTxt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If CType(e, MouseEventArgs).Button = Windows.Forms.MouseButtons.Right Then
            MyIDEntidadFoto = CType(sender, PictureBox).Tag
            UICtxtOptions.Show()
        End If
    End Sub

    Private Sub UICtxtOptions_CommandClick(ByVal sender As System.Object, ByVal e As Janus.Windows.UI.CommandBars.CommandEventArgs) Handles UICtxtOptions.CommandClick
        Select Case e.Command.Key
            Case "Add"
                AddImage()
            Case "Delete"
                DeleteImage(MyIDEntidadFoto)
            Case "Predeterminado"
                DefaultImage(MyIDEntidadFoto)
        End Select
    End Sub

    Private Sub FlowImages_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles FlowImages.Click
        If Length(Me.GrdEntidadFoto.GetValue("Entidad")) > 0 AndAlso Length(Me.GrdEntidadFoto.GetValue("Clave")) > 0 AndAlso _
           CType(e, MouseEventArgs).Button = Windows.Forms.MouseButtons.Right Then
            UICtxtGeneral.Show()
        End If
    End Sub

    Private Sub UICtxtGeneral_CommandClick(ByVal sender As Object, ByVal e As Janus.Windows.UI.CommandBars.CommandEventArgs) Handles UICtxtGeneral.CommandClick
        Select Case e.Command.Key
            Case "Add"
                AddImage()
        End Select
    End Sub

#End Region

End Class