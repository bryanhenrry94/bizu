using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;

using DevExpress.XtraReports.UI;
using Bizu.Application.General;
using System.Collections.Generic;

using Bizu.Domain.General;
using Bizu.Application.Bancos;
using System.Linq;

namespace Bizu.Reports.Bancos
{
    public partial class XBAN_Rpt010_rpt : DevExpress.XtraReports.UI.XtraReport
    {

        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;

        public XBAN_Rpt010_rpt()
        {
            InitializeComponent();
        }

        private void XBAN_Rpt010_rpt_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {
                lblEmpresa.Text = param.NombreEmpresa;
                XBAN_Rpt010_Bus BusRpt = new XBAN_Rpt010_Bus();

                lblFecha_Impresion.Text = DateTime.Now.ToString();
                
                string MensajeError = "";


                int IdEmpresa=0;
                int IdBanco=0;

                DateTime FechaIni = DateTime.Now;
                DateTime FechaFin = DateTime.Now;

                IdEmpresa = Convert.ToInt32(this.P_IdEmpresa.Value);
                IdBanco = Convert.ToInt32(this.P_IdBanco.Value );
                FechaIni = Convert.ToDateTime(this.P_Fecha_desde.Value);
                FechaIni = Convert.ToDateTime(FechaIni.ToShortDateString());

                FechaFin = Convert.ToDateTime(this.P_Fecha_hasta.Value );
                FechaFin = Convert.ToDateTime(FechaFin.ToShortDateString());

                List<XBAN_Rpt010_Info> lista = new List<XBAN_Rpt010_Info>();
                List<String> BancosNacionales = new List<String> { "1010102001001", "1010102001002", "1010102001003", "1010102001004", "1010102001005", "10101020101", "10101020102" };
                List<String> BancosInternacionales = new List<String> { "1010102002001", "1010102002002" };
                double SumaSaldoNacional = 0;
                double SumaSaldoInternacional = 0;

                if (IdBanco == 0)//todos los bancos 
                {
                    ba_Banco_Cuenta_Bus BusBancos = new ba_Banco_Cuenta_Bus();
                    
                       foreach (var item in BusBancos.Get_list_Banco_Cuenta(IdEmpresa))
                        {
                            List<XBAN_Rpt010_Info> lista_x_cuenta = new List<XBAN_Rpt010_Info>();

                            lista_x_cuenta = BusRpt.Get_Data_Reporte(item.IdEmpresa, item.IdBanco, FechaIni, FechaFin, ref MensajeError);

                            if (lista_x_cuenta.Count > 0)
                            {
                                XBAN_Rpt010_Info Info_Rpt010 = lista_x_cuenta.Last();

                                if (BancosNacionales.Contains(Info_Rpt010.IdCtaCble))
                                {
                                    SumaSaldoNacional += Info_Rpt010.Saldo;
                                }else
                                {
                                    if (BancosInternacionales.Contains(Info_Rpt010.IdCtaCble))
                                    {
                                        SumaSaldoInternacional += Info_Rpt010.Saldo;                                
                                    }
                                }                          
                            }

                            foreach (var item_reg_x_banco in lista_x_cuenta)
                            {
                                lista.Add(item_reg_x_banco);
                            }

                        }
                }
                else
                {
                    lista = BusRpt.Get_Data_Reporte(IdEmpresa, IdBanco, FechaIni, FechaFin, ref MensajeError);

                    if (lista.Count > 0)
                    {
                        XBAN_Rpt010_Info Info_Rpt010 = lista.Last();

                        if (BancosNacionales.Contains(Info_Rpt010.IdCtaCble))
                        {
                            SumaSaldoNacional += Info_Rpt010.Saldo;
                        }
                        else
                        {
                            if (BancosInternacionales.Contains(Info_Rpt010.IdCtaCble))
                            {
                                SumaSaldoInternacional += Info_Rpt010.Saldo;
                            }
                        }
                    }
                }

                if (lista.Count > 0)
                {                                        
                    foreach (var item in lista)
                    {
                        item.SaldoNacional = SumaSaldoNacional;
                        item.SaldoInternacional = SumaSaldoInternacional;
                    }                    
                }
                
                this.DataSource = lista;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "XBAN_Rpt010_rpt_BeforePrint", ex.Message), ex) { EntityType = typeof(XBAN_Rpt010_rpt) };   
            }
           

        }

    }
}
