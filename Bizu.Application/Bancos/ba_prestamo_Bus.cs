using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bizu.Infrastructure.Bancos;
using Bizu.Domain.Bancos;
using Bizu.Application.General;


namespace Bizu.Application.Bancos
{
    public class ba_prestamo_Bus
    {
        string mensaje = "";
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        ba_prestamo_Data oData = new ba_prestamo_Data();
        ba_prestamo_detalle_Bus detalle_bus = new ba_prestamo_detalle_Bus();
        ba_prestamo_detalle_x_af_activo_fijo_Prendados_Bus detalle_activo_prendado_bus = new ba_prestamo_detalle_x_af_activo_fijo_Prendados_Bus();
        bool bandera_respuesta = false;
        public Boolean GuardarDB(ba_prestamo_Info Item, ref decimal Id, ref string msg)
        {
            try
            {
                if (oData.GuardarDB(Item, ref Id, ref  msg))
                {
                    foreach (var item in Item.lista_detalle)
                    {
                        item.IdEmpresa = Item.IdEmpresa;
                        item.IdPrestamo = Id;
                        if (item.EstadoPago == null)
                            item.EstadoPago = "PEN";
                        if (item.Observacion_det == null || item.Observacion_det.Length<=2)
                            item.Observacion_det = " vence al " + item.Fecha_Canc;
                        if (item.Estado == null)
                            item.Estado = "A";
                        item.IdUsuario = Item.IdUsuario;
                        item.Fecha_Transac = DateTime.Now;
                        
                    }

                    if(detalle_bus.GuardarPrestamoDetalle(Item.lista_detalle))
                    {

                        foreach (var item in Item.lista_activos_prendados)
                        {
                            item.IdEmpresa = Item.IdEmpresa;
                            item.IdPrestamo =(int) Id;
                        }

                        if (detalle_activo_prendado_bus.GrabarDB(Item.lista_activos_prendados))
                        {
                            bandera_respuesta = true;
                        }

                    }
                }
                return bandera_respuesta;
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "GuardarDB", ex.Message), ex) { EntityType = typeof(ba_prestamo_Bus) };
            }
        }
        
        

        public List<ba_prestamo_Info> Get_List_Prestamo(int IdEmpresa, DateTime FechaInci, DateTime FechaFin)
        {
            try
            {
                return oData.Get_List_Prestamo(IdEmpresa, FechaInci, FechaFin);
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "Get_List_Prestamo", ex.Message), ex) { EntityType = typeof(ba_prestamo_Bus) };
            }


        }

        public ba_prestamo_Info Get_Info_Prestamo(int IdEmpresa, decimal IdPrestamo, decimal IdEmpleado)
        {
            try
            {
                return oData.Get_Info_Prestamo(IdEmpresa, IdPrestamo, IdEmpleado);
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "Get_Info_Prestamo", ex.Message), ex) { EntityType = typeof(ba_prestamo_Bus) };
            }
        }

        public List<ba_prestamo_Info> Get_List_PrestamoxIdPrestamo(int IdEmpresa, decimal IdPrestamo)
        {
            try
            {
                 return oData.Get_List_PrestamoxIdPrestamo(IdEmpresa, IdPrestamo);
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "Get_List_PrestamoxIdPrestamo", ex.Message), ex) { EntityType = typeof(ba_prestamo_Bus) };
            }

        }

        public Boolean ModificarDB(ba_prestamo_Info Info)
        {
            try
            {
                if (oData.ModificarDB(Info))
                {
                    foreach (var item in Info.lista_detalle)
                    {
                        item.IdEmpresa = Info.IdEmpresa;
                        item.IdPrestamo = Info.IdPrestamo;
                    }
                   if( detalle_bus.Eliminar(Info.IdEmpresa, Convert.ToInt32(Info.IdPrestamo)))
                   {
                       if (detalle_bus.GuardarPrestamoDetalle(Info.lista_detalle))
                       {

                           foreach (var item in Info.lista_activos_prendados)
                           {
                               item.IdEmpresa = Info.IdEmpresa;
                               item.IdPrestamo = (int)Info.IdPrestamo;
                           }
                       }
                       if(detalle_activo_prendado_bus.EliminarDB(Info.IdEmpresa,Convert.ToInt32(Info.IdPrestamo)))
                       {
                        if (detalle_activo_prendado_bus.GrabarDB(Info.lista_activos_prendados))
                        {
                            bandera_respuesta = true;
                        }
                       }
                    }
                }
                return bandera_respuesta;
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "GuardarDB", ex.Message), ex) { EntityType = typeof(ba_prestamo_Bus) };
            }

        }

        public Boolean AnularDB(ba_prestamo_Info Info)
        {
            try
            {
              return oData.AnularDB(Info);
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "AnularDB", ex.Message), ex) { EntityType = typeof(ba_prestamo_Bus) };
            }

        }
        public ba_prestamo_Bus()
        {

        }
    }
}
