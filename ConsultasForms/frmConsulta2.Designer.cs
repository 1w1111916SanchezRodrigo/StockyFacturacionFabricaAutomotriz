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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.cboTipoProductoConsult2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTipoProductoConsult2.FormattingEnabled = true;
            this.cboTipoProductoConsult2.Location = new System.Drawing.Point(12, 12);
            this.cboTipoProductoConsult2.Name = "cboTipoProductoConsult2";
            this.cboTipoProductoConsult2.Size = new System.Drawing.Size(121, 23);
            this.cboTipoProductoConsult2.TabIndex = 0;
            this.cboTipoProductoConsult2.SelectedIndexChanged += new System.EventHandler(this.cboTipoProducto_SelectedIndexChanged);
            // 
            // dgvCon2
            // 
            this.dgvCon2.AllowUserToAddRows = false;
            this.dgvCon2.AllowUserToDeleteRows = false;
            this.dgvCon2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCon2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(66)))));
            this.dgvCon2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCon2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCon2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCon2.ColumnHeadersHeight = 30;
            this.dgvCon2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvCon2.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.dgvCon2.EnableHeadersVisualStyles = false;
            this.dgvCon2.Location = new System.Drawing.Point(12, 39);
            this.dgvCon2.Name = "dgvCon2";
            this.dgvCon2.ReadOnly = true;
            this.dgvCon2.RowHeadersVisible = false;
            this.dgvCon2.Size = new System.Drawing.Size(361, 286);
            this.dgvCon2.TabIndex = 1;
            // 
            // lstPromedio
            // 
            this.lstPromedio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstPromedio.FormattingEnabled = true;
            this.lstPromedio.ItemHeight = 15;
            this.lstPromedio.Location = new System.Drawing.Point(382, 55);
            this.lstPromedio.Name = "lstPromedio";
            this.lstPromedio.Size = new System.Drawing.Size(90, 19);
            this.lstPromedio.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(379, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Promedio";
            // 
            // frmConsulta2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(66)))));
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