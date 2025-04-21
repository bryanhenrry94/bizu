using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Info.General;
using Core.Erp.Data.General;

namespace Core.Erp.Business.General
{
    public class tb_Bodega_Filtro_Bus
    {
        private tb_Bodega_Filtro_Data Data = new tb_Bodega_Filtro_Data();

        public bool GrabarBD(List<tb_Bodega_Filtro_Info> List)
        {
            try
            {
                return Data.GrabarBD(List);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
