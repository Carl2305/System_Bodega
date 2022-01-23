
namespace BODEGA_SAC
{
    partial class FormRegisterCategory
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
            this.txtNameCategory = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDescriptionCategory = new System.Windows.Forms.TextBox();
            this.btnRegisterCategory = new System.Windows.Forms.Button();
            this.btnCloseFormRegisterCategory = new System.Windows.Forms.Button();
            this.dgvTableAllCategories = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTableAllCategories)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Cooper Black", 20F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(551, 88);
            this.label1.TabIndex = 0;
            this.label1.Text = "Registro de Nuevas Categorias";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cooper Black", 10F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(15, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre Categoria";
            // 
            // txtNameCategory
            // 
            this.txtNameCategory.Font = new System.Drawing.Font("Cooper Black", 10F);
            this.txtNameCategory.ForeColor = System.Drawing.Color.Black;
            this.txtNameCategory.Location = new System.Drawing.Point(217, 120);
            this.txtNameCategory.Name = "txtNameCategory";
            this.txtNameCategory.Size = new System.Drawing.Size(328, 27);
            this.txtNameCategory.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cooper Black", 10F);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(15, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(199, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Descripcion Categoria";
            // 
            // txtDescriptionCategory
            // 
            this.txtDescriptionCategory.Font = new System.Drawing.Font("Cooper Black", 10F);
            this.txtDescriptionCategory.ForeColor = System.Drawing.Color.Black;
            this.txtDescriptionCategory.Location = new System.Drawing.Point(252, 169);
            this.txtDescriptionCategory.Multiline = true;
            this.txtDescriptionCategory.Name = "txtDescriptionCategory";
            this.txtDescriptionCategory.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDescriptionCategory.Size = new System.Drawing.Size(293, 98);
            this.txtDescriptionCategory.TabIndex = 4;
            // 
            // btnRegisterCategory
            // 
            this.btnRegisterCategory.AutoSize = true;
            this.btnRegisterCategory.Font = new System.Drawing.Font("Cooper Black", 15F);
            this.btnRegisterCategory.ForeColor = System.Drawing.Color.Black;
            this.btnRegisterCategory.Location = new System.Drawing.Point(252, 300);
            this.btnRegisterCategory.Name = "btnRegisterCategory";
            this.btnRegisterCategory.Size = new System.Drawing.Size(142, 39);
            this.btnRegisterCategory.TabIndex = 5;
            this.btnRegisterCategory.Text = "Registrar";
            this.btnRegisterCategory.UseVisualStyleBackColor = true;
            this.btnRegisterCategory.Click += new System.EventHandler(this.btnRegisterCategory_Click);
            // 
            // btnCloseFormRegisterCategory
            // 
            this.btnCloseFormRegisterCategory.AutoSize = true;
            this.btnCloseFormRegisterCategory.Font = new System.Drawing.Font("Cooper Black", 15F);
            this.btnCloseFormRegisterCategory.ForeColor = System.Drawing.Color.Black;
            this.btnCloseFormRegisterCategory.Location = new System.Drawing.Point(438, 300);
            this.btnCloseFormRegisterCategory.Name = "btnCloseFormRegisterCategory";
            this.btnCloseFormRegisterCategory.Size = new System.Drawing.Size(107, 39);
            this.btnCloseFormRegisterCategory.TabIndex = 6;
            this.btnCloseFormRegisterCategory.Text = "Cerrar";
            this.btnCloseFormRegisterCategory.UseVisualStyleBackColor = true;
            this.btnCloseFormRegisterCategory.Click += new System.EventHandler(this.btnCloseFormRegisterCategory_Click);
            // 
            // dgvTableAllCategories
            // 
            this.dgvTableAllCategories.AllowUserToAddRows = false;
            this.dgvTableAllCategories.AllowUserToDeleteRows = false;
            this.dgvTableAllCategories.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvTableAllCategories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTableAllCategories.Location = new System.Drawing.Point(12, 363);
            this.dgvTableAllCategories.Name = "dgvTableAllCategories";
            this.dgvTableAllCategories.ReadOnly = true;
            this.dgvTableAllCategories.RowHeadersWidth = 51;
            this.dgvTableAllCategories.RowTemplate.Height = 24;
            this.dgvTableAllCategories.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTableAllCategories.Size = new System.Drawing.Size(551, 178);
            this.dgvTableAllCategories.TabIndex = 7;
            // 
            // FormRegisterCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 553);
            this.Controls.Add(this.dgvTableAllCategories);
            this.Controls.Add(this.btnCloseFormRegisterCategory);
            this.Controls.Add(this.btnRegisterCategory);
            this.Controls.Add(this.txtDescriptionCategory);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNameCategory);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(593, 600);
            this.MinimumSize = new System.Drawing.Size(593, 600);
            this.Name = "FormRegisterCategory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrar Categoria ~ BODEGA SAC";
            this.Load += new System.EventHandler(this.FormRegisterCategory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTableAllCategories)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNameCategory;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDescriptionCategory;
        private System.Windows.Forms.Button btnRegisterCategory;
        private System.Windows.Forms.Button btnCloseFormRegisterCategory;
        private System.Windows.Forms.DataGridView dgvTableAllCategories;
    }
}