using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bizu.Domain.CuentasxPagar;

namespace Bizu.Infrastructure.CuentasxPagar
{
    public class cp_proveedor_Calificacion_Data
    {
        public Boolean Grabar(cp_proveedor_Calificacion_Info Info)
        {
            try
            {
                EntitiesCuentasxPagar cxp_entities = new EntitiesCuentasxPagar();

                cp_proveedor_Calificacion Address = new cp_proveedor_Calificacion();
                Address.IdEmpresa = Info.IdEmpresa;
                Address.IdProveedor = Info.IdProveedor;
                Info.IdCalificacion = GetId(Info.IdEmpresa, Info.IdProveedor);
                Address.IdCalificacion = Info.IdCalificacion;
                Address.Calificacion = Info.Calificacion;
                Address.Estado = Info.Estado;
                Address.FechaTransaccion = Info.FechaTransaccion;
                Address.IdUsuario = Info.IdUsuario;
                Address.FechaCreacion = Info.FechaCreacion;
                Address.IdUsuarioModificacion = Info.IdUsuarioModificacion;
                Address.FechaModificacion = Info.FechaModificacion;
                Address.IdUsuarioAnulacion = Info.IdUsuarioAnulacion;
                Address.FechaAnulacion = Info.FechaAnulacion;
                Address.MotivoAnulacion = Info.MotivoAnulacion;
                Address.Liberado = Info.Liberado;
                Address.IdUsuarioAprobacion = Info.IdUsuarioAprobacion;
                Address.FechaAprobacion = Info.FechaAprobacion;

                cxp_entities.cp_proveedor_Calificacion.Add(Address);
                cxp_entities.SaveChanges();

                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Boolean Existe(cp_proveedor_Calificacion_Info Info)
        {
            try
            {
                EntitiesCuentasxPagar cxp_entities = new EntitiesCuentasxPagar();

                cp_proveedor_Calificacion Address = (from q in cxp_entities.cp_proveedor_Calificacion
                                                    where q.IdEmpresa == Info.IdEmpresa
                                                    && q.IdProveedor == Info.IdProveedor
                                                    && q.IdCalificacion == Info.IdCalificacion
                                                     select q).FirstOrDefault();

                if(Address != null)
                {
                    return true;
                }               
                else
                {
                    return false;
                }
                
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Boolean Modificar(cp_proveedor_Calificacion_Info Info)
        {
            try
            {
                EntitiesCuentasxPagar cxp_entities = new EntitiesCuentasxPagar();

                cp_proveedor_Calificacion Address = (from q in cxp_entities.cp_proveedor_Calificacion
                                                    where q.IdEmpresa == Info.IdEmpresa
                                                    && q.IdProveedor == Info.IdProveedor
                                                    && q.IdCalificacion == Info.IdCalificacion
                                                     select q).FirstOrDefault();
                                           
                Address.Calificacion = Info.Calificacion;
                //Address.Estado = Info.Estado;
                //Address.FechaTransaccion = Info.FechaTransaccion;
                //Address.IdUsuario = Info.IdUsuario;
                //Address.FechaCreacion = Info.FechaCreacion;
                Address.IdUsuarioModificacion = Info.IdUsuarioModificacion;
                Address.FechaModificacion = Info.FechaModificacion;
                //Address.IdUsuarioAnulacion = Info.IdUsuarioAnulacion;
                //Address.FechaAnulacion = Info.FechaAnulacion;
                //Address.MotivoAnulacion = Info.MotivoAnulacion;
                Address.Liberado = Info.Liberado;
                Address.IdUsuarioAprobacion = Info.IdUsuarioAprobacion;
                Address.FechaAprobacion = Info.FechaAprobacion;
                Address.MotivoAprobacion = Info.MotivoAprobacion;
                
                cxp_entities.SaveChanges();

                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Boolean Anular(cp_proveedor_Calificacion_Info Info)
        {
            try
            {
                EntitiesCuentasxPagar cxp_entities = new EntitiesCuentasxPagar();


                cp_proveedor_Calificacion Address = (from q in cxp_entities.cp_proveedor_Calificacion
                                                    where q.IdEmpresa == Info.IdEmpresa
                                                    && q.IdProveedor == Info.IdProveedor
                                                    && q.IdCalificacion == Info.IdCalificacion
                                                    select q).FirstOrDefault();
                
                Address.Estado = "I";
                Address.FechaTransaccion = Info.FechaTransaccion;
                Address.IdUsuarioAnulacion = Info.IdUsuarioAnulacion;
                Address.FechaAnulacion = Info.FechaAnulacion;
                Address.MotivoAnulacion = Info.MotivoAnulacion;                

                cxp_entities.cp_proveedor_Calificacion.Add(Address);
                cxp_entities.SaveChanges();

                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int GetId(int IdEmpresa, decimal IdProveedor)
        {
            try
            {
                int Id = 0;

                EntitiesCuentasxPagar cxp_entities = new EntitiesCuentasxPagar();

                var query = from q in cxp_entities.cp_proveedor_Calificacion
                            where q.IdEmpresa == IdEmpresa
                            && q.IdProveedor == IdProveedor
                            select q;

                if (query.Count() <= 0)
                {
                    Id = 1;
                }
                else
                {
                    Id = (from q in cxp_entities.cp_proveedor_Calificacion
                                where q.IdEmpresa == IdEmpresa
                                && q.IdProveedor == IdProveedor
                                select q.IdCalificacion).Max() + 1;
                }
               
                return Id;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<cp_proveedor_Calificacion_Info> Get(int IdEmpresa, decimal IdProveedor)
        {
            try
            {
                List<cp_proveedor_Calificacion_Info> List = new List<cp_proveedor_Calificacion_Info>();

                EntitiesCuentasxPagar cxp_entities = new EntitiesCuentasxPagar();

                var query = from q in cxp_entities.cp_proveedor_Calificacion
                            where q.IdEmpresa == IdEmpresa
                            && q.IdProveedor == IdProveedor
                            select q;

                foreach (var item in query)
                {
                    cp_proveedor_Calificacion_Info Info = new cp_proveedor_Calificacion_Info();
                    Info.IdEmpresa = item.IdEmpresa;
                    Info.IdProveedor = item.IdProveedor;
                    Info.IdCalificacion = item.IdCalificacion;
                    Info.Calificacion = item.Calificacion;
                    Info.Estado = item.Estado;
                    Info.FechaTransaccion = item.FechaTransaccion;
                    Info.IdUsuario = item.IdUsuario;
                    Info.FechaCreacion = item.FechaCreacion;
                    Info.IdUsuarioModificacion = item.IdUsuarioModificacion;
                    Info.FechaModificacion = item.FechaModificacion;
                    Info.IdUsuarioAnulacion = item.IdUsuarioAnulacion;
                    Info.FechaAnulacion = item.FechaAnulacion;
                    Info.MotivoAnulacion = item.MotivoAnulacion;
                    Info.Liberado = item.Liberado;
                    Info.IdUsuarioAprobacion = item.IdUsuarioAprobacion;
                    Info.FechaAprobacion = item.FechaAprobacion;
                    Info.MotivoAprobacion = item.MotivoAprobacion;

                    List.Add(Info);
                }

                return List;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<cp_proveedor_Calificacion_Info> GetAll(int IdEmpresa)
        {
            try
            {
                List<cp_proveedor_Calificacion_Info> List = new List<cp_proveedor_Calificacion_Info>();

                EntitiesCuentasxPagar cxp_entities = new EntitiesCuentasxPagar();

                var query = from q in cxp_entities.vwcp_proveedor_Calificacion
                            where q.IdEmpresa == IdEmpresa                            
                            select q;

                foreach (var item in query)
                {
                    cp_proveedor_Calificacion_Info Info = new cp_proveedor_Calificacion_Info();
                    Info.IdEmpresa = item.IdEmpresa;
                    Info.IdProveedor = item.IdProveedor;
                    Info.IdCalificacion = Convert.ToInt32(item.IdCalificacion);
                    Info.Calificacion = Convert.ToDouble(item.Calificacion);
                    Info.Estado = item.Estado;
                    Info.FechaTransaccion = Convert.ToDateTime(item.FechaTransaccion);
                    Info.IdUsuario = item.IdUsuario;
                    Info.FechaCreacion = Convert.ToDateTime(item.FechaCreacion);
                    Info.IdUsuarioModificacion = item.IdUsuarioModificacion;
                    Info.FechaModificacion = item.FechaModificacion;
                    Info.IdUsuarioAnulacion = item.IdUsuarioAnulacion;
                    Info.FechaAnulacion = item.FechaAnulacion;
                    Info.MotivoAnulacion = item.MotivoAnulacion;
                    Info.Liberado = Convert.ToBoolean(item.Liberado);
                    Info.IdUsuarioAprobacion = item.IdUsuarioAprobacion;                    
                    Info.FechaAprobacion = item.FechaAprobacion;
                    Info.MotivoAprobacion = item.MotivoAprobacion;

                    List.Add(Info);
                }

                return List;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<cp_proveedor_Calificacion_Info> GetAll_Liberar(int IdEmpresa)
        {
            try
            {
                List<cp_proveedor_Calificacion_Info> List = new List<cp_proveedor_Calificacion_Info>();

                EntitiesCuentasxPagar cxp_entities = new EntitiesCuentasxPagar();

                var query = from q in cxp_entities.vwcp_proveedor_Calificacion
                            where q.IdEmpresa == IdEmpresa
                            &&  Convert.ToBoolean(q.Liberado) == false
                            && q.IdCalificacion != null
                            select q;

                foreach (var item in query)
                {
                    cp_proveedor_Calificacion_Info Info = new cp_proveedor_Calificacion_Info();
                    Info.IdEmpresa = item.IdEmpresa;
                    Info.IdProveedor = item.IdProveedor;
                    Info.IdCalificacion = Convert.ToInt32(item.IdCalificacion);
                    Info.Calificacion = Convert.ToDouble(item.Calificacion);
                    Info.Estado = item.Estado;
                    Info.FechaTransaccion = Convert.ToDateTime(item.FechaTransaccion);
                    Info.IdUsuario = item.IdUsuario;
                    Info.FechaCreacion = Convert.ToDateTime(item.FechaCreacion);
                    Info.IdUsuarioModificacion = item.IdUsuarioModificacion;
                    Info.FechaModificacion = item.FechaModificacion;
                    Info.IdUsuarioAnulacion = item.IdUsuarioAnulacion;
                    Info.FechaAnulacion = item.FechaAnulacion;
                    Info.MotivoAnulacion = item.MotivoAnulacion;
                    Info.Liberado = Convert.ToBoolean(item.Liberado);
                    Info.IdUsuarioAprobacion = item.IdUsuarioAprobacion;
                    Info.MotivoAprobacion = item.MotivoAprobacion;
                    Info.FechaAprobacion = item.FechaAprobacion;

                    List.Add(Info);
                }

                return List;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
