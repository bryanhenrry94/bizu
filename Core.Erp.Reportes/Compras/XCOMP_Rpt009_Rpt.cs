using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.IO;
using System.Collections.Generic;

using Core.Erp.Business.General;

namespace Core.Erp.Reportes.Compras
{
    public partial class XCOMP_Rpt009_Rpt : DevExpress.XtraReports.UI.XtraReport
    {
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        XCOMP_Rpt009_Bus repbus = new XCOMP_Rpt009_Bus();

        public XCOMP_Rpt009_Rpt()
        {
            InitializeComponent();
        }
       
        private void XCOMP_Rpt009_Rpt_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {
                this.xrPictureBox1.Image = this.param.InfoEmpresa.em_logo_Image;
                this.xrLfecha.Text = Convert.ToString(this.param.Fecha_Transac);
                this.xrLusuario.Text = this.param.IdUsuario;
                List<XCOMP_Rpt009_Info> list = new List<XCOMP_Rpt009_Info>();
                int num = Convert.ToInt32(base.Parameters["IdEmpresa"].Value);
                int idSucursal = Convert.ToInt32(base.Parameters["IdSucursal"].Value);
                base.DataSource = this.repbus.Cargar_data(this.param.IdEmpresa, idSucursal, Convert.ToInt32(base.Parameters["IdProducto"].Value), Convert.ToString(base.Parameters["IdCentroCosto"].Value), Convert.ToDateTime(base.Parameters["Fecha_Ini"].Value), Convert.ToDateTime(base.Parameters["Fecha_Fin"].Value)).ToArray();
            }
            catch (Exception exception)
            {
                throw exception;
            }
        }

    }
}
