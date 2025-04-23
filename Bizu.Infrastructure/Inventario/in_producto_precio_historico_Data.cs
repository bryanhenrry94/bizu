using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Text;

using Bizu.Domain.Inventario;
using Bizu.Infrastructure.General;
using Bizu.Domain.General;

namespace Bizu.Infrastructure.Inventario
{
    public class in_producto_precio_historico_Data
    {
        string mensaje = "";
        in_Producto_data Producto_Data = new in_Producto_data();

        public bool Grabar(in_producto_precio_historico_Info Info, ref string Mensaje) 
        {
            try
            {
                in_Producto_Info Info_Producto = new in_Producto_Info();

                using (EntitiesInventario oEnti = new EntitiesInventario())
                {
                    Info_Producto = Producto_Data.Get_Info_BuscarProducto(Info.IdEmpresa, Info.IdProducto);
        
                    var registo = new in_producto_precio_historico();
                    registo.IdEmpresa = Info.IdEmpresa;
                    registo.IdSucursal = Info.IdSucursal;
                    registo.IdProducto = Info.IdProducto;
                    registo.IdUsuario = Info.IdUsuario;

                    Info.Secuencia = (Info.Secuencia == 0) ? GetSecuencia(Info.IdEmpresa, Info.IdSucursal, Info.IdProducto) : Info.Secuencia;

                    registo.Secuencia = Info.Secuencia;
                    registo.Fecha = Info.Fecha;
                    registo.FechaTrans = Info.FechaTrans;
                    registo.pr_precio_publico = Info_Producto.pr_precio_publico == null ? 0 : (double)Info_Producto.pr_precio_publico;
                    registo.pr_precio_mayor = Info_Producto.pr_precio_mayor == null ? 0 : (double)Info_Producto.pr_precio_mayor;
                    registo.pr_precio_minimo = Info_Producto.pr_precio_minimo == null ? 0 : (double)Info_Producto.pr_precio_minimo;                   

                    oEnti.in_producto_precio_historico.Add(registo);
                    oEnti.SaveChanges();

                    Producto_Data.Modificar_Precios(Info.producto_info, ref Mensaje);

                    Mensaje = "Registro Ingresado Correctamente";
                }
                return true;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString() + " " + ex.Message;
                Mensaje = "Error al ingresar el registro ";
                throw new Exception(ex.ToString());
            }
        }


        public int GetSecuencia(int IdEmpresa, int IdSucursal, int IdProducto)
        {
            try
            {
                int Secuencia;
                EntitiesInventario oEnti = new EntitiesInventario();

                var q = (from per in oEnti.in_producto_precio_historico
                         where per.IdEmpresa == IdEmpresa
                         && per.IdSucursal == IdSucursal
                         && per.IdProducto == IdProducto
                         select per);

                if (q.ToList().Count < 1)
                {
                    Secuencia = 1;
                }
                else
                {
                    var sec = (from per in oEnti.in_producto_precio_historico
                               where per.IdEmpresa == IdEmpresa
                               && per.IdSucursal == IdSucursal
                               && per.IdProducto == IdProducto
                               select per.Secuencia).Max();

                    Secuencia = Convert.ToInt32(sec) + 1;
                }

                return Secuencia;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

    }
}
