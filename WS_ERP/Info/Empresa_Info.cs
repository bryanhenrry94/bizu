using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace WS_ERP.Info
{
    [DataContract]
    public class Empresa_Info
    {
        [DataMember]
        public int IdEmpresa { get; set; }
        [DataMember]
        public string codigo { get; set; }
        [DataMember]
        public string em_nombre { get; set; }
        [DataMember]
        public string em_ruc { get; set; }
        [DataMember]
        public string em_direccion { get; set; }
        [DataMember]
        public string Estado { get; set; }
        [DataMember]
        public string RazonSocial { get; set; }
        [DataMember]
        public string NombreComercial { get; set; }
        [DataMember]
        public string ContribuyenteEspecial { get; set; }        
    }
}