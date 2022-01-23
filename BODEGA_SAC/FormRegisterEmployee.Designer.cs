
namespace BODEGA_SAC
{
    partial class FormRegisterEmployee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRegisterEmployee));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNameEmployee = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLastNameEmployee = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDniEmployee = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtUserEmployee = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnRegisterEmployee = new System.Windows.Forms.Button();
            this.btnCloseFormRegisterEmployee = new System.Windows.Forms.Button();
            this.dgvTableAllEmployees = new System.Windows.Forms.DataGridView();
            this.cboRoleEmployee = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTableAllEmployees)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 26F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1058, 63);
            this.label1.TabIndex = 0;
            this.label1.Text = "Registro de Nuevos Empleados";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cooper Black", 12F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(17, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombres";
            // 
            // txtNameEmployee
            // 
            this.txtNameEmployee.Font = new System.Drawing.Font("Cooper Black", 12F);
            this.txtNameEmployee.ForeColor = System.Drawing.Color.Black;
            this.txtNameEmployee.Location = new System.Drawing.Point(137, 110);
            this.txtNameEmployee.Name = "txtNameEmployee";
            this.txtNameEmployee.Size = new System.Drawing.Size(335, 30);
            this.txtNameEmployee.TabIndex = 2;
            this.txtNameEmployee.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNameEmployee_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cooper Black", 12F);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(563, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "Apellidos";
            // 
            // txtLastNameEmployee
            // 
            this.txtLastNameEmployee.Font = new System.Drawing.Font("Cooper Black", 12F);
            this.txtLastNameEmployee.ForeColor = System.Drawing.Color.Black;
            this.txtLastNameEmployee.Location = new System.Drawing.Point(712, 114);
            this.txtLastNameEmployee.Name = "txtLastNameEmployee";
            this.txtLastNameEmployee.Size = new System.Drawing.Size(335, 30);
            this.txtLastNameEmployee.TabIndex = 4;
            this.txtLastNameEmployee.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLastNameEmployee_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cooper Black", 12F);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(17, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 23);
            this.label4.TabIndex = 5;
            this.label4.Text = "Doc. Identidad";
            // 
            // txtDniEmployee
            // 
            this.txtDniEmployee.Font = new System.Drawing.Font("Cooper Black", 12F);
            this.txtDniEmployee.ForeColor = System.Drawing.Color.Black;
            this.txtDniEmployee.Location = new System.Drawing.Point(194, 174);
            this.txtDniEmployee.Name = "txtDniEmployee";
            this.txtDniEmployee.Size = new System.Drawing.Size(220, 30);
            this.txtDniEmployee.TabIndex = 6;
            this.txtDniEmployee.Click += new System.EventHandler(this.txtDniEmployee_Click);
            this.txtDniEmployee.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDniEmployee_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cooper Black", 12F);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(443, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 23);
            this.label5.TabIndex = 14;
            this.label5.Text = "Usuario";
            // 
            // txtUserEmployee
            // 
            this.txtUserEmployee.Font = new System.Drawing.Font("Cooper Black", 12F);
            this.txtUserEmployee.ForeColor = System.Drawing.Color.Black;
            this.txtUserEmployee.Location = new System.Drawing.Point(567, 174);
            this.txtUserEmployee.Name = "txtUserEmployee";
            this.txtUserEmployee.ReadOnly = true;
            this.txtUserEmployee.Size = new System.Drawing.Size(291, 30);
            this.txtUserEmployee.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cooper Black", 12F);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(17, 238);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 23);
            this.label6.TabIndex = 7;
            this.label6.Text = "Cargo";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Cooper Black", 12F);
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(443, 238);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(125, 23);
            this.label7.TabIndex = 9;
            this.label7.Text = "Contraseña";
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Cooper Black", 12F);
            this.txtPassword.ForeColor = System.Drawing.Color.Black;
            this.txtPassword.Location = new System.Drawing.Point(609, 235);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(249, 30);
            this.txtPassword.TabIndex = 10;
            this.txtPassword.UseSystemPasswordChar = true;
            this.txtPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtConfirmPassword_KeyPress);
            // 
            // btnRegisterEmployee
            // 
            this.btnRegisterEmployee.AutoSize = true;
            this.btnRegisterEmployee.Font = new System.Drawing.Font("Cooper Black", 16F);
            this.btnRegisterEmployee.ForeColor = System.Drawing.Color.Black;
            this.btnRegisterEmployee.Location = new System.Drawing.Point(893, 174);
            this.btnRegisterEmployee.Name = "btnRegisterEmployee";
            this.btnRegisterEmployee.Size = new System.Drawing.Size(154, 41);
            this.btnRegisterEmployee.TabIndex = 11;
            this.btnRegisterEmployee.Text = "Registrar";
            this.btnRegisterEmployee.UseVisualStyleBackColor = true;
            this.btnRegisterEmployee.Click += new System.EventHandler(this.btnRegisterEmployee_Click);
            // 
            // btnCloseFormRegisterEmployee
            // 
            this.btnCloseFormRegisterEmployee.AutoSize = true;
            this.btnCloseFormRegisterEmployee.Font = new System.Drawing.Font("Cooper Black", 16F);
            this.btnCloseFormRegisterEmployee.ForeColor = System.Drawing.Color.Black;
            this.btnCloseFormRegisterEmployee.Location = new System.Drawing.Point(933, 226);
            this.btnCloseFormRegisterEmployee.Name = "btnCloseFormRegisterEmployee";
            this.btnCloseFormRegisterEmployee.Size = new System.Drawing.Size(114, 41);
            this.btnCloseFormRegisterEmployee.TabIndex = 12;
            this.btnCloseFormRegisterEmployee.Text = "Cerrar";
            this.btnCloseFormRegisterEmployee.UseVisualStyleBackColor = true;
            this.btnCloseFormRegisterEmployee.Click += new System.EventHandler(this.btnCloseFormRegisterEmployee_Click);
            // 
            // dgvTableAllEmployees
            // 
            this.dgvTableAllEmployees.AllowUserToAddRows = false;
            this.dgvTableAllEmployees.AllowUserToDeleteRows = false;
            this.dgvTableAllEmployees.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTableAllEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTableAllEmployees.Location = new System.Drawing.Point(12, 306);
            this.dgvTableAllEmployees.MultiSelect = false;
            this.dgvTableAllEmployees.Name = "dgvTableAllEmployees";
            this.dgvTableAllEmployees.ReadOnly = true;
            this.dgvTableAllEmployees.RowHeadersWidth = 51;
            this.dgvTableAllEmployees.RowTemplate.Height = 24;
            this.dgvTableAllEmployees.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvTableAllEmployees.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTableAllEmployees.Size = new System.Drawing.Size(1058, 435);
            this.dgvTableAllEmployees.TabIndex = 13;
            // 
            // cboRoleEmployee
            // 
            this.cboRoleEmployee.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRoleEmployee.Font = new System.Drawing.Font("Cooper Black", 12F);
            this.cboRoleEmployee.ForeColor = System.Drawing.Color.Black;
            this.cboRoleEmployee.FormattingEnabled = true;
            this.cboRoleEmployee.Location = new System.Drawing.Point(115, 235);
            this.cboRoleEmployee.Name = "cboRoleEmployee";
            this.cboRoleEmployee.Size = new System.Drawing.Size(299, 31);
            this.cboRoleEmployee.TabIndex = 8;
            // 
            // FormRegisterEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 753);
            this.Controls.Add(this.cboRoleEmployee);
            this.Controls.Add(this.dgvTableAllEmployees);
            this.Controls.Add(this.btnCloseFormRegisterEmployee);
            this.Controls.Add(this.btnRegisterEmployee);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtUserEmployee);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtDniEmployee);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtLastNameEmployee);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNameEmployee);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1100, 800);
            this.MinimumSize = new System.Drawing.Size(1100, 800);
            this.Name = "FormRegisterEmployee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrar Empleado ~ BODEGA SAC";
            this.Load += new System.EventHandler(this.FormRegisterEmployee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTableAllEmployees)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNameEmployee;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtLastNameEmployee;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDniEmployee;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtUserEmployee;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnRegisterEmployee;
        private System.Windows.Forms.Button btnCloseFormRegisterEmployee;
        private System.Windows.Forms.DataGridView dgvTableAllEmployees;
        private System.Windows.Forms.ComboBox cboRoleEmployee;
    }
}