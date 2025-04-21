using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Data.Inventario;
using Core.Erp.Info.Inventario;

namespace Core.Erp.Business.Inventario
{
    public class vwin_GuiaRemision_det_con_saldo_x_ing_a_inven_con_saldo_Bus
    {
        private vwin_GuiaRemision_det_con_saldo_x_ing_a_inven_con_saldo_Data Data = new vwin_GuiaRemision_det_con_saldo_x_ing_a_inven_con_saldo_Data();

        public List<vwin_GuiaRemision_det_con_saldo_x_ing_a_inven_con_saldo_Info> Get_List(int IdEmpresa, int IdSucursal, string IdCentroCosto)
        {
            try
            {
                return Data.Get_List(IdEmpresa, IdSucursal, IdCentroCosto);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<vwin_GuiaRemision_det_con_saldo_x_ing_a_inven_con_saldo_Info> Get_List(int IdEmpresa, int IdSucursal, decimal IdGuiaRemision)
        {
            try
            {
                return Data.Get_List(IdEmpresa, IdSucursal, IdGuiaRemision);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}