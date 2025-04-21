using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Business.CuentasxCobrar;
using Core.Erp.Info.CuentasxCobrar;
using Core.Erp.Business.General;
using Core.Erp.Info.General;
using Core.Erp.Winform.General;
using Core.Erp.Business.SeguridadAcceso;
using Core.Erp.Info.SeguridadAcceso;
using Core.Erp.Business.Contabilidad;
using Core.Erp.Info.Contabilidad;

namespace Core.Erp.Winform.CuentasxCobrar
{
    public partial class Auditoria_de_cartera_de_clientes_por_diario_contable_Cons : DevExpress.XtraEditors.XtraForm
    {
        seg_Menu_bus Busseg = new seg_Menu_bus();
        List<ct_Plancta_Info> lista_planCta = new List<ct_Plancta_Info>();
        ct_Plancta_Bus plan_bus = new ct_Plancta_Bus();
        
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        frmCxc_anticipo_clientes_Mant mant = new frmCxc_anticipo_clientes_Mant();
      
        string mensaje = "";
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();

        public Auditoria_de_cartera_de_clientes_por_diario_contable_Cons()
        {
            try
            {
                InitializeComponent();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void Auditoria_de_cartera_de_clientes_por_diario_contable_Cons_Load(object sender, EventArgs e)
        {
            try
            {
                dtpFechaDesde.Value = DateTime.Now.AddMonths(-1);
                dtpFechaHasta.Value = DateTime.Now.AddMonths(1);

                dtpFechaDesde2.Value = DateTime.Now.AddMonths(-1);
                dtpFechaHasta2.Value = DateTime.Now.AddMonths(1);

                dtpFechaDesdeCobro1.Value = DateTime.Now.AddMonths(-1);
                dtpFechaHastaCobro1.Value = DateTime.Now.AddMonths(1);

                dtpFechaDesdeCobro2.Value = DateTime.Now.AddMonths(-1);
                dtpFechaHastaCobro2.Value = DateTime.Now.AddMonths(1);


                string MensajeError = "";

                gridConSinDiarioDetalle.Visible = false;
                gridConSinDiario.Visible = true;

                gridCobro1.Visible = false;
                gridCobro2.Visible = true;



                lista_planCta = plan_bus.Get_List_Plancta_x_ctas_Movimiento(param.IdEmpresa, ref MensajeError);

                cmb_cuentas_inicio.Properties.DataSource = lista_planCta;

                cmb_cuentas_inicioCobro1.Properties.DataSource = lista_planCta;
                cmb_cuentas_inicioCobro2.Properties.DataSource = lista_planCta;
                cmb_cuentas_inicioCobro1.EditValue = "10102050201";
                cmb_cuentas_inicioCobro2.EditValue = "10102050201";
            }
            catch (Exception ex)
            {                
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }            
        }

        private void gridViewAnticipo_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                //info = new cxc_cobro_x_Anticipo_Info();
                //info = (cxc_cobro_x_Anticipo_Info)gridViewAnticipo.GetFocusedRow();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gridViewAnticipo_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            try
            {
                var data = gridViewAnticipo.GetRow(e.RowHandle) as cxc_cobro_x_Anticipo_Info;
                if (data == null)
                    return;
                if (data.Estado == "I")
                    e.Appearance.ForeColor = Color.Red;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void mnu_Modificar_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            gridConSinDiario.Visible = true;
            gridConSinDiarioDetalle.Visible = false;
            cxc_auditoria_de_diario_contable_cobranza_Bus auditoriaBus = new cxc_auditoria_de_diario_contable_cobranza_Bus();
            List<cxc_Factura_sin_diario_Info> Factura_consin_diarioList = new List<cxc_Factura_sin_diario_Info>();

            Factura_consin_diarioList = auditoriaBus.Get_List_Facturas_ConSin_Diario(param.IdEmpresa, Convert.ToInt32(ucIn_Sucursal_Bodega1.cmb_sucursal.EditValue), dtpFechaDesde.Value.Date, dtpFechaHasta.Value.Date);

            gridConSinDiario.DataSource = Factura_consin_diarioList;
        }

        private void btnImprimirFactConSinDiario_Click(object sender, EventArgs e)
        {
            gridConSinDiario.ShowPrintPreview();
        }

        private void btnConsultarFactConSinDiarioDetalle_Click(object sender, EventArgs e)
        {
            gridConSinDiario.Visible = false;
            gridConSinDiarioDetalle.Visible = true;
            cxc_auditoria_de_diario_contable_cobranza_Bus auditoriaBus = new cxc_auditoria_de_diario_contable_cobranza_Bus();
            List<cxc_Factura_detalle_por_cuenta_contable_Info> Factura_consin_diario_DetalleList = new List<cxc_Factura_detalle_por_cuenta_contable_Info>();

            Factura_consin_diario_DetalleList = auditoriaBus.Get_List_Facturas_ConSin_Diario_Detalle(param.IdEmpresa, Convert.ToInt32(ucIn_Sucursal_Bodega2.cmb_sucursal.EditValue), Convert.ToString(cmb_cuentas_inicio.EditValue), dtpFechaDesde2.Value.Date, dtpFechaHasta2.Value.Date);

            gridConSinDiarioDetalle.DataSource = Factura_consin_diario_DetalleList;
        }

        private void btnImprimirFactConSinDiarioDetalle_Click(object sender, EventArgs e)
        {
            gridConSinDiarioDetalle.Show();
        }

        private void btnConsultarCobro1_Click(object sender, EventArgs e)
        {
            gridCobro1.Visible = true;
            gridCobro2.Visible = false;
            cxc_auditoria_de_diario_contable_cobranza_Bus auditoriaBus = new cxc_auditoria_de_diario_contable_cobranza_Bus();
            List<spCXC_cobrosConSin_Diario_Info> Cobro_consin_diarioList = new List<spCXC_cobrosConSin_Diario_Info>();

            //Cobro_consin_diarioList = auditoriaBus.Get_List_Cobros_ConSin_Diario(param.IdEmpresa, Convert.ToInt32(ucIn_Sucursal_Bodega3.cmb_sucursal.EditValue), Convert.ToString(cmb_cuentas_inicioCobro1.EditValue), dtpFechaDesdeCobro1.Value.Date, dtpFechaHastaCobro1.Value.Date);

            gridCobro1.DataSource = Cobro_consin_diarioList;
        }

        private void btnImprimirCobro1_Click(object sender, EventArgs e)
        {
            gridCobro1.ShowPrintPreview();
        }

        private void btnConsultarCobro2_Click(object sender, EventArgs e)
        {
            gridCobro1.Visible = false;
            gridCobro2.Visible = true;
            cxc_auditoria_de_diario_contable_cobranza_Bus auditoriaBus = new cxc_auditoria_de_diario_contable_cobranza_Bus();
            List<spCXC_cobrosConSin_Diario_Detalle_Info> Cobro_consin_diarioList = new List<spCXC_cobrosConSin_Diario_Detalle_Info>();

            //Cobro_consin_diarioList = auditoriaBus.Get_List_Cobros_ConSin_Diario_Detalle(param.IdEmpresa, Convert.ToInt32(ucIn_Sucursal_Bodega4.cmb_sucursal.EditValue), Convert.ToString(cmb_cuentas_inicioCobro2.EditValue), dtpFechaDesdeCobro2.Value.Date, dtpFechaHastaCobro2.Value.Date);

            gridCobro2.DataSource = Cobro_consin_diarioList;
        }

        private void btnImprimirCobro2_Click(object sender, EventArgs e)
        {
            gridCobro2.ShowPrintPreview();
        }

        private void mnu_salir_Click(object sender, EventArgs e)
        {
            Close();
        }

        
    }
}