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

namespace BODEGA_SAC
{
    public partial class FormUpdateEmployee : Form
    {
        private int idEmployee = 0;
        public FormUpdateEmployee()
        {
            InitializeComponent();
        }

        private void FormUpdateEmployee_Load(object sender, EventArgs e)
        {
            CleanFormRegisterEmployee();
            LoadComboBoxRoleEmployee();
            loadTableAllEmployees();
        }

        private void dgvTableAllEmployees_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtNameEmployee.Text = dgvTableAllEmployees.Rows[dgvTableAllEmployees.CurrentRow.Index].Cells[1].Value.ToString();
            txtLastNameEmployee.Text = dgvTableAllEmployees.Rows[dgvTableAllEmployees.CurrentRow.Index].Cells[2].Value.ToString();
            txtDniEmployee.Text = dgvTableAllEmployees.Rows[dgvTableAllEmployees.CurrentRow.Index].Cells[3].Value.ToString();
            cboRoleEmployee.SelectedValue = int.Parse(dgvTableAllEmployees.Rows[dgvTableAllEmployees.CurrentRow.Index].Cells[4].Value.ToString());
            idEmployee = int.Parse(dgvTableAllEmployees.Rows[dgvTableAllEmployees.CurrentRow.Index].Cells[0].Value.ToString());

            txtNameEmployee.ReadOnly = false;
            txtLastNameEmployee.ReadOnly = false;
            txtDniEmployee.ReadOnly = false;
        }

        private void btnCloseFormUpdateEmployee_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpdateEmployee_Click(object sender, EventArgs e)
        {
            string name = txtNameEmployee.Text;
            string lasname = txtLastNameEmployee.Text;
            string dni = txtDniEmployee.Text;
            int role = Convert.ToInt32(cboRoleEmployee.SelectedValue);
            ValidateFormUpdateEmployee(idEmployee, name, lasname, dni, role);
        }

        private void ValidateFormUpdateEmployee(int codeIdEmployee, string name, string lasname, string dni, int role)
        {
            if (codeIdEmployee == 0)
            {
                MessageBox.Show("Selecciona una fila", "¡Error!");
            }
            else if (name.Trim() == null || name.Trim() == "")
            {
                MessageBox.Show("Ingrese un nombre.", "Faltan Datos");
                txtNameEmployee.Focus();
            }
            else if (lasname.Trim() == null || lasname.Trim() == "")
            {
                MessageBox.Show("Ingrese un apellido.", "Faltan Datos");
                txtLastNameEmployee.Focus();
            }
            else if (dni.Trim() == null || dni.Trim() == "")
            {
                MessageBox.Show("Ingrese un DNI.", "Faltan Datos");
                txtDniEmployee.Focus();
            }
            else if (role == 0)
            {
                MessageBox.Show("Seleccione un cargo", "Faltan Datos");
                cboRoleEmployee.Focus();
            }
            else
            {
                TB_EMPLOYEE tB_EMPLOYEE = new TB_EMPLOYEE();
                tB_EMPLOYEE.ID_EMPLOYEE = codeIdEmployee;
                tB_EMPLOYEE.NAME_EMPLOYEE = name.Trim().ToUpper();
                tB_EMPLOYEE.LAST_NAME_EMPLOYEE = lasname.Trim().ToUpper();
                tB_EMPLOYEE.DNI_EMPLOYEE = dni;
                tB_EMPLOYEE.STATUS_EMPLOYEE = 1;
                tB_EMPLOYEE.ID_ROLE_EMPLOYEE = role;
                if (UpdateEmployee(tB_EMPLOYEE))
                {
                    MessageBox.Show("Empleado Actualizado.");
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

        private bool UpdateEmployee(TB_EMPLOYEE employee)
        {
            try
            {
                using (BODEGA_SACEntities db = new BODEGA_SACEntities())
                {
                    TB_EMPLOYEE dataEmployee = db.TB_EMPLOYEE.Find(employee.ID_EMPLOYEE);
                    dataEmployee.NAME_EMPLOYEE = employee.NAME_EMPLOYEE;
                    dataEmployee.LAST_NAME_EMPLOYEE = employee.LAST_NAME_EMPLOYEE;
                    dataEmployee.DNI_EMPLOYEE = employee.DNI_EMPLOYEE;
                    dataEmployee.STATUS_EMPLOYEE = employee.STATUS_EMPLOYEE;
                    dataEmployee.ID_ROLE_EMPLOYEE = employee.ID_ROLE_EMPLOYEE;
                    db.Entry(dataEmployee).State = System.Data.Entity.EntityState.Modified;
                    return db.SaveChanges() > 0;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
        }

        private void CleanFormRegisterEmployee()
        {
            txtNameEmployee.Text = "";
            txtLastNameEmployee.Text = "";
            txtDniEmployee.Text = "";
            txtNameEmployee.ReadOnly = true;
            txtLastNameEmployee.ReadOnly = true;
            txtDniEmployee.ReadOnly = true;
            idEmployee = 0;
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
                                                 IDEMPLOYEE=emple.ID_EMPLOYEE,
                                                 NOMBRES = emple.NAME_EMPLOYEE,
                                                 APELLIDOS = emple.LAST_NAME_EMPLOYEE,
                                                 DNI = emple.DNI_EMPLOYEE,
                                                 IDCARGO=emple.ID_ROLE_EMPLOYEE,
                                                 CARGO = role.NAME_ROLE_EMPLOYEE
                                             });
                    dgvTableAllEmployees.DataSource = listaAllEmployees.ToList();
                    dgvTableAllEmployees.Columns[0].Visible = false;
                    //dgvTableAllEmployees.Columns[4].Visible = false;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
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
