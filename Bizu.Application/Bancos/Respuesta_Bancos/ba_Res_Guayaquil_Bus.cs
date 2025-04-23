using Bizu.Application.General;
using Bizu.Infrastructure.Bancos.Respuesta_Bancos;
using Bizu.Domain.Bancos;
using Bizu.Domain.Bancos.Respuesta_Bancos;
using Bizu.Domain.General;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bizu.Application.Bancos.Respuesta_Bancos
{
    public class ba_Res_Guayaquil_Bus
    {
        ba_Res_Guayaquil_Data oData = new ba_Res_Guayaquil_Data();
        List<tb_banco_estado_reg__resp_bancaria_Info> List_Estados_x_banco = new List<tb_banco_estado_reg__resp_bancaria_Info>();
        tb_banco_estado_reg__resp_bancaria_Bus bus_Estados_x_banco = new tb_banco_estado_reg__resp_bancaria_Bus();

        public List<ba_Archivo_Transferencia_Det_Info> Get_Res_Guayaquil(ba_Archivo_Transferencia_Info Archivo ,string Ruta, ref string Id_Orden_Bancaria)
        {
            try
            {

                List<ba_Res_Guayaquil_Info> List_Guayaquil = oData.Get_Res_Guayaquil(Ruta,ref Id_Orden_Bancaria);

                List_Estados_x_banco = bus_Estados_x_banco.Get_Lista_Estados();

                List<ba_Archivo_Transferencia_Det_Info> List_Archivo_Det = new List<ba_Archivo_Transferencia_Det_Info>();
                foreach (var item in List_Guayaquil)
                {
                    ba_Archivo_Transferencia_Det_Info info = new ba_Archivo_Transferencia_Det_Info();

                    info.Id_Item = item.Id_Item;
                    info.Fecha_Proceso = Convert.ToDateTime(item.Fecha_Proceso);
                    info.num_cta_acreditacion = item.Cuenta;
                    info.pe_cedulaRuc = item.Num_Identificacion;
                    info.pe_nombreCompleto = item.Referencia;
                    info.Valor_Enviado =Convert.ToDecimal(item.Valor_Enviado);
                    info.Valor = info.Valor_Enviado;
                    info.Valor_cobrado = info.Valor_procesado;
                    info.Valor_procesado = Convert.ToDecimal(item.Valor_Procesado);
                    info.Saldo = info.Valor_Enviado - info.Valor_procesado;
                   

                    info.nom_EstadoRegistro = item.Estado;
                    info.IdEstadoRegistro_cat = List_Estados_x_banco.FirstOrDefault(q=>q.IdEstado_Reg_Bancario==info.nom_EstadoRegistro).IdEstado_Reg_cat.Trim();
                    info.Genera_anulacion = List_Estados_x_banco.FirstOrDefault(q => q.IdEstado_Reg_Bancario == info.nom_EstadoRegistro).Genera_anulacion;

                    info.IdArchivo = Archivo.IdArchivo;
                    info.IdEmpresa = Archivo.IdEmpresa;

                    List_Archivo_Det.Add(info);
                }

                return List_Archivo_Det;
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "Get_Res_Guayaquil", ex.Message), ex) { EntityType = typeof(ba_Res_Guayaquil_Bus) };

            }
        }
    }
}
