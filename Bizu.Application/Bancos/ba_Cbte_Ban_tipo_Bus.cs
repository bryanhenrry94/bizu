using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bizu.Infrastructure.Bancos;
using Bizu.Domain.Bancos;
using Bizu.Application.General;


namespace Bizu.Application.Bancos
{
    public class ba_Cbte_Ban_tipo_Bus
    {
        string mensaje = "";
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        ba_Cbte_Ban_tipo_Data odata = new ba_Cbte_Ban_tipo_Data();

        public List<ba_Cbte_Ban_tipo_Info> Get_list_Cbte_Ban_Tipo_x_NCBA_NDBA()
        {
            try
            {
                return odata.Get_list_Cbte_Ban_Tipo_x_NCBA_NDBA();
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "Get_list_Cbte_Ban_Tipo_x_NCBA_NDBA", ex.Message), ex) { EntityType = typeof(ba_Cbte_Ban_tipo_Bus) };
            }
        }
        public List<ba_Cbte_Ban_tipo_Info> Get_List_Cbte_Ban_tipo()
        {
            try
            {
                return odata.Get_List_Cbte_Ban_tipo();
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "Get_List_Cbte_Ban_tipo", ex.Message), ex) { EntityType = typeof(ba_Cbte_Ban_tipo_Bus) };
            }
        }
        public List<ba_Cbte_Ban_tipo_Info> Get_List_Cbte_Ban_tipo_Todos()
        {
            try
            {
                return odata.Get_List_Cbte_Ban_tipo_Todos();
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "Get_List_Cbte_Ban_tipo_Todos", ex.Message), ex) { EntityType = typeof(ba_Cbte_Ban_tipo_Bus) };
            }
        }

    }
}
