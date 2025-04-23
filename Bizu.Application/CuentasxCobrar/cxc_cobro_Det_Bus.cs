using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Bizu.Infrastructure.CuentasxCobrar;
using Bizu.Domain.CuentasxCobrar;
using Bizu.Infrastructure;
using Bizu.Domain.Caja;
using Bizu.Application.Caja;
using Bizu.Application.Facturacion;
using Bizu.Domain.Facturacion;
using Bizu.Domain.Contabilidad;
using Bizu.Application.Contabilidad;
using Bizu.Application.General;
using Bizu.Domain.General;
using Bizu.Application.Bancos;
using Bizu.Domain.Bancos;



namespace Bizu.Application.CuentasxCobrar
{
    public class cxc_cobro_Det_Bus
    {

        #region Declaracion

        cxc_cobro_Det_Data data = new cxc_cobro_Det_Data();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        string MensajeError = "";

        #endregion

        public Boolean GuardarDB(cxc_cobro_Det_Info Info)
        {
            try
            {
                return data.GuardarDB(Info);
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "GuardarDB", ex.Message), ex) { EntityType = typeof(cxc_cobro_Bus) };
            }

        }

        public Boolean GuardarDB(List<cxc_cobro_Det_Info> lista)
        {
            try
            {
                return data.GuardarDB(lista);
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "GuardarDB", ex.Message), ex) { EntityType = typeof(cxc_cobro_Bus) };
            }

        }

        public Boolean ModificarDetalleCobro(List<cxc_cobro_Det_Info> lista)
        {
            try
            {
                return data.ModificarDetalleCobro(lista);
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "ModificarDetalleCobro", ex.Message), ex) { EntityType = typeof(cxc_cobro_Bus) };
            }

        }

        public Boolean ModificarDetalleCobro_Poli(List<cxc_cobro_Det_Info> lista)
        {
            try
            {
                return data.ModificarDetalleCobro_Poli(lista);
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "ModificarDetalleCobro", ex.Message), ex) { EntityType = typeof(cxc_cobro_Bus) };
            }

        }

        public List<cxc_cobro_Det_Info> Get_List_Cobro_detalle(int IdEmpresa, int idsucursal, decimal idcobro)
        {
            try
            {
                return data.Get_List_Cobro_detalle(IdEmpresa, idsucursal, idcobro);
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "Get_List_Cobro_detalle", ex.Message), ex) { EntityType = typeof(cxc_cobro_Bus) };
            }

        }

        public List<cxc_cobro_Det_Info> Get_List_cobro_x_documento(int IdEmpresa, int IdSucursal, int IdBodega, decimal IdCbteCble)
        {
            try
            {
                return data.Get_List_cobro_x_documento(IdEmpresa, IdSucursal, IdBodega, IdCbteCble);
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "Get_List_cobro_x_documento", ex.Message), ex) { EntityType = typeof(cxc_cobro_Bus) };
            }
        }

        public Boolean EliminarDetalleCobro(int IdEmpresa, int IdSucursal, decimal IdCobro)
        {
            try
            {
                return data.EliminarDetalleCobro(IdEmpresa, IdSucursal, IdCobro);
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "EliminarDetalleCobro", ex.Message), ex) { EntityType = typeof(cxc_cobro_Bus) };
            }

        }

        public Boolean EliminarDetalleCobro_x_Conciliacion(int IdEmpresa, int IdSucursal, decimal IdCobro, string TipoDoc, int IdBodegaCbte, int IdCbteNota)
        {
            try
            {
                return data.EliminarDetalleCobro_x_Conciliacion(IdEmpresa, IdSucursal, IdCobro, TipoDoc, IdBodegaCbte, IdCbteNota);
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "EliminarDetalleCobro", ex.Message), ex) { EntityType = typeof(cxc_cobro_Bus) };
            }

        }

    }
}
