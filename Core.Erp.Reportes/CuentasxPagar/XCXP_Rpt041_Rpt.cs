using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using Core.Erp.Business.General;

namespace Core.Erp.Reportes.CuentasxPagar
{
    public partial class XCXP_Rpt041_Rpt : DevExpress.XtraReports.UI.XtraReport
    {
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        XCXP_Rpt041_Bus oBus = new XCXP_Rpt041_Bus();

        public XCXP_Rpt041_Rpt()
        {
            InitializeComponent();
            lblUsuario1.Text = param.IdUsuario;
        }

        private void XCXP_Rpt041_Rpt_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {
                lblFecha.Text = DateTime.Now.ToString();
                lblUsuario.Text = param.IdUsuario;

                int IdEmpresa = param.IdEmpresa;
                string IdTipo_Persona = Convert.ToString(Parameters["pIdPersona_Tipo"].Value);
                int IdEntidad = Convert.ToInt32(Parameters["pIdEntidad"].Value);
                DateTime Fecha_Desde = Convert.ToDateTime(Parameters["pFechaDesde"].Value);
                DateTime Fecha_Hasta = Convert.ToDateTime(Parameters["pFechaHasta"].Value);
                
                this.DataSource = oBus.Get_Lista_Reporte(IdEmpresa, IdTipo_Persona, IdEntidad, Fecha_Desde, Fecha_Hasta);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }
    }
}