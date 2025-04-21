using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Bancos;
using Core.Erp.Data.CuentasxPagar;
using Core.Erp.Data.General;
using Core.Erp.Data.Contabilidad;
using Core.Erp.Data.CuentasxCobrar;
using Core.Erp.Info.CuentasxCobrar;
using System.Data.Entity.Core.Objects;
using Core.Erp.Info.CuentasxPagar;
using Core.Erp.Info.General;
using System.Data.Entity.Validation;

namespace Core.Erp.Data.Bancos
{
    public class ba_Cbte_Ban_Datos_Entrega_cheq_Data
    {
        public Boolean GrabarDB(ba_Cbte_Ban_Datos_Entrega_cheq_Info info, ref string MensajeError)
        {
            try
            {
                using (EntitiesBanco context = new EntitiesBanco())
                {
                    ba_Cbte_Ban_Datos_Entrega_cheq address = new ba_Cbte_Ban_Datos_Entrega_cheq();
                    address.IdEmpresa = info.IdEmpresa;
                    address.IdCbteCble = info.IdCbteCble;
                    address.IdTipocbte = info.IdTipocbte;
                    address.Cedula = info.Cedula;
                    address.Nombres = info.Nombres;
                    address.Apellidos = info.Apellidos;
                    address.NotaEntrega = info.NotaEntrega;
                    address.FechaTransac = info.FechaTransac;
                    address.IdUsuario = info.IdUsuario;
                    address.FechaEntrega = info.FechaEntrega;
                    address.Foto = info.Foto;

                    context.ba_Cbte_Ban_Datos_Entrega_cheq.Add(address);
                    context.SaveChanges();
                }
                return true;

            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
                MensajeError = ex.InnerException + " " + ex.Message;
                Console.WriteLine(ex.InnerException.Message);
                throw new Exception(ex.InnerException.ToString());
            }
        }

        public ba_Cbte_Ban_Datos_Entrega_cheq_Info GetInfo(int IdEmpresa, decimal IdCbteCble, int IdTipocbte)
        {
            try
            {
                ba_Cbte_Ban_Datos_Entrega_cheq_Info Info = new ba_Cbte_Ban_Datos_Entrega_cheq_Info();

                EntitiesBanco dbContext = new EntitiesBanco();

                var query = dbContext.ba_Cbte_Ban_Datos_Entrega_cheq.Where(q => q.IdEmpresa == IdEmpresa && q.IdCbteCble == IdCbteCble && q.IdTipocbte == IdTipocbte);

                foreach(var item in query)
                {
                    Info.IdEmpresa = item.IdEmpresa;
                    Info.IdCbteCble = item.IdCbteCble;
                    Info.IdTipocbte = item.IdTipocbte;
                    Info.Cedula = item.Cedula;
                    Info.Nombres = item.Nombres;
                    Info.Apellidos = item.Apellidos;
                    Info.NotaEntrega = item.NotaEntrega;
                    Info.FechaTransac = item.FechaTransac;
                    Info.IdUsuario = item.IdUsuario;
                    Info.FechaEntrega = item.FechaEntrega;
                    Info.Foto = item.Foto;
                }

                return Info;
            }catch(Exception e)
            {
                throw e;
            }
        }
    }
}