using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Info.Inventario;

namespace Core.Erp.Data.Inventario
{
    public class in_GuiaRemision_Det_Data
    {
        public List<in_GuiaRemision_Det_Info> Get_List(int IdEmpresa, int IdSucursal, decimal IdGuiaRemision)
        {
            List<in_GuiaRemision_Det_Info> Lista = new List<in_GuiaRemision_Det_Info>();

            try
            {
                EntitiesInventario entities_inv = new EntitiesInventario();

                var Query = from q in entities_inv.in_GuiaRemision_Det
                            where q.IdEmpresa == IdEmpresa
                            && q.IdSucursal == IdSucursal
                            && q.IdGuiaRemision == IdGuiaRemision
                            select q;

                foreach (var item in Query)
                {
                    in_GuiaRemision_Det_Info Info = new in_GuiaRemision_Det_Info();
                    Info.IdEmpresa = item.IdEmpresa;
                    Info.IdSucursal = item.IdSucursal;
                    Info.IdGuiaRemision = item.IdGuiaRemision;
                    Info.Secuencia = item.Secuencia;
                    Info.IdProducto = item.IdProducto;
                    Info.Codigo = item.Codigo;
                    Info.Descripcion = item.Descripcion;
                    Info.Detalle_x_Item = item.Detalle_x_Item;
                    Info.IdCentroCosto = item.IdCentroCosto;
                    Info.Peso = item.Peso;
                    Info.Cantidad = item.Cantidad;
                    Info.IdUnidadMedida = item.IdUnidadMedida;
                    Info.Cantidad_sinConversion = item.Cantidad_sinConversion;
                    Info.IdUnidadMedida_sinConversion = item.IdUnidadMedida_sinConversion;

                    Lista.Add(Info);
                }

                return Lista;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<in_GuiaRemision_Det_Info> Get_List_Guia_x_in_GuiaRemision_Det(int IdEmpresa, int IdSucursal, decimal IdGuiaRemision)
        {
            List<in_GuiaRemision_Det_Info> Lista = new List<in_GuiaRemision_Det_Info>();

            try
            {
                EntitiesInventario entities_inv = new EntitiesInventario();

                var Query = from q in entities_inv.in_GuiaRemision_Det
                            where q.IdEmpresa == IdEmpresa
                            && q.IdSucursal == IdSucursal
                            && q.IdGuiaRemision == IdGuiaRemision
                            select q;

                foreach (var item in Query)
                {
                    in_GuiaRemision_Det_Info Info = new in_GuiaRemision_Det_Info();
                    Info.IdEmpresa = item.IdEmpresa;
                    Info.IdSucursal = item.IdSucursal;
                    Info.IdGuiaRemision = item.IdGuiaRemision;
                    Info.Secuencia = item.Secuencia;
                    Info.IdProducto = item.IdProducto;
                    Info.Codigo = item.Codigo;
                    Info.Descripcion = item.Descripcion;
                    Info.Detalle_x_Item = item.Detalle_x_Item;
                    Info.IdCentroCosto = item.IdCentroCosto;
                    Info.Peso = item.Peso;
                    Info.Cantidad = item.Cantidad;
                    Info.IdUnidadMedida = item.IdUnidadMedida;
                    Info.Cantidad_sinConversion = item.Cantidad_sinConversion;
                    Info.IdUnidadMedida_sinConversion = item.IdUnidadMedida_sinConversion;

                    Lista.Add(Info);
                }

                return Lista;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        
        public Boolean Grabar(List<in_GuiaRemision_Det_Info> List_Detalle)
        {           
            try
            {
                EntitiesInventario entities_inv = new EntitiesInventario();

                foreach (var item in List_Detalle)
                {
                    in_GuiaRemision_Det Address = new in_GuiaRemision_Det();
                    Address.IdEmpresa = item.IdEmpresa;
                    Address.IdSucursal = item.IdSucursal;
                    Address.IdGuiaRemision = item.IdGuiaRemision;
                    Address.Secuencia = item.Secuencia;
                    Address.IdProducto = item.IdProducto;
                    Address.Codigo = item.Codigo;
                    Address.Descripcion = item.Descripcion;
                    Address.Detalle_x_Item = item.Detalle_x_Item;
                    Address.IdCentroCosto = item.IdCentroCosto;
                    Address.Peso = item.Peso;
                    Address.Cantidad = item.Cantidad;
                    Address.IdUnidadMedida = item.IdUnidadMedida;
                    Address.Cantidad_sinConversion = item.Cantidad_sinConversion;
                    Address.IdUnidadMedida_sinConversion = item.IdUnidadMedida_sinConversion;

                    entities_inv.in_GuiaRemision_Det.Add(Address);
                    entities_inv.SaveChanges();
                }

                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Boolean Eliminar(int IdEmpresa, int IdSucursal, decimal IdGuiaRemision)
        {
            try
            {
                EntitiesInventario entities_inv = new EntitiesInventario();

                entities_inv.Database.ExecuteSqlCommand("DELETE FROM in_GuiaRemision_Det WHERE IdEmpresa = '" + IdEmpresa + "' and IdSucursal = " + IdSucursal + " and IdGuiaRemision = " + IdGuiaRemision);

                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
