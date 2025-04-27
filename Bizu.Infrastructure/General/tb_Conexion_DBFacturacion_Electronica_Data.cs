using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
using Bizu.Domain.General;

namespace Bizu.Infrastructure.General
{
    public class tb_Conexion_DBFacturacion_Electronica_Data
    {
        private MySqlConnection oCon;
        private MySqlTransaction oTransaccion;

        public tb_Conexion_DBFacturacion_Electronica_Data()
        {

        }

        public bool GrabarBD(tb_Conexion_DBFacturacion_Electronica_Info Info, ref string mensaje)
        {
            try
            {
                EntitiesGeneral Context = new EntitiesGeneral();

                tb_conexion_dbfacturacion_electronica Obj = new tb_conexion_dbfacturacion_electronica();
                Obj.idempresa = Info.IdEmpresa;
                Obj.tipo_basedatos = Info.Tipo_BaseDatos;
                Obj.servidor = Info.Servidor;
                Obj.puerto = Info.Puerto;
                Obj.autenticacionwindows = Info.AutenticacionWindows;
                Obj.usuario = Info.Usuario;
                Obj.contrasena = Info.Contrasena;
                Obj.nombre_basedatos = Info.Nombre_BaseDatos;
                Obj.cadena_conexion = Info.Cadena_Conexion;
                Obj.script_comprobantesrecibidos = Info.Script_ComprobantesRecibidos;

                Context.tb_conexion_dbfacturacion_electronica.Add(Obj);
                Context.SaveChanges();

                mensaje = "Configuracion registrada con éxito!";

                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool ModificarBD(tb_Conexion_DBFacturacion_Electronica_Info Info, ref string mensaje)
        {
            try
            {
                EntitiesGeneral Context = new EntitiesGeneral();

                tb_conexion_dbfacturacion_electronica Obj = (from q in Context.tb_conexion_dbfacturacion_electronica
                                                             where q.idempresa == Info.IdEmpresa
                                                             select q).FirstOrDefault();

                if (Obj != null)
                {
                    Obj.tipo_basedatos = Info.Tipo_BaseDatos;
                    Obj.servidor = Info.Servidor;
                    Obj.puerto = Info.Puerto;
                    Obj.autenticacionwindows = Info.AutenticacionWindows;
                    Obj.usuario = Info.Usuario;
                    Obj.contrasena = Info.Contrasena;
                    Obj.nombre_basedatos = Info.Nombre_BaseDatos;
                    Obj.cadena_conexion = Info.Cadena_Conexion;
                    Obj.script_comprobantesrecibidos = Info.Script_ComprobantesRecibidos;

                    Context.SaveChanges();

                    mensaje = "Configuracion actualizada con éxito!";

                    return true;
                }
                else
                {
                    mensaje = "No existe información para actualizar";
                    return false;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public tb_Conexion_DBFacturacion_Electronica_Info Get_Info(int IdEmpresa)
        {
            try
            {
                tb_Conexion_DBFacturacion_Electronica_Info Info = new tb_Conexion_DBFacturacion_Electronica_Info();

                EntitiesGeneral Context = new EntitiesGeneral();

                var query = from q in Context.tb_conexion_dbfacturacion_electronica
                            where q.idempresa == IdEmpresa
                            select q;

                foreach (var item in query)
                {
                    Info.Tipo_BaseDatos = item.tipo_basedatos;
                    Info.Servidor = item.servidor;
                    Info.Puerto = item.puerto;
                    Info.AutenticacionWindows = item.autenticacionwindows;
                    Info.Usuario = item.usuario;
                    Info.Contrasena = item.contrasena;
                    Info.Nombre_BaseDatos = item.nombre_basedatos;
                    Info.Cadena_Conexion = item.cadena_conexion;
                    Info.Script_ComprobantesRecibidos = item.script_comprobantesrecibidos;
                }

                return Info;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool Existe(int IdEmpresa)
        {
            try
            {
                tb_Conexion_DBFacturacion_Electronica_Info Info = new tb_Conexion_DBFacturacion_Electronica_Info();

                EntitiesGeneral Context = new EntitiesGeneral();

                var query = from q in Context.tb_conexion_dbfacturacion_electronica
                            where q.idempresa == IdEmpresa
                            select q;

                if (query.Count() > 0)
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Conectar(string cadena_conexion)
        {
            try
            {
                oCon = new MySqlConnection(cadena_conexion);
                oCon.Open();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Desconectar()
        {
            try
            {
                if (oCon != null)
                {
                    if (oCon.State == ConnectionState.Open)
                        oCon.Close();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public MySqlDataReader Consultar(string sql)
        {
            try
            {
                if (oCon == null)
                    throw new Exception("Conexion is Null");

                MySqlDataReader result;

                MySqlCommand oCom;

                if (oTransaccion != null)
                    oCom = new MySqlCommand(sql, oCon, oTransaccion);
                else
                    oCom = new MySqlCommand(sql, oCon);

                result = oCom.ExecuteReader();
                oCom.Dispose();

                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public MySqlDataReader Consultar(string sql, int timeOut = 600)
        {
            MySqlDataReader reader2;
            try
            {
                if (ReferenceEquals(this.oCon, null))
                {
                    throw new Exception("Conexion is Null");
                }
                MySqlCommand command = (this.oTransaccion == null) ? new MySqlCommand(sql, this.oCon) : new MySqlCommand(sql, this.oCon, this.oTransaccion);
                command.CommandTimeout = timeOut;
                MySqlDataReader reader = command.ExecuteReader();
                command.Dispose();
                reader2 = reader;
            }
            catch (Exception exception1)
            {
                throw exception1;
            }
            return reader2;
        }

        public int delete(string sql)
        {
            int scalar = 0;

            try
            {
                if (oCon == null)
                    throw new Exception("Conexion is Null");

                MySqlCommand oCom;

                if (oTransaccion != null)
                    oCom = new MySqlCommand(sql, oCon, oTransaccion);
                else
                    oCom = new MySqlCommand(sql, oCon);

                scalar = oCom.ExecuteNonQuery();

                oCom.Dispose();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return scalar;
        }

        public void iniciarTransaccion()
        {
            try
            {
                oTransaccion = oCon.BeginTransaction();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void commitTransaccion()
        {
            try
            {
                oTransaccion.Commit();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void rollbackTransaccion()
        {
            try
            {
                if (oTransaccion != null)
                {
                    oTransaccion.Rollback();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}