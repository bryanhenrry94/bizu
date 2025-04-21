using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WS_ERP.Info;

namespace WS_ERP
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IWs_Facturacion" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IWs_Facturacion
    {
        [OperationContract]
        Response_Info Cliente_GetOneByIdCliente(int IdEmpresa, decimal IdCliente);

        [OperationContract]
        Response_Info Cliente_GetOneByIdEstadoObra(int IdEmpresa, decimal IdCliente, string IdEstadoObra);
    }
}