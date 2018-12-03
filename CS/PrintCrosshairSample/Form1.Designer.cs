namespace PrintCrosshairSample {
    partial class MainForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.ribbonControl = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.bciPrintCrosshair = new DevExpress.XtraBars.BarCheckItem();
            this.bbiShowPrintPreview = new DevExpress.XtraBars.BarButtonItem();
            this.rpChartSettings = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.rpgPrintOptions = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.chartControl = new DevExpress.XtraCharts.ChartControl();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonStatusBar1
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 697);
            this.ribbonStatusBar.Name = "ribbonStatusBar1";
            this.ribbonStatusBar.Ribbon = this.ribbonControl;
            this.ribbonStatusBar.Size = new System.Drawing.Size(1278, 22);
            // 
            // ribbonControl
            // 
            this.ribbonControl.ExpandCollapseItem.Id = 0;
            this.ribbonControl.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl.ExpandCollapseItem,
            this.bciPrintCrosshair,
            this.bbiShowPrintPreview});
            this.ribbonControl.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl.MaxItemId = 6;
            this.ribbonControl.Name = "ribbonControl";
            this.ribbonControl.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.rpChartSettings});
            this.ribbonControl.Size = new System.Drawing.Size(1278, 154);
            this.ribbonControl.StatusBar = this.ribbonStatusBar;
            // 
            // bciPrintCrosshair
            // 
            this.bciPrintCrosshair.Caption = "Print Crosshair";
            this.bciPrintCrosshair.Id = 4;
            this.bciPrintCrosshair.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("bciPrintCrosshair.ImageOptions.SvgImage")));
            this.bciPrintCrosshair.Name = "bciPrintCrosshair";
            this.bciPrintCrosshair.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.OnPrintCrosshairItemClick);
            // 
            // bbiShowPrintPreview
            // 
            this.bbiShowPrintPreview.Caption = "Show Print Preview";
            this.bbiShowPrintPreview.Id = 5;
            this.bbiShowPrintPreview.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("bbiShowPrintPreview.ImageOptions.SvgImage")));
            this.bbiShowPrintPreview.Name = "bbiShowPrintPreview";
            this.bbiShowPrintPreview.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.OnShowPrintPreviewItemClick);
            // 
            // rpChartSettings
            // 
            this.rpChartSettings.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.rpgPrintOptions});
            this.rpChartSettings.Name = "rpChartSettings";
            this.rpChartSettings.Text = "Chart Settings";
            // 
            // rpgPrintOptions
            // 
            this.rpgPrintOptions.ItemLinks.Add(this.bciPrintCrosshair);
            this.rpgPrintOptions.ItemLinks.Add(this.bbiShowPrintPreview);
            this.rpgPrintOptions.Name = "rpgPrintOptions";
            this.rpgPrintOptions.Text = "Print Options";
            // 
            // chartControl
            // 
            this.chartControl.CrosshairEnabled = DevExpress.Utils.DefaultBoolean.False;
            this.chartControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartControl.Legend.Name = "Default Legend";
            this.chartControl.Location = new System.Drawing.Point(0, 154);
            this.chartControl.Name = "chartControl";
            this.chartControl.PaletteName = "Office 2013";
            this.chartControl.SeriesSelectionMode = DevExpress.XtraCharts.SeriesSelectionMode.Point;
            this.chartControl.SeriesSerializable = new DevExpress.XtraCharts.Series[0];
            this.chartControl.Size = new System.Drawing.Size(1278, 543);
            this.chartControl.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1278, 719);
            this.Controls.Add(this.chartControl);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbonControl);
            this.Name = "MainForm";
            this.Ribbon = this.ribbonControl;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "Main Form";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl;
        private DevExpress.XtraBars.Ribbon.RibbonPage rpChartSettings;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgPrintOptions;
        private DevExpress.XtraBars.BarCheckItem bciPrintCrosshair;
        private DevExpress.XtraBars.BarButtonItem bbiShowPrintPreview;
        private DevExpress.XtraCharts.ChartControl chartControl;
    }
}

