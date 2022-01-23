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
    public partial class FormUpdateProduct : Form
    {
        private int codeProductId = 0;
        public FormUpdateProduct()
        {
            InitializeComponent();
        }

        private void FormUpdateProduct_Load(object sender, EventArgs e)
        {
            LoadComboBoxCategoryProduct();
            CleanFormUpdateProduct();
            loadTableAllProducts();
        }

        private void dgvTableAllProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lblCodeProduct.Text = dgvTableAllProducts.Rows[dgvTableAllProducts.CurrentRow.Index].Cells[1].Value.ToString();
            txtNameProduct.Text = dgvTableAllProducts.Rows[dgvTableAllProducts.CurrentRow.Index].Cells[4].Value.ToString();
            txtDescriptionProduct.Text = dgvTableAllProducts.Rows[dgvTableAllProducts.CurrentRow.Index].Cells[7].Value.ToString();
            txtPriceProduct.Text = dgvTableAllProducts.Rows[dgvTableAllProducts.CurrentRow.Index].Cells[5].Value.ToString();
            txtStockProduct.Text = dgvTableAllProducts.Rows[dgvTableAllProducts.CurrentRow.Index].Cells[6].Value.ToString();
            cboCategory.SelectedValue = int.Parse(dgvTableAllProducts.Rows[dgvTableAllProducts.CurrentRow.Index].Cells[2].Value.ToString());
            codeProductId = int.Parse(dgvTableAllProducts.Rows[dgvTableAllProducts.CurrentRow.Index].Cells[0].Value.ToString());
            txtNameProduct.ReadOnly = false;
            txtDescriptionProduct.ReadOnly = false;
            txtPriceProduct.ReadOnly = false;
            txtStockProduct.ReadOnly = false;
        }

        private void btnCloseFormUpdateProduct_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpdateProduct_Click(object sender, EventArgs e)
        {
            string name = txtNameProduct.Text;
            string description = txtDescriptionProduct.Text;
            int code = Convert.ToInt32(lblCodeProduct.Text);
            decimal price = 0;
            int stock = 0;
            if (txtPriceProduct.Text.Trim()!=null && txtPriceProduct.Text.Trim() != "")
            {
                price = Convert.ToDecimal(txtPriceProduct.Text);
            }
            if (txtStockProduct.Text.Trim() != null && txtStockProduct.Text.Trim() != "")
            {
                stock = Convert.ToInt32(txtStockProduct.Text);
            }
            int category = Convert.ToInt32(cboCategory.SelectedValue);
            ValidateFormUpdateProduct(codeProductId, name, description, code, price, stock, category);
        }
        private void ValidateFormUpdateProduct(int id, string name, string description, int code, decimal price, int stock, int category)
        {
            if (id == 0)
            {
                MessageBox.Show("Selecciona una fila", "¡Error!");
            }
            else if (name.Trim() == null || name.Trim() == "")
            {
                MessageBox.Show("Ingrese un Nombre de Producto.", "Faltan Datos");
                txtNameProduct.Focus();
            }
            else if (description.Trim() == null || description.Trim() == "")
            {
                MessageBox.Show("Ingrese una descripcion.", "Faltan Datos");
                txtDescriptionProduct.Focus();
            }
            else if (price.ToString() == null)
            {
                MessageBox.Show("Ingrese un precio.", "Faltan Datos");
                txtPriceProduct.Focus();
            }
            else if (price <= 0)
            {
                MessageBox.Show("El precio del producto debe ser mayor a 0", "¡Error!");
                txtPriceProduct.Focus();
            }
            else if (stock.ToString() == null)
            {
                MessageBox.Show("Ingrese una cantidad de stock.", "Faltan Datos");
                txtPriceProduct.Focus();
            }
            else if (stock <= 0)
            {
                MessageBox.Show("El stock del producto debe ser mayor a 0", "¡Error!");
                txtPriceProduct.Focus();
            }
            else if (category == 0)
            {
                MessageBox.Show("Seleccione una categoria de producto", "Faltan Datos");
                cboCategory.Focus();
            }
            else
            {
                TB_PRODUCT tb_product = new TB_PRODUCT();
                tb_product.ID_PRODUCT = id;
                tb_product.NAME_PRODUCT = name.Trim().ToUpper();
                tb_product.DESCRIPTION_PRODUCT = description.Trim().ToUpper();
                tb_product.CODE_PRODUCT = code;
                tb_product.PRICE_PRODUCT = price;
                tb_product.STOCK_PRODUCT = stock;
                tb_product.ID_CATEGORY = category;
                tb_product.STATUS_PRODUCT = 1;
                if (UpdateProduct(tb_product))
                {
                    MessageBox.Show("Producto Actualizado.");
                    CleanFormUpdateProduct();
                    loadTableAllProducts();
                }
                else
                {
                    MessageBox.Show("Error! Intentelo más tarde.");
                    CleanFormUpdateProduct();
                }
            }
        }

        private bool UpdateProduct(TB_PRODUCT product)
        {
            try
            {
                using (BODEGA_SACEntities db = new BODEGA_SACEntities())
                {
                    TB_PRODUCT dataProduct = db.TB_PRODUCT.Find(product.ID_PRODUCT);
                    dataProduct.NAME_PRODUCT = product.NAME_PRODUCT;
                    dataProduct.DESCRIPTION_PRODUCT = product.DESCRIPTION_PRODUCT;
                    dataProduct.CODE_PRODUCT = product.CODE_PRODUCT;
                    dataProduct.PRICE_PRODUCT = product.PRICE_PRODUCT;
                    dataProduct.STOCK_PRODUCT = product.STOCK_PRODUCT;
                    dataProduct.ID_CATEGORY = product.ID_CATEGORY;
                    dataProduct.STATUS_PRODUCT = product.STATUS_PRODUCT;
                    db.Entry(dataProduct).State = System.Data.Entity.EntityState.Modified;
                    return db.SaveChanges() > 0;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
        }

        private void CleanFormUpdateProduct()
        {
            txtNameProduct.Text = "";
            txtDescriptionProduct.Text = "";
            txtPriceProduct.Text = "";
            txtStockProduct.Text = "";
            cboCategory.SelectedIndex = 0;
            lblCodeProduct.Text = "0000";
            codeProductId = 0;
            txtNameProduct.ReadOnly = true;
            txtDescriptionProduct.ReadOnly = true;
            txtPriceProduct.ReadOnly = true;
            txtStockProduct.ReadOnly = true;
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
                                                ID = prod.ID_PRODUCT,
                                                CODIGO = prod.CODE_PRODUCT,
                                                IDCATEGORY = prod.ID_CATEGORY,
                                                CATEGORIA = catg.NAME_CATEGORY,
                                                NOMBRE = prod.NAME_PRODUCT,
                                                PRECIO = prod.PRICE_PRODUCT,
                                                STOCK = prod.STOCK_PRODUCT,
                                                DESCRIPCION = prod.DESCRIPTION_PRODUCT
                                            });
                    dgvTableAllProducts.DataSource = listaAllProducts.ToList();
                    dgvTableAllProducts.Columns[0].Visible = false;
                    dgvTableAllProducts.Columns[2].Visible = false;
                    dgvTableAllProducts.AutoResizeColumns();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
    }
}
