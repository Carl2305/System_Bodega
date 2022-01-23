
namespace BODEGA_SAC
{
    partial class FormUpdateCategory
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
            this.dgvTableAllCategories = new System.Windows.Forms.DataGridView();
            this.btnCloseFormUpdateCategory = new System.Windows.Forms.Button();
            this.btnUpdateCategory = new System.Windows.Forms.Button();
            this.txtDescriptionCategory = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNameCategory = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTableAllCategories)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTableAllCategories
            // 
            this.dgvTableAllCategories.AllowUserToAddRows = false;
            this.dgvTableAllCategories.AllowUserToDeleteRows = false;
            this.dgvTableAllCategories.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvTableAllCategories.ColumnHeadersHeight = 29;
            this.dgvTableAllCategories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvTableAllCategories.Location = new System.Drawing.Point(12, 364);
            this.dgvTableAllCategories.MultiSelect = false;
            this.dgvTableAllCategories.Name = "dgvTableAllCategories";
            this.dgvTableAllCategories.ReadOnly = true;
            this.dgvTableAllCategories.RowHeadersWidth = 51;
            this.dgvTableAllCategories.RowTemplate.Height = 24;
            this.dgvTableAllCategories.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTableAllCategories.Size = new System.Drawing.Size(551, 178);
            this.dgvTableAllCategories.TabIndex = 15;
            this.dgvTableAllCategories.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTableAllCategories_CellClick);
            // 
            // btnCloseFormUpdateCategory
            // 
            this.btnCloseFormUpdateCategory.AutoSize = true;
            this.btnCloseFormUpdateCategory.Font = new System.Drawing.Font("Cooper Black", 15F);
            this.btnCloseFormUpdateCategory.ForeColor = System.Drawing.Color.Black;
            this.btnCloseFormUpdateCategory.Location = new System.Drawing.Point(438, 301);
            this.btnCloseFormUpdateCategory.Name = "btnCloseFormUpdateCategory";
            this.btnCloseFormUpdateCategory.Size = new System.Drawing.Size(107, 39);
            this.btnCloseFormUpdateCategory.TabIndex = 14;
            this.btnCloseFormUpdateCategory.Text = "Cerrar";
            this.btnCloseFormUpdateCategory.UseVisualStyleBackColor = true;
            this.btnCloseFormUpdateCategory.Click += new System.EventHandler(this.btnCloseFormUpdateCategory_Click);
            // 
            // btnUpdateCategory
            // 
            this.btnUpdateCategory.AutoSize = true;
            this.btnUpdateCategory.Font = new System.Drawing.Font("Cooper Black", 15F);
            this.btnUpdateCategory.ForeColor = System.Drawing.Color.Black;
            this.btnUpdateCategory.Location = new System.Drawing.Point(252, 301);
            this.btnUpdateCategory.Name = "btnUpdateCategory";
            this.btnUpdateCategory.Size = new System.Drawing.Size(158, 39);
            this.btnUpdateCategory.TabIndex = 13;
            this.btnUpdateCategory.Text = "Actualizar";
            this.btnUpdateCategory.UseVisualStyleBackColor = true;
            this.btnUpdateCategory.Click += new System.EventHandler(this.btnUpdateCategory_Click);
            // 
            // txtDescriptionCategory
            // 
            this.txtDescriptionCategory.Font = new System.Drawing.Font("Cooper Black", 10F);
            this.txtDescriptionCategory.ForeColor = System.Drawing.Color.Black;
            this.txtDescriptionCategory.Location = new System.Drawing.Point(252, 170);
            this.txtDescriptionCategory.Multiline = true;
            this.txtDescriptionCategory.Name = "txtDescriptionCategory";
            this.txtDescriptionCategory.ReadOnly = true;
            this.txtDescriptionCategory.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDescriptionCategory.Size = new System.Drawing.Size(293, 98);
            this.txtDescriptionCategory.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cooper Black", 10F);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(15, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(199, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Descripcion Categoria";
            // 
            // txtNameCategory
            // 
            this.txtNameCategory.Font = new System.Drawing.Font("Cooper Black", 10F);
            this.txtNameCategory.ForeColor = System.Drawing.Color.Black;
            this.txtNameCategory.Location = new System.Drawing.Point(217, 121);
            this.txtNameCategory.Name = "txtNameCategory";
            this.txtNameCategory.ReadOnly = true;
            this.txtNameCategory.Size = new System.Drawing.Size(328, 27);
            this.txtNameCategory.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cooper Black", 10F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(15, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Nombre Categoria";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Cooper Black", 20F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(551, 88);
            this.label1.TabIndex = 8;
            this.label1.Text = "Actulizar Categorias";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormUpdateCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 553);
            this.Controls.Add(this.dgvTableAllCategories);
            this.Controls.Add(this.btnCloseFormUpdateCategory);
            this.Controls.Add(this.btnUpdateCategory);
            this.Controls.Add(this.txtDescriptionCategory);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNameCategory);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(593, 600);
            this.MinimumSize = new System.Drawing.Size(593, 600);
            this.Name = "FormUpdateCategory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Actualizar Categoria ~ BODEGA SAC";
            this.Load += new System.EventHandler(this.FormUpdateCategory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTableAllCategories)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTableAllCategories;
        private System.Windows.Forms.Button btnCloseFormUpdateCategory;
        private System.Windows.Forms.Button btnUpdateCategory;
        private System.Windows.Forms.TextBox txtDescriptionCategory;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNameCategory;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}