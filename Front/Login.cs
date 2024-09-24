using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Service;
using Model;
using ModelORM;

namespace Front
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnIniciarSession_Click(object sender, EventArgs e)
        {

            string username = tbUsername.Text;
            string password = tbPass.Text;


            UsuarioService usuarioService = new UsuarioService();
            //UsuarioModel user = usuarioService.buscarPorUsername(username);


            InicioForm inicioForm = new InicioForm();
            inicioForm.Show();
            this.Hide();

            inicioForm.FormClosing += form_closing;

        }


        private void form_closing(object sender, FormClosingEventArgs e)
        {
            tbUsername.Clear();
            tbPass.Clear();
            this.Show();
        }
    }
}
