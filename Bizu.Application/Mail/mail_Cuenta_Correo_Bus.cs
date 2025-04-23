using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bizu.Infrastructure.Mail;
using Bizu.Domain.Mail;
using Bizu.Infrastructure.General;
using Bizu.Domain.General;

namespace Bizu.Application.Mail
{
    public class mail_Cuenta_Correo_Bus
    {
        private mail_Cuenta_Correo_Data Data = new mail_Cuenta_Correo_Data();

        public Boolean GrabarBD(mail_Cuenta_Correo_Info Info, ref string mensaje)
        {
            try
            {
                if (Data.GrabarBD(Info, ref mensaje))
                {
                    if (Info.Cuenta_Predeterminada)
                    {
                        Data.Establecer_Cuenta_Predeterminada(Info.IdEmpresa, Info.IdCuenta);

                        tb_Empresa_Data Data_Empresa = new tb_Empresa_Data();
                        Data_Empresa.Establecer_Cuenta_Correo(Info.IdEmpresa, Info.Direccion_Correo);
                    }

                    return true;
                }
                else
                    return false;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Boolean ModificarBD(mail_Cuenta_Correo_Info Info, ref string mensaje)
        {
            try
            {
                if (Data.ModificarBD(Info, ref mensaje))
                {
                    tb_Empresa_Data Data_Empresa = new tb_Empresa_Data();
                    Data_Empresa.Establecer_Cuenta_Correo(Info.IdEmpresa, Info.Direccion_Correo);

                    return true;
                }
                else
                    return false;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Boolean Establecer_Cuenta_Predeterminada(int IdEmpresa, string IdCuenta)
        {
            try
            {
                return Data.Establecer_Cuenta_Predeterminada(IdEmpresa, IdCuenta);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<mail_Cuenta_Correo_Info> Get_List(int IdEmpresa)
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

        public string Get_IdCuenta_Predeterminada(int IdEmpresa)
        {
            try
            {
                return Data.Get_IdCuenta_Predeterminada(IdEmpresa);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public mail_Cuenta_Correo_Info Get_Info(int IdEmpresa, string IdCuenta)
        {
            try
            {
                return Data.Get_Info(IdEmpresa, IdCuenta);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
