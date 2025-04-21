using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace WS_ERP.Info
{
    [DataContract]
    public class Sucursal_Info
    {
        [DataMember]
        public int IdEmpresa { get; set; }
        [DataMember]
        public int IdSucursal { get; set; }
        [DataMember]
        public string Su_Descripcion { get; set; }
        [DataMember]
        public string codigo { get; set; }
        [DataMember]
        public string Su_CodigoEstablecimiento { get; set; }
        [DataMember]
        public string Su_Ubicacion { get; set; }
        [DataMember]
        public string Su_Ruc { get; set; }
        [DataMember]
        public string Su_JefeSucursal { get; set; }
        [DataMember]
        public string Su_Telefonos { get; set; }
        [DataMember]
        public string Su_Direccion { get; set; }
    }
}