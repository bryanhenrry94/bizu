using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace WS_ERP.Info
{
    [DataContract]
    public class GuiaRemision_Info
    {              
        private int _IdEmpresa;
        private int _IdSucursal;        
        private decimal _IdGuiaRemision { get; set; }        
        private Nullable<int> _IdBodega { get; set; }        
        private string _FechaEmision { get; set; }
        private string _FechaTrasladoIni { get; set; }
        private string _FechaTrasladoFin { get; set; }
        private string _Serie1 { get; set; }
        private string _Serie2 { get; set; }
        private string _NumDocumento { get; set; }
        private string _IdTipo_Persona { get; set; }
        private decimal _IdEntidad { get; set; }        
        private string _IdCentroCosto { get; set; }
        private string _Origen { get; set; }
        private string _Destino { get; set; }
        private string _Observacion { get; set; }
        private int _IdMotivo { get; set; }
        private string _Estado { get; set; }
        private string _IdUsuarioCreacion { get; set; }
        private string _FechaCreacion { get; set; }
        private string _IdUsuarioModificacion { get; set; }        
        private int _IdTransportista { get; set; }        
        private string _Placa { get; set; }
        private string _Ruta { get; set; }
        private string _Correo { get; set; }
        private string _CedulaRuc { get; set; }
        private List<GuiaRemision_Det_Info> _GuiaRemision_Det { get; set; }
        private string _CodigoError { get; set; }
        private string _MensajeError { get; set; }
        private string _Options { get; set; }        

        public GuiaRemision_Info()
        {
            this.GuiaRemision_Det = new List<GuiaRemision_Det_Info>();
        }

        [DataMember]
        public int IdEmpresa
        {
            get { return _IdEmpresa; }
            set { _IdEmpresa = value; }
        }

        [DataMember]
        public int IdSucursal
        {
            get { return _IdSucursal; }
            set { _IdSucursal = value; }
        }

        [DataMember]
        public decimal IdGuiaRemision
        {
            get { return _IdGuiaRemision; }
            set { _IdGuiaRemision = value; }
        }

        [DataMember]
        public Nullable<int> IdBodega
        {
            get { return _IdBodega; }
            set { _IdBodega = value; }
        }

        [DataMember]
        public string FechaEmision
        {
            get { return _FechaEmision; }
            set { _FechaEmision = value; }
        }

        [DataMember]
        public string FechaTrasladoIni
        {
            get { return _FechaTrasladoIni; }
            set { _FechaTrasladoIni = value; }
        }

        [DataMember]
        public string FechaTrasladoFin
        {
            get { return _FechaTrasladoFin; }
            set { _FechaTrasladoFin = value; }
        }

        [DataMember]
        public string Serie1
        {
            get { return _Serie1; }
            set { _Serie1 = value; }
        }

        [DataMember]
        public string Serie2
        {
            get { return _Serie2; }
            set { _Serie2 = value; }
        }

        [DataMember]
        public string NumDocumento
        {
            get { return _NumDocumento; }
            set { _NumDocumento = value; }
        }

        [DataMember]
        public string IdTipo_Persona
        {
            get { return _IdTipo_Persona; }
            set { _IdTipo_Persona = value; }
        }

        [DataMember]
        public decimal IdEntidad
        {
            get { return _IdEntidad; }
            set { _IdEntidad = value; }
        }         

        [DataMember]
        public string IdCentroCosto
        {
            get { return _IdCentroCosto; }
            set { _IdCentroCosto = value; }
        }

        [DataMember]
        public string Origen
        {
            get { return _Origen; }
            set { _Origen = value; }
        }

        [DataMember]
        public string Destino
        {
            get { return _Destino; }
            set { _Destino = value; }
        }

        [DataMember]
        public string Observacion
        {
            get { return _Observacion; }
            set { _Observacion = value; }
        }

        [DataMember]
        public int IdMotivo
        {
            get { return _IdMotivo; }
            set { _IdMotivo = value; }
        }

        [DataMember]
        public string Estado
        {
            get { return _Estado; }
            set { _Estado = value; }
        }

        [DataMember]
        public string IdUsuarioCreacion
        {
            get { return _IdUsuarioCreacion; }
            set { _IdUsuarioCreacion = value; }
        }

        [DataMember]
        public string FechaCreacion
        {
            get { return _FechaCreacion; }
            set { _FechaCreacion = value; }
        }

        [DataMember]
        public int IdTransportista
        {
            get { return _IdTransportista; }
            set { _IdTransportista = value; }
        }

        [DataMember]
        public string Placa
        {
            get { return _Placa; }
            set { _Placa = value; }
        }

        [DataMember]
        public string Ruta
        {
            get { return _Ruta; }
            set { _Ruta = value; }
        }

        [DataMember]
        public string Correo
        {
            get { return _Correo; }
            set { _Correo = value; }
        }

        [DataMember]
        public string CedulaRuc
        {
            get { return _CedulaRuc; }
            set { _CedulaRuc = value; }
        }

        [DataMember]
        public List<GuiaRemision_Det_Info> GuiaRemision_Det
        {
            get { return _GuiaRemision_Det; }
            set { _GuiaRemision_Det = value; }
        }
       
        [DataMember]
        public string CodigoError
        {
            get { return _CodigoError; }
            set { _CodigoError = value; }
        }

        [DataMember]
        public string MensajeError
        {
            get { return _MensajeError; }
            set { _MensajeError = value; }
        }

        [DataMember]
        public string Options
        {
            get { return _Options; }
            set { _Options = value; }
        }
    }
}