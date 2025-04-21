using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace WS_ERP.Info
{
    [DataContract]
    public class CentroCosto_Info
    {
        [DataMember]
        public int IdEmpresa { get; set; }
        [DataMember]
        public string IdCentroCosto { get; set; }
        [DataMember]
        public string Centro_costo { get; set; }
        [DataMember]
        public string Centro_costo2 { get; set; }
    }
}