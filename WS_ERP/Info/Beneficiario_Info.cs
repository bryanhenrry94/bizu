using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace WS_ERP.Info
{
    [DataContract]
    public class Beneficiario_Info
    {
        [DataMember]
        public int IdEmpresa { get; set; }
        [DataMember]
        public string IdBeneficiario { get; set; }
        [DataMember]
        public string IdTipo_Persona { get; set; }
        [DataMember]
        public decimal IdPersona { get; set; }
        [DataMember]
        public decimal IdEntidad { get; set; }
        [DataMember]
        public string Codigo { get; set; }
        [DataMember]
        public string Nombre { get; set; }
        [DataMember]
        public string pr_girar_cheque_a { get; set; }
        [DataMember]
        public string pe_razonSocial { get; set; }
        [DataMember]
        public string pe_cedulaRuc { get; set; }
        [DataMember]
        public string pe_Naturaleza { get; set; }
        [DataMember]
        public string IdCtaCble { get; set; }
        [DataMember]
        public string IdCentroCosto { get; set; }
        [DataMember]
        public string IdSubCentroCosto { get; set; }
        [DataMember]
        public decimal secuencial { get; set; }
        [DataMember]
        public string NombreCompleto { get; set; }
        [DataMember]
        public string IdCtaCble_Anticipo { get; set; }
        [DataMember]
        public string IdCtaCble_Gasto { get; set; }
        [DataMember]
        public string Estado { get; set; }
        [DataMember]
        public string ba_descripcion { get; set; }
        [DataMember]
        public string num_cta_acreditacion { get; set; }
        [DataMember]
        public string IdTipoCta_acreditacion_cat { get; set; }
        [DataMember]
        public string IdTipoDocumento { get; set; }
        [DataMember]
        public string CodigoLegal { get; set; }
        [DataMember]
        public string datosEdhesa { get; set; }
        [DataMember]
        public string pe_correo { get; set; }
    }
}