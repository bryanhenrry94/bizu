using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Runtime.Serialization;
using System.ServiceModel;
using System.Drawing;

namespace Bizu.Domain.Efirm
{
    [DataContract]
    public class tb_Comprobante_Info
    {
        public Boolean Checked { get; set; }
        [DataMember]
        public int IdEmpresa { get; set; }
        [DataMember]
        public string IdComprobante { get; set; }
        [DataMember]
        public string IdTipoDocumento { get; set; }
        [DataMember]
        public string IdEstado_cbte { get; set; }
        [DataMember]
        public string Cedula_Ruc { get; set; }
        [DataMember]
        public string Numero_Autorizacion { get; set; }
        [DataMember]
        public string s_XML { get; set; }
        [DataMember]
        public DateTime? Fecha_Emi_Fact { get; set; }
        [DataMember]
        public DateTime? Fecha_transaccion { get; set; }
        [DataMember]
        public DateTime? FechaAutorizacion { get; set; }
        [DataMember]
        public string ClaveContingencia { get; set; }
        [DataMember]
        public string RutaArchivo { get; set; }
        [DataMember]
        public string EstadoDoc { get; set; }
        [DataMember]
        public string Error { get; set; }
        [DataMember]
        public string IdEstadoProceso { get; set; }
        [DataMember]
        public string IdError_Sri { get; set; }
        [DataMember]
        public string Nombre_file { get; set; }
        public string MensajeSubida { get; set; }
        public string Nom_emisor { get; set; }
        [DataMember]
        public string Nom_TipoDocumento { get; set; }
        [DataMember]
        public string nom_Tipo_doc { get; set; }
        public string Nom_estado_doc { get; set; }
        public string NomCertificado { get; set; }
        [DataMember]
        public string RespuestaSRI { get; set; }
        public Boolean MosTrar_icono_Ride { get; set; }
        public Boolean MosTrar_icono_xml { get; set; }
        [DataMember]
        public Nullable<double> Total { get; set; }
        public Image LogoEmpresa { get; set; }
        public string sFechaAutorizacion { get; set; }
        public string sFecha_transaccion { get; set; }
        public Nullable<long> NumFila { get; set; }
        public Boolean Mostrar_Icon_Eliminar { get; set; }
        public string Ambiente { get; set; }
        [DataMember]
        public Nullable<decimal> TotalRegistros { get; set; }
        public string Clave_Acceso { get; set; }
        public string Nom_Contribuyente { get; set; }
        public decimal? IdContribuyente { get; set; }
        public string Tipo_Base_Exterior { get; set; }
        public string cadena_conexion_Exterior { get; set; }
        public string Cod_Empresa_Para_DB_Ext { get; set; }
        public Boolean Mostrar_IconoExportar { get; set; }
        public Boolean Mostrar_IconoGuardar { get; set; }
        public Boolean Mostrar_Icono_EnviadoMail { get; set; }
        public Boolean Exportado { get; set; }
        public string msgError { get; set; }
    }
}