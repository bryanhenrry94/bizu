using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.CuentasxPagar;
using Core.Erp.Info.General;
using Core.Erp.Data.General;

namespace Core.Erp.Data.CuentasxPagar
{
    public class cp_TerminoPago_Data
    {
        string mensaje = "";


        public List<cp_TerminoPago_Info> Get_List_TerminoPago(int idempresa, int idterminopago)
        {
            try
            {
                EntitiesCuentasxPagar context = new EntitiesCuentasxPagar();
                List<cp_TerminoPago_Info> lst = new List<cp_TerminoPago_Info>();

                var select = from q in context.cp_TerminoPago
                             where q.IdEmpresa == idempresa
                             select q;

                cp_TerminoPago_Info _Info;

                foreach (var item in select)
                {
                    _Info = new cp_TerminoPago_Info();
                    _Info.IdEmpresa = item.IdEmpresa;
                    _Info.IdTerminoPago = item.IdTerminoPago;
                    _Info.nom_TerminoPago = item.nom_TerminoPago;
                    _Info.Dias_Vct = item.Dias_Vct;
                    _Info.Num_Coutas = item.Num_Coutas;
                    lst.Add(_Info);
                }
                return lst;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = ex.ToString();
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.ToString());
            }
        }

        public Boolean GuardarDB(cp_TerminoPago_Info _Info)
        {
            try
            {
                EntitiesCuentasxPagar context = new EntitiesCuentasxPagar();
                var address = new cp_TerminoPago();

                address.IdEmpresa = _Info.IdEmpresa;
                address.IdTerminoPago = _Info.IdTerminoPago;
                address.nom_TerminoPago = _Info.nom_TerminoPago;
                address.Dias_Vct = _Info.Dias_Vct;
                address.Num_Coutas = _Info.Num_Coutas;
                address.Estado = _Info.Estado;

                context.cp_TerminoPago.Add(address);
                context.SaveChanges();

                return true;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = ex.ToString();
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.ToString());
            }
        }

        public Boolean ModificarDB(cp_TerminoPago_Info _Info)
        {
            try
            {
                EntitiesCuentasxPagar context = new EntitiesCuentasxPagar();
                var address = context.cp_TerminoPago.FirstOrDefault(var => var.IdEmpresa == _Info.IdEmpresa && var.IdTerminoPago == _Info.IdTerminoPago);
                if (address != null)
                {

                    address.nom_TerminoPago = _Info.nom_TerminoPago;
                    address.Dias_Vct = _Info.Dias_Vct;
                    address.Num_Coutas = _Info.Num_Coutas;

                    context.SaveChanges();
                }

                return true;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = ex.ToString();
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.ToString());
            }
        }

        public Boolean AnularDB(cp_TerminoPago_Info Info)
        {
            try
            {
                using (EntitiesCuentasxPagar context = new EntitiesCuentasxPagar())
                {

                    var contact = context.cp_TerminoPago.FirstOrDefault(var => var.IdEmpresa == Info.IdEmpresa && var.IdTerminoPago == Info.IdTerminoPago
                        );

                    if (contact != null)
                    {
                        contact.Estado = "I";
                        contact.IdUsuarioUltAnu = Info.IdUsuarioUltAnu;
                        contact.Fecha_UltAnu = Info.Fecha_UltAnu;
                        contact.FechaUltMod = Info.FechaUltMod;
                        contact.MotiAnula = Info.MotiAnula;
                        context.SaveChanges();
                    }
                }

                return true;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public List<cp_TerminoPago_Info> Get_List_TerminoPago(int idempresa)
        {
            try
            {
                EntitiesCuentasxPagar context = new EntitiesCuentasxPagar();
                List<cp_TerminoPago_Info> lst = new List<cp_TerminoPago_Info>();

                var select = from q in context.cp_TerminoPago
                             where q.IdEmpresa == idempresa 
                             select q;

                cp_TerminoPago_Info _Info;

                foreach (var item in select)
                {
                    _Info = new cp_TerminoPago_Info();
                    _Info.IdEmpresa = item.IdEmpresa;
                    _Info.IdTerminoPago = item.IdTerminoPago;
                    _Info.nom_TerminoPago = item.nom_TerminoPago;
                    _Info.Dias_Vct = item.Dias_Vct;
                    _Info.Num_Coutas = item.Num_Coutas;
                    _Info.Estado = item.Estado;
                    lst.Add(_Info);
                }
                return lst;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = ex.ToString();
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.ToString());
            }
        }

        //public List<cp_TerminoPago_Info> Get_List_TerminoPago_Proveedor(int idempresa, int idproveedor)
        //{
        //    try
        //    {
        //        EntitiesCuentasxPagar context = new EntitiesCuentasxPagar();
        //        List<cp_TerminoPago_Info> lst = new List<cp_TerminoPago_Info>();

        //        var select = from q in context.cp_TerminoPago
        //                     where q.IdEmpresa == idempresa

        //                     select q;

        //        cp_TerminoPago_Info _Info;

        //        foreach (var item in select)
        //        {
        //            _Info = new cp_TerminoPago_Info();
        //            _Info.IdEmpresa = item.IdEmpresa;
        //            _Info.IdTerminoPago = item.IdTerminoPago;
        //            _Info.nom_TerminoPago = item.nom_TerminoPago;
        //            _Info.Dias_Vct = item.Dias_Vct;
        //            _Info.Num_Coutas = item.Num_Coutas;
        //            _Info.Estado = item.Estado;
        //            lst.Add(_Info);
        //        }
        //        return lst;
        //    }
        //    catch (Exception ex)
        //    {
        //        string arreglo = ToString();
        //        tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
        //        tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
        //        mensaje = ex.ToString();
        //        oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
        //        throw new Exception(ex.ToString());
        //    }
        //}
    }
}
