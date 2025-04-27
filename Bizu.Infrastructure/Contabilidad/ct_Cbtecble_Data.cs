using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Bizu.Domain.Contabilidad;
using Bizu.Infrastructure.General;
using Bizu.Domain.General;
using System.Data.SqlClient;
using System.Data.Entity.Validation;

namespace Bizu.Infrastructure.Contabilidad
{
    public class ct_Cbtecble_Data
    {
        string mensaje = "";
        Boolean val = false;

        public List<ct_Cbtecble_Info> Get_list_Cbtecble(int IdEmpresa, ref string MensajeError)
        {
            try
            {

                List<ct_Cbtecble_Info> lM = new List<ct_Cbtecble_Info>();
                EntitiesDBConta OECbtecble_Info = new EntitiesDBConta();
                var selectCbtecble = from C in OECbtecble_Info.ct_cbtecble
                                     where C.idempresa == IdEmpresa
                                     select C;

                foreach (var item in selectCbtecble)
                {
                    ct_Cbtecble_Info Cbt = new ct_Cbtecble_Info();
                    Cbt.IdEmpresa = item.idempresa;
                    Cbt.IdTipoCbte = item.idtipocbte;
                    Cbt.IdCbteCble = item.idcbtecble;
                    Cbt.IdPeriodo = item.idperiodo;
                    Cbt.CodCbteCble = item.codcbtecble;
                    Cbt.cb_Fecha = Convert.ToDateTime(item.cb_fecha.ToShortDateString());
                    Cbt.cb_Valor = item.cb_valor;
                    Cbt.cb_Observacion = item.cb_observacion;
                    Cbt.Secuencia = Convert.ToDecimal(item.cb_secuencia);
                    Cbt.Estado = item.cb_estado;
                    Cbt.Anio = item.cb_anio;
                    Cbt.Mes = Convert.ToInt32(item.cb_mes);
                    Cbt.IdUsuario = item.idusuario;
                    Cbt.IdUsuarioAnu = item.idusuarioanu;
                    Cbt.cb_MotivoAnu = item.cb_motivoanu;
                    Cbt.IdUsuarioUltModi = item.idusuarioultmodi;
                    Cbt.cb_FechaAnu = Convert.ToDateTime(item.cb_fechaanu);
                    Cbt.cb_FechaTransac = Convert.ToDateTime(item.cb_fechatransac);
                    Cbt.cb_FechaUltModi = Convert.ToDateTime(item.cb_fechaultmodi);
                    Cbt.Mayorizado = item.cb_mayorizado;
                    Cbt.IdSucursal = item.idsucursal;

                    lM.Add(Cbt);
                }
                return (lM);
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString();
                throw new Exception(ex.ToString());
            }
        }

        public Boolean ReversoCbteCble(int idempresa, decimal idcbtecble, int idtipocble, int idtipocble_rev, ref decimal idcbtecble_rev,
            ref string msg, string user, string MotivoAnulacion = "", string fechaAnu = "")
        {
            try
            {
                string codigoCbte = "";

                DateTime _fechaAnu = new DateTime();
                _fechaAnu = fechaAnu == "" ? DateTime.Now : Convert.ToDateTime(fechaAnu);

                _fechaAnu = Convert.ToDateTime(_fechaAnu.ToShortDateString());


                ct_Cbtecble_Info info = new ct_Cbtecble_Info();
                ct_Cbtecble_Info info_cbtecbtes = new ct_Cbtecble_Info();
                EntitiesDBConta OEContabilidad = new EntitiesDBConta();
                var select_cbte = from A in OEContabilidad.ct_cbtecble
                                  where A.idempresa == idempresa && A.idcbtecble == idcbtecble && A.idtipocbte == idtipocble
                                  select A;

                foreach (var item in select_cbte)
                {
                    info = new ct_Cbtecble_Info();
                    info.IdEmpresa = item.idempresa;
                    info.IdTipoCbte = item.idtipocbte;
                    info.IdCbteCble = item.idcbtecble;
                    info.CodCbteCble = item.codcbtecble;
                    info.IdPeriodo = item.idperiodo;
                    info.cb_Fecha = item.cb_fecha;
                    info.cb_Valor = item.cb_valor;
                    info.cb_Observacion = item.cb_observacion;
                    info.Secuencia = item.cb_secuencia;
                    info.Estado = "I";
                    info.Anio = item.cb_anio;
                    info.Mes = item.cb_mes;
                    info.Mayorizado = item.cb_mayorizado;
                    info.cb_MotivoAnu = MotivoAnulacion;
                    info.cb_FechaAnu = _fechaAnu;
                    info.IdSucursal = item.idsucursal;

                    //empiezo a realizar una copia al nuevo comprobante
                    info_cbtecbtes = new ct_Cbtecble_Info();
                    info_cbtecbtes.IdEmpresa = item.idempresa;
                    info_cbtecbtes.IdTipoCbte = idtipocble_rev;
                    info_cbtecbtes.IdCbteCble = 0;
                    info_cbtecbtes.CodCbteCble = item.codcbtecble;
                    info_cbtecbtes.IdPeriodo = item.idperiodo;
                    info_cbtecbtes.cb_Fecha = Convert.ToDateTime(Convert.ToDateTime(info.cb_FechaAnu).ToShortDateString());

                    info_cbtecbtes.cb_Valor = item.cb_valor;
                    info_cbtecbtes.cb_Observacion =
                        "***REVERSO DEL DIARIO #: " + item.idcbtecble.ToString() +
                        ", TIPO COMPROBANTE #: " + item.idtipocbte.ToString() + " " +
                        item.cb_observacion + " ***";
                    info_cbtecbtes.Secuencia = Get_IdSecuencia(item.idempresa, ref msg);
                    info_cbtecbtes.Estado = item.cb_estado;
                    info_cbtecbtes.Anio = item.cb_anio;
                    info_cbtecbtes.Mes = item.cb_mes;
                    info_cbtecbtes.Mayorizado = "N";
                    info_cbtecbtes.IdUsuario = user;
                    info_cbtecbtes.cb_FechaTransac = Convert.ToDateTime(info.cb_FechaAnu);

                    info_cbtecbtes.IdSucursal = item.idsucursal;

                }

                OEContabilidad = new EntitiesDBConta();

                var select_cbtecble_det = from B in OEContabilidad.ct_cbtecble_det
                                          where B.idempresa == idempresa && B.idcbtecble == idcbtecble && B.idtipocbte == idtipocble
                                          select B;
                //info._cbteCble_det_lista_info(new ct_Cbtecble_det_Info());
                List<ct_Cbtecble_det_Info> lista_cbte = new List<ct_Cbtecble_det_Info>();
                List<ct_Cbtecble_det_Info> lm = new List<ct_Cbtecble_det_Info>();
                foreach (var item in select_cbtecble_det)
                {
                    ct_Cbtecble_det_Info info_det = new ct_Cbtecble_det_Info();
                    info_det.IdEmpresa = item.idempresa;
                    info_det.IdTipoCbte = item.idtipocbte;
                    info_det.IdCbteCble = item.idcbtecble;
                    info_det.IdCentroCosto_sub_centro_costo = (item.idcentrocosto_sub_centro_costo != null) ? item.idcentrocosto_sub_centro_costo.Trim() : null;
                    info_det.secuencia = item.secuencia;
                    info_det.IdCtaCble = item.idctacble.Trim();
                    info_det.IdCentroCosto = (item.idcentrocosto != null) ? item.idcentrocosto.Trim() : null;
                    info_det.dc_Valor = item.dc_valor;
                    info_det.dc_Observacion = "***REVERSADO***" + item.dc_observacion.Trim();
                    info_det.dc_Numconciliacion = item.dc_numconciliacion;
                    info_det.dc_EstaConciliado = item.dc_estaconciliado;
                    info_det.IdPunto_cargo_grupo = item.idpunto_cargo_grupo;
                    info_det.IdPunto_cargo = item.idpunto_cargo;
                    info_det.dc_para_conciliar = item.dc_para_conciliar == null ? false : Convert.ToBoolean(item.dc_para_conciliar);
                    lista_cbte.Add(info_det);
                    //

                    //procedo a copiar los detalles de los comprobantes al nuevo para proceder con el reverso
                    ct_Cbtecble_det_Info tmp = new ct_Cbtecble_det_Info();
                    tmp.IdEmpresa = item.idempresa;
                    tmp.IdTipoCbte = idtipocble_rev;
                    tmp.IdCbteCble = idcbtecble; //0;
                    tmp.IdCentroCosto_sub_centro_costo = (item.idcentrocosto_sub_centro_costo != null) ? item.idcentrocosto_sub_centro_costo.Trim() : null;
                    tmp.secuencia = item.secuencia;
                    tmp.IdCtaCble = item.idctacble.Trim();
                    tmp.IdCentroCosto = (item.idcentrocosto != null) ? item.idcentrocosto.Trim() : null;
                    tmp.dc_Valor = item.dc_valor * -1;
                    tmp.dc_Observacion = "***REVERSO***" + item.dc_observacion.Trim();
                    tmp.dc_Numconciliacion = item.dc_numconciliacion;
                    tmp.dc_EstaConciliado = item.dc_estaconciliado;
                    tmp.IdPunto_cargo_grupo = item.idpunto_cargo_grupo;
                    tmp.IdPunto_cargo = item.idpunto_cargo;
                    lm.Add(tmp);
                }

                info._cbteCble_det_lista_info = lista_cbte;
                info_cbtecbtes._cbteCble_det_lista_info = lm;
                info_cbtecbtes.CodCbteCble = "";

                if (info_cbtecbtes._cbteCble_det_lista_info.Count != 0)
                {
                    if (GrabarDB(info_cbtecbtes, ref idcbtecble_rev, ref codigoCbte, ref msg))
                    {

                        info.cb_Observacion = "**REVERSADO CON EL DIARIO : " + idcbtecble_rev + " Tipo: " + info_cbtecbtes.IdTipoCbte + "**" + info.cb_Observacion;

                        foreach (var item in info._cbteCble_det_lista_info)
                        {
                            item.dc_Observacion = "**REVERSADO CON EL DIARIO : " + idcbtecble_rev + " Tipo: " + info_cbtecbtes.IdTipoCbte + "**" + item.dc_Observacion;


                        }


                        if (ModificarDB(info, ref msg))
                        {
                            msg = "Se procedió a reversar el comprobante contable. " + msg;
                        }
                    }

                    ct_cbtecble_Reversado_Data _dataReversado = new ct_cbtecble_Reversado_Data();
                    ct_cbtecble_Reversado_Info _InfoReversado = new ct_cbtecble_Reversado_Info();

                    _InfoReversado.IdEmpresa = _InfoReversado.IdEmpresa_Anu = idempresa;
                    _InfoReversado.IdCbteCble = idcbtecble;
                    _InfoReversado.IdCbteCble_Anu = idcbtecble_rev;
                    _InfoReversado.IdTipoCbte = idtipocble;
                    _InfoReversado.IdTipoCbte_Anu = idtipocble_rev;
                    _dataReversado.GuardarDB(_InfoReversado);
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
                msg = mensaje = ex.ToString();
                throw new Exception(ex.ToString());
            }
        }

        public List<ct_Cbtecble_Info> Get_list_Cbtecble_ParaSaldoInicial(int IdEmpresa, DateTime iFechaIni, DateTime iFechaFin, ref string MensajeError)
        {
            try
            {

                iFechaIni = Convert.ToDateTime(iFechaIni.ToShortDateString());
                iFechaFin = Convert.ToDateTime(iFechaFin.ToShortDateString());

                List<ct_Cbtecble_Info> lM = new List<ct_Cbtecble_Info>();
                EntitiesDBConta OECbtecble_Info = new EntitiesDBConta();
                var selectCbtecble = from cb in OECbtecble_Info.ct_cbtecble
                                     join cbd in OECbtecble_Info.ct_cbtecble_det on
                                     new { cb.idempresa, cb.idcbtecble, cb.idtipocbte } equals new { cbd.idempresa, cbd.idcbtecble, cbd.idtipocbte }
                                     join plcta in OECbtecble_Info.ct_plancta on
                                     new { cbd.idempresa, cbd.idctacble } equals new { plcta.idempresa, plcta.idctacble }
                                     join npl in OECbtecble_Info.ct_plancta_nivel on
                                     new { plcta.idempresa, plcta.idnivelcta } equals new { npl.idempresa, npl.idnivelcta }
                                     where cb.idempresa == IdEmpresa
                                     && cb.cb_fecha >= iFechaIni && cb.cb_fecha <= iFechaFin
                                     orderby cbd.idctacble
                                     select new
                                     {
                                         cb.idempresa,
                                         cb.idcbtecble,
                                         cb.idperiodo,
                                         cb.idtipocbte,
                                         cb.cb_fecha,
                                         cb.cb_valor,
                                         cb.cb_mes,
                                         cb.cb_anio,
                                         cb.cb_estado,
                                         cb.cb_mayorizado,
                                         cb.codcbtecble,
                                         cb.cb_para_conciliar,
                                         cbd.dc_valor,
                                         cbd.idcentrocosto,
                                         cbd.idctacble,
                                         cbd.secuencia,
                                         cb.cb_observacion,
                                         cb.idsucursal,
                                         cbd.dc_observacion,
                                         plcta.idcatalogo,
                                         plcta.idctacblepadre,
                                         plcta.idgrupocble,
                                         plcta.idnivelcta,
                                         plcta.pc_cuenta,
                                         plcta.pc_esmovimiento,
                                         plcta.pc_estado,
                                         plcta.pc_naturaleza,
                                         npl.nv_numdigitos
                                     };

                foreach (var item in selectCbtecble)
                {
                    ct_Cbtecble_Info Cbt1 = new ct_Cbtecble_Info();
                    ct_Cbtecble_det_Info Cbtdt = new ct_Cbtecble_det_Info();
                    ct_Plancta_Info pli = new ct_Plancta_Info();
                    ct_Plancta_nivel_Info plNi = new ct_Plancta_nivel_Info();
                    Cbt1.IdEmpresa = item.idempresa;
                    Cbt1.IdTipoCbte = item.idtipocbte;
                    Cbt1.IdCbteCble = item.idcbtecble;
                    Cbt1.IdPeriodo = item.idperiodo;
                    Cbt1.cb_Fecha = Convert.ToDateTime(item.cb_fecha);
                    Cbt1.cb_Valor = item.cb_valor;
                    Cbt1.Estado = item.cb_estado;
                    Cbt1.Anio = item.cb_anio;
                    Cbt1.Mayorizado = item.cb_mayorizado;
                    Cbt1.cb_Observacion = item.cb_observacion;
                    Cbt1.IdSucursal = item.idsucursal;
                    Cbtdt.IdEmpresa = item.idempresa;
                    Cbtdt.dc_Observacion = item.dc_observacion;
                    Cbtdt.IdCbteCble = item.idcbtecble;
                    Cbtdt.dc_Valor = item.dc_valor;
                    Cbtdt.IdCentroCosto = item.idcentrocosto;
                    Cbtdt.IdCtaCble = item.idctacble;
                    Cbtdt.secuencia = item.secuencia;
                    pli.IdCtaCble = item.idctacble;
                    pli.IdCtaCblePadre = item.idctacblepadre;
                    pli.IdEmpresa = item.idempresa;
                    pli.IdGrupoCble = item.idgrupocble;
                    pli.IdNivelCta = item.idnivelcta;
                    pli.pc_Cuenta = item.pc_cuenta;
                    pli.pc_Cuenta2 = item.idctacble + " - " + item.pc_cuenta;
                    pli.pc_EsMovimiento = item.pc_esmovimiento;
                    pli.pc_Estado = item.pc_estado;
                    pli.pc_Naturaleza = item.pc_naturaleza;
                    plNi.IdEmpresa = item.idempresa;
                    plNi.IdNivelCta = item.idnivelcta;
                    plNi.nv_NumDigitos = item.nv_numdigitos;
                    Cbt1._cbteCble_det_info = Cbtdt;
                    Cbt1._cbteCble_det_info._Plancta_Info = pli;
                    Cbt1._cbteCble_det_info._Plancta_Info._Plancta_nivel_Info = plNi;

                    lM.Add(Cbt1);
                }
                return (lM);
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString();
                throw new Exception(ex.ToString());
            }
        }

        public List<ct_Cbtecble_Info> Get_list_Cbtecble(int IdEmpresa, DateTime iFechaIni, DateTime iFechaFin, int IdCbteCble1, string CodCbteCble1, string IdTipoCbte1, string observacion, string IdUsuario, ref string MensajeError)
        {
            try
            {

                iFechaIni = Convert.ToDateTime(iFechaIni.ToShortDateString());
                iFechaFin = Convert.ToDateTime(iFechaFin.ToShortDateString());

                List<ct_Cbtecble_Info> lM = new List<ct_Cbtecble_Info>();
                EntitiesDBConta OECbtecble_Info = new EntitiesDBConta();
                var selectCbtecble = from C in OECbtecble_Info.ct_cbtecble
                                     where C.idempresa == IdEmpresa
                                     && C.cb_fecha >= iFechaIni && C.cb_fecha <= iFechaFin
                                     select C;

                foreach (var item in selectCbtecble)
                {
                    ct_Cbtecble_Info Cbt = new ct_Cbtecble_Info();
                    Cbt.IdEmpresa = item.idempresa;
                    Cbt.IdTipoCbte = item.idtipocbte;
                    Cbt.IdCbteCble = item.idcbtecble;
                    Cbt.IdPeriodo = item.idperiodo;
                    Cbt.cb_Fecha = Convert.ToDateTime(item.cb_fecha);
                    Cbt.cb_Valor = item.cb_valor;
                    Cbt.cb_Observacion = item.cb_observacion;
                    Cbt.Secuencia = Convert.ToDecimal(item.cb_secuencia);
                    Cbt.Estado = item.cb_estado;
                    Cbt.Anio = item.cb_anio;
                    Cbt.Mes = Convert.ToInt32(item.cb_mes);
                    Cbt.IdUsuario = item.idusuario;
                    Cbt.IdUsuarioAnu = item.idusuarioanu;
                    Cbt.cb_MotivoAnu = item.cb_motivoanu;
                    Cbt.IdUsuarioUltModi = item.idusuarioultmodi;
                    Cbt.cb_FechaAnu = Convert.ToDateTime(item.cb_fechaanu);
                    Cbt.cb_FechaTransac = Convert.ToDateTime(item.cb_fechatransac);
                    Cbt.cb_FechaUltModi = Convert.ToDateTime(item.cb_fechaultmodi);
                    Cbt.Mayorizado = item.cb_mayorizado;
                    Cbt.IdSucursal = item.idsucursal;

                    lM.Add(Cbt);
                }
                return (lM);
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString();
                throw new Exception(ex.ToString());
            }
        }

        public List<ct_Cbtecble_Info> Get_list_Cbtecble(int IdEmpresa, DateTime iFechaIni, DateTime iFechaFin, decimal IdCbteCbleIni, decimal IdCbteCbleFin, string CodCbteCble, int IdTipoCbteIni, int IdTipoCbteFin, string observacion, string IdUsuario, ref string MensajeError)
        {
            try
            {
                List<ct_Cbtecble_Info> lM = new List<ct_Cbtecble_Info>();
                EntitiesDBConta OECbtecble = new EntitiesDBConta();


                iFechaIni = Convert.ToDateTime(iFechaIni.ToShortDateString());
                iFechaFin = Convert.ToDateTime(iFechaFin.ToShortDateString());


                var selectCbtecble = from cbtecble in OECbtecble.ct_cbtecble
                                     join tipocbte in OECbtecble.ct_cbtecble_tipo
                                     on new { cbtecble.idempresa, cbtecble.idtipocbte } equals new { tipocbte.idempresa, tipocbte.idtipocbte }
                                     where cbtecble.idempresa == IdEmpresa
                                     && cbtecble.cb_fecha >= iFechaIni && cbtecble.cb_fecha <= iFechaFin
                                     && cbtecble.idtipocbte >= IdTipoCbteIni && cbtecble.idtipocbte <= IdTipoCbteFin
                                     && cbtecble.idcbtecble >= IdCbteCbleIni && cbtecble.idcbtecble <= IdCbteCbleFin
                                     && cbtecble.codcbtecble.Contains(CodCbteCble) && cbtecble.cb_observacion.Contains(observacion)
                                     && cbtecble.idusuario.Contains(IdUsuario)
                                     select new
                                     {
                                         cbtecble.idempresa,
                                         cbtecble.idtipocbte,
                                         cbtecble.idcbtecble,
                                         cbtecble.idperiodo,
                                         cbtecble.codcbtecble,
                                         cbtecble.cb_fecha,
                                         cbtecble.cb_valor,
                                         cbtecble.cb_observacion,
                                         cbtecble.cb_secuencia,
                                         cbtecble.cb_estado,
                                         cbtecble.cb_anio,
                                         cbtecble.cb_mes,
                                         cbtecble.idusuario,
                                         cbtecble.idusuarioanu,
                                         cbtecble.idusuarioultmodi,
                                         cbtecble.cb_motivoanu,
                                         cbtecble.cb_fechaanu,
                                         cbtecble.cb_fechatransac,
                                         cbtecble.cb_fechaultmodi,
                                         cbtecble.cb_mayorizado,
                                         cbtecble.cb_para_conciliar,
                                         cbtecble.idsucursal,
                                         tipocbte.tc_tipocbte
                                     };

                foreach (var item in selectCbtecble)
                {
                    ct_Cbtecble_Info Cbt1 = new ct_Cbtecble_Info();
                    Cbt1.IdEmpresa = item.idempresa;
                    Cbt1.IdTipoCbte = item.idtipocbte;
                    Cbt1.IdCbteCble = item.idcbtecble;
                    Cbt1.tipoCTCB = item.tc_tipocbte;
                    Cbt1.CodCbteCble = item.codcbtecble;
                    Cbt1.IdPeriodo = item.idperiodo;
                    Cbt1.cb_Fecha = Convert.ToDateTime(item.cb_fecha);
                    Cbt1.cb_Valor = item.cb_valor;
                    Cbt1.cb_Observacion = item.cb_observacion;
                    Cbt1.Secuencia = Convert.ToDecimal(item.cb_secuencia);
                    Cbt1.Estado = item.cb_estado;
                    Cbt1.Anio = item.cb_anio;
                    Cbt1.Mes = Convert.ToInt32(item.cb_mes);
                    Cbt1.IdUsuario = item.idusuario;
                    Cbt1.IdUsuarioAnu = item.idusuarioanu;
                    Cbt1.cb_MotivoAnu = item.cb_motivoanu;
                    Cbt1.IdUsuarioUltModi = item.idusuarioultmodi;
                    Cbt1.cb_FechaAnu = Convert.ToDateTime(item.cb_fechaanu);
                    Cbt1.cb_FechaTransac = Convert.ToDateTime(item.cb_fechatransac);
                    Cbt1.cb_FechaUltModi = Convert.ToDateTime(item.cb_fechaultmodi);
                    Cbt1.Mayorizado = item.cb_mayorizado;
                    Cbt1.IdSucursal = item.idsucursal;

                    lM.Add(Cbt1);
                }
                return (lM);
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString();
                throw new Exception(ex.ToString());
            }
        }

        public decimal Get_IdCbteCble(int idempresa, int idTipoCbte, ref string MensajeError)
        {
            try
            {
                decimal IdcbteCble = 0;
                EntitiesDBConta OECbtecble = new EntitiesDBConta();


                var selecte = OECbtecble.ct_cbtecble.Count(q => q.idempresa == idempresa && q.idtipocbte == idTipoCbte);

                if (selecte == 0)
                {
                    IdcbteCble = 1;
                }
                else
                {
                    OECbtecble = new EntitiesDBConta();
                    var selectCbtecble = (from CbtCble in OECbtecble.ct_cbtecble
                                          where CbtCble.idempresa == idempresa
                                          && CbtCble.idtipocbte == idTipoCbte
                                          select CbtCble.idcbtecble).Max();
                    IdcbteCble = Convert.ToDecimal(selectCbtecble.ToString()) + 1;
                }
                return IdcbteCble;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString();
                throw new Exception(ex.ToString());
            }
        }

        public decimal Get_IdSecuencia(int IdEmpresa, ref string MensajeError)
        {
            try
            {
                decimal Idsecuencia;
                EntitiesDBConta OECbtecble = new EntitiesDBConta();


                var selecte = OECbtecble.ct_cbtecble.Count(q => q.idempresa == IdEmpresa);

                if (selecte == 0)
                {
                    Idsecuencia = 1;
                }
                else
                {
                    var selectCbtecble = (from CbtCble in OECbtecble.ct_cbtecble
                                          where CbtCble.idempresa == IdEmpresa
                                          select CbtCble.cb_secuencia).Count();
                    Idsecuencia = Convert.ToDecimal(selectCbtecble.ToString()) + 1;
                }
                return Idsecuencia;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString();
                throw new Exception(ex.ToString());
            }
        }

        public List<ct_Cbtecble_Info> Get_list_Cbtecble_Pendientes_ParaMayorizacion(int IdEmpresa, DateTime iFechaIni, DateTime iFechaFin, ref string MensajeError)
        {
            try
            {

                iFechaIni = Convert.ToDateTime(iFechaIni.ToShortDateString());
                iFechaFin = Convert.ToDateTime(iFechaFin.ToShortDateString());

                List<ct_Cbtecble_Info> lM = new List<ct_Cbtecble_Info>();
                EntitiesDBConta OECbtecble_Info = new EntitiesDBConta();
                var selectCbtecble = from cb in OECbtecble_Info.ct_cbtecble
                                     join cbd in OECbtecble_Info.ct_cbtecble_det on
                                     new { cb.idempresa, cb.idcbtecble, cb.idtipocbte } equals new { cbd.idempresa, cbd.idcbtecble, cbd.idtipocbte }
                                     join plcta in OECbtecble_Info.ct_plancta on
                                     new { cbd.idempresa, cbd.idctacble } equals new { plcta.idempresa, plcta.idctacble }
                                     join npl in OECbtecble_Info.ct_plancta_nivel on
                                     new { plcta.idempresa, plcta.idnivelcta } equals new { npl.idempresa, npl.idnivelcta }
                                     where cb.idempresa == IdEmpresa
                                     && cb.cb_fecha >= iFechaIni && cb.cb_fecha <= iFechaFin
                                     && cb.cb_mayorizado == "N"
                                     orderby cbd.idctacble
                                     select new
                                     {
                                         cb.idempresa,
                                         cb.idcbtecble,
                                         cb.idperiodo,
                                         cb.idtipocbte,
                                         cb.cb_fecha,
                                         cb.cb_valor,
                                         cb.cb_mes,
                                         cb.cb_anio,
                                         cb.cb_estado,
                                         cb.cb_mayorizado,
                                         cb.codcbtecble,
                                         cb.cb_para_conciliar,
                                         cb.idsucursal,
                                         cbd.dc_valor,
                                         cbd.idcentrocosto,
                                         cbd.idctacble,
                                         cbd.secuencia,
                                         cb.cb_observacion,
                                         cbd.dc_observacion,
                                         plcta.idcatalogo,
                                         plcta.idctacblepadre,
                                         plcta.idgrupocble,
                                         plcta.idnivelcta,
                                         plcta.pc_cuenta,
                                         plcta.pc_esmovimiento,
                                         plcta.pc_estado,
                                         plcta.pc_naturaleza,
                                         npl.nv_numdigitos
                                     };
                foreach (var item in selectCbtecble)
                {
                    ct_Cbtecble_Info Cbt1 = new ct_Cbtecble_Info();
                    ct_Cbtecble_det_Info Cbtdt = new ct_Cbtecble_det_Info();
                    ct_Plancta_Info pli = new ct_Plancta_Info();
                    ct_Plancta_nivel_Info plNi = new ct_Plancta_nivel_Info();
                    Cbt1.IdEmpresa = item.idempresa;
                    Cbt1.IdTipoCbte = item.idtipocbte;
                    Cbt1.IdCbteCble = item.idcbtecble;
                    Cbt1.IdPeriodo = item.idperiodo;
                    Cbt1.cb_Fecha = Convert.ToDateTime(item.cb_fecha);
                    Cbt1.cb_Valor = item.cb_valor;
                    Cbt1.Estado = item.cb_estado;
                    Cbt1.Anio = item.cb_anio;
                    Cbt1.Mayorizado = item.cb_mayorizado;
                    Cbt1.cb_Observacion = item.cb_observacion;
                    Cbt1.IdSucursal = item.idsucursal;
                    Cbtdt.IdEmpresa = item.idempresa;
                    Cbtdt.dc_Observacion = item.dc_observacion;
                    Cbtdt.IdCbteCble = item.idcbtecble;
                    Cbtdt.dc_Valor = item.dc_valor;
                    Cbtdt.IdCentroCosto = item.idcentrocosto;
                    Cbtdt.IdCtaCble = item.idctacble;
                    Cbtdt.secuencia = item.secuencia;
                    pli.IdCtaCble = item.idctacble;
                    pli.IdCtaCblePadre = item.idctacblepadre;
                    pli.IdEmpresa = item.idempresa;
                    pli.IdGrupoCble = item.idgrupocble;
                    pli.IdNivelCta = item.idnivelcta;
                    pli.pc_Cuenta = item.pc_cuenta;
                    pli.pc_Cuenta2 = item.idctacble + " - " + item.pc_cuenta;
                    pli.pc_EsMovimiento = item.pc_esmovimiento;
                    pli.pc_Estado = item.pc_estado;
                    pli.pc_Naturaleza = item.pc_naturaleza;
                    plNi.IdEmpresa = item.idempresa;
                    plNi.IdNivelCta = item.idnivelcta;
                    plNi.nv_NumDigitos = item.nv_numdigitos;
                    Cbt1._cbteCble_det_info = Cbtdt;
                    Cbt1._cbteCble_det_info._Plancta_Info = pli;
                    Cbt1._cbteCble_det_info._Plancta_Info._Plancta_nivel_Info = plNi;

                    lM.Add(Cbt1);
                }
                return (lM);
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString();
                throw new Exception(ex.ToString());
            }
        }

        public List<ct_Cbtecble_Info> Get_list_Cbtecble_ParaMayorizar(int IdEmpresa, DateTime iFechaIni, DateTime iFechaFin, ref string MensajeError)
        {
            try
            {

                iFechaIni = Convert.ToDateTime(iFechaIni.ToShortDateString());
                iFechaFin = Convert.ToDateTime(iFechaFin.ToShortDateString());

                List<ct_Cbtecble_Info> lM = new List<ct_Cbtecble_Info>();
                EntitiesDBConta OECbtecble_Info = new EntitiesDBConta();
                var selectCbtecble = from cb in OECbtecble_Info.ct_cbtecble
                                     join cbd in OECbtecble_Info.ct_cbtecble_det on
                                     new { cb.idempresa, cb.idcbtecble, cb.idtipocbte } equals new { cbd.idempresa, cbd.idcbtecble, cbd.idtipocbte }
                                     join plcta in OECbtecble_Info.ct_plancta on
                                     new { cbd.idempresa, cbd.idctacble } equals new { plcta.idempresa, plcta.idctacble }
                                     join npl in OECbtecble_Info.ct_plancta_nivel on
                                     new { plcta.idempresa, plcta.idnivelcta } equals new { npl.idempresa, npl.idnivelcta }
                                     where cb.idempresa == IdEmpresa
                                     && cb.cb_fecha >= iFechaIni && cb.cb_fecha <= iFechaFin
                                     orderby cbd.idctacble
                                     select new
                                     {
                                         cb.idempresa,
                                         cb.idcbtecble,
                                         cb.idperiodo,
                                         cb.idtipocbte,
                                         cb.cb_fecha,
                                         cb.cb_valor,
                                         cb.cb_mes,
                                         cb.cb_anio,
                                         cb.cb_estado,
                                         cb.cb_mayorizado,
                                         cb.codcbtecble,
                                         cb.idsucursal,
                                         cb.cb_para_conciliar,
                                         cbd.dc_valor,
                                         cbd.idcentrocosto,
                                         cbd.idctacble,
                                         cbd.secuencia,
                                         cb.cb_observacion,
                                         cbd.dc_observacion,
                                         plcta.idcatalogo,
                                         plcta.idctacblepadre,
                                         plcta.idgrupocble,
                                         plcta.idnivelcta,
                                         plcta.pc_cuenta,
                                         plcta.pc_esmovimiento,
                                         plcta.pc_estado,
                                         plcta.pc_naturaleza,
                                         npl.nv_numdigitos
                                     };
                foreach (var item in selectCbtecble)
                {
                    ct_Cbtecble_Info Cbt1 = new ct_Cbtecble_Info();
                    ct_Cbtecble_det_Info Cbtdt = new ct_Cbtecble_det_Info();
                    ct_Plancta_Info pli = new ct_Plancta_Info();
                    ct_Plancta_nivel_Info plNi = new ct_Plancta_nivel_Info();
                    Cbt1.IdEmpresa = item.idempresa;
                    Cbt1.IdTipoCbte = item.idtipocbte;
                    Cbt1.IdCbteCble = item.idcbtecble;
                    Cbt1.IdPeriodo = item.idperiodo;
                    Cbt1.cb_Fecha = Convert.ToDateTime(item.cb_fecha);
                    Cbt1.cb_Valor = item.cb_valor;
                    Cbt1.Estado = item.cb_estado;
                    Cbt1.Anio = item.cb_anio;
                    Cbt1.Mayorizado = item.cb_mayorizado;
                    Cbt1.cb_Observacion = item.cb_observacion;
                    Cbt1.IdSucursal = item.idsucursal;
                    Cbtdt.IdEmpresa = item.idempresa;
                    Cbtdt.dc_Observacion = item.dc_observacion;
                    Cbtdt.IdCbteCble = item.idcbtecble;
                    Cbtdt.dc_Valor = item.dc_valor;
                    Cbtdt.IdCentroCosto = item.idcentrocosto;
                    Cbtdt.IdCtaCble = item.idctacble;
                    Cbtdt.secuencia = item.secuencia;
                    pli.IdCtaCble = item.idctacble;
                    pli.IdCtaCblePadre = item.idctacblepadre;
                    pli.IdEmpresa = item.idempresa;
                    pli.IdGrupoCble = item.idgrupocble;
                    pli.IdNivelCta = item.idnivelcta;
                    pli.pc_Cuenta = item.pc_cuenta;
                    pli.pc_Cuenta2 = item.idctacble + " - " + item.pc_cuenta;
                    pli.pc_EsMovimiento = item.pc_esmovimiento;
                    pli.pc_Estado = item.pc_estado;
                    pli.pc_Naturaleza = item.pc_naturaleza;
                    plNi.IdEmpresa = item.idempresa;
                    plNi.IdNivelCta = item.idnivelcta;
                    plNi.nv_NumDigitos = item.nv_numdigitos;

                    Cbt1._cbteCble_det_info = Cbtdt;
                    Cbt1._cbteCble_det_info._Plancta_Info = pli;
                    Cbt1._cbteCble_det_info._Plancta_Info._Plancta_nivel_Info = plNi;

                    lM.Add(Cbt1);
                }
                return (lM);
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.InnerException.ToString());
            }
        }

        public Boolean ModificarDB(ct_Cbtecble_Info _CbteCbleInfo, ref string MensajeError)
        {
            try
            {
                List<ct_Cbtecble_det_Info> listadetalle = new List<ct_Cbtecble_det_Info>();
                listadetalle = _CbteCbleInfo._cbteCble_det_lista_info;
                using (EntitiesDBConta context = new EntitiesDBConta())
                {
                    var contact = context.ct_cbtecble.FirstOrDefault(tbCbteCble => tbCbteCble.idempresa == _CbteCbleInfo.IdEmpresa && tbCbteCble.idcbtecble == _CbteCbleInfo.IdCbteCble && tbCbteCble.idtipocbte == _CbteCbleInfo.IdTipoCbte);

                    if (contact != null)
                    {
                        contact.cb_anio = _CbteCbleInfo.cb_Fecha.Year;
                        contact.cb_estado = _CbteCbleInfo.Estado;
                        contact.idusuarioultmodi = (_CbteCbleInfo.IdUsuarioUltModi != "") ? _CbteCbleInfo.IdUsuarioUltModi : _CbteCbleInfo.IdUsuario;
                        contact.cb_fecha = _CbteCbleInfo.cb_Fecha;
                        contact.cb_fechaultmodi = Convert.ToDateTime(DateTime.Now.ToShortDateString());
                        contact.cb_mayorizado = "N";
                        contact.cb_mes = _CbteCbleInfo.cb_Fecha.Month;
                        contact.cb_observacion = _CbteCbleInfo.cb_Observacion;
                        contact.cb_secuencia = _CbteCbleInfo.Secuencia;
                        contact.cb_valor = _CbteCbleInfo.cb_Valor;
                        contact.idperiodo = _CbteCbleInfo.IdPeriodo; //BR 26-04-2018 NUEVO CAMPO A MODIFICAR POLIGRUP

                        contact.idsucursal = _CbteCbleInfo.IdSucursal;
                        context.SaveChanges();
                    }
                }

                ct_Cbtecble_det_Data _CbteCble_Det_Data = new ct_Cbtecble_det_Data();
                using (EntitiesDBConta EntCbteCbleDet = new EntitiesDBConta())
                {
                    var sql = from C in EntCbteCbleDet.ct_cbtecble_det
                              where C.idempresa == _CbteCbleInfo.IdEmpresa
                              && C.idcbtecble == _CbteCbleInfo.IdCbteCble
                              && C.idtipocbte == _CbteCbleInfo.IdTipoCbte
                              select C;
                    foreach (var item in sql)
                    {
                        ct_Cbtecble_det_Info info = new ct_Cbtecble_det_Info();
                        info.IdEmpresa = item.idempresa;
                        info.IdCbteCble = item.idcbtecble;
                        info.IdTipoCbte = item.idtipocbte;
                        info.IdCentroCosto = item.idcentrocosto;
                        info.IdCtaCble = item.idctacble.Trim();
                        info.dc_Valor = item.dc_valor;
                        info.dc_Observacion = item.dc_observacion;
                        _CbteCble_Det_Data.EliminarDB(info, ref MensajeError);
                    }
                    ct_Cbtecble_det_Data data = new ct_Cbtecble_det_Data();

                    int sec = 0;
                    foreach (var reg in listadetalle)
                    {
                        sec = sec + 1;
                        reg.secuencia = sec;
                        reg.IdCbteCble = _CbteCbleInfo.IdCbteCble;
                        reg.IdTipoCbte = _CbteCbleInfo.IdTipoCbte;


                        data.GrabarDB(reg, ref MensajeError);
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
                MensajeError = mensaje;
                throw new Exception(ex.InnerException.ToString());
            }
        }

        public Boolean Modificar_cabecera(ct_Cbtecble_Info _CbteCbleInfo)
        {
            try
            {
                using (EntitiesDBConta context = new EntitiesDBConta())
                {
                    var contact = context.ct_cbtecble.FirstOrDefault(tbCbteCble => tbCbteCble.idempresa == _CbteCbleInfo.IdEmpresa && tbCbteCble.idcbtecble == _CbteCbleInfo.IdCbteCble && tbCbteCble.idtipocbte == _CbteCbleInfo.IdTipoCbte);

                    if (contact != null)
                    {
                        contact.cb_anio = _CbteCbleInfo.cb_Fecha.Year;
                        contact.cb_estado = _CbteCbleInfo.Estado;
                        contact.idusuarioultmodi = (_CbteCbleInfo.IdUsuarioUltModi != "") ? _CbteCbleInfo.IdUsuarioUltModi : _CbteCbleInfo.IdUsuario;
                        contact.cb_fecha = _CbteCbleInfo.cb_Fecha;
                        contact.cb_fechaultmodi = Convert.ToDateTime(DateTime.Now.ToShortDateString());
                        contact.cb_mayorizado = "N";
                        contact.cb_mes = _CbteCbleInfo.cb_Fecha.Month;
                        contact.cb_observacion = _CbteCbleInfo.cb_Observacion;
                        contact.cb_secuencia = _CbteCbleInfo.Secuencia;
                        contact.cb_valor = _CbteCbleInfo.cb_Valor;
                        contact.idperiodo = _CbteCbleInfo.IdPeriodo; //BR 26-04-2018 NUEVO CAMPO A MODIFICAR POLIGRUP

                        contact.idsucursal = _CbteCbleInfo.IdSucursal;
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
                throw new Exception(ex.InnerException.ToString());
            }
        }

        public Boolean Actualizar_Observacion(ct_Cbtecble_Info _CbteCbleInfo, ref string MensajeError)
        {
            try
            {
                List<ct_Cbtecble_det_Info> listadetalle = new List<ct_Cbtecble_det_Info>();
                listadetalle = _CbteCbleInfo._cbteCble_det_lista_info;
                using (EntitiesDBConta context = new EntitiesDBConta())
                {
                    var contact = context.ct_cbtecble.FirstOrDefault(tbCbteCble => tbCbteCble.idempresa == _CbteCbleInfo.IdEmpresa && tbCbteCble.idcbtecble == _CbteCbleInfo.IdCbteCble && tbCbteCble.idtipocbte == _CbteCbleInfo.IdTipoCbte);

                    if (contact != null)
                    {
                        contact.cb_observacion = _CbteCbleInfo.cb_Observacion;
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
                MensajeError = mensaje;
                throw new Exception(ex.InnerException.ToString());
            }
        }

        public Boolean GrabarDB(ct_Cbtecble_Info _CbteCbleInfo, ref decimal IdCbteCble, ref string cod_CbteCble, ref string MensajeError)
        {
            try
            {
                try
                {
                    string codigo_CbteCble = "";

                    using (EntitiesDBConta context = new EntitiesDBConta())
                    {
                        var Q = from tbCbteCble in context.ct_cbtecble
                                where tbCbteCble.idcbtecble == _CbteCbleInfo.IdCbteCble
                                && tbCbteCble.idtipocbte == _CbteCbleInfo.IdTipoCbte
                                && tbCbteCble.idempresa == _CbteCbleInfo.IdEmpresa
                                select tbCbteCble;

                        if (Q.ToList().Count == 0)
                        {
                            var address = new ct_cbtecble();
                            address.idempresa = _CbteCbleInfo.IdEmpresa;

                            if (_CbteCbleInfo.IdCbteCble != 0)
                            {
                                address.idcbtecble = IdCbteCble = _CbteCbleInfo.IdCbteCble;
                            }
                            else
                            {
                                address.idcbtecble = IdCbteCble = _CbteCbleInfo.IdCbteCble = Get_IdCbteCble(_CbteCbleInfo.IdEmpresa, _CbteCbleInfo.IdTipoCbte, ref MensajeError);

                            }

                            address.idtipocbte = _CbteCbleInfo.IdTipoCbte;

                            codigo_CbteCble = (_CbteCbleInfo.CodCbteCble == null || _CbteCbleInfo.CodCbteCble == "") ? address.idcbtecble.ToString() : _CbteCbleInfo.CodCbteCble;

                            address.codcbtecble = codigo_CbteCble;

                            address.idperiodo = _CbteCbleInfo.IdPeriodo;
                            address.cb_fecha = Convert.ToDateTime(_CbteCbleInfo.cb_Fecha.ToShortDateString());
                            address.cb_valor = _CbteCbleInfo.cb_Valor;
                            address.cb_observacion = (_CbteCbleInfo.cb_Observacion == null) ? "" : _CbteCbleInfo.cb_Observacion;
                            address.cb_secuencia = Get_IdSecuencia(_CbteCbleInfo.IdEmpresa, ref MensajeError);
                            address.cb_estado = _CbteCbleInfo.Estado;
                            address.cb_anio = _CbteCbleInfo.cb_Fecha.Year;
                            address.cb_mes = Convert.ToByte(_CbteCbleInfo.cb_Fecha.Month);
                            address.idusuario = (_CbteCbleInfo.IdUsuario == null) ? "" : _CbteCbleInfo.IdUsuario;
                            address.idsucursal = _CbteCbleInfo.IdSucursal;
                            address.cb_fechatransac = DateTime.Now;
                            address.cb_mayorizado = _CbteCbleInfo.Mayorizado;
                            address.cb_para_conciliar = false;

                            context.ct_cbtecble.Add(address);

                            context.SaveChanges();

                            ct_Cbtecble_det_Data _CbteCble_Det_Data = new ct_Cbtecble_det_Data();
                            string obser = "";
                            int sec = 1;
                            foreach (var item in _CbteCbleInfo._cbteCble_det_lista_info)
                            {
                                obser = "";
                                item.IdEmpresa = _CbteCbleInfo.IdEmpresa;
                                item.IdCbteCble = _CbteCbleInfo.IdCbteCble;
                                item.IdTipoCbte = _CbteCbleInfo.IdTipoCbte;
                                item.dc_Observacion = item.dc_Observacion == null ? "" : item.dc_Observacion;

                                if (item.dc_Observacion.Length == 0)
                                {
                                    obser = address.cb_observacion;
                                }
                                else
                                {
                                    obser = item.dc_Observacion;
                                }
                                item.dc_Observacion = obser;
                                item.secuencia = sec;

                                sec = sec + 1;
                                _CbteCble_Det_Data.GrabarDB(item, ref MensajeError);
                            }
                        }
                        else
                            return false;
                    }
                    MensajeError = "Grabado exitosamente el Cbte#" + IdCbteCble;
                    return true;
                }
                catch (DbEntityValidationException ex)
                {
                    string mensaje = "";
                    string arreglo = ToString();
                    foreach (var item in ex.EntityValidationErrors)
                    {
                        foreach (var item_validaciones in item.ValidationErrors)
                        {
                            mensaje = "Propiedad: " + item_validaciones.PropertyName + " Mensaje: " + item_validaciones.ErrorMessage + "\n";
                        }
                    }
                    tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                    tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(mensaje, "", arreglo, "", "", "", "", "", DateTime.Now);
                    oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                    throw new Exception(mensaje);
                }
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                MensajeError = ex.InnerException + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
                throw new Exception(ex.InnerException.ToString());
            }
        }

        public Boolean EliminarDB(ct_Cbtecble_Info _CbteCbleInfo, ref string MensajeError)
        {
            try
            {
                using (EntitiesDBConta context = new EntitiesDBConta())
                {
                    context.Database.ExecuteSqlCommand("delete from ct_cbtecble_det where IdEmpresa = " + _CbteCbleInfo.IdEmpresa + " and IdCbteCble = " + _CbteCbleInfo.IdCbteCble + " and IdTipoCbte=" + _CbteCbleInfo.IdTipoCbte);
                    context.Database.ExecuteSqlCommand("delete from ct_cbtecble where IdEmpresa = " + _CbteCbleInfo.IdEmpresa + " and IdCbteCble = " + _CbteCbleInfo.IdCbteCble + " and IdTipoCbte=" + _CbteCbleInfo.IdTipoCbte);

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
                mensaje = ex.ToString();
                throw new Exception(ex.ToString());
            }
        }

        public ct_Cbtecble_Info Get_Info_CbteCble(int IdEmpresa, int IdTipoCbte, decimal IdCbteCbl, ref string MensajeError)
        {
            try
            {
                ct_Cbtecble_Info Cbt = new ct_Cbtecble_Info();

                using (EntitiesDBConta context = new EntitiesDBConta())
                {
                    var select = from var in context.ct_cbtecble
                                 where var.idempresa == IdEmpresa
                                 && var.idtipocbte == IdTipoCbte
                                 && var.idcbtecble == IdCbteCbl
                                 select var;

                    foreach (var item in select)
                    {
                        Cbt.IdEmpresa = item.idempresa;
                        Cbt.IdTipoCbte = item.idtipocbte;
                        Cbt.IdCbteCble = item.idcbtecble;
                        Cbt.IdPeriodo = item.idperiodo;
                        Cbt.CodCbteCble = item.codcbtecble;
                        Cbt.cb_Fecha = Convert.ToDateTime(item.cb_fecha.ToShortDateString());
                        Cbt.cb_Valor = item.cb_valor;
                        Cbt.cb_Valor = item.cb_valor;
                        Cbt.cb_Observacion = item.cb_observacion;
                        Cbt.Secuencia = Convert.ToDecimal(item.cb_secuencia);
                        Cbt.Estado = item.cb_estado;
                        Cbt.Anio = item.cb_anio;
                        Cbt.Mes = Convert.ToInt32(item.cb_mes);
                        Cbt.IdUsuario = item.idusuario;
                        Cbt.IdUsuarioAnu = item.idusuarioanu;
                        Cbt.cb_MotivoAnu = item.cb_motivoanu;
                        Cbt.IdUsuarioUltModi = item.idusuarioultmodi;
                        Cbt.cb_FechaAnu = Convert.ToDateTime(item.cb_fechaanu);
                        Cbt.cb_FechaTransac = Convert.ToDateTime(item.cb_fechatransac);
                        Cbt.cb_FechaUltModi = Convert.ToDateTime(item.cb_fechaultmodi);
                        Cbt.Mayorizado = item.cb_mayorizado;
                        Cbt.IdSucursal = item.idsucursal;
                    }

                }
                return Cbt;

            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString();
                throw new Exception(ex.ToString());
            }
        }

        public decimal Get_Numeros_Cbtes_no_Contabilizados(int IdEmpresa, DateTime fecha_Ini, DateTime fecha_Fin, ref string MensajeError)
        {

            try
            {
                decimal Num_cbtes;

                fecha_Ini = Convert.ToDateTime(fecha_Ini.ToShortDateString());
                fecha_Fin = Convert.ToDateTime(fecha_Fin.ToShortDateString());


                EntitiesDBConta OECbtecble = new EntitiesDBConta();

                var select = (from CbtCble in OECbtecble.ct_cbtecble
                              where CbtCble.idempresa == IdEmpresa
                              && CbtCble.cb_fecha >= fecha_Ini && CbtCble.cb_fecha <= fecha_Fin
                              && CbtCble.cb_mayorizado.ToUpper() == "N"
                              select CbtCble.cb_secuencia).Count();


                Num_cbtes = Convert.ToDecimal(select.ToString());

                return Num_cbtes;


            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString();
                throw new Exception(ex.ToString());
            }
        }

        public DateTime Get_fecha_min_cbtes_no_Mayorizado(int IdEmpresa, DateTime fecha_Ini, DateTime fecha_fin, ref string MensajeError)
        {

            try
            {

                DateTime fecha_min;


                fecha_Ini = Convert.ToDateTime(fecha_Ini.ToShortDateString());
                fecha_fin = Convert.ToDateTime(fecha_fin.ToShortDateString());


                EntitiesDBConta OECbtecble = new EntitiesDBConta();

                var select = (from CbtCble in OECbtecble.ct_cbtecble
                              where CbtCble.idempresa == IdEmpresa
                              && CbtCble.cb_fecha >= fecha_Ini && CbtCble.cb_fecha <= fecha_fin
                              && CbtCble.cb_mayorizado.ToUpper() == "N"
                              select CbtCble.cb_fecha).Min();

                fecha_min = Convert.ToDateTime(select.ToString());

                return fecha_min;


            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString();
                throw new Exception(ex.ToString());
            }
        }


        public ct_Cbtecble_Data()
        {

        }
    }
}