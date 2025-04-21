using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Info.Mail;
using Core.Erp.Data.Mail;

namespace Core.Erp.Business.Mail
{
    public class mail_Mail_Attachment_Bus
    {
        private mail_Mail_Attachment_Data Data = new mail_Mail_Attachment_Data();

        public bool GrabarBD(List<mail_Mail_Attachment_Info> List)
        {
            try
            {
                return Data.GrabarBD(List);
            }catch(Exception ex)
            {
                throw ex;
            }
        }

        public List<mail_Mail_Attachment_Info> Get_List (int IdEmpresa, int IdSucursal, int IdMail)
        {
            try
            {
                return Data.Get_List(IdEmpresa, IdSucursal, IdMail);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
