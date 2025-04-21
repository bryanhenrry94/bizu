using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Info.Inventario;
using Core.Erp.Data.Inventario;
using Core.Erp.Info.class_sri.GuiaRemision;
using Core.Erp.Info.class_sri;
using System.Xml.Serialization;
using System.IO;
using System.Data;
using Core.Erp.Info.General;
using Core.Erp.Info.class_sri.FacturaV2;
using Core.Erp.Business.General; 
using Core.Erp.Info.Facturacion;
using Core.Erp.Business.Facturacion;
using Core.Erp.Data.General;

namespace Core.Erp.Business.Inventario
{
    public class in_GuiaRemision_Bus
    {
        in_GuiaRemision_Data Data = new in_GuiaRemision_Data();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;

        public Boolean GrabarDB(in_GuiaRemision_Info Info_GuiaRemision, ref string ms)
        {
            try
            {
                tb_sis_Documento_Tipo_Talonario_Data Data_sisDocTipoTalo = new tb_sis_Documento_Tipo_Talonario_Data();
                tb_sis_Documento_Tipo_Talonario_Info Info_sisDocTipoTalo = new tb_sis_Documento_Tipo_Talonario_Info();
                in_GuiaRemision_Det_Data Data_det = new in_GuiaRemision_Det_Data();
                in_GuiaRemision_Exportacion_Data Data_GuiaExportacion = new in_GuiaRemision_Exportacion_Data();               

                int Secuencia = 0;

                if (Info_GuiaRemision != null)
                {
                    if (string.IsNullOrEmpty(Info_GuiaRemision.Serie1) || string.IsNullOrEmpty(Info_GuiaRemision.Serie2) || string.IsNullOrEmpty(Info_GuiaRemision.NumDocumento))
                    {
                        ms = "Verifique que la Guia tenga una secuencia de talonario impresa o electronica registrada!";
                        return false;
                    }

                    Info_sisDocTipoTalo.IdEmpresa = Info_GuiaRemision.IdEmpresa;
                    Info_sisDocTipoTalo.CodDocumentoTipo = "GUIA";
                    Info_sisDocTipoTalo.Establecimiento = Info_GuiaRemision.Serie1;
                    Info_sisDocTipoTalo.PuntoEmision = Info_GuiaRemision.Serie2;
                    Info_sisDocTipoTalo.NumDocumento = Info_GuiaRemision.NumDocumento;

                    if (Data_sisDocTipoTalo.Documento_talonario_esta_Usado(Info_sisDocTipoTalo, ref ms, ref ms))
                    {
                        Info_sisDocTipoTalo = Data_sisDocTipoTalo.Get_Info_Documento_Tipo_Talonario(Info_sisDocTipoTalo.IdEmpresa, Info_sisDocTipoTalo.CodDocumentoTipo, Info_sisDocTipoTalo.Establecimiento, Info_sisDocTipoTalo.PuntoEmision, Info_sisDocTipoTalo.NumDocumento);

                        tb_sis_Documento_Tipo_Talonario_Info Info_sisDocTipoTalo_new = Data_sisDocTipoTalo.Get_Info_Primer_Documento_no_usado(Info_sisDocTipoTalo.IdEmpresa, Info_sisDocTipoTalo.Establecimiento, Info_sisDocTipoTalo.PuntoEmision, Info_sisDocTipoTalo.CodDocumentoTipo, true, true);

                        if (Info_sisDocTipoTalo_new != null)
                        {
                            Info_GuiaRemision.Serie1 = Info_sisDocTipoTalo_new.Establecimiento;
                            Info_GuiaRemision.Serie2 = Info_sisDocTipoTalo_new.PuntoEmision;
                            Info_GuiaRemision.NumDocumento = Info_sisDocTipoTalo_new.NumDocumento;
                        }
                    }
                }


                if (Data.GrabarDB(Info_GuiaRemision, ref ms))
                {
                    foreach (var item in Info_GuiaRemision.in_GuiaRemision_Det)
                    {
                        item.IdEmpresa = Info_GuiaRemision.IdEmpresa;
                        item.IdSucursal = Info_GuiaRemision.IdSucursal;
                        item.IdGuiaRemision = Info_GuiaRemision.IdGuiaRemision;
                        Secuencia += 1;
                        item.Secuencia = Secuencia;
                    }
                    
                    in_Parametro_Bus Bus_Parametro = new in_Parametro_Bus();
                    in_Parametro_Info Info_Parametro = new in_Parametro_Info();

                    Info_Parametro = Bus_Parametro.Get_Info_Parametro(Info_GuiaRemision.IdEmpresa);

                    if (Convert.ToBoolean(Info_Parametro.Genera_Mov_Inv_x_GuiaRemision)) ;
                    {
                        if (Generar_Movi_Inven_x_GuiaRemision(ref Info_GuiaRemision, Convert.ToInt16(Info_Parametro.IdMovi_Inven_tipo_x_GuiaRemision), Convert.ToInt16(Info_Parametro.IdMotivo_Inv_x_GuiaRemision), ref ms))
                        {

                        }
                    }
                }
            }

            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return true;
        }

        private bool Generar_Movi_Inven_x_GuiaRemision(ref in_GuiaRemision_Info Info_GuiaRemision, int IdMovi_Inven_tipo_x_GuiaRemision, int IdMotivo_Inv_x_GuiaRemision, ref string mensaje)
        {
            try
            {
                decimal IdNumMovi = 0;

                in_Ing_Egr_Inven_Bus Bus_Ing_Egr = new in_Ing_Egr_Inven_Bus();
                in_Ing_Egr_Inven_Info Info_Ing_Egr = new in_Ing_Egr_Inven_Info();

                //CABECERA
                #region
                Info_Ing_Egr.IdEmpresa = Info_GuiaRemision.IdEmpresa;
                Info_Ing_Egr.IdSucursal = Info_GuiaRemision.IdSucursal;
                Info_Ing_Egr.IdMovi_inven_tipo = IdMovi_Inven_tipo_x_GuiaRemision;
                Info_Ing_Egr.IdNumMovi = 0;
                Info_Ing_Egr.IdBodega = Info_GuiaRemision.IdBodega;
                Info_Ing_Egr.signo = "-";
                Info_Ing_Egr.CodMoviInven = "";
                Info_Ing_Egr.cm_observacion = "Egreso automático GR#" + Info_GuiaRemision.Serie1 + "-" + Info_GuiaRemision.Serie2 + "-" + Info_GuiaRemision.NumDocumento;
                Info_Ing_Egr.cm_fecha = DateTime.Now;
                Info_Ing_Egr.IdUsuario = param.IdUsuario;
                Info_Ing_Egr.Estado = "A";
                Info_Ing_Egr.IdCentroCosto = Info_GuiaRemision.IdCentroCosto;
                Info_Ing_Egr.IdCentroCosto_sub_centro_costo = null;
                Info_Ing_Egr.MotivoAnulacion = "";
                Info_Ing_Egr.IdMotivo_oc = null;
                Info_Ing_Egr.Fecha_Transac = DateTime.Now;
                Info_Ing_Egr.nom_pc = param.nom_pc;
                Info_Ing_Egr.ip = param.ip;
                Info_Ing_Egr.IdMotivo_Inv = IdMotivo_Inv_x_GuiaRemision;

                #endregion
                
                //DETALLE
                #region
                Info_Ing_Egr.listIng_Egr = new List<in_Ing_Egr_Inven_det_Info>();

                foreach (var item in Info_GuiaRemision.in_GuiaRemision_Det)
                {
                    in_Ing_Egr_Inven_det_Info Info_Det = new in_Ing_Egr_Inven_det_Info();
                    Info_Det.IdEmpresa = item.IdEmpresa;
                    Info_Det.IdSucursal = item.IdSucursal;
                    Info_Det.IdMovi_inven_tipo = Info_Ing_Egr.IdMovi_inven_tipo;
                    Info_Det.IdNumMovi = Info_Ing_Egr.IdNumMovi;
                    Info_Det.Secuencia = 0;
                    Info_Det.IdBodega = Info_Ing_Egr.IdBodega;
                    Info_Det.IdProducto = Convert.ToDecimal(item.IdProducto);
                    Info_Det.dm_cantidad = Convert.ToDouble(item.Cantidad);
                    Info_Det.dm_observacion = Info_Ing_Egr.cm_observacion;
                    Info_Det.dm_peso = Convert.ToDouble(item.Peso);
                    Info_Det.IdCentroCosto = item.IdCentroCosto;
                    Info_Det.IdUnidadMedida = item.IdUnidadMedida;
                    Info_Det.dm_cantidad_sinConversion = Convert.ToDouble(item.Cantidad_sinConversion);
                    Info_Det.IdUnidadMedida_sinConversion = item.IdUnidadMedida_sinConversion;
                    Info_Det.IdMotivo_Inv = Info_Ing_Egr.IdMotivo_Inv;
                    Info_Det.Lote = item.Lote;                 
                    Info_Ing_Egr.listIng_Egr.Add(Info_Det);
                }

                #endregion

                if (!Bus_Ing_Egr.GuardarDB(Info_Ing_Egr, ref IdNumMovi, ref mensaje))
                {
                    return false;
                }

                //REGISTRAMOS MOVI X GUIA REMISION
                in_Ing_Egr_Inven_x_in_GuiaRemision_Bus Bus_Ing_Egr_x_GuiaRemision = new in_Ing_Egr_Inven_x_in_GuiaRemision_Bus();
                in_Ing_Egr_Inven_x_in_GuiaRemision_Info Info_Ing_Egr_x_GuiaRemision = new in_Ing_Egr_Inven_x_in_GuiaRemision_Info();

                Info_Ing_Egr_x_GuiaRemision.IdEmpresa = Info_Ing_Egr.IdEmpresa;
                Info_Ing_Egr_x_GuiaRemision.IdSucursal = Info_Ing_Egr.IdSucursal;
                Info_Ing_Egr_x_GuiaRemision.IdMovi_inven_tipo = Info_Ing_Egr.IdMovi_inven_tipo;
                Info_Ing_Egr_x_GuiaRemision.IdNumMovi = Info_Ing_Egr.IdNumMovi;
                Info_Ing_Egr_x_GuiaRemision.IdGuiaRemision = Info_GuiaRemision.IdGuiaRemision;

                if (!Bus_Ing_Egr_x_GuiaRemision.Grabar(Info_Ing_Egr_x_GuiaRemision, ref mensaje))
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                mensaje = ex.Message;
                throw new Exception(ex.Message);
            }

            return true;
        }

        public Boolean ModificarDB(in_GuiaRemision_Info Info_GuiaRemision, ref string ms)
        {
            try
            {
                in_GuiaRemision_Det_Data Data_det = new in_GuiaRemision_Det_Data();
                in_GuiaRemision_Exportacion_Data Data_GuiaExportacion = new in_GuiaRemision_Exportacion_Data();

                int Secuencia = 0;

                if (Data.ModificarDB(Info_GuiaRemision, ref ms))
                {
                    foreach (var item in Info_GuiaRemision.in_GuiaRemision_Det)
                    {
                        item.IdEmpresa = Info_GuiaRemision.IdEmpresa;
                        item.IdSucursal = Info_GuiaRemision.IdSucursal;
                        item.IdGuiaRemision = Info_GuiaRemision.IdGuiaRemision;
                        Secuencia += 1;
                        item.Secuencia = Secuencia;
                    }

                    if (Data_det.Eliminar(Info_GuiaRemision.IdEmpresa, Info_GuiaRemision.IdSucursal, Info_GuiaRemision.IdGuiaRemision))
                    {
                        if (Data_det.Grabar(Info_GuiaRemision.in_GuiaRemision_Det))
                        {
                           
                        }
                    }
                }

                if (Data_GuiaExportacion.Existe(Info_GuiaRemision.IdEmpresa, Info_GuiaRemision.IdSucursal, Info_GuiaRemision.IdGuiaRemision))
                {
                    if (Data_GuiaExportacion.EliminarDB(Info_GuiaRemision.IdEmpresa, Info_GuiaRemision.IdSucursal, Info_GuiaRemision.IdGuiaRemision))
                    {
                        if (Info_GuiaRemision.in_GuiaRemision_Exportacion != null)
                        {
                            Data_GuiaExportacion.GrabarDB(Info_GuiaRemision.in_GuiaRemision_Exportacion);
                        }
                    }
                }
                else
                {
                    if (Info_GuiaRemision.in_GuiaRemision_Exportacion != null)
                    {
                        Info_GuiaRemision.in_GuiaRemision_Exportacion.IdEmpresa = Info_GuiaRemision.IdEmpresa;
                        Info_GuiaRemision.in_GuiaRemision_Exportacion.IdSucursal = Info_GuiaRemision.IdSucursal;
                        Info_GuiaRemision.in_GuiaRemision_Exportacion.IdGuiaRemision = Info_GuiaRemision.IdGuiaRemision;

                        Data_GuiaExportacion.GrabarDB(Info_GuiaRemision.in_GuiaRemision_Exportacion);
                    }
                }

                //GRABAMOS MOVI X GUIA REMISION
                in_Ing_Egr_Inven_x_in_GuiaRemision_Bus Bus_Ing_Egr_x_GuiaRemision = new in_Ing_Egr_Inven_x_in_GuiaRemision_Bus();

                if (!Bus_Ing_Egr_x_GuiaRemision.Existe(Info_GuiaRemision.IdEmpresa, Info_GuiaRemision.IdSucursal, Info_GuiaRemision.IdGuiaRemision))
                {
                    in_Parametro_Bus Bus_Parametro = new in_Parametro_Bus();
                    in_Parametro_Info Info_Parametro = new in_Parametro_Info();

                    Info_Parametro = Bus_Parametro.Get_Info_Parametro(Info_GuiaRemision.IdEmpresa);

                    if (Convert.ToBoolean(Info_Parametro.Genera_Mov_Inv_x_GuiaRemision)) ;
                    {
                        if (Generar_Movi_Inven_x_GuiaRemision(ref Info_GuiaRemision, Convert.ToInt16(Info_Parametro.IdMovi_Inven_tipo_x_GuiaRemision), Convert.ToInt16(Info_Parametro.IdMotivo_Inv_x_GuiaRemision), ref ms))
                        {

                        }
                    }
                }               
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return true;
        }

        public Boolean Modificar_Estado_Cierre(int IdEmpresa, int IdSucursal, decimal IdGuiaRemision, string Estado_cierre)
        {
            try
            {
                return Data.Modificar_Estado_Cierre(IdEmpresa, IdSucursal, IdGuiaRemision, Estado_cierre);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Boolean Anular(in_GuiaRemision_Info Info_GuiaRemision, ref string ms)
        {
            try
            {
                if (Data.Anular(Info_GuiaRemision, ref ms))
                {
                    ms = "Registro anulado con éxito!!";

                    in_Ing_Egr_Inven_x_in_GuiaRemision_Bus Bus_Inv_x_GuiaRemision = new in_Ing_Egr_Inven_x_in_GuiaRemision_Bus();

                    if (Bus_Inv_x_GuiaRemision.Existe(Info_GuiaRemision.IdEmpresa, Info_GuiaRemision.IdSucursal, Info_GuiaRemision.IdGuiaRemision))
                    {
                        in_Ing_Egr_Inven_x_in_GuiaRemision_Info Info_Inv_x_GuiaRemision = new in_Ing_Egr_Inven_x_in_GuiaRemision_Info();

                        Info_Inv_x_GuiaRemision = Bus_Inv_x_GuiaRemision.Get(Info_GuiaRemision.IdEmpresa, Info_GuiaRemision.IdSucursal, Info_GuiaRemision.IdGuiaRemision);

                        in_Ing_Egr_Inven_Info info_IngEgr = new in_Ing_Egr_Inven_Info();
                        in_Ing_Egr_Inven_Bus Bus_Ing_Egr = new in_Ing_Egr_Inven_Bus();

                        info_IngEgr = Bus_Ing_Egr.Get_Info_Ing_Egr_Inven(Info_Inv_x_GuiaRemision.IdEmpresa, Info_Inv_x_GuiaRemision.IdSucursal, Info_Inv_x_GuiaRemision.IdMovi_inven_tipo, Info_Inv_x_GuiaRemision.IdNumMovi);
                        info_IngEgr.MotivoAnulacion = Info_GuiaRemision.MotivoAnulacion;
                        info_IngEgr.IdusuarioUltAnu = Info_GuiaRemision.IdUsuarioAnulacion;
                        info_IngEgr.Fecha_UltAnu = Convert.ToDateTime(Info_GuiaRemision.FechaAnulacion);

                        if (!Bus_Ing_Egr.AnularDB(info_IngEgr, ref ms))
                        {
                            ms = "error al anular movimiento de inventario";
                        }
                        else
                        {
                            if (Bus_Inv_x_GuiaRemision.Delete(Info_GuiaRemision.IdEmpresa, Info_GuiaRemision.IdSucursal, Info_GuiaRemision.IdGuiaRemision))
                                ms = "Registro anulado con éxito!!";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return true;
        }

        public List<in_GuiaRemision_Info> Get_List(int IdEmpresa, DateTime FechaIni, DateTime FechaFin)
        {
            try
            {
                return Data.Get_List(IdEmpresa, FechaIni, FechaFin);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<in_GuiaRemision_Info> Get_List_Lite(int IdEmpresa, DateTime FechaIni, DateTime FechaFin)
        {
            try
            {
                return Data.Get_List_Lite(IdEmpresa, FechaIni, FechaFin);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public in_GuiaRemision_Info Get_Info_x_in_GuiaRemision(int IdEmpresa, decimal IdGuiaRemision)
        {
            try
            {
                return Data.Get_Info_x_in_GuiaRemision(IdEmpresa, IdGuiaRemision);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public in_GuiaRemision_Info Get_GuiaRemision(int IdEmpresa, int IdSucursal, decimal IdGuiaRemision)
        {
            try
            {
                return Data.Get_GuiaRemision(IdEmpresa, IdSucursal, IdGuiaRemision);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Boolean Generar_Guardar_Xml_Guia(int IdEmpresa, int IdSucursal, decimal IdGuia, ref string msg)
        {
            try
            {
                string sIdCbte_x_Guia = "";

                in_Parametro_Bus Bus_Inventario = new in_Parametro_Bus();
                in_Parametro_Info Info_Parametro = new in_Parametro_Info();
                string RutaDescarga = "";

                Info_Parametro = Bus_Inventario.Get_Info_Parametro(IdEmpresa);

                if (Info_Parametro != null)
                {
                    RutaDescarga = Info_Parametro.pa_ruta_descarga_xml_guia_elct;
                }

                if (string.IsNullOrEmpty(RutaDescarga) == false)
                {
                    List<guiaRemision> lista = new List<guiaRemision>();
                    lista = Get_Xml_Guia(IdEmpresa, IdSucursal, IdGuia);

                    if (lista.Count != 0)
                    {
                        foreach (var item in lista)
                        {
                            sIdCbte_x_Guia = item.infoTributaria.razonSocial.Substring(0, 3) + "-" + Cl_Enumeradores.eTipoCodComprobante.GUI + "-" + item.infoTributaria.estab + "-" + item.infoTributaria.ptoEmi + "-" + item.infoTributaria.secuencial;
                            XmlSerializerNamespaces NamespaceObject = new XmlSerializerNamespaces();
                            NamespaceObject.Add("", "");
                            XmlSerializer mySerializer = new XmlSerializer(typeof(guiaRemision));
                            StreamWriter myWriter = new StreamWriter(RutaDescarga + sIdCbte_x_Guia + ".xml");
                            mySerializer.Serialize(myWriter, item, NamespaceObject);
                            myWriter.Close();
                        }
                    }

                    return true;
                }
                else
                {
                    msg = "No hay ruta para descarga del archivo.";
                    return false;
                }
            }
            catch (Exception ex)
            {
                msg = ex.ToString();
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Generar_Guardar_Xml_Guia", ex.Message), ex) { EntityType = typeof(in_GuiaRemision_Bus) };
            }
        }

        private List<guiaRemision> Get_Xml_Guia(int IdEmpresa, int IdSucursal, decimal IdGuia)
        {
            try
            {
                in_GuiaRemision_Info Info_Guia = new in_GuiaRemision_Info();
                Info_Guia = Get_Info_x_in_GuiaRemision(IdEmpresa, IdGuia);

                tb_transportista_Bus Bus_Transportista = new tb_transportista_Bus();
                tb_transportista_Info Info_Transportista = new tb_transportista_Info();

                List<guiaRemision> listaaux = new List<guiaRemision>();
                List<guiaRemision> lista = new List<guiaRemision>();
                guiaRemisionDestinatarios destinatarios = new guiaRemisionDestinatarios();
                guiaRemision myObject = new guiaRemision();

                myObject.destinatarios = destinatarios;
                destinatarios.destinatario = new List<destinatario>();
                destinatario destinatari = new destinatario();
                destinatarioDetalles destinatariodet = new destinatarioDetalles();
                destinatari.detalles = destinatariodet;
                destinatari.detalles.detalle = new List<detalle>();

                string correo = "";
                string format = "dd/MM/yyyy";

                myObject.id = guiaRemisionID.comprobante;
                myObject.version = "1.1.0";
                myObject.id = guiaRemisionID.comprobante;
                infoTributaria info = new infoTributaria();

                myObject.infoGuiaRemision = new guiaRemisionInfoGuiaRemision();
                myObject.infoTributaria = info;
                info.ambiente = "1";
                myObject.infoTributaria.tipoEmision = "1";

                tb_Empresa_Bus Bus_Empresa = new tb_Empresa_Bus();
                tb_Sucursal_Bus Bus_Sucursal = new tb_Sucursal_Bus();

                tb_Empresa_Info Info_Empresa = Bus_Empresa.Get_Info_Empresa(IdEmpresa); //param.InfoEmpresa;
                tb_Sucursal_Info Info_Sucursal = Bus_Sucursal.Get_Info_Sucursal(IdEmpresa, IdSucursal); //param.InfoSucursal;

                myObject.infoTributaria.razonSocial = string.IsNullOrEmpty(Info_Empresa.RazonSocial) ? "" : Info_Empresa.RazonSocial.Trim();
                myObject.infoTributaria.nombreComercial = string.IsNullOrEmpty(Info_Empresa.NombreComercial) ? "" : Info_Empresa.NombreComercial.Trim();
                myObject.infoTributaria.ruc = Info_Empresa.em_ruc;
                myObject.infoTributaria.claveAcceso = "0000000000000000000000000000000000000000000000000";
                myObject.infoTributaria.codDoc = "06";
                myObject.infoTributaria.estab = (Info_Guia.Serie1 != null) ? Info_Guia.Serie1.Trim() : "";
                myObject.infoTributaria.ptoEmi = (Info_Guia.Serie2 != null) ? Info_Guia.Serie2.Trim() : "";
                myObject.infoTributaria.secuencial = (Info_Guia.NumDocumento != null) ? Info_Guia.NumDocumento.Trim() : "";
                myObject.infoTributaria.dirMatriz = string.IsNullOrEmpty(Info_Empresa.em_direccion) ? "" : Info_Empresa.em_direccion.Trim();

                myObject.infoGuiaRemision.obligadoContabilidad = Info_Empresa.ObligadoAllevarConta;
                myObject.infoGuiaRemision.contribuyenteEspecial = Info_Empresa.ContribuyenteEspecial;
                myObject.infoGuiaRemision.dirEstablecimiento = string.IsNullOrEmpty(Info_Sucursal.Su_Direccion) ? "" : Info_Sucursal.Su_Direccion.Trim();
                myObject.infoGuiaRemision.dirPartida = string.IsNullOrEmpty(Info_Guia.Origen) ? "" : Info_Guia.Origen.Trim();
                myObject.infoGuiaRemision.razonSocialTransportista = string.IsNullOrEmpty(Info_Guia.NombreTransportista) ? "" : Info_Guia.NombreTransportista.Trim();

                Info_Transportista = Bus_Transportista.Get_Info_Transportista(Info_Guia.IdEmpresa, Info_Guia.CedulaTransportista);

                if (Info_Transportista != null)
                {
                    switch (Info_Transportista.IdTipoDocumento)
                    {
                        case "RUC": //RUC
                            myObject.infoGuiaRemision.tipoIdentificacionTransportista = "04";
                            break;
                        case "CED": //CEDULA
                            myObject.infoGuiaRemision.tipoIdentificacionTransportista = "05";
                            break;
                        case "PAS": //PASAPORTE
                            myObject.infoGuiaRemision.tipoIdentificacionTransportista = "06";
                            break;
                        case "FINAL": //VENTAS O CONSUMIDOR FINAL
                            myObject.infoGuiaRemision.tipoIdentificacionTransportista = "07";
                            break;
                        case "EXT": //IDENTIFICACION DEL EXTERIOR
                            myObject.infoGuiaRemision.tipoIdentificacionTransportista = "08";
                            break;
                        case "PLA": //PLACA
                            myObject.infoGuiaRemision.tipoIdentificacionTransportista = "09";
                            break;
                        default:
                            myObject.infoGuiaRemision.tipoIdentificacionTransportista = "05";//POR DEFAULT CEDULA
                            break;
                    }
                }
                else
                {
                    myObject.infoGuiaRemision.tipoIdentificacionTransportista = "05"; //POR DEFAULT CEDULA
                }

                myObject.infoGuiaRemision.rucTransportista = Info_Guia.CedulaTransportista;
                myObject.infoGuiaRemision.placa = Info_Guia.Placa;
                myObject.infoGuiaRemision.fechaIniTransporte = Info_Guia.FechaTrasladoIni.ToString(format);
                myObject.infoGuiaRemision.fechaFinTransporte = Info_Guia.FechaTrasladoFin.ToString(format);

                destinatari.identificacionDestinatario = Info_Guia.pe_cedulaRuc;
                destinatari.razonSocialDestinatario = Info_Guia.pe_nombreCompleto;
                destinatari.dirDestinatario = Info_Guia.Destino;
                destinatari.motivoTraslado = Info_Guia.Motivo; //Info_Guia.Observacion;
                destinatari.ruta = Info_Guia.Ruta;

                in_GuiaRemision_Det_Bus BusDetalle_Guia = new in_GuiaRemision_Det_Bus();
                List<in_GuiaRemision_Det_Info> ListInfoDetalle_Guia = new List<in_GuiaRemision_Det_Info>();

                ListInfoDetalle_Guia = BusDetalle_Guia.Get_List_Guia_x_in_GuiaRemision_Det(IdEmpresa, IdSucursal, IdGuia);

                foreach (var item in ListInfoDetalle_Guia)
                {
                    detalle det = new detalle();
                    det.codigoInterno = item.Codigo.ToString();
                    det.codigoAdicional = item.Codigo;
                    det.descripcion = item.Descripcion;
                    det.cantidad = Convert.ToDecimal(item.Cantidad_sinConversion);


                    //if (item.IdUnidadMedida != "" && item.IdUnidadMedida != null)
                    //{
                    //    detalleDetAdicional detAdicional = new detalleDetAdicional();
                    //    in_UnidadMedida_Bus Bus_UnidadMedida = new in_UnidadMedida_Bus();
                    //    in_UnidadMedida_Info Info_UnidadMedida = new in_UnidadMedida_Info();

                    //    Info_UnidadMedida = Bus_UnidadMedida.Get_Info_UnidadMedida(item.IdUnidadMedida);

                    //    detAdicional.nombre = Info_UnidadMedida.cod_alterno;
                    //    detAdicional.valor = Convert.ToString(item.Cantidad);

                    //    det.detallesAdicionales = new List<detalleDetAdicional>();
                    //    det.detallesAdicionales.Add(detAdicional);
                    //}

                    //if (item.IdUnidadMedida_sinConversion != "" && item.IdUnidadMedida_sinConversion != null)
                    //{
                    //    detalleDetAdicional detAdicional = new detalleDetAdicional();
                    //    in_UnidadMedida_Bus Bus_UnidadMedida = new in_UnidadMedida_Bus();
                    //    in_UnidadMedida_Info Info_UnidadMedida = new in_UnidadMedida_Info();

                    //    Info_UnidadMedida = Bus_UnidadMedida.Get_Info_UnidadMedida(item.IdUnidadMedida_sinConversion);

                    //    detAdicional.nombre = Info_UnidadMedida.cod_alterno;
                    //    detAdicional.valor = Convert.ToString(item.Cantidad_sinConversion);

                    //    det.detallesAdicionales = new List<detalleDetAdicional>();
                    //    det.detallesAdicionales.Add(detAdicional);
                    //}

                    if (item.Peso != null)
                    {
                        detalleDetAdicional detAdicional = new detalleDetAdicional();

                        detAdicional.nombre = Convert.ToString(item.Cantidad);
                        detAdicional.valor = Convert.ToString(item.Peso);

                        det.detallesAdicionales = new List<detalleDetAdicional>();
                        det.detallesAdicionales.Add(detAdicional);
                    }

                    destinatari.detalles.detalle.Add(det);
                }

                //campos adicionales guía de remisión
                guiaRemisionCampoAdicional compoadicional = new guiaRemisionCampoAdicional();
                Cl_ValidarEmail_Info datosAdc = new Cl_ValidarEmail_Info();

                correo = Info_Guia.Correo;

                myObject.infoAdicional = new List<guiaRemisionCampoAdicional>();

                if (datosAdc.email_bien_escrito(correo) == true)
                {
                    compoadicional = new guiaRemisionCampoAdicional();
                    compoadicional.nombre = "MAIL";
                    compoadicional.Value = correo;

                    myObject.infoAdicional.Add(compoadicional);
                }

                if (!string.IsNullOrEmpty(Info_Guia.Destino))
                {
                    compoadicional = new guiaRemisionCampoAdicional();
                    compoadicional.nombre = "DESTINO";
                    compoadicional.Value = string.IsNullOrEmpty(Info_Guia.Destino) ? "" : Info_Guia.Destino;
                    myObject.infoAdicional.Add(compoadicional);
                }

                if (!string.IsNullOrEmpty(Info_Guia.IdCentroCosto))
                {
                    compoadicional = new guiaRemisionCampoAdicional();
                    compoadicional.nombre = "OBRA";
                    compoadicional.Value = string.IsNullOrEmpty(Info_Guia.IdCentroCosto) ? "" : Info_Guia.IdCentroCosto;
                    myObject.infoAdicional.Add(compoadicional);
                }

                destinatarios.destinatario.Add(destinatari);
                lista.Add(myObject);

                return lista; ;

            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_Xml_Guia", ex.Message), ex) { EntityType = typeof(in_Guia_x_traspaso_bodega_Bus) };
            }

        }

        public byte[] Get_Comprobante_Efirm_PDF(int IdEmpresa, int IdSucursal, decimal IdGuiaRemision, ref string IdComprobante, ref string mensaje_error)
        {
            try
            {
                tb_Comprobantes_Efirm_Bus Bus_Comprobante = new tb_Comprobantes_Efirm_Bus();
                in_GuiaRemision_Info Info_GuiaRemision;
                byte[] result = null;
                int IdEmpresa_Efirm = 0;

                Info_GuiaRemision = Get_GuiaRemision(IdEmpresa, IdSucursal, IdGuiaRemision);

                if (Info_GuiaRemision != null)
                {
                    IdComprobante = Cl_Enumeradores.eTipoComprobante_Alias.GUI + "-" + Info_GuiaRemision.Serie1 + "-" + Info_GuiaRemision.Serie2 + "-" + Info_GuiaRemision.NumDocumento;

                    IdEmpresa_Efirm = Bus_Comprobante.Get_IdEmpresa_x_Ruc(param.InfoEmpresa.em_ruc, ref mensaje_error);

                    result = Bus_Comprobante.Get_RidePdf(IdEmpresa_Efirm, Info_GuiaRemision.pe_cedulaRuc, IdComprobante, ref mensaje_error);
                }
                else
                {
                    mensaje_error = "No se encontraron registros para el comprobante #" + IdGuiaRemision;
                }

                return result;
            }
            catch (Exception ex)
            {
                mensaje_error = ex.Message;
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_factura", ex.Message), ex) { EntityType = typeof(fa_factura_Bus) };
            }
        }

        public string Get_Comprobante_Efirm_XML(int IdEmpresa, int IdSucursal, decimal IdGuiaRemision, ref string IdComprobante, ref string mensaje_error)
        {
            try
            {
                tb_Comprobantes_Efirm_Bus Bus_Comprobante = new tb_Comprobantes_Efirm_Bus();
                in_GuiaRemision_Info Info_GuiaRemision;
                string result = "";
                int IdEmpresa_Efirm = 0;

                Info_GuiaRemision = Get_GuiaRemision(IdEmpresa, IdSucursal, IdGuiaRemision);

                if (Info_GuiaRemision != null)
                {
                    IdComprobante = Cl_Enumeradores.eTipoComprobante_Alias.GUI + "-" + Info_GuiaRemision.Serie1 + "-" + Info_GuiaRemision.Serie2 + "-" + Info_GuiaRemision.NumDocumento;

                    IdEmpresa_Efirm = Bus_Comprobante.Get_IdEmpresa_x_Ruc(param.InfoEmpresa.em_ruc, ref mensaje_error);

                    result = Bus_Comprobante.Get_Xml(IdEmpresa_Efirm, Info_GuiaRemision.pe_cedulaRuc, IdComprobante, ref mensaje_error);                    
                }
                else
                {
                    mensaje_error = "No se encontraron registros para el comprobante #" + IdGuiaRemision;
                }

                return result;
            }
            catch (Exception ex)
            {
                mensaje_error = ex.Message;
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_factura", ex.Message), ex) { EntityType = typeof(fa_factura_Bus) };
            }
        }

        public bool Validar_Stock(int IdEmpresa, int IdSucursal, int IdBodega, decimal IdProducto, DateTime Fecha, double dCantidad, ref string msg)
        {
            try
            {
                in_Ing_Egr_Inven_Data odata = new in_Ing_Egr_Inven_Data();

                //VALIDAR STOCK POR FECHA
                double stock_a_fecha = odata.Obtener_Stock_x_FechaMovimiento(IdEmpresa, IdSucursal, IdBodega, IdProducto, Fecha);

                if (Math.Round(dCantidad, 2) > Math.Round(stock_a_fecha, 2))
                {
                    msg = "Stock insuficiente!. Cant. disponible: " + stock_a_fecha + " el " + Fecha.ToShortDateString() + ", cant. solicitada: " + dCantidad  + " en el item: " + IdProducto;
                    return false;
                }

                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
               
    }
}
