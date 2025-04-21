using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.General;
using Core.Erp.Data.General;

namespace Core.Erp.Reportes.CuentasxCobrar
{
    public class XCXC_Rpt021_Data
    {
        string mensaje = "";
        tb_Empresa_Info Cbt = new tb_Empresa_Info();
        tb_Empresa_Data empresaData = new tb_Empresa_Data();

        public List<XCXC_Rpt021_Info> Get_Data(int IdEmpresa, int IdSucursal, decimal IdCliente)
        {
            try
            {
                List<XCXC_Rpt021_Info> lstRpt = new List<XCXC_Rpt021_Info>();

                using (Entities_CuentasxCobrar listado = new Entities_CuentasxCobrar())
                {
                    var select = from q in listado.spCXC_Rpt021(IdEmpresa, IdSucursal, IdCliente)
                                 select q;

                    foreach (var item in select)
                    {
                        XCXC_Rpt021_Info infoRpt = new XCXC_Rpt021_Info();
                        infoRpt.IdEmpresa = item.IdEmpresa;
                        infoRpt.IdSucursal = item.IdSucursal;
                        infoRpt.IdCliente = item.IdCliente;
                        infoRpt.IdProyecto = item.IdProyecto;
                        infoRpt.IdOferta = item.IdOferta;
                        infoRpt.NomCliente = item.NomCliente;
                        infoRpt.NomProyecto = item.NomProyecto;
                        infoRpt.FechaEmision = item.FechaEmision;
                        infoRpt.Descripcion = item.Descripcion;
                        infoRpt.Parcial = item.Parcial;
                        infoRpt.Retencion = item.Retencion;
                        infoRpt.Valor_a_Pagar = item.Valor_a_Pagar;
                        infoRpt.Factura = item.Factura;
                        infoRpt.MontoTotal = item.MontoTotal;
                        infoRpt.Nivel = item.Nivel;

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
                return new List<XCXC_Rpt021_Info>();
            }
        }
    }
}