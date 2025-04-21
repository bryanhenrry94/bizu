using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Info.Facturacion;

namespace Core.Erp.Data.Facturacion
{
    public class fa_cliente_Obra_Data
    {
        public bool GrabarDB(List<fa_cliente_Obra_Info> Info, ref string mensaje)
        {
            try
            {
                using (EntitiesFacturacion Context = new EntitiesFacturacion())
                {

                    foreach (var item in Info)
                    {
                        fa_cliente_obra Address = new fa_cliente_obra();
                        Address.IdEmpresa = item.IdEmpresa;
                        Address.IdCliente = item.IdCliente;
                        Address.IdCentroCosto = item.IdCentroCosto;
                        Address.FechaIni = item.FechaIni;
                        Address.FechaFin = item.FechaFin;
                        Address.DireccionObra = item.DireccionObra;
                        Address.CorreoObra = item.CorreoObra;
                        Address.IdEstadoObra = item.IdEstadoObra;

                        Context.fa_cliente_obra.Add(Address);
                    }

                    Context.SaveChanges();

                    mensaje = "Registro realizado con éxito!";
                }

                return true;
            }
            catch (Exception ex)
            {
                mensaje = ex.InnerException.Message;
                throw new Exception(mensaje);
            }
        }

        public List<fa_cliente_Obra_Info> Get_Info(int IdEmpresa, decimal IdCliente)
        {
            try
            {
                List<fa_cliente_Obra_Info> Lista = new List<fa_cliente_Obra_Info>();

                EntitiesFacturacion Context = new EntitiesFacturacion();

                var query = from q in Context.fa_cliente_obra
                            where q.IdEmpresa == IdEmpresa
                            && q.IdCliente == IdCliente
                            select q;

                foreach (var item in query)
                {
                    fa_cliente_Obra_Info Info = new fa_cliente_Obra_Info();
                    Info.IdEmpresa = item.IdEmpresa;
                    Info.IdCliente = item.IdCliente;
                    Info.IdCentroCosto = item.IdCentroCosto;
                    Info.FechaIni = item.FechaIni;
                    Info.FechaFin = item.FechaFin;
                    Info.DireccionObra = item.DireccionObra;
                    Info.CorreoObra = item.CorreoObra;
                    Info.IdEstadoObra = item.IdEstadoObra;

                    Lista.Add(Info);
                }

                return Lista;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<fa_cliente_Obra_Info> Get_Info_x_Estado(int IdEmpresa, decimal IdCliente, string IdEstadoObra)
        {
            try
            {
                List<fa_cliente_Obra_Info> Lista = new List<fa_cliente_Obra_Info>();

                EntitiesFacturacion Context = new EntitiesFacturacion();

                var query = from q in Context.fa_cliente_obra
                            where q.IdEmpresa == IdEmpresa
                            && q.IdCliente == IdCliente
                            && q.IdEstadoObra == IdEstadoObra
                            select q;

                foreach (var item in query)
                {
                    fa_cliente_Obra_Info Info = new fa_cliente_Obra_Info();
                    Info.IdEmpresa = item.IdEmpresa;
                    Info.IdCliente = item.IdCliente;
                    Info.IdCentroCosto = item.IdCentroCosto;
                    Info.FechaIni = item.FechaIni;
                    Info.FechaFin = item.FechaFin;
                    Info.DireccionObra = item.DireccionObra;
                    Info.CorreoObra = item.CorreoObra;
                    Info.IdEstadoObra = item.IdEstadoObra;

                    Lista.Add(Info);
                }

                return Lista;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }        

        public fa_cliente_Obra_Info Get_Info(int IdEmpresa, decimal IdCliente, string IdCentroCosto)
        {
            try
            {
                fa_cliente_Obra_Info Info = new fa_cliente_Obra_Info();

                EntitiesFacturacion Context = new EntitiesFacturacion();

                var query = from q in Context.fa_cliente_obra
                            where q.IdEmpresa == IdEmpresa
                            && q.IdCliente == IdCliente
                            && q.IdCentroCosto == IdCentroCosto
                            select q;

                foreach (var item in query)
                {
                    Info = new fa_cliente_Obra_Info();
                    Info.IdEmpresa = item.IdEmpresa;
                    Info.IdCliente = item.IdCliente;
                    Info.IdCentroCosto = item.IdCentroCosto;
                    Info.FechaIni = item.FechaIni;
                    Info.FechaFin = item.FechaFin;
                    Info.DireccionObra = item.DireccionObra;
                    Info.CorreoObra = item.CorreoObra;
                    Info.IdEstadoObra = item.IdEstadoObra;                    
                }

                return Info;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        
        public List<fa_cliente_Obra_Info> Get_List(int IdEmpresa, string IdCentroCosto)
        {
            try
            {
                List<fa_cliente_Obra_Info> Lista = new List<fa_cliente_Obra_Info>();
                
                EntitiesFacturacion Context = new EntitiesFacturacion();

                var query = from q in Context.fa_cliente_obra
                            where q.IdEmpresa == IdEmpresa                            
                            && q.IdCentroCosto == IdCentroCosto
                            select q;

                foreach (var item in query)
                {
                    fa_cliente_Obra_Info Info = new fa_cliente_Obra_Info();
                    Info.IdEmpresa = item.IdEmpresa;
                    Info.IdCliente = item.IdCliente;
                    Info.IdCentroCosto = item.IdCentroCosto;
                    Info.FechaIni = item.FechaIni;
                    Info.FechaFin = item.FechaFin;
                    Info.DireccionObra = item.DireccionObra;
                    Info.CorreoObra = item.CorreoObra;
                    Info.IdEstadoObra = item.IdEstadoObra;

                    Lista.Add(Info);
                }

                return Lista;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public bool EliminarDB(int IdEmpresa, decimal IdCliente)
        {
            try
            {
                using (EntitiesFacturacion Context = new EntitiesFacturacion())
                {
                    int iFilasAfectadas = Context.Database.ExecuteSqlCommand("DELETE FROM fa_cliente_obra WHERE IdEmpresa =" + IdEmpresa + " and IdCliente = " + IdCliente);

                    if (iFilasAfectadas > 0)
                    {
                        return true;
                    }
                    else
                        return false;
                }                
            }
            catch (Exception ex)
            {
                throw new Exception(ex.InnerException.Message);
            }
        }
    }
}
