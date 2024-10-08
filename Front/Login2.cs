using Service;
using System;
using System.Windows.Forms;

namespace Front
{
    public partial class Login2 : Form
    {

        private UsuarioService us = new UsuarioService();
        public Login2()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Login_Enter(object sender, EventArgs e)
        {

        }

        private void Login_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.Equals('\r'))
            {
                /*var usuario = us.buscarPorUsername(userTextBox.Text);
                if (usuario != null)
                {
                    if (usuario.pass == userTextBox.Text)
                    {
                        new MainMenu().Show();
                        ((Form)sender).Close();
                    }
                    else
                    {
                        MessageBox.Show("Clave incorrecta");
                    }
                }
                else
                {
                    MessageBox.Show("El usuario no existe");
                }*/

            }

        }
    }
}
