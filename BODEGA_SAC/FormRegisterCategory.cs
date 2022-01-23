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
    public partial class FormRegisterCategory : Form
    {
        public FormRegisterCategory()
        {
            InitializeComponent();
        }

        private void FormRegisterCategory_Load(object sender, EventArgs e)
        {
            CleanFormRegisterCategorie();
            loadTableAllCategories();
        }

        private void btnCloseFormRegisterCategory_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRegisterCategory_Click(object sender, EventArgs e)
        {
            string name = txtNameCategory.Text;
            string description = txtDescriptionCategory.Text;
            ValidateFormRegisterCategory(name, description);
        }

        private void ValidateFormRegisterCategory(string name, string description)
        {
            if (name.Trim() == null || name.Trim()=="")
            {
                MessageBox.Show("Ingrese un Nombre de Categoria.","Faltan Datos");
                txtNameCategory.Focus();
            }
            else if (description.Trim() == null || description.Trim() == "")
            {
                MessageBox.Show("Ingrese una descripcion.", "Faltan Datos");
                txtDescriptionCategory.Focus();
            }
            else
            {
                TB_CATEGORY tb_category = new TB_CATEGORY();
                tb_category.NAME_CATEGORY = name.Trim().ToUpper();
                tb_category.DESCRIPTION_CATEGORY = description.Trim().ToUpper();
                tb_category.STATUS_CATEGORY = 1;
                if (RegisterCategory(tb_category))
                {
                    MessageBox.Show("Empleado Registrado.");
                    CleanFormRegisterCategorie();
                    loadTableAllCategories();
                }
                else
                {
                    MessageBox.Show("Error! Intentelo más tarde.");
                    CleanFormRegisterCategorie();
                }
            }
        }
        private bool RegisterCategory(TB_CATEGORY category)
        {
            try
            {
                using (BODEGA_SACEntities db = new BODEGA_SACEntities())
                {
                    db.TB_CATEGORY.Add(category);
                    return db.SaveChanges() > 0;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return false;
        }
        private void CleanFormRegisterCategorie()
        {
            txtNameCategory.Text = "";
            txtDescriptionCategory.Text = "";
            txtNameCategory.Focus();
        }


        private void loadTableAllCategories()
        {
            try
            {
                using (BODEGA_SACEntities db = new BODEGA_SACEntities())
                {
                    var listaAllCategories = (from catg in db.TB_CATEGORY
                                            select new
                                            {
                                                NOMBRE = catg.NAME_CATEGORY,
                                                DESCRIPCION = catg.DESCRIPTION_CATEGORY
                                            });
                    dgvTableAllCategories.DataSource = listaAllCategories.ToList();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

    }
}
