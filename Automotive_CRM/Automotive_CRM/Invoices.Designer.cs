namespace Automotive_CRM
{
    partial class Invoices
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
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label customer_phoneLabel;
            System.Windows.Forms.Label parts_usedLabel;
            System.Windows.Forms.Label labor_costLabel;
            System.Windows.Forms.Label fluid_checkLabel;
            System.Windows.Forms.Label totalLabel;
            this.cRM_DatabaseDataSet = new Automotive_CRM.CRM_DatabaseDataSet();
            this.invoicesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.invoicesTableAdapter = new Automotive_CRM.CRM_DatabaseDataSetTableAdapters.InvoicesTableAdapter();
            this.tableAdapterManager = new Automotive_CRM.CRM_DatabaseDataSetTableAdapters.TableAdapterManager();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.customer_phoneTextBox = new System.Windows.Forms.TextBox();
            this.parts_usedTextBox = new System.Windows.Forms.TextBox();
            this.labor_costTextBox = new System.Windows.Forms.TextBox();
            this.fluid_checkCheckBox = new System.Windows.Forms.CheckBox();
            this.totalTextBox = new System.Windows.Forms.TextBox();
            this.invoicesDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            idLabel = new System.Windows.Forms.Label();
            customer_phoneLabel = new System.Windows.Forms.Label();
            parts_usedLabel = new System.Windows.Forms.Label();
            labor_costLabel = new System.Windows.Forms.Label();
            fluid_checkLabel = new System.Windows.Forms.Label();
            totalLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cRM_DatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoicesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoicesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // cRM_DatabaseDataSet
            // 
            this.cRM_DatabaseDataSet.DataSetName = "CRM_DatabaseDataSet";
            this.cRM_DatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // invoicesBindingSource
            // 
            this.invoicesBindingSource.DataMember = "Invoices";
            this.invoicesBindingSource.DataSource = this.cRM_DatabaseDataSet;
            // 
            // invoicesTableAdapter
            // 
            this.invoicesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CustomersTableAdapter = null;
            this.tableAdapterManager.InvoicesTableAdapter = this.invoicesTableAdapter;
            this.tableAdapterManager.PartsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Automotive_CRM.CRM_DatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VehicleTableAdapter = null;
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(294, 15);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(21, 13);
            idLabel.TabIndex = 1;
            idLabel.Text = "ID:";
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoicesBindingSource, "id", true));
            this.idTextBox.Location = new System.Drawing.Point(321, 12);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.ReadOnly = true;
            this.idTextBox.Size = new System.Drawing.Size(100, 20);
            this.idTextBox.TabIndex = 2;
            // 
            // customer_phoneLabel
            // 
            customer_phoneLabel.AutoSize = true;
            customer_phoneLabel.Location = new System.Drawing.Point(229, 41);
            customer_phoneLabel.Name = "customer_phoneLabel";
            customer_phoneLabel.Size = new System.Drawing.Size(88, 13);
            customer_phoneLabel.TabIndex = 3;
            customer_phoneLabel.Text = "Customer Phone:";
            // 
            // customer_phoneTextBox
            // 
            this.customer_phoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoicesBindingSource, "customer_phone", true));
            this.customer_phoneTextBox.Location = new System.Drawing.Point(321, 38);
            this.customer_phoneTextBox.Name = "customer_phoneTextBox";
            this.customer_phoneTextBox.Size = new System.Drawing.Size(100, 20);
            this.customer_phoneTextBox.TabIndex = 4;
            // 
            // parts_usedLabel
            // 
            parts_usedLabel.AutoSize = true;
            parts_usedLabel.Location = new System.Drawing.Point(256, 67);
            parts_usedLabel.Name = "parts_usedLabel";
            parts_usedLabel.Size = new System.Drawing.Size(62, 13);
            parts_usedLabel.TabIndex = 5;
            parts_usedLabel.Text = "Parts Used:";
            // 
            // parts_usedTextBox
            // 
            this.parts_usedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoicesBindingSource, "parts_used", true));
            this.parts_usedTextBox.Location = new System.Drawing.Point(321, 64);
            this.parts_usedTextBox.Name = "parts_usedTextBox";
            this.parts_usedTextBox.Size = new System.Drawing.Size(100, 20);
            this.parts_usedTextBox.TabIndex = 6;
            // 
            // labor_costLabel
            // 
            labor_costLabel.AutoSize = true;
            labor_costLabel.Location = new System.Drawing.Point(256, 93);
            labor_costLabel.Name = "labor_costLabel";
            labor_costLabel.Size = new System.Drawing.Size(61, 13);
            labor_costLabel.TabIndex = 7;
            labor_costLabel.Text = "Labor Cost:";
            // 
            // labor_costTextBox
            // 
            this.labor_costTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoicesBindingSource, "labor_cost", true));
            this.labor_costTextBox.Location = new System.Drawing.Point(321, 90);
            this.labor_costTextBox.Name = "labor_costTextBox";
            this.labor_costTextBox.Size = new System.Drawing.Size(100, 20);
            this.labor_costTextBox.TabIndex = 8;
            // 
            // fluid_checkLabel
            // 
            fluid_checkLabel.AutoSize = true;
            fluid_checkLabel.Location = new System.Drawing.Point(249, 121);
            fluid_checkLabel.Name = "fluid_checkLabel";
            fluid_checkLabel.Size = new System.Drawing.Size(66, 13);
            fluid_checkLabel.TabIndex = 9;
            fluid_checkLabel.Text = "Fluid Check:";
            // 
            // fluid_checkCheckBox
            // 
            this.fluid_checkCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.invoicesBindingSource, "fluid_check", true));
            this.fluid_checkCheckBox.Location = new System.Drawing.Point(321, 116);
            this.fluid_checkCheckBox.Name = "fluid_checkCheckBox";
            this.fluid_checkCheckBox.Size = new System.Drawing.Size(100, 24);
            this.fluid_checkCheckBox.TabIndex = 10;
            this.fluid_checkCheckBox.UseVisualStyleBackColor = true;
            // 
            // totalLabel
            // 
            totalLabel.AutoSize = true;
            totalLabel.Location = new System.Drawing.Point(281, 149);
            totalLabel.Name = "totalLabel";
            totalLabel.Size = new System.Drawing.Size(34, 13);
            totalLabel.TabIndex = 11;
            totalLabel.Text = "Total:";
            // 
            // totalTextBox
            // 
            this.totalTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoicesBindingSource, "total", true));
            this.totalTextBox.Location = new System.Drawing.Point(321, 146);
            this.totalTextBox.Name = "totalTextBox";
            this.totalTextBox.ReadOnly = true;
            this.totalTextBox.Size = new System.Drawing.Size(100, 20);
            this.totalTextBox.TabIndex = 12;
            // 
            // invoicesDataGridView
            // 
            this.invoicesDataGridView.AllowUserToAddRows = false;
            this.invoicesDataGridView.AllowUserToDeleteRows = false;
            this.invoicesDataGridView.AllowUserToResizeColumns = false;
            this.invoicesDataGridView.AllowUserToResizeRows = false;
            this.invoicesDataGridView.AutoGenerateColumns = false;
            this.invoicesDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.invoicesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.invoicesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn5});
            this.invoicesDataGridView.DataSource = this.invoicesBindingSource;
            this.invoicesDataGridView.Location = new System.Drawing.Point(12, 12);
            this.invoicesDataGridView.Name = "invoicesDataGridView";
            this.invoicesDataGridView.ReadOnly = true;
            this.invoicesDataGridView.RowHeadersVisible = false;
            this.invoicesDataGridView.Size = new System.Drawing.Size(211, 154);
            this.invoicesDataGridView.TabIndex = 12;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "customer_phone";
            this.dataGridViewTextBoxColumn2.HeaderText = "Phone";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "total";
            this.dataGridViewTextBoxColumn5.HeaderText = "Total";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // Invoices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 202);
            this.Controls.Add(this.invoicesDataGridView);
            this.Controls.Add(totalLabel);
            this.Controls.Add(this.totalTextBox);
            this.Controls.Add(fluid_checkLabel);
            this.Controls.Add(this.fluid_checkCheckBox);
            this.Controls.Add(labor_costLabel);
            this.Controls.Add(this.labor_costTextBox);
            this.Controls.Add(parts_usedLabel);
            this.Controls.Add(this.parts_usedTextBox);
            this.Controls.Add(customer_phoneLabel);
            this.Controls.Add(this.customer_phoneTextBox);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idTextBox);
            this.Name = "Invoices";
            this.Text = "Invoices";
            this.Load += new System.EventHandler(this.Invoices_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cRM_DatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoicesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoicesDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CRM_DatabaseDataSet cRM_DatabaseDataSet;
        private System.Windows.Forms.BindingSource invoicesBindingSource;
        private CRM_DatabaseDataSetTableAdapters.InvoicesTableAdapter invoicesTableAdapter;
        private CRM_DatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox customer_phoneTextBox;
        private System.Windows.Forms.TextBox parts_usedTextBox;
        private System.Windows.Forms.TextBox labor_costTextBox;
        private System.Windows.Forms.CheckBox fluid_checkCheckBox;
        private System.Windows.Forms.TextBox totalTextBox;
        private System.Windows.Forms.DataGridView invoicesDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    }
}