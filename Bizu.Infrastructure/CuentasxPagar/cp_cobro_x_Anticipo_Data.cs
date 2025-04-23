using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bizu.Domain.CuentasxPagar;
using Bizu.Infrastructure.General;
using Bizu.Domain.General;

namespace Bizu.Infrastructure.CuentasxPagar
{
   public  class cp_cobro_x_Anticipo_Data
    {

        string mensaje = "";

        public List<cp_cobro_x_Anticipo_Info> Get_List_cobro_x_Anticipo(int IdEmpresa, ref string mensaje)
        {
            try
            {
                List<cp_cobro_x_Anticipo_Info> Lst = new List<cp_cobro_x_Anticipo_Info>();
                List<cp_cobro_x_Anticipo_Info> Lista = new List<cp_cobro_x_Anticipo_Info>();
                using (EntitiesCuentasxPagar cp = new EntitiesCuentasxPagar())
                {
                    var consultar = from q in cp.vwcp_Anticipos_Proveedores
                                    orderby q.IdTipo_op
                                    select q;

                    foreach (var item in consultar)
                    {
                        cp_cobro_x_Anticipo_Info info = new cp_cobro_x_Anticipo_Info();

                        info.idempresa = item.idempresa;
                        info.IdOrdenPago = item.IdOrdenPago;
                        info.pr_nombre = item.pr_nombre;
                        info.Observacion = item.Observacion;
                        info.IdTipo_op = item.IdTipo_op;
                        info.IdEntidad = item.IdEntidad;
                        info.Fecha_Pago = item.Fecha_Pago;
                        info.IdFormaPago = item.IdFormaPago;
                        info.Valor_a_pagar = item.Valor_a_pagar;
                        info.IdEstadoAprobacion = item.IdEstadoAprobacion;
                        info.Estado = item.Estado;
                        info.IdCbteCble_cxp = item.IdCbteCble_cxp;
                        if (item.IdCbteCble_cxp != null && item.Factura == null)
                        {
                            info.Factura = "N/D";
                        }
                        else
                        {
                            info.Factura = item.Factura;
                        }
                        
                        info.Total_Pagado_Fact = item.Total_Pagado_Fact;
                                           
                        Lst.Add(info);
                    }
                    Lista = new List<cp_cobro_x_Anticipo_Info>(Lst.OrderByDescending(d => d.IdOrdenPago));
                }
                return Lista;
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
