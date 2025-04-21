using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Drawing;

namespace Core.Erp.Info.Compras
{
    public class com_ordencompra_local_Info
    {
        public int IdEmpresa { get; set; }
        public int IdSucursal { get; set; } 
        public decimal IdOrdenCompra { get; set; }
        public decimal IdProveedor { get; set; }
        public string oc_NumDocumento { get; set; }
        public string Tipo { get; set; }
        public string IdTerminoPago { get; set; }
        public int oc_plazo { get; set; }
        public DateTime? oc_fecha { get; set; }
        public double oc_flete { get; set; }
        public string oc_observacion { get; set; }
        public Nullable<int> IdProyecto { get; set; }
        public string nom_proyecto { get; set; }
        public DateTime? Fechreg { get; set; }
        public string Estado { get; set; }
        public string IdEstadoAprobacion_cat { get; set; }
        public string IdEstadoRecepcion_cat { get; set; }

        public string IdEstadoAprobacion_AUX { get; set; }

        public DateTime? co_fecha_aprobacion { get; set; }
        public string IdUsuario_Aprueba { get; set; }
        public string IdUsuario_Reprue { get; set; }
        public DateTime? co_fechaReproba { get; set; }
        public DateTime? Fecha_Transac { get; set; }
        public DateTime? Fecha_UltMod { get; set; }
        public string IdUsuarioUltMod { get; set; }
        public DateTime? FechaHoraAnul { get; set; }
        public string IdUsuarioUltAnu { get; set; }
        public double? oc_PesoTotal { get; set; }
        
        public string AfectaCosto { get; set; }
        public string MotivoAnulacion { get; set; }
        public Boolean check { get; set; }
        public string MotivoReprobacion { get; set; }
        public string Solicitante { get; set; }
        public string IdUsuario { get; set; }
        public string IdEstado_cierre { get; set; }
        public string IdEstado_cierre_aux { get; set; }


        public DateTime oc_fechaVencimiento { get; set; }

        public decimal? IdSolicitante { get; set; }
        public decimal IdComprador { get; set; }
        public decimal ? IdDepartamento { get; set; }
        public Nullable<int> IdSolicitud { get; set; }

        public Bitmap Ico { get; set; }

        public int ? IdMotivo { get; set; }

        public Boolean Mostrar_Solicitud { get; set; }


        // campos adicionales de la vista vwcom_ordencompra_local_sin_Guia_x_traspaso_bodega

        public string nom_proveedor { get; set; }
        public decimal IdProducto { get; set; }
        public string cod_producto { get; set; }
        public string nom_producto { get; set; }
        public double do_Cantidad { get; set; }
        public double do_precioCompra { get; set; }
        public double do_subtotal { get; set; }
        public int Secuencia { get; set; }

        // campos adicionales de la vista vwcom_ordencompra_local_sin_Guia_x_traspaso_bodega_consul

        public double Cantidad_enviar { get; set; }
        public string observacion_det_gui { get; set; }
        public decimal IdGuia { get; set; }
        public string Referencia_guia { get; set; }
        public  List<com_ordencompra_local_det_Info>  listDetalle { get; set; }

        public List<com_solicitud_compra_det_Info> listDetSoliciComp { get; set; }

        public string IdCatalogocompra { get; set; }

        public int ? Total_Reg_x_OC { get; set; }
        public int? Total_Reg_x_Guia { get; set; }

        

        public List<com_ordencompra_local_x_com_solicitud_compra_Info> lista_OC_x_Solicitud { get; set; }
        public List<com_ordencompra_local_det_x_com_solicitud_compra_det_Info> lista_OC_x_Solicitud_det { get; set; }       
       
        public  com_ordencompra_local_Info()
        {
            listDetalle = new List<com_ordencompra_local_det_Info>();
            listDetSoliciComp = new List<com_solicitud_compra_det_Info>();
            lista_OC_x_Solicitud = new List<com_ordencompra_local_x_com_solicitud_compra_Info>();
            lista_OC_x_Solicitud_det = new List<com_ordencompra_local_det_x_com_solicitud_compra_det_Info>();
        }

    }
}
