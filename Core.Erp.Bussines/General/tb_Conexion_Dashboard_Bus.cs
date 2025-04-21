using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Data.General;
using Core.Erp.Info.General;

namespace Core.Erp.Business.General
{
    public class tb_Conexion_Dashboard_Bus
    {
        private tb_Conexion_Dashboard_Data data;

        public tb_Conexion_Dashboard_Bus()
        {
            this.data = new tb_Conexion_Dashboard_Data();
        }

        public bool GrabarBD(tb_Conexion_Dashboard_Info Info)
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

        public tb_Conexion_Dashboard_Info Get_Conexion_Dashboard()
        {
            try
            {
                return this.data.Get_Conexion_Dashboard();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
