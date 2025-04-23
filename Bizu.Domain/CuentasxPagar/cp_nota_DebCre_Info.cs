using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bizu.Domain.Contabilidad;

namespace Bizu.Domain.CuentasxPagar
{
    public class cp_nota_DebCre_Info
    {
        public int IdEmpresa { get; set; }
        public decimal IdCbteCble_Nota { get; set; }
        public int IdTipoCbte_Nota { get; set; }
        public decimal IdProveedor { get; set; }
        public DateTime cn_fecha { get; set; }
        public string cn_serie1 { get; set; }
        public string cn_serie2 { get; set; }
        public string cn_Nota { get; set; }
        public string Num_Nota { get; set; }
        
        public DateTime? Fecha_contable { get; set; }
        public string cn_observacion { get; set; }
        public double cn_subtotal_iva { get; set; }
        public double cn_subtotal_siniva { get; set; }
        public double cn_baseImponible { get; set; }
        public double cn_Por_iva { get; set; }
        public double cn_valoriva { get; set; }
        public int? IdCod_ICE { get; set; }
        public double cn_Ice_base { get; set; }
        public double cn_Ice_por { get; set; }
        public double cn_Ice_valor { get; set; }
        public double cn_Serv_por { get; set; }
        public double cn_Serv_valor { get; set; }
        public decimal cn_BaseSeguro { get; set; }
        public decimal cn_total { get; set; }
        public string cn_vaCoa { get; set; }
        public string cn_Autorizacion { get; set; }
        public string IdTipoServicio { get; set; }
        public string IdCtaCble_Acre { get; set; }
        public string IdCtaCble_IVA { get; set; }
        public string IdUsuario { get; set; }
        public DateTime Fecha_Transac { get; set; }
        public string Estado { get; set; }
        public string IdUsuarioUltMod { get; set; }
        public DateTime? Fecha_UltMod { get; set; }
        public string IdUsuarioUltAnu { get; set; }
        public string MotivoAnu { get; set; }
        public string nom_pc { get; set; }
        public string ip { get; set; }
        public DateTime? Fecha_UltAnu { get; set; }
        public decimal? IdCbteCble_Anulacion { get; set; }
        public int? IdTipoCbte_Anulacion { get; set; }
        public string cn_tipoLocacion { get; set; }
        public string nomProveedor { get; set; }
        public String IdCentroCosto { get; set; }
        public Nullable<decimal> IdSucursal { get; set; }
        public Nullable<decimal> IdTipoFlujo { get; set; }
        public string DebCre { get; set; }
        public Nullable<int> IdIden_credito { get; set; }
        public Nullable<double> Saldo { get; set; }
        public string cn_num_doc_modificado { get; set; }
        public string cod_nota { get; set; }
        public DateTime? fecha_autorizacion { get; set; }

        public string docModificado { get; set; }
        public string estabModificado { get; set; }
        public string ptoEmiModificado { get; set; }
        public string secModificado { get; set; }
        public string autModificado { get; set; }
        public string PagoLocExt { get; set; }
        public string PaisPago { get; set; }
        public string ConvenioTributacion { get; set; }
        public string PagoSujetoRetencion { get; set; }
        public cp_proveedor_Info InfoProveedor { get; set; }
        public string cn_NotaRpt { get; set; }
        public string IdTipoNota { get; set; }
        public string NombreTipoNota { get; set; } // campo adicional para poner un nombre mas descriptivo segun el campo IdTipoNota
        public DateTime? cn_Fecha_vcto { get; set; }
        public string cn_Autorizacion_Imprenta { get; set; }
        public ct_Cbtecble_Info Info_CbteCble_X_Nota { get; set; }
        public int IdClaseProveedor { get; set; }
        public string descripcion_clas_prove { get; set; }
        public bool Check { get; set; }
        public List<cp_nota_DebCre_Impuesto_Info> ListNotaCredImpuesto { get; set; }
        public List<cp_nota_DebCre_Aprobacion_Ing_Bod_x_OC_det_Info> ListAprobacionIngBodDet { get; set; }

        public cp_nota_DebCre_Info()
        {
            Info_CbteCble_X_Nota = new ct_Cbtecble_Info();
            InfoProveedor = new cp_proveedor_Info();
            ListNotaCredImpuesto = new List<cp_nota_DebCre_Impuesto_Info>();
            ListAprobacionIngBodDet = new List<cp_nota_DebCre_Aprobacion_Ing_Bod_x_OC_det_Info>();
        }
    }
}