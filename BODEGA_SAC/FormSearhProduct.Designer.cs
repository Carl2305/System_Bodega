
namespace BODEGA_SAC
{
    partial class FormSearhProduct
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
            this.dgvTableAllProducts = new System.Windows.Forms.DataGridView();
            this.btnCloseFormRegisterProduct = new System.Windows.Forms.Button();
            this.btnSearchCodeProduct = new System.Windows.Forms.Button();
            this.txtCodeProduct = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlForCode = new System.Windows.Forms.Panel();
            this.pnlForName = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNameProduct = new System.Windows.Forms.TextBox();
            this.btnSearchNameProduct = new System.Windows.Forms.Button();
            this.pnlForCategory = new System.Windows.Forms.Panel();
            this.cboCategory = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSearchCetogoryProduct = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.rbtnAllProducts = new System.Windows.Forms.RadioButton();
            this.rbtnForCategory = new System.Windows.Forms.RadioButton();
            this.rbtnForName = new System.Windows.Forms.RadioButton();
            this.rbtnForCode = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTableAllProducts)).BeginInit();
            this.pnlForCode.SuspendLayout();
            this.pnlForName.SuspendLayout();
            this.pnlForCategory.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvTableAllProducts
            // 
            this.dgvTableAllProducts.AllowUserToAddRows = false;
            this.dgvTableAllProducts.AllowUserToDeleteRows = false;
            this.dgvTableAllProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTableAllProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTableAllProducts.Location = new System.Drawing.Point(12, 246);
            this.dgvTableAllProducts.MultiSelect = false;
            this.dgvTableAllProducts.Name = "dgvTableAllProducts";
            this.dgvTableAllProducts.ReadOnly = true;
            this.dgvTableAllProducts.RowHeadersWidth = 51;
            this.dgvTableAllProducts.RowTemplate.Height = 24;
            this.dgvTableAllProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTableAllProducts.Size = new System.Drawing.Size(1058, 495);
            this.dgvTableAllProducts.TabIndex = 6;
            // 
            // btnCloseFormRegisterProduct
            // 
            this.btnCloseFormRegisterProduct.AutoSize = true;
            this.btnCloseFormRegisterProduct.Font = new System.Drawing.Font("Cooper Black", 16F);
            this.btnCloseFormRegisterProduct.ForeColor = System.Drawing.Color.Black;
            this.btnCloseFormRegisterProduct.Location = new System.Drawing.Point(937, 173);
            this.btnCloseFormRegisterProduct.Name = "btnCloseFormRegisterProduct";
            this.btnCloseFormRegisterProduct.Size = new System.Drawing.Size(114, 41);
            this.btnCloseFormRegisterProduct.TabIndex = 5;
            this.btnCloseFormRegisterProduct.Text = "Cerrar";
            this.btnCloseFormRegisterProduct.UseVisualStyleBackColor = true;
            this.btnCloseFormRegisterProduct.Click += new System.EventHandler(this.btnCloseFormRegisterProduct_Click);
            // 
            // btnSearchCodeProduct
            // 
            this.btnSearchCodeProduct.AutoSize = true;
            this.btnSearchCodeProduct.Font = new System.Drawing.Font("Cooper Black", 16F);
            this.btnSearchCodeProduct.ForeColor = System.Drawing.Color.Black;
            this.btnSearchCodeProduct.Location = new System.Drawing.Point(638, 14);
            this.btnSearchCodeProduct.Name = "btnSearchCodeProduct";
            this.btnSearchCodeProduct.Size = new System.Drawing.Size(154, 41);
            this.btnSearchCodeProduct.TabIndex = 2;
            this.btnSearchCodeProduct.Text = "Buscar";
            this.btnSearchCodeProduct.UseVisualStyleBackColor = true;
            this.btnSearchCodeProduct.Click += new System.EventHandler(this.btnSearchCodeProduct_Click);
            // 
            // txtCodeProduct
            // 
            this.txtCodeProduct.Font = new System.Drawing.Font("Cooper Black", 12F);
            this.txtCodeProduct.ForeColor = System.Drawing.Color.Black;
            this.txtCodeProduct.Location = new System.Drawing.Point(275, 23);
            this.txtCodeProduct.Name = "txtCodeProduct";
            this.txtCodeProduct.Size = new System.Drawing.Size(335, 30);
            this.txtCodeProduct.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cooper Black", 12F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(12, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(216, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Código del producto";
            // 
            // label1
            // 
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 26F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1058, 63);
            this.label1.TabIndex = 0;
            this.label1.Text = "Busqueda de un Producto";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlForCode
            // 
            this.pnlForCode.Controls.Add(this.label2);
            this.pnlForCode.Controls.Add(this.txtCodeProduct);
            this.pnlForCode.Controls.Add(this.btnSearchCodeProduct);
            this.pnlForCode.Location = new System.Drawing.Point(12, 159);
            this.pnlForCode.Name = "pnlForCode";
            this.pnlForCode.Size = new System.Drawing.Size(836, 81);
            this.pnlForCode.TabIndex = 2;
            this.pnlForCode.Visible = false;
            // 
            // pnlForName
            // 
            this.pnlForName.Controls.Add(this.label3);
            this.pnlForName.Controls.Add(this.txtNameProduct);
            this.pnlForName.Controls.Add(this.btnSearchNameProduct);
            this.pnlForName.Location = new System.Drawing.Point(12, 159);
            this.pnlForName.Name = "pnlForName";
            this.pnlForName.Size = new System.Drawing.Size(836, 81);
            this.pnlForName.TabIndex = 3;
            this.pnlForName.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cooper Black", 12F);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(12, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(229, 23);
            this.label3.TabIndex = 0;
            this.label3.Text = "Nombre del producto";
            // 
            // txtNameProduct
            // 
            this.txtNameProduct.Font = new System.Drawing.Font("Cooper Black", 12F);
            this.txtNameProduct.ForeColor = System.Drawing.Color.Black;
            this.txtNameProduct.Location = new System.Drawing.Point(275, 23);
            this.txtNameProduct.Name = "txtNameProduct";
            this.txtNameProduct.Size = new System.Drawing.Size(335, 30);
            this.txtNameProduct.TabIndex = 1;
            // 
            // btnSearchNameProduct
            // 
            this.btnSearchNameProduct.AutoSize = true;
            this.btnSearchNameProduct.Font = new System.Drawing.Font("Cooper Black", 16F);
            this.btnSearchNameProduct.ForeColor = System.Drawing.Color.Black;
            this.btnSearchNameProduct.Location = new System.Drawing.Point(638, 14);
            this.btnSearchNameProduct.Name = "btnSearchNameProduct";
            this.btnSearchNameProduct.Size = new System.Drawing.Size(154, 41);
            this.btnSearchNameProduct.TabIndex = 2;
            this.btnSearchNameProduct.Text = "Buscar";
            this.btnSearchNameProduct.UseVisualStyleBackColor = true;
            this.btnSearchNameProduct.Click += new System.EventHandler(this.btnSearchNameProduct_Click);
            // 
            // pnlForCategory
            // 
            this.pnlForCategory.Controls.Add(this.cboCategory);
            this.pnlForCategory.Controls.Add(this.label4);
            this.pnlForCategory.Controls.Add(this.btnSearchCetogoryProduct);
            this.pnlForCategory.Location = new System.Drawing.Point(12, 159);
            this.pnlForCategory.Name = "pnlForCategory";
            this.pnlForCategory.Size = new System.Drawing.Size(836, 81);
            this.pnlForCategory.TabIndex = 4;
            this.pnlForCategory.Visible = false;
            // 
            // cboCategory
            // 
            this.cboCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCategory.Font = new System.Drawing.Font("Cooper Black", 12F);
            this.cboCategory.ForeColor = System.Drawing.Color.Black;
            this.cboCategory.FormattingEnabled = true;
            this.cboCategory.Location = new System.Drawing.Point(289, 23);
            this.cboCategory.Name = "cboCategory";
            this.cboCategory.Size = new System.Drawing.Size(354, 31);
            this.cboCategory.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cooper Black", 12F);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(12, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(244, 23);
            this.label4.TabIndex = 0;
            this.label4.Text = "Categoría del producto";
            // 
            // btnSearchCetogoryProduct
            // 
            this.btnSearchCetogoryProduct.AutoSize = true;
            this.btnSearchCetogoryProduct.Font = new System.Drawing.Font("Cooper Black", 16F);
            this.btnSearchCetogoryProduct.ForeColor = System.Drawing.Color.Black;
            this.btnSearchCetogoryProduct.Location = new System.Drawing.Point(663, 14);
            this.btnSearchCetogoryProduct.Name = "btnSearchCetogoryProduct";
            this.btnSearchCetogoryProduct.Size = new System.Drawing.Size(154, 41);
            this.btnSearchCetogoryProduct.TabIndex = 2;
            this.btnSearchCetogoryProduct.Text = "Buscar";
            this.btnSearchCetogoryProduct.UseVisualStyleBackColor = true;
            this.btnSearchCetogoryProduct.Click += new System.EventHandler(this.btnSearchCetogoryProduct_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.rbtnAllProducts);
            this.panel4.Controls.Add(this.rbtnForCategory);
            this.panel4.Controls.Add(this.rbtnForName);
            this.panel4.Controls.Add(this.rbtnForCode);
            this.panel4.Location = new System.Drawing.Point(12, 76);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1039, 63);
            this.panel4.TabIndex = 1;
            this.panel4.Tag = "";
            // 
            // rbtnAllProducts
            // 
            this.rbtnAllProducts.AutoSize = true;
            this.rbtnAllProducts.Checked = true;
            this.rbtnAllProducts.Font = new System.Drawing.Font("Cooper Black", 12F);
            this.rbtnAllProducts.ForeColor = System.Drawing.Color.Black;
            this.rbtnAllProducts.Location = new System.Drawing.Point(16, 18);
            this.rbtnAllProducts.Name = "rbtnAllProducts";
            this.rbtnAllProducts.Size = new System.Drawing.Size(237, 27);
            this.rbtnAllProducts.TabIndex = 3;
            this.rbtnAllProducts.TabStop = true;
            this.rbtnAllProducts.Text = "Todos los Productos";
            this.rbtnAllProducts.UseVisualStyleBackColor = true;
            this.rbtnAllProducts.CheckedChanged += new System.EventHandler(this.rbtnAllProducts_CheckedChanged);
            // 
            // rbtnForCategory
            // 
            this.rbtnForCategory.AutoSize = true;
            this.rbtnForCategory.Font = new System.Drawing.Font("Cooper Black", 12F);
            this.rbtnForCategory.ForeColor = System.Drawing.Color.Black;
            this.rbtnForCategory.Location = new System.Drawing.Point(688, 18);
            this.rbtnForCategory.Name = "rbtnForCategory";
            this.rbtnForCategory.Size = new System.Drawing.Size(171, 27);
            this.rbtnForCategory.TabIndex = 2;
            this.rbtnForCategory.Text = "Por Categoría";
            this.rbtnForCategory.UseVisualStyleBackColor = true;
            this.rbtnForCategory.CheckedChanged += new System.EventHandler(this.rbtnForCategory_CheckedChanged);
            // 
            // rbtnForName
            // 
            this.rbtnForName.AutoSize = true;
            this.rbtnForName.Font = new System.Drawing.Font("Cooper Black", 12F);
            this.rbtnForName.ForeColor = System.Drawing.Color.Black;
            this.rbtnForName.Location = new System.Drawing.Point(487, 18);
            this.rbtnForName.Name = "rbtnForName";
            this.rbtnForName.Size = new System.Drawing.Size(156, 27);
            this.rbtnForName.TabIndex = 1;
            this.rbtnForName.Text = "Por Nombre";
            this.rbtnForName.UseVisualStyleBackColor = true;
            this.rbtnForName.CheckedChanged += new System.EventHandler(this.rbtnForName_CheckedChanged);
            // 
            // rbtnForCode
            // 
            this.rbtnForCode.AutoSize = true;
            this.rbtnForCode.Font = new System.Drawing.Font("Cooper Black", 12F);
            this.rbtnForCode.ForeColor = System.Drawing.Color.Black;
            this.rbtnForCode.Location = new System.Drawing.Point(289, 18);
            this.rbtnForCode.Name = "rbtnForCode";
            this.rbtnForCode.Size = new System.Drawing.Size(143, 27);
            this.rbtnForCode.TabIndex = 0;
            this.rbtnForCode.Text = "Por Código";
            this.rbtnForCode.UseVisualStyleBackColor = true;
            this.rbtnForCode.CheckedChanged += new System.EventHandler(this.rbtnForCode_CheckedChanged);
            // 
            // FormSearhProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 753);
            this.Controls.Add(this.pnlForCategory);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.pnlForName);
            this.Controls.Add(this.pnlForCode);
            this.Controls.Add(this.dgvTableAllProducts);
            this.Controls.Add(this.btnCloseFormRegisterProduct);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1100, 800);
            this.MinimumSize = new System.Drawing.Size(1100, 800);
            this.Name = "FormSearhProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscar Producto ~ BODEGA SAC";
            this.Load += new System.EventHandler(this.FormSearhProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTableAllProducts)).EndInit();
            this.pnlForCode.ResumeLayout(false);
            this.pnlForCode.PerformLayout();
            this.pnlForName.ResumeLayout(false);
            this.pnlForName.PerformLayout();
            this.pnlForCategory.ResumeLayout(false);
            this.pnlForCategory.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTableAllProducts;
        private System.Windows.Forms.Button btnCloseFormRegisterProduct;
        private System.Windows.Forms.Button btnSearchCodeProduct;
        private System.Windows.Forms.TextBox txtCodeProduct;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlForCode;
        private System.Windows.Forms.Panel pnlForName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNameProduct;
        private System.Windows.Forms.Button btnSearchNameProduct;
        private System.Windows.Forms.Panel pnlForCategory;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSearchCetogoryProduct;
        private System.Windows.Forms.ComboBox cboCategory;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.RadioButton rbtnForCategory;
        private System.Windows.Forms.RadioButton rbtnForName;
        private System.Windows.Forms.RadioButton rbtnForCode;
        private System.Windows.Forms.RadioButton rbtnAllProducts;
    }
}