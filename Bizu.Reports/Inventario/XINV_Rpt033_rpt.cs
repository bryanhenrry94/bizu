using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using Bizu.Application.General;
using Bizu.Domain.General;
using Bizu.Reports;
using System.Collections.Generic;
using System.IO;

namespace Bizu.Reports.Inventario
{
    public partial class XINV_Rpt033_rpt : DevExpress.XtraReports.UI.XtraReport
    {
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        public List<int> List_Bodegas;
        public List<int> List_Lineas;

        public XINV_Rpt033_rpt()
        {
            InitializeComponent();
            xlbl_idReporte.Text = "XINV_Rpt033_Edehsa_rpt";
        }

        private void XINV_Rpt033_Edehsa_rpt_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {
                xrLUsuario.Text = param.IdUsuario;
                lblFechaImpresion.Text = DateTime.Now.ToString("dddd, dd' de 'MMMM' de 'yyyy HH:mm:ss");
                lblEmpresa.Text = param.NombreEmpresa;
                lblReporte.Text = "LISTADO DE INVENTARIO FISICO";

                string msg = "";
                XINV_Rpt033_Bus Bus = new XINV_Rpt033_Bus();
                List<XINV_Rpt033_Info> lista = new List<XINV_Rpt033_Info>();

                int IdEmpresa = 0;
                int IdSucursal = 0;
                string IdCategoria = "";
                int IdLinea = 0;
                decimal IdProducto = 0;
                Boolean Registro_Cero = false;
                DateTime Fecha_corte = DateTime.Now;
                IdEmpresa = Convert.ToInt32(Parameters["IdEmpresa"].Value);
                IdSucursal = Convert.ToInt32(Parameters["IdSucursal"].Value);
                //IdBodega = Convert.ToInt32(Parameters["IdBodega"].Value);
                //IdBodegaFin = Convert.ToInt32(Parameters["IdBodegaFin"].Value);
                //IdSucursalFin = Convert.ToInt32(Parameters["IdSucursalFin"].Value);
                IdCategoria = Convert.ToString(this.PIdCategoria.Value);
                IdLinea = Convert.ToInt32(this.PIdLinea.Value);
                Registro_Cero = Convert.ToBoolean(this.PRegistro_Cero.Value);
                Fecha_corte = Convert.ToDateTime(FechaFin.Value);
                IdProducto = Convert.ToDecimal(P_IdProducto.Value);

                lista = Bus.Get_data_Edehsa(IdEmpresa, IdSucursal, List_Bodegas, IdCategoria, List_Lineas, Registro_Cero, Fecha_corte, IdProducto, param.IdUsuario, ref msg);

                this.DataSource = lista.ToArray();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "XINV_Rpt033_Edehsa_rpt_BeforePrint", ex.Message), ex) { EntityType = typeof(XINV_Rpt033_rpt) };
            }
        }
    }
}
