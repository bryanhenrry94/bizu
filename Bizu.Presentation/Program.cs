using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Bizu.Application.General;
using Bizu.Domain.General;
using DevExpress.XtraSplashForm;
using System.Threading;
using System.Globalization;

namespace Bizu.Presentation
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            //DevExpress.ExpressApp.FrameworkSettings.DefaultSettingsCompatibilityMode = DevExpress.ExpressApp.FrameworkSettingsCompatibilityMode.v20_1;
            System.Windows.Forms.Application.EnableVisualStyles();
            System.Windows.Forms.Application.SetCompatibleTextRenderingDefault(false);

            Properties.Settings.Default.SkinName = "The Bezier";
            Properties.Settings.Default.Palette = "Office Black";
            Properties.Settings.Default.Save();
            DevExpress.LookAndFeel.UserLookAndFeel.Default.SetSkinStyle(Properties.Settings.Default.SkinName, Properties.Settings.Default.Palette);

            Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo(Properties.Settings.Default.ConfRegional);
            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(Properties.Settings.Default.ConfRegional);

            Thread.CurrentThread.CurrentCulture.NumberFormat.CurrencyDecimalSeparator = ".";
            Thread.CurrentThread.CurrentCulture.NumberFormat.CurrencyGroupSeparator = ",";

            Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator = ".";
            Thread.CurrentThread.CurrentCulture.NumberFormat.NumberGroupSeparator = ",";

            Thread.CurrentThread.CurrentCulture.NumberFormat.PercentDecimalSeparator = ".";
            Thread.CurrentThread.CurrentCulture.NumberFormat.PercentGroupSeparator = ",";
                     
            tb_Empresa_Bus BusEmpresa = new tb_Empresa_Bus();
            tb_Empresa_Info InfoEmpresa = new tb_Empresa_Info();
            tb_Sucursal_Info InfoSucursal = new tb_Sucursal_Info();
            tb_Sucursal_Bus BusSucursal = new tb_Sucursal_Bus();

            try
            {
                InfoEmpresa = BusEmpresa.Get_Info_Empresa(1); //CAMBIAR PARA INICIAR CON LA EMPRESA Q SE DESEE
                InfoSucursal = BusSucursal.Get_Info_Sucursal(InfoEmpresa.IdEmpresa, 1);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al conectarse a la Base Verifique la cadena de conexion APP..\n\n\n\n" + ex.Message, "Conexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Bizu.Application.General.cl_parametrosGenerales_Bus param = Bizu.Application.General.cl_parametrosGenerales_Bus.Instance;
            param.IdEmpresa = InfoEmpresa.IdEmpresa;
            param.IdSucursal = InfoSucursal.IdSucursal;
            param.IdUsuario = "No_log_sysVZEN";
            param.IdSucursal = 1;
            param.InfoEmpresa = InfoEmpresa;
            param.InfoSucursal = InfoSucursal;
            param.IdInstitucion = 1;
            param.em_Email = InfoEmpresa.em_Email;

            // Crear el formulario contenedor
            //Form mainForm = new Form();
            FrmMain mainForm = new FrmMain();
            mainForm.WindowState = FormWindowState.Maximized;
            mainForm.Text = "DAZZSOFT ERP";
            System.Windows.Forms.Application.Run(mainForm);
            //Application.Run(new Bizu.Presentation.SeguridadAcceso.FrmMain());            
            //Application.Run(new FrmPrd_Contratista_Cons());
        }
    }
}