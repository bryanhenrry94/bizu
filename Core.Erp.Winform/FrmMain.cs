using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraBars.Navigation;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Docking2010.Views;
using DevExpress.XtraBars.Helpers;
using System.Reflection;
using System.Deployment.Application;
using Core.Erp.Business.SeguridadAcceso;
using Core.Erp.Business.General;
using Core.Erp.Info.SeguridadAcceso;
using Core.Erp.Info.General;
using Core.Erp.Winform.SeguridadAcceso;

namespace Core.Erp.Winform
{
    public partial class FrmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        // Bus
        private cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        private seg_Usuario_x_Empresa_Bus BusUsuarioXEmpresa = new seg_Usuario_x_Empresa_Bus();
        private tb_Empresa_Bus BusEmpresa = new tb_Empresa_Bus();
        private tb_Sucursal_Bus BusSucursal = new tb_Sucursal_Bus();
        private seg_Menu_bus BusMenu = new seg_Menu_bus();
        private tb_sis_reporte_Bus BusReporte = new tb_sis_reporte_Bus();
        // Info
        private seg_Menu_info InfoMenu = new seg_Menu_info();
        private seg_usuario_info InfoUsuario;
        private tb_Empresa_Info InfoEmpresa;
        // List
        private List<tb_sis_reporte_Info> listReporte = new List<tb_sis_reporte_Info>();
        private List<seg_Usuario_x_Empresa_info> ListUsuarioXEmpresa = new List<seg_Usuario_x_Empresa_info>();

        XtraUserControl employeesUserControl;
        XtraUserControl customersUserControl;
        public FrmMain()
        {
            InitializeComponent();            
        }     
               
        private void FrmMain_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            try
            {                
                // Get the entry assembly
                Assembly entryAssembly = Assembly.GetEntryAssembly();

                // Check if the application is ClickOnce deployed
                if (ApplicationDeployment.IsNetworkDeployed)
                {
                    // Get the ClickOnce deployment manifest
                    ApplicationDeployment deployment = ApplicationDeployment.CurrentDeployment;

                    // Get the ClickOnce deployment version
                    Version version = deployment.CurrentVersion;

                    this.Text = this.Text + " " + version.ToString();
                }
                else
                {
                    // Get the assembly version from the entry assembly
                    Version version = entryAssembly.GetName().Version;

                    this.Text = this.Text + " " + version.ToString();
                }
                
                if (ValidarIngreso())
                {
                    string mensajeError = "";

                    CargarMenu(ref mensajeError);
                    
                    //lbl_usuario.Caption = param.IdUsuario;
                    //lbl_empresa.Caption = "[" + param.IdEmpresa + "] - " + param.NombreEmpresa;
                    //barStaticItem_param.Caption = "Usuario: " + param.IdUsuario + "   Empresa:[" + param.IdEmpresa + "] - " + param.NombreEmpresa;                    
                }

                //Cargar_Menu_Ribbon_x_Usuario();
                //Cargar_Combo();               
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error {ex.Message}", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidarIngreso()
        {
            try
            {
                FrmSeg_Login login = new FrmSeg_Login();
                login.ShowDialog(this);

                if (param.IdUsuario == null)
                {
                    Application.Exit();
                    return false;
                }

                // Obtener todas las empresas en la que esta asignado el usuario
                ListUsuarioXEmpresa = BusUsuarioXEmpresa.Get_List_seg_Usuario_x_Empresa(param.IdUsuario);

                // Si tiene mas de una empresa le pedimos que seleccione una empresa
                if (ListUsuarioXEmpresa.Count > 1)
                {
                    FrmSeg_Login_x_Empresas frm_login_x_empresas = new FrmSeg_Login_x_Empresas();
                    frm_login_x_empresas.ShowDialog(this);
                }
                else
                {
                    // Obtiene el primer registro de la empresa x usuario
                    seg_Usuario_x_Empresa_info InfoUsuarioXEmpresa = ListUsuarioXEmpresa.FirstOrDefault();

                    // Si solo tiene una empresa le asignamos la primera empresa por default                   
                    tb_Empresa_Info my_info = BusEmpresa.Get_Info_Empresa(InfoUsuarioXEmpresa.IdEmpresa);
                    param.InfoEmpresa = my_info;
                    param.IdEmpresa = my_info.IdEmpresa;
                    param.NombreEmpresa = my_info.em_nombre;

                    // Consulta la sucursal por la empresa
                    List<tb_Sucursal_Info> ListSucursal = BusSucursal.Get_List_Sucursal(my_info.IdEmpresa);
                    if (ListSucursal.Count > 0)
                    {
                        tb_Sucursal_Info InfoSucursal = ListSucursal.FirstOrDefault();
                        param.IdSucursal = InfoSucursal.IdSucursal;
                        param.InfoSucursal = InfoSucursal;
                    }
                    else
                    {
                        param.IdSucursal = 0;
                        param.InfoSucursal = null;
                    }
                }

                // Asignamos a los atributos globales
                InfoEmpresa = param.InfoEmpresa;
                InfoUsuario = param.InfoUsuario;
               
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error {ex.Message}", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public void CargarMenu(ref string MensajeError)
        {
            try
            {
                List<seg_Menu_info> menuList = BusMenu.Get_List_Menu_x_Empresa_x_Usuario(param.IdUsuario, param.IdEmpresa, ref MensajeError);                
                CargarMenuEnAccordion(menuList);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error {ex.Message}", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarMenuEnAccordion(List<seg_Menu_info> menus)
        {
            accordionControl.Elements.Clear();

            var nodosRaiz = menus
                .Where(m => m.Habilitado && m.IdMenuPadre == 0)
                .OrderBy(m => m.PosicionMenu)
                .ToList();

            foreach (var menu in nodosRaiz)
            {
                var elemento = CrearElemento(menu);
                accordionControl.Elements.Add(elemento);
                AgregarHijos(elemento, menu, menus);
            }

            accordionControl.ElementClick += AccordionControl1_ElementClick;
        }

        private void AgregarHijos(AccordionControlElement padre, seg_Menu_info menuPadre, List<seg_Menu_info> menus)
        {
            var hijos = menus
                .Where(m => m.Habilitado && m.IdMenuPadre == menuPadre.IdMenu)
                .OrderBy(m => m.PosicionMenu)
                .ToList();

            foreach (var hijo in hijos)
            {
                var elementoHijo = CrearElemento(hijo);
                padre.Elements.Add(elementoHijo);
                AgregarHijos(elementoHijo, hijo, menus);
            }
        }

        private AccordionControlElement CrearElemento(seg_Menu_info menu)
        {
            var elemento = new AccordionControlElement()
            {
                Text = menu.DescripcionMenu,
                Style = ElementStyle.Item,
                Tag = menu
            };

            if (menu.Tiene_FormularioAsociado)
            {
                elemento.Style = ElementStyle.Item;
            }
            else
            {
                elemento.Style = ElementStyle.Group;
            }

            return elemento;
        }

        private void AccordionControl1_ElementClick(object sender, ElementClickEventArgs e)
        {
            if (e.Element?.Tag is seg_Menu_info menu && menu.Tiene_FormularioAsociado)
            {
                try
                {
                    // Cargar el assembly desde el nombre (ruta relativa o absoluta)
                    Assembly ensamblado = Assembly.LoadFrom(menu.nom_Asembly);
                    AssemblyName assemName = ensamblado.GetName();

                    // Obtener el tipo del formulario
                    Type tipoFormulario = ensamblado.GetType($"{assemName.Name}.{menu.nom_Formulario}");

                    if (tipoFormulario == null)
                    {
                        MessageBox.Show($"No se encontró el formulario '{menu.nom_Formulario}' en el ensamblado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    if (this.FormularioEstaAbierto(menu.nom_Formulario)) return;
                        
                    var ObjFrm = Activator.CreateInstance(tipoFormulario);
                    Form Formulario = (Form)ObjFrm;
                    Formulario.Text = menu.DescripcionMenu;
                    Formulario.MdiParent = this;
                    Formulario.Tag = menu.DescripcionMenu;
                    Formulario.WindowState = FormWindowState.Maximized;
                    Formulario.Show();

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al abrir el formulario: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private bool FormularioEstaAbierto(string nombreDelFormularioCompleto)
        {
            try
            {
                string nombreCorto = nombreDelFormularioCompleto.Contains(".")
                    ? nombreDelFormularioCompleto.Substring(nombreDelFormularioCompleto.LastIndexOf('.') + 1)
                    : nombreDelFormularioCompleto;

                foreach (Form frm in this.MdiChildren)
                {
                    if (frm.Name.Equals(nombreCorto, StringComparison.OrdinalIgnoreCase))
                    {
                        frm.Focus();
                        MessageBox.Show("El formulario o reporte solicitado ya se encuentra abierto", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return true;
                    }
                }

                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al verificar el formulario abierto: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }


        // Simulación para propósito del ejemplo
        private List<seg_Menu_info> ObtenerMenus()
        {
            return new List<seg_Menu_info>(); // Reemplaza esto con tu lógica real
        }
    }
}