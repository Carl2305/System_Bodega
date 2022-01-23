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
using BODEGA_SAC.Cart;

namespace BODEGA_SAC
{
    public partial class FormRegisterSale : Form
    {
        private int CODE_EMPLOYEE;
        private int NUMBERDNI = 0;
        private List<TB_DETAIL_SALE> DATA_DETAIL_SALE = new List<TB_DETAIL_SALE>();
        private List<CART> DATA_CART_TABLE = new List<CART>();
        private decimal ImportCancel = 0;
        public FormRegisterSale(int employee)
        {
            this.CODE_EMPLOYEE = employee;
            InitializeComponent();
        }

        private void FormRegisterSale_Load(object sender, EventArgs e)
        {
            txtImportCancelFast.Text = "0.00";
            panel1.Enabled = false;
            pnlTypeSaleFast.Enabled = false;
            btnFinallySale.Enabled = false;
            txtImportCancelFast.Enabled = false;

            // boton deshabilitado momentaniamente
            rbtnSaleDetail.Enabled = false;
            rbtnSaleDetail.Visible = false;

        }

        private void btnSearchClient_Click(object sender, EventArgs e)
        {
            if (txtDNIClient.Text.Trim() != "")
            {
                int DNI_NUMBER = int.Parse(txtDNIClient.Text.Trim());
                if (GetNameClient(DNI_NUMBER) != null)
                {
                    lblNameClient.Text = GetNameClient(DNI_NUMBER).Trim().ToUpper();
                    panel1.Enabled = true;
                    pnlTypeSaleFast.Enabled = true;
                    btnFinallySale.Enabled = true;
                    txtImportCancelFast.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Registre el cliente como nuevo.", "Error");
                }
            }
        }

        private string GetNameClient(int DNI)
        {
            string nameClient = "";
            try
            {
                using (BODEGA_SACEntities db = new BODEGA_SACEntities())
                {
                    var dataNAME = (from cli in db.TB_CUSTOMER
                                    where cli.DNI_CUSTOMER==DNI.ToString()
                                  select cli.NAME_CUSTOMER);
                    nameClient = dataNAME.FirstOrDefault();
                    NUMBERDNI = DNI;
                    return nameClient;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return nameClient;
        }
        private int GetIdeClient(int DNI)
        {
            int ID = 0;
            try
            {
                using (BODEGA_SACEntities db = new BODEGA_SACEntities())
                {
                    var dataId = (from cli in db.TB_CUSTOMER
                                    where cli.DNI_CUSTOMER == DNI.ToString()
                                    select cli.ID_CUSTOMER);
                    ID = dataId.FirstOrDefault();
                    return ID;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return ID;
        }

        private void btnAddToCartFast_Click(object sender, EventArgs e)
        {
            if (txtCodeProductFast.Text != ""&&txtAmountFast.Text!="")
            {

                int codeProd = int.Parse(txtCodeProductFast.Text.Trim().ToString());
                int amount = int.Parse(txtAmountFast.Text.Trim().ToString());
                AddToCart(codeProd, amount);
                txtCodeProductFast.Text = "";
                txtAmountFast.Text = "";
            }
        }

        private void btnDeleteProductToCartFast_Click_1(object sender, EventArgs e)
        {
            int cantrow = dvgCartFast.RowCount;
            if (cantrow==1)
            {
                int codeProd = int.Parse(dvgCartFast.Rows[0].Cells[1].Value.ToString());
                DeleteProductToCart(codeProd);
            }else if (cantrow > 1)
            {
                int codeProd = int.Parse(dvgCartFast.Rows[dvgCartFast.CurrentRow.Index].Cells[1].Value.ToString());
                DeleteProductToCart(codeProd);
            }
            else
            {
                MessageBox.Show("Seleccione un producto para eliminar del carrito");
            }
        }

        private void btnFinallySale_Click(object sender, EventArgs e)
        {
            TB_SALE sale = new TB_SALE();
            sale.ID_EMPLOYEE = CODE_EMPLOYEE;
            sale.ID_CUSTOMER = GetIdeClient(NUMBERDNI);
            sale.DATE_SALE = DateTime.Now;
            sale.TOTAL_SALE = Convert.ToDecimal(lblTotalSaleFast.Text.Trim().ToString());
            sale.STATUS_SALE = 1;
            ImportCancel = Convert.ToDecimal(txtImportCancelFast.Text.Trim());
            if (sale.TOTAL_SALE < ImportCancel)
            {
                MessageBox.Show($"Cantidad de Cambio: {ImportCancel - sale.TOTAL_SALE}", "Entrega de Cambio");
                if (FinallySale(sale, DATA_DETAIL_SALE))
                {
                    MessageBox.Show("¡Compra exitosa!", "Operación Exitosa");
                    CleanFormRegisterFastSale();
                }
                else
                {
                    MessageBox.Show("¡Error, intente nuevamente!", "Operación Erronea");
                }
            }
            else if(sale.TOTAL_SALE==ImportCancel)
            {
                if (FinallySale(sale, DATA_DETAIL_SALE))
                {
                    MessageBox.Show("¡Compra exitosa!", "Operación Exitosa");
                    CleanFormRegisterFastSale();
                }
                else
                {
                    MessageBox.Show("¡Error, intente nuevamente!", "Operación Erronea");
                }
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show($"Se registrará una deuda al nombre del cliente del total de: S/ {sale.TOTAL_SALE-ImportCancel}", "Registro de Deuda",MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    if (FinallySale(sale, DATA_DETAIL_SALE))
                    {
                        TB_DEBT debt = new TB_DEBT();
                        debt.ID_SALE = GetCodeSale();
                        debt.ID_CUSTOMER = GetIdeClient(NUMBERDNI);
                        debt.TOTAL_SALE = sale.TOTAL_SALE;
                        debt.AMOUNT_PAID_SALE = ImportCancel;
                        debt.AMOUNT_TO_PAY_SALE = sale.TOTAL_SALE - ImportCancel;
                        debt.STATUS_DEBT = 1;
                        using(BODEGA_SACEntities db= new BODEGA_SACEntities())
                        {
                            db.TB_DEBT.Add(debt);
                            db.SaveChanges();
                        }
                        MessageBox.Show("¡Compra exitosa!", "Operación Exitosa");
                        CleanFormRegisterFastSale();
                    }
                    else
                    {
                        MessageBox.Show("¡Error, intente nuevamente!", "Operación Erronea");
                    }
                }
            }
        }

        private void btnCloseFormRegisterSale_Click(object sender, EventArgs e)
        {
            DATA_DETAIL_SALE = new List<TB_DETAIL_SALE>();
            this.Close();
        }

        private void CleanFormRegisterFastSale()
        {
            txtDNIClient.Text = "";
            txtCodeProductFast.Text = "";
            txtAmountFast.Text = "";
            txtImportCancelFast.Text = "0.00";
            lblIGVSaleFast.Text = "0.00";
            lblTotalSaleFast.Text = "0.00";
            lblNameClient.Text = "";
            txtDNIClient.Focus();
            dvgCartFast.DataSource = null;
            NUMBERDNI = 0;
            DATA_DETAIL_SALE = new List<TB_DETAIL_SALE>();
            DATA_CART_TABLE = new List<CART>();
            ImportCancel = 0;

            panel1.Enabled = false;
            pnlTypeSaleFast.Enabled = false;
            btnFinallySale.Enabled = false;
            txtImportCancelFast.Enabled = false;
        }

        private TB_PRODUCT GetDataProduct(int code)
        {
            try
            {
                using (BODEGA_SACEntities db = new BODEGA_SACEntities())
                {
                    var dataProduct = (from prod in db.TB_PRODUCT where prod.CODE_PRODUCT == code select prod);
                    return dataProduct.FirstOrDefault();
                };
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message); 
            }
            return null;
        }

        private void AddToCart(int code, int amount)
        {
            TB_PRODUCT dataProduct = GetDataProduct(code);
            if (DATA_CART_TABLE == null)
            {
                AddProductToCart(dataProduct, amount);
            }
            else
            {
                List<TB_DETAIL_SALE> sale_detail = DATA_DETAIL_SALE;
                List<CART> cart = DATA_CART_TABLE;
                int index = getIndexToCart(code);
                if (index == -1)
                {
                    AddProductToCart(dataProduct, amount);
                }
                else
                {
                    if (amount <= dataProduct.STOCK_PRODUCT)
                    {
                        sale_detail[index].AMOUNT_PRODUCT_SALE = amount;
                        cart[index].CANTIDAD = amount;
                        cart[index].SUB_TOTAL = cart[index].PRECIO * amount;
                    }
                    else
                    {
                        MessageBox.Show($"No hay Stock suficiente. \nStock Disponible: {dataProduct.STOCK_PRODUCT}", "¡ Alerta !");
                        sale_detail[index].AMOUNT_PRODUCT_SALE = dataProduct.STOCK_PRODUCT;
                        cart[index].CANTIDAD = dataProduct.STOCK_PRODUCT;
                        cart[index].SUB_TOTAL = cart[index].PRECIO * amount;
                    }
                    ChangeTableSale();
                    ChangeTotalIgv();
                }
            }
        }

        private void AddProductToCart(TB_PRODUCT dataProduct, int amount)
        {
            try
            {
                if (dataProduct != null)
                {
                    // seteo de datos para la variable del detalle del carrito
                    TB_DETAIL_SALE sale = new TB_DETAIL_SALE();
                    sale.ID_PRODUCT = dataProduct.ID_PRODUCT;
                    sale.PRICE_PRODUCT_SALE = dataProduct.PRICE_PRODUCT;
                    if (amount <= dataProduct.STOCK_PRODUCT)
                    {
                        sale.AMOUNT_PRODUCT_SALE = amount;
                    }
                    else
                    {
                        sale.AMOUNT_PRODUCT_SALE = dataProduct.STOCK_PRODUCT;
                    }
                    DATA_DETAIL_SALE.Add(sale);
                    // carga de la data que se muestra en la tabla
                    CART table = new CART();
                    table.ID_PRODUCT = dataProduct.ID_PRODUCT;
                    table.CODIGO = dataProduct.CODE_PRODUCT;
                    table.PRODUCTO = dataProduct.NAME_PRODUCT;
                    table.PRECIO = dataProduct.PRICE_PRODUCT;
                    if(dataProduct.STOCK_PRODUCT==0)
                    {
                        MessageBox.Show($"No hay Stock suficiente. \nStock Disponible: {dataProduct.STOCK_PRODUCT}","¡ Alerta !");
                        return;
                    }
                    else if (amount <= dataProduct.STOCK_PRODUCT)
                    {
                        table.CANTIDAD = amount;
                    }
                    else
                    {
                        MessageBox.Show($"No hay Stock suficiente. \nStock Disponible: {dataProduct.STOCK_PRODUCT}", "¡ Alerta !");
                        table.CANTIDAD = dataProduct.STOCK_PRODUCT;
                    }
                    table.SUB_TOTAL = (dataProduct.PRICE_PRODUCT * amount);
                    DATA_CART_TABLE.Add(table);
                    ChangeTableSale();
                    ChangeTotalIgv();
                }
                else
                {
                    MessageBox.Show("Ingrese un Código de Producto Válido","Error");
                }
            }catch(Exception e)
            {
                throw;
            }
        }
        
        private void ChangeTableSale()
        {
            dvgCartFast.DataSource = DATA_CART_TABLE.ToList();
            dvgCartFast.Columns[0].Visible = false;
            dvgCartFast.AutoResizeColumns();
        }

        private void ChangeTotalIgv()
        {
            decimal total = 0;
            decimal Subtotal = 0;
            decimal igv = 0;
            if(DATA_CART_TABLE != null){
                foreach (var item in DATA_CART_TABLE)
                {
                    Subtotal += item.SUB_TOTAL;
                }
                igv = Subtotal* Convert.ToDecimal(0.18);
                lblIGVSaleFast.Text = igv.ToString();
                total = Subtotal + igv;
                lblTotalSaleFast.Text = total.ToString();
            }
        }
        
        private int getIndexToCart(int id)
        {
            List<CART> cart = DATA_CART_TABLE;
            for(int i=0; i < cart.Count; i++)
            {
                if (cart[i].CODIGO == id) return i;
            }
            return -1;
        }
        
        private void DeleteProductToCart(int id)
        {
            int index = getIndexToCart(id);
            if (index != -1)
            {
                DATA_CART_TABLE.RemoveAt(index);
                DATA_DETAIL_SALE.RemoveAt(index);
                ChangeTableSale();
                ChangeTotalIgv();
            }
        }

        private int GetCodeSale()
        {
            using (BODEGA_SACEntities db = new BODEGA_SACEntities())
            {
                var dataId = db.TB_SALE.OrderByDescending(x => x.ID_SALE).FirstOrDefault();
                return dataId.ID_SALE;
            }
        }

        private bool FinallySale(TB_SALE header, List<TB_DETAIL_SALE> body)
        {
            bool answer = false;
            bool answer2 = false;
            try
            {
                using (BODEGA_SACEntities db = new BODEGA_SACEntities())
                {
                    db.TB_SALE.Add(header);
                    answer=db.SaveChanges()>0;
                }
                if (answer)
                {
                    int id_SALE = GetCodeSale();
                    foreach (var item in body)
                    {
                        using (BODEGA_SACEntities db = new BODEGA_SACEntities())
                        {
                            TB_DETAIL_SALE detil = new TB_DETAIL_SALE
                            {
                                ID_SALE = id_SALE,
                                ID_PRODUCT = item.ID_PRODUCT,
                                PRICE_PRODUCT_SALE = item.PRICE_PRODUCT_SALE,
                                AMOUNT_PRODUCT_SALE = item.AMOUNT_PRODUCT_SALE
                            };
                            db.TB_DETAIL_SALE.Add(detil);
                            answer2=db.SaveChanges()>0;
                        }
                    }
                }
                return answer2;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message,"Error");
            }
            return false;
        }
    }
}