using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bizu.Infrastructure.ActivoFijo;
using Bizu.Domain.ActivoFijo;
using Bizu.Application.General;


namespace Bizu.Application.ActivoFijo
{
    public class Af_Catalogo_Bus
    {
        #region Declaracion de Variables
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        string mensaje = "";
        Af_Catalogo_Data CD = new Af_Catalogo_Data();
        #endregion

        public string GetIdCatalogo(String IdTipoCatalogo)
        {
            try 
            {
                return CD.GetIdCatalogo(IdTipoCatalogo);
            }
            catch (Exception ex) 
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "getIdCatalogo", ex.Message), ex) { EntityType = typeof(Af_Catalogo_Bus) };
            }
        }

        public List<Af_Catalogo_Info> Get_List_Catalogo()
        {
            try { return CD.Get_List_Catalogo(); }
            catch (Exception ex) 
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "Get_List_Catalogo", ex.Message), ex) { EntityType = typeof(Af_Catalogo_Bus) };
            }
        }

        public List<Af_Catalogo_Info> Get_List_Catalogo(string cod)
        {
            try { return CD.Get_List_Catalogo(cod); }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "Get_List_Catalogo", ex.Message), ex) { EntityType = typeof(Af_Catalogo_Bus) };
            }
        }

        public Boolean GuardarDB(Af_Catalogo_Info Info)
        {
            try { return CD.GuardarDB(Info); }
            catch (Exception ex) 
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "GuardarDB", ex.Message), ex) { EntityType = typeof(Af_Catalogo_Bus) };
            }
        }

        public Boolean ValidarCodigoExiste(string cod)
        {
            try { return CD.ValidarCodigoExiste(cod); }
            catch (Exception ex) 
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "ValidarCodigoExiste", ex.Message), ex) { EntityType = typeof(Af_Catalogo_Bus) };
            }
        }

        public Boolean Modificar(Af_Catalogo_Info Info)
        {
            try { return CD.Modificar(Info); }
            catch (Exception ex) 
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "Modificar", ex.Message), ex) { EntityType = typeof(Af_Catalogo_Bus) };
            }
        }

        public Boolean Anular(Af_Catalogo_Info Info)
        {
            try { return CD.Anular(Info); }
            catch (Exception ex) 
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "Anular", ex.Message), ex) { EntityType = typeof(Af_Catalogo_Bus) };
            }
        }

        public Boolean ValidarIdTipoCatalogo_Descripcion(string idTipoCatalogo, string ca_descripcion)
        {
            try { return CD.ValidarIdTipoCatalogo_Descripcion(idTipoCatalogo, ca_descripcion); }
            catch (Exception ex) 
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "ValidarIdTipoCatalogo_Descripcion", ex.Message), ex) { EntityType = typeof(Af_Catalogo_Bus) };
            }
        }

    }
}
