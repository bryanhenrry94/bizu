using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Bizu.Domain.CuentasxPagar;
using Bizu.Infrastructure.CuentasxPagar;
using Bizu.Application.General;
using Bizu.Domain.General;
using Bizu.Application.Inventario;
using Bizu.Domain.Inventario;

namespace Bizu.Application.CuentasxPagar
{
    public class cp_Aprobacion_Ing_Bod_x_OC_det_Bus
    {
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        cp_Aprobacion_Ing_Bod_x_OC_det_Data odata;

        public cp_Aprobacion_Ing_Bod_x_OC_det_Bus() {
            this.odata = new cp_Aprobacion_Ing_Bod_x_OC_det_Data();
        }

        public Boolean GuardarDB(List<cp_Aprobacion_Ing_Bod_x_OC_det_Info> LstInfo, ref string msg)
        {
            try
            {
                return this.odata.GuardarDB(LstInfo, ref msg);
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "GuardarDB", ex.Message), ex) { EntityType = typeof(cp_Aprobacion_Ing_Bod_x_OC_det_Bus) };
            }

        }

        public List<cp_Aprobacion_Ing_Bod_x_OC_det_Info> Get_List_Aprobacion_Ing_Bod_x_OC_det(int IdEmpresa, decimal IdAprobacion)
        {
            try
            {
                return this.odata.Get_List_Aprobacion_Ing_Bod_x_OC_det(IdEmpresa, IdAprobacion);
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "Get_Info_Aprobacion_Ing_Bod_x_OC", ex.Message), ex) { EntityType = typeof(cp_Aprobacion_Ing_Bod_x_OC_det_Bus) };
            }
        }

        public List<cp_Aprobacion_Ing_Bod_x_OC_det_Info> Get_List_Aprobacion_Ing_Bod_x_OC_det_x_Proveedor(int IdEmpresa, decimal IdProveedor)
        {
            try
            {
                List<cp_Aprobacion_Ing_Bod_x_OC_det_Info> lista = new List<cp_Aprobacion_Ing_Bod_x_OC_det_Info>();
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
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "Get_Info_Aprobacion_Ing_Bod_x_OC", ex.Message), ex) { EntityType = typeof(cp_Aprobacion_Ing_Bod_x_OC_det_Bus) };
            }
        }

        public cp_Aprobacion_Ing_Bod_x_OC_det_Info2 Get_List_Aprobacion_Ing_Bod_x_OC_det2(int IdEmpresa, int Idsucursal, decimal IdNumMovi, decimal IdNumMoviTipo, int secuencia)
        {
            try
            {
                return this.odata.Get_List_Aprobacion_Ing_Bod_x_OC_det2(IdEmpresa, Idsucursal, IdNumMovi, IdNumMoviTipo, secuencia);
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "Get_Info_Aprobacion_Ing_Bod_x_OC", ex.Message), ex) { EntityType = typeof(cp_Aprobacion_Ing_Bod_x_OC_det_Bus) };
            }
        }
    }
}