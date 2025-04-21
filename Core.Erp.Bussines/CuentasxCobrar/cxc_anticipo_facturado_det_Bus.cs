using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Data.CuentasxCobrar;
using Core.Erp.Info.CuentasxCobrar;

namespace Core.Erp.Business.CuentasxCobrar
{
    public class cxc_anticipo_facturado_det_Bus
    {
        private cxc_anticipo_facturado_det_Data Data = new cxc_anticipo_facturado_det_Data();

        public List<cxc_anticipo_facturado_det_Info> Get_Detalle(int IdEmpresa, decimal IdAnticipo)
        {
            List<cxc_anticipo_facturado_det_Info> Lista = new List<cxc_anticipo_facturado_det_Info>();

            try
            {
                Lista = Data.Get_Detalle(IdEmpresa, IdAnticipo);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return Lista;
        }

        public bool GrabarBD(List<cxc_anticipo_facturado_det_Info> List_Info, string mensaje)
        {
            try
            {
                return Data.GrabarBD(List_Info, mensaje);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public bool GrabarBD(cxc_anticipo_facturado_det_Info Info, string mensaje)
        {
            try
            {
                return Data.GrabarBD(Info, mensaje);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }       
    }
}