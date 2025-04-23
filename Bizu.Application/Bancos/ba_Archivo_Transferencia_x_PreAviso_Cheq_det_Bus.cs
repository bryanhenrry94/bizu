using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Bizu.Infrastructure.Bancos;
using Bizu.Domain.Bancos;


namespace Bizu.Application.Bancos
{
  public  class ba_Archivo_Transferencia_x_PreAviso_Cheq_det_Bus
    {


        string mensaje = "";
        ba_Archivo_Transferencia_x_PreAviso_Cheq_det_Data Odata = new ba_Archivo_Transferencia_x_PreAviso_Cheq_det_Data();


        public List<ba_Archivo_Transferencia_x_PreAviso_Cheq_det_Info> Get_List_Archivo_Transferencia_x_PreAviso_Cheq_det(int idEmpresa, decimal idArchivo)
        {
            try
            {
                List<ba_Archivo_Transferencia_x_PreAviso_Cheq_det_Info> Lista = new List<ba_Archivo_Transferencia_x_PreAviso_Cheq_det_Info>();

                Lista=Odata.Get_List_Archivo_Transferencia_x_PreAviso_Cheq_det(idEmpresa, idArchivo);
              
                return Lista;
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "Get_List_Archivo_transferencia_Det", ex.Message), ex) { EntityType = typeof(ba_Archivo_Transferencia_Det_Bus) };
            }
        }

        public bool GrabarDB(List<ba_Archivo_Transferencia_x_PreAviso_Cheq_det_Info> Lista)
        {
            try
            {
                return Odata.GrabarDB(Lista);
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "Get_List_Archivo_transferencia_Det", ex.Message), ex) { EntityType = typeof(ba_Archivo_Transferencia_Det_Bus) };
            }
        }

        public bool AnularDB(List<ba_Archivo_Transferencia_x_PreAviso_Cheq_det_Info> lista)
        {
            try
            {
                return Odata.AnularDB(lista);
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "Get_List_Archivo_transferencia_Det", ex.Message), ex) { EntityType = typeof(ba_Archivo_Transferencia_Det_Bus) };
            }
        }

        public Boolean Actualizar_registro(ba_Archivo_Transferencia_x_PreAviso_Cheq_det_Info Info)
        {
            try
            {
                return Odata.Actualizar_registro(Info);
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "Get_List_Archivo_transferencia_Det", ex.Message), ex) { EntityType = typeof(ba_Archivo_Transferencia_Det_Bus) };
            }
        }


    }
}
