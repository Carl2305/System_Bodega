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
    public partial class FormUpdateBebt : Form
    {
        private int role = 2;
        private int NUMBERDNI = 0;
        private int ID_CUSTOMER = 0;
        public FormUpdateBebt(int role)
        {
            this.role = role;
            InitializeComponent();
        }

        private void btnSearchDNI_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtDNIClient.Text.Trim() != "")
                {
                    int DNI = Convert.ToInt32(txtDNIClient.Text.Trim());
                    lblNameClient.Text = GetNameClient(DNI);
                    ID_CUSTOMER = GetIdeClient(NUMBERDNI);
                    if (ID_CUSTOMER != 0)
                    {
                        loadTableDebtForCustomer(ID_CUSTOMER);
                    }
                    else
                    {
                        MessageBox.Show("Ingrese un DNI válido", "Error");
                        txtDNIClient.Focus();
                    }
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message,"Error");
            }
        }

        private void btnCloseFormUpdateDebt_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private string GetNameClient(int DNI)
        {
            string nameClient = "";
            try
            {
                using (BODEGA_SACEntities db = new BODEGA_SACEntities())
                {
                    var dataNAME = (from cli in db.TB_CUSTOMER
                                    where cli.DNI_CUSTOMER == DNI.ToString()
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
        private void loadTableDebtForCustomer(int ID)
        {
            try
            {
                using (BODEGA_SACEntities db = new BODEGA_SACEntities())
                {
                    var listaAllDebtForClient = (from debt in db.TB_DEBT
                                             join sale in db.TB_SALE on debt.ID_SALE equals sale.ID_SALE
                                             where debt.ID_CUSTOMER==ID && debt.STATUS_DEBT != 0
                                             select new
                                             {
                                                 ID=debt.ID_DEBT,
                                                 ID_VENTA=debt.ID_SALE,
                                                 FECHA = sale.DATE_SALE,
                                                 TOTAL_COMPRA = debt.TOTAL_SALE,
                                                 PAGADO = debt.AMOUNT_PAID_SALE,
                                                 POR_PAGAR = debt.AMOUNT_TO_PAY_SALE
                                             });
                    dgvTableAllDebtForCustomer.DataSource = listaAllDebtForClient.ToList();
                    dgvTableAllDebtForCustomer.Columns[0].Visible = false;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void dgvTableAllDebtForCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lblIdDebt.Text = dgvTableAllDebtForCustomer.Rows[dgvTableAllDebtForCustomer.CurrentRow.Index].Cells[0].Value.ToString();
            lblTotalSale.Text = dgvTableAllDebtForCustomer.Rows[dgvTableAllDebtForCustomer.CurrentRow.Index].Cells[3].Value.ToString();
            lblDebt.Text = dgvTableAllDebtForCustomer.Rows[dgvTableAllDebtForCustomer.CurrentRow.Index].Cells[5].Value.ToString();
            txtAmountPay.Text = dgvTableAllDebtForCustomer.Rows[dgvTableAllDebtForCustomer.CurrentRow.Index].Cells[4].Value.ToString();
            btnAmortizar.Enabled = true;
        }

        private bool AmortizarDebt(int ID_DEBT, decimal AMOUNT_PAID_SALE)
        {
            try
            {
                using(BODEGA_SACEntities db= new BODEGA_SACEntities())
                {
                    TB_DEBT dataDebt = db.TB_DEBT.Find(ID_DEBT);
                    dataDebt.AMOUNT_PAID_SALE = dataDebt.AMOUNT_PAID_SALE + AMOUNT_PAID_SALE;
                    dataDebt.AMOUNT_TO_PAY_SALE = dataDebt.TOTAL_SALE - dataDebt.AMOUNT_PAID_SALE;
                    db.Entry(dataDebt).State = System.Data.Entity.EntityState.Modified;
                    return db.SaveChanges() > 0;
                }
            }catch(Exception e)
            {
                MessageBox.Show(e.Message, "Error");
                return false;
            }
        }

        private void btnAmortizar_Click(object sender, EventArgs e)
        {
            int id=Convert.ToInt32(lblIdDebt.Text.Trim());
            decimal txtamount_pay = Convert.ToDecimal(txtAmountPay.Text.Trim());
            decimal debt = Convert.ToDecimal(lblDebt.Text.Trim());
            decimal total_sale = Convert.ToDecimal(lblTotalSale.Text.Trim());
            decimal Import_Cancel = total_sale-(debt + txtamount_pay);
            if (AmortizarDebt(id, txtamount_pay))
            {
                MessageBox.Show("Amortización Correcta", "Operación Exitosa");
            }
            else
            {
                MessageBox.Show("Error al amortizar la deuda", "Operación Fallida");
            }
            loadTableDebtForCustomer(ID_CUSTOMER);
            cleanFormUpdateDebt();
        }
        private void cleanFormUpdateDebt()
        {
            txtDNIClient.Text = "";
            lblNameClient.Text = "";
            lblIdDebt.Text = "----";
            lblTotalSale.Text = "0.00";
            lblDebt.Text = "0.00";
            txtAmountPay.Text = "";
            btnAmortizar.Enabled = false;
            NUMBERDNI = 0;
            ID_CUSTOMER = 0;
            dgvTableAllDebtForCustomer.DataSource = null;
            txtDNIClient.Focus();
        }

        private void FormUpdateBebt_Load(object sender, EventArgs e)
        {
            cleanFormUpdateDebt();
            if (role == 1)
            {
                pnlAmortizar.Enabled = true;
                pnlAmortizar.Visible = true;
            }
            else
            {
                label1.Text = "Buscar Deudas";
                pnlAmortizar.Enabled = false;
                pnlAmortizar.Visible = false;
            }
        }
    }
}
