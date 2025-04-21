using System;
using System.Collections.Generic;
using System.Linq;
using Core.Erp.Info.General;
using Core.Erp.Data.General;

namespace Core.Erp.Reportes.Compras
{
    public class XCOMP_Rpt012_Data
    {
        string mensaje = "";

        public List<XCOMP_Rpt012_Info> Get_Data(int IdEmpresa, int IdSucursal, decimal IdOrdenCompra)
        {
            try
            {
                List<XCOMP_Rpt012_Info> ListData = new List<XCOMP_Rpt012_Info>();
                int num = 0;

                using (EntitiesCompra_reporte_Ge base_ = new EntitiesCompra_reporte_Ge())
                {
                    var q = from C in base_.vwCOMP_Rpt012
                            where C.IdEmpresa == IdEmpresa
                            && C.IdSucursal == IdSucursal
                            && C.IdOrdenCompra == IdOrdenCompra
                            select C;

                    foreach (var rpt in q)
                    {
                        num++;
                        XCOMP_Rpt012_Info item = new XCOMP_Rpt012_Info
                        {
                            IdEmpresa = rpt.IdEmpresa,
                            IdSucursal = rpt.IdSucursal,
                            IdOrdenCompra = rpt.IdOrdenCompra,
                            IdProveedor = rpt.IdProveedor,
                            em_nombre = rpt.em_nombre,
                            pr_nombre = rpt.pr_nombre,
                            oc_plazo = rpt.oc_plazo,
                            oc_fecha = rpt.oc_fecha,
                            pr_codigo = rpt.pr_codigo,
                            pr_descripcion = rpt.pr_descripcion,
                            do_Cantidad = rpt.do_Cantidad,
                            IdUnidadMedida = rpt.IdUnidadMedida
                        };

                        if (rpt.pr_contribuyenteEspecial == "S")
                        {
                            item.pr_contribuyenteEspecial = true;
                            item.proveedor_es_contribuyente_especial = "X";
                        }
                        else
                        {
                            item.pr_contribuyenteEspecial = false;
                            item.proveedor_no_es_contribuyente_especial = "X";
                        }

                        item.do_precioCompra = rpt.do_precioCompra;
                        item.do_subtotal = rpt.do_subtotal;
                        item.do_iva = rpt.do_iva;
                        item.do_total = rpt.do_total;
                        item.do_descuento = rpt.do_descuento;
                        item.do_porc_des = rpt.do_porc_des;
                        item.Secuencia = num;

                        ListData.Add(item);
                    }
                }

                return ListData;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = ex.ToString() + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.ToString());
            }
        }
    }
}