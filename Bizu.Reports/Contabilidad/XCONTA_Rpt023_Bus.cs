using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bizu.Application.Contabilidad;
using Bizu.Domain.Contabilidad;

using Bizu.Application.General;
using Bizu.Domain.General;



namespace Bizu.Reports.Contabilidad
{
   public class XCONTA_Rpt023_Bus
    {
       public XCONTA_Rpt023_Bus()
       {

       }

        XCONTA_Rpt023_Data Odata = new XCONTA_Rpt023_Data();

        public List<XCONTA_Rpt023_Info> consultar_data(int IdEmpresa, DateTime FechaIni, DateTime FechaFin
           , bool Mostrar_reg_en_cero, bool Considerar_Asiento_cierre_anual, string IdUsuario, ref String mensaje)
        {
            try
            {
                List<XCONTA_Rpt023_Info> lista = new List<XCONTA_Rpt023_Info>();
                ct_AnioFiscal_Bus bus = new ct_AnioFiscal_Bus();
                ct_AnioFiscal_Info info = new ct_AnioFiscal_Info();

                lista = Odata.consultar_data(IdEmpresa, FechaIni, FechaFin,
                     Mostrar_reg_en_cero, Considerar_Asiento_cierre_anual, IdUsuario, ref mensaje);

                return lista;
            }
            catch (Exception ex)
            {
                tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
                oLog.Log_Error(ex.ToString());
                throw new Exception(ex.ToString());
            }
        }

    }
}
