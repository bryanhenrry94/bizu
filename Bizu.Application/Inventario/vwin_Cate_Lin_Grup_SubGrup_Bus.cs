using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bizu.Infrastructure.Inventario;
using Bizu.Domain.Inventario;

namespace Bizu.Application.Inventario
{
    public class vwin_Cate_Lin_Grup_SubGrup_Bus
    {
        vwin_Cate_Lin_Grup_SubGrup_Data Data = new vwin_Cate_Lin_Grup_SubGrup_Data();

        public List<vwin_Cate_Lin_Grup_SubGrup_Info> Get_List(int IdEmpresa)
        {
            try
            {
                return Data.Get_List(IdEmpresa);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<vwin_Cate_Lin_Grup_SubGrup_Info> Get_List(int IdEmpresa, string IdCategoria)
        {
            try
            {
                return Data.Get_List(IdEmpresa, IdCategoria);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}