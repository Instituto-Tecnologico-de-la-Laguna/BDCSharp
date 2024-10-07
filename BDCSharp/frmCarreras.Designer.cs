namespace BDCSharp
{
    partial class frmCarreras
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
            this.dgvCarreras = new System.Windows.Forms.DataGridView();
            this.dgcEdicion = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarreras)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCarreras
            // 
            this.dgvCarreras.AllowUserToAddRows = false;
            this.dgvCarreras.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvCarreras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCarreras.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgcEdicion});
            this.dgvCarreras.Location = new System.Drawing.Point(12, 57);
            this.dgvCarreras.Name = "dgvCarreras";
            this.dgvCarreras.RowHeadersWidth = 62;
            this.dgvCarreras.RowTemplate.Height = 28;
            this.dgvCarreras.Size = new System.Drawing.Size(968, 193);
            this.dgvCarreras.TabIndex = 0;
            this.dgvCarreras.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCarreras_CellContentClick);
            // 
            // dgcEdicion
            // 
            this.dgcEdicion.HeaderText = "Edicion";
            this.dgcEdicion.Image = global::BDCSharp.Properties.Resources.edit16;
            this.dgcEdicion.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dgcEdicion.MinimumWidth = 8;
            this.dgcEdicion.Name = "dgcEdicion";
            this.dgcEdicion.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgcEdicion.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dgcEdicion.Width = 97;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "Edicion";
            this.dataGridViewImageColumn1.Image = global::BDCSharp.Properties.Resources.edit16;
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn1.MinimumWidth = 8;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewImageColumn1.Width = 97;
            // 
            // frmCarreras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 262);
            this.Controls.Add(this.dgvCarreras);
            this.Name = "frmCarreras";
            this.Text = "Carreras";
            this.Activated += new System.EventHandler(this.frmCarreras_Activated);
            this.Load += new System.EventHandler(this.frmCarreras_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarreras)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCarreras;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dgcEdicion;
    }
}