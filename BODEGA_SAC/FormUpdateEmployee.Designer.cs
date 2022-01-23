
namespace BODEGA_SAC
{
    partial class FormUpdateEmployee
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
            this.cboRoleEmployee = new System.Windows.Forms.ComboBox();
            this.dgvTableAllEmployees = new System.Windows.Forms.DataGridView();
            this.btnCloseFormUpdateEmployee = new System.Windows.Forms.Button();
            this.btnUpdateEmployee = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDniEmployee = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtLastNameEmployee = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNameEmployee = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTableAllEmployees)).BeginInit();
            this.SuspendLayout();
            // 
            // cboRoleEmployee
            // 
            this.cboRoleEmployee.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRoleEmployee.Font = new System.Drawing.Font("Cooper Black", 12F);
            this.cboRoleEmployee.ForeColor = System.Drawing.Color.Black;
            this.cboRoleEmployee.FormattingEnabled = true;
            this.cboRoleEmployee.Location = new System.Drawing.Point(685, 175);
            this.cboRoleEmployee.Name = "cboRoleEmployee";
            this.cboRoleEmployee.Size = new System.Drawing.Size(362, 31);
            this.cboRoleEmployee.TabIndex = 22;
            // 
            // dgvTableAllEmployees
            // 
            this.dgvTableAllEmployees.AllowUserToAddRows = false;
            this.dgvTableAllEmployees.AllowUserToDeleteRows = false;
            this.dgvTableAllEmployees.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTableAllEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTableAllEmployees.Location = new System.Drawing.Point(12, 307);
            this.dgvTableAllEmployees.MultiSelect = false;
            this.dgvTableAllEmployees.Name = "dgvTableAllEmployees";
            this.dgvTableAllEmployees.ReadOnly = true;
            this.dgvTableAllEmployees.RowHeadersWidth = 51;
            this.dgvTableAllEmployees.RowTemplate.Height = 24;
            this.dgvTableAllEmployees.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvTableAllEmployees.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTableAllEmployees.Size = new System.Drawing.Size(1058, 435);
            this.dgvTableAllEmployees.TabIndex = 25;
            this.dgvTableAllEmployees.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTableAllEmployees_CellClick);
            // 
            // btnCloseFormUpdateEmployee
            // 
            this.btnCloseFormUpdateEmployee.AutoSize = true;
            this.btnCloseFormUpdateEmployee.Font = new System.Drawing.Font("Cooper Black", 16F);
            this.btnCloseFormUpdateEmployee.ForeColor = System.Drawing.Color.Black;
            this.btnCloseFormUpdateEmployee.Location = new System.Drawing.Point(933, 227);
            this.btnCloseFormUpdateEmployee.Name = "btnCloseFormUpdateEmployee";
            this.btnCloseFormUpdateEmployee.Size = new System.Drawing.Size(114, 41);
            this.btnCloseFormUpdateEmployee.TabIndex = 24;
            this.btnCloseFormUpdateEmployee.Text = "Cerrar";
            this.btnCloseFormUpdateEmployee.UseVisualStyleBackColor = true;
            this.btnCloseFormUpdateEmployee.Click += new System.EventHandler(this.btnCloseFormUpdateEmployee_Click);
            // 
            // btnUpdateEmployee
            // 
            this.btnUpdateEmployee.AutoSize = true;
            this.btnUpdateEmployee.Font = new System.Drawing.Font("Cooper Black", 16F);
            this.btnUpdateEmployee.ForeColor = System.Drawing.Color.Black;
            this.btnUpdateEmployee.Location = new System.Drawing.Point(733, 227);
            this.btnUpdateEmployee.Name = "btnUpdateEmployee";
            this.btnUpdateEmployee.Size = new System.Drawing.Size(154, 41);
            this.btnUpdateEmployee.TabIndex = 23;
            this.btnUpdateEmployee.Text = "Actulizar";
            this.btnUpdateEmployee.UseVisualStyleBackColor = true;
            this.btnUpdateEmployee.Click += new System.EventHandler(this.btnUpdateEmployee_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cooper Black", 12F);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(563, 178);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 23);
            this.label6.TabIndex = 21;
            this.label6.Text = "Cargo";
            // 
            // txtDniEmployee
            // 
            this.txtDniEmployee.Font = new System.Drawing.Font("Cooper Black", 12F);
            this.txtDniEmployee.ForeColor = System.Drawing.Color.Black;
            this.txtDniEmployee.Location = new System.Drawing.Point(194, 175);
            this.txtDniEmployee.Name = "txtDniEmployee";
            this.txtDniEmployee.ReadOnly = true;
            this.txtDniEmployee.Size = new System.Drawing.Size(278, 30);
            this.txtDniEmployee.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cooper Black", 12F);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(17, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 23);
            this.label4.TabIndex = 19;
            this.label4.Text = "Doc. Identidad";
            // 
            // txtLastNameEmployee
            // 
            this.txtLastNameEmployee.Font = new System.Drawing.Font("Cooper Black", 12F);
            this.txtLastNameEmployee.ForeColor = System.Drawing.Color.Black;
            this.txtLastNameEmployee.Location = new System.Drawing.Point(712, 115);
            this.txtLastNameEmployee.Name = "txtLastNameEmployee";
            this.txtLastNameEmployee.ReadOnly = true;
            this.txtLastNameEmployee.Size = new System.Drawing.Size(335, 30);
            this.txtLastNameEmployee.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cooper Black", 12F);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(563, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 23);
            this.label3.TabIndex = 17;
            this.label3.Text = "Apellidos";
            // 
            // txtNameEmployee
            // 
            this.txtNameEmployee.Font = new System.Drawing.Font("Cooper Black", 12F);
            this.txtNameEmployee.ForeColor = System.Drawing.Color.Black;
            this.txtNameEmployee.Location = new System.Drawing.Point(137, 111);
            this.txtNameEmployee.Name = "txtNameEmployee";
            this.txtNameEmployee.ReadOnly = true;
            this.txtNameEmployee.Size = new System.Drawing.Size(335, 30);
            this.txtNameEmployee.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cooper Black", 12F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(17, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 23);
            this.label2.TabIndex = 15;
            this.label2.Text = "Nombres";
            // 
            // label1
            // 
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 26F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1058, 63);
            this.label1.TabIndex = 14;
            this.label1.Text = "Actualizar Empleados";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormUpdateEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 753);
            this.Controls.Add(this.cboRoleEmployee);
            this.Controls.Add(this.dgvTableAllEmployees);
            this.Controls.Add(this.btnCloseFormUpdateEmployee);
            this.Controls.Add(this.btnUpdateEmployee);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtDniEmployee);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtLastNameEmployee);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNameEmployee);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1100, 800);
            this.MinimumSize = new System.Drawing.Size(1100, 800);
            this.Name = "FormUpdateEmployee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Actualizar Empleados ~ BODEGA SAC";
            this.Load += new System.EventHandler(this.FormUpdateEmployee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTableAllEmployees)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboRoleEmployee;
        private System.Windows.Forms.DataGridView dgvTableAllEmployees;
        private System.Windows.Forms.Button btnCloseFormUpdateEmployee;
        private System.Windows.Forms.Button btnUpdateEmployee;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDniEmployee;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtLastNameEmployee;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNameEmployee;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}