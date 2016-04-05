Public Class frmReporteGrid

    Public Sub New(ByVal Consulta As String)

        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call
        pSQL = Consulta

    End Sub

    Private _Nom_Rep As String = ""
    Public Property Nom_Rep() As String
        Get
            Return _Nom_Rep
        End Get
        Set(ByVal value As String)
            _Nom_Rep = value
        End Set
    End Property

    Private pSQL As String

    Private Sub cmdActualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdActualizar.ItemClick
        Llenar_Grid()
    End Sub

    Private Sub Imprimir_Vista()

        Try

            Dim printingSystem1 As New DevExpress.XtraPrinting.PrintingSystem()
            Dim printLink As New DevExpress.XtraPrinting.PrintableComponentLink()

            printingSystem1.PageSettings.Landscape = True

            printLink.Component = dgrid
            printLink.CreateDocument(printingSystem1)
            printingSystem1.PreviewFormEx.ShowDialog()
            printingSystem1.Dispose()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub Llenar_Grid()


        Try

            If pSQL.Trim = "" Then

                MsgBox("Los parametros de la consulta no son correctos", MsgBoxStyle.Exclamation, Me.Text)
                Me.Close()

            Else

                Dim DT As New DataTable
                BD.OpenDT(DT, pSQL)
                Dgrid.DataSource = DT
                GridView1.OptionsBehavior.Editable = False

            End If

            Application.DoEvents()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub

    Private Sub frmRepEnGrid_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

        Try

            If IO.File.Exists(CurDir() & "\" & Nom_Rep & ".xml") Then IO.File.Delete(CurDir() & "\" & Nom_Rep & ".xml")
            GridView1.SaveLayoutToXml(CurDir() & "\" & Nom_Rep & ".xml")

        Catch ex As Exception
        End Try

    End Sub

    Private Sub frmRepEnGrid_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Try

            Llenar_Grid()

            If IO.File.Exists(CurDir() & "\" & Nom_Rep & ".xml") Then GridView1.RestoreLayoutFromXml(CurDir() & "\" & Nom_Rep & ".xml")

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub

    Private Sub cmdImprimir_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmdImprimir.ItemClick
        Imprimir_Vista()
    End Sub


End Class