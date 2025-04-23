using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bizu.Domain.General;
using Bizu.Infrastructure.General;

namespace Bizu.Reports.Inventario
{
    public class XINV_Rpt041_Data
    {
        tb_Empresa_Data dataEmp = new tb_Empresa_Data();
        tb_Empresa_Info infoEmp = new tb_Empresa_Info();

        public List<XINV_Rpt041_Info> consultar_data(int IdEmpresa, int IdSucursal, decimal IdGuiaRemision, ref string mensaje)
        {
            try
            {
                List<XINV_Rpt041_Info> listadedatos = new List<XINV_Rpt041_Info>();
                using (Entities_Inventario_General ingresoVarios = new Entities_Inventario_General())
                {
                    var select = from h in ingresoVarios.vwINV_Rpt041
                                 where h.IdEmpresa == IdEmpresa
                                 && h.IdSucursal == IdSucursal
                                 && h.IdGuiaRemision == IdGuiaRemision
                                 select h;

                    foreach (var item in select)
                    {
                        XINV_Rpt041_Info itemInfo = new XINV_Rpt041_Info();
                        itemInfo.IdEmpresa = item.IdEmpresa;
                        itemInfo.IdSucursal = item.IdSucursal;
                        itemInfo.IdGuiaRemision = item.IdGuiaRemision;
                        itemInfo.IdBodega = item.IdBodega;
                        itemInfo.FechaEmision = item.FechaEmision;
                        itemInfo.FechaTrasladoIni = item.FechaTrasladoIni;
                        itemInfo.FechaTrasladoFin = item.FechaTrasladoFin;
                        itemInfo.Serie1 = item.Serie1;
                        itemInfo.Serie2 = item.Serie2;
                        itemInfo.NumDocumento = item.NumDocumento;
                        itemInfo.IdTipo_Persona = item.IdTipo_Persona;
                        itemInfo.IdEntidad = item.IdEntidad;
                        itemInfo.Origen = item.Origen;
                        itemInfo.Destino = item.Destino;
                        itemInfo.Observacion = item.Observacion;
                        itemInfo.IdMotivo = item.IdMotivo;
                        itemInfo.Estado = item.Estado;
                        itemInfo.Secuencia = item.Secuencia;
                        itemInfo.IdProducto = item.IdProducto;
                        itemInfo.Codigo = item.Codigo;
                        itemInfo.Descripcion = item.Descripcion;
                        itemInfo.Detalle_x_Item = item.Detalle_x_Item;
                        itemInfo.Cantidad = item.Cantidad;
                        itemInfo.IdUnidadMedida = item.IdUnidadMedida;
                        itemInfo.Peso = item.Peso;
                        itemInfo.Cantidad_sinConversion = item.Cantidad_sinConversion;
                        itemInfo.IdUnidadMedida_sinConversion = item.IdUnidadMedida_sinConversion;
                        itemInfo.IdCentroCosto = item.IdCentroCosto;
                        itemInfo.EmbarqueTipo = item.EmbarqueTipo;
                        itemInfo.Ruta = item.Ruta;
                        itemInfo.Contenedor = item.Contenedor;
                        itemInfo.Sello = item.Sello;
                        itemInfo.Vapor = item.Vapor;
                        itemInfo.Embalaje = item.EmbarqueTipo;
                        itemInfo.PesoNeto = item.PesoNeto;
                        itemInfo.PesoBruto = item.PesoBruto;
                        itemInfo.Exportador_nombre = item.Exportador_nombre;
                        itemInfo.Exportador_direccion = item.Exportador_direccion;
                        itemInfo.Exportador_correo = item.Exportador_correo;
                        itemInfo.Exportador_telefono = item.Exportador_telefono;
                        itemInfo.Exportador_fax = item.Exportador_fax;
                        itemInfo.Comprador_nombre = item.Comprador_nombre;
                        itemInfo.Comprador_direccion = item.Comprador_direccion;
                        itemInfo.Comprador_correo = item.Comprador_correo;
                        itemInfo.Comprador_telefono = item.Comprador_telefono;
                        itemInfo.Comprador_fax = item.Comprador_fax;

                        listadedatos.Add(itemInfo);
                    }
                }
                return listadedatos;
            }
            catch (Exception ex)
            {

                return new List<XINV_Rpt041_Info>();
            }
        }
    }
}