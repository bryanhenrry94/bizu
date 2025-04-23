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
using Bizu.Application.Mail;
using Bizu.Domain.General;
using Bizu.Domain.Mail;

namespace Bizu.Presentation.Mail
{
    public partial class FrmMail_BandejaSalida : DevExpress.XtraEditors.XtraForm
    {
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        mail_Mail_Bus Bus_Mail = new mail_Mail_Bus();
        List<mail_Mail_Info> List_Info_Mail = new List<mail_Mail_Info>();
        BindingList<mail_Mail_Info> BindingList_Info_Mail = new BindingList<mail_Mail_Info>();

        public FrmMail_BandejaSalida()
        {
            InitializeComponent();
        }

        private bool Anular()
        {
            try
            {
                if (MessageBox.Show("¿Esta seguro de eliminar el registro?", param.Nombre_sistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {
                    string mensaje = "";

                    mail_Mail_Info Info_Selected = gridView_Mail.GetFocusedRow() as mail_Mail_Info;

                    if (Info_Selected != null)
                    {
                        if (Bus_Mail.EliminarBD(Info_Selected, ref mensaje))
                            cargar_grid();
                    }
                    else
                    {
                        MessageBox.Show("Seleccione un registro!", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return false;
                    }

                    return true;
                }
                else
                    return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void cargar_grid()
        {
            try
            {
                List_Info_Mail = Bus_Mail.Get_List(param.IdEmpresa, param.IdSucursal, param.IdUsuario);
                BindingList_Info_Mail = new BindingList<mail_Mail_Info>(List_Info_Mail);
                gridControl_Mail.DataSource = BindingList_Info_Mail;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmMail_BandejaSalida_Load(object sender, EventArgs e)
        {
            try
            {
                BindingList_Info_Mail = new BindingList<mail_Mail_Info>();
                gridControl_Mail.DataSource = BindingList_Info_Mail;

                cargar_grid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gridView_Mail_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            try
            {
                var data = gridView_Mail.GetRow(e.RowHandle) as mail_Mail_Info;
                if (data == null)
                    return;

                if (!string.IsNullOrEmpty(data.MensajeError))
                    e.Appearance.ForeColor = Color.Red;
            }
            catch (Exception ex)
            {
            }
        }

        private void btn_enviar_mail_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("¿Esta seguro de enviar mail?", param.Nombre_sistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {
                    string mensaje = "";

                    mail_Mail_Info Info_Selected = gridView_Mail.GetFocusedRow() as mail_Mail_Info;

                    if (Info_Selected != null)
                    {
                        Bus_Mail.Emviar_Mail(Info_Selected, ref mensaje);
                        cargar_grid();
                    }
                    else
                    {
                        MessageBox.Show("Seleccione un registro!", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_anular_Click(object sender, EventArgs e)
        {
            Anular();
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}