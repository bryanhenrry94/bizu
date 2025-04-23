using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bizu.Domain.General;
using Bizu.Infrastructure.General;

namespace Bizu.Application.General
{
    public class tb_ComprobantesRecibidos_Bus
    {
        private tb_ComprobantesRecibidos_Data Data;      
        
        public tb_ComprobantesRecibidos_Bus()
        {
            this.Data = new tb_ComprobantesRecibidos_Data();
        }

        public bool GrabarBD(tb_ComprobantesRecibidos_Info Info)
        {
            try
            {                
                return this.Data.GrabarBD(Info);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool Existe(string RucEmisor, string SerieComprobante)
        {
            try
            {
                return this.Data.Existe(RucEmisor, SerieComprobante);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool ModificarDB(tb_ComprobantesRecibidos_Info Info)
        {
            try
            {                
                return this.Data.ModificarDB(Info);
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
                return this.Data.EliminarBD(Id);
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
                return this.Data.GetInfo(RucEmisor, TipoComprobante, SerieComprobante);
            }catch(Exception ex)
            {
                throw ex;
            }
        }

        public List<tb_ComprobantesRecibidos_Info> GetList()
        {
            try
            {
                return this.Data.GetList();
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
                return this.Data.GetList(Ruc);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<tb_ComprobantesRecibidos_Info> GetList(string Ruc, DateTime FechaIni, DateTime FechaFin)
        {
            try
            {
                return this.Data.GetList(Ruc, FechaIni, FechaFin);
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
                return this.Data.GetList(Ruc, FechaIni, FechaFin, TipoComprobante);
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
                return this.Data.GetList(Ruc, FechaIni, FechaFin, TipoComprobante, Estado);
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
                return this.Data.GetList(Ruc, Estado);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }        
    }
}
