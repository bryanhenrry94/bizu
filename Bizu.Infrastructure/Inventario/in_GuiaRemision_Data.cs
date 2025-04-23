using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bizu.Domain.Inventario;
using Bizu.Domain.General;
using Bizu.Infrastructure.General;

namespace Bizu.Infrastructure.Inventario
{
    public class in_GuiaRemision_Data
    {
        tb_sis_Documento_Tipo_Talonario_Data Data_sisDocTipoTalo = new tb_sis_Documento_Tipo_Talonario_Data();
        tb_sis_Documento_Tipo_Talonario_Info Info_sisDocTipoTalo = new tb_sis_Documento_Tipo_Talonario_Info();

        public Boolean GrabarDB(in_GuiaRemision_Info Info_GuiaRemision, ref string ms)
        {
            try
            {
                EntitiesInventario entities_inv = new EntitiesInventario();

                in_GuiaRemision Address = new in_GuiaRemision();
                Address.IdEmpresa = Info_GuiaRemision.IdEmpresa;
                Address.IdSucursal = Info_GuiaRemision.IdSucursal;
                Info_GuiaRemision.IdGuiaRemision = GetId(Address.IdEmpresa, Address.IdSucursal);
                Address.IdGuiaRemision = Info_GuiaRemision.IdGuiaRemision;
                Address.IdBodega = Info_GuiaRemision.IdBodega;
                Address.FechaEmision = Info_GuiaRemision.FechaEmision;
                Address.FechaTrasladoIni = Info_GuiaRemision.FechaTrasladoIni;
                Address.FechaTrasladoFin = Info_GuiaRemision.FechaTrasladoFin;
                Address.Serie1 = Info_GuiaRemision.Serie1;
                Address.Serie2 = Info_GuiaRemision.Serie2;
                Address.NumDocumento = Info_GuiaRemision.NumDocumento;
                Address.IdTipo_Persona = Info_GuiaRemision.IdTipo_Persona;
                Address.IdEntidad = Info_GuiaRemision.IdEntidad;
                Address.IdProyecto = Info_GuiaRemision.IdProyecto;
                Address.IdCentroCosto = Info_GuiaRemision.IdCentroCosto;
                Address.Origen = Info_GuiaRemision.Origen;
                Address.Destino = Info_GuiaRemision.Destino;
                Address.Observacion = Info_GuiaRemision.Observacion;
                Address.IdMotivo = Info_GuiaRemision.IdMotivo;
                Address.IdEstado_cierre = Info_GuiaRemision.IdEstado_cierre;
                Address.Estado = Info_GuiaRemision.Estado;
                Address.IdUsuarioCreacion = Info_GuiaRemision.IdUsuarioCreacion;
                Address.FechaCreacion = Info_GuiaRemision.FechaCreacion;
                Address.IdUsuarioModificacion = Info_GuiaRemision.IdUsuarioModificacion;
                Address.FechaModificacion = Info_GuiaRemision.FechaModificacion;
                Address.IdUsuarioAnulacion = Info_GuiaRemision.IdUsuarioAnulacion;
                Address.FechaAnulacion = Info_GuiaRemision.FechaAnulacion;
                Address.MotivoAnulacion = Info_GuiaRemision.MotivoAnulacion;
                Address.FechaAutorizacion = Info_GuiaRemision.FechaAutorizacion;
                Address.NumAutorizacion = Info_GuiaRemision.NumAutorizacion;
                Address.IdTransportista = Info_GuiaRemision.IdTransportista;
                Address.Placa = Info_GuiaRemision.Placa;
                Address.Ruta = Info_GuiaRemision.Ruta;
                Address.Correo = Info_GuiaRemision.Correo;

                entities_inv.in_GuiaRemision.Add(Address);
                entities_inv.SaveChanges();


                //modifico el estatus de usado al numero de la factura
                Info_sisDocTipoTalo.Establecimiento = Info_GuiaRemision.Serie1;
                Info_sisDocTipoTalo.PuntoEmision = Info_GuiaRemision.Serie2;
                Info_sisDocTipoTalo.NumDocumento = Info_GuiaRemision.NumDocumento;
                Info_sisDocTipoTalo.IdEmpresa = Info_GuiaRemision.IdEmpresa;
                Info_sisDocTipoTalo.CodDocumentoTipo = "GUIA";
                Data_sisDocTipoTalo.Modificar_Estado_Usado(Info_sisDocTipoTalo, ref ms);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return true;
        }

        public Boolean ModificarDB(in_GuiaRemision_Info Info_GuiaRemision, ref string ms)
        {
            try
            {
                EntitiesInventario entities_inv = new EntitiesInventario();

                in_GuiaRemision Address = (from q in entities_inv.in_GuiaRemision
                                           where q.IdEmpresa == Info_GuiaRemision.IdEmpresa
                                               && q.IdSucursal == Info_GuiaRemision.IdSucursal
                                               && q.IdGuiaRemision == Info_GuiaRemision.IdGuiaRemision
                                           select q).FirstOrDefault();

                if (Address != null)
                {
                    Address.IdBodega = Info_GuiaRemision.IdBodega;
                    Address.FechaEmision = Info_GuiaRemision.FechaEmision;
                    Address.FechaTrasladoIni = Info_GuiaRemision.FechaTrasladoIni;
                    Address.FechaTrasladoFin = Info_GuiaRemision.FechaTrasladoFin;
                    Address.Serie1 = Info_GuiaRemision.Serie1;
                    Address.Serie2 = Info_GuiaRemision.Serie2;
                    Address.NumDocumento = Info_GuiaRemision.NumDocumento;
                    Address.IdTipo_Persona = Info_GuiaRemision.IdTipo_Persona;
                    Address.IdEntidad = Info_GuiaRemision.IdEntidad;
                    Address.IdProyecto = Info_GuiaRemision.IdProyecto;
                    Address.IdCentroCosto = Info_GuiaRemision.IdCentroCosto;
                    Address.Origen = Info_GuiaRemision.Origen;
                    Address.Destino = Info_GuiaRemision.Destino;
                    Address.Observacion = Info_GuiaRemision.Observacion;
                    Address.IdMotivo = Info_GuiaRemision.IdMotivo;
                    Address.IdEstado_cierre = Info_GuiaRemision.IdEstado_cierre;
                    Address.Estado = Info_GuiaRemision.Estado;
                    //Address.IdUsuarioCreacion = Info_GuiaRemision.IdUsuarioCreacion;
                    //Address.FechaCreacion = Info_GuiaRemision.FechaCreacion;
                    Address.IdUsuarioModificacion = Info_GuiaRemision.IdUsuarioModificacion;
                    Address.FechaModificacion = Info_GuiaRemision.FechaModificacion;
                    //Address.IdUsuarioAnulacion = Info_GuiaRemision.IdUsuarioAnulacion;
                    //Address.FechaAnulacion = Info_GuiaRemision.FechaAnulacion;
                    //Address.MotivoAnulacion = Info_GuiaRemision.MotivoAnulacion;
                    //Address.FechaAutorizacion = Info_GuiaRemision.FechaAutorizacion;
                    //Address.NumAutorizacion = Info_GuiaRemision.NumAutorizacion;
                    Address.IdTransportista = Info_GuiaRemision.IdTransportista;
                    Address.Placa = Info_GuiaRemision.Placa;
                    Address.Ruta = Info_GuiaRemision.Ruta;
                    Address.Correo = Info_GuiaRemision.Correo;

                    entities_inv.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return true;
        }

        public Boolean Modificar_Estado_Cierre(int IdEmpresa, int IdSucursal, decimal IdGuiaRemision, string Estado_cierre)
        {
            try
            {
                EntitiesInventario context = new EntitiesInventario();

                var Address = (from q in context.in_GuiaRemision
                               where q.IdEmpresa == IdEmpresa
                               && q.IdSucursal == IdSucursal
                               && q.IdGuiaRemision == IdGuiaRemision
                               select q).First();

                if (Address != null)
                {
                    Address.IdEstado_cierre = Estado_cierre;
                    context.SaveChanges();
                    return true;
                }
                else
                    return false;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Boolean Anular(in_GuiaRemision_Info Info_GuiaRemision, ref string ms)
        {
            try
            {
                EntitiesInventario entities_inv = new EntitiesInventario();

                in_GuiaRemision Address = (from q in entities_inv.in_GuiaRemision
                                           where q.IdEmpresa == Info_GuiaRemision.IdEmpresa
                                               && q.IdSucursal == Info_GuiaRemision.IdSucursal
                                               && q.IdGuiaRemision == Info_GuiaRemision.IdGuiaRemision
                                           select q).FirstOrDefault();

                if (Address != null)
                {
                    Address.Estado = "I";
                    Address.IdUsuarioAnulacion = Info_GuiaRemision.IdUsuarioAnulacion;
                    Address.FechaAnulacion = Info_GuiaRemision.FechaAnulacion;
                    Address.MotivoAnulacion = Info_GuiaRemision.MotivoAnulacion;

                    entities_inv.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return true;
        }

        public Decimal GetId(int IdEmpresa, int IdSucursal)
        {
            Decimal Id = 0;

            try
            {
                EntitiesInventario entities_inv = new EntitiesInventario();

                var query = from q in entities_inv.in_GuiaRemision
                            where q.IdEmpresa == IdEmpresa
                            && q.IdSucursal == IdSucursal
                            select q;

                if (query.Count() > 0)
                {
                    Id = (from q in entities_inv.in_GuiaRemision
                          where q.IdEmpresa == IdEmpresa
                          && q.IdSucursal == IdSucursal
                          select q.IdGuiaRemision).Max() + 1;
                }
                else
                {
                    Id = 1;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return Id;
        }

        public List<in_GuiaRemision_Info> Get_List(int IdEmpresa, DateTime FechaIni, DateTime FechaFin)
        {
            List<in_GuiaRemision_Info> Lista = new List<in_GuiaRemision_Info>();

            try
            {
                EntitiesInventario entities_inv = new EntitiesInventario();

                var query = from q in entities_inv.vwin_GuiaRemision
                            where q.IdEmpresa == IdEmpresa
                            && q.FechaEmision >= FechaIni.Date && q.FechaEmision <= FechaFin.Date
                            select q;

                foreach (var item in query)
                {
                    in_GuiaRemision_Info Info = new in_GuiaRemision_Info();
                    Info.IdEmpresa = item.IdEmpresa;
                    Info.IdSucursal = item.IdSucursal;
                    Info.Su_Descripcion = item.Su_Descripcion;
                    Info.IdGuiaRemision = item.IdGuiaRemision;
                    Info.IdBodega = item.IdBodega;
                    Info.nom_bodega = item.nom_bodega;
                    Info.FechaEmision = item.FechaEmision;
                    Info.FechaTrasladoIni = item.FechaTrasladoIni;
                    Info.FechaTrasladoFin = item.FechaTrasladoFin;
                    Info.Serie1 = item.Serie1;
                    Info.Serie2 = item.Serie2;
                    Info.NumDocumento = item.NumDocumento;
                    Info.IdTipo_Persona = item.IdTipo_Persona;
                    Info.IdEntidad = item.IdEntidad;
                    Info.pe_cedulaRuc = item.pe_cedulaRuc;
                    Info.pe_nombreCompleto = item.pe_nombreCompleto;
                    Info.IdProyecto = item.IdProyecto;
                    Info.NomProyecto = item.NomProyecto;
                    Info.IdCentroCosto = item.IdCentroCosto;
                    Info.Centro_costo = item.Centro_costo;
                    Info.Origen = item.Origen;
                    Info.Destino = item.Destino;
                    Info.Observacion = item.Observacion;
                    Info.IdMotivo = item.IdMotivo;
                    Info.Motivo = item.Motivo;
                    Info.IdEstado_cierre = item.IdEstado_cierre;
                    Info.Estado = item.Estado;
                    Info.IdUsuarioCreacion = item.IdUsuarioCreacion;
                    Info.FechaCreacion = item.FechaCreacion;
                    Info.IdUsuarioModificacion = item.IdUsuarioModificacion;
                    Info.FechaModificacion = item.FechaModificacion;
                    Info.IdUsuarioAnulacion = item.IdUsuarioAnulacion;
                    Info.FechaAnulacion = item.FechaAnulacion;
                    Info.MotivoAnulacion = item.MotivoAnulacion;
                    Info.FechaAutorizacion = item.FechaAutorizacion;
                    Info.NumAutorizacion = item.NumAutorizacion;
                    Info.IdTransportista = item.IdTransportista;
                    Info.NombreTransportista = item.NombreTransportista;
                    Info.CedulaTransportista = item.CedulaTransportista;
                    Info.Placa = item.Placa;
                    Info.Ruta = item.Ruta;
                    Info.Correo = item.Correo;

                    Lista.Add(Info);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return Lista;
        }

        public List<in_GuiaRemision_Info> Get_List_Lite(int IdEmpresa, DateTime FechaIni, DateTime FechaFin)
        {
            List<in_GuiaRemision_Info> Lista = new List<in_GuiaRemision_Info>();

            try
            {
                EntitiesInventario entities_inv = new EntitiesInventario();

                var query = from q in entities_inv.vwin_GuiaRemision_Lite
                            where q.IdEmpresa == IdEmpresa
                            && q.FechaEmision >= FechaIni.Date && q.FechaEmision <= FechaFin.Date
                            select q;

                foreach (var item in query)
                {
                    in_GuiaRemision_Info Info = new in_GuiaRemision_Info();
                    Info.IdEmpresa = item.IdEmpresa;
                    Info.IdSucursal = item.IdSucursal;
                    Info.Su_Descripcion = item.Su_Descripcion;
                    Info.IdGuiaRemision = item.IdGuiaRemision;
                    Info.IdBodega = item.IdBodega;
                    Info.nom_bodega = item.nom_bodega;
                    Info.FechaEmision = item.FechaEmision;
                    Info.FechaTrasladoIni = item.FechaTrasladoIni;
                    Info.FechaTrasladoFin = item.FechaTrasladoFin;
                    Info.Serie1 = item.Serie1;
                    Info.Serie2 = item.Serie2;
                    Info.NumDocumento = item.NumDocumento;
                    Info.IdTipo_Persona = item.IdTipo_Persona;
                    Info.IdEntidad = item.IdEntidad;
                    //Info.pe_cedulaRuc = item.pe_cedulaRuc;
                    //Info.pe_nombreCompleto = item.pe_nombreCompleto;
                    Info.IdProyecto = item.IdProyecto;
                    Info.NomProyecto = item.NomProyecto;
                    Info.IdCentroCosto = item.IdCentroCosto;
                    Info.Centro_costo = item.Centro_costo;
                    Info.Origen = item.Origen;
                    Info.Destino = item.Destino;
                    Info.Observacion = item.Observacion;
                    Info.IdMotivo = item.IdMotivo;
                    Info.Motivo = item.Motivo;
                    Info.IdEstado_cierre = item.IdEstado_cierre;
                    Info.Estado = item.Estado;
                    Info.IdUsuarioCreacion = item.IdUsuarioCreacion;
                    Info.FechaCreacion = item.FechaCreacion;
                    Info.IdUsuarioModificacion = item.IdUsuarioModificacion;
                    Info.FechaModificacion = item.FechaModificacion;
                    Info.IdUsuarioAnulacion = item.IdUsuarioAnulacion;
                    Info.FechaAnulacion = item.FechaAnulacion;
                    Info.MotivoAnulacion = item.MotivoAnulacion;
                    Info.FechaAutorizacion = item.FechaAutorizacion;
                    Info.NumAutorizacion = item.NumAutorizacion;
                    Info.IdTransportista = item.IdTransportista;
                    Info.NombreTransportista = item.NombreTransportista;
                    Info.CedulaTransportista = item.CedulaTransportista;
                    Info.Placa = item.Placa;
                    Info.Ruta = item.Ruta;
                    Info.Correo = item.Correo;

                    Lista.Add(Info);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return Lista;
        }

        public in_GuiaRemision_Info Get_Info_x_in_GuiaRemision(int IdEmpresa, decimal IdGuiaRemision)
        {
            in_GuiaRemision_Info Info = new in_GuiaRemision_Info();

            try
            {
                EntitiesInventario entities_inv = new EntitiesInventario();

                var query = (from q in entities_inv.vwin_GuiaRemision
                             where q.IdEmpresa == IdEmpresa
                             && q.IdGuiaRemision == IdGuiaRemision
                             select q).FirstOrDefault();

                Info = new in_GuiaRemision_Info();
                Info.IdEmpresa = query.IdEmpresa;
                Info.IdSucursal = query.IdSucursal;
                Info.Su_Descripcion = query.Su_Descripcion;
                Info.IdGuiaRemision = query.IdGuiaRemision;
                Info.IdBodega = query.IdBodega;
                Info.nom_bodega = query.nom_bodega;
                Info.FechaEmision = query.FechaEmision;
                Info.FechaTrasladoIni = query.FechaTrasladoIni;
                Info.FechaTrasladoFin = query.FechaTrasladoFin;
                Info.Serie1 = query.Serie1;
                Info.Serie2 = query.Serie2;
                Info.NumDocumento = query.NumDocumento;
                Info.IdTipo_Persona = query.IdTipo_Persona;
                Info.IdEntidad = query.IdEntidad;
                Info.pe_cedulaRuc = query.pe_cedulaRuc;
                Info.pe_nombreCompleto = query.pe_nombreCompleto;
                Info.IdProyecto = query.IdProyecto;
                Info.NomProyecto = query.NomProyecto;
                Info.IdCentroCosto = query.IdCentroCosto;
                Info.Centro_costo = query.Centro_costo;
                Info.Origen = query.Origen;
                Info.Destino = query.Destino;
                Info.Observacion = query.Observacion;
                Info.IdMotivo = query.IdMotivo;
                Info.Motivo = query.Motivo;
                Info.IdEstado_cierre = query.IdEstado_cierre;
                Info.Estado = query.Estado;
                Info.IdUsuarioCreacion = query.IdUsuarioCreacion;
                Info.FechaCreacion = query.FechaCreacion;
                Info.IdUsuarioModificacion = query.IdUsuarioModificacion;
                Info.FechaModificacion = query.FechaModificacion;
                Info.IdUsuarioAnulacion = query.IdUsuarioAnulacion;
                Info.FechaAnulacion = query.FechaAnulacion;
                Info.MotivoAnulacion = query.MotivoAnulacion;
                Info.FechaAutorizacion = query.FechaAutorizacion;
                Info.NumAutorizacion = query.NumAutorizacion;
                Info.IdTransportista = query.IdTransportista;
                Info.NombreTransportista = query.NombreTransportista;
                Info.CedulaTransportista = query.CedulaTransportista;
                Info.Placa = query.Placa;
                Info.Ruta = query.Ruta;
                Info.Correo = query.Correo;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return Info;
        }

        public in_GuiaRemision_Info Get_GuiaRemision(int IdEmpresa, int IdSucursal, decimal IdGuiaRemision)
        {
            in_GuiaRemision_Info Info = new in_GuiaRemision_Info();

            try
            {
                EntitiesInventario entities_inv = new EntitiesInventario();

                var query = (from q in entities_inv.vwin_GuiaRemision
                             where q.IdEmpresa == IdEmpresa
                             && q.IdSucursal == IdSucursal
                             && q.IdGuiaRemision == IdGuiaRemision
                             select q).FirstOrDefault();

                Info = new in_GuiaRemision_Info();
                Info.IdEmpresa = query.IdEmpresa;
                Info.IdSucursal = query.IdSucursal;
                Info.Su_Descripcion = query.Su_Descripcion;
                Info.IdGuiaRemision = query.IdGuiaRemision;
                Info.IdBodega = query.IdBodega;
                Info.nom_bodega = query.nom_bodega;
                Info.FechaEmision = query.FechaEmision;
                Info.FechaTrasladoIni = query.FechaTrasladoIni;
                Info.FechaTrasladoFin = query.FechaTrasladoFin;
                Info.Serie1 = query.Serie1;
                Info.Serie2 = query.Serie2;
                Info.NumDocumento = query.NumDocumento;
                Info.IdTipo_Persona = query.IdTipo_Persona;
                Info.IdEntidad = query.IdEntidad;
                Info.pe_cedulaRuc = query.pe_cedulaRuc;
                Info.pe_nombreCompleto = query.pe_nombreCompleto;
                Info.IdProyecto = query.IdProyecto;
                Info.NomProyecto = query.NomProyecto;
                Info.IdCentroCosto = query.IdCentroCosto;
                Info.Centro_costo = query.Centro_costo;
                Info.Origen = query.Origen;
                Info.Destino = query.Destino;
                Info.Observacion = query.Observacion;
                Info.IdMotivo = query.IdMotivo;
                Info.Motivo = query.Motivo;
                Info.IdEstado_cierre = query.IdEstado_cierre;
                Info.Estado = query.Estado;
                Info.IdUsuarioCreacion = query.IdUsuarioCreacion;
                Info.FechaCreacion = query.FechaCreacion;
                Info.IdUsuarioModificacion = query.IdUsuarioModificacion;
                Info.FechaModificacion = query.FechaModificacion;
                Info.IdUsuarioAnulacion = query.IdUsuarioAnulacion;
                Info.FechaAnulacion = query.FechaAnulacion;
                Info.MotivoAnulacion = query.MotivoAnulacion;
                Info.FechaAutorizacion = query.FechaAutorizacion;
                Info.NumAutorizacion = query.NumAutorizacion;
                Info.IdTransportista = query.IdTransportista;
                Info.NombreTransportista = query.NombreTransportista;
                Info.CedulaTransportista = query.CedulaTransportista;
                Info.Placa = query.Placa;
                Info.Ruta = query.Ruta;
                Info.Correo = query.Correo;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return Info;
        }

        public string Validar_Stock(int IdEmpresa, int IdSucursal, int IdBodega, decimal IdProducto, double dCantidad)
        {
            try
            {
                string mensaje = "";

                using (EntitiesInventario Context = new EntitiesInventario())
                {
                    var query = (from q in Context.vwin_producto_x_tb_bodega
                                 where q.IdEmpresa == IdEmpresa
                                 && q.IdSucursal == IdSucursal
                                 && q.IdBodega == IdBodega
                                 && q.IdProducto == IdProducto
                                 select q).FirstOrDefault();

                    if (Math.Round(query.pr_stock, 2) < Math.Round(dCantidad, 2))
                    {
                        mensaje = "Stock Insuficiente!\nProducto: " + query.pr_descripcion + " Stock: " + query.pr_stock;
                    }
                }

                return mensaje;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}