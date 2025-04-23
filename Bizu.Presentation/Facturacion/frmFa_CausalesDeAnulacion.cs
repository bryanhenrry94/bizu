using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Bizu.Application.General;
namespace Bizu.Presentation.Facturacion
{
    public partial class frmFa_CausalesDeAnulacion : DevExpress.XtraEditors.XtraForm
    {
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        public frmFa_CausalesDeAnulacion()
        {
            try
            {
               InitializeComponent();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }

        private void frmFa_CausalesDeAnulacion_Load(object sender, EventArgs e)
        {

        }
    }
}
