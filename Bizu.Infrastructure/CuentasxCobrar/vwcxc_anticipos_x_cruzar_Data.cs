using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bizu.Domain.General;
using Bizu.Infrastructure.General;
using Bizu.Domain.CuentasxCobrar;

namespace Bizu.Infrastructure.CuentasxCobrar
{
    public class vwcxc_anticipos_x_cruzar_Data
    {
        string mensaje = "";
        public List<vwcxc_anticipos_x_cruzar_Info> Get_List_anticipos_x_cruzar(vwcxc_anticipos_x_cruzar_Info info)
        {
            try
            {
                List<vwcxc_anticipos_x_cruzar_Info> lista = new List<vwcxc_anticipos_x_cruzar_Info>();
                EntitiesCuentas_x_Cobrar CXC = new EntitiesCuentas_x_Cobrar();

                var consulta = from q in CXC.vwcxc_anticipos_x_cruzar
                               where q.IdEmpresa == info.IdEmpresa && q.IdCliente == info.IdCliente
                               select q;
                foreach (var item in consulta)
                {
                    vwcxc_anticipos_x_cruzar_Info infoAntCli = new vwcxc_anticipos_x_cruzar_Info();

                    infoAntCli.IdEmpresa_Cobro = Convert.ToInt32(item.IdEmpresa_Cobro);
                    infoAntCli.IdSucursal_cobro = Convert.ToInt32(item.IdSucursal_cobro);
                    infoAntCli.IdCobro_cobro = Convert.ToInt32(item.IdCobro_cobro);
                    infoAntCli.IdEmpresa = item.IdEmpresa;
                    infoAntCli.IdAnticipo = item.IdAnticipo;
                    infoAntCli.IdSucursal = item.IdSucursal;
                    infoAntCli.IdCliente = item.IdCliente;
                    infoAntCli.Fecha = Convert.ToDateTime(item.Fecha);
                    infoAntCli.Observacion = item.Observacion;
                    infoAntCli.pe_apellido = item.pe_apellido;
                    infoAntCli.pe_nombre = item.pe_nombre;
                    infoAntCli.IdCobro_tipo = item.IdCobro_tipo;
                    infoAntCli.cr_Banco = item.cr_Banco;
                    infoAntCli.cr_NumDocumento = item.cr_NumDocumento;
                    infoAntCli.IdCaja = item.IdCaja;
                    infoAntCli.cr_TotalCobro = item.cr_TotalCobro;
                    infoAntCli.Saldo_Pendiente = Math.Round(Convert.ToDouble(item.Saldo_Pendiente), 2); ;
                    infoAntCli.SaldoAUX = Math.Round(Convert.ToDouble(item.Saldo_Pendiente), 2); ;
                    infoAntCli.IdCtaCble_cxc = item.IdCtaCble_cxc;
                    infoAntCli.IdCtaCble_Anti = item.IdCtaCble_Anti;

                    lista.Add(infoAntCli);
                }
                return lista;
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

        public List<vwcxc_anticipos_x_cruzar_Info> Get_List_anticipos_x_cruzar_Todos(vwcxc_anticipos_x_cruzar_Info info)
        {
            try
            {
                List<vwcxc_anticipos_x_cruzar_Info> lista = new List<vwcxc_anticipos_x_cruzar_Info>();
                EntitiesCuentas_x_Cobrar CXC = new EntitiesCuentas_x_Cobrar();

                var consulta = from q in CXC.vwcxc_anticipos_x_cruzar
                               where q.IdEmpresa == info.IdEmpresa

                               select q;
                foreach (var item in consulta)
                {
                    vwcxc_anticipos_x_cruzar_Info infoAntCli = new vwcxc_anticipos_x_cruzar_Info();

                    infoAntCli.IdEmpresa_Cobro = Convert.ToInt32(item.IdEmpresa_Cobro);
                    infoAntCli.IdSucursal_cobro = Convert.ToInt32(item.IdSucursal_cobro);
                    infoAntCli.IdCobro_cobro = Convert.ToInt32(item.IdCobro_cobro);
                    infoAntCli.IdEmpresa = item.IdEmpresa;
                    infoAntCli.IdAnticipo = item.IdAnticipo;
                    infoAntCli.IdSucursal = item.IdSucursal;
                    infoAntCli.IdCliente = item.IdCliente;
                    infoAntCli.Fecha = Convert.ToDateTime(item.Fecha);
                    infoAntCli.Observacion = item.Observacion;
                    infoAntCli.pe_apellido = item.pe_apellido;
                    infoAntCli.pe_nombre = item.pe_nombre;
                    infoAntCli.IdCobro_tipo = item.IdCobro_tipo;
                    infoAntCli.cr_Banco = item.cr_Banco;
                    infoAntCli.cr_NumDocumento = item.cr_NumDocumento;
                    infoAntCli.IdCaja = item.IdCaja;
                    infoAntCli.cr_TotalCobro = item.cr_TotalCobro;
                    infoAntCli.Saldo_Pendiente = Math.Round(Convert.ToDouble(item.Saldo_Pendiente), 2); ;
                    infoAntCli.SaldoAUX = Math.Round(Convert.ToDouble(item.Saldo_Pendiente), 2); ;
                    infoAntCli.IdCtaCble_cxc = item.IdCtaCble_cxc;
                    infoAntCli.IdCtaCble_Anti = item.IdCtaCble_Anti;

                    lista.Add(infoAntCli);
                }
                return lista;
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

        public List<vwcxc_anticipos_x_cruzar_Info> Get_List_anticipos_x_cruzar_Pendientes_de_Diario(vwcxc_anticipos_x_cruzar_Info info)
        {
            try
            {
                List<vwcxc_anticipos_x_cruzar_Info> lista = new List<vwcxc_anticipos_x_cruzar_Info>();
                EntitiesCuentas_x_Cobrar CXC = new EntitiesCuentas_x_Cobrar();

                if (info.IdCliente != 0)
                {
                    var consulta = from q in CXC.vwcxc_cobro_x_anticipo_pendientes_de_diario
                                   where q.IdEmpresa == info.IdEmpresa && q.IdCliente == info.IdCliente
                                   select q;
                    foreach (var item in consulta)
                    {
                        vwcxc_anticipos_x_cruzar_Info infoAntCli = new vwcxc_anticipos_x_cruzar_Info();

                        infoAntCli.IdEmpresa_Cobro = Convert.ToInt32(item.IdEmpresa);
                        infoAntCli.IdSucursal_cobro = Convert.ToInt32(item.IdSucursal);
                        infoAntCli.IdCobro_cobro = Convert.ToInt32(item.IdCobro);
                        infoAntCli.IdEmpresa = item.IdEmpresa;
                        infoAntCli.IdAnticipo = 0;
                        infoAntCli.IdSucursal = item.IdSucursal;
                        infoAntCli.IdCliente = item.IdCliente;
                        infoAntCli.Fecha = Convert.ToDateTime(item.cr_fecha);
                        infoAntCli.Observacion = "";//item.Observacion;
                        infoAntCli.pe_apellido = item.pe_apellido;
                        infoAntCli.pe_nombre = item.pe_nombre;
                        infoAntCli.IdCobro_tipo = item.IdCobro_tipo;
                        infoAntCli.cr_Banco = null;//item.cr_Banco;
                        infoAntCli.cr_NumDocumento = null;//item.cr_NumDocumento;
                        infoAntCli.IdCaja = 1;//item.IdCaja;
                        infoAntCli.cr_TotalCobro = item.cr_TotalCobro;
                        infoAntCli.Saldo_Pendiente = Math.Round(Convert.ToDouble(item.diferencia), 2); ;
                        infoAntCli.SaldoAUX = Math.Round(Convert.ToDouble(item.diferencia), 2); ;
                        infoAntCli.IdCtaCble_cxc = item.IdCtaCble_cxc;
                        infoAntCli.IdCtaCble_Anti = item.IdCtaCble_Anti;

                        lista.Add(infoAntCli);
                    }
                }
                else
                {
                    if (info.IdEmpresa != null)
                    {

                        //filtrar todos

                        var consulta = from q in CXC.vwcxc_cobro_x_anticipo_pendientes_de_diario
                                       where q.IdEmpresa == info.IdEmpresa
                                       select q;
                        foreach (var item in consulta)
                        {
                            vwcxc_anticipos_x_cruzar_Info infoAntCli = new vwcxc_anticipos_x_cruzar_Info();

                            infoAntCli.IdEmpresa_Cobro = Convert.ToInt32(item.IdEmpresa);
                            infoAntCli.IdSucursal_cobro = Convert.ToInt32(item.IdSucursal);
                            infoAntCli.IdCobro_cobro = Convert.ToInt32(item.IdCobro);
                            infoAntCli.IdEmpresa = item.IdEmpresa;
                            infoAntCli.IdAnticipo = 0;
                            infoAntCli.IdSucursal = item.IdSucursal;
                            infoAntCli.IdCliente = item.IdCliente;
                            infoAntCli.Fecha = Convert.ToDateTime(item.cr_fecha);
                            infoAntCli.Observacion = "";//item.Observacion;
                            infoAntCli.pe_apellido = item.pe_apellido;
                            infoAntCli.pe_nombre = item.pe_nombre;
                            infoAntCli.IdCobro_tipo = item.IdCobro_tipo;
                            infoAntCli.cr_Banco = null;//item.cr_Banco;
                            infoAntCli.cr_NumDocumento = null;//item.cr_NumDocumento;
                            infoAntCli.IdCaja = 1;//item.IdCaja;
                            infoAntCli.cr_TotalCobro = item.cr_TotalCobro;
                            infoAntCli.Saldo_Pendiente = Math.Round(Convert.ToDouble(item.diferencia), 2); ;
                            infoAntCli.SaldoAUX = Math.Round(Convert.ToDouble(item.diferencia), 2); ;
                            infoAntCli.IdCtaCble_cxc = item.IdCtaCble_cxc;
                            infoAntCli.IdCtaCble_Anti = item.IdCtaCble_Anti;

                            lista.Add(infoAntCli);
                        }
                    }
                }

                return lista;
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
    }
}