using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Core.Erp.Business.General;
using Core.Erp.Info.General;

using Core.Erp.Info.CuentasxPagar;
using Core.Erp.Business.CuentasxPagar;
using Core.Erp.Business.Inventario;
using Core.Erp.Info.Inventario;
using Core.Erp.Business.SeguridadAcceso;
using Core.Erp.Info.SeguridadAcceso;

namespace Core.Erp.Winform.Inventario
{
    public partial class FrmIn_Productos_Actuazacion_Precios_Macivamente_Cons : Form
    {

        tb_sis_Log_Error_Vzen_Bus Log_Error_bus;
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        seg_Menu_bus Busseg = new seg_Menu_bus();
        List<seg_Menu_info> Infoseg = new List<seg_Menu_info>();
        string mensaje_error = "";

        #region Variables y atributos

        in_Ing_Egr_Inven_Bus bus_IngEgr;
        in_Ing_Egr_Inven_Info Info;
        FrmIn_Ingreso_varios_Mant frm;

        List<vwin_producto_precio_historico_Info> LstPrecioHistorico = new List<vwin_producto_precio_historico_Info>();
        List<vwin_producto_precio_historico_Info> ListBindingProductos = new List<vwin_producto_precio_historico_Info>();
        vwin_producto_precio_historico_Bus BusProductos = new vwin_producto_precio_historico_Bus();

        List<vwin_producto_x_tb_bodega_Precios_Info> LstProducto = new List<vwin_producto_x_tb_bodega_Precios_Info>();
        vwin_producto_x_tb_bodega_Precios_Bus BusProducto = new vwin_producto_x_tb_bodega_Precios_Bus();

        List<in_producto_precio_historico_Info> Info_list = new List<in_producto_precio_historico_Info>();
        in_producto_precio_historico_Bus Bus_producto_precio_historico = new in_producto_precio_historico_Bus();

        in_categorias_bus Bus_Categoria = new in_categorias_bus();
        List<in_categorias_Info> ListCategoria = new List<in_categorias_Info>();
        in_linea_Bus BusLinea = new in_linea_Bus();
        List<in_linea_info> ListLinea = new List<in_linea_info>();
        in_marca_bus BusMarca = new in_marca_bus();
        List<in_Marca_Info> ListMarca = new List<in_Marca_Info>();

        int IdSucursalIni = 0;
        int IdSucursalFin = 0;
        int IdBodegaIni = 0;
        int IdBodegaFin = 0;
        int IdMarca = 0;
        int IdLinea = 0;
        string IdCategoria = "";
        decimal IdProductoIni = 0;
        decimal IdProductoFin = 0;

        DateTime fecha_desde;
        DateTime fecha_hasta;
        #endregion

        public FrmIn_Productos_Actuazacion_Precios_Macivamente_Cons()
        {
            InitializeComponent();
        }

        private void FrmIn_Productos_Actuazacion_Precios_Macivamente_Cons_Load(object sender, EventArgs e)
        {
            try
            {

                in_categorias_Info InfoCategoria = new in_categorias_Info();
                in_linea_info InfoLinea = new in_linea_info();
                in_Marca_Info InfoMarca = new in_Marca_Info();

                ListMarca = BusMarca.Get_list_Marca(param.IdEmpresa);
                ListMarca.Add(InfoMarca);
                cmb_marca.Properties.DataSource = ListMarca;
                cmb_marca.Properties.DisplayMember = "Descripcion2";
                cmb_marca.Properties.ValueMember = "IdMarca";

                ListCategoria = Bus_Categoria.Get_List_categorias(param.IdEmpresa);
                ListCategoria.Add(InfoCategoria);
                cmb_categoria.Properties.DataSource = ListCategoria;
                cmb_categoria.Properties.DisplayMember = "ca_Categoria2";
                cmb_categoria.Properties.ValueMember = "IdCategoria";

                ListLinea = BusLinea.Get_List_Linea(param.IdEmpresa, "");
                ListLinea.Add(InfoLinea);
                cmb_Linea.Properties.DataSource = ListLinea;
                cmb_Linea.Properties.DisplayMember = "nom_linea2";
                cmb_Linea.Properties.ValueMember = "IdLinea";

                List<String> ListTipoPrecio = new List<string>();
                ListTipoPrecio.Add("Precio Min. (Actual)");
                ListTipoPrecio.Add("Precio May. (Actual)");
                ListTipoPrecio.Add("Precio Inst. (Actual)");
                                           
                cmb_tipoPrecio.DataSource = ListTipoPrecio;

                rbtPorcentaje.Checked = true;
                rbtValor.Checked = false;

                uCin_Producto1.Get_Id_ProductoIni();

                cargagrid();
            }
            catch (Exception ex)
            {
                Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void cargagrid()
        {
            try
            {
                IdSucursalIni = cmb_Sucursal_Bodega.get_IdSucursal();
                if (IdSucursalIni == 0)
                {
                    IdSucursalIni = 1;
                    IdSucursalFin = 9999;
                    IdBodegaIni = 1;
                    IdBodegaFin = 9999;
                }
                else
                {
                    IdSucursalIni = cmb_Sucursal_Bodega.get_IdSucursal();
                    IdSucursalFin = cmb_Sucursal_Bodega.get_IdSucursal();
                    IdBodegaIni = cmb_Sucursal_Bodega.get_IdBodega() == 0 ? 1 : cmb_Sucursal_Bodega.get_IdBodega();
                    IdBodegaFin = cmb_Sucursal_Bodega.get_IdBodega() == 0 ? 9999 : cmb_Sucursal_Bodega.get_IdBodega();
                }

                IdProductoIni = uCin_Producto1.Get_Id_ProductoIni();
                IdProductoFin = uCin_Producto1.Get_Id_ProductoFin();

                IdCategoria = cmb_categoria.EditValue != null ? Convert.ToString(cmb_categoria.EditValue) : "";
                IdLinea = cmb_Linea.EditValue != null ? Convert.ToInt32(cmb_Linea.EditValue) : 0;
                IdMarca = cmb_marca.EditValue != null ? Convert.ToInt32(cmb_marca.EditValue) : 0;
                

                LstProducto = BusProducto.Get_List_Producto_x_Bodega_Precios(param.IdEmpresa, IdBodegaIni, IdBodegaFin, IdMarca,
                    IdLinea, IdCategoria, IdProductoIni, IdProductoFin);

                LstPrecioHistorico = null;
                LstPrecioHistorico = BusProductos.Get_List_Producto_Precio_Historico(param.IdEmpresa, IdBodegaIni, IdBodegaFin, IdMarca, IdLinea, IdCategoria, IdProductoIni, IdProductoFin);

                foreach (var item in LstProducto)
                {
                    int secuencia = 0;

                    var List_Precios = LstPrecioHistorico.FindAll(q => q.IdEmpresa == item.IdEmpresa && q.IdSucursal == item.IdSucursal
                       && q.IdProducto == item.IdProducto);

                    if (List_Precios.Count > 0) 
                    {
                        secuencia = Convert.ToInt32(List_Precios.Max(q => q.Secuencia));

                        if (secuencia != 0)
                        {
                            var reg = LstPrecioHistorico.FirstOrDefault(q => q.IdEmpresa == item.IdEmpresa &&
                              q.IdSucursal == item.IdSucursal && q.IdProducto == item.IdProducto && q.Secuencia == secuencia);

                            item.pr_precio_publico_anterior = Convert.ToDouble(reg.pr_precio_publico_anterior);
                            item.pr_precio_mayor_anterior = Convert.ToDouble(reg.pr_precio_mayor_anterior);
                            item.pr_precio_minimo_anterior = Convert.ToDouble(reg.pr_precio_minimo_anterior);
                        }
                    }
                    else
                    {
                        item.pr_precio_publico_anterior = (item.pr_precio_publico_anterior == 0) ? item.pr_precio_publico : item.pr_precio_publico_anterior;
                        item.pr_precio_mayor_anterior = (item.pr_precio_mayor_anterior == 0) ? item.pr_precio_mayor : item.pr_precio_mayor_anterior;
                        item.pr_precio_minimo_anterior = (item.pr_precio_minimo_anterior == 0) ? item.pr_precio_minimo : item.pr_precio_minimo_anterior;
                    }             
                                             
                }

                gridControlProductos.DataSource = LstProducto.OrderByDescending(x => x.IdProducto);                            
            }
            catch (Exception ex)
            {
                Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Preparar_Formulario(Cl_Enumeradores.eTipo_action Accion)
        {

            try
            {
                Info = new in_Ing_Egr_Inven_Info();

                if (Accion != Cl_Enumeradores.eTipo_action.grabar)
                {
                    Info = (in_Ing_Egr_Inven_Info)gridViewProductos.GetFocusedRow();
                }


                if (Info == null)
                {
                    MessageBox.Show("Seleccione un Registro a Mostrar", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                if (Info.Estado == "I")
                {
                    MessageBox.Show("El registro ya se encuentra anulado", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                if (Info.Estado == "APRO" && Accion == Cl_Enumeradores.eTipo_action.Anular)
                {
                    MessageBox.Show("No se puede anular el registro porque se encuentra aprobado", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                //if (Accion == Cl_Enumeradores.eTipo_action.actualizar && (Info.co_factura != null || Info.IdEstadoAproba == "APRO"))
                //{
                //    Accion = Cl_Enumeradores.eTipo_action.actualizar_proceso_cerrado;
                //}

                frm = new FrmIn_Ingreso_varios_Mant();
                frm.MdiParent = this.MdiParent;
                frm.event_FrmIn_Ingreso_varios_Mant_FormClosing += frm_event_FrmIn_Ingreso_varios_Mant_FormClosing;
                frm.set_Accion(Accion);
                frm.setInfo(Info);



                switch (Accion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:
                        frm.Text = frm.Text + " ***NUEVO REGISTRO***";
                        break;
                    case Cl_Enumeradores.eTipo_action.actualizar:

                        frm.Text = frm.Text + " ***MODIFICAR REGISTRO***";
                        break;
                    case Cl_Enumeradores.eTipo_action.Anular:

                        if (Info != null)
                        {
                            if (Info.Estado == "I")
                            { MessageBox.Show("El registro ya se encuentra Anulado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return; }
                            else
                            {
                                frm.Text = frm.Text + "***ANULAR REGISTRO***";
                            }
                        }
                        else
                        {
                            MessageBox.Show("Seleccione un Registro a Anular", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return;
                        }

                        break;
                    case Cl_Enumeradores.eTipo_action.consultar:
                        frm.Text = frm.Text + "***CONSULTAR REGISTRO***";
                        break;
                    default:
                        break;
                }


                frm.Show();



            }
            catch (Exception ex)
            {
                Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        void frm_event_FrmIn_Ingreso_varios_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                cargagrid();
            }
            catch (Exception ex)
            {
                Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void ucGe_Menu_Mantenimiento_x_usuario1_event_btnSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        public void ucGe_Menu_Mantenimiento_x_usuario1_event_btnAnular_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                Preparar_Formulario(Cl_Enumeradores.eTipo_action.Anular);
            }
            catch (Exception ex)
            {
                Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void ucGe_Menu_Mantenimiento_x_usuario1_event_btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                cargagrid();
            }
            catch (Exception ex)
            {
                Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void ucGe_Menu_Mantenimiento_x_usuario1_event_btnImprimir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                gridViewProductos.ShowPrintPreview();
            }
            catch (Exception ex)
            {
                Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void ucGe_Menu_Mantenimiento_x_usuario1_event_btnconsultar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                Preparar_Formulario(Cl_Enumeradores.eTipo_action.consultar);
            }
            catch (Exception ex)
            {
                Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void ucGe_Menu_Mantenimiento_x_usuario1_event_btnModificar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                Info = (in_Ing_Egr_Inven_Info)gridViewProductos.GetFocusedRow();
                if (Info == null) return;
                if (Info.Estado == "I") { MessageBox.Show("El registro se encuentra anulado y no se puede modificar"); return; }
                
                Preparar_Formulario(Cl_Enumeradores.eTipo_action.actualizar);

            }
            catch (Exception ex)
            {
                Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void ucGe_Menu_Mantenimiento_x_usuario1_event_btnNuevo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                //Preparar_Formulario(Cl_Enumeradores.eTipo_action.grabar);

            }
            catch (Exception ex)
            {
                Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void gridViewProductos_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            try
            {
                Info = new in_Ing_Egr_Inven_Info();
                Info = (in_Ing_Egr_Inven_Info)gridViewProductos.GetFocusedRow();
            }
            catch (Exception ex)
            {
                Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void gridViewProductos_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            try
            {
                var data = gridViewProductos.GetRow(e.RowHandle) as in_Ing_Egr_Inven_Info;
                if (data == null)
                    return;
                if (data.Estado == "I")
                    e.Appearance.ForeColor = Color.Red;
                else
                {
                    if (data.IdEstadoAproba == "APRO")
                        e.Appearance.ForeColor = Color.Blue;

                }
            }
            catch (Exception ex)
            {
                Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lblPlantilla_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //SaveFileDialog fichero = new SaveFileDialog();
            //fichero.Filter = "Excel (*.xls)|*.xls";
            //if (fichero.ShowDialog() == DialogResult.OK)
            //{
            //    Microsoft.Office.Interop.Excel.Application aplicacion;
            //    Microsoft.Office.Interop.Excel.Workbook libros_trabajo;
            //    Microsoft.Office.Interop.Excel.Worksheet hoja_trabajo;
            //    aplicacion = new Microsoft.Office.Interop.Excel.Application();
            //    libros_trabajo = aplicacion.Workbooks.Add();
            //    hoja_trabajo =
            //    (Microsoft.Office.Interop.Excel.Worksheet)libros_trabajo.Worksheets.get_Item(1);
            //    //Recorremos el DataGridView rellenando la hoja de trabajo
            //    //for (int i = 0; i < gridViewProductos.RowCount - 1; i++)
            //    //{
            //    //    for (int j = 0; j < gridViewProductos.Columns.Count; j++)
            //    //    {
            //    //        hoja_trabajo.Cells[i + 1, j + 1] = gridViewProductos.Columns[j];
            //    //    }
            //    //}
            //    int fila = 0;

            //    List<vwin_producto_x_tb_bodega_Precios_Info> LstPro = new List<vwin_producto_x_tb_bodega_Precios_Info>(LstPrecioHistorico.OrderByDescending(x => x.IdProducto));

            //    foreach (var item in LstPro)
            //    {
            //        fila = fila + 1;

            //        hoja_trabajo.Cells[fila, 1] = item.pr_codigo;
            //        hoja_trabajo.Cells[fila, 2] = item.pr_descripcion;
            //        hoja_trabajo.Cells[fila, 3] = item.pr_precio_publico;
            //        hoja_trabajo.Cells[fila, 4] = item.pr_precio_mayor;
            //        hoja_trabajo.Cells[fila, 5] = item.pr_precio_minimo;

            //        hoja_trabajo.Cells[fila, 6] = "";
            //        hoja_trabajo.Cells[fila, 7] = "";
            //        hoja_trabajo.Cells[fila, 8] = "";
                
            //    }
            //    libros_trabajo.SaveAs(fichero.FileName,
            //    Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookNormal);
            //    libros_trabajo.Close(true);
            //    aplicacion.Quit();
            //}
        }

        private Boolean Agregar_fila_copiada(string data)
        {
            //try
            //{
            //    if (string.IsNullOrWhiteSpace(data)) return false;
            //    string[] rowData = data.Split(new char[] { '\r', '\x09' });

            //    //posicion de la ata pegada
            //    //codigo produc | unidad medida |cant |costo|observacion|

            //    vwin_producto_x_tb_bodega_Precios_Info newRow = new vwin_producto_x_tb_bodega_Precios_Info();
            //    if (rowData.Count() >= 3) //return false;          
            //    {
            //        string cod_producto = rowData[0];
            //        vwin_producto_x_tb_bodega_Precios_Info Info_Producto;
            //        var QProducto = LstPrecioHistorico.FirstOrDefault(v => v.IdEmpresa == param.IdEmpresa && v.pr_codigo == cod_producto);
            //        if (QProducto != null)
            //        { Info_Producto = LstPrecioHistorico.FirstOrDefault(v => v.IdEmpresa == param.IdEmpresa && v.pr_codigo == cod_producto); }
            //        else { MessageBox.Show("el codigo de este producto:" + cod_producto + " no esta en la base"); return false; }

            //        //string IdUnidadMedida = Convert.ToString(rowData[2]) == "" ? Info_Producto.IdUnidadMedida_Consumo : Convert.ToString(rowData[2]);
            //        double cantidad = Convert.ToDouble(rowData[3]);
            //        double costo_unitario = Convert.ToDouble(rowData[4]);
            //        string observacion = Convert.ToString(rowData[1]);

            //        string codigo = Convert.ToString(rowData[0]);
            //        string descripcion = Convert.ToString(rowData[1]);
            //        double precio_minorista = Convert.ToDouble(rowData[2]);
            //        double precio_mayorista = Convert.ToDouble(rowData[3]);
            //        double precio_Institucional = Convert.ToDouble(rowData[4]);

            //        double precio_minorista_Nuevo = Convert.ToDouble(rowData[5]);
            //        double precio_mayorista_Nuevo = Convert.ToDouble(rowData[6]);
            //        double precio_Institucional_Nuevo = Convert.ToDouble(rowData[7]);

            //        in_Ing_Egr_Inven_det_Info emp = new in_Ing_Egr_Inven_det_Info();
            //        if (!string.IsNullOrWhiteSpace(cod_producto))
            //        {
            //            if (Info_Producto.pr_codigo == codigo)
            //            {
            //                newRow.IdProducto = Info_Producto.IdProducto;
            //                newRow.IdEmpresa = Info_Producto.IdEmpresa;
            //                newRow.IdBodega = Info_Producto.IdBodega;

            //                newRow.pr_codigo = cod_producto;
            //                newRow.pr_descripcion = descripcion;
            //                newRow.pr_precio_publico = precio_minorista;
            //                newRow.pr_precio_mayor = precio_mayorista;
            //                newRow.pr_precio_minimo = precio_Institucional;

            //                newRow.pr_precio_publico_nuevo = precio_minorista_Nuevo;
            //                newRow.pr_precio_mayor_nuevo = precio_mayorista_Nuevo;
            //                newRow.pr_precio_minimo_nuevo = precio_Institucional_Nuevo;
            //            }
            //        }
            //        else
            //        {
            //            MessageBox.Show("Ya se encuentra registrado el codigo del producto # :" + cod_producto);
            //            return false;
            //        }

            //        if (newRow.IdProducto > 0)
            //        {
            //            ListBindingProductos.Add(newRow);
            //        }

            //        return true;
            //    }
            //    else
            //    {
            //        MessageBox.Show("No hay las columnas necesarias para insertar al registros");
            //        return false;
                //}            

            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message + "\n\n" + "El formato debe ser el siguiente\n" + "|codigo Producto|nombre producto|unidad med.|cantidad|costo|observacion det|centros cos|", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    Log_Error_bus.Log_Error(ex.ToString());
            //    return false;
            //}

            return false;
        }

        private void Pegar_Data()
        {
            //try
            //{
            //    ListBindingProductos = new List<vwin_producto_x_tb_bodega_Precios_Info>();
            //    string[] data = ClipboardData.Split('\n');
            //    if (data.Length < 1) return;
            //    foreach (string row in data)
            //    {
            //        if (!Agregar_fila_copiada(row))
            //            break;

            //    }
            //}
            //catch (Exception ex)
            //{
            //    Log_Error_bus.Log_Error(ex.ToString());
            //}
        }

        private void gridControlProductos_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Delete)
                {
                    if (MessageBox.Show("¿Está seguro que desea eliminar este registro ?", "Elimina", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        gridViewProductos.DeleteRow(gridViewProductos.FocusedRowHandle);
                    }
                }

                // para pegar en las columnas en el mismo orden 
                if (e.KeyCode == Keys.V && e.Control == true)
                {
                    Pegar_Data();

                    gridControlProductos.DataSource = null;
                    gridControlProductos.DataSource = ListBindingProductos;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }
        string ClipboardData
        {
            get
            {
                IDataObject iData = Clipboard.GetDataObject();
                if (iData == null) return "";

                if (iData.GetDataPresent(DataFormats.Text))
                    return (string)iData.GetData(DataFormats.Text);
                return "";
            }
            set { Clipboard.SetDataObject(value); }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            cargagrid();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void chk_Seleccionar_visibles_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < gridViewProductos.RowCount; i++)
                {
                    gridViewProductos.SetRowCellValue(i, colChecked, chk_Seleccionar_visibles.Checked);
                    //gridViewCons.SetRowCellValue(i, colIdEstadoAproba, chk_Seleccionar_visibles.Checked == true ? "APRO" : "PEND");
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void rbtPorcentaje_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (rbtPorcentaje.Checked == true)
                {
                    txtValor.Enabled = false;
                    txtValor.Text = "0";
                }
                else
                {
                    txtValor.Enabled = true;
                    txtPorcentaje.Text = "0";
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void rbtValor_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (rbtValor.Checked == true)
                {
                    txtPorcentaje.Enabled = false;
                }
                else
                {
                    txtPorcentaje.Enabled = true;
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void cmb_categoria_EditValueChanged(object sender, EventArgs e)
        {
            ListLinea = BusLinea.Get_List_Linea(param.IdEmpresa, Convert.ToString(cmb_categoria.EditValue));
            //ListLinea.Add(InfoLinea);
            cmb_Linea.Properties.DataSource = ListLinea;
            cmb_Linea.Properties.DisplayMember = "nom_linea2";
            cmb_Linea.Properties.ValueMember = "IdLinea";
        }

        private void btn_calcular_Click(object sender, EventArgs e)
        {
            try
            {
                decimal valor = 0;
                decimal Porcentaje = 0;
                decimal precio_publico = 0;
                decimal precio_mayor = 0;
                decimal precio_minimo = 0;

                if (cmb_tipoPrecio.SelectedIndex < 0) return;

                if (rbtValor.Checked == true)
                {
                    for (int i = 0; i < gridViewProductos.RowCount; i++)
                    {
                        if (Convert.ToBoolean(gridViewProductos.GetRowCellValue(i, colChecked)) == true)
                        {
                            valor = Convert.ToDecimal(txtValor.Text);

                            switch (cmb_tipoPrecio.SelectedIndex) 
                            {
                                case 0:
                                    precio_publico = Convert.ToDecimal(gridViewProductos.GetRowCellValue(i, col_pr_precio_publico));
                                    precio_publico += valor;                                                       
                                    gridViewProductos.SetRowCellValue(i, col_pr_precio_publico, precio_publico);
                                                        
                                    break;

                                case 1:
                                    precio_mayor = Convert.ToDecimal(gridViewProductos.GetRowCellValue(i, col_pr_precio_mayor));
                                    precio_mayor += valor;
                                    gridViewProductos.SetRowCellValue(i, col_pr_precio_mayor, precio_mayor);

                                    break;

                                case 2:
                                    precio_minimo = Convert.ToDecimal(gridViewProductos.GetRowCellValue(i, col_pr_precio_minimo));
                                    precio_minimo += valor;
                                    gridViewProductos.SetRowCellValue(i, col_pr_precio_minimo, precio_minimo); 

                                    break;
                            }                                                                                                                                              
                        }
                    }                    
                }
                else
                {
                    for (int i = 0; i < gridViewProductos.RowCount; i++)
                    {
                        if (Convert.ToBoolean(gridViewProductos.GetRowCellValue(i, colChecked)) == true)
                        {
                            Porcentaje = Convert.ToDecimal(txtPorcentaje.Text);

                            switch (cmb_tipoPrecio.SelectedIndex)
                            {
                                case 0:
                                    precio_publico = Convert.ToDecimal(gridViewProductos.GetRowCellValue(i, col_pr_precio_publico));
                                    precio_publico = precio_publico + (precio_publico * Porcentaje);
                                    gridViewProductos.SetRowCellValue(i, col_pr_precio_publico, precio_publico);
                            
                                    break;

                                case 1:
                                    precio_mayor = Convert.ToDecimal(gridViewProductos.GetRowCellValue(i, col_pr_precio_mayor));
                                    precio_mayor = precio_mayor + (precio_mayor * Porcentaje);
                                    gridViewProductos.SetRowCellValue(i, col_pr_precio_mayor, precio_mayor);                            

                                    break;

                                case 2:
                                    precio_minimo = Convert.ToDecimal(gridViewProductos.GetRowCellValue(i, col_pr_precio_minimo));
                                    precio_minimo = precio_minimo + (precio_minimo * Porcentaje);
                                    gridViewProductos.SetRowCellValue(i, col_pr_precio_minimo, precio_minimo);

                                    break;
                            }          
                        }
                    }                    
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void ucGe_Menu_event_btnGuardar_y_Salir_Click(object sender, EventArgs e)
        {
            try
            {
                Get();

                if (validar()) 
                {
                    if (MessageBox.Show("Esta seguro de actualizar el listado de precios seleccionado?", param.Nombre_sistema, MessageBoxButtons.YesNo, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.No) 
                    {
                        return;
                    }

                    Bus_producto_precio_historico.Grabar_List(Info_list, ref mensaje_error);

                    MessageBox.Show("Precios Actualizados correctamente!!", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);

                    cargagrid();
                }                
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void ucGe_Menu_event_btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void Get() 
        {
            try
            {
                Info_list = new List<in_producto_precio_historico_Info>();

                for (int i = 0; i < gridViewProductos.RowCount; i++)
                {
                    if (Convert.ToBoolean(gridViewProductos.GetRowCellValue(i, colChecked)) == true)
                    {
                        in_producto_precio_historico_Info Info = new in_producto_precio_historico_Info();

                        Info.IdEmpresa = param.IdEmpresa;
                        Info.IdSucursal = cmb_Sucursal_Bodega.get_IdSucursal();
                        Info.IdProducto = Convert.ToInt32(gridViewProductos.GetRowCellValue(i, colIdProducto));
                        Info.IdUsuario = param.IdUsuario;
                        Info.Secuencia = 0;
                        Info.Fecha = DateTime.Today;
                        Info.FechaTrans = param.Fecha_Transac;
                        Info.pr_precio_publico = 0;
                        Info.pr_precio_mayor = 0;
                        Info.pr_precio_minimo = 0;

                        Info.producto_info = new in_Producto_Info();
                        Info.producto_info.IdEmpresa = param.IdEmpresa;
                        Info.producto_info.IdProducto = Info.IdProducto;

                        Info.producto_info.pr_precio_publico = Convert.ToDouble(gridViewProductos.GetRowCellValue(i, col_pr_precio_publico));
                        Info.producto_info.pr_precio_mayor = Convert.ToDouble(gridViewProductos.GetRowCellValue(i, col_pr_precio_mayor));
                        Info.producto_info.pr_precio_minimo = Convert.ToDouble(gridViewProductos.GetRowCellValue(i, col_pr_precio_minimo));

                        Info.producto_info.IdUsuarioUltMod = Info.IdUsuario;

                        Info_list.Add(Info);
                    }
                }    
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        public bool validar() 
        {
            try
            {
                int cont = 0;

                if (cmb_Sucursal_Bodega.get_IdSucursal() == null)
                {
                    MessageBox.Show("Seleccione la sucursal", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }

                if (cmb_Sucursal_Bodega.get_IdBodega() == null)
                {
                    MessageBox.Show("Seleccione la bodega", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }

                for (int i = 0; i < gridViewProductos.RowCount; i++)
                {
                    if (Convert.ToBoolean(gridViewProductos.GetRowCellValue(i, colChecked)) == true)
                    {
                        cont += 1;
                    }
                }

                if (cont == 0)
                {
                    MessageBox.Show("Seleccione los productos que desea actualizar", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
                return false;
            }
        }

        private void ucGe_Menu_event_btnImprimir_Click(object sender, EventArgs e)
        {
            gridControlProductos.ShowPrintPreview();
        }

        private void cmb_Sucursal_Bodega_Event_cmb_bodega1_EditValueChanged(object sender, EventArgs e)
        {
            //cmb_Sucursal_Bodega.get_IdBodega()

        }

    }
}
