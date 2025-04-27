using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bizu.Domain.General;
using Bizu.Infrastructure.General;

namespace Bizu.Infrastructure.General
{
    public class tb_modulo_Data
    {
        string mensaje = "";

        public Boolean GuardarDB(tb_modulo_Info Info)
        {
            try
            {
                List<tb_modulo_Info> Lst = new List<tb_modulo_Info>();
                using (EntitiesGeneral Context = new EntitiesGeneral())
                {
                    var Address = new tb_modulo();

                    Address.codmodulo = Info.CodModulo;
                    Address.descripcion = Info.Descripcion;
                    Address.nom_carpeta = Info.Nom_Carpeta;
                    Address.se_cierra = Info.Se_Cierra;
                    Context.tb_modulo.Add(Address);
                    Context.SaveChanges();
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

        public List<tb_modulo_Info> Get_list_Modulo()
        {
            try
            {
                List<tb_modulo_Info> Lst = new List<tb_modulo_Info>();
                EntitiesGeneral oEnti = new EntitiesGeneral();
                var Query = from q in oEnti.tb_modulo
                            select q;
                foreach (var item in Query)
                {
                    tb_modulo_Info Obj = new tb_modulo_Info();
                    Obj.CodModulo = item.codmodulo;
                    Obj.Descripcion = item.descripcion;
                    Obj.Nom_Carpeta = item.nom_carpeta;
                    Obj.Se_Cierra = item.se_cierra;
                    Lst.Add(Obj);
                }
                return Lst;
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

        public List<tb_modulo_Info> Get_list_Modulo(Boolean Se_Cierra)
        {
            try
            {
                List<tb_modulo_Info> Lst = new List<tb_modulo_Info>();
                EntitiesGeneral oEnti = new EntitiesGeneral();
                var Query = from q in oEnti.tb_modulo
                            where q.se_cierra == Se_Cierra
                            select q;
                foreach (var item in Query)
                {
                    tb_modulo_Info Obj = new tb_modulo_Info();
                    Obj.CodModulo = item.codmodulo;
                    Obj.Descripcion = item.descripcion;
                    Obj.Nom_Carpeta = item.nom_carpeta;
                    Obj.Se_Cierra = item.se_cierra;
                    Lst.Add(Obj);
                }
                return Lst;
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

        public List<tb_modulo_Info> Get_list_Modulo(string codModulo)
        {
            try
            {
                List<tb_modulo_Info> Lst = new List<tb_modulo_Info>();
                EntitiesGeneral oEnti = new EntitiesGeneral();
                var Query = from q in oEnti.tb_modulo
                            where q.codmodulo.Contains(codModulo)
                            select q;
                foreach (var item in Query)
                {
                    tb_modulo_Info Obj = new tb_modulo_Info();
                    Obj.CodModulo = item.codmodulo;
                    Obj.Descripcion = item.descripcion;
                    Obj.Se_Cierra = item.se_cierra;
                    Lst.Add(Obj);
                }
                return Lst;
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

        public tb_modulo_Info Get_Info_Modulo(string CodModulo)
        {
            EntitiesGeneral oEnti = new EntitiesGeneral();
            try
            {
                tb_modulo_Info Info = new tb_modulo_Info();
                var Objeto = oEnti.tb_modulo.FirstOrDefault(var => var.codmodulo == CodModulo);
                if (Objeto != null)
                {
                    Info.CodModulo = Objeto.codmodulo;
                    Info.Descripcion = Objeto.descripcion;
                    Info.Se_Cierra = Objeto.se_cierra;
                }
                return Info;
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

        public Boolean ModificarDB(tb_modulo_Info info)
        {
            try
            {
                using (EntitiesGeneral context = new EntitiesGeneral())
                {
                    var contact = context.tb_modulo.FirstOrDefault(minfo => minfo.codmodulo == info.CodModulo);
                    if (contact != null)
                    {
                        contact.descripcion = info.Descripcion;
                        contact.nom_carpeta = info.Nom_Carpeta;
                        contact.se_cierra = info.Se_Cierra;
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

        public tb_modulo_Data() { }
    }
}