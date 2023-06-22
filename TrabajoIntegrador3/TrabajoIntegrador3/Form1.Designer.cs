
namespace TrabajoIntegrador3
{
    partial class Form1
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
            this.txtCode1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCode2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCode3 = new System.Windows.Forms.TextBox();
            this.dtpFechaFabricacion = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.btnAgregarProduct = new System.Windows.Forms.Button();
            this.btnModificarProducto = new System.Windows.Forms.Button();
            this.btnBorrarProducto = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.btnIDAscendente = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.btnIDDescendente = new System.Windows.Forms.Button();
            this.btnPrecioAscendente = new System.Windows.Forms.Button();
            this.btnPrecioDescendente = new System.Windows.Forms.Button();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.btnVaciarCampos = new System.Windows.Forms.Button();
            this.btnClonarProducto = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblIEnumerator = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCode1
            // 
            this.txtCode1.Location = new System.Drawing.Point(449, 51);
            this.txtCode1.Name = "txtCode1";
            this.txtCode1.Size = new System.Drawing.Size(59, 20);
            this.txtCode1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(400, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Codigo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(514, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(10, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "-";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(595, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(10, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "-";
            // 
            // txtCode2
            // 
            this.txtCode2.Location = new System.Drawing.Point(530, 51);
            this.txtCode2.Name = "txtCode2";
            this.txtCode2.Size = new System.Drawing.Size(59, 20);
            this.txtCode2.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(676, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(10, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "-";
            // 
            // txtCode3
            // 
            this.txtCode3.Location = new System.Drawing.Point(611, 51);
            this.txtCode3.Name = "txtCode3";
            this.txtCode3.Size = new System.Drawing.Size(59, 20);
            this.txtCode3.TabIndex = 6;
            // 
            // dtpFechaFabricacion
            // 
            this.dtpFechaFabricacion.Location = new System.Drawing.Point(692, 51);
            this.dtpFechaFabricacion.Name = "dtpFechaFabricacion";
            this.dtpFechaFabricacion.Size = new System.Drawing.Size(205, 20);
            this.dtpFechaFabricacion.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(377, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Descripcion:";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(449, 77);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(221, 20);
            this.txtDescripcion.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(400, 106);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Precio:";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(449, 103);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(140, 20);
            this.txtPrecio.TabIndex = 11;
            this.txtPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecio_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(400, 132);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Stock:";
            // 
            // txtStock
            // 
            this.txtStock.Location = new System.Drawing.Point(449, 129);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(140, 20);
            this.txtStock.TabIndex = 13;
            // 
            // btnAgregarProduct
            // 
            this.btnAgregarProduct.Location = new System.Drawing.Point(449, 156);
            this.btnAgregarProduct.Name = "btnAgregarProduct";
            this.btnAgregarProduct.Size = new System.Drawing.Size(140, 23);
            this.btnAgregarProduct.TabIndex = 15;
            this.btnAgregarProduct.Text = "Agregar Producto";
            this.btnAgregarProduct.UseVisualStyleBackColor = true;
            this.btnAgregarProduct.Click += new System.EventHandler(this.btnAgregarProduct_Click);
            // 
            // btnModificarProducto
            // 
            this.btnModificarProducto.Location = new System.Drawing.Point(595, 156);
            this.btnModificarProducto.Name = "btnModificarProducto";
            this.btnModificarProducto.Size = new System.Drawing.Size(140, 23);
            this.btnModificarProducto.TabIndex = 16;
            this.btnModificarProducto.Text = "Modificar Producto";
            this.btnModificarProducto.UseVisualStyleBackColor = true;
            this.btnModificarProducto.Click += new System.EventHandler(this.btnModificarProducto_Click);
            // 
            // btnBorrarProducto
            // 
            this.btnBorrarProducto.Location = new System.Drawing.Point(741, 156);
            this.btnBorrarProducto.Name = "btnBorrarProducto";
            this.btnBorrarProducto.Size = new System.Drawing.Size(140, 23);
            this.btnBorrarProducto.TabIndex = 17;
            this.btnBorrarProducto.Text = "Borrar Producto";
            this.btnBorrarProducto.UseVisualStyleBackColor = true;
            this.btnBorrarProducto.Click += new System.EventHandler(this.btnBorrarProducto_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(156, 36);
            this.label8.TabIndex = 18;
            this.label8.Text = "Inventario";
            // 
            // btnIDAscendente
            // 
            this.btnIDAscendente.Location = new System.Drawing.Point(90, 116);
            this.btnIDAscendente.Name = "btnIDAscendente";
            this.btnIDAscendente.Size = new System.Drawing.Size(140, 23);
            this.btnIDAscendente.TabIndex = 19;
            this.btnIDAscendente.Text = "ID Ascendente";
            this.btnIDAscendente.UseVisualStyleBackColor = true;
            this.btnIDAscendente.Click += new System.EventHandler(this.btnIDAscendente_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 121);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Ordernar por:";
            // 
            // btnIDDescendente
            // 
            this.btnIDDescendente.Location = new System.Drawing.Point(236, 116);
            this.btnIDDescendente.Name = "btnIDDescendente";
            this.btnIDDescendente.Size = new System.Drawing.Size(140, 23);
            this.btnIDDescendente.TabIndex = 21;
            this.btnIDDescendente.Text = "ID Descendente";
            this.btnIDDescendente.UseVisualStyleBackColor = true;
            this.btnIDDescendente.Click += new System.EventHandler(this.btnIDDescendente_Click);
            // 
            // btnPrecioAscendente
            // 
            this.btnPrecioAscendente.Location = new System.Drawing.Point(90, 145);
            this.btnPrecioAscendente.Name = "btnPrecioAscendente";
            this.btnPrecioAscendente.Size = new System.Drawing.Size(140, 23);
            this.btnPrecioAscendente.TabIndex = 22;
            this.btnPrecioAscendente.Text = "Precio Ascendente";
            this.btnPrecioAscendente.UseVisualStyleBackColor = true;
            this.btnPrecioAscendente.Click += new System.EventHandler(this.btnPrecioAscendente_Click);
            // 
            // btnPrecioDescendente
            // 
            this.btnPrecioDescendente.Location = new System.Drawing.Point(236, 145);
            this.btnPrecioDescendente.Name = "btnPrecioDescendente";
            this.btnPrecioDescendente.Size = new System.Drawing.Size(140, 23);
            this.btnPrecioDescendente.TabIndex = 23;
            this.btnPrecioDescendente.Text = "Precio Descendente";
            this.btnPrecioDescendente.UseVisualStyleBackColor = true;
            this.btnPrecioDescendente.Click += new System.EventHandler(this.btnPrecioDescendente_Click);
            // 
            // dgvProductos
            // 
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvProductos.Location = new System.Drawing.Point(19, 201);
            this.dgvProductos.MultiSelect = false;
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.ReadOnly = true;
            this.dgvProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProductos.Size = new System.Drawing.Size(424, 237);
            this.dgvProductos.TabIndex = 24;
            this.dgvProductos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductos_CellClick);
            // 
            // btnVaciarCampos
            // 
            this.btnVaciarCampos.Location = new System.Drawing.Point(595, 127);
            this.btnVaciarCampos.Name = "btnVaciarCampos";
            this.btnVaciarCampos.Size = new System.Drawing.Size(140, 23);
            this.btnVaciarCampos.TabIndex = 25;
            this.btnVaciarCampos.Text = "Vaciar Campos";
            this.btnVaciarCampos.UseVisualStyleBackColor = true;
            this.btnVaciarCampos.Click += new System.EventHandler(this.btnVaciarCampos_Click);
            // 
            // btnClonarProducto
            // 
            this.btnClonarProducto.Location = new System.Drawing.Point(595, 217);
            this.btnClonarProducto.Name = "btnClonarProducto";
            this.btnClonarProducto.Size = new System.Drawing.Size(140, 23);
            this.btnClonarProducto.TabIndex = 26;
            this.btnClonarProducto.Text = "Clonar Producto";
            this.btnClonarProducto.UseVisualStyleBackColor = true;
            this.btnClonarProducto.Click += new System.EventHandler(this.btnClonarProducto_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(501, 222);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(88, 13);
            this.label10.TabIndex = 27;
            this.label10.Text = "Probar IClonable:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Location = new System.Drawing.Point(449, 201);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(456, 10);
            this.panel1.TabIndex = 28;
            // 
            // lblIEnumerator
            // 
            this.lblIEnumerator.AutoSize = true;
            this.lblIEnumerator.Location = new System.Drawing.Point(468, 271);
            this.lblIEnumerator.Name = "lblIEnumerator";
            this.lblIEnumerator.Size = new System.Drawing.Size(0, 13);
            this.lblIEnumerator.TabIndex = 29;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 450);
            this.Controls.Add(this.lblIEnumerator);
            this.Controls.Add(this.dgvProductos);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnClonarProducto);
            this.Controls.Add(this.btnVaciarCampos);
            this.Controls.Add(this.btnPrecioDescendente);
            this.Controls.Add(this.btnPrecioAscendente);
            this.Controls.Add(this.btnIDDescendente);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnIDAscendente);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnBorrarProducto);
            this.Controls.Add(this.btnModificarProducto);
            this.Controls.Add(this.btnAgregarProduct);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtStock);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.dtpFechaFabricacion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCode3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCode2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCode1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtCode1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCode2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCode3;
        private System.Windows.Forms.DateTimePicker dtpFechaFabricacion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.Button btnAgregarProduct;
        private System.Windows.Forms.Button btnModificarProducto;
        private System.Windows.Forms.Button btnBorrarProducto;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnIDAscendente;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnIDDescendente;
        private System.Windows.Forms.Button btnPrecioAscendente;
        private System.Windows.Forms.Button btnPrecioDescendente;
        public System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.Button btnVaciarCampos;
        private System.Windows.Forms.Button btnClonarProducto;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblIEnumerator;
    }
}

