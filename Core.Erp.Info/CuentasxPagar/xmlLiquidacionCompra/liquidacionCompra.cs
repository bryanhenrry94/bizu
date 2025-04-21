using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Core.Erp.Info.CuentasxPagar.xmlLiquidacionCompra
{
    /// <comentarios/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]

    public partial class liquidacionCompra
    {
        private infoTributaria infoTributariaField;

        private infoLiquidacionCompra infoLiquidacionCompraField;

        private List<detalle> detallesField;

        private List<reembolsoDetalle> reembolsosField;

        private List<infoAdicional> infoAdicionalField;

        private liquidacionCompraID idField;

        private bool idFieldSpecified;

        private string versionField;

        /// <comentarios/>
        public infoTributaria infoTributaria
        {
            get
            {
                return this.infoTributariaField;
            }
            set
            {
                this.infoTributariaField = value;
            }
        }

        /// <comentarios/>
        public infoLiquidacionCompra infoLiquidacionCompra
        {
            get
            {
                return this.infoLiquidacionCompraField;
            }
            set
            {
                this.infoLiquidacionCompraField = value;
            }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlArrayItemAttribute("detalle", IsNullable = false)]
        public List<detalle> detalles
        {
            get
            {
                return this.detallesField;
            }
            set
            {
                this.detallesField = value;
            }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlArrayItemAttribute("reembolsoDetalle", IsNullable = false)]
        public List<reembolsoDetalle> reembolsos
        {
            get
            {
                return this.reembolsosField;
            }
            set
            {
                this.reembolsosField = value;
            }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlArrayItemAttribute("campoAdicional", IsNullable = false)]
        public List<infoAdicional> infoAdicional
        {
            get
            {
                return this.infoAdicionalField;
            }
            set
            {
                this.infoAdicionalField = value;
            }
        }

        /// <comentarios/>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
        [System.SerializableAttribute()]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public enum liquidacionCompraID
        {
            /// <comentarios/>
            comprobante,
        }       

        /// <comentarios/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public liquidacionCompraID id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool idSpecified
        {
            get
            {
                return this.idFieldSpecified;
            }
            set
            {
                this.idFieldSpecified = value;
            }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string version
        {
            get
            {
                return this.versionField;
            }
            set
            {
                this.versionField = value;
            }
        }
    }
}
