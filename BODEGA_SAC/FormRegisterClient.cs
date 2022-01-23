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
    public partial class FormRegisterClient : Form
    {
        public FormRegisterClient()
        {
            InitializeComponent();
        }

        private void btnCloseFormRegisterClient_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRegisterClient_Click(object sender, EventArgs e)
        {
            string name = txtNameClient.Text.Trim().ToUpper();
            string dni = txtDNIClient.Text.Trim();
            ValidateFormRegisterClient(name, dni);
        }
        private void ValidateFormRegisterClient(string name, string dni)
        {
            if (name.Trim() == null || name.Trim() == "")
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
                tb_client.NAME_CUSTOMER = name.Trim().ToUpper();
                tb_client.DNI_CUSTOMER = dni.Trim().ToUpper();
                tb_client.STATUS_CUSTOMER = 1;
                if (RegisterClient(tb_client))
                {
                    MessageBox.Show("Cliente Registrado.");
                    CleanFormRegisterClient();
                }
                else
                {
                    MessageBox.Show("Error! Intentelo más tarde.");
                    CleanFormRegisterClient();
                }
            }
        }

        private bool RegisterClient(TB_CUSTOMER client)
        {
            try
            {
                using (BODEGA_SACEntities db = new BODEGA_SACEntities())
                {
                    db.TB_CUSTOMER.Add(client);
                    return db.SaveChanges() > 0;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return false;
        }
        private void CleanFormRegisterClient()
        {
            txtNameClient.Text = "";
            txtDNIClient.Text = "";
            txtNameClient.Focus();
        }
    }
}
