
namespace BODEGA_SAC
{
    partial class FormListDebt
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
            this.dgvTableAllDebt = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTotalDebt = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnCloseFormListDebt = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTableAllDebt)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTableAllDebt
            // 
            this.dgvTableAllDebt.AllowUserToAddRows = false;
            this.dgvTableAllDebt.AllowUserToDeleteRows = false;
            this.dgvTableAllDebt.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvTableAllDebt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTableAllDebt.Location = new System.Drawing.Point(12, 75);
            this.dgvTableAllDebt.MultiSelect = false;
            this.dgvTableAllDebt.Name = "dgvTableAllDebt";
            this.dgvTableAllDebt.ReadOnly = true;
            this.dgvTableAllDebt.RowHeadersVisible = false;
            this.dgvTableAllDebt.RowHeadersWidth = 31;
            this.dgvTableAllDebt.RowTemplate.Height = 24;
            this.dgvTableAllDebt.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTableAllDebt.Size = new System.Drawing.Size(805, 350);
            this.dgvTableAllDebt.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 26F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(805, 63);
            this.label1.TabIndex = 9;
            this.label1.Text = "Listado de Deudas";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotalDebt
            // 
            this.lblTotalDebt.AutoSize = true;
            this.lblTotalDebt.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold);
            this.lblTotalDebt.ForeColor = System.Drawing.Color.Black;
            this.lblTotalDebt.Location = new System.Drawing.Point(451, 499);
            this.lblTotalDebt.Name = "lblTotalDebt";
            this.lblTotalDebt.Size = new System.Drawing.Size(79, 36);
            this.lblTotalDebt.TabIndex = 19;
            this.lblTotalDebt.Text = "0.00";
            this.lblTotalDebt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Cooper Black", 18F);
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(12, 499);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(370, 35);
            this.label9.TabIndex = 18;
            this.label9.Text = "Monto Total Deudas S/.";
            // 
            // btnCloseFormListDebt
            // 
            this.btnCloseFormListDebt.AutoSize = true;
            this.btnCloseFormListDebt.Font = new System.Drawing.Font("Cooper Black", 16F);
            this.btnCloseFormListDebt.ForeColor = System.Drawing.Color.Black;
            this.btnCloseFormListDebt.Location = new System.Drawing.Point(681, 493);
            this.btnCloseFormListDebt.Name = "btnCloseFormListDebt";
            this.btnCloseFormListDebt.Size = new System.Drawing.Size(114, 41);
            this.btnCloseFormListDebt.TabIndex = 20;
            this.btnCloseFormListDebt.Text = "Cerrar";
            this.btnCloseFormListDebt.UseVisualStyleBackColor = true;
            this.btnCloseFormListDebt.Click += new System.EventHandler(this.btnCloseFormListDebt_Click);
            // 
            // FormListDebt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 553);
            this.Controls.Add(this.btnCloseFormListDebt);
            this.Controls.Add(this.lblTotalDebt);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvTableAllDebt);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(847, 600);
            this.MinimumSize = new System.Drawing.Size(847, 600);
            this.Name = "FormListDebt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listado de Deudas ~ BODEGA SAC";
            this.Load += new System.EventHandler(this.FormListDebt_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTableAllDebt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTableAllDebt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTotalDebt;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnCloseFormListDebt;
    }
}