using Core.Erp.Data.General;
using Core.Erp.Info.General;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Core.Erp.Reportes.Inventario
{
    public class XINV_Rpt032_Data
    {
        public List<XINV_Rpt032_Info> Get_list(int IdEmpresa, int IdSucursal, int IdBodega, decimal IdProducto, int IdMarca, DateTime Fecha_ini, DateTime Fecha_fin)
        {
            try
            {
                decimal IdProducto_ini = IdProducto;
                decimal IdProducto_fin = IdProducto == 0 ? 9999999 : IdProducto;

                int IdSucursal_ini = IdSucursal;
                int IdSucursal_fin = IdSucursal == 0 ? 99999 : IdSucursal;

                int IdBodega_ini = IdBodega;
                int IdBodega_fin = IdBodega == 0 ? 99999 : IdBodega;

                int IdMarca_ini = IdMarca;
                int IdMarca_fin = IdMarca == 0 ? 99999 : IdMarca;

                Fecha_ini = Fecha_ini.Date;
                Fecha_fin = Fecha_fin.Date;

                List<XINV_Rpt032_Info> Lista = new List<XINV_Rpt032_Info>();

                using (Entities_Inventario_General Context = new Entities_Inventario_General())
                {
                    var lst = from q in Context.vwINV_Rpt031
                              where q.IdEmpresa == IdEmpresa
                              && IdProducto_ini <= q.IdProducto && q.IdProducto <= IdProducto_fin
                              && IdSucursal_ini <= q.IdSucursal && q.IdSucursal <= IdSucursal_fin
                              && IdBodega_ini <= q.IdBodega && q.IdBodega <= IdBodega_fin
                              && IdMarca_ini <= q.IdMarca && q.IdMarca <= IdMarca_fin
                              && Fecha_ini <= q.Fecha_Transac && q.Fecha_Transac <= Fecha_fin
                              select q;

                    foreach (var item in lst)
                    {
                        XINV_Rpt032_Info prd = new XINV_Rpt032_Info();
                        prd.IdEmpresa = item.IdEmpresa;
                        prd.Estado = item.Estado.Trim();
                        prd.Fecha_Transac = item.Fecha_Transac;
                        prd.Fecha_UltAnu = item.Fecha_UltAnu;
                        prd.Fecha_UltMod = item.Fecha_UltMod;

                        prd.pr_imagen_Grande = item.pr_imagen_Grande;
                        prd.pr_imagenPeque = item.pr_imagenPeque;
                        prd.IdPresentacion = item.IdPresentacion;
                        prd.ca_Categoria = item.ca_Categoria;
                        prd.nom_linea = item.nom_linea;
                        prd.nom_grupo = item.nom_grupo;
                        prd.nom_subgrupo = item.nom_subgrupo;

                        prd.pr_descripcion_2 = item.pr_descripcion_2;
                        prd.pr_descripcion = item.pr_descripcion;
                        prd.PesoEspecifico = item.PesoEspecifico;
                        prd.AnchoEspecifico = item.AnchoEspecifico;
                        prd.IdUnidadMedida_Consumo = item.IdUnidadMedida_Consumo;
                        prd.IdEmpresa = item.IdEmpresa;

                        prd.IdMarca = (item.IdMarca == null) ? 0 : Convert.ToInt32(item.IdMarca);

                        prd.IdProducto = item.IdProducto;

                        prd.IdProductoTipo = item.IdProductoTipo;

                        prd.IdUnidadMedida = item.IdUnidadMedida.Trim();
                        prd.IdUsuario = item.IdUsuario.Trim();
                        prd.IdUsuarioUltAnu = item.IdUsuarioUltAnu;
                        prd.IdUsuarioUltMod = item.IdUsuarioUltMod;
                        prd.ip = item.ip.Trim();
                        prd.nom_pc = item.nom_pc.Trim();
                        prd.pr_alto = item.pr_alto;
                        prd.pr_codigo = item.pr_codigo.Trim();
                        prd.pr_codigo_barra = item.pr_codigo_barra.Trim();
                        prd.pr_costo_CIF = item.pr_costo_CIF;
                        prd.pr_costo_fob = item.pr_costo_fob;
                        prd.pr_costo_promedio = item.pr_costo_promedio;
                        prd.pr_descripcion = item.pr_descripcion.Trim();
                        prd.pr_DiasAereo = item.pr_DiasAereo;
                        prd.pr_DiasMaritimo = item.pr_DiasMaritimo;
                        prd.pr_DiasTerrestre = item.pr_DiasTerrestre;

                        prd.pr_largo = item.pr_largo;

                        prd.pr_ManejaSeries = item.pr_ManejaSeries.Trim();
                        prd.pr_observacion = item.pr_observacion.Trim();
                        prd.pr_partidaArancel = item.pr_partidaArancel;
                        prd.pr_pedidos = item.pr_pedidos;
                        prd.pr_peso = item.pr_peso;
                        prd.pr_porcentajeArancel = item.pr_porcentajeArancel;

                        if (item.IdMarca == 6)
                        {
                            string May, Min, Pub = "";

                            decimal Valor1 = Convert.ToDecimal(item.pr_precio_mayor);
                            May = Valor1.ToString("N5");
                            decimal Valor2 = Convert.ToDecimal(item.pr_precio_minimo);
                            Min = Valor2.ToString("N5");
                            decimal Valor3 = Convert.ToDecimal(item.pr_precio_publico);
                            Pub = Valor3.ToString("N5");

                            prd.pr_precio_mayor = Convert.ToDecimal(May);
                            prd.pr_precio_minimo = Convert.ToDecimal(Min);
                            prd.pr_precio_publico = Convert.ToDecimal(Pub);
                        }
                        else 
                        {
                            string may, min, pub = "";

                            decimal valor1 = Convert.ToDecimal(item.pr_precio_mayor);
                            may = valor1.ToString("N2");
                            decimal valor2 = Convert.ToDecimal(item.pr_precio_minimo);
                            min = valor2.ToString("N2");
                            decimal valor3 = Convert.ToDecimal(item.pr_precio_publico);
                            pub = valor3.ToString("N2");

                            prd.pr_precio_mayor = Convert.ToDecimal(may);
                            prd.pr_precio_minimo = Convert.ToDecimal(min);
                            prd.pr_precio_publico = Convert.ToDecimal(pub);
                        }
                        
                        prd.pr_profundidad = item.pr_profundidad;
                        prd.pr_stock = item.pr_stock;
                        prd.pr_descripcion_2 = "[" + item.pr_codigo + "]- " + item.pr_descripcion;
                        prd.pr_stock_maximo = item.pr_stock_maximo;
                        prd.pr_stock_minimo = item.pr_stock_minimo;
                        prd.IdProductoTipo = item.IdProductoTipo;

                        prd.IdCategoria = item.IdCategoria.Trim();
                        prd.IdLinea = Convert.ToInt32(item.IdLinea);
                        prd.IdGrupo = Convert.ToInt32(item.IdGrupo);
                        prd.IdSubGrupo = Convert.ToInt32(item.IdSubGrupo);



                        prd.IdProductoTipo = item.IdProductoTipo;
                        prd.ManejaKardex = item.ManejaKardex;
                        prd.pr_ManejaIva = item.pr_ManejaIva.Trim();
                        prd.IdMotivo_Vta = Convert.ToInt32(item.IdMotivo_Vta);
                        prd.IdCod_Impuesto_Iva = item.IdCod_Impuesto_Iva;
                        prd.IdCod_Impuesto_Ice = item.IdCod_Impuesto_Ice;
                        prd.Aparece_modu_Ventas = item.Aparece_modu_Ventas;
                        prd.Aparece_modu_Compras = item.Aparece_modu_Compras;
                        prd.Aparece_modu_Inventario = item.Aparece_modu_Inventario;
                        prd.Aparece_modu_Activo_F = item.Aparece_modu_Activo_F;

                        prd.marca = item.marca;
                        prd.IdBodega = item.IdBodega;
                        prd.IdSucursal = item.IdSucursal;
                        prd.unidadMedida = item.unidadMedida;

                        
                        string st = "";
                        int st1 = Convert.ToInt32(item.pr_stock);
                        st = st1.ToString("###,###,##0");
                        prd.stock = st;


                        Lista.Add(prd);
                    }
                }

                return Lista;
            }
            catch (Exception ex)
            {
                string MensajeError = "";
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                MensajeError = ex.InnerException + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
                throw new Exception(ex.InnerException.ToString());
            }
        }

        public List<XINV_Rpt032_Info> Get_list_(int IdEmpresa, int IdSucursal, int IdBodega)
        {
            try
            {

                int IdSucursal_ini = IdSucursal;
                int IdSucursal_fin = IdSucursal == 0 ? 99999 : IdSucursal;

                int IdBodega_ini = IdBodega;
                int IdBodega_fin = IdBodega == 0 ? 99999 : IdBodega;

                List<XINV_Rpt032_Info> Lista = new List<XINV_Rpt032_Info>();

                using (Entities_Inventario_General Context = new Entities_Inventario_General())
                {
                    var lst = from q in Context.vwINV_Rpt031
                              where q.IdEmpresa == IdEmpresa
                              && IdSucursal_ini <= q.IdSucursal && q.IdSucursal <= IdSucursal_fin
                              && IdBodega_ini <= q.IdBodega && q.IdBodega <= IdBodega_fin
                              select q;

                    foreach (var item in lst)
                    {
                        XINV_Rpt032_Info prd = new XINV_Rpt032_Info();

                        var ite = Lista.FindAll(p => p.IdMarca == item.IdMarca);

                        if (ite.Count() > 0)
                        {
                        }
                        else 
                        {
                            if (item.IdBodega == IdBodega)
                            {
                               prd.IdMarca = (item.IdMarca == null) ? 0 : Convert.ToInt32(item.IdMarca);
                               prd.marca = item.marca;
                               Lista.Add(prd);
                            }                        
                        }                                                                                        
                    }
                }

                return Lista;
            }
            catch (Exception ex)
            {
                string MensajeError = "";
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                MensajeError = ex.InnerException + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
                throw new Exception(ex.InnerException.ToString());
            }
        }
    }
}
