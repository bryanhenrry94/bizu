using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bizu.Domain.Bancos;
using Bizu.Infrastructure.Bancos;
using Bizu.Domain.Caja;
using Bizu.Application.General;


namespace Bizu.Application.Bancos
{
    public class ba_Caja_Movimiento_x_Cbte_Ban_x_Deposito_Bus
    {

        string mensaje = "";
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        ba_Caja_Movimiento_x_Cbte_Ban_x_Deposito_Data data = new ba_Caja_Movimiento_x_Cbte_Ban_x_Deposito_Data();

        public List<ba_Caja_Movimiento_x_Cbte_Ban_x_Deposito_Info> Get_List_Caja_Movimiento_x_Cbte_Ban_x_Deposito(int IdEmpresa, decimal IdCbteCble, int IdTipoCbte)
        {
            try
            {
                return data.Get_List_Caja_Movimiento_x_Cbte_Ban_x_Deposito(IdEmpresa, IdCbteCble, IdTipoCbte);
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "GrabarDB", ex.Message), ex) { EntityType = typeof(ba_Caja_Movimiento_x_Cbte_Ban_x_Deposito_Bus) };
            }

        }

        public List<ba_Caja_Movimiento_x_Cbte_Ban_x_Deposito_Info> Get_List_Cbte_Ban_x_Caja_Movimiento(int mcj_IdEmpresa, decimal mcj_IdCbteCble, int mcj_IdTipoCbte)
        {
            try
            {
                return data.Get_List_Cbte_Ban_x_Caja_Movimiento(mcj_IdEmpresa, mcj_IdCbteCble, mcj_IdTipoCbte);
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "GrabarDB", ex.Message), ex) { EntityType = typeof(ba_Caja_Movimiento_x_Cbte_Ban_x_Deposito_Bus) };
            }

        }        

        public Boolean GrabarDB(List<ba_Caja_Movimiento_x_Cbte_Ban_x_Deposito_Info> lista)
        {
            try
            {
                return data.GrabarDB(lista);
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "GrabarDB", ex.Message), ex) { EntityType = typeof(ba_Caja_Movimiento_x_Cbte_Ban_x_Deposito_Bus) };
            }

        }

        public Boolean GrabarDB(ba_Caja_Movimiento_x_Cbte_Ban_x_Deposito_Info Info)
        {
            try
            {
                return data.GrabarDB(Info);
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "GrabarDB", ex.Message), ex) { EntityType = typeof(ba_Caja_Movimiento_x_Cbte_Ban_x_Deposito_Bus) };
            }


        }

        public Boolean GrabarListadoMovCaja_x_Deposito(List<caj_Caja_Movimiento_Info> Lst, int IdtipoCbteCble_Bco, decimal IdCbteCble_Bco)
        {
            try
            {
                return data.GrabarListadoMovCaja_x_Deposito(Lst, IdtipoCbteCble_Bco, IdCbteCble_Bco);
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "GrabarListadoMovCaja_x_Deposito", ex.Message), ex) { EntityType = typeof(ba_Caja_Movimiento_x_Cbte_Ban_x_Deposito_Bus) };
            }


        }

        public Boolean EliminarCobros_x_deposito(int IdEmpresa, int IdTipoCbte, decimal IdCbteCble)
        {
            try
            {
                return data.EliminarCobros_x_deposito(IdEmpresa, IdTipoCbte, IdCbteCble);
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "GrabarDB", ex.Message), ex) { EntityType = typeof(ba_Caja_Movimiento_x_Cbte_Ban_x_Deposito_Bus) };
            }
        }

        public ba_Caja_Movimiento_x_Cbte_Ban_x_Deposito_Bus()
        {

        }
    }
}
