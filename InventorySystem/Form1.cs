using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventorySystemWinform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            MainApp.Initialize();
            MainApp.InventoryUpdated += (s, e) =>
            {
                ApplyFilter(); inventoryItemBindingSource.ResetBindings(false);
            };
            MainApp.ErrorOccured += (s, e) =>
            {
                MessageBox.Show(e, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            };
            inventoryItemBindingSource.DataSource = MainApp.Inventory;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(inventoryDataField.ItemName))
            {
                MessageBox.Show("Invalid Input", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            MainApp.AddItem(inventoryDataField.ItemName, inventoryDataField.ItemQuantity,
                inventoryDataField.ItemPrice, inventoryDataField.ItemSupplier);
            inventoryDataField.ClearFields();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (inventoryDataField.ItemID < 0)
            {
                MessageBox.Show("No Item Selected", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            
            MainApp.EditItem(inventoryDataField.ItemID - 1, inventoryDataField.ItemName,
                inventoryDataField.ItemQuantity, inventoryDataField.ItemPrice, inventoryDataField.ItemSupplier);
            SetInventoryDataField(MainApp.GetItemById(inventoryDataField.ItemID));
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (inventoryDataField.ItemID < 0)
            {
                MessageBox.Show("No Item Selected", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            MainApp.DeleteItem(inventoryDataField.ItemID - 1);
        }
        private void SetInventoryDataField(InventoryItem item)
        {
            inventoryDataField.ItemID = item.Id;
            inventoryDataField.ItemName = item.Name;
            inventoryDataField.ItemQuantity = item.Quantity;
            inventoryDataField.ItemPrice = item.Price;
            inventoryDataField.ItemSupplier = item.Supplier;
            inventoryDataField.StockLevel = item.StockLevel;
        }
        private void dataGridInventory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        { 
            SetInventoryDataField(MainApp.GetItemById(Convert.ToInt32(dataGridInventory.Rows[e.RowIndex].Cells[0].Value)));
        }
        private void ApplyFilter()
        {
            InventoryItem[] items = MainApp.GetInventoryItems(
                name: txtFilterName.Text,
                supplier: txtFilterSupplier.Text,
                cmbFilterStockLevel.CheckedItems.Count == 0 ? null : cmbFilterStockLevel.CheckedItems.Cast<String>().ToArray()
            ).ToArray();

            inventoryItemBindingSource.DataSource = items;
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
           ApplyFilter();
           inventoryItemBindingSource.ResetBindings(false);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtFilterName.Clear();
            txtFilterSupplier.Clear();
            cmbFilterStockLevel.SelectedIndex = -1;

            for (int i = 0; i < cmbFilterStockLevel.Items.Count; i++)
            {
                cmbFilterStockLevel.SetItemChecked(i, false);
            }

            inventoryItemBindingSource.DataSource = MainApp.Inventory;
            inventoryItemBindingSource.ResetBindings(false);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            MainApp.WriteToFile(); Close();
        }
    }
}
