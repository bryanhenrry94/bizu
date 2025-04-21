using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Core.Erp.Winform.General;
using Core.Erp.Business.General;
using Core.Erp.Info.General;

namespace Core.Erp.Winform.Controles
{
    public partial class UCScrum_Board : UserControl
    {
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        private FrmGe_Tarea_Mant frmScrum_Tarea_Mant;
        private UCScrum_Task tarea;

        private tb_tarea_Bus bus_tarea = new tb_tarea_Bus();
        private List<tb_tarea_Info> list_tarea_pendiente = new List<tb_tarea_Info>();
        private List<tb_tarea_Info> list_tarea_proceso = new List<tb_tarea_Info>();
        private List<tb_tarea_Info> list_tarea_finalizada = new List<tb_tarea_Info>();

        private DateTime fecha_desde;
        private DateTime fecha_hasta;

        public UCScrum_Board()
        {
            InitializeComponent();
        }

        private void btn_nueva_tarea_Click(object sender, EventArgs e)
        {
            try
            {
                this.frmScrum_Tarea_Mant = new FrmGe_Tarea_Mant();
                this.frmScrum_Tarea_Mant.setAccion(Cl_Enumeradores.eTipo_action.grabar);
                this.frmScrum_Tarea_Mant.event_FrmGe_Tarea_Mant_FormClosing += FrmScrum_Tarea_Mant_event_FrmGe_Tarea_Mant_FormClosing;
                this.frmScrum_Tarea_Mant.ShowDialog();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmScrum_Tarea_Mant_event_FrmGe_Tarea_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.loadData();
        }

        public void loadData()
        {
            try
            {
                // limpiamos el control
                this.stackPanel_pendiente.Controls.Clear();
                this.list_tarea_pendiente = this.bus_tarea.GetList(param.IdEmpresa, param.IdUsuario, this.fecha_desde, this.fecha_hasta, Cl_Enumeradores.eTipoEstado_Tarea.PEND.ToString());
                foreach (var item in this.list_tarea_pendiente)
                {
                    this.tarea = new UCScrum_Task();
                    this.tarea.setInfo(item);
                    this.tarea.Dock = DockStyle.Fill;
                    this.tarea.event_UCScrum_Task_Click += Tarea_event_UCScrum_Task_Click;

                    this.stackPanel_pendiente.Controls.Add(tarea);
                }

                this.stackPanel_enProceso.Controls.Clear();
                this.list_tarea_proceso = this.bus_tarea.GetList(param.IdEmpresa, param.IdUsuario, this.fecha_desde, this.fecha_hasta, Cl_Enumeradores.eTipoEstado_Tarea.PROC.ToString());
                foreach (var item in this.list_tarea_proceso)
                {
                    this.tarea = new UCScrum_Task();
                    this.tarea.setInfo(item);
                    this.tarea.Dock = DockStyle.Fill;
                    this.tarea.event_UCScrum_Task_Click += Tarea_event_UCScrum_Task_Click;

                    this.stackPanel_enProceso.Controls.Add(tarea);
                }

                this.stackPanel_finalizada.Controls.Clear();
                this.list_tarea_finalizada = this.bus_tarea.GetList(param.IdEmpresa, param.IdUsuario, this.fecha_desde, this.fecha_hasta, Cl_Enumeradores.eTipoEstado_Tarea.FINA.ToString());
                foreach (var item in this.list_tarea_finalizada)
                {
                    this.tarea = new UCScrum_Task();
                    this.tarea.setInfo(item);
                    this.tarea.Dock = DockStyle.Fill;
                    this.tarea.event_UCScrum_Task_Click += Tarea_event_UCScrum_Task_Click;

                    this.stackPanel_finalizada.Controls.Add(tarea);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Tarea_event_UCScrum_Task_Click(tb_tarea_Info _Info_Tarea)
        {
            try
            {
                if(_Info_Tarea == null)
                {
                    MessageBox.Show("No existe información a mostrar!", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                this.frmScrum_Tarea_Mant = new FrmGe_Tarea_Mant();
                this.frmScrum_Tarea_Mant.setAccion(Cl_Enumeradores.eTipo_action.actualizar);
                this.frmScrum_Tarea_Mant.setInfo(_Info_Tarea);
                this.frmScrum_Tarea_Mant.event_FrmGe_Tarea_Mant_FormClosing += FrmScrum_Tarea_Mant_event_FrmGe_Tarea_Mant_FormClosing;
                this.frmScrum_Tarea_Mant.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void UcScrum_Card_Pendiente_event_refreshData(object sender, FormClosingEventArgs e)
        {
            this.loadData();
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            this.loadData();
        }

        private void cmb_CriterioBusqueda_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int DiasTranscurridos = 0;
                DateTime fecha = DateTime.Now;
                switch (cmb_CriterioBusqueda.SelectedItem.ToString())
                {
                    case "Mes actual":
                        dtpFechaDesde.EditValue = getFirstDateOfMount();
                        dtpFechaHasta.EditValue = getLastDateOfMount();
                        break;
                    case "Última semana":
                        dtpFechaDesde.EditValue = Convert.ToDateTime(DateTime.Now.Date.AddDays(-7).ToShortDateString());
                        dtpFechaHasta.EditValue = Convert.ToDateTime(DateTime.Now.AddDays(1).ToShortDateString());
                        break;
                    case "Último mes":
                        dtpFechaDesde.EditValue = Convert.ToDateTime(DateTime.Now.Date.AddMonths(-1).ToShortDateString());
                        dtpFechaHasta.EditValue = Convert.ToDateTime(DateTime.Now.AddDays(1).ToShortDateString());
                        break;
                    case "Último trimestre":
                        dtpFechaDesde.EditValue = Convert.ToDateTime(DateTime.Now.Date.AddMonths(-3).ToShortDateString());
                        dtpFechaHasta.EditValue = Convert.ToDateTime(DateTime.Now.AddDays(1).ToShortDateString());
                        break;
                    case "Año pasado":
                        DiasTranscurridos = DateTime.Now.DayOfYear;
                        fecha = fecha.AddDays(-DiasTranscurridos + 1);
                        dtpFechaDesde.EditValue = Convert.ToDateTime(fecha.Date.AddYears(-1).ToShortDateString());
                        dtpFechaHasta.EditValue = Convert.ToDateTime(fecha.AddDays(-1).ToShortDateString());
                        break;
                    case "Año actual":
                        DiasTranscurridos = DateTime.Now.DayOfYear;
                        fecha = fecha.AddDays(-DiasTranscurridos + 1);
                        dtpFechaDesde.EditValue = Convert.ToDateTime(fecha.Date.ToShortDateString());
                        dtpFechaHasta.EditValue = Convert.ToDateTime(fecha.AddYears(1).AddDays(-1).ToShortDateString());
                        break;
                    case "Hoy":
                        dtpFechaDesde.EditValue = Convert.ToDateTime(DateTime.Now.Date.ToShortDateString());
                        dtpFechaHasta.EditValue = Convert.ToDateTime(DateTime.Now.ToShortDateString());
                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dtpFechaDesde_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                fecha_desde = Convert.ToDateTime(dtpFechaDesde.EditValue);
                fecha_hasta = Convert.ToDateTime(dtpFechaHasta.EditValue);
                this.loadData();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dtpFechaHasta_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                fecha_desde = Convert.ToDateTime(dtpFechaDesde.EditValue);
                fecha_hasta = Convert.ToDateTime(dtpFechaHasta.EditValue);
                this.loadData();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UCScrum_Board_Final_Load(object sender, EventArgs e)
        {
            try
            {
                this.cmb_CriterioBusqueda.SelectedIndex = 0;
                this.dtpFechaDesde.EditValue = getFirstDateOfMount();
                this.dtpFechaHasta.EditValue = getLastDateOfMount();

                this.loadData();
            }
            catch(Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private DateTime getFirstDateOfMount()
        {
            DateTime current_date = DateTime.Now;
            DateTime first_date = new DateTime(current_date.Year, current_date.Month, 1);

            return first_date;
        }

        private DateTime getLastDateOfMount()
        {
            DateTime current_date = DateTime.Now;
            DateTime first_date = new DateTime(current_date.Year, current_date.Month, 1);

            return first_date.AddMonths(1).AddDays(-1);
        }

    }
}
