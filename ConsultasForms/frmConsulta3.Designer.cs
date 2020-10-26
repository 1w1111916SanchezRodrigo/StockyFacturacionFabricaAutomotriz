namespace DistribuidoraCrelech.ConsultasForms
{
    partial class frmConsulta3
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
            this.dgvCons3 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cboLetra1 = new System.Windows.Forms.ComboBox();
            this.cboLetra2 = new System.Windows.Forms.ComboBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCons3)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCons3
            // 
            this.dgvCons3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCons3.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dgvCons3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCons3.Location = new System.Drawing.Point(65, 70);
            this.dgvCons3.Name = "dgvCons3";
            this.dgvCons3.Size = new System.Drawing.Size(433, 204);
            this.dgvCons3.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(128, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Letra";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(211, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Letra";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // cboLetra1
            // 
            this.cboLetra1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLetra1.FormattingEnabled = true;
            this.cboLetra1.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G",
            "H",
            "I",
            "J",
            "K",
            "L",
            "M",
            "N",
            "Ñ",
            "O",
            "P",
            "Q",
            "R",
            "S",
            "T",
            "U",
            "V",
            "W",
            "X",
            "Y",
            "Z"});
            this.cboLetra1.Location = new System.Drawing.Point(128, 33);
            this.cboLetra1.Name = "cboLetra1";
            this.cboLetra1.Size = new System.Drawing.Size(44, 21);
            this.cboLetra1.TabIndex = 8;
            this.cboLetra1.SelectedIndexChanged += new System.EventHandler(this.cboLetra1_SelectedIndexChanged);
            // 
            // cboLetra2
            // 
            this.cboLetra2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLetra2.FormattingEnabled = true;
            this.cboLetra2.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G",
            "H",
            "I",
            "J",
            "K",
            "L",
            "M",
            "N",
            "Ñ",
            "O",
            "P",
            "Q",
            "R",
            "S",
            "T",
            "U",
            "V",
            "W",
            "X",
            "Y",
            "Z"});
            this.cboLetra2.Location = new System.Drawing.Point(214, 33);
            this.cboLetra2.Name = "cboLetra2";
            this.cboLetra2.Size = new System.Drawing.Size(42, 21);
            this.cboLetra2.TabIndex = 9;
            this.cboLetra2.SelectedIndexChanged += new System.EventHandler(this.cboLetra2_SelectedIndexChanged);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(284, 33);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 10;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // frmConsulta3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.cboLetra2);
            this.Controls.Add(this.cboLetra1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvCons3);
            this.Name = "frmConsulta3";
            this.Text = "frmConsulta3";
            this.Load += new System.EventHandler(this.frmConsulta3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCons3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvCons3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboLetra1;
        private System.Windows.Forms.ComboBox cboLetra2;
        private System.Windows.Forms.Button btnBuscar;
    }
}