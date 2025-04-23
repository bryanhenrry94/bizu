using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Bizu.Infrastructure.General;
using Bizu.Domain.General;
using Bizu.Application.General;

namespace Bizu.Application.General
{

   public class tb_persona_direccion_tipo_Bus
    {

        string mensaje = "";
        tb_persona_direccion_tipo_Data Odata = new tb_persona_direccion_tipo_Data();


        public Boolean GuardarDB(tb_persona_direccion_tipo_Info Info, ref int IdTipoDireccion, ref string msjError)
        {
            try
            {
                return Odata.GuardarDB(Info, ref IdTipoDireccion, ref msjError);
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "ObtenerEmpresa", ex.Message), ex) { EntityType = typeof(tb_Empresa_Bus) };
            }
        }

        public Boolean ModificarDB(tb_persona_direccion_tipo_Info Info, ref string msjError)
        {
            try
            {
                return Odata.ModificarDB(Info, ref msjError);
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "ObtenerEmpresa", ex.Message), ex) { EntityType = typeof(tb_Empresa_Bus) };
            }
        }

        public Boolean ModificarDB(List<tb_persona_direccion_tipo_Info> ListInfo, ref string msjError)
        {
            try
            {
                return Odata.ModificarDB(ListInfo, ref msjError);
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "ObtenerEmpresa", ex.Message), ex) { EntityType = typeof(tb_Empresa_Bus) };
            }
        }

      

        public List<tb_persona_direccion_tipo_Info> Get_List_persona_direccion()
        {
            try
            {
                return Odata.Get_List_persona_direccion();
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "ObtenerEmpresa", ex.Message), ex) { EntityType = typeof(tb_Empresa_Bus) };
            }
        }

        public tb_persona_direccion_tipo_Info Get_Info_persona_direccion(int IdTipoDireccion)
        {
            try
            {
                return Odata.Get_Info_persona_direccion(IdTipoDireccion);
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "ObtenerEmpresa", ex.Message), ex) { EntityType = typeof(tb_Empresa_Bus) };
            }
        }


    }
}
