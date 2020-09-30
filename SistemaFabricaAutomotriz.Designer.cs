namespace DistribuidoraCrelech
{
    partial class DistribuidoraCrelech
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
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabStock = new System.Windows.Forms.TabPage();
            this.tabProductos2 = new System.Windows.Forms.TabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabFacturas = new System.Windows.Forms.TabPage();
            this.btNuevaFact = new System.Windows.Forms.Button();
            this.tabHistorial = new System.Windows.Forms.TabPage();
            this.tabPrincipal = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnNuevoProducto = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabPage2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabProductos2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabFacturas.SuspendLayout();
            this.tabPrincipal.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.LightGray;
            this.tabPage2.Controls.Add(this.tabControl1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(788, 429);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Productos";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabStock);
            this.tabControl1.Controls.Add(this.tabProductos2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(3, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(782, 423);
            this.tabControl1.TabIndex = 0;
            // 
            // tabStock
            // 
            this.tabStock.BackColor = System.Drawing.Color.Gainsboro;
            this.tabStock.Location = new System.Drawing.Point(4, 22);
            this.tabStock.Name = "tabStock";
            this.tabStock.Padding = new System.Windows.Forms.Padding(3);
            this.tabStock.Size = new System.Drawing.Size(774, 397);
            this.tabStock.TabIndex = 0;
            this.tabStock.Text = "Stock";
            // 
            // tabProductos2
            // 
            this.tabProductos2.BackColor = System.Drawing.Color.Transparent;
            this.tabProductos2.Controls.Add(this.dataGridView1);
            this.tabProductos2.Controls.Add(this.btnNuevoProducto);
            this.tabProductos2.Controls.Add(this.groupBox1);
            this.tabProductos2.Location = new System.Drawing.Point(4, 22);
            this.tabProductos2.Name = "tabProductos2";
            this.tabProductos2.Padding = new System.Windows.Forms.Padding(3);
            this.tabProductos2.Size = new System.Drawing.Size(774, 397);
            this.tabProductos2.TabIndex = 1;
            this.tabProductos2.Text = "Productos";
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.LightGray;
            this.tabPage1.Controls.Add(this.tabControl2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(788, 429);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Ventas";
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabFacturas);
            this.tabControl2.Controls.Add(this.tabHistorial);
            this.tabControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl2.Location = new System.Drawing.Point(3, 3);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(782, 423);
            this.tabControl2.TabIndex = 0;
            // 
            // tabFacturas
            // 
            this.tabFacturas.Controls.Add(this.btNuevaFact);
            this.tabFacturas.Location = new System.Drawing.Point(4, 22);
            this.tabFacturas.Name = "tabFacturas";
            this.tabFacturas.Padding = new System.Windows.Forms.Padding(3);
            this.tabFacturas.Size = new System.Drawing.Size(774, 397);
            this.tabFacturas.TabIndex = 0;
            this.tabFacturas.Text = "Facturas";
            this.tabFacturas.UseVisualStyleBackColor = true;
            // 
            // btNuevaFact
            // 
            this.btNuevaFact.Location = new System.Drawing.Point(23, 354);
            this.btNuevaFact.Name = "btNuevaFact";
            this.btNuevaFact.Size = new System.Drawing.Size(126, 23);
            this.btNuevaFact.TabIndex = 0;
            this.btNuevaFact.Text = "Nueva Factura";
            this.btNuevaFact.UseVisualStyleBackColor = true;
            this.btNuevaFact.Click += new System.EventHandler(this.btNuevaFact_Click);
            // 
            // tabHistorial
            // 
            this.tabHistorial.Location = new System.Drawing.Point(4, 22);
            this.tabHistorial.Name = "tabHistorial";
            this.tabHistorial.Padding = new System.Windows.Forms.Padding(3);
            this.tabHistorial.Size = new System.Drawing.Size(774, 397);
            this.tabHistorial.TabIndex = 1;
            this.tabHistorial.Text = "Historial de ventas";
            this.tabHistorial.UseVisualStyleBackColor = true;
            // 
            // tabPrincipal
            // 
            this.tabPrincipal.Controls.Add(this.tabPage1);
            this.tabPrincipal.Controls.Add(this.tabPage2);
            this.tabPrincipal.Controls.Add(this.tabPage3);
            this.tabPrincipal.Controls.Add(this.tabPage4);
            this.tabPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabPrincipal.Location = new System.Drawing.Point(0, 0);
            this.tabPrincipal.Name = "tabPrincipal";
            this.tabPrincipal.SelectedIndex = 0;
            this.tabPrincipal.Size = new System.Drawing.Size(796, 455);
            this.tabPrincipal.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.LightGray;
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(788, 429);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Clientes";
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(788, 429);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Compras";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(6, 19);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(187, 21);
            this.comboBox1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(6, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(211, 53);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Categoria";
            // 
            // btnNuevoProducto
            // 
            this.btnNuevoProducto.Location = new System.Drawing.Point(22, 341);
            this.btnNuevoProducto.Name = "btnNuevoProducto";
            this.btnNuevoProducto.Size = new System.Drawing.Size(106, 23);
            this.btnNuevoProducto.TabIndex = 2;
            this.btnNuevoProducto.Text = "Nuevo Producto";
            this.btnNuevoProducto.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 87);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(742, 216);
            this.dataGridView1.TabIndex = 3;
            // 
            // DistribuidoraCrelech
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 455);
            this.Controls.Add(this.tabPrincipal);
            this.Name = "DistribuidoraCrelech";
            this.Text = "Form1";
            this.tabPage2.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabProductos2.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.tabFacturas.ResumeLayout(false);
            this.tabPrincipal.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabControl tabPrincipal;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabStock;
        private System.Windows.Forms.TabPage tabProductos2;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabFacturas;
        private System.Windows.Forms.TabPage tabHistorial;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button btNuevaFact;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnNuevoProducto;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

