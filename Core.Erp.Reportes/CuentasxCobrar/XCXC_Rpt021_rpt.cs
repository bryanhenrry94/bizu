using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using Core.Erp.Business.General;
using System.Collections.Generic;
using System.Reflection;
using Core.Erp.Info.CuentasxCobrar;
using Core.Erp.Business.CuentasxCobrar;
using Core.Erp.Info.General;
using System.Linq;

namespace Core.Erp.Reportes.CuentasxCobrar
{
    public partial class XCXC_Rpt021_rpt : DevExpress.XtraReports.UI.XtraReport
    {
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();  
        List<string> listTipoCobro = new List<string>();
        cxc_cobro_tipo_Bus CobroBus = new cxc_cobro_tipo_Bus();
        List<cxc_cobro_tipo_Info> List_TipoCobro = new List<cxc_cobro_tipo_Info>();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;

        public Boolean fech = false;

        public XCXC_Rpt021_rpt()
        {
            InitializeComponent();
            lblFechaImpresion.Text = DateTime.Now.ToString("dddd, dd' de 'MMMM' de 'yyyy HH:mm:ss");

            RazonSocial.Value = param.InfoEmpresa.RazonSocial;
            xrPictureBox1.Image = param.InfoEmpresa.em_logo_Image;
        }

        public void set_lista_cobros(List<string> ltipo)
        {
            try
            {
                listTipoCobro = ltipo;
            }
            catch (Exception ex)
            {
            }
        }

        private void XCXC_Rpt021_rpt_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {
                XCXC_Rpt021_Bus rptBus = new XCXC_Rpt021_Bus();
                List<XCXC_Rpt021_Info> lstInfo = new List<XCXC_Rpt021_Info>();

                int IdEmpresa = 0;
                int IdSucursal = 0;
                decimal IdCliente = 0;
                bool Mostrar_Con_Saldo = false;

                IdEmpresa = Convert.ToInt32(Parameters["IdEmpresa"].Value);
                IdSucursal = Convert.ToInt32(Parameters["IdSucursal"].Value);
                IdCliente = Convert.ToDecimal(Parameters["IdCliente"].Value);
                Mostrar_Con_Saldo = Convert.ToBoolean(Parameters["Mostrar_Con_Saldo"].Value);

                lstInfo = rptBus.Get_Data(IdEmpresa, IdSucursal, IdCliente);

                foreach (var item in lstInfo)
                {
                    item.Saldo = lstInfo.Where(q => q.IdEmpresa == item.IdEmpresa && q.IdSucursal == item.IdSucursal && q.IdProyecto == item.IdProyecto && q.IdOferta == item.IdOferta).Select(q => q.MontoTotal).Sum();
                }

                if (Mostrar_Con_Saldo)
                {
                    lstInfo.RemoveAll(q => Math.Round(q.Valor_a_Pagar, 3) == 0 && q.Nivel != 3);
                    lstInfo.RemoveAll(q => Math.Round(q.Saldo, 2) == 0);
                }

                this.DataSource = lstInfo.ToArray();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "XCXC_Rpt021_rpt_BeforePrint", ex.Message), ex) { EntityType = typeof(XCXC_Rpt021_rpt) };
            }
        }
    }
}