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
    public partial class MainMenu : Form
    {

        //private static Usuario usuario;
        private static IconMenuItem menuActivo = null;
        private static Form formularioActivo = null;
        private usuario user;

        public MainMenu(usuario user)
        {
            this.user = user;
            InitializeComponent();
            //labelRol.Text = this.user.rol.nombre;
            labelUser.Text = this.user.username;
            int widthAdjustment = this.labelUser.Width; // Obtén el ancho del Label
            this.labelUser.Location = new System.Drawing.Point(1054 - widthAdjustment, 32);

            if (this.user.id_rol == 2) {
                itemUsuarios.Visible = false;
                ItemProveedor.Visible = false;
                ItemCompras.Visible = false;
                ItemReportes.Visible = false;
            }

            if (this.user.id_rol == 4) {
                itemUsuarios.Visible = false;
                IcomVentas.Visible = false;
                ItemReportes.Visible = false;
                ItemReportes.Visible = false;
            }
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

            if (formularioActivo != null)
            {
                formularioActivo.Close();
            }

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

        private void ItemClientes_Click(object sender, EventArgs e)
        {
            abrirFormulario((IconMenuItem)sender, new ClientsForm());
        }

        private void itemUsuarios_Click(object sender, EventArgs e)
        {
            abrirFormulario((IconMenuItem)sender, new UsersForm());
        }

        private void ItemCompras_Click(object sender, EventArgs e)
        {
            abrirFormulario((IconMenuItem)sender, new ShoppingForm());
        }

        private void ItemProveedor_Click(object sender, EventArgs e)
        {
            abrirFormulario((IconMenuItem)sender, new SuppliersForm());
        }

        private void ItemProductos_Click(object sender, EventArgs e)
        {
            abrirFormulario((IconMenuItem)sender, new ProductsForm());
        }

        private void ItemAcercaDe_Click(object sender, EventArgs e)
        {
            new AboutForm().Show();
        }
    }
}
