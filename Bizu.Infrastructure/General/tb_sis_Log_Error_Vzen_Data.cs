using Bizu.Domain.General;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bizu.Infrastructure.General;


namespace Bizu.Infrastructure.General
{
    public class tb_sis_Log_Error_Vzen_Data
    {
        string mensaje = "";

        public Boolean Guardar_Log_Error(tb_sis_Log_Error_Vzen_Info Item, ref string mensaje)
        {
            try
            {
                using (EntitiesGeneral Context = new EntitiesGeneral())
                {
                    tb_sis_log_error_vzen Cabe = new tb_sis_log_error_vzen();
                    Cabe.fecha_trans = Item.Fecha_Trans;
                    Cabe.detalle = Item.Detalle;
                    Cabe.tipo = Item.Tipo;
                    Cabe.clase = Item.Clase;
                    Cabe.pantalla = Item.Pantalla;
                    Cabe.asamble = Item.Asamble;
                    Cabe.usuario = Item.Usuario;
                    Cabe.ip = Item.Ip;
                    Cabe.pc = Item.PC;

                    Context.tb_sis_log_error_vzen.Add(Cabe);
                    Context.SaveChanges();
                }

                return true;
            }
            catch (Exception ex)
            {
                mensaje = ex.ToString() + " " + ex.Message;
                return false;
            }
        }

        public void Log_Error(string msg, string IdUsuario, string ip, string nom_pc, DateTime Fecha_Trans)
        {
            try
            {
                string arreglo = ToString();
                var palabras = arreglo.Split(',');
                string clase = "";
                string pantalla = "";
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(msg, "", clase = palabras[0], pantalla = palabras[1],
                    "", IdUsuario, ip, nom_pc, Fecha_Trans);
                string mensaje = "";

                //llamado a la función de grabado de log
                Guardar_Log_Error(Log_Error_sis, ref mensaje);
            }
            catch (Exception ex)
            {
                mensaje = ex.ToString() + " " + ex.Message;
            }
        }

        public List<tb_sis_Log_Error_Vzen_Info> Get_List_Log_Error_Vzen()
        {
            try
            {
                List<tb_sis_Log_Error_Vzen_Info> lM = new List<tb_sis_Log_Error_Vzen_Info>();
                EntitiesGeneral OEselecEmpresa = new EntitiesGeneral();

                var selectEmpresa = from C in OEselecEmpresa.tb_sis_log_error_vzen
                                    orderby C.id descending
                                    select C;

                foreach (var item in selectEmpresa)
                {
                    tb_sis_Log_Error_Vzen_Info Cbt = new tb_sis_Log_Error_Vzen_Info();
                    Cbt.Asamble = item.asamble;
                    Cbt.Clase = item.clase;
                    Cbt.Detalle = item.detalle;
                    Cbt.Fecha_Trans = item.fecha_trans;
                    Cbt.Ip = item.ip;
                    Cbt.Pantalla = item.pantalla;
                    Cbt.PC = item.pc;
                    Cbt.Tipo = item.tipo;
                    Cbt.Usuario = item.usuario;
                    Cbt.Id = item.id;

                    lM.Add(Cbt);
                }

                return (lM);
            }

            catch (Exception ex)
            {
                string arreglo = ToString();
                return new List<tb_sis_Log_Error_Vzen_Info>();
            }
        }

        public tb_sis_Log_Error_Vzen_Data()
        {

        }
    }
}
