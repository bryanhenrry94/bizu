using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Core.Erp.Business.Compras;
using Core.Erp.Info.Compras;
using Core.Erp.Business.General;
using Core.Erp.Info.General;

namespace Core.Erp.Winform.Compras
{
    public partial class FrmCom_Solicitante_Cons : DevExpress.XtraEditors.XtraForm
    {
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        com_solicitante_Bus Bus_Solicitante = new com_solicitante_Bus();
        List<com_solicitante_Info> List_Solicitante = new List<com_solicitante_Info>();

        public FrmCom_Solicitante_Cons()
        {
            InitializeComponent();

            ucGe_Menu.event_btnNuevo_ItemClick += ucGe_Menu_event_btnNuevo_ItemClick;
            ucGe_Menu.event_btnModificar_ItemClick += ucGe_Menu_event_btnModificar_ItemClick;
            ucGe_Menu.event_btnconsultar_ItemClick += ucGe_Menu_event_btnconsultar_ItemClick;
            ucGe_Menu.event_btnAnular_ItemClick += ucGe_Menu_event_btnAnular_ItemClick;
            ucGe_Menu.event_btnImprimir_ItemClick += ucGe_Menu_event_btnImprimir_ItemClick;
            ucGe_Menu.event_btnSalir_ItemClick += ucGe_Menu_event_btnSalir_ItemClick;
            ucGe_Menu.event_btnBuscar_Click += ucGe_Menu_event_btnBuscar_Click;
        }

        void ucGe_Menu_event_btnBuscar_Click(object sender, EventArgs e)
        {
            cargar_grid();
        }

        void ucGe_Menu_event_btnSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        void ucGe_Menu_event_btnImprimir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridControl_Solicitante.ShowPrintPreview();
        }

        void ucGe_Menu_event_btnAnular_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            preparar_formulario(Cl_Enumeradores.eTipo_action.Anular);
        }

        void ucGe_Menu_event_btnconsultar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            preparar_formulario(Cl_Enumeradores.eTipo_action.consultar);
        }

        void ucGe_Menu_event_btnModificar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            preparar_formulario(Cl_Enumeradores.eTipo_action.actualizar);
        }

        void ucGe_Menu_event_btnNuevo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            preparar_formulario(Cl_Enumeradores.eTipo_action.grabar);
        }

        private void cargar_grid()
        {
            try
            {
                List_Solicitante = Bus_Solicitante.Get_List_Solicitante(1);
                gridControl_Solicitante.DataSource = List_Solicitante;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void preparar_formulario(Cl_Enumeradores.eTipo_action _Accion)
        {
            try
            {
                com_solicitante_Info Info_Selected = (com_solicitante_Info)gridView_Solicitante.GetFocusedRow();

                FrmCom_Solicitante_Mant Frm = new FrmCom_Solicitante_Mant();

                if (_Accion != Cl_Enumeradores.eTipo_action.grabar)
                {
                    Frm.Set_Info(Info_Selected);

                    if (_Accion == Cl_Enumeradores.eTipo_action.Anular)
                        if (Info_Selected.estado == "I")
                        {
                            MessageBox.Show("El registro ya se encuentra anulado!", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            return;
                        }
                }


                Frm.Set_Accion(_Accion);
                Frm.event_FrmCom_Solicitante_Mant_FormClosing += Frm_event_FrmCom_Solicitante_Mant_FormClosing;
                Frm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void Frm_event_FrmCom_Solicitante_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            cargar_grid();
        }

        private void FrmCom_Solicitante_Cons_Load(object sender, EventArgs e)
        {
            cargar_grid();
        }
    }
}