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
    public partial class FormListDebt : Form
    {
        public FormListDebt()
        {
            InitializeComponent();
        }

        private void FormListDebt_Load(object sender, EventArgs e)
        {
            loadTableAllDebt();
        }
        private void loadTableAllDebt()
        {
            try
            {
                using (BODEGA_SACEntities db = new BODEGA_SACEntities())
                {
                    var listaAllDebt = (from debt in db.TB_DEBT
                                                 join sale in db.TB_SALE on debt.ID_SALE equals sale.ID_SALE
                                                 join custo in db.TB_CUSTOMER on sale.ID_CUSTOMER equals custo.ID_CUSTOMER
                                        where debt.STATUS_DEBT!=0
                                                 select new
                                                 {
                                                     ID = debt.ID_DEBT,
                                                     ID_VENTA = debt.ID_SALE,
                                                     ID_CLIENTE=custo.ID_CUSTOMER,
                                                     CLIENTE=custo.NAME_CUSTOMER,
                                                     FECHA = sale.DATE_SALE,
                                                     TOTAL_COMPRA = debt.TOTAL_SALE,
                                                     PAGADO = debt.AMOUNT_PAID_SALE,
                                                     POR_PAGAR = debt.AMOUNT_TO_PAY_SALE
                                                 });
                    dgvTableAllDebt.DataSource = listaAllDebt.ToList();
                    dgvTableAllDebt.Columns[0].Visible = false;
                    dgvTableAllDebt.Columns[2].Visible = false;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void btnCloseFormListDebt_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
