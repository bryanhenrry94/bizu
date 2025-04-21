using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using Core.Erp.Business.General;
using Core.Erp.Info.General;
using Core.Erp.Reportes;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Core.Erp.Reportes.Inventario
{
    public partial class XINV_Rpt009_Consolidado_rpt : DevExpress.XtraReports.UI.XtraReport
    {
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        public List<int> List_Bodegas;
        private TopMarginBand topMarginBand1;
        private DetailBand detailBand1;
        private BottomMarginBand bottomMarginBand1;
        public List<int> List_Lineas;

        public XINV_Rpt009_Consolidado_rpt()
        {
            InitializeComponent();
            //xlbl_idReporte.Text = "XINV_Rpt009_Consolidado_rpt";

            //xrPictureBox1.Image = param.InfoEmpresa.em_logo_Image;
        }

        private void XINV_Rpt009_Edehsa_rpt_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {
                //xrLUsuario.Text = param.IdUsuario;
                //lblFechaImpresion.Text = DateTime.Now.ToString("dddd, dd' de 'MMMM' de 'yyyy HH:mm:ss");
                //lblEmpresa.Text = param.NombreEmpresa;
                //lblReporte.Text = "LISTADO DE INVENTARIO FISICO";

                //string msg = "";
                //XINV_Rpt009_Bus Bus = new XINV_Rpt009_Bus();
                //List<XINV_Rpt009_Info> lista = new List<XINV_Rpt009_Info>();

                //int IdEmpresa = 0;
                //int IdBodega = 0;
                //int IdSucursal = 0;
                //int IdBodegaFin = 0;
                //int IdSucursalFin = 0;
                //string IdCategoria = "";
                //int IdLinea = 0;
                //decimal IdProducto = 0;
                //Boolean Registro_Cero = false;
                //DateTime Fecha_corte = DateTime.Now;
                //IdEmpresa = Convert.ToInt32(Parameters["IdEmpresa"].Value);
                //IdBodega = Convert.ToInt32(Parameters["IdBodega"].Value);
                //IdSucursal = Convert.ToInt32(Parameters["IdSucursal"].Value);
                //IdBodegaFin = Convert.ToInt32(Parameters["IdBodegaFin"].Value);
                //IdSucursalFin = Convert.ToInt32(Parameters["IdSucursalFin"].Value);
                //IdCategoria = Convert.ToString(this.PIdCategoria.Value);
                //IdLinea = Convert.ToInt32(this.PIdLinea.Value);
                //Registro_Cero = Convert.ToBoolean(this.PRegistro_Cero.Value);
                //Fecha_corte = Convert.ToDateTime(FechaFin.Value).Date;
                //IdProducto = Convert.ToDecimal(P_IdProducto.Value);

                //lista = Bus.Get_data_Edehsa(IdEmpresa, IdSucursal, List_Bodegas, IdCategoria, List_Lineas, Registro_Cero, Fecha_corte, IdProducto, param.IdUsuario, ref msg);

                //// Agrupamos para mostrar el total por bodega
                //var query = from q in lista
                //            group q by new
                //            {
                //                q.IdEmpresa,
                //                q.IdSucursal,
                //                q.nom_sucursal,
                //                q.IdProducto,
                //                q.pr_peso,
                //                q.pr_codigo,
                //                q.pr_descripcion,
                //                q.IdCategoria,
                //                q.ca_Categoria,
                //                q.IdLinea,
                //                q.nom_linea,
                //                q.nom_UnidadMedida                                
                //            } into grouping
                //            let count = grouping.Count()
                //            select new XINV_Rpt009_Info {
                //                IdEmpresa = grouping.Key.IdEmpresa,
                //                IdSucursal = grouping.Key.IdSucursal,
                //                nom_sucursal = grouping.Key.nom_sucursal,
                //                IdProducto = grouping.Key.IdProducto,
                //                pr_peso = grouping.Key.pr_peso,
                //                pr_codigo = grouping.Key.pr_codigo,
                //                pr_descripcion = grouping.Key.pr_descripcion,
                //                IdCategoria = grouping.Key.IdCategoria,
                //                ca_Categoria = grouping.Key.ca_Categoria,
                //                IdLinea = grouping.Key.IdLinea,
                //                nom_linea = grouping.Key.nom_linea,
                //                nom_UnidadMedida = grouping.Key.nom_UnidadMedida,
                //                Stock = grouping.Sum(p => p.Stock),
                //                Stock_conversion = grouping.Sum(p => p.Stock_conversion),
                //                costo = grouping.Sum(p => p.costo),
                //                costo_total = grouping.Sum(p => p.costo_total)
                //            };

                //lista = query.ToList();
                
                //Mostrar_celdas(Convert.ToBoolean(P_toma_física.Value));

                //this.DataSource = lista.ToArray();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "XINV_Rpt009_Edehsa_rpt_BeforePrint", ex.Message), ex) { EntityType = typeof(XINV_Rpt009_Consolidado_rpt) };
            }
        }

        private void Mostrar_celdas(bool Toma_fisica)
        {
            try
            {
                //float width_cab = tbl_cab.WidthF;
                //float width_det = tbl_det.WidthF;

                //if (Toma_fisica)
                //{
                //    lblReporte.Text = "LISTADO DE INVENTARIO PARA TOMA FISICA";

                //    float width_cel_cab_cant = cel_cab_costo.WidthF + cel_cab_total.WidthF + cel_cab_cant.WidthF;
                //    float width_cel_det_cant = cel_det_costo.WidthF + cel_det_total.WidthF + cel_det_cant.WidthF;

                //    //Costo
                //    if(tbl_cab.Rows[0].Cells.Contains(cel_cab_costo))
                //        tbl_cab.Rows[0].Cells.Remove(cel_cab_costo);
                //    if(tbl_det.Rows[0].Cells.Contains(cel_det_costo))
                //        tbl_det.Rows[0].Cells.Remove(cel_det_costo);
                //    //Total
                //    if (tbl_cab.Rows[0].Cells.Contains(cel_cab_total))
                //        tbl_cab.Rows[0].Cells.Remove(cel_cab_total);
                //    if (tbl_det.Rows[0].Cells.Contains(cel_det_total))
                //        tbl_det.Rows[0].Cells.Remove(cel_det_total);

                //    //Cantidad física
                //    if (!tbl_cab.Rows[0].Cells.Contains(cel_cab_cant))
                //        tbl_cab.Rows[0].Cells.Add(cel_cab_cant);
                //    if (!tbl_det.Rows[0].Cells.Contains(cel_det_cant))
                //        tbl_det.Rows[0].Cells.Add(cel_det_cant);


                //    cel_lin_total.Visible = false;
                //    cel_cat_total.Visible = false;                    
                //    cel_suc_total.Visible = false;
                //    cel_rpt_total.Visible = false;

                //    cel_cab_cant.WidthF = width_cel_cab_cant;
                //    cel_det_cant.WidthF = width_cel_det_cant;                    
                //}
                //else
                //{
                //    float width_cel_cab_total = cel_cab_total.WidthF + cel_cab_cant.WidthF;
                //    float width_cel_det_total = cel_det_total.WidthF + cel_det_cant.WidthF;

                //    //Costo
                //    if (!tbl_cab.Rows[0].Cells.Contains(cel_cab_costo))
                //        tbl_cab.Rows[0].Cells.Add(cel_cab_costo);
                //    if (!tbl_det.Rows[0].Cells.Contains(cel_det_costo))
                //        tbl_det.Rows[0].Cells.Add(cel_det_costo);
                //    //Total
                //    if (!tbl_cab.Rows[0].Cells.Contains(cel_cab_total))
                //        tbl_cab.Rows[0].Cells.Add(cel_cab_total);
                //    if (!tbl_det.Rows[0].Cells.Contains(cel_det_total))
                //        tbl_det.Rows[0].Cells.Add(cel_det_total);
                //    //Cantidad
                //    if (tbl_cab.Rows[0].Cells.Contains(cel_cab_cant))
                //        tbl_cab.Rows[0].Cells.Remove(cel_cab_cant);
                //    if (tbl_det.Rows[0].Cells.Contains(cel_det_cant))
                //        tbl_det.Rows[0].Cells.Remove(cel_det_cant);

                //    cel_cab_total.WidthF = width_cel_cab_total;
                //    cel_det_total.WidthF = width_cel_det_total;


                //    cel_lin_total.Visible = true;
                //    cel_cat_total.Visible = true;                    
                //    cel_suc_total.Visible = true;
                //    cel_rpt_total.Visible = true;
                //}

                //tbl_cab.WidthF = width_cab;
                //tbl_det.WidthF = width_det;
                               
                //float width_nom = cel_det_id.WidthF + cel_det_cod.WidthF + cel_det_pro.WidthF + cel_det_uni.WidthF + cel_det_peso.WidthF;
                //cel_lin_nom.WidthF = width_nom;
                //cel_cat_nom.WidthF = width_nom;                
                //cel_suc_nom.WidthF = width_nom;
                //cel_rpt_nom.WidthF = width_nom;

                //float width_stock = cel_det_stock.WidthF;
                //cel_lin_stock.WidthF = width_stock;
                //cel_cat_stock.WidthF = width_stock;                
                //cel_suc_stock.WidthF = width_stock;
                //cel_rpt_stock.WidthF = width_stock;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "XINV_Rpt009_Edehsa_rpt_BeforePrint", ex.Message), ex) { EntityType = typeof(XINV_Rpt009_Consolidado_rpt) };
            }
        }

        private void InitializeComponent()
        {
            this.topMarginBand1 = new DevExpress.XtraReports.UI.TopMarginBand();
            this.detailBand1 = new DevExpress.XtraReports.UI.DetailBand();
            this.bottomMarginBand1 = new DevExpress.XtraReports.UI.BottomMarginBand();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // topMarginBand1
            // 
            this.topMarginBand1.Name = "topMarginBand1";
            // 
            // detailBand1
            // 
            this.detailBand1.Name = "detailBand1";
            // 
            // bottomMarginBand1
            // 
            this.bottomMarginBand1.Name = "bottomMarginBand1";
            // 
            // XINV_Rpt009_Consolidado_rpt
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.topMarginBand1,
            this.detailBand1,
            this.bottomMarginBand1});
            this.Version = "19.2";
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }
    }
}