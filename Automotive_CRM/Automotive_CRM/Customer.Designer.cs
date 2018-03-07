namespace Automotive_CRM
{
    partial class Customer
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
            System.Windows.Forms.Label phone_numberLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label addressLabel;
            System.Windows.Forms.Label email_addressLabel;
            System.Windows.Forms.Label alternate_phoneLabel;
            this.customersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cRM_DatabaseDataSet = new Automotive_CRM.CRM_DatabaseDataSet();
            this.notesTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.customerGridView = new System.Windows.Forms.DataGridView();
            this.phonenumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.searchBtn = new System.Windows.Forms.Button();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.saveBtn = new System.Windows.Forms.Button();
            this.tableAdapterManager = new Automotive_CRM.CRM_DatabaseDataSetTableAdapters.TableAdapterManager();
            this.customersTableAdapter = new Automotive_CRM.CRM_DatabaseDataSetTableAdapters.CustomersTableAdapter();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.phone_numberTextBox = new System.Windows.Forms.TextBox();
            this.email_addressTextBox = new System.Windows.Forms.TextBox();
            this.alternate_phoneTextBox = new System.Windows.Forms.TextBox();
            phone_numberLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            addressLabel = new System.Windows.Forms.Label();
            email_addressLabel = new System.Windows.Forms.Label();
            alternate_phoneLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cRM_DatabaseDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // phone_numberLabel
            // 
            phone_numberLabel.AutoSize = true;
            phone_numberLabel.Location = new System.Drawing.Point(231, 32);
            phone_numberLabel.Name = "phone_numberLabel";
            phone_numberLabel.Size = new System.Drawing.Size(81, 13);
            phone_numberLabel.TabIndex = 1;
            phone_numberLabel.Text = "Phone Number:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(273, 9);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(38, 13);
            nameLabel.TabIndex = 3;
            nameLabel.Text = "Name:";
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.Location = new System.Drawing.Point(262, 55);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new System.Drawing.Size(48, 13);
            addressLabel.TabIndex = 5;
            addressLabel.Text = "Address:";
            // 
            // email_addressLabel
            // 
            email_addressLabel.AutoSize = true;
            email_addressLabel.Location = new System.Drawing.Point(235, 79);
            email_addressLabel.Name = "email_addressLabel";
            email_addressLabel.Size = new System.Drawing.Size(76, 13);
            email_addressLabel.TabIndex = 7;
            email_addressLabel.Text = "Email Address:";
            // 
            // alternate_phoneLabel
            // 
            alternate_phoneLabel.AutoSize = true;
            alternate_phoneLabel.Location = new System.Drawing.Point(225, 104);
            alternate_phoneLabel.Name = "alternate_phoneLabel";
            alternate_phoneLabel.Size = new System.Drawing.Size(86, 13);
            alternate_phoneLabel.TabIndex = 13;
            alternate_phoneLabel.Text = "Alternate Phone:";
            // 
            // customersBindingSource
            // 
            this.customersBindingSource.DataMember = "Customers";
            this.customersBindingSource.DataSource = this.cRM_DatabaseDataSet;
            // 
            // cRM_DatabaseDataSet
            // 
            this.cRM_DatabaseDataSet.DataSetName = "CRM_DatabaseDataSet";
            this.cRM_DatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // notesTextBox
            // 
            this.notesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "notes", true));
            this.notesTextBox.Location = new System.Drawing.Point(6, 19);
            this.notesTextBox.Multiline = true;
            this.notesTextBox.Name = "notesTextBox";
            this.notesTextBox.Size = new System.Drawing.Size(484, 99);
            this.notesTextBox.TabIndex = 16;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.notesTextBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 223);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(496, 124);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Notes";
            // 
            // customerGridView
            // 
            this.customerGridView.AllowUserToAddRows = false;
            this.customerGridView.AllowUserToDeleteRows = false;
            this.customerGridView.AllowUserToResizeColumns = false;
            this.customerGridView.AllowUserToResizeRows = false;
            this.customerGridView.AutoGenerateColumns = false;
            this.customerGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.customerGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customerGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.phonenumberDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn});
            this.customerGridView.DataSource = this.customersBindingSource;
            this.customerGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.customerGridView.Location = new System.Drawing.Point(12, 12);
            this.customerGridView.Name = "customerGridView";
            this.customerGridView.ReadOnly = true;
            this.customerGridView.RowHeadersVisible = false;
            this.customerGridView.Size = new System.Drawing.Size(207, 150);
            this.customerGridView.TabIndex = 20;
            this.customerGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // phonenumberDataGridViewTextBoxColumn
            // 
            this.phonenumberDataGridViewTextBoxColumn.DataPropertyName = "phone_number";
            this.phonenumberDataGridViewTextBoxColumn.HeaderText = "Phone Number";
            this.phonenumberDataGridViewTextBoxColumn.Name = "phonenumberDataGridViewTextBoxColumn";
            this.phonenumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // searchBtn
            // 
            this.searchBtn.Location = new System.Drawing.Point(12, 194);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(75, 23);
            this.searchBtn.TabIndex = 21;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // searchBox
            // 
            this.searchBox.Location = new System.Drawing.Point(12, 168);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(207, 20);
            this.searchBox.TabIndex = 22;
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(433, 353);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(75, 23);
            this.saveBtn.TabIndex = 23;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.CustomersTableAdapter = null;
            this.tableAdapterManager.InvoicesTableAdapter = null;
            this.tableAdapterManager.PartsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Automotive_CRM.CRM_DatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VehicleTableAdapter = null;
            // 
            // customersTableAdapter
            // 
            this.customersTableAdapter.ClearBeforeFill = true;
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "name", true));
            this.nameTextBox.Location = new System.Drawing.Point(317, 6);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(191, 20);
            this.nameTextBox.TabIndex = 24;
            // 
            // addressTextBox
            // 
            this.addressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "address", true));
            this.addressTextBox.Location = new System.Drawing.Point(316, 52);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(192, 20);
            this.addressTextBox.TabIndex = 25;
            // 
            // phone_numberTextBox
            // 
            this.phone_numberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "phone_number", true));
            this.phone_numberTextBox.Location = new System.Drawing.Point(316, 29);
            this.phone_numberTextBox.Name = "phone_numberTextBox";
            this.phone_numberTextBox.Size = new System.Drawing.Size(192, 20);
            this.phone_numberTextBox.TabIndex = 26;
            // 
            // email_addressTextBox
            // 
            this.email_addressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "email_address", true));
            this.email_addressTextBox.Location = new System.Drawing.Point(316, 76);
            this.email_addressTextBox.Name = "email_addressTextBox";
            this.email_addressTextBox.Size = new System.Drawing.Size(192, 20);
            this.email_addressTextBox.TabIndex = 27;
            // 
            // alternate_phoneTextBox
            // 
            this.alternate_phoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "alternate_phone", true));
            this.alternate_phoneTextBox.Location = new System.Drawing.Point(316, 101);
            this.alternate_phoneTextBox.Name = "alternate_phoneTextBox";
            this.alternate_phoneTextBox.Size = new System.Drawing.Size(192, 20);
            this.alternate_phoneTextBox.TabIndex = 30;
            // 
            // Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 385);
            this.Controls.Add(this.alternate_phoneTextBox);
            this.Controls.Add(this.email_addressTextBox);
            this.Controls.Add(this.phone_numberTextBox);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.customerGridView);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(alternate_phoneLabel);
            this.Controls.Add(email_addressLabel);
            this.Controls.Add(addressLabel);
            this.Controls.Add(nameLabel);
            this.Controls.Add(phone_numberLabel);
            this.Name = "Customer";
            this.Text = "Customer";
            this.Load += new System.EventHandler(this.Customer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cRM_DatabaseDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private CRM_DatabaseDataSet cRM_DatabaseDataSet;
        private System.Windows.Forms.BindingSource customersBindingSource;
        private CRM_DatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox notesTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView customerGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn phonenumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Button saveBtn;
        private CRM_DatabaseDataSetTableAdapters.CustomersTableAdapter customersTableAdapter;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.TextBox phone_numberTextBox;
        private System.Windows.Forms.TextBox email_addressTextBox;
        private System.Windows.Forms.TextBox alternate_phoneTextBox;
    }
}