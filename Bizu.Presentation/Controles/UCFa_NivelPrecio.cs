using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Bizu.Application.Inventario;
using Bizu.Application.General;
using Bizu.Domain.General;
using Bizu.Domain.Inventario;

namespace Bizu.Presentation.Controles
{
    public partial class UCFa_NivelPrecio : UserControl
    {
        #region Variables

        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();

        List<in_Catalogo_Info> List = new List<in_Catalogo_Info>();
        in_Catalogo_Bus Bus = new in_Catalogo_Bus();
        in_Catalogo_Info Info = new in_Catalogo_Info();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;

        public delegate void delegate_cmbListadoPrecio_EditValueChanged(object sender, EventArgs e);
        public event delegate_cmbListadoPrecio_EditValueChanged event_cmbListadoPrecio_EditValueChanged;

        #endregion

        public UCFa_NivelPrecio()
        {
            InitializeComponent();
            event_cmbListadoPrecio_EditValueChanged += UCFa_NivelPrecio_event_cmbListadoPrecio_EditValueChanged;
        }

        void UCFa_NivelPrecio_event_cmbListadoPrecio_EditValueChanged(object sender, EventArgs e)
        {
            
        }

        private void cmbListadoPrecio_EditValueChanged(object sender, EventArgs e)
        {            
            try
            {
                event_cmbListadoPrecio_EditValueChanged(sender, e);
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void UCFa_NivelPrecio_Load(object sender, EventArgs e)
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

        void cargar()
        {
            try
            {
                List = new List<in_Catalogo_Info>();
                List = Bus.Get_List_Catalogo(9);
                cmbListadoPrecio.Properties.DataSource = List;

                if (List.Count > 0)
                {
                    cmbListadoPrecio.EditValue = List.First().IdCatalogo;
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        public in_Catalogo_Info get_Info()
        {
            try
            {
                Info = new in_Catalogo_Info();
                if (cmbListadoPrecio.EditValue != null)
                    Info = List.FirstOrDefault(v => v.IdCatalogo == Convert.ToString(cmbListadoPrecio.EditValue));

                return Info;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return new in_Catalogo_Info();
            }

        }

        public void set_Info(string IdCatalogo)
        {
            try
            {
                cmbListadoPrecio.EditValue = IdCatalogo;
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
