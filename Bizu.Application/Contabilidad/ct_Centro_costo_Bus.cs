using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Bizu.Domain.Contabilidad;
using Bizu.Infrastructure.Contabilidad;
using Bizu.Domain.General;
using Bizu.Application.General;


namespace Bizu.Application.Contabilidad
{
    public class ct_Centro_costo_Bus
    {
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        ct_Centro_costo_Data data = new ct_Centro_costo_Data();

        public List<ct_Centro_costo_Info> Get_list_Centro_Costo(int IdEmpresa,ref string MensajeError)
        {
            List<ct_Centro_costo_Info> lm = new List<ct_Centro_costo_Info>();
            try
            {
                lm = data.Get_list_Centro_Costo(IdEmpresa, ref MensajeError);
                return (lm);
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "Get_list_Centro_Costo", ex.Message), ex) { EntityType = typeof(ct_Centro_costo_Bus) };
            }
        }

        public List<ct_Centro_costo_Info> Get_list_Centro_costo_x_IdCuentas_Padre(int IdEmpresa, string IdCuenta_Padre, ref string MensajeError)
        {
            try
            {
                return data.Get_list_Centro_costo_x_IdCuentas_Padre(IdEmpresa, IdCuenta_Padre, ref MensajeError);
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "Get_list_Centro_costo_x_IdCuentas_Padre", ex.Message), ex) { EntityType = typeof(ct_Centro_costo_Bus) };
            }
        }
        
        public List<ct_Centro_costo_Info> Get_list_Centro_Costo_cuentas_de_movimiento(int IdEmpresa, ref string MensajeError)
        {
            List<ct_Centro_costo_Info> lm = new List<ct_Centro_costo_Info>();
            try
            {
                lm = data.Get_list_Centro_Costo_cuentas_de_Movimiento(IdEmpresa, ref MensajeError);
                return (lm);
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "Get_list_Centro_Costo_cuentas_de_Movimiento", ex.Message), ex) { EntityType = typeof(ct_Centro_costo_Bus) };
            }
        }
        
        public List<ct_Centro_costo_Info> Get_list_Centro_Costo_cuentas_padre(int IdEmpresa, ref string MensajeError)
        {
            List<ct_Centro_costo_Info> lm = new List<ct_Centro_costo_Info>();
            try
            {
                lm = data.Get_list_Centro_Costo_cuentas_padre(IdEmpresa, ref MensajeError);
                return (lm);
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "Get_list_Centro_Costo_cuentas_padre", ex.Message), ex) { EntityType = typeof(ct_Centro_costo_Bus) };
            }
        }

        public string Get_IdCentroCosto(int IdEmpresa, ct_Centro_costo_Info idCentro_Costo_padre, ref string MensajeError)
        {
            return "";
        }

        public string Get_IdCentroCosto_x_Raiz(int IdEmpresa, ref string MensajeError)
        {
            try
            {
                return data.Get_IdCentroCosto_x_Raiz(IdEmpresa,ref MensajeError);
                
            }
            catch (Exception ex)
            {

                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "Get_IdCentroCosto", ex.Message), ex) { EntityType = typeof(ct_Centro_costo_Bus) };
            }
        }

        public Boolean VerificaNivel(int idnivel, int idempresa, ref string MensajeError)
        {
            try
            {
                return data.VerificaNivel(idnivel, idempresa, ref MensajeError);
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "VerificaNivel", ex.Message), ex) { EntityType = typeof(ct_Centro_costo_Bus) };
            }
        }

        public Boolean ModificarDB(ct_Centro_costo_Info info, ref string MensajeError)
        {
            try
            {
                return data.ModificarDB(info,ref MensajeError);
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "ModificarDB", ex.Message), ex) { EntityType = typeof(ct_Centro_costo_Bus) };
            }
        }

        public Boolean AnularDB(ct_Centro_costo_Info info, ref string MensajeError)
        {
            try
            {
                return data.AnularDB(info,ref MensajeError);
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "AnularDB", ex.Message), ex) { EntityType = typeof(ct_Centro_costo_Bus) };
            }
        }

        public Boolean GrabarDB(ct_Centro_costo_Info info, ref string MensajeError)
        {
            try
            {
                if (info.IdCentroCosto == "")
                {
                    ct_Centro_costo_Info InfoCentro_costo_padre = new ct_Centro_costo_Info();

                    if (InfoCentro_costo_padre.IdCentroCosto != null)
                    {
                        info.IdCentroCosto = Get_IdCentroCosto(info.IdEmpresa, InfoCentro_costo_padre, ref MensajeError);
                    }
                    else// este caso es por q es raiz no tiene padre 
                    { 
                        info.IdCentroCosto = Get_IdCentroCosto_x_Raiz(info.IdEmpresa, ref MensajeError);
                    }
                }

                return data.GrabarDB(info,ref MensajeError);
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "GrabarDB", ex.Message), ex) { EntityType = typeof(ct_Centro_costo_Bus) };
            }
        }
        
        public ct_Centro_costo_Bus()
        {
            
        }
    }
}
