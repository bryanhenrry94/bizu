using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bizu.Domain.Contabilidad;
using Bizu.Infrastructure.General;
using Bizu.Domain.General;

namespace Bizu.Infrastructure.Contabilidad
{
    public class ct_Parametro_Data
    {
        string mensaje = "";

        public Boolean GuardarDB(ct_Parametro_Info Info)
        {
            try
            {
                using (EntitiesDBConta Context = new EntitiesDBConta())
                {
                    ct_parametro Address = new ct_parametro();

                    Address.idempresa = Info.IdEmpresa;
                    Address.idtipocbte_saldoinicial= Info.IdTipoCbte_SaldoInicial;
                    Address.idtipocbte_asientocierre_anual = Info.IdTipoCbte_AsientoCierre_Anual;
                    Address.p_se_muestra_todas_las_ctas_en_combos = Info.P_Se_Muestra_Todas_las_ctas_en_combos;
                    Context.ct_parametro.Add(Address);
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

        public Boolean ModificarDB(ct_Parametro_Info info)
        {
            try
            {
                using (EntitiesDBConta Context = new EntitiesDBConta())
                {
                    EntitiesDBConta param = new EntitiesDBConta();
                    var selectBaParam = (from C in param.ct_parametro
                                         where C.idempresa == info.IdEmpresa
                                         select C).Count();

                    if (selectBaParam == 0)
                    {
                        ct_parametro addressG = new ct_parametro();
                        addressG.idempresa = info.IdEmpresa;
                        addressG.idtipocbte_asientocierre_anual = info.IdTipoCbte_AsientoCierre_Anual;
                        addressG.idtipocbte_saldoinicial = info.IdTipoCbte_SaldoInicial;
                        addressG.p_se_muestra_todas_las_ctas_en_combos = info.P_Se_Muestra_Todas_las_ctas_en_combos;

                        Context.ct_parametro.Add(addressG);
                        Context.SaveChanges();
                    }
                    else
                    {
                        var contact = Context.ct_parametro.FirstOrDefault(para => para.idempresa == info.IdEmpresa);
                        if (contact != null)
                        {
                            contact.idempresa = info.IdEmpresa;
                            contact.idtipocbte_saldoinicial = info.IdTipoCbte_SaldoInicial;
                            contact.idtipocbte_asientocierre_anual = info.IdTipoCbte_AsientoCierre_Anual;
                            contact.p_se_muestra_todas_las_ctas_en_combos = info.P_Se_Muestra_Todas_las_ctas_en_combos;
                            Context.SaveChanges();
                        }
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString();
                throw new Exception(ex.ToString());
            }
        }

        public ct_Parametro_Info Get_Info_Parametro(int IdEmpresa)
        {
            try
            {
                ct_Parametro_Info Cbt = new ct_Parametro_Info();
                EntitiesDBConta param = new EntitiesDBConta();
                var selectBaParam = from C in param.ct_parametro
                                    where C.idempresa == IdEmpresa
                                    select C;

                foreach (var item in selectBaParam)
                {

                    Cbt.IdEmpresa = item.idempresa;
                    Cbt.IdTipoCbte_SaldoInicial = Convert.ToInt32(item.idtipocbte_saldoinicial);
                    Cbt.IdTipoCbte_AsientoCierre_Anual = Convert.ToInt32(item.idtipocbte_asientocierre_anual);
                    Cbt.P_Se_Muestra_Todas_las_ctas_en_combos = Convert.ToBoolean(item.p_se_muestra_todas_las_ctas_en_combos);

                }
                return (Cbt);
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString();
                throw new Exception(ex.ToString());
            }
        }
    }
}
