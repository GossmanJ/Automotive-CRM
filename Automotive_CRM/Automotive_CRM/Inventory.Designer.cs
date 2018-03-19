namespace Automotive_CRM
{
    partial class Inventory
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label priceLabel;
            System.Windows.Forms.Label stockLabel;
            System.Windows.Forms.Label on_orderLabel;
            System.Windows.Forms.Label compatible_makeBtn;
            this.cRM_DatabaseDataSet = new Automotive_CRM.CRM_DatabaseDataSet();
            this.partsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.partsTableAdapter = new Automotive_CRM.CRM_DatabaseDataSetTableAdapters.PartsTableAdapter();
            this.tableAdapterManager = new Automotive_CRM.CRM_DatabaseDataSetTableAdapters.TableAdapterManager();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.compatible_makesTextBox = new System.Windows.Forms.TextBox();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.stockTextBox = new System.Windows.Forms.TextBox();
            this.on_orderTextBox = new System.Windows.Forms.TextBox();
            this.inventoryGridView = new System.Windows.Forms.DataGridView();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.searchBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.newBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.onorderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.compatiblemakesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.viewCompatibleCarsBtn = new System.Windows.Forms.Button();
            nameLabel = new System.Windows.Forms.Label();
            priceLabel = new System.Windows.Forms.Label();
            stockLabel = new System.Windows.Forms.Label();
            on_orderLabel = new System.Windows.Forms.Label();
            compatible_makeBtn = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cRM_DatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(238, 171);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(38, 13);
            nameLabel.TabIndex = 1;
            nameLabel.Text = "Name:";
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.Location = new System.Drawing.Point(241, 197);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new System.Drawing.Size(34, 13);
            priceLabel.TabIndex = 4;
            priceLabel.Text = "Price:";
            // 
            // stockLabel
            // 
            stockLabel.AutoSize = true;
            stockLabel.Location = new System.Drawing.Point(238, 223);
            stockLabel.Name = "stockLabel";
            stockLabel.Size = new System.Drawing.Size(38, 13);
            stockLabel.TabIndex = 6;
            stockLabel.Text = "Stock:";
            // 
            // on_orderLabel
            // 
            on_orderLabel.AutoSize = true;
            on_orderLabel.Location = new System.Drawing.Point(441, 171);
            on_orderLabel.Name = "on_orderLabel";
            on_orderLabel.Size = new System.Drawing.Size(53, 13);
            on_orderLabel.TabIndex = 8;
            on_orderLabel.Text = "On Order:";
            // 
            // cRM_DatabaseDataSet
            // 
            this.cRM_DatabaseDataSet.DataSetName = "CRM_DatabaseDataSet";
            this.cRM_DatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // partsBindingSource
            // 
            this.partsBindingSource.DataMember = "Parts";
            this.partsBindingSource.DataSource = this.cRM_DatabaseDataSet;
            // 
            // partsTableAdapter
            // 
            this.partsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CustomersTableAdapter = null;
            this.tableAdapterManager.InvoicesTableAdapter = null;
            this.tableAdapterManager.PartsTableAdapter = this.partsTableAdapter;
            this.tableAdapterManager.UpdateOrder = Automotive_CRM.CRM_DatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VehicleTableAdapter = null;
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.partsBindingSource, "name", true));
            this.nameTextBox.Location = new System.Drawing.Point(280, 168);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(100, 20);
            this.nameTextBox.TabIndex = 2;
            // 
            // compatible_makesTextBox
            // 
            this.compatible_makesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.partsBindingSource, "compatible_makes", true));
            this.compatible_makesTextBox.Location = new System.Drawing.Point(500, 194);
            this.compatible_makesTextBox.Multiline = true;
            this.compatible_makesTextBox.Name = "compatible_makesTextBox";
            this.compatible_makesTextBox.Size = new System.Drawing.Size(100, 21);
            this.compatible_makesTextBox.TabIndex = 3;
            // 
            // priceTextBox
            // 
            this.priceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.partsBindingSource, "price", true));
            this.priceTextBox.Location = new System.Drawing.Point(280, 194);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(100, 20);
            this.priceTextBox.TabIndex = 5;
            // 
            // stockTextBox
            // 
            this.stockTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.partsBindingSource, "stock", true));
            this.stockTextBox.Location = new System.Drawing.Point(280, 220);
            this.stockTextBox.Name = "stockTextBox";
            this.stockTextBox.Size = new System.Drawing.Size(100, 20);
            this.stockTextBox.TabIndex = 7;
            // 
            // on_orderTextBox
            // 
            this.on_orderTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.partsBindingSource, "on_order", true));
            this.on_orderTextBox.Location = new System.Drawing.Point(500, 168);
            this.on_orderTextBox.Name = "on_orderTextBox";
            this.on_orderTextBox.Size = new System.Drawing.Size(100, 20);
            this.on_orderTextBox.TabIndex = 9;
            // 
            // inventoryGridView
            // 
            this.inventoryGridView.AllowUserToAddRows = false;
            this.inventoryGridView.AllowUserToDeleteRows = false;
            this.inventoryGridView.AllowUserToResizeColumns = false;
            this.inventoryGridView.AllowUserToResizeRows = false;
            this.inventoryGridView.AutoGenerateColumns = false;
            this.inventoryGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.inventoryGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.inventoryGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.stockDataGridViewTextBoxColumn,
            this.onorderDataGridViewTextBoxColumn,
            this.compatiblemakesDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn});
            this.inventoryGridView.DataSource = this.partsBindingSource;
            this.inventoryGridView.Location = new System.Drawing.Point(12, 12);
            this.inventoryGridView.Name = "inventoryGridView";
            this.inventoryGridView.ReadOnly = true;
            this.inventoryGridView.RowHeadersVisible = false;
            this.inventoryGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.inventoryGridView.Size = new System.Drawing.Size(589, 150);
            this.inventoryGridView.TabIndex = 10;
            this.inventoryGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.inventoryGridView_CellContentClick);
            // 
            // searchBox
            // 
            this.searchBox.Location = new System.Drawing.Point(12, 168);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(145, 20);
            this.searchBox.TabIndex = 12;
            // 
            // searchBtn
            // 
            this.searchBtn.Location = new System.Drawing.Point(12, 194);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(75, 23);
            this.searchBtn.TabIndex = 13;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(12, 249);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(69, 23);
            this.deleteBtn.TabIndex = 14;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // newBtn
            // 
            this.newBtn.Location = new System.Drawing.Point(82, 249);
            this.newBtn.Name = "newBtn";
            this.newBtn.Size = new System.Drawing.Size(69, 23);
            this.newBtn.TabIndex = 15;
            this.newBtn.Text = "New ";
            this.newBtn.UseVisualStyleBackColor = true;
            this.newBtn.Click += new System.EventHandler(this.newBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(532, 249);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(69, 23);
            this.saveBtn.TabIndex = 16;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // stockDataGridViewTextBoxColumn
            // 
            this.stockDataGridViewTextBoxColumn.DataPropertyName = "stock";
            this.stockDataGridViewTextBoxColumn.HeaderText = "Stock";
            this.stockDataGridViewTextBoxColumn.Name = "stockDataGridViewTextBoxColumn";
            this.stockDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // onorderDataGridViewTextBoxColumn
            // 
            this.onorderDataGridViewTextBoxColumn.DataPropertyName = "on_order";
            this.onorderDataGridViewTextBoxColumn.HeaderText = "On Order";
            this.onorderDataGridViewTextBoxColumn.Name = "onorderDataGridViewTextBoxColumn";
            this.onorderDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // compatiblemakesDataGridViewTextBoxColumn
            // 
            this.compatiblemakesDataGridViewTextBoxColumn.DataPropertyName = "compatible_makes";
            this.compatiblemakesDataGridViewTextBoxColumn.HeaderText = "Compatible Make";
            this.compatiblemakesDataGridViewTextBoxColumn.Name = "compatiblemakesDataGridViewTextBoxColumn";
            this.compatiblemakesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // compatible_makeBtn
            // 
            compatible_makeBtn.AutoSize = true;
            compatible_makeBtn.Location = new System.Drawing.Point(402, 199);
            compatible_makeBtn.Name = "compatible_makeBtn";
            compatible_makeBtn.Size = new System.Drawing.Size(92, 13);
            compatible_makeBtn.TabIndex = 17;
            compatible_makeBtn.Text = "Compatible Make:";
            // 
            // viewCompatibleCarsBtn
            // 
            this.viewCompatibleCarsBtn.Location = new System.Drawing.Point(405, 249);
            this.viewCompatibleCarsBtn.Name = "viewCompatibleCarsBtn";
            this.viewCompatibleCarsBtn.Size = new System.Drawing.Size(121, 23);
            this.viewCompatibleCarsBtn.TabIndex = 18;
            this.viewCompatibleCarsBtn.Text = "View Compatible Cars";
            this.viewCompatibleCarsBtn.UseVisualStyleBackColor = true;
            this.viewCompatibleCarsBtn.Click += new System.EventHandler(this.viewCompatibleCarsBtn_Click);
            // 
            // Inventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 281);
            this.Controls.Add(this.viewCompatibleCarsBtn);
            this.Controls.Add(compatible_makeBtn);
            this.Controls.Add(this.compatible_makesTextBox);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.newBtn);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.inventoryGridView);
            this.Controls.Add(on_orderLabel);
            this.Controls.Add(this.on_orderTextBox);
            this.Controls.Add(stockLabel);
            this.Controls.Add(this.stockTextBox);
            this.Controls.Add(priceLabel);
            this.Controls.Add(this.priceTextBox);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Inventory";
            this.Text = "Inventory";
            this.Load += new System.EventHandler(this.Inventory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cRM_DatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CRM_DatabaseDataSet cRM_DatabaseDataSet;
        private System.Windows.Forms.BindingSource partsBindingSource;
        private CRM_DatabaseDataSetTableAdapters.PartsTableAdapter partsTableAdapter;
        private CRM_DatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox compatible_makesTextBox;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.TextBox stockTextBox;
        private System.Windows.Forms.TextBox on_orderTextBox;
        private System.Windows.Forms.DataGridView inventoryGridView;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button newBtn;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn onorderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn compatiblemakesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button viewCompatibleCarsBtn;
    }
}