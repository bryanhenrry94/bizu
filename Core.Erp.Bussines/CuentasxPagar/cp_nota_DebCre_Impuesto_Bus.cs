using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Info.CuentasxPagar;
using Core.Erp.Data.CuentasxPagar;

namespace Core.Erp.Business.CuentasxPagar
{
    public class cp_nota_DebCre_Impuesto_Bus
    {
        private cp_nota_DebCre_Impuesto_Data Data;

        public cp_nota_DebCre_Impuesto_Bus()
        {
            this.Data = new cp_nota_DebCre_Impuesto_Data();
        }

        public bool Eliminar(int IdEmpresa, decimal IdCbteCble_Nota, int IdTipoCbte_Nota)
        {
            try
            {
                return Data.Eliminar(IdEmpresa, IdCbteCble_Nota, IdTipoCbte_Nota);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool GrabarBD(cp_nota_DebCre_Impuesto_Info Info)
        {
            try
            {
                return Data.GrabarBD(Info);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<cp_nota_DebCre_Impuesto_Info> GetList(int IdEmpresa, decimal IdCbteCble_Nota, int IdTipoCbte_Nota)
        {
            try
            {
                return this.Data.GetList(IdEmpresa, IdCbteCble_Nota, IdTipoCbte_Nota);
            }catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
