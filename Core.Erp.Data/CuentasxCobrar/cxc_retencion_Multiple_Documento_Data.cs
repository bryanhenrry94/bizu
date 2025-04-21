using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Info.CuentasxCobrar;
using Core.Erp.Data.General;
using Core.Erp.Info.General;
using System.Data.Entity.Validation;

namespace Core.Erp.Data.CuentasxCobrar
{
    public class cxc_retencion_Multiple_Documento_Data
    {
        string mensaje = "";

        public Boolean GuardarDB(List<cxc_retencion_Multiple_Documento_Info> lista)
        {
            try
            {
                int secuencia = 0;
                

                if (lista != null && lista.Count() > 0)
                {

                    using (EntitiesCuentas_x_Cobrar Contex = new EntitiesCuentas_x_Cobrar())
                    {
                        var obj = lista.First();

                        var lst = from q in Contex.cxc_retencion_Multiple_Documento
                                  join c in Contex.cxc_retencion_Multiple
                                  on new { q.IdEmpresa, q.IdMultir } equals new { c.IdEmpresa, c.IdMultir }
                                  where obj.IdEmpresa == q.IdEmpresa
                                  && obj.IdMultir == q.IdMultir
                                  //&& c.Estado == "A"
                                  group q by new { q.IdEmpresa, q.IdBodega_cbteVta, q.IdCbteVta_cbteVta };
                      
                        if (lst.Count() > 0)
                        {
                            secuencia = lst.Count();
                        }

                        foreach (var item in lista)
                        {
                                var address = new cxc_retencion_Multiple_Documento();

                                item.Secuencia = secuencia + 1;

                                address.IdEmpresa = item.IdEmpresa;
                                address.IdMultir = item.IdMultir;
                                address.Secuencia = item.Secuencia;
                                address.IdEmpresa_cbteVta = item.IdEmpresa_cbteVta;
                                address.IdSucursal_cbteVta = item.IdSucursal_cbteVta;
                                address.IdBodega_cbteVta = item.IdBodega_cbteVta;
                                address.IdCbteVta_cbteVta = item.IdCbteVta_cbteVta;
                                address.IdTipoDoc_cbteVta = item.IdTipoDoc_cbteVta;
                                

                                Contex.cxc_retencion_Multiple_Documento.Add(address);

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

        public Boolean ModificarDetalleCobro(List<cxc_retencion_Multiple_Documento_Info> lista)
        {
            try
            {
                try
                {
                    List<cxc_retencion_Multiple_Documento_Info> listaAux = new List<cxc_retencion_Multiple_Documento_Info>();
                    cxc_retencion_Multiple_Documento_Info i = new cxc_retencion_Multiple_Documento_Info();
                    i = lista.First();
                    listaAux = Get_List_Retencion_detalle(i.IdEmpresa, i.IdMultir, Convert.ToDecimal(i.IdCbteVta_cbteVta));

                    using (EntitiesCuentas_x_Cobrar context = new EntitiesCuentas_x_Cobrar())
                    {
                        foreach (var item in listaAux)
                        {
                            var contact = context.cxc_retencion_Multiple_Documento.First(cot => cot.IdEmpresa == item.IdEmpresa && cot.IdMultir == item.IdMultir && cot.IdCbteVta_cbteVta == item.IdCbteVta_cbteVta);
                            context.cxc_retencion_Multiple_Documento.Remove(contact);
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
                        var address = new cxc_retencion_Multiple_Documento();
                        secuencia = secuencia + 1;
                        address.IdEmpresa = item.IdEmpresa;
                        address.IdMultir = item.IdMultir;
                        address.Secuencia = secuencia;
                        address.IdEmpresa_cbteVta = item.IdEmpresa_cbteVta;
                        address.IdSucursal_cbteVta = item.IdSucursal_cbteVta;
                        address.IdBodega_cbteVta = item.IdBodega_cbteVta;
                        address.IdCbteVta_cbteVta = item.IdCbteVta_cbteVta;
                        address.IdTipoDoc_cbteVta = item.IdTipoDoc_cbteVta;      

                        Contex.cxc_retencion_Multiple_Documento.Add(address);
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

        public List<cxc_retencion_Multiple_Documento_Info> Get_List_Retencion_detalle(int IdEmpresa, int idMulti, decimal IdCbteVta_cbteVta)
        {
            try
            {
                List<cxc_retencion_Multiple_Documento_Info> lM = new List<cxc_retencion_Multiple_Documento_Info>();
                EntitiesCuentas_x_Cobrar CXC = new EntitiesCuentas_x_Cobrar();
                var select_det_cobro = from A in CXC.cxc_retencion_Multiple_Documento
                                       where A.IdEmpresa == IdEmpresa
                                       && A.IdMultir == idMulti
                                       && A.IdCbteVta_cbteVta == IdCbteVta_cbteVta
                                       select A
                                      ;
                foreach (var item in select_det_cobro)
                {
                    cxc_retencion_Multiple_Documento_Info dat = new cxc_retencion_Multiple_Documento_Info();
                    dat.IdEmpresa = item.IdEmpresa;
                    dat.IdEmpresa = item.IdEmpresa;
                    dat.IdMultir = item.IdMultir;
                    dat.Secuencia = item.Secuencia;
                    dat.IdEmpresa_cbteVta = item.IdEmpresa_cbteVta;
                    dat.IdSucursal_cbteVta = item.IdSucursal_cbteVta;
                    dat.IdBodega_cbteVta = item.IdBodega_cbteVta;
                    dat.IdCbteVta_cbteVta = item.IdCbteVta_cbteVta;
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

        public List<cxc_retencion_Multiple_Documento_Info> Get_List_Retencion_x_documento(int IdEmpresa, int IdMulti)
        {
            try
            {
                List<cxc_retencion_Multiple_Documento_Info> Lista = new List<cxc_retencion_Multiple_Documento_Info>();

                using (EntitiesCuentas_x_Cobrar Context = new EntitiesCuentas_x_Cobrar())
                {
                    var lst = from q in Context.cxc_retencion_Multiple_Documento
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
                        cxc_retencion_Multiple_Documento_Info info = new cxc_retencion_Multiple_Documento_Info();
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

        public Boolean ConsultarDocumento(List<cxc_retencion_Multiple_Documento_Info> lista)
        {
            try
            {
                int secuencia = 0;
                Boolean estado;
                estado = false;

                if (lista != null && lista.Count() > 0)
                {
                    using (EntitiesCuentas_x_Cobrar Contex = new EntitiesCuentas_x_Cobrar())
                    {
                        var obj = lista.First();

                        var lst = from q in Contex.cxc_retencion_Multiple_Documento
                                  where q.IdMultir == obj.IdMultir
                                  && q.IdEmpresa_cbteVta == obj.IdEmpresa_cbteVta
                                  && q.IdSucursal_cbteVta == obj.IdSucursal_cbteVta
                                  && q.IdBodega_cbteVta == obj.IdBodega_cbteVta
                                  && q.IdCbteVta_cbteVta == obj.IdCbteVta_cbteVta
                                  select q;

                        if (lst.Count() > 0)
                        {
                            estado = true;
                        }
                       
                    }
                }
                return estado;
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
