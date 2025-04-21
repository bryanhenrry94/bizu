using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Core.Erp.Data.CuentasxCobrar;

using Core.Erp.Business.General;
using Core.Erp.Business.Facturacion;
using Core.Erp.Business.Contabilidad;

using Core.Erp.Info.Facturacion;
using Core.Erp.Info.CuentasxCobrar;
using Core.Erp.Info.General;
using Core.Erp.Info.Contabilidad;

namespace Core.Erp.Business.CuentasxCobrar
{
    public class cxc_anticipo_facturado_Bus
    {
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        cxc_anticipo_facturado_Data data = new cxc_anticipo_facturado_Data();

        public List<cxc_anticipo_facturado_Info> Get_List(int IdEmpresa, int IdSucursal, ref string mensaje)
        {
            try
            {
                return data.Get_List(IdEmpresa, IdSucursal, ref mensaje);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_cobro_x_Anticipo", ex.Message), ex) { EntityType = typeof(cxc_cobro_x_Anticipo_Bus) };
            }
        }

        public List<cxc_anticipo_facturado_Info> Get_List(int IdEmpresa, int IdSucursal, DateTime FechaIni, DateTime FechaFin, ref string mensaje)
        {
            try
            {
                return data.Get_List(IdEmpresa, IdSucursal, FechaIni, FechaFin, ref mensaje);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_cobro_x_Anticipo", ex.Message), ex) { EntityType = typeof(cxc_cobro_x_Anticipo_Bus) };
            }
        }

        public Boolean ExisteAnticipoFacturado(int IdEmpresa, int IdSucursal, int IdProyecto, int IdOferta)
        {
            try
            {
                return data.ExisteAnticipoFacturado(IdEmpresa, IdSucursal, IdProyecto, IdOferta);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Boolean validar_objeto(cxc_anticipo_facturado_Info info, ref string mensaje)
        {
            try
            {
                Boolean res = true;

                if (info.IdEmpresa == 0 || info.IdSucursal == 0)
                {
                    mensaje = "no hay IdEmpresa o IdSucursal";
                    res = false;
                }

                return res;
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "validar_objeto", ex.Message), ex) { EntityType = typeof(cxc_cobro_x_Anticipo_Bus) };
            }
        }

        public Boolean GuardarDB(cxc_anticipo_facturado_Info infoAnticipo, ref string mensaje)
        {
            try
            {
                if (!validar_objeto(infoAnticipo, ref mensaje))
                {
                    return false;
                }

                ct_Cbtecble_Bus Bus_CbteCble = new ct_Cbtecble_Bus();
                decimal IdCbteCble = 0;

                //GENERAMOS DIARIO
                if (Bus_CbteCble.GrabarDB(infoAnticipo.Info_CbteCble, ref IdCbteCble, ref mensaje))
                {
                    infoAnticipo.IdEmpresa_ct = infoAnticipo.Info_CbteCble.IdEmpresa;
                    infoAnticipo.IdTipoCbte_ct = infoAnticipo.Info_CbteCble.IdTipoCbte;
                    infoAnticipo.IdCbteCble_ct = infoAnticipo.Info_CbteCble.IdCbteCble;

                    //GRABAMOS REGISTRO DE ANTICIPO COBRADO                    
                    if (data.GrabarDB(infoAnticipo, ref mensaje))
                    {
                        // GRABAMOS EL DETALLE, SINO GRABA NO PASA NADA PORQUE UN ANTICIPO FACTURADO PUEDE EXISTIR SIN UN DETALLE
                        if(GrabarDetalleBD(infoAnticipo, ref mensaje))
                        {

                        }                        
                    }
                }

                return true;
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GuardarDB", ex.Message), ex) { EntityType = typeof(cxc_cobro_x_Anticipo_Bus) };
            }
        }

        private Boolean GrabarDetalleBD(cxc_anticipo_facturado_Info infoAnticipo, ref string mensaje)
        {
            try
            {
                ct_Cbtecble_Bus Bus_CbteCble = new ct_Cbtecble_Bus();
                cxc_anticipo_facturado_det_Data Data_Det = new cxc_anticipo_facturado_det_Data();
                bool resGrabar = false;

                foreach (var item in infoAnticipo.cxc_anticipo_facturado_det)
                {
                    item.IdEmpresa = infoAnticipo.IdEmpresa;
                    item.IdSucursal = infoAnticipo.IdSucursal;
                    item.IdAnticipo = infoAnticipo.IdAnticipo;

                    //SI NO TIENE DIARIO REGISTRADO GENERAMOS UN DIARIO
                    if (item.IdEmpresa_ct == null && item.IdTipoCbte_ct == null && item.IdCbteCble_ct == null)
                    {
                        ct_Cbtecble_Info Info_CbteCble = new ct_Cbtecble_Info();

                        item.IdCentroCosto = infoAnticipo.IdCentroCosto;

                        Info_CbteCble = Get_Diario_Cancelacion_Anticipo(item);

                        decimal _IdCbteCble = 0;

                        if (Bus_CbteCble.GrabarDB(Info_CbteCble, ref _IdCbteCble, ref mensaje))
                        {
                            item.IdEmpresa_ct = Info_CbteCble.IdEmpresa;
                            item.IdTipoCbte_ct = Info_CbteCble.IdTipoCbte;
                            item.IdCbteCble_ct = Info_CbteCble.IdCbteCble;
                        }
                    }

                    if (Data_Det.ExisteBD(item, mensaje))
                        resGrabar = Data_Det.ModificarBD(item, mensaje);
                    else
                        resGrabar = Data_Det.GrabarBD(item, mensaje);
                }

                return resGrabar;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private ct_Cbtecble_Info Get_Diario_Cancelacion_Anticipo(cxc_anticipo_facturado_det_Info item)
        {
            ct_Periodo_Bus Per_B = new ct_Periodo_Bus();
            ct_Periodo_Info Info_Periodo = new ct_Periodo_Info();
            ct_Cbtecble_Info Info_CbteCble = new ct_Cbtecble_Info();
            string mensaje = "";

            try
            {
                Info_Periodo = Per_B.Get_Info_Periodo(param.IdEmpresa, item.Fecha, ref mensaje);

                Info_CbteCble.IdEmpresa = param.IdEmpresa;
                Info_CbteCble.IdTipoCbte = 39; //AJUSTE ANTICIPO FACTURADO
                Info_CbteCble.IdCbteCble = 0;
                Info_CbteCble.CodCbteCble = "";
                Info_CbteCble.IdPeriodo = Info_Periodo.IdPeriodo;
                Info_CbteCble.cb_Fecha = item.Fecha;
                Info_CbteCble.cb_Valor = item.Valor;
                Info_CbteCble.cb_Observacion = item.Detalle;
                Info_CbteCble.Secuencia = 0;
                Info_CbteCble.Estado = "A";
                Info_CbteCble.Anio = Convert.ToDateTime(item.Fecha).Year;
                Info_CbteCble.Mes = Convert.ToDateTime(item.Fecha).Month;
                Info_CbteCble.IdUsuario = param.IdUsuario;
                Info_CbteCble.IdUsuarioUltModi = param.IdUsuario;
                Info_CbteCble.cb_FechaTransac = param.Fecha_Transac;
                Info_CbteCble.cb_FechaUltModi = param.Fecha_Transac;
                Info_CbteCble.Mayorizado = "N";

                //DEBE
                ct_Cbtecble_det_Info Info_CbteCble_Debe = new ct_Cbtecble_det_Info();
                Info_CbteCble_Debe.IdEmpresa = Info_CbteCble.IdEmpresa;
                Info_CbteCble_Debe.IdTipoCbte = Info_CbteCble.IdTipoCbte;
                Info_CbteCble_Debe.IdCbteCble = Info_CbteCble.IdCbteCble;
                Info_CbteCble_Debe.secuencia = 1;
                Info_CbteCble_Debe.IdCtaCble = "2010411001"; //Anticipo facturado por aplicar
                Info_CbteCble_Debe.IdCentroCosto = item.IdCentroCosto;
                Info_CbteCble_Debe.IdCentroCosto_sub_centro_costo = null;
                Info_CbteCble_Debe.dc_Valor = item.Valor;
                Info_CbteCble_Debe.dc_Observacion = item.Detalle;

                Info_CbteCble._cbteCble_det_lista_info.Add(Info_CbteCble_Debe);

                //HABER
                ct_Cbtecble_det_Info Info_CbteCble_Haber = new ct_Cbtecble_det_Info();
                Info_CbteCble_Haber.IdEmpresa = Info_CbteCble.IdEmpresa;
                Info_CbteCble_Haber.IdTipoCbte = Info_CbteCble.IdTipoCbte;
                Info_CbteCble_Haber.IdCbteCble = Info_CbteCble.IdCbteCble;
                Info_CbteCble_Haber.secuencia = 2;
                Info_CbteCble_Haber.IdCtaCble = (string.IsNullOrEmpty(item.IdCtaCble)) ? "40403" : item.IdCtaCble; //Ventas Diferidas año 2020
                Info_CbteCble_Haber.IdCentroCosto = item.IdCentroCosto;
                Info_CbteCble_Haber.IdCentroCosto_sub_centro_costo = null;
                Info_CbteCble_Haber.dc_Valor = item.Valor * -1;
                Info_CbteCble_Haber.dc_Observacion = item.Detalle;

                Info_CbteCble._cbteCble_det_lista_info.Add(Info_CbteCble_Haber);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return Info_CbteCble;
        }

        public Boolean ModificarDB(cxc_anticipo_facturado_Info infoAnticipo, ref string mensaje)
        {
            try
            {
                Boolean resGrabar = false;

                if (infoAnticipo.IdEmpresa_ct != null && infoAnticipo.IdTipoCbte_ct != null && infoAnticipo.IdCbteCble_ct != null)
                {
                    resGrabar = data.ModificarDB(infoAnticipo, ref mensaje);
                }
                else
                {
                    //GENERAMOS DIARIO
                    ct_Cbtecble_Bus Bus_CbteCble = new ct_Cbtecble_Bus();
                    decimal IdCbteCble = 0;

                    if (Bus_CbteCble.GrabarDB(infoAnticipo.Info_CbteCble, ref  IdCbteCble, ref mensaje))
                    {
                        //GRABAMOS REGISTRO DE ANTICIPO COBRADO
                        infoAnticipo.IdEmpresa_ct = infoAnticipo.Info_CbteCble.IdEmpresa;
                        infoAnticipo.IdTipoCbte_ct = infoAnticipo.Info_CbteCble.IdTipoCbte;
                        infoAnticipo.IdCbteCble_ct = infoAnticipo.Info_CbteCble.IdCbteCble;

                        resGrabar = data.ModificarDB(infoAnticipo, ref mensaje);
                    }
                }

                if (resGrabar)
                {
                    resGrabar = GrabarDetalleBD(infoAnticipo, ref mensaje);
                }

                return resGrabar;
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ModificarDB", ex.Message), ex) { EntityType = typeof(cxc_cobro_x_Anticipo_Bus) };
            }
        }

        public decimal Existe(int IdCliente, ref string mensaje)
        {
            try
            {
                return data.Existe(IdCliente, ref mensaje);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Existe", ex.Message), ex) { EntityType = typeof(cxc_cobro_x_Anticipo_Bus) };
            }
        }

        public bool Anular(cxc_anticipo_facturado_Info Info, ref string mensaje)
        {
            try
            {
                bool resAnular = false;

                if (Info.IdEmpresa_ct != null && Info.IdTipoCbte_ct != null && Info.IdCbteCble_ct != null)
                {
                    ct_Cbtecble_Bus Bus_CbteCble = new ct_Cbtecble_Bus();
                    int IdTipoCbte_Anul = 38;
                    decimal IdCbteCble_Anu = 0;

                    if (Bus_CbteCble.ReversoCbteCble(Convert.ToInt32(Info.IdEmpresa_ct), Convert.ToInt32(Info.IdCbteCble_ct), Convert.ToInt32(Info.IdTipoCbte_ct),
                        IdTipoCbte_Anul, ref IdCbteCble_Anu, ref mensaje, Info.Info_CbteCble.IdUsuarioAnu, Info.Info_CbteCble.cb_MotivoAnu))
                    {
                        Info.Estado = "I";

                        if (data.AnularDB(Info, ref mensaje))
                        {
                            resAnular = true;
                        }
                    }
                }
                else
                {
                    if (data.AnularDB(Info, ref mensaje))
                    {
                        resAnular = true;
                    }
                }

                return resAnular;
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Anular", ex.Message), ex) { EntityType = typeof(cxc_cobro_x_Anticipo_Bus) };
            }
        }
    }
}