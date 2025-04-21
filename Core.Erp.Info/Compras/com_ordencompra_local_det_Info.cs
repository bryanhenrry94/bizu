using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Info.Compras
{
    public class com_ordencompra_local_det_Info
    {
        public List<com_solicitud_compra_det_Info> List_com_solicitud_compra_det = new List<com_solicitud_compra_det_Info>();

        public int IdEmpresa { get; set; }

        public int IdSucursal { get; set; }

        public decimal IdOrdenCompra { get; set; }

        public int Secuencia { get; set; }

        public decimal IdProducto { get; set; }

        public double do_Cantidad { get; set; }

        public double do_precioCompra { get; set; }

        public double do_porc_des { get; set; }

        public double do_descuento { get; set; }

        public double do_precioFinal { get; set; }

        public double do_subtotal { get; set; }

        public double do_iva { get; set; }

        public double do_total { get; set; }

        public string do_Costeado { get; set; }

        public double do_peso { get; set; }

        public string do_observacion { get; set; }

        public double Por_Iva { get; set; }

        public string IdCod_Impuesto { get; set; }

        public string codproducto { get; set; }


        public int? IdPunto_cargo_grupo { get; set; }

        public int? IdPunto_cargo { get; set; }

        public string IdCentroCosto { get; set; }

        public string IdCentroCosto_sub_centro_costo { get; set; }

        public string Nomsub_centro_costo { get; set; }

        public string IdUnidadMedida { get; set; }

        public string IdUnidadMedida_x_prod { get; set; }

        public string mv_observacion { get; set; }

        public double do_CantidadOC { get; set; }

        public double dm_cantidad_Inv { get; set; }

        public double dm_cantidad { get; set; }

        public double SaldoxRecibir { get; set; }

        public int mv_sec { get; set; }


        public string oc_NumDocumento { get; set; }


        public string solicitante { get; set; }

        public string UsuarioAprueba { get; set; }

        public string UsuarioReprueba { get; set; }

        public DateTime FechaAprob { get; set; }

        public DateTime FechaRep { get; set; }

        public string Esta_en_base { get; set; }

        public string Tiene_Movi_Inven { get; set; }

        public string Tiene_despacho { get; set; }

        public double cant_devuelta { get; set; }

        public double saldo_x_devolver { get; set; }


        public int? Idmotivo { get; set; }

        public string nom_motivo_OC { get; set; }

        public string Referencia { get; set; }

        public decimal? ID_Solicitante { get; set; }

        public string Nom_Solicitante { get; set; }

        public decimal IdProveedor { get; set; }

        public bool Checked { get; set; }

        public int IdGrupo { get; set; }

        public double costo { get; set; }

        public string nom_grupo { get; set; }

        public decimal? IdRubro { get; set; }
    }
}