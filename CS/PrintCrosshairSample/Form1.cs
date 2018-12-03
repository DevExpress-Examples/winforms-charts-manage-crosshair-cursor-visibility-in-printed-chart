using System;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraCharts;
using DevExpress.XtraCharts.Printing;

namespace PrintCrosshairSample {
    public partial class MainForm : DevExpress.XtraBars.Ribbon.RibbonForm {
        private MainViewModel VM { get; set; } = new MainViewModel();

        public MainForm() {
            InitializeComponent();
        }

        private void OnChartObjectHotTracked(object sender, HotTrackEventArgs e) {
            if (!(e.Object is Series))
                e.Cancel = true;
        }

        private void Form1_Load(object sender, EventArgs e) {
            InitChart();
        }

        private void InitChart() {
            var template = chartControl.SeriesTemplate;
            template.SeriesDataMember = "Company";
            template.SetDataMembers("Category", "Value");
            StackedBarSeriesView view = new StackedBarSeriesView();
            view.FillStyle.FillMode = FillMode.Solid;
            template.View = view;

            chartControl.DataSource = VM.TotalIncome;
            chartControl.OptionsPrint.SizeMode = PrintSizeMode.Zoom;

            chartControl.ObjectHotTracked += this.OnChartObjectHotTracked;
            chartControl.MouseUp += this.OnChartControlMouseUp;
        }


        private void OnChartControlMouseUp(object sender, MouseEventArgs e) {
            var diagram = (XYDiagram)chartControl.Diagram;
            diagram.ShowCrosshair(e.Location);
        }

        private void OnShowPrintPreviewItemClick(object sender, ItemClickEventArgs e) {
            chartControl.ShowPrintPreview();
        }

        private void OnPrintCrosshairItemClick(object sender, ItemClickEventArgs e) {
            chartControl.OptionsPrint.PrintCrosshair = bciPrintCrosshair.Checked;
        }
    }
}
