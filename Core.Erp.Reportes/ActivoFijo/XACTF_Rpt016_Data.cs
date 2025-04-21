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
    public class XACTF_Rpt016_Data
    {
        public List<XACTF_Rpt016_Info> Consultar_Data(int IdEmpresa, int IdActivoFijo)
        {
            try
            {
                List<XACTF_Rpt016_Info> lstRpt = new List<XACTF_Rpt016_Info>();

                using (Entities_ActivoFijo_Reportes listado = new Entities_ActivoFijo_Reportes())
                {
                    var select = from q in listado.vwACTF_Rpt016
                                 where q.IdEmpresa == IdEmpresa
                                 && q.IdActivoFijo == IdActivoFijo
                                 select q;

                    foreach (var item in select)
                    {
                        XACTF_Rpt016_Info info = new XACTF_Rpt016_Info();
                        info.IdEmpresa = item.IdEmpresa;
                        info.IdActivoFijo = item.IdActivoFijo;
                        info.CodActivoFijo = item.CodActivoFijo;
                        info.Af_Codigo_Barra = item.Af_Codigo_Barra;
                        info.Af_Nombre = item.Af_Nombre;
                        info.IdProveedor = item.IdProveedor;
                        info.nom_proveedor = item.nom_proveedor;
                        info.IdDepartamento = item.IdDepartamento;
                        info.nom_departamento = item.nom_departamento;
                        info.IdEncargado = item.IdEncargado;
                        info.nom_encargado = item.nom_encargado;
                        info.IdOrdenCompra = item.IdOrdenCompra;
                        info.Af_fecha_compra = item.Af_fecha_compra;
                        info.num_factura = item.num_factura;

                        lstRpt.Add(info);
                    }
                }

                return lstRpt;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
        }
    }
}