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
            System.Windows.Forms.Label vehicle_idsLabel;
            System.Windows.Forms.Label invoice_idsLabel;
            System.Windows.Forms.Label alternate_phoneLabel;
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.cRM_DatabaseDataSet = new Automotive_CRM.CRM_DatabaseDataSet();
            this.customersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customersTableAdapter = new Automotive_CRM.CRM_DatabaseDataSetTableAdapters.CustomersTableAdapter();
            this.tableAdapterManager = new Automotive_CRM.CRM_DatabaseDataSetTableAdapters.TableAdapterManager();
            this.phone_numberTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.email_addressTextBox = new System.Windows.Forms.TextBox();
            this.vehicle_idsTextBox = new System.Windows.Forms.TextBox();
            this.invoice_idsTextBox = new System.Windows.Forms.TextBox();
            this.alternate_phoneTextBox = new System.Windows.Forms.TextBox();
            this.notesTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            phone_numberLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            addressLabel = new System.Windows.Forms.Label();
            email_addressLabel = new System.Windows.Forms.Label();
            vehicle_idsLabel = new System.Windows.Forms.Label();
            invoice_idsLabel = new System.Windows.Forms.Label();
            alternate_phoneLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cRM_DatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.DataSource = this.customersBindingSource;
            this.listBox1.DisplayMember = "name";
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 9);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(199, 147);
            this.listBox1.TabIndex = 0;
            // 
            // cRM_DatabaseDataSet
            // 
            this.cRM_DatabaseDataSet.DataSetName = "CRM_DatabaseDataSet";
            this.cRM_DatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customersBindingSource
            // 
            this.customersBindingSource.DataMember = "Customers";
            this.customersBindingSource.DataSource = this.cRM_DatabaseDataSet;
            // 
            // customersTableAdapter
            // 
            this.customersTableAdapter.ClearBeforeFill = true;
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
            // phone_numberLabel
            // 
            phone_numberLabel.AutoSize = true;
            phone_numberLabel.Location = new System.Drawing.Point(223, 32);
            phone_numberLabel.Name = "phone_numberLabel";
            phone_numberLabel.Size = new System.Drawing.Size(81, 13);
            phone_numberLabel.TabIndex = 1;
            phone_numberLabel.Text = "Phone Number:";
            // 
            // phone_numberTextBox
            // 
            this.phone_numberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "phone_number", true));
            this.phone_numberTextBox.Location = new System.Drawing.Point(307, 29);
            this.phone_numberTextBox.Name = "phone_numberTextBox";
            this.phone_numberTextBox.Size = new System.Drawing.Size(193, 20);
            this.phone_numberTextBox.TabIndex = 2;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(265, 9);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(38, 13);
            nameLabel.TabIndex = 3;
            nameLabel.Text = "Name:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "name", true));
            this.nameTextBox.Location = new System.Drawing.Point(307, 6);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(193, 20);
            this.nameTextBox.TabIndex = 4;
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.Location = new System.Drawing.Point(254, 55);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new System.Drawing.Size(48, 13);
            addressLabel.TabIndex = 5;
            addressLabel.Text = "Address:";
            // 
            // addressTextBox
            // 
            this.addressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "address", true));
            this.addressTextBox.Location = new System.Drawing.Point(307, 52);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(193, 20);
            this.addressTextBox.TabIndex = 6;
            // 
            // email_addressLabel
            // 
            email_addressLabel.AutoSize = true;
            email_addressLabel.Location = new System.Drawing.Point(227, 79);
            email_addressLabel.Name = "email_addressLabel";
            email_addressLabel.Size = new System.Drawing.Size(76, 13);
            email_addressLabel.TabIndex = 7;
            email_addressLabel.Text = "Email Address:";
            // 
            // email_addressTextBox
            // 
            this.email_addressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "email_address", true));
            this.email_addressTextBox.Location = new System.Drawing.Point(307, 76);
            this.email_addressTextBox.Name = "email_addressTextBox";
            this.email_addressTextBox.Size = new System.Drawing.Size(193, 20);
            this.email_addressTextBox.TabIndex = 8;
            // 
            // vehicle_idsLabel
            // 
            vehicle_idsLabel.AutoSize = true;
            vehicle_idsLabel.Location = new System.Drawing.Point(241, 103);
            vehicle_idsLabel.Name = "vehicle_idsLabel";
            vehicle_idsLabel.Size = new System.Drawing.Size(62, 13);
            vehicle_idsLabel.TabIndex = 9;
            vehicle_idsLabel.Text = "Vehicle Ids:";
            // 
            // vehicle_idsTextBox
            // 
            this.vehicle_idsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "vehicle_ids", true));
            this.vehicle_idsTextBox.Location = new System.Drawing.Point(307, 100);
            this.vehicle_idsTextBox.Name = "vehicle_idsTextBox";
            this.vehicle_idsTextBox.Size = new System.Drawing.Size(193, 20);
            this.vehicle_idsTextBox.TabIndex = 10;
            // 
            // invoice_idsLabel
            // 
            invoice_idsLabel.AutoSize = true;
            invoice_idsLabel.Location = new System.Drawing.Point(241, 126);
            invoice_idsLabel.Name = "invoice_idsLabel";
            invoice_idsLabel.Size = new System.Drawing.Size(62, 13);
            invoice_idsLabel.TabIndex = 11;
            invoice_idsLabel.Text = "Invoice Ids:";
            // 
            // invoice_idsTextBox
            // 
            this.invoice_idsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "invoice_ids", true));
            this.invoice_idsTextBox.Location = new System.Drawing.Point(307, 123);
            this.invoice_idsTextBox.Name = "invoice_idsTextBox";
            this.invoice_idsTextBox.Size = new System.Drawing.Size(193, 20);
            this.invoice_idsTextBox.TabIndex = 12;
            // 
            // alternate_phoneLabel
            // 
            alternate_phoneLabel.AutoSize = true;
            alternate_phoneLabel.Location = new System.Drawing.Point(217, 149);
            alternate_phoneLabel.Name = "alternate_phoneLabel";
            alternate_phoneLabel.Size = new System.Drawing.Size(86, 13);
            alternate_phoneLabel.TabIndex = 13;
            alternate_phoneLabel.Text = "Alternate Phone:";
            // 
            // alternate_phoneTextBox
            // 
            this.alternate_phoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "alternate_phone", true));
            this.alternate_phoneTextBox.Location = new System.Drawing.Point(307, 146);
            this.alternate_phoneTextBox.Name = "alternate_phoneTextBox";
            this.alternate_phoneTextBox.Size = new System.Drawing.Size(193, 20);
            this.alternate_phoneTextBox.TabIndex = 14;
            // 
            // notesTextBox
            // 
            this.notesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "notes", true));
            this.notesTextBox.Location = new System.Drawing.Point(6, 19);
            this.notesTextBox.Multiline = true;
            this.notesTextBox.Name = "notesTextBox";
            this.notesTextBox.Size = new System.Drawing.Size(271, 166);
            this.notesTextBox.TabIndex = 16;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.notesTextBox);
            this.groupBox1.Location = new System.Drawing.Point(217, 172);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(283, 191);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Notes";
            // 
            // Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 375);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(alternate_phoneLabel);
            this.Controls.Add(this.alternate_phoneTextBox);
            this.Controls.Add(invoice_idsLabel);
            this.Controls.Add(this.invoice_idsTextBox);
            this.Controls.Add(vehicle_idsLabel);
            this.Controls.Add(this.vehicle_idsTextBox);
            this.Controls.Add(email_addressLabel);
            this.Controls.Add(this.email_addressTextBox);
            this.Controls.Add(addressLabel);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(phone_numberLabel);
            this.Controls.Add(this.phone_numberTextBox);
            this.Controls.Add(this.listBox1);
            this.Name = "Customer";
            this.Text = "Customer";
            this.Load += new System.EventHandler(this.Customer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cRM_DatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private CRM_DatabaseDataSet cRM_DatabaseDataSet;
        private System.Windows.Forms.BindingSource customersBindingSource;
        private CRM_DatabaseDataSetTableAdapters.CustomersTableAdapter customersTableAdapter;
        private CRM_DatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox phone_numberTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.TextBox email_addressTextBox;
        private System.Windows.Forms.TextBox vehicle_idsTextBox;
        private System.Windows.Forms.TextBox invoice_idsTextBox;
        private System.Windows.Forms.TextBox alternate_phoneTextBox;
        private System.Windows.Forms.TextBox notesTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}