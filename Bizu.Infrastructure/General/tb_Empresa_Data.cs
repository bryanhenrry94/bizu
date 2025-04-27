using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bizu.Domain.General;
using Bizu.Infrastructure.General;

namespace Bizu.Infrastructure.General
{
    public class tb_Empresa_Data
    {
        string mensaje = "";

        public List<tb_Empresa_Info> Get_List_Empresa()
        {
            try
            {
                List<tb_Empresa_Info> lM = new List<tb_Empresa_Info>();
                EntitiesGeneral OEselecEmpresa = new EntitiesGeneral();
                var selectEmpresa = from C in OEselecEmpresa.tb_empresa
                                    select C;

                foreach (var item in selectEmpresa)
                {
                    tb_Empresa_Info Cbt = new tb_Empresa_Info();
                    Cbt.IdEmpresa = item.idempresa;
                    Cbt.em_nombre = item.em_nombre;
                    Cbt.em_gerente = item.em_gerente;
                    Cbt.em_ruc = item.em_ruc;
                    Cbt.em_telefonos = item.em_telefonos;
                    Cbt.em_fax = item.em_fax;
                    Cbt.em_notificacion = Convert.ToInt32(item.em_notificacion);
                    Cbt.em_direccion = item.em_direccion;
                    Cbt.em_tel_int = item.em_tel_int;
                    Cbt.em_logo = item.em_logo;
                    Cbt.em_fechaInicioContable = item.em_fechainiciocontable;
                    Cbt.em_rucContador = item.em_ruccontador;
                    Cbt.em_contador = item.em_contador;
                    Cbt.Estado = item.estado;
                    Cbt.codigo = item.codigo;
                    Cbt.em_logo_Image = Funciones.ArrayAImage(item.em_logo);
                    Cbt.em_fondo_Image = Funciones.ArrayAImage(item.em_fondo);
                    Cbt.RazonSocial = item.razonsocial;
                    Cbt.NombreComercial = item.nombrecomercial;
                    Cbt.ContribuyenteEspecial = item.contribuyenteespecial;
                    Cbt.ObligadoAllevarConta = item.obligadoallevarconta;
                    Cbt.cod_entidad_dinardap = item.cod_entidad_dinardap;
                    Cbt.em_Email = item.em_email;
                    Cbt.em_Email_Contacto = item.em_email_contacto;
                    Cbt.Sitio_Web = item.sitio_web;

                    lM.Add(Cbt);
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

        public List<tb_Empresa_Info> Get_List_Empresa(List<int> List_Empresa)
        {
            try
            {
                List<tb_Empresa_Info> lM = new List<tb_Empresa_Info>();
                EntitiesGeneral OEselecEmpresa = new EntitiesGeneral();
                var selectEmpresa = from C in OEselecEmpresa.tb_empresa
                                    where List_Empresa.Contains(C.idempresa)
                                    select C;

                foreach (var item in selectEmpresa)
                {
                    tb_Empresa_Info Cbt = new tb_Empresa_Info();
                    Cbt.IdEmpresa = item.idempresa;
                    Cbt.em_nombre = item.em_nombre;
                    Cbt.em_gerente = item.em_gerente;
                    Cbt.em_ruc = item.em_ruc;
                    Cbt.em_telefonos = item.em_telefonos;
                    Cbt.em_fax = item.em_fax;
                    Cbt.em_notificacion = Convert.ToInt32(item.em_notificacion);
                    Cbt.em_direccion = item.em_direccion;
                    Cbt.em_tel_int = item.em_tel_int;
                    Cbt.em_logo = item.em_logo;
                    Cbt.em_fechaInicioContable = item.em_fechainiciocontable;
                    Cbt.em_rucContador = item.em_ruccontador;
                    Cbt.em_contador = item.em_contador;
                    Cbt.Estado = item.estado;
                    Cbt.codigo = item.codigo;
                    Cbt.em_logo_Image = Funciones.ArrayAImage(item.em_logo);
                    Cbt.em_fondo_Image = Funciones.ArrayAImage(item.em_fondo);
                    Cbt.RazonSocial = item.razonsocial;
                    Cbt.NombreComercial = item.nombrecomercial;
                    Cbt.ContribuyenteEspecial = item.contribuyenteespecial;
                    Cbt.ObligadoAllevarConta = item.obligadoallevarconta;
                    Cbt.cod_entidad_dinardap = item.cod_entidad_dinardap;
                    Cbt.em_Email = item.em_email;
                    Cbt.em_Email_Contacto = item.em_email_contacto;
                    Cbt.Sitio_Web = item.sitio_web;

                    lM.Add(Cbt);
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

        public List<tb_Empresa_Info> Get_List_Empresa_x_Usuario(string IdUsuario)
        {

            try
            {

                List<tb_Empresa_Info> lM = new List<tb_Empresa_Info>();
                EntitiesGeneral OEselecEmpresa = new EntitiesGeneral();
                var selectEmpresa = from C in OEselecEmpresa.vwtb_empresa_x_usuario
                                    where C.idusuario == IdUsuario
                                    select C;

                foreach (var item in selectEmpresa)
                {
                    tb_Empresa_Info Cbt = new tb_Empresa_Info();
                    Cbt.IdEmpresa = item.idempresa;
                    Cbt.em_nombre = item.em_nombre;
                    Cbt.em_nombre2 = "[" + item.idempresa + "]-" + item.em_nombre;
                    Cbt.em_gerente = item.em_gerente;
                    Cbt.em_ruc = item.em_ruc;
                    Cbt.em_telefonos = item.em_telefonos;
                    Cbt.em_notificacion = Convert.ToInt32(item.em_notificacion);
                    Cbt.em_direccion = item.em_direccion;
                    Cbt.em_tel_int = item.em_tel_int;
                    Cbt.em_logo = item.em_logo;
                    Cbt.em_fechaInicioContable = item.em_fechainiciocontable;
                    Cbt.em_rucContador = item.em_ruccontador;
                    Cbt.em_contador = item.em_contador;
                    Cbt.Estado = item.estado;
                    Cbt.codigo = item.codigo;
                    Cbt.em_logo_Image = Funciones.ArrayAImage(item.em_logo);
                    Cbt.em_fondo_Image = Funciones.ArrayAImage(item.em_fondo);
                    Cbt.RazonSocial = item.razonsocial;
                    Cbt.NombreComercial = item.nombrecomercial;
                    Cbt.ContribuyenteEspecial = item.contribuyenteespecial;
                    Cbt.ObligadoAllevarConta = item.obligadoallevarconta;
                    Cbt.cod_entidad_dinardap = item.cod_entidad_dinardap;
                    Cbt.em_Email_Contacto = item.em_email_contacto;
                    Cbt.Sitio_Web = item.sitio_web;
                    Cbt.em_fax = item.em_fax;
                    Cbt.em_Email = item.em_email;

                    lM.Add(Cbt);
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

        public Boolean Existe_Usuario_x_Empresa(int IdEmpresa, string IdUsuario)
        {
            try
            {
                EntitiesGeneral OEselecEmpresa = new EntitiesGeneral();

                var selectEmpresa = from C in OEselecEmpresa.vwtb_empresa_x_usuario
                                    where C.idempresa == IdEmpresa
                                    && C.idusuario == IdUsuario
                                    select C;

                if (selectEmpresa.Count() > 0)
                    return true;
                else
                    return false;
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

        public tb_Empresa_Info Get_Info_Empresa(int IdEmpresa)
        {
            try
            {
                EntitiesGeneral OEselecEmpresa = new EntitiesGeneral();
                var selectEmpresa = from C in OEselecEmpresa.tb_empresa
                                    where C.idempresa == IdEmpresa
                                    select C;

                tb_Empresa_Info Cbt = new tb_Empresa_Info();

                foreach (var item in selectEmpresa)
                {

                    Cbt.IdEmpresa = item.idempresa;
                    Cbt.em_nombre = item.em_nombre;
                    Cbt.em_gerente = item.em_gerente;
                    Cbt.em_ruc = item.em_ruc;
                    Cbt.em_telefonos = item.em_telefonos;
                    Cbt.em_fax = item.em_fax;
                    Cbt.em_notificacion = Convert.ToInt32(item.em_notificacion);
                    Cbt.em_direccion = item.em_direccion;
                    Cbt.em_contador = item.em_contador;
                    Cbt.em_tel_int = item.em_tel_int;
                    Cbt.em_logo = item.em_logo;
                    Cbt.em_fechaInicioContable = item.em_fechainiciocontable;
                    Cbt.Estado = item.estado;
                    Cbt.codigo = item.codigo;
                    Cbt.em_logo_Image = Funciones.ArrayAImage(item.em_logo);
                    Cbt.em_fondo_Image = Funciones.ArrayAImage(item.em_fondo);
                    Cbt.RazonSocial = item.razonsocial;
                    Cbt.NombreComercial = item.nombrecomercial;
                    Cbt.ContribuyenteEspecial = item.contribuyenteespecial;
                    Cbt.ObligadoAllevarConta = item.obligadoallevarconta;
                    Cbt.cod_entidad_dinardap = item.cod_entidad_dinardap;
                    Cbt.em_Email = item.em_email;
                    Cbt.em_Email_Contacto = item.em_email_contacto;
                    Cbt.Sitio_Web = item.sitio_web;

                }

                return (Cbt);
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

        public byte[] Get_Fondo_Pantalla_x_Empresa(int IdEmpresa)
        {
            try
            {
                byte[] em_fondo = null;

                EntitiesGeneral OEselecEmpresa = new EntitiesGeneral();
                var selectEmpresa = from C in OEselecEmpresa.tb_empresa
                                    where C.idempresa == IdEmpresa
                                    select C;

                tb_Empresa_Info Cbt = new tb_Empresa_Info();

                foreach (var item in selectEmpresa)
                {

                    em_fondo = item.em_fondo;

                }

                return (em_fondo);
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

        public Boolean ModificarDB(tb_Empresa_Info info)
        {
            try
            {
                using (EntitiesGeneral context = new EntitiesGeneral())
                {
                    var contact = context.tb_empresa.FirstOrDefault(minfo => minfo.idempresa == info.IdEmpresa);
                    if (contact != null)
                    {
                        contact.idempresa = info.IdEmpresa;
                        contact.em_nombre = info.em_nombre;
                        contact.em_ruc = info.em_ruc;
                        contact.em_gerente = info.em_gerente;
                        contact.em_contador = info.em_contador;
                        contact.em_ruccontador = info.em_rucContador;
                        contact.em_telefonos = info.em_telefonos;
                        contact.em_fax = info.em_fax;
                        contact.em_notificacion = info.em_notificacion;
                        contact.em_direccion = info.em_direccion;
                        contact.em_tel_int = info.em_tel_int;
                        contact.em_logo = info.em_logo;
                        contact.em_fondo = info.em_fondo;
                        contact.em_fechainiciocontable = info.em_fechaInicioContable;
                        contact.estado = info.Estado;
                        contact.codigo = info.codigo;
                        contact.razonsocial = info.RazonSocial;
                        contact.nombrecomercial = info.NombreComercial;
                        contact.contribuyenteespecial = info.ContribuyenteEspecial;
                        contact.obligadoallevarconta = info.ObligadoAllevarConta;
                        contact.cod_entidad_dinardap = info.cod_entidad_dinardap;
                        contact.em_email = info.em_Email;
                        contact.em_email_contacto = info.em_Email_Contacto;
                        contact.sitio_web = info.Sitio_Web;

                        context.SaveChanges();
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
                throw new Exception(ex.ToString());
            }
        }

        public Boolean GrabarDB(tb_Empresa_Info info)
        {
            try
            {
                int idEmpresa = 0;
                using (EntitiesGeneral context = new EntitiesGeneral())
                {
                    EntitiesGeneral EDB = new EntitiesGeneral();
                    var Q = from per in EDB.tb_empresa
                            where per.idempresa == info.IdEmpresa
                            select per;
                    if (Q.ToList().Count == 0)
                    {
                        idEmpresa = getIdEmpresa();

                        var address = new tb_empresa();

                        if (info.codigo == "")
                        {
                            info.codigo = idEmpresa.ToString();
                        }
                        address.idempresa = idEmpresa;
                        address.em_nombre = info.em_nombre;
                        address.em_ruc = info.em_ruc;
                        address.em_gerente = info.em_gerente;
                        address.em_contador = info.em_contador;
                        address.em_ruccontador = info.em_rucContador;
                        address.em_telefonos = info.em_telefonos;
                        address.em_fax = info.em_fax;
                        address.em_notificacion = info.em_notificacion;
                        address.em_direccion = info.em_direccion;
                        address.em_tel_int = info.em_tel_int;
                        address.em_logo = info.em_logo;
                        address.em_fondo = info.em_fondo;
                        address.em_fechainiciocontable = info.em_fechaInicioContable;
                        address.estado = info.Estado;
                        address.codigo = info.codigo;
                        address.razonsocial = info.RazonSocial;
                        address.nombrecomercial = info.NombreComercial;
                        address.contribuyenteespecial = info.ContribuyenteEspecial;
                        address.obligadoallevarconta = info.ObligadoAllevarConta;
                        address.cod_entidad_dinardap = info.cod_entidad_dinardap;
                        address.em_email = info.em_Email;
                        address.em_email_contacto = info.em_Email_Contacto;
                        address.sitio_web = info.Sitio_Web;
                        context.tb_empresa.Add(address);
                        context.SaveChanges();

                        tb_Sucursal_Data oDataSucursal = new tb_Sucursal_Data();
                        tb_Sucursal_Info infoSucursal = new tb_Sucursal_Info();

                        int id = 0;
                        string msg = "";

                        infoSucursal.IdEmpresa = idEmpresa;
                        infoSucursal.Su_Descripcion = "MATRIZ";
                        infoSucursal.Fecha_Transac = DateTime.Now;

                        oDataSucursal.GrabarDB(infoSucursal, ref id, ref msg);
                    }
                    else
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

        public int getIdEmpresa()
        {

            try
            {
                int IdEmpresa;

                //   List<tb_Empresa_Info> lM = new List<ct_CbteCble_Obj_info>();
                EntitiesGeneral OECbtecble = new EntitiesGeneral();

                var selectCbtecble = (from CbtCble in OECbtecble.tb_empresa
                                      select CbtCble.idempresa).Max();
                IdEmpresa = Convert.ToInt32(selectCbtecble.ToString()) + 1;
                return IdEmpresa;
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

        public Boolean EliminarDB(tb_Empresa_Info info)
        {
            try
            {
                using (EntitiesGeneral context = new EntitiesGeneral())
                {
                    var contact = context.tb_empresa.FirstOrDefault(dinfo => dinfo.idempresa == info.IdEmpresa);
                    if (contact != null)
                    {
                        context.tb_empresa.Remove(contact);
                        context.SaveChanges();
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
                throw new Exception(ex.ToString());
            }
        }

        public tb_Empresa_Info Get_Info(int IdEmpresa)
        {
            try
            {
                EntitiesGeneral OEselecEmpresa = new EntitiesGeneral();
                var selectEmpresa = from C in OEselecEmpresa.tb_empresa
                                    where C.idempresa == IdEmpresa
                                    select C;

                tb_Empresa_Info Cbt = new tb_Empresa_Info();

                foreach (var item in selectEmpresa)
                {
                    Cbt.em_nombre = item.em_nombre;
                    Cbt.em_logo = item.em_logo;
                    Cbt.RazonSocial = item.razonsocial;
                    Cbt.NombreComercial = item.nombrecomercial;

                }

                return (Cbt);
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

        public Boolean Establecer_Cuenta_Correo(int IdEmpresa, string em_Email)
        {
            try
            {
                EntitiesGeneral context = new EntitiesGeneral();

                var Address = (from q in context.tb_empresa
                               where q.idempresa == IdEmpresa
                               select q).First();

                if (Address != null)
                {
                    Address.em_email = em_Email;

                    context.SaveChanges();
                }

                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public tb_Empresa_Data() { }
    }
}