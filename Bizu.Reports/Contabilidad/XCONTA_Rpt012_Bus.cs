using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Bizu.Application.General;
using Bizu.Domain.General;
using Bizu.Domain.Contabilidad;

namespace Bizu.Reports.Contabilidad
{
  public  class XCONTA_Rpt012_Bus
    {
        XCONTA_Rpt012_Data Odata = new XCONTA_Rpt012_Data();

        public List<XCONTA_Rpt012_Info> consultar_data(int IdEmpresa, List<ct_Periodo_Info> ListPeriodo, string IdCentroCosto, int IdNivel_a_mostrar
             , int IdPunto_cargo_grupo, int IdPunto_cargo, bool Mostrar_reg_Cero, bool Mostrar_CC, string IdUsuario, ref String mensaje)
        {
            try
            {
                return Odata.consultar_data(IdEmpresa, ListPeriodo, IdCentroCosto, IdNivel_a_mostrar,
                    IdPunto_cargo_grupo, IdPunto_cargo, Mostrar_reg_Cero, Mostrar_CC, IdUsuario, ref mensaje);
            }
            catch (Exception ex)
            {
                tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
                oLog.Log_Error(ex.ToString());
                throw new Exception(ex.ToString());
            }
        }

        public List<XCONTA_Rpt002_Info> Get_data_Mayorizado_x_fecha(int IdEmpresa, DateTime fecha_inicio, DateTime fecha_fin, string IdCentroCosto, int IdNivel_a_mostrar
              , int IdPunto_cargo_grupo, int IdPunto_cargo, bool Mostrar_reg_Cero, bool Mostrar_CC, string IdUsuario, ref String mensaje)
        {
            try
            {
                return Odata.Get_data_Mayorizado_x_fecha(IdEmpresa, fecha_inicio, fecha_fin, IdCentroCosto, IdNivel_a_mostrar, IdPunto_cargo_grupo, IdPunto_cargo, Mostrar_reg_Cero, Mostrar_CC, IdUsuario, ref mensaje);
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
