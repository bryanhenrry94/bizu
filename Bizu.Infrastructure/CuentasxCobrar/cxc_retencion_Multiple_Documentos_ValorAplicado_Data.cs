using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bizu.Domain.CuentasxCobrar;
using Bizu.Infrastructure.General;
using Bizu.Domain.General;
using System.Data.Entity.Validation;

namespace Bizu.Infrastructure.CuentasxCobrar
{
    public class cxc_retencion_Multiple_Documentos_ValorAplicado_Data
    {
        string mensaje = "";

        public Boolean GuardarDB(List<cxc_retencion_Multiple_Documentos_ValorAplicado_Info> lista)
        {
            try
            {
                int secuencia = 0;


                if (lista != null && lista.Count() > 0)
                {

                    using (EntitiesCuentas_x_Cobrar Contex = new EntitiesCuentas_x_Cobrar())
                    {
                        var obj = lista.First();

                        var lst = from q in Contex.cxc_retencion_Multiple_Documentos_ValorAplicado
                                  join c in Contex.cxc_retencion_Multiple_Documento
                                  on new { q.IdEmpresa, q.IdMultir } equals new { c.IdEmpresa, c.IdMultir }
                                  where obj.IdEmpresa == q.IdEmpresa
                                  && obj.IdMultir == q.IdMultir
                                  //&& c.Estado == "A"
                                  group q by new { q.IdEmpresa, q.IdBodega_cbteVta, q.IdCobro };


                        if (lst.Count() > 0)
                        {
                            secuencia = lst.Count();
                        }

                        foreach (var item in lista)
                        {

                            var address = new cxc_retencion_Multiple_Documentos_ValorAplicado();
                            secuencia = secuencia + 1;

                            address.IdEmpresa = item.IdEmpresa;
                            address.IdMultir = item.IdMultir;
                            address.Secuencia = secuencia;
                            address.IdCobro = item.IdCobro;
                            address.IdEmpresa_cbteVta = item.IdEmpresa_cbteVta;
                            address.IdSucursal_cbteVta = item.IdSucursal_cbteVta;
                            address.IdBodega_cbteVta = item.IdBodega_cbteVta;
                            address.IdCbteVta_cbteVta = item.IdCbteVta_cbteVta;
                            address.IdTipoDoc_cbteVta = item.IdTipoDoc_cbteVta;
                            address.IdCobro_tipo = item.IdCobro_tipo;
                            address.Base = item.Base;
                            address.PorcentajeRetenc = item.PorcentajeRetenc;
                            address.ValorRetenc = item.ValorRetenc;

                            Contex.cxc_retencion_Multiple_Documentos_ValorAplicado.Add(address);

                        }
                        Contex.SaveChanges();
                    }
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
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.InnerException.ToString());
            }
        }

        public Boolean ModificarDetalleCobro(List<cxc_retencion_Multiple_Documentos_ValorAplicado_Info> lista)
        {
            try
            {
                try
                {
                    List<cxc_retencion_Multiple_Documentos_ValorAplicado_Info> listaAux = new List<cxc_retencion_Multiple_Documentos_ValorAplicado_Info>();
                    cxc_retencion_Multiple_Documentos_ValorAplicado_Info i = new cxc_retencion_Multiple_Documentos_ValorAplicado_Info();
                    i = lista.First();
                    listaAux = Get_List_Retencion_detalle(i.IdEmpresa, i.IdMultir, Convert.ToInt32(i.IdCobro));

                    using (EntitiesCuentas_x_Cobrar context = new EntitiesCuentas_x_Cobrar())
                    {
                        foreach (var item in listaAux)
                        {
                            var contact = context.cxc_retencion_Multiple_Documentos_ValorAplicado.First(cot => cot.IdEmpresa == item.IdEmpresa && cot.IdMultir == item.IdMultir && cot.IdCobro == item.IdCobro);
                            context.cxc_retencion_Multiple_Documentos_ValorAplicado.Remove(contact);
                            context.SaveChanges();
                        }
                    }
                }
                catch (Exception ex)
                {
                    string arreglo = ToString();
                    tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                    tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                        "", "", "", "", DateTime.Now);
                    oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                    mensaje = ex.InnerException + " " + ex.Message;
                }
                using (EntitiesCuentas_x_Cobrar Contex = new EntitiesCuentas_x_Cobrar())
                {
                    int secuencia = 0;
                    foreach (var item in lista)
                    {
                        var address = new cxc_retencion_Multiple_Documentos_ValorAplicado();
                        secuencia = secuencia + 1;
                        address.IdEmpresa = item.IdEmpresa;
                        address.IdMultir = item.IdMultir;
                        address.IdCobro = item.IdCobro;
                        address.Secuencia = secuencia;
                        address.IdEmpresa_cbteVta = item.IdEmpresa_cbteVta;
                        address.IdSucursal_cbteVta = item.IdSucursal_cbteVta;
                        address.IdBodega_cbteVta = item.IdBodega_cbteVta;
                        address.IdCbteVta_cbteVta = item.IdCbteVta_cbteVta;
                        address.IdTipoDoc_cbteVta = item.IdTipoDoc_cbteVta;

                        Contex.cxc_retencion_Multiple_Documentos_ValorAplicado.Add(address);
                        Contex.SaveChanges();
                    }
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
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.InnerException.ToString());
            }
        }

        public List<cxc_retencion_Multiple_Documentos_ValorAplicado_Info> Get_List_Retencion_detalle(int IdEmpresa, int idMulti, int idcobro)
        {
            try
            {
                List<cxc_retencion_Multiple_Documentos_ValorAplicado_Info> lM = new List<cxc_retencion_Multiple_Documentos_ValorAplicado_Info>();
                EntitiesCuentas_x_Cobrar CXC = new EntitiesCuentas_x_Cobrar();
                var select_det_cobro = from A in CXC.cxc_retencion_Multiple_Documentos_ValorAplicado
                                       where A.IdEmpresa == IdEmpresa
                                       && A.IdMultir == idMulti
                                       && A.IdCobro == idcobro
                                       select A
                                      ;
                foreach (var item in select_det_cobro)
                {
                    cxc_retencion_Multiple_Documentos_ValorAplicado_Info dat = new cxc_retencion_Multiple_Documentos_ValorAplicado_Info();
                    dat.IdEmpresa = item.IdEmpresa;
                    dat.IdEmpresa = item.IdEmpresa;
                    dat.IdMultir = item.IdMultir;
                    dat.IdCobro = item.IdCobro;
                    dat.Secuencia = item.Secuencia;
                    dat.IdEmpresa_cbteVta = item.IdEmpresa_cbteVta;
                    dat.IdSucursal_cbteVta = item.IdSucursal_cbteVta;
                    dat.IdBodega_cbteVta = item.IdBodega_cbteVta;
                    dat.IdCbteVta_cbteVta = Convert.ToDecimal(item.IdCbteVta_cbteVta);
                    dat.IdTipoDoc_cbteVta = item.IdTipoDoc_cbteVta;

                    lM.Add(dat);
                }
                return (lM);

            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.InnerException.ToString());
            }

        }

        public cxc_retencion_Multiple_Documentos_ValorAplicado_Info Get_Retencion_detalle(int IdEmpresa, int idMulti, int idcobro)
        {
            try
            {
                cxc_retencion_Multiple_Documentos_ValorAplicado_Info dat = new cxc_retencion_Multiple_Documentos_ValorAplicado_Info();
                
                EntitiesCuentas_x_Cobrar CXC = new EntitiesCuentas_x_Cobrar();
                var select_det_cobro = from A in CXC.cxc_retencion_Multiple_Documentos_ValorAplicado
                                       where A.IdEmpresa == IdEmpresa
                                       && A.IdMultir == idMulti
                                       && A.IdCobro == idcobro
                                       select A
                                      ;
                foreach (var item in select_det_cobro)
                {
                    
                    dat.IdEmpresa = item.IdEmpresa;
                    dat.IdEmpresa = item.IdEmpresa;
                    dat.IdMultir = item.IdMultir;
                    dat.IdCobro = item.IdCobro;
                    dat.Secuencia = item.Secuencia;
                    dat.IdEmpresa_cbteVta = item.IdEmpresa_cbteVta;
                    dat.IdSucursal_cbteVta = item.IdSucursal_cbteVta;
                    dat.IdBodega_cbteVta = item.IdBodega_cbteVta;
                    dat.IdCbteVta_cbteVta = Convert.ToDecimal(item.IdCbteVta_cbteVta);
                    dat.IdTipoDoc_cbteVta = item.IdTipoDoc_cbteVta;
                  
                }
                return (dat);

            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.InnerException.ToString());
            }

        }

        public List<cxc_retencion_Multiple_Documentos_ValorAplicado_Info> Get_List_Retencion_x_documento(int IdEmpresa, int IdMulti)
        {
            try
            {
                List<cxc_retencion_Multiple_Documentos_ValorAplicado_Info> Lista = new List<cxc_retencion_Multiple_Documentos_ValorAplicado_Info>();

                using (EntitiesCuentas_x_Cobrar Context = new EntitiesCuentas_x_Cobrar())
                {
                    var lst = from q in Context.cxc_retencion_Multiple_Documentos_ValorAplicado
                              join c in Context.cxc_retencion_Multiple
                              on new { q.IdEmpresa, q.IdMultir } equals new { c.IdEmpresa, c.IdMultir }
                              where IdEmpresa == q.IdEmpresa
                              && IdMulti == q.IdMultir
                              //&& c.Estado == "A"
                              group q by new { q.IdEmpresa, q.IdMultir, q.IdEmpresa_cbteVta, q.IdBodega_cbteVta, q.IdSucursal_cbteVta, q.IdCbteVta_cbteVta }
                                  into grouping
                              let count = grouping.Count()
                              select new
                                  {
                                      grouping.Key.IdEmpresa,
                                      grouping.Key.IdMultir,
                                      grouping.Key.IdEmpresa_cbteVta,
                                      grouping.Key.IdBodega_cbteVta,
                                      grouping.Key.IdSucursal_cbteVta,
                                      grouping.Key.IdCbteVta_cbteVta
                                  };
                    foreach (var item in lst)
                    {
                        cxc_retencion_Multiple_Documentos_ValorAplicado_Info info = new cxc_retencion_Multiple_Documentos_ValorAplicado_Info();
                        info.IdEmpresa = item.IdEmpresa;
                        info.IdMultir = item.IdMultir;
                        info.IdEmpresa_cbteVta = item.IdEmpresa_cbteVta;
                        info.IdSucursal_cbteVta = item.IdSucursal_cbteVta;
                        info.IdBodega_cbteVta = item.IdBodega_cbteVta;
                        info.IdCbteVta_cbteVta = item.IdCbteVta_cbteVta;
                        Lista.Add(info);
                    }
                }

                return Lista;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.InnerException.ToString());
            }
        }
    }
}
