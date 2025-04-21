using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Info.General;
using Core.Erp.Data.General;
using Core.Erp.Info.CuentasxPagar;
using Core.Erp.Data.CuentasxPagar;

namespace Core.Erp.Business.General
{
    public class tb_Comprobantes_Recibidos_Bus
    {
        tb_Comprobantes_Recibidos_Data Data = new tb_Comprobantes_Recibidos_Data();

        public List<tb_Comprobantes_Recibidos_Info> Consultar(int IdEmpresa)
        {
            try
            {
                return Data.Consultar(IdEmpresa);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<tb_Comprobantes_Recibidos_Info> Consultar(int IdEmpresa, DateTime FechaIni, DateTime FechaFin)
        {
            try
            {
                return Data.Consultar(IdEmpresa, FechaIni, FechaFin);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool Eliminar(int IdEmpresa, decimal IdMensaje)
        {
            try
            {
                return Data.Eliminar(IdEmpresa, IdMensaje);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
