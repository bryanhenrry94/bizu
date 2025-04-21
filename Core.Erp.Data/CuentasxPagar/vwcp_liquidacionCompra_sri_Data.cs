using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Info.CuentasxPagar;

namespace Core.Erp.Data.CuentasxPagar
{
    public class vwcp_liquidacionCompra_sri_Data
    {
        public List<vwcp_liquidacionCompra_sri_Info> Get_list_LiquidacionCompra_Sri(int IdEmpresa, decimal IdLiquidacionCompra, ref string msg)
        {
            cp_liquidacion_compra_Data Data = new cp_liquidacion_compra_Data();

            try
            {
                EntitiesCuentasxPagar Context = new EntitiesCuentasxPagar();

                List<vwcp_liquidacionCompra_sri_Info> Lista = new List<vwcp_liquidacionCompra_sri_Info>();

                var query = from q in Context.vwcp_liquidacionCompra_sri
                            where q.IdEmpresa == IdEmpresa                            
                            && q.IdLiquidacionCompra == IdLiquidacionCompra
                            select q;

                foreach (var item in query)
                {
                    vwcp_liquidacionCompra_sri_Info Info = new vwcp_liquidacionCompra_sri_Info();
                    Info.IdEmpresa = item.IdEmpresa;
                    Info.IdLiquidacionCompra = item.IdLiquidacionCompra;
                    Info.serie = item.serie;
                    Info.numDocumento = item.numDocumento;
                    Info.fecha = item.fecha;
                    Info.pe_nombreCompleto = item.pe_nombreCompleto;
                    Info.pe_razonSocial = item.pe_razonSocial;
                    Info.pe_cedulaRuc = item.pe_cedulaRuc;
                    Info.pe_correo = item.pe_correo;
                    Info.pe_direccion = item.pe_direccion;
                    Info.pe_telfono_Contacto = item.pe_telfono_Contacto;
                    Info.IdProveedor = item.IdProveedor;
                    Info.co_serie = item.co_serie;
                    Info.co_factura = item.co_factura;
                    Info.co_FechaFactura = item.co_FechaFactura;
                    Info.IdOrden_giro_Tipo = item.IdOrden_giro_Tipo;
                    Info.IdTipoDocumento = item.IdTipoDocumento;
                    Info.IdSucursal = item.IdSucursal;
                    Info.Su_Descripcion = item.Su_Descripcion;
                    Info.Su_Direccion = item.Su_Direccion;
                    Info.RazonSocial = item.RazonSocial;
                    Info.NombreComercial = item.NombreComercial;
                    Info.ContribuyenteEspecial = item.ContribuyenteEspecial;
                    Info.ObligadoAllevarConta = item.ObligadoAllevarConta;
                    Info.em_ruc = item.em_ruc;
                    Info.em_direccion = item.em_direccion;
                    Info.CorreoPrincipal = item.CorreoPrincipal;
                    Info.CorreoSecundario = item.CorreoSecundario;
                    Info.CorreoAlterno = item.CorreoAlterno;
                    Info.Estado = item.Estado;

                    Lista.Add(Info);
                }

                return Lista;
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ValidarObjeto_XML_LiquidacionCompra", ex.Message), ex) { EntityType = typeof(vwcp_liquidacionCompra_sri_Info) };
            }
        }
    }
}
