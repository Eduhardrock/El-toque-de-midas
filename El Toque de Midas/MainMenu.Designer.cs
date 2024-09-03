namespace El_Toque_de_Midas
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
            menuInicio = new MenuStrip();
            itemUsuarios = new FontAwesome.Sharp.IconMenuItem();
            IcomVentas = new FontAwesome.Sharp.IconMenuItem();
            ItemCompras = new FontAwesome.Sharp.IconMenuItem();
            ItemProveedor = new FontAwesome.Sharp.IconMenuItem();
            ItemReportes = new FontAwesome.Sharp.IconMenuItem();
            ItemClientes = new FontAwesome.Sharp.IconMenuItem();
            ItemAcercaDe = new FontAwesome.Sharp.IconMenuItem();
            mainMenuPanel = new Panel();
            menuInicio.SuspendLayout();
            SuspendLayout();
            // 
            // menuInicio
            // 
            menuInicio.Items.AddRange(new ToolStripItem[] { itemUsuarios, IcomVentas, ItemCompras, ItemProveedor, ItemReportes, ItemClientes, ItemAcercaDe });
            menuInicio.Location = new Point(0, 0);
            menuInicio.Name = "menuInicio";
            menuInicio.Size = new Size(1307, 71);
            menuInicio.TabIndex = 0;
            menuInicio.Text = "menuInicio";
            // 
            // itemUsuarios
            // 
            itemUsuarios.IconChar = FontAwesome.Sharp.IconChar.UsersCog;
            itemUsuarios.IconColor = Color.Black;
            itemUsuarios.IconFont = FontAwesome.Sharp.IconFont.Auto;
            itemUsuarios.ImageScaling = ToolStripItemImageScaling.None;
            itemUsuarios.Name = "itemUsuarios";
            itemUsuarios.Size = new Size(64, 67);
            itemUsuarios.Text = "Usuarios";
            itemUsuarios.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // IcomVentas
            // 
            IcomVentas.IconChar = FontAwesome.Sharp.IconChar.Tags;
            IcomVentas.IconColor = Color.Black;
            IcomVentas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            IcomVentas.ImageScaling = ToolStripItemImageScaling.None;
            IcomVentas.Name = "IcomVentas";
            IcomVentas.Size = new Size(60, 67);
            IcomVentas.Text = "Ventas";
            IcomVentas.TextImageRelation = TextImageRelation.ImageAboveText;
            IcomVentas.Click += IcomVentas_Click;
            // 
            // ItemCompras
            // 
            ItemCompras.IconChar = FontAwesome.Sharp.IconChar.CartFlatbed;
            ItemCompras.IconColor = Color.Black;
            ItemCompras.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ItemCompras.ImageScaling = ToolStripItemImageScaling.None;
            ItemCompras.Name = "ItemCompras";
            ItemCompras.Size = new Size(67, 67);
            ItemCompras.Text = "Compras";
            ItemCompras.TextImageRelation = TextImageRelation.ImageAboveText;
            //ItemCompras.Click += ItemCompras_Click;
            // 
            // ItemProveedor
            // 
            ItemProveedor.IconChar = FontAwesome.Sharp.IconChar.Truck;
            ItemProveedor.IconColor = Color.Black;
            ItemProveedor.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ItemProveedor.ImageScaling = ToolStripItemImageScaling.None;
            ItemProveedor.Name = "ItemProveedor";
            ItemProveedor.Size = new Size(84, 67);
            ItemProveedor.Text = "Proveedores";
            ItemProveedor.TextImageRelation = TextImageRelation.ImageAboveText;
            ItemProveedor.Click += ItemProveedor_Click;
            // 
            // ItemReportes
            // 
            ItemReportes.IconChar = FontAwesome.Sharp.IconChar.ChartColumn;
            ItemReportes.IconColor = Color.Black;
            ItemReportes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ItemReportes.ImageScaling = ToolStripItemImageScaling.None;
            ItemReportes.Name = "ItemReportes";
            ItemReportes.Size = new Size(65, 67);
            ItemReportes.Text = "Reportes";
            ItemReportes.TextImageRelation = TextImageRelation.ImageAboveText;
            ItemReportes.Click += ItemReportes_Click;
            // 
            // ItemClientes
            // 
            ItemClientes.IconChar = FontAwesome.Sharp.IconChar.UsersCog;
            ItemClientes.IconColor = Color.Black;
            ItemClientes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ItemClientes.ImageScaling = ToolStripItemImageScaling.None;
            ItemClientes.Name = "ItemClientes";
            ItemClientes.Size = new Size(61, 67);
            ItemClientes.Text = "Clientes";
            ItemClientes.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // ItemAcercaDe
            // 
            ItemAcercaDe.IconChar = FontAwesome.Sharp.IconChar.CircleInfo;
            ItemAcercaDe.IconColor = Color.Black;
            ItemAcercaDe.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ItemAcercaDe.ImageScaling = ToolStripItemImageScaling.None;
            ItemAcercaDe.Name = "ItemAcercaDe";
            ItemAcercaDe.Size = new Size(72, 67);
            ItemAcercaDe.Text = "Acerca De";
            ItemAcercaDe.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // mainMenuPanel
            // 
            mainMenuPanel.Dock = DockStyle.Fill;
            mainMenuPanel.Location = new Point(0, 71);
            mainMenuPanel.Name = "mainMenuPanel";
            mainMenuPanel.Size = new Size(1307, 522);
            mainMenuPanel.TabIndex = 1;
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1307, 593);
            Controls.Add(mainMenuPanel);
            Controls.Add(menuInicio);
            MainMenuStrip = menuInicio;
            Name = "MainMenu";
            Text = "Toque de Midas - Menú Principal";
            Load += Inicio_Load;
            menuInicio.ResumeLayout(false);
            menuInicio.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
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
        private Panel mainMenuPanel;
    }
}