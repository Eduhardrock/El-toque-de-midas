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
    public partial class ClientsForm : Form
    {
        public ClientsForm()
        {
            InitializeComponent();
        }

        private void ClientsForm_Load(object sender, EventArgs e)
        {

        }

        private void textBox_Enter(object sender, EventArgs e)
        {
            
            ((ClientsForm)sender).= Color.Khaki;
        }

        private void textBox_Leave(object sender, EventArgs e)
        {
            ((TextBox) sender).BackColor = Color.PaleGoldenrod;
        }

        
    }
}
