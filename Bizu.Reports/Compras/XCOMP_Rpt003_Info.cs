using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Bizu.Reports.Compras
{
    public class XCOMP_Rpt003_Info
    {
        public decimal IdRow { get; set; }

        public int IdEmpresa { get; set; }

        public int IdSucursal { get; set; }

        public int IdBodega { get; set; }

        public int IdMovi_inven_tipo { get; set; }

        public decimal IdNumMovi { get; set; }

        public string cm_tipo { get; set; }

        public string cm_observacion { get; set; }

        public DateTime cm_fecha { get; set; }

        public string Estado { get; set; }

        public string TipoMovi_Inven { get; set; }

        public decimal IdProducto { get; set; }

        public string cod_producto { get; set; }

        public double dm_cantidad { get; set; }

        public string dm_observacion { get; set; }

        public double dm_precio { get; set; }

        public double mv_costo { get; set; }

        public double dm_peso { get; set; }

        public string emp_nombre { get; set; }

        public string emp_ruc { get; set; }

        public string emp_tele { get; set; }

        public string emp_direccion { get; set; }

        public byte[] em_logo { get; set; }

        public decimal IdProveedor { get; set; }

        public bool do_ManejaIva { get; set; }

        public string IVA { get; set; }

        public double Subtotal { get; set; }

        public decimal IdOrdenCompra { get; set; }

        public string IdUnidadMedida { get; set; }

        public string nom_unidad { get; set; }

        public string pr_descripcion { get; set; }

        public string Su_Descripcion { get; set; }

        public string bo_Descripcion { get; set; }

        public string pr_nombre { get; set; }

        public string pr_codigo { get; set; }

        public int IdMotivo_Inv { get; set; }

        public string Desc_mov_inv { get; set; }

        public string Referencia { get; set; }

        public bool? EsDocumentoAutorizado { get; set; }

        public string NumGuia { get; set; }

        public string numDocumento { get; set; }

        public DateTime? Fecha_registro { get; set; }

        public string IdUsuario_registro { get; set; }

        public string IdCentroCosto { get; set; }

        public XCOMP_Rpt003_Info()
        {

        }
    }
}
