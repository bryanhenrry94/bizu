using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

using Bizu.Application.General;
using System.Collections.Generic;
using Bizu.Domain.General;
using System.Linq;

namespace Bizu.Reports.CuentasxPagar
{
    public partial class XCXP_Rpt017_resumen_rpt : DevExpress.XtraReports.UI.XtraReport
    {
        public int claseProv = 0;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        
        public XCXP_Rpt017_resumen_rpt()
        {
            InitializeComponent();

            this.xrL_Fecha.Text = DateTime.Now.ToString("dddd, dd' de 'MMMM' de 'yyyy HH:mm:ss");
        }

        private void XCXP_Rpt017_rpt_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {
                this.xrPictureBox1.Image = param.InfoEmpresa.em_logo_Image;
                this.lblEmpresa.Text = param.InfoEmpresa.em_nombre;
                XCXP_Rpt017_Bus rptBus = new XCXP_Rpt017_Bus();
                List<XCXP_Rpt017_Info> source = new List<XCXP_Rpt017_Info>();

                string S_FechaCorte = "";
                string S_Proveedor = "";
                string IdCentroCosto = "";

                S_FechaCorte = Convert.ToString(Parameters["S_FechaCorte"].Value);
                S_Proveedor = Convert.ToString(Parameters["S_Proveedor"].Value);
                IdCentroCosto = Convert.ToString(Parameters["IdCentroCosto"].Value);

                source = rptBus.get_Reporte_Estado_Cuenta_Proveedor_con_Dias_Vencidos(Convert.ToInt32(Parameters["IdEmpresa"].Value), Convert.ToDateTime(base.Parameters["FechaCorte"].Value), Convert.ToDecimal(base.Parameters["IdProveedorIni"].Value), Convert.ToDecimal(base.Parameters["IdProveedorFin"].Value));

                if (!string.IsNullOrEmpty(IdCentroCosto))
                    if (IdCentroCosto == "SinCentro")
                        source = source.FindAll(q => q.IdCentroCosto == null);
                    else
                        source = source.FindAll(q => q.IdCentroCosto == IdCentroCosto);

                var select_group = from T in source
                              group T by new
                              {
                                  T.IdEmpresa,
                                  T.IdProveedor,
                                  T.nom_proveedor,
                                  T.IdClaseProveedor,
                                  T.Ruc_Proveedor
                              }
                    into grouping
                              let count = grouping.Count()
                              select new
                              {
                                  grouping.Key,
                                  Total_Compra = grouping.Sum(p => p.Total_Compra),
                                  Valor_a_pagar = grouping.Sum(p => p.Valor_a_pagar),
                                  MontoAplicado = grouping.Sum(p => p.MontoAplicado),
                                  Saldo = grouping.Sum(p => p.Saldo),
                                  x_Vencer = grouping.Sum(p => p.x_Vencer),
                                  Vencido_1_30 = grouping.Sum(p => p.Vencido_1_30),
                                  Vencido_31_60 = grouping.Sum(p => p.Vencido_31_60),
                                  Vencido_61_180 = grouping.Sum(p => p.Vencido_61_180),
                                  Vencido_Mayor_181 = grouping.Sum(p => p.Vencido_Mayor_181),
                              };

                List<XCXP_Rpt017_Info> lista = new List<XCXP_Rpt017_Info>();

                foreach(var type in select_group)
                {
                    XCXP_Rpt017_Info item = new XCXP_Rpt017_Info
                    {
                        IdEmpresa = type.Key.IdEmpresa,
                        IdProveedor = type.Key.IdProveedor,
                        nom_proveedor = type.Key.nom_proveedor,
                        IdClaseProveedor = type.Key.IdClaseProveedor,
                        Ruc_Proveedor = type.Key.Ruc_Proveedor,
                        Total_Compra = type.Total_Compra,
                        Valor_a_pagar = type.Valor_a_pagar,
                        MontoAplicado = type.MontoAplicado,
                        Saldo = type.Saldo,
                        x_Vencer = type.x_Vencer,
                        Vencido_1_30 = type.Vencido_1_30,
                        Vencido_31_60 = type.Vencido_31_60,
                        Vencido_61_180 = type.Vencido_61_180,
                        Vencido_Mayor_181 = type.Vencido_Mayor_181
                    };
                    lista.Add(item);
                }

                this.DataSource = lista;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "XCXP_Rpt017_rpt_BeforePrint", ex.Message), ex) { EntityType = typeof(XCXP_Rpt017_rpt) };
            }
        }
    }
}
