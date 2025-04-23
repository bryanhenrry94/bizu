using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Collections.Generic;
using Bizu.Application.General;

namespace Bizu.Reports.Compras
{
    public partial class XCOMP_Rpt008_Rpt : DevExpress.XtraReports.UI.XtraReport
    {
        List<XCOMP_Rpt008_Info> Lst_rpt = new List<XCOMP_Rpt008_Info>();
        XCOMP_Rpt008_Bus bus_rpt = new XCOMP_Rpt008_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();

        public XCOMP_Rpt008_Rpt()
        {
            InitializeComponent();
        }

        private void XCOMP_Rpt008_Rpt_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {
                xrPictureBox1.Image = param.InfoEmpresa.em_logo_Image;
                lblEmpresa.Text = param.NombreEmpresa;
                lbl_usuario.Text = param.IdUsuario;
                lbl_fecha.Text = DateTime.Now.ToString();

                int IdSucursal = Convert.ToInt32(P_IdSucursal.Value);
                decimal IdProducto = 0;
                DateTime Fecha_ini = Convert.ToDateTime(P_Fecha_ini.Value);
                DateTime Fecha_fin = Convert.ToDateTime(P_Fecha_fin.Value);

                Lst_rpt = bus_rpt.get_list(param.IdEmpresa,IdSucursal,IdProducto,Fecha_ini,Fecha_fin);
                this.DataSource = Lst_rpt;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "XCOMP_Rpt008_Rpt_BeforePrint", ex.Message), ex) { EntityType = typeof(XCOMP_Rpt008_Rpt) };
            }
        }

    }
}
