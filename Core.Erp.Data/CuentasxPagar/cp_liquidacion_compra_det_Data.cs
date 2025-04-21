using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Info.CuentasxPagar;

namespace Core.Erp.Data.CuentasxPagar
{
    public class cp_liquidacion_compra_det_Data
    {
        public bool GrabarDB(List<cp_liquidacion_compra_det_Info> Info, ref string msg)
        {
            try
            {
                using (EntitiesCuentasxPagar context = new EntitiesCuentasxPagar())
                {
                    foreach (var item in Info)
                    {
                        cp_liquidacion_compra_det Addres = new cp_liquidacion_compra_det();
                        Addres.IdEmpresa = item.IdEmpresa;
                        Addres.IdLiquidacionCompra = item.IdLiquidacionCompra;                        
                        Addres.Secuencia = item.Secuencia;
                        Addres.IdProducto = item.IdProducto;
                        Addres.Codigo = item.Codigo;
                        Addres.Descripcion = item.Descripcion;
                        Addres.IdUnidadMedida = item.IdUnidadMedida;
                        Addres.Cantidad = item.Cantidad;
                        Addres.Precio = item.Precio;
                        Addres.PorDescUnitario = item.PorDescUnitario;
                        Addres.DescUnitario = item.DescUnitario;
                        Addres.PrecioFinal = item.PrecioFinal;
                        Addres.Subtotal = item.Subtotal;
                        Addres.IdCod_Impuesto_Iva = item.IdCod_Impuesto_Iva;
                        Addres.Iva = item.Iva;
                        Addres.por_iva = item.por_iva;
                        Addres.Total = item.Total;

                        context.cp_liquidacion_compra_det.Add(Addres);
                    }

                    context.SaveChanges();

                    msg = "Detalle de liquidacion de compra registrado con éxito!";
                }

                return true;
            }
            catch (Exception ex)
            {
                msg = ex.InnerException.Message;
                throw new Exception(ex.InnerException.Message);
            }
        }

        public bool EliminarDB(int IdEmpresa, decimal IdLiquidacionCompra, ref string msg)
        {
            try
            {
                using (EntitiesCuentasxPagar context = new EntitiesCuentasxPagar())
                {
                    int iFilasAfectadas = 0;

                    iFilasAfectadas = context.Database.ExecuteSqlCommand("DELETE FROM cp_liquidacion_compra_det WHERE IdEmpresa = " + IdEmpresa + " AND IdLiquidacionCompra = " + IdLiquidacionCompra);

                    msg = iFilasAfectadas + " registros eliminados correctamente!";
                }

                return true;
            }
            catch (Exception ex)
            {
                msg = ex.InnerException.Message;
                throw new Exception(ex.InnerException.Message);
            }
        }

        public List<cp_liquidacion_compra_det_Info> Get_Detalle(int IdEmpresa, decimal IdLiquidacionCompra)
        {
            try
            {
                List<cp_liquidacion_compra_det_Info> Lista = new List<cp_liquidacion_compra_det_Info>();

                using (EntitiesCuentasxPagar context = new EntitiesCuentasxPagar())
                {
                    var query = from q in context.cp_liquidacion_compra_det
                                where q.IdEmpresa == IdEmpresa
                                && q.IdLiquidacionCompra == IdLiquidacionCompra
                                select q;

                    foreach (var item in query)
                    {
                        cp_liquidacion_compra_det_Info Info = new cp_liquidacion_compra_det_Info();
                        Info.IdEmpresa = item.IdEmpresa;
                        Info.IdLiquidacionCompra = item.IdLiquidacionCompra;
                        Info.Secuencia = item.Secuencia;
                        Info.IdProducto = item.IdProducto;
                        Info.Codigo = item.Codigo;
                        Info.Descripcion = item.Descripcion;
                        Info.IdUnidadMedida = item.IdUnidadMedida;
                        Info.Cantidad = item.Cantidad;
                        Info.Precio = item.Precio;
                        Info.PorDescUnitario = item.PorDescUnitario;
                        Info.DescUnitario = item.DescUnitario;
                        Info.PrecioFinal = item.PrecioFinal;
                        Info.Subtotal = item.Subtotal;
                        Info.IdCod_Impuesto_Iva = item.IdCod_Impuesto_Iva;
                        Info.Iva = item.Iva;
                        Info.por_iva = item.por_iva;
                        Info.Total = item.Total;

                        Lista.Add(Info);
                    }
                }

                return Lista;
            }
            catch (Exception ex)
            {                
                throw new Exception(ex.InnerException.Message);
            }
        }
    }
}
