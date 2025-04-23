using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bizu.Domain.General
{
    public class tb_Actividades_Horario_Info
    {
        public string IdTransaccion { get; set; }
        public string IdTipoEjecucion { get; set; }
        public int Num_cbtes_x_pagina { get; set; }
        public bool lunes { get; set; }
        public bool martes { get; set; }
        public bool miercoles { get; set; }
        public bool jueves { get; set; }
        public bool viernes { get; set; }
        public bool sabado { get; set; }
        public bool domingo { get; set; }
        public bool ocurre_1_vez { get; set; }
        public bool ocurre_cada { get; set; }
        public int valor_ocurre_cada { get; set; }
        public string IdTipoTiempo { get; set; }

        public TimeSpan hora_inicia_a_las { get; set; }
        public TimeSpan hora_finaliza_a_las { get; set; }
        public TimeSpan valor_ocurre_1_vez { get; set; }

        public List<tb_Actividades_Horario_Acciones_Info> listaAcciones { get; set; }

        public tb_Actividades_Horario_Info()
        {
            listaAcciones = new List<tb_Actividades_Horario_Acciones_Info>();
        }
    }
}
