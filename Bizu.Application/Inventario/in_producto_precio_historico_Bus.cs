using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bizu.Domain.Inventario;
using Bizu.Infrastructure.Inventario;

namespace Bizu.Application.Inventario
{
    public class in_producto_precio_historico_Bus
    {
        in_producto_precio_historico_Data Data = new in_producto_precio_historico_Data();

        public bool Grabar(in_producto_precio_historico_Info Info, ref string Mensaje)
        {
            try
            {
                return Data.Grabar(Info, ref Mensaje);
            }
            catch (Exception ex)
            {               
                throw new Exception(ex.ToString());
            }
        }

        public bool Grabar_List(List<in_producto_precio_historico_Info> Info_List, ref string Mensaje)
        {
            try
            {
                foreach (var item in Info_List) 
                {
                    Grabar(item, ref Mensaje);
                }

                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
        }
    }
}
