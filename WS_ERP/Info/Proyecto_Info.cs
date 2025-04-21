using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace WS_ERP.Info
{
    [DataContract]
    public class Proyecto_Info
    {
        [DataMember]
        public int IdEmpresa { get; set; }
        [DataMember]
        public int IdSucursal { get; set; }
        [DataMember]
        public int IdProyecto { get; set; }
        [DataMember]
        public string Codigo { get; set; }
        [DataMember]
        public string Nombre { get; set; }
        [DataMember]
        public string IdEstadoAprobacion { get; set; }
        [DataMember]
        public string IdEstadoCierre { get; set; }
        [DataMember]
        public Nullable<decimal> IdCliente { get; set; }
        [DataMember]
        public Nullable<int> IdResidente { get; set; }
        [DataMember]
        public DateTime FechaInicio { get; set; }
        [DataMember]
        public DateTime FechaFin { get; set; }
        [DataMember]
        public string Observacion { get; set; }
        [DataMember]
        public string IdCentroCosto { get; set; }
        [DataMember]
        public string DireccionObra { get; set; }
        [DataMember]
        public string Correo_obra { get; set; }
        [DataMember]
        public Nullable<int> IdBodega_Obra { get; set; }
        [DataMember]
        public string Estado { get; set; }
        [DataMember]
        public Nullable<DateTime> FechaCreacion { get; set; }
        [DataMember]
        public string IdUsuarioCreacion { get; set; }
        [DataMember]
        public Nullable<DateTime> FechaModificacion { get; set; }
        [DataMember]
        public string IdUsuarioModificacion { get; set; }
        [DataMember]
        public Nullable<DateTime> FechaAnulacion { get; set; }
        [DataMember]
        public string IdUsuarioAnulacion { get; set; }
        [DataMember]
        public string MotivoAnulacion { get; set; }
        [DataMember]
        public string IdUsuarioAprueba { get; set; }
        [DataMember]
        public Nullable<DateTime> FechaAprueba { get; set; }
        [DataMember]
        public string CodigoError { get; set; }
        [DataMember]
        public string MensajeError { get; set; }
    }
}