
namespace BODEGA_SAC
{
    partial class FormRegisterSale
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
            this.txtDNIClient = new System.Windows.Forms.TextBox();
            this.btnSearchClient = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.rbtnSaleDetail = new System.Windows.Forms.RadioButton();
            this.rbtnSaleFast = new System.Windows.Forms.RadioButton();
            this.pnlTypeSaleFast = new System.Windows.Forms.Panel();
            this.btnDeleteProductToCartFast = new System.Windows.Forms.Button();
            this.lblTotalSaleFast = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblIGVSaleFast = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dvgCartFast = new System.Windows.Forms.DataGridView();
            this.btnAddToCartFast = new System.Windows.Forms.Button();
            this.txtAmountFast = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCodeProductFast = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnFinallySale = new System.Windows.Forms.Button();
            this.lblNameClient = new System.Windows.Forms.Label();
            this.btnCloseFormRegisterSale = new System.Windows.Forms.Button();
            this.txtImportCancelFast = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.pnlTypeSaleFast.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgCartFast)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Cooper Black", 20F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1158, 61);
            this.label1.TabIndex = 0;
            this.label1.Text = "Registrar Nueva Venta";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cooper Black", 13F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(14, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "DNI Cliente";
            // 
            // txtDNIClient
            // 
            this.txtDNIClient.Font = new System.Drawing.Font("Cooper Black", 13F);
            this.txtDNIClient.ForeColor = System.Drawing.Color.Black;
            this.txtDNIClient.Location = new System.Drawing.Point(181, 97);
            this.txtDNIClient.MaxLength = 8;
            this.txtDNIClient.Name = "txtDNIClient";
            this.txtDNIClient.Size = new System.Drawing.Size(156, 32);
            this.txtDNIClient.TabIndex = 2;
            // 
            // btnSearchClient
            // 
            this.btnSearchClient.AutoSize = true;
            this.btnSearchClient.Font = new System.Drawing.Font("Cooper Black", 13F);
            this.btnSearchClient.ForeColor = System.Drawing.Color.Black;
            this.btnSearchClient.Location = new System.Drawing.Point(353, 95);
            this.btnSearchClient.Name = "btnSearchClient";
            this.btnSearchClient.Size = new System.Drawing.Size(99, 35);
            this.btnSearchClient.TabIndex = 3;
            this.btnSearchClient.Text = "Buscar";
            this.btnSearchClient.UseVisualStyleBackColor = true;
            this.btnSearchClient.Click += new System.EventHandler(this.btnSearchClient_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cooper Black", 13F);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(507, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(189, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nombre Cliente";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.rbtnSaleDetail);
            this.panel1.Controls.Add(this.rbtnSaleFast);
            this.panel1.Location = new System.Drawing.Point(12, 136);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1158, 50);
            this.panel1.TabIndex = 6;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Cooper Black", 13F);
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(3, 14);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(168, 25);
            this.label11.TabIndex = 0;
            this.label11.Text = "Tipo de Venta";
            // 
            // rbtnSaleDetail
            // 
            this.rbtnSaleDetail.AutoSize = true;
            this.rbtnSaleDetail.Font = new System.Drawing.Font("Cooper Black", 11F);
            this.rbtnSaleDetail.ForeColor = System.Drawing.Color.Black;
            this.rbtnSaleDetail.Location = new System.Drawing.Point(481, 15);
            this.rbtnSaleDetail.Name = "rbtnSaleDetail";
            this.rbtnSaleDetail.Size = new System.Drawing.Size(187, 25);
            this.rbtnSaleDetail.TabIndex = 2;
            this.rbtnSaleDetail.TabStop = true;
            this.rbtnSaleDetail.Text = "Venta Detallada";
            this.rbtnSaleDetail.UseVisualStyleBackColor = true;
            // 
            // rbtnSaleFast
            // 
            this.rbtnSaleFast.AutoSize = true;
            this.rbtnSaleFast.Checked = true;
            this.rbtnSaleFast.Font = new System.Drawing.Font("Cooper Black", 11F);
            this.rbtnSaleFast.ForeColor = System.Drawing.Color.Black;
            this.rbtnSaleFast.Location = new System.Drawing.Point(255, 15);
            this.rbtnSaleFast.Name = "rbtnSaleFast";
            this.rbtnSaleFast.Size = new System.Drawing.Size(163, 25);
            this.rbtnSaleFast.TabIndex = 1;
            this.rbtnSaleFast.TabStop = true;
            this.rbtnSaleFast.Text = "Venta Rápida";
            this.rbtnSaleFast.UseVisualStyleBackColor = true;
            // 
            // pnlTypeSaleFast
            // 
            this.pnlTypeSaleFast.Controls.Add(this.btnDeleteProductToCartFast);
            this.pnlTypeSaleFast.Controls.Add(this.lblTotalSaleFast);
            this.pnlTypeSaleFast.Controls.Add(this.label9);
            this.pnlTypeSaleFast.Controls.Add(this.lblIGVSaleFast);
            this.pnlTypeSaleFast.Controls.Add(this.label6);
            this.pnlTypeSaleFast.Controls.Add(this.dvgCartFast);
            this.pnlTypeSaleFast.Controls.Add(this.btnAddToCartFast);
            this.pnlTypeSaleFast.Controls.Add(this.txtAmountFast);
            this.pnlTypeSaleFast.Controls.Add(this.label5);
            this.pnlTypeSaleFast.Controls.Add(this.txtCodeProductFast);
            this.pnlTypeSaleFast.Controls.Add(this.label4);
            this.pnlTypeSaleFast.Location = new System.Drawing.Point(12, 192);
            this.pnlTypeSaleFast.Name = "pnlTypeSaleFast";
            this.pnlTypeSaleFast.Size = new System.Drawing.Size(1158, 289);
            this.pnlTypeSaleFast.TabIndex = 7;
            // 
            // btnDeleteProductToCartFast
            // 
            this.btnDeleteProductToCartFast.AutoSize = true;
            this.btnDeleteProductToCartFast.Font = new System.Drawing.Font("Cooper Black", 13F);
            this.btnDeleteProductToCartFast.ForeColor = System.Drawing.Color.Black;
            this.btnDeleteProductToCartFast.Location = new System.Drawing.Point(801, 72);
            this.btnDeleteProductToCartFast.Name = "btnDeleteProductToCartFast";
            this.btnDeleteProductToCartFast.Size = new System.Drawing.Size(250, 35);
            this.btnDeleteProductToCartFast.TabIndex = 12;
            this.btnDeleteProductToCartFast.Text = "Eliminar del Carrito";
            this.btnDeleteProductToCartFast.UseVisualStyleBackColor = true;
            this.btnDeleteProductToCartFast.Click += new System.EventHandler(this.btnDeleteProductToCartFast_Click_1);
            // 
            // lblTotalSaleFast
            // 
            this.lblTotalSaleFast.Font = new System.Drawing.Font("Consolas", 26F, System.Drawing.FontStyle.Bold);
            this.lblTotalSaleFast.ForeColor = System.Drawing.Color.Black;
            this.lblTotalSaleFast.Location = new System.Drawing.Point(903, 211);
            this.lblTotalSaleFast.Name = "lblTotalSaleFast";
            this.lblTotalSaleFast.Size = new System.Drawing.Size(190, 51);
            this.lblTotalSaleFast.TabIndex = 9;
            this.lblTotalSaleFast.Text = "00.00";
            this.lblTotalSaleFast.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Cooper Black", 20F);
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(693, 221);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(155, 39);
            this.label9.TabIndex = 8;
            this.label9.Text = "Total S/";
            // 
            // lblIGVSaleFast
            // 
            this.lblIGVSaleFast.Font = new System.Drawing.Font("Consolas", 26F, System.Drawing.FontStyle.Bold);
            this.lblIGVSaleFast.ForeColor = System.Drawing.Color.Black;
            this.lblIGVSaleFast.Location = new System.Drawing.Point(903, 129);
            this.lblIGVSaleFast.Name = "lblIGVSaleFast";
            this.lblIGVSaleFast.Size = new System.Drawing.Size(190, 51);
            this.lblIGVSaleFast.TabIndex = 7;
            this.lblIGVSaleFast.Text = "00.00";
            this.lblIGVSaleFast.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cooper Black", 20F);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(706, 139);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(142, 39);
            this.label6.TabIndex = 6;
            this.label6.Text = "IVG. S/";
            // 
            // dvgCartFast
            // 
            this.dvgCartFast.AllowUserToAddRows = false;
            this.dvgCartFast.AllowUserToDeleteRows = false;
            this.dvgCartFast.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dvgCartFast.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgCartFast.Location = new System.Drawing.Point(7, 61);
            this.dvgCartFast.MultiSelect = false;
            this.dvgCartFast.Name = "dvgCartFast";
            this.dvgCartFast.ReadOnly = true;
            this.dvgCartFast.RowHeadersWidth = 51;
            this.dvgCartFast.RowTemplate.Height = 24;
            this.dvgCartFast.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvgCartFast.Size = new System.Drawing.Size(630, 201);
            this.dvgCartFast.TabIndex = 11;
            // 
            // btnAddToCartFast
            // 
            this.btnAddToCartFast.AutoSize = true;
            this.btnAddToCartFast.Font = new System.Drawing.Font("Cooper Black", 13F);
            this.btnAddToCartFast.ForeColor = System.Drawing.Color.Black;
            this.btnAddToCartFast.Location = new System.Drawing.Point(810, 13);
            this.btnAddToCartFast.Name = "btnAddToCartFast";
            this.btnAddToCartFast.Size = new System.Drawing.Size(229, 35);
            this.btnAddToCartFast.TabIndex = 4;
            this.btnAddToCartFast.Text = "Agregar al Carrito";
            this.btnAddToCartFast.UseVisualStyleBackColor = true;
            this.btnAddToCartFast.Click += new System.EventHandler(this.btnAddToCartFast_Click);
            // 
            // txtAmountFast
            // 
            this.txtAmountFast.Font = new System.Drawing.Font("Cooper Black", 13F);
            this.txtAmountFast.ForeColor = System.Drawing.Color.Black;
            this.txtAmountFast.Location = new System.Drawing.Point(637, 15);
            this.txtAmountFast.MaxLength = 3;
            this.txtAmountFast.Name = "txtAmountFast";
            this.txtAmountFast.Size = new System.Drawing.Size(112, 32);
            this.txtAmountFast.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cooper Black", 13F);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(495, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 25);
            this.label5.TabIndex = 2;
            this.label5.Text = "Cantidad";
            // 
            // txtCodeProductFast
            // 
            this.txtCodeProductFast.Font = new System.Drawing.Font("Cooper Black", 13F);
            this.txtCodeProductFast.ForeColor = System.Drawing.Color.Black;
            this.txtCodeProductFast.Location = new System.Drawing.Point(284, 15);
            this.txtCodeProductFast.MaxLength = 4;
            this.txtCodeProductFast.Name = "txtCodeProductFast";
            this.txtCodeProductFast.Size = new System.Drawing.Size(156, 32);
            this.txtCodeProductFast.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cooper Black", 13F);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(2, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(239, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "Código del Producto";
            // 
            // btnFinallySale
            // 
            this.btnFinallySale.AutoSize = true;
            this.btnFinallySale.Font = new System.Drawing.Font("Cooper Black", 22F);
            this.btnFinallySale.ForeColor = System.Drawing.Color.Black;
            this.btnFinallySale.Location = new System.Drawing.Point(536, 515);
            this.btnFinallySale.Name = "btnFinallySale";
            this.btnFinallySale.Size = new System.Drawing.Size(354, 52);
            this.btnFinallySale.TabIndex = 10;
            this.btnFinallySale.Text = "Finalizar Compra";
            this.btnFinallySale.UseVisualStyleBackColor = true;
            this.btnFinallySale.Click += new System.EventHandler(this.btnFinallySale_Click);
            // 
            // lblNameClient
            // 
            this.lblNameClient.Font = new System.Drawing.Font("Cooper Black", 13F);
            this.lblNameClient.ForeColor = System.Drawing.Color.Black;
            this.lblNameClient.Location = new System.Drawing.Point(721, 96);
            this.lblNameClient.Name = "lblNameClient";
            this.lblNameClient.Size = new System.Drawing.Size(436, 32);
            this.lblNameClient.TabIndex = 5;
            this.lblNameClient.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnCloseFormRegisterSale
            // 
            this.btnCloseFormRegisterSale.AutoSize = true;
            this.btnCloseFormRegisterSale.Font = new System.Drawing.Font("Cooper Black", 13F);
            this.btnCloseFormRegisterSale.ForeColor = System.Drawing.Color.Black;
            this.btnCloseFormRegisterSale.Location = new System.Drawing.Point(1033, 529);
            this.btnCloseFormRegisterSale.Name = "btnCloseFormRegisterSale";
            this.btnCloseFormRegisterSale.Size = new System.Drawing.Size(121, 35);
            this.btnCloseFormRegisterSale.TabIndex = 11;
            this.btnCloseFormRegisterSale.Text = "Salir";
            this.btnCloseFormRegisterSale.UseVisualStyleBackColor = true;
            this.btnCloseFormRegisterSale.Click += new System.EventHandler(this.btnCloseFormRegisterSale_Click);
            // 
            // txtImportCancelFast
            // 
            this.txtImportCancelFast.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold);
            this.txtImportCancelFast.ForeColor = System.Drawing.Color.Black;
            this.txtImportCancelFast.Location = new System.Drawing.Point(253, 531);
            this.txtImportCancelFast.MaxLength = 8;
            this.txtImportCancelFast.Name = "txtImportCancelFast";
            this.txtImportCancelFast.Size = new System.Drawing.Size(117, 31);
            this.txtImportCancelFast.TabIndex = 13;
            this.txtImportCancelFast.Text = "0.00";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Cooper Black", 13F);
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(12, 534);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(224, 25);
            this.label7.TabIndex = 12;
            this.label7.Text = "Importe Cancelado";
            // 
            // FormRegisterSale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 603);
            this.Controls.Add(this.txtImportCancelFast);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnCloseFormRegisterSale);
            this.Controls.Add(this.btnFinallySale);
            this.Controls.Add(this.lblNameClient);
            this.Controls.Add(this.pnlTypeSaleFast);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSearchClient);
            this.Controls.Add(this.txtDNIClient);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1200, 650);
            this.MinimumSize = new System.Drawing.Size(1200, 650);
            this.Name = "FormRegisterSale";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrar Venta ~ BODEGA SAC";
            this.Load += new System.EventHandler(this.FormRegisterSale_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlTypeSaleFast.ResumeLayout(false);
            this.pnlTypeSaleFast.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgCartFast)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDNIClient;
        private System.Windows.Forms.Button btnSearchClient;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbtnSaleDetail;
        private System.Windows.Forms.RadioButton rbtnSaleFast;
        private System.Windows.Forms.Panel pnlTypeSaleFast;
        private System.Windows.Forms.TextBox txtAmountFast;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCodeProductFast;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAddToCartFast;
        private System.Windows.Forms.DataGridView dvgCartFast;
        private System.Windows.Forms.Label lblTotalSaleFast;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblIGVSaleFast;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnFinallySale;
        private System.Windows.Forms.Label lblNameClient;
        private System.Windows.Forms.Button btnCloseFormRegisterSale;
        private System.Windows.Forms.Button btnDeleteProductToCartFast;
        private System.Windows.Forms.TextBox txtImportCancelFast;
        private System.Windows.Forms.Label label7;
    }
}