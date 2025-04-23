using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bizu.Domain.Compras;

namespace Bizu.Domain.CuentasxPagar
{
  public  class cp_orden_giro_x_com_ordencompra_local_det_Info
    {
      public int IdEmpresa_Ogiro { get; set; }
      public decimal IdCbteCble_Ogiro { get; set; }     
      public int IdTipoCbte_Ogiro { get; set; }
      public int IdEmpresa_OC { get; set; }
      public int IdSucursal_OC { get; set; }
      public decimal IdOrdenCompra { get; set; }
      public int Secuencia_OC { get; set; }
      public string Observacion { get; set; }
      public int Secuencia_reg { get; set; }


      public decimal IdProducto { get; set; }
      public double do_Cantidad { get; set; }
      public double do_precioCompra { get; set; }
      public double do_porc_des { get; set; }
      public double do_descuento { get; set; }
      public double do_subtotal { get; set; }
      public double do_iva { get; set; }
      public double do_total { get; set; }
      public string IdUnidadMedida { get; set; }
      public string producto { get; set; }
      public string nom_medida { get; set; }
     
      //personalizacion Poligrup
      public Nullable<decimal> IdSolicitud { get; set; }
      public Nullable<decimal> ID_Departamento { get; set; }
      public string Nom_Departamento { get; set; }
      public Nullable<decimal> ID_Solicitante { get; set; }
      public string Nom_Solicitante { get; set; }

      //CLASE PERSONALIZADA POLIGRUP 
      public cp_orden_giro_x_com_ordencompra_local_det_Info_Solicitud info3 { get; set; }
                          
      public cp_orden_giro_x_com_ordencompra_local_det_Info(){
          info3 = new cp_orden_giro_x_com_ordencompra_local_det_Info_Solicitud();
      }
    }
}
