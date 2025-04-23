using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Bizu.Application.Contabilidad;
using Bizu.Domain.Contabilidad;
using Bizu.Application.General;
using Bizu.Presentation.Contabilidad;
using Bizu.Domain.General;


namespace Bizu.Presentation.Controles
{
    public partial class UCCon_TipoCosto : DevExpress.XtraEditors.XtraUserControl
    {

        #region Variables
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();

        List<ct_Tipo_costo_Info> listTipoCosto = new List<ct_Tipo_costo_Info>();
        ct_Tipo_costo_Bus BusTipoCosto = new ct_Tipo_costo_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;

        //frmCon_TipoCbteCble_Mant frm; x disposicion de oscar no se realiza el mantenimiento de este combo - domingo 4 mar 2018 12:30

    
        ct_Tipo_costo_Info InfoTipoCosto = new ct_Tipo_costo_Info();


        public delegate void delegate_cmbTipoCosto_EditValueChanged(object sender, EventArgs e);
        public event delegate_cmbTipoCosto_EditValueChanged event_cmbTipoCosto_EditValueChanged;

        public delegate void delegate_cmbTipoCosto_Validating(object sender, EventArgs e);
        public event delegate_cmbTipoCosto_Validating event_cmbTipoCosto_Validating;

        public delegate void delegate_cmbTipoCosto_Validated(object sender, EventArgs e);
        public event delegate_cmbTipoCosto_Validated event_cmbTipoCosto_Validated;



        #endregion



      


        public UCCon_TipoCosto()
        {
            InitializeComponent();
            event_cmbTipoCosto_EditValueChanged += UCCon_TipoCosto_event_cmbTipoCosto_EditValueChanged;
            event_cmbTipoCosto_Validated += UCCon_TipoCosto_event_cmbTipoCosto_Validated;
            event_cmbTipoCosto_Validating += UCCon_TipoCosto_event_cmbTipoCosto_Validating;

        }

        void UCCon_TipoCosto_event_cmbTipoCosto_Validating(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        void UCCon_TipoCosto_event_cmbTipoCosto_Validated(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        void UCCon_TipoCosto_event_cmbTipoCosto_EditValueChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

       
        
        private void cmbTipoCosto_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
              //  event_cmbTipoCosto_EditValueChanged(sender, e);
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }


        //private void cmbTipoCosto_Validated(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        event_cmbTipoCosto_Validated(sender, e);
        //    }
        //    catch (Exception ex)
        //    {
        //        string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
        //        MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
        //    }
        //}

        private void cmbTipoCosto_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                event_cmbTipoCosto_Validating(sender, e);
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }




        //***************************************---------------------------------------------

        private void UCCon_TipoCosto_Load(object sender, EventArgs e)
        {
            try
            {
                cargar_TipoCosto();
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

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                // llamar_Formulario(Cl_Enumeradores.eTipo_action.grabar);
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
                get_TipoCosto();
                //llamar_Formulario(Cl_Enumeradores.eTipo_action.actualizar);
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
                get_TipoCosto();
                //llamar_Formulario(Cl_Enumeradores.eTipo_action.consultar);
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        void cargar_TipoCosto()
        {
            try
            {
                listTipoCosto = new List<ct_Tipo_costo_Info>();
             //   listTipoCosto = BusTipoCosto.Get_list_Tipo_costo(param.IdEmpresa);
                cmbTipoCosto.Properties.DataSource = listTipoCosto;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        //private void llamar_Formulario(Cl_Enumeradores.eTipo_action Accion)
        //{
        //    try
        //    {
        //        frm = new frmCon_TipoCbteCble_Mant();
        //        frm.event_frmCon_TipoCbteCble_Mant_FormClosing += new frmCon_TipoCbteCble_Mant.delegate_frmCon_TipoCbteCble_Mant_FormClosing(frm_event_frmCon_TipoCbteCble_Mant_FormClosing);                
        //        if (!(Accion == Cl_Enumeradores.eTipo_action.grabar))
        //        {
        //            frm.set_TipoCbtecble(InfoTipoCbteCble);
        //            frm.set_accion(Accion);

        //        }
        //        else
        //            frm.set_accion(Accion);

        //        frm.Show();
        //    }
        //    catch (Exception ex)
        //    {
        //        string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
        //        MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
        //    }
        //}


        void frm_event_frmCon_TipoCbteCble_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                cargar_TipoCosto();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }



        public void Inicializar_cmbTipoCosto()
        {
            try
            {
                cmbTipoCosto.EditValue = null;

            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        public void set_TipoCbteCble(int IdTipoCosto)
        {
            try
            {
                cmbTipoCosto.EditValue = IdTipoCosto;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }


        public ct_Tipo_costo_Info get_TipoCosto()
        {
            try
            {
                InfoTipoCosto = listTipoCosto.FirstOrDefault(v => v.IdTipo_Costo == Convert.ToInt32(cmbTipoCosto.EditValue));
                return InfoTipoCosto;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return new ct_Tipo_costo_Info();
            }

        }

       

        

    
    
    }
}
