using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Bizu.Domain.Inventario
{
    public class in_GuiaRemision_Info
    {
        public in_GuiaRemision_Info()
        {
            this.in_GuiaRemision_Det = new List<in_GuiaRemision_Det_Info>();
        }
    
        public int IdEmpresa { get; set; }
        public int IdSucursal { get; set; }
        public string Su_Descripcion { get; set; }
        public decimal IdGuiaRemision { get; set; }
        public Nullable<int> IdBodega { get; set; }
        public string nom_bodega { get; set; }
        public System.DateTime FechaEmision { get; set; }
        public System.DateTime FechaTrasladoIni { get; set; }
        public System.DateTime FechaTrasladoFin { get; set; }
        public string Serie1 { get; set; }
        public string Serie2 { get; set; }
        public string NumDocumento { get; set; }
        public string IdTipo_Persona { get; set; }
        public decimal IdEntidad { get; set; }
        public string pe_nombreCompleto { get; set; }
        public string pe_cedulaRuc { get; set; }
        public Nullable<int> IdProyecto { get; set; }
        public string NomProyecto { get; set; }
        public string IdCentroCosto { get; set; }
        public string Centro_costo { get; set; }
        public string Origen { get; set; }
        public string Destino { get; set; }
        public string Observacion { get; set; }
        public int IdMotivo { get; set; }
        public string Motivo { get; set; }
        public string IdEstado_cierre { get; set; }
        public string Estado { get; set; }
        public string IdUsuarioCreacion { get; set; }
        public Nullable<System.DateTime> FechaCreacion { get; set; }
        public string IdUsuarioModificacion { get; set; }
        public Nullable<System.DateTime> FechaModificacion { get; set; }
        public string IdUsuarioAnulacion { get; set; }
        public Nullable<System.DateTime> FechaAnulacion { get; set; }
        public string MotivoAnulacion { get; set; }
        public Nullable<System.DateTime> FechaAutorizacion { get; set; }
        public string NumAutorizacion { get; set; }
        public int IdTransportista { get; set; }        
        public string CedulaTransportista { get; set; }
        public string NombreTransportista { get; set; }
        public string Placa { get; set; }
        public string Ruta { get; set; }
        public string Correo { get; set; }
        public Bitmap Icono_pdf { get; set; }
        public Bitmap Icono_xml { get; set; }
    
        public List<in_GuiaRemision_Det_Info> in_GuiaRemision_Det { get; set; }
        public in_GuiaRemision_Exportacion_Info in_GuiaRemision_Exportacion { get; set; }        

    }
}
