using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http.Json;
using FuelStationFinal.Shared.ViewModels;

namespace FuelStation.Win
{
    public partial class CustomerListForm : Form
    {
        private bool AddCustomer=true;
        HttpClient httpClient = new HttpClient();
        public CustomerListForm()
        {
            InitializeComponent();
        }
        private async Task RefreshData()
        {
            grvCustomer.DataSource = null;
            grvCustomer.DataSource = await httpClient.GetFromJsonAsync<List<CustomerListViewModel>>("https://localhost:7128/customer");
            grvCustomer.Update();
            grvCustomer.Refresh();
            grvCustomer.Columns["ID"].Visible = false;
        }

        private void CustomerListForm_Load(object sender, EventArgs e)
        {
            grvCustomer.ReadOnly = true;
            RefreshData();
        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            
            CustomerForm form = new CustomerForm();
            form.ShowDialog();
            await RefreshData();
        }

        private async void btnEdit_Click(object sender, EventArgs e)
        {
            AddCustomer = false;
            if (grvCustomer.SelectedRows.Count != 1)
                return;
            var selectedCustomer = (CustomerListViewModel)grvCustomer.SelectedRows[index: 0].DataBoundItem;
            var customer = new CustomerForm(selectedCustomer,AddCustomer);
            customer.ShowDialog();
            await RefreshData();
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            if (grvCustomer.SelectedRows.Count != 1)
                return;
            var selectedCustomer = (CustomerListViewModel)grvCustomer.SelectedRows[index: 0].DataBoundItem;
            var response = await httpClient.DeleteAsync($"https://localhost:7128/customer/{selectedCustomer.ID}/");
            response.EnsureSuccessStatusCode();
            await RefreshData();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
