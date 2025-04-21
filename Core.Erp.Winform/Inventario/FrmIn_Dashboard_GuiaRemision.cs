using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Core.Erp.Info.General;
using Core.Erp.Business.General;

using DevExpress.DashboardCommon;
using DevExpress.DataAccess.ConnectionParameters;
using DevExpress.DataAccess.Sql;
using System.IO;

namespace Core.Erp.Winform.Inventario
{
    public partial class FrmIn_Dashboard_GuiaRemision : Form
    {
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_Conexion_Dashboard_Bus bus_ConexionDashboard = new tb_Conexion_Dashboard_Bus();

        public FrmIn_Dashboard_GuiaRemision()
        {
            InitializeComponent();

            ucGe_Menu.event_btnSalir_Click += UcGe_Menu_event_btnSalir_Click;
        }

        private void FrmIn_Dashboard_GuiaRemision_Load(object sender, EventArgs e)
        {            
            try
            {
                this.dashboardViewer1.Parameters["pIdEmpresa"].SelectedValue = param.IdEmpresa;
                this.dashboardViewer1.Parameters["pFechaDesde"].SelectedValue = DateTime.Now;
                this.dashboardViewer1.Parameters["pFechaHasta"].SelectedValue = DateTime.Now;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UcGe_Menu_event_btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dashboardViewer1_ConfigureDataConnection(object sender, DevExpress.DashboardCommon.DashboardConfigureDataConnectionEventArgs e)
        {
            try
            {
                tb_Conexion_Dashboard_Info Info_ConexionDashboard = bus_ConexionDashboard.Get_Conexion_Dashboard();

                if (Info_ConexionDashboard == null)
                {
                    MessageBox.Show("La configuracion de conexion para el dashboard esta vacia", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                // Checks the name of the connection for which the event has been raised.
                if (e.DataSourceName == "Origen de datos SQL 1")
                {
                    // Gets the connection parameters used to establish a connection to the database.
                    switch (Info_ConexionDashboard.Provider)
                    {
                        case "MySQL":
                            MySqlConnectionParameters parameters = (MySqlConnectionParameters)e.ConnectionParameters;
                            parameters.ServerName = Info_ConexionDashboard.ServerName; // "10.0.0.11";
                            parameters.PortNumber = Convert.ToInt32(Info_ConexionDashboard.PortNumber); // 3306;
                            parameters.DatabaseName = Info_ConexionDashboard.DatabaseName; // "DBERP_PRODUCCION";
                            parameters.UserName = Info_ConexionDashboard.UserName; // "mysql_sa";
                            parameters.Password = Info_ConexionDashboard.Password; // "admin*2012";
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRefrescarDashboard_Click(object sender, EventArgs e)
        {
            try
            {
                this.dashboardViewer1.Parameters["pIdEmpresa"].SelectedValue = param.IdEmpresa;
                this.dashboardViewer1.Parameters["pFechaDesde"].SelectedValue = dtpDesde.EditValue;
                this.dashboardViewer1.Parameters["pFechaHasta"].SelectedValue = dtpHasta.EditValue;
                this.dashboardViewer1.ReloadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
