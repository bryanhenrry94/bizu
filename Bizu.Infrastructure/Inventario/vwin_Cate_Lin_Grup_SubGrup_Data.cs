using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bizu.Domain.Inventario;

namespace Bizu.Infrastructure.Inventario
{
    public class vwin_Cate_Lin_Grup_SubGrup_Data
    {
        public List<vwin_Cate_Lin_Grup_SubGrup_Info> Get_List(int IdEmpresa)
        {
            try
            {
                List<vwin_Cate_Lin_Grup_SubGrup_Info> Lista = new List<vwin_Cate_Lin_Grup_SubGrup_Info>();

                EntitiesInventario Context = new EntitiesInventario();

                var query = from q in Context.vwin_Cate_Lin_Grup_SubGrup
                            where q.IdEmpresa == IdEmpresa
                            select q;

                foreach (var item in query)
                {
                    vwin_Cate_Lin_Grup_SubGrup_Info Info = new vwin_Cate_Lin_Grup_SubGrup_Info();
                    Info.IdEmpresa = item.IdEmpresa;
                    Info.IdCategoria = item.IdCategoria;
                    Info.IdLinea = item.IdLinea;
                    Info.IdGrupo = item.IdGrupo;
                    Info.IdSubgrupo = item.IdSubgrupo;
                    Info.ca_Categoria = item.ca_Categoria;
                    Info.nom_linea = item.nom_linea;
                    Info.nom_grupo = item.nom_grupo;
                    Info.nom_subgrupo = item.nom_subgrupo;
                    Info.IdElemento = item.IdCategoria + "-" + item.IdLinea + "-" + item.IdGrupo + "-" + item.IdSubgrupo;

                    Lista.Add(Info);
                }

                return Lista;
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
                List<vwin_Cate_Lin_Grup_SubGrup_Info> Lista = new List<vwin_Cate_Lin_Grup_SubGrup_Info>();

                EntitiesInventario Context = new EntitiesInventario();

                var query = from q in Context.vwin_Cate_Lin_Grup_SubGrup
                            where q.IdEmpresa == IdEmpresa
                            && q.IdCategoria == IdCategoria
                            select q;

                foreach (var item in query)
                {
                    vwin_Cate_Lin_Grup_SubGrup_Info Info = new vwin_Cate_Lin_Grup_SubGrup_Info();
                    Info.IdEmpresa = item.IdEmpresa;
                    Info.IdCategoria = item.IdCategoria;
                    Info.IdLinea = item.IdLinea;
                    Info.IdGrupo = item.IdGrupo;
                    Info.IdSubgrupo = item.IdSubgrupo;
                    Info.ca_Categoria = item.ca_Categoria;
                    Info.nom_linea = item.nom_linea;
                    Info.nom_grupo = item.nom_grupo;
                    Info.nom_subgrupo = item.nom_subgrupo;
                    Info.IdElemento = item.IdCategoria + "-" + item.IdLinea + "-" + item.IdGrupo + "-" + item.IdSubgrupo;

                    Lista.Add(Info);
                }

                return Lista;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}