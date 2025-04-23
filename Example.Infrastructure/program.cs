using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using Dazzsoft.ERP.Infrastructure.Persistence;

namespace Dazzsoft.ERP.Infrastructure
{
    static class program
    {

        [STAThread]
        static void Main()
        {
            using (var context = new GeneralContext())
            {
                var empresas = context.TbEmpresa.ToList();

                // Leer usuarios
                foreach (var u in empresas)
                {
                    Console.WriteLine($"Codigo: {u.Codigo}, RUC: {u.EmRuc}, Razon Social: {u.RazonSocial}");
                }
            }

            Console.WriteLine("Presiona cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}
