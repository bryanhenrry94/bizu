using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Collections.Generic;
using Bizu.Application.General;

namespace Bizu.Reports.Inventario
{
    public partial class XINV_Rpt011_rpt : DevExpress.XtraReports.UI.XtraReport
    {
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        List<XINV_Rpt011_Info> List_Info = new List<XINV_Rpt011_Info>();
        XINV_Rpt011_Bus Bus_Rpt = new XINV_Rpt011_Bus();
        List<int> lst_bodega = new List<int>();
        public List<int> List_IdLinea;             
            
        public XINV_Rpt011_rpt()
        {
            InitializeComponent();
        }

        public void set_lst_bodega(List<int> lst_bodega_int)
        {
            try
            {
                lst_bodega = lst_bodega_int;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "XINV_Rpt011_Rpt_BeforePrint", ex.Message), ex) { EntityType = typeof(XINV_Rpt011_rpt) };
            }
        }

        private void XINV_Rpt011_rpt_BeforePrint_1(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {
                xrPictureBox1.Image = param.InfoEmpresa.em_logo_Image;
                lblEmpresa.Text = param.NombreEmpresa;
                lblUsuario.Text = param.IdUsuario;
                lblFecha.Text = param.Fecha_Transac.ToString();
                bool Mostrar_detallado = Convert.ToBoolean(p_mostrar_agrupado.Value);
                bool mostrar_valores_en_0 = Convert.ToBoolean(p_mostrar_valores_en_0.Value);
                string IdCategoria = Convert.ToString(P_IdCategoria.Value);

                List_Info = Bus_Rpt.Get_List(Convert.ToDateTime(p_fecha_ini.Value), Convert.ToDateTime(p_fecha_fin.Value), param.IdEmpresa, Convert.ToInt32(p_IdSucursal.Value), lst_bodega, Convert.ToInt32(p_IdProducto.Value), param.IdUsuario, mostrar_valores_en_0, Mostrar_detallado, IdCategoria, List_IdLinea);
                this.DataSource = List_Info;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "XINV_Rpt011_Rpt_BeforePrint", ex.Message), ex) { EntityType = typeof(XINV_Rpt011_rpt) };
            }
        }

        private void GroupHeader1_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {

        }
    }
}