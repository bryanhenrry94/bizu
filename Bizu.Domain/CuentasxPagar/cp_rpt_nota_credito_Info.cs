using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bizu.Domain.General;

namespace Bizu.Domain.CuentasxPagar
{
   public class cp_rpt_nota_credito_Info
    {
        
         
        public cp_proveedor_Info Proveedor { get; set; }
        public tb_Empresa_Info Empresa { get; set; }
        public cp_nota_DebCre_Info NotaCr { get; set; }
        public List<cp_orden_giro_pagos_Info> LstPagosOG { get; set; }
        public tb_persona_Info Persona { get; set; }






       public cp_rpt_nota_credito_Info() { }
    }
}
