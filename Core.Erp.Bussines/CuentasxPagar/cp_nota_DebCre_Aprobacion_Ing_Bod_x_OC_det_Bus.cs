using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Info.CuentasxPagar;
using Core.Erp.Business.Inventario;
using Core.Erp.Info.Inventario;
using Core.Erp.Data.CuentasxPagar;

namespace Core.Erp.Business.CuentasxPagar
{
    public class cp_nota_DebCre_Aprobacion_Ing_Bod_x_OC_det_Bus
    {
        cp_nota_DebCre_Aprobacion_Ing_Bod_x_OC_det_Data odata;

        public cp_nota_DebCre_Aprobacion_Ing_Bod_x_OC_det_Bus()
        {
            odata = new cp_nota_DebCre_Aprobacion_Ing_Bod_x_OC_det_Data();
        }

        public List<cp_nota_DebCre_Aprobacion_Ing_Bod_x_OC_det_Info> Get_List_Aprobacion_Ing_Bod_x_OC_det_x_Proveedor(int IdEmpresa, decimal IdProveedor)
        {
            try
            {
                List<cp_nota_DebCre_Aprobacion_Ing_Bod_x_OC_det_Info> lista = new List<cp_nota_DebCre_Aprobacion_Ing_Bod_x_OC_det_Info>();
                in_subgrupo_x_CentroCosto_x_SubCentroCosto_x_CtaCble_Bus BusSub_x_CC = new in_subgrupo_x_CentroCosto_x_SubCentroCosto_x_CtaCble_Bus();
                in_subgrupo_x_CentroCosto_x_SubCentroCosto_x_CtaCble_Info InfoSub_CC = new in_subgrupo_x_CentroCosto_x_SubCentroCosto_x_CtaCble_Info();

                lista = this.odata.Get_List_Aprobacion_Ing_Bod_x_OC_det_x_Proveedor(IdEmpresa, IdProveedor);

                foreach (var item in lista)
                {
                    if (item.es_Inven_o_Consumo == ein_Inventario_O_Consumo.TIC_CONSU)
                    {
                        InfoSub_CC = BusSub_x_CC.Get_Info_in_subgrupo(IdEmpresa, item.IdCategoria, item.IdLinea, item.IdGrupo, item.IdSubGrupo, item.IdCentro_Costo, item.IdCentroCosto_sub_centro_costo);
                        item.IdCtaCble_Gasto = InfoSub_CC.IdCtaCble;
                    }

                    if (item.es_Inven_o_Consumo == ein_Inventario_O_Consumo.TIC_INVEN)
                    {
                        // VALIDACION ADICIONAL SOLICITADA POR CONTABILIDAD PARA QUE NO CARGUE CUENTA CONTABLE SINO TIENE DIARIO CONTABLE EL INGRESO A BODEGA X OC
                        if (Convert.ToBoolean(item.TieneDiario) == false)
                            continue;

                        if (string.IsNullOrEmpty(item.IdCtaCble_Costo_x_Motivo) == false)
                        {
                            item.IdCtaCble_Gasto = item.IdCtaCble_Costo_x_Motivo;
                            continue;
                        }

                        if (string.IsNullOrEmpty(item.IdCtaCble_Inven_x_Produc) == false)
                        {
                            item.IdCtaCble_Gasto = item.IdCtaCble_Inven_x_Produc;
                            continue;
                        }

                        if (string.IsNullOrEmpty(item.IdCtaCble_Inven_x_Motivo) == false)
                        {
                            item.IdCtaCble_Gasto = item.IdCtaCble_Inven_x_Motivo;
                            continue;
                        }

                        if (string.IsNullOrEmpty(item.IdCtaCtble_Inve_x_Bodega) == false)
                        {
                            item.IdCtaCble_Gasto = item.IdCtaCtble_Inve_x_Bodega;
                            continue;
                        }
                    }
                }

                return lista;
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_Info_Aprobacion_Ing_Bod_x_OC", ex.Message), ex) { EntityType = typeof(cp_Aprobacion_Ing_Bod_x_OC_det_Bus) };
            }
        }

        public List<cp_nota_DebCre_Aprobacion_Ing_Bod_x_OC_det_Info> GetList(int IdEmpresa, decimal IdCbteCble_Nota, int IdTipoCbte_Nota)
        {
            try
            {
                return this.odata.GetList(IdEmpresa, IdCbteCble_Nota, IdTipoCbte_Nota);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
