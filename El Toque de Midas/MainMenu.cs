using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace El_Toque_de_Midas
{
    public partial class MainMenu : Form
    {

        //private static Usuario usuario;
        private static IconMenuItem menuActivo = null;
        private static Form formularioActivo = null;

        public MainMenu()
        {
            //usuario = user;
            InitializeComponent();
        }

        private void abrirFormulario(IconMenuItem menu, Form form)
        {
            if (menuActivo != null)
            {
                menuActivo.BackColor = Color.Black;
                menuActivo.IconColor = Color.White;
                menuActivo.ForeColor = Color.White;
            }

            menu.BackColor = Color.DimGray;
            menu.IconColor = Color.Gold;
            menu.ForeColor = Color.Gold;
            menuActivo = menu;

            formularioActivo = form;
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            form.BackColor = Color.DimGray;

            mainMenuPanel.Controls.Add(form);
            form.Show();

        }

        private void Inicio_Load(object sender, EventArgs e)
        {

        }

        private void IcomVentas_Click(object sender, EventArgs e)
        {
            abrirFormulario((IconMenuItem)sender, new SalesForm());
        }

        private void ItemReportes_Click(object sender, EventArgs e)
        {
            abrirFormulario((IconMenuItem)sender, new ReportsForm());
        }

        private void ItemClientes_Click(object sender, EventArgs e) {
            abrirFormulario((IconMenuItem)sender, new ClientsForm());
        }

        private void itemUsuarios_Click(object sender, EventArgs e) {
            abrirFormulario((IconMenuItem)sender, new UsersForm());
        }

        private void ItemCompras_Click(object sender, EventArgs e) {
            abrirFormulario((IconMenuItem)sender, new ShoppingForm());
        }

        private void ItemProveedor_Click(object sender, EventArgs e)
        {
            abrirFormulario((IconMenuItem)sender, new SuppliersForm());
        }

    }
}
