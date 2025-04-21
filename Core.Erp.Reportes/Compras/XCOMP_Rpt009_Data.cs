using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Core.Erp.Business.General;
using Core.Erp.Info.General;
using Core.Erp.Data.General;

namespace Core.Erp.Reportes.Compras
{
    public class XCOMP_Rpt009_Data
    {
        public List<XCOMP_Rpt009_Info> Cargar_data(int IdEmpresa, int IdSucursal, decimal IdProducto, string IdCentroCosto, DateTime Fecha_ini, DateTime Fecha_fin)
        {
            try
            {
                List<XCOMP_Rpt009_Info> Lista = new List<XCOMP_Rpt009_Info>();

                int IdSucursal_ini = IdSucursal;
                int IdSucursal_fin = IdSucursal == 0 ? 9999 : IdSucursal;

                decimal IdProducto_ini = IdProducto;
                decimal IdProducto_fin = IdProducto == 0 ? 99909 : IdProducto;

                Fecha_ini = Fecha_ini.Date;
                Fecha_fin = Fecha_fin.Date;

                using (EntitiesCompra_reporte_Ge Context = new EntitiesCompra_reporte_Ge())
                {
                    var lst = from q in Context.vwCOMP_Rpt009
                              where q.IdEmpresa == IdEmpresa
                              && IdSucursal_ini <= q.IdSucursal && q.IdSucursal <= IdSucursal_fin
                              && IdProducto_ini <= q.IdProducto && q.IdProducto <= IdProducto_fin
                              && Fecha_ini <= q.fecha && q.fecha <= Fecha_fin
                              select q;

                    foreach (var rpt in lst)
                    {
                        XCOMP_Rpt009_Info item = new XCOMP_Rpt009_Info
                        {
                            IdEmpresa = rpt.IdEmpresa,
                            IdSucursal = rpt.IdSucursal,
                            IdSolicitudCompra = rpt.IdSolicitudCompra,
                            Sucursal = rpt.Sucursal,
                            fecha = rpt.fecha,
                            plazo = rpt.plazo,
                            fecha_vtc = rpt.fecha_vtc,
                            observacion = rpt.observacion,
                            Estado = rpt.Estado,
                            IdEstadoAprobacion = rpt.IdEstadoAprobacion,
                            nom_EstadoAprobacion = rpt.nom_EstadoAprobacion,
                            IdPersona_Solicita = rpt.IdPersona_Solicita,
                            Solicitante = rpt.Solicitante,
                            IdProyecto = rpt.IdProyecto,
                            nom_proyecto = rpt.nom_proyecto,
                            Secuencia = rpt.Secuencia,
                            IdProducto = rpt.IdProducto,
                            cod_producto = rpt.cod_producto,
                            NomProducto = rpt.NomProducto,
                            Cantidad_Solicitada = rpt.Cantidad_Solicitada,
                            Cantidad_Comprada = rpt.Cantidad_Comprada,
                            Cantidad_Pendiente = rpt.Cantidad_Pendiente,
                            IdCentroCosto = rpt.IdCentroCosto,
                            IdUnidadMedida = rpt.IdUnidadMedida,
                            nom_Unidad = rpt.nom_Unidad,
                            nom_Unidad_Alterno = rpt.nom_Unidad_Alterno,
                            do_observacion = rpt.do_observacion,
                            IdOferta = rpt.IdOferta,
                            Secuencia_Oferta = rpt.Secuencia_Oferta,
                            Descripcion_Oferta = rpt.Descripcion_Oferta,
                            cod_rubro = rpt.cod_rubro,
                            nom_rubro = rpt.nom_rubro
                        };
                        item.nom_rubro_2 = (item.cod_rubro == null) ? "" : ("[" + item.cod_rubro.Trim() + "]-" + item.nom_rubro.Trim());
                        Lista.Add(item);
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
