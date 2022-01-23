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
    public partial class FormSearhProduct : Form
    {
        public FormSearhProduct()
        {
            InitializeComponent();
        }

        private void FormSearhProduct_Load(object sender, EventArgs e)
        {
            loadTableAllProducts();
        }

        private void rbtnAllProducts_CheckedChanged(object sender, EventArgs e)
        {
            pnlForCode.Visible = false;
            pnlForName.Visible = false;
            pnlForCategory.Visible = false;
            loadTableAllProducts();
        }

        private void rbtnForCode_CheckedChanged(object sender, EventArgs e)
        {
            pnlForCode.Visible = true;
            pnlForName.Visible = false;
            pnlForCategory.Visible = false;
            loadTableAllProducts();
        }

        private void rbtnForName_CheckedChanged(object sender, EventArgs e)
        {
            pnlForCode.Visible = false;
            pnlForName.Visible = true;
            pnlForCategory.Visible = false;
            loadTableAllProducts();
        }

        private void rbtnForCategory_CheckedChanged(object sender, EventArgs e)
        {
            pnlForCode.Visible = false;
            pnlForName.Visible = false;
            pnlForCategory.Visible = true;
            LoadComboBoxCategoryProduct();
            loadTableAllProducts();
        }

        private void btnCloseFormRegisterProduct_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSearchCodeProduct_Click(object sender, EventArgs e)
        {
            if(txtCodeProduct.Text.Trim().Equals("")|| txtCodeProduct.Text.Trim().ToString() == null)
            {
                MessageBox.Show("Ingrese un código de un Producto","Faltan Datos");
                loadTableAllProducts();
            }
            else
            {
                int code = int.Parse(txtCodeProduct.Text.Trim().ToString());
                loadTableAllProductsForCode(code);
            }
        }

        private void btnSearchNameProduct_Click(object sender, EventArgs e)
        {
            if (txtNameProduct.Text.Trim().Equals("") || txtNameProduct.Text.Trim().ToString() == null)
            {
                MessageBox.Show("Ingrese un nombre o inicial del producto.", "Faltan Datos");
                loadTableAllProducts();
            }
            else
            {
                string name = txtNameProduct.Text.Trim().ToUpper();
                loadTableAllProductsForName(name);
            }
        }

        private void btnSearchCetogoryProduct_Click(object sender, EventArgs e)
        {
            int category = int.Parse(cboCategory.SelectedValue.ToString());
            loadTableAllProductsForCategory(category);
        }

        private void loadTableAllProducts()
        {
            try
            {
                using (BODEGA_SACEntities db = new BODEGA_SACEntities())
                {
                    var listaAllProducts = (from prod in db.TB_PRODUCT
                                            join catg in db.TB_CATEGORY on prod.ID_CATEGORY equals catg.ID_CATEGORY
                                            select new
                                            {
                                                CODIGO = prod.CODE_PRODUCT,
                                                NOMBRE = prod.NAME_PRODUCT,
                                                PRECIO = prod.PRICE_PRODUCT,
                                                STOCK = prod.STOCK_PRODUCT,
                                                CATEGORIA = catg.NAME_CATEGORY,
                                                DESCRIPCION = prod.DESCRIPTION_PRODUCT
                                            });
                    dgvTableAllProducts.DataSource = listaAllProducts.ToList();
                    dgvTableAllProducts.AutoResizeColumns();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        private void loadTableAllProductsForCode(int code)
        {
            try
            {
                using (BODEGA_SACEntities db = new BODEGA_SACEntities())
                {
                    var listaAllProducts = (from prod in db.TB_PRODUCT
                                            join catg in db.TB_CATEGORY on prod.ID_CATEGORY equals catg.ID_CATEGORY
                                            where prod.CODE_PRODUCT==code 
                                            select new
                                            {
                                                CODIGO = prod.CODE_PRODUCT,
                                                NOMBRE = prod.NAME_PRODUCT,
                                                PRECIO = prod.PRICE_PRODUCT,
                                                STOCK = prod.STOCK_PRODUCT,
                                                CATEGORIA = catg.NAME_CATEGORY,
                                                DESCRIPCION = prod.DESCRIPTION_PRODUCT
                                            });
                    dgvTableAllProducts.DataSource = listaAllProducts.ToList();
                    dgvTableAllProducts.AutoResizeColumns();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        private void loadTableAllProductsForName(string name)
        {
            try
            {
                using (BODEGA_SACEntities db = new BODEGA_SACEntities())
                {
                    var listaAllProducts = (from prod in db.TB_PRODUCT
                                            join catg in db.TB_CATEGORY on prod.ID_CATEGORY equals catg.ID_CATEGORY
                                            where prod.NAME_PRODUCT.Contains(name) || prod.DESCRIPTION_PRODUCT.Contains(name) || catg.NAME_CATEGORY.Contains(name)
                                            select new
                                            {
                                                CODIGO = prod.CODE_PRODUCT,
                                                NOMBRE = prod.NAME_PRODUCT,
                                                PRECIO = prod.PRICE_PRODUCT,
                                                STOCK = prod.STOCK_PRODUCT,
                                                CATEGORIA = catg.NAME_CATEGORY,
                                                DESCRIPCION = prod.DESCRIPTION_PRODUCT
                                            });
                    dgvTableAllProducts.DataSource = listaAllProducts.ToList();
                    dgvTableAllProducts.AutoResizeColumns();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        private void loadTableAllProductsForCategory(int category)
        {
            try
            {
                using (BODEGA_SACEntities db = new BODEGA_SACEntities())
                {
                    var listaAllProducts = (from prod in db.TB_PRODUCT
                                            join catg in db.TB_CATEGORY on prod.ID_CATEGORY equals catg.ID_CATEGORY
                                            where catg.ID_CATEGORY==category
                                            select new
                                            {
                                                CODIGO = prod.CODE_PRODUCT,
                                                NOMBRE = prod.NAME_PRODUCT,
                                                PRECIO = prod.PRICE_PRODUCT,
                                                STOCK = prod.STOCK_PRODUCT,
                                                CATEGORIA = catg.NAME_CATEGORY,
                                                DESCRIPCION = prod.DESCRIPTION_PRODUCT
                                            });
                    dgvTableAllProducts.DataSource = listaAllProducts.ToList();
                    dgvTableAllProducts.AutoResizeColumns();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        private void LoadComboBoxCategoryProduct()
        {
            using (BODEGA_SACEntities db = new BODEGA_SACEntities())
            {
                cboCategory.DataSource = db.TB_CATEGORY.OrderBy(d => d.NAME_CATEGORY).ToList();
                cboCategory.DisplayMember = "NAME_CATEGORY";
                cboCategory.ValueMember = "ID_CATEGORY";
            }
        }

    }
}
