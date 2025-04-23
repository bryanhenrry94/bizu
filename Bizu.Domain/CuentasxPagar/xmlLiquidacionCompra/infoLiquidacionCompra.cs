using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Bizu.Domain.CuentasxPagar.xmlLiquidacionCompra
{
    /// <comentarios/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]

    public partial class infoLiquidacionCompra
    {
        private string fechaEmisionField;

        private string dirEstablecimientoField;

        private string contribuyenteEspecialField;

        private obligadoContabilidad obligadoContabilidadField;

        private bool obligadoContabilidadFieldSpecified;

        private string comercioExteriorField;

        private string tipoIdentificacionProveedorField;

        private string razonSocialProveedorField;

        private string identificacionProveedorField;

        private string direccionProveedorField;

        private decimal totalSinImpuestosField;

        private decimal totalDescuentoField;

        private string codDocReembolsoField;

        private decimal totalComprobantesReembolsoField;

        private bool totalComprobantesReembolsoFieldSpecified;

        private decimal totalBaseImponibleReembolsoField;

        private bool totalBaseImponibleReembolsoFieldSpecified;

        private decimal totalImpuestoReembolsoField;

        private bool totalImpuestoReembolsoFieldSpecified;

        private List<totalConImpuestos> totalConImpuestosField;

        private decimal importeTotalField;

        private string monedaField;

        private List<pagosPago> pagosField;

        /// <comentarios/>
        public string fechaEmision
        {
            get
            {
                return this.fechaEmisionField;
            }
            set
            {
                this.fechaEmisionField = value;
            }
        }

        /// <comentarios/>
        public string dirEstablecimiento
        {
            get
            {
                return this.dirEstablecimientoField;
            }
            set
            {
                this.dirEstablecimientoField = value;
            }
        }

        /// <comentarios/>
        public string contribuyenteEspecial
        {
            get
            {
                return this.contribuyenteEspecialField;
            }
            set
            {
                this.contribuyenteEspecialField = value;
            }
        }

        ///// <comentarios/>
        //public obligadoContabilidad obligadoContabilidad
        //{
        //    get
        //    {
        //        return this.obligadoContabilidadField;
        //    }
        //    set
        //    {
        //        this.obligadoContabilidadField = value;
        //    }
        //}

        /// <comentarios/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool obligadoContabilidadSpecified
        {
            get
            {
                return this.obligadoContabilidadFieldSpecified;
            }
            set
            {
                this.obligadoContabilidadFieldSpecified = value;
            }
        }

        /// <comentarios/>
        public string tipoIdentificacionProveedor
        {
            get
            {
                return this.tipoIdentificacionProveedorField;
            }
            set
            {
                this.tipoIdentificacionProveedorField = value;
            }
        }

        /// <comentarios/>
        public string razonSocialProveedor
        {
            get
            {
                return this.razonSocialProveedorField;
            }
            set
            {
                this.razonSocialProveedorField = value;
            }
        }

        /// <comentarios/>
        public string identificacionProveedor
        {
            get
            {
                return this.identificacionProveedorField;
            }
            set
            {
                this.identificacionProveedorField = value;
            }
        }

        /// <comentarios/>
        public string direccionProveedor
        {
            get
            {
                return this.direccionProveedorField;
            }
            set
            {
                this.direccionProveedorField = value;
            }
        }

        /// <comentarios/>
        public decimal totalSinImpuestos
        {
            get
            {
                return this.totalSinImpuestosField;
            }
            set
            {
                this.totalSinImpuestosField = value;
            }
        }
        
        /// <comentarios/>
        public decimal totalDescuento
        {
            get
            {
                return this.totalDescuentoField;
            }
            set
            {
                this.totalDescuentoField = value;
            }
        }

        /// <comentarios/>
        public string codDocReembolso
        {
            get
            {
                return this.codDocReembolsoField;
            }
            set
            {
                this.codDocReembolsoField = value;
            }
        }

        /// <comentarios/>
        public decimal totalComprobantesReembolso
        {
            get
            {
                return this.totalComprobantesReembolsoField;
            }
            set
            {
                this.totalComprobantesReembolsoField = value;
            }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool totalComprobantesReembolsoSpecified
        {
            get
            {
                return this.totalComprobantesReembolsoFieldSpecified;
            }
            set
            {
                this.totalComprobantesReembolsoFieldSpecified = value;
            }
        }

        /// <comentarios/>
        public decimal totalBaseImponibleReembolso
        {
            get
            {
                return this.totalBaseImponibleReembolsoField;
            }
            set
            {
                this.totalBaseImponibleReembolsoField = value;
            }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool totalBaseImponibleReembolsoSpecified
        {
            get
            {
                return this.totalBaseImponibleReembolsoFieldSpecified;
            }
            set
            {
                this.totalBaseImponibleReembolsoFieldSpecified = value;
            }
        }

        /// <comentarios/>
        public decimal totalImpuestoReembolso
        {
            get
            {
                return this.totalImpuestoReembolsoField;
            }
            set
            {
                this.totalImpuestoReembolsoField = value;
            }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool totalImpuestoReembolsoSpecified
        {
            get
            {
                return this.totalImpuestoReembolsoFieldSpecified;
            }
            set
            {
                this.totalImpuestoReembolsoFieldSpecified = value;
            }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlArrayItemAttribute("totalImpuesto", IsNullable = false)]
        public List<totalConImpuestos> totalConImpuestos
        {
            get
            {
                return this.totalConImpuestosField;
            }
            set
            {
                this.totalConImpuestosField = value;
            }
        }        

        /// <comentarios/>
        public decimal importeTotal
        {
            get
            {
                return this.importeTotalField;
            }
            set
            {
                this.importeTotalField = value;
            }
        }

        /// <comentarios/>
        public string moneda
        {
            get
            {
                return this.monedaField;
            }
            set
            {
                this.monedaField = value;
            }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlArrayItemAttribute("pago", IsNullable = false)]
        public List<pagosPago> pagos
        {
            get
            {
                return this.pagosField;
            }
            set
            {
                this.pagosField = value;
            }
        }

        /// <comentarios/>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
        [System.SerializableAttribute()]
        public enum obligadoContabilidad
        {

            /// <comentarios/>
            SI,

            /// <comentarios/>
            NO,
        }
    }
}
