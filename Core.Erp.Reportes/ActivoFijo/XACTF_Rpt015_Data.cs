using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Business.General;
using Core.Erp.Info.General;
using Core.Erp.Data.General;

namespace Core.Erp.Reportes.ActivoFijo
{
    public class XACTF_Rpt015_Data
    {
        string mensaje = "";
        tb_Empresa_Bus busEmpresa = new tb_Empresa_Bus();
        tb_Empresa_Info Cbt = new tb_Empresa_Info();

        public List<XACTF_Rpt015_Info> get_RptCompraSinIngreso_AF(int IdEmpresa, DateTime FechaIni, DateTime FechaFin)
        {
            try
            {
                List<XACTF_Rpt015_Info> lstRpt = new List<XACTF_Rpt015_Info>();

                using (Entities_ActivoFijo_Reportes listado = new Entities_ActivoFijo_Reportes())
                {
                    var select = from q in listado.vwACTF_Rpt015
                                 where q.IdEmpresa == IdEmpresa
                                 && q.oc_fecha >= FechaIni && q.oc_fecha <= FechaFin
                                 select q;

                    Cbt = busEmpresa.Get_Info_Empresa(IdEmpresa);

                    foreach (var item in select)
                    {
                        XACTF_Rpt015_Info infoRpt = new XACTF_Rpt015_Info();
                        infoRpt.IdEmpresa = item.IdEmpresa;
                        infoRpt.IdSucursal = item.IdSucursal;
                        infoRpt.IdOrdenCompra = item.IdOrdenCompra;
                        infoRpt.oc_NumDocumento = item.oc_NumDocumento;
                        infoRpt.oc_fecha = item.oc_fecha;
                        infoRpt.IdProveedor = item.IdProveedor;
                        infoRpt.pr_nombre = item.pr_nombre;
                        infoRpt.Secuencia = item.Secuencia;
                        infoRpt.IdProducto = item.IdProducto;
                        infoRpt.do_Cantidad = item.do_Cantidad;
                        infoRpt.do_precioCompra = item.do_precioCompra;
                        infoRpt.do_descuento = item.do_descuento;
                        infoRpt.do_precioFinal = item.do_precioFinal;
                        infoRpt.do_subtotal = item.do_subtotal;
                        infoRpt.Por_Iva = item.Por_Iva;
                        infoRpt.do_iva = item.do_iva;
                        infoRpt.do_total = item.do_total;
                        infoRpt.IdBodega = item.IdBodega;
                        infoRpt.bo_Descripcion = item.bo_Descripcion;
                        infoRpt.Estado = (item.Estado == "A") ? "Activo" : "Inactivo";
                        infoRpt.pr_codigo = item.pr_codigo;
                        infoRpt.pr_descripcion = item.pr_descripcion;
                        
                        lstRpt.Add(infoRpt);
                    }
                }

                return lstRpt;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = ex.InnerException + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.ToString());
            }
        }
    }
}
