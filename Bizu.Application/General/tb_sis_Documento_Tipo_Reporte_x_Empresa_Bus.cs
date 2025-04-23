using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bizu.Infrastructure.General;
using Bizu.Domain.General;


namespace Bizu.Application.General
{
    public class tb_sis_Documento_Tipo_Reporte_x_Empresa_Bus
    {
        tb_sis_Documento_Tipo_Reporte_x_Empresa_Data dataDoc = new tb_sis_Documento_Tipo_Reporte_x_Empresa_Data();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;

        public Boolean GuardarDatos(tb_sis_Documento_Tipo_Reporte_x_Empresa_Info Info, ref string msjError)
        {
            try
            {
                Info.IdUsuario = param.IdUsuario;
                Info.IdUsuarioUltMod = param.IdUsuario;
                
                if (dataDoc.ValidarExistencia(Info.IdEmpresa, Info.codDocumentoTipo))
                    return dataDoc.GuardarDatos(Info, ref msjError);
                else
                    return dataDoc.ModificarDatos(Info, ref msjError);
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "GuardarDatos", ex.Message), ex) { EntityType = typeof(tb_sis_Documento_Tipo_Reporte_x_Empresa_Bus) };
           
            }
        }


        public tb_sis_Documento_Tipo_Reporte_x_Empresa_Info get_DisenioRpt(int IdEmpresa, string codDocumentoTipo)
        {
            try
            {
                return dataDoc.get_DisenioRpt(IdEmpresa, codDocumentoTipo);
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "get_DisenioRpt", ex.Message), ex) { EntityType = typeof(tb_sis_Documento_Tipo_Reporte_x_Empresa_Bus) };
           
            }
        }


        public tb_sis_Documento_Tipo_Reporte_x_Empresa_Bus()
        {

        }
    }
}
