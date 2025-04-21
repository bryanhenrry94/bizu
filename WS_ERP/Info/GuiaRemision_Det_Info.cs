using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace WS_ERP.Info
{
    [DataContract]
    public class GuiaRemision_Det_Info
    {
        [DataMember]
        public int IdEmpresa { get; set; }
        [DataMember]
        public int IdSucursal { get; set; }
        [DataMember]
        public decimal IdGuiaRemision { get; set; }
        [DataMember]
        public int Secuencia { get; set; }
        [DataMember]
        public Nullable<decimal> IdProducto { get; set; }
        [DataMember]
        public string Codigo { get; set; }
        [DataMember]
        public string Descripcion { get; set; }
        [DataMember]
        public string Detalle_x_Item { get; set; }
        [DataMember]
        public Nullable<double> Peso { get; set; }
        [DataMember]
        public double Cantidad { get; set; }
        [DataMember]
        public string IdUnidadMedida { get; set; }
        [DataMember]
        public Nullable<double> Cantidad_sinConversion { get; set; }
        [DataMember]
        public string IdUnidadMedida_sinConversion { get; set; }
        [DataMember]
        public string IdCentroCosto { get; set; }
    }
}