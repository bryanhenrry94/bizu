using System;
using System.Collections.Generic;
using System.Linq;
using Core.Erp.Info.General;
using Core.Erp.Data.General;

namespace Core.Erp.Reportes.Compras
{
    public class XCOMP_Rpt001_Data
    {
        string mensaje = "";

        public List<XCOMP_Rpt001_Info> Get_Data(int IdEmpresa, int IdSucursal, decimal IdOrdenCompra)
        {
            try
            {
                List<XCOMP_Rpt001_Info> ListData = new List<XCOMP_Rpt001_Info>();
                int s = 0;

                using (EntitiesCompra_reporte_Ge base_ = new EntitiesCompra_reporte_Ge())
                {

                    var q = from C in base_.vwCOMP_Rpt001
                            where C.IdEmpresa == IdEmpresa
                            && C.IdSucursal == IdSucursal
                            && C.IdOrdenCompra == IdOrdenCompra
                            select C;

                    foreach (var item in q)
                    {
                        s = s + 1;
                        XCOMP_Rpt001_Info info = new XCOMP_Rpt001_Info();
                        info.IdEmpresa = item.IdEmpresa;
                        info.IdSucursal = item.IdSucursal;
                        info.IdOrdenCompra = item.IdOrdenCompra;
                        info.IdProveedor = item.IdProveedor;
                        info.em_nombre = item.em_nombre;
                        info.pr_nombre = item.pr_nombre;
                        info.oc_plazo = item.oc_plazo;
                        info.oc_fecha = item.oc_fecha;
                        info.pr_codigo = item.pr_codigo;
                        info.pr_codigo = item.pr_codigo;
                        info.pr_descripcion = item.pr_descripcion;
                        info.do_Cantidad = item.do_Cantidad;
                        info.IdUnidadMedida = item.IdUnidadMedida;

                        if (item.pr_contribuyenteEspecial == "S")
                        {
                            info.pr_contribuyenteEspecial = true;
                            info.proveedor_es_contribuyente_especial = "X";
                        }
                        else
                        {
                            info.pr_contribuyenteEspecial = false;
                            info.proveedor_no_es_contribuyente_especial = "X";
                        }

                        info.do_precioCompra = item.do_precioCompra;
                        info.do_subtotal = item.do_subtotal;
                        info.do_Subtotal_SinDescuento = item.do_Subtotal_SinDescuento;
                        info.do_iva = item.do_iva;
                        info.do_total = item.do_total;
                        info.do_descuento = item.do_descuento;
                        info.do_porc_des = item.do_porc_des;
                        info.Usuario_Solicitante = item.Usuario_Solicitante;
                        info.Usuario_Procesa = item.Usuario_Procesa;
                        info.Usuario_Aprueba = item.Usuario_Aprueba;
                        info.oc_NumDocumento = item.oc_NumDocumento;

                        if (item.TerminoPago == "CRED")
                        {
                            info.escredito = "X";
                            info.escontado = "";
                        }
                        if (item.TerminoPago == "CONTADO")
                        {
                            info.escredito = "";
                            info.escontado = "X";
                        }

                        info.UnidadMedidaConsumo = item.UnidadMedidaConsumo;
                        info.pr_peso = item.pr_peso;
                        info.do_CantidadConversion = item.pr_peso != 0 ? item.do_Cantidad / item.pr_peso : item.do_Cantidad;
                        info.Secuencia = s;
                        info.IdCentroCosto = item.IdCentroCosto;
                        info.Centro_costo = item.Centro_costo;
                        info.detalle_x_item = item.detalle_x_item;
                        info.oc_observacion = item.oc_observacion;
                        info.Por_Iva = item.Por_Iva;
                        info.IdCod_Impuesto = item.IdCod_Impuesto;

                        ListData.Add(info);
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