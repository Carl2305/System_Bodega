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
    public partial class FormRegisterEmployee : Form
    {
        private void CleanFormRegisterEmployee()
        {
            txtNameEmployee.Text = "";
            txtLastNameEmployee.Text = "";
            txtDniEmployee.Text = "";
            txtUserEmployee.Text = "";
            txtPassword.Text = "";
            txtPassword.Text = "";
            txtNameEmployee.Focus();
        }

        public FormRegisterEmployee()
        {
            InitializeComponent();
        }

        private void FormRegisterEmployee_Load(object sender, EventArgs e)
        {
            loadTableAllEmployees();
            CleanFormRegisterEmployee();
            LoadComboBoxRoleEmployee();
        }

        private void btnCloseFormRegisterEmployee_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void loadTableAllEmployees()
        {
            try
            {
                using (BODEGA_SACEntities db = new BODEGA_SACEntities())
                {
                    var listaAllEmployees = (from emple in db.TB_EMPLOYEE
                                             join role in db.TB_ROLE_EMPLOYEE on emple.ID_ROLE_EMPLOYEE equals role.ID_ROLE_EMPLOYEE
                                             select new
                                             {
                                                 NOMBRES = emple.NAME_EMPLOYEE,
                                                 APELLIDOS = emple.LAST_NAME_EMPLOYEE,
                                                 DNI = emple.DNI_EMPLOYEE,
                                                 CARGO = role.NAME_ROLE_EMPLOYEE
                                             });
                    dgvTableAllEmployees.DataSource = listaAllEmployees.ToList();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void txtNameEmployee_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtLastNameEmployee.Focus();
            }
        }

        private void txtLastNameEmployee_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtDniEmployee.Focus();
                GenerateUserEmployee();
            }
        }

        private void txtDniEmployee_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtPassword.Focus();
                GenerateUserEmployee();
            }
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtPassword.Focus();
            }
        }

        private void txtConfirmPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btnRegisterEmployee.Focus();
            }
        }

        private void btnRegisterEmployee_Click(object sender, EventArgs e)
        {
            string name = txtNameEmployee.Text;
            string lasname=txtLastNameEmployee.Text;
            string dni=txtDniEmployee.Text;
            string user=txtUserEmployee.Text;
            int codRole = Convert.ToInt32(cboRoleEmployee.SelectedValue);
            string password=txtPassword.Text;

            ValidateFormRegisterEmployee(name,lasname,dni,user,codRole,password);
        }

        private void ValidateFormRegisterEmployee(string name, string lasname, string dni, string user, int role, string password)
        {
            if (name.Trim() == null || name.Trim() == "")
            {
                MessageBox.Show("Ingrese un nombre.", "Faltan Datos");
                txtNameEmployee.Focus();
            }
            else if (lasname.Trim() == null || lasname.Trim() == "")
            {
                MessageBox.Show("Ingrese un apellido.","Faltan Datos");
                txtLastNameEmployee.Focus();
            }
            else if (dni.Trim() == null || dni.Trim() == "")
            {
                MessageBox.Show("Ingrese un DNI.","Faltan Datos");
                txtDniEmployee.Focus();
            }
            else if (role==0)
            {
                MessageBox.Show("Seleccione un cargo","Faltan Datos");
                cboRoleEmployee.Focus();
            }
            else if (password.Trim() == null || password.Trim() == "")
            {
                MessageBox.Show("Ingrese una Contraseña.","Faltan Datos");
                txtPassword.Focus();
            }
            else
            {
                TB_EMPLOYEE tB_EMPLOYEE = new TB_EMPLOYEE();
                tB_EMPLOYEE.NAME_EMPLOYEE = name.Trim().ToUpper();
                tB_EMPLOYEE.LAST_NAME_EMPLOYEE = lasname.Trim().ToUpper();
                tB_EMPLOYEE.DNI_EMPLOYEE = dni;
                tB_EMPLOYEE.STATUS_EMPLOYEE = 1;
                tB_EMPLOYEE.ID_ROLE_EMPLOYEE = role;

                TB_LOGIN_EMPLOYEE tB_LOGIN_EMPLOYEE = new TB_LOGIN_EMPLOYEE();
                tB_LOGIN_EMPLOYEE.USER_EMPLOYEE = user;
                tB_LOGIN_EMPLOYEE.PASSWORD_EMPLOYEE = Tools.Encrypt(password);
                if(RegisterEmployee(tB_EMPLOYEE, tB_LOGIN_EMPLOYEE))
                {
                    MessageBox.Show("Empleado Registrado.");
                    CleanFormRegisterEmployee();
                    loadTableAllEmployees();
                }
                else
                {
                    MessageBox.Show("Error! Intentelo más tarde.");
                    CleanFormRegisterEmployee();
                }
            }
        }

        private bool RegisterEmployee(TB_EMPLOYEE employee, TB_LOGIN_EMPLOYEE login)
        {
            try
            {
                using (BODEGA_SACEntities db = new BODEGA_SACEntities())
                {
                    db.TB_EMPLOYEE.Add(employee);
                    if (db.SaveChanges() > 0)
                    {
                        login.ID_EMPLOYEE = (GetLastIdEmployee()+1);
                        db.TB_LOGIN_EMPLOYEE.Add(login);
                        return db.SaveChanges() > 0;
                    }
                }
            }catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return false;
        }
        private int GetLastIdEmployee()
        {
            int IdLogin = 0;
            try
            {
                using (BODEGA_SACEntities db = new BODEGA_SACEntities())
                {
                    var dataId = (from emple in db.TB_EMPLOYEE
                                     select emple.ID_EMPLOYEE);
                    IdLogin = dataId.FirstOrDefault();
                    return IdLogin;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return 0;
        }
        private void GenerateUserEmployee()
        {
            try
            {
                txtUserEmployee.Text = $"{txtNameEmployee.Text.Trim()}{txtLastNameEmployee.Text.Trim().Substring(0, 2)}";
            }
            catch (Exception ex)
            {
                txtUserEmployee.Text = "";
            }
        }

        private void txtDniEmployee_Click(object sender, EventArgs e)
        {
            GenerateUserEmployee();
        }
        private void LoadComboBoxRoleEmployee()
        {
            using (BODEGA_SACEntities db = new BODEGA_SACEntities())
            {
                cboRoleEmployee.DataSource = db.TB_ROLE_EMPLOYEE.OrderBy(d => d.NAME_ROLE_EMPLOYEE).ToList();
                cboRoleEmployee.DisplayMember = "NAME_ROLE_EMPLOYEE";
                cboRoleEmployee.ValueMember = "ID_ROLE_EMPLOYEE";
            }
        }
    }
}
