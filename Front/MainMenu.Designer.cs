using System.Drawing;
using System.Windows.Forms;

namespace Front
{
    partial class MainMenu
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
            this.menuInicio = new System.Windows.Forms.MenuStrip();
            this.itemUsuarios = new FontAwesome.Sharp.IconMenuItem();
            this.itemProductos = new FontAwesome.Sharp.IconMenuItem();
            this.IcomVentas = new FontAwesome.Sharp.IconMenuItem();
            this.ItemCompras = new FontAwesome.Sharp.IconMenuItem();
            this.ItemProveedor = new FontAwesome.Sharp.IconMenuItem();
            this.ItemReportes = new FontAwesome.Sharp.IconMenuItem();
            this.ItemClientes = new FontAwesome.Sharp.IconMenuItem();
            this.ItemAcercaDe = new FontAwesome.Sharp.IconMenuItem();
            this.mainMenuPanel = new System.Windows.Forms.Panel();
            this.labelUser = new System.Windows.Forms.Label();
            this.menuInicio.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuInicio
            // 
            this.menuInicio.BackColor = System.Drawing.Color.Black;
            this.menuInicio.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 0);
            this.menuInicio.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemUsuarios,
            this.itemProductos,
            this.IcomVentas,
            this.ItemCompras,
            this.ItemProveedor,
            this.ItemReportes,
            this.ItemClientes,
            this.ItemAcercaDe});
            this.menuInicio.Location = new System.Drawing.Point(0, 0);
            this.menuInicio.Name = "menuInicio";
            this.menuInicio.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuInicio.Size = new System.Drawing.Size(1101, 71);
            this.menuInicio.TabIndex = 0;
            this.menuInicio.Text = "menuInicio";
            // 
            // itemUsuarios
            // 
            this.itemUsuarios.BackColor = System.Drawing.Color.Black;
            this.itemUsuarios.ForeColor = System.Drawing.Color.White;
            this.itemUsuarios.IconChar = FontAwesome.Sharp.IconChar.UsersGear;
            this.itemUsuarios.IconColor = System.Drawing.Color.White;
            this.itemUsuarios.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.itemUsuarios.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.itemUsuarios.Name = "itemUsuarios";
            this.itemUsuarios.Size = new System.Drawing.Size(64, 67);
            this.itemUsuarios.Text = "Usuarios";
            this.itemUsuarios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.itemUsuarios.Click += new System.EventHandler(this.itemUsuarios_Click);
            // 
            // itemProductos
            // 
            this.itemProductos.BackColor = System.Drawing.Color.Black;
            this.itemProductos.ForeColor = System.Drawing.Color.White;
            this.itemProductos.IconChar = FontAwesome.Sharp.IconChar.Barcode;
            this.itemProductos.IconColor = System.Drawing.Color.White;
            this.itemProductos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.itemProductos.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.itemProductos.Name = "itemProductos";
            this.itemProductos.Size = new System.Drawing.Size(73, 67);
            this.itemProductos.Text = "Productos";
            this.itemProductos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.itemProductos.Click += new System.EventHandler(this.ItemProductos_Click);
            // 
            // IcomVentas
            // 
            this.IcomVentas.BackColor = System.Drawing.Color.Black;
            this.IcomVentas.ForeColor = System.Drawing.Color.White;
            this.IcomVentas.IconChar = FontAwesome.Sharp.IconChar.Tags;
            this.IcomVentas.IconColor = System.Drawing.Color.White;
            this.IcomVentas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IcomVentas.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.IcomVentas.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.IcomVentas.Name = "IcomVentas";
            this.IcomVentas.Size = new System.Drawing.Size(60, 67);
            this.IcomVentas.Text = "Ventas";
            this.IcomVentas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.IcomVentas.Click += new System.EventHandler(this.IcomVentas_Click);
            // 
            // ItemCompras
            // 
            this.ItemCompras.BackColor = System.Drawing.Color.Black;
            this.ItemCompras.ForeColor = System.Drawing.Color.White;
            this.ItemCompras.IconChar = FontAwesome.Sharp.IconChar.DollyFlatbed;
            this.ItemCompras.IconColor = System.Drawing.Color.White;
            this.ItemCompras.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ItemCompras.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ItemCompras.Name = "ItemCompras";
            this.ItemCompras.Size = new System.Drawing.Size(67, 67);
            this.ItemCompras.Text = "Compras";
            this.ItemCompras.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ItemCompras.Click += new System.EventHandler(this.ItemCompras_Click);
            // 
            // ItemProveedor
            // 
            this.ItemProveedor.BackColor = System.Drawing.Color.Black;
            this.ItemProveedor.ForeColor = System.Drawing.Color.White;
            this.ItemProveedor.IconChar = FontAwesome.Sharp.IconChar.Truck;
            this.ItemProveedor.IconColor = System.Drawing.Color.White;
            this.ItemProveedor.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ItemProveedor.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ItemProveedor.Name = "ItemProveedor";
            this.ItemProveedor.Size = new System.Drawing.Size(84, 67);
            this.ItemProveedor.Text = "Proveedores";
            this.ItemProveedor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ItemProveedor.Click += new System.EventHandler(this.ItemProveedor_Click);
            // 
            // ItemReportes
            // 
            this.ItemReportes.BackColor = System.Drawing.Color.Black;
            this.ItemReportes.ForeColor = System.Drawing.Color.White;
            this.ItemReportes.IconChar = FontAwesome.Sharp.IconChar.ChartColumn;
            this.ItemReportes.IconColor = System.Drawing.Color.White;
            this.ItemReportes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ItemReportes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ItemReportes.Name = "ItemReportes";
            this.ItemReportes.Size = new System.Drawing.Size(65, 67);
            this.ItemReportes.Text = "Reportes";
            this.ItemReportes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ItemReportes.Click += new System.EventHandler(this.ItemReportes_Click);
            // 
            // ItemClientes
            // 
            this.ItemClientes.BackColor = System.Drawing.Color.Black;
            this.ItemClientes.ForeColor = System.Drawing.Color.White;
            this.ItemClientes.IconChar = FontAwesome.Sharp.IconChar.ContactBook;
            this.ItemClientes.IconColor = System.Drawing.Color.White;
            this.ItemClientes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ItemClientes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ItemClientes.Name = "ItemClientes";
            this.ItemClientes.Size = new System.Drawing.Size(61, 67);
            this.ItemClientes.Text = "Clientes";
            this.ItemClientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ItemClientes.Click += new System.EventHandler(this.ItemClientes_Click);
            // 
            // ItemAcercaDe
            // 
            this.ItemAcercaDe.BackColor = System.Drawing.Color.Black;
            this.ItemAcercaDe.ForeColor = System.Drawing.Color.White;
            this.ItemAcercaDe.IconChar = FontAwesome.Sharp.IconChar.CircleInfo;
            this.ItemAcercaDe.IconColor = System.Drawing.Color.White;
            this.ItemAcercaDe.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ItemAcercaDe.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ItemAcercaDe.Name = "ItemAcercaDe";
            this.ItemAcercaDe.Size = new System.Drawing.Size(72, 67);
            this.ItemAcercaDe.Text = "Acerca De";
            this.ItemAcercaDe.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ItemAcercaDe.Click += new System.EventHandler(this.ItemAcercaDe_Click);
            // 
            // mainMenuPanel
            // 
            this.mainMenuPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainMenuPanel.ForeColor = System.Drawing.Color.White;
            this.mainMenuPanel.Location = new System.Drawing.Point(0, 71);
            this.mainMenuPanel.Name = "mainMenuPanel";
            this.mainMenuPanel.Size = new System.Drawing.Size(1101, 502);
            this.mainMenuPanel.TabIndex = 1;
            // 
            // labelUser
            // 
            this.labelUser.AutoSize = true;
            this.labelUser.BackColor = System.Drawing.Color.Black;
            this.labelUser.ForeColor = System.Drawing.Color.White;
            this.labelUser.Location = new System.Drawing.Point(1054, 32);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(0, 13);
            this.labelUser.TabIndex = 2;
            this.labelUser.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1101, 573);
            this.Controls.Add(this.labelUser);
            this.Controls.Add(this.mainMenuPanel);
            this.Controls.Add(this.menuInicio);
            this.MainMenuStrip = this.menuInicio;
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Toque de Midas - Menú Principal";
            this.menuInicio.ResumeLayout(false);
            this.menuInicio.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuInicio;
        private FontAwesome.Sharp.IconMenuItem ItemAcercaDe;
        private FontAwesome.Sharp.IconMenuItem itemUsuarios;
        private FontAwesome.Sharp.IconMenuItem IcomVentas;
        private FontAwesome.Sharp.IconMenuItem ItemCompras;
        private FontAwesome.Sharp.IconMenuItem ItemProveedor;
        private FontAwesome.Sharp.IconMenuItem ItemReportes;
        private FontAwesome.Sharp.IconMenuItem ItemClientes;
        private FontAwesome.Sharp.IconMenuItem itemProductos;
        private Panel mainMenuPanel;
        //private Label labelRol;
        private Label labelUser;
    }
}