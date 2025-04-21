using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Info.Facturacion;

namespace Core.Erp.Data.Facturacion
{
    public class fa_notaCreDeb_x_in_Ing_Egr_Inven_Data
    {
        public bool Grabar(List<fa_notaCreDeb_x_in_Ing_Egr_Inven_Info> List, ref string msg)
        {
            try
            {
                using (EntitiesFacturacion Enti = new EntitiesFacturacion())
                {
                    foreach (var item in List)
                    {
                        fa_notaCreDeb_x_in_Ing_Egr_Inven Adress = new fa_notaCreDeb_x_in_Ing_Egr_Inven();
                        Adress.no_IdEmpresa = item.no_IdEmpresa;
                        Adress.no_IdSucursal = item.no_IdSucursal;
                        Adress.no_IdBodega = item.no_IdBodega;
                        Adress.no_IdNota = item.no_IdNota;                        
                        Adress.in_IdEmpresa = item.in_IdEmpresa;
                        Adress.in_IdSucursal = item.in_IdSucursal;
                        Adress.in_IdMovi_inven_tipo = item.in_IdMovi_inven_tipo;
                        Adress.in_IdNumMovi = item.in_IdNumMovi;                        

                        Enti.fa_notaCreDeb_x_in_Ing_Egr_Inven.Add(Adress);
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

        public List<fa_notaCreDeb_x_in_Ing_Egr_Inven_Info> Get_List(int Inv_IdEmpresa, int Inv_IdSucursal,
            int Inv_IdMovi_inven_tipo, decimal Inv_IdNumMovi, ref string msg)
        {
            try
            {
                List<fa_notaCreDeb_x_in_Ing_Egr_Inven_Info> Lista = new List<fa_notaCreDeb_x_in_Ing_Egr_Inven_Info>();

                using (EntitiesFacturacion Enti = new EntitiesFacturacion())
                {
                    var select = from q in Enti.fa_notaCreDeb_x_in_Ing_Egr_Inven
                                 where q.in_IdEmpresa == Inv_IdEmpresa 
                                 && q.in_IdSucursal == Inv_IdSucursal 
                                 && q.in_IdMovi_inven_tipo == Inv_IdMovi_inven_tipo
                                 && q.in_IdNumMovi == Inv_IdNumMovi
                                 select q;

                    foreach (var item in select)
                    {
                        fa_notaCreDeb_x_in_Ing_Egr_Inven_Info Info = new fa_notaCreDeb_x_in_Ing_Egr_Inven_Info();
                        Info.no_IdEmpresa = item.no_IdEmpresa;
                        Info.no_IdSucursal = item.no_IdSucursal;
                        Info.no_IdBodega = item.no_IdBodega;
                        Info.no_IdNota = item.no_IdNota;
                        Info.in_IdEmpresa = item.in_IdEmpresa;
                        Info.in_IdSucursal = item.in_IdSucursal;
                        Info.in_IdMovi_inven_tipo = item.in_IdMovi_inven_tipo;
                        Info.in_IdNumMovi = item.in_IdNumMovi;

                        Lista.Add(Info);
                    }
                }

                return Lista;
            }
            catch (Exception e)
            {
                msg = e.Message;
                return new List<fa_notaCreDeb_x_in_Ing_Egr_Inven_Info>();
            }
        }
    }
}
