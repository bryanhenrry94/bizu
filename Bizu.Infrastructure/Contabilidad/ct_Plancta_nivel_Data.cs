using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Bizu.Domain.Contabilidad;
using Bizu.Infrastructure.General;
using Bizu.Domain.General;

namespace Bizu.Infrastructure.Contabilidad
{
    public class ct_Plancta_nivel_Data
    {
        string mensaje = "";

        public int getId_Plancta_nivel()
        {
            int Id = 0;
            try
            {
                using (EntitiesDBConta Base = new EntitiesDBConta())
                {
                    int select = (from q in Base.ct_plancta_nivel
                                  select q).Count();

                    if (select == 0)
                    {
                        Id = 1;
                    }
                    else
                    {
                        var select_as = (from q in Base.ct_plancta_nivel
                                         select q.idnivelcta).Max();
                        Id = Convert.ToInt32(select_as.ToString()) + 1;
                    }
                }
                return Id;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                string MensajeError = string.Empty;
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                MensajeError = ex.ToString();
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
                throw new Exception(ex.ToString());
            }
        }

        public List<ct_Plancta_nivel_Info> Get_list_Plancta_nivel(int IdEmpresa)
        {
            try
            {

                List<ct_Plancta_nivel_Info> lM = new List<ct_Plancta_nivel_Info>();
                using (EntitiesDBConta OEselectPlancta_nivel = new EntitiesDBConta())
                {
                    var selectPlancta_nivel = from C in OEselectPlancta_nivel.ct_plancta_nivel
                                              where C.idempresa == IdEmpresa
                                              select C;

                    ct_Plancta_nivel_Info _PlantaCtaNivelInfo;
                    foreach (var item in selectPlancta_nivel)
                    {
                        _PlantaCtaNivelInfo = new ct_Plancta_nivel_Info();
                        _PlantaCtaNivelInfo.IdEmpresa = item.idempresa;
                        _PlantaCtaNivelInfo.IdNivelCta = item.idnivelcta;
                        _PlantaCtaNivelInfo.nv_NumDigitos = item.nv_numdigitos;
                        _PlantaCtaNivelInfo.nv_Descripcion = item.nv_descripcion;
                        _PlantaCtaNivelInfo.Estado = item.estado;

                        lM.Add(_PlantaCtaNivelInfo);
                    }

                    return (lM);
                }
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString();
                throw new Exception(ex.ToString());
            }
        }

        public ct_Plancta_nivel_Info Get_info_plancta_nivel(int IdEmpresa, int IdNivelCta)
        {
            try
            {
                ct_Plancta_nivel_Info info = new ct_Plancta_nivel_Info();

                using (EntitiesDBConta OEselectPlancta_nivel = new EntitiesDBConta())
                {
                    var selectPlancta_nivel = from C in OEselectPlancta_nivel.vwct_plancta_nivel
                                              where C.idempresa == IdEmpresa
                                              && C.idnivelcta == IdNivelCta
                                              select C;


                    foreach (var item in selectPlancta_nivel)
                    {
                        info = new ct_Plancta_nivel_Info();
                        info.IdEmpresa = item.idempresa;
                        info.IdNivelCta = item.idnivelcta;
                        info.nv_NumDigitos = item.nv_numdigitos;
                        info.nv_Descripcion = item.nv_descripcion;
                        info.nv_NumDigitos_total = Convert.ToInt32(item.nv_numdigitos_total);
                        info.Estado = item.estado;
                    }
                }

                return info;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString();
                throw new Exception(ex.ToString());
            }
        }

        public Boolean Valida_Nivel(ct_Plancta_nivel_Info _PCninfo)
        {
            try
            {
                using (EntitiesDBConta context = new EntitiesDBConta())
                {
                    var Q = from PCta_info in context.ct_plancta
                            where PCta_info.idempresa == _PCninfo.IdEmpresa && PCta_info.idnivelcta == _PCninfo.IdNivelCta
                            select PCta_info;
                    return (Q.ToList().Count > 0) ? true : false;
                }
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString();
                throw new Exception(ex.ToString());
            }
        }

        public Boolean ModificarDB(ct_Plancta_nivel_Info _PCninfo)
        {
            try
            {
                using (EntitiesDBConta context = new EntitiesDBConta())
                {
                    var contact = context.ct_plancta_nivel.FirstOrDefault(Pcta_info => Pcta_info.idnivelcta == _PCninfo.IdNivelCta && Pcta_info.idempresa == _PCninfo.IdEmpresa);
                    if (contact != null)
                    {
                        contact.idempresa = _PCninfo.IdEmpresa;
                        contact.idnivelcta = Convert.ToByte(_PCninfo.IdNivelCta);
                        contact.nv_numdigitos = Convert.ToByte(_PCninfo.nv_NumDigitos);
                        contact.nv_descripcion = _PCninfo.nv_Descripcion;
                        contact.estado = _PCninfo.Estado;
                        context.SaveChanges();
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString();
                throw new Exception(ex.ToString());
            }
        }

        public Boolean GrabarDB(ct_Plancta_nivel_Info _PCninfo)
        {
            try
            {
                using (EntitiesDBConta context = new EntitiesDBConta())
                {
                    EntitiesDBConta EDB = new EntitiesDBConta();
                    var Q = from per in EDB.ct_plancta_nivel
                            where per.idnivelcta == _PCninfo.IdNivelCta
                            && per.idempresa == _PCninfo.IdEmpresa
                            select per;
                    if (Q.ToList().Count == 0)
                    {
                        var address = new ct_plancta_nivel();
                        int IdNivel = 0;
                        IdNivel = (_PCninfo.IdNivelCta != 0) ? _PCninfo.IdNivelCta : getId_Plancta_nivel();
                        address.idempresa = _PCninfo.IdEmpresa;
                        address.idnivelcta = IdNivel;
                        address.nv_numdigitos = _PCninfo.nv_NumDigitos;
                        address.nv_descripcion = _PCninfo.nv_Descripcion;
                        address.estado = "A";
                        context.ct_plancta_nivel.Add(address);
                        context.SaveChanges();

                    }
                    else
                        return false;
                }
                return true;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString();
                throw new Exception(ex.ToString());
            }
        }

        public Boolean GrabarDB(List<ct_Plancta_nivel_Info> _ListPCninfo)
        {
            try
            {
                foreach (var item in _ListPCninfo)
                {
                    GrabarDB(item);
                }

                return true;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString();
                throw new Exception(ex.ToString());
            }
        }

        public Boolean AnularDB(ct_Plancta_nivel_Info _PCninfo)
        {
            try
            {
                using (EntitiesDBConta context = new EntitiesDBConta())
                {
                    var contact = context.ct_plancta_nivel.FirstOrDefault(Pcta_info => Pcta_info.idempresa == _PCninfo.IdEmpresa && Pcta_info.idnivelcta == _PCninfo.IdNivelCta);

                    if (contact != null)
                    {
                        contact.idusuarioultanu = _PCninfo.IdUsuarioUltAnu;
                        contact.fecha_ultanu = DateTime.Now;
                        contact.motivoanulacion = _PCninfo.MotivoAnulacion;
                        contact.estado = "I";
                        context.SaveChanges();
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString();
                throw new Exception(ex.ToString());
            }
        }

        public Boolean EliminarDB(int IdEmpresa)
        {
            try
            {
                using (EntitiesDBConta Entity = new EntitiesDBConta())
                {
                    int numeroElimindo = Entity.Database.ExecuteSqlCommand("delete from ct_plancta_nivel where IdEmpresa = " + IdEmpresa);
                }
                return true;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString();
                throw new Exception(ex.ToString());
            }
        }

        public ct_Plancta_nivel_Data()
        {

        }
    }
}