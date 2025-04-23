using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bizu.Domain.General;
using Bizu.Infrastructure.General;

namespace Bizu.Reports.CuentasxCobrar
{
    public class XCXC_Rpt020_Data
    {
        string mensaje = "";
        tb_Empresa_Info Cbt = new tb_Empresa_Info();
        tb_Empresa_Data empresaData = new tb_Empresa_Data();


        public List<XCXC_Rpt020_Info> get_RptCobros(int IdEmpresa, int IdSucursalIni, int IdSucursalFin, decimal IdClienteIni,
            decimal IdClienteFin, DateTime FechaIni, DateTime FechaHasta, List<string> ListIdTipoCobro)
        {
            try
            {
                List<XCXC_Rpt020_Info> lstRpt = new List<XCXC_Rpt020_Info>();
                FechaIni = Convert.ToDateTime(FechaIni.ToShortDateString());
                FechaHasta = Convert.ToDateTime(FechaHasta.ToShortDateString());

                using (Entities_CuentasxCobrar listado = new Entities_CuentasxCobrar())
                {

                    var select = from q in listado.vwCXC_Rpt020
                                 where q.IdEmpresa == IdEmpresa
                                 && q.IdSucursal >= IdSucursalIni && q.IdSucursal <= IdSucursalFin
                                 && q.IdCliente >= IdClienteIni && q.IdCliente <= IdClienteFin
                                 && q.cr_fecha >= FechaIni && q.cr_fecha <= FechaHasta
                                 && ListIdTipoCobro.Contains(q.IdCobro_tipo)
                                 select q;

                    select = select.OrderBy(q => q.IdCobro);

                    Cbt = empresaData.Get_Info_Empresa(IdEmpresa);

                    foreach (var item in select)
                    {
                        XCXC_Rpt020_Info infoRpt = new XCXC_Rpt020_Info();

                        infoRpt.IdEmpresa = item.IdEmpresa;
                        infoRpt.IdSucursal = item.IdSucursal;
                        infoRpt.IdCobro = item.IdCobro;
                        infoRpt.cr_Codigo = item.cr_Codigo;
                        infoRpt.IdCobro_tipo = item.IdCobro_tipo;
                        infoRpt.IdCliente = item.IdCliente;
                        infoRpt.pe_nombreCompleto = item.pe_nombreCompleto;
                        infoRpt.cr_estado = item.cr_estado;
                        infoRpt.cr_TotalCobro = item.cr_TotalCobro;
                        infoRpt.cr_fecha = item.cr_fecha;
                        infoRpt.cr_fechaDocu = item.cr_fechaDocu;
                        infoRpt.cr_fechaCobro = item.cr_fechaCobro;
                        infoRpt.fecha_Transac = item.fecha_Transac;
                        infoRpt.IdCbteCble = item.IdCbteCble;
                        infoRpt.cb_Valor = item.cb_Valor;
                        infoRpt.IdPeriodo = item.IdPeriodo;
                        infoRpt.cb_Fecha = item.cb_Fecha;
                        infoRpt.cb_Estado = item.cb_Estado;
                        infoRpt.cb_Observacion = item.cb_Observacion;

                        lstRpt.Add(infoRpt);
                    }

                }
                return lstRpt;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = ex.InnerException + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                return new List<XCXC_Rpt020_Info>();
            }
        }
    }
}
