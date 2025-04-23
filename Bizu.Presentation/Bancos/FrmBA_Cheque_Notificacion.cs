using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Bizu.Domain.Bancos;
using Bizu.Domain.General;

namespace Bizu.Presentation.Bancos
{
    public partial class FrmBA_Cheque_Notificacion : DevExpress.XtraEditors.XtraForm
    {
        public Cl_Enumeradores.eMetodoEnvio MetodoEnvio;

        public FrmBA_Cheque_Notificacion()
        {
            InitializeComponent();
        }
        
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.MetodoEnvio = Cl_Enumeradores.eMetodoEnvio.Cancelar;
            this.Close();
        }

        private void btnManual_Click(object sender, EventArgs e)
        {
            this.MetodoEnvio = Cl_Enumeradores.eMetodoEnvio.Manual;
            this.Close();
        }

        private void btnCorreo_Click(object sender, EventArgs e)
        {
            this.MetodoEnvio = Cl_Enumeradores.eMetodoEnvio.Correo;
            this.Close();
        }
    }
}