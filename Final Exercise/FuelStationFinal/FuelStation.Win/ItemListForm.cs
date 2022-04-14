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

namespace FuelStation.Win
{
    public partial class ItemListForm : Form
    {
        HttpClient httpClient = new HttpClient();
        private bool addItem = true;
        public ItemListForm()
        {
            InitializeComponent();
        }
        private async Task RefreshData()
        {
            grvItem.DataSource = null;
            grvItem.DataSource = await httpClient.GetFromJsonAsync<List<ItemListViewModel>>("https://localhost:7128/item");
            grvItem.Update();
            grvItem.Refresh();
            grvItem.Columns["ID"].Visible = false;
        }

        private void ItemForm_Load(object sender, EventArgs e)
        {
            grvItem.ReadOnly = true;
            RefreshData();
        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            ItemForm form = new ItemForm();
            form.ShowDialog();
            await RefreshData();
        }

        private async void btnEdit_Click(object sender, EventArgs e)
        {
            addItem = false;
            if (grvItem.SelectedRows.Count != 1)
                return;
            var selectedItem = (ItemListViewModel)grvItem.SelectedRows[index: 0].DataBoundItem;
            var item = new ItemForm(selectedItem,addItem);
            item.ShowDialog();
            await RefreshData();
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            //if (grvItem.SelectedRows.Count != 1)
            //    return;
            var selectedItem = (ItemListViewModel)grvItem.SelectedRows[index: 0].DataBoundItem;
            var response = await httpClient.DeleteAsync($"https://localhost:7128/item/{selectedItem.ID}/");
            response.EnsureSuccessStatusCode();
            await RefreshData();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
