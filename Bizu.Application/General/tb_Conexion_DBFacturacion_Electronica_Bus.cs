using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bizu.Domain.General;
using Bizu.Infrastructure.General;

namespace Bizu.Application.General
{
    public class tb_Conexion_DBFacturacion_Electronica_Bus
    {
        tb_Conexion_DBFacturacion_Electronica_Data Data = new tb_Conexion_DBFacturacion_Electronica_Data();

        public bool GrabarBD(tb_Conexion_DBFacturacion_Electronica_Info Info, ref string mensaje)
        {
            try
            {
                return Data.GrabarBD(Info, ref mensaje);
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
                return Data.ModificarBD(Info, ref mensaje);
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
                return Data.Get_Info(IdEmpresa);
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
                return Data.Existe(IdEmpresa);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
