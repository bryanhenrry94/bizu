using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bizu.Domain.Facturacion;
using Bizu.Infrastructure.Facturacion;
using Bizu.Application.General;
using Bizu.Domain.General;

namespace Bizu.Application.Facturacion
{
    public class fa_Secuencia_Documento_Talonario_Bus
    {
        //#region Declaración de variables
        //tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        //string mensaje = "";
        //fa_Secuencia_Documento_Talonario_Data data = new fa_Secuencia_Documento_Talonario_Data();
        //#endregion

        //public List<tb_sis_Documento_Tipo_x_Empresa_Info> Get_List_Documento_Tipo_ApareceTalonario()
        //{
        //    try
        //    {

        //        return data.Get_List_Documento_Tipo_ApareceTalonario();
        //    }
        //    catch (Exception ex)
        //    {

        //        Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
        //        throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "ObtenerListaDocTipo", ex.Message), ex) { EntityType = typeof(fa_Secuencia_Documento_Talonario_Bus) };
        //    }
        //}

        //public Boolean GuardarDB(fa_Secuencia_Documento_Talonario_Info info)
        //{
        //    try
        //    {
        //        return data.GuardarDB(info);
        //    }
        //    catch (Exception ex)
        //    {

        //        Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
        //        throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "grabar", ex.Message), ex) { EntityType = typeof(fa_Secuencia_Documento_Talonario_Bus) };

        //    }
        //}

        //public List<fa_Secuencia_Documento_Talonario_Info> Get_List_fa_Secuencia_Documento_Talonario(int idEmpresa)
        //{
        //    try
        //    {
        //        return data.Get_List_fa_Secuencia_Documento_Talonario(idEmpresa);
        //    }
        //    catch (Exception ex)
        //    {
        //        Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
        //        throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "ObtenerListaDocTipoxSecTalonario", ex.Message), ex) { EntityType = typeof(fa_Secuencia_Documento_Talonario_Bus) };

        //    }
        //}

        //public Boolean ModificarDB(fa_Secuencia_Documento_Talonario_Info info)
        //{
        //    try
        //    {
        //        return data.ModificarDB(info);
        //    }
        //    catch (Exception ex)
        //    {
        //        Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
        //        throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "Modificar", ex.Message), ex) { EntityType = typeof(fa_Secuencia_Documento_Talonario_Bus) };

        //    }
        //}

        //public List<fa_Documento_Tipo_info> Get_List_Documento_Tipo_ApareceComboFac_TipoFact()
        //{
        //    try
        //    {
        //        return data.Get_List_Documento_Tipo_ApareceComboFac_TipoFact();
        //    }
        //    catch (Exception ex)
        //    {
        //        Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
        //        throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "ObtenerListaDocFac", ex.Message), ex) { EntityType = typeof(fa_Secuencia_Documento_Talonario_Bus) };

        //    }
        //}

        //public List<fa_Documento_Tipo_info> Get_List_Documento_Tipo_ApareceComboFac_Import(int IdEmpresa)
        //{
        //    try
        //    {
        //        return data.Get_List_Documento_Tipo_ApareceComboFac_Import(IdEmpresa);
        //    }
        //    catch (Exception ex)
        //    {
        //        Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
        //        throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "ObtenerListaDocImp", ex.Message), ex) { EntityType = typeof(fa_Secuencia_Documento_Talonario_Bus) };

        //    }
        //}

        //public Boolean GuardarNumDoc(int IdEmpresa, int idSucursal, int idBodega, string serie1, string serie2, string numDocTrans, string TipoDoc,string NAutorizacion)
        //{
        //    try
        //    {
        //        return data.GuardarNumDoc( IdEmpresa, idSucursal, idBodega, serie1, serie2, numDocTrans,TipoDoc, NAutorizacion);
        //    }
        //    catch (Exception ex)
        //    {
        //        Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
        //        throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "GuardarNumDoc", ex.Message), ex) { EntityType = typeof(fa_Secuencia_Documento_Talonario_Bus) };

        //    }
        //}

        //public Boolean VerificarNumeroTalonarioIsUsed(string Qry)
        //{
        //    try
        //    {
        //        return data.VerificarNumeroTalonarioIsUsed(Qry);
        //    }
        //    catch (Exception ex)
        //    {
        //        Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
        //        throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "VerificarNumeroTalonarioIsUsed", ex.Message), ex) { EntityType = typeof(fa_Secuencia_Documento_Talonario_Bus) };

        //    }            
        //}

        //public List<fa_Documento_Tipo_info> Get_List_Documento_Tipo_x_Empresa(int IdEmpresa)
        //  {
        //      try
        //      {
        //          return data.Get_List_Documento_Tipo_x_Empresa(IdEmpresa);
        //      }
        //      catch(Exception ex)
        //      {
        //          Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
        //          throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "ObtenerListaDocTipoXempresa", ex.Message), ex) { EntityType = typeof(fa_Secuencia_Documento_Talonario_Bus) };

        //      }
        //  }

        //public Boolean VerificarNumAutorizacionExiste(int IdEmpresa, string CodDocumentoTipo, string nAutorizacion)
        //  {
        //      try
        //      {
        //        return data.VerificarNumAutorizacionExiste(IdEmpresa, CodDocumentoTipo, nAutorizacion);
        //      }
        //      catch (Exception ex)
        //      {
        //          Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
        //          throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "VerificarNumAutorizacionExiste", ex.Message), ex) { EntityType = typeof(fa_Secuencia_Documento_Talonario_Bus) };

        //      }
              
        //  }

        //public fa_Secuencia_Documento_Talonario_Bus() { }
    
    }
}
