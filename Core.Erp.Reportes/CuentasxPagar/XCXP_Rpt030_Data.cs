using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Data.General;
using Core.Erp.Info.General;
using Core.Erp.Business.General;
using Core.Erp.Info.General;

namespace Core.Erp.Reportes.CuentasxPagar
{
    public class XCXP_Rpt030_Data
    {

        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;

        public List<XCXP_Rpt030_Info> Get_List_Data(int IdEmpresa, DateTime FechaIni, DateTime FechaFin, bool x_Fecha_Emision, ref string mensaje)
        {
            tb_Empresa_Data dataEmp = new tb_Empresa_Data();
            tb_Empresa_Info infoEmp = new tb_Empresa_Info();


            List<XCXP_Rpt030_Info> listadatos = new List<XCXP_Rpt030_Info>();
            try
            {               
                using (EntitiesCXP_General OEnti = new EntitiesCXP_General())
                {
                    IQueryable<vwCXP_Rpt030> select;

                    if (x_Fecha_Emision == true)
                    {
                        select = from q in OEnti.vwCXP_Rpt030
                                 where q.IdEmpresa == IdEmpresa
                                 && FechaIni <= q.FechaEmision && q.FechaEmision <= FechaFin
                                 select q;
                    }
                    else
                    {
                        select = from q in OEnti.vwCXP_Rpt030
                                 where q.IdEmpresa == IdEmpresa
                                 && FechaIni <= q.co_FechaContabilizacion && q.co_FechaContabilizacion <= FechaFin
                                 select q;
                    }

                    switch (param.IdCliente_Ven_x_Default)
                    {
                        case Cl_Enumeradores.eCliente_Vzen.GRAFINPRENT:                           
                            //mostramos solo las facturas de proveedor
                            select = select.Where(q => q.Codigo == "FACT" || q.Codigo == "NTVTA");
                            break;                        
                    }

                    infoEmp = dataEmp.Get_Info_Empresa(IdEmpresa);
                    foreach (var item in select)
                    {
                        XCXP_Rpt030_Info info = new XCXP_Rpt030_Info();
                        info.IdEmpresa = item.IdEmpresa;
                        info.IdTipoCbte_Ogiro = item.IdTipoCbte_Ogiro;
                        info.IdCbteCble_Ogiro = item.IdCbteCble_Ogiro;
                        info.pr_nombre = item.pr_nombre;
                        info.NumDocumento = item.NumDocumento; //+"/" +item.IdCbteCble_Ogiro ;
                        info.co_observacion = item.co_observacion;
                        info.FechaEmision = item.FechaEmision;
                        info.FechaRegistro = item.FechaRegistro;
                        info.co_Por_iva = item.co_Por_iva;
                        info.co_valoriva = item.co_valoriva;
                        info.co_subtotal_iva = item.co_subtotal_iva;
                        info.co_subtotal_siniva = item.co_subtotal_siniva;
                        info.co_baseImponible = item.co_baseImponible;
                        info.co_total = item.co_total;
                        info.co_vaCoa = item.co_vaCoa;
                        info.IdIden_credito = item.IdIden_credito;
                        info.Codigo = item.Codigo;
                        info.codigoSRI = item.codigoSRI;
                        info.co_descripcion = item.co_descripcion;
                        info.TipoServicio = item.TipoServicio;
                        info.em_Nombre = infoEmp.em_nombre;
                        info.co_FechaContabilizacion = item.co_FechaContabilizacion;

                        info.IdOrden_giro_Tipo = item.IdOrden_giro_Tipo;
                        info.Descripcion = item.Descripcion;
                        listadatos.Add(info);
                    }
                }

                return listadatos;
            }
            catch (Exception ex)
            {
                return new List<XCXP_Rpt030_Info>(); ;
            }
        }

        public List<XCXP_Rpt030_Info> Get_List_Data_Tipo(int IdEmpresa, DateTime FechaIni, DateTime FechaFin, bool x_Fecha_Emision, int Codigotipo,ref string mensaje)
        {
            tb_Empresa_Data dataEmp = new tb_Empresa_Data();
            tb_Empresa_Info infoEmp = new tb_Empresa_Info();


            List<XCXP_Rpt030_Info> listadatos = new List<XCXP_Rpt030_Info>();
            try
            {
                using (EntitiesCXP_General OEnti = new EntitiesCXP_General())
                {
                    IQueryable<vwCXP_Rpt030> select;

                    if (x_Fecha_Emision == true)
                    {
                        select = from q in OEnti.vwCXP_Rpt030
                                 where q.IdEmpresa == IdEmpresa
                                 && FechaIni <= q.FechaEmision && q.FechaEmision <= FechaFin
                                 && q.IdIden_credito == Codigotipo
                                 select q;
                    }
                    else
                    {
                        select = from q in OEnti.vwCXP_Rpt030
                                 where q.IdEmpresa == IdEmpresa
                                 && FechaIni <= q.co_FechaContabilizacion && q.co_FechaContabilizacion <= FechaFin
                                 && q.IdIden_credito == Codigotipo
                                 select q;
                    }

                    infoEmp = dataEmp.Get_Info_Empresa(IdEmpresa);
                    foreach (var item in select)
                    {
                        XCXP_Rpt030_Info info = new XCXP_Rpt030_Info();
                        info.IdEmpresa = item.IdEmpresa;
                        info.IdTipoCbte_Ogiro = item.IdTipoCbte_Ogiro;
                        info.IdCbteCble_Ogiro = item.IdCbteCble_Ogiro;
                        info.pr_nombre = item.pr_nombre;
                        info.NumDocumento = item.NumDocumento; //+"/" +item.IdCbteCble_Ogiro ;
                        info.co_observacion = item.co_observacion;
                        info.FechaEmision = item.FechaEmision;
                        info.FechaRegistro = item.FechaRegistro;
                        info.co_Por_iva = item.co_Por_iva;
                        info.co_valoriva = item.co_valoriva;
                        info.co_subtotal_iva = item.co_subtotal_iva;
                        info.co_subtotal_siniva = item.co_subtotal_siniva;
                        info.co_baseImponible = item.co_baseImponible;
                        info.co_total = item.co_total;
                        info.co_vaCoa = item.co_vaCoa;
                        info.IdIden_credito = item.IdIden_credito;
                        info.Codigo = item.Codigo;
                        info.codigoSRI = item.codigoSRI;
                        info.co_descripcion = item.co_descripcion;
                        info.TipoServicio = item.TipoServicio;
                        info.em_Nombre = infoEmp.em_nombre;
                        info.co_FechaContabilizacion = item.co_FechaContabilizacion;

                        info.IdOrden_giro_Tipo = item.IdOrden_giro_Tipo;
                        info.Descripcion = item.Descripcion;
                        listadatos.Add(info);
                    }
                }

                return listadatos;
            }
            catch (Exception ex)
            {
                return new List<XCXP_Rpt030_Info>(); ;
            }
        }

        public List<XCXP_Rpt030_Info> Get_List_Data_Totales(int IdEmpresa, DateTime FechaIni, DateTime FechaFin, bool x_Fecha_Emision, ref List<XCXP_Rpt030_Info_Resumen> list_Resumen_ret, ref string mensaje)
        {
            tb_Empresa_Data dataEmp = new tb_Empresa_Data();
            tb_Empresa_Info infoEmp = new tb_Empresa_Info();


            List<XCXP_Rpt030_Info> listadatos = new List<XCXP_Rpt030_Info>();
            try
            {
                using (EntitiesCXP_General OEnti = new EntitiesCXP_General())
                {
                    IQueryable<vwCXP_Rpt030> select;

                    if (x_Fecha_Emision == true)
                    {
                        select = from q in OEnti.vwCXP_Rpt030
                                 where q.IdEmpresa == IdEmpresa
                                 && FechaIni <= q.FechaEmision && q.FechaEmision <= FechaFin
                                 select q;
                    }
                    else
                    {
                        select = from q in OEnti.vwCXP_Rpt030
                                 where q.IdEmpresa == IdEmpresa
                                 && FechaIni <= q.co_FechaContabilizacion && q.co_FechaContabilizacion <= FechaFin
                                 select q;
                    }

                    infoEmp = dataEmp.Get_Info_Empresa(IdEmpresa);
                    foreach (var item in select)
                    {
                        XCXP_Rpt030_Info info = new XCXP_Rpt030_Info();
                        info.IdEmpresa = item.IdEmpresa;
                        info.IdTipoCbte_Ogiro = item.IdTipoCbte_Ogiro;
                        info.IdCbteCble_Ogiro = item.IdCbteCble_Ogiro;
                        info.pr_nombre = item.pr_nombre;
                        info.NumDocumento = item.NumDocumento; //+"/" +item.IdCbteCble_Ogiro ;
                        info.co_observacion = item.co_observacion;
                        info.FechaEmision = item.FechaEmision;
                        info.FechaRegistro = item.FechaRegistro;
                        info.co_Por_iva = item.co_Por_iva;
                        info.co_valoriva = item.co_valoriva;
                        info.co_subtotal_iva = item.co_subtotal_iva;
                        info.co_subtotal_siniva = item.co_subtotal_siniva;
                        info.co_baseImponible = item.co_baseImponible;
                        info.co_total = item.co_total;
                        info.co_vaCoa = item.co_vaCoa;
                        info.IdIden_credito = item.IdIden_credito;
                        info.Codigo = item.Codigo;
                        info.codigoSRI = item.codigoSRI;
                        info.co_descripcion = item.co_descripcion;
                        info.TipoServicio = item.TipoServicio;
                        info.em_Nombre = infoEmp.em_nombre;
                        info.co_FechaContabilizacion = item.co_FechaContabilizacion;

                        info.IdOrden_giro_Tipo = item.IdOrden_giro_Tipo;
                        info.Descripcion = item.Descripcion;
                        listadatos.Add(info);
                    }
                }


                list_Resumen_ret = new List<XCXP_Rpt030_Info_Resumen>();

                var TdebitosxCta = from Cb in listadatos
                                   group Cb by new { Cb.Descripcion }
                                       into grouping
                                       select new { grouping.Key, subtotal0 = grouping.Sum(p => p.co_subtotal_siniva), subtotal12 = grouping.Sum(p => p.co_subtotal_iva), iva = grouping.Sum(p => p.co_valoriva), total = grouping.Sum(p => p.co_total) };

                foreach (var item in TdebitosxCta)
                {
                    XCXP_Rpt030_Info_Resumen InfoR = new XCXP_Rpt030_Info_Resumen();
                    string desc;
                    desc = item.Key.Descripcion;
                    if (desc == "Nota de crédito")
                    {
                        InfoR.Descripcion = item.Key.Descripcion;
                        InfoR.co_subtotal_siniva = (item.subtotal0 * -1);
                        InfoR.co_subtotal_iva = (item.subtotal12 * -1);
                        InfoR.co_valoriva = (item.iva * -1);
                        InfoR.co_total = (item.total * -1);
                        list_Resumen_ret.Add(InfoR);
                    }
                    else 
                    {
                        InfoR.Descripcion = item.Key.Descripcion;
                        InfoR.co_subtotal_siniva = item.subtotal0;
                        InfoR.co_subtotal_iva = item.subtotal12;
                        InfoR.co_valoriva = item.iva;
                        InfoR.co_total = item.total;
                        list_Resumen_ret.Add(InfoR);
                    }
                    desc = "";
                }


                return listadatos;
            }
            catch (Exception ex)
            {
                return new List<XCXP_Rpt030_Info>(); ;
            }
        }
    }
}
