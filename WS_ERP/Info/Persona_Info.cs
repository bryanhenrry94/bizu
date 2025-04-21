using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace WS_ERP.Info
{
    [DataContract]
    public class Persona_Info
    {
        [DataMember]
        public int IdEmpresa { get; set; }
        [DataMember]
        public decimal IdPersona { get; set; }
        [DataMember]
        public string CodPersona { get; set; }
        [DataMember]
        public string pe_Naturaleza { get; set; }
        [DataMember]
        public string pe_nombreCompleto { get; set; }
        [DataMember]
        public string pe_razonSocial { get; set; }
        [DataMember]
        public string pe_apellido { get; set; }
        [DataMember]
        public string pe_nombre { get; set; }
        [DataMember]
        public int IdTipoPersona { get; set; }
        [DataMember]
        public string IdTipoDocumento { get; set; }
        [DataMember]
        public string pe_cedulaRuc { get; set; }
        [DataMember]
        public string pe_direccion { get; set; }
        [DataMember]
        public string pe_telefonoCasa { get; set; }
        [DataMember]
        public string pe_telefonoOfic { get; set; }
        [DataMember]
        public string pe_telefonoInter { get; set; }
        [DataMember]
        public string pe_telfono_Contacto { get; set; }
        [DataMember]
        public string pe_celular { get; set; }
        [DataMember]
        public string pe_correo { get; set; }
    }
}