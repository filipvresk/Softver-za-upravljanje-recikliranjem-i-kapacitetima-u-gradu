namespace Treca_Zadaca
{
    partial class frmUnesiMaterijal
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaterialType = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMaterialPriceKg = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMaterialQuantity = new System.Windows.Forms.TextBox();
            this.btnInsertMaterial = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Vrsta materijala";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtMaterialType
            // 
            this.txtMaterialType.Location = new System.Drawing.Point(36, 93);
            this.txtMaterialType.Name = "txtMaterialType";
            this.txtMaterialType.Size = new System.Drawing.Size(339, 22);
            this.txtMaterialType.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Cijena po kilogramu";
            // 
            // txtMaterialPriceKg
            // 
            this.txtMaterialPriceKg.Location = new System.Drawing.Point(36, 176);
            this.txtMaterialPriceKg.Name = "txtMaterialPriceKg";
            this.txtMaterialPriceKg.Size = new System.Drawing.Size(339, 22);
            this.txtMaterialPriceKg.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 228);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Količina";
            // 
            // txtMaterialQuantity
            // 
            this.txtMaterialQuantity.Location = new System.Drawing.Point(36, 247);
            this.txtMaterialQuantity.Name = "txtMaterialQuantity";
            this.txtMaterialQuantity.Size = new System.Drawing.Size(339, 22);
            this.txtMaterialQuantity.TabIndex = 7;
            // 
            // btnInsertMaterial
            // 
            this.btnInsertMaterial.Location = new System.Drawing.Point(52, 365);
            this.btnInsertMaterial.Name = "btnInsertMaterial";
            this.btnInsertMaterial.Size = new System.Drawing.Size(107, 35);
            this.btnInsertMaterial.TabIndex = 8;
            this.btnInsertMaterial.Text = "Unesi";
            this.btnInsertMaterial.UseVisualStyleBackColor = true;
            this.btnInsertMaterial.Click += new System.EventHandler(this.btnInsertMaterial_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(234, 365);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(107, 35);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "Odustani";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmUnesiMaterijal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 450);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnInsertMaterial);
            this.Controls.Add(this.txtMaterialQuantity);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtMaterialPriceKg);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMaterialType);
            this.Controls.Add(this.label2);
            this.Name = "frmUnesiMaterijal";
            this.Text = "Unos materijala";
            this.Load += new System.EventHandler(this.frmUnesiMaterijal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaterialType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMaterialPriceKg;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMaterialQuantity;
        private System.Windows.Forms.Button btnInsertMaterial;
        private System.Windows.Forms.Button btnExit;
    }
}