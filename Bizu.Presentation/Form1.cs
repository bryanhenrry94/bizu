using System;
using System.Net.Http;
using System.Net;
using System.IO;
using System.Windows.Forms;
using System.Text;

namespace Bizu.Presentation
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        // HttpClient is intended to be instantiated once per application, rather than per-use. See Remarks.
        static readonly HttpClient client = new HttpClient();

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btnConsumirServicio_Click(object sender, EventArgs e)
        {
            consultarPesoCorporal();
        }        

        private async void consultarPesoCorporal()
        {
            HttpResponseMessage response = await client.GetAsync(txtUrlRest.Text);
            response.EnsureSuccessStatusCode();
            string responseBody = await response.Content.ReadAsStringAsync();

            txtResponse.Text = responseBody;
        }

        private void btnServicioSOAP_Click(object sender, EventArgs e)
        {
            try
            {
                HttpWebRequest HttpWReq = (HttpWebRequest)WebRequest.Create(txtUrlSOAP.Text);
                HttpWebResponse HttpWResp = (HttpWebResponse)HttpWReq.GetResponse();

                StreamReader reader = new StreamReader(HttpWResp.GetResponseStream());
                string result = reader.ReadToEnd();
                reader.Close();
                HttpWResp.Close();

                txtResponseSOAP.Text = result;

                byte[] data = Convert.FromBase64String(result);

                string file = Path.GetTempPath() + "comprobante.pdf";
                File.WriteAllBytes(file, data);

                System.Diagnostics.Process.Start(file);        
            }
            catch (Exception ex)
            {
                txtResponse.Text = ex.Message;
            }            
        }
    }
}