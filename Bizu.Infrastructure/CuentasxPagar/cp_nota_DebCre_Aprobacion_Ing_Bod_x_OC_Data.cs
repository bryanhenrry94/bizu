using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bizu.Domain.CuentasxPagar;

namespace Bizu.Infrastructure.CuentasxPagar
{
    public class cp_nota_DebCre_Aprobacion_Ing_Bod_x_OC_Data
    {
        public bool GrabarBD(cp_nota_DebCre_Aprobacion_Ing_Bod_x_OC_Info Info)
        {
            try
            {
                EntitiesCuentasxPagar dbContext = new EntitiesCuentasxPagar();

                // Obtiene el secuencial de la base de datos, el ultimo registro + 1
                Info.IdAprobacion = GetIdAprobacion(Info.IdEmpresa);

                cp_nota_DebCre_Aprobacion_Ing_Bod_x_OC _objAprobxOC = new cp_nota_DebCre_Aprobacion_Ing_Bod_x_OC();
                _objAprobxOC.IdEmpresa = Info.IdEmpresa;
                _objAprobxOC.IdAprobacion = Info.IdAprobacion;
                _objAprobxOC.FechaAprobacion = Info.FechaAprobacion;
                _objAprobxOC.IdEmpresa_Nota = Info.IdEmpresa;
                _objAprobxOC.IdCbteCble_Nota = Info.IdCbteCble_Nota;
                _objAprobxOC.IdTipoCbte_Nota = Info.IdTipoCbte_Nota;
                _objAprobxOC.Subtotal_iva = Info.Subtotal_iva;
                _objAprobxOC.Subtotal_siniva = Info.Subtotal_siniva;
                _objAprobxOC.Descuento = 0;
                _objAprobxOC.BaseImponible = Info.BaseImponible;
                _objAprobxOC.Por_iva = Info.Por_iva;
                _objAprobxOC.Valor_iva = Info.Valor_iva;
                _objAprobxOC.Total = Info.Total;

                dbContext.cp_nota_DebCre_Aprobacion_Ing_Bod_x_OC.Add(_objAprobxOC);
                dbContext.SaveChanges();

                // Si tiene registros graba en la base de datos el detalle
                if(Info.ListAprobacionDet.Count > 0)
                {
                    int iSecuencia = 0;

                    foreach (var item in Info.ListAprobacionDet)
                    {
                        iSecuencia++;

                        cp_nota_DebCre_Aprobacion_Ing_Bod_x_OC_det InfoAprobacionDet = new cp_nota_DebCre_Aprobacion_Ing_Bod_x_OC_det();
                        InfoAprobacionDet.IdEmpresa = Info.IdEmpresa;
                        InfoAprobacionDet.IdAprobacion = Info.IdAprobacion;
                        InfoAprobacionDet.Secuencia = iSecuencia;
                        InfoAprobacionDet.IdEmpresa_Ing_Egr_Inv = item.IdEmpresa_Ing_Egr_Inv;
                        InfoAprobacionDet.IdSucursal_Ing_Egr_Inv = item.IdSucursal_Ing_Egr_Inv;
                        InfoAprobacionDet.IdMovi_inven_tipo_Ing_Egr_Inv = item.IdMovi_inven_tipo_Ing_Egr_Inv;
                        InfoAprobacionDet.IdNumMovi_Ing_Egr_Inv = item.IdNumMovi_Ing_Egr_Inv;
                        InfoAprobacionDet.Secuencia_Ing_Egr_Inv = item.Secuencia;
                        InfoAprobacionDet.Cantidad = item.Cantidad;
                        InfoAprobacionDet.Costo_uni = item.Costo_uni;
                        InfoAprobacionDet.Descuento = item.Descuento;
                        InfoAprobacionDet.SubTotal = item.SubTotal;
                        InfoAprobacionDet.PorIva = item.PorIva;
                        InfoAprobacionDet.Valor_Iva = item.Valor_Iva;
                        InfoAprobacionDet.Total = item.Total;
                        InfoAprobacionDet.IdCtaCble_Gasto = item.IdCtaCble_Gasto;
                        InfoAprobacionDet.IdCtaCble_IVA = item.IdCtaCble_IVA;
                        InfoAprobacionDet.IdCentro_Costo_x_Gasto_x_cxp = item.IdCentro_Costo_x_Gasto_x_cxp;
                        InfoAprobacionDet.IdCentroCosto_sub_centro_costo_cxp = item.IdCentroCosto_sub_centro_costo_cxp;

                        dbContext.cp_nota_DebCre_Aprobacion_Ing_Bod_x_OC_det.Add(InfoAprobacionDet);
                        dbContext.SaveChanges();
                    }
                }

                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public decimal GetIdAprobacion(int IdEmpresa)
        {
            try
            {
                EntitiesCuentasxPagar dbContext = new EntitiesCuentasxPagar();

                var query = dbContext.cp_nota_DebCre_Aprobacion_Ing_Bod_x_OC.Where(q => q.IdEmpresa == IdEmpresa);

                if(query.Count() > 0)
                {
                    return query.Max(q => q.IdAprobacion) + 1;
                }
                else
                {
                    return 1;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
