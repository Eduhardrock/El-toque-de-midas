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
using Service;

namespace Front
{
    public partial class UsersForm : Form {

        UsuarioService usuarioService = new UsuarioService();
        RolService rolService = new RolService();
        EmpleadoService empleadoService = new EmpleadoService();
        PersonaService personaService = new PersonaService();
        public UsersForm()
        {
            InitializeComponent();
            cargaDatos();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;

            if (index >= 0)
            {
                idTextBox.Text = dataGridView1.Rows[index].Cells["id"].Value.ToString();
                usernameTextBox.Text = dataGridView1.Rows[index].Cells["username"].Value.ToString();
                rolComboBox.SelectedValue = int.Parse(dataGridView1.Rows[index].Cells["rolId"].Value.ToString());
                passTextBox.Text = dataGridView1.Rows[index].Cells["pass"].Value.ToString();
            }
        }

        private void cargaDatos () {

            dataGridView1.Rows.Clear(); // Clear all rows (if there are any)
            dataGridView1.Columns.Clear();

            rolComboBox.DisplayMember = "nombre";
            rolComboBox.ValueMember = "id";
            rolComboBox.DataSource = this.rolService.listarTodas();
            rolComboBox.SelectedIndex = -1;

            List<usuario> users = this.usuarioService.listarTodos();

            // Crear DataGridView
            dataGridView1.AutoGenerateColumns = false;

            // Agregar columnas para Usuario y Empleado
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Id Usuario", Name = "id" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Nombre de Usuario", Name = "username" });
            //dataGridView1.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Nombre Empleado", Name = "empleadoPersonaNombre" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Rol Usuario", Name = "rolNombre" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "RolId", Name = "rolId", Visible = false });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Fecha De Ingreso", Name = "empleadoFechaIngreso" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Clave", Name = "pass", Visible = false});
            
            //dataGridView1.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Nombre Empleado", Name = "empleadoPersonaNombre" });

            // Llenar el DataGridView con datos de ambas fuentes
            foreach (var usuario in users)
            {
                dataGridView1.Rows.Add(
                    usuario.id,
                    usuario.username,
                    usuario.rol.nombre,
                    usuario.rol.id,
                    usuario.empleado.fechaIngreso,
                    usuario.pass
                    );
            }

        }

        private void searchButton_Click(object sender, EventArgs e) {

            /*usuarioService.buscarPorUsername
            var username = usernameTextBox.Text;
            var id_rol = rolComboBox.SelectedIndex;
            List<usuario> users = this.usuarioService.*/

        }

        private void saveButton_Click(object sender, EventArgs e) {
            persona p = personaService.buscarPorDni(dniTextBox.Text);
            if (p != null) {
                empleado em = empleadoService.buscarPorIdPersona(p.id);
                if (em != null) {
                    usuario us = new usuario();
                    us.pass = passTextBox.Text;
                    us.username = usernameTextBox.Text;
                    us.id_empleado = em.id;
                    us.id_rol = (int)rolComboBox.SelectedValue;
                    usuarioService.agregar(us);
                    cargaDatos();
                    limpiarFormularios();
                }
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            usuarioService.eliminarPorId(int.Parse(idTextBox.Text));
            limpiarFormularios();
            cargaDatos();
        }

        private void modifyButton_Click(object sender, EventArgs e)
        {
            
            usuario us = new usuario();
            us.pass = passTextBox.Text;
            us.username = usernameTextBox.Text;
            us.id_rol = (int)rolComboBox.SelectedValue;
            usuarioService.actualizar(int.Parse(idTextBox.Text), us);
            cargaDatos();
            limpiarFormularios();
        }
    
        private void limpiarFormularios ()
        {
            idTextBox.Text = "0";
            passTextBox.Text = "";
            usernameTextBox.Text = "";
            dniTextBox.Text = "";
            rolComboBox.SelectedIndex = -1;
            
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }
    }
}
