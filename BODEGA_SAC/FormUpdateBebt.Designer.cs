
namespace BODEGA_SAC
{
    partial class FormUpdateBebt
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
            this.dgvTableAllDebtForCustomer = new System.Windows.Forms.DataGridView();
            this.btnCloseFormUpdateDebt = new System.Windows.Forms.Button();
            this.txtDNIClient = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNameClient = new System.Windows.Forms.Label();
            this.btnSearchDNI = new System.Windows.Forms.Button();
            this.pnlAmortizar = new System.Windows.Forms.Panel();
            this.lblTotalSale = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtAmountPay = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lblDebt = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblIdDebt = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAmortizar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTableAllDebtForCustomer)).BeginInit();
            this.pnlAmortizar.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvTableAllDebtForCustomer
            // 
            this.dgvTableAllDebtForCustomer.AllowUserToAddRows = false;
            this.dgvTableAllDebtForCustomer.AllowUserToDeleteRows = false;
            this.dgvTableAllDebtForCustomer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvTableAllDebtForCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTableAllDebtForCustomer.Location = new System.Drawing.Point(12, 175);
            this.dgvTableAllDebtForCustomer.MultiSelect = false;
            this.dgvTableAllDebtForCustomer.Name = "dgvTableAllDebtForCustomer";
            this.dgvTableAllDebtForCustomer.ReadOnly = true;
            this.dgvTableAllDebtForCustomer.RowHeadersVisible = false;
            this.dgvTableAllDebtForCustomer.RowHeadersWidth = 31;
            this.dgvTableAllDebtForCustomer.RowTemplate.Height = 24;
            this.dgvTableAllDebtForCustomer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTableAllDebtForCustomer.Size = new System.Drawing.Size(620, 342);
            this.dgvTableAllDebtForCustomer.TabIndex = 7;
            this.dgvTableAllDebtForCustomer.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTableAllDebtForCustomer_CellClick);
            // 
            // btnCloseFormUpdateDebt
            // 
            this.btnCloseFormUpdateDebt.AutoSize = true;
            this.btnCloseFormUpdateDebt.Font = new System.Drawing.Font("Cooper Black", 16F);
            this.btnCloseFormUpdateDebt.ForeColor = System.Drawing.Color.Black;
            this.btnCloseFormUpdateDebt.Location = new System.Drawing.Point(976, 476);
            this.btnCloseFormUpdateDebt.Name = "btnCloseFormUpdateDebt";
            this.btnCloseFormUpdateDebt.Size = new System.Drawing.Size(114, 41);
            this.btnCloseFormUpdateDebt.TabIndex = 6;
            this.btnCloseFormUpdateDebt.Text = "Cerrar";
            this.btnCloseFormUpdateDebt.UseVisualStyleBackColor = true;
            this.btnCloseFormUpdateDebt.Click += new System.EventHandler(this.btnCloseFormUpdateDebt_Click);
            // 
            // txtDNIClient
            // 
            this.txtDNIClient.Font = new System.Drawing.Font("Cooper Black", 12F);
            this.txtDNIClient.ForeColor = System.Drawing.Color.Black;
            this.txtDNIClient.Location = new System.Drawing.Point(168, 111);
            this.txtDNIClient.MaxLength = 8;
            this.txtDNIClient.Name = "txtDNIClient";
            this.txtDNIClient.Size = new System.Drawing.Size(133, 30);
            this.txtDNIClient.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cooper Black", 12F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(17, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "DNI Cliente";
            // 
            // label1
            // 
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 26F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1108, 63);
            this.label1.TabIndex = 0;
            this.label1.Text = "Buscar y Actualizar Deudas";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNameClient
            // 
            this.lblNameClient.Font = new System.Drawing.Font("Cooper Black", 12F);
            this.lblNameClient.ForeColor = System.Drawing.Color.Black;
            this.lblNameClient.Location = new System.Drawing.Point(506, 114);
            this.lblNameClient.Name = "lblNameClient";
            this.lblNameClient.Size = new System.Drawing.Size(541, 23);
            this.lblNameClient.TabIndex = 4;
            // 
            // btnSearchDNI
            // 
            this.btnSearchDNI.AutoSize = true;
            this.btnSearchDNI.Font = new System.Drawing.Font("Cooper Black", 12F);
            this.btnSearchDNI.ForeColor = System.Drawing.Color.Black;
            this.btnSearchDNI.Location = new System.Drawing.Point(329, 109);
            this.btnSearchDNI.Name = "btnSearchDNI";
            this.btnSearchDNI.Size = new System.Drawing.Size(117, 33);
            this.btnSearchDNI.TabIndex = 3;
            this.btnSearchDNI.Text = "Buscar";
            this.btnSearchDNI.UseVisualStyleBackColor = true;
            this.btnSearchDNI.Click += new System.EventHandler(this.btnSearchDNI_Click);
            // 
            // pnlAmortizar
            // 
            this.pnlAmortizar.Controls.Add(this.lblTotalSale);
            this.pnlAmortizar.Controls.Add(this.label9);
            this.pnlAmortizar.Controls.Add(this.txtAmountPay);
            this.pnlAmortizar.Controls.Add(this.label7);
            this.pnlAmortizar.Controls.Add(this.lblDebt);
            this.pnlAmortizar.Controls.Add(this.label6);
            this.pnlAmortizar.Controls.Add(this.lblIdDebt);
            this.pnlAmortizar.Controls.Add(this.label3);
            this.pnlAmortizar.Controls.Add(this.btnAmortizar);
            this.pnlAmortizar.Location = new System.Drawing.Point(663, 175);
            this.pnlAmortizar.Name = "pnlAmortizar";
            this.pnlAmortizar.Size = new System.Drawing.Size(427, 282);
            this.pnlAmortizar.TabIndex = 8;
            // 
            // lblTotalSale
            // 
            this.lblTotalSale.AutoSize = true;
            this.lblTotalSale.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold);
            this.lblTotalSale.ForeColor = System.Drawing.Color.Black;
            this.lblTotalSale.Location = new System.Drawing.Point(249, 55);
            this.lblTotalSale.Name = "lblTotalSale";
            this.lblTotalSale.Size = new System.Drawing.Size(54, 23);
            this.lblTotalSale.TabIndex = 17;
            this.lblTotalSale.Text = "0.00";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Cooper Black", 12F);
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(15, 55);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(200, 23);
            this.label9.TabIndex = 16;
            this.label9.Text = "Total Comprado S/";
            // 
            // txtAmountPay
            // 
            this.txtAmountPay.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold);
            this.txtAmountPay.ForeColor = System.Drawing.Color.Black;
            this.txtAmountPay.Location = new System.Drawing.Point(280, 148);
            this.txtAmountPay.MaxLength = 8;
            this.txtAmountPay.Name = "txtAmountPay";
            this.txtAmountPay.Size = new System.Drawing.Size(133, 31);
            this.txtAmountPay.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Cooper Black", 12F);
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(15, 151);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(229, 23);
            this.label7.TabIndex = 14;
            this.label7.Text = "Cantidad a Amortizar";
            // 
            // lblDebt
            // 
            this.lblDebt.AutoSize = true;
            this.lblDebt.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold);
            this.lblDebt.ForeColor = System.Drawing.Color.Black;
            this.lblDebt.Location = new System.Drawing.Point(142, 101);
            this.lblDebt.Name = "lblDebt";
            this.lblDebt.Size = new System.Drawing.Size(54, 23);
            this.lblDebt.TabIndex = 13;
            this.lblDebt.Text = "0.00";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cooper Black", 12F);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(15, 101);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 23);
            this.label6.TabIndex = 12;
            this.label6.Text = "Deuda S/";
            // 
            // lblIdDebt
            // 
            this.lblIdDebt.AutoSize = true;
            this.lblIdDebt.Font = new System.Drawing.Font("Cooper Black", 12F);
            this.lblIdDebt.ForeColor = System.Drawing.Color.Black;
            this.lblIdDebt.Location = new System.Drawing.Point(142, 11);
            this.lblIdDebt.Name = "lblIdDebt";
            this.lblIdDebt.Size = new System.Drawing.Size(34, 23);
            this.lblIdDebt.TabIndex = 11;
            this.lblIdDebt.Text = "----";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cooper Black", 12F);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(15, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 23);
            this.label3.TabIndex = 10;
            this.label3.Text = "ID Deuda";
            // 
            // btnAmortizar
            // 
            this.btnAmortizar.AutoSize = true;
            this.btnAmortizar.Font = new System.Drawing.Font("Cooper Black", 16F);
            this.btnAmortizar.ForeColor = System.Drawing.Color.Black;
            this.btnAmortizar.Location = new System.Drawing.Point(90, 219);
            this.btnAmortizar.Name = "btnAmortizar";
            this.btnAmortizar.Size = new System.Drawing.Size(262, 41);
            this.btnAmortizar.TabIndex = 9;
            this.btnAmortizar.Text = "Amortizar Deuda";
            this.btnAmortizar.UseVisualStyleBackColor = true;
            this.btnAmortizar.Click += new System.EventHandler(this.btnAmortizar_Click);
            // 
            // FormUpdateBebt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1132, 553);
            this.Controls.Add(this.pnlAmortizar);
            this.Controls.Add(this.btnSearchDNI);
            this.Controls.Add(this.lblNameClient);
            this.Controls.Add(this.dgvTableAllDebtForCustomer);
            this.Controls.Add(this.btnCloseFormUpdateDebt);
            this.Controls.Add(this.txtDNIClient);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1150, 600);
            this.MinimumSize = new System.Drawing.Size(1150, 600);
            this.Name = "FormUpdateBebt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscar / Actualizar Deudas ~ BODEGA SAC";
            this.Load += new System.EventHandler(this.FormUpdateBebt_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTableAllDebtForCustomer)).EndInit();
            this.pnlAmortizar.ResumeLayout(false);
            this.pnlAmortizar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTableAllDebtForCustomer;
        private System.Windows.Forms.Button btnCloseFormUpdateDebt;
        private System.Windows.Forms.TextBox txtDNIClient;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNameClient;
        private System.Windows.Forms.Button btnSearchDNI;
        private System.Windows.Forms.Panel pnlAmortizar;
        private System.Windows.Forms.Button btnAmortizar;
        private System.Windows.Forms.Label lblIdDebt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblDebt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAmountPay;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblTotalSale;
        private System.Windows.Forms.Label label9;
    }
}