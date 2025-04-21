using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
using Core.Erp.Info.General;

namespace Core.Erp.Data.General
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

                tb_Conexion_DBFacturacion_Electronica Obj = new tb_Conexion_DBFacturacion_Electronica();
                Obj.IdEmpresa = Info.IdEmpresa;
                Obj.Tipo_BaseDatos = Info.Tipo_BaseDatos;
                Obj.Servidor = Info.Servidor;
                Obj.Puerto = Info.Puerto;
                Obj.AutenticacionWindows = Info.AutenticacionWindows;
                Obj.Usuario = Info.Usuario;
                Obj.Contrasena = Info.Contrasena;
                Obj.Nombre_BaseDatos = Info.Nombre_BaseDatos;
                Obj.Cadena_Conexion = Info.Cadena_Conexion;
                Obj.Script_ComprobantesRecibidos = Info.Script_ComprobantesRecibidos;

                Context.tb_Conexion_DBFacturacion_Electronica.Add(Obj);
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

                tb_Conexion_DBFacturacion_Electronica Obj = (from q in Context.tb_Conexion_DBFacturacion_Electronica
                                                             where q.IdEmpresa == Info.IdEmpresa
                                                             select q).FirstOrDefault();

                if (Obj != null)
                {
                    Obj.Tipo_BaseDatos = Info.Tipo_BaseDatos;
                    Obj.Servidor = Info.Servidor;
                    Obj.Puerto = Info.Puerto;
                    Obj.AutenticacionWindows = Info.AutenticacionWindows;
                    Obj.Usuario = Info.Usuario;
                    Obj.Contrasena = Info.Contrasena;
                    Obj.Nombre_BaseDatos = Info.Nombre_BaseDatos;
                    Obj.Cadena_Conexion = Info.Cadena_Conexion;
                    Obj.Script_ComprobantesRecibidos = Info.Script_ComprobantesRecibidos;

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

                var query = from q in Context.tb_Conexion_DBFacturacion_Electronica
                            where q.IdEmpresa == IdEmpresa
                            select q;

                foreach (var item in query)
                {
                    Info.Tipo_BaseDatos = item.Tipo_BaseDatos;
                    Info.Servidor = item.Servidor;
                    Info.Puerto = item.Puerto;
                    Info.AutenticacionWindows = item.AutenticacionWindows;
                    Info.Usuario = item.Usuario;
                    Info.Contrasena = item.Contrasena;
                    Info.Nombre_BaseDatos = item.Nombre_BaseDatos;
                    Info.Cadena_Conexion = item.Cadena_Conexion;
                    Info.Script_ComprobantesRecibidos = item.Script_ComprobantesRecibidos;
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

                var query = from q in Context.tb_Conexion_DBFacturacion_Electronica
                            where q.IdEmpresa == IdEmpresa
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