using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Bizu.Application.General;
using Bizu.Domain.General;
using Bizu.Application.Compras;
using Bizu.Domain.Compras;
using Bizu.Application.Inventario;
using Bizu.Domain.Inventario;



namespace Bizu.Presentation.Inventario
{
    public partial class FrmIn_Detalle_Ing_Egr_Bodega_Alerta : DevExpress.XtraEditors.XtraForm
    {
        public FrmIn_Detalle_Ing_Egr_Bodega_Alerta()
        {
            InitializeComponent();
        }



        List<in_Ing_Egr_Inven_det_Info> list_a_mostrar = new List<in_Ing_Egr_Inven_det_Info>();


        public void set_info_list(List<in_Ing_Egr_Inven_det_Info> _list_a_mostrar)
        {
            list_a_mostrar = _list_a_mostrar;
        }


        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void FrmIn_Detalle_Ing_Egr_Bodega_Alerta_Load(object sender, EventArgs e)
        {
            gridControlIngEgr.DataSource = list_a_mostrar;
        }
    }
}
