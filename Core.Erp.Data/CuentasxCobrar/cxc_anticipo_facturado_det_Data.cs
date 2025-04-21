using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Info.CuentasxCobrar;

namespace Core.Erp.Data.CuentasxCobrar
{
    public class cxc_anticipo_facturado_det_Data
    {
        public List<cxc_anticipo_facturado_det_Info> Get_Detalle(int IdEmpresa, decimal IdAnticipo)
        {
            List<cxc_anticipo_facturado_det_Info> Lista = new List<cxc_anticipo_facturado_det_Info>();

            try
            {
                using (EntitiesCuentas_x_Cobrar Context = new EntitiesCuentas_x_Cobrar())
                {
                    var query = from q in Context.cxc_anticipo_facturado_det
                                where q.IdEmpresa == IdEmpresa
                                && q.IdAnticipo == IdAnticipo
                                select q;

                    foreach (var item in query)
                    {
                        cxc_anticipo_facturado_det_Info Info = new cxc_anticipo_facturado_det_Info();
                        Info.IdEmpresa = item.IdEmpresa;
                        Info.IdSucursal = item.IdSucursal;
                        Info.IdAnticipo = item.IdAnticipo;
                        Info.Secuencia = item.Secuencia;
                        Info.Detalle = item.Detalle;
                        Info.Fecha = item.Fecha;
                        Info.Valor = item.Valor;
                        Info.IdEmpresa_ct = item.IdEmpresa_ct;
                        Info.IdTipoCbte_ct = item.IdTipoCbte_ct;
                        Info.IdCbteCble_ct = item.IdCbteCble_ct;
                        Info.IdCtaCble = item.IdCtaCble;

                        Lista.Add(Info);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return Lista;
        }

        public bool GrabarBD(List<cxc_anticipo_facturado_det_Info> List_Info, string mensaje)
        {
            try
            {
                using (EntitiesCuentas_x_Cobrar Context = new EntitiesCuentas_x_Cobrar())
                {
                    foreach (var item in List_Info)
                    {
                        cxc_anticipo_facturado_det Info = new cxc_anticipo_facturado_det();
                        Info.IdEmpresa = item.IdEmpresa;
                        Info.IdSucursal = item.IdSucursal;
                        Info.IdAnticipo = item.IdAnticipo;
                        Info.Secuencia = item.Secuencia;
                        Info.Detalle = item.Detalle;
                        Info.Fecha = item.Fecha;
                        Info.Valor = item.Valor;
                        Info.IdEmpresa_ct = item.IdEmpresa_ct;
                        Info.IdTipoCbte_ct = item.IdTipoCbte_ct;
                        Info.IdCbteCble_ct = item.IdCbteCble_ct;
                        Info.IdCtaCble = item.IdCtaCble;

                        Context.cxc_anticipo_facturado_det.Add(Info);
                    }

                    Context.SaveChanges();
                }

                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public bool GrabarBD(cxc_anticipo_facturado_det_Info Info, string mensaje)
        {
            try
            {
                using (EntitiesCuentas_x_Cobrar Context = new EntitiesCuentas_x_Cobrar())
                {
                    cxc_anticipo_facturado_det Address = new cxc_anticipo_facturado_det();
                    Address.IdEmpresa = Info.IdEmpresa;
                    Address.IdSucursal = Info.IdSucursal;
                    Address.IdAnticipo = Info.IdAnticipo;
                    Address.Secuencia = Get_Secuencia(Info.IdEmpresa, Info.IdAnticipo);
                    Address.Detalle = Info.Detalle;
                    Address.Fecha = Info.Fecha;
                    Address.Valor = Info.Valor;
                    Address.IdEmpresa_ct = Info.IdEmpresa_ct;
                    Address.IdTipoCbte_ct = Info.IdTipoCbte_ct;
                    Address.IdCbteCble_ct = Info.IdCbteCble_ct;
                    Address.IdCtaCble = Info.IdCtaCble;

                    Context.cxc_anticipo_facturado_det.Add(Address);
                    Context.SaveChanges();
                }

                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public bool ModificarBD(cxc_anticipo_facturado_det_Info Info, string mensaje)
        {
            try
            {
                using (EntitiesCuentas_x_Cobrar Context = new EntitiesCuentas_x_Cobrar())
                {
                    cxc_anticipo_facturado_det Address = (from q in Context.cxc_anticipo_facturado_det
                            where q.IdEmpresa == Info.IdEmpresa
                            && q.IdAnticipo == Info.IdAnticipo
                            && q.Secuencia == Info.Secuencia
                            select q).First();

                    if (Address != null)
                    {
                        Address.Detalle = Info.Detalle;
                        Address.Fecha = Info.Fecha;
                        Address.Valor = Info.Valor;
                        Address.IdEmpresa_ct = Info.IdEmpresa_ct;
                        Address.IdTipoCbte_ct = Info.IdTipoCbte_ct;
                        Address.IdCbteCble_ct = Info.IdCbteCble_ct;
                        Address.IdCtaCble = Info.IdCtaCble;

                        Context.SaveChanges();
                    }
                }

                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public bool ExisteBD(cxc_anticipo_facturado_det_Info Info, string mensaje)
        {
            try
            {
                EntitiesCuentas_x_Cobrar Context = new EntitiesCuentas_x_Cobrar();

                var query = from q in Context.cxc_anticipo_facturado_det
                            where q.IdEmpresa == Info.IdEmpresa
                            && q.IdAnticipo == Info.IdAnticipo
                            && q.Secuencia == Info.Secuencia
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

        private int Get_Secuencia(int IdEmpresa, decimal IdAnticipo)
        {
            try
            {
                int Secuencia = 0;

                using(EntitiesCuentas_x_Cobrar Context = new EntitiesCuentas_x_Cobrar())
                {
                    var query = from q in Context.cxc_anticipo_facturado_det
                                where q.IdEmpresa == IdEmpresa
                                && q.IdAnticipo == IdAnticipo
                                select q;

                    if (query.Count() > 0)
                    {
                        Secuencia = (from q in Context.cxc_anticipo_facturado_det
                                    where q.IdEmpresa == IdEmpresa
                                    && q.IdAnticipo == IdAnticipo
                                    select q.Secuencia).Max() + 1; 
                    }
                    else
                    {
                        Secuencia = 1;
                    }
                }

                return Secuencia;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}