using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WS_ERP.Info;

namespace WS_ERP
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IWs_General" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IWs_General
    {
        [OperationContract]
        Response_Info Transportista_Grabar(Transportista_Info Info);

        [OperationContract]
        Response_Info Transportista_Actualizar(Transportista_Info Info);

        [OperationContract]
        Response_Info Transportista_Anular(int IdEmpresa, decimal IdTransportista, string IdUsuarioAnul, string MotivoAnul);

        [OperationContract]
        Response_Info Transportista_GetAllByIdEmpresa(int IdEmpresa);

        [OperationContract]
        Response_Info Transportista_GetOneByIdTransportista(int IdEmpresa, decimal IdTransportista);

        [OperationContract]
        Response_Info Get_Ultimo_Talonario_No_Usado(int IdEmpresa, string puntoemision, string establecimiento, string tipodoc, bool Es_Documento_Electronico);

        [OperationContract]
        Response_Info PersonaTipo_GetAll();
        
        [OperationContract]
        Response_Info Beneficiario_GetAllByIdTipoPersona(int IdEmpresa, string IdTipoPersona);

        [OperationContract]
        Response_Info Persona_GetOneByIdPersona(decimal IdPersona);

        [OperationContract]
        Response_Info Persona_GetOneByIdentificacion(string IdTipoDocumento, string CedulaRuc);

        [OperationContract]
        Response_Info Sucursal_GetAllByIdEmpresa(int IdEmpresa);

        [OperationContract]
        Response_Info Empresa_GetAll();

        [OperationContract]
        Response_Info Empresa_GetOneByIdEmpresa(int IdEmpresa);

        [OperationContract]
        Response_Info Empresa_GetAllByIdUsuario(string IdUsuario);

        [OperationContract]
        Response_Info Bodega_GetAll(int IdEmpresa, int IdSucursal);
    }
}
