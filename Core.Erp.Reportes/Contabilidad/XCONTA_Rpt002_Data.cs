using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Data.General;
using Core.Erp.Info.General;

namespace Core.Erp.Reportes.Contabilidad
{
    public class XCONTA_Rpt002_Data
    {

        public List<XCONTA_Rpt002_Info> consultar_data(int IdEmpresa, DateTime FechaIni, DateTime FechaFin, List<string> ListIdCentroCosto, int IdNivel_a_mostrar
             , int IdPunto_cargo_grupo
           , int IdPunto_cargo
            ,bool Mostrar_reg_en_cero
           , bool MostrarCC,bool Considerar_Asiento_cierre_anual,string IdUsuario,  ref String MensajeError)
        {
            try
            {
                List<XCONTA_Rpt002_Info> listadedatos = new List<XCONTA_Rpt002_Info>();

                string IdCentroCosto = "";


                if (ListIdCentroCosto.Count() > 0)
                {
                    using (EntitiesContabilidadRptGeneral Estado_Resultado_FiltroCC = new EntitiesContabilidadRptGeneral())
                    {
                        Estado_Resultado_FiltroCC.Database.ExecuteSqlCommand("DELETE FROM ct_centro_costo_Filtro WHERE IdEmpresa= "+ IdEmpresa + " and IdUsuario='" + IdUsuario + "'");

                        foreach (var itemCC in ListIdCentroCosto)
                        {
                            var Address = new ct_centro_costo_Filtro();

                            Address.IdCentroCosto = itemCC;
                            Address.IdEmpresa = IdEmpresa;
                            Address.IdUsuario = IdUsuario;
                            Estado_Resultado_FiltroCC.ct_centro_costo_Filtro.Add(Address);
                            Estado_Resultado_FiltroCC.SaveChanges();
                            
                        }
                    

                    }
                }
                else
                {
                    IdCentroCosto = "";
                }
                
                using (EntitiesContabilidadRptGeneral Estado_Resultado = new EntitiesContabilidadRptGeneral())
                {
                    Estado_Resultado.SetCommandTimeOut(30000);//timeout 3 minutos

                        IList<spCON_Mayorizar_x_fecha_corte_Result> listBalance =
                        Estado_Resultado.spCON_Mayorizar_x_fecha_corte(IdEmpresa, FechaIni, FechaFin, IdCentroCosto, IdPunto_cargo_grupo, IdPunto_cargo, Mostrar_reg_en_cero, MostrarCC, Considerar_Asiento_cierre_anual, IdUsuario).ToList();

                    var Querry_x_UTILIDAD = from C in listBalance
                                     where C.CtaUtilidad==true
                                     select C;


                    var Querry_x_ER = from C in listBalance
                                      where C.gc_estado_financiero == "ER"
                                     
                                      && C.IdNivelCta <= IdNivel_a_mostrar
                                      select C;

                   foreach (var item in Querry_x_ER)
                    {
                        XCONTA_Rpt002_Info itemInfo = new XCONTA_Rpt002_Info();
                        itemInfo.IdEmpresa = item.IdEmpresa;
                        itemInfo.IdCtaCble = item.IdCtaCble;
                        itemInfo.nom_cuenta = item.nom_cuenta;
                        itemInfo.nom_cuenta2 = item.IdCtaCble + " "+ item.nom_cuenta;
                        itemInfo.IdNivelCta = item.IdNivelCta;
                        itemInfo.IdCtaCblePadre = item.IdCtaCblePadre;
                        itemInfo.GrupoCble = item.GrupoCble;
                        itemInfo.OrderGrupoCble = Convert.ToInt32(item.OrderGrupoCble);
                        itemInfo.gc_estado_financiero = item.gc_estado_financiero;


                        itemInfo.Saldo_Inicial = item.Saldo_Inicial;
                        itemInfo.Debito_Mes = item.Debito_Mes;
                        itemInfo.Credito_Mes = item.Credito_Mes;
                        itemInfo.Saldo = item.Saldo;

                        itemInfo.Saldo_inicial_x_Movi = item.Saldo_inicial_x_Movi;
                        itemInfo.Debito_Mes_x_Movi = item.Debito_Mes_x_Movi;
                        itemInfo.Credito_Mes_x_Movi = item.Credito_Mes_x_Movi;
                        itemInfo.Saldo_x_Movi = item.Saldo_x_Movi;



                        itemInfo.pc_EsMovimiento=item.pc_EsMovimiento;
                        //itemInfo.GrupoCble = item.OrderGrupoCble + " " + item.GrupoCble;
                        itemInfo.gc_signo_operacion = item.gc_signo_operacion;


                        itemInfo.IdPuntoCargo = item.IdPunto_cargo;
                        itemInfo.IdPuntoCargo_Grupo = item.IdPunto_cargo_grupo;
                        itemInfo.IdCentroCosto = item.IdCentroCosto;
                        itemInfo.nom_PuntoCargo = item.nom_punto_cargo;
                        itemInfo.nom_PuntoCargo_Grupo = item.nom_punto_cargo_grupo;
                        itemInfo.nom_CentroCosto = item.nom_centro_costo;
                        itemInfo.nom_empresa = item.nom_empresa;

                        itemInfo.IdGrupo_Mayor = item.IdGrupo_Mayor;
                        itemInfo.nom_grupo_mayor = item.nom_grupo_mayor;
                        itemInfo.order_grupo_mayor = item.order_grupo_mayor;
                        listadedatos.Add(itemInfo);

                    }




                }
                return listadedatos;
            }
            catch (Exception ex)
            {
                string mensaje = "";
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString();
                throw new Exception(ex.ToString());
            }

        }

        public List<XCONTA_Rpt002_Info> consultar_data_RangoFecha(int IdEmpresa, DateTime FechaIni, DateTime FechaFin, List<string> ListIdCentroCosto, int IdNivel_a_mostrar
             , int IdPunto_cargo_grupo
           , int IdPunto_cargo
            , bool Mostrar_reg_en_cero
           , bool MostrarCC, bool Considerar_Asiento_cierre_anual, string IdUsuario, ref String MensajeError)
        {
            try
            {
                List<XCONTA_Rpt002_Info> listadedatos = new List<XCONTA_Rpt002_Info>();

                string IdCentroCosto = "";


                if (ListIdCentroCosto.Count() > 0)
                {
                    using (EntitiesContabilidadRptGeneral Estado_Resultado_FiltroCC = new EntitiesContabilidadRptGeneral())
                    {
                        Estado_Resultado_FiltroCC.Database.ExecuteSqlCommand("delete from ct_centro_costo_Filtro where IdEmpresa={0} and IdUsuario={1}", IdEmpresa, IdUsuario);

                        foreach (var itemCC in ListIdCentroCosto)
                        {
                            var Address = new ct_centro_costo_Filtro();

                            Address.IdCentroCosto = itemCC;
                            Address.IdEmpresa = IdEmpresa;
                            Address.IdUsuario = IdUsuario;
                            Estado_Resultado_FiltroCC.ct_centro_costo_Filtro.Add(Address);
                            Estado_Resultado_FiltroCC.SaveChanges();
                        }
                    }
                }
                else
                {
                    IdCentroCosto = "";
                }


                using (EntitiesContabilidadRptGeneral Estado_Resultado = new EntitiesContabilidadRptGeneral())
                {
                    Estado_Resultado.SetCommandTimeOut(30000);//timeout 3 minutos

                    IList<spCON_Mayorizar_x_Rangofecha_Result> listBalance =
                    Estado_Resultado.spCON_Mayorizar_x_Rangofecha(IdEmpresa, FechaIni, FechaFin, 
                    IdCentroCosto, IdPunto_cargo_grupo, IdPunto_cargo, Mostrar_reg_en_cero, MostrarCC, Considerar_Asiento_cierre_anual, IdUsuario).ToList();

                    var Querry_x_UTILIDAD = from C in listBalance
                                            where C.CtaUtilidad == true
                                            select C;


                    var Querry_x_ER = from C in listBalance
                                      where C.gc_estado_financiero == "ER"

                                      && C.IdNivelCta <= IdNivel_a_mostrar
                                      select C;

                    foreach (var item in Querry_x_ER)
                    {
                        XCONTA_Rpt002_Info itemInfo = new XCONTA_Rpt002_Info();
                        itemInfo.IdEmpresa = item.IdEmpresa;
                        itemInfo.IdCtaCble = item.IdCtaCble;
                        itemInfo.nom_cuenta = item.nom_cuenta;
                        itemInfo.nom_cuenta2 = item.IdCtaCble + " " + item.nom_cuenta;
                        itemInfo.IdNivelCta = item.IdNivelCta;
                        itemInfo.IdCtaCblePadre = item.IdCtaCblePadre;
                        itemInfo.GrupoCble = item.GrupoCble;
                        itemInfo.OrderGrupoCble = Convert.ToInt32(item.OrderGrupoCble);
                        itemInfo.gc_estado_financiero = item.gc_estado_financiero;


                        itemInfo.Saldo_Inicial = item.Saldo_Inicial;
                        itemInfo.Debito_Mes = item.Debito_Mes;
                        itemInfo.Credito_Mes = item.Credito_Mes;
                        itemInfo.Saldo = item.Saldo;

                        itemInfo.Saldo_inicial_x_Movi = item.Saldo_inicial_x_Movi;
                        itemInfo.Debito_Mes_x_Movi = item.Debito_Mes_x_Movi;
                        itemInfo.Credito_Mes_x_Movi = item.Credito_Mes_x_Movi;
                        itemInfo.Saldo_x_Movi = item.Saldo_x_Movi;



                        itemInfo.pc_EsMovimiento = item.pc_EsMovimiento;
                        //itemInfo.GrupoCble = item.OrderGrupoCble + " " + item.GrupoCble;
                        itemInfo.gc_signo_operacion = item.gc_signo_operacion;


                        itemInfo.IdPuntoCargo = item.IdPunto_cargo;
                        itemInfo.IdPuntoCargo_Grupo = item.IdPunto_cargo_grupo;
                        itemInfo.IdCentroCosto = item.IdCentroCosto;
                        itemInfo.nom_PuntoCargo = item.nom_punto_cargo;
                        itemInfo.nom_PuntoCargo_Grupo = item.nom_punto_cargo_grupo;
                        itemInfo.nom_CentroCosto = item.nom_centro_costo;
                        itemInfo.nom_empresa = item.nom_empresa;

                        itemInfo.IdGrupo_Mayor = item.IdGrupo_Mayor;
                        itemInfo.nom_grupo_mayor = item.nom_grupo_mayor;
                        itemInfo.order_grupo_mayor = item.order_grupo_mayor;
                        listadedatos.Add(itemInfo);

                    }


                    /*
                    foreach (var item in Querry_x_UTILIDAD)
                    {
                        XCONTA_Rpt002_Info itemInfo = new XCONTA_Rpt002_Info();
                        itemInfo.IdEmpresa = item.IdEmpresa;
                        itemInfo.IdCtaCble = item.IdCtaCble;
                        itemInfo.nom_cuenta = item.nom_cuenta;
                        itemInfo.nom_cuenta2 = item.IdCtaCble + " " + item.nom_cuenta;
                        itemInfo.IdNivelCta = 1;
                        itemInfo.IdCtaCblePadre = item.IdCtaCblePadre;
                        itemInfo.GrupoCble = "UTILIDAD";
                        itemInfo.OrderGrupoCble = 9;
                        itemInfo.gc_estado_financiero = "ER";


                        itemInfo.Saldo_Inicial = item.Saldo_Inicial;
                        itemInfo.Debito_Mes = item.Debito_Mes;
                        itemInfo.Credito_Mes = item.Credito_Mes;
                        itemInfo.Saldo = item.Saldo;

                        itemInfo.Saldo_inicial_x_Movi = item.Saldo_inicial_x_Movi;
                        itemInfo.Debito_Mes_x_Movi = item.Debito_Mes_x_Movi;
                        itemInfo.Credito_Mes_x_Movi = item.Credito_Mes_x_Movi;
                        itemInfo.Saldo_x_Movi = item.Saldo_x_Movi;



                        itemInfo.pc_EsMovimiento = item.pc_EsMovimiento;
                        itemInfo.GrupoCble = item.OrderGrupoCble + " UTILIDAD";
                        itemInfo.gc_signo_operacion = item.gc_signo_operacion;


                        itemInfo.IdPuntoCargo = item.IdPunto_cargo;
                        itemInfo.IdPuntoCargo_Grupo = item.IdPunto_cargo_grupo;
                        itemInfo.IdCentroCosto = item.IdCentroCosto;
                        itemInfo.nom_PuntoCargo = item.nom_punto_cargo;
                        itemInfo.nom_PuntoCargo_Grupo = item.nom_punto_cargo_grupo;
                        itemInfo.nom_CentroCosto = item.nom_centro_costo;
                        itemInfo.nom_empresa = item.nom_empresa;

                        listadedatos.Add(itemInfo);

                    }*/


                }
                return listadedatos;
            }
            catch (Exception ex)
            {
                string mensaje = "";
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString();
                throw new Exception(ex.ToString());
            }

        }

        public List<XCONTA_Rpt002_Info> consultar_data_RangoFecha(int IdEmpresa, DateTime FechaIni, DateTime FechaFin, string IdCentroCosto, int IdNivel_a_mostrar
             , int IdPunto_cargo_grupo
           , int IdPunto_cargo
            , bool Mostrar_reg_en_cero
           , bool MostrarCC, bool Considerar_Asiento_cierre_anual, string IdUsuario, ref String MensajeError)
        {
            try
            {
                List<XCONTA_Rpt002_Info> listadedatos = new List<XCONTA_Rpt002_Info>();

                if (!string.IsNullOrEmpty(IdCentroCosto))
                {
                    using (EntitiesContabilidadRptGeneral Estado_Resultado_FiltroCC = new EntitiesContabilidadRptGeneral())
                    {
                        Estado_Resultado_FiltroCC.Database.ExecuteSqlCommand("DELETE FROM ct_centro_costo_Filtro where IdEmpresa="
                          + IdEmpresa + " and IdUsuario='" + IdUsuario + "'");

                        var Address = new ct_centro_costo_Filtro();

                        Address.IdCentroCosto = IdCentroCosto;
                        Address.IdEmpresa = IdEmpresa;
                        Address.IdUsuario = IdUsuario;
                        Estado_Resultado_FiltroCC.ct_centro_costo_Filtro.Add(Address);
                        Estado_Resultado_FiltroCC.SaveChanges();
                    }
                }

                using (EntitiesContabilidadRptGeneral Estado_Resultado = new EntitiesContabilidadRptGeneral())
                {
                    Estado_Resultado.SetCommandTimeOut(30000);//timeout 3 minutos

                    IList<spCON_Mayorizar_x_Rangofecha_Result> listBalance =
                    Estado_Resultado.spCON_Mayorizar_x_Rangofecha(IdEmpresa, FechaIni, FechaFin,
                    IdCentroCosto, IdPunto_cargo_grupo, IdPunto_cargo, Mostrar_reg_en_cero, MostrarCC, Considerar_Asiento_cierre_anual, IdUsuario).ToList();

                    var Querry_x_UTILIDAD = from C in listBalance
                                            where C.CtaUtilidad == true
                                            select C;


                    var Querry_x_ER = from C in listBalance
                                      where C.gc_estado_financiero == "ER"

                                      && C.IdNivelCta <= IdNivel_a_mostrar
                                      select C;

                    foreach (var item in Querry_x_ER)
                    {
                        XCONTA_Rpt002_Info itemInfo = new XCONTA_Rpt002_Info();
                        itemInfo.IdEmpresa = item.IdEmpresa;
                        itemInfo.IdCtaCble = item.IdCtaCble;
                        itemInfo.nom_cuenta = item.nom_cuenta;
                        itemInfo.nom_cuenta2 = item.IdCtaCble + " " + item.nom_cuenta;
                        itemInfo.IdNivelCta = item.IdNivelCta;
                        itemInfo.IdCtaCblePadre = item.IdCtaCblePadre;
                        itemInfo.GrupoCble = item.GrupoCble;
                        itemInfo.OrderGrupoCble = Convert.ToInt32(item.OrderGrupoCble);
                        itemInfo.gc_estado_financiero = item.gc_estado_financiero;


                        itemInfo.Saldo_Inicial = item.Saldo_Inicial;
                        itemInfo.Debito_Mes = item.Debito_Mes;
                        itemInfo.Credito_Mes = item.Credito_Mes;
                        itemInfo.Saldo = item.Saldo;

                        itemInfo.Saldo_inicial_x_Movi = item.Saldo_inicial_x_Movi;
                        itemInfo.Debito_Mes_x_Movi = item.Debito_Mes_x_Movi;
                        itemInfo.Credito_Mes_x_Movi = item.Credito_Mes_x_Movi;
                        itemInfo.Saldo_x_Movi = item.Saldo_x_Movi;



                        itemInfo.pc_EsMovimiento = item.pc_EsMovimiento;
                        //itemInfo.GrupoCble = item.OrderGrupoCble + " " + item.GrupoCble;
                        itemInfo.gc_signo_operacion = item.gc_signo_operacion;


                        itemInfo.IdPuntoCargo = item.IdPunto_cargo;
                        itemInfo.IdPuntoCargo_Grupo = item.IdPunto_cargo_grupo;
                        itemInfo.IdCentroCosto = item.IdCentroCosto;
                        itemInfo.nom_PuntoCargo = item.nom_punto_cargo;
                        itemInfo.nom_PuntoCargo_Grupo = item.nom_punto_cargo_grupo;
                        itemInfo.nom_CentroCosto = item.nom_centro_costo;
                        itemInfo.nom_empresa = item.nom_empresa;

                        itemInfo.IdGrupo_Mayor = item.IdGrupo_Mayor;
                        itemInfo.nom_grupo_mayor = item.nom_grupo_mayor;
                        itemInfo.order_grupo_mayor = item.order_grupo_mayor;
                        listadedatos.Add(itemInfo);

                    }


                    /*
                    foreach (var item in Querry_x_UTILIDAD)
                    {
                        XCONTA_Rpt002_Info itemInfo = new XCONTA_Rpt002_Info();
                        itemInfo.IdEmpresa = item.IdEmpresa;
                        itemInfo.IdCtaCble = item.IdCtaCble;
                        itemInfo.nom_cuenta = item.nom_cuenta;
                        itemInfo.nom_cuenta2 = item.IdCtaCble + " " + item.nom_cuenta;
                        itemInfo.IdNivelCta = 1;
                        itemInfo.IdCtaCblePadre = item.IdCtaCblePadre;
                        itemInfo.GrupoCble = "UTILIDAD";
                        itemInfo.OrderGrupoCble = 9;
                        itemInfo.gc_estado_financiero = "ER";


                        itemInfo.Saldo_Inicial = item.Saldo_Inicial;
                        itemInfo.Debito_Mes = item.Debito_Mes;
                        itemInfo.Credito_Mes = item.Credito_Mes;
                        itemInfo.Saldo = item.Saldo;

                        itemInfo.Saldo_inicial_x_Movi = item.Saldo_inicial_x_Movi;
                        itemInfo.Debito_Mes_x_Movi = item.Debito_Mes_x_Movi;
                        itemInfo.Credito_Mes_x_Movi = item.Credito_Mes_x_Movi;
                        itemInfo.Saldo_x_Movi = item.Saldo_x_Movi;



                        itemInfo.pc_EsMovimiento = item.pc_EsMovimiento;
                        itemInfo.GrupoCble = item.OrderGrupoCble + " UTILIDAD";
                        itemInfo.gc_signo_operacion = item.gc_signo_operacion;


                        itemInfo.IdPuntoCargo = item.IdPunto_cargo;
                        itemInfo.IdPuntoCargo_Grupo = item.IdPunto_cargo_grupo;
                        itemInfo.IdCentroCosto = item.IdCentroCosto;
                        itemInfo.nom_PuntoCargo = item.nom_punto_cargo;
                        itemInfo.nom_PuntoCargo_Grupo = item.nom_punto_cargo_grupo;
                        itemInfo.nom_CentroCosto = item.nom_centro_costo;
                        itemInfo.nom_empresa = item.nom_empresa;

                        listadedatos.Add(itemInfo);

                    }*/


                }
                return listadedatos;
            }
            catch (Exception ex)
            {
                string mensaje = "";
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString();
                throw new Exception(ex.ToString());
            }

        }                           
    }
}
