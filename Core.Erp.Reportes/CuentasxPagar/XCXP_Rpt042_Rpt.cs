using System;
using System.Linq;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using Core.Erp.Reportes.CuentasxPagar;
using Core.Erp.Business.General;
using Core.Erp.Info.General;
using System.Collections.Generic;

namespace Core.Erp.Reportes.CuentasxPagar
{
    public partial class XCXP_Rpt042_Rpt : DevExpress.XtraReports.UI.XtraReport
    {
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;

        public XCXP_Rpt042_Rpt()
        {
            InitializeComponent();
        }

        private void XCXP_Rpt042_Rpt_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {
                XCXP_Rpt042_Bus bus = new XCXP_Rpt042_Bus();

                List<XCXP_Rpt042_Info> List = new List<XCXP_Rpt042_Info>();

                int IdEmpresa = Convert.ToInt32(this.pIdEmpresa.Value);
                DateTime FechaIni = Convert.ToDateTime(pFechaIni.Value);
                DateTime FechaFin = Convert.ToDateTime(pFechaFin.Value);
                string Impuesto = Convert.ToString(pImpuesto.Value);
                string CodTipoDocumento = Convert.ToString(pCodTipoDocumento.Value);

                List = bus.GetData(IdEmpresa, FechaIni, FechaFin);

                // Si el valor CodTipoDocumento es diferente de vacio
                if (!string.IsNullOrEmpty(CodTipoDocumento))
                {
                    // Divide la cadena en una lista y aplica Trim a cada elemento
                    List<string> lstTipoDoc = CodTipoDocumento.Split(',')
                                                               .Select(doc => doc.Trim())
                                                               .ToList();

                    List = List.Where(q => lstTipoDoc.Contains(q.IdOrden_giro_Tipo)).ToList();
                }

                if (!string.IsNullOrEmpty(Impuesto))
                    List = List.Where(q => q.CodigoPorcentaje == Impuesto).ToList();
                
                this.DataSource = List;

                this.xrPictureBox1.Image = param.InfoEmpresa.em_logo_Image;
                this.txtFechaImpresion.Text = DateTime.Now.ToString();
                this.txtIdUsuario.Text = param.IdUsuario;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}