
namespace BODEGA_SAC
{
    partial class FormUpdateProduct
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
            this.txtStockProduct = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.lblCodeProduct = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cboCategory = new System.Windows.Forms.ComboBox();
            this.dgvTableAllProducts = new System.Windows.Forms.DataGridView();
            this.btnCloseFormUpdateProduct = new System.Windows.Forms.Button();
            this.btnUpdateProduct = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDescriptionProduct = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPriceProduct = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNameProduct = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTableAllProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // txtStockProduct
            // 
            this.txtStockProduct.Font = new System.Drawing.Font("Cooper Black", 12F);
            this.txtStockProduct.ForeColor = System.Drawing.Color.Black;
            this.txtStockProduct.Location = new System.Drawing.Point(892, 111);
            this.txtStockProduct.Name = "txtStockProduct";
            this.txtStockProduct.ReadOnly = true;
            this.txtStockProduct.Size = new System.Drawing.Size(153, 30);
            this.txtStockProduct.TabIndex = 26;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Cooper Black", 12F);
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(816, 114);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 23);
            this.label9.TabIndex = 25;
            this.label9.Text = "Stock";
            // 
            // lblCodeProduct
            // 
            this.lblCodeProduct.AutoSize = true;
            this.lblCodeProduct.Font = new System.Drawing.Font("Cooper Black", 12F);
            this.lblCodeProduct.ForeColor = System.Drawing.Color.Black;
            this.lblCodeProduct.Location = new System.Drawing.Point(989, 38);
            this.lblCodeProduct.Name = "lblCodeProduct";
            this.lblCodeProduct.Size = new System.Drawing.Size(58, 23);
            this.lblCodeProduct.TabIndex = 18;
            this.lblCodeProduct.Text = "0000";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Cooper Black", 12F);
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(891, 10);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(156, 23);
            this.label8.TabIndex = 17;
            this.label8.Text = "Cod. Producto";
            // 
            // cboCategory
            // 
            this.cboCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCategory.Font = new System.Drawing.Font("Cooper Black", 12F);
            this.cboCategory.ForeColor = System.Drawing.Color.Black;
            this.cboCategory.FormattingEnabled = true;
            this.cboCategory.Location = new System.Drawing.Point(637, 163);
            this.cboCategory.Name = "cboCategory";
            this.cboCategory.Size = new System.Drawing.Size(408, 31);
            this.cboCategory.TabIndex = 28;
            // 
            // dgvTableAllProducts
            // 
            this.dgvTableAllProducts.AllowUserToAddRows = false;
            this.dgvTableAllProducts.AllowUserToDeleteRows = false;
            this.dgvTableAllProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTableAllProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTableAllProducts.Location = new System.Drawing.Point(12, 326);
            this.dgvTableAllProducts.MultiSelect = false;
            this.dgvTableAllProducts.Name = "dgvTableAllProducts";
            this.dgvTableAllProducts.ReadOnly = true;
            this.dgvTableAllProducts.RowHeadersWidth = 51;
            this.dgvTableAllProducts.RowTemplate.Height = 24;
            this.dgvTableAllProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTableAllProducts.Size = new System.Drawing.Size(1058, 416);
            this.dgvTableAllProducts.TabIndex = 31;
            this.dgvTableAllProducts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTableAllProducts_CellClick);
            // 
            // btnCloseFormUpdateProduct
            // 
            this.btnCloseFormUpdateProduct.AutoSize = true;
            this.btnCloseFormUpdateProduct.Font = new System.Drawing.Font("Cooper Black", 16F);
            this.btnCloseFormUpdateProduct.ForeColor = System.Drawing.Color.Black;
            this.btnCloseFormUpdateProduct.Location = new System.Drawing.Point(931, 240);
            this.btnCloseFormUpdateProduct.Name = "btnCloseFormUpdateProduct";
            this.btnCloseFormUpdateProduct.Size = new System.Drawing.Size(114, 41);
            this.btnCloseFormUpdateProduct.TabIndex = 30;
            this.btnCloseFormUpdateProduct.Text = "Cerrar";
            this.btnCloseFormUpdateProduct.UseVisualStyleBackColor = true;
            this.btnCloseFormUpdateProduct.Click += new System.EventHandler(this.btnCloseFormUpdateProduct_Click);
            // 
            // btnUpdateProduct
            // 
            this.btnUpdateProduct.AutoSize = true;
            this.btnUpdateProduct.Font = new System.Drawing.Font("Cooper Black", 16F);
            this.btnUpdateProduct.ForeColor = System.Drawing.Color.Black;
            this.btnUpdateProduct.Location = new System.Drawing.Point(745, 240);
            this.btnUpdateProduct.Name = "btnUpdateProduct";
            this.btnUpdateProduct.Size = new System.Drawing.Size(154, 41);
            this.btnUpdateProduct.TabIndex = 29;
            this.btnUpdateProduct.Text = "Actulizar";
            this.btnUpdateProduct.UseVisualStyleBackColor = true;
            this.btnUpdateProduct.Click += new System.EventHandler(this.btnUpdateProduct_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cooper Black", 12F);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(509, 166);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 23);
            this.label6.TabIndex = 27;
            this.label6.Text = "Categoria";
            // 
            // txtDescriptionProduct
            // 
            this.txtDescriptionProduct.Font = new System.Drawing.Font("Cooper Black", 12F);
            this.txtDescriptionProduct.ForeColor = System.Drawing.Color.Black;
            this.txtDescriptionProduct.Location = new System.Drawing.Point(164, 163);
            this.txtDescriptionProduct.Multiline = true;
            this.txtDescriptionProduct.Name = "txtDescriptionProduct";
            this.txtDescriptionProduct.ReadOnly = true;
            this.txtDescriptionProduct.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDescriptionProduct.Size = new System.Drawing.Size(308, 118);
            this.txtDescriptionProduct.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cooper Black", 12F);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(12, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 23);
            this.label4.TabIndex = 21;
            this.label4.Text = "Descripción";
            // 
            // txtPriceProduct
            // 
            this.txtPriceProduct.Font = new System.Drawing.Font("Cooper Black", 12F);
            this.txtPriceProduct.ForeColor = System.Drawing.Color.Black;
            this.txtPriceProduct.Location = new System.Drawing.Point(624, 111);
            this.txtPriceProduct.Name = "txtPriceProduct";
            this.txtPriceProduct.ReadOnly = true;
            this.txtPriceProduct.Size = new System.Drawing.Size(146, 30);
            this.txtPriceProduct.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cooper Black", 12F);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(509, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 23);
            this.label3.TabIndex = 23;
            this.label3.Text = "Precio S/.";
            // 
            // txtNameProduct
            // 
            this.txtNameProduct.Font = new System.Drawing.Font("Cooper Black", 12F);
            this.txtNameProduct.ForeColor = System.Drawing.Color.Black;
            this.txtNameProduct.Location = new System.Drawing.Point(137, 111);
            this.txtNameProduct.Name = "txtNameProduct";
            this.txtNameProduct.ReadOnly = true;
            this.txtNameProduct.Size = new System.Drawing.Size(335, 30);
            this.txtNameProduct.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cooper Black", 12F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(17, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 23);
            this.label2.TabIndex = 19;
            this.label2.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 26F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(846, 63);
            this.label1.TabIndex = 16;
            this.label1.Text = "Actualizar Productos";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormUpdateProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 753);
            this.Controls.Add(this.txtStockProduct);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblCodeProduct);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cboCategory);
            this.Controls.Add(this.dgvTableAllProducts);
            this.Controls.Add(this.btnCloseFormUpdateProduct);
            this.Controls.Add(this.btnUpdateProduct);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtDescriptionProduct);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPriceProduct);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNameProduct);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1100, 800);
            this.MinimumSize = new System.Drawing.Size(1100, 800);
            this.Name = "FormUpdateProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Actualizar Producto ~ BODEGA SAC";
            this.Load += new System.EventHandler(this.FormUpdateProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTableAllProducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtStockProduct;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblCodeProduct;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cboCategory;
        private System.Windows.Forms.DataGridView dgvTableAllProducts;
        private System.Windows.Forms.Button btnCloseFormUpdateProduct;
        private System.Windows.Forms.Button btnUpdateProduct;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDescriptionProduct;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPriceProduct;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNameProduct;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}