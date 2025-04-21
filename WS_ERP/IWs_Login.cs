using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Core.Erp.Info.SeguridadAcceso;
using WS_ERP.Info;

namespace WS_ERP
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IWs_Login" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IWs_Login
    {
        [OperationContract]
        Response_Info Login(string IdUsuario, string Contrasena);

        [OperationContract]
        Response_Info Login_x_Empresa(int IdEmpresa, string IdUsuario, string Contrasena);
    }
}
