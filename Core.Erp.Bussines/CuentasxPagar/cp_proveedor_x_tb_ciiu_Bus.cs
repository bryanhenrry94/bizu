using Core.Erp.Data.CuentasxPagar;
using Core.Erp.Info.CuentasxPagar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Business.CuentasxPagar
{
    public class cp_proveedor_x_tb_ciiu_Bus
    {
        cp_proveedor_x_tb_ciiu_Data Data = new cp_proveedor_x_tb_ciiu_Data();

        public bool GrabarActividadEconomica(cp_proveedor_x_tb_ciiu_Info Info)
        {
            try
            {
                return Data.GrabarActividadEconomica(Info);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<cp_proveedor_x_tb_ciiu_Info> GetList(int IdEmpresa, decimal IdProveedor)
        {
            try
            {
                return Data.GetList(IdEmpresa, IdProveedor);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool ExisteDB(int IdEmpresa, decimal IdProveedor, int Id)
        {
            try
            {
                return Data.ExisteDB(IdEmpresa, IdProveedor, Id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool EliminarBD(int IdEmpresa, decimal IdProveedor, int Id)
        {
            try
            {
                return Data.EliminarBD(IdEmpresa, IdProveedor, Id);
            }catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}