using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using Bizu.Application.General;

namespace Bizu.Application.General
{
    class cl_Control_De_Erro_Busr
    {

        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        string mensaje = "";

        public void VerificarCarpete()
        {
            try
            {
                string ruta = "C:\\LogError";

            if (!(Directory.Exists(ruta)))
            {
                string activeDir = @"c:\";
                string newPath = System.IO.Path.Combine(activeDir, "LogError");
                System.IO.Directory.CreateDirectory(newPath);

            }
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "Obtener_Bodegas", ex.Message), ex) { EntityType = typeof(cl_Control_De_Erro_Busr) };
         
            }
        }

        public Boolean capturalog(string msj, string transaccion)
        {
            try
            {
                string newFileName = System.IO.Path.GetRandomFileName();
            string fecha = DateTime.Now.Day.ToString() + DateTime.Now.Month.ToString() + DateTime.Now.Year.ToString() + DateTime.Now.Hour.ToString() + DateTime.Now.Minute.ToString() + DateTime.Now.Second.ToString();


            string activeDir = @"c:\";
            string newPath = System.IO.Path.Combine(activeDir, "LogError");
            string nameTEx = fecha + "_ERP.txt";
            newPath = System.IO.Path.Combine(newPath, nameTEx);
            string texto;
            VerificarCarpete();

            if (!System.IO.File.Exists(newPath))
            {
                using (System.IO.FileStream fs = System.IO.File.Create(newPath))
                {
                    string fic = @"c:\\LogError\\" + nameTEx;
                    texto = msj;
                    fs.Close();


                }

                System.IO.StreamWriter sw = new System.IO.StreamWriter(newPath);
                sw.WriteLine(transaccion);
                sw.WriteLine(msj);

                sw.Close();
            }

            return true;
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "Obtener_Bodegas", ex.Message), ex) { EntityType = typeof(cl_Control_De_Erro_Busr) };
         
            }
            
        }
    }
}
