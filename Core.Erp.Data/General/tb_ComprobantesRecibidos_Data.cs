using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Info.General;
using System.Data.Entity.Validation;

namespace Core.Erp.Data.General
{
    public class tb_ComprobantesRecibidos_Data
    {
        public bool GrabarBD(tb_ComprobantesRecibidos_Info Info)
        {
            try
            {
                EntitiesGeneral dbContext = new EntitiesGeneral();

                Info.Id = GetId();

                tb_ComprobantesRecibidos _comprobante = new tb_ComprobantesRecibidos();
                _comprobante.Id = Info.Id;
                _comprobante.RucEmisor = Info.RucEmisor;
                _comprobante.RazonSocialEmisor = Info.RazonSocialEmisor;
                _comprobante.TipoComprobante = Info.TipoComprobante;
                _comprobante.SerieComprobante = Info.SerieComprobante;
                _comprobante.ClaveAcceso = Info.ClaveAcceso;
                _comprobante.FechaAutorizacion = Info.FechaAutorizacion;
                _comprobante.NumeroAutorizacion = Info.NumeroAutorizacion;
                _comprobante.FechaEmision = Info.FechaEmision;
                _comprobante.IdentificacionReceptor = Info.IdentificacionReceptor;
                _comprobante.ValorSinImpuestos = Info.ValorSinImpuestos;
                _comprobante.Iva = Info.Iva;
                _comprobante.ImporteTotal = Info.ImporteTotal;
                _comprobante.NumeroDocumentoModificado = Info.NumeroDocumentoModificado;
                _comprobante.Estado = Info.Estado;
                _comprobante.Motivo = Info.Motivo;
                _comprobante.XML = Info.XML;
                _comprobante.IdEmpresa_Ogiro = Info.IdEmpresa_Ogiro;
                _comprobante.IdCbteCble_Ogiro = Info.IdCbteCble_Ogiro;
                _comprobante.IdTipoCbte_Ogiro = Info.IdTipoCbte_Ogiro;

                dbContext.tb_ComprobantesRecibidos.Add(_comprobante);
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

                var query = dbContext.tb_ComprobantesRecibidos.Where(q => q.RucEmisor == RucEmisor && q.SerieComprobante == SerieComprobante).ToList();

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

                tb_ComprobantesRecibidos _comprobante = dbContext.tb_ComprobantesRecibidos.Where(q => q.Id == Info.Id).First();

                if(_comprobante != null)
                {
                    //_comprobante.Id = Info.Id;
                    _comprobante.RucEmisor = Info.RucEmisor;
                    _comprobante.RazonSocialEmisor = Info.RazonSocialEmisor;
                    _comprobante.TipoComprobante = Info.TipoComprobante;
                    _comprobante.SerieComprobante = Info.SerieComprobante;
                    _comprobante.ClaveAcceso = Info.ClaveAcceso;
                    _comprobante.FechaAutorizacion = Info.FechaAutorizacion;
                    _comprobante.NumeroAutorizacion = Info.NumeroAutorizacion;
                    _comprobante.FechaEmision = Info.FechaEmision;
                    _comprobante.IdentificacionReceptor = Info.IdentificacionReceptor;
                    _comprobante.ValorSinImpuestos = Info.ValorSinImpuestos;
                    _comprobante.Iva = Info.Iva;
                    _comprobante.ImporteTotal = Info.ImporteTotal;
                    _comprobante.NumeroDocumentoModificado = Info.NumeroDocumentoModificado;
                    _comprobante.Estado = Info.Estado;
                    _comprobante.Motivo = Info.Motivo;
                    _comprobante.XML = Info.XML;
                    _comprobante.IdEmpresa_Ogiro = Info.IdEmpresa_Ogiro;
                    _comprobante.IdCbteCble_Ogiro = Info.IdCbteCble_Ogiro;
                    _comprobante.IdTipoCbte_Ogiro = Info.IdTipoCbte_Ogiro;

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

                tb_ComprobantesRecibidos _comprobante = dbContext.tb_ComprobantesRecibidos.Where(q => q.Id == Id).First();

                if (_comprobante != null)
                {
                    dbContext.tb_ComprobantesRecibidos.Remove(_comprobante);
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

                var query = dbContext.tb_ComprobantesRecibidos.Where(q => q.RucEmisor == RucEmisor && q.TipoComprobante == TipoComprobante && q.SerieComprobante == SerieComprobante);

                foreach(var Info in query)
                {
                    _comprobante.Id = Info.Id;
                    _comprobante.RucEmisor = Info.RucEmisor;
                    _comprobante.RazonSocialEmisor = Info.RazonSocialEmisor;
                    _comprobante.TipoComprobante = Info.TipoComprobante;
                    _comprobante.SerieComprobante = Info.SerieComprobante;
                    _comprobante.ClaveAcceso = Info.ClaveAcceso;
                    _comprobante.FechaAutorizacion = Info.FechaAutorizacion;
                    _comprobante.NumeroAutorizacion = Info.NumeroAutorizacion;
                    _comprobante.FechaEmision = Info.FechaEmision;
                    _comprobante.IdentificacionReceptor = Info.IdentificacionReceptor;
                    _comprobante.ValorSinImpuestos = Info.ValorSinImpuestos;
                    _comprobante.Iva = Info.Iva;
                    _comprobante.ImporteTotal = Info.ImporteTotal;
                    _comprobante.NumeroDocumentoModificado = Info.NumeroDocumentoModificado;
                    _comprobante.Estado = Info.Estado;
                    _comprobante.Motivo = Info.Motivo;
                    _comprobante.XML = Info.XML;
                    _comprobante.IdEmpresa_Ogiro = Info.IdEmpresa_Ogiro;
                    _comprobante.IdCbteCble_Ogiro = Info.IdCbteCble_Ogiro;
                    _comprobante.IdTipoCbte_Ogiro = Info.IdTipoCbte_Ogiro;
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

                var query = dbContext.tb_ComprobantesRecibidos.ToList();

                foreach (var Info in query)
                {
                    tb_ComprobantesRecibidos_Info _comprobante = new tb_ComprobantesRecibidos_Info();
                    _comprobante.Id = Info.Id;
                    _comprobante.RucEmisor = Info.RucEmisor;
                    _comprobante.RazonSocialEmisor = Info.RazonSocialEmisor;
                    _comprobante.TipoComprobante = Info.TipoComprobante;
                    _comprobante.SerieComprobante = Info.SerieComprobante;
                    _comprobante.ClaveAcceso = Info.ClaveAcceso;
                    _comprobante.FechaAutorizacion = Info.FechaAutorizacion;
                    _comprobante.NumeroAutorizacion = Info.NumeroAutorizacion;
                    _comprobante.FechaEmision = Info.FechaEmision;
                    _comprobante.IdentificacionReceptor = Info.IdentificacionReceptor;
                    _comprobante.ValorSinImpuestos = Info.ValorSinImpuestos;
                    _comprobante.Iva = Info.Iva;
                    _comprobante.ImporteTotal = Info.ImporteTotal;
                    _comprobante.NumeroDocumentoModificado = Info.NumeroDocumentoModificado;
                    _comprobante.Estado = Info.Estado;
                    _comprobante.Motivo = Info.Motivo;
                    _comprobante.XML = Info.XML;
                    _comprobante.IdEmpresa_Ogiro = Info.IdEmpresa_Ogiro;
                    _comprobante.IdCbteCble_Ogiro = Info.IdCbteCble_Ogiro;
                    _comprobante.IdTipoCbte_Ogiro = Info.IdTipoCbte_Ogiro;

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

                var query = dbContext.tb_ComprobantesRecibidos.Where(q => q.IdentificacionReceptor == Ruc).ToList();

                foreach(var Info in query)
                {
                    tb_ComprobantesRecibidos_Info _comprobante = new tb_ComprobantesRecibidos_Info();
                    _comprobante.Id = Info.Id;
                    _comprobante.RucEmisor = Info.RucEmisor;
                    _comprobante.RazonSocialEmisor = Info.RazonSocialEmisor;
                    _comprobante.TipoComprobante = Info.TipoComprobante;
                    _comprobante.SerieComprobante = Info.SerieComprobante;
                    _comprobante.ClaveAcceso = Info.ClaveAcceso;
                    _comprobante.FechaAutorizacion = Info.FechaAutorizacion;
                    _comprobante.NumeroAutorizacion = Info.NumeroAutorizacion;
                    _comprobante.FechaEmision = Info.FechaEmision;
                    _comprobante.IdentificacionReceptor = Info.IdentificacionReceptor;
                    _comprobante.ValorSinImpuestos = Info.ValorSinImpuestos;
                    _comprobante.Iva = Info.Iva;
                    _comprobante.ImporteTotal = Info.ImporteTotal;
                    _comprobante.NumeroDocumentoModificado = Info.NumeroDocumentoModificado;
                    _comprobante.Estado = Info.Estado;
                    _comprobante.Motivo = Info.Motivo;
                    _comprobante.XML = Info.XML;
                    _comprobante.IdEmpresa_Ogiro = Info.IdEmpresa_Ogiro;
                    _comprobante.IdCbteCble_Ogiro = Info.IdCbteCble_Ogiro;
                    _comprobante.IdTipoCbte_Ogiro = Info.IdTipoCbte_Ogiro;

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

                var query = dbContext.tb_ComprobantesRecibidos.Where(
                    q => q.IdentificacionReceptor == Ruc
                    && q.FechaEmision >= FechaIni
                    && q.FechaEmision <= FechaFin                    
                ).ToList();

                foreach (var Info in query)
                {
                    tb_ComprobantesRecibidos_Info _comprobante = new tb_ComprobantesRecibidos_Info();
                    _comprobante.Id = Info.Id;
                    _comprobante.RucEmisor = Info.RucEmisor;
                    _comprobante.RazonSocialEmisor = Info.RazonSocialEmisor;
                    _comprobante.TipoComprobante = Info.TipoComprobante;
                    _comprobante.SerieComprobante = Info.SerieComprobante;
                    _comprobante.ClaveAcceso = Info.ClaveAcceso;
                    _comprobante.FechaAutorizacion = Info.FechaAutorizacion;
                    _comprobante.NumeroAutorizacion = Info.NumeroAutorizacion;
                    _comprobante.FechaEmision = Info.FechaEmision;
                    _comprobante.IdentificacionReceptor = Info.IdentificacionReceptor;
                    _comprobante.ValorSinImpuestos = Info.ValorSinImpuestos;
                    _comprobante.Iva = Info.Iva;
                    _comprobante.ImporteTotal = Info.ImporteTotal;
                    _comprobante.NumeroDocumentoModificado = Info.NumeroDocumentoModificado;
                    _comprobante.Estado = Info.Estado;
                    _comprobante.Motivo = Info.Motivo;
                    _comprobante.XML = Info.XML;
                    _comprobante.IdEmpresa_Ogiro = Info.IdEmpresa_Ogiro;
                    _comprobante.IdCbteCble_Ogiro = Info.IdCbteCble_Ogiro;
                    _comprobante.IdTipoCbte_Ogiro = Info.IdTipoCbte_Ogiro;

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

                var query = dbContext.tb_ComprobantesRecibidos.Where(
                    q => q.IdentificacionReceptor == Ruc
                    && q.FechaEmision >= FechaIni
                    && q.FechaEmision <= FechaFin
                    && q.TipoComprobante == TipoComprobante
                ).ToList();

                foreach (var Info in query)
                {
                    tb_ComprobantesRecibidos_Info _comprobante = new tb_ComprobantesRecibidos_Info();
                    _comprobante.Id = Info.Id;
                    _comprobante.RucEmisor = Info.RucEmisor;
                    _comprobante.RazonSocialEmisor = Info.RazonSocialEmisor;
                    _comprobante.TipoComprobante = Info.TipoComprobante;
                    _comprobante.SerieComprobante = Info.SerieComprobante;
                    _comprobante.ClaveAcceso = Info.ClaveAcceso;
                    _comprobante.FechaAutorizacion = Info.FechaAutorizacion;
                    _comprobante.NumeroAutorizacion = Info.NumeroAutorizacion;
                    _comprobante.FechaEmision = Info.FechaEmision;
                    _comprobante.IdentificacionReceptor = Info.IdentificacionReceptor;
                    _comprobante.ValorSinImpuestos = Info.ValorSinImpuestos;
                    _comprobante.Iva = Info.Iva;
                    _comprobante.ImporteTotal = Info.ImporteTotal;
                    _comprobante.NumeroDocumentoModificado = Info.NumeroDocumentoModificado;
                    _comprobante.Estado = Info.Estado;
                    _comprobante.Motivo = Info.Motivo;
                    _comprobante.XML = Info.XML;
                    _comprobante.IdEmpresa_Ogiro = Info.IdEmpresa_Ogiro;
                    _comprobante.IdCbteCble_Ogiro = Info.IdCbteCble_Ogiro;
                    _comprobante.IdTipoCbte_Ogiro = Info.IdTipoCbte_Ogiro;

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

                var query = dbContext.tb_ComprobantesRecibidos.Where(
                    q => q.IdentificacionReceptor == Ruc
                    && q.FechaEmision >= FechaIni
                    && q.FechaEmision <= FechaFin
                    && q.TipoComprobante == TipoComprobante
                    && q.Estado == Estado
                ).ToList();

                foreach (var Info in query)
                {
                    tb_ComprobantesRecibidos_Info _comprobante = new tb_ComprobantesRecibidos_Info();
                    _comprobante.Id = Info.Id;
                    _comprobante.RucEmisor = Info.RucEmisor;
                    _comprobante.RazonSocialEmisor = Info.RazonSocialEmisor;
                    _comprobante.TipoComprobante = Info.TipoComprobante;
                    _comprobante.SerieComprobante = Info.SerieComprobante;
                    _comprobante.ClaveAcceso = Info.ClaveAcceso;
                    _comprobante.FechaAutorizacion = Info.FechaAutorizacion;
                    _comprobante.NumeroAutorizacion = Info.NumeroAutorizacion;
                    _comprobante.FechaEmision = Info.FechaEmision;
                    _comprobante.IdentificacionReceptor = Info.IdentificacionReceptor;
                    _comprobante.ValorSinImpuestos = Info.ValorSinImpuestos;
                    _comprobante.Iva = Info.Iva;
                    _comprobante.ImporteTotal = Info.ImporteTotal;
                    _comprobante.NumeroDocumentoModificado = Info.NumeroDocumentoModificado;
                    _comprobante.Estado = Info.Estado;
                    _comprobante.Motivo = Info.Motivo;
                    _comprobante.XML = Info.XML;
                    _comprobante.IdEmpresa_Ogiro = Info.IdEmpresa_Ogiro;
                    _comprobante.IdCbteCble_Ogiro = Info.IdCbteCble_Ogiro;
                    _comprobante.IdTipoCbte_Ogiro = Info.IdTipoCbte_Ogiro;

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

                var query = dbContext.tb_ComprobantesRecibidos.Where(q => q.IdentificacionReceptor == Ruc && q.Estado == Estado).ToList();

                foreach (var Info in query)
                {
                    tb_ComprobantesRecibidos_Info _comprobante = new tb_ComprobantesRecibidos_Info();
                    _comprobante.Id = Info.Id;
                    _comprobante.RucEmisor = Info.RucEmisor;
                    _comprobante.RazonSocialEmisor = Info.RazonSocialEmisor;
                    _comprobante.TipoComprobante = Info.TipoComprobante;
                    _comprobante.SerieComprobante = Info.SerieComprobante;
                    _comprobante.ClaveAcceso = Info.ClaveAcceso;
                    _comprobante.FechaAutorizacion = Info.FechaAutorizacion;
                    _comprobante.NumeroAutorizacion = Info.NumeroAutorizacion;
                    _comprobante.FechaEmision = Info.FechaEmision;
                    _comprobante.IdentificacionReceptor = Info.IdentificacionReceptor;
                    _comprobante.ValorSinImpuestos = Info.ValorSinImpuestos;
                    _comprobante.Iva = Info.Iva;
                    _comprobante.ImporteTotal = Info.ImporteTotal;
                    _comprobante.NumeroDocumentoModificado = Info.NumeroDocumentoModificado;
                    _comprobante.Estado = Info.Estado;
                    _comprobante.Motivo = Info.Motivo;
                    _comprobante.XML = Info.XML;
                    _comprobante.IdEmpresa_Ogiro = Info.IdEmpresa_Ogiro;
                    _comprobante.IdCbteCble_Ogiro = Info.IdCbteCble_Ogiro;
                    _comprobante.IdTipoCbte_Ogiro = Info.IdTipoCbte_Ogiro;

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

                var query = dbContext.tb_ComprobantesRecibidos.ToList();

                if (query.Count > 0)
                    Id = query.Select(q => q.Id).Max() + 1;
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
