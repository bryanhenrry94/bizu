using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bizu.Domain.Facturacion;

namespace Bizu.Infrastructure.Facturacion
{
    public class fa_notaCreDeb_det_x_in_Ing_Egr_Inven_det_Data
    {
        public bool Grabar(List<fa_notaCreDeb_det_x_in_Ing_Egr_Inven_det_Info> List, ref string msg)
        {
            try {
                using (EntitiesFacturacion Enti = new EntitiesFacturacion()) 
                { 
                    foreach(var item in List)
                    {
                        fa_notaCreDeb_det_x_in_Ing_Egr_Inven_det Adress = new fa_notaCreDeb_det_x_in_Ing_Egr_Inven_det();
                        Adress.no_IdEmpresa = item.no_IdEmpresa;
                        Adress.no_IdSucursal = item.no_IdSucursal;
                        Adress.no_IdBodega = item.no_IdBodega;
                        Adress.no_IdNota = item.no_IdNota;
                        Adress.no_Secuencia = item.no_Secuencia;
                        Adress.in_IdEmpresa = item.in_IdEmpresa;
                        Adress.in_IdSucursal = item.in_IdSucursal;
                        Adress.in_IdMovi_inven_tipo = item.in_IdMovi_inven_tipo;
                        Adress.in_IdNumMovi = item.in_IdNumMovi;
                        Adress.in_Secuencia = item.in_Secuencia;                        

                        Enti.fa_notaCreDeb_det_x_in_Ing_Egr_Inven_det.Add(Adress);
                        Enti.SaveChanges();
                    }                    
                }

                return true;
            }
            catch (Exception e) 
            {
                msg = e.Message;
                return false;
            }
            
        }

        public bool EliminarDB(int in_IdEmpresa, int in_IdSucursal, int in_IdMovi_inven_tipo, decimal in_IdNumMovi, ref string msg)
        {
            try
            {
                using (EntitiesFacturacion Contex = new EntitiesFacturacion())
                {
                    Contex.Database.ExecuteSqlCommand("delete from fa_notaCreDeb_det_x_in_Ing_Egr_Inven_det where in_IdEmpresa="
                          + in_IdEmpresa + " and in_IdSucursal= " + in_IdSucursal + " and in_IdMovi_inven_tipo = " 
                          + in_IdMovi_inven_tipo + " and in_IdNumMovi = " + in_IdNumMovi);
                   
                }

                return true;
            }
            catch (Exception e)
            {
                msg = e.Message;
                return false;
            }

        }
    }
}
