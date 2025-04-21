using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Info.Inventario;

namespace Core.Erp.Data.Inventario
{
    public class in_GuiaRemision_Motivo_Data
    {
        public List<in_GuiaRemision_Motivo_Info> Get_List_motivo(int IdEmpresa)
        {
            List<in_GuiaRemision_Motivo_Info> Lista = new List<in_GuiaRemision_Motivo_Info>();
                 
            try
            {
                EntitiesInventario Entitie_inve = new EntitiesInventario();

                var query = from q in Entitie_inve.in_GuiaRemision_Motivo
                            where q.IdEmpresa == IdEmpresa
                            select q;

                foreach (var item in query)
                {
                    in_GuiaRemision_Motivo_Info Info = new in_GuiaRemision_Motivo_Info();
                    Info.IdEmpresa = item.IdEmpresa;
                    Info.IdMotivo = item.IdMotivo;
                    Info.Codigo = item.Codigo;
                    Info.Descripcion = item.Descripcion;
                    Info.Estado = item.Estado;

                    Lista.Add(Info);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return Lista;
        }

        public Boolean Grabar(in_GuiaRemision_Motivo_Info GuiaRemision_Motivo_Info, ref int id, ref string mensaje)
        {
            try
            {
                EntitiesInventario Entitie_inve = new EntitiesInventario();

                in_GuiaRemision_Motivo Info = new in_GuiaRemision_Motivo();
                Info.IdEmpresa = GuiaRemision_Motivo_Info.IdEmpresa;
                Info.IdMotivo = Get_ID(Info.IdEmpresa);
                Info.Codigo = GuiaRemision_Motivo_Info.Codigo;
                Info.Descripcion = GuiaRemision_Motivo_Info.Descripcion;
                Info.Estado = "A";

                Entitie_inve.in_GuiaRemision_Motivo.Add(Info);
                Entitie_inve.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return true;
        }

        public Boolean Modificar(in_GuiaRemision_Motivo_Info GuiaRemision_Motivo_Info, ref string mensaje)
        {
            try
            {
                EntitiesInventario Entitie_inve = new EntitiesInventario();

                var Info = (from q in Entitie_inve.in_GuiaRemision_Motivo 
                                             where q.IdEmpresa == GuiaRemision_Motivo_Info.IdEmpresa && q.IdMotivo == GuiaRemision_Motivo_Info.IdMotivo
                                             select q).FirstOrDefault(); 
                
                Info.IdEmpresa = GuiaRemision_Motivo_Info.IdEmpresa;
                Info.IdMotivo = GuiaRemision_Motivo_Info.IdMotivo;
                Info.Codigo = GuiaRemision_Motivo_Info.Codigo;
                Info.Descripcion = GuiaRemision_Motivo_Info.Descripcion;
                Info.Estado = GuiaRemision_Motivo_Info.Estado;
                
                Entitie_inve.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return true;
        }

        public Boolean Anular(in_GuiaRemision_Motivo_Info GuiaRemision_Motivo_Info, ref string Mensaje)
        {
            try
            {
                EntitiesInventario Entitie_inve = new EntitiesInventario();

                var Info = (from q in Entitie_inve.in_GuiaRemision_Motivo
                            where q.IdEmpresa == GuiaRemision_Motivo_Info.IdEmpresa && q.IdMotivo == GuiaRemision_Motivo_Info.IdMotivo
                            select q).FirstOrDefault();
                
                Info.Estado = "I";

                Entitie_inve.SaveChanges();

                Mensaje = "Registro anulado con éxito!!";
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return true;
        }

        public Boolean Get_List_in_motivo_guia_remision_Existe(in_GuiaRemision_Motivo_Info GuiaRemision_Motivo_Info, ref string mensaje)
        {
            Boolean Existe = false;

            try
            {            
                EntitiesInventario Entitie_inve = new EntitiesInventario();

                var query = from q in Entitie_inve.in_GuiaRemision_Motivo
                            where q.IdEmpresa == GuiaRemision_Motivo_Info.IdEmpresa
                            && q.Codigo == GuiaRemision_Motivo_Info.Codigo
                            select q;

                if (query.Count() > 0)
                {
                    Existe = true;
                }

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return Existe;
        }

        public int Get_ID(int IdEmpresa)
        {            
            int Id = 0;

            try
            {
                EntitiesInventario Entitie_inve = new EntitiesInventario();

                var query = from q in Entitie_inve.in_GuiaRemision_Motivo
                            where q.IdEmpresa == IdEmpresa
                            select q;

                if (query.Count() > 0)
                {
                    Id = (from q in Entitie_inve.in_GuiaRemision_Motivo
                                where q.IdEmpresa == IdEmpresa
                                select q.IdMotivo).Max() + 1;
                }
                else
                {
                    Id = 1;
                }                
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return Id;
        }
    }
}
