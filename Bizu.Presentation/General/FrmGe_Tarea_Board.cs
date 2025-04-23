using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bizu.Presentation.General
{
    public partial class FrmGe_Tarea_Board : Form
    {
        public FrmGe_Tarea_Board()
        {
            InitializeComponent();
        }

        private void FrmGe_Tablero_Board_Load(object sender, EventArgs e)
        {
            this.ucScrum_Board_Final1.loadData();
        }
    }
}
