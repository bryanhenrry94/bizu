using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bizu.Domain.General;
using Bizu.Infrastructure.General;
using Bizu.Domain.Compras;
using Bizu.Infrastructure.Compras;




namespace Bizu.Application.Compras
{
   public class com_departamento_Bus
    {
       com_departamento_Data Odata = new com_departamento_Data();

        string mensaje = "";
        public List<com_departamento_Info> Get_List_Departamento(int IdEmpresa)
        {
            try
            {
                return Odata.Get_List_Departamento(IdEmpresa);  
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "Get_List_Departamento", ex.Message), ex) { EntityType = typeof(com_departamento_Bus) };
            }
           
        }
        

        public Boolean GuardarDB(com_departamento_Info Info)
        {
            try
            {
                return Odata.GuardarDB(Info);
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "Get_List_MotivoRequerimiento", ex.Message), ex) { EntityType = typeof(com_Catalogo_Bus) };
            }

        }

        public bool ModificarDB(com_departamento_Info info)
        {
            try
            {
                return Odata.ModificarDB(info);
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "Get_List_MotivoRequerimiento", ex.Message), ex) { EntityType = typeof(com_Catalogo_Bus) };
            }
        }

        public Boolean AnularDB(com_departamento_Info Info)
        {
            try
            {
                return Odata.AnularDB(Info);
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "Get_List_MotivoRequerimiento", ex.Message), ex) { EntityType = typeof(com_Catalogo_Bus) };
            }
        }

    }
}
