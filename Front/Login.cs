using Service;
using System;
using System.Windows.Forms;

namespace Front
{
    public partial class Login : Form {

        UsuarioService userService = new UsuarioService();
        private PlaceholderTextBox userTextBox = new PlaceholderTextBox { PlaceholderText = "usuario" };
        private PlaceholderTextBox passTextBox = new PlaceholderTextBox { PlaceholderText = "clave" };
        public Login()
        {
            InitializeComponent();
             // 
            // userTextBox
            // 
            this.userTextBox.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.userTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.userTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.userTextBox.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userTextBox.Location = new System.Drawing.Point(47, 218);
            this.userTextBox.Name = "userTextBox";
            this.userTextBox.Size = new System.Drawing.Size(127, 22);
            this.userTextBox.TabIndex = 0;
            this.userTextBox.TabStop = false;
            this.userTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Login_KeyPress);
            // 
            // passTextBox
            // 
            this.passTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.passTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.passTextBox.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passTextBox.Location = new System.Drawing.Point(47, 259);
            this.passTextBox.Name = "passTextBox";
            this.passTextBox.PasswordChar = '*';
            this.passTextBox.Size = new System.Drawing.Size(127, 22);
            this.passTextBox.TabIndex = 1;
            this.passTextBox.TabStop = false;
            this.passTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Login_KeyPress); ;

            this.Controls.Add(this.passTextBox);
            this.Controls.Add(this.userTextBox);
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
            if (e.KeyChar.Equals('\r')) {
                var us = userService.buscarPorUsername(userTextBox.Text);
                if (us != null) {
                    if (us.pass == passTextBox.Text) {
                        new MainMenu(us).Show();
                    } else {
                        MessageBox.Show("Clave incorrecta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                } else {
                    MessageBox.Show("El usuario no existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
            
        }
    }
}
