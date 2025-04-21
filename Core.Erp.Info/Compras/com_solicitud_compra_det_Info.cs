using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Core.Erp.Info.Compras
{
   public class com_solicitud_compra_det_Info
    {
        public int IdEmpresa { get; set; }

        public int IdSucursal { get; set; }

        public decimal IdSolicitudCompra { get; set; }

        public int Secuencia { get; set; }

        public DateTime fecha { get; set; }

        public int plazo { get; set; }

        public DateTime fecha_vtc { get; set; }

        public string observacion { get; set; }

        public decimal? IdProducto { get; set; }

        public double do_Cantidad { get; set; }

        public string do_observacion { get; set; }

        public string Ref_Solicitud { get; set; }

        public string NomProducto { get; set; }

        public decimal pr_stock { get; set; }

        public string pr_descripcion { get; set; }

        public bool Checked { get; set; }

        public string DetallexItems { get; set; }

        public string nom_Proyecto { get; set; }

        public int? IdOferta { get; set; }

        public string cod_Oferta { get; set; }

        public string nom_Oferta { get; set; }

        public string nom_Oferta_2 { get; set; }

        public double Peso { get; set; }

        public double Precio { get; set; }

        public double Porc_Descuento { get; set; }

        public double Descuento { get; set; }

        public double PrecioFinal { get; set; }

        public double Subtotal { get; set; }

        public double Iva { get; set; }

        public double Total { get; set; }

        public bool Paga_Iva { get; set; }

        public string IdCentroCosto { get; set; }

        public string NomCentroCosto { get; set; }

        public string IdCentroCosto_sub_centro_costo { get; set; }

        public string Nomsub_centro_costo { get; set; }

        public string nom_punto_cargo { get; set; }

        public string cod_producto { get; set; }

        public string nom_producto_princ { get; set; }

        public int? IdPunto_cargo_grupo { get; set; }

        public int? IdPunto_cargo { get; set; }

        public string IdUnidadMedida { get; set; }

        public string nom_Unidad { get; set; }

        public string nom_Unidad_Alterno { get; set; }

        public string nom_Sucursal { get; set; }

        public string IdEstadoAprobacion { get; set; }

        public string IdEstadoAprobacion_AUX { get; set; }

        public Bitmap Ico1 { get; set; }

        public double do_CantidadSolicitud { get; set; }

        public double do_CantidadPedida { get; set; }

        public double do_Saldo { get; set; }

        public int? IdProyecto { get; set; }

        public decimal IdSolicitante { get; set; }

        public string nom_solicitante { get; set; }

        public string IdCategoria { get; set; }

        public string ca_Categoria { get; set; }

        public int IdLinea { get; set; }

        public string nom_linea { get; set; }

        public int? Secuencia_Oferta { get; set; }

        public string cod_Rubro { get; set; }

        public string nom_Rubro { get; set; }

        public string nom_Rubro_2 { get; set; }

        public string Estado { get; set; }

        public Bitmap Icono { get; set; }

        public int Dias_Vencidos { get; set; }

        public Nullable<decimal> IdRubro { get; set; }

        public Nullable<int> IdEmpresa_obr_AsignacionPorcentual { get; set; }
        public Nullable<int> IdSucursal_obr_AsignacionPorcentual { get; set; }
        public Nullable<int> IdProyecto_obr_AsignacionPorcentual { get; set; }
        public Nullable<int> IdOferta_obr_AsignacionPorcentual { get; set; }
        public Nullable<int> Secuencia_obr_AsignacionPorcentual { get; set; }
        public string Descripcion_AsignacionPorcentual { get; set; }
        public Nullable<double> Porcentaje_AsignacionPorcentual { get; set; }
        public Nullable<double> Valor_AsignacionPorcentual { get; set; }

        public com_solicitud_compra_det_Info(){}
    }
}
