Imports System.Runtime.Remoting.Messaging
Public Class FrmProgresoProceso
    Inherits System.Windows.Forms.Form

    Private mStart As System.Delegate
    Private margs() As Object
    Private mRslt As Object
    Private mException As Exception
    Private mContext As SessionInformation

    Private mTh As Threading.Thread

#Region " Código generado por el Diseñador de Windows Forms "

    Public Sub New()
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent()

        'Agregar cualquier inicialización después de la llamada a InitializeComponent()
        Me.BackColor = Settings.FormBackColor
        Me.Icon = UI.Resources.ExpertisRelieveIcon

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
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents UIPgr As Janus.Windows.EditControls.UIProgressBar
    Friend WithEvents Label2 As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents LblMessage As Solmicro.Expertis.Engine.UI.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.LblMessage = New Solmicro.Expertis.Engine.UI.Label
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.UIPgr = New Janus.Windows.EditControls.UIProgressBar
        Me.Label2 = New Solmicro.Expertis.Engine.UI.Label
        Me.SuspendLayout()
        '
        'LblMessage
        '
        Me.LblMessage.AutoSize = False
        Me.LblMessage.Location = New System.Drawing.Point(7, 7)
        Me.LblMessage.Name = "LblMessage"
        Me.LblMessage.Size = New System.Drawing.Size(247, 38)
        Me.LblMessage.TabIndex = 0
        Me.LblMessage.Text = "La función se está procesando, el proceso tardará unos minutos."
        Me.LblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Timer1
        '
        Me.Timer1.Interval = 20
        '
        'UIPgr
        '
        Me.UIPgr.Location = New System.Drawing.Point(7, 74)
        Me.UIPgr.Name = "UIPgr"
        Me.UIPgr.Size = New System.Drawing.Size(246, 22)
        Me.UIPgr.TabIndex = 2
        Me.UIPgr.Tag = ""
        Me.UIPgr.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003
        '
        'Label2
        '
        Me.Label2.AutoSize = False
        Me.Label2.Location = New System.Drawing.Point(11, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(240, 21)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Por favor espere..."
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FrmProgresoProceso
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(262, 111)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.UIPgr)
        Me.Controls.Add(Me.LblMessage)
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmProgresoProceso"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Lanzando Proceso"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If IsFinish Then
            Close()
        Else
            If UIPgr.Value < 100 Then
                UIPgr.Value += 1
            Else
                UIPgr.Value = 0
            End If
        End If
    End Sub

    Private Sub FrmProcesoPlanif_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
    End Sub

    Public Sub Start(ByVal start As System.Threading.ThreadStart)
        mStart = start
        Me.Start(start, Nothing)
    End Sub

    Public Sub Start(ByVal start As System.Threading.ThreadStart, _
                    ByVal StrTexto As String, _
                    ByVal StrNomForm As String)

        If Len(StrTexto) > 0 Then LblMessage.Text = StrTexto
        If Len(StrNomForm) > 0 Then Text = StrNomForm

        Me.Start(start)
    End Sub

    Public Function Start(ByVal startDelegate As System.Delegate, ByVal args() As Object) As Object
        If Not IsFinish Then Throw New Exception("No se puede iniciar otro proceso hasta que no se termine de ejecutar el proceso en curso.")
        mStart = startDelegate
        margs = args
        mContext = CType(CallContext.GetData(SessionInformation.SessionSlot), SessionInformation)
        mTh = New Threading.Thread(AddressOf Launch)
        mTh.SetApartmentState(Threading.ApartmentState.STA)
        mTh.Name = "WaitScreenProc"
        mTh.Start()
        Me.ShowDialog()
        If mException Is Nothing Then
            Return mRslt
        Else
            Throw mException
        End If
    End Function

    Public Function Start(ByVal startDelegate As System.Delegate, _
                        ByVal args() As Object, _
                        ByVal StrTexto As String, _
                        ByVal StrNomForm As String) As Object

        If Len(StrTexto) > 0 Then LblMessage.Text = StrTexto
        If Len(StrNomForm) > 0 Then Text = StrNomForm

        Return Start(startDelegate, args)

    End Function

    Private Sub Launch()
        Try
            CallContext.SetData(SessionInformation.SessionSlot, mContext)
            mRslt = mStart.DynamicInvoke(margs)
        Catch ex As Exception
            If ex.InnerException Is Nothing Then
                mException = ex
            Else
                mException = ex.InnerException
            End If
        Finally
            'IsFinish = True
        End Try
    End Sub

    Protected Overrides Sub OnClosing(ByVal e As System.ComponentModel.CancelEventArgs)
        e.Cancel = Not IsFinish
    End Sub

    Public ReadOnly Property IsFinish() As Boolean
        Get
            Return mTh Is Nothing OrElse Not mTh.IsAlive
        End Get
    End Property
End Class
