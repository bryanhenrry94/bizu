using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bizu.Domain.Contabilidad;
using Bizu.Infrastructure.General;
using Bizu.Domain.General;

namespace Bizu.Infrastructure.Contabilidad
{
    public class ct_cbtecble_Reversado_Data
    {
        string mensaje = "";
        public Boolean GuardarDB(ct_cbtecble_Reversado_Info Info)
        {
            try
            {
                using (EntitiesDBConta Context = new EntitiesDBConta())
                {

                    var Address = new ct_cbtecble_reversado();

                    Address.idempresa = Info.IdEmpresa;
                    Address.idtipocbte = Info.IdTipoCbte;
                    Address.idcbtecble = Info.IdCbteCble;
                    Address.idempresa_anu = Info.IdEmpresa_Anu;
                    Address.idtipocbte_anu = Info.IdTipoCbte_Anu;
                    Address.idcbtecble_anu = Info.IdCbteCble_Anu;
                    Context.ct_cbtecble_reversado.Add(Address);
                    Context.SaveChanges();
                }
                return true;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString();
                throw new Exception(ex.ToString());
            }
        }

        public ct_cbtecble_Reversado_Info Get_CbteCble_Reversado_Info(int IdEmpresa, int IdTipoCbte, decimal IdCbteCble)
        {
            EntitiesDBConta oEnti = new EntitiesDBConta();
            try
            {
                ct_cbtecble_Reversado_Info Info = new ct_cbtecble_Reversado_Info();
                var Objeto = oEnti.ct_cbtecble_reversado.FirstOrDefault(var => var.idempresa == IdEmpresa && var.idtipocbte == IdTipoCbte && var.idcbtecble == IdCbteCble);

                if (Objeto != null)
                {
                    Info.IdEmpresa = Objeto.idempresa;
                    Info.IdTipoCbte = Objeto.idtipocbte;
                    Info.IdCbteCble = Objeto.idcbtecble;
                    Info.IdEmpresa_Anu = Objeto.idempresa_anu;
                    Info.IdTipoCbte_Anu = Objeto.idtipocbte_anu;
                    Info.IdCbteCble_Anu = Objeto.idcbtecble_anu;
                }
                return Info;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString();
                throw new Exception(ex.ToString());
            }
        }    
    }
}