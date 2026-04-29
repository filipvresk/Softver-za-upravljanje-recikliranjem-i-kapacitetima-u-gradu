namespace Treca_Zadaca
{
    partial class frmMaterijali
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
            this.dgvMaterijali = new System.Windows.Forms.DataGridView();
            this.btnAddMaterial = new System.Windows.Forms.Button();
            this.btnDeleteMaterial = new System.Windows.Forms.Button();
            this.btnUpdateMaterial = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaterijali)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMaterijali
            // 
            this.dgvMaterijali.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMaterijali.Location = new System.Drawing.Point(12, 96);
            this.dgvMaterijali.Name = "dgvMaterijali";
            this.dgvMaterijali.RowHeadersWidth = 51;
            this.dgvMaterijali.RowTemplate.Height = 24;
            this.dgvMaterijali.Size = new System.Drawing.Size(776, 342);
            this.dgvMaterijali.TabIndex = 0;
            // 
            // btnAddMaterial
            // 
            this.btnAddMaterial.Location = new System.Drawing.Point(94, 37);
            this.btnAddMaterial.Name = "btnAddMaterial";
            this.btnAddMaterial.Size = new System.Drawing.Size(144, 41);
            this.btnAddMaterial.TabIndex = 1;
            this.btnAddMaterial.Text = "Unesi materijal";
            this.btnAddMaterial.UseVisualStyleBackColor = true;
            this.btnAddMaterial.Click += new System.EventHandler(this.btnAddMaterial_Click);
            // 
            // btnDeleteMaterial
            // 
            this.btnDeleteMaterial.Location = new System.Drawing.Point(569, 37);
            this.btnDeleteMaterial.Name = "btnDeleteMaterial";
            this.btnDeleteMaterial.Size = new System.Drawing.Size(144, 41);
            this.btnDeleteMaterial.TabIndex = 2;
            this.btnDeleteMaterial.Text = "Obriši materijal";
            this.btnDeleteMaterial.UseVisualStyleBackColor = true;
            this.btnDeleteMaterial.Click += new System.EventHandler(this.btnDeleteMaterial_Click);
            // 
            // btnUpdateMaterial
            // 
            this.btnUpdateMaterial.Location = new System.Drawing.Point(323, 37);
            this.btnUpdateMaterial.Name = "btnUpdateMaterial";
            this.btnUpdateMaterial.Size = new System.Drawing.Size(144, 41);
            this.btnUpdateMaterial.TabIndex = 3;
            this.btnUpdateMaterial.Text = "Ažuriraj materijal";
            this.btnUpdateMaterial.UseVisualStyleBackColor = true;
            this.btnUpdateMaterial.Click += new System.EventHandler(this.btnUpdateMaterial_Click);
            // 
            // frmMaterijali
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnUpdateMaterial);
            this.Controls.Add(this.btnDeleteMaterial);
            this.Controls.Add(this.btnAddMaterial);
            this.Controls.Add(this.dgvMaterijali);
            this.Name = "frmMaterijali";
            this.Text = "Materijali";
            this.Load += new System.EventHandler(this.frmMaterijali_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaterijali)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMaterijali;
        private System.Windows.Forms.Button btnAddMaterial;
        private System.Windows.Forms.Button btnDeleteMaterial;
        private System.Windows.Forms.Button btnUpdateMaterial;
    }
}