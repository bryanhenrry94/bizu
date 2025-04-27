using Bizu.Infrastructure.General;
using Bizu.Domain.Contabilidad;
using Bizu.Domain.General;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bizu.Infrastructure.Contabilidad
{
    public class ct_anio_fiscal_x_cuenta_utilidad_Data
    {

        public ct_anio_fiscal_x_cuenta_utilidad_Info Get_Info_anioF_x_Cta(int Idempresa, int IdanioFiscal, ref string mensaje)
        {
            try
            {
                ct_anio_fiscal_x_cuenta_utilidad_Info Info = new ct_anio_fiscal_x_cuenta_utilidad_Info();
                using (EntitiesDBConta Context = new EntitiesDBConta())
                {

                    var Select = from q in Context.ct_anio_fiscal_x_cuenta_utilidad
                                 where q.idaniofiscal == IdanioFiscal
                                 && q.idempresa == Idempresa
                                 select q;
                    foreach (var item in Select)
                    {
                        Info.IdanioFiscal = item.idaniofiscal;
                        Info.IdCtaCble = item.idctacble;
                        Info.observacion = item.observacion;
                        Info.IdEmpresa_cbte_cierre = item.idempresa_cbte_cierre;
                        Info.IdTipoCbte_cbte_cierre = item.idtipocbte_cbte_cierre;
                        Info.IdCbteCble_cbte_cierre = item.idcbtecble_cbte_cierre;
                    }
                }
                return Info;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString();
                throw new Exception(ex.ToString());
            }
        }

        public bool GuardarDB(ct_anio_fiscal_x_cuenta_utilidad_Info Info, ref string mensaje)
        {
            try
            {
                Boolean res = false;
                using (EntitiesDBConta Context = new EntitiesDBConta())
                {
                    ct_anio_fiscal_x_cuenta_utilidad contact = new ct_anio_fiscal_x_cuenta_utilidad();

                    contact.idempresa = Info.IdEmpresa;
                    contact.idaniofiscal = Info.IdanioFiscal;
                    contact.idctacble = Info.IdCtaCble;
                    contact.observacion = (Info.observacion == null) ? "" : Info.observacion;

                    Context.ct_anio_fiscal_x_cuenta_utilidad.Add(contact);
                    Context.SaveChanges();
                    res = true;
                }
                return res;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString();
                throw new Exception(ex.ToString());
            }
        }


        public bool ModificiarDB(ct_anio_fiscal_x_cuenta_utilidad_Info Info, ref string mensaje)
        {
            try
            {
                Boolean res = false;
                using (EntitiesDBConta Context = new EntitiesDBConta())
                {
                    ct_anio_fiscal_x_cuenta_utilidad contact = Context.ct_anio_fiscal_x_cuenta_utilidad.FirstOrDefault(v => v.idempresa == Info.IdEmpresa && v.idaniofiscal == Info.IdanioFiscal);                  
                    if (contact != null)
                    {
                        contact.idctacble = Info.IdCtaCble;
                        Context.SaveChanges();
                        res = true;
                    }

                    if (contact == null) // no esta el año fiscal
                    {
                        GuardarDB(Info, ref mensaje);
                        res = true;
                    }

                }
                return res;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString();
                throw new Exception(ex.ToString());
            }
        }


        public bool ModificiarDB_CbteCierre(ct_anio_fiscal_x_cuenta_utilidad_Info Info, ref string mensaje)
        {
            try
            {
                Boolean res = false;
                using (EntitiesDBConta Context = new EntitiesDBConta())
                {
                    ct_anio_fiscal_x_cuenta_utilidad contact = Context.ct_anio_fiscal_x_cuenta_utilidad.FirstOrDefault(v => v.idempresa == Info.IdEmpresa && v.idaniofiscal == Info.IdanioFiscal);
                    if (contact != null)
                    {
                        contact.idempresa_cbte_cierre = Info.IdEmpresa_cbte_cierre;
                        contact.idtipocbte_cbte_cierre = Info.IdTipoCbte_cbte_cierre;
                        contact.idcbtecble_cbte_cierre = Info.IdCbteCble_cbte_cierre;

                        Context.SaveChanges();
                        res = true;
                    }

                    if (contact == null) // no esta el año fiscal
                    {
                        GuardarDB(Info, ref mensaje);
                        res = true;
                    }

                }
                return res;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString();
                throw new Exception(ex.ToString());
            }
        }
    
    }
}
