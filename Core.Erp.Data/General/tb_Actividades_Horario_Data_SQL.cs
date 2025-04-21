using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Info.General;

namespace Core.Erp.Data.General
{
    public class tb_Actividades_Horario_Data_SQL : Itb_Actividades_Horario_Data
    {
        public List<tb_Actividades_Horario_Info> consultar(ref string mensajeErrorOut)
        {
            try
            {
                List<tb_Actividades_Horario_Info> lista = new List<tb_Actividades_Horario_Info>();

                EntitiesGeneral OEselecEmpresa = new EntitiesGeneral();

                var selectEmpresa = from C in OEselecEmpresa.tb_Actividades_Horario
                                    select C;

                foreach (var item in selectEmpresa)
                {
                    tb_Actividades_Horario_Info Cbt = new tb_Actividades_Horario_Info();



                    Cbt.IdTransaccion = item.IdTransaccion;
                    Cbt.IdTipoEjecucion = item.IdTipoEjecucion;
                    Cbt.Num_cbtes_x_pagina = item.Num_cbtes_x_pagina;
                    Cbt.lunes = item.lunes;
                    Cbt.martes = item.martes;
                    Cbt.miercoles = item.miercoles;
                    Cbt.jueves = item.jueves;
                    Cbt.viernes = item.viernes;
                    Cbt.sabado = item.sabado;
                    Cbt.domingo = item.domingo;
                    Cbt.ocurre_1_vez = item.ocurre_1_vez;
                    Cbt.valor_ocurre_1_vez = item.valor_ocurre_1_vez;
                    Cbt.ocurre_cada = item.ocurre_cada;
                    Cbt.valor_ocurre_cada = item.valor_ocurre_cada;
                    Cbt.IdTipoTiempo = item.IdTipoTiempo;
                    Cbt.hora_inicia_a_las = item.hora_inicia_a_las;
                    Cbt.hora_finaliza_a_las = item.hora_finaliza_a_las;

                    lista.Add(Cbt);
                }

                return lista;
            }
            catch (Exception ex)
            {
                return new List<tb_Actividades_Horario_Info>();
            }
        }

        public tb_Actividades_Horario_Info consultar(string IdTransaccion, ref string mensajeErrorOut)
        {
            try
            {

                tb_Actividades_Horario_Info Cbt = new tb_Actividades_Horario_Info();
                EntitiesGeneral OEselecEmpresa = new EntitiesGeneral();

                var selectEmpresa = from C in OEselecEmpresa.tb_Actividades_Horario
                                    where C.IdTransaccion == IdTransaccion
                                    select C;

                foreach (var item in selectEmpresa)
                {




                    Cbt.IdTransaccion = item.IdTransaccion;
                    Cbt.IdTipoEjecucion = item.IdTipoEjecucion;
                    Cbt.Num_cbtes_x_pagina = item.Num_cbtes_x_pagina;
                    Cbt.lunes = item.lunes;
                    Cbt.martes = item.martes;
                    Cbt.miercoles = item.miercoles;
                    Cbt.jueves = item.jueves;
                    Cbt.viernes = item.viernes;
                    Cbt.sabado = item.sabado;
                    Cbt.domingo = item.domingo;
                    Cbt.ocurre_1_vez = item.ocurre_1_vez;
                    Cbt.valor_ocurre_1_vez = item.valor_ocurre_1_vez;
                    Cbt.ocurre_cada = item.ocurre_cada;
                    Cbt.valor_ocurre_cada = item.valor_ocurre_cada;
                    Cbt.IdTipoTiempo = item.IdTipoTiempo;
                    Cbt.hora_inicia_a_las = item.hora_inicia_a_las;
                    Cbt.hora_finaliza_a_las = item.hora_finaliza_a_las;
                }

                return Cbt;
            }
            catch (Exception ex)
            {
                return new tb_Actividades_Horario_Info();
            }
        }

        public bool GrabarDB(tb_Actividades_Horario_Info Info, ref string mensajeErrorOut)
        {
            try
            {

                using (EntitiesGeneral Context = new EntitiesGeneral())
                {

                    var Address = new tb_Actividades_Horario();

                    Address.IdTransaccion = Info.IdTransaccion;
                    Address.IdTipoEjecucion = Info.IdTipoEjecucion;
                    Address.Num_cbtes_x_pagina = Info.Num_cbtes_x_pagina;
                    Address.lunes = Info.lunes;
                    Address.martes = Info.martes;
                    Address.miercoles = Info.miercoles;
                    Address.jueves = Info.jueves;
                    Address.viernes = Info.viernes;
                    Address.sabado = Info.sabado;
                    Address.domingo = Info.domingo;
                    Address.ocurre_1_vez = Info.ocurre_1_vez;
                    Address.valor_ocurre_1_vez = Info.valor_ocurre_1_vez;
                    Address.ocurre_cada = Info.ocurre_cada;
                    Address.valor_ocurre_cada = Info.valor_ocurre_cada;
                    Address.IdTipoTiempo = Info.IdTipoTiempo.ToString();
                    Address.hora_inicia_a_las = Info.hora_inicia_a_las;
                    Address.hora_finaliza_a_las = Info.hora_finaliza_a_las;



                    Context.tb_Actividades_Horario.Add(Address);
                    Context.SaveChanges();
                }

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool ModificarDB(tb_Actividades_Horario_Info Info, ref string mensajeErrorOut)
        {
            try
            {

                using (EntitiesGeneral Context = new EntitiesGeneral())
                {



                    var contact = Context.tb_Actividades_Horario.First(minfo => minfo.IdTransaccion == Info.IdTransaccion);

                    contact.IdTipoEjecucion = Info.IdTipoEjecucion;
                    contact.Num_cbtes_x_pagina = Info.Num_cbtes_x_pagina;
                    contact.lunes = Info.lunes;
                    contact.martes = Info.martes;
                    contact.miercoles = Info.miercoles;
                    contact.jueves = Info.jueves;
                    contact.viernes = Info.viernes;
                    contact.sabado = Info.sabado;
                    contact.domingo = Info.domingo;
                    contact.ocurre_1_vez = Info.ocurre_1_vez;
                    contact.valor_ocurre_1_vez = Info.valor_ocurre_1_vez;
                    contact.ocurre_cada = Info.ocurre_cada;
                    contact.valor_ocurre_cada = Info.valor_ocurre_cada;
                    contact.IdTipoTiempo = Info.IdTipoTiempo.ToString();
                    contact.hora_inicia_a_las = Info.hora_inicia_a_las;
                    contact.hora_finaliza_a_las = Info.hora_finaliza_a_las;
                    Context.SaveChanges();
                }

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
