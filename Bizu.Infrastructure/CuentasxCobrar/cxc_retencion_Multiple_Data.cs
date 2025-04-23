using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bizu.Domain.CuentasxCobrar;
using Bizu.Domain.Bancos;
using Bizu.Infrastructure.General;
using Bizu.Domain.General;
using System.Data.Entity.Validation;

namespace Bizu.Infrastructure.CuentasxCobrar
{
    public class cxc_retencion_Multiple_Data
    {
        string mensaje = "";

        public Boolean GuardarDB(cxc_retencion_Multiple_Info Info)
        {

            try
            {
                using (EntitiesCuentas_x_Cobrar Context = new EntitiesCuentas_x_Cobrar())
                {


                    var Address = new cxc_retencion_Multiple();
                    Address.IdEmpresa = Info.IdEmpresa;
                    Address.IdMultir = Convert.ToInt32(GetId(Info.IdEmpresa, Convert.ToInt32(Info.IdSucursal)));
                    Address.IdSucursal = Info.IdSucursal;                   
                    Address.Fecha = Convert.ToDateTime(Info.Fecha);
                    Address.FechaIngreso = Convert.ToDateTime(Info.FechaCobro);
                    Address.FechaCobro = Convert.ToDateTime(Info.FechaIngreso);
                    Address.IdCliente = Info.IdCliente;
                    Address.IdCaja = Info.IdCaja;
                    Address.NumRetencion = "RETEN" + "#" + Address.IdMultir;

                    Address.FechaRetencion = Info.FechaRetencion;
                    Address.TotalRetencion = Info.TotalRetencion;
                    Address.Estado = "A";

                    Info.IdMultir = Address.IdMultir;

                    Context.cxc_retencion_Multiple.Add(Address);
                    Context.SaveChanges();

                }
                return true;
            }
            catch (DbEntityValidationException ex)
            {
                foreach (var eve in ex.EntityValidationErrors)
                {
                    string arreglo = ToString();
                    mensaje = "Entity of type \"{0}\" in state \"{1}\" has the following validation errors:" +
                      eve.Entry.Entity.GetType().Name.ToString() + eve.Entry.State.ToString();

                    foreach (var ve in eve.ValidationErrors)
                    {
                        mensaje = mensaje + "- Property: \"{0}\", Error: \"{1}\"" +
                            ve.PropertyName.ToString() + ve.ErrorMessage;
                    }

                }
                throw new Exception(ex.ToString());
             }
      
        }

        public decimal GetId(int IdEmpresa, int IdSucursal)
        {
            try
            {
                decimal Id;
                EntitiesCuentas_x_Cobrar ocxc = new EntitiesCuentas_x_Cobrar();

                var select = (from q in ocxc.cxc_retencion_Multiple
                              where q.IdEmpresa == IdEmpresa
                              select q.IdMultir).Count();

                if (select == 0)
                {
                    Id = 1;
                }
                else
                {
                    var select_IdCXC = (from q in ocxc.cxc_retencion_Multiple
                                        where q.IdEmpresa == IdEmpresa
                                        select q.IdMultir).Max();
                    Id = Convert.ToInt32(select_IdCXC.ToString()) + 1;
                }
                return Id;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.InnerException.ToString());
            }
        }

        public Boolean ModificarDB(cxc_retencion_Multiple_Info Info)
        {
            try
            {
                Boolean res = false;
                using (EntitiesCuentas_x_Cobrar Context = new EntitiesCuentas_x_Cobrar())
                {
                    var contact = Context.cxc_retencion_Multiple.FirstOrDefault(cxc => cxc.IdEmpresa == Info.IdEmpresa && cxc.IdSucursal == Info.IdSucursal && cxc.IdMultir == Info.IdMultir);
                    if (contact != null)
                    {
                        //contact.cr_observacion = Info.cr_observacion;
                        contact.NumRetencion = Info.NumRetencion;
                        contact.Fecha = Info.Fecha;
                        contact.FechaCobro = Info.FechaCobro;
                        contact.FechaIngreso = Info.FechaIngreso;
                        contact.FechaRetencion = Info.FechaRetencion;
                        Context.SaveChanges();
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
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public Boolean AnularDB(cxc_retencion_Multiple_Info info)
        {
            try
            {
                Boolean res = false;
                using (EntitiesCuentas_x_Cobrar context = new EntitiesCuentas_x_Cobrar())
                {
                    var contact = context.cxc_retencion_Multiple.FirstOrDefault(cot => cot.IdEmpresa == info.IdEmpresa && cot.IdSucursal == info.IdSucursal && cot.IdMultir == info.IdMultir);
                    if (contact != null)
                    {
                       // contact.Fecha_UltAnu = DateTime.Now;
                       // contact.IdUsuarioUltAnu = info.IdUsuarioUltAnu;
                        contact.Estado = "I";
                        //contact.MotiAnula = info.MotiAnula;
                        //contact.cr_observacion = "REVERSADO" + info.cr_observacion;
                        context.SaveChanges();
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
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }


        public List<cxc_cobro_Info> Get_List_Cobros_para_Consulta_Retenciones(int IdEmpresa, int IdSucursal, DateTime Fecha_Ini, DateTime Fecha_Fin)
        {
            try
            {
                List<cxc_cobro_Info> lM = new List<cxc_cobro_Info>();
                EntitiesCuentas_x_Cobrar Base = new EntitiesCuentas_x_Cobrar();
                int IdsucursalIni = (IdSucursal == 0) ? 1 : IdSucursal;
                int IdsucursalFin = (IdSucursal == 0) ? 99999 : IdSucursal;

                Fecha_Ini = Convert.ToDateTime(Fecha_Ini.ToShortDateString());
                Fecha_Fin = Convert.ToDateTime(Fecha_Fin.ToShortDateString());


                var select_ = from T in Base.vwcxc_retencion_Multiple where T.IdEmpresa == IdEmpresa
                              && T.IdSucursal >= IdsucursalIni
                              && T.IdSucursal <= IdsucursalFin
                              && T.cr_fecha >= Fecha_Ini && T.cr_fecha <= Fecha_Fin
                              && T.IdCobro_tipo.Contains("RT")
                              select T;
                foreach (var item in select_)
                {
                    cxc_cobro_Info dat = new cxc_cobro_Info();


                    dat.IdEmpresa = item.IdEmpresa;
                    dat.IdSucursal = item.IdSucursal;

                    dat.IdMultir = item.IdMultir;
                    dat.Documento_Cobrado = item.Documento_Cobrado;

                    dat.IdCobro = item.IdCobro;
                    dat.IdCobro_tipo = item.IdCobro_tipo;
                    dat.IdCliente = item.IdCliente;
                    dat.cr_TotalCobro = item.cr_TotalCobro;
                    dat.cr_fecha = item.cr_fecha;
                    dat.cr_fechaCobro = item.cr_fechaCobro;
                    dat.cr_fechaDocu = Convert.ToDateTime(item.cr_fechaDocu);
                    dat.cr_observacion = item.cr_observacion;
                    dat.cr_Banco = item.cr_Banco;
                    dat.cr_cuenta = item.cr_cuenta;
                    dat.cr_NumDocumento = item.cr_NumDocumento;
                    dat.cr_estado = item.cr_estado;
                    dat.cr_recibo = item.cr_recibo;
                    dat.cr_Codigo = item.cr_Codigo;
                    dat.IdCaja = item.IdCaja;
                    dat.IdBanco = Convert.ToInt32(item.IdBanco);
                    dat.cr_propietarioCta = item.cr_propietarioCta;
                    dat.cr_es_anticipo = item.cr_es_anticipo;
                    dat.cr_Tarjeta = Convert.ToString(item.cr_Tarjeta);
                    //dat.cr_estadoCobro = item.cr_estadoCobro;
                    dat.nSucursal = item.nSucursal;
                    dat.nCliente = item.nCliente;
                    dat.chek = false;

                    lM.Add(dat);
                }
                return (lM);
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.InnerException.ToString());
            }
        }
    }
}
