using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Reportes.Facturacion
{
    public class XFAC_Rpt015_Data
    {
        public List<XFAC_Rpt015_Info> Get_Data(int IdEmpresa, int IdSucursalIni, int IdSucursalFin, int IdBodegaIni,
          int IdBodegaFin, int IdVendedorIni, int IdVendedorFin, DateTime FechaIni, DateTime FechaFin, int IdClienteIni, int IdClienteFin)
        {
            try
            {
                List<XFAC_Rpt015_Info> lista = new List<XFAC_Rpt015_Info>();

                using (EntitiesFacturacion_Reportes conexion = new EntitiesFacturacion_Reportes())
                {

                    IdSucursalIni = (IdSucursalIni != 0) ? IdSucursalIni : 0;
                    IdSucursalFin = (IdSucursalFin != 0) ? IdSucursalFin : 99999999;

                    IdBodegaIni = (IdBodegaIni != 0) ? IdBodegaIni : 0;
                    IdBodegaFin = (IdBodegaFin != 0) ? IdBodegaFin : 99999999;

                    IdVendedorIni = (IdVendedorIni != 0) ? IdVendedorIni : 0;
                    IdVendedorFin = (IdVendedorFin != 0) ? IdVendedorFin : 99999999;

                    IdClienteIni = (IdClienteIni != 0) ? IdClienteIni : 0;
                    IdClienteFin = (IdClienteFin != 0) ? IdClienteFin : 99999999;
                    
                    //var select = from h in conexion.spFAC_Rpt015(IdEmpresa, IdSucursalIni, IdSucursalFin, IdClienteIni, IdClienteFin, IdVendedorIni,
                    //                 IdVendedorFin, IdBodegaIni, IdBodegaFin, FechaIni, FechaFin)
                    //             select h;
                    var select = from h in conexion.spFAC_Rpt015(IdEmpresa, IdClienteIni, IdClienteFin, IdSucursalIni, IdSucursalFin, IdBodegaIni, IdBodegaFin, IdVendedorIni,
                                     IdVendedorFin, FechaIni, FechaFin)
                                 select h;



                    foreach (var item in select)
                    {
                        XFAC_Rpt015_Info itemInfo = new XFAC_Rpt015_Info();
                        itemInfo.IdEmpresa = item.IdEmpresa;
                        itemInfo.IdSucursal = item.IdSucursal;
                        itemInfo.IdBodega = item.IdBodega;
                        itemInfo.IdCbteVta = item.IdCbteVta;
                        itemInfo.IdVendedor = item.IdVendedor;
                        itemInfo.Ve_Vendedor = item.Ve_Vendedor;
                        itemInfo.NumeroFactura = item.NumeroFactura;
                        itemInfo.pe_nombreCompleto = item.pe_nombreCompleto;
                        itemInfo.subtotal = item.subtotal;
                        itemInfo.total_iva = item.total_iva;
                        itemInfo.total = item.total;
                        itemInfo.cantidad = item.cantidad;
                        itemInfo.fecha = item.fecha;
                        itemInfo.descuento = item.descuento;
                        
                        lista.Add(itemInfo);
                    }
                }

                return lista; 
            }
            catch (Exception ex)
            {
                return new List<XFAC_Rpt015_Info>();
            }
        }
    }
}
