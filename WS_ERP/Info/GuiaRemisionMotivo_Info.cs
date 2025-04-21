using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace WS_ERP.Info
{
    [DataContract]
    public class GuiaRemisionMotivo_Info
    {
        [DataMember]
        public int IdEmpresa { get; set; }
        [DataMember]
        public int IdMotivo { get; set; }
        [DataMember]
        public string Codigo { get; set; }
        [DataMember]
        public string Descripcion { get; set; }
        [DataMember]
        public string Estado { get; set; }
    }
}