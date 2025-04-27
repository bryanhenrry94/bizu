using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Bizu.Domain.General;

namespace Bizu.Infrastructure.General
{
    public class tb_sis_impuesto_Data
    {

        string mensaje = "";

        public List<tb_sis_impuesto_Info> Get_List_impuesto()
        {
            try
            {
                List<tb_sis_impuesto_Info> lst = new List<tb_sis_impuesto_Info>();

                EntitiesGeneral oEnti = new EntitiesGeneral();

                var bancos = from q in oEnti.tb_sis_impuesto
                             select q;
                foreach (var item in bancos)
                {
                    tb_sis_impuesto_Info info = new tb_sis_impuesto_Info();

                    info.IdCod_Impuesto = item.idcod_impuesto;
                    info.nom_impuesto = item.nom_impuesto;
                    info.Usado_en_Ventas = item.usado_en_ventas;
                    info.Usado_en_Compras = item.usado_en_compras;
                    info.porcentaje = item.porcentaje;
                    info.IdCodigo_SRI = item.idcodigo_sri;
                    info.estado = item.estado;
                    info.IdTipoImpuesto = item.idtipoimpuesto;


                    lst.Add(info);
                }
                return lst;
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


        public tb_sis_impuesto_Info Get_Info_impuesto(string IdCod_Impuesto)
        {
            try
            {
                tb_sis_impuesto_Info info = new tb_sis_impuesto_Info();

                EntitiesGeneral oEnti = new EntitiesGeneral();

                var bancos = from q in oEnti.tb_sis_impuesto
                             where q.idcod_impuesto == IdCod_Impuesto
                             select q;
                foreach (var item in bancos)
                {

                    info.IdCod_Impuesto = item.idcod_impuesto;
                    info.nom_impuesto = item.nom_impuesto;
                    info.Usado_en_Ventas = item.usado_en_ventas;
                    info.Usado_en_Compras = item.usado_en_compras;
                    info.porcentaje = item.porcentaje;
                    info.IdCodigo_SRI = item.idcodigo_sri;
                    info.estado = item.estado;
                    info.IdTipoImpuesto = item.idtipoimpuesto;
                }
                return info;
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

        public List<tb_sis_impuesto_Info> Get_List_impuesto(string IdTipoImpuesto)
        {
            try
            {
                List<tb_sis_impuesto_Info> lst = new List<tb_sis_impuesto_Info>();

                EntitiesGeneral oEnti = new EntitiesGeneral();

                var bancos = from q in oEnti.tb_sis_impuesto
                             where q.idtipoimpuesto == IdTipoImpuesto
                             select q;
                foreach (var item in bancos)
                {
                    tb_sis_impuesto_Info info = new tb_sis_impuesto_Info();

                    info.IdCod_Impuesto = item.idcod_impuesto;
                    info.nom_impuesto = item.nom_impuesto;
                    info.Usado_en_Ventas = item.usado_en_ventas;
                    info.Usado_en_Compras = item.usado_en_compras;
                    info.porcentaje = item.porcentaje;
                    info.IdCodigo_SRI = item.idcodigo_sri;
                    info.estado = item.estado;
                    info.IdTipoImpuesto = item.idtipoimpuesto;

                    lst.Add(info);
                }
                return lst;
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


        public List<tb_sis_impuesto_Info> Get_List_impuesto_x_CtaCble(int IdEmpresa, string IdTipoImpuesto)
        {
            try
            {
                List<tb_sis_impuesto_Info> lst = new List<tb_sis_impuesto_Info>();

                EntitiesGeneral oEnti = new EntitiesGeneral();

                var bancos = from q in oEnti.tb_sis_impuesto
                             join cta in oEnti.tb_sis_impuesto_x_ctacble on q.idcod_impuesto equals cta.idcod_impuesto
                             where q.idtipoimpuesto == IdTipoImpuesto
                             && cta.idempresa_cta == IdEmpresa
                             select new
                             {
                                 cta.idempresa_cta,
                                 q.idcod_impuesto,
                                 q.nom_impuesto,
                                 q.usado_en_ventas,
                                 q.usado_en_compras,
                                 q.porcentaje,
                                 q.idcodigo_sri,
                                 q.estado,
                                 q.idtipoimpuesto,
                                 cta.idctacble
                             };

                foreach (var item in bancos)
                {
                    tb_sis_impuesto_Info info = new tb_sis_impuesto_Info();

                    info.IdCod_Impuesto = item.idcod_impuesto;
                    info.nom_impuesto = item.nom_impuesto;
                    info.Usado_en_Ventas = item.usado_en_ventas;
                    info.Usado_en_Compras = item.usado_en_compras;
                    info.porcentaje = item.porcentaje;
                    info.IdCodigo_SRI = item.idcodigo_sri;
                    info.estado = item.estado;
                    info.IdTipoImpuesto = item.idtipoimpuesto;
                    info.Info_sis_Impuesto_x_ctacble.IdCod_Impuesto = item.idcod_impuesto;
                    info.Info_sis_Impuesto_x_ctacble.IdCtaCble = item.idctacble;
                    info.Info_sis_Impuesto_x_ctacble.IdEmpresa_cta = item.idempresa_cta;

                    lst.Add(info);
                }
                return lst;
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

        public List<tb_sis_impuesto_Info> Get_List_impuesto_para_Compras(string IdTipoImpuesto)
        {
            try
            {
                List<tb_sis_impuesto_Info> lst = new List<tb_sis_impuesto_Info>();

                EntitiesGeneral oEnti = new EntitiesGeneral();

                var bancos = from q in oEnti.tb_sis_impuesto
                             where q.usado_en_compras == true
                             && q.idtipoimpuesto == IdTipoImpuesto
                             select q;

                foreach (var item in bancos)
                {
                    tb_sis_impuesto_Info info = new tb_sis_impuesto_Info();

                    info.IdCod_Impuesto = item.idcod_impuesto;
                    info.nom_impuesto = item.nom_impuesto;
                    info.Usado_en_Ventas = item.usado_en_ventas;
                    info.Usado_en_Compras = item.usado_en_compras;
                    info.porcentaje = item.porcentaje;
                    info.IdCodigo_SRI = item.idcodigo_sri;
                    info.estado = item.estado;
                    info.IdTipoImpuesto = item.idtipoimpuesto;


                    lst.Add(info);
                }
                return lst;
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

        public List<tb_sis_impuesto_Info> Get_List_impuesto_para_Ventas(string IdTipoImpuesto)
        {
            try
            {
                List<tb_sis_impuesto_Info> lst = new List<tb_sis_impuesto_Info>();

                EntitiesGeneral oEnti = new EntitiesGeneral();

                var bancos = from q in oEnti.tb_sis_impuesto
                             where q.usado_en_ventas == true
                              && q.idtipoimpuesto == IdTipoImpuesto
                             select q;
                foreach (var item in bancos)
                {
                    tb_sis_impuesto_Info info = new tb_sis_impuesto_Info();

                    info.IdCod_Impuesto = item.idcod_impuesto;
                    info.nom_impuesto = item.nom_impuesto;
                    info.Usado_en_Ventas = item.usado_en_ventas;
                    info.Usado_en_Compras = item.usado_en_compras;
                    info.porcentaje = item.porcentaje;
                    info.IdCodigo_SRI = item.idcodigo_sri;
                    info.estado = item.estado;
                    info.IdTipoImpuesto = item.idtipoimpuesto;

                    lst.Add(info);
                }
                return lst;
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

        public Boolean GrabarDB(tb_sis_impuesto_Info Info, ref string msg)
        {
            try
            {
                Boolean resultado = false;
                using (EntitiesGeneral context = new EntitiesGeneral())
                {
                    var address = new tb_sis_impuesto();

                    address.idcod_impuesto = Info.IdCod_Impuesto;
                    address.nom_impuesto = Info.nom_impuesto;
                    address.usado_en_ventas = Info.Usado_en_Ventas;
                    address.usado_en_compras = Info.Usado_en_Compras;
                    address.porcentaje = Info.porcentaje;
                    address.idcodigo_sri = Info.IdCodigo_SRI;
                    address.estado = true;
                    address.idtipoimpuesto = Info.IdTipoImpuesto;

                    context.tb_sis_impuesto.Add(address);
                    context.SaveChanges();
                    msg = "Se ha procedido grabar el Banco #: " + address.idcod_impuesto.ToString() + " exitosamente.";
                    resultado = true;
                }
                return resultado;
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

        public Boolean ActualizarDB(tb_sis_impuesto_Info Info, ref string msg)
        {
            try
            {
                bool resultado = false;
                using (EntitiesGeneral context = new EntitiesGeneral())
                {
                    var address = context.tb_sis_impuesto.FirstOrDefault(v => v.idcod_impuesto == Info.IdCod_Impuesto);
                    if (address != null)
                    {
                        address.nom_impuesto = Info.nom_impuesto;
                        address.usado_en_ventas = Info.Usado_en_Ventas;
                        address.usado_en_compras = Info.Usado_en_Compras;
                        address.porcentaje = Info.porcentaje;
                        address.idcodigo_sri = Info.IdCodigo_SRI;
                        address.estado = Info.estado;
                        address.idtipoimpuesto = Info.IdTipoImpuesto;

                        context.SaveChanges();
                        msg = "Se ha modificado el Banco #: " + address.idcod_impuesto.ToString() + " exitosamente.";
                        resultado = true;
                    }
                }
                return resultado;
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

        public Boolean AnulaDB(tb_sis_impuesto_Info Info, ref string msg)
        {
            try
            {
                Boolean resultado = false;
                using (EntitiesGeneral context = new EntitiesGeneral())
                {
                    var address = context.tb_sis_impuesto.FirstOrDefault(q => q.idcod_impuesto == Info.IdCod_Impuesto);
                    if (address != null)
                    {
                        address.estado = false;
                        context.SaveChanges();
                        msg = "Se ha procedido anular  #: " + Info.IdCod_Impuesto.ToString() + " exitosamente.";
                        resultado = true;
                    }
                }
                return resultado;
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
    }
}