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
    public partial class FormRegisterProduct : Form
    {
        public FormRegisterProduct()
        {
            InitializeComponent();
        }

        private void FormRegisterProduct_Load(object sender, EventArgs e)
        {
            LoadComboBoxCategoryProduct();
            loadTableAllProducts();
            CleanFormRegisterProduct();
            GetCodeProduct();
        }

        private void btnCloseFormRegisterProduct_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRegisterProduct_Click(object sender, EventArgs e)
        {
            string name=txtNameProduct.Text;
            string description=txtDescriptionProduct.Text;
            int code = Convert.ToInt32(lblCodeProduct.Text);
            decimal price=Convert.ToDecimal(txtPriceProduct.Text);
            int stock=Convert.ToInt32(txtStockProduct.Text);
            int category = Convert.ToInt32(cboCategory.SelectedValue);
            ValidateFormRegisterProduct(name, description, code, price, stock, category);
        }
        private void ValidateFormRegisterProduct(string name, string description, int code, decimal price, int stock, int category)
        {
            if (name.Trim() == null || name.Trim() == "")
            {
                MessageBox.Show("Ingrese un Nombre de Producto.", "Faltan Datos");
                txtNameProduct.Focus();
            }
            else if (description.Trim() == null || description.Trim() == "")
            {
                MessageBox.Show("Ingrese una descripcion.", "Faltan Datos");
                txtDescriptionProduct.Focus();
            }
            else if (price.ToString()== null)
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
                tb_product.NAME_PRODUCT = name.Trim().ToUpper();
                tb_product.DESCRIPTION_PRODUCT = description.Trim().ToUpper();
                tb_product.CODE_PRODUCT = code;
                tb_product.PRICE_PRODUCT = price;
                tb_product.STOCK_PRODUCT = stock;
                tb_product.ID_CATEGORY = category;
                tb_product.STATUS_PRODUCT = 1;
                if (RegisterProdcut(tb_product))
                {
                    MessageBox.Show("Producto Registrado.");
                    CleanFormRegisterProduct();
                    loadTableAllProducts();
                    GetCodeProduct();
                }
                else
                {
                    MessageBox.Show("Error! Intentelo más tarde.");
                    CleanFormRegisterProduct();
                }
            }
        }
        private bool RegisterProdcut(TB_PRODUCT product)
        {
            try
            {
                using (BODEGA_SACEntities db = new BODEGA_SACEntities())
                {
                    db.TB_PRODUCT.Add(product);
                    return db.SaveChanges() > 0;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return false;
        }
        private void CleanFormRegisterProduct()
        {
            txtNameProduct.Text = "";
            txtDescriptionProduct.Text="";
            txtPriceProduct.Text="";
            txtStockProduct.Text = "";
            cboCategory.SelectedIndex=0;
            txtNameProduct.Focus();
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
                                                 CATEGORIA=catg.NAME_CATEGORY,
                                                 NOMBRE = prod.NAME_PRODUCT,
                                                 PRECIO = prod.PRICE_PRODUCT,
                                                 STOCK = prod.STOCK_PRODUCT,
                                                 DESCRIPCION=prod.DESCRIPTION_PRODUCT
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
        private void GetCodeProduct()
        {
            lblCodeProduct.Text = "";
            using (BODEGA_SACEntities db = new BODEGA_SACEntities())
            {
                var dataId = db.TB_PRODUCT.OrderByDescending(x => x.CODE_PRODUCT).FirstOrDefault();
                lblCodeProduct.Text = (dataId.CODE_PRODUCT+1).ToString();
            }
        }
    }
}
