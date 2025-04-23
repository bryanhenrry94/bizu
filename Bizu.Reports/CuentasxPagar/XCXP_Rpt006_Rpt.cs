using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Collections.Generic;
using Bizu.Domain.CuentasxPagar;
using Bizu.Application.CuentasxPagar;

using Bizu.Application.General;

namespace Bizu.Reports.CuentasxPagar
{
    public partial class XCXP_Rpt006_Rpt : DevExpress.XtraReports.UI.XtraReport
    {
        cl_parametrosGenerales_Bus param =cl_parametrosGenerales_Bus.Instance;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cp_orden_pago_cancelaciones_Bus bus_PagoCance;
        List<XCXP_Rpt006_Info_Resumen> list_resumen = new List<XCXP_Rpt006_Info_Resumen>();
        
        public XCXP_Rpt006_Rpt()
        {
            InitializeComponent();

            xrPictureBox1.Image = param.InfoEmpresa.em_logo_Image;
            lblUsuario1.Text = param.IdUsuario;
        }

        public void set_parametros(int IdEmpresa,decimal IdCbteCble_Nota)
        {

            try
            {

                this.IdEmpresa.Value = IdEmpresa;
                this.IdEmpresa.Visible = false;



                this.IdCbteCble_Nota.Value = IdCbteCble_Nota;
                this.IdCbteCble_Nota.Visible = false;


            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "set_parametros", ex.Message), ex) { EntityType = typeof(XCXP_Rpt006_Rpt) };
            }
        }

        private void PageHeader_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {

        }

        private void XCXP_Rpt006_Rpt_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {                
                xrLEmpresa.Text = param.NombreEmpresa;
                xrL_fecha.Text = DateTime.Now.ToLongDateString();

                XCXP_Rpt006_Bus repbus = new XCXP_Rpt006_Bus();
                List<XCXP_Rpt006_Info> ListDataRpt = new List<XCXP_Rpt006_Info>();

                int IdEmpresa = 0;
                Decimal IdCbteCble_Nota = 0;

                string mensaje = "";
                list_resumen = new List<XCXP_Rpt006_Info_Resumen>();

                IdEmpresa = Convert.ToInt32(Parameters["IdEmpresa"].Value);
                IdCbteCble_Nota = Convert.ToDecimal(Parameters["IdCbteCble_Nota"].Value);


                ListDataRpt = repbus.consultar_data(IdEmpresa, IdCbteCble_Nota, ref list_resumen, ref mensaje);

                //foreach(var item1 in ListDataRpt )
                //{
                //    string sms;
                //    bus_PagoCance = new cp_orden_pago_cancelaciones_Bus();
                //    List<cp_orden_pago_cancelaciones_Info> lista_PagoCance = new List<cp_orden_pago_cancelaciones_Info>();

                //    lista_PagoCance = bus_PagoCance.ConsultaGeneral_Cancelacion_x_Pagos(item1.IdEmpresa, item1.IdTipoCbte_Nota, item1.IdCbteCble_Nota, ref mensaje);

                //    if (lista_PagoCance.Count != 0)
                //    {

                //        foreach (var item in lista_PagoCance)
                //        {
                //            vwcp_orden_pago_con_cancelacion_Info info_cance = new vwcp_orden_pago_con_cancelacion_Info();

                //            //item1.IdOrdenPago = Convert.ToInt32(item.IdOrdenPago_op);
                           
                //            ////infoOrdenP = busOrdenP.Get_orden_pago(Convert.ToInt32(item.IdEmpresa_cxp), Convert.ToDecimal(item.IdOrdenPago_op), ref sms);
                //            //if (item.IdTipoCbte_cxp == 10)
                //            //{
                //            //    item1.FacturaModificada = "ND / " + Convert.ToString(item.IdCbteCble_cxp);
                //            //}
                //            //else if (item.IdTipoCbte_cxp == 7)
                //            //{
                //            //    item1.FacturaModificada = "FACT / " + Convert.ToString(item.IdCbteCble_cxp);
                //            //}
                //        }
                //    }
                //}

                this.DataSource = ListDataRpt.ToArray();

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "XCXP_Rpt006_Rpt_BeforePrint", ex.Message), ex) { EntityType = typeof(XCXP_Rpt006_Rpt) };
            }
        }

        private void xrSubreport1_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {
                ((XRSubreport)sender).ReportSource.DataSource = list_resumen;
                ((XRSubreport)sender).ReportSource.FillDataSource();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "set_parametros", ex.Message), ex) { EntityType = typeof(XCXP_Rpt006_resumen_rpt) };
            }
        }      
    }
}
