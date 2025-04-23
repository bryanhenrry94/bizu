using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bizu.Domain.General;
using Bizu.Infrastructure.General;


namespace Bizu.Reports.Compras
{
    public class XCOMP_Rpt005_Data
    {
        string mensaje = "";
        tb_Empresa_Info Cbt = new tb_Empresa_Info();
        tb_Empresa_Data empresaData = new tb_Empresa_Data();

        public List<XCOMP_Rpt005_Info> get_PreAprobacion_Solicitud(List<XCOMP_Rpt005_Info> lstIdSolicitudCompra)
        {
            try
            {
                List<XCOMP_Rpt005_Info> lstInfo = new List<XCOMP_Rpt005_Info>();
                using (EntitiesCompra_reporte_Ge listado = new EntitiesCompra_reporte_Ge())
                {

                    var select = from q in lstIdSolicitudCompra
                                 join c in listado.vwCOMP_Rpt005 on new { q.IdEmpresa, q.IdSucursal, q.IdSolicitudCompra, q.Secuencia_SC }
                                 equals new { c.IdEmpresa, c.IdSucursal, c.IdSolicitudCompra, c.Secuencia_SC }
                                 select c;

                    Cbt = empresaData.Get_Info_Empresa(lstIdSolicitudCompra.First().IdEmpresa);

                    foreach (var rpt in select)
                    {
                        XCOMP_Rpt005_Info Info = new XCOMP_Rpt005_Info
                        {
                            IdEmpresa = rpt.IdEmpresa,
                            IdSucursal = rpt.IdSucursal,
                            IdSolicitudCompra = rpt.IdSolicitudCompra,
                            Secuencia_SC = rpt.Secuencia_SC,
                            IdProducto_SC = rpt.IdProducto_SC,
                            Su_Descripcion = rpt.Su_Descripcion,
                            NomProducto_SC = rpt.NomProducto_SC,
                            Cantidad_aprobada = rpt.Cantidad_aprobada,
                            IdUsuarioAprueba = rpt.IdUsuarioAprueba,
                            FechaHoraAprobacion = rpt.FechaHoraAprobacion,
                            observacion = rpt.observacion,
                            IdUnidadMedida = rpt.IdUnidadMedida,
                            Descripcion = rpt.Descripcion,
                            do_precioCompra = rpt.do_precioCompra,
                            do_porc_des = rpt.do_porc_des,
                            do_subtotal = rpt.do_subtotal,
                            do_iva = rpt.do_iva,
                            do_total = rpt.do_total,
                            do_ManejaIva = rpt.do_ManejaIva,
                            IdPunto_cargo = rpt.IdPunto_cargo,
                            IdProveedor = rpt.IdProveedor,
                            pr_nombre = rpt.pr_nombre,
                            IdPersona = rpt.IdPersona,
                            nomSolicitante = rpt.nomSolicitante,
                            IdEstadoAprobacion = rpt.IdEstadoAprobacion,
                            DescrpcionEstado = rpt.DescrpcionEstado,
                            NomEmpresa = this.Cbt.em_nombre,
                            Logo = this.Cbt.em_logo_Image
                        };

                        lstInfo.Add(Info);
                    }
                }

                return lstInfo;
            }
            catch (Exception ex)
            {
                string MensajeError = "";
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", "", "", "", "", "", "", DateTime.Now);
                MensajeError = ex.ToString();
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);

                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "Get_Data_Reporte", ex.Message), ex) { EntityType = typeof(XCOMP_Rpt005_Data) };
            }
        }

    }
}
