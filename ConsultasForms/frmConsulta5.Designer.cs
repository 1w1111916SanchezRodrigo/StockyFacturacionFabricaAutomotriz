namespace DistribuidoraCrelech.ConsultasForms
{
    partial class frmConsulta5
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
            this.dgvFacturas = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.lblImpAnual = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblPromMensual = new System.Windows.Forms.Label();
            this.cmbAnio = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbTipoProdu = new System.Windows.Forms.ComboBox();
            this.lblanio = new System.Windows.Forms.Label();
            this.lblprodu = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFacturas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvFacturas
            // 
            this.dgvFacturas.AllowUserToAddRows = false;
            this.dgvFacturas.AllowUserToDeleteRows = false;
            this.dgvFacturas.AllowUserToResizeRows = false;
            this.dgvFacturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFacturas.Location = new System.Drawing.Point(12, 55);
            this.dgvFacturas.Name = "dgvFacturas";
            this.dgvFacturas.ReadOnly = true;
            this.dgvFacturas.ShowEditingIcon = false;
            this.dgvFacturas.Size = new System.Drawing.Size(540, 154);
            this.dgvFacturas.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(349, 228);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Promedio mensual:";
            // 
            // lblImpAnual
            // 
            this.lblImpAnual.AutoSize = true;
            this.lblImpAnual.ForeColor = System.Drawing.Color.Red;
            this.lblImpAnual.Location = new System.Drawing.Point(464, 257);
            this.lblImpAnual.Name = "lblImpAnual";
            this.lblImpAnual.Size = new System.Drawing.Size(35, 13);
            this.lblImpAnual.TabIndex = 2;
            this.lblImpAnual.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(382, 257);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Total anual:";
            // 
            // lblPromMensual
            // 
            this.lblPromMensual.AutoSize = true;
            this.lblPromMensual.Location = new System.Drawing.Point(464, 228);
            this.lblPromMensual.Name = "lblPromMensual";
            this.lblPromMensual.Size = new System.Drawing.Size(35, 13);
            this.lblPromMensual.TabIndex = 4;
            this.lblPromMensual.Text = "label4";
            // 
            // cmbAnio
            // 
            this.cmbAnio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAnio.FormattingEnabled = true;
            this.cmbAnio.Location = new System.Drawing.Point(110, 12);
            this.cmbAnio.Name = "cmbAnio";
            this.cmbAnio.Size = new System.Drawing.Size(57, 21);
            this.cmbAnio.TabIndex = 5;
            this.cmbAnio.SelectionChangeCommitted += new System.EventHandler(this.cmbAnio_SelectionChangeCommitted);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Seleccione el año:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(204, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(154, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Seleccione el tipo de producto:";
            // 
            // cmbTipoProdu
            // 
            this.cmbTipoProdu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoProdu.FormattingEnabled = true;
            this.cmbTipoProdu.Location = new System.Drawing.Point(364, 12);
            this.cmbTipoProdu.Name = "cmbTipoProdu";
            this.cmbTipoProdu.Size = new System.Drawing.Size(114, 21);
            this.cmbTipoProdu.TabIndex = 8;
            this.cmbTipoProdu.SelectionChangeCommitted += new System.EventHandler(this.cmbTipoProdu_SelectionChangeCommitted);
            // 
            // lblanio
            // 
            this.lblanio.AutoSize = true;
            this.lblanio.Location = new System.Drawing.Point(84, 228);
            this.lblanio.Name = "lblanio";
            this.lblanio.Size = new System.Drawing.Size(0, 13);
            this.lblanio.TabIndex = 9;
            // 
            // lblprodu
            // 
            this.lblprodu.AutoSize = true;
            this.lblprodu.Location = new System.Drawing.Point(157, 228);
            this.lblprodu.Name = "lblprodu";
            this.lblprodu.Size = new System.Drawing.Size(0, 13);
            this.lblprodu.TabIndex = 10;
            // 
            // frmConsulta5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 302);
            this.Controls.Add(this.lblprodu);
            this.Controls.Add(this.lblanio);
            this.Controls.Add(this.cmbTipoProdu);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbAnio);
            this.Controls.Add(this.lblPromMensual);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblImpAnual);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvFacturas);
            this.Name = "frmConsulta5";
            this.Text = "frmConsulta5";
            this.Load += new System.EventHandler(this.frmConsulta5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFacturas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvFacturas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblImpAnual;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblPromMensual;
        private System.Windows.Forms.ComboBox cmbAnio;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbTipoProdu;
        private System.Windows.Forms.Label lblanio;
        private System.Windows.Forms.Label lblprodu;
    }
}