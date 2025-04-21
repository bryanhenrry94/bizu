using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Info.Academico;
using Core.Erp.Data.Academico;
using Core.Erp.Info.General;
using Core.Erp.Data.General;
namespace Core.Erp.Business.Academico
{
   public class Aca_contrato_x_estudiante_det_beca_Bus
    {
        string msj = "";
        Aca_contrato_x_estudiante_det_beca_Data data = new Aca_contrato_x_estudiante_det_beca_Data();
        public bool Grabar_DB(List<Aca_contrato_x_estudiante_det_beca_Info> lista)
        {
            try
            {
                return data.Grabar_DB(lista);

            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Grabar_DB", ex.Message), ex) { EntityType = typeof(Aca_contrato_x_estudiante_det_beca_Bus) };
         
            }
        }


        public List<Aca_contrato_x_estudiante_det_beca_Info> Get_lista(int IdIntitucion, decimal IdEstudiante, decimal IdContrato, int IdAnioLectivo)
        {
            try
            {
                return data.Get_lista(IdIntitucion, IdEstudiante, IdContrato, IdAnioLectivo);

            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_lista", ex.Message), ex) { EntityType = typeof(Aca_contrato_x_estudiante_det_beca_Bus) };
         

            }
        }
        public bool Anular_DB(Aca_contrato_x_estudiante_det_beca_Info Info)
        {
            try
            {
                return data.AnularBD(Info);

            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Anular_DB", ex.Message), ex) { EntityType = typeof(Aca_contrato_x_estudiante_det_beca_Bus) };

            }
        }

    }
}
