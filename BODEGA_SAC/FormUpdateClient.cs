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
    public partial class FormUpdateClient : Form
    {
        private int CodeCustomer = 0;
        public FormUpdateClient()
        {
            InitializeComponent();
        }

        private void FormUpdateClient_Load(object sender, EventArgs e)
        {
            loadTableAllClients();
        }

        private void loadTableAllClients()
        {
            try
            {
                using (BODEGA_SACEntities db = new BODEGA_SACEntities())
                {
                    var listAllClients = (from cli in db.TB_CUSTOMER
                                            select new
                                            {
                                                ID = cli.ID_CUSTOMER,
                                                NOMBRE = cli.NAME_CUSTOMER,
                                                DNI = cli.DNI_CUSTOMER
                                            });
                    dgvTableAllClient.DataSource = listAllClients.ToList();
                    dgvTableAllClient.Columns[0].Visible = false;
                    dgvTableAllClient.AutoResizeColumns();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void btnCloseFormRegisterClient_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRegisterClient_Click(object sender, EventArgs e)
        {
            string name = txtNameClient.Text.Trim().ToUpper();
            string dni = txtDNIClient.Text.Trim();
            ValidateFormUpdateClient(CodeCustomer, name, dni);
        }

        private void dgvTableAllClient_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtNameClient.Text = dgvTableAllClient.Rows[dgvTableAllClient.CurrentRow.Index].Cells[1].Value.ToString();
            txtDNIClient.Text = dgvTableAllClient.Rows[dgvTableAllClient.CurrentRow.Index].Cells[2].Value.ToString();
            CodeCustomer = int.Parse(dgvTableAllClient.Rows[dgvTableAllClient.CurrentRow.Index].Cells[0].Value.ToString());
            txtNameClient.ReadOnly = false;
            txtDNIClient.ReadOnly = false;
        }

        private void CleanFormUpdateClient()
        {
            CodeCustomer = 0;
            txtNameClient.Text = "";
            txtDNIClient.Text = "";
            txtNameClient.ReadOnly = true;
            txtDNIClient.ReadOnly = true;
        }

        private void ValidateFormUpdateClient(int id, string name, string dni)
        {
            if (CodeCustomer == 0)
            {
                MessageBox.Show("Seleccione un Cliente para edtar.","Error");
            }
            else if (name.Trim() == null || name.Trim() == "")
            {
                MessageBox.Show("Ingrese un Nombre del cliente.", "Faltan Datos");
                txtNameClient.Focus();
            }
            else if (dni.Trim() == null || dni.Trim() == "")
            {
                MessageBox.Show("Ingrese el DNI del cliente.", "Faltan Datos");
                txtDNIClient.Focus();
            }
            else
            {
                TB_CUSTOMER tb_client = new TB_CUSTOMER();
                tb_client.ID_CUSTOMER = CodeCustomer;
                tb_client.NAME_CUSTOMER = name.Trim().ToUpper();
                tb_client.DNI_CUSTOMER = dni.Trim().ToUpper();
                tb_client.STATUS_CUSTOMER = 1;
                if (UpdateClient(tb_client))
                {
                    MessageBox.Show("Cliente Actualizado.");
                    CleanFormUpdateClient();
                    loadTableAllClients();
                }
                else
                {
                    MessageBox.Show("Error! Intentelo más tarde.");
                    CleanFormUpdateClient();
                }
            }
        }

        private bool UpdateClient(TB_CUSTOMER client)
        {
            try
            {
                using (BODEGA_SACEntities db = new BODEGA_SACEntities())
                {
                    TB_CUSTOMER dataCustomer = db.TB_CUSTOMER.Find(client.ID_CUSTOMER);
                    dataCustomer.NAME_CUSTOMER = client.NAME_CUSTOMER;
                    dataCustomer.DNI_CUSTOMER = client.DNI_CUSTOMER;
                    dataCustomer.STATUS_CUSTOMER = client.STATUS_CUSTOMER;
                    db.Entry(dataCustomer).State = System.Data.Entity.EntityState.Modified;
                    return db.SaveChanges() > 0;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return false;
        }
    }
}
