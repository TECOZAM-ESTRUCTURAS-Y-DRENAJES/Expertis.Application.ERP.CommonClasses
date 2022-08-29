Public Class frmListImage

#Region "Variables Privadas / Propiedades Públicas"

    Private MDtSource As DataTable
    Private MIDEntidadFoto As Integer

    Public WriteOnly Property DtSource() As DataTable
        Set(ByVal value As DataTable)
            MDtSource = value
        End Set
    End Property

    Public ReadOnly Property IDEntidadFoto() As Integer
        Get
            Return MIDEntidadFoto
        End Get
    End Property

#End Region

#Region "Funciones Privadas"

    Private Sub LoadCab()
        Me.TxtEntidad.Text = MDtSource.Rows(0)("Entidad")
        Me.TxtClave.Text = MDtSource.Rows(0)("Clave")
    End Sub

    Private Sub LoadImages()
        For Each Dr As DataRow In MDtSource.Select
            Dim PicImage As New PictureBox
            PicImage.Width = 75 : PicImage.Height = 75
            PicImage.SizeMode = PictureBoxSizeMode.CenterImage
            PicImage.BorderStyle = Windows.Forms.BorderStyle.Fixed3D
            PicImage.Image = ResizePicture(PicImage, Dr("Foto"))
            PicImage.Tag = Dr("IDEntidadFoto")
            AddHandler PicImage.DoubleClick, AddressOf LoadSelFoto
            Me.FlowImages.Controls.Add(PicImage)
        Next
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

    Private Sub LoadSelFoto(ByVal sender As Object, ByVal e As System.EventArgs)
        MIDEntidadFoto = CType(sender, PictureBox).Tag
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub

#End Region

#Region "Eventos FrmListImage"

    Private Sub frmListImage_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not MDtSource Is Nothing AndAlso MDtSource.Rows.Count > 0 Then
            LoadCab()
            LoadImages()
        Else
            ExpertisApp.GenerateMessage("No hay imagenes configuradas.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Me.Close()
        End If
    End Sub

    Private Sub BtnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCerrar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

#End Region

End Class