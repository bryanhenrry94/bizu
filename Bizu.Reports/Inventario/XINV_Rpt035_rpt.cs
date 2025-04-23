using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Collections.Generic;
using Bizu.Application.General;

namespace Bizu.Reports.Inventario
{
    public partial class XINV_Rpt035_rpt : DevExpress.XtraReports.UI.XtraReport
    {
        #region variables
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        List<XINV_Rpt035_Info> List_Info = new List<XINV_Rpt035_Info>();
        XINV_Rpt035_Bus Bus_Rpt = new XINV_Rpt035_Bus();
        List<int> lst_bodega = new List<int>();
        #endregion

        public List<int> List_IdLinea;

        public void set_lst_bodega(List<int> lst_bodega_int )
        {
            try
            {
                lst_bodega = lst_bodega_int;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "XINV_Rpt035_rpt_BeforePrint", ex.Message), ex) { EntityType = typeof(XINV_Rpt035_rpt) };
            }
        }

        public XINV_Rpt035_rpt()
        {
            InitializeComponent();
        }

        private void XINV_Rpt035_rpt_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {
                xrPictureBox1.Image = param.InfoEmpresa.em_logo_Image;
                lblEmpresa.Text = param.NombreEmpresa;
                lblUsuario.Text = param.IdUsuario;
                lblFecha.Text = param.Fecha_Transac.ToString();
                bool Mostrar_detallado = Convert.ToBoolean(P_mostrar_agrupado.Value);
                bool mostrar_valores_en_0 = Convert.ToBoolean(P_mostrar_valores_en_0.Value);
                string IdCategoria = Convert.ToString(P_IdCategoria.Value);                

                List_Info = Bus_Rpt.Get_List(Convert.ToDateTime(P_fecha_ini.Value), Convert.ToDateTime(P_fecha_fin.Value), param.IdEmpresa, Convert.ToInt32(P_IdSucursal.Value), lst_bodega, Convert.ToInt32(P_IdProducto.Value), param.IdUsuario, mostrar_valores_en_0, Mostrar_detallado, IdCategoria, List_IdLinea);
                this.DataSource = List_Info;             
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "XINV_Rpt035_rpt_BeforePrint", ex.Message), ex) { EntityType = typeof(XINV_Rpt035_rpt) };
            }
        }
    }
}
