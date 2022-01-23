
namespace BODEGA_SAC
{
    partial class FormLogin
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.lblTitleLogin = new System.Windows.Forms.Label();
            this.lblUserLogin = new System.Windows.Forms.Label();
            this.lblPasswordLogin = new System.Windows.Forms.Label();
            this.txtPasswordLogin = new System.Windows.Forms.TextBox();
            this.btnLogIn = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.txtUserLogin = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblTitleLogin
            // 
            this.lblTitleLogin.Font = new System.Drawing.Font("Cooper Black", 26F);
            this.lblTitleLogin.Location = new System.Drawing.Point(12, 9);
            this.lblTitleLogin.Name = "lblTitleLogin";
            this.lblTitleLogin.Size = new System.Drawing.Size(538, 95);
            this.lblTitleLogin.TabIndex = 0;
            this.lblTitleLogin.Text = "Bienvenido";
            this.lblTitleLogin.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // lblUserLogin
            // 
            this.lblUserLogin.Font = new System.Drawing.Font("Cooper Black", 14F);
            this.lblUserLogin.ForeColor = System.Drawing.Color.Black;
            this.lblUserLogin.Location = new System.Drawing.Point(12, 151);
            this.lblUserLogin.Name = "lblUserLogin";
            this.lblUserLogin.Size = new System.Drawing.Size(205, 27);
            this.lblUserLogin.TabIndex = 1;
            this.lblUserLogin.Text = "Usuario";
            this.lblUserLogin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPasswordLogin
            // 
            this.lblPasswordLogin.Font = new System.Drawing.Font("Cooper Black", 14F);
            this.lblPasswordLogin.ForeColor = System.Drawing.Color.Black;
            this.lblPasswordLogin.Location = new System.Drawing.Point(15, 202);
            this.lblPasswordLogin.Name = "lblPasswordLogin";
            this.lblPasswordLogin.Size = new System.Drawing.Size(202, 27);
            this.lblPasswordLogin.TabIndex = 3;
            this.lblPasswordLogin.Text = "Contraseña";
            this.lblPasswordLogin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtPasswordLogin
            // 
            this.txtPasswordLogin.Font = new System.Drawing.Font("Cooper Black", 14F);
            this.txtPasswordLogin.ForeColor = System.Drawing.Color.Black;
            this.txtPasswordLogin.Location = new System.Drawing.Point(255, 199);
            this.txtPasswordLogin.Name = "txtPasswordLogin";
            this.txtPasswordLogin.Size = new System.Drawing.Size(254, 34);
            this.txtPasswordLogin.TabIndex = 4;
            this.txtPasswordLogin.Text = "admin";
            this.txtPasswordLogin.UseSystemPasswordChar = true;
            this.txtPasswordLogin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPasswordLogin_KeyPress);
            // 
            // btnLogIn
            // 
            this.btnLogIn.AutoSize = true;
            this.btnLogIn.Font = new System.Drawing.Font("Cooper Black", 14F);
            this.btnLogIn.ForeColor = System.Drawing.Color.Black;
            this.btnLogIn.Location = new System.Drawing.Point(92, 278);
            this.btnLogIn.Name = "btnLogIn";
            this.btnLogIn.Size = new System.Drawing.Size(125, 37);
            this.btnLogIn.TabIndex = 5;
            this.btnLogIn.Text = "Ingresar";
            this.btnLogIn.UseVisualStyleBackColor = true;
            this.btnLogIn.Click += new System.EventHandler(this.btnLogIn_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.AutoSize = true;
            this.btnLogOut.Font = new System.Drawing.Font("Cooper Black", 14F);
            this.btnLogOut.ForeColor = System.Drawing.Color.Black;
            this.btnLogOut.Location = new System.Drawing.Point(350, 278);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(125, 37);
            this.btnLogOut.TabIndex = 6;
            this.btnLogOut.Text = "Salir";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // txtUserLogin
            // 
            this.txtUserLogin.Font = new System.Drawing.Font("Cooper Black", 14F);
            this.txtUserLogin.ForeColor = System.Drawing.Color.Black;
            this.txtUserLogin.Location = new System.Drawing.Point(255, 148);
            this.txtUserLogin.Name = "txtUserLogin";
            this.txtUserLogin.Size = new System.Drawing.Size(254, 34);
            this.txtUserLogin.TabIndex = 2;
            this.txtUserLogin.Text = "Admin";
            this.txtUserLogin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUserLogin_KeyPress);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 353);
            this.Controls.Add(this.txtUserLogin);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.btnLogIn);
            this.Controls.Add(this.txtPasswordLogin);
            this.Controls.Add(this.lblPasswordLogin);
            this.Controls.Add(this.lblUserLogin);
            this.Controls.Add(this.lblTitleLogin);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(580, 400);
            this.MinimumSize = new System.Drawing.Size(580, 400);
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LOGIN";
            this.Load += new System.EventHandler(this.FormLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitleLogin;
        private System.Windows.Forms.Label lblUserLogin;
        private System.Windows.Forms.Label lblPasswordLogin;
        private System.Windows.Forms.TextBox txtPasswordLogin;
        private System.Windows.Forms.Button btnLogIn;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.TextBox txtUserLogin;
    }
}

