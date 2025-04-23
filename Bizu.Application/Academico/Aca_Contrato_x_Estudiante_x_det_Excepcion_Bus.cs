using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Core.Erp.Info.Academico;
using Core.Erp.Data.Academico;
using Core.Erp.Business.General;
namespace Core.Erp.Business.Academico
{
    public class Aca_Contrato_x_Estudiante_x_det_Excepcion_Bus
    {
        Aca_Contrato_x_Estudiante_x_det_Excepcion_Data OData = new Aca_Contrato_x_Estudiante_x_det_Excepcion_Data();
       tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
 
        #region "Get"

        public int GetId()
        {
            int Id = 0;
            try
            {
                Id = OData.GetId();
                return Id;
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GetId", ex.Message), ex) { EntityType = typeof(Aca_Contrato_x_Estudiante_x_det_Excepcion_Bus) };
            }

        }

        public List<Aca_Contrato_x_Estudiante_x_det_Excepcion_Info> Get_List_Rubros_Contrato(Aca_Contrato_x_Estudiante_Info InfoContrato)
        {
           
            try
            {
                return OData.Get_List_Rubros_Contrato(InfoContrato);
             
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_Rubros_Contrato", ex.Message), ex) { EntityType = typeof(Aca_Contrato_x_Estudiante_x_det_Excepcion_Bus) };
            }

        }
        public List<Aca_Contrato_x_Estudiante_x_det_Excepcion_Info> Get_lista(int IdIntitucion, decimal IdEstudiante, decimal IdContrato, int IdAnioLectivo)
        {
            try
            {
                return  OData.Get_lista(IdIntitucion, IdEstudiante, IdContrato, IdAnioLectivo);
                
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_lista", ex.Message), ex) { EntityType = typeof(Aca_Contrato_x_Estudiante_x_det_Excepcion_Bus) };
            }

        }

        public List<Aca_Contrato_x_Estudiante_x_det_Excepcion_Info> Get_lista_excepciones_Contratos(int IdIntitucion, decimal IdContrato)
        {
            try
            {
                return OData.Get_lista_excepciones_Contratos(IdIntitucion, IdContrato);

            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_lista_excepciones_Contratos", ex.Message), ex) { EntityType = typeof(Aca_Contrato_x_Estudiante_x_det_Excepcion_Bus) };
            }

        }

        #endregion
        #region Grabar
        public bool Grabar_DB(List<Aca_Contrato_x_Estudiante_x_det_Excepcion_Info> lista)
        {
            try
            {
                return OData.Grabar_DB(lista);

            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Grabar_DB", ex.Message), ex) { EntityType = typeof(Aca_Contrato_x_Estudiante_x_det_Excepcion_Bus) };

            }
        }


        public bool AnularBD(Aca_Contrato_x_Estudiante_x_det_Excepcion_Info Info)
        {
            try
            {
                return OData.AnularBD(Info);

            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "AnularBD", ex.Message), ex) { EntityType = typeof(Aca_Contrato_x_Estudiante_x_det_Excepcion_Bus) };

            }
        }
        #endregion

    }
}
