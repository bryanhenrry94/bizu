using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Info.General;
using System.Data.OleDb;
using MySql.Data.MySqlClient;

namespace Core.Erp.Data.General
{
    public class tb_Comprobantes_Recibidos_Data
    {
        public List<tb_Comprobantes_Recibidos_Info> Consultar(int IdEmpresa)
        {
            try
            {
                List<tb_Comprobantes_Recibidos_Info> Lista = new List<tb_Comprobantes_Recibidos_Info>();

                tb_Conexion_DBFacturacion_Electronica_Data Conexion_BD = new tb_Conexion_DBFacturacion_Electronica_Data();
                tb_Conexion_DBFacturacion_Electronica_Info Info_Conexion = new tb_Conexion_DBFacturacion_Electronica_Info();

                Info_Conexion = Conexion_BD.Get_Info(IdEmpresa);

                Conexion_BD.Conectar(Info_Conexion.Cadena_Conexion);

                MySqlDataReader data = Conexion_BD.Consultar(Info_Conexion.Script_ComprobantesRecibidos);

                while (data.Read())
                {
                    tb_Comprobantes_Recibidos_Info Info = new tb_Comprobantes_Recibidos_Info();
                    Info.descripcion_archi = Convert.ToString(data["descripcion_archi"]);
                    Info.extencion = Convert.ToString(data["extencion"]).ToUpper();
                    Info.Fecha = Convert.ToDateTime(data["Fecha"]);
                    Info.Asunto = Convert.ToString(data["Asunto"]);
                    Info.mail_emisor = Convert.ToString(data["mail_emisor"]);
                    Info.Ced_Ruc_Emisor = Convert.ToString(data["Ced_Ruc_Emisor"]);
                    Info.Razon_Social_emisor = Convert.ToString(data["Razon_Social_emisor"]);
                    Info.sXml = Convert.ToString(data["sXml"]);
                    Info.IdTipo_Mensaje = Convert.ToString(data["IdTipo_Mensaje"]);
                    Info.codMensajeId = Convert.ToString(data["codMensajeId"]);
                    Info.IdCuenta = Convert.ToString(data["IdCuenta"]);
                    Info.Texto_mensaje = Convert.ToString(data["Texto_mensaje"]);
                    Info.Secuencia = Convert.ToString(data["Secuencia"]);
                    Info.Archivo_adjunto = (byte[])data["Archivo_adjunto"];
                    Info.Para = Convert.ToString(data["Para"]);
                    Info.IdMensaje = Convert.ToDecimal(data["IdMensaje"]);
                    Info.Ambiente = Convert.ToString(data["Ambiente"]);
                    Info.TipoDocumento = Convert.ToString(data["TipoDocumento"]);
                    Info.Esta_Provisionada = false;

                    Lista.Add(Info);
                }

                data.Close();

                Conexion_BD.Desconectar();

                return Lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<tb_Comprobantes_Recibidos_Info> Consultar(int IdEmpresa, DateTime FechaIni, DateTime FechaFin)
        {
            try
            {
                List<tb_Comprobantes_Recibidos_Info> Lista = new List<tb_Comprobantes_Recibidos_Info>();

                tb_Conexion_DBFacturacion_Electronica_Data Conexion_BD = new tb_Conexion_DBFacturacion_Electronica_Data();
                tb_Conexion_DBFacturacion_Electronica_Info Info_Conexion = new tb_Conexion_DBFacturacion_Electronica_Info();

                Info_Conexion = Conexion_BD.Get_Info(IdEmpresa);

                Conexion_BD.Conectar(Info_Conexion.Cadena_Conexion);

                string[] textArray1 = new string[] { "call sp_consulta_comprobantes_recibidos('", FechaIni.ToString("yyyy-MM-dd"), "', '", FechaFin.ToString("yyyy-MM-dd"), "');" };

                MySqlDataReader data = Conexion_BD.Consultar(string.Concat(textArray1), 600);

                while (data.Read())
                {
                    tb_Comprobantes_Recibidos_Info Info = new tb_Comprobantes_Recibidos_Info();
                    Info.descripcion_archi = Convert.ToString(data["descripcion_archi"]);
                    Info.extencion = Convert.ToString(data["extencion"]).ToUpper();
                    Info.Fecha = Convert.ToDateTime(data["Fecha"]);
                    Info.Asunto = Convert.ToString(data["Asunto"]);
                    Info.mail_emisor = Convert.ToString(data["mail_emisor"]);
                    Info.Ced_Ruc_Emisor = Convert.ToString(data["Ced_Ruc_Emisor"]);
                    Info.Razon_Social_emisor = Convert.ToString(data["Razon_Social_emisor"]);
                    Info.sXml = Convert.ToString(data["sXml"]);
                    Info.IdTipo_Mensaje = Convert.ToString(data["IdTipo_Mensaje"]);
                    Info.codMensajeId = Convert.ToString(data["codMensajeId"]);
                    Info.IdCuenta = Convert.ToString(data["IdCuenta"]);
                    Info.Texto_mensaje = Convert.ToString(data["Texto_mensaje"]);
                    Info.Secuencia = Convert.ToString(data["Secuencia"]);
                    Info.Archivo_adjunto = (byte[])data["Archivo_adjunto"];
                    Info.Para = Convert.ToString(data["Para"]);
                    Info.IdMensaje = Convert.ToDecimal(data["IdMensaje"]);
                    Info.Ambiente = Convert.ToString(data["Ambiente"]);
                    Info.TipoDocumento = Convert.ToString(data["TipoDocumento"]);
                    Info.Esta_Provisionada = false;

                    Lista.Add(Info);
                }

                data.Close();

                Conexion_BD.Desconectar();

                return Lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool Eliminar(int IdEmpresa, decimal IdMensaje)
        {
            bool flag;
            tb_Conexion_DBFacturacion_Electronica_Data data = new tb_Conexion_DBFacturacion_Electronica_Data();
            tb_Conexion_DBFacturacion_Electronica_Info info = new tb_Conexion_DBFacturacion_Electronica_Info();
            int num = 0;

            try
            {
                data.Conectar(data.Get_Info(IdEmpresa).Cadena_Conexion);
                data.iniciarTransaccion();
                num = data.delete("DELETE FROM mail_Mensaje_Archi_Adjunto WHERE IdMensaje = " + IdMensaje.ToString());
                num = data.delete("DELETE FROM mail_Mensaje WHERE IdMensaje = " + IdMensaje.ToString());
                data.commitTransaccion();
                data.Desconectar();
                flag = true;
            }
            catch (Exception exception)
            {
                data.rollbackTransaccion();
                throw new Exception(exception.Message);
            }

            return flag;
        }
    }
}