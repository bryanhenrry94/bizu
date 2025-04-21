using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Core.Erp.Business.General;
using Core.Erp.Info.General;
using Core.Erp.Data.General;

namespace Core.Erp.Reportes.Compras
{
    public class XCOMP_Rpt011_Data
    {
        public List<XCOMP_Rpt011_Info> Cargar_data(int IdEmpresa, int IdSucursal, int IdProveedor, string IdCentroCosto, DateTime Fecha_Desde, DateTime Fecha_Hasta)
        {
            try
            {
                List<XCOMP_Rpt011_Info> Lista = new List<XCOMP_Rpt011_Info>();

                int IdSucursal_ini = IdSucursal;
                int IdSucursal_fin = IdSucursal == 0 ? 9999 : IdSucursal;

                int IdProveedor_Ini = IdProveedor;
                int IdProveedor_Fin = IdProveedor == 0 ? 9999 : IdProveedor;

                Fecha_Desde = Fecha_Desde.Date;
                Fecha_Hasta = Fecha_Hasta.Date;

                using (EntitiesCompra_reporte_Ge Context = new EntitiesCompra_reporte_Ge())
                {
                    var lst = from q in Context.vwCOMP_Rpt011
                              where q.IdEmpresa == IdEmpresa
                              && q.IdSucursal == IdSucursal
                              && q.IdProveedor >= IdProveedor_Ini
                              && q.IdProveedor <= IdProveedor_Fin
                              && q.oc_fecha >= Fecha_Desde
                              && q.oc_fecha <= Fecha_Hasta
                              select q;

                    if (!string.IsNullOrEmpty(IdCentroCosto))
                        lst = lst.Where(q => q.IdCentroCosto == IdCentroCosto);

                    foreach (var item in lst)
                    {
                        XCOMP_Rpt011_Info info = new XCOMP_Rpt011_Info();
                        info.IdEmpresa = item.IdEmpresa;
                        info.IdSucursal = item.IdSucursal;
                        info.IdOrdenCompra = item.IdOrdenCompra;
                        info.Secuencia = item.Secuencia;
                        info.oc_fecha = item.oc_fecha;
                        info.oc_fechaVencimiento = item.oc_fechaVencimiento;
                        info.IdProveedor = item.IdProveedor;
                        info.nom_proveedor = item.nom_proveedor;
                        info.IdComprador = item.IdComprador;
                        info.Nom_Comprador = item.Nom_Comprador;
                        info.oc_observacion = item.oc_observacion;
                        info.Estado = item.Estado;
                        info.nom_EstadoCerrado = item.nom_EstadoCerrado;
                        info.IdEstadoAprobacion_cat = item.IdEstadoAprobacion_cat;
                        info.ap_descripcion = item.ap_descripcion;
                        info.IdUsuario_Aprueba = item.IdUsuario_Aprueba;
                        info.co_fecha_aprobacion = item.co_fecha_aprobacion;
                        info.Fecha_Transac = item.Fecha_Transac;
                        info.IdProducto = item.IdProducto;
                        info.pr_codigo = item.pr_codigo;
                        info.pr_descripcion = item.pr_descripcion;
                        info.do_Cantidad = item.do_Cantidad;
                        info.do_precioCompra = item.do_precioCompra;
                        info.do_precioFinal = item.do_precioFinal;
                        info.do_subtotal = item.do_subtotal;
                        info.do_iva = item.do_iva;
                        info.do_total = item.do_total;
                        info.IdCentroCosto = item.IdCentroCosto;
                        info.ID = item.ID;
                        info.ParentID = item.ParentID;
                        info.IdProyecto = item.IdProyecto;
                        info.IdOferta = item.IdOferta;
                        info.Secuencia_Oferta = item.Secuencia_Oferta;
                        info.Rubro = item.Rubro;
                        info.Subtotal_Rubro = item.Subtotal_Rubro;
                        info.nom_proyecto = item.nom_proyecto;

                        Lista.Add(info);
                    }
                }

                return Lista;
            }
            catch (Exception ex)
            {
                string MensajeError = "";
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", "", "", "", "", "", "", DateTime.Now);
                MensajeError = ex.ToString();
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);

                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "get_list", ex.Message), ex) { EntityType = typeof(XCOMP_Rpt008_Data) };
            }
        }
    }
}