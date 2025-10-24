namespace InventorySystemWinform
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            dataGridInventory = new DataGridView();
            dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn7 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn8 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn9 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn10 = new DataGridViewTextBoxColumn();
            stockLevelDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            inventoryItemBindingSource = new BindingSource(components);
            btnAdd = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            groupBoxFilters = new GroupBox();
            btnApply = new Button();
            btnClear = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            lblName = new Label();
            txtFilterName = new TextBox();
            lblSupplier = new Label();
            txtFilterSupplier = new TextBox();
            cmbFilterStockLevel = new CheckedListBox();
            panel1 = new Panel();
            inventoryDataField = new InventoryDataField();
            flowLayoutPanel2 = new FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)dataGridInventory).BeginInit();
            ((System.ComponentModel.ISupportInitialize)inventoryItemBindingSource).BeginInit();
            groupBoxFilters.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridInventory
            // 
            dataGridInventory.AutoGenerateColumns = false;
            dataGridInventory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridInventory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridInventory.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn6, dataGridViewTextBoxColumn7, dataGridViewTextBoxColumn8, dataGridViewTextBoxColumn9, dataGridViewTextBoxColumn10, stockLevelDataGridViewTextBoxColumn });
            dataGridInventory.DataSource = inventoryItemBindingSource;
            dataGridInventory.Dock = DockStyle.Fill;
            dataGridInventory.Location = new Point(0, 0);
            dataGridInventory.Margin = new Padding(3, 4, 3, 4);
            dataGridInventory.MultiSelect = false;
            dataGridInventory.Name = "dataGridInventory";
            dataGridInventory.ReadOnly = true;
            dataGridInventory.RowHeadersWidth = 62;
            dataGridInventory.RowTemplate.Height = 28;
            dataGridInventory.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridInventory.Size = new Size(864, 544);
            dataGridInventory.TabIndex = 0;
            dataGridInventory.CellClick += dataGridInventory_CellContentClick;
            // 
            // dataGridViewTextBoxColumn6
            // 
            dataGridViewTextBoxColumn6.DataPropertyName = "Id";
            dataGridViewTextBoxColumn6.HeaderText = "Id";
            dataGridViewTextBoxColumn6.MinimumWidth = 8;
            dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            dataGridViewTextBoxColumn6.ReadOnly = true;
            dataGridViewTextBoxColumn6.Visible = false;
            // 
            // dataGridViewTextBoxColumn7
            // 
            dataGridViewTextBoxColumn7.DataPropertyName = "Name";
            dataGridViewTextBoxColumn7.HeaderText = "Name";
            dataGridViewTextBoxColumn7.MinimumWidth = 8;
            dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            dataGridViewTextBoxColumn8.DataPropertyName = "Quantity";
            dataGridViewTextBoxColumn8.HeaderText = "Quantity";
            dataGridViewTextBoxColumn8.MinimumWidth = 8;
            dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            dataGridViewTextBoxColumn9.DataPropertyName = "Price";
            dataGridViewTextBoxColumn9.HeaderText = "Price";
            dataGridViewTextBoxColumn9.MinimumWidth = 8;
            dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            dataGridViewTextBoxColumn9.ReadOnly = true;
            dataGridViewTextBoxColumn9.Visible = false;
            // 
            // dataGridViewTextBoxColumn10
            // 
            dataGridViewTextBoxColumn10.DataPropertyName = "Supplier";
            dataGridViewTextBoxColumn10.HeaderText = "Supplier";
            dataGridViewTextBoxColumn10.MinimumWidth = 8;
            dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            dataGridViewTextBoxColumn10.ReadOnly = true;
            dataGridViewTextBoxColumn10.Visible = false;
            // 
            // stockLevelDataGridViewTextBoxColumn
            // 
            stockLevelDataGridViewTextBoxColumn.DataPropertyName = "StockLevel";
            stockLevelDataGridViewTextBoxColumn.HeaderText = "StockLevel";
            stockLevelDataGridViewTextBoxColumn.MinimumWidth = 8;
            stockLevelDataGridViewTextBoxColumn.Name = "stockLevelDataGridViewTextBoxColumn";
            stockLevelDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // inventoryItemBindingSource
            // 
            inventoryItemBindingSource.DataSource = typeof(InventoryItem);
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(3, 4);
            btnAdd.Margin = new Padding(3, 4, 3, 4);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(125, 54);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "Add Item";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(134, 4);
            btnEdit.Margin = new Padding(3, 4, 3, 4);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(125, 54);
            btnEdit.TabIndex = 3;
            btnEdit.Text = "Edit Item";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(265, 4);
            btnDelete.Margin = new Padding(3, 4, 3, 4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(125, 54);
            btnDelete.TabIndex = 4;
            btnDelete.Text = "Delete Item";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // groupBoxFilters
            // 
            groupBoxFilters.Controls.Add(btnApply);
            groupBoxFilters.Controls.Add(btnClear);
            groupBoxFilters.Controls.Add(flowLayoutPanel1);
            groupBoxFilters.Dock = DockStyle.Bottom;
            groupBoxFilters.Font = new Font("Microsoft Sans Serif", 12F);
            groupBoxFilters.Location = new Point(0, 544);
            groupBoxFilters.Margin = new Padding(3, 4, 3, 4);
            groupBoxFilters.Name = "groupBoxFilters";
            groupBoxFilters.Padding = new Padding(3, 4, 3, 4);
            groupBoxFilters.Size = new Size(1305, 249);
            groupBoxFilters.TabIndex = 6;
            groupBoxFilters.TabStop = false;
            groupBoxFilters.Text = "Filters";
            // 
            // btnApply
            // 
            btnApply.Font = new Font("Microsoft Sans Serif", 10F);
            btnApply.Location = new Point(826, 114);
            btnApply.Margin = new Padding(3, 4, 3, 4);
            btnApply.Name = "btnApply";
            btnApply.Size = new Size(148, 58);
            btnApply.TabIndex = 3;
            btnApply.Text = "Apply";
            btnApply.UseVisualStyleBackColor = true;
            btnApply.Click += btnApply_Click;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Microsoft Sans Serif", 10F);
            btnClear.Location = new Point(826, 54);
            btnClear.Margin = new Padding(3, 4, 3, 4);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(148, 58);
            btnClear.TabIndex = 2;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(lblName);
            flowLayoutPanel1.Controls.Add(txtFilterName);
            flowLayoutPanel1.Controls.Add(lblSupplier);
            flowLayoutPanel1.Controls.Add(txtFilterSupplier);
            flowLayoutPanel1.Controls.Add(cmbFilterStockLevel);
            flowLayoutPanel1.Font = new Font("Microsoft Sans Serif", 10F);
            flowLayoutPanel1.Location = new Point(22, 52);
            flowLayoutPanel1.Margin = new Padding(3, 4, 3, 4);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(761, 220);
            flowLayoutPanel1.TabIndex = 1;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(3, 0);
            lblName.Name = "lblName";
            lblName.Size = new Size(64, 25);
            lblName.TabIndex = 0;
            lblName.Text = "Name";
            // 
            // txtFilterName
            // 
            txtFilterName.Location = new Point(73, 4);
            txtFilterName.Margin = new Padding(3, 4, 3, 4);
            txtFilterName.Name = "txtFilterName";
            txtFilterName.Size = new Size(263, 30);
            txtFilterName.TabIndex = 1;
            // 
            // lblSupplier
            // 
            lblSupplier.AutoSize = true;
            lblSupplier.Location = new Point(342, 0);
            lblSupplier.Name = "lblSupplier";
            lblSupplier.Size = new Size(84, 25);
            lblSupplier.TabIndex = 2;
            lblSupplier.Text = "Supplier";
            // 
            // txtFilterSupplier
            // 
            txtFilterSupplier.Location = new Point(432, 4);
            txtFilterSupplier.Margin = new Padding(3, 4, 3, 4);
            txtFilterSupplier.Name = "txtFilterSupplier";
            txtFilterSupplier.Size = new Size(263, 30);
            txtFilterSupplier.TabIndex = 3;
            // 
            // cmbFilterStockLevel
            // 
            cmbFilterStockLevel.FormattingEnabled = true;
            cmbFilterStockLevel.Items.AddRange(new object[] { "In Stock", "Low Stock", "Out of Stock" });
            cmbFilterStockLevel.Location = new Point(3, 42);
            cmbFilterStockLevel.Margin = new Padding(3, 4, 3, 4);
            cmbFilterStockLevel.Name = "cmbFilterStockLevel";
            cmbFilterStockLevel.Size = new Size(305, 139);
            cmbFilterStockLevel.TabIndex = 4;
            // 
            // panel1
            // 
            panel1.Controls.Add(inventoryDataField);
            panel1.Controls.Add(flowLayoutPanel2);
            panel1.Dock = DockStyle.Right;
            panel1.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel1.Location = new Point(864, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(441, 544);
            panel1.TabIndex = 7;
            // 
            // inventoryDataField
            // 
            inventoryDataField.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            inventoryDataField.ItemID = -1;
            inventoryDataField.ItemName = "";
            inventoryDataField.ItemPrice = new decimal(new int[] { 0, 0, 0, 0 });
            inventoryDataField.ItemQuantity = 0;
            inventoryDataField.ItemSupplier = "None";
            inventoryDataField.Location = new Point(0, 0);
            inventoryDataField.Margin = new Padding(3, 4, 3, 4);
            inventoryDataField.Name = "inventoryDataField";
            inventoryDataField.Size = new Size(403, 425);
            inventoryDataField.StockLevel = "";
            inventoryDataField.TabIndex = 8;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Controls.Add(btnAdd);
            flowLayoutPanel2.Controls.Add(btnEdit);
            flowLayoutPanel2.Controls.Add(btnDelete);
            flowLayoutPanel2.Location = new Point(6, 433);
            flowLayoutPanel2.Margin = new Padding(3, 4, 3, 4);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(397, 63);
            flowLayoutPanel2.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1305, 793);
            Controls.Add(dataGridInventory);
            Controls.Add(panel1);
            Controls.Add(groupBoxFilters);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "INVENTORY SYSTEM";
            FormClosing += Form1_FormClosing;
            ((System.ComponentModel.ISupportInitialize)dataGridInventory).EndInit();
            ((System.ComponentModel.ISupportInitialize)inventoryItemBindingSource).EndInit();
            groupBoxFilters.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            panel1.ResumeLayout(false);
            flowLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridInventory;
        private System.Windows.Forms.BindingSource inventoryItemBindingSource;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplierDataGridViewTextBoxColumn;
        private InventoryDataField inventoryDataField1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockLevelDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox groupBoxFilters;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtFilterName;
        private System.Windows.Forms.Label lblSupplier;
        private System.Windows.Forms.TextBox txtFilterSupplier;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.CheckedListBox cmbFilterStockLevel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private InventoryDataField inventoryDataField;
    }
}

