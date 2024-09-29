
namespace El_Toque_de_Midas
{
    partial class SuppliersForm
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            splitContainer1 = new SplitContainer();
            panel1 = new Panel();
            searchButton = new FontAwesome.Sharp.IconButton();
            deleteButton = new FontAwesome.Sharp.IconButton();
            modifyButton = new FontAwesome.Sharp.IconButton();
            saveButton = new FontAwesome.Sharp.IconButton();
            label6 = new Label();
            addressTextBox = new TextBox();
            label5 = new Label();
            emailTextBox = new TextBox();
            label4 = new Label();
            telTextBox = new TextBox();
            label3 = new Label();
            label2 = new Label();
            nameTextBox = new TextBox();
            lastNameTextBox = new TextBox();
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
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(panel1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(dataGridView1);
            splitContainer1.Panel2.Paint += splitContainer1_Panel2_Paint;
            splitContainer1.Size = new Size(1284, 661);
            splitContainer1.SplitterDistance = 266;
            splitContainer1.TabIndex = 4;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DimGray;
            panel1.Controls.Add(searchButton);
            panel1.Controls.Add(deleteButton);
            panel1.Controls.Add(modifyButton);
            panel1.Controls.Add(saveButton);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(addressTextBox);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(emailTextBox);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(telTextBox);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(nameTextBox);
            panel1.Controls.Add(lastNameTextBox);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(dniTextBox);
            panel1.Controls.Add(clientBigLabel);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(266, 661);
            panel1.TabIndex = 1;
            // 
            // searchButton
            // 
            searchButton.BackColor = Color.PaleGoldenrod;
            searchButton.FlatAppearance.BorderColor = Color.PaleGoldenrod;
            searchButton.FlatAppearance.MouseDownBackColor = Color.Gold;
            searchButton.FlatAppearance.MouseOverBackColor = Color.Khaki;
            searchButton.FlatStyle = FlatStyle.Flat;
            searchButton.IconChar = FontAwesome.Sharp.IconChar.Search;
            searchButton.IconColor = Color.Black;
            searchButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            searchButton.Location = new Point(22, 487);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(52, 49);
            searchButton.TabIndex = 18;
            searchButton.UseVisualStyleBackColor = false;
            // 
            // deleteButton
            // 
            deleteButton.BackColor = Color.PaleGoldenrod;
            deleteButton.FlatAppearance.BorderColor = Color.PaleGoldenrod;
            deleteButton.FlatAppearance.MouseDownBackColor = Color.Gold;
            deleteButton.FlatAppearance.MouseOverBackColor = Color.Khaki;
            deleteButton.FlatStyle = FlatStyle.Flat;
            deleteButton.IconChar = FontAwesome.Sharp.IconChar.Eraser;
            deleteButton.IconColor = Color.Black;
            deleteButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            deleteButton.Location = new Point(196, 487);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(52, 49);
            deleteButton.TabIndex = 17;
            deleteButton.UseVisualStyleBackColor = false;
            // 
            // modifyButton
            // 
            modifyButton.BackColor = Color.PaleGoldenrod;
            modifyButton.FlatAppearance.BorderColor = Color.PaleGoldenrod;
            modifyButton.FlatAppearance.MouseDownBackColor = Color.Gold;
            modifyButton.FlatAppearance.MouseOverBackColor = Color.Khaki;
            modifyButton.FlatStyle = FlatStyle.Flat;
            modifyButton.IconChar = FontAwesome.Sharp.IconChar.FilePen;
            modifyButton.IconColor = Color.Black;
            modifyButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            modifyButton.Location = new Point(138, 487);
            modifyButton.Name = "modifyButton";
            modifyButton.Size = new Size(52, 49);
            modifyButton.TabIndex = 16;
            modifyButton.Text = "                                            ";
            modifyButton.UseVisualStyleBackColor = false;
            // 
            // saveButton
            // 
            saveButton.BackColor = Color.PaleGoldenrod;
            saveButton.FlatAppearance.BorderColor = Color.PaleGoldenrod;
            saveButton.FlatAppearance.MouseDownBackColor = Color.Gold;
            saveButton.FlatAppearance.MouseOverBackColor = Color.Khaki;
            saveButton.FlatStyle = FlatStyle.Flat;
            saveButton.IconChar = FontAwesome.Sharp.IconChar.Save;
            saveButton.IconColor = Color.Black;
            saveButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            saveButton.Location = new Point(80, 487);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(52, 49);
            saveButton.TabIndex = 15;
            saveButton.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.White;
            label6.Location = new Point(22, 406);
            label6.Margin = new Padding(3, 0, 3, 3);
            label6.Name = "label6";
            label6.Size = new Size(57, 15);
            label6.TabIndex = 14;
            label6.Text = "Dirección";
            // 
            // addressTextBox
            // 
            addressTextBox.BackColor = Color.PaleGoldenrod;
            addressTextBox.Location = new Point(22, 427);
            addressTextBox.Margin = new Padding(3, 3, 3, 20);
            addressTextBox.Name = "addressTextBox";
            addressTextBox.Size = new Size(226, 23);
            addressTextBox.TabIndex = 13;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.White;
            label5.Location = new Point(22, 342);
            label5.Margin = new Padding(3, 0, 3, 3);
            label5.Name = "label5";
            label5.Size = new Size(36, 15);
            label5.TabIndex = 12;
            label5.Text = "Email";
            // 
            // emailTextBox
            // 
            emailTextBox.BackColor = Color.PaleGoldenrod;
            emailTextBox.Location = new Point(22, 363);
            emailTextBox.Margin = new Padding(3, 3, 3, 20);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(226, 23);
            emailTextBox.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoEllipsis = true;
            label4.AutoSize = true;
            label4.ForeColor = Color.White;
            label4.Location = new Point(22, 278);
            label4.Margin = new Padding(3, 0, 3, 3);
            label4.Name = "label4";
            label4.Size = new Size(52, 15);
            label4.TabIndex = 10;
            label4.Text = "Teléfono";
            // 
            // telTextBox
            // 
            telTextBox.BackColor = Color.PaleGoldenrod;
            telTextBox.Location = new Point(22, 299);
            telTextBox.Margin = new Padding(3, 3, 3, 20);
            telTextBox.Name = "telTextBox";
            telTextBox.Size = new Size(226, 23);
            telTextBox.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.White;
            label3.Location = new Point(22, 214);
            label3.Margin = new Padding(3, 0, 3, 3);
            label3.Name = "label3";
            label3.Size = new Size(61, 15);
            label3.TabIndex = 8;
            label3.Text = "Nombre/s";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(22, 150);
            label2.Margin = new Padding(3, 0, 3, 3);
            label2.Name = "label2";
            label2.Size = new Size(61, 15);
            label2.TabIndex = 7;
            label2.Text = "Apellido/s";
            // 
            // nameTextBox
            // 
            nameTextBox.BackColor = Color.PaleGoldenrod;
            nameTextBox.Location = new Point(22, 235);
            nameTextBox.Margin = new Padding(3, 3, 3, 20);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(226, 23);
            nameTextBox.TabIndex = 6;
            // 
            // lastNameTextBox
            // 
            lastNameTextBox.BackColor = Color.PaleGoldenrod;
            lastNameTextBox.Location = new Point(22, 171);
            lastNameTextBox.Margin = new Padding(3, 3, 3, 20);
            lastNameTextBox.Name = "lastNameTextBox";
            lastNameTextBox.Size = new Size(226, 23);
            lastNameTextBox.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(22, 86);
            label1.Margin = new Padding(3, 0, 3, 3);
            label1.Name = "label1";
            label1.Size = new Size(53, 15);
            label1.TabIndex = 4;
            label1.Text = "Nro. DNI";
            // 
            // dniTextBox
            // 
            dniTextBox.BackColor = Color.PaleGoldenrod;
            dniTextBox.Location = new Point(22, 107);
            dniTextBox.Margin = new Padding(3, 3, 3, 20);
            dniTextBox.Name = "dniTextBox";
            dniTextBox.Size = new Size(226, 23);
            dniTextBox.TabIndex = 1;
            // 
            // clientBigLabel
            // 
            clientBigLabel.AutoSize = true;
            clientBigLabel.Font = new Font("Segoe UI Semibold", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            clientBigLabel.ForeColor = Color.White;
            clientBigLabel.Location = new Point(22, 22);
            clientBigLabel.Name = "clientBigLabel";
            clientBigLabel.Size = new Size(201, 45);
            clientBigLabel.TabIndex = 0;
            clientBigLabel.Text = "Proveedores";
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.BackColor = Color.PaleGoldenrod;
            dataGridViewCellStyle1.SelectionBackColor = Color.DarkGoldenrod;
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.Goldenrod;
            dataGridViewCellStyle2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = Color.IndianRed;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { dni, nombre, lastName, telephone, email, address });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(1014, 661);
            dataGridView1.TabIndex = 3;
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
            // SuppliersForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(1284, 661);
            Controls.Add(splitContainer1);
            Name = "SuppliersForm";
            Text = "Form1";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {
            
        }

        #endregion

        private SplitContainer splitContainer1;
        private Panel panel1;
        private FontAwesome.Sharp.IconButton searchButton;
        private FontAwesome.Sharp.IconButton deleteButton;
        private FontAwesome.Sharp.IconButton modifyButton;
        private FontAwesome.Sharp.IconButton saveButton;
        private Label label6;
        private TextBox addressTextBox;
        private Label label5;
        private TextBox emailTextBox;
        private Label label4;
        private TextBox telTextBox;
        private Label label3;
        private Label label2;
        private TextBox nameTextBox;
        private TextBox lastNameTextBox;
        private Label label1;
        private TextBox dniTextBox;
        private Label clientBigLabel;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn dni;
        private DataGridViewTextBoxColumn nombre;
        private DataGridViewTextBoxColumn lastName;
        private DataGridViewTextBoxColumn telephone;
        private DataGridViewTextBoxColumn email;
        private DataGridViewTextBoxColumn address;
    }
}