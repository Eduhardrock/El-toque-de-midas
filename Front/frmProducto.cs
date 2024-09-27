using Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Front
{
    public partial class frmProducto : Form
    {

        private CategoriaService categoriaService;

        public frmProducto()
        {
            InitializeComponent();
            categoriaService = new CategoriaService();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void dataGridCategoria_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void frmProducto_Load(object sender, EventArgs e)
        {
            Console.WriteLine("Entre al data grid para cargar datos");

            var resultado = this.categoriaService.listarTodas();

            Console.WriteLine("RESULTADO : " + resultado.ToString());

            dataGridCategoria.DataSource = this.categoriaService.listarTodas();
            dataGridCategoria.Columns["id"].HeaderText = "ID";
            dataGridCategoria.Columns["nombre"].HeaderText = "NOMBRE";
            dataGridCategoria.Columns["productoes"].Visible = false;
        }
    }
}
