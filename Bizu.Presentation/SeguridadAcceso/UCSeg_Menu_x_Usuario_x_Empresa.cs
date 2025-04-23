using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraTreeList;
using DevExpress.XtraTreeList.Nodes;

using Bizu.Domain.SeguridadAcceso;
using Bizu.Application.SeguridadAcceso;
using Bizu.Domain.General;
using Bizu.Application.General;

namespace Bizu.Presentation.SeguridadAcceso
{    
    public partial class UCSeg_Menu_x_Usuario_x_Empresa : UserControl
    {
        bool expanded = true;

        public delegate void delegate_treeListMenu_x_Usuario_x_Empresa_KeyUp(object sender, KeyEventArgs e);
        public event delegate_treeListMenu_x_Usuario_x_Empresa_KeyUp event_treeListMenu_x_Usuario_x_Empresa_KeyUp;

        public delegate void delegate_treeListMenu_x_Usuario_x_Empresa_MouseDown(object sender, MouseEventArgs e);
        public event delegate_treeListMenu_x_Usuario_x_Empresa_MouseDown event_treeListMenu_x_Usuario_x_Empresa_MouseDown;
        
        public delegate void delegate_btnRefrescarMenu_Click(object sender, EventArgs e);
        public event delegate_btnRefrescarMenu_Click event_btnRefrescarMenu_Click;

        public delegate void delegate_treeListMenu_x_Usuario_x_Empresa_FocusedNodeChanged(object sender, DevExpress.XtraTreeList.FocusedNodeChangedEventArgs e);
        public event delegate_treeListMenu_x_Usuario_x_Empresa_FocusedNodeChanged event_treeListMenu_x_Usuario_x_Empresa_FocusedNodeChanged;

        public delegate void delegate_treeListMenu_x_Usuario_x_Empresa_SelectImageClick(object sender, DevExpress.XtraTreeList.NodeClickEventArgs e);
        public event delegate_treeListMenu_x_Usuario_x_Empresa_SelectImageClick event_treeListMenu_x_Usuario_x_Empresa_SelectImageClick;

        public delegate void delegate_treeListMenu_x_Usuario_x_Empresa_TreeListMenuItemClick(object sender, TreeListMenuItemClickEventArgs e);
        public event delegate_treeListMenu_x_Usuario_x_Empresa_TreeListMenuItemClick event_treeListMenu_x_Usuario_x_Empresa_TreeListMenuItemClick;

        public delegate void delegate_treeListMenu_x_Usuario_x_Empresa_NodeCellStyle(object sender, GetCustomNodeCellStyleEventArgs e);
        public event delegate_treeListMenu_x_Usuario_x_Empresa_NodeCellStyle event_treeListMenu_x_Usuario_x_Empresa_NodeCellStyle;

        public UCSeg_Menu_x_Usuario_x_Empresa()
        {
            InitializeComponent();
            event_treeListMenu_x_Usuario_x_Empresa_FocusedNodeChanged += UCSeg_Menu_x_Usuario_x_Empresa_event_treeListMenu_x_Usuario_x_Empresa_FocusedNodeChanged;
            event_treeListMenu_x_Usuario_x_Empresa_SelectImageClick += UCSeg_Menu_x_Usuario_x_Empresa_event_treeListMenu_x_Usuario_x_Empresa_SelectImageClick;
            event_treeListMenu_x_Usuario_x_Empresa_NodeCellStyle += UCSeg_Menu_x_Usuario_x_Empresa_event_treeListMenu_x_Usuario_x_Empresa_NodeCellStyle;
            event_treeListMenu_x_Usuario_x_Empresa_TreeListMenuItemClick += UCSeg_Menu_x_Usuario_x_Empresa_event_treeListMenu_x_Usuario_x_Empresa_TreeListMenuItemClick;
            event_btnRefrescarMenu_Click += UCSeg_Menu_x_Usuario_x_Empresa_event_btnRefrescarMenu_Click;
        }

        void UCSeg_Menu_x_Usuario_x_Empresa_event_btnRefrescarMenu_Click(object sender, EventArgs e)
        {
            
        }

        void UCSeg_Menu_x_Usuario_x_Empresa_event_treeListMenu_x_Usuario_x_Empresa_TreeListMenuItemClick(object sender, TreeListMenuItemClickEventArgs e)
        {
            
        }

        void UCSeg_Menu_x_Usuario_x_Empresa_event_treeListMenu_x_Usuario_x_Empresa_NodeCellStyle(object sender, GetCustomNodeCellStyleEventArgs e)
        {
            
        }

        void UCSeg_Menu_x_Usuario_x_Empresa_event_treeListMenu_x_Usuario_x_Empresa_SelectImageClick(object sender, NodeClickEventArgs e)
        {
            
        }

        void UCSeg_Menu_x_Usuario_x_Empresa_event_treeListMenu_x_Usuario_x_Empresa_FocusedNodeChanged(object sender, FocusedNodeChangedEventArgs e)
        {
            
        }        

        private void treeListMenu_x_Usuario_x_Empresa_FocusedNodeChanged(object sender, DevExpress.XtraTreeList.FocusedNodeChangedEventArgs e)
        {
            try
            {
                event_treeListMenu_x_Usuario_x_Empresa_FocusedNodeChanged(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }        
        
        private void treeListMenu_x_Usuario_x_Empresa_SelectImageClick(object sender, DevExpress.XtraTreeList.NodeClickEventArgs e)
        {
            try
            {
                event_treeListMenu_x_Usuario_x_Empresa_SelectImageClick(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void treeListMenu_x_Usuario_x_Empresa_CustomDrawNodeCell(object sender, DevExpress.XtraTreeList.CustomDrawNodeCellEventArgs e)
        {
            try
            {
                TreeList lista = sender as TreeList;
                if (e.Node == lista.FocusedNode)
                {
                    e.Graphics.FillRectangle(SystemBrushes.Window, e.Bounds);
                    Rectangle rectangulo = new Rectangle(e.EditViewInfo.ContentRect.Left,
                        e.EditViewInfo.ContentRect.Top,
                        Convert.ToInt32(e.Graphics.MeasureString(e.CellText, this.treeListMenu_x_Usuario_x_Empresa.Font).Width + 1),
                        Convert.ToInt32(e.Graphics.MeasureString(e.CellText, this.treeListMenu_x_Usuario_x_Empresa.Font).Height));
                    e.Graphics.FillRectangle(SystemBrushes.Highlight, rectangulo);
                    e.Graphics.DrawString(e.CellText, treeListMenu_x_Usuario_x_Empresa.Font, SystemBrushes.HighlightText, rectangulo);

                    e.Handled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);                
            }
        }
        
        private void Expandir_o_Contaraer_Nodos(TreeListNodes nodos, bool ExpandirContraer)
        {
            try
            {
                foreach (TreeListNode nodo in nodos)
                {
                    if (nodo.Nodes.Count > 0)
                        Expandir_o_Contaraer_Nodos(nodo.Nodes, ExpandirContraer);
                    nodo.Expanded = ExpandirContraer;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error al expandir nodos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void treeListMenu_x_Usuario_x_Empresa_NodeCellStyle(object sender, GetCustomNodeCellStyleEventArgs e)
        {
            try
            {
                event_treeListMenu_x_Usuario_x_Empresa_NodeCellStyle(sender,e);                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
        
        private void treeListMenu_x_Usuario_x_Empresa_TreeListMenuItemClick(object sender, TreeListMenuItemClickEventArgs e)
        {
            try
            {
                event_treeListMenu_x_Usuario_x_Empresa_TreeListMenuItemClick(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void treeListMenu_x_Usuario_x_Empresa_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                event_treeListMenu_x_Usuario_x_Empresa_KeyUp(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void treeListMenu_x_Usuario_x_Empresa_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                event_treeListMenu_x_Usuario_x_Empresa_MouseDown(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                event_btnRefrescarMenu_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTree_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                Expandir_o_Contaraer_Nodos(treeListMenu_x_Usuario_x_Empresa.Nodes, expanded);
                expanded = !expanded;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

    }
}
