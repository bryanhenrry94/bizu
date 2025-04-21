using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Business.General;
using Core.Erp.Info.General;
using Core.Erp.Data.General;

namespace Core.Erp.Reportes.Compras
{
    public class XCOMP_Rpt010_Data
    {
        public List<XCOMP_Rpt010_Info> Cargar_data(int IdEmpresa, int IdSucursal, int IdProveedor, string IdCentroCosto, DateTime Fecha_Desde, DateTime Fecha_Hasta, bool MostrarConSaldo, string IdUsuario)
        {
            try
            {
                List<XCOMP_Rpt010_Info> Lista = new List<XCOMP_Rpt010_Info>();

                int IdSucursal_ini = IdSucursal;
                int IdSucursal_fin = IdSucursal == 0 ? 9999 : IdSucursal;

                Fecha_Desde = Fecha_Desde.Date;
                Fecha_Hasta = Fecha_Hasta.Date;

                using (EntitiesCompra_reporte_Ge Context = new EntitiesCompra_reporte_Ge())
                {
                    var lst = from q in Context.spCOMP_Rpt010(IdEmpresa, IdSucursal, IdProveedor, IdCentroCosto, Fecha_Desde, Fecha_Hasta, MostrarConSaldo, IdUsuario)
                              select q;

                    foreach (var item in lst)
                    {
                        XCOMP_Rpt010_Info info = new XCOMP_Rpt010_Info();
                        info.IdEmpresa = item.IdEmpresa;
                        info.IdSucursal = item.IdSucursal;
                        info.IdOrdenCompra = item.IdOrdenCompra;
                        info.Tipo = item.Tipo;
                        info.Cbte = item.Cbte;
                        info.IdProveedor = item.IdProveedor;
                        info.nom_Proveedor = item.nom_Proveedor;
                        info.Referencia = item.Referencia;
                        info.Total_Debe = item.Total_Debe;
                        info.Total_Haber = item.Total_Haber;
                        info.Total_Saldo = item.Total_Saldo;
                        info.Debe_OC = item.Debe_OC;
                        info.Haber_OC = item.Haber_OC;
                        info.Saldo_OC = item.Saldo_OC;
                        info.Fecha_Documento = item.Fecha_Documento;
                        info.Observacion = item.Observacion;
                        info.Estado = item.Estado;
                        info.IdCentroCosto = item.IdCentroCosto;
                        info.Nivel = item.Nivel;

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