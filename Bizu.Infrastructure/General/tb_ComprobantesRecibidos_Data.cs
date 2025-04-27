using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bizu.Domain.General;
using System.Data.Entity.Validation;

namespace Bizu.Infrastructure.General
{
    public class tb_ComprobantesRecibidos_Data
    {
        public bool GrabarBD(tb_ComprobantesRecibidos_Info Info)
        {
            try
            {
                EntitiesGeneral dbContext = new EntitiesGeneral();

                Info.Id = GetId();

                tb_comprobantesrecibidos _comprobante = new tb_comprobantesrecibidos();
                _comprobante.id = Info.Id;
                _comprobante.rucemisor = Info.RucEmisor;
                _comprobante.razonsocialemisor = Info.RazonSocialEmisor;
                _comprobante.tipocomprobante = Info.TipoComprobante;
                _comprobante.seriecomprobante = Info.SerieComprobante;
                _comprobante.claveacceso = Info.ClaveAcceso;
                _comprobante.fechaautorizacion = Info.FechaAutorizacion;
                _comprobante.numeroautorizacion = Info.NumeroAutorizacion;
                _comprobante.fechaemision = Info.FechaEmision;
                _comprobante.identificacionreceptor = Info.IdentificacionReceptor;
                _comprobante.valorsinimpuestos = Info.ValorSinImpuestos;
                _comprobante.iva = Info.Iva;
                _comprobante.importetotal = Info.ImporteTotal;
                _comprobante.numerodocumentomodificado = Info.NumeroDocumentoModificado;
                _comprobante.estado = Info.Estado;
                _comprobante.motivo = Info.Motivo;
                _comprobante.xml = Info.XML;
                _comprobante.idempresa_ogiro = Info.IdEmpresa_Ogiro;
                _comprobante.idcbtecble_ogiro = Info.IdCbteCble_Ogiro;
                _comprobante.idtipocbte_ogiro = Info.IdTipoCbte_Ogiro;

                dbContext.tb_comprobantesrecibidos.Add(_comprobante);
                dbContext.SaveChanges();

                return true;
            }catch(Exception ex)
            {
                throw ex;
            }
        }

        public bool Existe(string RucEmisor, string SerieComprobante)
        {
            try
            {
                EntitiesGeneral dbContext = new EntitiesGeneral();

                var query = dbContext.tb_comprobantesrecibidos.Where(q => q.rucemisor == RucEmisor && q.seriecomprobante == SerieComprobante).ToList();

                if (query.Count > 0)
                    return true;
                else
                    return false;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public bool ModificarDB(tb_ComprobantesRecibidos_Info Info)
        {
            try
            {
                EntitiesGeneral dbContext = new EntitiesGeneral();

                tb_comprobantesrecibidos _comprobante = dbContext.tb_comprobantesrecibidos.Where(q => q.id == Info.Id).First();

                if(_comprobante != null)
                {
                    _comprobante.rucemisor = Info.RucEmisor;
                    _comprobante.razonsocialemisor = Info.RazonSocialEmisor;
                    _comprobante.tipocomprobante = Info.TipoComprobante;
                    _comprobante.seriecomprobante = Info.SerieComprobante;
                    _comprobante.claveacceso = Info.ClaveAcceso;
                    _comprobante.fechaautorizacion = Info.FechaAutorizacion;
                    _comprobante.numeroautorizacion = Info.NumeroAutorizacion;
                    _comprobante.fechaemision = Info.FechaEmision;
                    _comprobante.identificacionreceptor = Info.IdentificacionReceptor;
                    _comprobante.valorsinimpuestos = Info.ValorSinImpuestos;
                    _comprobante.iva = Info.Iva;
                    _comprobante.importetotal = Info.ImporteTotal;
                    _comprobante.numerodocumentomodificado = Info.NumeroDocumentoModificado;
                    _comprobante.estado = Info.Estado;
                    _comprobante.motivo = Info.Motivo;
                    _comprobante.xml = Info.XML;
                    _comprobante.idempresa_ogiro = Info.IdEmpresa_Ogiro;
                    _comprobante.idcbtecble_ogiro = Info.IdCbteCble_Ogiro;
                    _comprobante.idtipocbte_ogiro = Info.IdTipoCbte_Ogiro;

                    dbContext.SaveChanges();
                }
               
                return true;
            }
            catch (DbEntityValidationException ex)
            {
                var errorMessages = ex.EntityValidationErrors
                    .SelectMany(x => x.ValidationErrors)
                    .Select(x => x.ErrorMessage);

                var fullErrorMessage = string.Join("; ", errorMessages);
                var exceptionMessage = $"Validation failed for one or more entities. See 'EntityValidationErrors' property for more details. The validation errors are: {fullErrorMessage}";

                // Log or rethrow the detailed exception message
                throw new DbEntityValidationException(exceptionMessage, ex.EntityValidationErrors);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool EliminarBD(int Id)
        {
            try
            {
                EntitiesGeneral dbContext = new EntitiesGeneral();

                tb_comprobantesrecibidos _comprobante = dbContext.tb_comprobantesrecibidos.Where(q => q.id == Id).First();

                if (_comprobante != null)
                {
                    dbContext.tb_comprobantesrecibidos.Remove(_comprobante);
                    dbContext.SaveChanges();
                }

                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public tb_ComprobantesRecibidos_Info GetInfo(string RucEmisor, string TipoComprobante, string SerieComprobante)
        {
            try
            {
                tb_ComprobantesRecibidos_Info _comprobante = new tb_ComprobantesRecibidos_Info();

                EntitiesGeneral dbContext = new EntitiesGeneral();

                var query = dbContext.tb_comprobantesrecibidos.Where(q => q.rucemisor == RucEmisor && q.tipocomprobante == TipoComprobante && q.seriecomprobante == SerieComprobante);

                foreach(var Info in query)
                {
                    _comprobante.Id = Info.id;
                    _comprobante.RucEmisor = Info.rucemisor;
                    _comprobante.RazonSocialEmisor = Info.razonsocialemisor;
                    _comprobante.TipoComprobante = Info.tipocomprobante;
                    _comprobante.SerieComprobante = Info.seriecomprobante;
                    _comprobante.ClaveAcceso = Info.claveacceso;
                    _comprobante.FechaAutorizacion = Info.fechaautorizacion;
                    _comprobante.NumeroAutorizacion = Info.numeroautorizacion;
                    _comprobante.FechaEmision = Info.fechaemision;
                    _comprobante.IdentificacionReceptor = Info.identificacionreceptor;
                    _comprobante.ValorSinImpuestos = Info.valorsinimpuestos;
                    _comprobante.Iva = Info.iva;
                    _comprobante.ImporteTotal = Info.importetotal;
                    _comprobante.NumeroDocumentoModificado = Info.numerodocumentomodificado;
                    _comprobante.Estado = Info.estado;
                    _comprobante.Motivo = Info.motivo;
                    _comprobante.XML = Info.xml;
                    _comprobante.IdEmpresa_Ogiro = Info.idempresa_ogiro;
                    _comprobante.IdCbteCble_Ogiro = Info.idcbtecble_ogiro;
                    _comprobante.IdTipoCbte_Ogiro = Info.idtipocbte_ogiro;
                }

                return _comprobante;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<tb_ComprobantesRecibidos_Info> GetList()
        {
            try
            {
                List<tb_ComprobantesRecibidos_Info> ListComprobantesRecibidos = new List<tb_ComprobantesRecibidos_Info>();

                EntitiesGeneral dbContext = new EntitiesGeneral();

                var query = dbContext.tb_comprobantesrecibidos.ToList();

                foreach (var Info in query)
                {
                    tb_ComprobantesRecibidos_Info _comprobante = new tb_ComprobantesRecibidos_Info();
                    _comprobante.Id = Info.id;
                    _comprobante.RucEmisor = Info.rucemisor;
                    _comprobante.RazonSocialEmisor = Info.razonsocialemisor;
                    _comprobante.TipoComprobante = Info.tipocomprobante;
                    _comprobante.SerieComprobante = Info.seriecomprobante;
                    _comprobante.ClaveAcceso = Info.claveacceso;
                    _comprobante.FechaAutorizacion = Info.fechaautorizacion;
                    _comprobante.NumeroAutorizacion = Info.numeroautorizacion;
                    _comprobante.FechaEmision = Info.fechaemision;
                    _comprobante.IdentificacionReceptor = Info.identificacionreceptor;
                    _comprobante.ValorSinImpuestos = Info.valorsinimpuestos;
                    _comprobante.Iva = Info.iva;
                    _comprobante.ImporteTotal = Info.importetotal;
                    _comprobante.NumeroDocumentoModificado = Info.numerodocumentomodificado;
                    _comprobante.Estado = Info.estado;
                    _comprobante.Motivo = Info.motivo;
                    _comprobante.XML = Info.xml;
                    _comprobante.IdEmpresa_Ogiro = Info.idempresa_ogiro;
                    _comprobante.IdCbteCble_Ogiro = Info.idcbtecble_ogiro;
                    _comprobante.IdTipoCbte_Ogiro = Info.idtipocbte_ogiro;

                    ListComprobantesRecibidos.Add(_comprobante);
                }

                return ListComprobantesRecibidos;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<tb_ComprobantesRecibidos_Info> GetList(string Ruc)
        {
            try
            {
                List<tb_ComprobantesRecibidos_Info> ListComprobantesRecibidos = new List<tb_ComprobantesRecibidos_Info>();

                EntitiesGeneral dbContext = new EntitiesGeneral();

                var query = dbContext.tb_comprobantesrecibidos.Where(q => q.identificacionreceptor == Ruc).ToList();

                foreach(var Info in query)
                {
                    tb_ComprobantesRecibidos_Info _comprobante = new tb_ComprobantesRecibidos_Info();
                    _comprobante.Id = Info.id;
                    _comprobante.RucEmisor = Info.rucemisor;
                    _comprobante.RazonSocialEmisor = Info.razonsocialemisor;
                    _comprobante.TipoComprobante = Info.tipocomprobante;
                    _comprobante.SerieComprobante = Info.seriecomprobante;
                    _comprobante.ClaveAcceso = Info.claveacceso;
                    _comprobante.FechaAutorizacion = Info.fechaautorizacion;
                    _comprobante.NumeroAutorizacion = Info.numeroautorizacion;
                    _comprobante.FechaEmision = Info.fechaemision;
                    _comprobante.IdentificacionReceptor = Info.identificacionreceptor;
                    _comprobante.ValorSinImpuestos = Info.valorsinimpuestos;
                    _comprobante.Iva = Info.iva;
                    _comprobante.ImporteTotal = Info.importetotal;
                    _comprobante.NumeroDocumentoModificado = Info.numerodocumentomodificado;
                    _comprobante.Estado = Info.estado;
                    _comprobante.Motivo = Info.motivo;
                    _comprobante.XML = Info.xml;
                    _comprobante.IdEmpresa_Ogiro = Info.idempresa_ogiro;
                    _comprobante.IdCbteCble_Ogiro = Info.idcbtecble_ogiro;
                    _comprobante.IdTipoCbte_Ogiro = Info.idtipocbte_ogiro;

                    ListComprobantesRecibidos.Add(_comprobante);
                }

                return ListComprobantesRecibidos;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public List<tb_ComprobantesRecibidos_Info> GetList(string Ruc, DateTime FechaIni, DateTime FechaFin)
        {
            try
            {
                List<tb_ComprobantesRecibidos_Info> ListComprobantesRecibidos = new List<tb_ComprobantesRecibidos_Info>();

                EntitiesGeneral dbContext = new EntitiesGeneral();

                var query = dbContext.tb_comprobantesrecibidos.Where(
                    q => q.identificacionreceptor == Ruc
                    && q.fechaemision >= FechaIni
                    && q.fechaemision <= FechaFin                    
                ).ToList();

                foreach (var Info in query)
                {
                    tb_ComprobantesRecibidos_Info _comprobante = new tb_ComprobantesRecibidos_Info();
                    _comprobante.Id = Info.id;
                    _comprobante.RucEmisor = Info.rucemisor;
                    _comprobante.RazonSocialEmisor = Info.razonsocialemisor;
                    _comprobante.TipoComprobante = Info.tipocomprobante;
                    _comprobante.SerieComprobante = Info.seriecomprobante;
                    _comprobante.ClaveAcceso = Info.claveacceso;
                    _comprobante.FechaAutorizacion = Info.fechaautorizacion;
                    _comprobante.NumeroAutorizacion = Info.numeroautorizacion;
                    _comprobante.FechaEmision = Info.fechaemision;
                    _comprobante.IdentificacionReceptor = Info.identificacionreceptor;
                    _comprobante.ValorSinImpuestos = Info.valorsinimpuestos;
                    _comprobante.Iva = Info.iva;
                    _comprobante.ImporteTotal = Info.importetotal;
                    _comprobante.NumeroDocumentoModificado = Info.numerodocumentomodificado;
                    _comprobante.Estado = Info.estado;
                    _comprobante.Motivo = Info.motivo;
                    _comprobante.XML = Info.xml;
                    _comprobante.IdEmpresa_Ogiro = Info.idempresa_ogiro;
                    _comprobante.IdCbteCble_Ogiro = Info.idcbtecble_ogiro;
                    _comprobante.IdTipoCbte_Ogiro = Info.idtipocbte_ogiro;

                    ListComprobantesRecibidos.Add(_comprobante);
                }

                return ListComprobantesRecibidos;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<tb_ComprobantesRecibidos_Info> GetList(string Ruc, DateTime FechaIni, DateTime FechaFin, string TipoComprobante)
        {
            try
            {
                List<tb_ComprobantesRecibidos_Info> ListComprobantesRecibidos = new List<tb_ComprobantesRecibidos_Info>();

                EntitiesGeneral dbContext = new EntitiesGeneral();

                var query = dbContext.tb_comprobantesrecibidos.Where(
                    q => q.identificacionreceptor == Ruc
                    && q.fechaemision >= FechaIni
                    && q.fechaemision <= FechaFin
                    && q.tipocomprobante == TipoComprobante
                ).ToList();

                foreach (var Info in query)
                {
                    tb_ComprobantesRecibidos_Info _comprobante = new tb_ComprobantesRecibidos_Info();
                    _comprobante.Id = Info.id;
                    _comprobante.RucEmisor = Info.rucemisor;
                    _comprobante.RazonSocialEmisor = Info.razonsocialemisor;
                    _comprobante.TipoComprobante = Info.tipocomprobante;
                    _comprobante.SerieComprobante = Info.seriecomprobante;
                    _comprobante.ClaveAcceso = Info.claveacceso;
                    _comprobante.FechaAutorizacion = Info.fechaautorizacion;
                    _comprobante.NumeroAutorizacion = Info.numeroautorizacion;
                    _comprobante.FechaEmision = Info.fechaemision;
                    _comprobante.IdentificacionReceptor = Info.identificacionreceptor;
                    _comprobante.ValorSinImpuestos = Info.valorsinimpuestos;
                    _comprobante.Iva = Info.iva;
                    _comprobante.ImporteTotal = Info.importetotal;
                    _comprobante.NumeroDocumentoModificado = Info.numerodocumentomodificado;
                    _comprobante.Estado = Info.estado;
                    _comprobante.Motivo = Info.motivo;
                    _comprobante.XML = Info.xml;
                    _comprobante.IdEmpresa_Ogiro = Info.idempresa_ogiro;
                    _comprobante.IdCbteCble_Ogiro = Info.idcbtecble_ogiro;
                    _comprobante.IdTipoCbte_Ogiro = Info.idtipocbte_ogiro;

                    ListComprobantesRecibidos.Add(_comprobante);
                }

                return ListComprobantesRecibidos;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<tb_ComprobantesRecibidos_Info> GetList(string Ruc, DateTime FechaIni, DateTime FechaFin, string TipoComprobante, string Estado)
        {
            try
            {
                List<tb_ComprobantesRecibidos_Info> ListComprobantesRecibidos = new List<tb_ComprobantesRecibidos_Info>();

                EntitiesGeneral dbContext = new EntitiesGeneral();

                var query = dbContext.tb_comprobantesrecibidos.Where(
                    q => q.identificacionreceptor == Ruc
                    && q.fechaemision >= FechaIni
                    && q.fechaemision <= FechaFin
                    && q.tipocomprobante == TipoComprobante
                    && q.estado == Estado
                ).ToList();

                foreach (var Info in query)
                {
                    tb_ComprobantesRecibidos_Info _comprobante = new tb_ComprobantesRecibidos_Info();
                    _comprobante.Id = Info.id;
                    _comprobante.RucEmisor = Info.rucemisor;
                    _comprobante.RazonSocialEmisor = Info.razonsocialemisor;
                    _comprobante.TipoComprobante = Info.tipocomprobante;
                    _comprobante.SerieComprobante = Info.seriecomprobante;
                    _comprobante.ClaveAcceso = Info.claveacceso;
                    _comprobante.FechaAutorizacion = Info.fechaautorizacion;
                    _comprobante.NumeroAutorizacion = Info.numeroautorizacion;
                    _comprobante.FechaEmision = Info.fechaemision;
                    _comprobante.IdentificacionReceptor = Info.identificacionreceptor;
                    _comprobante.ValorSinImpuestos = Info.valorsinimpuestos;
                    _comprobante.Iva = Info.iva;
                    _comprobante.ImporteTotal = Info.importetotal;
                    _comprobante.NumeroDocumentoModificado = Info.numerodocumentomodificado;
                    _comprobante.Estado = Info.estado;
                    _comprobante.Motivo = Info.motivo;
                    _comprobante.XML = Info.xml;
                    _comprobante.IdEmpresa_Ogiro = Info.idempresa_ogiro;
                    _comprobante.IdCbteCble_Ogiro = Info.idcbtecble_ogiro;
                    _comprobante.IdTipoCbte_Ogiro = Info.idtipocbte_ogiro;

                    ListComprobantesRecibidos.Add(_comprobante);
                }

                return ListComprobantesRecibidos;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<tb_ComprobantesRecibidos_Info> GetList(string Ruc, string Estado)
        {
            try
            {
                List<tb_ComprobantesRecibidos_Info> ListComprobantesRecibidos = new List<tb_ComprobantesRecibidos_Info>();

                EntitiesGeneral dbContext = new EntitiesGeneral();

                var query = dbContext.tb_comprobantesrecibidos.Where(q => q.identificacionreceptor == Ruc && q.estado == Estado).ToList();

                foreach (var Info in query)
                {
                    tb_ComprobantesRecibidos_Info _comprobante = new tb_ComprobantesRecibidos_Info();
                    _comprobante.Id = Info.id;
                    _comprobante.RucEmisor = Info.rucemisor;
                    _comprobante.RazonSocialEmisor = Info.razonsocialemisor;
                    _comprobante.TipoComprobante = Info.tipocomprobante;
                    _comprobante.SerieComprobante = Info.seriecomprobante;
                    _comprobante.ClaveAcceso = Info.claveacceso;
                    _comprobante.FechaAutorizacion = Info.fechaautorizacion;
                    _comprobante.NumeroAutorizacion = Info.numeroautorizacion;
                    _comprobante.FechaEmision = Info.fechaemision;
                    _comprobante.IdentificacionReceptor = Info.identificacionreceptor;
                    _comprobante.ValorSinImpuestos = Info.valorsinimpuestos;
                    _comprobante.Iva = Info.iva;
                    _comprobante.ImporteTotal = Info.importetotal;
                    _comprobante.NumeroDocumentoModificado = Info.numerodocumentomodificado;
                    _comprobante.Estado = Info.estado;
                    _comprobante.Motivo = Info.motivo;
                    _comprobante.XML = Info.xml;
                    _comprobante.IdEmpresa_Ogiro = Info.idempresa_ogiro;
                    _comprobante.IdCbteCble_Ogiro = Info.idcbtecble_ogiro;
                    _comprobante.IdTipoCbte_Ogiro = Info.idtipocbte_ogiro;

                    ListComprobantesRecibidos.Add(_comprobante);
                }

                return ListComprobantesRecibidos;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int GetId()
        {
            try
            {
                int Id = 0;

                EntitiesGeneral dbContext = new EntitiesGeneral();

                var query = dbContext.tb_comprobantesrecibidos.ToList();

                if (query.Count > 0)
                    Id = query.Select(q => q.id).Max() + 1;
                else
                    Id = 1;

                return Id;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
