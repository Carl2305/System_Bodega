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
    public partial class MDI_BODEGA_SAC : Form
    {
        private TB_EMPLOYEE DataemployeeForm;
        public MDI_BODEGA_SAC(TB_EMPLOYEE employee)
        {
            this.DataemployeeForm = employee;
            InitializeComponent();
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void MDI_BODEGA_SAC_Load(object sender, EventArgs e)
        {
            if (DataemployeeForm != null)
            {
                switch (DataemployeeForm.ID_ROLE_EMPLOYEE)
                {
                    case 1: btnFileToolStripMenuItem.Visible = false; break;
                    case 2: btnManteAdmin.Visible = false; break;
                    default: btnManteAdmin.Visible = false; break;
                }
            }
        }

        private void MDI_BODEGA_SAC_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnExitEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMyProfileEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form existe = Application.OpenForms.OfType<Form>().Where(pre => pre.Name == "FormMyProfile").SingleOrDefault<Form>();
            if (existe != null)
            {
                existe.WindowState = FormWindowState.Normal;
                existe.BringToFront();
                return;
            }
            FormMyProfile childForm = new FormMyProfile(DataemployeeForm);
            childForm.MdiParent = this;
            childForm.Show();
        }

        private void btnChangePasswordEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form existe = Application.OpenForms.OfType<Form>().Where(pre => pre.Name == "FormChangePassword").SingleOrDefault<Form>();
            if (existe != null)
            {
                existe.WindowState = FormWindowState.Normal;
                existe.BringToFront();
                return;
            }
            FormChangePassword formChangePassword = new FormChangePassword(DataemployeeForm);
            formChangePassword.MdiParent = this;
            formChangePassword.Show();
        }

        private void btnChangePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form existe = Application.OpenForms.OfType<Form>().Where(pre => pre.Name == "FormChangePassword").SingleOrDefault<Form>();
            if (existe != null)
            {
                existe.WindowState = FormWindowState.Normal;
                existe.BringToFront();
                return;
            }
            FormChangePassword formChangePassword = new FormChangePassword(DataemployeeForm);
            formChangePassword.MdiParent = this;
            formChangePassword.Show();
        }

        private void btnMyProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form existe = Application.OpenForms.OfType<Form>().Where(pre => pre.Name == "FormMyProfile").SingleOrDefault<Form>();
            if (existe != null)
            {
                existe.WindowState = FormWindowState.Normal;
                existe.BringToFront();
                return;
            }
            FormMyProfile childForm = new FormMyProfile(DataemployeeForm);
            childForm.MdiParent = this;
            childForm.Show();
        }

        private void btnEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form existe = Application.OpenForms.OfType<Form>().Where(pre => pre.Name == "FormRegisterEmployee").SingleOrDefault<Form>();
            if (existe != null)
            {
                existe.WindowState = FormWindowState.Normal;
                existe.BringToFront();
                return;
            }
            FormRegisterEmployee childForm = new FormRegisterEmployee();
            childForm.MdiParent = this;
            childForm.Show();
        }

        private void btnProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form existe = Application.OpenForms.OfType<Form>().Where(pre => pre.Name == "FormRegisterProduct").SingleOrDefault<Form>();
            if (existe != null)
            {
                existe.WindowState = FormWindowState.Normal;
                existe.BringToFront();
                return;
            }
            FormRegisterProduct childForm = new FormRegisterProduct();
            childForm.MdiParent = this;
            childForm.Show();
        }

        private void btnCategoryProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form existe = Application.OpenForms.OfType<Form>().Where(pre => pre.Name == "FormRegisterCategory").SingleOrDefault<Form>();
            if (existe != null)
            {
                existe.WindowState = FormWindowState.Normal;
                existe.BringToFront();
                return;
            }
            FormRegisterCategory childForm = new FormRegisterCategory();
            childForm.MdiParent = this;
            childForm.Show();
        }

        private void btnUpdateEmployeeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form existe = Application.OpenForms.OfType<Form>().Where(pre => pre.Name == "FormUpdateEmployee").SingleOrDefault<Form>();
            if (existe != null)
            {
                existe.WindowState = FormWindowState.Normal;
                existe.BringToFront();
                return;
            }
            FormUpdateEmployee childForm = new FormUpdateEmployee();
            childForm.MdiParent = this;
            childForm.Show();
        }

        private void btnUpdateCategoryProductToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form existe = Application.OpenForms.OfType<Form>().Where(pre => pre.Name == "FormUpdateCategory").SingleOrDefault<Form>();
            if (existe != null)
            {
                existe.WindowState = FormWindowState.Normal;
                existe.BringToFront();
                return;
            }
            FormUpdateCategory childForm = new FormUpdateCategory();
            childForm.MdiParent = this;
            childForm.Show();
        }

        private void btnUpdateProductToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form existe = Application.OpenForms.OfType<Form>().Where(pre => pre.Name == "FormUpdateProduct").SingleOrDefault<Form>();
            if (existe != null)
            {
                existe.WindowState = FormWindowState.Normal;
                existe.BringToFront();
                return;
            }
            FormUpdateProduct childForm = new FormUpdateProduct();
            childForm.MdiParent = this;
            childForm.Show();
        }

        private void btnUpdateDebtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form existe = Application.OpenForms.OfType<Form>().Where(pre => pre.Name == "FormUpdateBebt").SingleOrDefault<Form>();
            if (existe != null)
            {
                existe.WindowState = FormWindowState.Normal;
                existe.BringToFront();
                return;
            }
            FormUpdateBebt childForm = new FormUpdateBebt(1);
            childForm.MdiParent = this;
            childForm.Show();
        }

        private void btnSearchProductToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form existe = Application.OpenForms.OfType<Form>().Where(pre => pre.Name == "FormSearhProduct").SingleOrDefault<Form>();
            if (existe != null)
            {
                existe.WindowState = FormWindowState.Normal;
                existe.BringToFront();
                return;
            }
            FormSearhProduct childForm = new FormSearhProduct();
            childForm.MdiParent = this;
            childForm.Show();
        }

        private void btnNewSaleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form existe = Application.OpenForms.OfType<Form>().Where(pre => pre.Name == "FormRegisterSale").SingleOrDefault<Form>();
            if (existe != null)
            {
                existe.WindowState = FormWindowState.Normal;
                existe.BringToFront();
                return;
            }
            FormRegisterSale childForm = new FormRegisterSale(DataemployeeForm.ID_EMPLOYEE);
            childForm.MdiParent = this;
            childForm.Show();
        }


        private void btnUpdateClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form existe = Application.OpenForms.OfType<Form>().Where(pre => pre.Name == "FormUpdateClient").SingleOrDefault<Form>();
            if (existe != null)
            {
                existe.WindowState = FormWindowState.Normal;
                existe.BringToFront();
                return;
            }
            FormUpdateClient childForm = new FormUpdateClient();
            childForm.MdiParent = this;
            childForm.Show();
        }

        private void btnNewClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form existe = Application.OpenForms.OfType<Form>().Where(pre => pre.Name == "FormRegisterClient").SingleOrDefault<Form>();
            if (existe != null)
            {
                existe.WindowState = FormWindowState.Normal;
                existe.BringToFront();
                return;
            }
            FormRegisterClient childForm = new FormRegisterClient();
            childForm.MdiParent = this;
            childForm.Show();
        }

        private void btnSearchDebtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DataemployeeForm.ID_ROLE_EMPLOYEE == 1)
            {
                Form existe = Application.OpenForms.OfType<Form>().Where(pre => pre.Name == "FormUpdateBebt").SingleOrDefault<Form>();
                if (existe != null)
                {
                    existe.WindowState = FormWindowState.Normal;
                    existe.BringToFront();
                    return;
                }
                FormUpdateBebt childForm = new FormUpdateBebt(1);
                childForm.MdiParent = this;
                childForm.Show();
            }
            else
            {
                Form existe = Application.OpenForms.OfType<Form>().Where(pre => pre.Name == "FormUpdateBebt").SingleOrDefault<Form>();
                if (existe != null)
                {
                    existe.WindowState = FormWindowState.Normal;
                    existe.BringToFront();
                    return;
                }
                FormUpdateBebt childForm = new FormUpdateBebt(2);
                childForm.MdiParent = this;
                childForm.Show();
            }
        }

        private void btnListDebtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form existe = Application.OpenForms.OfType<Form>().Where(pre => pre.Name == "FormListDebt").SingleOrDefault<Form>();
            if (existe != null)
            {
                existe.WindowState = FormWindowState.Normal;
                existe.BringToFront();
                return;
            }
            FormListDebt childForm = new FormListDebt();
            childForm.MdiParent = this;
            childForm.Show();
        }

        private void SearchSaleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form existe = Application.OpenForms.OfType<Form>().Where(pre => pre.Name == "FormSearchSale").SingleOrDefault<Form>();
            if (existe != null)
            {
                existe.WindowState = FormWindowState.Normal;
                existe.BringToFront();
                return;
            }
            FormSearchSale childForm = new FormSearchSale();
            childForm.MdiParent = this;
            childForm.Show();
        }
    }
}
