namespace WindFormProductos1
{
    partial class FormProductos
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
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblStock = new System.Windows.Forms.Label();
            this.btCargar = new System.Windows.Forms.Button();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.dgv_Producto = new System.Windows.Forms.DataGridView();
            this.tabC_Producto = new System.Windows.Forms.TabControl();
            this.tabC_Control = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lbl_StockMov = new System.Windows.Forms.Label();
            this.btAceptar = new System.Windows.Forms.Button();
            this.rbEgreso = new System.Windows.Forms.RadioButton();
            this.rbIngreso = new System.Windows.Forms.RadioButton();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblDescripMov = new System.Windows.Forms.Label();
            this.lblCodigoMov = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Producto)).BeginInit();
            this.tabC_Producto.SuspendLayout();
            this.tabC_Control.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(36, 42);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(40, 13);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Código";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(36, 80);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(63, 13);
            this.lblDescripcion.TabIndex = 1;
            this.lblDescripcion.Text = "Descripción";
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Location = new System.Drawing.Point(41, 124);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(35, 13);
            this.lblStock.TabIndex = 2;
            this.lblStock.Text = "Stock";
            // 
            // btCargar
            // 
            this.btCargar.Location = new System.Drawing.Point(224, 119);
            this.btCargar.Name = "btCargar";
            this.btCargar.Size = new System.Drawing.Size(75, 23);
            this.btCargar.TabIndex = 3;
            this.btCargar.Text = "Cargar";
            this.btCargar.UseVisualStyleBackColor = true;
            this.btCargar.Click += new System.EventHandler(this.btCargar_Click);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(82, 42);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(144, 20);
            this.txtCodigo.TabIndex = 4;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(105, 80);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(194, 20);
            this.txtDescripcion.TabIndex = 5;
            // 
            // txtStock
            // 
            this.txtStock.Location = new System.Drawing.Point(82, 117);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(100, 20);
            this.txtStock.TabIndex = 6;
            // 
            // dgv_Producto
            // 
            this.dgv_Producto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Producto.Location = new System.Drawing.Point(157, 273);
            this.dgv_Producto.Name = "dgv_Producto";
            this.dgv_Producto.Size = new System.Drawing.Size(438, 150);
            this.dgv_Producto.TabIndex = 7;
            this.dgv_Producto.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Producto_CellClick);
            // 
            // tabC_Producto
            // 
            this.tabC_Producto.Controls.Add(this.tabC_Control);
            this.tabC_Producto.Controls.Add(this.tabPage2);
            this.tabC_Producto.Location = new System.Drawing.Point(157, 54);
            this.tabC_Producto.Name = "tabC_Producto";
            this.tabC_Producto.SelectedIndex = 0;
            this.tabC_Producto.Size = new System.Drawing.Size(442, 213);
            this.tabC_Producto.TabIndex = 8;
            // 
            // tabC_Control
            // 
            this.tabC_Control.Controls.Add(this.lblCodigo);
            this.tabC_Control.Controls.Add(this.lblDescripcion);
            this.tabC_Control.Controls.Add(this.btCargar);
            this.tabC_Control.Controls.Add(this.txtStock);
            this.tabC_Control.Controls.Add(this.lblStock);
            this.tabC_Control.Controls.Add(this.txtDescripcion);
            this.tabC_Control.Controls.Add(this.txtCodigo);
            this.tabC_Control.Location = new System.Drawing.Point(4, 22);
            this.tabC_Control.Name = "tabC_Control";
            this.tabC_Control.Padding = new System.Windows.Forms.Padding(3);
            this.tabC_Control.Size = new System.Drawing.Size(434, 187);
            this.tabC_Control.TabIndex = 0;
            this.tabC_Control.Text = "Carga de Productos";
            this.tabC_Control.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lbl_StockMov);
            this.tabPage2.Controls.Add(this.btAceptar);
            this.tabPage2.Controls.Add(this.rbEgreso);
            this.tabPage2.Controls.Add(this.rbIngreso);
            this.tabPage2.Controls.Add(this.txtCantidad);
            this.tabPage2.Controls.Add(this.lblCantidad);
            this.tabPage2.Controls.Add(this.lblDescripMov);
            this.tabPage2.Controls.Add(this.lblCodigoMov);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(434, 187);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Movimiento de productos";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lbl_StockMov
            // 
            this.lbl_StockMov.AutoSize = true;
            this.lbl_StockMov.Location = new System.Drawing.Point(56, 84);
            this.lbl_StockMov.Name = "lbl_StockMov";
            this.lbl_StockMov.Size = new System.Drawing.Size(35, 13);
            this.lbl_StockMov.TabIndex = 7;
            this.lbl_StockMov.Text = "label2";
            // 
            // btAceptar
            // 
            this.btAceptar.Location = new System.Drawing.Point(349, 79);
            this.btAceptar.Name = "btAceptar";
            this.btAceptar.Size = new System.Drawing.Size(75, 23);
            this.btAceptar.TabIndex = 6;
            this.btAceptar.Text = "Aceptar";
            this.btAceptar.UseVisualStyleBackColor = true;
            this.btAceptar.Click += new System.EventHandler(this.btAceptar_Click);
            // 
            // rbEgreso
            // 
            this.rbEgreso.AutoSize = true;
            this.rbEgreso.Location = new System.Drawing.Point(258, 84);
            this.rbEgreso.Name = "rbEgreso";
            this.rbEgreso.Size = new System.Drawing.Size(58, 17);
            this.rbEgreso.TabIndex = 5;
            this.rbEgreso.TabStop = true;
            this.rbEgreso.Text = "Egreso";
            this.rbEgreso.UseVisualStyleBackColor = true;
            // 
            // rbIngreso
            // 
            this.rbIngreso.AutoSize = true;
            this.rbIngreso.Location = new System.Drawing.Point(258, 52);
            this.rbIngreso.Name = "rbIngreso";
            this.rbIngreso.Size = new System.Drawing.Size(60, 17);
            this.rbIngreso.TabIndex = 4;
            this.rbIngreso.TabStop = true;
            this.rbIngreso.Text = "Ingreso";
            this.rbIngreso.UseVisualStyleBackColor = true;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(128, 109);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(100, 20);
            this.txtCantidad.TabIndex = 3;
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(56, 116);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(49, 13);
            this.lblCantidad.TabIndex = 2;
            this.lblCantidad.Text = "Cantidad";
            // 
            // lblDescripMov
            // 
            this.lblDescripMov.AutoSize = true;
            this.lblDescripMov.Location = new System.Drawing.Point(56, 52);
            this.lblDescripMov.Name = "lblDescripMov";
            this.lblDescripMov.Size = new System.Drawing.Size(35, 13);
            this.lblDescripMov.TabIndex = 1;
            this.lblDescripMov.Text = "label2";
            // 
            // lblCodigoMov
            // 
            this.lblCodigoMov.AutoSize = true;
            this.lblCodigoMov.Location = new System.Drawing.Point(56, 22);
            this.lblCodigoMov.Name = "lblCodigoMov";
            this.lblCodigoMov.Size = new System.Drawing.Size(35, 13);
            this.lblCodigoMov.TabIndex = 0;
            this.lblCodigoMov.Text = "label1";
            // 
            // FormProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabC_Producto);
            this.Controls.Add(this.dgv_Producto);
            this.Name = "FormProductos";
            this.Text = "FormProductos";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Producto)).EndInit();
            this.tabC_Producto.ResumeLayout(false);
            this.tabC_Control.ResumeLayout(false);
            this.tabC_Control.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.Button btCargar;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.DataGridView dgv_Producto;
        private System.Windows.Forms.TabControl tabC_Producto;
        private System.Windows.Forms.TabPage tabC_Control;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.RadioButton rbEgreso;
        private System.Windows.Forms.RadioButton rbIngreso;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label lblDescripMov;
        private System.Windows.Forms.Label lblCodigoMov;
        private System.Windows.Forms.Button btAceptar;
        private System.Windows.Forms.Label lbl_StockMov;
    }
}