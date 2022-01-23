
namespace BODEGA_SAC
{
    partial class FormSearchSale
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
            this.dgvTableDetailSale = new System.Windows.Forms.DataGridView();
            this.lblTotalDebt = new System.Windows.Forms.Label();
            this.lblDateSale = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblNameCustomer = new System.Windows.Forms.Label();
            this.btnCloseFormDetailSale = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIdVenta = new System.Windows.Forms.TextBox();
            this.btnSearchSale = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTableDetailSale)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 26F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(571, 63);
            this.label1.TabIndex = 10;
            this.label1.Text = "Buscar Venta";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvTableDetailSale
            // 
            this.dgvTableDetailSale.AllowUserToAddRows = false;
            this.dgvTableDetailSale.AllowUserToDeleteRows = false;
            this.dgvTableDetailSale.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvTableDetailSale.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTableDetailSale.Location = new System.Drawing.Point(12, 296);
            this.dgvTableDetailSale.MultiSelect = false;
            this.dgvTableDetailSale.Name = "dgvTableDetailSale";
            this.dgvTableDetailSale.ReadOnly = true;
            this.dgvTableDetailSale.RowHeadersVisible = false;
            this.dgvTableDetailSale.RowHeadersWidth = 31;
            this.dgvTableDetailSale.RowTemplate.Height = 24;
            this.dgvTableDetailSale.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTableDetailSale.Size = new System.Drawing.Size(571, 427);
            this.dgvTableDetailSale.TabIndex = 11;
            // 
            // lblTotalDebt
            // 
            this.lblTotalDebt.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold);
            this.lblTotalDebt.ForeColor = System.Drawing.Color.Black;
            this.lblTotalDebt.Location = new System.Drawing.Point(408, 225);
            this.lblTotalDebt.Name = "lblTotalDebt";
            this.lblTotalDebt.Size = new System.Drawing.Size(177, 36);
            this.lblTotalDebt.TabIndex = 21;
            this.lblTotalDebt.Text = "0.00";
            this.lblTotalDebt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblDateSale
            // 
            this.lblDateSale.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateSale.ForeColor = System.Drawing.Color.Black;
            this.lblDateSale.Location = new System.Drawing.Point(300, 142);
            this.lblDateSale.Name = "lblDateSale";
            this.lblDateSale.Size = new System.Drawing.Size(285, 23);
            this.lblDateSale.TabIndex = 20;
            this.lblDateSale.Text = "dd/MM/yyyy HH:mm:ss";
            this.lblDateSale.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cooper Black", 18F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(157, 225);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(245, 35);
            this.label2.TabIndex = 22;
            this.label2.Text = "Total Venta S/.";
            // 
            // lblNameCustomer
            // 
            this.lblNameCustomer.AutoSize = true;
            this.lblNameCustomer.Font = new System.Drawing.Font("Cooper Black", 12F);
            this.lblNameCustomer.ForeColor = System.Drawing.Color.Black;
            this.lblNameCustomer.Location = new System.Drawing.Point(12, 177);
            this.lblNameCustomer.Name = "lblNameCustomer";
            this.lblNameCustomer.Size = new System.Drawing.Size(316, 23);
            this.lblNameCustomer.TabIndex = 23;
            this.lblNameCustomer.Text = "Nombre y apellidos del cliente";
            // 
            // btnCloseFormDetailSale
            // 
            this.btnCloseFormDetailSale.AutoSize = true;
            this.btnCloseFormDetailSale.Font = new System.Drawing.Font("Cooper Black", 16F);
            this.btnCloseFormDetailSale.ForeColor = System.Drawing.Color.Black;
            this.btnCloseFormDetailSale.Location = new System.Drawing.Point(460, 738);
            this.btnCloseFormDetailSale.Name = "btnCloseFormDetailSale";
            this.btnCloseFormDetailSale.Size = new System.Drawing.Size(114, 41);
            this.btnCloseFormDetailSale.TabIndex = 24;
            this.btnCloseFormDetailSale.Text = "Cerrar";
            this.btnCloseFormDetailSale.UseVisualStyleBackColor = true;
            this.btnCloseFormDetailSale.Click += new System.EventHandler(this.btnCloseFormDetailSale_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cooper Black", 12F);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(12, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 23);
            this.label3.TabIndex = 25;
            this.label3.Text = "ID VENTA";
            // 
            // txtIdVenta
            // 
            this.txtIdVenta.Font = new System.Drawing.Font("Cooper Black", 12F);
            this.txtIdVenta.ForeColor = System.Drawing.Color.Black;
            this.txtIdVenta.Location = new System.Drawing.Point(152, 88);
            this.txtIdVenta.Name = "txtIdVenta";
            this.txtIdVenta.Size = new System.Drawing.Size(100, 30);
            this.txtIdVenta.TabIndex = 26;
            // 
            // btnSearchSale
            // 
            this.btnSearchSale.AutoSize = true;
            this.btnSearchSale.Font = new System.Drawing.Font("Cooper Black", 16F);
            this.btnSearchSale.ForeColor = System.Drawing.Color.Black;
            this.btnSearchSale.Location = new System.Drawing.Point(291, 79);
            this.btnSearchSale.Name = "btnSearchSale";
            this.btnSearchSale.Size = new System.Drawing.Size(117, 41);
            this.btnSearchSale.TabIndex = 27;
            this.btnSearchSale.Text = "Buscar";
            this.btnSearchSale.UseVisualStyleBackColor = true;
            this.btnSearchSale.Click += new System.EventHandler(this.btnSearchSale_Click);
            // 
            // FormSearchSale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 791);
            this.Controls.Add(this.btnSearchSale);
            this.Controls.Add(this.txtIdVenta);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnCloseFormDetailSale);
            this.Controls.Add(this.lblNameCustomer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblTotalDebt);
            this.Controls.Add(this.lblDateSale);
            this.Controls.Add(this.dgvTableDetailSale);
            this.Controls.Add(this.label1);
            this.Name = "FormSearchSale";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscar Venta ~ BODEGA SAC";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTableDetailSale)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvTableDetailSale;
        private System.Windows.Forms.Label lblTotalDebt;
        private System.Windows.Forms.Label lblDateSale;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblNameCustomer;
        private System.Windows.Forms.Button btnCloseFormDetailSale;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIdVenta;
        private System.Windows.Forms.Button btnSearchSale;
    }
}