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
    public partial class FormChangePassword : Form
    {
        private TB_EMPLOYEE DataemployeeForm;
        public FormChangePassword(TB_EMPLOYEE employee)
        {
            this.DataemployeeForm = employee;
            InitializeComponent();
            CleanFormChangePassword();
        }

        private void btnCloseFormChangePassword_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSaveNewPassword_Click(object sender, EventArgs e)
        {
            string oldpassword = txtOldPassword.Text;
            string newpassword = txtNewPassword.Text;
            string confpassword = txtConfirmPassword.Text;
            ValidateFormChangePassword(oldpassword,newpassword,confpassword);
        }
        private void ValidateFormChangePassword(string oldPass, string newPass, string confirmPass)
        {
            if (oldPass.Trim() == null || oldPass.Trim() == "")
            {
                MessageBox.Show("Ingrese su contraseña antigua.");
                txtOldPassword.Focus();
            }
            else if (newPass.Trim() == null || newPass.Trim() == "")
            {
                MessageBox.Show("Ingrese una contraseña Nueva.");
                txtNewPassword.Focus();
            }
            else if (confirmPass.Trim() == null || confirmPass.Trim() == "")
            {
                MessageBox.Show("Repita su contraseña Nueva.");
                txtConfirmPassword.Focus();
            }
            else
            {
                if (newPass.Trim().Equals(confirmPass.Trim()))
                {
                    if (Tools.Encrypt(oldPass.Trim()).Equals(GetPasswordLoginOldService()))
                    {
                        if (ChangePasswordUser(Tools.Encrypt(newPass)))
                        {
                            MessageBox.Show("El sistema será cerrado para guardar \n los cambios que se relizaron.", "Aviso de Cierre de Sessión", MessageBoxButtons.OK);
                            Application.Exit();
                        }
                        else
                        {
                            MessageBox.Show("Error! Intentelo más tarde.");
                            CleanFormChangePassword();
                        }
                    }
                    else
                    {
                        MessageBox.Show("La contraseña antigua no es correcta.");
                        txtOldPassword.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Las contraseñas no coinciden.");
                    txtConfirmPassword.Focus();
                }
            }
        }
        private string GetPasswordLoginOldService()
        {
            string pass = "";
            try
            {
                using (BODEGA_SACEntities db = new BODEGA_SACEntities())
                {
                    var datalogin = (from log in db.TB_LOGIN_EMPLOYEE
                                     where log.ID_EMPLOYEE.Equals(DataemployeeForm.ID_EMPLOYEE)
                                     select log.PASSWORD_EMPLOYEE);
                    pass = datalogin.FirstOrDefault();
                    return pass;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return "";
        }

        private int GetIdLoginService()
        {
            int IdLogin = 0;
            try
            {
                using (BODEGA_SACEntities db = new BODEGA_SACEntities())
                {
                    var datalogin = (from log in db.TB_LOGIN_EMPLOYEE
                                     where log.ID_EMPLOYEE.Equals(DataemployeeForm.ID_EMPLOYEE)
                                     select log.ID_LOGIN);
                    IdLogin = datalogin.FirstOrDefault();
                    return IdLogin;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return 0;
        }

        private bool ChangePasswordUser(string newPassword)
        {
            int IdLogin = GetIdLoginService();
            try
            {
                if (IdLogin != 0)
                {
                    using (BODEGA_SACEntities db = new BODEGA_SACEntities())
                    {
                        TB_LOGIN_EMPLOYEE dataLogin = db.TB_LOGIN_EMPLOYEE.Find(IdLogin);
                        dataLogin.PASSWORD_EMPLOYEE = newPassword;
                        db.Entry(dataLogin).State = System.Data.Entity.EntityState.Modified;
                        return db.SaveChanges() > 0;
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return false;
        }
        private void CleanFormChangePassword()
        {
            txtOldPassword.Text = "";
            txtNewPassword.Text = "";
            txtConfirmPassword.Text = "";
            txtOldPassword.Focus();
        }
    }
}
