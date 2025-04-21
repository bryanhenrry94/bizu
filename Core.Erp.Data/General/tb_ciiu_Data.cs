using Core.Erp.Info.General;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Data.General
{
     public class tb_ciiu_Data
    {
        public List<tb_ciiu_Info> GetList(){
            List<tb_ciiu_Info> lista = new List<tb_ciiu_Info>();

            EntitiesGeneral dbContext = new EntitiesGeneral();

            var resultado = dbContext.tb_ciiu.ToList();


            foreach (var item in resultado)
            {
                tb_ciiu_Info info = new tb_ciiu_Info();
                info.id = item.id;
                info.codigo = item.codigo;
                info.descripcion = item.descripcion;
                info.nivel = item.nivel;

                lista.Add(info);
            }




            return lista;
        }
    }
}
