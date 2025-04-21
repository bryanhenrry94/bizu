using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace WS_ERP.Info
{
    [DataContract]
    public class Producto_Info
    {
        [DataMember]
        public int IdEmpresa { get; set; }
        [DataMember]
        public decimal IdProducto { get; set; }
        [DataMember]
        public string pr_codigo { get; set; }
        [DataMember]
        public string pr_descripcion { get; set; }
        [DataMember]
        public string pr_descripcion_2 { get; set; }
        [DataMember]
        public string pr_codigo_barra { get; set; }
        [DataMember]
        public int IdProductoTipo { get; set; }
        [DataMember]
        public string pr_observacion { get; set; }
        [DataMember]
        public string IdUnidadMedida { get; set; }
        [DataMember]
        public string IdUnidadMedida_Consumo { get; set; }
        [DataMember]
        public double? pr_costo_promedio { get; set; }
        [DataMember]
        public double? pr_peso { get; set; }
        [DataMember]
        public double? pr_stock { get; set; }
        [DataMember]
        public double? pr_Disponible { get; set; }
        [DataMember]
        public string IdCategoria { get; set; }
        [DataMember]
        public int IdLinea { get; set; }
        [DataMember]
        public int IdGrupo { get; set; }
        [DataMember]
        public int IdSubGrupo { get; set; }
        [DataMember]
        public string Ubicacion1 { get; set; }
        [DataMember]
        public string Ubicacion2 { get; set; }

        [DataMember]
        public string CodigoError { get; set; }
        [DataMember]
        public string MensajeError { get; set; }   
    }
}