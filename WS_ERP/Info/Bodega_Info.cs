using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace WS_ERP.Info
{
    [DataContract]
    public class Bodega_Info
    {
        [DataMember]
        public int IdEmpresa { get; set; }
        [DataMember]
        public int IdBodega { get; set; }
        [DataMember]
        public int IdSucursal { get; set; }
        [DataMember]
        public string cod_bodega { get; set; }
        [DataMember]
        public string bo_Descripcion { get; set; }
        [DataMember]
        public string bo_Descripcion2 { get; set; }
        [DataMember]
        public string cod_punto_emision { get; set; }
        [DataMember]
        public Boolean Estado { get; set; }
    }
}