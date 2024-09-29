namespace El_Toque_de_Midas
{
    partial class ShoppingForm
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
            clientBigLabel = new Label();
            label2 = new Label();
            label1 = new Label();
            lastNameTextBox = new TextBox();
            infoVentaGroupBox = new GroupBox();
            dniTextBox = new TextBox();
            label3 = new Label();
            label4 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            groupBox1 = new GroupBox();
            saveButton = new FontAwesome.Sharp.IconButton();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            numericUpDown1 = new NumericUpDown();
            textBox6 = new TextBox();
            textBox5 = new TextBox();
            label5 = new Label();
            label6 = new Label();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            SubTotal = new DataGridViewTextBoxColumn();
            Cantidad = new DataGridViewTextBoxColumn();
            Precio = new DataGridViewTextBoxColumn();
            Producto = new DataGridViewTextBoxColumn();
            idProducto = new DataGridViewTextBoxColumn();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            label10 = new Label();
            textBox7 = new TextBox();
            dataGridView1 = new DataGridView();
            groupBox2 = new GroupBox();
            panel1 = new Panel();
            infoVentaGroupBox.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // clientBigLabel
            // 
            clientBigLabel.AutoSize = true;
            clientBigLabel.Font = new Font("Segoe UI Semibold", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            clientBigLabel.ForeColor = Color.White;
            clientBigLabel.Location = new Point(3, 0);
            clientBigLabel.Name = "clientBigLabel";
            clientBigLabel.Size = new Size(149, 45);
            clientBigLabel.TabIndex = 1;
            clientBigLabel.Text = "Compras";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(250, 33);
            label2.Margin = new Padding(3, 0, 3, 3);
            label2.Name = "label2";
            label2.Size = new Size(96, 15);
            label2.TabIndex = 8;
            label2.Text = "Tipo Documento";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(18, 33);
            label1.Margin = new Padding(3, 0, 3, 3);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 7;
            label1.Text = "Fecha";
            // 
            // lastNameTextBox
            // 
            lastNameTextBox.BackColor = Color.PaleGoldenrod;
            lastNameTextBox.Location = new Point(250, 54);
            lastNameTextBox.Margin = new Padding(3, 3, 3, 20);
            lastNameTextBox.Name = "lastNameTextBox";
            lastNameTextBox.Size = new Size(226, 23);
            lastNameTextBox.TabIndex = 6;
            // 
            // infoVentaGroupBox
            // 
            infoVentaGroupBox.Controls.Add(label2);
            infoVentaGroupBox.Controls.Add(label1);
            infoVentaGroupBox.Controls.Add(lastNameTextBox);
            infoVentaGroupBox.Controls.Add(dniTextBox);
            infoVentaGroupBox.ForeColor = Color.White;
            infoVentaGroupBox.Location = new Point(18, 48);
            infoVentaGroupBox.Name = "infoVentaGroupBox";
            infoVentaGroupBox.Size = new Size(487, 100);
            infoVentaGroupBox.TabIndex = 2;
            infoVentaGroupBox.TabStop = false;
            infoVentaGroupBox.Text = "Información de la Venta";
            // 
            // dniTextBox
            // 
            dniTextBox.BackColor = Color.PaleGoldenrod;
            dniTextBox.Location = new Point(18, 54);
            dniTextBox.Margin = new Padding(3, 3, 3, 20);
            dniTextBox.Name = "dniTextBox";
            dniTextBox.Size = new Size(226, 23);
            dniTextBox.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.White;
            label3.Location = new Point(250, 33);
            label3.Margin = new Padding(3, 0, 3, 3);
            label3.Name = "label3";
            label3.Size = new Size(107, 15);
            label3.TabIndex = 8;
            label3.Text = "Nombre Completo";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.White;
            label4.Location = new Point(18, 33);
            label4.Margin = new Padding(3, 0, 3, 3);
            label4.Name = "label4";
            label4.Size = new Size(112, 15);
            label4.TabIndex = 7;
            label4.Text = "Nro. de Documento";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.PaleGoldenrod;
            textBox1.Location = new Point(250, 54);
            textBox1.Margin = new Padding(3, 3, 3, 20);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(226, 23);
            textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.PaleGoldenrod;
            textBox2.Location = new Point(18, 54);
            textBox2.Margin = new Padding(3, 3, 3, 20);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(226, 23);
            textBox2.TabIndex = 2;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(textBox2);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(521, 48);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(487, 100);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Información del Cliente";
            // 
            // saveButton
            // 
            saveButton.BackColor = Color.PaleGoldenrod;
            saveButton.FlatAppearance.BorderColor = Color.PaleGoldenrod;
            saveButton.FlatAppearance.MouseDownBackColor = Color.Gold;
            saveButton.FlatAppearance.MouseOverBackColor = Color.Khaki;
            saveButton.FlatStyle = FlatStyle.Flat;
            saveButton.IconChar = FontAwesome.Sharp.IconChar.Add;
            saveButton.IconColor = Color.Black;
            saveButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            saveButton.Location = new Point(913, 28);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(52, 49);
            saveButton.TabIndex = 16;
            saveButton.UseVisualStyleBackColor = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ForeColor = Color.White;
            label9.Location = new Point(753, 33);
            label9.Margin = new Padding(3, 0, 3, 3);
            label9.Name = "label9";
            label9.Size = new Size(55, 15);
            label9.TabIndex = 14;
            label9.Text = "Cantidad";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = Color.White;
            label8.Location = new Point(619, 33);
            label8.Margin = new Padding(3, 0, 3, 3);
            label8.Name = "label8";
            label8.Size = new Size(36, 15);
            label8.TabIndex = 13;
            label8.Text = "Stock";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.White;
            label7.Location = new Point(482, 33);
            label7.Margin = new Padding(3, 0, 3, 3);
            label7.Name = "label7";
            label7.Size = new Size(40, 15);
            label7.TabIndex = 12;
            label7.Text = "Precio";
            // 
            // numericUpDown1
            // 
            numericUpDown1.BackColor = Color.PaleGoldenrod;
            numericUpDown1.Location = new Point(753, 54);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(128, 23);
            numericUpDown1.TabIndex = 11;
            // 
            // textBox6
            // 
            textBox6.BackColor = Color.PaleGoldenrod;
            textBox6.Location = new Point(619, 54);
            textBox6.Margin = new Padding(3, 3, 3, 20);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(128, 23);
            textBox6.TabIndex = 10;
            // 
            // textBox5
            // 
            textBox5.BackColor = Color.PaleGoldenrod;
            textBox5.Location = new Point(482, 54);
            textBox5.Margin = new Padding(3, 3, 3, 20);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(128, 23);
            textBox5.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.White;
            label5.Location = new Point(250, 33);
            label5.Margin = new Padding(3, 0, 3, 3);
            label5.Name = "label5";
            label5.Size = new Size(69, 15);
            label5.TabIndex = 8;
            label5.Text = "Descripción";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.White;
            label6.Location = new Point(18, 33);
            label6.Margin = new Padding(3, 0, 3, 3);
            label6.Name = "label6";
            label6.Size = new Size(114, 15);
            label6.TabIndex = 7;
            label6.Text = "Código de Producto";
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.PaleGoldenrod;
            textBox3.Location = new Point(250, 54);
            textBox3.Margin = new Padding(3, 3, 3, 20);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(226, 23);
            textBox3.TabIndex = 6;
            // 
            // textBox4
            // 
            textBox4.BackColor = Color.PaleGoldenrod;
            textBox4.Location = new Point(18, 54);
            textBox4.Margin = new Padding(3, 3, 3, 20);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(226, 23);
            textBox4.TabIndex = 2;
            // 
            // SubTotal
            // 
            SubTotal.HeaderText = "Sub Total";
            SubTotal.Name = "SubTotal";
            // 
            // Cantidad
            // 
            Cantidad.HeaderText = "Cantidad";
            Cantidad.Name = "Cantidad";
            // 
            // Precio
            // 
            Precio.HeaderText = "Precio";
            Precio.Name = "Precio";
            // 
            // Producto
            // 
            Producto.HeaderText = "Producto";
            Producto.Name = "Producto";
            // 
            // idProducto
            // 
            idProducto.HeaderText = "";
            idProducto.Name = "idProducto";
            // 
            // iconButton1
            // 
            iconButton1.BackColor = Color.PaleGoldenrod;
            iconButton1.FlatAppearance.BorderColor = Color.PaleGoldenrod;
            iconButton1.FlatAppearance.MouseDownBackColor = Color.Gold;
            iconButton1.FlatAppearance.MouseOverBackColor = Color.Khaki;
            iconButton1.FlatStyle = FlatStyle.Flat;
            iconButton1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            iconButton1.ForeColor = Color.Black;
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.Tag;
            iconButton1.IconColor = Color.Black;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton1.Location = new Point(771, 474);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(107, 49);
            iconButton1.TabIndex = 17;
            iconButton1.Text = "Cargar\r\nCompra";
            iconButton1.TextAlign = ContentAlignment.TopRight;
            iconButton1.UseVisualStyleBackColor = false;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.ForeColor = Color.White;
            label10.Location = new Point(771, 346);
            label10.Margin = new Padding(3, 0, 3, 3);
            label10.Name = "label10";
            label10.Size = new Size(74, 15);
            label10.TabIndex = 14;
            label10.Text = "Total a Pagar";
            // 
            // textBox7
            // 
            textBox7.BackColor = Color.PaleGoldenrod;
            textBox7.Location = new Point(771, 367);
            textBox7.Margin = new Padding(3, 3, 3, 20);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(128, 23);
            textBox7.TabIndex = 11;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { idProducto, Producto, Precio, Cantidad, SubTotal });
            dataGridView1.Location = new Point(18, 269);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(718, 254);
            dataGridView1.TabIndex = 5;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(saveButton);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(numericUpDown1);
            groupBox2.Controls.Add(textBox6);
            groupBox2.Controls.Add(textBox5);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(textBox3);
            groupBox2.Controls.Add(textBox4);
            groupBox2.ForeColor = Color.White;
            groupBox2.Location = new Point(18, 163);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(990, 100);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "Información de Producto";
            // 
            // panel1
            // 
            panel1.BackColor = Color.DimGray;
            panel1.Controls.Add(iconButton1);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(textBox7);
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(groupBox2);
            panel1.Controls.Add(groupBox1);
            panel1.Controls.Add(infoVentaGroupBox);
            panel1.Controls.Add(clientBigLabel);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(1024, 537);
            panel1.TabIndex = 1;
            // 
            // ShoppingForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(1284, 661);
            Controls.Add(panel1);
            Name = "ShoppingForm";
            Text = "Form1";
            infoVentaGroupBox.ResumeLayout(false);
            infoVentaGroupBox.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label clientBigLabel;
        private Label label2;
        private Label label1;
        private TextBox lastNameTextBox;
        private GroupBox infoVentaGroupBox;
        private TextBox dniTextBox;
        private Label label3;
        private Label label4;
        private TextBox textBox1;
        private TextBox textBox2;
        private GroupBox groupBox1;
        private FontAwesome.Sharp.IconButton saveButton;
        private Label label9;
        private Label label8;
        private Label label7;
        private NumericUpDown numericUpDown1;
        private TextBox textBox6;
        private TextBox textBox5;
        private Label label5;
        private Label label6;
        private TextBox textBox3;
        private TextBox textBox4;
        private DataGridViewTextBoxColumn SubTotal;
        private DataGridViewTextBoxColumn Cantidad;
        private DataGridViewTextBoxColumn Precio;
        private DataGridViewTextBoxColumn Producto;
        private DataGridViewTextBoxColumn idProducto;
        private FontAwesome.Sharp.IconButton iconButton1;
        private Label label10;
        private TextBox textBox7;
        private DataGridView dataGridView1;
        private GroupBox groupBox2;
        private Panel panel1;
    }
}