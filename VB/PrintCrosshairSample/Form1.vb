Imports System
Imports System.Linq
Imports System.Windows.Forms
Imports DevExpress.XtraBars
Imports DevExpress.XtraCharts
Imports DevExpress.XtraCharts.Printing

Namespace PrintCrosshairSample

    Public Partial Class MainForm
        Inherits DevExpress.XtraBars.Ribbon.RibbonForm

        Private Property VM As MainViewModel = New MainViewModel()

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub OnChartObjectHotTracked(ByVal sender As Object, ByVal e As HotTrackEventArgs)
            If Not(TypeOf e.Object Is Series) Then e.Cancel = True
        End Sub

        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs)
            InitChart()
        End Sub

        Private Sub InitChart()
            Dim template = chartControl.SeriesTemplate
            template.SeriesDataMember = "Company"
            template.SetDataMembers("Category", "Value")
            Dim view As StackedBarSeriesView = New StackedBarSeriesView()
            view.FillStyle.FillMode = FillMode.Solid
            template.View = view
            chartControl.DataSource = VM.TotalIncome
            chartControl.OptionsPrint.SizeMode = PrintSizeMode.Zoom
            Me.chartControl.ObjectHotTracked += AddressOf Me.OnChartObjectHotTracked
            Me.chartControl.MouseUp += AddressOf Me.OnChartControlMouseUp
        End Sub

        Private Sub OnChartControlMouseUp(ByVal sender As Object, ByVal e As MouseEventArgs)
            Dim diagram = CType(chartControl.Diagram, XYDiagram)
            diagram.ShowCrosshair(e.Location)
        End Sub

        Private Sub OnShowPrintPreviewItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            chartControl.ShowPrintPreview()
        End Sub

        Private Sub OnPrintCrosshairItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            chartControl.OptionsPrint.PrintCrosshair = bciPrintCrosshair.Checked
        End Sub
    End Class
End Namespace
