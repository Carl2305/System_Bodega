
namespace BODEGA_SAC
{
    partial class FormMyProfile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMyProfile));
            this.label1 = new System.Windows.Forms.Label();
            this.lblName_LastName = new System.Windows.Forms.Label();
            this.lblRoleEmployee = new System.Windows.Forms.Label();
            this.lblDNI = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnCloseFormMyProfile = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 26F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(12, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(522, 63);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mi perfil";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblName_LastName
            // 
            this.lblName_LastName.Font = new System.Drawing.Font("Cooper Black", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName_LastName.ForeColor = System.Drawing.Color.Black;
            this.lblName_LastName.Location = new System.Drawing.Point(12, 142);
            this.lblName_LastName.Name = "lblName_LastName";
            this.lblName_LastName.Size = new System.Drawing.Size(522, 38);
            this.lblName_LastName.TabIndex = 2;
            this.lblName_LastName.Text = "Nombres y Apellidos";
            this.lblName_LastName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRoleEmployee
            // 
            this.lblRoleEmployee.Font = new System.Drawing.Font("Cooper Black", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoleEmployee.ForeColor = System.Drawing.Color.Black;
            this.lblRoleEmployee.Location = new System.Drawing.Point(12, 206);
            this.lblRoleEmployee.Name = "lblRoleEmployee";
            this.lblRoleEmployee.Size = new System.Drawing.Size(522, 38);
            this.lblRoleEmployee.TabIndex = 3;
            this.lblRoleEmployee.Text = "Cargo";
            this.lblRoleEmployee.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDNI
            // 
            this.lblDNI.Font = new System.Drawing.Font("Cooper Black", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDNI.ForeColor = System.Drawing.Color.Black;
            this.lblDNI.Location = new System.Drawing.Point(12, 271);
            this.lblDNI.Name = "lblDNI";
            this.lblDNI.Size = new System.Drawing.Size(522, 38);
            this.lblDNI.TabIndex = 4;
            this.lblDNI.Text = "DNI";
            this.lblDNI.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(540, 63);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(248, 246);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnCloseFormMyProfile
            // 
            this.btnCloseFormMyProfile.AutoSize = true;
            this.btnCloseFormMyProfile.Font = new System.Drawing.Font("Cooper Black", 15F);
            this.btnCloseFormMyProfile.ForeColor = System.Drawing.Color.Black;
            this.btnCloseFormMyProfile.Location = new System.Drawing.Point(630, 391);
            this.btnCloseFormMyProfile.Name = "btnCloseFormMyProfile";
            this.btnCloseFormMyProfile.Size = new System.Drawing.Size(134, 39);
            this.btnCloseFormMyProfile.TabIndex = 9;
            this.btnCloseFormMyProfile.Text = "Cerrar";
            this.btnCloseFormMyProfile.UseVisualStyleBackColor = true;
            this.btnCloseFormMyProfile.Click += new System.EventHandler(this.btnCloseFormMyProfile_Click);
            // 
            // FormMyProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 442);
            this.Controls.Add(this.btnCloseFormMyProfile);
            this.Controls.Add(this.lblDNI);
            this.Controls.Add(this.lblRoleEmployee);
            this.Controls.Add(this.lblName_LastName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(818, 489);
            this.MinimumSize = new System.Drawing.Size(818, 489);
            this.Name = "FormMyProfile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MI PERFIL ~ BODEGA SAC";
            this.Load += new System.EventHandler(this.FormMyProfile_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblName_LastName;
        private System.Windows.Forms.Label lblRoleEmployee;
        private System.Windows.Forms.Label lblDNI;
        private System.Windows.Forms.Button btnCloseFormMyProfile;
    }
}