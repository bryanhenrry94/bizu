namespace Bizu.Reports.Contabilidad
{
    partial class XCONTA_Rpt023_rpt
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.PIdEmpresa = new DevExpress.XtraReports.Parameters.Parameter();
            this.PFechaIni = new DevExpress.XtraReports.Parameters.Parameter();
            this.PFechaFin = new DevExpress.XtraReports.Parameters.Parameter();
            this.PMostrar_Reg_en_cero = new DevExpress.XtraReports.Parameters.Parameter();
            this.PConsiderar_Asiento_cierre_anual = new DevExpress.XtraReports.Parameters.Parameter();
            this.ReportHeader = new DevExpress.XtraReports.UI.ReportHeaderBand();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.Detail.HeightF = 13.54167F;
            this.Detail.Name = "Detail";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.Detail.Visible = false;
            // 
            // TopMargin
            // 
            this.TopMargin.HeightF = 0F;
            this.TopMargin.Name = "TopMargin";
            this.TopMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.TopMargin.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.TopMargin_BeforePrint);
            // 
            // BottomMargin
            // 
            this.BottomMargin.HeightF = 32F;
            this.BottomMargin.Name = "BottomMargin";
            this.BottomMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // PIdEmpresa
            // 
            this.PIdEmpresa.Description = "PIdEmpresa";
            this.PIdEmpresa.Name = "PIdEmpresa";
            this.PIdEmpresa.Type = typeof(int);
            this.PIdEmpresa.Value = 0;
            // 
            // PFechaIni
            // 
            this.PFechaIni.Description = "PFechaIni";
            this.PFechaIni.Name = "PFechaIni";
            this.PFechaIni.Type = typeof(System.DateTime);
            this.PFechaIni.Value = new System.DateTime(2018, 2, 10, 12, 41, 16, 969);
            // 
            // PFechaFin
            // 
            this.PFechaFin.Description = "PFechaFin";
            this.PFechaFin.Name = "PFechaFin";
            this.PFechaFin.Type = typeof(System.DateTime);
            this.PFechaFin.Value = new System.DateTime(2018, 2, 10, 12, 41, 51, 317);
            // 
            // PMostrar_Reg_en_cero
            // 
            this.PMostrar_Reg_en_cero.Description = "PMostrar_Reg_en_cero";
            this.PMostrar_Reg_en_cero.Name = "PMostrar_Reg_en_cero";
            this.PMostrar_Reg_en_cero.Type = typeof(bool);
            this.PMostrar_Reg_en_cero.Value = false;
            // 
            // PConsiderar_Asiento_cierre_anual
            // 
            this.PConsiderar_Asiento_cierre_anual.Description = "PConsiderar_Asiento_cierre_anual";
            this.PConsiderar_Asiento_cierre_anual.Name = "PConsiderar_Asiento_cierre_anual";
            this.PConsiderar_Asiento_cierre_anual.Type = typeof(bool);
            this.PConsiderar_Asiento_cierre_anual.Value = false;
            // 
            // ReportHeader
            // 
            this.ReportHeader.HeightF = 46.875F;
            this.ReportHeader.Name = "ReportHeader";
            // 
            // XCONTA_Rpt023_rpt
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.ReportHeader,
            this.Detail,
            this.TopMargin,
            this.BottomMargin});
            this.Landscape = true;
            this.Margins = new System.Drawing.Printing.Margins(26, 16, 0, 32);
            this.PageHeight = 850;
            this.PageWidth = 1100;
            this.Parameters.AddRange(new DevExpress.XtraReports.Parameters.Parameter[] {
            this.PIdEmpresa,
            this.PFechaIni,
            this.PFechaFin,
            this.PMostrar_Reg_en_cero,
            this.PConsiderar_Asiento_cierre_anual});
            this.Version = "12.1";
            this.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.XCONTA_Rpt023_rpt_BeforePrint);
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.XtraReports.UI.ReportHeaderBand ReportHeader;
        public DevExpress.XtraReports.Parameters.Parameter PIdEmpresa;
        public DevExpress.XtraReports.Parameters.Parameter PFechaIni;
        public DevExpress.XtraReports.Parameters.Parameter PFechaFin;
        public DevExpress.XtraReports.Parameters.Parameter PMostrar_Reg_en_cero;
        public DevExpress.XtraReports.Parameters.Parameter PConsiderar_Asiento_cierre_anual;
    }
}
