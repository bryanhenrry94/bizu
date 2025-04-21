using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace WS_ERP.Info
{
    [DataContract]
    public class Transportista_Info
    {
        [DataMember]
        public int IdEmpresa { get; set; }
        [DataMember]
        public decimal IdTransportista { get; set; }
        [DataMember]
        public string IdTipoDocumento { get; set; }
        [DataMember]
        public decimal IdPersona { get; set; }
        [DataMember]
        public string Estado { get; set; }
        [DataMember]
        public string Nombre { get; set; }
        [DataMember]
        public string Cedula { get; set; }
        [DataMember]
        public string Placa { get; set; }
        [DataMember]
        public string pe_nombreCompleto { get; set; }
        [DataMember]
        public string IdUsuario { get; set; }
        [DataMember]
        public DateTime Fecha_Transaccion { get; set; }
        [DataMember]
        public string IdUsuarioUltMod { get; set; }
        [DataMember]
        public DateTime Fecha_UltMod { get; set; }
        [DataMember]
        public string IdUsuarioUltAnu { get; set; }
        [DataMember]
        public DateTime Fecha_UltAnu { get; set; }
        [DataMember]
        public string MotivoAnu { get; set; }
    }
}