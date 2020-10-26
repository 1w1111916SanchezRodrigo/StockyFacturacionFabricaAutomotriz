namespace DistribuidoraCrelech.ConsultasForms
{
    partial class frmConsulta2
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
            this.cboTipoProductoConsult2 = new System.Windows.Forms.ComboBox();
            this.dgvCon2 = new System.Windows.Forms.DataGridView();
            this.lstPromedio = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCon2)).BeginInit();
            this.SuspendLayout();
            // 
            // cboTipoProductoConsult2
            // 
            this.cboTipoProductoConsult2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoProductoConsult2.FormattingEnabled = true;
            this.cboTipoProductoConsult2.Location = new System.Drawing.Point(12, 24);
            this.cboTipoProductoConsult2.Name = "cboTipoProductoConsult2";
            this.cboTipoProductoConsult2.Size = new System.Drawing.Size(121, 21);
            this.cboTipoProductoConsult2.TabIndex = 0;
            this.cboTipoProductoConsult2.SelectedIndexChanged += new System.EventHandler(this.cboTipoProducto_SelectedIndexChanged);
            // 
            // dgvCon2
            // 
            this.dgvCon2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCon2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCon2.Location = new System.Drawing.Point(12, 51);
            this.dgvCon2.Name = "dgvCon2";
            this.dgvCon2.Size = new System.Drawing.Size(361, 266);
            this.dgvCon2.TabIndex = 1;
            // 
            // lstPromedio
            // 
            this.lstPromedio.FormattingEnabled = true;
            this.lstPromedio.Location = new System.Drawing.Point(139, 28);
            this.lstPromedio.Name = "lstPromedio";
            this.lstPromedio.Size = new System.Drawing.Size(87, 17);
            this.lstPromedio.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(139, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Promedio";
            // 
            // frmConsulta2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstPromedio);
            this.Controls.Add(this.dgvCon2);
            this.Controls.Add(this.cboTipoProductoConsult2);
            this.Name = "frmConsulta2";
            this.Text = "frmConsulta2";
            this.Load += new System.EventHandler(this.frmConsulta2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCon2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboTipoProductoConsult2;
        private System.Windows.Forms.DataGridView dgvCon2;
        private System.Windows.Forms.ListBox lstPromedio;
        private System.Windows.Forms.Label label1;
    }
}