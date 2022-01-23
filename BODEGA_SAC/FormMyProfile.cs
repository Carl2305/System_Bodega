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
    public partial class FormMyProfile : Form
    {
        private TB_EMPLOYEE DataemployeeForm;
        public FormMyProfile(TB_EMPLOYEE employee)
        {
            this.DataemployeeForm = employee;
            InitializeComponent();
        }

        private void FormMyProfile_Load(object sender, EventArgs e)
        {
            if (DataemployeeForm != null)
            {
                TB_ROLE_EMPLOYEE roleEmployee = new TB_ROLE_EMPLOYEE();
                using (BODEGA_SACEntities db = new BODEGA_SACEntities())
                {
                    var datarole = (from role in db.TB_ROLE_EMPLOYEE
                                     where role.ID_ROLE_EMPLOYEE.Equals(DataemployeeForm.ID_ROLE_EMPLOYEE)
                                     select role);
                    roleEmployee = datarole.FirstOrDefault();
                }
                lblName_LastName.Text = $"{DataemployeeForm.NAME_EMPLOYEE} {DataemployeeForm.LAST_NAME_EMPLOYEE}";
                lblRoleEmployee.Text = roleEmployee.NAME_ROLE_EMPLOYEE;
                lblDNI.Text = DataemployeeForm.DNI_EMPLOYEE;
            }
        }

        private void btnCloseFormMyProfile_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
