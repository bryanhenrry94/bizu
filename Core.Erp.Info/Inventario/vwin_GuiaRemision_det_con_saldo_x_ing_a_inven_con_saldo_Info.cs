using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Info.Inventario
{
    public class vwin_GuiaRemision_det_con_saldo_x_ing_a_inven_con_saldo_Info
    {
        public long fila { get; set; }
        public int IdEmpresa { get; set; }
        public int IdSucursal { get; set; }
        public decimal IdGuiaRemision { get; set; }
        public int Secuencia { get; set; }
        public Nullable<int> IdBodega { get; set; }
        public System.DateTime FechaEmision { get; set; }
        public string Serie1 { get; set; }
        public string Serie2 { get; set; }
        public string NumDocumento { get; set; }
        public string NumGuia { get; set; }
        public string IdTipo_Persona { get; set; }
        public decimal IdEntidad { get; set; }
        public string pe_nombreCompleto { get; set; }
        public Nullable<int> IdProyecto { get; set; }
        public string NomProyecto { get; set; }
        public string IdEstadoCierre { get; set; }
        public string IdCentroCosto { get; set; }
        public string Centro_costo { get; set; }
        public string Centro_costo2 { get; set; }
        public string Origen { get; set; }
        public string Destino { get; set; }
        public string Observacion { get; set; }
        public int IdMotivo { get; set; }
        public string Estado { get; set; }
        public Nullable<System.DateTime> FechaAutorizacion { get; set; }
        public string NumAutorizacion { get; set; }
        public Nullable<decimal> IdProducto { get; set; }
        public string Codigo { get; set; }
        public string Descripcion { get; set; }
        public string Detalle_x_Item { get; set; }
        public double cantidad_GR { get; set; }
        public Nullable<double> Peso { get; set; }
        public Nullable<double> cantidad_sinConversion_GR { get; set; }
        public string IdUnidadMedida { get; set; }
        public string IdUnidadMedida_sinConversion { get; set; }
        public Nullable<double> cantidad_ing_a_Inven { get; set; }
        public Nullable<double> cantidad_ingresada { get; set; }
        public Nullable<double> Saldo_GR_x_Ing { get; set; }
    }
}