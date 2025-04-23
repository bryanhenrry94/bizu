using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bizu.Domain.General;
using Bizu.Domain.CuentasxPagar.Archivos_Pagos_Bancos;

namespace Bizu.Application.CuentasxPagar.Archivos_Bancos
{
    public class cp_Archivo_Banco_Produbanco_pago_proveedores_Bus
    {
        public Boolean Guardar_Archivo_Banco_Produbanco(Archivo_Banco_Produbanco_pago_proveedores_Info info, tb_banco_procesos_bancarios_x_empresa_Info Info_proceso, string patch, string nombre_file)
        {
            try
            {
                if (Validar_Linea_archivo_BP(info))
                {
                    switch (Info_proceso.cod_Proceso)
                    {
                        case ebanco_procesos_bancarios_tipo.PAGO_PROVEEDORES_PRODU:// pago a proveedores banco produbanco
                            Generar_archivo_pago_proveedores_BP(info, patch, "\t", nombre_file);
                            break;
                        default:
                            break;
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "Generar_archivo", ex.Message), ex) { EntityType = typeof(cp_Archivo_Banco_Bolivariano_pago_proveedores_Bus) };
            }
        }

        public bool Validar_Linea_archivo_BP(Archivo_Banco_Produbanco_pago_proveedores_Info info_)
        {
            try
            {
                info_.PagTer_nombreBeneficiario = info_.PagTer_nombreBeneficiario.Replace('Ñ', 'N').Replace('ñ', 'n');

                return true;
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "Generar_archivo", ex.Message), ex) { EntityType = typeof(cp_Archivo_Banco_Bolivariano_pago_proveedores_Bus) };
            }
        }

        public Boolean Generar_archivo_pago_proveedores_BP(Archivo_Banco_Produbanco_pago_proveedores_Info info, string patch, string carSeparador, string nombre_File)
        {
            try
            {
                string linea = "";
                linea += info.PagTer_codigoOrientacion + carSeparador;
                linea += info.PagTer_cuentaEmpresa + carSeparador;
                linea += info.PagTer_secuencial.PadLeft(7, '0') + carSeparador;
                linea += info.PagTer_comprobantePago + carSeparador;
                linea += info.PagTer_contrapartida + carSeparador;
                linea += info.PagTer_moneda + carSeparador;
                linea += info.PagTer_valor + carSeparador;
                linea += info.PagTer_formaPago + carSeparador;
                linea += info.PagTer_codigoBanco.PadRight(2, ' ') + carSeparador;
                linea += info.PagTer_tipoCuenta.PadRight(2, ' ') + carSeparador;
                linea += info.PagTer_numeroCuenta + carSeparador;
                linea += info.PagTer_tipoIDCliente.PadRight(1, ' ') + carSeparador;
                linea += info.PagTer_numeroIDCliente.PadRight(14, ' ') + carSeparador;
                linea += info.PagTer_nombreBeneficiario.Length > 40 ? info.PagTer_nombreBeneficiario.Substring(0, 40) + carSeparador : info.PagTer_nombreBeneficiario + carSeparador;

                //if (!string.IsNullOrEmpty(info.PagTer_direccionBeneficiario)) 
                linea += info.PagTer_direccionBeneficiario + carSeparador; //OPCIONAL

                //if (!string.IsNullOrEmpty(info.PagTer_ciudadBeneficiario)) 
                linea += info.PagTer_ciudadBeneficiario + carSeparador; //OPCIONAL

                //if (!string.IsNullOrEmpty(info.PagTer_telefonoBeneficiario)) 
                linea += info.PagTer_telefonoBeneficiario + carSeparador; //OPCIONAL

                //if (!string.IsNullOrEmpty(info.PagTer_localidadBeneficiario)) 
                linea += info.PagTer_localidadBeneficiario + carSeparador; //OPCIONAL

                linea += info.PagTer_referencia + carSeparador;

                //if (!string.IsNullOrEmpty(info.PagTer_referenciaAdicional)) 
                linea += info.PagTer_referenciaAdicional + carSeparador; //OPCIONAL

                using (System.IO.StreamWriter file = new System.IO.StreamWriter(patch + nombre_File + ".txt", true))
                {
                    file.WriteLine(linea);
                    file.Close();
                }

                return true;
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "Generar_archivo_pago_proveedores_BP", ex.Message), ex) { EntityType = typeof(cp_Archivo_Banco_Bolivariano_pago_proveedores_Bus) };
            }
        }
    }
}