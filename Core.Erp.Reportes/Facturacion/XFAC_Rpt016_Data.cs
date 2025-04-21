using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Info.Inventario;

namespace Core.Erp.Reportes.Facturacion
{
    public class XFAC_Rpt016_Data
    {
        public List<XFAC_Rpt016_Info> Get_ListCostoProductoVendido_Detalle(int IdEmpresa, int IdSucursal, DateTime FechaIni, DateTime FechaFin, string IdUsuario,
            List<Int32> List_IdCliente, List<Int32> List_IdMarca)
        {
            try
            {
                List<XFAC_Rpt016_Info> lista = new List<XFAC_Rpt016_Info>();

                using (EntitiesFacturacion_Reportes conexion = new EntitiesFacturacion_Reportes())
                {

                    var querry = from q in conexion.spFAC_Rpt016(IdEmpresa, IdSucursal,FechaIni, FechaFin,IdUsuario)
                                 where List_IdMarca.Contains(q.IdMarca)
                                 && List_IdCliente.Contains(q.IdCliente)
                                 select q;
                                       
                    foreach (var item in querry)
                    {
                        XFAC_Rpt016_Info itemInfo = new XFAC_Rpt016_Info();
                        itemInfo.IdEmpresa = item.IdEmpresa;
                        itemInfo.IdSucursal = item.IdSucursal;
                        itemInfo.IdBodega  =item.IdBodega;
                        itemInfo.TipoDoc  =item.TipoDoc;
                        itemInfo.IdCbteVta  =item.IdCbteVta;                        
                        itemInfo.IdCliente  = item.IdCliente;
                        itemInfo.nom_cliente  =item.nom_cliente;
                        itemInfo.vt_cantidad  =item.vt_cantidad;
                        itemInfo.vt_Precio  =item.vt_Precio;
                        itemInfo.vt_Peso  =item.vt_Peso;
                        itemInfo.vt_peso_total  = item.vt_peso_total;
                        itemInfo.mv_costo  =item.mv_costo;
                        itemInfo.vt_costo_total  =item.vt_costo_total;
                        itemInfo.vt_venta_bruta  =item.vt_venta_bruta;
                        itemInfo.vt_venta_neta  =item.vt_venta_neta;
                        itemInfo.vt_DescUnitario  =item.vt_DescUnitario;
                        itemInfo.vt_PorDescUnitario  =item.vt_PorDescUnitario;
                        itemInfo.vt_Subtotal  = item.vt_Subtotal;
                        itemInfo.vt_iva  =item.vt_iva;
                        itemInfo.vt_por_iva  =item.vt_por_iva;
                        itemInfo.vt_total  =item.vt_total;
                        itemInfo.vt_fecha  =item.vt_fecha;
                        itemInfo.IdProducto  =item.IdProducto;
                        itemInfo.pr_descripcion  =item.pr_descripcion;
                        itemInfo.IdMarca  =item.IdMarca;
                        itemInfo.marca  =item.marca;
                        itemInfo.IdGrupo  =item.IdGrupo;
                        itemInfo.nom_grupo = item.nom_grupo;

                        lista.Add(itemInfo);
                    }
                }

                return lista; 
            }
            catch (Exception ex)
            {
                return new List<XFAC_Rpt016_Info>();
            }
        }
    }
}