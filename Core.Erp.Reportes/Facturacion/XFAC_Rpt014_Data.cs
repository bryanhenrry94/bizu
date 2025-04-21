using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Info.Inventario;

namespace Core.Erp.Reportes.Facturacion
{
    public class XFAC_Rpt014_Data
    {
        public List<XFAC_Rpt014_Info> Get_ListCostoProductoVendido(int IdEmpresa, int IdSucursal, DateTime FechaIni, DateTime FechaFin, string IdUsuario,
           List<Int32> List_IdCliente, List<Int32> List_IdMarca, bool bMostrarDetalle)
        {
            try
            {
                List<XFAC_Rpt014_Info> lista = new List<XFAC_Rpt014_Info>();

                using (EntitiesFacturacion_Reportes conexion = new EntitiesFacturacion_Reportes())
                {
                    
                    //INSERTAMOS FILTRO DE CLIENTE
                    if (List_IdCliente.Count() > 0)
                    {
                        string sql = "delete fa_filtro_cliente where IdEmpresa=" + IdEmpresa + " and IdSucursal = "+ IdSucursal +" and IdUsuario='" + IdUsuario + "'";

                        conexion.Database.ExecuteSqlCommand(sql);

                        foreach (var itemCC in List_IdCliente)
                        {
                            var Address = new fa_filtro_cliente();

                            Address.IdEmpresa = IdEmpresa;
                            Address.IdSucursal = IdSucursal;
                            Address.IdUsuario = IdUsuario;
                            Address.IdCliente = itemCC;
                            conexion.fa_filtro_cliente.Add(Address);
                            conexion.SaveChanges();
                        }
                    }               

                    //EJECUTAMOS PROCESO DE COSTO PRODUCTO VENDIDO
                    var querry = from q in conexion.spFAC_Rpt014(
                                 IdEmpresa,
                                 IdSucursal,
                                 FechaIni,
                                 FechaFin,
                                 IdUsuario                                 
                                 )
                                 where List_IdMarca.Contains(q.IdMarca)                                 
                                 select q;                                       

                    foreach (var item in querry)
                    {
                        XFAC_Rpt014_Info itemInfo = new XFAC_Rpt014_Info();
                        itemInfo.IdEmpresa = item.IdEmpresa;
                        itemInfo.IdSucursal = item.IdSucursal;
                        itemInfo.IdBodega = item.IdBodega;
                        itemInfo.IdMarca = item.IdMarca;
                        itemInfo.marca = item.marca;
                        itemInfo.IdGrupo = item.IdGrupo;
                        itemInfo.nom_grupo = item.nom_grupo;
                        itemInfo.vt_cantidad = item.vt_cantidad;
                        itemInfo.vt_Precio = item.vt_Precio;
                        itemInfo.vt_peso_total = item.vt_peso_total;
                        itemInfo.vt_costo_total = item.vt_costo_total;
                        itemInfo.vt_total = item.vt_total;
                        itemInfo.vt_DescUnitario = item.vt_DescUnitario;
                        itemInfo.vt_venta_bruta = Convert.ToDouble(item.vt_venta_bruta);
                        itemInfo.vt_venta_neta = item.vt_venta_neta;
                        itemInfo.vt_Subtotal = item.vt_Subtotal;
                        itemInfo.vt_iva = item.vt_iva;
                        itemInfo.vt_por_iva = item.vt_por_iva;

                        itemInfo.vt_PorDescUnitario = (Convert.ToDouble(item.vt_venta_bruta) == 0) ? 0 : item.vt_DescUnitario / Convert.ToDouble(item.vt_venta_bruta);
                        itemInfo.por_costoVenta = (Convert.ToDouble(item.vt_venta_neta) == 0) ? 0 : Convert.ToDouble(item.vt_costo_total) / Convert.ToDouble(item.vt_venta_neta);

                        itemInfo.vt_utilidad_bruta = Convert.ToDouble(item.vt_venta_neta) - Convert.ToDouble(item.vt_costo_total);
                        
                        itemInfo.por_utilidad_bruta = (Convert.ToDouble(itemInfo.vt_venta_neta) == 0) ? 0 : 
                            Convert.ToDouble(itemInfo.vt_utilidad_bruta) / Convert.ToDouble(itemInfo.vt_venta_neta);

                        itemInfo.precio_Unit_KG = (Convert.ToDouble(item.vt_peso_total) == 0) ? 0 :
                            Convert.ToDouble(item.vt_venta_neta) / Convert.ToDouble(item.vt_peso_total);

                        itemInfo.costo_Unit_KG = (Convert.ToDouble(item.vt_peso_total) == 0) ? 0 :
                            Convert.ToDouble(item.vt_costo_total) / Convert.ToDouble(item.vt_peso_total);

                        lista.Add(itemInfo);                         
                    }
                }

                return lista; 
            }
            catch (Exception ex)
            {
                return new List<XFAC_Rpt014_Info>();
            }
        }
                 
    }
}