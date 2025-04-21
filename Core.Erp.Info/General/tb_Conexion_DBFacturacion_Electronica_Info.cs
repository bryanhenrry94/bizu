using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Info.General
{
    public class tb_Conexion_DBFacturacion_Electronica_Info
    {
        public int IdEmpresa { get; set; }
        public string Tipo_BaseDatos { get; set; }
        public string Servidor { get; set; }
        public Nullable<int> Puerto { get; set; }
        public Nullable<bool> AutenticacionWindows { get; set; }
        public string Usuario { get; set; }
        public string Contrasena { get; set; }
        public string Nombre_BaseDatos { get; set; }
        public string Cadena_Conexion { get; set; }
        public string Script_ComprobantesRecibidos { get; set; }
    }
}
