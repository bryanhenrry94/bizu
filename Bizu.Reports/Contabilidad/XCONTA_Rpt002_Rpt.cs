using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Collections.Generic;
using System.IO;
using Bizu.Application.General;
using Bizu.Domain.General;
using Bizu.Reports;

namespace Bizu.Reports.Contabilidad
{
    public partial class XCONTA_Rpt002_Rpt : DevExpress.XtraReports.UI.XtraReport
    {
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();

        public List<string> listIdCentroCosto { get; set; }

        public XCONTA_Rpt002_Rpt()
        {
            InitializeComponent();
        }

        private void XCONTA_Rpt002_Rpt_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {


            xrLfecha.Text = DateTime.Now.ToString();
            xlblIdReporte.Text = this.Name;

            xrPb_logo.Image = param.InfoEmpresa.em_logo_Image;
            lbl_nom_empresa.Text = param.NombreEmpresa;
            
            xlblIdReporte.Text = "XCONTA_Rpt002_Rpt";

            try
            {
                string msg = "";
                XCONTA_Rpt002_Bus Bus = new XCONTA_Rpt002_Bus();
                List<XCONTA_Rpt002_Info> lista = new List<XCONTA_Rpt002_Info>();

                int IdEmpresa = 0;
                int IdNivel_a_mostrar = 0;
                DateTime FechaIni;
                DateTime FechaFin;
                string IdCentroCosto = "";



                List<string> ListIdCentroCosto = new List<string>();

                

                int IdPunto_Cargo = 0;
                int IdPunto_Cargo_Grupo = 0;
                bool Mostrar_Reg_en_cero = false;
                bool Mostrar_CC = false;
                bool Considerar_Asiento_cierre_anual = false;

                IdEmpresa = Convert.ToInt32(PIdEmpresa.Value);
                FechaIni = Convert.ToDateTime(PFechaIni.Value).Date;
                FechaFin = Convert.ToDateTime(PFechaFin.Value).Date;
                IdNivel_a_mostrar = Convert.ToInt32(PIdNivel_a_mostrar.Value);
                IdPunto_Cargo = Convert.ToInt32(PIdPunto_Cargo.Value);
                IdPunto_Cargo_Grupo = Convert.ToInt32(PIdPunto_Cargo_Grupo.Value);
                Mostrar_Reg_en_cero = Convert.ToBoolean(PMostrar_Reg_en_cero.Value);
                Mostrar_CC = Convert.ToBoolean(P_MostrarCC.Value);
                IdCentroCosto = Convert.ToString(PIdCentroCosto.Value);
                Considerar_Asiento_cierre_anual = Convert.ToBoolean(PConsiderar_Asiento_cierre_anual.Value);

                switch (param.IdCliente_Ven_x_Default)
                {
                    case Cl_Enumeradores.eCliente_Vzen.GRAFINPRENT:
                        lista = Bus.consultar_data_RangoFecha(IdEmpresa, FechaIni.Date, FechaFin.Date, listIdCentroCosto, IdNivel_a_mostrar, IdPunto_Cargo,
                                                    IdPunto_Cargo_Grupo, Mostrar_Reg_en_cero, Mostrar_CC, Considerar_Asiento_cierre_anual, param.IdUsuario, ref msg);
                        break;

                    case Cl_Enumeradores.eCliente_Vzen.EDEHSA:
                        lista = Bus.consultar_data_RangoFecha(IdEmpresa, FechaIni, FechaFin, IdCentroCosto, IdNivel_a_mostrar, IdPunto_Cargo, IdPunto_Cargo_Grupo, Mostrar_Reg_en_cero, Mostrar_CC, Considerar_Asiento_cierre_anual, param.IdUsuario, ref msg);

                        //lbl_CentroCosto.Text = IdCentroCosto;

                        foreach (var item in listIdCentroCosto)
                        {
                            if (lbl_CentroCosto.Text == "")
                            {
                                lbl_CentroCosto.Text = item;
                            }
                            else
                            {
                                lbl_CentroCosto.Text = lbl_CentroCosto.Text + "-" + item;
                            }
                        }
                        break;

                    default:
                        lista = Bus.consultar_data(IdEmpresa, FechaIni, FechaFin, ListIdCentroCosto, IdNivel_a_mostrar, IdPunto_Cargo,
                                                    IdPunto_Cargo_Grupo, Mostrar_Reg_en_cero, Mostrar_CC, Considerar_Asiento_cierre_anual, param.IdUsuario, ref msg);
                        break;
                }
               
                if (lista.Count == 0)
                {
                    xrLmensaje.Visible = true;
                    xrLmensaje.Text = "No hay datos encontrados para estos filtros";
                }
                else
                {
                    xrLmensaje.Visible = false;
                }


                switch (param.IdCliente_Ven_x_Default)
                {
                    case Cl_Enumeradores.eCliente_Vzen.GRAFINPRENT:
                        foreach (var item in lista)
                        {
                            if (item.IdCtaCble.Length == 5 && item.Saldo > 0)
                            {
                                string idctacble = "", nom_cuenta = "";
                                idctacble = item.IdCtaCble;
                                nom_cuenta = item.nom_cuenta;

                                item.IdCtaCble = "";
                                item.nom_cuenta = "";
                                item.IdCtaCble = idctacble + " Sin CC";
                                item.nom_cuenta = nom_cuenta + "/Sin Centro de Costo";
                            }
                        }
                        break;
                }

                switch (param.IdCliente_Ven_x_Default)
                {
                    case Cl_Enumeradores.eCliente_Vzen.EDEHSA:
                        //efecto de cambio de signo para efecto visual del reporte
                        foreach (var item in lista)
                        {
                            item.Saldo = item.Saldo * -1;
                            item.Saldo_Inicial = item.Saldo_Inicial * -1;
                            item.Saldo_inicial_x_Movi = item.Saldo_inicial_x_Movi * -1;
                            item.Saldo_x_Movi = item.Saldo_x_Movi * -1;

                            if (string.IsNullOrEmpty(item.GrupoCble) != true)
                            {
                                switch (item.GrupoCble.Trim())
                                {
                                    case "INGRESOS OPERACIONALES":
                                        item.GrupoCble_Total = "RESULTADO BRUTO";
                                        break;

                                    case "GASTOS":
                                        item.GrupoCble_Total = "RESULTADO OPERACIONAL";
                                        break;

                                    case "NO OPERACIONAL":
                                        item.GrupoCble_Total = "RESULTADO NO OPERACIONAL";
                                        break;

                                    default:
                                        item.GrupoCble_Total = item.GrupoCble;
                                        break;
                                }
                            }
                        }

                        xrTableCell11.Text = "RESULTADO DEL EJERCICIO";
                        xrTableCell7.Visible = false;
                        xrTableCell8.Visible = false;

                        Titulo_x_grupo_cble.Expression = "Trim([GrupoCble_Total]) + ' :->'";                        

                        break;
                }

                lista.ForEach(q => q.pc_EsMovimiento = "S");
                
                this.DataSource = lista.ToArray();
                
                //xrTable2.Font = new Font("Verdana", 8, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            }
            catch (Exception ex)
            {

                Log_Error_bus.Log_Error(ex.ToString());
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error,                                        ex.Message);
                         throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "XCONTA_Rpt002_Rpt_BeforePrint",                                                      ex.Message),                      ex) { EntityType = typeof(XCONTA_Rpt002_Rpt) };   
            }  
        }

        Decimal resultadoBruto = 0;
        
        private void xrTableCell10_SummaryCalculated(object sender, TextFormatEventArgs e)
        {
            if (xrTableCell9.Text == "RESULTADO BRUTO :->")
                resultadoBruto = Convert.ToDecimal(e.Value);

            if (xrTableCell9.Text == "RESULTADO OPERACIONAL :->")
                e.Text = String.Format("{0:n2}", resultadoBruto + Convert.ToDecimal(e.Value));                            
        }

        private void xrTableCell10_SummaryGetResult(object sender, SummaryGetResultEventArgs e)
        {
            if (xrTableCell9.Text == "RESULTADO BRUTO :->")
                resultadoBruto += Convert.ToDecimal(e.Result);   
        }

        private void xrTableCell10_SummaryReset(object sender, EventArgs e)
        {
            //if (xrTableCell9.Text == "RESULTADO BRUTO :->")
            //resultadoBruto = 0;
        }
    }
}
