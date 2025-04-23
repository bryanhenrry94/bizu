using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bizu.Domain.General;
using Bizu.Application.General;

namespace Bizu.Reports.CuentasxPagar
{
    public class XCXP_Rpt039_Data
    {
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        public List<XCXP_Rpt039_Info> consultar_data
        (int IdEmpresa, Decimal IdProveedor , DateTime co_fechaOg_Ini, DateTime co_fechaOg_Fin, ref String mensaje)
        {
            try
            {
                List<XCXP_Rpt039_Info> listadedatos = new List<XCXP_Rpt039_Info>();
                tb_Empresa_Info Cbt = new tb_Empresa_Info();

                Cbt = param.InfoEmpresa;

                DateTime FechaIni = Convert.ToDateTime(co_fechaOg_Ini.ToShortDateString());
                DateTime FechaFin = Convert.ToDateTime(co_fechaOg_Fin.ToShortDateString());

                decimal IdProveedorIni = 0;
                decimal IdProveedorFin = 0;

                if (IdProveedor == 0)
                {
                    IdProveedorIni = 1;
                    IdProveedorFin = 9999999999;
                }
                else
                {
                    IdProveedorIni = IdProveedor;
                    IdProveedorFin = IdProveedor;
                }

                EntitiesCXP_General Estactaprovee = new EntitiesCXP_General();

                string query = "select * from vwCXP_Rpt039 where IdEmpresa = " + IdEmpresa + " and IdProveedor >=" + IdProveedorIni + " and IdProveedor <=" + IdProveedorFin + " and co_fechaOg >=" +"'"+ FechaIni +"'"+ " and co_fechaOg <=" +"'"+ FechaFin +"'";
                var sql = Estactaprovee.Database.SqlQuery<XCXP_Rpt039_Info>(query);

                foreach (var item in sql)
                {

                    XCXP_Rpt039_Info itemInfo = new XCXP_Rpt039_Info();
                    //if (item.IdCbteCble_Ogiro == 286)
                    //{
                    //}
                    if (listadedatos.Count(q => q.IdEmpresa == item.IdEmpresa && q.IdCbteCble_Ogiro == item.IdCbteCble_Ogiro) > 0)
                    {
                        item.co_subtotal = 0;
                        item.co_valoriva = 0;
                        item.co_total = 0;
                    }

                    itemInfo.IdEmpresa = item.IdEmpresa;
                    itemInfo.IdCbteCble_Ogiro = item.IdCbteCble_Ogiro;
                    itemInfo.IdProveedor = item.IdProveedor;
                    itemInfo.pr_nombre = item.pr_nombre;
                    itemInfo.co_factura = item.co_serie + "-" + item.co_factura;
                    itemInfo.co_fechaOg = item.co_fechaOg;
                    itemInfo.co_FechaFactura = item.co_FechaFactura;
                    itemInfo.co_subtotal = item.co_subtotal;
                    itemInfo.co_valoriva = item.co_valoriva;
                    itemInfo.co_total = item.co_total;
                    itemInfo.fac_estado = item.fac_estado;

                    itemInfo.IdOrdenCompra = item.IdOrdenCompra;
                    itemInfo.oc_fecha = item.oc_fecha;
                    itemInfo.oc_estado = item.oc_estado;
                    itemInfo.oc_subtot = item.oc_subtot;
                    itemInfo.oc_iva = item.oc_iva;
                    itemInfo.oc_total = item.oc_total;

                    listadedatos.Add(itemInfo);
                }

                
                return listadedatos;
            }
            catch (Exception ex)
            {

                return new List<XCXP_Rpt039_Info>();
            }
        }

    
    
    }
}
