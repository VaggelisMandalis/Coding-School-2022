using FuelStationFinal.Shared.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static FuelStation.Models.Entities.Enums;

namespace FuelStation.Win
{
    public partial class ItemForm : Form
    {
        private ItemListViewModel _itemViewModel;
        HttpClient httpClient= new HttpClient();
        private bool _addItem = true;
        public ItemForm()
        {

            InitializeComponent();
        }
        public ItemForm(ItemListViewModel item, bool addItem) : this()
        {
            _itemViewModel = item;
            _addItem = addItem;
        }

        private void ItemForm_Load(object sender, EventArgs e)
        {
            if (_itemViewModel == null)
            {
                _itemViewModel = new ItemListViewModel();
            }
            bsItems.DataSource = _itemViewModel;
            SetDataBindings();
        }
        private void SetDataBindings()
        {
            string[] itemType = Enum.GetNames(typeof(ItemType));
            cmbItemType.Items.AddRange(itemType);
            cmbItemType.DataBindings.Add(new Binding("Text", bsItems, "ItemType", true));
            txtCode.DataBindings.Add(new Binding("Text", bsItems, "Code", true));
            txtDescription.DataBindings.Add(new Binding("Text", bsItems, "Description", true));
            txtPrice.DataBindings.Add(new Binding("Text", bsItems, "Price", true));
            txtCost.DataBindings.Add(new Binding("Text", bsItems, "Cost", true));

        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            //if (_itemViewModel.ID == Guid.Empty)
            if (txtCode.Text == "" || txtDescription.Text == "")
            {
                MessageBox.Show("Code or Description fields are empty", "Data Entry Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCode.Focus();
            }
            else if ((int.TryParse(txtPrice.Text, out int code) && code <= 0)|| (int.TryParse(txtCost.Text, out int amount) && amount <= 0))
            {
                MessageBox.Show("Price or Cost fields can not be negative", "Data Entry Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCode.Focus();
            }
            else if (_addItem == true)
            {
                var response = await httpClient.PostAsJsonAsync("https://localhost:7128/item", _itemViewModel);
                response.EnsureSuccessStatusCode();
            }
            else
            {
                var response = await httpClient.PutAsJsonAsync("https://localhost:7128/item", _itemViewModel);
                response.EnsureSuccessStatusCode();

            }
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
