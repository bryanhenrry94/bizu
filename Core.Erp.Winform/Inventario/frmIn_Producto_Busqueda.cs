using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Winform.Controles;
using Core.Erp.Info.Inventario;
using Core.Erp.Business.General;
using Core.Erp.Info.General;
using Core.Erp.Business.Inventario;
using DevExpress.XtraEditors.Filtering;
using DevExpress.XtraEditors.Repository;
using DevExpress.Data.Filtering.Helpers;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;
using System.Collections;
using DevExpress.XtraEditors;
using DevExpress.Data.Linq.Helpers;
using DevExpress.Data.Linq;

namespace Core.Erp.Winform.Inventario
{
    public partial class FrmIn_Producto_Busqueda : DevExpress.XtraEditors.XtraForm
    {
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        string cadena = "";
        List<in_Producto_Info> lst = new List<in_Producto_Info>();
        public in_Producto_Info Info_Selected { get; set; }
        IQueryable<in_Producto_Info> source;

        public FrmIn_Producto_Busqueda()
        {
            try
            {
                InitializeComponent();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public FrmIn_Producto_Busqueda(int IdSucursal,int IdBodega): this()
        {
            try
            {
                Set_Bod_Suc(IdSucursal, IdBodega);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Set_Bod_Suc(int IdSucursal, int IdBodega)
        {
            try
            {
                UCIn_Sucursal_Bodega.set_Idsucursal(IdSucursal);
                UCIn_Sucursal_Bodega.set_Idbodega(IdSucursal, IdBodega);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmIn_Producto_Busqueda_Load(object sender, EventArgs e)
        {
            cargar_grid();
        }

        private void cargar_grid()
        {
            try
            {
                in_Producto_Info prd = new in_Producto_Info();
                in_producto_Bus Bus = new in_producto_Bus();

                lst = Bus.Get_list_Producto(param.IdEmpresa, Convert.ToInt32(UCIn_Sucursal_Bodega.cmb_sucursal.EditValue), Convert.ToInt32(UCIn_Sucursal_Bodega.cmb_bodega.EditValue));

                if (chk_mostrar_con_stock.Checked)
                    lst = lst.Where(q => q.pr_stock > 0).ToList();

                gridControlProductos.DataSource = lst;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            cargar_grid();
        }

        private void BtnSeleccionar_Click(object sender, EventArgs e)
        {
            Info_Selected = gridViewProductos.GetFocusedRow() as in_Producto_Info;

            if (Info_Selected == null)
            {
                MessageBox.Show("Por favor seleccione una fila!", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            this.Close();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gridViewProductos_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                Info_Selected = gridViewProductos.GetFocusedRow() as in_Producto_Info;

                if (Info_Selected == null)
                {
                    MessageBox.Show("Por favor seleccione una fila!", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                this.Close();
            }
            catch (Exception ex) { }
        }
    }
}