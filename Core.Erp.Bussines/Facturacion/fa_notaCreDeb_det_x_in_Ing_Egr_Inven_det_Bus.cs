using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Info.Facturacion;
using Core.Erp.Data.Facturacion;

namespace Core.Erp.Business.Facturacion
{
    public class fa_notaCreDeb_det_x_in_Ing_Egr_Inven_det_Bus
    {
        private fa_notaCreDeb_det_x_in_Ing_Egr_Inven_det_Data Data = new fa_notaCreDeb_det_x_in_Ing_Egr_Inven_det_Data();

        public bool Grabar(List<fa_notaCreDeb_det_x_in_Ing_Egr_Inven_det_Info> List, ref string msg)
        {
            try {
                return Data.Grabar(List, ref msg);
            }
            catch (Exception e) 
            {
                msg = e.Message;
                return false;
            }
            
        }

        public bool EliminarDB(int in_IdEmpresa, int in_IdSucursal, int in_IdMovi_inven_tipo, decimal in_IdNumMovi, ref string msg)
        {
            try
            {
                return Data.EliminarDB(in_IdEmpresa, in_IdSucursal, in_IdMovi_inven_tipo, in_IdNumMovi, ref msg);
            }
            catch (Exception e)
            {
                msg = e.Message;
                return false;
            }

        }
    }
}
