using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Bizu.Infrastructure.Facturacion;
using Bizu.Domain.Facturacion;
using Bizu.Application.General;

namespace Bizu.Application.Facturacion
{
    public class fa_catalogo_Bus
    {
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        string mensaje = "";
        fa_catalogo_Data Data = new fa_catalogo_Data();

        public List<fa_catalogo_Info> Get_List_catalogo(int IdCatalogoTipo)
        {
            try
            {
                return Data.Get_List_catalogo(IdCatalogoTipo);
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "ConsultaGeneral", ex.Message), ex) { EntityType = typeof(fa_catalogo_Bus) };
            }           
           
        }
        
        public Boolean ValidarCodigoExiste(string Cod)
        {
            try
            {
                return Data.ValidarCodigoExiste(Cod);
            }
            catch (Exception ex) 
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "ValidarCodigoExiste", ex.Message), ex) { EntityType = typeof(fa_catalogo_Bus) };
            }
        
        
        }

        public string getId()
        {
            try
            {
                return Data.GetId();
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "getId", ex.Message), ex) { EntityType = typeof(fa_catalogo_Bus) };
            }
        }

        public Boolean ValidarIdTipoCatalogo_Descripcion(int IdCatalogo_tipo, string nombre)
        {
            try
            {
                return Data.ValidarIdTipoCatalogo_Descripcion(IdCatalogo_tipo, nombre);
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "ValidarIdTipoCatalogo_Descripcion", ex.Message), ex) { EntityType = typeof(fa_catalogo_Bus) };
            }           
        }

        public bool GuardarDB(fa_catalogo_Info Info, ref string IdCatalogo, ref string msjError)
        {
            try
            {
                Boolean resultOpe = true;
                if (ValidarCodigoExiste(Info.IdCatalogo) == false)
                {
                    if (ValidarIdTipoCatalogo_Descripcion(Info.IdCatalogo_tipo, Info.Nombre) == false)
                    {
                        resultOpe = Data.GuardarDB( Info, ref IdCatalogo, ref msjError);                       
                    }
                    else
                    {
                        msjError = "La descripción asignada ya existe";
                        resultOpe = false;
                    }
                }
                else
                {
                    msjError = "El código ingresado ya se encuentra asignado \n Por favor ingrese uno nuevo";
                    resultOpe = false;
                }

                return resultOpe;
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "GuardarDB", ex.Message), ex) { EntityType = typeof(fa_catalogo_Bus) };
            }          
            
        }

        public bool ModificarDB(fa_catalogo_Info Info, ref string msjError)
        {
            try
            {
                return Data.ModificarDB(Info, ref msjError);
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "Modificar", ex.Message), ex) { EntityType = typeof(fa_catalogo_Bus) };
            }
                                  
        }

        public bool AnularDB(fa_catalogo_Info Info, ref string msjError)
        {
            try
            {
                return Data.AnularDB(Info, ref msjError);
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "Anular", ex.Message), ex) { EntityType = typeof(fa_catalogo_Bus) };
            }
        }

    }
}
