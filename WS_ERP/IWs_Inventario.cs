using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WS_ERP.Info;

namespace WS_ERP
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IWs_Inventario" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IWs_Inventario
    {
        [OperationContract]
        Response_Info Get_All_MotivoGuia(int IdEmpresa);

        [OperationContract]
        Response_Info Get_Producto_By_CodBarra(int IdEmpresa, int IdSucursal, int IdBodega, string codigo_barra);

        [OperationContract]
        Response_Info Get_Producto_By_IdProducto(int IdEmpresa, int IdSucursal, int IdBodega, decimal IdProducto);

        [OperationContract]
        Response_Info Grabar_GuiaRemision(GuiaRemision_Info Info);

        [OperationContract]
        Response_Info Get_All_GuiaRemision(int IdEmpresa, string FechaIni, string FechaFin);

        [OperationContract]
        Response_Info Generar_XML_GuiaRemision(int IdEmpresa, int IdSucursal, decimal IdGuiaRemision);

        [OperationContract]
        Response_Info Validar_Stock(int IdEmpresa, int IdSucursal, int IdBodega, decimal IdProducto, double dCantidad);

        [OperationContract]
        Response_Info Get_GuiaRemision(int IdEmpresa, int IdSucursal, decimal IdGuiaRemision);
    }
}
