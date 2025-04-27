using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bizu.Domain.General;
using Bizu.Domain.CuentasxPagar;
using Bizu.Domain.Inventario;
using Bizu.Infrastructure.General;


namespace Bizu.Infrastructure.General
{
    public class tb_Catalogo_Data
    {
        string mensaje = "";
        public List<Cl_EstadoCivil_Info> Get_List_EstadoCivil()
        {
            try
            {
                List<Cl_EstadoCivil_Info> lEstC = new List<Cl_EstadoCivil_Info>();
                EntitiesGeneral OCatalogo = new EntitiesGeneral();
                var EstadoCivil = from C in OCatalogo.tb_catalogo
                                  where C.idtipocatalogo == 2
                                  orderby C.ca_orden
                                  select C;

                foreach (var item in EstadoCivil)
                {
                    Cl_EstadoCivil_Info Cbt = new Cl_EstadoCivil_Info();
                    Cbt.id = item.idcatalogo;
                    Cbt.codigo = item.codcatalogo;
                    Cbt.descripcion = item.ca_descripcion;
                    lEstC.Add(Cbt);
                }
                return lEstC;
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

        public List<Cl_TipoDoc_Personales_Info> Get_List_TipoDoc_Personales()
        {
            try
            {
                List<Cl_TipoDoc_Personales_Info> lEstC = new List<Cl_TipoDoc_Personales_Info>();
                EntitiesGeneral OCatalogo = new EntitiesGeneral();
                var Doc = from C in OCatalogo.tb_catalogo
                          where C.idtipocatalogo == 3
                          orderby C.ca_orden
                          select C;

                foreach (var item in Doc)
                {
                    Cl_TipoDoc_Personales_Info Cbt = new Cl_TipoDoc_Personales_Info();
                    Cbt.id = item.idcatalogo;
                    Cbt.codigo = item.codcatalogo;
                    Cbt.descripcion = item.ca_descripcion;
                    lEstC.Add(Cbt);
                }
                return lEstC;
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

        public List<Cl_Sexo_Info> Get_List_Sexo()
        {
            try
            {

                List<Cl_Sexo_Info> lEstC = new List<Cl_Sexo_Info>();
                EntitiesGeneral OCatalogo = new EntitiesGeneral();
                var Doc = from C in OCatalogo.tb_catalogo
                          where C.idtipocatalogo == 1
                          orderby C.ca_orden
                          select C;
                foreach (var item in Doc)
                {
                    Cl_Sexo_Info Cbt = new Cl_Sexo_Info();
                    Cbt.id = item.codcatalogo;
                    Cbt.codigo = item.codcatalogo;
                    Cbt.descripcion = item.ca_descripcion;
                    lEstC.Add(Cbt);
                }
                return lEstC;
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

        public List<Cl_NaturalezaPerso> Get_List_NaturalezaPer()
        {

            try
            {

                List<Cl_NaturalezaPerso> lEstC = new List<Cl_NaturalezaPerso>();
                EntitiesGeneral OCatalogo = new EntitiesGeneral();
                var Doc = from C in OCatalogo.tb_catalogo
                          where C.idtipocatalogo == 5
                          orderby C.ca_orden
                          select C;


                foreach (var item in Doc)
                {
                    Cl_NaturalezaPerso Cbt = new Cl_NaturalezaPerso();
                    Cbt.id = item.idcatalogo;
                    Cbt.codigo = item.codcatalogo;
                    Cbt.descripcion = item.ca_descripcion;



                    lEstC.Add(Cbt);
                }




                return lEstC;
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

        public List<Cl_Estado_Info> Get_List_Estado()
        {
            try
            {



                List<Cl_Estado_Info> lEstC = new List<Cl_Estado_Info>();
                EntitiesGeneral OCatalogo = new EntitiesGeneral();
                var Doc = from C in OCatalogo.tb_catalogo
                          where C.idtipocatalogo == 4
                          orderby C.ca_orden
                          select C;


                foreach (var item in Doc)
                {
                    Cl_Estado_Info Cbt = new Cl_Estado_Info();
                    Cbt.id = item.idcatalogo;
                    Cbt.codigo = item.codcatalogo;
                    Cbt.descripcion = item.ca_descripcion;



                    lEstC.Add(Cbt);
                }




                return lEstC;
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

        public List<tb_Catalogo_Info> Get_List_Catalogo(Cl_Enumeradores.TipoCatalogo Tipo)
        {

            try
            {

                string tipo2 = "";
                tipo2 = Tipo.ToString();

                List<tb_Catalogo_Info> lista = new List<tb_Catalogo_Info>();
                EntitiesGeneral OCatalogo = new EntitiesGeneral();
                var Doc = from C in OCatalogo.tb_catalogo
                          join TC in OCatalogo.tb_catalogotipo
                          on C.idtipocatalogo equals TC.idtipocatalogo
                          where TC.codigo.Equals(tipo2)
                          orderby C.ca_orden
                          select C;


                foreach (var item in Doc)
                {
                    tb_Catalogo_Info catalogo = new tb_Catalogo_Info();
                    catalogo.IdCatalogo = item.idcatalogo;
                    catalogo.IdTipoCatalogo = item.idtipocatalogo;
                    catalogo.CodCatalogo = item.codcatalogo;
                    catalogo.ca_descripcion = item.ca_descripcion;
                    catalogo.ca_estado = item.ca_estado;
                    catalogo.ca_orden = item.ca_orden;

                    lista.Add(catalogo);
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

        public List<tb_Catalogo_Info> Get_List_MotivoAnulacion()
        {
            try
            {
                List<tb_Catalogo_Info> lEstC = new List<tb_Catalogo_Info>();
                EntitiesGeneral OCatalogo = new EntitiesGeneral();
                var Doc = from C in OCatalogo.tb_catalogo
                          where C.idtipocatalogo == 24
                          orderby C.ca_orden
                          select C;

                foreach (var item in Doc)
                {
                    tb_Catalogo_Info Cbt = new tb_Catalogo_Info();
                    Cbt.IdCatalogo = item.idcatalogo;
                    Cbt.CodCatalogo = item.codcatalogo;
                    Cbt.ca_descripcion = item.ca_descripcion;

                    lEstC.Add(Cbt);
                }

                return lEstC;
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

        public List<tb_Catalogo_Info> Get_CatalogoPorTipo(int IdTipoCatalgo)
        {
            try
            {
                List<tb_Catalogo_Info> lEstC = new List<tb_Catalogo_Info>();
                EntitiesGeneral OCatalogo = new EntitiesGeneral();
                var Doc = from C in OCatalogo.tb_catalogo
                          where C.idtipocatalogo == IdTipoCatalgo
                          select C;

                foreach (var item in Doc)
                {
                    tb_Catalogo_Info Cbt = new tb_Catalogo_Info();

                    Cbt.IdCatalogo = item.idcatalogo;
                    Cbt.CodCatalogo = item.codcatalogo;
                    Cbt.ca_descripcion = item.ca_descripcion;
                    Cbt.ca_estado = item.ca_estado;
                    Cbt.ca_orden = item.ca_orden;
                    Cbt.IdTipoCatalogo = item.idtipocatalogo;

                    lEstC.Add(Cbt);
                }

                return lEstC;
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

        public Boolean AnularDB(tb_Catalogo_Info info, ref string msg)
        {
            try
            {
                using (EntitiesGeneral context = new EntitiesGeneral())
                {
                    var contact = context.tb_catalogo.FirstOrDefault(A => A.idcatalogo == info.IdCatalogo);
                    if (contact != null)
                    {
                        contact.ca_estado = "I";
                        context.SaveChanges();
                        msg = "Se Cambio el estado del catálogo :" + info.CodCatalogo.ToString() + " exitosamente";
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
                msg = "Error del Sistema :" + ex.Message + " ";
                throw new Exception(ex.ToString());
            }
        }

        public Boolean GrabarDB(tb_Catalogo_Info info, ref string msg, ref int id)
        {
            try
            {
                int idCat;
                int orden;

                using (EntitiesGeneral EDG = new EntitiesGeneral())
                {
                    var codigo = (from per in EDG.tb_catalogo
                                  where per.codcatalogo == info.CodCatalogo
                                  select per).Count();
                    if (codigo != 0)
                    {
                        msg = "El Codigo Ingresado Ya Existe Favor Ingrese uno diferente";
                        return false;
                    }

                    idCat = GetId();
                    info.IdCatalogo = idCat;
                    info.CodCatalogo = (info.CodCatalogo == null || info.CodCatalogo == "") ? Convert.ToString(idCat) : info.CodCatalogo;

                    var Q = from per in EDG.tb_catalogo
                            where per.idcatalogo == info.IdCatalogo
                            select per;

                    if (Q.ToList().Count == 0)
                    {

                        tb_catalogo address = new tb_catalogo();

                        address.idcatalogo = info.IdCatalogo;
                        address.codcatalogo = info.CodCatalogo;
                        address.idtipocatalogo = info.IdTipoCatalogo;

                        orden = GetOrdenSegunTipo(info.IdTipoCatalogo);
                        address.ca_orden = orden;

                        address.ca_estado = info.ca_estado;
                        address.ca_descripcion = info.ca_descripcion;

                        EDG.tb_catalogo.Add(address);
                        EDG.SaveChanges();

                        msg = "El Catálogo #" + address.codcatalogo + " se grabó Exitosamente";
                        return true;
                    }
                    else
                        return false;
                }
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString() + " " + ex.Message;
                msg = "Error al Grabar .." + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public int GetOrdenSegunTipo(int tipo)
        {
            try
            {

                int Id;
                EntitiesGeneral OEGeneral = new EntitiesGeneral();

                var q = from C in OEGeneral.tb_catalogo
                        where C.idtipocatalogo == tipo
                        select C;
                if (q.ToList().Count == 0)
                    return 1;
                else
                {
                    var select_ = (from t in OEGeneral.tb_catalogo
                                   where t.idtipocatalogo == tipo
                                   select t.idcatalogo).Max();
                    Id = Convert.ToInt32(select_.ToString()) + 1;
                    return Id;
                }
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

        public Boolean ModificarDB(tb_Catalogo_Info info, ref string msg)
        {
            try
            {
                using (EntitiesGeneral context = new EntitiesGeneral())
                {
                    var contact = context.tb_catalogo.FirstOrDefault(A => A.idtipocatalogo == info.IdTipoCatalogo && A.idcatalogo == info.IdCatalogo);
                    if (contact != null)
                    {
                        contact.idcatalogo = info.IdCatalogo;
                        contact.idtipocatalogo = info.IdTipoCatalogo;
                        //contact.CodCatalogo = info.CodCatalogo;
                        contact.ca_orden = info.ca_orden;
                        contact.ca_estado = info.ca_estado;
                        contact.ca_descripcion = info.ca_descripcion;
                        context.SaveChanges();
                        msg = "El Catálogo #" + contact.codcatalogo + " se actualizó Exitosamente";
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
                msg = "Error al Grabar" + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public int GetId()
        {
            try
            {
                int Id;
                EntitiesGeneral OECompras = new EntitiesGeneral();
                var select = from q in OECompras.tb_catalogo
                             select q;

                if (select.ToList().Count < 1)
                {
                    Id = 1;
                }
                else
                {
                    var select_pv = (from q in OECompras.tb_catalogo
                                     select q.idcatalogo).Max();
                    Id = Convert.ToInt32(select_pv.ToString()) + 1;
                    Id = (Id == 0) ? 1 : Id;
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
                mensaje = ex.ToString();
                throw new Exception(ex.ToString());
            }
        }


        public string Get_DescripcionDocumentoIdentidad(string codigo, ref string descripcion)
        {
            try
            {
                using (EntitiesGeneral context = new EntitiesGeneral())
                {
                    var contact = context.tb_catalogo.FirstOrDefault(A => A.codcatalogo == codigo);
                    if (contact != null)
                    {
                        descripcion = contact.ca_descripcion;

                    }
                }
                return descripcion;
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

    }
}