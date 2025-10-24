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
    public partial class InventoryDataField : UserControl
    {
        public int ItemID
        {
            get
            {
                if (int.TryParse(txtID.Text, out int id))
                {
                    return id;
                }
                return -1;
            }
            set => txtID.Text = value.ToString();
        }

        public int ItemQuantity
        {
            get
            {
                if (int.TryParse(txtQuantity.Text, out int quantity))
                {
                    return quantity;
                }
                return 0;
            }
            set => txtQuantity.Text = value.ToString();
        }

        public decimal ItemPrice
        {
            get
            {
                if (decimal.TryParse(txtPrice.Text, out decimal price))
                {
                    return price;
                }
                return 0;
            }
            set => txtPrice.Text = value.ToString();
        }
        public string ItemName
        {
            get => txtName.Text;
            set => txtName.Text = value;
        }
        public string ItemSupplier
        {
            get => String.IsNullOrWhiteSpace(txtSupplier.Text) ? "None" : txtSupplier.Text;
            set => txtSupplier.Text = value;
        }
        public string StockLevel
        {
            get => txtStockLevel.Text;
            set => txtStockLevel.Text = value;
        }

        public InventoryDataField()
        {
            InitializeComponent();

        }
        public void ClearFields()
        {
            txtName.Clear();
            txtID.Clear();
            txtSupplier.Clear();
            txtQuantity.Clear();
            txtPrice.Clear();
            txtStockLevel.Clear();
        }

        public void ValidateNumericField(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                if (e.KeyChar == '.' && !((TextBox)sender).Text.Contains(".")) return;
                e.Handled = true;
            }
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void InventoryDataField_Load(object sender, EventArgs e)
        {

        }
    }
}
