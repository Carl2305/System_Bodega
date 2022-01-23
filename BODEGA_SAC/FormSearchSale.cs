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
    public partial class FormSearchSale : Form
    {
        public FormSearchSale()
        {
            InitializeComponent();
        }
        private void getSaleHeader(int idSale)
        {
            TB_SALE data = null;
            using (BODEGA_SACEntities db= new BODEGA_SACEntities())
            {
                data = db.TB_SALE.Find(idSale);
                if (data != null)
                {
                    lblDateSale.Text = data.DATE_SALE.ToString();
                    lblNameCustomer.Text = data.TB_CUSTOMER.NAME_CUSTOMER.ToString();
                    lblTotalDebt.Text = data.TOTAL_SALE.ToString();
                }
            }
            
        }
        private void loadTableAllDetail(int idSale)
        {
            try
            {
                using (BODEGA_SACEntities db = new BODEGA_SACEntities())
                {
                    var listaAllDebt = (from deta in db.TB_DETAIL_SALE
                                        join prod in db.TB_PRODUCT on deta.ID_PRODUCT equals prod.ID_PRODUCT
                                        where deta.ID_SALE==idSale
                                        select new
                                        {
                                            ID = deta.ID_SALE,
                                            PRODUCTO = prod.NAME_PRODUCT,
                                            PRECIO_VENDIDO = deta.PRICE_PRODUCT_SALE,
                                            CANTIDAD = deta.AMOUNT_PRODUCT_SALE
                                        });
                    dgvTableDetailSale.DataSource = listaAllDebt.ToList();
                    dgvTableDetailSale.Columns[0].Visible = false;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void btnCloseFormDetailSale_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSearchSale_Click(object sender, EventArgs e)
        {
            if (txtIdVenta.Text != "")
            {
                int ID_SALE = Convert.ToInt32(txtIdVenta.Text.Trim());
                getSaleHeader(ID_SALE);
                loadTableAllDetail(ID_SALE);
            }
            else
            {
                MessageBox.Show("Ingrese un Id de Una Venta","Faltan Datos");
            }
        }
    }
}
