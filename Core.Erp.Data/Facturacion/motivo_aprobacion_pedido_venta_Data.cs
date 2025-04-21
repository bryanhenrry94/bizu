using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.Validation;
using Core.Erp.Info.General;
using Core.Erp.Info.Facturacion;
using Core.Erp.Data.General;

namespace Core.Erp.Data.Facturacion
{
    public class motivo_aprobacion_pedido_venta_Data
    {
        string mensaje = "";

        public Boolean GrabarDB(motivo_aprobacion_pedido_venta_Info info)
        {
            try
            {
                using (EntitiesFacturacion context = new EntitiesFacturacion())
                {
                    fa_motivo_aprobacion_Pedido_Venta contact = new fa_motivo_aprobacion_Pedido_Venta();
                    contact.IdEmpresa = info.IdEmpresa;
                    contact.IdMotivo = info.IdMotivo = Convert.ToInt32(GetId(info.IdEmpresa));
                    contact.IdPedido = info.IdPedido;
                    contact.IdCliente = info.IdCliente;
                    contact.MotivoAprobacion = info.MotivoAprobacion;
                    contact.vt_fecha = DateTime.Now;
                    contact.IdUsuario = (info.IdUsuario != null) ? info.IdUsuario : "";

                    context.fa_motivo_aprobacion_Pedido_Venta.Add(contact);
                    context.SaveChanges();

                }
                return true;
            }

            catch (Exception ex)
            {
                string arreglo = ToString();
                string strMensaje = "";
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                strMensaje = ex.ToString() + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref strMensaje);
                throw new Exception(ex.ToString());
            }
        }

        public decimal GetId(int IdEmpresa)
        {
            try
            {
                decimal Id;
                EntitiesFacturacion OEPCliente = new EntitiesFacturacion();
                var select = from q in OEPCliente.fa_motivo_aprobacion_Pedido_Venta
                             where q.IdEmpresa == IdEmpresa
                             select q;

                if (select.ToList().Count < 1)
                {
                    Id = 1;
                }
                else
                {
                    var select_motivo = (from q in OEPCliente.fa_motivo_aprobacion_Pedido_Venta
                                          where q.IdEmpresa == IdEmpresa
                                          select q.IdMotivo).Max();
                    Id = Convert.ToInt32(select_motivo.ToString()) + 1;
                }
                return Id;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = ex.ToString();
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.ToString());
            }
        }

        public List<motivo_aprobacion_pedido_venta_Info> Get_Info_Motivo(int IdEmpresa, decimal IdCliente)
        {
            try
            {
                List<motivo_aprobacion_pedido_venta_Info> ListMotivo = new List<motivo_aprobacion_pedido_venta_Info>();

                using (EntitiesFacturacion entity = new EntitiesFacturacion())
                {
                    var select_tipo_nota = from A in entity.vwfa_motivo_aprobacion_Pedido_Venta
                                           where A.IdEmpresa == IdEmpresa
                                           && A.IdCliente == IdCliente
                                           select A;

                    foreach (var item in select_tipo_nota)
                    {
                        motivo_aprobacion_pedido_venta_Info info = new motivo_aprobacion_pedido_venta_Info();

                        info.IdEmpresa = item.IdEmpresa;
                        info.IdMotivo = item.IdMotivo;
                        info.IdPedido = item.IdPedido;
                        info.IdCliente = item.IdCliente;
                        info.pe_nombreCompleto = item.pe_nombreCompleto;
                        info.IdUsuario = item.IdUsuario;
                        info.NombreUsuario = item.NombreUsuario;
                        info.vt_fecha = item.vt_fecha;
                        info.MotivoAprobacion = item.MotivoAprobacion;

                        ListMotivo.Add(info);
                    }
                }
                return ListMotivo;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = ex.ToString();
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.ToString());
            }
        }

        public motivo_aprobacion_pedido_venta_Info Get_Info(int IdEmpresa, decimal IdMotivo)
        {
            try
            {
                motivo_aprobacion_pedido_venta_Info info = new motivo_aprobacion_pedido_venta_Info();

                using (EntitiesFacturacion entity = new EntitiesFacturacion())
                {
                    var select_tipo_nota = from A in entity.vwfa_motivo_aprobacion_Pedido_Venta
                                           where A.IdEmpresa == IdEmpresa
                                           && A.IdCliente == IdMotivo
                                           select A;

                    foreach (var item in select_tipo_nota)
                    {
                        

                        info.IdEmpresa = item.IdEmpresa;
                        info.IdMotivo = item.IdMotivo;
                        info.IdPedido = item.IdPedido;
                        info.IdCliente = item.IdCliente;
                        info.pe_nombreCompleto = item.pe_nombreCompleto;
                        info.IdUsuario = item.IdUsuario;
                        info.NombreUsuario = item.NombreUsuario;
                        info.vt_fecha = item.vt_fecha;
                        info.MotivoAprobacion = item.MotivoAprobacion;

                    }
                }
                return info;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = ex.ToString();
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.ToString());
            }
        }
    }
}
