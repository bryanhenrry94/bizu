using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data.Sql;
using Bizu.Application.General;
using Bizu.Domain.General;

namespace Bizu.Presentation.General
{
    public partial class FrmGe_Conexion_DBFacturacion_Electronica : DevExpress.XtraEditors.XtraForm
    {
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_Conexion_DBFacturacion_Electronica_Bus Bus_Configuracion_BD = new tb_Conexion_DBFacturacion_Electronica_Bus();
        tb_Conexion_DBFacturacion_Electronica_Info Info = new tb_Conexion_DBFacturacion_Electronica_Info();

        public FrmGe_Conexion_DBFacturacion_Electronica()
        {
            InitializeComponent();

            ucGe_Menu.event_btnGuardar_Click += ucGe_Menu_event_btnGuardar_Click;
            ucGe_Menu.event_btnGuardar_y_Salir_Click += ucGe_Menu_event_btnGuardar_y_Salir_Click;
            ucGe_Menu.event_btnSalir_Click += ucGe_Menu_event_btnSalir_Click;
        }

        void ucGe_Menu_event_btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void ucGe_Menu_event_btnGuardar_y_Salir_Click(object sender, EventArgs e)
        {
            if (Guardar()) this.Close();
        }

        void ucGe_Menu_event_btnGuardar_Click(object sender, EventArgs e)
        {
            Guardar();
        }

        private void FrmGe_Parametro_BaseExterna_Load(object sender, EventArgs e)
        {
            Set_Info_In_Control();
        }

        private void Set_Info_In_Control()
        {
            try
            {
                Info = Bus_Configuracion_BD.Get_Info(param.IdEmpresa);
                cmb_tipo_base.Text = Info.Tipo_BaseDatos;
                txt_server.EditValue = Info.Servidor;
                txt_puerto.EditValue = Info.Puerto;
                chk_autenticacion_windows.Checked = Convert.ToBoolean(Info.AutenticacionWindows);
                txt_usuario.EditValue = Info.Usuario;
                txt_contrasena.EditValue = Info.Contrasena;
                txt_base_datos.EditValue = Info.Nombre_BaseDatos;
                txt_cadena_conexion.EditValue = Info.Cadena_Conexion;
                txt_script_comprobantes_recibidos.Text = Info.Script_ComprobantesRecibidos;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Get_Info()
        {
            try
            {
                Info = new tb_Conexion_DBFacturacion_Electronica_Info();
                Info.IdEmpresa = param.IdEmpresa;
                Info.Tipo_BaseDatos = cmb_tipo_base.Text;
                Info.Servidor = Convert.ToString(txt_server.EditValue);
                Info.Puerto = Convert.ToInt32(txt_puerto.EditValue);
                Info.AutenticacionWindows = chk_autenticacion_windows.Checked;
                Info.Usuario = Convert.ToString(txt_usuario.EditValue);
                Info.Contrasena = Convert.ToString(txt_contrasena.EditValue);
                Info.Nombre_BaseDatos = Convert.ToString(txt_base_datos.EditValue);
                Info.Cadena_Conexion = Convert.ToString(txt_cadena_conexion.EditValue);
                Info.Script_ComprobantesRecibidos = txt_script_comprobantes_recibidos.Text;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private bool Guardar()
        {
            try
            {
                string mensaje = "";

                if (!Validar()) return false;

                Get_Info();

                if (Bus_Configuracion_BD.Existe(param.IdEmpresa))
                {
                    if (Bus_Configuracion_BD.ModificarBD(Info, ref mensaje))
                    {
                        MessageBox.Show(mensaje, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    if (Bus_Configuracion_BD.GrabarBD(Info, ref mensaje))
                    {
                        MessageBox.Show(mensaje, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private bool Validar()
        {
            try
            {


                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void set_Cadena_Conexion()
        {
            try
            {
                switch (cmb_tipo_base.Text)
                {
                    case "Microsoft SQL Server":
                        if (chk_autenticacion_windows.Checked)
                        {
                            txt_cadena_conexion.EditValue = "Provider=SQLOLEDB;Data Source=" + Convert.ToString(txt_server.EditValue) + ";Initial Catalog=" + Convert.ToString(txt_base_datos.EditValue) + ";integrated security=SSPI;";
                        }
                        else
                        {
                            if (txt_puerto.EditValue != null && Convert.ToInt32(txt_puerto.EditValue) != 0)
                            {
                                txt_cadena_conexion.EditValue = "Provider=SQLOLEDB;Data Source=" + Convert.ToString(txt_server.EditValue) + "," + Convert.ToString(txt_puerto.EditValue) + ";Initial Catalog=" + Convert.ToString(txt_base_datos.EditValue) + ";User Id=" + Convert.ToString(txt_usuario.EditValue) + ";Password=" + Convert.ToString(txt_contrasena.EditValue);
                            }
                            else
                            {
                                txt_cadena_conexion.EditValue = "Provider=SQLOLEDB;Data Source=" + Convert.ToString(txt_server.EditValue) + ";Initial Catalog=" + Convert.ToString(txt_base_datos.EditValue) + ";User Id=" + Convert.ToString(txt_usuario.EditValue) + ";Password=" + Convert.ToString(txt_contrasena.EditValue);
                            }
                        }
                        break;

                    case "Oracle":
                        txt_cadena_conexion.EditValue = "Provider=MSDAORA;Data Source=" + Convert.ToString(txt_base_datos.EditValue) + ";User Id=" + Convert.ToString(txt_usuario.EditValue) + ";Password=" + Convert.ToString(txt_contrasena.EditValue);
                        break;

                    default:
                        txt_cadena_conexion.EditValue = "";

                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void cmb_tipo_base_SelectedIndexChanged(object sender, EventArgs e)
        {
            set_Cadena_Conexion();
        }

        private void txt_server_EditValueChanged(object sender, EventArgs e)
        {
            set_Cadena_Conexion();
        }

        private void txt_puerto_EditValueChanged(object sender, EventArgs e)
        {
            set_Cadena_Conexion();
        }

        private void chk_autenticacion_windows_CheckedChanged(object sender, EventArgs e)
        {
            txt_usuario.Properties.ReadOnly = chk_autenticacion_windows.Checked;
            txt_contrasena.Properties.ReadOnly = chk_autenticacion_windows.Checked;

            set_Cadena_Conexion();
        }

        private void txt_usuario_EditValueChanged(object sender, EventArgs e)
        {
            set_Cadena_Conexion();
        }

        private void txt_contrasena_EditValueChanged(object sender, EventArgs e)
        {
            set_Cadena_Conexion();
        }

        private void txt_base_datos_EditValueChanged(object sender, EventArgs e)
        {
            set_Cadena_Conexion();
        }

        private void btn_probar_conexion_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmb_tipo_base.Text == "")
                {
                    MessageBox.Show("Seleccione el tipo de Base!", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    cmb_tipo_base.Focus();
                    return;
                }

                if (txt_cadena_conexion.EditValue == null)
                {
                    MessageBox.Show("Ingrese la cadena de conexion!", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txt_cadena_conexion.Focus();
                    return;
                }

                switch (cmb_tipo_base.Text)
                {
                    case "Microsoft SQL Server":
                        using (OleDbConnection connection = new OleDbConnection(Convert.ToString(txt_cadena_conexion.EditValue)))
                        {
                            try
                            {
                                connection.Open();
                                MessageBox.Show("Conexión establecida con éxito!", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            catch (Exception exception)
                            {
                                MessageBox.Show(exception.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }
                        }

                        break;

                    default:
                        MessageBox.Show("No se ha configurado este tipo de conexión, comuniquese con sistemas!", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_ejecutar_script_Click(object sender, EventArgs e)
        {
            switch (cmb_tipo_base.Text)
            {
                case "Microsoft SQL Server":
                    string sCnn;
                    sCnn = Convert.ToString(txt_cadena_conexion.EditValue);

                    string sSel = txt_script_comprobantes_recibidos.Text;

                    try
                    {
                        OleDbDataAdapter resulSql;
                        DataTable dt = new DataTable();
                        OleDbCommand oCom;
                        OleDbConnection conexion = new OleDbConnection(sCnn);

                        oCom = new OleDbCommand(sSel, conexion);

                        oCom.CommandTimeout = 200;
                        resulSql = new OleDbDataAdapter(oCom);

                        resulSql.SelectCommand.CommandType = CommandType.Text;
                        resulSql.SelectCommand.CommandText = sSel;
                        resulSql.Fill(dt);

                        oCom.Dispose();

                        this.gridControl_Comprobantes_Recibidos.DataSource = dt;

                        MessageBox.Show("Info: " + String.Format("Total datos en la tabla: {0}", dt.Rows.Count), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (OleDbException ex)
                    {
                        MessageBox.Show("Error: " + ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    break;

                default:
                    MessageBox.Show("No se ha configurado este tipo de conexión, comuniquese con sistemas!", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    break;
            }
        }

    }
}
