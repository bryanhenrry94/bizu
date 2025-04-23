using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bizu.Domain.General;
using Bizu.Domain.class_sri.FacturaV2;
using Bizu.Domain.class_sri.Retencion;
using Bizu.Domain.class_sri.NotaDebito;
using Bizu.Domain.class_sri.NotaCredito;
using Bizu.Domain.class_sri.GuiaRemision;

namespace Bizu.Domain.SRI
{
   public  class Comprobante_Info
    {
        public string IdComprobante { get; set; }
        public DateTime Fecha { get; set; }
        public Bizu.Domain.General.Cl_Enumeradores.eTipoComprobante TipoCbte { get; set; }
        public string Observacion { get; set; }

        public factura CbteFactura { get; set; }
        public comprobanteRetencion cbteRet { get; set; }
        public notaCredito cbteNC { get; set; }
        public notaDebito cbteDeb { get; set; }
        public guiaRemision cbtGR { get; set; }
        public factura cbtFacruraR { get; set; }
        public Boolean Checked { get; set; }
        public string xml { get; set; }

        public Comprobante_Info()
        {

        }

        public Comprobante_Info(string _IdComprobante, DateTime _Fecha, Bizu.Domain.General.Cl_Enumeradores.eTipoComprobante _TipoCbte
            , string _Observacion, factura _CbteFactura)
        {
            IdComprobante = _IdComprobante;
            Fecha = _Fecha;
            TipoCbte = _TipoCbte;
            Observacion = _Observacion;
            CbteFactura = _CbteFactura;
        }

        public Comprobante_Info(string _IdComprobante, DateTime _Fecha, Bizu.Domain.General.Cl_Enumeradores.eTipoComprobante _TipoCbte
             , string _Observacion, guiaRemision _cbtGR)
        {
            IdComprobante = _IdComprobante;
            Fecha = _Fecha;
            TipoCbte = _TipoCbte;
            Observacion = _Observacion;
            cbtGR = _cbtGR;
        }




        public Comprobante_Info(string _IdComprobante, DateTime _Fecha, Bizu.Domain.General.Cl_Enumeradores.eTipoComprobante _TipoCbte
              , string _Observacion, notaCredito _cbteNC)
        {
            IdComprobante = _IdComprobante;
            Fecha = _Fecha;
            TipoCbte = _TipoCbte;
            Observacion = _Observacion;
            cbteNC = _cbteNC;

        }




        public Comprobante_Info(string _IdComprobante, DateTime _Fecha, Bizu.Domain.General.Cl_Enumeradores.eTipoComprobante _TipoCbte
               , string _Observacion, notaDebito _cbteDeb)
        {
            IdComprobante = _IdComprobante;
            Fecha = _Fecha;
            TipoCbte = _TipoCbte;
            Observacion = _Observacion;
            cbteDeb = _cbteDeb;

        }

        public Comprobante_Info(string _IdComprobante, DateTime _Fecha, Bizu.Domain.General.Cl_Enumeradores.eTipoComprobante _TipoCbte
                , string _Observacion, comprobanteRetencion _cbteRet)
        {
            IdComprobante = _IdComprobante;
            Fecha = _Fecha;
            TipoCbte = _TipoCbte;
            Observacion = _Observacion;
            cbteRet = _cbteRet;

        }



        //public Comprobante_Info(string _IdComprobante, DateTime _Fecha, eTipoComprobante _TipoCbte
        //        , string _Observacion, factura _cbteFacR)
        //{
        //    IdComprobante = _IdComprobante;
        //    Fecha = _Fecha;
        //    TipoCbte = _TipoCbte;
        //    Observacion = _Observacion;
        //    cbtFacruraR = _cbteFacR;

        //}



    }
}
