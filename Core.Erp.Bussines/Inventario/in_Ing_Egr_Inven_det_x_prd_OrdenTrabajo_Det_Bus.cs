using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Data.Inventario;
using Core.Erp.Info.Inventario;

namespace Core.Erp.Business.Inventario
{
    public class in_Ing_Egr_Inven_det_x_prd_OrdenTrabajo_Det_Bus
    {
        private in_Ing_Egr_Inven_det_x_prd_OrdenTrabajo_Det_Data Data = new in_Ing_Egr_Inven_det_x_prd_OrdenTrabajo_Det_Data();

        public List<in_Ing_Egr_Inven_det_x_prd_OrdenTrabajo_Det_Info> Get_List(int IdEmpresa, int IdSucursal, decimal IdOrdenTrabajo)
        {
            List<in_Ing_Egr_Inven_det_x_prd_OrdenTrabajo_Det_Info> list;
            try
            {
                list = this.Data.Get_List(IdEmpresa, IdSucursal, IdOrdenTrabajo);
            }
            catch (Exception exception1)
            {
                throw new Exception(exception1.Message);
            }
            return list;
        }

        public bool GrabarBD(List<in_Ing_Egr_Inven_det_x_prd_OrdenTrabajo_Det_Info> List_Info, ref string mensaje)
        {
            bool flag;
            try
            {
                flag = this.Data.GrabarBD(List_Info, ref mensaje);
            }
            catch (Exception exception1)
            {
                throw new Exception(exception1.Message);
            }
            return flag;
        }
    }
}