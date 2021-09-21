Namespace PrintCrosshairSample

    Partial Class MainForm

        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (Me.components IsNot Nothing) Then
                Me.components.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub

#Region "Windows Form Designer generated code"
        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PrintCrosshairSample.MainForm))
            Me.ribbonStatusBar = New DevExpress.XtraBars.Ribbon.RibbonStatusBar()
            Me.ribbonControl = New DevExpress.XtraBars.Ribbon.RibbonControl()
            Me.bciPrintCrosshair = New DevExpress.XtraBars.BarCheckItem()
            Me.bbiShowPrintPreview = New DevExpress.XtraBars.BarButtonItem()
            Me.rpChartSettings = New DevExpress.XtraBars.Ribbon.RibbonPage()
            Me.rpgPrintOptions = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
            Me.chartControl = New DevExpress.XtraCharts.ChartControl()
            CType((Me.ribbonControl), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.chartControl), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' ribbonStatusBar1
            ' 
            Me.ribbonStatusBar.Location = New System.Drawing.Point(0, 697)
            Me.ribbonStatusBar.Name = "ribbonStatusBar1"
            Me.ribbonStatusBar.Ribbon = Me.ribbonControl
            Me.ribbonStatusBar.Size = New System.Drawing.Size(1278, 22)
            ' 
            ' ribbonControl
            ' 
            Me.ribbonControl.ExpandCollapseItem.Id = 0
            Me.ribbonControl.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.ribbonControl.ExpandCollapseItem, Me.bciPrintCrosshair, Me.bbiShowPrintPreview})
            Me.ribbonControl.Location = New System.Drawing.Point(0, 0)
            Me.ribbonControl.MaxItemId = 6
            Me.ribbonControl.Name = "ribbonControl"
            Me.ribbonControl.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.rpChartSettings})
            Me.ribbonControl.Size = New System.Drawing.Size(1278, 154)
            Me.ribbonControl.StatusBar = Me.ribbonStatusBar
            ' 
            ' bciPrintCrosshair
            ' 
            Me.bciPrintCrosshair.Caption = "Print Crosshair"
            Me.bciPrintCrosshair.Id = 4
            Me.bciPrintCrosshair.ImageOptions.SvgImage = CType((resources.GetObject("bciPrintCrosshair.ImageOptions.SvgImage")), DevExpress.Utils.Svg.SvgImage)
            Me.bciPrintCrosshair.Name = "bciPrintCrosshair"
            Me.bciPrintCrosshair.ItemClick += New DevExpress.XtraBars.ItemClickEventHandler(AddressOf Me.OnPrintCrosshairItemClick)
            ' 
            ' bbiShowPrintPreview
            ' 
            Me.bbiShowPrintPreview.Caption = "Show Print Preview"
            Me.bbiShowPrintPreview.Id = 5
            Me.bbiShowPrintPreview.ImageOptions.SvgImage = CType((resources.GetObject("bbiShowPrintPreview.ImageOptions.SvgImage")), DevExpress.Utils.Svg.SvgImage)
            Me.bbiShowPrintPreview.Name = "bbiShowPrintPreview"
            Me.bbiShowPrintPreview.ItemClick += New DevExpress.XtraBars.ItemClickEventHandler(AddressOf Me.OnShowPrintPreviewItemClick)
            ' 
            ' rpChartSettings
            ' 
            Me.rpChartSettings.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.rpgPrintOptions})
            Me.rpChartSettings.Name = "rpChartSettings"
            Me.rpChartSettings.Text = "Chart Settings"
            ' 
            ' rpgPrintOptions
            ' 
            Me.rpgPrintOptions.ItemLinks.Add(Me.bciPrintCrosshair)
            Me.rpgPrintOptions.ItemLinks.Add(Me.bbiShowPrintPreview)
            Me.rpgPrintOptions.Name = "rpgPrintOptions"
            Me.rpgPrintOptions.Text = "Print Options"
            ' 
            ' chartControl
            ' 
            Me.chartControl.CrosshairEnabled = DevExpress.Utils.DefaultBoolean.[False]
            Me.chartControl.Dock = System.Windows.Forms.DockStyle.Fill
            Me.chartControl.Legend.Name = "Default Legend"
            Me.chartControl.Location = New System.Drawing.Point(0, 154)
            Me.chartControl.Name = "chartControl"
            Me.chartControl.PaletteName = "Office 2013"
            Me.chartControl.SeriesSelectionMode = DevExpress.XtraCharts.SeriesSelectionMode.Point
            Me.chartControl.SeriesSerializable = New DevExpress.XtraCharts.Series(-1) {}
            Me.chartControl.Size = New System.Drawing.Size(1278, 543)
            Me.chartControl.TabIndex = 0
            ' 
            ' MainForm
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(1278, 719)
            Me.Controls.Add(Me.chartControl)
            Me.Controls.Add(Me.ribbonStatusBar)
            Me.Controls.Add(Me.ribbonControl)
            Me.Name = "MainForm"
            Me.Ribbon = Me.ribbonControl
            Me.StatusBar = Me.ribbonStatusBar
            Me.Text = "Main Form"
            Me.Load += New System.EventHandler(AddressOf Me.Form1_Load)
            CType((Me.ribbonControl), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.chartControl), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()
        End Sub

#End Region
        Private ribbonStatusBar As DevExpress.XtraBars.Ribbon.RibbonStatusBar

        Private ribbonControl As DevExpress.XtraBars.Ribbon.RibbonControl

        Private rpChartSettings As DevExpress.XtraBars.Ribbon.RibbonPage

        Private rpgPrintOptions As DevExpress.XtraBars.Ribbon.RibbonPageGroup

        Private bciPrintCrosshair As DevExpress.XtraBars.BarCheckItem

        Private bbiShowPrintPreview As DevExpress.XtraBars.BarButtonItem

        Private chartControl As DevExpress.XtraCharts.ChartControl
    End Class
End Namespace
