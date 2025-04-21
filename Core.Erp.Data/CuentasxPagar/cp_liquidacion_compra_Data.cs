using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Info.CuentasxPagar;

namespace Core.Erp.Data.CuentasxPagar
{
    public class cp_liquidacion_compra_Data
    {
        public bool GrabarDB(cp_liquidacion_compra_Info Info, ref string msg)
        {
            try
            {
                using (EntitiesCuentasxPagar context = new EntitiesCuentasxPagar())
                {
                    cp_liquidacion_compra Addres = new cp_liquidacion_compra();
                    Addres.IdEmpresa = Info.IdEmpresa;
                    Info.IdLiquidacionCompra = GetId(Info.IdEmpresa); //OBTENGO ID
                    Addres.IdLiquidacionCompra = Info.IdLiquidacionCompra;
                    Addres.CodDocumentoTipo = Info.CodDocumentoTipo;
                    Addres.serie1 = Info.serie1;
                    Addres.serie2 = Info.serie2;
                    Addres.NumDocumento = Info.NumDocumento;
                    Addres.NAutorizacion = Info.NAutorizacion;
                    Addres.Fecha_Autorizacion = Info.Fecha_Autorizacion;
                    Addres.fecha = Info.fecha;
                    Addres.observacion = Info.observacion;
                    Addres.IdEmpresa_Ogiro = Info.IdEmpresa_Ogiro;
                    Addres.IdCbteCble_Ogiro = Info.IdCbteCble_Ogiro;
                    Addres.IdTipoCbte_Ogiro = Info.IdTipoCbte_Ogiro;
                    Addres.ct_IdEmpresa_Anu = Info.ct_IdEmpresa_Anu;
                    Addres.ct_IdTipoCbte_Anu = Info.ct_IdTipoCbte_Anu;
                    Addres.ct_IdCbteCble_Anu = Info.ct_IdCbteCble_Anu;
                    Addres.cp_EstaImpresa = (Info.cp_EstaImpresa == null) ? "N" : Info.cp_EstaImpresa;
                    Addres.Estado = Info.Estado;
                    Addres.IdUsuario = Info.IdUsuario;
                    Addres.Fecha_Transac = Info.Fecha_Transac;
                    Addres.nom_pc = Info.nom_pc;
                    Addres.ip = Info.ip;
                    Addres.IdUsuarioUltMod = Info.IdUsuarioUltMod;
                    Addres.Fecha_UltMod = Info.Fecha_UltMod;
                    Addres.IdUsuarioUltAnu = Info.IdUsuarioUltAnu;
                    Addres.Fecha_UltAnu = Info.Fecha_UltAnu;
                    Addres.MotivoAnulacion = Info.MotivoAnulacion;

                    context.cp_liquidacion_compra.Add(Addres);

                    context.SaveChanges();

                    msg = "Liquidacion de compra registrado con éxito!";
                }

                return true;
            }
            catch (Exception ex)
            {
                msg = ex.InnerException.Message;
                throw new Exception(ex.InnerException.Message);
            }
        }

        public bool ModificarDB(cp_liquidacion_compra_Info Info, ref string msg)
        {
            try
            {
                using (EntitiesCuentasxPagar context = new EntitiesCuentasxPagar())
                {
                    cp_liquidacion_compra Addres = new cp_liquidacion_compra();

                    Addres = (from q in context.cp_liquidacion_compra
                              where q.IdEmpresa == Info.IdEmpresa
                              && q.IdLiquidacionCompra == Info.IdLiquidacionCompra
                              select q).FirstOrDefault();

                    if (Addres != null)
                    {
                        Addres.CodDocumentoTipo = Info.CodDocumentoTipo;
                        Addres.serie1 = Info.serie1;
                        Addres.serie2 = Info.serie2;
                        Addres.NumDocumento = Info.NumDocumento;
                        Addres.NAutorizacion = Info.NAutorizacion;
                        Addres.Fecha_Autorizacion = Info.Fecha_Autorizacion;
                        Addres.fecha = Info.fecha;
                        Addres.observacion = Info.observacion;
                        Addres.IdEmpresa_Ogiro = Info.IdEmpresa_Ogiro;
                        Addres.IdCbteCble_Ogiro = Info.IdCbteCble_Ogiro;
                        Addres.IdTipoCbte_Ogiro = Info.IdTipoCbte_Ogiro;
                        //Addres.ct_IdEmpresa_Anu = Info.ct_IdEmpresa_Anu;
                        //Addres.ct_IdTipoCbte_Anu = Info.ct_IdTipoCbte_Anu;
                        //Addres.ct_IdCbteCble_Anu = Info.ct_IdCbteCble_Anu;
                        //Addres.cp_EstaImpresa = Info.cp_EstaImpresa;
                        Addres.Estado = Info.Estado;
                        Addres.IdUsuarioUltMod = Info.IdUsuarioUltMod;
                        Addres.Fecha_UltMod = Info.Fecha_UltMod;
                        Addres.IdUsuarioUltAnu = Info.IdUsuarioUltAnu;
                        Addres.Fecha_UltAnu = Info.Fecha_UltAnu;
                        Addres.MotivoAnulacion = Info.MotivoAnulacion;

                        context.SaveChanges();
                    }
                    else
                    {
                        if (GrabarDB(Info, ref msg))
                        {

                        }
                    }

                    msg = "Liquidacion de compra registrado con éxito!";
                }

                return true;
            }
            catch (Exception ex)
            {
                msg = ex.InnerException.Message;
                throw new Exception(ex.InnerException.Message);
            }
        }

        public decimal GetId(int IdEmpresa)
        {
            try
            {
                decimal ID = 0;

                EntitiesCuentasxPagar Context = new EntitiesCuentasxPagar();

                var query = from q in Context.cp_liquidacion_compra
                            where q.IdEmpresa == IdEmpresa
                            select q;

                if (query.Count() > 0)
                {
                    ID = (from q in Context.cp_liquidacion_compra
                          where q.IdEmpresa == IdEmpresa
                          select q.IdLiquidacionCompra).Max() + 1;
                }
                else
                {
                    ID = 1;
                }

                return ID;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Boolean Modificar_Num_Retencion(cp_liquidacion_compra_Info info, ref string mensaje)
        {
            try
            {
                Boolean res = false;
                EntitiesCuentasxPagar context = new EntitiesCuentasxPagar();
                cp_liquidacion_compra reg = new cp_liquidacion_compra();

                reg = context.cp_liquidacion_compra.FirstOrDefault(minfo => minfo.IdEmpresa == info.IdEmpresa
                    && minfo.IdCbteCble_Ogiro == info.IdCbteCble_Ogiro
                    && minfo.IdTipoCbte_Ogiro == info.IdTipoCbte_Ogiro
                    && minfo.IdLiquidacionCompra == info.IdLiquidacionCompra);

                if (reg != null)
                {
                    reg.fecha = info.fecha;
                    reg.observacion = (String.IsNullOrEmpty(info.observacion) ? "" : info.observacion.Trim());                    

                    reg.serie1 = info.serie1;
                    reg.serie2 = info.serie2;
                    reg.CodDocumentoTipo = (info.CodDocumentoTipo == null) ? "RETEN" : info.CodDocumentoTipo;
                    reg.NumDocumento = info.NumDocumento;
                    ////////////////////
                    reg.NAutorizacion = info.NAutorizacion;
                    reg.Fecha_UltMod = info.Fecha_UltMod;
                    reg.IdUsuarioUltAnu = info.IdUsuarioUltMod;

                    context.SaveChanges();
                    res = true;
                }

                return res;
            }
            catch (Exception ex)
            {                
                throw new Exception(ex.ToString());
            }
        }

        public cp_liquidacion_compra_Info Get_Info(int IdEmpresa, int IdTipoCbte_Ogiro, decimal IdCbteCble_Ogiro)
        {
            try
            {
                cp_liquidacion_compra_det_Data Data_det = new cp_liquidacion_compra_det_Data();
                cp_liquidacion_compra_Info Info = new cp_liquidacion_compra_Info();

                using (EntitiesCuentasxPagar context = new EntitiesCuentasxPagar())
                {
                    var query = from q in context.cp_liquidacion_compra
                                where q.IdEmpresa == IdEmpresa
                                && q.IdTipoCbte_Ogiro == IdTipoCbte_Ogiro
                                && q.IdCbteCble_Ogiro == IdCbteCble_Ogiro
                                select q;

                    foreach (var item in query)
                    {                        
                        Info.IdEmpresa = item.IdEmpresa;                        
                        Info.IdLiquidacionCompra = item.IdLiquidacionCompra;
                        Info.CodDocumentoTipo = item.CodDocumentoTipo;
                        Info.serie1 = item.serie1;
                        Info.serie2 = item.serie2;
                        Info.NumDocumento = item.NumDocumento;
                        Info.NAutorizacion = item.NAutorizacion;
                        Info.Fecha_Autorizacion = item.Fecha_Autorizacion;
                        Info.fecha = item.fecha;
                        Info.observacion = item.observacion;
                        Info.IdEmpresa_Ogiro = item.IdEmpresa_Ogiro;
                        Info.IdCbteCble_Ogiro = item.IdCbteCble_Ogiro;
                        Info.IdTipoCbte_Ogiro = item.IdTipoCbte_Ogiro;
                        Info.ct_IdEmpresa_Anu = item.ct_IdEmpresa_Anu;
                        Info.ct_IdTipoCbte_Anu = item.ct_IdTipoCbte_Anu;
                        Info.ct_IdCbteCble_Anu = item.ct_IdCbteCble_Anu;
                        Info.cp_EstaImpresa = (item.cp_EstaImpresa == null) ? "N" : item.cp_EstaImpresa;
                        Info.Estado = item.Estado;
                        Info.IdUsuario = item.IdUsuario;
                        Info.Fecha_Transac = item.Fecha_Transac;
                        Info.nom_pc = item.nom_pc;
                        Info.ip = item.ip;
                        Info.IdUsuarioUltMod = item.IdUsuarioUltMod;
                        Info.Fecha_UltMod = item.Fecha_UltMod;
                        Info.IdUsuarioUltAnu = item.IdUsuarioUltAnu;
                        Info.Fecha_UltAnu = item.Fecha_UltAnu;
                        Info.MotivoAnulacion = item.MotivoAnulacion;                        

                        Info.cp_liquidacion_compra_det = new List<cp_liquidacion_compra_det_Info>();
                        Info.cp_liquidacion_compra_det = Data_det.Get_Detalle(Info.IdEmpresa, Info.IdLiquidacionCompra);
                    }                                       
                }

                return Info;
            }
            catch (Exception ex)
            {               
                throw new Exception(ex.InnerException.Message);
            }
        }

        public cp_liquidacion_compra_Info Get_Info(int IdEmpresa, decimal IdLiquidacionCompra)
        {
            try
            {
                cp_liquidacion_compra_det_Data Data_det = new cp_liquidacion_compra_det_Data();
                cp_liquidacion_compra_Info Info = new cp_liquidacion_compra_Info();

                using (EntitiesCuentasxPagar context = new EntitiesCuentasxPagar())
                {
                    var query = from q in context.cp_liquidacion_compra
                                where q.IdEmpresa == IdEmpresa
                                && q.IdLiquidacionCompra == IdLiquidacionCompra
                                select q;

                    foreach (var item in query)
                    {
                        Info.IdEmpresa = item.IdEmpresa;
                        Info.IdLiquidacionCompra = item.IdLiquidacionCompra;
                        Info.CodDocumentoTipo = item.CodDocumentoTipo;
                        Info.serie1 = item.serie1;
                        Info.serie2 = item.serie2;
                        Info.NumDocumento = item.NumDocumento;
                        Info.NAutorizacion = item.NAutorizacion;
                        Info.Fecha_Autorizacion = item.Fecha_Autorizacion;
                        Info.fecha = item.fecha;
                        Info.observacion = item.observacion;
                        Info.IdEmpresa_Ogiro = item.IdEmpresa_Ogiro;
                        Info.IdCbteCble_Ogiro = item.IdCbteCble_Ogiro;
                        Info.IdTipoCbte_Ogiro = item.IdTipoCbte_Ogiro;
                        Info.ct_IdEmpresa_Anu = item.ct_IdEmpresa_Anu;
                        Info.ct_IdTipoCbte_Anu = item.ct_IdTipoCbte_Anu;
                        Info.ct_IdCbteCble_Anu = item.ct_IdCbteCble_Anu;
                        Info.cp_EstaImpresa = (item.cp_EstaImpresa == null) ? "N" : item.cp_EstaImpresa;
                        Info.Estado = item.Estado;
                        Info.IdUsuario = item.IdUsuario;
                        Info.Fecha_Transac = item.Fecha_Transac;
                        Info.nom_pc = item.nom_pc;
                        Info.ip = item.ip;
                        Info.IdUsuarioUltMod = item.IdUsuarioUltMod;
                        Info.Fecha_UltMod = item.Fecha_UltMod;
                        Info.IdUsuarioUltAnu = item.IdUsuarioUltAnu;
                        Info.Fecha_UltAnu = item.Fecha_UltAnu;
                        Info.MotivoAnulacion = item.MotivoAnulacion;

                        Info.cp_liquidacion_compra_det = new List<cp_liquidacion_compra_det_Info>();
                        Info.cp_liquidacion_compra_det = Data_det.Get_Detalle(Info.IdEmpresa, Info.IdLiquidacionCompra);
                    }
                }

                return Info;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.InnerException.Message);
            }
        }       
    }
}
