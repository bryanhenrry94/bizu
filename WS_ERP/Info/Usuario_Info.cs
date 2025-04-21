using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace WS_ERP.Info
{
    [DataContract]
    public class Usuario_Info
    {
        [DataMember]
        public int IdEmpresa { get; set; }
        [DataMember]
        public string IdUsuario { get; set; }
        [DataMember]
        public string Contrasena { get; set; }
        [DataMember]
        public string estado { get; set; }        
        [DataMember]
        public string Nombre { get; set; }

        public Usuario_Info() { }
    }
}