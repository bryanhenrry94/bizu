using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.CuentasxCobrar;
using Core.Erp.Data.General;
using Core.Erp.Info.General;
using System.Data.Entity.Validation;

namespace Core.Erp.Data.CuentasxCobrar
{
    public class cxc_auditoria_de_diario_contable_cobranza_Data
    {
        string mensaje = "";

        public List<cxc_Factura_sin_diario_Info> Get_List_Facturas_ConSin_Diario(int IdEmpresa, int IdSucursal, DateTime FechaIni, DateTime FechaFin)
        {
            try
            {
                List<cxc_Factura_sin_diario_Info> lM = new List<cxc_Factura_sin_diario_Info>();
                EntitiesCuentas_x_Cobrar Base = new EntitiesCuentas_x_Cobrar();

                //var select_ = from T in Base.vwfa_Factura_sin_diario
                //              where T.IdEmpresa == IdEmpresa
                //              && T.IdSucursal == IdSucursal
                //              && T.vt_fecha >= FechaIni && T.vt_fecha <= FechaFin
                //              select T;

                //foreach (var item in select_)
                //{
                //    cxc_Factura_sin_diario_Info dat = new cxc_Factura_sin_diario_Info();

                //    dat.IdEmpresa = item.IdEmpresa;
                //    dat.IdSucursal = item.IdSucursal;
                //    dat.IdBodega = item.IdBodega;
                //    dat.IdCbteVta = item.IdCbteVta;
                //    dat.vt_NumFactura = item.vt_NumFactura;
                //    dat.vt_fecha = item.vt_fecha;

                //    dat.ct_IdEmpresa = item.ct_IdEmpresa;
                //    dat.ct_IdTipoCbte = item.ct_IdTipoCbte;
                //    dat.ct_IdCbteCble = item.ct_IdCbteCble;
                //    dat.Novedad = item.Novedad;

                //    lM.Add(dat);
                //}

                return (lM);
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.InnerException.ToString());
            }
        }

        public List<cxc_Factura_detalle_por_cuenta_contable_Info> Get_List_Facturas_ConSin_Diario_Detalle(int IdEmpresa, int IdSucursal, string IdCuenta, DateTime FechaIni, DateTime FechaFin)
        {
            try
            {
                List<cxc_Factura_detalle_por_cuenta_contable_Info> lM = new List<cxc_Factura_detalle_por_cuenta_contable_Info>();
                EntitiesCuentas_x_Cobrar Base = new EntitiesCuentas_x_Cobrar();

                //var select_ = from T in Base.vwfa_Factura_detalle_por_cuenta_contable
                //              where T.IdEmpresa == IdEmpresa
                //              && T.IdSucursal == IdSucursal
                //              && T.vt_fecha >= FechaIni && T.vt_fecha <= FechaFin
                //              select T;

                //              if (IdCuenta != "")
                //                  select_ = select_.Where(q => q.IdCtaCble == IdCuenta);

                //foreach (var item in select_)
                //{
                //    cxc_Factura_detalle_por_cuenta_contable_Info dat = new cxc_Factura_detalle_por_cuenta_contable_Info();

                //    dat.fac_IdEmpresa = item.fac_IdEmpresa;
                //    dat.IdSucursal = item.IdSucursal;
                //    dat.IdBodega = item.IdBodega;
                //    dat.IdCbteVta = item.IdCbteVta;
                //    dat.vt_NumFactura = item.vt_NumFactura;
                //    dat.vt_fecha = item.vt_fecha;

                //    dat.IdEmpresa = item.IdEmpresa;
                //    dat.IdTipoCbte = item.IdTipoCbte;
                //    dat.IdCbteCble = item.IdCbteCble;
                //    dat.cb_Fecha = item.cb_Fecha;
                //    dat.IdCtaCble = item.IdCtaCble;
                //    dat.pc_Cuenta = item.pc_Cuenta;
                //    dat.dc_Valor = item.dc_Valor;
                //    dat.Debe = item.Debe;
                //    dat.Haber = item.Haber;

                //    lM.Add(dat);
                //}

                return (lM);
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.InnerException.ToString());
            }
        }
    }
}