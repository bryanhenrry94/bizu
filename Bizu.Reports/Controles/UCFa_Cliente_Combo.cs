using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bizu.Application.Facturacion;
using Bizu.Domain.Facturacion;
using Bizu.Application.General;
using Bizu.Domain.General;



namespace Bizu.Reports.Controles
{
    public partial class UCFa_Cliente_Combo : UserControl
    {

        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;

        public UCFa_Cliente_Combo()
        {
            InitializeComponent();
        }

        public void Cargar_cliente()
        {
            try
            {
                fa_Cliente_Bus BusCliente = new fa_Cliente_Bus();

               cmb_cliente.Properties.DataSource= BusCliente.Get_List_Clientes(param.IdEmpresa);


            }
            catch (Exception ex)
            {
                
                
            }
        }

        private void cmb_cliente_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}
