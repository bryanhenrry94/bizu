using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;

namespace Bizu.Presentation.Mail
{
    public partial class FrmMail_Envio : DevExpress.XtraEditors.XtraForm
    {
        public FrmMail_Envio()
        {
            InitializeComponent();
        }

        private void btn_enviar_Click(object sender, EventArgs e)
        {
            SmtpClient smtpClient = new SmtpClient("secure251.inmotionhosting.com", 587); //I tried using different hosts and ports
            smtpClient.UseDefaultCredentials = false;
            smtpClient.Credentials = new NetworkCredential("ebiz@edehsa.com", "Ebiz_2017");
            smtpClient.EnableSsl = false; //'Also tried setting this to false

            MailMessage mm = new MailMessage();
            mm.From = new MailAddress("ebiz@edehsa.com");
            mm.Subject = Convert.ToString(txt_asunto.EditValue);
            mm.IsBodyHtml = true;
            mm.Body = txt_mensaje.Text;
            mm.To.Add(Convert.ToString(txt_para.EditValue));

            try
            {
                smtpClient.Send(mm);
                MessageBox.Show("SUCCESS!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            mm.Dispose();
            smtpClient.Dispose();

        }
    }
}
