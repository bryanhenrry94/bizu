using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bizu.Infrastructure.Contabilidad;
using Bizu.Domain.Contabilidad;

namespace Bizu.Application.Contabilidad
{
    public class ct_dashboard_financiero_Bus
    {
        private ct_dashboard_financiero_Data data = new ct_dashboard_financiero_Data();

        public bool GrabarBD(ct_dashboard_financiero_Info Info)
        {
            try
            {
                return data.GrabarBD(Info);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool EliminarBD(int IdEmpresa, string IdUsuario)
        {
            try
            {
                return data.EliminarBD(IdEmpresa, IdUsuario);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<ct_dashboard_financiero_Info> GetList(int IdEmpresa, string IdUsuario)
        {
            try
            {
                return data.GetList(IdEmpresa, IdUsuario);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}