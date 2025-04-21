using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace WS_ERP.Info
{
    [DataContract]
    public class Response_Info
    {
        [DataMember]
        public string CodigoError { get; set; }
        [DataMember]
        public string MensajeError { get; set; }
        [DataMember]
        public string Data { get; set; }

        public Response_Info()
        {
            this.CodigoError = "";
            this.MensajeError = "";
            this.Data = "";
        }
    }
}