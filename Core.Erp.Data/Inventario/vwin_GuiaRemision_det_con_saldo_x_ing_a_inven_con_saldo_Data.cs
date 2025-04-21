using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Info.Inventario;

namespace Core.Erp.Data.Inventario
{
    public class vwin_GuiaRemision_det_con_saldo_x_ing_a_inven_con_saldo_Data
    {
        public List<vwin_GuiaRemision_det_con_saldo_x_ing_a_inven_con_saldo_Info> Get_List(int IdEmpresa, int IdSucursal, string IdCentroCosto)
        {
            try
            {
                List<vwin_GuiaRemision_det_con_saldo_x_ing_a_inven_con_saldo_Info> Lista = new List<vwin_GuiaRemision_det_con_saldo_x_ing_a_inven_con_saldo_Info>();

                EntitiesInventario context = new EntitiesInventario();

                var query = from q in context.vwin_GuiaRemision_det_con_saldo_x_ing_a_inven_con_saldo
                            where q.IdEmpresa == IdEmpresa
                            && q.IdSucursal == IdSucursal
                            && q.IdEstadoCierre == "ABI"
                            && q.Saldo_GR_x_Ing > 0
                            select q;

                if (!string.IsNullOrEmpty(IdCentroCosto))
                {
                    query = query.Where(q => q.IdCentroCosto == IdCentroCosto);
                }

                foreach (var item in query)
                {
                    vwin_GuiaRemision_det_con_saldo_x_ing_a_inven_con_saldo_Info Info = new vwin_GuiaRemision_det_con_saldo_x_ing_a_inven_con_saldo_Info();
                    Info.fila = Convert.ToInt32(item.fila);
                    Info.IdEmpresa = item.IdEmpresa;
                    Info.IdSucursal = item.IdSucursal;
                    Info.IdGuiaRemision = item.IdGuiaRemision;
                    Info.Secuencia = item.Secuencia;
                    Info.IdBodega = item.IdBodega;
                    Info.FechaEmision = item.FechaEmision;
                    Info.Serie1 = item.Serie1;
                    Info.Serie2 = item.Serie2;
                    Info.NumDocumento = item.NumDocumento;
                    Info.NumGuia = item.NumGuia;
                    Info.IdTipo_Persona = item.IdTipo_Persona;
                    Info.IdEntidad = item.IdEntidad;
                    Info.pe_nombreCompleto = item.pe_nombreCompleto;
                    Info.IdProyecto = item.IdProyecto;
                    Info.NomProyecto = item.NomProyecto;
                    Info.IdEstadoCierre = item.IdEstadoCierre;
                    Info.IdCentroCosto = item.IdCentroCosto;
                    Info.Centro_costo = item.Centro_costo;
                    Info.Centro_costo2 = (string.IsNullOrEmpty(item.IdCentroCosto)) ? "" : "[" + item.IdCentroCosto + "]-" + item.Centro_costo;
                    Info.Origen = item.Origen;
                    Info.Destino = item.Destino;
                    Info.Observacion = item.Observacion;
                    Info.IdMotivo = item.IdMotivo;
                    Info.Estado = item.Estado;
                    Info.FechaAutorizacion = item.FechaAutorizacion;
                    Info.NumAutorizacion = item.NumAutorizacion;
                    Info.IdProducto = item.IdProducto;
                    Info.Codigo = item.Codigo;
                    Info.Descripcion = item.Descripcion;
                    Info.Detalle_x_Item = item.Detalle_x_Item;
                    Info.cantidad_GR = item.cantidad_GR;
                    Info.Peso = item.Peso;
                    Info.cantidad_sinConversion_GR = item.cantidad_sinConversion_GR;
                    Info.IdUnidadMedida = item.IdUnidadMedida;
                    Info.IdUnidadMedida_sinConversion = item.IdUnidadMedida_sinConversion;
                    Info.cantidad_ing_a_Inven = item.cantidad_ing_a_Inven;
                    Info.cantidad_ingresada = item.cantidad_ingresada;
                    Info.Saldo_GR_x_Ing = item.Saldo_GR_x_Ing;

                    Lista.Add(Info);
                }

                return Lista;
            }
          catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<vwin_GuiaRemision_det_con_saldo_x_ing_a_inven_con_saldo_Info> Get_List(int IdEmpresa, int IdSucursal, decimal IdGuiaRemision)
        {
            try
            {
                List<vwin_GuiaRemision_det_con_saldo_x_ing_a_inven_con_saldo_Info> Lista = new List<vwin_GuiaRemision_det_con_saldo_x_ing_a_inven_con_saldo_Info>();

                EntitiesInventario context = new EntitiesInventario();

                var query = from q in context.vwin_GuiaRemision_det_con_saldo_x_ing_a_inven_con_saldo
                            where q.IdEmpresa == IdEmpresa
                            && q.IdSucursal == IdSucursal
                            && q.IdGuiaRemision == IdGuiaRemision
                            && q.IdEstadoCierre == "ABI"
                            && q.Saldo_GR_x_Ing > 0
                            select q;

                foreach (var item in query)
                {
                    vwin_GuiaRemision_det_con_saldo_x_ing_a_inven_con_saldo_Info Info = new vwin_GuiaRemision_det_con_saldo_x_ing_a_inven_con_saldo_Info();
                    Info.fila = Convert.ToInt32(item.fila);
                    Info.IdEmpresa = item.IdEmpresa;
                    Info.IdSucursal = item.IdSucursal;
                    Info.IdGuiaRemision = item.IdGuiaRemision;
                    Info.Secuencia = item.Secuencia;
                    Info.IdBodega = item.IdBodega;
                    Info.FechaEmision = item.FechaEmision;
                    Info.Serie1 = item.Serie1;
                    Info.Serie2 = item.Serie2;
                    Info.NumDocumento = item.NumDocumento;
                    Info.NumGuia = item.NumGuia;
                    Info.IdTipo_Persona = item.IdTipo_Persona;
                    Info.IdEntidad = item.IdEntidad;
                    Info.pe_nombreCompleto = item.pe_nombreCompleto;
                    Info.IdProyecto = item.IdProyecto;
                    Info.NomProyecto = item.NomProyecto;
                    Info.IdEstadoCierre = item.IdEstadoCierre;
                    Info.IdCentroCosto = item.IdCentroCosto;
                    Info.Centro_costo = item.Centro_costo;
                    Info.Centro_costo2 = (string.IsNullOrEmpty(item.IdCentroCosto)) ? "" : "[" + item.IdCentroCosto + "]-" + item.Centro_costo;
                    Info.Origen = item.Origen;
                    Info.Destino = item.Destino;
                    Info.Observacion = item.Observacion;
                    Info.IdMotivo = item.IdMotivo;
                    Info.Estado = item.Estado;
                    Info.FechaAutorizacion = item.FechaAutorizacion;
                    Info.NumAutorizacion = item.NumAutorizacion;
                    Info.IdProducto = item.IdProducto;
                    Info.Codigo = item.Codigo;
                    Info.Descripcion = item.Descripcion;
                    Info.Detalle_x_Item = item.Detalle_x_Item;
                    Info.cantidad_GR = item.cantidad_GR;
                    Info.Peso = item.Peso;
                    Info.cantidad_sinConversion_GR = item.cantidad_sinConversion_GR;
                    Info.IdUnidadMedida = item.IdUnidadMedida;
                    Info.IdUnidadMedida_sinConversion = item.IdUnidadMedida_sinConversion;
                    Info.cantidad_ing_a_Inven = item.cantidad_ing_a_Inven;
                    Info.cantidad_ingresada = item.cantidad_ingresada;
                    Info.Saldo_GR_x_Ing = item.Saldo_GR_x_Ing;

                    Lista.Add(Info);
                }

                return Lista;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}