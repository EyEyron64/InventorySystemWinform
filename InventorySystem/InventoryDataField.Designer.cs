namespace InventorySystemWinform
{
    partial class InventoryDataField
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            stockLevelLabel = new Label();
            txtStockLevel = new TextBox();
            idLabel = new Label();
            txtID = new TextBox();
            btnClear = new Button();
            supplierLabel = new Label();
            txtSupplier = new TextBox();
            priceLabel = new Label();
            txtPrice = new TextBox();
            quantityLabel = new Label();
            txtQuantity = new TextBox();
            nameLabel = new Label();
            txtName = new TextBox();
            SuspendLayout();
            // 
            // stockLevelLabel
            // 
            stockLevelLabel.AutoSize = true;
            stockLevelLabel.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            stockLevelLabel.Location = new Point(22, 274);
            stockLevelLabel.Name = "stockLevelLabel";
            stockLevelLabel.Size = new Size(103, 22);
            stockLevelLabel.TabIndex = 57;
            stockLevelLabel.Text = "Stock Level";
            // 
            // txtStockLevel
            // 
            txtStockLevel.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtStockLevel.Location = new Point(165, 271);
            txtStockLevel.Name = "txtStockLevel";
            txtStockLevel.ReadOnly = true;
            txtStockLevel.Size = new Size(228, 28);
            txtStockLevel.TabIndex = 56;
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            idLabel.Location = new Point(23, 25);
            idLabel.Name = "idLabel";
            idLabel.Size = new Size(27, 22);
            idLabel.TabIndex = 55;
            idLabel.Text = "ID";
            // 
            // txtID
            // 
            txtID.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtID.Location = new Point(129, 22);
            txtID.Name = "txtID";
            txtID.ReadOnly = true;
            txtID.Size = new Size(264, 28);
            txtID.TabIndex = 54;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnClear.Location = new Point(249, 326);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(144, 53);
            btnClear.TabIndex = 53;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // supplierLabel
            // 
            supplierLabel.AutoSize = true;
            supplierLabel.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            supplierLabel.Location = new Point(22, 219);
            supplierLabel.Name = "supplierLabel";
            supplierLabel.Size = new Size(76, 22);
            supplierLabel.TabIndex = 52;
            supplierLabel.Text = "Supplier";
            // 
            // txtSupplier
            // 
            txtSupplier.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSupplier.Location = new Point(129, 219);
            txtSupplier.Name = "txtSupplier";
            txtSupplier.Size = new Size(264, 28);
            txtSupplier.TabIndex = 51;
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            priceLabel.Location = new Point(22, 173);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new Size(51, 22);
            priceLabel.TabIndex = 50;
            priceLabel.Text = "Price";
            // 
            // txtPrice
            // 
            txtPrice.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPrice.Location = new Point(129, 171);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(264, 28);
            txtPrice.TabIndex = 49;
            // 
            // quantityLabel
            // 
            quantityLabel.AutoSize = true;
            quantityLabel.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            quantityLabel.Location = new Point(22, 129);
            quantityLabel.Name = "quantityLabel";
            quantityLabel.Size = new Size(77, 22);
            quantityLabel.TabIndex = 48;
            quantityLabel.Text = "Quantity";
            // 
            // txtQuantity
            // 
            txtQuantity.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtQuantity.Location = new Point(129, 126);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(264, 28);
            txtQuantity.TabIndex = 47;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nameLabel.Location = new Point(22, 75);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(57, 22);
            nameLabel.TabIndex = 46;
            nameLabel.Text = "Name";
            // 
            // txtName
            // 
            txtName.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtName.Location = new Point(129, 71);
            txtName.Name = "txtName";
            txtName.Size = new Size(264, 28);
            txtName.TabIndex = 45;
            // 
            // InventoryDataField
            // 
            AutoScaleMode = AutoScaleMode.None;
            Controls.Add(stockLevelLabel);
            Controls.Add(txtStockLevel);
            Controls.Add(idLabel);
            Controls.Add(txtID);
            Controls.Add(btnClear);
            Controls.Add(supplierLabel);
            Controls.Add(txtSupplier);
            Controls.Add(priceLabel);
            Controls.Add(txtPrice);
            Controls.Add(quantityLabel);
            Controls.Add(txtQuantity);
            Controls.Add(nameLabel);
            Controls.Add(txtName);
            Font = new Font("Microsoft Sans Serif", 10F);
            Name = "InventoryDataField";
            Size = new Size(415, 403);
            Load += InventoryDataField_Load;
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label stockLevelLabel;
        private System.Windows.Forms.TextBox txtStockLevel;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label supplierLabel;
        private System.Windows.Forms.TextBox txtSupplier;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label quantityLabel;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox txtName;
    }
}
