using Bizu.Infrastructure.Bancos;
using Bizu.Domain.Bancos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bizu.Application.General;
using Bizu.Application.Contabilidad;
using Bizu.Domain.General;
using Bizu.Domain.Contabilidad;
using Bizu.Infrastructure;
using Bizu.Domain.CuentasxPagar;
using Bizu.Application.CuentasxPagar;
namespace Bizu.Application.Bancos
{
    public class ba_Cbte_Ban_Datos_Entrega_cheq_Bus
    {
        ba_Cbte_Ban_Datos_Entrega_cheq_Data oData = new ba_Cbte_Ban_Datos_Entrega_cheq_Data();

        public Boolean GrabarDB(ba_Cbte_Ban_Datos_Entrega_cheq_Info info, ref string MensajeError)
        {
            try
            {
                return oData.GrabarDB(info, ref MensajeError);
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "Get_Info_Vista_Archivo_transferencia", ex.Message), ex) { EntityType = typeof(ba_Archivo_Transferencia_Bus) };
            }
        }

        public ba_Cbte_Ban_Datos_Entrega_cheq_Info GetInfo( int IdEmpresa, decimal IdCbteCble, int IdTipocbte)
        {
            try
            {
                return oData.GetInfo(IdEmpresa, IdCbteCble, IdTipocbte);
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "Get_Info_Vista_Archivo_transferencia", ex.Message), ex) { EntityType = typeof(ba_Archivo_Transferencia_Bus) };
            }
        }
    }
}