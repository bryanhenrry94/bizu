using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Info.Inventario;
using Core.Erp.Data.Inventario;

namespace Core.Erp.Business.Inventario
{
    public class in_GuiaRemision_Motivo_Bus
    {
        in_GuiaRemision_Motivo_Data Data = new in_GuiaRemision_Motivo_Data();

        public List<in_GuiaRemision_Motivo_Info> Get_List_motivo(int IdEmpresa)
        {
            try
            {
                return Data.Get_List_motivo(IdEmpresa);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);             
            }
        }
       
        public Boolean Grabar(in_GuiaRemision_Motivo_Info GuiaRemision_Motivo_Info, ref int id, ref string mensaje)
        {
            try
            {
                return Data.Grabar(GuiaRemision_Motivo_Info, ref id, ref mensaje);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Boolean Modificar(in_GuiaRemision_Motivo_Info GuiaRemision_Motivo_Info, ref string mensaje)
        {
            try
            {
                return Data.Modificar(GuiaRemision_Motivo_Info, ref mensaje);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Boolean Anular(in_GuiaRemision_Motivo_Info GuiaRemision_Motivo_Info, ref string mensaje)
        {
            try
            {
                return Data.Anular(GuiaRemision_Motivo_Info, ref mensaje);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Boolean Get_List_in_motivo_guia_remision_Existe(in_GuiaRemision_Motivo_Info GuiaRemision_Motivo_Info, ref string mensaje)
        {
            try
            {
                return Data.Get_List_in_motivo_guia_remision_Existe(GuiaRemision_Motivo_Info, ref mensaje);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
