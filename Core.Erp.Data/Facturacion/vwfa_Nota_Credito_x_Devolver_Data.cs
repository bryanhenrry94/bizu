using Core.Erp.Data.General;
using Core.Erp.Info.Facturacion;
using Core.Erp.Info.General;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Data.Facturacion
{
    public class vwfa_Nota_Credito_x_Devolver_Data
    {
        public List<vwfa_Nota_Credito_x_Devolver_Info> Get_list_docs_x_cruzar_SinSaldo(int IdEmpresa, decimal IdCliente)
        {
            try
            {
                List<vwfa_Nota_Credito_x_Devolver_Info> Lista = new List<vwfa_Nota_Credito_x_Devolver_Info>();

                using (EntitiesFacturacion Context = new EntitiesFacturacion())
                {
                    var lst = from q in Context.vwfa_Nota_Credito_x_Devolver
                              where IdEmpresa == q.IdEmpresa
                              && IdCliente == q.IdCliente
                              && q.Estado == "A"
                              //&& q.Saldo != 0

                              select q;
                    foreach (var item in lst)
                    {
                        vwfa_Nota_Credito_x_Devolver_Info info = new vwfa_Nota_Credito_x_Devolver_Info();
                        info.IdEmpresa = item.IdEmpresa;
                        info.IdSucursal = item.IdSucursal;
                        info.IdBodega = item.IdBodega;
                        info.CreDeb = item.CreDeb;
                        info.Serie1 = item.Serie1;
                        info.Serie2 = item.Serie2;
                        info.NumDoc = item.NumDoc;
                        info.Documento = item.Documento;
                        info.sc_observacion = item.sc_observacion;
                        info.IdNota = item.IdNota;
                        info.CodNota = item.CodNota;
                        info.Su_Descripcion = item.Su_Descripcion;
                        info.IdCliente = item.IdCliente;
                        info.no_fecha = item.no_fecha;
                        info.sc_total = item.sc_total;
                        info.Saldo = item.Saldo;
                        info.totalCobrado = item.totalCobrado;
                        info.bo_Descripcion = item.bo_Descripcion;
                        info.sc_subtotal = item.sc_subtotal;
                        info.sc_iva = item.sc_iva;
                        info.no_fecha_venc = item.no_fecha_venc;
                        info.RtFT = item.RtFT;
                        info.RtIVA = item.RtIVA;
                        info.CodCliente = item.CodCliente;
                        info.NomCliente = item.NomCliente;
                        info.em_nombre = item.em_nombre;
                        info.Estado = item.Estado;

                        Lista.Add(info);
                    }
                }

                return Lista;
            }
            catch (Exception ex)
            {
                string mensaje = "";
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = ex.ToString();
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.ToString());
            }
        }
    }
}
