using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bizu.Domain.CuentasxPagar;

namespace Bizu.Infrastructure.CuentasxPagar
{
    public class cp_nota_DebCre_Impuesto_Data
    {
        public bool Eliminar(int IdEmpresa, decimal IdCbteCble_Nota, int IdTipoCbte_Nota)
        {
            try
            {
                EntitiesCuentasxPagar dbContext = new EntitiesCuentasxPagar();

                string sQuery = $"delete from cp_nota_DebCre_Impuesto where IdEmpresa = {IdEmpresa} and IdCbteCble_Nota = {IdCbteCble_Nota} and IdTipoCbte_Nota = {IdTipoCbte_Nota}";

                dbContext.Database.ExecuteSqlCommand(sQuery);

                return true;
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
                EntitiesCuentasxPagar dbContext = new EntitiesCuentasxPagar();

                cp_nota_DebCre_Impuesto _objOrdenGiro = new cp_nota_DebCre_Impuesto();
                _objOrdenGiro.IdEmpresa = Info.IdEmpresa;
                _objOrdenGiro.IdCbteCble_Nota = Info.IdCbteCble_Nota;
                _objOrdenGiro.IdTipoCbte_Nota = Info.IdTipoCbte_Nota;
                _objOrdenGiro.Codigo = Info.Codigo;
                _objOrdenGiro.CodigoPorcentaje = Info.CodigoPorcentaje;
                _objOrdenGiro.BaseImponible = Info.BaseImponible;
                _objOrdenGiro.Tarifa = Info.Tarifa;
                _objOrdenGiro.Valor = Info.Valor;

                dbContext.cp_nota_DebCre_Impuesto.Add(_objOrdenGiro);
                dbContext.SaveChanges();

                return true;
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
                List<cp_nota_DebCre_Impuesto_Info> Lista = new List<cp_nota_DebCre_Impuesto_Info>();

                EntitiesCuentasxPagar dbContext = new EntitiesCuentasxPagar();

                var query = dbContext.cp_nota_DebCre_Impuesto.Where(q => q.IdEmpresa == IdEmpresa && q.IdCbteCble_Nota == IdCbteCble_Nota && q.IdTipoCbte_Nota == IdTipoCbte_Nota).ToList();

                foreach(var item in query)
                {
                    cp_nota_DebCre_Impuesto_Info Info = new cp_nota_DebCre_Impuesto_Info();
                    Info.IdEmpresa = item.IdEmpresa;
                    Info.IdCbteCble_Nota = item.IdCbteCble_Nota;
                    Info.IdTipoCbte_Nota = item.IdTipoCbte_Nota;
                    Info.Codigo = item.Codigo;
                    Info.CodigoPorcentaje = item.CodigoPorcentaje;
                    Info.BaseImponible = item.BaseImponible;
                    Info.Tarifa = item.Tarifa;
                    Info.Valor = item.Valor;

                    Lista.Add(Info);
                }

                return Lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
