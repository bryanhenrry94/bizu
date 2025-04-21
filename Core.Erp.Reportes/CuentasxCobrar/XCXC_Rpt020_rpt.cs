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

namespace Core.Erp.Reportes.CuentasxCobrar
{
    public partial class XCXC_Rpt020_rpt : DevExpress.XtraReports.UI.XtraReport
    {
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        List<string> listTipoCobro = new List<string>();
        cxc_cobro_tipo_Bus CobroBus = new cxc_cobro_tipo_Bus();
        List<cxc_cobro_tipo_Info> List_TipoCobro = new List<cxc_cobro_tipo_Info>();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        
        public Boolean fech = false;

        public XCXC_Rpt020_rpt()
        {
            InitializeComponent();
            xlbl_idReporte.Text = "XCXC_Rpt020_rpt";
            lblFechaImpresion.Text = DateTime.Now.ToString("dddd, dd' de 'MMMM' de 'yyyy HH:mm:ss");

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

        private void XCXC_Rpt020_rpt_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {
                XCXC_Rpt020_Bus rptBus = new XCXC_Rpt020_Bus();
                List<XCXC_Rpt020_Info> lstInfo = new List<XCXC_Rpt020_Info>();

                int IdEmpresa = 0;
                int IdSucursalIni = 0;
                int IdSucursalFin = 0;
                decimal IdClienteIni = 0;
                decimal IdClienteFin = 0;
                DateTime FechaIni = DateTime.Now;
                DateTime FechaFin = DateTime.Now;
                string TipoFecha = "";


                IdEmpresa = Convert.ToInt32(Parameters["IdEmpresa"].Value);
                IdSucursalIni = Convert.ToInt32(Parameters["IdSucursalIni"].Value);
                IdSucursalFin = Convert.ToInt32(Parameters["IdSucursalFin"].Value);
                IdClienteIni = Convert.ToDecimal(Parameters["IdClienteIni"].Value);
                IdClienteFin = Convert.ToDecimal(Parameters["IdClienteFin"].Value);
                FechaIni = Convert.ToDateTime(Parameters["FechaIni"].Value);
                FechaFin = Convert.ToDateTime(Parameters["FechaFin"].Value);
                TipoFecha = Convert.ToString(Parameters["TipoFecha"].Value);

                if (listTipoCobro.Count==0)
                {
                    List_TipoCobro = CobroBus.Get_List_Cobro_Tipo_Todos();

                    foreach (var item in List_TipoCobro)
                    {
                        string Tipo = "";
                        Tipo = item.IdCobro_tipo;
                        listTipoCobro.Add(Tipo);
                    }
                }

        
               lstInfo = rptBus.get_RptCobros(IdEmpresa, IdSucursalIni, IdSucursalFin, IdClienteIni, IdClienteFin, FechaIni, FechaFin, listTipoCobro);
                        
                
                this.DataSource = lstInfo.ToArray();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "XCXC_Rpt020_rpt_BeforePrint", ex.Message), ex) { EntityType = typeof(XCXC_Rpt020_rpt) };
            }
        }
    }
}
