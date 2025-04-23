using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using Bizu.Application.General;
using Bizu.Domain.General;
using Bizu.Reports;
using System.Collections.Generic;
using System.IO;

namespace Bizu.Reports.CuentasxPagar
{
    public partial class XCXP_Rpt030_Rpt : DevExpress.XtraReports.UI.XtraReport
    {
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        public int codigo;

        public XCXP_Rpt030_Rpt()
        {
            InitializeComponent();
        }

        private void XCXP_Rpt030_Rpt_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {
                xrLUsuario.Text = param.IdUsuario;
                lblFechaImpresion.Text = DateTime.Now.ToString("dddd, dd' de 'MMMM' de 'yyyy HH:mm:ss");
                xlbl_idReporte.Text = "XCXP_Rpt030_Rpt";

                string msg = "";
                XCXP_Rpt030_Bus Bus = new XCXP_Rpt030_Bus();
                List<XCXP_Rpt030_Info> lista = new List<XCXP_Rpt030_Info>();

                int IdEmpresa = 0;
                
                DateTime FechaIni;
                DateTime FechaFin;
                bool x_Fecha_Emision = true;


                IdEmpresa = Convert.ToInt32(this.PIdEmpresa.Value);
                FechaFin = Convert.ToDateTime(this.p_FechaFin.Value);
                FechaIni = Convert.ToDateTime(this.p_FechaIni.Value);
                x_Fecha_Emision = Convert.ToBoolean(this.P_X_Fecha_Emision.Value);

                if (codigo > 0)
                {
                    lista = Bus.Get_List_Data_Tipo(IdEmpresa, FechaIni, FechaFin, x_Fecha_Emision, codigo, ref msg);
                }
                else 
                {
                    lista = Bus.Get_List_Data(IdEmpresa, FechaIni, FechaFin, x_Fecha_Emision, ref msg);
                }

                foreach (var item in lista)
                {
                    if (item.Codigo == "NC")
                    {
                        item.co_baseImponible = item.co_baseImponible * -1;
                        item.co_subtotal_iva = item.co_subtotal_iva * -1;
                        item.co_subtotal_siniva = item.co_subtotal_siniva * -1;
                        item.co_valoriva = item.co_valoriva * -1;
                        item.co_total = item.co_total * -1;
                    }
                }

                this.DataSource = lista.ToArray();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "XCXP_Rpt030_Rpt_BeforePrint", ex.Message), ex) { EntityType = typeof(XCXP_Rpt030_Rpt) };
            }
        }

    }
}
