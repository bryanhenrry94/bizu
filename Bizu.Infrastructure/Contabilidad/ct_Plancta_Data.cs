using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Bizu.Domain.Contabilidad;
using System.Resources;
using Bizu.Domain.General;
using Bizu.Infrastructure.General;
using System.Data.Entity.Validation;

namespace Bizu.Infrastructure.Contabilidad
{

    public class ct_Plancta_Data
    {
        public List<ct_Plancta_Info> Get_List_Plancta(int IdEmpresa, ref string MensajeError)
        {
            try
            {

                string ClaveCorta = "";

                List<ct_Plancta_Info> lM = new List<ct_Plancta_Info>();
                EntitiesDBConta OEselectPlancta = new EntitiesDBConta();
                var selectPlancta = from C in OEselectPlancta.ct_plancta
                                    join N in OEselectPlancta.ct_plancta_nivel on new { C.idempresa, C.idnivelcta } equals new { N.idempresa, N.idnivelcta }
                                    where C.idempresa == IdEmpresa
                                    select new
                                    {
                                        C.idempresa,
                                        C.idctacble,
                                        C.pc_cuenta,
                                        C.idctacblepadre,
                                        C.idcatalogo,
                                        C.pc_naturaleza,
                                        C.idnivelcta,
                                        C.idgrupocble,
                                        C.pc_estado,
                                        C.pc_esmovimiento,
                                        C.pc_es_flujo_efectivo,
                                        N.nv_numdigitos,
                                        C.pc_clave_corta,
                                        C.idtipoctacble,
                                        C.idtipo_gasto,
                                        C.idtipo_costo
                                    };

                foreach (var item in selectPlancta)
                {

                    ct_Plancta_Info _PlantaCtaInfo = new ct_Plancta_Info();
                    ct_Plancta_nivel_Info NivelO = new ct_Plancta_nivel_Info();

                    ClaveCorta = (item.pc_clave_corta == null || item.pc_clave_corta == "") ? "" : "{" + item.pc_clave_corta + "}";

                    _PlantaCtaInfo.IdEmpresa = item.idempresa;
                    _PlantaCtaInfo.IdCtaCble = item.idctacble.Trim();
                    _PlantaCtaInfo.pc_Cuenta = item.pc_cuenta.Trim();
                    _PlantaCtaInfo.pc_Cuenta2 = ClaveCorta + "[" + item.idctacble.Trim() + "] - " + item.pc_cuenta.Trim();
                    _PlantaCtaInfo.IdCtaCblePadre = (item.idctacblepadre == null) ? "" : item.idctacblepadre.Trim();
                    _PlantaCtaInfo.IdCatalogo = Convert.ToDecimal(item.idcatalogo);
                    _PlantaCtaInfo.pc_Naturaleza = item.pc_naturaleza;
                    _PlantaCtaInfo.IdNivelCta = item.idnivelcta;
                    _PlantaCtaInfo.IdGrupoCble = item.idgrupocble.Trim();
                    _PlantaCtaInfo.pc_Estado = item.pc_estado;
                    _PlantaCtaInfo.pc_EsMovimiento = item.pc_esmovimiento;
                    _PlantaCtaInfo._Plancta_nivel_Info = NivelO;
                    _PlantaCtaInfo._Plancta_nivel_Info.IdEmpresa = item.idempresa;
                    _PlantaCtaInfo._Plancta_nivel_Info.IdNivelCta = item.idnivelcta;
                    _PlantaCtaInfo.pc_es_flujo_efectivo = item.pc_es_flujo_efectivo;
                    _PlantaCtaInfo._Plancta_nivel_Info.nv_NumDigitos = item.nv_numdigitos;
                    _PlantaCtaInfo.pc_clave_corta = item.pc_clave_corta;
                    _PlantaCtaInfo.IdTipoCtaCble = item.idtipoctacble;
                    _PlantaCtaInfo.IdTipo_Gasto = item.idtipo_gasto;
                    _PlantaCtaInfo.IdTipo_Costo = item.idtipo_costo;

                    lM.Add(_PlantaCtaInfo);
                }

                return (lM);
            }

            catch (Exception ex)
            {
                MensajeError = ex.Message;
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", MensajeError, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
                MensajeError = ex.ToString();
                throw new Exception(ex.ToString());
            }
        }

        public List<ct_Plancta_Info> ProcesarDataTableCt_Plancta_Info(DataTable ds, int idempresa, ref string MensajeError)
        {
            List<ct_Plancta_Info> lista = new List<ct_Plancta_Info>();
            lista.Clear();
            string IdCtaCble_var = "";
            string msgE = "";
            try
            {
                //VALIDAR QUE TENGA MAS DE 9 COLUMNAS
                if (ds.Columns.Count >= 8)
                {
                    //RECORRE EL DATATABLE REGISTRO X REGISTRO
                    if (ds.Rows.Count > 0)
                    {
                        int c = 0;

                        foreach (DataRow row in ds.Rows)
                        {

                            ct_Plancta_Info info = new ct_Plancta_Info();
                            //RECORRE C/U DE LAS COLUMNAS
                            info.IdEmpresa = idempresa;
                            object[] arreglo = row.ItemArray;
                            c = c + 1;
                            if (c == 430)
                            {
                                c++;
                            }
                            for (int col = 0; col < ds.Columns.Count + 1; col++)
                            {
                                switch (col)
                                {
                                    case 0:
                                        info.IdCtaCble = Convert.ToString(row[col]);
                                        IdCtaCble_var = Convert.ToString(row[col]);
                                        break;
                                    case 1:
                                        info.pc_Cuenta = Convert.ToString(row[col]);
                                        info.pc_Cuenta2 = Convert.ToString(row[col]);
                                        break;
                                    case 2:
                                        info.IdCtaCblePadre = Convert.ToString(row[col]);
                                        break;
                                    case 3:
                                        info.IdNivelCta = Convert.ToInt32(row[col]);
                                        msgE = "IdNivel de Cta";
                                        break;
                                    case 4:
                                        info.pc_EsMovimiento = Convert.ToString(row[col]);
                                        break;
                                    case 5:
                                        info.IdGrupoCble = Convert.ToString(row[col]);
                                        break;
                                    case 6:
                                        info.pc_Naturaleza = Convert.ToString(row[col]);
                                        break;
                                    case 7:
                                        info.pc_Estado = Convert.ToString(row[col]);
                                        break;
                                    //case 8:
                                    //    info.pc_clave_corta = Convert.ToString(row[col]);
                                    //    break;
                                    default:
                                        break;
                                }
                            }
                            lista.Add(info);
                        }
                    }
                    else
                    {
                        MensajeError = "Por favor verifique que el archivo contenga Datos.";
                        lista = new List<ct_Plancta_Info>();
                    }

                }
                else
                {
                    MensajeError = "Por favor verifique que el archivo tenga el formato correcto.\r Son 11 columnas.";
                    lista = new List<ct_Plancta_Info>();
                }
                return lista;
            }
            catch (Exception ex)
            {
                MensajeError = "Error en" + msgE + ex.Message + IdCtaCble_var;
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", MensajeError, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
                MensajeError = ex.ToString();
                throw new Exception(ex.ToString());
            }
        }

        public List<ct_Plancta_Info> Get_List_Plan_ctaPadre(int IdEmpresa, ref string MensajeError)
        {
            try
            {
                string ClaveCorta = "";

                List<ct_Plancta_Info> lM = new List<ct_Plancta_Info>();
                EntitiesDBConta OEselectPlancta = new EntitiesDBConta();
                var selectPlancta = from C in OEselectPlancta.ct_plancta
                                    where C.idempresa == IdEmpresa && C.pc_esmovimiento == "N"
                                    select C;


                foreach (var item in selectPlancta)
                {
                    ct_Plancta_Info _PlantaCtaInfo = new ct_Plancta_Info();

                    ClaveCorta = (item.pc_clave_corta == null) ? "" : "{" + item.pc_clave_corta + "}";

                    _PlantaCtaInfo.IdCtaCble = item.idctacble.Trim();
                    _PlantaCtaInfo.pc_Cuenta = item.pc_cuenta.Trim();
                    _PlantaCtaInfo.pc_Cuenta2 = ClaveCorta + "[" + item.idctacble.Trim() + "] - " + item.pc_cuenta.Trim();
                    _PlantaCtaInfo.IdEmpresa = item.idempresa;
                    _PlantaCtaInfo.IdCtaCblePadre = (item.idctacblepadre != null) ? item.idctacblepadre.Trim() : "";
                    _PlantaCtaInfo.IdCatalogo = Convert.ToDecimal(item.idcatalogo);
                    _PlantaCtaInfo.pc_Naturaleza = item.pc_naturaleza;
                    _PlantaCtaInfo.IdNivelCta = item.idnivelcta;
                    _PlantaCtaInfo.IdGrupoCble = item.idgrupocble;
                    _PlantaCtaInfo.pc_Estado = item.pc_estado;
                    _PlantaCtaInfo.pc_EsMovimiento = item.pc_esmovimiento;
                    _PlantaCtaInfo.pc_es_flujo_efectivo = item.pc_es_flujo_efectivo;
                    _PlantaCtaInfo.pc_clave_corta = item.pc_clave_corta;
                    _PlantaCtaInfo.IdTipoCtaCble = item.idtipoctacble;
                    _PlantaCtaInfo.IdTipo_Gasto = item.idtipo_gasto;
                    _PlantaCtaInfo.IdTipo_Costo = item.idtipo_costo;
                    lM.Add(_PlantaCtaInfo);
                }

                return (lM);
            }
            catch (Exception ex)
            {
                MensajeError = ex.Message;
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", MensajeError, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
                MensajeError = ex.ToString();
                throw new Exception(ex.ToString());
            }
        }

        public List<ct_Plancta_Info> Get_List_Plancta_x_ctas_Movimiento(int IdEmpresa, ref string MensajeError, Boolean Mostrar_Todo_El_Plan_cta = false)
        {

            try
            {
                List<ct_Plancta_Info> lM = new List<ct_Plancta_Info>();

                string ClaveCorta = "";
                IQueryable<vwct_plancta> selectPlancta;

                EntitiesDBConta OEselectPlancta = new EntitiesDBConta();


                if (Mostrar_Todo_El_Plan_cta == true)
                {
                    selectPlancta = from C in OEselectPlancta.vwct_plancta
                                    where C.idempresa == IdEmpresa
                                    select C;
                }
                else
                {

                    selectPlancta = from C in OEselectPlancta.vwct_plancta
                                    where C.idempresa == IdEmpresa
                                    && C.pc_esmovimiento == "S"
                                    select C;
                }


                foreach (var item in selectPlancta)
                {
                    ct_Plancta_Info _PlantaCtaInfo = new ct_Plancta_Info();

                    ClaveCorta = (item.pc_clave_corta == null) ? "" : "{" + item.pc_clave_corta + "}";

                    _PlantaCtaInfo.IdCtaCble = item.idctacble.Trim();
                    _PlantaCtaInfo.pc_Cuenta = item.pc_cuenta.Trim();
                    _PlantaCtaInfo.pc_Cuenta2 = ClaveCorta + "[" + item.idctacble.Trim() + "] - " + item.pc_cuenta.Trim();
                    _PlantaCtaInfo.IdEmpresa = item.idempresa;
                    _PlantaCtaInfo.IdCtaCblePadre = item.idctacblepadre;
                    _PlantaCtaInfo.IdCatalogo = Convert.ToDecimal(item.idcatalogo);
                    _PlantaCtaInfo.pc_Naturaleza = item.pc_naturaleza;
                    _PlantaCtaInfo.IdNivelCta = item.idnivelcta;
                    _PlantaCtaInfo.IdGrupoCble = item.idgrupocble;
                    _PlantaCtaInfo.pc_Estado = item.pc_estado;
                    _PlantaCtaInfo.pc_EsMovimiento = item.pc_esmovimiento;
                    _PlantaCtaInfo.pc_es_flujo_efectivo = item.pc_es_flujo_efectivo;
                    _PlantaCtaInfo.pc_clave_corta = item.pc_clave_corta;
                    _PlantaCtaInfo.CuentaPadre = item.cuentapadre;
                    _PlantaCtaInfo.IdTipoCtaCble = item.idtipoctacble;
                    _PlantaCtaInfo.SEstado = (item.pc_estado == "A") ? "ACTIVO" : "*ANULADO*";
                    _PlantaCtaInfo.IdTipo_Costo = item.idtipo_costo;


                    lM.Add(_PlantaCtaInfo);
                }
                return lM;
            }
            catch (Exception ex)
            {
                MensajeError = ex.Message;
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", MensajeError, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
                MensajeError = ex.ToString();
                throw new Exception(ex.ToString());
            }

        }

        public List<ct_Plancta_Info> Get_List_Plancta(int IdEmpresa, string IdCtaIni, string IdCtaFin, ref string MensajeError)
        {
            try
            {
                string ClaveCorta = "";
                List<ct_Plancta_Info> lM = new List<ct_Plancta_Info>();
                EntitiesDBConta OEselectPlancta = new EntitiesDBConta();
                var selectPlancta = from C in OEselectPlancta.ct_plancta
                                    where C.idempresa == IdEmpresa && C.pc_esmovimiento == "S" && (C.idctacble.CompareTo(IdCtaIni.Trim()) >= 0 && C.idctacble.CompareTo(IdCtaFin.Trim()) <= 0)
                                    select C;
                foreach (var item in selectPlancta)
                {
                    ct_Plancta_Info _PlantaCtaInfo = new ct_Plancta_Info();

                    ClaveCorta = (item.pc_clave_corta == null || item.pc_clave_corta == "") ? "" : "{" + item.pc_clave_corta + "}";

                    _PlantaCtaInfo.IdCtaCble = item.idctacble;// se quito el trim
                    _PlantaCtaInfo.pc_Cuenta = item.pc_cuenta.Trim();
                    _PlantaCtaInfo.pc_Cuenta2 = ClaveCorta + "[" + item.idctacble.Trim() + "] - " + item.pc_cuenta.Trim();
                    _PlantaCtaInfo.IdEmpresa = item.idempresa;
                    _PlantaCtaInfo.IdCtaCblePadre = item.idctacblepadre;
                    _PlantaCtaInfo.IdCatalogo = Convert.ToDecimal(item.idcatalogo);
                    _PlantaCtaInfo.pc_Naturaleza = item.pc_naturaleza;
                    _PlantaCtaInfo.IdNivelCta = item.idnivelcta;
                    _PlantaCtaInfo.IdGrupoCble = item.idgrupocble;
                    _PlantaCtaInfo.pc_Estado = item.pc_estado;
                    _PlantaCtaInfo.pc_EsMovimiento = item.pc_esmovimiento;
                    _PlantaCtaInfo.pc_es_flujo_efectivo = item.pc_es_flujo_efectivo;
                    _PlantaCtaInfo.pc_clave_corta = item.pc_clave_corta;
                    _PlantaCtaInfo.IdTipoCtaCble = item.idtipoctacble;
                    _PlantaCtaInfo.IdTipo_Costo = item.idtipo_costo;

                    lM.Add(_PlantaCtaInfo);
                }
                return lM;
            }
            catch (Exception ex)
            {
                MensajeError = ex.Message;
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", MensajeError, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
                MensajeError = ex.ToString();
                throw new Exception(ex.ToString());
            }
        }

        public List<ct_Plancta_Info> Get_List_Plancta(int IdEmpresa, int IdNivel)
        {
            try
            {
                List<ct_Plancta_Info> Lista = new List<ct_Plancta_Info>();
                ct_Plancta_Info lM = new ct_Plancta_Info();
                EntitiesDBConta OEselectPlancta = new EntitiesDBConta();
                var selectPlancta = from C in OEselectPlancta.ct_plancta
                                    where C.idempresa == IdEmpresa
                                    && C.idnivelcta == IdNivel
                                    select new
                                    {
                                        C.idempresa,
                                        C.idctacble,
                                        C.pc_cuenta,
                                        C.idctacblepadre,
                                        C.idcatalogo,
                                        C.pc_naturaleza,
                                        C.idnivelcta,
                                        C.idgrupocble,
                                        C.pc_estado,
                                        C.pc_esmovimiento,
                                        C.pc_es_flujo_efectivo,
                                        C.pc_clave_corta,
                                        C.idtipoctacble,
                                        C.idtipo_gasto,
                                        C.idtipo_costo
                                    };

                foreach (var item in selectPlancta)
                {
                    lM = new ct_Plancta_Info();
                    lM.IdEmpresa = item.idempresa;
                    lM.IdCtaCble = item.idctacble.Trim();
                    lM.pc_Cuenta = item.pc_cuenta.Trim();
                    lM.IdCtaCblePadre = (item.idctacblepadre == null) ? "" : item.idctacblepadre.Trim();
                    lM.IdCatalogo = Convert.ToDecimal(item.idcatalogo);
                    lM.pc_Naturaleza = item.pc_naturaleza;
                    lM.IdNivelCta = item.idnivelcta;
                    lM.IdGrupoCble = item.idgrupocble.Trim();
                    lM.pc_Estado = item.pc_estado;
                    lM.pc_EsMovimiento = item.pc_esmovimiento;
                    lM.pc_es_flujo_efectivo = item.pc_es_flujo_efectivo;
                    lM.pc_clave_corta = item.pc_clave_corta;
                    lM.IdTipoCtaCble = item.idtipoctacble;
                    lM.IdTipo_Gasto = item.idtipo_gasto;
                    lM.IdTipo_Costo = item.idtipo_costo;

                    Lista.Add(lM);
                }

                return Lista;
            }

            catch (Exception ex)
            {
                string MensajeError = "";
                MensajeError = ex.Message;
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", MensajeError, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
                MensajeError = ex.ToString();
                throw new Exception(ex.ToString());
            }
        }

        public List<ct_Plancta_Info> Get_List_Plancta_para_asiento_cierre(int IdEmpresa, int Anio)
        {
            try
            {
                List<ct_Plancta_Info> Lista = new List<ct_Plancta_Info>();

                using (EntitiesDBConta Context = new EntitiesDBConta())
                {
                    var lst = from q in Context.spCON_saldo_cuentas_x_anio_para_cierre(IdEmpresa, Anio)
                              select q;

                    foreach (var item in lst)
                    {
                        ct_Plancta_Info info = new ct_Plancta_Info();
                        info.IdEmpresa = IdEmpresa;
                        info.IdCtaCble = item.IdCtaCble;
                        info.IdPunto_cargo = item.IdPunto_cargo;
                        info.IdPunto_cargo_grupo = item.IdPunto_cargo_grupo;
                        info.IdCentroCosto = item.IdCentroCosto;
                        info.IdCentroCosto_sub_centro_costo = item.IdCentroCosto_sub_centro_costo;
                        info.Saldo = item.dc_Valor == null ? 0 : Convert.ToDouble(item.dc_Valor);
                        Lista.Add(info);
                    }
                }

                return Lista;
            }

            catch (Exception ex)
            {
                string MensajeError = "";
                MensajeError = ex.Message;
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", MensajeError, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
                MensajeError = ex.ToString();
                throw new Exception(ex.ToString());
            }
        }

        public string Get_Id(int IdEmpresa, string codPadre, ref string MensajeError)
        {
            string idHijo = "";

            try
            {
                //declaracion de variables
                int numDigitosxPadre = 0;
                int i_nivelPadre = 0;
                int numDigitosxHijo = 0;
                int i_nivelHijo = 0;

                EntitiesDBConta OEPlanCta = new EntitiesDBConta();
                var tb = from C in OEPlanCta.ct_plancta
                         where C.idempresa == IdEmpresa && C.idctacble == codPadre
                         select new { C.idnivelcta };

                foreach (var item in tb)
                {
                    //obtengo el nivel del padre de dicha cta
                    i_nivelPadre = Convert.ToInt32(item.idnivelcta);
                }

                OEPlanCta.Dispose();
                OEPlanCta = new EntitiesDBConta();
                var tb1 = from D in OEPlanCta.ct_plancta_nivel
                          where D.idempresa == IdEmpresa && D.idnivelcta == i_nivelPadre
                          select new { D.nv_numdigitos };
                foreach (var item in tb1)
                {
                    // obtengo los numeros de digitos del padre
                    numDigitosxPadre = Convert.ToInt32(item.nv_numdigitos);
                }
                // al nivel del hijo le sumo uno
                i_nivelHijo = i_nivelPadre + 1;

                OEPlanCta.Dispose();
                OEPlanCta = new EntitiesDBConta();
                var tb2 = from E in OEPlanCta.ct_plancta_nivel
                          where E.idempresa == IdEmpresa && E.idnivelcta == i_nivelHijo
                          select new { E.nv_numdigitos };
                foreach (var item in tb2)
                {
                    //Obtengo los numeros de digitos del hijo
                    numDigitosxHijo = Convert.ToInt32(item.nv_numdigitos);
                }

                OEPlanCta.Dispose();
                OEPlanCta = new EntitiesDBConta();
                var tb3 = from F in OEPlanCta.ct_plancta
                          where F.idempresa == IdEmpresa && F.idctacblepadre == codPadre && F.idnivelcta == i_nivelHijo
                          select new { id = F.idctacble.Substring(F.idctacblepadre.Trim().Length) };

                List<int> lista = new List<int>();
                foreach (var item in tb3)
                {
                    lista.Add(Convert.ToInt32(item.id));
                }

                if (lista.Count > 0)
                {
                    //obtengo el max de los id
                    var temp = (from A in lista
                                select A).Max() + 1;
                    idHijo = temp.ToString();
                    idHijo = "000000000" + idHijo;
                }
                else
                {
                    //asigno el primer valor cuando no obtengo nada de la lista
                    idHijo = "000000001";
                }
                int value = idHijo.Length - numDigitosxHijo;
                string result = idHijo.Substring(value, numDigitosxHijo);

                return result;
            }
            catch (Exception ex)
            {
                MensajeError = ex.Message;

                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", MensajeError, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
                MensajeError = ex.ToString();
                throw new Exception(ex.ToString());
            }
        }

        public Boolean ModificarDB(ct_Plancta_Info info, ref string MensajeError)
        {
            try
            {
                using (EntitiesDBConta context = new EntitiesDBConta())
                {
                    var contact = context.ct_plancta.FirstOrDefault(minfo => minfo.idctacble == info.IdCtaCble && minfo.idempresa == info.IdEmpresa);

                    if (contact != null)
                    {
                        contact.idempresa = info.IdEmpresa;
                        contact.pc_cuenta = info.pc_Cuenta;

                        if (info.IdCtaCblePadre == "")
                        {
                            contact.idctacblepadre = null;
                        }


                        contact.idcatalogo = info.IdCatalogo;
                        contact.pc_naturaleza = info.pc_Naturaleza;
                        contact.idnivelcta = Convert.ToInt32(info.IdNivelCta);
                        contact.idgrupocble = info.IdGrupoCble;
                        contact.pc_estado = info.pc_Estado;
                        contact.pc_esmovimiento = info.pc_EsMovimiento;
                        contact.pc_es_flujo_efectivo = info.pc_es_flujo_efectivo;

                        contact.idusuarioultmod = info.IdUsuario;
                        contact.fecha_ultmod = DateTime.Now;
                        contact.idtipoctacble = info.IdTipoCtaCble;
                        contact.idtipo_gasto = info.IdTipo_Gasto;
                        contact.idtipo_costo = info.IdTipo_Costo;

                        contact.pc_clave_corta = info.pc_clave_corta;
                        context.SaveChanges();
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                MensajeError = ex.Message;
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", MensajeError, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
                MensajeError = ex.ToString();
                throw new Exception(ex.ToString());
            }
        }

        public Boolean ValidaIdCtaCble(int IdEmpresa, string IdCuenta, ref string MensajeError)
        {
            try
            {
                using (EntitiesDBConta context = new EntitiesDBConta())
                {
                    EntitiesDBConta EDB = new EntitiesDBConta();
                    var Q = from per in EDB.ct_plancta
                            where per.idempresa == IdEmpresa
                            && per.idctacble.Trim() == IdCuenta.Trim()
                            select per;

                    return (Q.ToList().Count > 0) ? true : false;
                }

            }
            catch (Exception ex)
            {
                MensajeError = ex.Message;
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", MensajeError, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
                MensajeError = ex.ToString();
                throw new Exception(ex.ToString());
            }

        }

        public Boolean GrabarDB(ct_Plancta_Info info, ref string MensajeError)
        {
            try
            {
                MensajeError = "";
                using (EntitiesDBConta context = new EntitiesDBConta())
                {
                    EntitiesDBConta EDB = new EntitiesDBConta();
                    var Q = from per in EDB.ct_plancta
                            where per.idempresa == info.IdEmpresa
                            && per.idctacble == info.IdCtaCble
                            select per;

                    if (Q.ToList().Count == 0)
                    {
                        var address = new ct_plancta();
                        address.idempresa = info.IdEmpresa;
                        address.idctacble = info.IdCtaCble;
                        address.pc_cuenta = info.pc_Cuenta;
                        address.idctacblepadre = info.IdCtaCblePadre == "" ? null : info.IdCtaCblePadre;
                        address.idcatalogo = info.IdCatalogo;
                        address.pc_naturaleza = info.pc_Naturaleza;
                        address.idnivelcta = Convert.ToByte(info.IdNivelCta);
                        address.idgrupocble = info.IdGrupoCble;
                        address.pc_estado = info.pc_Estado;
                        address.pc_esmovimiento = info.pc_EsMovimiento;
                        address.pc_es_flujo_efectivo = info.pc_es_flujo_efectivo;

                        decimal Idpc_clave_corta = 0;
                        if (info.pc_EsMovimiento == "S")
                        {
                            if (string.IsNullOrEmpty(info.pc_clave_corta))
                            {
                                Idpc_clave_corta = GetIdClave(info.IdEmpresa);
                                address.pc_clave_corta = Idpc_clave_corta.ToString();
                            }
                            else
                            {
                                address.pc_clave_corta = info.pc_clave_corta;
                            }
                        }
                        else
                            address.pc_clave_corta = "0";

                        address.idusuario = info.IdUsuario;
                        address.nom_pc = info.nom_pc;
                        address.ip = info.ip;
                        address.fecha_transac = DateTime.Now;
                        address.idusuarioultmod = info.IdUsuario;
                        address.fecha_ultmod = DateTime.Now;
                        address.idtipoctacble = info.IdTipoCtaCble;
                        address.idtipo_gasto = info.IdTipo_Gasto;
                        address.idtipo_costo = info.IdTipo_Costo;

                        context.ct_plancta.Add(address);
                        context.SaveChanges();
                    }
                    else
                    {
                        ModificarDB(info, ref MensajeError);
                    }
                }
                return true;
            }


            catch (DbEntityValidationException ex)
            {
                MensajeError = ex.Message;
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", MensajeError, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
                MensajeError = ex + " " + ex.Message;
                foreach (var item in ex.EntityValidationErrors)
                {
                    foreach (var item_validaciones in item.ValidationErrors)
                    {
                        MensajeError = "Propiedad: " + item_validaciones.PropertyName + " Mensaje: " + item_validaciones.ErrorMessage + "\n";
                    }

                }
                return false;
                //throw new Exception(ex.ToString());
            }
        }

        public Boolean EliminarDB(int IdEmpresa, ref string MensajeError)
        {
            try
            {
                using (EntitiesDBConta context = new EntitiesDBConta())
                {
                    //context.SetCommandTimeOut(6000);
                    context.Database.ExecuteSqlCommand("delete from ct_plancta where IdEmpresa = " + IdEmpresa);
                }
                return true;
            }
            catch (Exception ex)
            {
                MensajeError = ex.Message;
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", MensajeError, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
                MensajeError = ex.ToString();
                throw new Exception(ex.ToString());
            }
        }

        public Boolean AnularDB(ct_Plancta_Info info, ref string MensajeError)
        {
            try
            {
                Boolean res = false;

                using (EntitiesDBConta context = new EntitiesDBConta())
                {
                    var contact = context.ct_plancta.FirstOrDefault(minfo => minfo.idctacble == info.IdCtaCble && minfo.idempresa == info.IdEmpresa);

                    if (contact != null)
                    {
                        var padre = (from C in context.ct_plancta
                                     where C.idctacblepadre == info.IdCtaCble
                                     select C.idctacble).Count();
                        if (padre == 0)
                        {
                            contact.pc_estado = "I";
                            contact.idusuarioultanu = info.IdUsuarioUltAnu;
                            contact.fecha_ultanu = DateTime.Now;
                            contact.motivoanulacion = info.MotivoAnulacion;

                            context.SaveChanges();
                            res = true;
                        }
                        else
                        {
                            res = false;
                        }
                    }
                }
                return res;
            }
            catch (Exception ex)
            {
                MensajeError = ex.Message;
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", MensajeError, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
                MensajeError = ex.ToString();
                throw new Exception(ex.ToString());
            }
        }

        public Boolean VerificaNivel(int idnivel, int idempresa, ref string MensajeError)
        {

            try
            {
                EntitiesDBConta tabla = new EntitiesDBConta();
                var q = (from reg in tabla.ct_plancta_nivel
                         where reg.idempresa == idempresa
                         select reg.idnivelcta).Max();
                return (Convert.ToInt32(q.ToString()) == idnivel) ? true : false;
            }
            catch (Exception ex)
            {
                MensajeError = ex.Message;
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", MensajeError, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
                MensajeError = ex.ToString();
                throw new Exception(ex.ToString());
            }
        }

        public List<ct_Plancta_Info> Get_List_Plancta_x_Grupo(int IdEmpresa, string IdGrupoCble)
        {
            try
            {
                List<ct_Plancta_Info> Lista = new List<ct_Plancta_Info>();
                using (EntitiesDBConta Context = new EntitiesDBConta())
                {
                    var lst = from q in Context.ct_plancta
                              where q.idempresa == IdEmpresa
                              select q;

                    if (IdGrupoCble != "")
                    {
                        lst = lst.Where(q => q.idgrupocble == IdGrupoCble);
                    }
                    string ClaveCorta = "";
                    foreach (var item in lst)
                    {
                        ct_Plancta_Info info = new ct_Plancta_Info();
                        ClaveCorta = (item.pc_clave_corta == null || item.pc_clave_corta == "") ? "" : "{" + item.pc_clave_corta + "}";

                        info.IdEmpresa = item.idempresa;
                        info.IdCtaCble = item.idctacble.Trim();
                        info.pc_Cuenta = item.pc_cuenta.Trim();
                        info.pc_Cuenta2 = ClaveCorta + "[" + item.idctacble.Trim() + "] - " + item.pc_cuenta.Trim();
                        info.IdCtaCblePadre = (item.idctacblepadre == null) ? "" : item.idctacblepadre.Trim();
                        info.IdCatalogo = Convert.ToDecimal(item.idcatalogo);
                        info.pc_Naturaleza = item.pc_naturaleza;
                        info.IdNivelCta = item.idnivelcta;
                        info.IdGrupoCble = item.idgrupocble.Trim();
                        info.pc_Estado = item.pc_estado;
                        info.pc_EsMovimiento = item.pc_esmovimiento;
                        info.pc_clave_corta = item.pc_clave_corta;
                        info.IdTipoCtaCble = item.idtipoctacble;
                        info.IdGrupoCble = item.idgrupocble;
                        info.IdTipo_Gasto = item.idtipo_gasto;
                        info.IdTipo_Costo = item.idtipo_costo;
                        Lista.Add(info);
                    }
                }
                return Lista;
            }
            catch (Exception ex)
            {
                string MensajeError = "";
                MensajeError = ex.Message;
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", MensajeError, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
                MensajeError = ex.ToString();
                throw new Exception(ex.ToString());
            }
        }

        public ct_Plancta_Data()
        {

        }

        private decimal GetIdClave(int IdEmpresa)
        {
            decimal Id = 0;
            try
            {
                // rth 
                // validar solo numeros por expresion regular, descartar letras 13/03/2018 
                System.Text.RegularExpressions.Regex numero = new System.Text.RegularExpressions.Regex(@"^[+-]?\d+(\.\d+)?$");

                EntitiesDBConta contex = new EntitiesDBConta();
                var selecte = (from q in contex.ct_plancta
                               where q.idempresa == IdEmpresa
                               && q.pc_clave_corta != ""
                               && q.pc_clave_corta != null
                               select q.pc_clave_corta).ToList();

                var coinciden = (from v in selecte
                                 where numero.Matches(v).Count > 0
                                 select v);


                if (coinciden.ToList().Count() == 0)
                {
                    Id = 1;
                }
                else
                {
                    List<decimal> lista_decimal = new List<decimal>();
                    foreach (var item in coinciden.ToList())
                    {
                        lista_decimal.Add(Convert.ToDecimal(item));
                    }

                    Id = lista_decimal.Max() + 1;
                }

                return Id;
            }
            catch (Exception ex)
            {
                string MensajeError = "";
                MensajeError = ex.Message;
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", MensajeError, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
                MensajeError = ex.ToString();
                throw new Exception(ex.ToString());
            }
        }
    }
}