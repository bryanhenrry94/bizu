using Core.Erp.Data.General;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Business.General
{
    public class tb_catastroGranContribuyente_Bus
    {
        tb_catastroGranContribuyente_Data Data = new tb_catastroGranContribuyente_Data();

        public bool ValidarRucGranContribuyente(string Ruc)
        {
            try
            {
                return Data.ValidarRucGranContribuyente(Ruc);
            }
            catch (Exception e)
            {
                throw e;
            }

        }
    }
}
