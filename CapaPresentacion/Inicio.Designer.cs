namespace CapaPresentacion
{
    partial class Inicio
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
            this.menuInferior = new System.Windows.Forms.MenuStrip();
            this.menu_usuario = new FontAwesome.Sharp.IconMenuItem();
            this.menu_mantenedor = new FontAwesome.Sharp.IconMenuItem();
            this.menu_ventas = new FontAwesome.Sharp.IconMenuItem();
            this.menu_compras = new FontAwesome.Sharp.IconMenuItem();
            this.menu_clientes = new FontAwesome.Sharp.IconMenuItem();
            this.menu_proveedor = new FontAwesome.Sharp.IconMenuItem();
            this.menu_reporte = new FontAwesome.Sharp.IconMenuItem();
            this.menu_acercade = new FontAwesome.Sharp.IconMenuItem();
            this.menuSuperior = new System.Windows.Forms.MenuStrip();
            this.label1 = new System.Windows.Forms.Label();
            this.contenedor_principal = new System.Windows.Forms.Panel();
            this.menuInferior.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuInferior
            // 
            this.menuInferior.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_usuario,
            this.menu_mantenedor,
            this.menu_ventas,
            this.menu_compras,
            this.menu_clientes,
            this.menu_proveedor,
            this.menu_reporte,
            this.menu_acercade});
            this.menuInferior.Location = new System.Drawing.Point(0, 58);
            this.menuInferior.Name = "menuInferior";
            this.menuInferior.Size = new System.Drawing.Size(770, 73);
            this.menuInferior.TabIndex = 0;
            this.menuInferior.Text = "menuStrip1";
            // 
            // menu_usuario
            // 
            this.menu_usuario.AutoSize = false;
            this.menu_usuario.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu_usuario.IconChar = FontAwesome.Sharp.IconChar.UsersCog;
            this.menu_usuario.IconColor = System.Drawing.Color.Black;
            this.menu_usuario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menu_usuario.IconSize = 50;
            this.menu_usuario.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menu_usuario.Name = "menu_usuario";
            this.menu_usuario.Size = new System.Drawing.Size(80, 69);
            this.menu_usuario.Text = "USUARIO";
            this.menu_usuario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // menu_mantenedor
            // 
            this.menu_mantenedor.AutoSize = false;
            this.menu_mantenedor.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu_mantenedor.IconChar = FontAwesome.Sharp.IconChar.Tools;
            this.menu_mantenedor.IconColor = System.Drawing.Color.Black;
            this.menu_mantenedor.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menu_mantenedor.IconSize = 50;
            this.menu_mantenedor.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menu_mantenedor.Name = "menu_mantenedor";
            this.menu_mantenedor.Size = new System.Drawing.Size(102, 69);
            this.menu_mantenedor.Text = "MANTENEDOR";
            this.menu_mantenedor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // menu_ventas
            // 
            this.menu_ventas.AutoSize = false;
            this.menu_ventas.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu_ventas.IconChar = FontAwesome.Sharp.IconChar.Tags;
            this.menu_ventas.IconColor = System.Drawing.Color.Black;
            this.menu_ventas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menu_ventas.IconSize = 50;
            this.menu_ventas.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menu_ventas.Name = "menu_ventas";
            this.menu_ventas.Size = new System.Drawing.Size(80, 69);
            this.menu_ventas.Text = "VENTAS";
            this.menu_ventas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // menu_compras
            // 
            this.menu_compras.AutoSize = false;
            this.menu_compras.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu_compras.IconChar = FontAwesome.Sharp.IconChar.CartFlatbed;
            this.menu_compras.IconColor = System.Drawing.Color.Black;
            this.menu_compras.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menu_compras.IconSize = 50;
            this.menu_compras.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menu_compras.Name = "menu_compras";
            this.menu_compras.Size = new System.Drawing.Size(80, 69);
            this.menu_compras.Text = "COMPRAS";
            this.menu_compras.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // menu_clientes
            // 
            this.menu_clientes.AutoSize = false;
            this.menu_clientes.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu_clientes.IconChar = FontAwesome.Sharp.IconChar.UserGroup;
            this.menu_clientes.IconColor = System.Drawing.Color.Black;
            this.menu_clientes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menu_clientes.IconSize = 50;
            this.menu_clientes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menu_clientes.Name = "menu_clientes";
            this.menu_clientes.Size = new System.Drawing.Size(80, 69);
            this.menu_clientes.Text = "CLIENTES";
            this.menu_clientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // menu_proveedor
            // 
            this.menu_proveedor.AutoSize = false;
            this.menu_proveedor.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu_proveedor.IconChar = FontAwesome.Sharp.IconChar.AddressCard;
            this.menu_proveedor.IconColor = System.Drawing.Color.Black;
            this.menu_proveedor.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menu_proveedor.IconSize = 50;
            this.menu_proveedor.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menu_proveedor.Name = "menu_proveedor";
            this.menu_proveedor.Size = new System.Drawing.Size(102, 69);
            this.menu_proveedor.Text = "PROVEEDORES";
            this.menu_proveedor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.menu_proveedor.Click += new System.EventHandler(this.iconMenuItem4_Click);
            // 
            // menu_reporte
            // 
            this.menu_reporte.AutoSize = false;
            this.menu_reporte.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu_reporte.IconChar = FontAwesome.Sharp.IconChar.BarChart;
            this.menu_reporte.IconColor = System.Drawing.Color.Black;
            this.menu_reporte.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menu_reporte.IconSize = 50;
            this.menu_reporte.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menu_reporte.Name = "menu_reporte";
            this.menu_reporte.Size = new System.Drawing.Size(122, 69);
            this.menu_reporte.Text = "REPORTES";
            this.menu_reporte.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // menu_acercade
            // 
            this.menu_acercade.AutoSize = false;
            this.menu_acercade.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu_acercade.IconChar = FontAwesome.Sharp.IconChar.CircleInfo;
            this.menu_acercade.IconColor = System.Drawing.Color.Black;
            this.menu_acercade.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menu_acercade.IconSize = 50;
            this.menu_acercade.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menu_acercade.Name = "menu_acercade";
            this.menu_acercade.Size = new System.Drawing.Size(80, 69);
            this.menu_acercade.Text = "ACERCA DE";
            this.menu_acercade.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // menuSuperior
            // 
            this.menuSuperior.AutoSize = false;
            this.menuSuperior.BackColor = System.Drawing.Color.SteelBlue;
            this.menuSuperior.Location = new System.Drawing.Point(0, 0);
            this.menuSuperior.Name = "menuSuperior";
            this.menuSuperior.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuSuperior.Size = new System.Drawing.Size(770, 58);
            this.menuSuperior.TabIndex = 1;
            this.menuSuperior.Text = "menuStrip2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.SteelBlue;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 33);
            this.label1.TabIndex = 2;
            this.label1.Text = "Sistema de Ventas";
            // 
            // contenedor_principal
            // 
            this.contenedor_principal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contenedor_principal.Location = new System.Drawing.Point(0, 131);
            this.contenedor_principal.Name = "contenedor_principal";
            this.contenedor_principal.Size = new System.Drawing.Size(770, 272);
            this.contenedor_principal.TabIndex = 3;
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 403);
            this.Controls.Add(this.contenedor_principal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuInferior);
            this.Controls.Add(this.menuSuperior);
            this.MainMenuStrip = this.menuInferior;
            this.Name = "Inicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.menuInferior.ResumeLayout(false);
            this.menuInferior.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuInferior;
        private System.Windows.Forms.MenuStrip menuSuperior;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconMenuItem menu_acercade;
        private FontAwesome.Sharp.IconMenuItem menu_usuario;
        private FontAwesome.Sharp.IconMenuItem menu_mantenedor;
        private FontAwesome.Sharp.IconMenuItem menu_ventas;
        private FontAwesome.Sharp.IconMenuItem menu_compras;
        private FontAwesome.Sharp.IconMenuItem menu_clientes;
        private FontAwesome.Sharp.IconMenuItem menu_proveedor;
        private FontAwesome.Sharp.IconMenuItem menu_reporte;
        private System.Windows.Forms.Panel contenedor_principal;
    }
}

