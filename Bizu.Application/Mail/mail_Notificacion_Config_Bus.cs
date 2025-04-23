using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bizu.Infrastructure.Mail;
using Bizu.Domain.Mail;

namespace Bizu.Application.Mail
{
    public class mail_Notificacion_Config_Bus
    {
        private mail_Notificacion_Config_Data data;

        public mail_Notificacion_Config_Bus()
        {
            this.data = new mail_Notificacion_Config_Data();
        }

        public List<mail_Notificacion_Config_Info> Get_List(int IdEmpresa, string IdUsuario)
        {
            try
            {
                return this.data.Get_List(IdEmpresa, IdUsuario);
            }
            catch (Exception ex)
            {
                throw ex;
            }            
        }

        public mail_Notificacion_Config_Info Get_Info(int IdEmpresa, string IdUsuario, string HostName)
        {
            try
            {
                return this.data.Get_Info(IdEmpresa, IdUsuario, HostName);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool ExisteBD(int IdEmpresa, string IdUsuario, string HostName)
        {
            try
            {
                return this.data.ExisteBD(IdEmpresa, IdUsuario, HostName);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool GrabarBD(mail_Notificacion_Config_Info Info)
        {
            try
            {
                return this.data.GrabarBD(Info);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
