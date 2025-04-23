using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bizu.Infrastructure.General
{
    public class tb_catastroGranContribuyente_Data
    {
        public bool ValidarRucGranContribuyente(string Ruc)
        {
            try
            {
                // consultar en la base de datos el ruc del campo 
                EntitiesGeneral dbContext = new EntitiesGeneral();

                var resultado = dbContext.tb_catastroGranContribuyente
                                 .Where(tcgc => tcgc.ruc == Ruc)
                                 .ToList();
                if (resultado.Count > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception e)
            {
                throw e;
            }

        }
    }
}
