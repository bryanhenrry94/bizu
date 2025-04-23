using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bizu.Domain.CuentasxCobrar;
using Bizu.Infrastructure.General;
using Bizu.Domain.General;

namespace Bizu.Infrastructure.CuentasxCobrar
{
    public class cxc_anticipo_facturado_Data
    {
        public List<cxc_anticipo_facturado_Info> Get_List(int IdEmpresa, int IdSucursal, ref string mensaje)
        {
            try
            {
                List<cxc_anticipo_facturado_Info> Lst = new List<cxc_anticipo_facturado_Info>();
                List<cxc_anticipo_facturado_Info> Lista = new List<cxc_anticipo_facturado_Info>();

                using (EntitiesCuentas_x_Cobrar cxc = new EntitiesCuentas_x_Cobrar())
                {
                    var consultar = from q in cxc.vwcxc_anticipo_facturado
                                    where q.IdEmpresa == IdEmpresa
                                    && q.IdSucursal == IdSucursal
                                    select q;
                    foreach (var item in consultar)
                    {
                        cxc_anticipo_facturado_Info info = new cxc_anticipo_facturado_Info();
                        info.IdEmpresa = item.IdEmpresa;
                        info.IdSucursal = item.IdSucursal;
                        info.IdAnticipo = item.IdAnticipo;
                        info.IdCliente = item.IdCliente;
                        info.IdProyecto = Convert.ToInt32(item.IdProyecto);
                        info.IdOferta = Convert.ToInt32(item.IdOferta);
                        info.nom_cliente = item.nom_cliente;
                        info.IdCentroCosto = item.IdCentroCosto;
                        info.nom_centroCosto = item.nom_centroCosto;
                        info.Valor = item.Valor;
                        info.MontoAplicado = item.MontoAplicado;
                        info.Saldo = info.Valor - info.MontoAplicado;
                        info.Fecha = Convert.ToDateTime(item.Fecha);
                        info.Observacion = item.Observacion;
                        info.IdEmpresa_ct = item.IdEmpresa_ct;
                        info.IdTipoCbte_ct = item.IdTipoCbte_ct;
                        info.IdCbteCble_ct = item.IdCbteCble_ct;
                        info.IdEmpresa_CbteVta = item.IdEmpresa_CbteVta;
                        info.IdSucursal_CbteVta = item.IdSucursal_CbteVta;
                        info.IdBodega_CbteVta = item.IdBodega_CbteVta;
                        info.IdCbteVta = item.IdCbteVta;
                        info.Fecha_Transac = item.Fecha_Transac;
                        info.IdUsuario = item.IdUsuario;
                        info.IdUsuarioUltMod = item.IdUsuarioUltMod;
                        info.Fecha_UltMod = item.Fecha_UltMod;
                        info.IdUsuarioUltAnu = item.IdUsuarioUltAnu;
                        info.Fecha_UltAnu = item.Fecha_UltAnu;
                        info.MotiAnula = item.MotiAnula;
                        info.nom_pc = item.nom_pc;
                        info.ip = item.ip;
                        info.Estado = item.Estado;

                        Lst.Add(info);
                    }

                    Lista = new List<cxc_anticipo_facturado_Info>(Lst.OrderByDescending(d => d.IdAnticipo));
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

        public List<cxc_anticipo_facturado_Info> Get_List(int IdEmpresa, int IdSucursal, int IdTipoCbte, decimal IdCbteCble)
        {
            try
            {
                List<cxc_anticipo_facturado_Info> Lst = new List<cxc_anticipo_facturado_Info>();
                List<cxc_anticipo_facturado_Info> Lista = new List<cxc_anticipo_facturado_Info>();

                using (EntitiesCuentas_x_Cobrar cxc = new EntitiesCuentas_x_Cobrar())
                {
                    var consultar = from q in cxc.vwcxc_anticipo_facturado
                                    where q.IdEmpresa_ct == IdEmpresa
                                    && q.IdSucursal == IdSucursal
                                    && q.IdTipoCbte_ct == IdTipoCbte
                                    && q.IdCbteCble_ct == IdCbteCble
                                    select q;

                    foreach (var item in consultar)
                    {
                        cxc_anticipo_facturado_Info info = new cxc_anticipo_facturado_Info();
                        info.IdEmpresa = item.IdEmpresa;
                        info.IdSucursal = item.IdSucursal;
                        info.IdAnticipo = item.IdAnticipo;
                        info.IdCliente = item.IdCliente;
                        info.IdProyecto = Convert.ToInt32(item.IdProyecto);
                        info.IdOferta = Convert.ToInt32(item.IdOferta);
                        info.nom_cliente = item.nom_cliente;
                        info.IdCentroCosto = item.IdCentroCosto;
                        info.nom_centroCosto = item.nom_centroCosto;
                        info.Valor = item.Valor;
                        info.MontoAplicado = item.MontoAplicado;
                        info.Saldo = info.Valor - info.MontoAplicado;
                        info.Fecha = Convert.ToDateTime(item.Fecha);
                        info.Observacion = item.Observacion;
                        info.IdEmpresa_ct = item.IdEmpresa_ct;
                        info.IdTipoCbte_ct = item.IdTipoCbte_ct;
                        info.IdCbteCble_ct = item.IdCbteCble_ct;
                        info.IdEmpresa_CbteVta = item.IdEmpresa_CbteVta;
                        info.IdSucursal_CbteVta = item.IdSucursal_CbteVta;
                        info.IdBodega_CbteVta = item.IdBodega_CbteVta;
                        info.IdCbteVta = item.IdCbteVta;
                        info.Fecha_Transac = item.Fecha_Transac;
                        info.IdUsuario = item.IdUsuario;
                        info.IdUsuarioUltMod = item.IdUsuarioUltMod;
                        info.Fecha_UltMod = item.Fecha_UltMod;
                        info.IdUsuarioUltAnu = item.IdUsuarioUltAnu;
                        info.Fecha_UltAnu = item.Fecha_UltAnu;
                        info.MotiAnula = item.MotiAnula;
                        info.nom_pc = item.nom_pc;
                        info.ip = item.ip;
                        info.Estado = item.Estado;

                        Lst.Add(info);
                    }

                    Lista = new List<cxc_anticipo_facturado_Info>(Lst.OrderByDescending(d => d.IdAnticipo));
                }
                return Lista;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.InnerException.ToString());
            }
        }

        public List<cxc_anticipo_facturado_Info> Get_List(int IdEmpresa, int IdSucursal, DateTime FechaIni, DateTime FechaFin, ref string mensaje)
        {
            try
            {
                List<cxc_anticipo_facturado_Info> Lst = new List<cxc_anticipo_facturado_Info>();
                List<cxc_anticipo_facturado_Info> Lista = new List<cxc_anticipo_facturado_Info>();

                using (EntitiesCuentas_x_Cobrar cxc = new EntitiesCuentas_x_Cobrar())
                {
                    var consultar = from q in cxc.vwcxc_anticipo_facturado
                                    where q.IdEmpresa == IdEmpresa
                                    && q.IdSucursal == IdSucursal
                                    && q.Fecha >= FechaIni && q.Fecha <= FechaFin
                                    select q;
                    foreach (var item in consultar)
                    {
                        cxc_anticipo_facturado_Info info = new cxc_anticipo_facturado_Info();
                        info.IdEmpresa = item.IdEmpresa;
                        info.IdSucursal = item.IdSucursal;
                        info.IdAnticipo = item.IdAnticipo;
                        info.IdCliente = item.IdCliente;
                        info.IdProyecto = Convert.ToInt32(item.IdProyecto);
                        info.IdOferta = Convert.ToInt32(item.IdOferta);
                        info.nom_cliente = item.nom_cliente;
                        info.IdCentroCosto = item.IdCentroCosto;
                        info.nom_centroCosto = item.nom_centroCosto;
                        info.Valor = item.Valor;
                        info.MontoAplicado = item.MontoAplicado;
                        info.Saldo = info.Valor - info.MontoAplicado;
                        info.Fecha = Convert.ToDateTime(item.Fecha);
                        info.Observacion = item.Observacion;
                        info.IdEmpresa_ct = item.IdEmpresa_ct;
                        info.IdTipoCbte_ct = item.IdTipoCbte_ct;
                        info.IdCbteCble_ct = item.IdCbteCble_ct;
                        info.IdEmpresa_CbteVta = item.IdEmpresa_CbteVta;
                        info.IdSucursal_CbteVta = item.IdSucursal_CbteVta;
                        info.IdBodega_CbteVta = item.IdBodega_CbteVta;
                        info.IdCbteVta = item.IdCbteVta;
                        info.Fecha_Transac = item.Fecha_Transac;
                        info.IdUsuario = item.IdUsuario;
                        info.IdUsuarioUltMod = item.IdUsuarioUltMod;
                        info.Fecha_UltMod = item.Fecha_UltMod;
                        info.IdUsuarioUltAnu = item.IdUsuarioUltAnu;
                        info.Fecha_UltAnu = item.Fecha_UltAnu;
                        info.MotiAnula = item.MotiAnula;
                        info.nom_pc = item.nom_pc;
                        info.ip = item.ip;
                        info.Estado = item.Estado;

                        Lst.Add(info);
                    }
                    Lista = new List<cxc_anticipo_facturado_Info>(Lst.OrderByDescending(d => d.IdAnticipo));
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

        public Boolean ExisteAnticipoFacturado(int IdEmpresa, int IdSucursal, int IdProyecto, int IdOferta)
        {
            try
            {
                EntitiesCuentas_x_Cobrar context = new EntitiesCuentas_x_Cobrar();

                var query = from q in context.cxc_anticipo_facturado
                            where q.IdEmpresa == IdEmpresa
                            && q.IdSucursal == IdSucursal
                            && q.IdProyecto == IdProyecto
                            && q.IdOferta == IdOferta
                            select q;

                if (query.Count() > 0)
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Boolean GrabarDB(cxc_anticipo_facturado_Info Info, ref string mensaje)
        {
            try
            {
                using (EntitiesCuentas_x_Cobrar cxc = new EntitiesCuentas_x_Cobrar())
                {
                    cxc_anticipo_facturado Obj = new cxc_anticipo_facturado();
                    Obj.IdEmpresa = Info.IdEmpresa;
                    Obj.IdSucursal = Info.IdSucursal;
                    Info.IdAnticipo = GetId(Info.IdEmpresa, Info.IdSucursal);
                    Obj.IdAnticipo = Info.IdAnticipo;
                    Obj.IdCliente = Info.IdCliente;
                    Obj.IdProyecto = Info.IdProyecto;
                    Obj.IdOferta = Info.IdOferta;
                    Obj.IdCentroCosto = Info.IdCentroCosto;
                    Obj.Valor = Info.Valor;
                    Obj.Fecha = Info.Fecha;
                    Obj.Observacion = Info.Observacion;
                    Obj.IdEmpresa_ct = Info.IdEmpresa_ct;
                    Obj.IdTipoCbte_ct = Info.IdTipoCbte_ct;
                    Obj.IdCbteCble_ct = Info.IdCbteCble_ct;
                    Obj.IdEmpresa_CbteVta = Info.IdEmpresa_CbteVta;
                    Obj.IdSucursal_CbteVta = Info.IdSucursal_CbteVta;
                    Obj.IdBodega_CbteVta = Info.IdBodega_CbteVta;
                    Obj.IdCbteVta = Info.IdCbteVta;
                    Obj.Fecha_Transac = Info.Fecha_Transac;
                    Obj.IdUsuario = Info.IdUsuario;
                    Obj.IdUsuarioUltMod = Info.IdUsuarioUltMod;
                    Obj.Fecha_UltMod = Info.Fecha_UltMod;
                    Obj.IdUsuarioUltAnu = Info.IdUsuarioUltAnu;
                    Obj.Fecha_UltAnu = Info.Fecha_UltAnu;
                    Obj.MotiAnula = Info.MotiAnula;
                    Obj.nom_pc = Info.nom_pc;
                    Obj.ip = Info.ip;
                    Obj.Estado = Info.Estado;

                    cxc.cxc_anticipo_facturado.Add(Obj);
                    cxc.SaveChanges();
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

        public Boolean ModificarDB(cxc_anticipo_facturado_Info Info, ref string mensaje)
        {
            try
            {
                Boolean res = false;

                using (EntitiesCuentas_x_Cobrar cxc = new EntitiesCuentas_x_Cobrar())
                {
                    cxc_anticipo_facturado Obj = cxc.cxc_anticipo_facturado.FirstOrDefault(v => v.IdEmpresa == Info.IdEmpresa && v.IdSucursal == Info.IdSucursal && v.IdAnticipo == Info.IdAnticipo);

                    if (Obj != null)
                    {
                        Obj.IdCliente = Info.IdCliente;
                        Obj.IdProyecto = Info.IdProyecto;
                        Obj.IdOferta = Info.IdOferta;
                        Obj.IdCentroCosto = Info.IdCentroCosto;
                        Obj.Valor = Info.Valor;
                        Obj.Fecha = Info.Fecha;
                        Obj.Observacion = Info.Observacion;
                        Obj.IdEmpresa_ct = Info.IdEmpresa_ct;
                        Obj.IdTipoCbte_ct = Info.IdTipoCbte_ct;
                        Obj.IdCbteCble_ct = Info.IdCbteCble_ct;
                        Obj.IdEmpresa_CbteVta = Info.IdEmpresa_CbteVta;
                        Obj.IdSucursal_CbteVta = Info.IdSucursal_CbteVta;
                        Obj.IdBodega_CbteVta = Info.IdBodega_CbteVta;
                        Obj.IdCbteVta = Info.IdCbteVta;
                        Obj.Fecha_Transac = Info.Fecha_Transac;
                        Obj.IdUsuario = Info.IdUsuario;
                        Obj.IdUsuarioUltMod = Info.IdUsuarioUltMod;
                        Obj.Fecha_UltMod = Info.Fecha_UltMod;
                        Obj.IdUsuarioUltAnu = Info.IdUsuarioUltAnu;
                        Obj.Fecha_UltAnu = Info.Fecha_UltAnu;
                        Obj.MotiAnula = Info.MotiAnula;
                        Obj.nom_pc = Info.nom_pc;
                        Obj.ip = Info.ip;
                        Obj.Estado = Info.Estado;

                        cxc.SaveChanges();
                        res = true;
                    }
                }
                return res;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public Boolean AnularDB(cxc_anticipo_facturado_Info Info, ref string mensaje)
        {
            try
            {
                Boolean res = false;
                using (EntitiesCuentas_x_Cobrar cxc = new EntitiesCuentas_x_Cobrar())
                {
                    cxc_anticipo_facturado Obj = cxc.cxc_anticipo_facturado.FirstOrDefault(v => v.IdEmpresa == Info.IdEmpresa && v.IdSucursal == Info.IdSucursal && v.IdAnticipo == Info.IdAnticipo);

                    if (Obj != null)
                    {
                        Obj.IdUsuarioUltAnu = Info.IdUsuarioUltAnu;
                        Obj.Fecha_UltAnu = Info.Fecha_UltAnu;
                        Obj.MotiAnula = Info.MotiAnula;
                        Obj.nom_pc = Info.nom_pc;
                        Obj.ip = Info.ip;
                        Obj.Estado = Info.Estado;

                        cxc.SaveChanges();
                        res = true;
                    }
                }
                return res;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public decimal Existe(int IdCliente, ref string mensaje)
        {
            try
            {
                decimal numero = 0;

                using (EntitiesCuentas_x_Cobrar cxc = new EntitiesCuentas_x_Cobrar())
                {
                    var consu = from q in cxc.cxc_anticipo_facturado
                                where q.IdCliente == IdCliente
                                select q;
                    foreach (var item in consu)
                    {
                        numero = item.IdAnticipo;
                    }
                }

                return numero;
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

        public decimal GetId(int IdEmpresa, int IdSucursal)
        {
            try
            {
                decimal id = 0;

                using (EntitiesCuentas_x_Cobrar cxc = new EntitiesCuentas_x_Cobrar())
                {
                    var cons = from q in cxc.cxc_anticipo_facturado
                               where q.IdEmpresa == IdEmpresa
                               && q.IdSucursal == IdSucursal
                               select q;

                    if (cons.Count() > 0)
                    {
                        id = (from q in cxc.cxc_anticipo_facturado
                              where q.IdEmpresa == IdEmpresa
                              && q.IdSucursal == IdSucursal
                              select q.IdAnticipo).Max() + 1;
                    }
                    else
                    {
                        id = 1;
                    }
                }

                return id;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.InnerException.ToString());
            }
        }
    }
}