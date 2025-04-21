using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Data.Facturacion;
using Core.Erp.Info.Facturacion;

namespace Core.Erp.Business.Facturacion
{
    public class fa_notaCreDeb_x_in_Ing_Egr_Inven_Bus
    {
        private fa_notaCreDeb_x_in_Ing_Egr_Inven_Data Data = new fa_notaCreDeb_x_in_Ing_Egr_Inven_Data();

        public bool Grabar(List<fa_notaCreDeb_x_in_Ing_Egr_Inven_Info> List, ref string msg)
        {
            try
            {
                return Data.Grabar(List, ref msg);
            }
            catch (Exception e)
            {
                msg = e.Message;
                return false;
            }

        }

        public List<fa_notaCreDeb_x_in_Ing_Egr_Inven_Info> Get_List(int Inv_IdEmpresa, int Inv_IdSucursal,
            int Inv_IdMovi_inven_tipo, decimal Inv_IdNumMovi, ref string msg)
        {
            try
            {
                return Data.Get_List(Inv_IdEmpresa, Inv_IdSucursal, Inv_IdMovi_inven_tipo, Inv_IdNumMovi, ref msg);
            }
            catch (Exception e)
            {
                msg = e.Message;
                return new  List<fa_notaCreDeb_x_in_Ing_Egr_Inven_Info>();
            }

        }
    }
}
