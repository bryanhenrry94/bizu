﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Bizu.Domain.Contabilidad;
using Bizu.Infrastructure.Contabilidad;
using Bizu.Application.General;

namespace Bizu.Application.Contabilidad
{
    public class ct_punto_cargo_Bus
    {
        string mensaje = "";
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        ct_punto_cargo_Data data = new ct_punto_cargo_Data();

        public ct_punto_cargo_Info Get_Info_Punto_cargo(int idEmpresa, int idPunto_cargo)
        {
            try
            {
                return data.Get_Info_Punto_cargo(idEmpresa, idPunto_cargo);
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "Get_Info_Punto_cargo", ex.Message), ex) { EntityType = typeof(ct_punto_cargo_Bus) };
            }
        }

        public List<ct_punto_cargo_Info> Get_List_PuntoCargo(int IdEmpresa)
        {

            try
            {
                return data.Get_list_PuntoCargo(IdEmpresa);
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "Get_list_PuntoCargo", ex.Message), ex) { EntityType = typeof(ct_punto_cargo_Bus) };
            }
        }

        public List<ct_punto_cargo_Info> Get_list_PuntoCargo_x_grupo(int IdEmpresa, int IdPunto_cargo_grupo)
        {
            try
            {
                return data.Get_list_PuntoCargo_x_grupo(IdEmpresa, IdPunto_cargo_grupo);
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "Get_list_PuntoCargo", ex.Message), ex) { EntityType = typeof(ct_punto_cargo_Bus) };
            }
        }

        public List<ct_punto_cargo_Info> Get_list_PuntoCargo_x_grupo(int IdEmpresa)
        {
            try
            {
                return data.Get_list_PuntoCargo_x_grupo(IdEmpresa);
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "Get_list_PuntoCargo", ex.Message), ex) { EntityType = typeof(ct_punto_cargo_Bus) };
            }
        }

        public Boolean GuardarDB(ct_punto_cargo_Info info, int IdEmpresa)
        {
            try
            {
                return data.GuardarDB(info, IdEmpresa);
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "GuardarDB", ex.Message), ex) { EntityType = typeof(ct_punto_cargo_Bus) };
            }
        }

        public Boolean ModificarDB(ct_punto_cargo_Info info)
        {
            try
            {
                return data.ModificarDB(info);

            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "ModificarDB", ex.Message), ex) { EntityType = typeof(ct_punto_cargo_Bus) };
            }
        }

        public Boolean AnularDB(ct_punto_cargo_Info info)
        {
            try
            {
                return data.AnularDB(info);
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "AnularDB", ex.Message), ex) { EntityType = typeof(ct_punto_cargo_Bus) };
            }

        }

        public Boolean VericarCodigoExiste(string codigo, ref string mensaje)
        {
            try
            {
                return data.VericarCodigoExiste(codigo, ref mensaje);
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "VericarCodigoExiste", ex.Message), ex) { EntityType = typeof(ct_punto_cargo_Bus) };
            }
        }
    }
}