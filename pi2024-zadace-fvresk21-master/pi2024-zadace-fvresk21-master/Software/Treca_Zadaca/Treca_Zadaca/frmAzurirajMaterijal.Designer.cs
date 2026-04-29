namespace Treca_Zadaca
{
    partial class frmAzurirajMaterijal
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtIdMaterialUpdate = new System.Windows.Forms.TextBox();
            this.txtMaterialTypeUpdate = new System.Windows.Forms.TextBox();
            this.txtMaterialPriceKgUpdate = new System.Windows.Forms.TextBox();
            this.txtMaterialQuantityUpdate = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnExitUpdate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID materijala";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Vrsta materijala";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cijena po kilogramu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 248);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Količina";
            // 
            // txtIdMaterialUpdate
            // 
            this.txtIdMaterialUpdate.Location = new System.Drawing.Point(42, 66);
            this.txtIdMaterialUpdate.Name = "txtIdMaterialUpdate";
            this.txtIdMaterialUpdate.ReadOnly = true;
            this.txtIdMaterialUpdate.Size = new System.Drawing.Size(220, 22);
            this.txtIdMaterialUpdate.TabIndex = 4;
            // 
            // txtMaterialTypeUpdate
            // 
            this.txtMaterialTypeUpdate.Location = new System.Drawing.Point(42, 131);
            this.txtMaterialTypeUpdate.Name = "txtMaterialTypeUpdate";
            this.txtMaterialTypeUpdate.Size = new System.Drawing.Size(220, 22);
            this.txtMaterialTypeUpdate.TabIndex = 5;
            // 
            // txtMaterialPriceKgUpdate
            // 
            this.txtMaterialPriceKgUpdate.Location = new System.Drawing.Point(42, 201);
            this.txtMaterialPriceKgUpdate.Name = "txtMaterialPriceKgUpdate";
            this.txtMaterialPriceKgUpdate.Size = new System.Drawing.Size(220, 22);
            this.txtMaterialPriceKgUpdate.TabIndex = 6;
            // 
            // txtMaterialQuantityUpdate
            // 
            this.txtMaterialQuantityUpdate.Location = new System.Drawing.Point(42, 267);
            this.txtMaterialQuantityUpdate.Name = "txtMaterialQuantityUpdate";
            this.txtMaterialQuantityUpdate.Size = new System.Drawing.Size(220, 22);
            this.txtMaterialQuantityUpdate.TabIndex = 7;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(65, 355);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(114, 44);
            this.btnUpdate.TabIndex = 8;
            this.btnUpdate.Text = "Ažuriraj";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnExitUpdate
            // 
            this.btnExitUpdate.Location = new System.Drawing.Point(249, 355);
            this.btnExitUpdate.Name = "btnExitUpdate";
            this.btnExitUpdate.Size = new System.Drawing.Size(120, 44);
            this.btnExitUpdate.TabIndex = 9;
            this.btnExitUpdate.Text = "Odustani";
            this.btnExitUpdate.UseVisualStyleBackColor = true;
            this.btnExitUpdate.Click += new System.EventHandler(this.btnExitUpdate_Click);
            // 
            // frmAzurirajMaterijal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 450);
            this.Controls.Add(this.btnExitUpdate);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txtMaterialQuantityUpdate);
            this.Controls.Add(this.txtMaterialPriceKgUpdate);
            this.Controls.Add(this.txtMaterialTypeUpdate);
            this.Controls.Add(this.txtIdMaterialUpdate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmAzurirajMaterijal";
            this.Text = "Ažuriraj materijal";
            this.Load += new System.EventHandler(this.frmAzurirajMaterijal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtIdMaterialUpdate;
        private System.Windows.Forms.TextBox txtMaterialTypeUpdate;
        private System.Windows.Forms.TextBox txtMaterialPriceKgUpdate;
        private System.Windows.Forms.TextBox txtMaterialQuantityUpdate;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnExitUpdate;
    }
}