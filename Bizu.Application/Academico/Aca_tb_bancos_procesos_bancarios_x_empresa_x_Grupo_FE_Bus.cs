using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Academico;
using Core.Erp.Data.Academico;
using Core.Erp.Info.General;
using Core.Erp.Business.General;
using System.Data;

namespace Core.Erp.Business.Academico
{
    public class Aca_tb_bancos_procesos_bancarios_x_empresa_x_Grupo_FE_Bus
    {
        #region variables
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        string mensaje = "";
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        Aca_tb_bancos_procesos_bancarios_x_empresa_x_Grupo_FE_Data da;
        #endregion

        public Aca_tb_bancos_procesos_bancarios_x_empresa_x_Grupo_FE_Info Get_Info_ProcesoBanco_x_GrupoFE(int IdInstitucion, int IdGrupoFE, int IdEmpresa, string IdProcesoBancarioTipo)
        {
            try
            {
                da = new Aca_tb_bancos_procesos_bancarios_x_empresa_x_Grupo_FE_Data();
                return da.Get_Info_ProcesoBanco_x_GrupoFE(IdInstitucion, IdGrupoFE, IdEmpresa, IdProcesoBancarioTipo);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_Info_ProcesoBanco_x_GrupoFE", ex.Message), ex) { EntityType = typeof(Aca_tb_bancos_procesos_bancarios_x_empresa_x_Grupo_FE_Bus) };
            }

        }

        public List<Aca_tb_bancos_procesos_bancarios_x_empresa_x_Grupo_FE_Info> Get_List_ProcesoBanco_x_GrupoFE(int IdInstitucion, int IdEmpresa)
        {
            try
            {
                da = new Aca_tb_bancos_procesos_bancarios_x_empresa_x_Grupo_FE_Data();
                return da.Get_List_ProcesoBanco_x_GrupoFE(IdInstitucion, IdEmpresa);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_ProcesoBanco_x_GrupoFE", ex.Message), ex) { EntityType = typeof(Aca_tb_bancos_procesos_bancarios_x_empresa_x_Grupo_FE_Bus) };
            }

        }

    }
}
