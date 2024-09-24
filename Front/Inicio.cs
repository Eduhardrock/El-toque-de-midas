using FontAwesome.Sharp;
using ModelORM;
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
    public partial class InicioForm : Form
    {
        private static IconMenuItem menuActivo = null;
        private static Form formularioActivo = null;

        public InicioForm()
        {

            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void iconMenuUsuario_Click(object sender, EventArgs e)
        {
            abrirForm((IconMenuItem)sender, new frmUsuario());
        }


        private void subMenuCategoria_Click(object sender, EventArgs e)
        {
            abrirForm(iconMantenedor, new frmCategoria());
        }

        private void subMenuProducto_Click(object sender, EventArgs e)
        {
            abrirForm(iconMantenedor, new frmProducto());
        }


        private void menu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void contenedor_Paint(object sender, PaintEventArgs e)
        {

        }



        private void abrirForm(IconMenuItem menu, Form formulario)
        {
            if (menuActivo != null)
            {
                menuActivo.BackColor = Color.White;
            }

            menu.BackColor = Color.Silver;
            menuActivo = menu;

            if (formularioActivo != null)
            {
                formularioActivo.Close();
            }

            formularioActivo = formulario;
            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;
            formulario.BackColor = Color.LightGray;
            contenedor.Controls.Add(formulario);
            formulario.Show();


        }

       
    }
}
