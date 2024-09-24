namespace Front
{
    partial class InicioForm
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menu = new System.Windows.Forms.MenuStrip();
            this.iconUsuario = new FontAwesome.Sharp.IconMenuItem();
            this.iconMantenedor = new FontAwesome.Sharp.IconMenuItem();
            this.subMenuCategoria = new FontAwesome.Sharp.IconMenuItem();
            this.subMenuProducto = new FontAwesome.Sharp.IconMenuItem();
            this.iconCliente = new FontAwesome.Sharp.IconMenuItem();
            this.iconVenta = new FontAwesome.Sharp.IconMenuItem();
            this.iconCompras = new FontAwesome.Sharp.IconMenuItem();
            this.iconProveedores = new FontAwesome.Sharp.IconMenuItem();
            this.iconReportes = new FontAwesome.Sharp.IconMenuItem();
            this.menuTitulo = new System.Windows.Forms.MenuStrip();
            this.label1 = new System.Windows.Forms.Label();
            this.contenedor = new System.Windows.Forms.Panel();
            this.subMenuRegistrarVenta = new FontAwesome.Sharp.IconMenuItem();
            this.subMenuBuscarVenta = new FontAwesome.Sharp.IconMenuItem();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.Color.White;
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iconUsuario,
            this.iconMantenedor,
            this.iconCliente,
            this.iconVenta,
            this.iconCompras,
            this.iconProveedores,
            this.iconReportes});
            this.menu.Location = new System.Drawing.Point(0, 48);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(1251, 71);
            this.menu.TabIndex = 0;
            this.menu.Text = "menu";
            this.menu.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menu_ItemClicked);
            // 
            // iconUsuario
            // 
            this.iconUsuario.IconChar = FontAwesome.Sharp.IconChar.UserGear;
            this.iconUsuario.IconColor = System.Drawing.Color.Black;
            this.iconUsuario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconUsuario.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.iconUsuario.Name = "iconUsuario";
            this.iconUsuario.Size = new System.Drawing.Size(60, 67);
            this.iconUsuario.Text = "Usuario";
            this.iconUsuario.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.iconUsuario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.iconUsuario.Click += new System.EventHandler(this.iconMenuUsuario_Click);
            // 
            // iconMantenedor
            // 
            this.iconMantenedor.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.subMenuCategoria,
            this.subMenuProducto});
            this.iconMantenedor.IconChar = FontAwesome.Sharp.IconChar.ScrewdriverWrench;
            this.iconMantenedor.IconColor = System.Drawing.Color.Black;
            this.iconMantenedor.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconMantenedor.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.iconMantenedor.Name = "iconMantenedor";
            this.iconMantenedor.Size = new System.Drawing.Size(84, 67);
            this.iconMantenedor.Text = "Mantenedor";
            this.iconMantenedor.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.iconMantenedor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // subMenuCategoria
            // 
            this.subMenuCategoria.IconChar = FontAwesome.Sharp.IconChar.None;
            this.subMenuCategoria.IconColor = System.Drawing.Color.Black;
            this.subMenuCategoria.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.subMenuCategoria.Name = "subMenuCategoria";
            this.subMenuCategoria.Size = new System.Drawing.Size(125, 22);
            this.subMenuCategoria.Text = "Categoria";
            this.subMenuCategoria.Click += new System.EventHandler(this.subMenuCategoria_Click);
            // 
            // subMenuProducto
            // 
            this.subMenuProducto.IconChar = FontAwesome.Sharp.IconChar.None;
            this.subMenuProducto.IconColor = System.Drawing.Color.Black;
            this.subMenuProducto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.subMenuProducto.Name = "subMenuProducto";
            this.subMenuProducto.Size = new System.Drawing.Size(125, 22);
            this.subMenuProducto.Text = "Producto";
            this.subMenuProducto.Click += new System.EventHandler(this.subMenuProducto_Click);
            // 
            // iconCliente
            // 
            this.iconCliente.IconChar = FontAwesome.Sharp.IconChar.UserGroup;
            this.iconCliente.IconColor = System.Drawing.Color.Black;
            this.iconCliente.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconCliente.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.iconCliente.Name = "iconCliente";
            this.iconCliente.Size = new System.Drawing.Size(60, 67);
            this.iconCliente.Text = "Cliente";
            this.iconCliente.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.iconCliente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // iconVenta
            // 
            this.iconVenta.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.subMenuRegistrarVenta,
            this.subMenuBuscarVenta});
            this.iconVenta.IconChar = FontAwesome.Sharp.IconChar.Tags;
            this.iconVenta.IconColor = System.Drawing.Color.Black;
            this.iconVenta.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconVenta.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.iconVenta.Name = "iconVenta";
            this.iconVenta.Size = new System.Drawing.Size(60, 67);
            this.iconVenta.Text = "Venta";
            this.iconVenta.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.iconVenta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // iconCompras
            // 
            this.iconCompras.IconChar = FontAwesome.Sharp.IconChar.DollyFlatbed;
            this.iconCompras.IconColor = System.Drawing.Color.Black;
            this.iconCompras.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconCompras.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.iconCompras.Name = "iconCompras";
            this.iconCompras.Size = new System.Drawing.Size(67, 67);
            this.iconCompras.Text = "Compras";
            this.iconCompras.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.iconCompras.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // iconProveedores
            // 
            this.iconProveedores.IconChar = FontAwesome.Sharp.IconChar.AddressCard;
            this.iconProveedores.IconColor = System.Drawing.Color.Black;
            this.iconProveedores.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconProveedores.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.iconProveedores.Name = "iconProveedores";
            this.iconProveedores.Size = new System.Drawing.Size(84, 67);
            this.iconProveedores.Text = "Proveedores";
            this.iconProveedores.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.iconProveedores.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // iconReportes
            // 
            this.iconReportes.IconChar = FontAwesome.Sharp.IconChar.ChartBar;
            this.iconReportes.IconColor = System.Drawing.Color.Black;
            this.iconReportes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconReportes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.iconReportes.Name = "iconReportes";
            this.iconReportes.Size = new System.Drawing.Size(65, 67);
            this.iconReportes.Text = "Reportes";
            this.iconReportes.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.iconReportes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // menuTitulo
            // 
            this.menuTitulo.AutoSize = false;
            this.menuTitulo.BackColor = System.Drawing.Color.Black;
            this.menuTitulo.Location = new System.Drawing.Point(0, 0);
            this.menuTitulo.Name = "menuTitulo";
            this.menuTitulo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuTitulo.Size = new System.Drawing.Size(1251, 48);
            this.menuTitulo.TabIndex = 1;
            this.menuTitulo.Text = "menuTitulo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "El Toque De Midas";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // contenedor
            // 
            this.contenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contenedor.Location = new System.Drawing.Point(0, 119);
            this.contenedor.Name = "contenedor";
            this.contenedor.Size = new System.Drawing.Size(1251, 326);
            this.contenedor.TabIndex = 3;
            this.contenedor.Paint += new System.Windows.Forms.PaintEventHandler(this.contenedor_Paint);
            // 
            // subMenuRegistrarVenta
            // 
            this.subMenuRegistrarVenta.IconChar = FontAwesome.Sharp.IconChar.None;
            this.subMenuRegistrarVenta.IconColor = System.Drawing.Color.Black;
            this.subMenuRegistrarVenta.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.subMenuRegistrarVenta.Name = "subMenuRegistrarVenta";
            this.subMenuRegistrarVenta.Size = new System.Drawing.Size(180, 22);
            this.subMenuRegistrarVenta.Text = "Registrar";
            // 
            // subMenuBuscarVenta
            // 
            this.subMenuBuscarVenta.IconChar = FontAwesome.Sharp.IconChar.None;
            this.subMenuBuscarVenta.IconColor = System.Drawing.Color.Black;
            this.subMenuBuscarVenta.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.subMenuBuscarVenta.Name = "subMenuBuscarVenta";
            this.subMenuBuscarVenta.Size = new System.Drawing.Size(180, 22);
            this.subMenuBuscarVenta.Text = "Buscar";
            // 
            // InicioForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1251, 445);
            this.Controls.Add(this.contenedor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.menuTitulo);
            this.MainMenuStrip = this.menuTitulo;
            this.Name = "InicioForm";
            this.Text = "Inicio";
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.MenuStrip menuTitulo;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconMenuItem iconUsuario;
        private FontAwesome.Sharp.IconMenuItem iconMantenedor;
        private FontAwesome.Sharp.IconMenuItem iconCliente;
        private FontAwesome.Sharp.IconMenuItem iconVenta;
        private FontAwesome.Sharp.IconMenuItem iconProveedores;
        private FontAwesome.Sharp.IconMenuItem iconCompras;
        private FontAwesome.Sharp.IconMenuItem iconReportes;
        private System.Windows.Forms.Panel contenedor;
        private FontAwesome.Sharp.IconMenuItem subMenuCategoria;
        private FontAwesome.Sharp.IconMenuItem subMenuProducto;
        private FontAwesome.Sharp.IconMenuItem subMenuRegistrarVenta;
        private FontAwesome.Sharp.IconMenuItem subMenuBuscarVenta;
    }
}

