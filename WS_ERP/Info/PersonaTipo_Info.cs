using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace WS_ERP.Info
{
    [DataContract]
    public class PersonaTipo_Info
    {
        [DataMember]
        public string IdTipo_Persona { get; set; }
        [DataMember]
        public string Descripcion { get; set; }
    }
}