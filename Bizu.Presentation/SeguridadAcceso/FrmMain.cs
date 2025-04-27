using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Helpers;
using DevExpress.XtraBars.Ribbon;
using System.Linq;

using Bizu.Domain.SeguridadAcceso;
using Bizu.Application.SeguridadAcceso;
using Bizu.Domain.General;
using Bizu.Application.General;
using Bizu.Application.Mail;
using Bizu.Domain.Mail;
using System.Deployment.Application;
using System.Reflection;

namespace Bizu.Presentation.SeguridadAcceso
{
    public partial class FrmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        bool Cerrar = false;
        private seg_usuario_info InfoUsuario;
        private tb_Empresa_Info InfoEmpresa;
        tb_Empresa_Bus BusEmpresa = new tb_Empresa_Bus();
        tb_Sucursal_Bus BusSucursal = new tb_Sucursal_Bus();
        seg_Menu_bus BusMenu = new seg_Menu_bus();
        seg_Menu_info InfoMenu = new seg_Menu_info();

        tb_sis_reporte_Bus BusReporte = new tb_sis_reporte_Bus();
        List<tb_sis_reporte_Info> listReporte = new List<tb_sis_reporte_Info>();

        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        Bizu.Application.General.cl_parametrosGenerales_Bus param = Bizu.Application.General.cl_parametrosGenerales_Bus.Instance;

        seg_Usuario_x_Empresa_Bus BusUsuarioXEmpresa = new seg_Usuario_x_Empresa_Bus();
        List<seg_Usuario_x_Empresa_info> ListUsuarioXEmpresa = new List<seg_Usuario_x_Empresa_info>();
        
        public FrmMain()
        {
            try
            {
                InitializeComponent();

                ucSeg_Menu_x_Usuario_x_Empresa1.event_treeListMenu_x_Usuario_x_Empresa_MouseDown += ucSeg_Menu_x_Usuario_x_Empresa1_event_treeListMenu_x_Usuario_x_Empresa_MouseDown;
                ucSeg_Menu_x_Usuario_x_Empresa1.event_treeListMenu_x_Usuario_x_Empresa_SelectImageClick += ucSeg_Menu_x_Usuario_x_Empresa1_event_treeListMenu_x_Usuario_x_Empresa_SelectImageClick;
                ucSeg_Menu_x_Usuario_x_Empresa1.event_treeListMenu_x_Usuario_x_Empresa_NodeCellStyle += ucSeg_Menu_x_Usuario_x_Empresa1_event_treeListMenu_x_Usuario_x_Empresa_NodeCellStyle;
                ucSeg_Menu_x_Usuario_x_Empresa1.event_treeListMenu_x_Usuario_x_Empresa_KeyUp += ucSeg_Menu_x_Usuario_x_Empresa1_event_treeListMenu_x_Usuario_x_Empresa_KeyUp;
                ucSeg_Menu_x_Usuario_x_Empresa1.event_btnRefrescarMenu_Click += ucSeg_Menu_x_Usuario_x_Empresa1_event_btnRefrescarMenu_Click;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        void ucSeg_Menu_x_Usuario_x_Empresa1_event_btnRefrescarMenu_Click(object sender, EventArgs e)
        {
            try
            {
                string mensajeError = "";
                CargarMenu(ref mensajeError);
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        void ucSeg_Menu_x_Usuario_x_Empresa1_event_treeListMenu_x_Usuario_x_Empresa_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                DevExpress.XtraTreeList.TreeList tree = (DevExpress.XtraTreeList.TreeList)sender;
                DevExpress.XtraTreeList.TreeListHitInfo hitInfo = tree.CalcHitInfo(e.Location);
                if (hitInfo.HitInfoType == DevExpress.XtraTreeList.HitInfoType.Cell)
                {
                    SeleccionarNodo(hitInfo.Node);
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        void ucSeg_Menu_x_Usuario_x_Empresa1_event_treeListMenu_x_Usuario_x_Empresa_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (ucSeg_Menu_x_Usuario_x_Empresa1.treeListMenu_x_Usuario_x_Empresa.Selection.Count > 0)
                {
                    switch (e.KeyCode)
                    {
                        case Keys.Enter:
                            SeleccionarNodo(ucSeg_Menu_x_Usuario_x_Empresa1.treeListMenu_x_Usuario_x_Empresa.Selection[0]);
                            break;
                        case Keys.Left:
                            ucSeg_Menu_x_Usuario_x_Empresa1.treeListMenu_x_Usuario_x_Empresa.Selection[0].Expanded = false;
                            break;
                        case Keys.Right:
                            ucSeg_Menu_x_Usuario_x_Empresa1.treeListMenu_x_Usuario_x_Empresa.Selection[0].Expanded = true;
                            break;
                    }
                }
                else
                {

                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        void ucSeg_Menu_x_Usuario_x_Empresa1_event_treeListMenu_x_Usuario_x_Empresa_NodeCellStyle(object sender, DevExpress.XtraTreeList.GetCustomNodeCellStyleEventArgs e)
        {
            try
            {
                if (e.Node.GetValue("IdMenuPadre") as int? == 0)
                {
                    e.Appearance.Font = new Font(e.Appearance.Font, FontStyle.Bold);
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        void ucSeg_Menu_x_Usuario_x_Empresa1_event_treeListMenu_x_Usuario_x_Empresa_SelectImageClick(object sender, DevExpress.XtraTreeList.NodeClickEventArgs e)
        {
            try
            {
                SeleccionarNodo(e.Node);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SeleccionarNodo(DevExpress.XtraTreeList.Nodes.TreeListNode nodo)
        {
            try
            {
                if (nodo.Id == -100000)
                {
                    ucSeg_Menu_x_Usuario_x_Empresa1.treeListMenu_x_Usuario_x_Empresa.ExpandAll();
                }
                else
                {
                    if ((bool)nodo.GetValue("Tiene_FormularioAsociado"))
                    {
                        InfoMenu.IdMenu = (int)nodo.GetValue("IdMenu");
                        InfoMenu.IdMenuPadre = (int)nodo.GetValue("IdMenuPadre");
                        InfoMenu.DescripcionMenu = (string)nodo.GetValue("DescripcionMenu");
                        InfoMenu.PosicionMenu = (int)nodo.GetValue("PosicionMenu");
                        InfoMenu.Habilitado = (bool)nodo.GetValue("Habilitado");
                        InfoMenu.Tiene_FormularioAsociado = (bool)nodo.GetValue("Tiene_FormularioAsociado");
                        InfoMenu.nom_Formulario = (string)nodo.GetValue("nom_Formulario");
                        InfoMenu.nom_Asembly = (string)nodo.GetValue("nom_Asembly");

                        InfoMenu.nivel = (int)nodo.GetValue("nivel");
                        this.Cursor = Cursors.WaitCursor;
                        LlamarFormulario();
                        MarcarNodoPadre(nodo);
                    }
                }

            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

        private void MarcarNodoPadre(DevExpress.XtraTreeList.Nodes.TreeListNode nodo)
        {
            try
            {
                if (nodo.ParentNode != null)
                {
                    if (nodo.GetValue("IdMenuPadre") as int? != 0)
                    {
                        if (!(bool)nodo.ParentNode.GetValue("Tiene_FormularioAsociado"))
                        {
                            nodo.ParentNode.Selected = true;
                        }
                        else
                        {
                            MarcarNodoPadre(nodo.ParentNode);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void CapturarEventosApariencia(BarItemLinkCollection links)
        {
            try
            {
                foreach (var item in links)
                {
                    if (item.GetType() == typeof(BarSubItemLink))
                    {
                        BarSubItemLink subItems = (BarSubItemLink)item;
                        CapturarEventosApariencia(subItems.Item.ItemLinks);
                    }
                    if (item.GetType() == typeof(BarButtonItemLink))
                    {
                        BarButtonItemLink barItem = (BarButtonItemLink)item;
                        barItem.Item.ItemPress += itemAparienciaPresionado;
                    }
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void EstablecerTema(BarItemLinkCollection links)
        {
            try
            {
                foreach (var item in links)
                {
                    if (item.GetType() == typeof(BarSubItemLink))
                    {
                        BarSubItemLink subItems = (BarSubItemLink)item;
                        CapturarEventosApariencia(subItems.Item.ItemLinks);
                    }
                    if (item.GetType() == typeof(BarButtonItemLink))
                    {
                        BarButtonItemLink barItem = (BarButtonItemLink)item;
                    }
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            try
            {
                DevExpress.UserSkins.BonusSkins.Register();
                SkinHelper.InitSkinPopupMenu(blcApariencia);
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

                EstablecerTema(blcApariencia.ItemLinks);
                CapturarEventosApariencia(blcApariencia.ItemLinks);

                if (ValidarIngreso())
                {
                    string mensajeError = "";

                    CargarMenu(ref mensajeError);
                    ucSeg_Menu_x_Usuario_x_Empresa1.treeListMenu_x_Usuario_x_Empresa.Focus();
                    lbl_usuario.Caption = param.IdUsuario;
                    lbl_empresa.Caption = "[" + param.IdEmpresa + "] - " + param.NombreEmpresa;
                    barStaticItem_param.Caption = "Usuario: " + param.IdUsuario  + "   Empresa:[" + param.IdEmpresa + "] - " + param.NombreEmpresa;

                    if (param.InfoEmpresa.em_logo != null)
                    {
                        // pictureEditLogo.Image = Funciones.ArrayAImage(param.InfoEmpresa.em_logo);
                    }
                }

                Cargar_Menu_Ribbon_x_Usuario();
                Cargar_Combo();

                bei_progressBar.Caption = "0.00%";
                bei_progressBar.EditValue = 0;

                // PARAMETRO MAIL NOTIFICACION CONFIG
                if (param.EmiteNotificacion)
                {
                    //INICIALIZA LOS EVENTOS DELEGADOS DE LA BARRA DE PROGRESO
                    bw.ProgressChanged += new ProgressChangedEventHandler(bw_ProgressChanged);
                    bw.RunWorkerCompleted += bw_RunWorkerCompleted;
                    bw.DoWork += bw_DoWork;
                   
                    lbl_notificacion_status.Visibility = BarItemVisibility.Always;
                    beiProgressEnvioCorreo.Visibility = BarItemVisibility.Always;
                    btnBandejaSalida.Visibility = BarItemVisibility.Always;
                }
                else
                {
                    lbl_notificacion_status.Visibility = BarItemVisibility.Never;
                    beiProgressEnvioCorreo.Visibility = BarItemVisibility.Never;
                    btnBandejaSalida.Visibility = BarItemVisibility.Never;
                }               
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
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
                    System.Windows.Forms.Application.Exit();
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

                mail_Notificacion_Config_Bus bus_mail_notificacion = new mail_Notificacion_Config_Bus();
                mail_Notificacion_Config_Info Info_mail_Notificacion;

                if (bus_mail_notificacion.ExisteBD(param.IdEmpresa, param.IdUsuario, param.nom_pc))
                {
                    Info_mail_Notificacion = bus_mail_notificacion.Get_Info(param.IdEmpresa, param.IdUsuario, param.nom_pc);
                }
                else
                {
                    Info_mail_Notificacion = new mail_Notificacion_Config_Info();
                    Info_mail_Notificacion.IdEmpresa = param.IdEmpresa;
                    Info_mail_Notificacion.IdUsuario = param.IdUsuario;
                    Info_mail_Notificacion.HostName = param.nom_pc;
                    Info_mail_Notificacion.EmiteNotificacion = false; // Por default los usuarios no emiten notificacion

                    bus_mail_notificacion.GrabarBD(Info_mail_Notificacion);
                }

                // Asignamos de manera global la configuracion de notificacion
                param.EmiteNotificacion = Info_mail_Notificacion.EmiteNotificacion;

                byte[] fondo = BusEmpresa.Get_Fondo_Pantalla_x_Empresa(param.InfoEmpresa.IdEmpresa);

                if (fondo != null)
                {
                    this.BackgroundImage = Funciones.ArrayAImage(fondo);
                }

                if (InfoEmpresa.em_nombre.Equals("DESARROLLO") || InfoEmpresa.em_nombre.Equals("DESarrollo") || InfoEmpresa.em_nombre.Equals("desARROllo") || InfoEmpresa.em_nombre.Equals("desarroLLO"))
                {
                    LBLMENSAJE.Visible = true;
                }
                if (InfoEmpresa.em_nombre.Equals("PRUEBAS") || InfoEmpresa.em_nombre.Equals("PRUEBA") || InfoEmpresa.em_nombre.Equals("Prueba") || InfoEmpresa.em_nombre.Equals("Pruebas"))
                {
                    LBLMENSAJE.Visible = true;
                    LBLMENSAJE.Text = "AMBIENTE DE PRUEBAS";
                }

                return true;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return false;
            }
        }

        private void LlamarFormulario()
        {
            try
            {
                if (InfoMenu.Tiene_FormularioAsociado == false)
                {
                    return;
                }

                string NombreFormulario = InfoMenu.nom_Formulario;
                string Nombre_Asamble = InfoMenu.nom_Asembly;
                string nombre_dll = "";

                string RutaPantalla = "";

                nombre_dll = Nombre_Asamble;
                System.Reflection.Assembly Ensamblado;
                Ensamblado = System.Reflection.Assembly.LoadFrom(nombre_dll);
                System.Reflection.AssemblyName assemName = Ensamblado.GetName();
                Version ver = assemName.Version;

                Object ObjFrm;
                Type tipo = Ensamblado.GetType(assemName.Name + "." + NombreFormulario);

                RutaPantalla = assemName.Name + "." + NombreFormulario;

                if (tipo == null)
                {
                    MessageBox.Show("No se encontró el formulario Emsamblado:" + Nombre_Asamble + "  Formulario:" + NombreFormulario, "Error de ubicación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (!this.FormularioEstaAbierto(NombreFormulario))
                    {
                        ObjFrm = Activator.CreateInstance(tipo);
                        Form Formulario = (Form)ObjFrm;
                        //Formulario.Text = InfoMenu.DescripcionMenu + " Version:" + ver.ToString();
                        Formulario.Text = InfoMenu.DescripcionMenu;
                        Formulario.MdiParent = this;
                        Formulario.Tag = InfoMenu;
                        Formulario.WindowState = FormWindowState.Maximized;
                        Formulario.Show();
                    }
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private Boolean FormularioEstaAbierto(String NombreDelFrm)
        {
            try
            {
                bool estaAbierto = false;
                if (this.MdiChildren.Length > 0)
                {
                    for (int i = 0; i < this.MdiChildren.Length; i++)
                    {
                        int posicion = NombreDelFrm.LastIndexOf('.');
                        string nombreCorto = NombreDelFrm.Substring(posicion + 1, NombreDelFrm.Length - posicion - 1);
                        if (posicion != -1)
                        {
                            if (nombreCorto.Equals(this.MdiChildren[i].Name))
                            {
                                estaAbierto = true;
                            }
                        }
                        else if (NombreDelFrm.Contains(this.MdiChildren[i].Name))
                        {
                            estaAbierto = true;
                        }

                        if (estaAbierto)
                        {
                            this.MdiChildren[i].Focus();
                            MessageBox.Show("El formulario o reporte solicitado ya se encuentra abierto");
                            return true;
                        }
                    }
                    return false;
                }
                else
                    return false;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return false;
            }

        }

        public void CargarMenu(ref string MensajeError)
        {
            try
            {
                string idUsuario = param.IdUsuario;
                int idEmpresa = param.IdEmpresa;
                string mensaje = "";
                List<seg_Menu_info> lMenuInfo = BusMenu.Get_List_Menu_x_Empresa_x_Usuario(idUsuario, idEmpresa, ref MensajeError);
                //MensajeError = mensaje;
                //ucSeg_Menu_x_Usuario_x_Empresa1.treeListMenu_x_Usuario_x_Empresa.SelectImageList = ucSeg_Menu_x_Usuario_x_Empresa1.imageCollection1;
                //ucSeg_Menu_x_Usuario_x_Empresa1.treeListMenu_x_Usuario_x_Empresa.ColumnsImageList = ucSeg_Menu_x_Usuario_x_Empresa1.imageCollection1;
                ucSeg_Menu_x_Usuario_x_Empresa1.treeListMenu_x_Usuario_x_Empresa.DataSource = null;
                ucSeg_Menu_x_Usuario_x_Empresa1.treeListMenu_x_Usuario_x_Empresa.DataSource = lMenuInfo;
                EstablecerIcono(ucSeg_Menu_x_Usuario_x_Empresa1.treeListMenu_x_Usuario_x_Empresa.Nodes);
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + MensajeError + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void EstablecerIcono(DevExpress.XtraTreeList.Nodes.TreeListNodes lnodos)
        {
            try
            {
                foreach (DevExpress.XtraTreeList.Nodes.TreeListNode nodo in lnodos)
                {
                    string descripcion = (string)nodo.GetValue("DescripcionMenu");

                    if (nodo.Nodes.Count > 0)
                    {
                        EstablecerIcono(nodo.Nodes);
                    }
                    else if ((bool)nodo.GetValue("Tiene_FormularioAsociado"))
                    {
                        nodo.ImageIndex = 2;
                        nodo.SelectImageIndex = 2;
                    }

                    if ((bool)nodo.GetValue("Tiene_FormularioAsociado"))
                    {
                        nodo.ImageIndex = 2;
                        nodo.SelectImageIndex = 2;
                    }
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void btnMostrarMenu_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                switch (dockPanelMenu.Visibility)
                {
                    case DevExpress.XtraBars.Docking.DockVisibility.AutoHide:
                        {
                            dockPanelMenu.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden;
                            break;
                        }
                    case DevExpress.XtraBars.Docking.DockVisibility.Hidden:
                        {
                            dockPanelMenu.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Visible;
                            break;
                        }
                    case DevExpress.XtraBars.Docking.DockVisibility.Visible:
                        {
                            dockPanelMenu.Visibility = DevExpress.XtraBars.Docking.DockVisibility.AutoHide;
                            break;
                        }
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void btnLogOut_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void btnSalir_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                if (MessageBox.Show("¿Está seguro que desea cerrar la aplicación?", param.Nombre_sistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Cerrar = true;
                    System.Windows.Forms.Application.Exit();
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void itemAparienciaPresionado(object sender, ItemClickEventArgs e)
        {
            try
            {
                Properties.Settings.Default.SkinName = e.Item.Caption;
                Properties.Settings.Default.Save();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ucSeg_Menu_x_Usuario_x_Empresa1_Load(object sender, EventArgs e)
        {

        }

        private void ribbon_Click(object sender, EventArgs e)
        {

        }

        private void Cargar_Menu_Ribbon_x_Usuario()
        {
            try
            {
                ribbonMenuTop.Images = imageCollection64_x_64;
            }
            catch (Exception ex)
            {

                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        void BarButton_item_Click(object sender, ItemClickEventArgs e)
        {
            
        }

        void Cargar_Combo()
        {
            try
            {

                listReporte = BusReporte.Get_List_reporte(true);
                cmb_reportes.DataSource = listReporte;

            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }

        }

        private void barEditItem_Reportes_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (barEditItem_Reportes.EditValue != null)
                {
                    tb_sis_reporte_Info Info_reporte = new tb_sis_reporte_Info();
                    Info_reporte = listReporte.FirstOrDefault(v => v.CodReporte == barEditItem_Reportes.EditValue.ToString());

                    if (Info_reporte != null)
                    {
                        if (Info_reporte.CodReporte != "")
                        {
                            string NombreFormulario = Info_reporte.Formulario;
                            string Nombre_Asamble = Info_reporte.nom_Asembly + ".dll";
                            string nombre_dll = "";
                            string RutaPantalla = "";

                            nombre_dll = Nombre_Asamble;
                            System.Reflection.Assembly Ensamblado;
                            Ensamblado = System.Reflection.Assembly.LoadFrom(nombre_dll);
                            System.Reflection.AssemblyName assemName = Ensamblado.GetName();
                            Version ver = assemName.Version;

                            Object ObjFrm;
                            Type tipo = Ensamblado.GetType(assemName.Name + "." + NombreFormulario);

                            RutaPantalla = assemName.Name + "." + NombreFormulario;

                            if (tipo == null)
                            {
                                MessageBox.Show("No se encontró el formulario de este reporte:" + Nombre_Asamble + "  Formulario:" + NombreFormulario, "Error de ubicación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                if (!this.FormularioEstaAbierto(NombreFormulario))
                                {
                                    ObjFrm = Activator.CreateInstance(tipo);
                                    Form Formulario = (Form)ObjFrm;
                                    Formulario.Text = Info_reporte.Nombre + " Version:" + Info_reporte.VersionActual.ToString();
                                    Formulario.MdiParent = this;
                                    Formulario.Tag = Info_reporte;
                                    Formulario.WindowState = FormWindowState.Maximized;
                                    Formulario.Show();
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (!Cerrar)
                    if (MessageBox.Show("¿Está seguro que desea cerrar la aplicación?", param.Nombre_sistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    {
                        e.Cancel = true;
                    }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void listMdiChildren_ListItemClick(object sender, ListItemClickEventArgs e)
        {

        }

        BackgroundWorker bw = new BackgroundWorker
        {
            WorkerReportsProgress = true,
            WorkerSupportsCancellation = true
        };

        void bw_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            try
            {
                if (e.ProgressPercentage <= progressBar.Maximum)
                {
                    lbl_notificacion_status.Caption = "Enviando correo:";
                    beiProgressEnvioCorreo.EditValue = e.ProgressPercentage;
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }
        }

        void bw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            try
            {
                if (e.Cancelled)
                {
                    lbl_notificacion_status.Caption = "Proceso cancelado..";
                    beiProgressEnvioCorreo.EditValue = 0;
                    return;
                }

                if (e.Error != null) {
                    lbl_notificacion_status.Caption = "Error: " + e.Error.Message;
                    return;
                }

                lbl_notificacion_status.Caption = "Envio completado";
                beiProgressEnvioCorreo.EditValue = 0;
                timerContadorSegundos.Enabled = true;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }
        }

        void bw_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                timerContadorSegundos.Enabled = false;

                int i = 0;
                int numFila = 0;
                double percent = 0;

                mail_Mail_Bus Bus_Mail = new mail_Mail_Bus();
                List<mail_Mail_Info> List_Mail = new List<mail_Mail_Info>();

                List_Mail = Bus_Mail.Get_List(param.IdEmpresa, param.IdSucursal, param.IdUsuario, 10);

                numFila = List_Mail.Count();
                i = 0;

                foreach (var item in List_Mail)
                {
                    string mensaje = "";

                    //DETIENE EL PROCESO SOLICTADO POR EL USUARIO
                    if (bw.CancellationPending)
                    {
                        e.Cancel = true;
                        return;
                    }

                    Bus_Mail.Emviar_Mail(item, ref mensaje);

                    i++;
                    percent = (Convert.ToDouble(i) / Convert.ToDouble(numFila)) * 100;
                    bw.ReportProgress((int)percent);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        BackgroundWorker bw_marcacion = new BackgroundWorker
        {
            WorkerReportsProgress = true,
            WorkerSupportsCancellation = true
        };

        void bw_marcacion_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            try
            {
                if (e.ProgressPercentage <= progressBar.Maximum)
                {
                    beiProgressEnvioCorreo.EditValue = e.ProgressPercentage;
                    lbl_notificacion_status.Caption = "Descargando marcaciones:";
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }
        }

        void bw_marcacion_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            try
            {
                if (e.Cancelled)
                {
                    lbl_notificacion_status.Caption = "Proceso cancelado..";
                    return;
                }

                if (e.Error != null)
                {
                    lbl_notificacion_status.Caption = "Error: " + e.Error.Message;
                    return;
                }

                lbl_notificacion_status.Caption = "Descarga completada";
                beiProgressEnvioCorreo.EditValue = 0;

                timerContadorSegundos.Enabled = true;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }
        }

    }
}