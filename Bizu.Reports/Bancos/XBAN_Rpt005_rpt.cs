using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using Bizu.Application.General;
using System.Collections.Generic;
using System.Linq;
using Bizu.Application.CuentasxPagar;
using Bizu.Domain.CuentasxPagar;
using Bizu.Domain.General;
using Bizu.Domain.Bancos;
using Bizu.Application.Bancos;

namespace Bizu.Reports.Bancos
{
    public partial class XBAN_Rpt005_rpt : DevExpress.XtraReports.UI.XtraReport
    {
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;

        public XBAN_Rpt005_rpt()
        {
            InitializeComponent();
        }

        private void XBAN_Rpt005_rpt_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {
                XBAN_Rpt005_Bus repbus = new XBAN_Rpt005_Bus();
                List<XBAN_Rpt005_Info> listDataRpt = new List<XBAN_Rpt005_Info>();
                List<XBAN_Rpt005_Info> listDataRpt_agrupado_x_cta = new List<XBAN_Rpt005_Info>();

                string mensaje = "";
                string OP_CtbeCble = "";
                int IdEmpresa = 0;
                int IdTipoCbte = 0;
                decimal IdCbteCble = 0;
                double dcTotalDebe = 0;
                double dcTotalHaber = 0;
                
                IdEmpresa = Convert.ToInt32(this.PIdEmpresa.Value);
                IdCbteCble = Convert.ToDecimal(this.PIdCbteCble.Value);
                IdTipoCbte = Convert.ToInt32(this.PIdTipo.Value);

                cp_orden_pago_cancelaciones_Bus BusOp = new cp_orden_pago_cancelaciones_Bus();
                List<cp_orden_pago_cancelaciones_Info> listsOP = new List<cp_orden_pago_cancelaciones_Info>();                
                ba_Banco_Cuenta_Bus Bus_ba_Banco_Cuenta = new ba_Banco_Cuenta_Bus();
                ba_Banco_Cuenta_Info Info_ba_Banco_Cuenta = new ba_Banco_Cuenta_Info();                
                ba_Cbte_Ban_Info Info_banco = new ba_Cbte_Ban_Info();
                tb_banco_Info Info_tb_banco = new tb_banco_Info();
                tb_banco_Bus Bus_tb_banco = new tb_banco_Bus();

                listsOP = BusOp.Get_List_OP_x_CbteCtble(IdEmpresa, IdTipoCbte, IdCbteCble, ref mensaje);

                foreach (var item in listsOP)
                {
                    if (OP_CtbeCble == "" || OP_CtbeCble == null)
                        OP_CtbeCble = item.IdOrdenPago_op.ToString();
                    else
                        OP_CtbeCble = OP_CtbeCble + "/" + item.IdOrdenPago_op.ToString();
                }

                lbl_OP_x_CbteCble.Text = "Orden de Pago:" + OP_CtbeCble;

                listDataRpt = repbus.GetData(IdEmpresa, IdCbteCble, IdTipoCbte, ref mensaje);

                if (param.IdCliente_Ven_x_Default == Cl_Enumeradores.eCliente_Vzen.EDEHSA)
                {
                    ba_Cbte_Ban_Bus Bus_banco = new ba_Cbte_Ban_Bus();

                    Info_banco = Bus_banco.Get_Info_Cbte_Ban(IdEmpresa, IdTipoCbte, IdCbteCble, ref mensaje);

                    if (Info_banco != null)
                        Info_ba_Banco_Cuenta = Bus_ba_Banco_Cuenta.Get_Info_Banco_Cuenta(Info_banco.IdEmpresa, Info_banco.IdBanco);

                    if (Info_ba_Banco_Cuenta != null)
                        Info_tb_banco = Bus_tb_banco.Get_Info_Banco(Convert.ToInt32(Info_ba_Banco_Cuenta.IdBanco_Financiero));

                }

                var qGrupo = from Cb in listDataRpt
                             group Cb by new
                             {
                                 Cb.IdEmpresa,
                                 Cb.IdCbteCble,
                                 Cb.IdTipocbte,
                                 Cb.Cod_Cbtecble,
                                 Cb.cb_Observacion,
                                 Cb.cb_secuencia,
                                 Cb.cb_Valor,
                                 Cb.cb_Cheque,
                                 Cb.cb_ChequeImpreso,
                                 Cb.cb_FechaCheque,
                                 Cb.Fecha_Transac,
                                 Cb.Estado,
                                 Cb.cb_giradoA,
                                 Cb.cb_ciudadChq,
                                 Cb.CodTipoCbteBan,
                                 Cb.cb_Fecha,
                                 Cb.con_Fecha,
                                 Cb.con_Valor,
                                 Cb.con_Observacion,
                                 Cb.con_IdCbteCble,
                                 Cb.IdCtaCble,
                                 Cb.pc_Cuenta,
                                 Cb.ValorEnLetras,
                                 Cb.nom_ciudad,
                                 Cb.ba_descripcion,
                                 Cb.ba_Num_Cuenta,
                                 
                             }
                                 into grouping
                                 select new { grouping.Key, totaldebidoxCta = grouping.Sum(p => p.dc_ValorDebe), totalcreditoxCta = grouping.Sum(p => p.dc_ValorHaber) };

                foreach (var item in qGrupo)
                {
                    XBAN_Rpt005_Info InfoD = new XBAN_Rpt005_Info();
                    
                    InfoD.cb_Valor = item.Key.cb_Valor;
                    InfoD.IdCbteCble = item.Key.IdCbteCble;
                    InfoD.cb_Cheque = item.Key.cb_Cheque;
                    InfoD.cb_Observacion = item.Key.cb_Observacion;
                    InfoD.con_Fecha = item.Key.con_Fecha;
                    InfoD.cb_FechaCheque = item.Key.cb_FechaCheque;
                    InfoD.cb_giradoA = item.Key.cb_giradoA;
                    InfoD.ValorEnLetras = item.Key.ValorEnLetras;
                    InfoD.dc_ValorDebe = item.totaldebidoxCta;
                    InfoD.dc_ValorHaber = item.totalcreditoxCta;
                    InfoD.con_Valor = item.Key.con_Valor;
                    InfoD.con_Observacion = item.Key.con_Observacion;
                    InfoD.IdCtaCble = item.Key.IdCtaCble; 
                    InfoD.pc_Cuenta = item.Key.pc_Cuenta;
                    InfoD.ValorEnLetras = item.Key.ValorEnLetras;
                    InfoD.cb_ciudadChq = item.Key.cb_ciudadChq;
                    InfoD.nom_ciudad = item.Key.nom_ciudad;

                    if (Info_tb_banco != null)                     
                        InfoD.ba_descripcion = (Info_tb_banco.ba_descripcion != null) ? Info_tb_banco.ba_descripcion : "";

                    if (Info_ba_Banco_Cuenta != null)  
                        InfoD.ba_Num_Cuenta = (Info_ba_Banco_Cuenta.ba_Num_Cuenta != null) ? Info_ba_Banco_Cuenta.ba_Num_Cuenta : "";

                    dcTotalDebe += InfoD.dc_ValorDebe;
                    dcTotalHaber += InfoD.dc_ValorHaber;                    

                    //SI ES EDEHSA SOLO AGREGA LAS DOS PRIMERAS CUENTAS A LA LISTA PARA QUE NO SE DESCUADRE EL REPORTE DE COMPROBANTE
                    if (param.IdCliente_Ven_x_Default == Cl_Enumeradores.eCliente_Vzen.EDEHSA)
                    {
                        if (listDataRpt_agrupado_x_cta.Count < 4)
                        {
                            listDataRpt_agrupado_x_cta.Add(InfoD);
                        }
                    }
                    else {
                        listDataRpt_agrupado_x_cta.Add(InfoD);
                    }                    
                }                

                //SI ES EDEHSA ACTUALIZO LAS CANTIDADES DEBE Y HABER
                if (param.IdCliente_Ven_x_Default == Cl_Enumeradores.eCliente_Vzen.EDEHSA)
                {                
                    if (listDataRpt_agrupado_x_cta.Count < 4)
                    {
                        rellenar_diario_cheque_vacio(listDataRpt_agrupado_x_cta);
                    }

                    foreach (var item in listDataRpt_agrupado_x_cta)
                    {
                        item.dc_TotalDebe = dcTotalDebe;
                        item.dc_TotalHaber = dcTotalHaber;
                    }
                }
                               
                this.DataSource = listDataRpt_agrupado_x_cta.ToArray();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "XBAN_Rpt005_rpt_BeforePrint", ex.Message), ex) { EntityType = typeof(XBAN_Rpt005_rpt) };
            }
        }

        public void rellenar_diario_cheque_vacio(List<XBAN_Rpt005_Info> listDataRpt_agrupado_x_cta)
        {
            try
            {                
                while (listDataRpt_agrupado_x_cta.Count < 4)
                {
                    XBAN_Rpt005_Info Info = new XBAN_Rpt005_Info();
                    Info.cb_Valor = 0;
                    Info.IdCbteCble = 0;
                    Info.cb_Cheque = "";
                    Info.cb_Observacion = "";
                    //Info.con_Fecha = null;
                    Info.cb_FechaCheque = null;
                    Info.cb_giradoA = null;
                    Info.ValorEnLetras = "";
                    Info.dc_ValorDebe = 0;
                    Info.dc_ValorHaber = 0;
                    Info.con_Valor = 0;
                    Info.con_Observacion = "";
                    Info.IdCtaCble = "";
                    Info.pc_Cuenta = "";                    
                    Info.cb_ciudadChq = "";
                    Info.nom_ciudad = "";
                   
                    listDataRpt_agrupado_x_cta.Add(Info);
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "XBAN_Rpt005_rpt_BeforePrint", ex.Message), ex) { EntityType = typeof(XBAN_Rpt005_rpt) };
            }
        }
    }
}
