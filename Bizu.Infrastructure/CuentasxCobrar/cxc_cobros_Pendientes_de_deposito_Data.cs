using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Bizu.Domain.CuentasxCobrar;
using Bizu.Infrastructure.General;
using Bizu.Domain.General;

namespace Bizu.Infrastructure.CuentasxCobrar
{
    public class cxc_cobros_Pendientes_de_deposito_Data
    {
        public cxc_cobros_Pendientes_de_deposito_Info Get_Info_cobros_Pendientes_de_deposito(int IdEmpresa, int IdSucursal, int IdCobro, ref string mensaje)
        {
            try
            {
                cxc_cobros_Pendientes_de_deposito_Info dat = new cxc_cobros_Pendientes_de_deposito_Info();
                EntitiesCuentas_x_Cobrar Base = new EntitiesCuentas_x_Cobrar();

                var select_ = from T in Base.vwcxc_cobros_Pendientes_de_deposito
                              where T.IdEmpresa == IdEmpresa && T.IdSucursal == IdSucursal && T.IdCobro == IdCobro
                              select T;

                foreach (var item in select_)
                {
                    dat.IdEmpresa = item.IdEmpresa;
                    dat.IdSucursal = item.IdSucursal;
                    dat.IdCobro = item.IdCobro;
                    dat.cr_Codigo = item.cr_Codigo;
                    dat.IdCobro_tipo = item.IdCobro_tipo;
                    dat.IdCliente = item.IdCliente;
                    dat.cr_TotalCobro = item.cr_TotalCobro;
                    dat.cr_fecha = item.cr_fecha;
                    dat.cr_fechaDocu = item.cr_fechaDocu;
                    dat.cr_fechaCobro = item.cr_fechaCobro;
                    dat.cr_observacion = item.cr_observacion;
                    dat.cr_estado = item.cr_estado;
                    dat.CompCobro_IdTipoCbte = item.CompCobro_IdTipoCbte;
                    dat.CompCobro_IdCbteCble = item.CompCobro_IdCbteCble;
                    dat.CompCobro_cb_Fecha = item.CompCobro_cb_Fecha;
                    dat.CompCobro_Valor = item.CompCobro_Valor;
                    dat.Deposito_IdTipocbte = item.Deposito_IdTipocbte;
                    dat.Deposito_IdCbteCble = item.Deposito_IdCbteCble;
                }
                return (dat);
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
