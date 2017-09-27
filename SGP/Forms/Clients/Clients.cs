using SGP.Helpers;
using SGP.Repository;
using SGP.Models;
using System;
using System.Windows.Forms;
using SGP.Enums;

namespace SGP.Forms.Clients
{
    public partial class Clients : Form
    {
        #region Declaraciones Globales
        private ClientsRepository Client;
        #endregion

        public Clients()
        {
            Client = new ClientsRepository();
            InitializeComponent();
        }

        private void Clients_Load(object sender, EventArgs e)
        {
            Helper.HideTabs(tab);
            dataGridClients.Rows.Clear();
            foreach (Models.Clients client in Client.FindAll())
            {
                dataGridClients.Rows.Add(
                    client.Id,
                    client.FullName,
                    ((AppEnums.ClientType)client.ClientType).ToName(),
                    client.Identification);
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            list.Hide();
            form.Show();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            form.Hide();
            list.Show();
        }

        private void Clients_FormClosed(object sender, FormClosedEventArgs e)
        {
            Main.clientForm = null;
        }
    }
}
