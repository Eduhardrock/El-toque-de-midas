namespace El_Toque_de_Midas
{
    partial class ClientsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            label3 = new Label();
            label2 = new Label();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label1 = new Label();
            dniTextBox = new TextBox();
            clientBigLabel = new Label();
            dataGridView1 = new DataGridView();
            dni = new DataGridViewTextBoxColumn();
            nombre = new DataGridViewTextBoxColumn();
            lastName = new DataGridViewTextBoxColumn();
            telephone = new DataGridViewTextBoxColumn();
            email = new DataGridViewTextBoxColumn();
            address = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DimGray;
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(dniTextBox);
            panel1.Controls.Add(clientBigLabel);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(265, 536);
            panel1.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.White;
            label3.Location = new Point(22, 229);
            label3.Name = "label3";
            label3.Size = new Size(61, 15);
            label3.TabIndex = 8;
            label3.Text = "Nombre/s";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(22, 156);
            label2.Name = "label2";
            label2.Size = new Size(61, 15);
            label2.TabIndex = 7;
            label2.Text = "Apellido/s";
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.PaleGoldenrod;
            textBox2.Location = new Point(22, 247);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(221, 23);
            textBox2.TabIndex = 6;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.PaleGoldenrod;
            textBox1.Location = new Point(22, 174);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(221, 23);
            textBox1.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(22, 89);
            label1.Name = "label1";
            label1.Size = new Size(53, 15);
            label1.TabIndex = 4;
            label1.Text = "Nro. DNI";
            // 
            // dniTextBox
            // 
            dniTextBox.BackColor = Color.PaleGoldenrod;
            dniTextBox.Location = new Point(22, 107);
            dniTextBox.Name = "dniTextBox";
            dniTextBox.Size = new Size(221, 23);
            dniTextBox.TabIndex = 1;
            dniTextBox.Enter += textBox_Enter;
            dniTextBox.Leave += textBox_Leave;
            // 
            // clientBigLabel
            // 
            clientBigLabel.AutoSize = true;
            clientBigLabel.Font = new Font("Segoe UI Semibold", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            clientBigLabel.ForeColor = Color.White;
            clientBigLabel.Location = new Point(12, 11);
            clientBigLabel.Name = "clientBigLabel";
            clientBigLabel.Size = new Size(135, 45);
            clientBigLabel.TabIndex = 0;
            clientBigLabel.Text = "Clientes";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { dni, nombre, lastName, telephone, email, address });
            dataGridView1.Location = new Point(299, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(973, 536);
            dataGridView1.TabIndex = 1;
            // 
            // dni
            // 
            dni.HeaderText = "Nro. DNI";
            dni.Name = "dni";
            // 
            // nombre
            // 
            nombre.HeaderText = "Nombre";
            nombre.Name = "nombre";
            // 
            // lastName
            // 
            lastName.HeaderText = "Apellido/s";
            lastName.Name = "lastName";
            // 
            // telephone
            // 
            telephone.HeaderText = "Teléfono";
            telephone.Name = "telephone";
            // 
            // email
            // 
            email.HeaderText = "E-mail";
            email.Name = "email";
            // 
            // address
            // 
            address.HeaderText = "Dirección";
            address.Name = "address";
            // 
            // ClientsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(1284, 561);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            Name = "ClientsForm";
            Text = "Form1";
            Load += ClientsForm_Load;
            
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn dni;
        private DataGridViewTextBoxColumn nombre;
        private DataGridViewTextBoxColumn lastName;
        private DataGridViewTextBoxColumn telephone;
        private DataGridViewTextBoxColumn email;
        private DataGridViewTextBoxColumn address;
        private Label clientBigLabel;
        private Label label1;
        private TextBox dniTextBox;
        private Label label3;
        private Label label2;
        private TextBox textBox2;
        private TextBox textBox1;
    }
}