using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bizu.Domain.General;
using Bizu.Infrastructure.General;

namespace Bizu.Infrastructure.General
{
    public class tb_CatalogoTipo_Data
    {
        string mensaje = "";
        public List<tb_CatalogoTipo_Info> Get_List_CatalogoTipo()
        {

            try
            {

                List<tb_CatalogoTipo_Info> lista = new List<tb_CatalogoTipo_Info>();
                EntitiesGeneral OCatalogo = new EntitiesGeneral();
                var Doc = from C in OCatalogo.tb_catalogotipo
                          select C;


                foreach (var item in Doc)
                {
                    tb_CatalogoTipo_Info info = new tb_CatalogoTipo_Info();
                    info.IdTipoCatalogo = item.idtipocatalogo;
                    info.Codigo = item.codigo;
                    info.tc_Descripcion = item.tc_descripcion;
                    lista.Add(info);
                }

                return lista;
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

        public Boolean GrabaDB(tb_CatalogoTipo_Info info, ref string msg, ref int IdCatalogoTipo)
        {
            try
            {
                using (EntitiesGeneral context = new EntitiesGeneral())
                {
                    var existe = (from q in context.tb_catalogotipo
                                  where q.codigo == info.Codigo
                                  select q).Count();

                    if (existe != 0)
                    {
                        msg = "El Codigo Ingresado ya existe Por Favor Ingresar uno distinto";
                        return false;
                    }

                    //var contact = tb_catalogotipo.Createtb_CatalogoTipo(0);
                    tb_catalogotipo address = new tb_catalogotipo();
                    int Tipo = IdCatalogoTipo = GetId();
                    address.idtipocatalogo = Tipo;
                    address.tc_descripcion = info.tc_Descripcion;
                    address.codigo = info.Codigo;
                    //contact = address;
                    context.tb_catalogotipo.Add(address);
                    context.SaveChanges();
                    msg = "Se ha procedido a grabar el registro del catalogo #: " + Tipo.ToString();
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
                msg = "Error no se grabó ";
                throw new Exception(ex.ToString());
            }
        }

        public Boolean ModificaDB(tb_CatalogoTipo_Info info, ref string msg)
        {
            try
            {
                using (EntitiesGeneral context = new EntitiesGeneral())
                {
                    var contact = context.tb_catalogotipo.FirstOrDefault(obj => obj.idtipocatalogo == info.IdTipoCatalogo);
                    if (contact != null)
                    {
                        contact.tc_descripcion = info.tc_Descripcion;
                        context.SaveChanges();
                        msg = "Se ha procedido a Actualizar el registro del tipo catalogo #: " + info.IdTipoCatalogo.ToString();
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
                msg = "Error no se grabó ";
                throw new Exception(ex.ToString());
            }
        }

        public int GetId()
        {
            try
            {
                int Id;
                EntitiesGeneral OECatalogo = new EntitiesGeneral();
                var select = from q in OECatalogo.tb_catalogotipo
                             select q;

                if (select == null)
                {
                    Id = 1;
                }
                else
                {
                    var select_em = (from q in OECatalogo.tb_catalogotipo
                                     select q.idtipocatalogo).Max();
                    Id = Convert.ToInt32(select_em.ToString()) + 1;
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

        public tb_CatalogoTipo_Data() { }
    }
}