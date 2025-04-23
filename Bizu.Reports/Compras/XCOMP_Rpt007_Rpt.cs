using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Collections.Generic;
using Bizu.Application.General;

namespace Bizu.Reports.Compras
{
    public partial class XCOMP_Rpt007_Rpt : DevExpress.XtraReports.UI.XtraReport
    {
        List<XCOMP_Rpt007_Info> ListaRpt = new List<XCOMP_Rpt007_Info>();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();

        public XCOMP_Rpt007_Rpt()
        {
            InitializeComponent();
        }

        public XCOMP_Rpt007_Rpt(List<XCOMP_Rpt007_Info> Lista, String nom_Sucursal, string nom_Alerta)
        {
            InitializeComponent();

            this.lblSucursal.Text = nom_Sucursal;
            this.lblNomAlerta.Text = nom_Alerta;
            this.ListaRpt = Lista;
        }

        private void XCOMP_Rpt007_Rpt_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {
                this.xrLUsuario.Text = param.IdUsuario;
                this.lblFechaImpresion.Text = param.Fecha_Transac.ToString("dd/MM/yyyy");
                this.DataSource = ListaRpt;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "XCOMP_Rpt006_rpt_BeforePrint", ex.Message), ex) { EntityType = typeof(XCOMP_Rpt006_rpt) };   
            }
         }

        

    }
}
