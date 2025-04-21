using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net;
using System.Xml;

namespace Core.Erp.Business.SRI
{
    public class sri_comprobantes
    {
        public sri_autorizacion GetAutorizacion(string ClaveAcceso)
        {
            try
            {
                // Forzar TLS 1.2
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

                sri_autorizacion autorizacionSRI = new sri_autorizacion();
                
                // URL del servicio web
                string url = "https://cel.sri.gob.ec/comprobantes-electronicos-ws/AutorizacionComprobantesOffline";

                // Crea la solicitud HTTP POST
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                request.Method = "POST";
                request.ContentType = "text/xml";

                // Crea el cuerpo del mensaje SOAP
                string soapBody = $@"<?xml version=""1.0"" encoding=""utf-8""?>
                            <soap:Envelope xmlns:soap=""http://schemas.xmlsoap.org/soap/envelope/"" xmlns:tns=""http://ec.gob.sri.ws.autorizacion"">
                                <soap:Body>
                                    <tns:autorizacionComprobante>
                                        <claveAccesoComprobante>{ClaveAcceso}</claveAccesoComprobante>
                                    </tns:autorizacionComprobante>
                                </soap:Body>
                            </soap:Envelope>";

                // Convierte el cuerpo del mensaje SOAP en bytes
                byte[] byteData = Encoding.UTF8.GetBytes(soapBody);

                // Establece la longitud del contenido y escribe los datos en la solicitud
                request.ContentLength = byteData.Length;
                using (Stream requestStream = request.GetRequestStream())
                {
                    requestStream.Write(byteData, 0, byteData.Length);
                }

                try
                {
                    // Realiza la solicitud al servicio web
                    HttpWebResponse response = (HttpWebResponse)request.GetResponse();

                    string sXML_SRI = "";

                    // Lee la respuesta del servicio web
                    using (Stream responseStream = response.GetResponseStream())
                    {
                        StreamReader reader = new StreamReader(responseStream);
                        string responseXml = reader.ReadToEnd();
                        //Console.WriteLine(responseXml); // Aquí está la respuesta en formato XML

                        // Crea un objeto XmlDocument y carga el XML de respuesta
                        XmlDocument xmlDoc = new XmlDocument();
                        xmlDoc.LoadXml(responseXml);

                        // Encuentra y muestra el valor de la etiqueta <estado>
                        XmlNode estadoNode = xmlDoc.SelectSingleNode("//estado");
                        if (estadoNode != null)
                        {
                            string estadoValue = estadoNode.InnerText;
                            autorizacionSRI.estado = estadoValue;
                        }

                        // Encuentra y muestra el valor de la etiqueta <numeroAutorizacion>
                        XmlNode numeroAutorizacionNode = xmlDoc.SelectSingleNode("//numeroAutorizacion");
                        if (numeroAutorizacionNode != null)
                        {
                            string numeroAutorizacionValue = numeroAutorizacionNode.InnerText;
                            autorizacionSRI.numeroAutorizacion = numeroAutorizacionValue;
                        }

                        // Encuentra y muestra el valor de la etiqueta <fechaAutorizacion>
                        XmlNode fechaAutorizacionNode = xmlDoc.SelectSingleNode("//fechaAutorizacion");
                        if (fechaAutorizacionNode != null)
                        {
                            DateTime fechaAutorizacionValue = Convert.ToDateTime(fechaAutorizacionNode.InnerText);
                            autorizacionSRI.fechaAutorizacion = fechaAutorizacionValue;

                        }

                        // Encuentra y muestra el valor de la etiqueta <ambiente>
                        XmlNode ambienteNode = xmlDoc.SelectSingleNode("//ambiente");
                        if (ambienteNode != null)
                        {
                            string ambienteValue = ambienteNode.InnerText;
                            autorizacionSRI.ambiente = ambienteValue;
                        }

                        XmlNode comprobanteNode = xmlDoc.SelectSingleNode("//comprobante");
                        if (comprobanteNode != null)
                        {
                            string comprobanteValue = comprobanteNode.InnerText;
                            
                            // Crear un StringBuilder para construir el XML
                            StringBuilder xmlBuilder = new StringBuilder();

                            // Agregar la declaración XML con la codificación UTF-8
                            xmlBuilder.AppendLine(@"<?xml version=""1.0"" encoding=""UTF-8"" standalone=""yes""?>");

                            // Iniciar el elemento raíz <autorizacion>
                            xmlBuilder.AppendLine("<autorizacion>");

                            // Agregar los elementos hijos de <autorizacion> con sus valores
                            xmlBuilder.AppendLine($"  <estado>{autorizacionSRI.estado}</estado>");
                            xmlBuilder.AppendLine($"  <numeroAutorizacion>{autorizacionSRI.numeroAutorizacion}</numeroAutorizacion>");
                            xmlBuilder.AppendLine($"  <fechaAutorizacion>{autorizacionSRI.fechaAutorizacion}</fechaAutorizacion>");
                            xmlBuilder.AppendLine($"  <ambiente>{autorizacionSRI.ambiente}</ambiente>");

                            // Agregar el elemento <comprobante> con su valor dentro de CDATA
                            xmlBuilder.AppendLine($"  <comprobante><![CDATA[{comprobanteValue}]]></comprobante>");

                            // Agregar el elemento <mensajes>
                            xmlBuilder.AppendLine("  <mensajes />");

                            // Cerrar el elemento raíz </autorizacion>
                            xmlBuilder.AppendLine("</autorizacion>");

                            // Obtener el XML como un string
                            string xmlString = xmlBuilder.ToString();
                            
                            autorizacionSRI.comprobante = xmlString;
                        }
                    }
                    
                    // Cierra la respuesta
                    response.Close();
                }
                catch (WebException ex)
                {
                    // Manejo de errores
                    Console.WriteLine(ex.Message);
                }

                return autorizacionSRI;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // Método para crear un elemento XML con un texto como contenido
        static XmlElement CreateElementWithText(XmlDocument xmlDoc, string elementName, string text)
        {
            XmlElement element = xmlDoc.CreateElement(elementName);
            element.InnerText = text;
            return element;
        }
    }   
}
