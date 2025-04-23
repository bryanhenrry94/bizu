namespace Bizu.Presentation.Controles
{
    partial class UCScrum_Task
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.tablePanel1 = new DevExpress.Utils.Layout.TablePanel();
            this.lbl_asignado = new System.Windows.Forms.Label();
            this.lbl_prioridad = new System.Windows.Forms.Label();
            this.lbl_descripcion = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).BeginInit();
            this.tablePanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_titulo
            // 
            this.tablePanel1.SetColumn(this.lbl_titulo, 1);
            this.lbl_titulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo.Location = new System.Drawing.Point(62, 0);
            this.lbl_titulo.Name = "lbl_titulo";
            this.tablePanel1.SetRow(this.lbl_titulo, 0);
            this.lbl_titulo.Size = new System.Drawing.Size(172, 29);
            this.lbl_titulo.TabIndex = 0;
            this.lbl_titulo.Text = "Titulo";
            this.lbl_titulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_titulo.Click += new System.EventHandler(this.UCScrum_Task_Click);
            // 
            // tablePanel1
            // 
            this.tablePanel1.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 21.26F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 63.9F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 24.84F)});
            this.tablePanel1.Controls.Add(this.lbl_asignado);
            this.tablePanel1.Controls.Add(this.lbl_prioridad);
            this.tablePanel1.Controls.Add(this.lbl_titulo);
            this.tablePanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tablePanel1.Location = new System.Drawing.Point(0, 0);
            this.tablePanel1.Name = "tablePanel1";
            this.tablePanel1.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 23F)});
            this.tablePanel1.Size = new System.Drawing.Size(307, 29);
            this.tablePanel1.TabIndex = 2;
            // 
            // lbl_asignado
            // 
            this.tablePanel1.SetColumn(this.lbl_asignado, 2);
            this.lbl_asignado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_asignado.Location = new System.Drawing.Point(241, 4);
            this.lbl_asignado.Name = "lbl_asignado";
            this.tablePanel1.SetRow(this.lbl_asignado, 0);
            this.lbl_asignado.Size = new System.Drawing.Size(63, 20);
            this.lbl_asignado.TabIndex = 4;
            this.lbl_asignado.Text = "Usuario";
            this.lbl_asignado.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbl_asignado.Click += new System.EventHandler(this.UCScrum_Task_Click);
            // 
            // lbl_prioridad
            // 
            this.tablePanel1.SetColumn(this.lbl_prioridad, 0);
            this.lbl_prioridad.Location = new System.Drawing.Point(3, 1);
            this.lbl_prioridad.Name = "lbl_prioridad";
            this.tablePanel1.SetRow(this.lbl_prioridad, 0);
            this.lbl_prioridad.Size = new System.Drawing.Size(53, 26);
            this.lbl_prioridad.TabIndex = 3;
            this.lbl_prioridad.Text = "Prioridad";
            this.lbl_prioridad.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_prioridad.Click += new System.EventHandler(this.UCScrum_Task_Click);
            // 
            // lbl_descripcion
            // 
            this.lbl_descripcion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_descripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_descripcion.Location = new System.Drawing.Point(0, 29);
            this.lbl_descripcion.Name = "lbl_descripcion";
            this.lbl_descripcion.Size = new System.Drawing.Size(307, 36);
            this.lbl_descripcion.TabIndex = 5;
            this.lbl_descripcion.Text = "descripcion";
            this.lbl_descripcion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_descripcion.Click += new System.EventHandler(this.UCScrum_Task_Click);
            // 
            // UCScrum_Task
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbl_descripcion);
            this.Controls.Add(this.tablePanel1);
            this.Name = "UCScrum_Task";
            this.Size = new System.Drawing.Size(307, 65);
            this.Load += new System.EventHandler(this.UCScrum_Task_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).EndInit();
            this.tablePanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_titulo;
        private DevExpress.Utils.Layout.TablePanel tablePanel1;
        private System.Windows.Forms.Label lbl_prioridad;
        private System.Windows.Forms.Label lbl_asignado;
        private System.Windows.Forms.Label lbl_descripcion;
    }
}
