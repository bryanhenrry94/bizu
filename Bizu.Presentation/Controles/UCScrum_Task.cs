using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bizu.Presentation.General;
using Bizu.Application.General;
using Bizu.Domain.General;

namespace Bizu.Presentation.Controles
{
    public partial class UCScrum_Task : UserControl
    {
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        public tb_tarea_Info Info_Tarea;
        
        public delegate void delegate_UCScrum_Task_Click(tb_tarea_Info _Info_Tarea);
        public event delegate_UCScrum_Task_Click event_UCScrum_Task_Click;
        
        public UCScrum_Task()
        {
            InitializeComponent();

            event_UCScrum_Task_Click += UCScrum_Task_event_UCScrum_Task_Click;
        }

        private void UCScrum_Task_event_UCScrum_Task_Click(tb_tarea_Info _Info_Tarea)
        {
            
        }

        private void UCScrum_Task_event_refreshData(object sender, FormClosingEventArgs e)
        {

        }

        public void setInfo(tb_tarea_Info _Info_Tarea)
        {
            this.Info_Tarea = _Info_Tarea;
            
        }

        private void UCScrum_Task_Click(object sender, EventArgs e)
        {
            event_UCScrum_Task_Click(this.Info_Tarea);
        }

        private void UCScrum_Task_Load(object sender, EventArgs e)
        {
            try
            {
                if(this.Info_Tarea != null)
                {
                    lbl_prioridad.Text = this.Info_Tarea.Prioridad;
                    lbl_titulo.Text = this.Info_Tarea.Titulo;
                    lbl_descripcion.Text = this.Info_Tarea.Descripcion;
                    lbl_asignado.Text = this.Info_Tarea.IdUsuarioUltAsignacion.ToLower();

                    double totalDays = (DateTime.Now.Date - this.Info_Tarea.FechaFin).TotalDays;

                    // semaforo verde
                    if(totalDays <= 3)
                    {
                        this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(97)))), ((int)(((byte)(0)))));
                        this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(239)))), ((int)(((byte)(206)))));
                    }

                    // semaforo amarillo
                    if (totalDays > 3 && totalDays <= 6)
                    {
                        this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(101)))), ((int)(((byte)(0)))));
                        this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(156)))));
                    }

                    // semaforo rojo
                    if (totalDays > 6)
                    {
                        this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(0)))), ((int)(((byte)(6)))));
                        this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(199)))), ((int)(((byte)(206)))));
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
