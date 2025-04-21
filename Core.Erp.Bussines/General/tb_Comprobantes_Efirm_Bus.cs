using System;
using System.Net;
using System.IO;
using Newtonsoft.Json;
using System.Configuration;

namespace Core.Erp.Business.General
{
    public class tb_Comprobantes_Efirm_Bus
    {       
        public byte[] Get_RidePdf(int IdEmpresa, string CedulaRuc_Beneficiario, string IdComprobante, ref string mensaje_error)
        {
            byte[] data = null;            
     
            try            
            {
                string urlApiComprobante = ObtenerUrl();
                string url = $"{urlApiComprobante}?IdEmpresa={IdEmpresa}&cedulaRuc={CedulaRuc_Beneficiario}&IdComprobante={IdComprobante}&tipo=pdf";

                HttpWebRequest HttpWReq = (HttpWebRequest)WebRequest.Create(url);
                HttpWebResponse HttpWResp = (HttpWebResponse)HttpWReq.GetResponse();

                StreamReader reader = new StreamReader(HttpWResp.GetResponseStream());
                string result = reader.ReadToEnd();
                reader.Close();
                HttpWResp.Close();

                data = Convert.FromBase64String(result);
            } 
            catch (Exception ex)
            {
                mensaje_error = ex.Message;
                throw new Exception(ex.Message);
            }
           
            return data;
        }

        public string Get_Xml(int IdEmpresa, string CedulaRuc_Beneficiario, string IdComprobante, ref string mensaje_error)
        {
            string result = "";

            try
            {
                string urlApiComprobante = ObtenerUrl();
                string url = $"{urlApiComprobante}?IdEmpresa={IdEmpresa }&cedulaRuc={CedulaRuc_Beneficiario}&IdComprobante={IdComprobante}";

                HttpWebRequest HttpWReq = (HttpWebRequest)WebRequest.Create(url);
                using (var response = (HttpWebResponse)HttpWReq.GetResponse())
                {
                    using (var reader = new StreamReader(response.GetResponseStream()))
                    {
                        var jsonContent = reader.ReadToEnd();
                        var data = JsonConvert.DeserializeObject<Core.Erp.Info.Efirm.tb_Comprobante_Info>(jsonContent);

                        result = data.s_XML;
                    }
                }
            }
            catch (Exception ex)
            {
                mensaje_error = ex.Message;
                throw new Exception(ex.Message);
            }            

            return result;
        }

        public int Get_IdEmpresa_x_Ruc(string Ruc, ref string mensaje_error)
        {
            int IdEmpresa_Efirm = 0;

            try
            {
                HttpWebRequest HttpWReq = (HttpWebRequest)WebRequest.Create("http://10.0.0.9/efirm_ws/api/empresas.php?ruc="+Ruc);
                
                using (var response = (HttpWebResponse)HttpWReq.GetResponse())
                {
                    using (var reader = new StreamReader(response.GetResponseStream()))
                    {
                        var jsonContent = reader.ReadToEnd();
                        var data = JsonConvert.DeserializeObject<Core.Erp.Info.Efirm.tb_Empresa_Info>(jsonContent);

                        IdEmpresa_Efirm = data.IdEmpresa;
                    }
                }
            }
            catch (Exception ex)
            {
                mensaje_error = ex.Message;
                throw new Exception(ex.Message);
            }

            return IdEmpresa_Efirm;
        }

        public string ObtenerUrl()
        {
            // Lee la configuración desde el archivo de configuración
            string url = ConfigurationManager.AppSettings["ApiComprobante"];

            if (string.IsNullOrEmpty(url))
            {
                Console.WriteLine("La URL no está configurada correctamente.");
                // Puedes manejar la falta de configuración de la URL aquí
            }

            return url;
        }
    }
}
