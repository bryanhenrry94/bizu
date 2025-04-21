using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Info.General
{
    public class tb_Comprobantes_Recibidos_Info
    {
        public bool Checked { get; set; }
        public string descripcion_archi { get; set; }
        public string extencion { get; set; }
        public DateTime Fecha { get; set; }
        public string Asunto { get; set; }
        public string mail_emisor { get; set; }
        public string Serie1 { get; set; }
        public string Serie2 { get; set; }
        public string Secuencial { get; set; }
        public string Ced_Ruc_Emisor { get; set; }
        public string Razon_Social_emisor { get; set; }
        public string sXml { get; set; }
        public string IdTipo_Mensaje { get; set; }
        public string codMensajeId { get; set; }
        public string IdCuenta { get; set; }
        public string Texto_mensaje { get; set; }
        public string Secuencia { get; set; }
        public byte[] Archivo_adjunto { get; set; }
        public string Para { get; set; }
        public decimal IdMensaje { get; set; }
        public string Ambiente { get; set; }
        public string ClaveAcceso { get; set; }
        public string TipoDocumento { get; set; }
        public string NombreTipoDocumento { get; set; }
        public string FechaAutorizacion { get; set; }
        public string NumeroAutorizacion { get; set; }
        public string Estado_SRI { get; set; }
        public string Error { get; set; }
        public bool Esta_Provisionada { get; set; }
    }
}
