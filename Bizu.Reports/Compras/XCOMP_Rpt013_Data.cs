using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bizu.Application.General;
using Bizu.Domain.General;
using Bizu.Infrastructure.General;

namespace Bizu.Reports.Compras
{
    public class XCOMP_Rpt013_Data
    {
        public List<XCOMP_Rpt013_Info> Cargar_data(int IdEmpresa, int IdSucursal,
                        decimal IdProducto,
                        int IdProveedor,
                        string IdCategoria,
                        int IdLinea,
                        string IdCentroCosto,
                        DateTime FechaIni,
                        DateTime FechaFin)
        {
            try
            {
                List<XCOMP_Rpt013_Info> listadedatos = new List<XCOMP_Rpt013_Info>();
                FechaIni = Convert.ToDateTime(FechaIni.ToShortDateString());
                FechaFin = Convert.ToDateTime(FechaFin.ToShortDateString());

                int IdSucursalIni = IdSucursal;
                int IdSucursalFin = IdSucursal == 0 ? 9999 : IdSucursal;

                decimal IdProductoIni = IdProducto;
                decimal IdProductoFin = IdProducto == 0 ? 99999 : IdProducto;

                int IdProveedorIni = IdProveedor;
                int IdProveedorFin = IdProveedor == 0 ? 99999 : IdProveedor;

                using (EntitiesCompra_reporte_Ge ListadoOrdenCompra = new EntitiesCompra_reporte_Ge())
                {
                    var query = from h in ListadoOrdenCompra.vwCOMP_Rpt013
                                 where h.IdEmpresa == IdEmpresa
                                 && h.IdSucursal >= IdSucursalIni && h.IdSucursal <= IdSucursalFin
                                 && h.IdProveedor >= IdProveedorIni && h.IdProveedor <= IdProveedorFin
                                 && h.IdProducto >= IdProductoIni && h.IdProducto <= IdProductoFin
                                 && h.oc_fecha >= FechaIni && h.oc_fecha <= FechaFin
                                 select h;

                    if (!string.IsNullOrEmpty(IdCategoria))
                    {
                        query = query.Where(q => q.IdCategoria == IdCategoria);
                    }

                    if(IdLinea != 0)
                    {
                        query = query.Where(q => q.IdLinea == IdLinea);
                    }

                    if (!string.IsNullOrEmpty(IdCentroCosto))
                    {
                        query = query.Where(q => q.IdCentroCosto == IdCentroCosto);
                    }

                    foreach (var item in query)
                    {
                        XCOMP_Rpt013_Info itemInfo = new XCOMP_Rpt013_Info();
                        itemInfo.IdEmpresa = item.IdEmpresa;
                        itemInfo.IdSucursal = item.IdSucursal;
                        itemInfo.IdOrdenCompra = item.IdOrdenCompra;
                        itemInfo.IdProveedor = item.IdProveedor;
                        itemInfo.IdProducto = item.IdProducto;
                        itemInfo.em_nombre = item.em_nombre;
                        itemInfo.pr_nombre = item.pr_nombre;
                        itemInfo.oc_plazo = item.oc_plazo;
                        itemInfo.oc_fecha = item.oc_fecha;
                        itemInfo.pr_codigo = item.pr_codigo;
                        itemInfo.CantidadRecibida = item.CantidadRecibida;
                        itemInfo.Saldo = item.Saldo;
                        itemInfo.do_Cantidad = item.do_Cantidad;
                        itemInfo.IdUnidadMedida = item.IdUnidadMedida;
                        itemInfo.pr_descripcion = item.pr_descripcion;
                        itemInfo.IdCategoria = item.IdCategoria;
                        itemInfo.nom_categoria = item.nom_categoria;
                        itemInfo.IdLinea = item.IdLinea;
                        itemInfo.nom_linea = item.nom_linea;
                        itemInfo.pr_peso = item.pr_peso;
                        itemInfo.do_precioCompra = item.do_precioCompra;
                        itemInfo.do_subtotal = item.do_subtotal;
                        itemInfo.do_Subtotal_SinDescuento = item.do_Subtotal_SinDescuento;
                        itemInfo.do_iva = item.do_iva;
                        itemInfo.do_total = item.do_total;
                        itemInfo.do_descuento = item.do_descuento;
                        itemInfo.do_porc_des = item.do_porc_des;
                        itemInfo.pr_contribuyenteEspecial = item.pr_contribuyenteEspecial;
                        itemInfo.oc_NumDocumento = item.oc_NumDocumento;
                        itemInfo.Usuario_Solicitante = item.Usuario_Solicitante;
                        itemInfo.Usuario_Procesa = item.Usuario_Procesa;
                        itemInfo.Usuario_Aprueba = item.Usuario_Aprueba;
                        itemInfo.TerminoPago = item.TerminoPago;
                        itemInfo.DiasTerminoPago = item.DiasTerminoPago;
                        itemInfo.UnidadMedidaConsumo = item.UnidadMedidaConsumo;
                        itemInfo.IdCentroCosto = item.IdCentroCosto;
                        itemInfo.Centro_costo = item.Centro_costo;
                        itemInfo.detalle_x_item = item.detalle_x_item;
                        itemInfo.oc_observacion = item.oc_observacion;
                        itemInfo.IdEstadoAprobacion_cat = item.IdEstadoAprobacion_cat;
                        itemInfo.Estado = item.Estado;

                        listadedatos.Add(itemInfo);
                    }
                }

                return listadedatos;
            }
            catch (Exception ex)
            {
                string MensajeError = "";
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", "", "", "", "", "", "", DateTime.Now);
                MensajeError = ex.ToString();
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "Get_Data_Reporte", ex.Message), ex) { EntityType = typeof(XCOMP_Rpt013_Data) };
            }
        }
    }
}