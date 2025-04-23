using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bizu.Infrastructure.CuentasxPagar;
using Bizu.Domain.CuentasxPagar;
using Bizu.Domain.Contabilidad;
using Bizu.Application.Contabilidad;
using Bizu.Application.General;

using System.Xml.Serialization;
using System.IO;
using Bizu.Domain.class_sri.Retencion;
using Bizu.Domain.General;


namespace Bizu.Application.CuentasxPagar
{
    public class cp_retencion_Bus
    {
        cp_retencion_Data data_retencion= new cp_retencion_Data();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        ct_Cbtecble_Bus CbteCble_B = new ct_Cbtecble_Bus();
        string mensaje = "";

        public cp_retencion_Info Get_Retencion_Valores_totales_x_OG(int IdEmpresa, int IdTipoCbteCble, decimal IdCbteCble)
        {
            try
            {
                return data_retencion.Get_Retencion_Valores_totales_x_OG(IdEmpresa, IdTipoCbteCble, IdCbteCble);
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "Get_Retencion_Valores_totales_x_OG", ex.Message), ex) { EntityType = typeof(cp_retencion_Bus) };
            }
        }

        public cp_retencion_Info Get_Info_retencion(int IdEmpresa, decimal IdCbteCble_Ogiro, int IdTipoCbte_Ogiro)
        {
            try
            {
                return data_retencion.Get_Info_retencion(IdEmpresa, IdCbteCble_Ogiro, IdTipoCbte_Ogiro);
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "Get_Info_retencion", ex.Message), ex) { EntityType = typeof(cp_retencion_Bus) };
            }

        }

        public cp_retencion_Info Get_Info_retencion_X_Retecion_FT(int IdEmpresa, decimal IdCbteCble_Ogiro, int IdTipoCbte_Ogiro)
        {
            try
            {
                return data_retencion.Get_Info_retencion_X_Retecion_FT(IdEmpresa, IdCbteCble_Ogiro, IdTipoCbte_Ogiro);
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "Get_Info_retencion", ex.Message), ex) { EntityType = typeof(cp_retencion_Bus) };
            }

        }
        
        public cp_retencion_Info Get_Info_retencion_X_Retecion_RTIVA(int IdEmpresa, decimal IdCbteCble_Ogiro, int IdTipoCbte_Ogiro)
        {
            try
            {
                return data_retencion.Get_Info_retencion_X_Retecion_RTIVA(IdEmpresa, IdCbteCble_Ogiro, IdTipoCbte_Ogiro);
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "Get_Info_retencion", ex.Message), ex) { EntityType = typeof(cp_retencion_Bus) };
            }

        }
               
        public cp_retencion_Info Get_Info_retencion(int IdEmpresa, decimal IdRetencion)
        {
            try
            {
                return data_retencion.Get_Info_retencion(IdEmpresa, IdRetencion);
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "Get_Info_retencion", ex.Message), ex) { EntityType = typeof(cp_retencion_Bus) };
            }

        }

        public List<cp_retencion_Info> Get_List_retencion(int IdEmpresa)
        {
            try
            {
                return data_retencion.Get_List_retencion(IdEmpresa);
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "Get_List_retencion", ex.Message), ex) { EntityType = typeof(cp_retencion_Bus) };
            }
        }

        public List<cp_retencion_Info> Get_List_retencion(int IdEmpresa,DateTime fechaIni,DateTime FechaFin)
        {
            try
            {
                return data_retencion.Get_List_retencion(IdEmpresa, fechaIni, FechaFin);
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "Get_List_retencion", ex.Message), ex) { EntityType = typeof(cp_retencion_Bus) };
            }
        }

        public List<vwcp_orden_giro_sin_retenciones_Info> Get_List_cp_orden_giro_sin_retenciones(int IdEmpresa, DateTime FechaDesde, DateTime FechaHasta)
        {
            try
            {
                return data_retencion.Get_List_cp_orden_giro_sin_retenciones(IdEmpresa,  FechaDesde, FechaHasta);
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "Get_List_cp_orden_giro_sin_retenciones", ex.Message), ex) { EntityType = typeof(cp_retencion_Bus) };
            }

        }

        public Boolean ValidaRetencion(cp_retencion_Info info,   ref string mensaje)
        { Boolean res = false;
        try
        {
            if (info == null)
            {
                mensaje = "La retención que desea grabar esta vacía.. "; return false;
            }
            if (info.IdEmpresa == 0 )
            {
                mensaje = "Al grabar la retención el código de la empresa está incorrecto...Comuniquese con Sistemas";
                return false;
            }
            if (info.IdCbteCble_Ogiro == 0 || info.IdCbteCble_Ogiro == null)
            {
                mensaje = "Al grabar la retención el código del CbteCble de la Factura Proveedor está incorrecto...Comuniquese con Sistemas";
                return false;
            }
            if (info.IdTipoCbte_Ogiro == 0 || info.IdTipoCbte_Ogiro == null)
            {
                mensaje = "Al grabar la retención el código del Tipo de Cbte de la Factura Proveedor está incorrecto...Comuniquese con Sistemas";
                return false;
            }
            if (info.fecha == null || info.fecha == new DateTime())
            {
                mensaje = "Al grabar la fecha de la retención está incorrecta...Comuniquese con Sistemas";
                return false;
            }
            if (info.ListDetalle == null || info.ListDetalle.Count < 1)
            {
                mensaje = "No se puede grabar una retención sin detalle.. "; return false;
            }
          
            res = true;
        }
        catch (Exception ex)
        {
            Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
            throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "ValidaRetencion", ex.Message), ex) { EntityType = typeof(cp_retencion_Bus) };
        }
        return res;
        }

        public Boolean Existe_Retencion(int IdEmpresa, decimal IdRetencion)
        {
            try
            {
                return data_retencion.Existe_Retencion(IdEmpresa,IdRetencion);
            }
            catch (Exception ex)
            {

                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "Existe_Retencion", ex.Message), ex) { EntityType = typeof(cp_retencion_Bus) };
            }
        
        }
       
        public Boolean Graba_CbteCble_Ret_FactProveedor(cp_retencion_Info info, ct_Cbtecble_Info cbtecble,  ref string mensaje)
        {
        
        
            decimal idCbteCble = 0;
            Boolean res_Grabar_RT = false;
            Boolean res_Grabar_CbteCble_x_RT = false;
            try
            {

                if (cbtecble.IdTipoCbte == 0)
                {
                    cp_parametros_Bus ParBu = new cp_parametros_Bus();
                    cp_parametros_Info ParaInfo = new cp_parametros_Info();

                    ParaInfo = ParBu.Get_Info_parametros(info.IdEmpresa);
                    cbtecble.IdTipoCbte = Convert.ToInt32(ParaInfo.pa_IdTipoCbte_x_Retencion);

                }



                cbtecble.IdCbteCble = idCbteCble;


                if (string.IsNullOrEmpty(cbtecble.cb_Observacion))
                {
                    cbtecble.cb_Observacion = info.observacion;
                }

                foreach (var item in cbtecble._cbteCble_det_lista_info)
                {
                    if (string.IsNullOrEmpty(item.dc_Observacion))
                    {
                        item.dc_Observacion = "RT " + info.observacion; 
                    }
                }

                if (info.IdRetencion == 0)
                {//grabando cabecera y detalle de retencion
                    res_Grabar_RT = GrabarDB(info);
                }
                else
                    res_Grabar_RT = true;// ya esta grabado


                if (res_Grabar_RT)//si grabo la retencion se hace el diario 
                {
                    res_Grabar_CbteCble_x_RT = CbteCble_B.GrabarDB(cbtecble, ref idCbteCble, ref mensaje);



                    //puede q no guarde el diario por q sea una retencion en 0%
                    if (res_Grabar_CbteCble_x_RT && res_Grabar_RT)//si grabo cbte y retencion
                    {
                        cp_retencion_x_ct_cbtecble_Info TI = new cp_retencion_x_ct_cbtecble_Info();
                        TI.ct_IdCbteCble = idCbteCble;
                        TI.ct_IdEmpresa = cbtecble.IdEmpresa;
                        TI.ct_IdTipoCbte = cbtecble.IdTipoCbte;
                        TI.Observacion = "";
                        TI.rt_IdEmpresa = info.IdEmpresa;
                        TI.rt_IdRetencion = info.IdRetencion;
                        GrabarDB_Ret_CbteCble(TI, ref mensaje);
                    }
                }

                return res_Grabar_RT;
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "Graba_CbteCble_Ret_FactProveedor", ex.Message), ex) { EntityType = typeof(cp_retencion_Bus) };
            }
        }
        
        public Boolean GrabarDB(cp_retencion_Info info)
        {

            Boolean res = false; string mensaje = "";
            try
            {
                return data_retencion.GrabarDB(info);
                  
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "GrabarDB", ex.Message), ex) { EntityType = typeof(cp_retencion_Bus) };
            }
            return res;            
        }

        public Boolean ActualizarDB(cp_retencion_Info Info, ref string msg)
        {

            try
            {
                Info.IdUsuarioUltMod = param.IdUsuario;
                Info.Fecha_UltMod = param.GetDateServer();
                return data_retencion.ActualizarDB(Info, ref msg);
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "ActualizarDB", ex.Message), ex) { EntityType = typeof(cp_retencion_Bus) };
            }
        }

        public Boolean GrabarDB_Ret_CbteCble(cp_retencion_x_ct_cbtecble_Info TI, ref string mensaje)
        {
           
            try
            {
              return data_retencion.GrabarDB_Ret_CbteCble(TI,ref mensaje );
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "GrabarDB_Ret_CbteCble", ex.Message), ex) { EntityType = typeof(cp_retencion_Bus) };
            }

        }

        public Boolean ModificarDB(cp_retencion_Info info, ct_Cbtecble_Info cbtecble, ref string mensaje)
        {
            Boolean res = true;
            try
            {
                cp_retencion_Info ret = new cp_retencion_Info();
                if (!ValidaRetencion(info, ref mensaje)) return false;


                ret = Get_Info_retencion(info.IdEmpresa, Convert.ToDecimal(info.IdCbteCble_Ogiro), Convert.ToInt32(info.IdTipoCbte_Ogiro));
                if (ret == null || ret.ListDetalle == null || ret.ListDetalle.Count <= 0)
                {
                    return Graba_CbteCble_Ret_FactProveedor(info, cbtecble,  ref mensaje);
                }
                info.IdRetencion = ret.IdRetencion;
                foreach (var item in info.ListDetalle)
                {
                    item.IdRetencion = info.IdRetencion;
                }

                if (cbtecble.IdCbteCble == 0)
                {
                    Graba_CbteCble_Ret_FactProveedor(info, cbtecble,  ref mensaje);
                }

                foreach (var item in cbtecble._cbteCble_det_lista_info)
                {
                    item.IdCbteCble = cbtecble.IdCbteCble;
                    item.IdTipoCbte = cbtecble.IdTipoCbte;
                }

                if (data_retencion.Modificar_Num_Retencion(info, ref mensaje)) // solo modifica la cab de retencion
                {
                    cp_retencion_det_Data odataDet = new cp_retencion_det_Data();
                    if (odataDet.ActualizarDB(info.ListDetalle, ret.ListDetalle)) // elimina el detalle y lo vuelve a crear 
                    {
                        
                            if (!CbteCble_B.ModificarDB(cbtecble, ref mensaje))
                                mensaje = "Ha ocurrido un error al actualizar el CbteCble de Retención..." + mensaje;
                       
                    }
                }
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "ModificarDB", ex.Message), ex) { EntityType = typeof(cp_retencion_Bus) };
            }
             return res;
        }

        public Boolean VericarNumRetencion(string NumRetencion, string Serie, int IdEmpresa, ref string mensaje, decimal IdCbteOG = 0)
        {
           
            try
            {
              return data_retencion.VericarNumRetencion(NumRetencion,Serie, IdEmpresa, ref mensaje, IdCbteOG);
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "VericarNumRetencion", ex.Message), ex) { EntityType = typeof(cp_retencion_Bus) };
            }

        }

        public Boolean VericarNumRetencion(string NumRetencion, string Serie, int IdEmpresa,  int IdEmpresa_OG, decimal IdCbteCble_OG, int IdTipoCbte_OG,ref string mensaje)
        {

            try
            {
                return data_retencion.VericarNumRetencion(NumRetencion, Serie, IdEmpresa, IdEmpresa_OG, IdCbteCble_OG,  IdTipoCbte_OG,ref  mensaje);
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "VericarNumRetencion", ex.Message), ex) { EntityType = typeof(cp_retencion_Bus) };
            }

        }

        public Boolean Modificar_Num_Retencion(cp_retencion_Info Info_Retencion, ref string mensajeError)
        {
            
            try
            {
                Boolean res = false;
                

                tb_sis_Documento_Tipo_Talonario_Bus busTalonario = new tb_sis_Documento_Tipo_Talonario_Bus();
                tb_sis_Documento_Tipo_Talonario_Info infoTalonario = new tb_sis_Documento_Tipo_Talonario_Info();
                tb_Sucursal_Bus Bus_Sucu = new tb_Sucursal_Bus();
                tb_Bodega_Bus Bus_bodega = new tb_Bodega_Bus();

                string mensajeDocumentoDupli = "";
                string cod_estable = "";
                string cod_pto_emision = "";

                Info_Retencion.CodDocumentoTipo = string.IsNullOrEmpty(Info_Retencion.CodDocumentoTipo) ? "RETEN" : Info_Retencion.CodDocumentoTipo;


                // el objeto viene sin serie o sin # factura tomo el ultimo num de factura del talonario
                if (Info_Retencion.serie1 == "" || Info_Retencion.serie1 == null || Info_Retencion.serie2 == "" || Info_Retencion.serie2 == null
                    || Info_Retencion.NumRetencion == "" || Info_Retencion.NumRetencion == null)
                {

                    cod_estable = Bus_Sucu.Get_Cod_Establecimiento_x_Sucursal(Info_Retencion.IdEmpresa, param.IdSucursal);
                    cod_pto_emision = Bus_bodega.Get_cod_pto_emision_x_Bodega(Info_Retencion.IdEmpresa, param.IdSucursal, 1);

                    infoTalonario = busTalonario.Get_Info_Primer_Documento_no_usado(Info_Retencion.IdEmpresa, cod_estable,cod_pto_emision, Info_Retencion.CodDocumentoTipo
                        , Info_Retencion.EsDocumentoElectronico);


                    if (infoTalonario.NumDocumento == null)
                    {
                        mensajeError = "No hay talonarios para Establecimiento=" + cod_estable + " y punto de emision=" + cod_pto_emision;
                        throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "no hay talonario activos", mensajeError)) { EntityType = typeof(cp_retencion_Bus) };
                    }

                    Info_Retencion.serie1 = infoTalonario.Establecimiento;
                    Info_Retencion.serie2 = infoTalonario.PuntoEmision;
                    Info_Retencion.NumRetencion = infoTalonario.NumDocumento;

                }
                else
                {

                    // se puede dar si mas de un usario estan haciendo la factura y tienen en memoria o en la pantalla el mismo talonario
                    //verifico el numero de factura si esta usado
                    infoTalonario.Establecimiento = Info_Retencion.serie1;
                    infoTalonario.PuntoEmision = Info_Retencion.serie2;
                    infoTalonario.NumDocumento = Info_Retencion.NumRetencion;
                    infoTalonario.IdEmpresa = Info_Retencion.IdEmpresa;
                    infoTalonario.CodDocumentoTipo = Info_Retencion.CodDocumentoTipo;
                    infoTalonario.es_Documento_electronico = Info_Retencion.EsDocumentoElectronico;


                    if (busTalonario.Documento_talonario_esta_Usado(infoTalonario, ref mensajeError, ref mensajeDocumentoDupli))
                    {
                        //si esta en usado busco el siguiente
                        cod_estable = Bus_Sucu.Get_Cod_Establecimiento_x_Sucursal(Info_Retencion.IdEmpresa, param.IdSucursal);
                        cod_pto_emision = Bus_bodega.Get_cod_pto_emision_x_Bodega(Info_Retencion.IdEmpresa, param.IdSucursal, 1);

                        infoTalonario = busTalonario.Get_Info_Primer_Documento_no_usado(Info_Retencion.IdEmpresa, cod_estable,
                            cod_pto_emision, Info_Retencion.CodDocumentoTipo, Info_Retencion.EsDocumentoElectronico);

                        if (infoTalonario.NumDocumento == null)
                        {
                            throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "no hay talonario activos", mensajeError)) { EntityType = typeof(cp_retencion_Bus) };
                        }

                        Info_Retencion.serie1 = infoTalonario.Establecimiento;
                        Info_Retencion.serie2 = infoTalonario.PuntoEmision;
                        Info_Retencion.NumRetencion = infoTalonario.NumDocumento;

                        if (!infoTalonario.es_Documento_electronico)
                        {
                            //si no es documento electronico le actualizo el numero de autorizacion y la fecha de autorizacion
                            Info_Retencion.NAutorizacion = infoTalonario.NumAutorizacion;
                            Info_Retencion.Fecha_Autorizacion = DateTime.Now.Date;
                        }
                        
                    }
                    else
                    {
                        if (!infoTalonario.es_Documento_electronico)
                        {
                            //Si no esta siendo usado, si no es documento electronico le actualizo el numero de autorizacion y la fecha de autorizacion
                            infoTalonario = busTalonario.Get_Info_Documento_Tipo_Talonario(Info_Retencion.IdEmpresa, Info_Retencion.CodDocumentoTipo, cod_estable, cod_pto_emision, Info_Retencion.NumRetencion);


                            Info_Retencion.NAutorizacion = infoTalonario.NumAutorizacion;
                            Info_Retencion.Fecha_Autorizacion = DateTime.Now.Date;
                        }
                    }
                }

                res = data_retencion.Modificar_Num_Retencion(Info_Retencion, ref mensajeError);
                busTalonario.Modificar_Estado_Usado(infoTalonario, ref mensajeError);

                return res;
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "ModificarNRetencion", ex.Message), ex) { EntityType = typeof(cp_retencion_Bus) };
            }

        }

        public Boolean AnularDB(cp_retencion_Info info,  ref decimal idCbteCble_anu, ref string mensaje)
        {
            Boolean res = true;
            try
            {                
                cp_parametros_Bus BusParam = new cp_parametros_Bus();
                cp_parametros_Info InfoParam = new cp_parametros_Info();
                InfoParam = BusParam.Get_Info_parametros(info.IdEmpresa);

                cp_retencion_x_ct_cbtecble_Info info_x_cbte = Get_Info_retencion_x_ct_cbtecble(info.IdEmpresa, info.IdRetencion);
                if (info_x_cbte.ct_IdEmpresa  != 0)
                {
                    info.Info_CbteCble_x_RT = CbteCble_B.Get_Info_CbteCble(info_x_cbte.ct_IdEmpresa, info_x_cbte.ct_IdTipoCbte, info_x_cbte.ct_IdCbteCble, ref mensaje);

                    switch (param.IdCliente_Ven_x_Default)
                    {
                        case Cl_Enumeradores.eCliente_Vzen.EDEHSA:
                            if (CbteCble_B.ReversoCbteCble_Edehsa(info.Info_CbteCble_x_RT.IdEmpresa, info.Info_CbteCble_x_RT.IdCbteCble, info.Info_CbteCble_x_RT.IdTipoCbte
                            , Convert.ToInt32(InfoParam.pa_IdTipoCbte_x_Anu_Retencion),Convert.ToDateTime(info.Fecha_UltAnu),
                            ref idCbteCble_anu, ref mensaje, info.IdUsuarioUltAnu, info.MotivoAnulacion))
                            {
                                info.ct_IdEmpresa_Anu = info.Info_CbteCble_x_RT.IdEmpresa;
                                info.ct_IdCbteCble_Anu = idCbteCble_anu;
                                info.ct_IdTipoCbte_Anu = InfoParam.pa_IdTipoCbte_x_Anu_Retencion;
                            }
                         
                            break;

                        default:
                            if (CbteCble_B.ReversoCbteCble(info.Info_CbteCble_x_RT.IdEmpresa, info.Info_CbteCble_x_RT.IdCbteCble, info.Info_CbteCble_x_RT.IdTipoCbte
                            , Convert.ToInt32(InfoParam.pa_IdTipoCbte_x_Anu_Retencion),
                            ref idCbteCble_anu, ref mensaje, info.IdUsuarioUltAnu, info.MotivoAnulacion))
                             {
                                info.ct_IdEmpresa_Anu = info.Info_CbteCble_x_RT.IdEmpresa;
                                info.ct_IdCbteCble_Anu = idCbteCble_anu;
                                info.ct_IdTipoCbte_Anu = InfoParam.pa_IdTipoCbte_x_Anu_Retencion;
                            }
                            break;
                    }
                    
                }
                return data_retencion.AnularDB(info, ref mensaje);                
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "AnularDB", ex.Message), ex) { EntityType = typeof(cp_retencion_Bus) };
            }
            return res;
        }
              
        public cp_retencion_x_ct_cbtecble_Info Get_Info_retencion_x_ct_cbtecble(int IdEmpresa, decimal IdCbteCble, int IdTipoCbte)
        { 
        
            try
            {
               return data_retencion.Get_Info_retencion_x_ct_cbtecble(IdEmpresa, IdCbteCble, IdTipoCbte); 
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "Get_Info_retencion_x_ct_cbtecble", ex.Message), ex) { EntityType = typeof(cp_retencion_Bus) };
            } 
        }

        public cp_retencion_x_ct_cbtecble_Info Get_Info_retencion_x_ct_cbtecble(int IdEmpresa, decimal IdRetencion)
        {

            try
            {
                return data_retencion.Get_Info_retencion_x_ct_cbtecble(IdEmpresa, IdRetencion);
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "Get_Info_retencion_x_ct_cbtecble", ex.Message), ex) { EntityType = typeof(cp_retencion_Bus) };
            }
        }

        public List<vwcp_Retencion_sri_Info> Get_Lis_reten(int IdEmpresa, decimal IdRetencion,ref string MensajeError)
        {
            try
            {
                List<vwcp_Retencion_sri_Info> lista_Retencion = new List<vwcp_Retencion_sri_Info>();
                lista_Retencion = data_retencion.Get_list_Retencion_Sri(IdEmpresa, IdRetencion, ref MensajeError);
                return lista_Retencion;
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "Get_Info_retencion_x_ct_cbtecble", ex.Message), ex) { EntityType = typeof(cp_retencion_Bus) };
            }
        }

        public Boolean Generacion_xml_SRI(int IdEmpresa, decimal IdRetencion,ref string MensajeError)
        {
            try
            {

                cp_parametros_Info cp_parametro = new cp_parametros_Info();
                cp_parametros_Bus bus_cp_parametro = new cp_parametros_Bus();
                cp_parametro = bus_cp_parametro.Get_Info_parametros(IdEmpresa);
                string sIdCbteFact = "";
                          
                List<vwcp_Retencion_sri_Info> lista_Retencion_sri = new List<vwcp_Retencion_sri_Info>();

                lista_Retencion_sri = data_retencion.Get_list_Retencion_Sri(IdEmpresa, IdRetencion, ref MensajeError);

                if (lista_Retencion_sri.Count !=0)
                {
                   // validar objeto

                    if(!ValidarObjeto_XML_Retencion( lista_Retencion_sri, ref  MensajeError))
                      return false;


                    List<comprobanteRetencion> lista = new List<comprobanteRetencion>();
                    lista = data_retencion.GenerarXmlRetencion(IdEmpresa, IdRetencion, ref MensajeError);

                    if (lista.Count != 0)
                    {
                        foreach (var item in lista)
                        {

                            sIdCbteFact = item.infoTributaria.razonSocial.Substring(0, 3) + "-" + Cl_Enumeradores.eTipoCodComprobante.RET + "-" + item.infoTributaria.estab + "-" + item.infoTributaria.ptoEmi + "-" + item.infoTributaria.secuencial;
                            XmlSerializerNamespaces NamespaceObject = new XmlSerializerNamespaces();
                            NamespaceObject.Add("", "");
                            XmlSerializer mySerializer = new XmlSerializer(typeof(comprobanteRetencion));
                            StreamWriter myWriter = new StreamWriter(cp_parametro.pa_ruta_descarga_xml_fac_elct + sIdCbteFact + ".xml");
                            mySerializer.Serialize(myWriter, item, NamespaceObject);
                            myWriter.Close();


                        }
                    }


                }
                                                                                                                  
                return true;
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "Generacion_xml_SRI", ex.Message), ex) { EntityType = typeof(cp_retencion_Bus) };
                
            }
        
        }

        public Boolean ValidarObjeto_XML_Retencion(List<vwcp_Retencion_sri_Info> lista, ref string MensajeError)
        {
            try
            {
                Boolean res = true;

                foreach (var item in lista)
                {
                   
                    if(String.IsNullOrEmpty(item.RazonSocial))
                    {
                        MensajeError = "Falta Razón Social Empresa. Por Favor verifique";
                        res = false;
                        return res;
                    
                    }
                    if (String.IsNullOrEmpty(item.NombreComercial))
                    {
                        MensajeError = "Falta Nombre Comercial Empresa. Por Favor verifique";
                        res = false;
                        return res;

                    }

                    if (String.IsNullOrEmpty(item.em_direccion))
                    {
                        MensajeError = "Falta Dirección Matriz Empresa. Por Favor verifique";
                        res = false;
                        return res;

                    }

                    if (String.IsNullOrEmpty(item.em_ruc))
                    {
                        MensajeError = "Falta Tipo de Identificación Empresa. Por Favor verifique";
                        res = false;
                        return res;

                    }

                    //if (String.IsNullOrEmpty(item.ContribuyenteEspecial))
                    //{
                    //    MensajeError = "Falta Número de Contribuyente Especial Empresa. Por Favor verifique";
                    //    res = false;
                    //    return res;
                    //}

                    //Retencion
                    if (String.IsNullOrEmpty(item.serie))
                    {
                        MensajeError = "Falta serie del Documento o la Retención no ha sido Impresa. Por Favor verifique";
                        res = false;
                        return res;

                    }

                    if (String.IsNullOrEmpty(item.NumRetencion))
                    {
                        MensajeError = "Falta Secuencial del Documento o la Retención no ha sido Impresa. Por Favor verifique";
                        res = false;
                        return res;

                    }

                    //Proveedor
                    if (String.IsNullOrEmpty(item.Su_Direccion))
                    {
                        MensajeError = "Falta Dirección Establecimiento. Por Favor verifique";
                        res = false;
                        return res;

                    }

                    if (String.IsNullOrEmpty(item.pe_razonSocial))
                    {
                        MensajeError = "Falta Razón Social del Sujeto a Retener. Por Favor verifique";
                        res = false;
                        return res;

                    }

                    if (String.IsNullOrEmpty(item.pe_cedulaRuc))
                    {
                        MensajeError = "Falta Identificación del Sujeto Retenido. Por Favor verifique";
                        res = false;
                        return res;
                    }
                }

                return res;
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "ValidarObjeto_XML_Retencion", ex.Message), ex) { EntityType = typeof(cp_retencion_Bus) };
            }


        }

        public byte[] Get_Comprobante_Efirm_PDF(int IdEmpresa, decimal IdRetencion, ref string IdComprobante, ref string mensaje_error)
        {
            try
            {
                tb_Comprobantes_Efirm_Bus Bus_Comprobante = new tb_Comprobantes_Efirm_Bus();
                cp_proveedor_Bus Bus_Proveedor = new cp_proveedor_Bus();
                cp_proveedor_Info Info_Proveedor;
                cp_retencion_Info Info_Retencion;
                cp_orden_giro_Info Info_OrdenGiro;
                cp_orden_giro_Bus Bus_OrdenGiro = new cp_orden_giro_Bus();                
                byte[] result = null;
                int IdEmpresa_Efirm = 0;

                Info_Retencion = Get_Info_retencion(IdEmpresa, IdRetencion);

                if (Info_Retencion != null)
                {
                    Info_OrdenGiro = Bus_OrdenGiro.Get_Info_orden_giro(Convert.ToInt32(Info_Retencion.IdEmpresa), Convert.ToInt32(Info_Retencion.IdTipoCbte_Ogiro), Convert.ToDecimal(Info_Retencion.IdCbteCble_Ogiro));

                    if (Info_OrdenGiro == null)
                    {
                        mensaje_error = "No se ha encontrado relacion con el documento de proveedor Cbte Ogiro#" + Info_Retencion.IdCbteCble_Ogiro;
                        throw new Exception(mensaje_error);                        
                    }

                    IdComprobante = Cl_Enumeradores.eTipoComprobante_Alias.RT + "-" + Info_Retencion.serie1 + "-" + Info_Retencion.serie2 + "-" + Info_Retencion.NumRetencion;

                    if (string.IsNullOrEmpty(IdComprobante))
                    {
                        mensaje_error = "No se puede realizar la consulta para el comprobante #" + IdComprobante; 
                        throw new Exception(mensaje_error);
                    }

                    Info_Proveedor = Bus_Proveedor.Get_Info_Proveedor(Info_Retencion.IdEmpresa, Info_OrdenGiro.IdProveedor);

                    if (Info_Proveedor == null)
                    {
                        mensaje_error = "No se puede realizar la consulta porque no existe la cedula/ruc para el proveedor Id#" + Info_OrdenGiro.IdProveedor;
                        throw new Exception(mensaje_error);
                    }

                    IdEmpresa_Efirm = Bus_Comprobante.Get_IdEmpresa_x_Ruc(param.InfoEmpresa.em_ruc, ref mensaje_error);

                    result = Bus_Comprobante.Get_RidePdf(IdEmpresa_Efirm, Info_Proveedor.Persona_Info.pe_cedulaRuc, IdComprobante, ref mensaje_error);                                                                    
                }
                else
                {
                    mensaje = "No se encontraron registros para el comprobante de Ret. #" + IdRetencion;
                }

                return result;
            }
            catch (Exception ex)
            {
                mensaje_error = ex.Message;
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "Get_Comprobante_Efirm_PDF", ex.Message), ex) { EntityType = typeof(cp_retencion_Bus) };
            }
        }

        public string Get_Comprobante_Efirm_XML(int IdEmpresa, decimal IdRetencion, ref string IdComprobante, ref string mensaje_error)
        {
            try
            {
                tb_Comprobantes_Efirm_Bus Bus_Comprobante = new tb_Comprobantes_Efirm_Bus();
                cp_proveedor_Bus Bus_Proveedor = new cp_proveedor_Bus();
                cp_proveedor_Info Info_Proveedor;
                cp_retencion_Info Info_Retencion;                                
                cp_orden_giro_Info Info_OrdenGiro;
                cp_orden_giro_Bus Bus_OrdenGiro = new cp_orden_giro_Bus();
                int IdEmpresa_Efirm = 0;
                string result = "";

                Info_Retencion = Get_Info_retencion(IdEmpresa, IdRetencion);

                if (Info_Retencion != null)
                {
                    Info_OrdenGiro = Bus_OrdenGiro.Get_Info_orden_giro(Convert.ToInt32(Info_Retencion.IdEmpresa), Convert.ToInt32(Info_Retencion.IdTipoCbte_Ogiro), Convert.ToDecimal(Info_Retencion.IdCbteCble_Ogiro));

                    if (Info_OrdenGiro == null)
                    {
                        mensaje_error = "No se ha encontrado relacion con el documento de proveedor Cbte Ogiro#" + Info_Retencion.IdCbteCble_Ogiro;
                        throw new Exception(mensaje_error);
                    }

                    IdComprobante = Cl_Enumeradores.eTipoComprobante_Alias.RT + "-" + Info_Retencion.serie1 + "-" + Info_Retencion.serie2 + "-" + Info_Retencion.NumRetencion;

                    if (string.IsNullOrEmpty(IdComprobante))
                    {
                        mensaje_error = "No se puede realizar la consulta para el comprobante #" + IdComprobante;
                        throw new Exception(mensaje_error);
                    }

                    Info_Proveedor = Bus_Proveedor.Get_Info_Proveedor(Info_Retencion.IdEmpresa, Info_OrdenGiro.IdProveedor);

                    if (Info_Proveedor == null)
                    {
                        mensaje_error = "No se puede realizar la consulta porque no existe la cedula/ruc para el proveedor Id#" + Info_OrdenGiro.IdProveedor;
                        throw new Exception(mensaje_error);
                    }

                    IdEmpresa_Efirm = Bus_Comprobante.Get_IdEmpresa_x_Ruc(param.InfoEmpresa.em_ruc, ref mensaje_error);

                    result = Bus_Comprobante.Get_Xml(IdEmpresa_Efirm, Info_Proveedor.Persona_Info.pe_cedulaRuc, IdComprobante, ref mensaje_error);                    
                }
                else
                {
                    mensaje = "No se encontraron registros para el comprobante de Ret. #" + IdRetencion;
                }                
             
                return result;
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "Get_Comprobante_Efirm_XML", ex.Message), ex) { EntityType = typeof(cp_retencion_Bus) };
            }
        }

        public cp_retencion_Bus() { }

    }
}

