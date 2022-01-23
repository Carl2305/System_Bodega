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
    public partial class FormUpdateCategory : Form
    {
        private int codeCaregory = 0;
        public FormUpdateCategory()
        {
            InitializeComponent();
        }

        private void FormUpdateCategory_Load(object sender, EventArgs e)
        {
            CleanFormUpdateCategory();
            loadTableAllCategories();
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
                                                  CODIGO=catg.ID_CATEGORY,
                                                  NOMBRE = catg.NAME_CATEGORY,
                                                  DESCRIPCION = catg.DESCRIPTION_CATEGORY
                                              });
                    dgvTableAllCategories.DataSource = listaAllCategories.ToList();
                    dgvTableAllCategories.Columns[0].Visible = false;
                    dgvTableAllCategories.AutoResizeColumns();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void dgvTableAllCategories_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtNameCategory.Text = dgvTableAllCategories.Rows[dgvTableAllCategories.CurrentRow.Index].Cells[1].Value.ToString();
            txtDescriptionCategory.Text = dgvTableAllCategories.Rows[dgvTableAllCategories.CurrentRow.Index].Cells[2].Value.ToString();
            codeCaregory = int.Parse(dgvTableAllCategories.Rows[dgvTableAllCategories.CurrentRow.Index].Cells[0].Value.ToString());

            txtNameCategory.ReadOnly = false;
            txtDescriptionCategory.ReadOnly = false;
        }

        private void btnCloseFormUpdateCategory_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpdateCategory_Click(object sender, EventArgs e)
        {
            string name = txtNameCategory.Text;
            string description = txtDescriptionCategory.Text;
            ValidateFormUpdateCategory(codeCaregory,name,description);
        }

        private void ValidateFormUpdateCategory(int code, string name, string description)
        {
            if (code == 0)
            {
                MessageBox.Show("Selecciona una fila", "¡Error!");
            }
            else if (name.Trim()==null||name.Trim()=="")
            {
                MessageBox.Show("Ingrese un Nombre de Categoia.", "Faltan Datos");
                txtNameCategory.Focus();
            }
            else if (description.Trim() == null || description.Trim() == "")
            {
                MessageBox.Show("Ingrese una Descripcion para la Categoria", "Faltan Datos");
                txtDescriptionCategory.Focus();
            }
            else
            {
                TB_CATEGORY category = new TB_CATEGORY();
                category.NAME_CATEGORY = name.Trim().ToUpper();
                category.DESCRIPTION_CATEGORY = description.Trim().ToUpper();
                category.ID_CATEGORY = code;
                if (UpdateCategory(category))
                {
                    MessageBox.Show("Categoria Actualizada Correctamente.");
                    loadTableAllCategories();
                    CleanFormUpdateCategory();
                }
                else
                {
                    MessageBox.Show("Error! Intentelo más tarde.", "¡Error!");
                    CleanFormUpdateCategory();
                }
            }
        }

        private bool UpdateCategory(TB_CATEGORY category)
        {
            try
            {
                using (BODEGA_SACEntities db = new BODEGA_SACEntities())
                {
                    TB_CATEGORY dataCategory = db.TB_CATEGORY.Find(category.ID_CATEGORY);
                    dataCategory.NAME_CATEGORY = category.NAME_CATEGORY;
                    dataCategory.DESCRIPTION_CATEGORY = category.DESCRIPTION_CATEGORY;
                    db.Entry(dataCategory).State = System.Data.Entity.EntityState.Modified;
                    return db.SaveChanges() > 0;
                }
            }catch(Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
        }

        private void CleanFormUpdateCategory()
        {
            txtNameCategory.Text = "";
            txtDescriptionCategory.Text = "";
            codeCaregory = 0;
            txtNameCategory.ReadOnly = true;
            txtDescriptionCategory.ReadOnly = true;
        }
    }
}
