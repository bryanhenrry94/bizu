using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Bizu.Application.CuentasxPagar;
using Bizu.Domain.CuentasxPagar;
using Bizu.Application.Facturacion;
using Bizu.Domain.Facturacion;
using Bizu.Domain.General;
using Bizu.Application.General;
using Bizu.Presentation.General;

namespace Bizu.Presentation.CuentasxPagar
{
    public partial class frmCP_Proveedor_TerminoPago_Mant : DevExpress.XtraEditors.XtraForm
    {
        #region Declaración de variables
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cp_TerminoPago_Bus TerminoPagoBus = new cp_TerminoPago_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        cp_TerminoPago_Info _Info = new cp_TerminoPago_Info();
        //fa_TerminoPago_Distribucion_Bus terminoDisBus = new fa_TerminoPago_Distribucion_Bus();
        //BindingList<fa_TerminoPago_Distribucion_Info> lstTerminoDis = new BindingList<fa_TerminoPago_Distribucion_Info>();
        //BindingList<fa_TerminoPago_Distribucion_Info> temp = new BindingList<fa_TerminoPago_Distribucion_Info>();
        public Cl_Enumeradores.eTipo_action _Accion { get; set; }
        public delegate void delegate_frmCP_Proveedor_TerminoPago_Mantenimiento_FormClosing(object sender, FormClosingEventArgs e);
        public event delegate_frmCP_Proveedor_TerminoPago_Mantenimiento_FormClosing Event_frmCP_Proveedor_TerminoPago_Mantenimiento_FormClosing;
        float PorcentajeTotal = 0;
        string MensajeError = "";

        #endregion
             
        public frmCP_Proveedor_TerminoPago_Mant()
        {
            try
            {
                InitializeComponent();
                ucGe_Menu.event_btnAnular_Click += ucGe_Menu_event_btnAnular_Click;
                ucGe_Menu.event_btnGuardar_Click += ucGe_Menu_event_btnGuardar_Click;
                ucGe_Menu.event_btnGuardar_y_Salir_Click += ucGe_Menu_event_btnGuardar_y_Salir_Click;
                ucGe_Menu.event_btnlimpiar_Click += ucGe_Menu_event_btnlimpiar_Click;
                ucGe_Menu.event_btnSalir_Click += ucGe_Menu_event_btnSalir_Click;
                Event_frmCP_Proveedor_TerminoPago_Mantenimiento_FormClosing += frmCP_Proveedor_TerminoPago_Mant_event_FrmCom_TerminoPagos_Mant_FormClosing;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        void frmCP_Proveedor_TerminoPago_Mant_event_FrmCom_TerminoPagos_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        void ucGe_Menu_event_btnSalir_Click(object sender, EventArgs e)
        {
            try
            {
                Close();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void ucGe_Menu_event_btnlimpiar_Click(object sender, EventArgs e)
        {
            try
            {
                LimpiarDatos();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void ucGe_Menu_event_btnGuardar_y_Salir_Click(object sender, EventArgs e)
        {
            try
            {
                if (guardarDatos())
                {
                    this.Close();
                }     
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void ucGe_Menu_event_btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                guardarDatos();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        void ucGe_Menu_event_btnAnular_Click(object sender, EventArgs e)
        {
            try
            {
                if (lblAnulado.Visible)
                {
                    MessageBox.Show("El registro ya se encuentra anulado", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ucGe_Menu.Enabled_bntAnular = false;
                }
                else
                {
                    Anular();
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        Boolean guardarDatos()
        {
            try
            {
                Boolean bolResult = false;
                 if (Validar())
                {
                    //if (validarPorDistribucion())
                    //{
                        //if (PorcentajeTotal == 100)
                        //{
                            string msjError = "";
                            Get();
                            if (Cl_Enumeradores.eTipo_action.grabar == _Accion)
                            {
                                if (TerminoPagoBus.GuardarDB(_Info, ref msjError))
                                {
                                    bolResult = true;
                                    string smensaje = string.Format("{0} # {1} se guardó con éxito.", "El Término de Pago", _Info.IdTerminoPago);
                                    MessageBox.Show(smensaje, param.Nombre_sistema);
                                    //ucGe_Menu.Enabled_bntGuardar_y_Salir = false;
                                    //ucGe_Menu.Enabled_btnGuardar = false;
                                    LimpiarDatos();
                                }
                                else
                                {
                                    MessageBox.Show("Error " + msjError, "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                            }
                            if (Cl_Enumeradores.eTipo_action.actualizar == _Accion)
                            {
                                if (TerminoPagoBus.ModificarDB(_Info, ref msjError))
                                {
                                    bolResult = true;                                   
                                    string smensaje = string.Format("{0} # {1} se modificó con éxito.", "El Término de Pago", _Info.IdTerminoPago);
                                    MessageBox.Show(smensaje, param.Nombre_sistema);  
                                    //ucGe_Menu.Enabled_bntGuardar_y_Salir = false;
                                    //ucGe_Menu.Enabled_btnGuardar = false;
                                    LimpiarDatos();
                                }
                                else {
                                    MessageBox.Show("Error " + msjError, "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                            }
                        //}
                    //}

                }
                 return bolResult;
            }
            catch (Exception ex)
            {
                 Log_Error_bus.Log_Error(ex.ToString());
                 MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                 return false;
            }
        }

        public void setInfo(cp_TerminoPago_Info _Info)
        {
            try
            {
                this._Info = _Info;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void Set()
        {
            try
            {

                txtCodigo.Text = _Info.IdTerminoPago;
                txtDescripcion.Text = _Info.nom_TerminoPago;
                txtDias.Text = _Info.Dias_Vct.ToString();
                txtCuota.Text = _Info.Num_Coutas.ToString();
                
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void Get()
        {
            try
            {
                _Info.IdEmpresa = param.IdEmpresa;
                _Info.IdTerminoPago = txtCodigo.Text;
                _Info.nom_TerminoPago = txtDescripcion.Text;
                _Info.Num_Coutas = Convert.ToInt32(txtCuota.Text);
                _Info.Dias_Vct = Convert.ToInt32(txtDias.Text);
                _Info.Estado = "A";
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void load()
        {
            try
            {
                switch (_Accion)
                { 
                    case Cl_Enumeradores.eTipo_action.actualizar:
                        Set();
                        txtCodigo.ReadOnly = true;
                        txtCodigo.ForeColor = Color.Black;
                        txtCodigo.BackColor = Color.White;
                        ucGe_Menu.Visible_bntLimpiar = DevExpress.XtraBars.BarItemVisibility.Never;
                        //obtenerGrid();
                        break;

                    case Cl_Enumeradores.eTipo_action.consultar:
                        Set();
                        ucGe_Menu.Enabled_bntGuardar_y_Salir = false;
                        ucGe_Menu.Enabled_btnGuardar = false;
                        ucGe_Menu.Visible_bntLimpiar = DevExpress.XtraBars.BarItemVisibility.Never;
                        BloquearDatos();
                        //obtenerGrid();
                        break;
                    case Cl_Enumeradores.eTipo_action.grabar:


                        Set();


                        break;

                    case Cl_Enumeradores.eTipo_action.Anular:
                        Set();
                        ucGe_Menu.Enabled_bntGuardar_y_Salir = false;
                        ucGe_Menu.Enabled_btnGuardar = false;
                        break;
                }



            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //private void obtenerGrid()
        //{
        //    try
        //    {
        //        gridControlDistribucion.DataSource = lstTerminoDis = new BindingList<fa_TerminoPago_Distribucion_Info>( terminoDisBus.Get_List_TerminoPago_Distribucion(_Info.IdTerminoPago));
        //    }
        //    catch (Exception ex)
        //    {
        //        Log_Error_bus.Log_Error(ex.ToString());
        //        MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}

         public Boolean Validar()
         {
             try
             {
                 if (txtCodigo.Text == "" || txtCodigo.Text == null)
                 {
                     MessageBox.Show("Ingrese el Codigo por favor", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                     return false;
                 }
                 if (txtDescripcion.Text == "" || txtDescripcion.Text == null)
                 {
                     MessageBox.Show("Ingrese la Descripción por favor","Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                     return false;
                 }
                 if (Convert.ToInt32(txtCuota.Text) == 0 || txtCuota.Text == "")
                 {
                     MessageBox.Show("Ingrese la Cuota por favor", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                     return false;
                 }
                 if (Convert.ToInt32(txtDias.Text) == 0 || txtDias.Text == "")
                 {
                     MessageBox.Show("Ingrese los dias por favor", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                     return false;
                 }
                 if (Convert.ToInt32(txtCuota.Text) > Convert.ToInt32(txtDias.Text))
                 {
                     MessageBox.Show("Los dias deben ser mayor a la cuota", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                     return false;
                 }
                 return true;
             }
             catch (Exception ex)
             {
                 Log_Error_bus.Log_Error(ex.ToString());
                 MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                 return false;
             }
         }

        //private void calcular()
        //{
        //    try
        //    {
        //        if (txtCuota.Text != "" && txtDias.Text != "")
        //        {
        //            int cuota = Convert.ToInt32(txtCuota.Text);
        //            int dias = Convert.ToInt32(txtDias.Text);
        //            PorcentajeTotal = 0;
        //            if (cuota <= dias)
        //            {
        //                gridControlDistribucion.DataSource = lstTerminoDis = new BindingList<fa_TerminoPago_Distribucion_Info>();
        //                string codigo = txtCodigo.Text;

        //                int standarDias = dias / cuota; ;
        //                int acumDias = 0;
        //                int mod = dias % cuota;
        //                float Porcentaje = 100 / cuota;


        //                fa_TerminoPago_Distribucion_Info TerminoPago;
        //                for (int i = 1; i <= cuota; i++)
        //                {
        //                    if ((cuota - mod) < i)
        //                    {
        //                        acumDias = acumDias + standarDias + 1;
        //                    }
        //                    else
        //                    {
        //                        acumDias = acumDias + standarDias;
        //                    }

        //                    TerminoPago = new fa_TerminoPago_Distribucion_Info();

        //                    TerminoPago.Secuencia = i;
        //                    TerminoPago.Num_Dias_Vcto = acumDias;
        //                    if (cuota == i)
        //                    {
        //                        Porcentaje = 100 - PorcentajeTotal;
        //                        TerminoPago.Por_distribucion = Porcentaje;
        //                    }
        //                    else
        //                    {
        //                        TerminoPago.Por_distribucion = Porcentaje;
        //                    }
        //                    TerminoPago.IdTerminoPago = codigo;

        //                    lstTerminoDis.Add(TerminoPago);
        //                    PorcentajeTotal = PorcentajeTotal + Porcentaje;
        //                }

        //               // lstTerminoDis.Add(new fa_TerminoPago_Distribucion_Info { Por_distribucion = PorcentajeTotal });
        //            }
        //            else
        //            {
        //                gridControlDistribucion.DataSource = lstTerminoDis = temp;
        //            }
        //            gridViewDistribucion.RefreshData();
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        Log_Error_bus.Log_Error(ex.ToString());
        //        MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}

        void BloquearDatos()
        {
            try
            {
                txtCodigo.ReadOnly = true;
                txtCodigo.ForeColor = Color.Black;
                txtCodigo.BackColor = Color.White;
                txtDias.ReadOnly = true;
                txtDias.BackColor = Color.White;
                txtDias.ForeColor = Color.Black;

                txtDescripcion.ReadOnly = true;
                txtDescripcion.ForeColor = Color.Black;
                txtDescripcion.BackColor = Color.White;

                txtCuota.ReadOnly = true;
                txtCuota.BackColor = Color.White;
                txtCuota.ForeColor = Color.Black;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmCP_Proveedor_TerminoPago_Mantenimiento_Load(object sender, EventArgs e)
        {
            try
            {
                load();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtCuota_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                 //calcular();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }    

        private void LimpiarDatos()
        {
            try
            {                
                txtCodigo.Text = "";
                txtDias.Text = "1";    
                txtDescripcion.Text = "";
                txtCuota.Text = "1";
                _Accion = Cl_Enumeradores.eTipo_action.grabar;
                _Info = new cp_TerminoPago_Info();
                //lstTerminoDis = new BindingList<fa_TerminoPago_Distribucion_Info>();

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void frmCP_Proveedor_TerminoPago_Mantenimiento_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                Event_frmCP_Proveedor_TerminoPago_Mantenimiento_FormClosing(sender, e);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtDias_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if ((e.KeyChar < 45 || e.KeyChar > 57) && e.KeyChar != 8)
                {
                    e.Handled = true;
                }
                else
                {
                    e.Handled = false;
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void txtDias_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtDias.Text == "0" || txtDias.Text == "")
                {
                    txtDias.Text = "1";
                    txtDias.SelectionLength = 1;
                }
                //calcular();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
           
        }

        private void txtCuota_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtCuota.Text == "0" || txtCuota.Text == "")
                {
                    txtCuota.Text = "1";
                    txtCuota.SelectionLength = 1;
                }
                //calcular();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void txtCuota_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if ((e.KeyChar < 45 || e.KeyChar > 57) && e.KeyChar != 8)
                {
                    e.Handled = true;
                }
                else
                {
                    e.Handled = false;
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //private Boolean validarPorDistribucion()
        //{
        //    try 
        //    {
        //        List<fa_TerminoPago_Distribucion_Info> lstTerminoDis2 = new List<fa_TerminoPago_Distribucion_Info>(lstTerminoDis);
        //        double porcentTotVali = 0 ;
        //        foreach (var item in lstTerminoDis2)
        //        {
        //            if (item.Num_Dias_Vcto > 0 && item.Secuencia > 0)
        //                porcentTotVali = porcentTotVali + item.Por_distribucion;
        //        }

        //        if (porcentTotVali != 100)
        //        {
        //            MessageBox.Show("El Total del Porcentaje debe ser 100");
        //            return false;
        //        }

        //        lstTerminoDis2 = lstTerminoDis2.FindAll(var => var.Por_distribucion ==0);
        //        if (lstTerminoDis2.Count > 0)
        //        {
        //            MessageBox.Show("Hay porcentajes con el valor de cero");
        //            return false;
        //        }
        //        return true;
        //    }
        //    catch (Exception ex)
        //    {
        //        Log_Error_bus.Log_Error(ex.ToString());
        //        MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        return false;
        //    }
        //}

        private void repositorioDistribucion_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                if ((Convert.ToDecimal(gridViewDistribucion.FocusedValue)) == 0)
                {
                    MessageBox.Show("El porcentaje no puede ser cero");
                   
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void repositorioDistribucion_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if ((Convert.ToDecimal(gridViewDistribucion.FocusedValue)) == 0)
                {
                    MessageBox.Show("El porcentaje no puede ser cero");

                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gridViewDistribucion_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                if (gridViewDistribucion.FocusedColumn == colPor_distribucion)
                {
                    if ((Convert.ToDecimal(gridViewDistribucion.FocusedValue)) == 0)
                    {
                        MessageBox.Show("El porcentaje no puede ser cero");

                    }
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        void Anular()
        {
            try
            {
                if (_Info.IdTerminoPago != "")
                {
                    //Esta_seguro_Eliminar
                    if (MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Esta_seguro_Eliminar) + " #:" + _Info.IdTerminoPago, param.Nombre_sistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        FrmGe_MotivoAnulacion ofrm = new FrmGe_MotivoAnulacion();
                        ofrm.ShowDialog();

                        _Info.IdUsuarioUltAnu = param.IdUsuario;
                        _Info.Fecha_UltAnu = DateTime.Now;
                        _Info.MotiAnula = ofrm.motivoAnulacion;

                        string msjError = "";
                        if (_Info.Estado == "A")
                        {
                            if (TerminoPagoBus.AnularDB(_Info, ref msjError))
                            {
                                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Grabado_satisfactoriamente), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                                ucGe_Menu.Visible_bntAnular = DevExpress.XtraBars.BarItemVisibility.Never;
                                lblAnulado.Visible = true;
                            }
                            else
                            {
                                string smensaje = string.Format("Error al Anular:  {0}", MensajeError);
                                MessageBox.Show(smensaje, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            //Debido_q_ya_se_encuentra_anulado
                            MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.No_se_puede_anular_registro) + _Info.IdTerminoPago + param.Get_Mensaje_sys(enum_Mensajes_sys.Debido_q_ya_se_encuentra_anulado), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    }

                }
                else
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Por_favor_seleccione_item_a_anular), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }

        }
    
    }
}
