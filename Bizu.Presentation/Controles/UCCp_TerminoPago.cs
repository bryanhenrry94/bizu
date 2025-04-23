using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Bizu.Application.CuentasxPagar;
using Bizu.Domain.CuentasxPagar;
using Bizu.Application.General;
using Bizu.Presentation.CuentasxPagar;
using Bizu.Domain.General;


namespace Bizu.Presentation.Controles
{
    public partial class UCCp_TerminoPago : UserControl
    {
        #region Variables
        
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();

        List<cp_TerminoPago_Info> List = new List<cp_TerminoPago_Info>();
        cp_TerminoPago_Bus Bus = new cp_TerminoPago_Bus();
        cp_TerminoPago_Info Info = new cp_TerminoPago_Info();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        
        public delegate void delegate_cmbTermPago_EditValueChanged(object sender, EventArgs e);
        public event delegate_cmbTermPago_EditValueChanged event_cmbTermPago_EditValueChanged;

        #endregion

        public UCCp_TerminoPago()
        {
            InitializeComponent();
            event_cmbTermPago_EditValueChanged += UCFa_TerminoPago_event_cmbTermPago_EditValueChanged;
        }

        //cmb_Acciones
        public bool Visible_cmb_Acciones { get { return (this.cmb_Acciones.Visible && this.cmb_Acciones.Visible); } set { this.cmb_Acciones.Visible = this.cmb_Acciones.Visible = value; } }

        void UCFa_TerminoPago_event_cmbTermPago_EditValueChanged(object sender, EventArgs e)
        {            

        }

        private void cmbTermPago_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                event_cmbTermPago_EditValueChanged(sender, e);
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }                      

        public void cargar()
        {
            try
            {
                List = new List<cp_TerminoPago_Info>();
                List = Bus.Get_List_TerminoPago(param.IdEmpresa);
                cmbTermPago.Properties.DataSource = List;
                //cmbTermPago.Properties.DisplayMember = "nom_TerminoPago";
                //cmbTermPago.Properties.ValueMember = "IdTerminoPago";

                if (List.Count > 0)
                {
                    cmbTermPago.EditValue = List.First().IdTerminoPago;
                }


          
            
                
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }
           
        public cp_TerminoPago_Info get_Info()
        {
            try
            {
                Info = new cp_TerminoPago_Info();
                if (cmbTermPago.EditValue != null)
                    Info = List.FirstOrDefault(v => v.IdTerminoPago == Convert.ToString(cmbTermPago.EditValue));

                return Info;                
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return new cp_TerminoPago_Info();
            }

        }

        public void set_Info(string IdTerminoPago)
        {
            try
            {
                cmbTermPago.EditValue = IdTerminoPago;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        //public void set_Info_Proveedor(int idempresa, int IdProveedor)
        //{
        //    try
        //    {
        //        List = new List<cp_TerminoPago_Info>();
        //        List = Bus.Get_List_TerminoPago_Proveedor(idempresa, IdProveedor);
        //        cmbTermPago.Properties.DataSource = List;

        //        if (List.Count > 0)
        //        {
        //            cmbTermPago.EditValue = List.First().IdTerminoPago;
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
        //        MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
        //    }
        //}

        private void UCFa_TerminoPago_Load(object sender, EventArgs e)
        {
            try
            {
                cargar();

            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                llamar_Formulario(Cl_Enumeradores.eTipo_action.grabar);
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                llamar_Formulario(Cl_Enumeradores.eTipo_action.actualizar);
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                llamar_Formulario(Cl_Enumeradores.eTipo_action.consultar);
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }
        private void llamar_Formulario(Cl_Enumeradores.eTipo_action Accion)
        {
            try
            {
                frmCP_Proveedor_TerminoPago_Mant frm = new frmCP_Proveedor_TerminoPago_Mant();
                //frm.Event_frmCP_Proveedor_TerminoPago_Mantenimiento_FormClosing += frmCP_Proveedor_TerminoPago_Mant_event_FrmCom_TerminoPagos_Mant_FormClosing;
                if (Accion != Cl_Enumeradores.eTipo_action.grabar)
                {
                    if (cmbTermPago.EditValue != null)
                    {
                        Info = List.Where(q => q.IdEmpresa == param.IdEmpresa && q.IdTerminoPago == cmbTermPago.EditValue).First();
                        frm._Accion = Accion;
                        frm.setInfo(Info);
                        frm.Show();
                        
                    }
                    else
                        MessageBox.Show("Seleccione un Termino de Pago.", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    frm._Accion = Accion;
                    frm.Show();
                    
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void cmb_Acciones_Click(object sender, EventArgs e)
        {
            try
            {
                MenuAcciones.Show(cmb_Acciones, new Point(0, cmb_Acciones.Height));
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }
    }
}
