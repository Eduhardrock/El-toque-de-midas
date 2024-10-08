
using System.Drawing;
using System.Windows.Forms;

namespace Front
{
    partial class UsersForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label4 = new System.Windows.Forms.Label();
            this.passTextBox = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rolComboBox = new System.Windows.Forms.ComboBox();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.dniTextBox = new System.Windows.Forms.TextBox();
            this.clientBigLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.searchButton = new FontAwesome.Sharp.IconButton();
            this.deleteButton = new FontAwesome.Sharp.IconButton();
            this.modifyButton = new FontAwesome.Sharp.IconButton();
            this.saveButton = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.usuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoEllipsis = true;
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(19, 241);
            this.label4.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Contraseña";
            // 
            // passTextBox
            // 
            this.passTextBox.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.passTextBox.Location = new System.Drawing.Point(19, 259);
            this.passTextBox.Margin = new System.Windows.Forms.Padding(3, 3, 3, 17);
            this.passTextBox.Name = "passTextBox";
            this.passTextBox.PasswordChar = '*';
            this.passTextBox.Size = new System.Drawing.Size(194, 20);
            this.passTextBox.TabIndex = 9;
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.PaleGoldenrod;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkGoldenrod;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Goldenrod;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Khaki;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DarkKhaki;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.Size = new System.Drawing.Size(870, 573);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(19, 185);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Rol";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(19, 130);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nombre de Usuario";
            // 
            // rolComboBox
            // 
            this.rolComboBox.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.rolComboBox.Location = new System.Drawing.Point(19, 204);
            this.rolComboBox.Margin = new System.Windows.Forms.Padding(3, 3, 3, 17);
            this.rolComboBox.Name = "rolComboBox";
            this.rolComboBox.Size = new System.Drawing.Size(194, 21);
            this.rolComboBox.TabIndex = 6;
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.usernameTextBox.Location = new System.Drawing.Point(19, 148);
            this.usernameTextBox.Margin = new System.Windows.Forms.Padding(3, 3, 3, 17);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(194, 20);
            this.usernameTextBox.TabIndex = 5;
            // 
            // dniTextBox
            // 
            this.dniTextBox.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.dniTextBox.Location = new System.Drawing.Point(19, 93);
            this.dniTextBox.Margin = new System.Windows.Forms.Padding(3, 3, 3, 17);
            this.dniTextBox.Name = "dniTextBox";
            this.dniTextBox.Size = new System.Drawing.Size(194, 20);
            this.dniTextBox.TabIndex = 1;
            // 
            // clientBigLabel
            // 
            this.clientBigLabel.AutoSize = true;
            this.clientBigLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientBigLabel.ForeColor = System.Drawing.Color.White;
            this.clientBigLabel.Location = new System.Drawing.Point(19, 19);
            this.clientBigLabel.Name = "clientBigLabel";
            this.clientBigLabel.Size = new System.Drawing.Size(146, 45);
            this.clientBigLabel.TabIndex = 0;
            this.clientBigLabel.Text = "Usuarios";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Controls.Add(this.idTextBox);
            this.panel1.Controls.Add(this.searchButton);
            this.panel1.Controls.Add(this.deleteButton);
            this.panel1.Controls.Add(this.modifyButton);
            this.panel1.Controls.Add(this.saveButton);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.passTextBox);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.rolComboBox);
            this.panel1.Controls.Add(this.usernameTextBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dniTextBox);
            this.panel1.Controls.Add(this.clientBigLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(228, 573);
            this.panel1.TabIndex = 1;
            // 
            // idTextBox
            // 
            this.idTextBox.BackColor = System.Drawing.Color.White;
            this.idTextBox.Location = new System.Drawing.Point(189, 28);
            this.idTextBox.Margin = new System.Windows.Forms.Padding(3, 3, 3, 17);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(24, 20);
            this.idTextBox.TabIndex = 19;
            this.idTextBox.Visible = false;
            // 
            // searchButton
            // 
            this.searchButton.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.searchButton.FlatAppearance.BorderColor = System.Drawing.Color.PaleGoldenrod;
            this.searchButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gold;
            this.searchButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Khaki;
            this.searchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchButton.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.searchButton.IconColor = System.Drawing.Color.Black;
            this.searchButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.searchButton.Location = new System.Drawing.Point(19, 422);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(45, 42);
            this.searchButton.TabIndex = 18;
            this.searchButton.UseVisualStyleBackColor = false;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.deleteButton.FlatAppearance.BorderColor = System.Drawing.Color.PaleGoldenrod;
            this.deleteButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gold;
            this.deleteButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Khaki;
            this.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteButton.IconChar = FontAwesome.Sharp.IconChar.Eraser;
            this.deleteButton.IconColor = System.Drawing.Color.Black;
            this.deleteButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.deleteButton.Location = new System.Drawing.Point(168, 422);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(45, 42);
            this.deleteButton.TabIndex = 17;
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // modifyButton
            // 
            this.modifyButton.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.modifyButton.FlatAppearance.BorderColor = System.Drawing.Color.PaleGoldenrod;
            this.modifyButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gold;
            this.modifyButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Khaki;
            this.modifyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.modifyButton.IconChar = FontAwesome.Sharp.IconChar.FilePen;
            this.modifyButton.IconColor = System.Drawing.Color.Black;
            this.modifyButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.modifyButton.Location = new System.Drawing.Point(118, 422);
            this.modifyButton.Name = "modifyButton";
            this.modifyButton.Size = new System.Drawing.Size(45, 42);
            this.modifyButton.TabIndex = 16;
            this.modifyButton.Text = "                                            ";
            this.modifyButton.UseVisualStyleBackColor = false;
            this.modifyButton.Click += new System.EventHandler(this.modifyButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.saveButton.FlatAppearance.BorderColor = System.Drawing.Color.PaleGoldenrod;
            this.saveButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gold;
            this.saveButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Khaki;
            this.saveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveButton.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            this.saveButton.IconColor = System.Drawing.Color.Black;
            this.saveButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.saveButton.Location = new System.Drawing.Point(69, 422);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(45, 42);
            this.saveButton.TabIndex = 15;
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(19, 75);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nro. DNI";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dataGridView1);
            this.splitContainer1.Size = new System.Drawing.Size(1101, 573);
            this.splitContainer1.SplitterDistance = 228;
            this.splitContainer1.SplitterWidth = 3;
            this.splitContainer1.TabIndex = 3;
            // 
            // usuarioBindingSource
            // 
            this.usuarioBindingSource.DataSource = typeof(ModelORM.usuario);
            // 
            // UsersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1101, 573);
            this.Controls.Add(this.splitContainer1);
            this.Name = "UsersForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {
        }

        #endregion
        private FontAwesome.Sharp.IconButton searchButton;
        private FontAwesome.Sharp.IconButton deleteButton;
        private FontAwesome.Sharp.IconButton modifyButton;
        private FontAwesome.Sharp.IconButton saveButton;
        private Label label4;
        private TextBox passTextBox;
        private DataGridView dataGridView1;
        private Label label3;
        private Label label2;
        private ComboBox rolComboBox;
        private TextBox usernameTextBox;
        private TextBox dniTextBox;
        private Label clientBigLabel;
        private Panel panel1;
        private Label label1;
        private SplitContainer splitContainer1;
        private BindingSource usuarioBindingSource;
        private TextBox idTextBox;
    }
}