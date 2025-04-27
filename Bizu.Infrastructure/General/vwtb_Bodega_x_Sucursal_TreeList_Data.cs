using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bizu.Domain.General;

namespace Bizu.Infrastructure.General
{
    public class vwtb_Bodega_x_Sucursal_TreeList_Data
    {
        string mensaje = "";
        public List<vwtb_Bodega_x_Sucursal_TreeList_Info> Get_List_Bodega_x_Sucursal(int IdEmpresa)
        {
            try
            {
                List<vwtb_Bodega_x_Sucursal_TreeList_Info> lstInfo = new List<vwtb_Bodega_x_Sucursal_TreeList_Info>();
                using (EntitiesGeneral listado = new EntitiesGeneral())
                {
                    var select = from q in listado.vwtb_bodega_x_sucursal_treelist
                                 where q.idempresa == IdEmpresa
                                 select q;

                    foreach (var item in select)
                    {
                        vwtb_Bodega_x_Sucursal_TreeList_Info Info = new vwtb_Bodega_x_Sucursal_TreeList_Info();
                        Info.IdEmpresa = item.idempresa;
                        Info.ID = item.id;
                        Info.IdPadre = item.idpadre;
                        Info.Nombre = item.nombre;
                        Info.Estado = item.estado;
                        Info.Nivel = item.nivel;
                        Info.IdSucursal = item.idsucursal;
                        Info.IdBodega = Convert.ToInt32(item.idbodega);
                        Info.Checked = true;

                        lstInfo.Add(Info);
                    }
                }

                return lstInfo;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.InnerException.ToString());
            }
        }
    }
}