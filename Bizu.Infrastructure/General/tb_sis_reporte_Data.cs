using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

using Bizu.Domain.General;

namespace Bizu.Infrastructure.General
{

    public class tb_sis_reporte_Data
    {
        string mensaje = "";
        public Boolean GuardarDB(tb_sis_reporte_Info Info)
        {
            try
            {
                List<tb_sis_reporte_Info> Lst = new List<tb_sis_reporte_Info>();
                using (EntitiesGeneral Context = new EntitiesGeneral())
                {

                    var Address = new tb_sis_reporte();

                    Address.codreporte = Info.CodReporte;
                    Address.nombre = Info.Nombre;
                    Address.nombrecorto = Info.NombreCorto;
                    Address.modulo = Info.Modulo;
                    Address.vistarpt = Info.VistaRpt;
                    Address.formulario = Info.Formulario;
                    Address.orden = Info.Orden;
                    Address.estado = Info.Estado;
                    Address.se_muestra_admin_reporte = Info.se_Muestra_Admin_Reporte;
                    Address.observacion = Info.Observacion;
                    Address.imagen = Info.imgByt;
                    Address.nom_asembly = Info.nom_Asembly;
                    Address.versionactual = Info.VersionActual;
                    Address.tipo_balance = Info.Tipo_Balance;
                    Address.squery = Info.SQuery;
                    Address.class_nomreporte = Info.Class_NomReporte;
                    Address.class_info = Info.Class_Info;
                    Address.class_data = Info.Class_Data;
                    Address.class_bus = Info.Class_Bus;
                    Address.store_proce_rpt = Info.Store_proce_rpt;

                    Context.tb_sis_reporte.Add(Address);
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


        public List<tb_sis_reporte_Info> Get_List_reporte()
        {
            try
            {
                List<tb_sis_reporte_Info> Lst = new List<tb_sis_reporte_Info>();
                EntitiesGeneral oEnti = new EntitiesGeneral();
                var Query = from q in oEnti.tb_sis_reporte
                            select q;

                foreach (var item in Query)
                {
                    tb_sis_reporte_Info Obj = new tb_sis_reporte_Info();
                    Obj.CodReporte = item.codreporte;
                    Obj.Nombre = item.nombre;
                    Obj.NombreCorto = item.nombrecorto;
                    Obj.Modulo = item.modulo;
                    Obj.VistaRpt = item.vistarpt;
                    Obj.Formulario = item.formulario;
                    Obj.Orden = item.orden;
                    Obj.Class_NomReporte = item.class_nomreporte;
                    Obj.Observacion = item.observacion;
                    Obj.imgByt = item.imagen;
                    Obj.imagen = Funciones.ArrayAImage(item.imagen);
                    Obj.nom_Asembly = item.nom_asembly;
                    Obj.VersionActual = Convert.ToInt32(item.versionactual);
                    Obj.Estado = item.estado;
                    Obj.se_Muestra_Admin_Reporte = Convert.ToBoolean(item.se_muestra_admin_reporte);
                    Obj.Tipo_Balance = item.tipo_balance;
                    Obj.SQuery = item.squery;
                    Obj.Class_Info = item.class_info;
                    Obj.Class_Bus = item.class_bus;
                    Obj.Class_Data = item.class_data;
                    Obj.Store_proce_rpt = item.store_proce_rpt;
                    Obj.Disenio_reporte = item.disenio_reporte;
                    Obj.Se_Muestra_Icono = true;

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

        public List<tb_sis_reporte_Info> Get_List_reporte(Boolean _se_Muestra_Admin_Reporte)
        {
            try
            {
                List<tb_sis_reporte_Info> Lst = new List<tb_sis_reporte_Info>();
                EntitiesGeneral oEnti = new EntitiesGeneral();
                var Query = from q in oEnti.tb_sis_reporte
                            where q.se_muestra_admin_reporte == _se_Muestra_Admin_Reporte
                            select q;

                foreach (var item in Query)
                {
                    tb_sis_reporte_Info Obj = new tb_sis_reporte_Info();
                    Obj.CodReporte = item.codreporte;
                    Obj.Nombre = item.nombre;
                    Obj.NombreCorto = item.nombrecorto;
                    Obj.Modulo = item.modulo;
                    Obj.VistaRpt = item.vistarpt;
                    Obj.Formulario = item.formulario;
                    Obj.Orden = item.orden;
                    Obj.Class_NomReporte = item.class_nomreporte;
                    Obj.Observacion = item.observacion;
                    Obj.imgByt = item.imagen;
                    Obj.imagen = Funciones.ArrayAImage(item.imagen);
                    Obj.nom_Asembly = item.nom_asembly;
                    Obj.VersionActual = Convert.ToInt32(item.versionactual);
                    Obj.Estado = item.estado;
                    Obj.se_Muestra_Admin_Reporte = Convert.ToBoolean(item.se_muestra_admin_reporte);
                    Obj.Tipo_Balance = item.tipo_balance;
                    Obj.SQuery = item.squery;
                    Obj.Class_Info = item.class_info;
                    Obj.Class_Bus = item.class_bus;
                    Obj.Class_Data = item.class_data;
                    Obj.Store_proce_rpt = item.store_proce_rpt;
                    Obj.Disenio_reporte = item.disenio_reporte;
                    Obj.Se_Muestra_Icono = true;

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

        public List<tb_sis_reporte_Info> Get_List_reporte_x_Modulo(List<tb_modulo_Info> lstModulo)
        {
            try
            {
                List<tb_sis_reporte_Info> Lst = new List<tb_sis_reporte_Info>();
                var list = new List<string>();
                foreach (var item in lstModulo)
                {
                    list.Add(item.CodModulo);
                }
                EntitiesGeneral oEnti = new EntitiesGeneral();
                var Query = from q in oEnti.tb_sis_reporte
                            where q.se_muestra_admin_reporte == true
                             && q.estado == "A" && (list.Contains(q.modulo))
                            select q;


                foreach (var item in Query)
                {
                    tb_sis_reporte_Info Obj = new tb_sis_reporte_Info();
                    Obj.CodReporte = item.codreporte;
                    Obj.Nombre = item.nombre;
                    Obj.NombreCorto = item.nombrecorto;
                    Obj.Modulo = item.modulo;
                    Obj.VistaRpt = item.vistarpt;
                    Obj.Formulario = item.formulario;
                    Obj.Orden = item.orden;
                    Obj.Class_NomReporte = item.class_nomreporte;
                    Obj.Observacion = item.observacion;
                    Obj.imgByt = item.imagen;
                    Obj.imagen = Funciones.ArrayAImage(item.imagen);
                    Obj.nom_Asembly = item.nom_asembly;
                    Obj.Tipo_Balance = item.tipo_balance;
                    Obj.Estado = item.estado;
                    Obj.se_Muestra_Admin_Reporte = Convert.ToBoolean(item.se_muestra_admin_reporte);
                    Obj.VersionActual = Convert.ToInt32(item.versionactual);
                    Obj.SQuery = item.squery;
                    Obj.Class_Info = item.class_info;
                    Obj.Class_Bus = item.class_bus;
                    Obj.Class_Data = item.class_data;
                    Obj.Store_proce_rpt = item.store_proce_rpt;
                    Obj.Disenio_reporte = item.disenio_reporte;
                    Obj.Se_Muestra_Icono = true;

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

        public List<tb_sis_reporte_Info> Get_List_reporte(string CodModulo, string Tipo)
        {
            try
            {
                List<tb_sis_reporte_Info> Lst = new List<tb_sis_reporte_Info>();
                EntitiesGeneral oEnti = new EntitiesGeneral();
                var Query = from q in oEnti.tb_sis_reporte
                            where q.modulo == CodModulo && q.tipo_balance == Tipo
                            select q;

                foreach (var item in Query)
                {
                    tb_sis_reporte_Info Obj = new tb_sis_reporte_Info();
                    Obj.CodReporte = item.codreporte;
                    Obj.Nombre = item.nombre;
                    Obj.NombreCorto = item.nombrecorto;
                    Obj.Modulo = item.modulo;
                    Obj.VistaRpt = item.vistarpt;
                    Obj.Formulario = item.formulario;
                    Obj.Orden = item.orden;
                    Obj.Class_NomReporte = item.class_nomreporte;
                    Obj.Observacion = item.observacion;
                    Obj.imgByt = item.imagen;
                    Obj.imagen = Funciones.ArrayAImage(item.imagen);
                    Obj.nom_Asembly = item.nom_asembly;
                    Obj.Tipo_Balance = item.tipo_balance;
                    Obj.VersionActual = Convert.ToInt32(item.versionactual);
                    Obj.Estado = item.estado;
                    Obj.se_Muestra_Admin_Reporte = Convert.ToBoolean(item.se_muestra_admin_reporte);
                    Obj.Class_Info = item.class_info;
                    Obj.Class_Bus = item.class_bus;
                    Obj.Class_Data = item.class_data;
                    Obj.Store_proce_rpt = item.store_proce_rpt;
                    Obj.Disenio_reporte = item.disenio_reporte;
                    Obj.SQuery = item.squery;
                    Obj.Se_Muestra_Icono = true;
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
                return new List<tb_sis_reporte_Info>();
            }
        }

        public string Get_Numero(string CodModulo)
        {
            try
            {
                string num = "";
                EntitiesGeneral oEnti = new EntitiesGeneral();

                var c = oEnti.Database.SqlQuery<int>("select max(substring(CodReporte,LEN(CodReporte)-2,3) )+1 from tb_sis_reporte where Modulo='" + CodModulo + "' ");
                try
                {
                    var c2 = c.First();
                    if (c2 == null)
                        num = "001";
                    else if (Convert.ToDecimal(c2) < 10)
                        num = "00" + Convert.ToString(c2);
                    else if (Convert.ToDecimal(c2) < 99)
                        num = "0" + Convert.ToString(c2);
                    else if (Convert.ToDecimal(c2) < 999)
                        num = Convert.ToString(c2);
                    else
                        num = null;
                }
                catch (Exception)
                {
                    return "001";
                }
                return num;
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

        public tb_sis_reporte_Info Get_Info_reporte(string CodReporte)
        {
            EntitiesGeneral oEnti = new EntitiesGeneral();
            try
            {
                tb_sis_reporte_Info Info = new tb_sis_reporte_Info();
                var Objeto = oEnti.tb_sis_reporte.FirstOrDefault(var => var.codreporte == CodReporte);

                if (Objeto != null)
                {
                    Info.CodReporte = Objeto.codreporte;
                    Info.Nombre = Objeto.nombre;
                    Info.NombreCorto = Objeto.nombrecorto;
                    Info.Modulo = Objeto.modulo;
                    Info.VistaRpt = Objeto.vistarpt;
                    Info.Formulario = Objeto.formulario;
                    Info.Orden = Objeto.orden;
                    Info.Class_NomReporte = Objeto.class_nomreporte;
                    Info.Observacion = Objeto.observacion;
                    Info.imgByt = Objeto.imagen;
                    Info.imagen = Funciones.ArrayAImage(Objeto.imagen);
                    Info.VersionActual = Convert.ToInt32(Objeto.versionactual);
                    Info.Estado = Objeto.estado;
                    Info.se_Muestra_Admin_Reporte = Convert.ToBoolean(Objeto.se_muestra_admin_reporte);
                    Info.Tipo_Balance = Objeto.tipo_balance;
                    Info.nom_Asembly = Objeto.nom_asembly;
                    Info.SQuery = Objeto.squery;
                    Info.Class_Info = Objeto.class_info;
                    Info.Class_Bus = Objeto.class_bus;
                    Info.Class_Data = Objeto.class_data;
                    Info.Store_proce_rpt = Objeto.store_proce_rpt;
                    Info.Se_Muestra_Icono = true;
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

        public Boolean ModificarDB(tb_sis_reporte_Info info)
        {
            try
            {
                using (EntitiesGeneral context = new EntitiesGeneral())
                {
                    var contact = context.tb_sis_reporte.FirstOrDefault(minfo => minfo.codreporte == info.CodReporte);
                    if (contact != null)
                    {
                        contact.nombre = info.Nombre;
                        contact.nombrecorto = info.NombreCorto;
                        contact.modulo = info.Modulo;
                        contact.vistarpt = info.VistaRpt;
                        contact.formulario = info.Formulario;
                        contact.orden = info.Orden;
                        contact.class_nomreporte = info.Class_NomReporte;
                        contact.observacion = info.Observacion;
                        contact.imagen = info.imgByt;
                        contact.nom_asembly = info.nom_Asembly;
                        contact.versionactual = Convert.ToInt32(info.VersionActual);
                        contact.estado = info.Estado;
                        contact.se_muestra_admin_reporte = Convert.ToBoolean(info.se_Muestra_Admin_Reporte);
                        contact.tipo_balance = info.Tipo_Balance;
                        contact.squery = info.SQuery;
                        contact.class_info = info.Class_Info;
                        contact.class_bus = info.Class_Bus;
                        contact.class_data = info.Class_Data;
                        contact.store_proce_rpt = info.Store_proce_rpt;
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

        public Boolean ModificarDB_Disenio(tb_sis_reporte_Info info)
        {
            try
            {
                using (EntitiesGeneral context = new EntitiesGeneral())
                {
                    var contact = context.tb_sis_reporte.FirstOrDefault(minfo => minfo.codreporte == info.CodReporte);
                    if (contact != null)
                    {
                        contact.disenio_reporte = info.Disenio_reporte;
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

        public Boolean VericarExisteIdString(string codigo, ref string mensaje)
        {
            try
            {
                Boolean Existe;
                string scodigo;

                scodigo = codigo.Trim();
                mensaje = "";
                Existe = false;

                EntitiesGeneral B = new EntitiesGeneral();

                var select_ = from t in B.tb_sis_reporte
                              where t.codreporte == scodigo
                              select t;

                foreach (var item in select_)
                {
                    mensaje = mensaje + " " + item.nombre;
                    Existe = true;
                }

                return Existe;
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

        public DataTable Get_DataSet_SQL(string sqlQuerry)
        {
            try
            {
                EntitiesGeneral EntitiesB = new EntitiesGeneral();
                string connString = ((System.Data.EntityClient.EntityConnection)EntitiesB.Database.Connection).StoreConnection.ConnectionString;
                SqlDataAdapter da = new SqlDataAdapter(sqlQuerry, connString);
                DataTable ds = new DataTable();
                da.Fill(ds);
                return ds;
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

        public DataTable Get_DataTable_Tabla(string nombreTabla)
        {
            try
            {
                EntitiesGeneral EntitiesB = new EntitiesGeneral();
                string connString = ((System.Data.EntityClient.EntityConnection)EntitiesB.Database.Connection).StoreConnection.ConnectionString;
                string sql = "Select COLUMN_NAME,DATA_TYPE From INFORMATION_SCHEMA.columns where table_name ='" + nombreTabla + "'";
                SqlDataAdapter da = new SqlDataAdapter(sql, connString);
                DataTable ds = new DataTable();
                da.Fill(ds);
                return ds;
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

        public Boolean CrearTabla(int IdEmpresa, string usuario, DateTime Fecha_Transaccion, string nomPc, string nombre_Tabla, string query)
        {

            try
            {
                EntitiesGeneral EntitiesB = new EntitiesGeneral();
                string connString = ((System.Data.EntityClient.EntityConnection)EntitiesB.Database.Connection).StoreConnection.ConnectionString;

                SqlCommand cmd = new SqlCommand();
                SqlConnection cc = new SqlConnection(connString);

                string qr = "SELECT cast(" + IdEmpresa + " as int) as IdEmpresa_SP, cast('" + usuario + "' as varchar(20)) as IdUsuario_SP,cast('" + Fecha_Transaccion + "' as datetime) as Fecha_Transac,cast('" + nomPc + "' as varchar(20)) as nom_pc ,* INTO " + nombre_Tabla + " FROM (" + query + ") as pr";
                cmd.Connection = cc;
                cc.Open();
                cmd.CommandText = qr;
                cmd.ExecuteNonQuery();

                cc.Close();
                cmd.Dispose();
                cc.Dispose();

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


        public Boolean Execute_SQL(string query)
        {

            try
            {
                EntitiesGeneral EntitiesB = new EntitiesGeneral();
                string connString = ((System.Data.EntityClient.EntityConnection)EntitiesB.Database.Connection).StoreConnection.ConnectionString;

                SqlCommand cmd = new SqlCommand();
                SqlConnection cc = new SqlConnection(connString);


                cmd.Connection = cc;
                cc.Open();
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();

                cc.Close();
                cmd.Dispose();
                cc.Dispose();

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

        public List<String> Get_List_Tablas()
        {
            try
            {
                List<String> lst = new List<String>();
                EntitiesGeneral EntitiesB = new EntitiesGeneral();
                string connString = ((System.Data.EntityClient.EntityConnection)EntitiesB.Database.Connection).StoreConnection.ConnectionString;
                string sql = "Select table_name From INFORMATION_SCHEMA.Tables order by table_name";
                SqlDataAdapter da = new SqlDataAdapter(sql, connString);
                DataTable ds = new DataTable();
                da.Fill(ds);
                foreach (DataRow row in ds.Rows)
                {
                    foreach (DataColumn column in ds.Columns)
                    {
                        lst.Add((String)row[column]);
                    }
                }
                return lst;
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

        public tb_sis_reporte_Data() { }
    }
}