using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bizu.Domain.CuentasxPagar;

namespace Bizu.Infrastructure.CuentasxPagar
{
    public class cp_nota_DebCre_Aprobacion_Ing_Bod_x_OC_det_Data
    {
        public List<cp_nota_DebCre_Aprobacion_Ing_Bod_x_OC_det_Info> Get_List_Aprobacion_Ing_Bod_x_OC_det_x_Proveedor(int IdEmpresa, decimal IdProveedor)
        {
            try
            {
                List<cp_nota_DebCre_Aprobacion_Ing_Bod_x_OC_det_Info> Lst = new List<cp_nota_DebCre_Aprobacion_Ing_Bod_x_OC_det_Info>();
                EntitiesInventario oEnti = new EntitiesInventario();

                var Query = from q in oEnti.vwin_Ing_Egr_Inven_det_x_com_ordencompra_local_det_x_cp_Aprob
                            where q.IdEmpresa == IdEmpresa
                            && q.IdProveedor == IdProveedor
                            select q;

                foreach (var item in Query)
                {
                    cp_nota_DebCre_Aprobacion_Ing_Bod_x_OC_det_Info Obj = new cp_nota_DebCre_Aprobacion_Ing_Bod_x_OC_det_Info();
                    Obj.IdEmpresa_Ing_Egr_Inv = item.IdEmpresa;
                    Obj.IdSucursal_Ing_Egr_Inv = item.IdSucursal;
                    Obj.IdMovi_inven_tipo_Ing_Egr_Inv = Convert.ToInt32(item.IdMovi_inven_tipo);
                    Obj.IdNumMovi_Ing_Egr_Inv = item.IdNumMovi;
                    Obj.Secuencia_Ing_Egr_Inv = item.Secuencia;
                    Obj.IdBodega = item.IdBodega;
                    Obj.Fecha_Ing_Bod = (item.cm_fecha == null) ? DateTime.Now : Convert.ToDateTime(item.cm_fecha);
                    Obj.IdProducto = item.IdProducto;
                    Obj.nom_producto = item.nom_producto;
                    Obj.IdUnidadMedida = item.IdUnidadMedida;
                    Obj.nom_medida = item.nom_medida;
                    Obj.nom_bodega = item.nom_bodega;
                    Obj.nom_sucursal = item.nom_sucursal;
                    Obj.Cantidad = item.dm_cantidad;
                    Obj.Costo_uni = Convert.ToDouble((item.mv_costo == null) ? 0 : item.mv_costo);
                    Obj.do_porc_des = item.do_porc_des;
                    Obj.PorIva = item.Por_Iva;
                    Obj.IdProveedor = item.IdProveedor;
                    Obj.nom_proveedor = item.nom_proveedor;
                    Obj.PorIva = item.Por_Iva;
                    Obj.oc_observacion = item.oc_observacion;
                    Obj.Precio = item.dm_precio;

                    ein_Inventario_O_Consumo Tipo_Inve_o_Consu;

                    try
                    {
                        Tipo_Inve_o_Consu = (ein_Inventario_O_Consumo)Enum.Parse(typeof(ein_Inventario_O_Consumo), item.es_Inven_o_Consumo);
                    }
                    catch
                    {
                        Tipo_Inve_o_Consu = ein_Inventario_O_Consumo.TIC_INVEN;
                    }

                    Obj.S_es_Inven_o_Consumo = item.es_Inven_o_Consumo;
                    Obj.es_Inven_o_Consumo = Tipo_Inve_o_Consu;
                    Obj.IdCtaCtble_Gasto_x_cxp_x_Produc = item.IdCtaCtble_Gasto_x_cxp_x_Produc;
                    Obj.IdCtaCble_Inven_x_Produc = item.IdCtaCble_Inven_x_Produc;
                    Obj.IdCtaCtble_Inve_x_Bodega = item.IdCtaCtble_Inve_x_Bodega;
                    Obj.IdCtaCble_Inven_x_Motivo = item.IdCtaCble_Inven_x_Motivo;
                    Obj.IdCtaCble_Costo_x_Motivo = item.IdCtaCble_Costo_x_Motivo;
                    //Campos para contabilizacion de Naturisa
                    Obj.IdCategoria = item.IdCategoria;
                    Obj.IdLinea = item.IdLinea;
                    Obj.IdGrupo = item.IdGrupo;
                    Obj.IdSubGrupo = item.IdSubGrupo;
                    //Campos para el diario de gastos
                    Obj.IdCentro_Costo = item.IdCentroCosto;
                    Obj.IdCentroCosto_sub_centro_costo = item.IdCentroCosto_sub_centro_costo;
                    Obj.IdPunto_cargo_grupo = item.IdPunto_cargo_grupo;
                    Obj.IdPunto_cargo = item.IdPunto_cargo;
                    Obj.Secuencia_OC = item.Secuencia_oc == null ? 1 : (int)item.Secuencia_oc;
                    Obj.IdSucursal_OC = item.IdSucursal_oc == null ? 1 : (int)item.IdSucursal_oc;
                    Obj.IdOrdenCompra = Convert.ToDecimal(item.IdOrdenCompra);
                    Obj.Dias = item.Dias;
                    Obj.TieneDiario = item.TieneDiario;

                    Lst.Add(Obj);
                }

                return Lst;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<cp_nota_DebCre_Aprobacion_Ing_Bod_x_OC_det_Info> GetList(int IdEmpresa, decimal IdCbteCble_Nota, int IdTipoCbte_Nota)
        {
            try
            {
                EntitiesCuentasxPagar dbContext = new EntitiesCuentasxPagar();

                List<cp_nota_DebCre_Aprobacion_Ing_Bod_x_OC_det_Info> Lista = new List<cp_nota_DebCre_Aprobacion_Ing_Bod_x_OC_det_Info>();

                var result = from cab in dbContext.cp_nota_DebCre_Aprobacion_Ing_Bod_x_OC
                             join det in dbContext.cp_nota_DebCre_Aprobacion_Ing_Bod_x_OC_det
                             on new { cab.IdEmpresa, cab.IdAprobacion }
                             equals new { det.IdEmpresa, det.IdAprobacion }
                             where cab.IdEmpresa_Nota == IdEmpresa
                             && cab.IdCbteCble_Nota == IdCbteCble_Nota
                             && cab.IdTipoCbte_Nota == IdTipoCbte_Nota
                             select det;

                foreach (var item in result)
                {
                    cp_nota_DebCre_Aprobacion_Ing_Bod_x_OC_det_Info Info = new cp_nota_DebCre_Aprobacion_Ing_Bod_x_OC_det_Info();
                    Info.IdEmpresa = item.IdEmpresa;
                    Info.IdAprobacion = item.IdAprobacion;
                    Info.Secuencia = item.Secuencia;
                    Info.IdEmpresa_Ing_Egr_Inv = item.IdEmpresa_Ing_Egr_Inv;
                    Info.IdSucursal_Ing_Egr_Inv = item.IdSucursal_Ing_Egr_Inv;
                    Info.IdMovi_inven_tipo_Ing_Egr_Inv = item.IdMovi_inven_tipo_Ing_Egr_Inv;
                    Info.IdNumMovi_Ing_Egr_Inv = item.IdNumMovi_Ing_Egr_Inv;
                    Info.Secuencia_Ing_Egr_Inv = item.Secuencia_Ing_Egr_Inv;
                    Info.Cantidad = item.Cantidad;
                    Info.Costo_uni = item.Costo_uni;
                    Info.Descuento = item.Descuento;
                    Info.SubTotal = item.SubTotal;
                    Info.PorIva = item.PorIva;
                    Info.Valor_Iva = item.Valor_Iva;
                    Info.Total = item.Total;
                    Info.IdCtaCble_Gasto = item.IdCtaCble_Gasto;
                    Info.IdCtaCble_IVA = item.IdCtaCble_IVA;
                    Info.IdCentro_Costo_x_Gasto_x_cxp = item.IdCentro_Costo_x_Gasto_x_cxp;
                    Info.IdCentroCosto_sub_centro_costo_cxp = item.IdCentroCosto_sub_centro_costo_cxp;
                    Info.Checked = true; // Se asigna true para que calcule los totales en pantalla de aprobacion de ND

                    Lista.Add(Info);
                }

                return Lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
