using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Data.Mail;
using Core.Erp.Info.Mail;

namespace Core.Erp.Business.Mail
{
    public class mail_Plantilla_Mensaje_Bus
    {
        mail_Plantilla_Mensaje_Data Data = new mail_Plantilla_Mensaje_Data();

        public Boolean GrabarBD(mail_Plantilla_Mensaje_Info Info, ref string mensaje)
        {
            try
            {
                return Data.GrabarBD(Info, ref mensaje);
            }
            catch (Exception ex)
            {
                mensaje = ex.Message;
                throw new Exception(ex.Message);
            }
        }

        public Boolean ModificarBD(mail_Plantilla_Mensaje_Info Info, ref string mensaje)
        {
            try
            {
                return Data.ModificarBD(Info, ref mensaje);
            }
            catch (Exception ex)
            {
                mensaje = ex.Message;
                throw new Exception(ex.Message);
            }
        }

        public List<mail_Plantilla_Mensaje_Info> Get_List(int IdEmpresa)
        {
            try
            {
                return Data.Get_List(IdEmpresa);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public mail_Plantilla_Mensaje_Info Get_Info(int IdEmpresa, string IdMensaje)
        {
            try
            {
                return Data.Get_Info(IdEmpresa, IdMensaje);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
