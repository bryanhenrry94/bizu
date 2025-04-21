using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace WS_ERP.Info
{
    [DataContract]
    public class Talonario_Info
    {
        [DataMember]
        public int IdEmpresa { get; set; }
        [DataMember]
        public string CodDocumentoTipo { get; set; }
        [DataMember]
        public string Establecimiento { get; set; }
        [DataMember]
        public string PuntoEmision { get; set; }
        [DataMember]
        public string NumDocumento { get; set; }
        [DataMember]
        public DateTime? FechaCaducidad { get; set; }
        [DataMember]
        public bool? Usado { get; set; }
        [DataMember]
        public string Estado { get; set; }
        [DataMember]
        public int IdSucursal { get; set; }
        [DataMember]
        public string NumAutorizacion { get; set; }
        [DataMember]
        public string NombreSucursal { get; set; }
        [DataMember]
        public string NombreEmpresa { get; set; }
        [DataMember]
        public bool es_Documento_electronico { get; set; } 
    }
}