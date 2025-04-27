using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bizu.Domain.General;

namespace Bizu.Infrastructure.General
{
    public class tb_parametro_Data
    {
        string mensaje = "";

        public List<tb_parametro_Info> Get_List_parametro()
        {
            try
            {
                List<tb_parametro_Info> lM = new List<tb_parametro_Info>();
                EntitiesGeneral OEGeneral = new EntitiesGeneral();

                var select_pv = from A in OEGeneral.tb_parametro
                                select A;

                foreach (var item in select_pv)
                {

                    tb_parametro_Info info = new tb_parametro_Info();
                    info.IdParametro = item.idparametro;
                    info.IdTipoParam = item.idtipoparam;
                    info.Valor = item.valor;
                    info.descripcion = item.descripcion;


                    lM.Add(info);
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

        public Boolean ModificarDB(tb_parametro_Info info, ref string msg)
        {
            try
            {
                using (EntitiesGeneral context = new EntitiesGeneral())
                {

                    var contact = context.tb_parametro.First(obj => obj.idparametro == info.IdParametro);
                    contact.idparametro = info.IdParametro;
                    contact.idtipoparam = info.IdTipoParam;
                    contact.valor = info.Valor;
                    contact.descripcion = info.descripcion;
                    context.SaveChanges();
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
                msg = "Se ha producido el siguiente error: " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }


        public Boolean GuardarDB(tb_parametro_Info info, ref string msg)
        {
            try
            {
                Boolean resultado = false;
                using (EntitiesGeneral context = new EntitiesGeneral())
                {
                    var address = new tb_parametro();
                    address.idparametro = info.IdParametro;
                    address.idtipoparam = info.IdTipoParam;
                    address.valor = info.Valor;
                    address.descripcion = info.descripcion;

                    context.tb_parametro.Add(address);
                    context.SaveChanges();
                    resultado = true;
                }
                return resultado;

            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString() + " " + ex.Message;
                msg = "Se ha producido el siguiente error: " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }


        public string getValor(string dato, ref string msg)
        {
            try
            {
                string resultado = "0";
                EntitiesGeneral OEGeneral = new EntitiesGeneral();
                var contact = OEGeneral.tb_parametro.First(obj => obj.idparametro == dato);
                if (contact != null)
                {
                    return resultado = contact.valor;

                }
                return resultado;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString() + " " + ex.Message;
                msg = "Se ha producido el siguiente error: " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }
    }
}