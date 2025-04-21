using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Info.CuentasxPagar
{
    public class vwcp_liquidacionCompra_sri_Info
    {
        public int IdEmpresa { get; set; }
        public decimal IdLiquidacionCompra { get; set; }
        public string serie { get; set; }
        public string numDocumento { get; set; }
        public System.DateTime fecha { get; set; }
        public string pe_nombreCompleto { get; set; }
        public string pe_razonSocial { get; set; }
        public string pe_cedulaRuc { get; set; }
        public string pe_correo { get; set; }
        public string pe_direccion { get; set; }
        public string pe_telfono_Contacto { get; set; }
        public decimal IdProveedor { get; set; }
        public string co_serie { get; set; }
        public string co_factura { get; set; }
        public System.DateTime co_FechaFactura { get; set; }
        public string IdOrden_giro_Tipo { get; set; }
        public string IdTipoDocumento { get; set; }
        public Nullable<int> IdSucursal { get; set; }
        public string Su_Descripcion { get; set; }
        public string Su_Direccion { get; set; }
        public string RazonSocial { get; set; }
        public string NombreComercial { get; set; }
        public string ContribuyenteEspecial { get; set; }
        public string ObligadoAllevarConta { get; set; }
        public string em_ruc { get; set; }
        public string em_direccion { get; set; }
        public string CorreoPrincipal { get; set; }
        public string CorreoSecundario { get; set; }
        public string CorreoAlterno { get; set; }
        public string Estado { get; set; }

        public List<cp_liquidacion_compra_det_Info> LiquidacionCompra_Det;

        public vwcp_liquidacionCompra_sri_Info()
        {
            LiquidacionCompra_Det = new List<cp_liquidacion_compra_det_Info>();
        }
    }
}
