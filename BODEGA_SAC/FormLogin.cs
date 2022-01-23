using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BODEGA_SAC.Model;
using BODEGA_SAC.utils;

namespace BODEGA_SAC
{
    public partial class FormLogin : Form
    {
        private TB_EMPLOYEE dataEmployeeForm;
        public FormLogin()
        {
            InitializeComponent();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            txtUserLogin.Text = "";
            txtPasswordLogin.Text = "admin123";
            txtUserLogin.Focus();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            string user = txtUserLogin.Text;
            string password = txtPasswordLogin.Text;
            ValidateFormLogin(user, password);
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void ValidateFormLogin(string user, string password)
        {
            if (user.Trim() == null || user.Trim() == "")
            {
                MessageBox.Show("Ingrese un Usuario.");
                txtUserLogin.Focus();
            }
            else if (password.Trim() == null || password.Trim() == "")
            {
                MessageBox.Show("Ingrese su Contraseña.");
                txtPasswordLogin.Focus();
            }
            else
            {
                if(ValidateLogin(user, Tools.Encrypt(password)))
                {
                    this.Hide();
                    MDI_BODEGA_SAC mdi_Admin = new MDI_BODEGA_SAC(this.dataEmployeeForm);
                    mdi_Admin.Show();
                }
                else
                {
                    MessageBox.Show("Credenciales Incorrectas");
                    txtUserLogin.Focus();
                }
            }
        }
        private TB_LOGIN_EMPLOYEE GetLoginService(string user, string password)
        {
            TB_LOGIN_EMPLOYEE login = new TB_LOGIN_EMPLOYEE();            
            try
            {
                using (BODEGA_SACEntities db = new BODEGA_SACEntities())
                {
                    var datalogin = (from log in db.TB_LOGIN_EMPLOYEE
                                     where log.USER_EMPLOYEE.Equals(user) && log.PASSWORD_EMPLOYEE.Equals(password)
                                     select log);
                    login = datalogin.FirstOrDefault();
                    return login;
                }
            }catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return null;
        }
        private TB_EMPLOYEE GetLoginEmployee(TB_LOGIN_EMPLOYEE login)
        {
            TB_EMPLOYEE employe = new TB_EMPLOYEE();
            try
            {
                if (login != null)
                {
                    using (BODEGA_SACEntities db = new BODEGA_SACEntities())
                    {
                        var data = (from emple in db.TB_EMPLOYEE
                                    where emple.ID_EMPLOYEE.Equals(login.ID_EMPLOYEE) && emple.STATUS_EMPLOYEE.Equals(1)
                                    select emple);
                        employe = data.FirstOrDefault();
                        return employe;
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

            return null;
        }
        private bool ValidateLogin(string user, string password)
        {
            TB_LOGIN_EMPLOYEE login = GetLoginService(user, password);
            TB_EMPLOYEE employe = GetLoginEmployee(login);
            if (login!=null && employe != null)
            {
                this.dataEmployeeForm = employe;
                return true;
            }
            return false;
        }

        private void txtUserLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtPasswordLogin.Focus();
            }
        }

        private void txtPasswordLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btnLogIn.Focus();
            }
        }
    }
}
