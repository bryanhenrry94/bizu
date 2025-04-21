using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Core.Erp.Info.General;
using Core.Erp.Business.General;

namespace Core.Erp.Winform
{
    public partial class UC_Horario_Actividades : UserControl
    {
        #region Declaración de variables
        tb_Actividades_Horario_Bus BusActvidad = new tb_Actividades_Horario_Bus();
        List<tb_Actividades_Horario_Info> ListaActiHora = new List<tb_Actividades_Horario_Info>();
        tb_Actividades_Horario_Info InfoHorariosYActividases = new tb_Actividades_Horario_Info();

        BindingList<tb_Actividades_Horario_Acciones_Info> listActiviAcciones = new BindingList<tb_Actividades_Horario_Acciones_Info>();
        tb_Actividades_Horario_Acciones_Bus BusAccionesAcc = new tb_Actividades_Horario_Acciones_Bus();

        tb_sis_Log_Error_Vzen_Bus BusSisLog = new tb_sis_Log_Error_Vzen_Bus();

        List<TimeSpan> listaIntervalosHoras = new List<TimeSpan>();

        public string IdTransaccion { get; set; }


        int TiempoEspera_Proceso1 = 0;
        int TiempoEspera_Proceso2 = 0;
        int TiempoEspera_Proceso3 = 0;
        int TiempoEspera_Proceso4 = 0;
        int TiempoEspera_Proceso5 = 0;
        int TiempoEspera_Proceso6 = 0;
        #endregion

        public delegate void delegate_Disparador_horario(int _TiempoEspera_Proceso1, int _TiempoEspera_Proceso2, int _TiempoEspera_Proceso3,
            int _TiempoEspera_Proceso4, int _TiempoEspera_Proceso5, int _TiempoEspera_Proceso6, TimeSpan HoraDisparo, tb_Actividades_Horario_Info InfoActividad_en_proceso);
        public event delegate_Disparador_horario event_Disparador_horario;

        //private void btn_guardar_Click(object sender, EventArgs e)
        public delegate void delegate_btn_guardar_Click(object sender, EventArgs e);
        public event delegate_btn_guardar_Click event_btn_guardar_Click;

        public UC_Horario_Actividades()
        {
            try
            {
                InitializeComponent();
                event_Disparador_horario += UC_Horario_Actividades_event_Disparador_horario;
                event_btn_guardar_Click += UC_Horario_Actividades_event_btn_guardar_Click;
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error: " + ex.Message);
            }



        }

        void UC_Horario_Actividades_event_btn_guardar_Click(object sender, EventArgs e)
        {

        }

        void UC_Horario_Actividades_event_Disparador_horario(int _TiempoEspera_Proceso1, int _TiempoEspera_Proceso2, int _TiempoEspera_Proceso3, int _TiempoEspera_Proceso4, int _TiempoEspera_Proceso5, int _TiempoEspera_Proceso6, TimeSpan HoraDisparo, tb_Actividades_Horario_Info InfoActividad_en_proceso)
        {



        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void UC_Horario_Actividades_Load(object sender, EventArgs e)
        {
            try
            {
                llenar_combos();
                set_data();
                Generar_tabla_de_intervalos_tiempo_horarios();

            }
            catch (Exception ex)
            {

                MessageBox.Show("Error: " + ex.Message);
            }



        }

        void get_data()
        {

            try
            {
                string msg = "";

                InfoHorariosYActividases = new tb_Actividades_Horario_Info();


                InfoHorariosYActividases.IdTransaccion = IdTransaccion;
                InfoHorariosYActividases.IdTipoEjecucion = cmb_tipo_ejecucion.SelectedValue.ToString();
                InfoHorariosYActividases.IdTipoTiempo = cmb_ocurre_cada_tiempo.SelectedValue.ToString();
                InfoHorariosYActividases.Num_cbtes_x_pagina = 0;
                InfoHorariosYActividases.lunes = chklunes.Checked;
                InfoHorariosYActividases.martes = chkmartes.Checked;
                InfoHorariosYActividases.miercoles = chkmiercoles.Checked;
                InfoHorariosYActividases.jueves = chkJueves.Checked;
                InfoHorariosYActividases.viernes = chkViernes.Checked;
                InfoHorariosYActividases.sabado = chkSabado.Checked;
                InfoHorariosYActividases.domingo = chkdomingo.Checked;

                InfoHorariosYActividases.ocurre_cada = opt_ocurre_cada.Checked;
                InfoHorariosYActividases.ocurre_1_vez = opt_ocurre_1_vez.Checked;

                TimeSpan HoraOcurre_1_vez = new TimeSpan(txt_hora_ocurre_1_vez_a_las.Time.Hour, txt_hora_ocurre_1_vez_a_las.Time.Minute, txt_hora_ocurre_1_vez_a_las.Time.Second);
                InfoHorariosYActividases.valor_ocurre_1_vez = HoraOcurre_1_vez;
                InfoHorariosYActividases.valor_ocurre_cada = Convert.ToInt32(txt_valor_ocurre_cada.Value);

                InfoHorariosYActividases.IdTipoTiempo = cmb_ocurre_cada_tiempo.SelectedValue.ToString();


                TimeSpan hora_inicia_a = new TimeSpan(txt_hora_inicia_a.Time.Hour, txt_hora_inicia_a.Time.Minute, txt_hora_inicia_a.Time.Second);
                InfoHorariosYActividases.hora_inicia_a_las = hora_inicia_a;


                TimeSpan finaliza_a_las = new TimeSpan(txt_finaliza_a_las.Time.Hour, txt_finaliza_a_las.Time.Minute, txt_finaliza_a_las.Time.Second);
                InfoHorariosYActividases.hora_finaliza_a_las = finaliza_a_las;


                InfoHorariosYActividases.listaAcciones = new List<tb_Actividades_Horario_Acciones_Info>(listActiviAcciones);



            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }

        public void Guardar()
        {
            try
            {
                string msg = "";

                get_data();
                if (BusActvidad.ModificarDB(InfoHorariosYActividases, ref msg))
                {
                    MessageBox.Show("Grabado ok", "sistemas", MessageBoxButtons.OK);
                    Generar_tabla_de_intervalos_tiempo_horarios();
                    set_data();
                }
                else
                {
                    MessageBox.Show("No se Grabo", "sistemas", MessageBoxButtons.OK);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        void set_data()
        {
            try
            {
                string msg = "";
                ListaActiHora = BusActvidad.consultar(ref msg);

                var Select = from C in ListaActiHora
                             where C.IdTransaccion == IdTransaccion
                             select C;


                foreach (var itemInfo in Select)
                {
                    cmb_tipo_ejecucion.SelectedValue = itemInfo.IdTipoEjecucion;
                    set_visibilidad_group_box(itemInfo.IdTipoEjecucion.ToString());
                    cmb_ocurre_cada_tiempo.SelectedValue = itemInfo.IdTipoTiempo;                   
                    chklunes.Checked = itemInfo.lunes;
                    chkmartes.Checked = itemInfo.martes;
                    chkmiercoles.Checked = itemInfo.miercoles;
                    chkJueves.Checked = itemInfo.jueves;
                    chkViernes.Checked = itemInfo.viernes;
                    chkSabado.Checked = itemInfo.sabado;
                    chkdomingo.Checked = itemInfo.domingo;
                    opt_ocurre_cada.Checked = itemInfo.ocurre_cada;
                    opt_ocurre_1_vez.Checked = itemInfo.ocurre_1_vez;
                    txt_hora_ocurre_1_vez_a_las.Time = new DateTime(1900, 01, 01, itemInfo.valor_ocurre_1_vez.Hours, itemInfo.valor_ocurre_1_vez.Minutes, itemInfo.valor_ocurre_1_vez.Seconds);
                    txt_valor_ocurre_cada.Value = itemInfo.valor_ocurre_cada;
                    cmb_ocurre_cada_tiempo.SelectedValue = itemInfo.IdTipoTiempo;
                    txt_hora_inicia_a.Time = new DateTime(1900, 01, 01, itemInfo.hora_inicia_a_las.Hours, itemInfo.hora_inicia_a_las.Minutes, itemInfo.hora_inicia_a_las.Seconds);
                    txt_finaliza_a_las.Time = new DateTime(1900, 01, 01, itemInfo.hora_finaliza_a_las.Hours, itemInfo.hora_finaliza_a_las.Minutes, itemInfo.hora_finaliza_a_las.Seconds);
                    InfoHorariosYActividases = itemInfo;
                }

                listActiviAcciones = new BindingList<tb_Actividades_Horario_Acciones_Info>(BusAccionesAcc.consultar(IdTransaccion, ref msg));
                gridControlAcciones.DataSource = listActiviAcciones;


                foreach (var item in listActiviAcciones)
                {
                    switch (item.Secuencia_ejecucion)
                    {
                        case 1:
                            TiempoEspera_Proceso1 = item.TiempoEspera;
                            break;
                        case 2:
                            TiempoEspera_Proceso2 = item.TiempoEspera;
                            break;
                        case 3:
                            TiempoEspera_Proceso3 = item.TiempoEspera;
                            break;
                        case 4:
                            TiempoEspera_Proceso4 = item.TiempoEspera;
                            break;
                        case 5:
                            TiempoEspera_Proceso5 = item.TiempoEspera;
                            break;
                        case 6:
                            TiempoEspera_Proceso6 = item.TiempoEspera;
                            break;

                    }

                }


                opt_ocurre_1_vez_CheckedChanged(null, null);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }

        void llenar_combos()
        {
            try
            {
                string msg = "";
                tb_Actividades_Horario_Tipo_Ejecucion_Bus BusTEje = new tb_Actividades_Horario_Tipo_Ejecucion_Bus();
                tb_Actividades_Horario_Tipo_Tiempo_Bus BusTiempo = new tb_Actividades_Horario_Tipo_Tiempo_Bus();

                cmb_tipo_ejecucion.DataSource = BusTEje.consultar(ref msg);
                cmb_tipo_ejecucion.ValueMember = "IdTipoEjecucion";
                cmb_tipo_ejecucion.DisplayMember = "Descripcion";
                cmb_ocurre_cada_tiempo.DataSource = BusTiempo.consultar();
                cmb_ocurre_cada_tiempo.ValueMember = "IdTipoTiempo";
                cmb_ocurre_cada_tiempo.DisplayMember = "descripcion";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void gridControlAcciones_Click(object sender, EventArgs e)
        {

        }

        private void cmb_tipo_ejecucion_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            try
            {

                Guardar();
                event_btn_guardar_Click(sender, e);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);

            }
        }

        void Ejecucion_Horario_de_Actividad()
        {
            try
            {
                DateTime FechaHoy = DateTime.Now;
                TimeSpan HoraHoy = new TimeSpan(FechaHoy.TimeOfDay.Hours, FechaHoy.TimeOfDay.Minutes, FechaHoy.TimeOfDay.Seconds);
                TimeSpan HoraEjecucion;

                Boolean Dia_de_Ejecucion = false;


                if (InfoHorariosYActividases.IdTipoEjecucion == "AUTO") // si es automatico se procede a validar
                {



                    switch (FechaHoy.Date.DayOfWeek)
                    {
                        case DayOfWeek.Monday: //lunes
                            Dia_de_Ejecucion = InfoHorariosYActividases.lunes;
                            break;
                        case DayOfWeek.Thursday: //martes
                            Dia_de_Ejecucion = InfoHorariosYActividases.martes;
                            break;
                        case DayOfWeek.Wednesday: //miercoles
                            Dia_de_Ejecucion = InfoHorariosYActividases.miercoles;
                            break;
                        case DayOfWeek.Tuesday: //jueves
                            Dia_de_Ejecucion = InfoHorariosYActividases.jueves;
                            break;
                        case DayOfWeek.Friday://viernes
                            Dia_de_Ejecucion = InfoHorariosYActividases.viernes;
                            break;
                        case DayOfWeek.Saturday://sabado
                            Dia_de_Ejecucion = InfoHorariosYActividases.sabado;
                            break;
                        case DayOfWeek.Sunday://domingo
                            Dia_de_Ejecucion = InfoHorariosYActividases.domingo;
                            break;
                    }




                    if (Dia_de_Ejecucion == true)// si es el dia se ejecuta
                    {

                        if (InfoHorariosYActividases.ocurre_1_vez == true)
                        {
                            HoraEjecucion = InfoHorariosYActividases.valor_ocurre_1_vez;


                            if (HoraHoy == HoraEjecucion)
                            {
                                // ejecutando el disparo
                                event_Disparador_horario(TiempoEspera_Proceso1, TiempoEspera_Proceso2, TiempoEspera_Proceso3, TiempoEspera_Proceso4, TiempoEspera_Proceso5, TiempoEspera_Proceso6, HoraEjecucion, InfoHorariosYActividases);

                            }

                        }
                        if (InfoHorariosYActividases.ocurre_cada == true)
                        {

                            HoraEjecucion = listaIntervalosHoras.Find(v => v.Hours == HoraHoy.Hours && v.Minutes == HoraHoy.Minutes && v.Seconds == HoraHoy.Seconds);

                            if (HoraHoy == HoraEjecucion)
                            {
                                // ejecutando el disparo
                                event_Disparador_horario(TiempoEspera_Proceso1, TiempoEspera_Proceso2, TiempoEspera_Proceso3, TiempoEspera_Proceso4, TiempoEspera_Proceso5, TiempoEspera_Proceso6, HoraEjecucion, InfoHorariosYActividases);
                            }


                        }//

                    }



                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);

            }
        }

        void Generar_tabla_de_intervalos_tiempo_horarios()
        {
            try
            {

                int ValorOcurreCada = InfoHorariosYActividases.valor_ocurre_cada;
                TimeSpan HoraInicio = InfoHorariosYActividases.hora_inicia_a_las;
                TimeSpan HoraFin = InfoHorariosYActividases.hora_finaliza_a_las;
                TimeSpan Hora_Acumulada;
                TimeSpan Hora_a_sumar;

                Hora_Acumulada = HoraInicio;

                listaIntervalosHoras = new List<TimeSpan>();



                while (Hora_Acumulada <= HoraFin)
                {
                    listaIntervalosHoras.Add(Hora_Acumulada);

                    switch (InfoHorariosYActividases.IdTipoTiempo)
                    {
                        case "SEG":
                            Hora_a_sumar = TimeSpan.FromSeconds((double)ValorOcurreCada);
                            Hora_Acumulada = Hora_Acumulada + Hora_a_sumar;
                            break;
                        case "MIN":

                            Hora_a_sumar = TimeSpan.FromMinutes((double)ValorOcurreCada);
                            Hora_Acumulada = Hora_Acumulada + Hora_a_sumar;
                            break;
                        case "HOR":

                            Hora_a_sumar = TimeSpan.FromHours((double)ValorOcurreCada);
                            Hora_Acumulada = Hora_Acumulada + Hora_a_sumar;
                            break;
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);

            }

        }

        private void panelMain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cmb_ocurre_cada_tiempo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void timerSensorDisparo_Tick(object sender, EventArgs e)
        {
            try
            {
                Ejecucion_Horario_de_Actividad();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ejecucion_Horario_de_Actividad();

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void cmb_tipo_ejecucion_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {


            }
        }

        private void cmb_tipo_ejecucion_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                string Id = cmb_tipo_ejecucion.SelectedValue.ToString();
                set_visibilidad_group_box(Id);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        void set_visibilidad_group_box(string sTipoEje)
        {
            try
            {
                gb_acciones_a_ejecutarse.Visible = true;
                gb_frecuencia_semanal.Visible = true;
                gb_frecuencia_diaria.Visible = true;

                if (sTipoEje == "MANU")
                {
                    gb_acciones_a_ejecutarse.Visible = false;
                    gb_frecuencia_semanal.Visible = false;
                    gb_frecuencia_diaria.Visible = false;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void opt_ocurre_1_vez_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                txt_hora_ocurre_1_vez_a_las.Visible = opt_ocurre_1_vez.Checked;
                gb_ocurre_cada.Visible = !(opt_ocurre_1_vez.Checked);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void opt_ocurre_cada_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                gb_ocurre_cada.Visible = opt_ocurre_cada.Checked;
                txt_hora_ocurre_1_vez_a_las.Visible = !(opt_ocurre_cada.Checked);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);

            }
        }
    }
}
