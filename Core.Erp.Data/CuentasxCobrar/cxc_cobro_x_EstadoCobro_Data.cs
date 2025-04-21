using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.CuentasxCobrar;
using Core.Erp.Info.General;
using Core.Erp.Data.General;
///Prog: Derek Mejia
///V 22 02 2014 12.18

namespace Core.Erp.Data.CuentasxCobrar
{
    public class cxc_cobro_x_EstadoCobro_Data
    {
        string mensaje = "";
        public Boolean GuardarDB_Verifica_si_es_Protestado(List<cxc_cobro_x_EstadoCobro_Info> lista, ref string msg)
        {
            try
            {
                try
                {
                    cxc_cobro_x_EstadoCobro_Info info = new cxc_cobro_x_EstadoCobro_Info();
                    EntitiesCuentas_x_Cobrar context = new EntitiesCuentas_x_Cobrar();
                    var select = from q in context.cxc_cobro_x_EstadoCobro
                                 select q;
                    if(msg=="PROS"){
                    foreach (var item in lista)
                    {
                        select = from q in context.cxc_cobro_x_EstadoCobro
                                     where q.IdEmpresa == item.IdEmpresa && q.IdSucursal == item.IdSucursal 
                                     && q.IdCobro == item.IdCobro && q.IdEstadoCobro == item.IdEstadoCobro 
                                     && q.IdCobro_tipo == item.IdCobro_tipo
                                     select q;

                    }
                    if (select.ToList().Count() == 1) {
                        msg = "Ya se encuentra Protestado";
                        return false; }
                    }
                }
                catch (Exception ex)
                {
                    string arreglo = ToString();
                    tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                    tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                    oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                    mensaje = ex.InnerException + " " + ex.Message;
                }
                using (EntitiesCuentas_x_Cobrar context = new EntitiesCuentas_x_Cobrar())
                {
                    foreach (var item in lista)
                    {
                    //var contactG = cxc_cobro_x_EstadoCobro.Createcxc_cobro_x_EstadoCobro(0,0,0,"","",DateTime.Now);

                    cxc_cobro_x_EstadoCobro addressG = new cxc_cobro_x_EstadoCobro();
                    addressG.IdEmpresa = item.IdEmpresa;
                    addressG.IdSucursal = item.IdSucursal;
                    addressG.IdCobro = item.IdCobro;
                    addressG.Secuencia = GetSecuencia(item.IdEmpresa,item.IdSucursal, item.IdCobro);
                    
                    addressG.IdCobro_tipo = item.IdCobro_tipo;
                    addressG.IdEstadoCobro = item.IdEstadoCobro;
                    addressG.Fecha = item.Fecha;
                    addressG.nt_IdBodega = item.nt_IdBodega;
                    addressG.nt_IdNota = item.nt_IdNota;
                    addressG.nt_IdSucursal = item.nt_IdSucursal;
                    addressG.IdBanco = item.IdBanco;
                    addressG.observacion = item.observacion;
                    addressG.IdCbte_vta_nota = item.IdCbte_vta_nota;

                    //contactG = addressG;
                    context.cxc_cobro_x_EstadoCobro.Add(addressG);
                    context.SaveChanges();
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                msg = ex.Message;
                throw new Exception(ex.InnerException.ToString());
            }

        }

        public Boolean GuardarDB(cxc_cobro_x_EstadoCobro_Info InfoEstadoCobro)
        {
            try 
            {
                using(EntitiesCuentas_x_Cobrar context = new EntitiesCuentas_x_Cobrar())
                {
                    //no se debe insertar el mismo tipo de estado para el mismo cobro
                    var Q = from tbCbteCble in context.cxc_cobro_x_EstadoCobro
                            where tbCbteCble.IdEmpresa == InfoEstadoCobro.IdEmpresa
                            && tbCbteCble.IdSucursal == InfoEstadoCobro.IdSucursal
                            && tbCbteCble.IdCobro == InfoEstadoCobro.IdCobro
                            && tbCbteCble.IdCobro_tipo == InfoEstadoCobro.IdCobro_tipo
                            select tbCbteCble;

                    if (Q.ToList().Count == 0)
                    {

                        cxc_cobro_x_EstadoCobro addressG = new cxc_cobro_x_EstadoCobro();
                        addressG.IdEmpresa = InfoEstadoCobro.IdEmpresa;
                        addressG.Secuencia = GetSecuencia(InfoEstadoCobro.IdEmpresa, InfoEstadoCobro.IdSucursal, InfoEstadoCobro.IdCobro);
                        addressG.IdSucursal = InfoEstadoCobro.IdSucursal;
                        addressG.IdCobro = InfoEstadoCobro.IdCobro;
                        addressG.IdCobro_tipo = InfoEstadoCobro.IdCobro_tipo;
                        addressG.IdEstadoCobro = InfoEstadoCobro.IdEstadoCobro;
                        addressG.Fecha = InfoEstadoCobro.Fecha;
                        addressG.nt_IdBodega = InfoEstadoCobro.nt_IdBodega;
                        addressG.nt_IdNota = InfoEstadoCobro.nt_IdNota;
                        addressG.nt_IdSucursal = InfoEstadoCobro.nt_IdSucursal;
                        addressG.IdBanco = InfoEstadoCobro.IdBanco;
                        addressG.observacion = "";
                        addressG.IdCbte_vta_nota = InfoEstadoCobro.IdCbte_vta_nota;
                        context.cxc_cobro_x_EstadoCobro.Add(addressG);
                        context.SaveChanges();
                    }


                }
                return true;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.InnerException.ToString());
            }
        }

        public List<cxc_cobro_x_EstadoCobro_Info> Get_List_cobro_x_EstadoCobro(int IdEmpresa) 
        {
            try
            {
                EntitiesCuentas_x_Cobrar oen = new EntitiesCuentas_x_Cobrar();
                string querty = " select a.*,b.posicion from cxc_cobro_x_EstadoCobro a inner join cxc_EstadoCobro b " +
                                " on a.IdEstadoCobro =b.IdEstadoCobro where IdEmpresa="+IdEmpresa+" order by IdCobro,posicion ";
                return oen.Database.SqlQuery<cxc_cobro_x_EstadoCobro_Info>(querty).ToList();
            }
            catch(Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.InnerException.ToString());
            }
        }

        private int GetSecuencia(int IdEmpresa,int IdSucursal, decimal IdCobro)
        {
            try
            {
                int Id;
                EntitiesCuentas_x_Cobrar ECXP = new EntitiesCuentas_x_Cobrar();

                var select = ECXP.cxc_cobro_x_EstadoCobro.Count(q => q.IdEmpresa == IdEmpresa && q.IdCobro == IdCobro && q.IdSucursal==IdSucursal);
                if (select == 0)
                {
                    return Id = 1;
                }

                else
                {
                    var select_ = (from t in ECXP.cxc_cobro_x_EstadoCobro
                                   where t.IdEmpresa == IdEmpresa && t.IdCobro == IdCobro && t.IdSucursal == IdSucursal
                                   select t.Secuencia).Max();
                    Id = Convert.ToInt32(select_.ToString()) + 1;
                    return Id;
                }
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.InnerException.ToString());
            }
        }

        public Boolean GuardarDB_(cxc_cobro_x_EstadoCobro_Info InfoEstadoCobro)
        {
            try
            {
                using (EntitiesCuentas_x_Cobrar context = new EntitiesCuentas_x_Cobrar())
                {                 
                        cxc_cobro_x_EstadoCobro addressG = new cxc_cobro_x_EstadoCobro();
                        addressG.IdEmpresa = InfoEstadoCobro.IdEmpresa;
                        addressG.Secuencia = GetSecuencia(InfoEstadoCobro.IdEmpresa, InfoEstadoCobro.IdSucursal, InfoEstadoCobro.IdCobro);
                        addressG.IdSucursal = InfoEstadoCobro.IdSucursal;
                        addressG.IdCobro = InfoEstadoCobro.IdCobro;
                        addressG.IdCobro_tipo = InfoEstadoCobro.IdCobro_tipo;
                        addressG.IdEstadoCobro = InfoEstadoCobro.IdEstadoCobro;
                        addressG.Fecha = InfoEstadoCobro.Fecha;
                        addressG.nt_IdBodega = InfoEstadoCobro.nt_IdBodega;
                        addressG.nt_IdNota = InfoEstadoCobro.nt_IdNota;
                        addressG.nt_IdSucursal = InfoEstadoCobro.nt_IdSucursal;
                        addressG.IdBanco = InfoEstadoCobro.IdBanco;
                        addressG.observacion = "";
                        addressG.IdCbte_vta_nota = InfoEstadoCobro.IdCbte_vta_nota;
                        context.cxc_cobro_x_EstadoCobro.Add(addressG);
                        context.SaveChanges();
                }
                return true;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.InnerException.ToString());
            }
        }

        public List<cxc_cobro_x_EstadoCobro_Info> Get_List_cobro_x_EstadoCobro_Concil(int IdEmpresa, int IdSucursal, int IdCobro)
        {
            try
            {
                EntitiesCuentas_x_Cobrar oen = new EntitiesCuentas_x_Cobrar();
                string querty = " select a.*,b.posicion from cxc_cobro_x_EstadoCobro a inner join cxc_EstadoCobro b " +
                                " on a.IdEstadoCobro =b.IdEstadoCobro where IdEmpresa=" + IdEmpresa + " and IdSucursal=" + IdSucursal + " and IdCobro=" + IdCobro + " order by IdCobro,posicion ";
                return oen.Database.SqlQuery<cxc_cobro_x_EstadoCobro_Info>(querty).ToList();
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.InnerException.ToString());
            }
        }

        public Boolean ModificarEstadoCobro_Concil(List<cxc_cobro_x_EstadoCobro_Info> lista)
        {
            try
            {
                try
                {
                    List<cxc_cobro_x_EstadoCobro_Info> listaAux = new List<cxc_cobro_x_EstadoCobro_Info>();
                    cxc_cobro_x_EstadoCobro_Info i = new cxc_cobro_x_EstadoCobro_Info();
                    i = lista.First();
                    listaAux = Get_List_Cobro_detalle_EstadoCobro(i.IdEmpresa, i.IdSucursal, i.IdCobro);

                    using (EntitiesCuentas_x_Cobrar context = new EntitiesCuentas_x_Cobrar())
                    {
                        foreach (var item in listaAux)
                        {
                            var contact = context.cxc_cobro_x_EstadoCobro.First(cot => cot.IdEmpresa == item.IdEmpresa && cot.IdSucursal == item.IdSucursal && cot.IdCobro == item.IdCobro);
                            context.cxc_cobro_x_EstadoCobro.Remove(contact);
                            context.SaveChanges();
                        }
                    }
                }
                catch (Exception ex)
                {
                    string arreglo = ToString();
                    tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                    tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                        "", "", "", "", DateTime.Now);
                    oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                    mensaje = ex.InnerException + " " + ex.Message;
                }
                using (EntitiesCuentas_x_Cobrar Contex = new EntitiesCuentas_x_Cobrar())
                {
                    foreach (var item in lista)
                    {
                         var address = new cxc_cobro_x_EstadoCobro();

                         address.IdEmpresa = item.IdEmpresa;
                         address.IdSucursal = item.IdSucursal;
                         address.IdCobro = item.IdCobro;
                         address.IdEstadoCobro = "PORC";
                         address.Secuencia = item.Secuencia;
                         address.IdCobro_tipo = item.IdCobro_tipo;
                         address.observacion = item.observacion;
                         address.Fecha = item.Fecha;
                         address.nt_IdSucursal = item.nt_IdSucursal;
                         address.nt_IdBodega = item.nt_IdBodega;
                         address.nt_IdNota = item.nt_IdNota;
                         address.IdBanco = item.IdBanco;
                         address.IdCbte_vta_nota = item.IdCbte_vta_nota;
                         address.IdUsuario = item.IdUsuario;
                         address.nom_pc = item.nom_pc;
                         address.ip = item.ip;

                         Contex.cxc_cobro_x_EstadoCobro.Add(address);
                         Contex.SaveChanges();
                    }
                }
                return true;
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

        public List<cxc_cobro_x_EstadoCobro_Info> Get_List_Cobro_detalle_EstadoCobro(int IdEmpresa, int idsucursal, decimal idcobro)
        {
            try
            {
                List<cxc_cobro_x_EstadoCobro_Info> lM = new List<cxc_cobro_x_EstadoCobro_Info>();
                EntitiesCuentas_x_Cobrar CXC = new EntitiesCuentas_x_Cobrar();
                var select_det_cobro = from A in CXC.cxc_cobro_x_EstadoCobro
                                       where A.IdEmpresa == IdEmpresa
                                       && A.IdSucursal == idsucursal
                                       && A.IdCobro == idcobro
                                       select A
                                      ;
                foreach (var item in select_det_cobro)
                {
                    cxc_cobro_x_EstadoCobro_Info dat = new cxc_cobro_x_EstadoCobro_Info();
                    dat.IdEmpresa = item.IdEmpresa;
                    dat.IdSucursal = item.IdSucursal;
                    dat.IdCobro = item.IdCobro;
                    dat.IdEstadoCobro = item.IdEstadoCobro;
                    dat.Secuencia = item.Secuencia;                   
                    dat.IdCobro_tipo = item.IdCobro_tipo;
                    dat.observacion = item.observacion;
                    dat.Fecha = item.Fecha;
                    dat.nt_IdSucursal = item.nt_IdSucursal;
                    dat.nt_IdBodega = item.nt_IdBodega;
                    dat.nt_IdNota = item.nt_IdNota;                
                    dat.IdBanco = item.IdBanco;                 
                    dat.IdCbte_vta_nota = item.IdCbte_vta_nota;
                    dat.IdUsuario = item.IdUsuario;
                    dat.nom_pc = item.nom_pc;
                    dat.ip = item.ip;

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