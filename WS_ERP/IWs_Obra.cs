using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WS_ERP.Info;

namespace WS_ERP
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IWs_Obra" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IWs_Obra
    {
        [OperationContract]
        Response_Info Proyecto_GetAll(int IdEmpresa, int IdSucursal);

        [OperationContract]
        Response_Info Proyecto_GetAllByIdCliente(int IdEmpresa, int IdSucursal, decimal IdCliente);
    }
}
