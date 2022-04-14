using System;
using FuelStationFinal.Shared.ViewModels;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http.Json;

namespace FuelStation.Win
{
    public partial class CustomerForm : Form
    {
        private CustomerListViewModel _customerViewModel;
        private bool _addCustomer=true;
        HttpClient httpClient = new HttpClient();
        public CustomerForm()
        {
            InitializeComponent();
        }
        public CustomerForm(CustomerListViewModel customer,bool addCustomer) : this()
        {
            _customerViewModel = customer;
            _addCustomer = addCustomer;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void CustomerForm_Load(object sender, EventArgs e)
        {
            if (_customerViewModel == null)
            {
                _customerViewModel = new CustomerListViewModel();
            }
            bsCustomers.DataSource = _customerViewModel;
            SetDataBindings();

        }
        private void SetDataBindings()
        {
            txtCardNumber.DataBindings.Add(new Binding("Text", bsCustomers, "CardNumber", true));
            txtName.DataBindings.Add(new Binding("Text", bsCustomers, "Name", true));
            txtSurname.DataBindings.Add(new Binding("Text", bsCustomers, "Surname", true));

        }
        private async void btnSave_Click(object sender, EventArgs e)
        {
            
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void btnSave_Click_1(object sender, EventArgs e)
        {
            //if (_customerViewModel.ID == Guid.Empty)
            if(_addCustomer==true)
            {
                var response = await httpClient.PostAsJsonAsync("https://localhost:7128/customer", _customerViewModel);
                response.EnsureSuccessStatusCode();
            }
            else
            {
                var response = await httpClient.PutAsJsonAsync("https://localhost:7128/customer", _customerViewModel);
                response.EnsureSuccessStatusCode();

            }
            this.Close();

        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
