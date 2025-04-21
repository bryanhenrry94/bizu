using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Core.Erp.Business.Facturacion;
using Core.Erp.Info.Facturacion;
using Core.Erp.Business.General;
using Core.Erp.Winform.Facturacion;
using Core.Erp.Info.General;


namespace Core.Erp.Winform.Controles
{
    public partial class UCFa_TerminoPago : UserControl
    {
        #region Variables
        
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();

        List<fa_TerminoPago_Info> List = new List<fa_TerminoPago_Info>();
        fa_TerminoPago_Bus Bus = new fa_TerminoPago_Bus();
        fa_TerminoPago_Info Info = new fa_TerminoPago_Info();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        
        public delegate void delegate_cmbTerminoPago_EditValueChanged(object sender, EventArgs e);
        public event delegate_cmbTerminoPago_EditValueChanged event_cmbTerminoPago_EditValueChanged;

        #endregion

        public UCFa_TerminoPago()
        {
            InitializeComponent();
            event_cmbTerminoPago_EditValueChanged += UCFa_TerminoPago_event_cmbTerminoPago_EditValueChanged;
        }

        void UCFa_TerminoPago_event_cmbTerminoPago_EditValueChanged(object sender, EventArgs e)
        {            

        }

        private void cmbTerminoPago_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                event_cmbTerminoPago_EditValueChanged(sender, e);
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }                      

        void cargar()
        {
            try
            {
                List = new List<fa_TerminoPago_Info>();
                List = Bus.Get_List_TerminoPago("");
                cmbTerminoPago.Properties.DataSource = List;

                if (List.Count > 0)
                {
                    cmbTerminoPago.EditValue = List.First().IdTerminoPago;
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }
           
        public fa_TerminoPago_Info get_Info()
        {
            try
            {
                Info = new fa_TerminoPago_Info();
                if (cmbTerminoPago.EditValue != null)
                    Info = List.FirstOrDefault(v => v.IdTerminoPago == Convert.ToString(cmbTerminoPago.EditValue));

                return Info;                
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return new fa_TerminoPago_Info();
            }

        }

        public void set_Info(string IdTerminoPago)
        {
            try
            {
                cmbTerminoPago.EditValue = IdTerminoPago;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

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
    }
}
