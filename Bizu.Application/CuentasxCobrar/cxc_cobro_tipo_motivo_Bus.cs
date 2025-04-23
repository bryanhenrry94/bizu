using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Bizu.Infrastructure.CuentasxCobrar;
using Bizu.Domain.CuentasxCobrar;
using Bizu.Application.General;


namespace Bizu.Application.CuentasxCobrar
{
   public class cxc_cobro_tipo_motivo_Bus
    {
       cxc_cobro_tipo_motivo_Data Odata = new cxc_cobro_tipo_motivo_Data();

        
        public List<cxc_cobro_tipo_motivo_Info> Get_List_cobro_tipo_motivo()
        {
            try
            {
                List<cxc_cobro_tipo_motivo_Info> lista = new List<cxc_cobro_tipo_motivo_Info>();
                lista=Odata.Get_List_cobro_tipo_motivo();
                return lista;
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "Get_List_Cobro_Tipo", ex.Message), ex) { EntityType = typeof(cxc_cobro_tipo_Bus) };
            }

        }
    

    }
}
