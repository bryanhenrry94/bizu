using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bizu.Domain.General;
using Bizu.Infrastructure.General;

namespace Bizu.Infrastructure.General
{
    public class tb_Sucursal_Data
    {
        string mensaje = "";

        public List<tb_Sucursal_Info> Get_List_Sucursal(int IdEmpresa)
        {
            try
            {
                List<tb_Sucursal_Info> lM = new List<tb_Sucursal_Info>();
                EntitiesGeneral OESucursal = new EntitiesGeneral();

                var select_sucursal = from A in OESucursal.tb_sucursal
                                      where A.idempresa == IdEmpresa
                                      && A.estado == "A"
                                      select A;

                foreach (var item in select_sucursal)
                {
                    tb_Sucursal_Info info = new tb_Sucursal_Info();
                    info.IdEmpresa = item.idempresa;
                    info.IdSucursal = item.idsucursal;
                    info.Su_CodigoEstablecimiento = item.su_codigoestablecimiento;
                    info.Su_Ubicacion = item.su_ubicacion;
                    info.Su_Ruc = item.su_ruc;
                    info.Su_JefeSucursal = item.su_jefesucursal;
                    info.Su_Telefonos = item.su_telefonos;
                    info.Su_Direccion = item.su_direccion;
                    info.Es_establecimiento = item.es_establecimiento;
                    info.Su_Descripcion = item.su_descripcion.Trim();
                    info.Su_Descripcion2 = "[" + item.idsucursal + "]" + item.su_descripcion.Trim();
                    info.Estado = (item.estado == "A") ? true : false;
                    info.SEstado = (item.estado == "A") ? "ACTIVO" : "*ANULADO*";
                    info.codigo = item.codigo;

                    lM.Add(info);

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
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public tb_Sucursal_Info Get_Info_Sucursal(int IdEmpresa, int IdSucursal)
        {
            try
            {
                tb_Sucursal_Info info = new tb_Sucursal_Info();
                EntitiesGeneral OESucursal = new EntitiesGeneral();

                var select_sucursal = from A in OESucursal.tb_sucursal
                                      where A.idempresa == IdEmpresa
                                      && A.idsucursal == IdSucursal
                                      select A;

                foreach (var item in select_sucursal)
                {
                    info.IdEmpresa = item.idempresa;
                    info.IdSucursal = item.idsucursal;
                    info.Su_CodigoEstablecimiento = item.su_codigoestablecimiento;
                    info.Su_Ubicacion = item.su_ubicacion;
                    info.Su_Ruc = item.su_ruc;
                    info.Su_JefeSucursal = item.su_jefesucursal;
                    info.Su_Telefonos = item.su_telefonos;
                    info.Su_Direccion = item.su_direccion;
                    info.Es_establecimiento = item.es_establecimiento;
                    info.Su_Descripcion = item.su_descripcion.Trim();
                    info.Su_Descripcion2 = "[" + item.idsucursal + "]" + item.su_descripcion.Trim();
                    info.Estado = (item.estado == "A") ? true : false;
                    info.SEstado = (item.estado == "A") ? "ACTIVO" : "*ANULADO*";
                    info.codigo = item.codigo;

                }
                return info;
            }

            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public string Get_Cod_Establecimiento_x_Sucursal(int IdEmpresa, int IdSucursal)
        {
            try
            {
                string Cod_estable = "";

                EntitiesGeneral OESucursal = new EntitiesGeneral();

                var select_sucursal = from A in OESucursal.tb_sucursal
                                      where A.idempresa == IdEmpresa
                                      && A.idsucursal == IdSucursal
                                      select A;

                foreach (var item in select_sucursal)
                {


                    Cod_estable = item.su_codigoestablecimiento;


                }
                return Cod_estable;
            }

            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public Boolean ModificarDB(tb_Sucursal_Info info, ref string msg)
        {
            try
            {
                using (EntitiesGeneral context = new EntitiesGeneral())
                {
                    var contact = context.tb_sucursal.FirstOrDefault(obj => obj.idempresa == info.IdEmpresa && obj.idsucursal == info.IdSucursal);
                    if (contact != null)
                    {
                        contact.su_descripcion = info.Su_Descripcion;
                        contact.su_codigoestablecimiento = info.Su_CodigoEstablecimiento;
                        contact.su_ubicacion = info.Su_Ubicacion;
                        contact.su_ruc = info.Su_Ruc;
                        contact.su_jefesucursal = info.Su_JefeSucursal;
                        contact.su_telefonos = info.Su_Telefonos;
                        contact.su_direccion = info.Su_Direccion;
                        contact.codigo = info.codigo;
                        contact.idusuarioultmod = info.IdUsuarioUltMod;
                        contact.fecha_ultmod = info.Fecha_UltMod;
                        contact.nom_pc = info.nom_pc;
                        contact.es_establecimiento = info.Es_establecimiento;
                        contact.ip = info.ip;
                        contact.estado = (info.Estado == true) ? "A" : "I";
                        context.SaveChanges();
                        msg = "Se ha procedido actualizar el registro de la sucursal #: " + info.IdSucursal.ToString() + " exitosamente";
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
                mensaje = ex.ToString() + " " + ex.Message;
                msg = "Se ha producido el siguiente error: " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public int GetId(int IdEmpresa)
        {
            try
            {
                int Id;
                EntitiesGeneral OECSucursal = new EntitiesGeneral();
                var select = from q in OECSucursal.tb_sucursal
                             where q.idempresa == IdEmpresa
                             select q;


                if (select.Count() == 0)
                {
                    Id = 1;
                }
                else
                {
                    var select_Sucursal = (from q in OECSucursal.tb_sucursal
                                           where q.idempresa == IdEmpresa
                                           select q.idsucursal).Max();
                    Id = Convert.ToInt32(select_Sucursal.ToString()) + 1;
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
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }

        }

        public Boolean GrabarDB(tb_Sucursal_Info info, ref int id, ref string msg)
        {
            try
            {
                using (EntitiesGeneral context = new EntitiesGeneral())
                {
                    var address = new tb_sucursal();
                    int idsucur = GetId(info.IdEmpresa);
                    id = idsucur;
                    address.idempresa = info.IdEmpresa;
                    address.idsucursal = idsucur;
                    address.su_descripcion = info.Su_Descripcion;
                    address.idusuario = info.IdUsuario;
                    address.fecha_transac = info.Fecha_Transac;
                    address.su_codigoestablecimiento = info.Su_CodigoEstablecimiento;
                    address.es_establecimiento = info.Es_establecimiento;
                    address.su_ubicacion = info.Su_Ubicacion;
                    address.su_ruc = info.Su_Ruc;
                    address.su_jefesucursal = info.Su_JefeSucursal;
                    address.su_telefonos = info.Su_Telefonos;
                    address.su_direccion = info.Su_Direccion;
                    address.codigo = (info.codigo == "" || info.codigo == null) ? "S_" + idsucur : info.codigo;
                    address.estado = "A";

                    context.tb_sucursal.Add(address);
                    context.SaveChanges();
                    msg = "Se ha procedido a grabar el registro de la sucursal #: " + id.ToString() + " exitosamente.";
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
                mensaje = ex.ToString() + " " + ex.Message;
                msg = "Se ha producido el siguiente error: " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public Boolean EliminarDB(tb_Sucursal_Info info, ref string msg)
        {
            try
            {
                using (EntitiesGeneral context = new EntitiesGeneral())
                {
                    var contact = context.tb_sucursal.FirstOrDefault(obj => obj.idempresa == info.IdEmpresa && obj.idsucursal == info.IdSucursal);
                    if (contact != null)
                    {
                        contact.idusuarioultanu = info.IdUsuarioUltAnu;
                        contact.fecha_ultanu = DateTime.Now;
                        contact.nom_pc = info.nom_pc;
                        contact.ip = info.ip;
                        contact.estado = "I";
                        context.SaveChanges();
                        msg = "Se ha procedido anular el registro de la sucursal #: " + info.IdSucursal.ToString() + " exitosamente";
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
                mensaje = ex.ToString() + " " + ex.Message;
                msg = "Se ha producido el siguiente error: " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public Boolean ValidarCodigoExiste(int IdEmresa, string Ruc, string Cod)
        {
            try
            {
                EntitiesGeneral Ent = new EntitiesGeneral();

                var Existe = from q in Ent.tb_sucursal
                             where q.idempresa == IdEmresa
                             && q.su_ruc == Ruc
                             && q.su_codigoestablecimiento == Cod
                             select q;

                if (Existe.Count() > 0)
                {
                    return false;
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
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public int Get_numEstablecimiento_x_empresa_SRI(int IdEmpresa)
        {
            try
            {
                int x = 0;

                using (EntitiesGeneral Context = new EntitiesGeneral())
                {
                    var lst = from q in Context.tb_sucursal
                              where q.idempresa == IdEmpresa
                              && q.es_establecimiento == true
                              select q;

                    if (lst.Count() == 0)
                        x = 1;
                    else
                        x = lst.Count();
                }

                return x;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public tb_Sucursal_Data() { }
    }
}