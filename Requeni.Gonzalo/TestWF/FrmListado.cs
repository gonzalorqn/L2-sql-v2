using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace TestWF
{
    public partial class FrmListado : Form
    {
        private List<Persona> _personas;
        private DataTable _tabla;

        public FrmListado()
        {
            InitializeComponent();
        }

        private void FrmListado_Load(object sender, EventArgs e)
        {
            AccesoDatos ad = new AccesoDatos();
            this.dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this._personas = ad.TraerTodos();
            this._tabla = ad.TraerTablaPersonas();
            this.dataGridView1.DataSource = this._tabla;
        }
    }
}
