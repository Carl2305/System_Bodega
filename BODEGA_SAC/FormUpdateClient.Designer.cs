
namespace BODEGA_SAC
{
    partial class FormUpdateClient
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
            this.btnCloseFormRegisterClient = new System.Windows.Forms.Button();
            this.btnRegisterClient = new System.Windows.Forms.Button();
            this.txtDNIClient = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNameClient = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvTableAllClient = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTableAllClient)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCloseFormRegisterClient
            // 
            this.btnCloseFormRegisterClient.AutoSize = true;
            this.btnCloseFormRegisterClient.Font = new System.Drawing.Font("Cooper Black", 15F);
            this.btnCloseFormRegisterClient.ForeColor = System.Drawing.Color.Black;
            this.btnCloseFormRegisterClient.Location = new System.Drawing.Point(587, 141);
            this.btnCloseFormRegisterClient.Name = "btnCloseFormRegisterClient";
            this.btnCloseFormRegisterClient.Size = new System.Drawing.Size(107, 39);
            this.btnCloseFormRegisterClient.TabIndex = 16;
            this.btnCloseFormRegisterClient.Text = "Cerrar";
            this.btnCloseFormRegisterClient.UseVisualStyleBackColor = true;
            this.btnCloseFormRegisterClient.Click += new System.EventHandler(this.btnCloseFormRegisterClient_Click);
            // 
            // btnRegisterClient
            // 
            this.btnRegisterClient.AutoSize = true;
            this.btnRegisterClient.Font = new System.Drawing.Font("Cooper Black", 15F);
            this.btnRegisterClient.ForeColor = System.Drawing.Color.Black;
            this.btnRegisterClient.Location = new System.Drawing.Point(389, 141);
            this.btnRegisterClient.Name = "btnRegisterClient";
            this.btnRegisterClient.Size = new System.Drawing.Size(158, 39);
            this.btnRegisterClient.TabIndex = 15;
            this.btnRegisterClient.Text = "Actualizar";
            this.btnRegisterClient.UseVisualStyleBackColor = true;
            this.btnRegisterClient.Click += new System.EventHandler(this.btnRegisterClient_Click);
            // 
            // txtDNIClient
            // 
            this.txtDNIClient.Font = new System.Drawing.Font("Cooper Black", 13F);
            this.txtDNIClient.ForeColor = System.Drawing.Color.Black;
            this.txtDNIClient.Location = new System.Drawing.Point(179, 146);
            this.txtDNIClient.MaxLength = 8;
            this.txtDNIClient.Name = "txtDNIClient";
            this.txtDNIClient.ReadOnly = true;
            this.txtDNIClient.Size = new System.Drawing.Size(156, 32);
            this.txtDNIClient.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cooper Black", 13F);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(12, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 25);
            this.label3.TabIndex = 13;
            this.label3.Text = "DNI Cliente";
            // 
            // txtNameClient
            // 
            this.txtNameClient.Font = new System.Drawing.Font("Cooper Black", 13F);
            this.txtNameClient.ForeColor = System.Drawing.Color.Black;
            this.txtNameClient.Location = new System.Drawing.Point(179, 89);
            this.txtNameClient.Name = "txtNameClient";
            this.txtNameClient.ReadOnly = true;
            this.txtNameClient.Size = new System.Drawing.Size(525, 32);
            this.txtNameClient.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cooper Black", 13F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(12, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 25);
            this.label2.TabIndex = 11;
            this.label2.Text = "Nombres ";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Cooper Black", 20F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(708, 61);
            this.label1.TabIndex = 10;
            this.label1.Text = "Actualizar Cliente";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvTableAllClient
            // 
            this.dgvTableAllClient.AllowUserToAddRows = false;
            this.dgvTableAllClient.AllowUserToDeleteRows = false;
            this.dgvTableAllClient.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTableAllClient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTableAllClient.Location = new System.Drawing.Point(12, 206);
            this.dgvTableAllClient.MultiSelect = false;
            this.dgvTableAllClient.Name = "dgvTableAllClient";
            this.dgvTableAllClient.ReadOnly = true;
            this.dgvTableAllClient.RowHeadersWidth = 51;
            this.dgvTableAllClient.RowTemplate.Height = 24;
            this.dgvTableAllClient.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTableAllClient.Size = new System.Drawing.Size(708, 185);
            this.dgvTableAllClient.TabIndex = 17;
            this.dgvTableAllClient.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTableAllClient_CellClick);
            // 
            // FormUpdateClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 403);
            this.Controls.Add(this.dgvTableAllClient);
            this.Controls.Add(this.btnCloseFormRegisterClient);
            this.Controls.Add(this.btnRegisterClient);
            this.Controls.Add(this.txtDNIClient);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNameClient);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(750, 450);
            this.MinimumSize = new System.Drawing.Size(750, 450);
            this.Name = "FormUpdateClient";
            this.Text = "Actualizar Cliente ~ BODEGA SAC";
            this.Load += new System.EventHandler(this.FormUpdateClient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTableAllClient)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCloseFormRegisterClient;
        private System.Windows.Forms.Button btnRegisterClient;
        private System.Windows.Forms.TextBox txtDNIClient;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNameClient;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvTableAllClient;
    }
}