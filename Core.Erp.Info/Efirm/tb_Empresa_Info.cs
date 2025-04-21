using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Drawing;

namespace Core.Erp.Info.Efirm
{
    [DataContract]
    public class tb_Empresa_Info
    {
       
        [DataMember]
        public int IdEmpresa { get; set; }
        [DataMember]
        public string RazonSocial { get; set; }
        [DataMember]
        public string NombreComercial { get; set; }
        [DataMember]
        public string RUC { get; set; }
        [DataMember]
        public string DirMatriz { get; set; }
        [DataMember]
        public string ContribuyenteEspecial { get; set; }
        [DataMember]
        public string ObligadoAllevarConta { get; set; }
        public string NombreCertificado { get; set; }
        public string Clave_Certificado { get; set; }

        // [DataMember]
        //public int IdAmbiente { get; set; }
        // [DataMember]
        //public int TipoEmision { get; set; }

        public Nullable<System.DateTime> FechaValidez { get; set; }
        [DataMember]
        public bool Estado { get; set; }
        [DataMember]
        public byte[] logo { get; set; }

        [DataMember]
        public string logo_base64string { get; set; }

        public string IdToquenAFirmar { get; set; }

        [DataMember]
        public string Alias { get; set; }

         [DataMember]
        public string cod_Ambiente { get; set; }
         [DataMember]
        public string cod_TipoEmision { get; set; }

         [DataMember]
         public string url { get; set; }

        public int IdEmpresAUX { get; set; }


        public Image imagen { get; set; }
           
        public int ValidaImagen { get; set; }

        public string Nemonico_RIDE { get; set; }

        public string Tipo_Notificacion_a_cliente { get; set; }
        public string Tipo_Base_Exterior { get; set; }
        public string cadena_conexion_Exterior { get; set; }
        public string Cod_Empresa_Para_DB_Ext { get; set; }

        public string Formato_fecha_Base_ext { get; set; }
        public string Formato_hora_Base_ext { get; set; }
        public string Nombre_tabla_Base_ext { get; set; }

        public int DiasExpirar { get; set; }

        public tb_Empresa_Info()
        {

        }
        public tb_Empresa_Info(int IdEmpresa_, string RazonSocial_)
        {
            IdEmpresa = IdEmpresa_;
            RazonSocial = RazonSocial_;
        }

    }
}
