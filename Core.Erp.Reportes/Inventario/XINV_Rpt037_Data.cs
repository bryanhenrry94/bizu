using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Reportes.Inventario
{
    public class XINV_Rpt037_Data
    {
        public List<XINV_Rpt037_Info> Get_Data(int IdEmpresa, int IdSucursal, int IdBodega, int IdMov_inven_tipo, int IdNumMovi, decimal IdProducto)
        {
            try
            {
                Int32 IdSucursalIni = (IdSucursal != 0) ? IdSucursal : 0;
                Int32 IdSucursalFin = (IdSucursal != 0) ? IdSucursal : 99999999;

                Int32 IdBodegaIni = (IdBodega != 0) ? IdBodega : 0;
                Int32 IdBodegaFin = (IdBodega != 0) ? IdBodega : 99999999;                

                List<XINV_Rpt037_Info> lista = new List<XINV_Rpt037_Info>();
                using (Entities_Inventario_General conexion = new Entities_Inventario_General())
                {
                    var querry = from q in conexion.vwINV_Rpt037
                                 where q.IdEmpresa == IdEmpresa
                                    && q.IdSucursal >= IdSucursalIni && q.IdSucursal <= IdSucursalFin
                                    && q.IdBodega >= IdBodegaIni && q.IdBodega <= IdBodegaFin                                                                        
                                    && q.IdMovi_inven_tipo == IdMov_inven_tipo 
                                    && q.IdNumMovi == IdNumMovi
                                    && q.IdProducto == IdProducto                                                                        
                                 select q;

                    foreach (var item in querry)
                    {

                        XINV_Rpt037_Info itemInfo = new XINV_Rpt037_Info();

                        itemInfo.IdEmpresa = item.IdEmpresa;
                        itemInfo.IdSucursal = item.IdSucursal;
                        itemInfo.IdBodega = item.IdBodega;
                        itemInfo.IdMovi_inven_tipo = item.IdMovi_inven_tipo;
                        itemInfo.IdNumMovi = item.IdNumMovi;
                        itemInfo.Secuencia = item.Secuencia;
                        itemInfo.IdProducto = item.IdProducto;
                        itemInfo.pr_codigo = item.pr_codigo;
                        itemInfo.pr_descripcion = item.pr_descripcion;
                        itemInfo.IdCentroCosto = item.IdCentroCosto;
                        itemInfo.Centro_costo = item.Centro_costo;
                        itemInfo.TipoDocumento = item.TipoDocumento;
                        itemInfo.numDocumento = item.numDocumento;
                        itemInfo.IdOrdenCompra = item.IdOrdenCompra;
                        itemInfo.IdProveedor = item.IdProveedor;
                        itemInfo.pe_cedulaRuc = item.pe_cedulaRuc;
                        itemInfo.Proveedor = item.Proveedor;
                        itemInfo.Fecha_Transac = item.Fecha_Transac;
                        itemInfo.cm_fecha = item.cm_fecha;
                        itemInfo.cm_observacion = item.cm_observacion;
                        itemInfo.pr_codigo_barra = item.pr_codigo_barra;

                        lista.Add(itemInfo);
                    }
                }
                return lista.OrderBy(q=>q.IdNumMovi).ToList();

            }
            catch (Exception ex)
            {                
                return new List<XINV_Rpt037_Info>();
            }
        }
    }
}
