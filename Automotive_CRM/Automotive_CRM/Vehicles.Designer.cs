namespace Automotive_CRM
{
    partial class Vehicles
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
            System.Windows.Forms.Label owner_nameLabel;
            System.Windows.Forms.Label owner_numberLabel;
            System.Windows.Forms.Label makeLabel;
            System.Windows.Forms.Label modelLabel;
            System.Windows.Forms.Label yearLabel;
            System.Windows.Forms.Label date_recievedLabel;
            System.Windows.Forms.Label date_returnedLabel;
            this.cRM_DatabaseDataSet = new Automotive_CRM.CRM_DatabaseDataSet();
            this.vehicleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vehicleTableAdapter = new Automotive_CRM.CRM_DatabaseDataSetTableAdapters.VehicleTableAdapter();
            this.tableAdapterManager = new Automotive_CRM.CRM_DatabaseDataSetTableAdapters.TableAdapterManager();
            this.owner_nameTextBox = new System.Windows.Forms.TextBox();
            this.owner_numberTextBox = new System.Windows.Forms.TextBox();
            this.makeTextBox = new System.Windows.Forms.TextBox();
            this.modelTextBox = new System.Windows.Forms.TextBox();
            this.yearTextBox = new System.Windows.Forms.TextBox();
            this.date_recievedDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.date_returnedDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.vehicleDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameGroupBox = new System.Windows.Forms.GroupBox();
            this.notesTextBox = new System.Windows.Forms.TextBox();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.searchBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.newBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.viewOwnerBtn = new System.Windows.Forms.Button();
            owner_nameLabel = new System.Windows.Forms.Label();
            owner_numberLabel = new System.Windows.Forms.Label();
            makeLabel = new System.Windows.Forms.Label();
            modelLabel = new System.Windows.Forms.Label();
            yearLabel = new System.Windows.Forms.Label();
            date_recievedLabel = new System.Windows.Forms.Label();
            date_returnedLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cRM_DatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleDataGridView)).BeginInit();
            this.nameGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // owner_nameLabel
            // 
            owner_nameLabel.AutoSize = true;
            owner_nameLabel.Location = new System.Drawing.Point(207, 193);
            owner_nameLabel.Name = "owner_nameLabel";
            owner_nameLabel.Size = new System.Drawing.Size(72, 13);
            owner_nameLabel.TabIndex = 1;
            owner_nameLabel.Text = "Owner Name:";
            // 
            // owner_numberLabel
            // 
            owner_numberLabel.AutoSize = true;
            owner_numberLabel.Location = new System.Drawing.Point(198, 219);
            owner_numberLabel.Name = "owner_numberLabel";
            owner_numberLabel.Size = new System.Drawing.Size(81, 13);
            owner_numberLabel.TabIndex = 2;
            owner_numberLabel.Text = "Owner Number:";
            // 
            // makeLabel
            // 
            makeLabel.AutoSize = true;
            makeLabel.Location = new System.Drawing.Point(239, 245);
            makeLabel.Name = "makeLabel";
            makeLabel.Size = new System.Drawing.Size(37, 13);
            makeLabel.TabIndex = 4;
            makeLabel.Text = "Make:";
            // 
            // modelLabel
            // 
            modelLabel.AutoSize = true;
            modelLabel.Location = new System.Drawing.Point(237, 271);
            modelLabel.Name = "modelLabel";
            modelLabel.Size = new System.Drawing.Size(39, 13);
            modelLabel.TabIndex = 6;
            modelLabel.Text = "Model:";
            // 
            // yearLabel
            // 
            yearLabel.AutoSize = true;
            yearLabel.Location = new System.Drawing.Point(245, 297);
            yearLabel.Name = "yearLabel";
            yearLabel.Size = new System.Drawing.Size(32, 13);
            yearLabel.TabIndex = 8;
            yearLabel.Text = "Year:";
            // 
            // date_recievedLabel
            // 
            date_recievedLabel.AutoSize = true;
            date_recievedLabel.Location = new System.Drawing.Point(197, 326);
            date_recievedLabel.Name = "date_recievedLabel";
            date_recievedLabel.Size = new System.Drawing.Size(82, 13);
            date_recievedLabel.TabIndex = 10;
            date_recievedLabel.Text = "Date Recieved:";
            // 
            // date_returnedLabel
            // 
            date_returnedLabel.AutoSize = true;
            date_returnedLabel.Location = new System.Drawing.Point(197, 352);
            date_returnedLabel.Name = "date_returnedLabel";
            date_returnedLabel.Size = new System.Drawing.Size(80, 13);
            date_returnedLabel.TabIndex = 12;
            date_returnedLabel.Text = "Date Returned:";
            // 
            // cRM_DatabaseDataSet
            // 
            this.cRM_DatabaseDataSet.DataSetName = "CRM_DatabaseDataSet";
            this.cRM_DatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vehicleBindingSource
            // 
            this.vehicleBindingSource.DataMember = "Vehicle";
            this.vehicleBindingSource.DataSource = this.cRM_DatabaseDataSet;
            // 
            // vehicleTableAdapter
            // 
            this.vehicleTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CustomersTableAdapter = null;
            this.tableAdapterManager.InvoicesTableAdapter = null;
            this.tableAdapterManager.PartsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Automotive_CRM.CRM_DatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VehicleTableAdapter = this.vehicleTableAdapter;
            // 
            // owner_nameTextBox
            // 
            this.owner_nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vehicleBindingSource, "owner_name", true));
            this.owner_nameTextBox.Location = new System.Drawing.Point(281, 190);
            this.owner_nameTextBox.Name = "owner_nameTextBox";
            this.owner_nameTextBox.Size = new System.Drawing.Size(200, 20);
            this.owner_nameTextBox.TabIndex = 2;
            // 
            // owner_numberTextBox
            // 
            this.owner_numberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vehicleBindingSource, "owner_number", true));
            this.owner_numberTextBox.Location = new System.Drawing.Point(281, 216);
            this.owner_numberTextBox.Name = "owner_numberTextBox";
            this.owner_numberTextBox.Size = new System.Drawing.Size(200, 20);
            this.owner_numberTextBox.TabIndex = 3;
            // 
            // makeTextBox
            // 
            this.makeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vehicleBindingSource, "make", true));
            this.makeTextBox.Location = new System.Drawing.Point(281, 242);
            this.makeTextBox.Name = "makeTextBox";
            this.makeTextBox.Size = new System.Drawing.Size(200, 20);
            this.makeTextBox.TabIndex = 5;
            // 
            // modelTextBox
            // 
            this.modelTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vehicleBindingSource, "model", true));
            this.modelTextBox.Location = new System.Drawing.Point(281, 268);
            this.modelTextBox.Name = "modelTextBox";
            this.modelTextBox.Size = new System.Drawing.Size(200, 20);
            this.modelTextBox.TabIndex = 7;
            // 
            // yearTextBox
            // 
            this.yearTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vehicleBindingSource, "year", true));
            this.yearTextBox.Location = new System.Drawing.Point(281, 294);
            this.yearTextBox.Name = "yearTextBox";
            this.yearTextBox.Size = new System.Drawing.Size(200, 20);
            this.yearTextBox.TabIndex = 9;
            // 
            // date_recievedDateTimePicker
            // 
            this.date_recievedDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.vehicleBindingSource, "date_recieved", true));
            this.date_recievedDateTimePicker.Location = new System.Drawing.Point(281, 320);
            this.date_recievedDateTimePicker.Name = "date_recievedDateTimePicker";
            this.date_recievedDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.date_recievedDateTimePicker.TabIndex = 11;
            // 
            // date_returnedDateTimePicker
            // 
            this.date_returnedDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.vehicleBindingSource, "date_returned", true));
            this.date_returnedDateTimePicker.Location = new System.Drawing.Point(281, 346);
            this.date_returnedDateTimePicker.Name = "date_returnedDateTimePicker";
            this.date_returnedDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.date_returnedDateTimePicker.TabIndex = 13;
            // 
            // vehicleDataGridView
            // 
            this.vehicleDataGridView.AllowUserToAddRows = false;
            this.vehicleDataGridView.AllowUserToDeleteRows = false;
            this.vehicleDataGridView.AllowUserToResizeColumns = false;
            this.vehicleDataGridView.AllowUserToResizeRows = false;
            this.vehicleDataGridView.AutoGenerateColumns = false;
            this.vehicleDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.vehicleDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.vehicleDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.vehicleDataGridView.DataSource = this.vehicleBindingSource;
            this.vehicleDataGridView.Location = new System.Drawing.Point(12, 12);
            this.vehicleDataGridView.Name = "vehicleDataGridView";
            this.vehicleDataGridView.ReadOnly = true;
            this.vehicleDataGridView.RowHeadersVisible = false;
            this.vehicleDataGridView.Size = new System.Drawing.Size(664, 172);
            this.vehicleDataGridView.TabIndex = 14;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "make";
            this.dataGridViewTextBoxColumn2.HeaderText = "Make";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "model";
            this.dataGridViewTextBoxColumn3.HeaderText = "Model";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "year";
            this.dataGridViewTextBoxColumn4.HeaderText = "Year";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "owner_number";
            this.dataGridViewTextBoxColumn7.HeaderText = "Owner Number";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "owner_name";
            this.dataGridViewTextBoxColumn8.HeaderText = "Owner Name";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // nameGroupBox
            // 
            this.nameGroupBox.Controls.Add(this.notesTextBox);
            this.nameGroupBox.Location = new System.Drawing.Point(487, 193);
            this.nameGroupBox.Name = "nameGroupBox";
            this.nameGroupBox.Size = new System.Drawing.Size(188, 147);
            this.nameGroupBox.TabIndex = 15;
            this.nameGroupBox.TabStop = false;
            this.nameGroupBox.Text = "Notes";
            // 
            // notesTextBox
            // 
            this.notesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vehicleBindingSource, "notes", true));
            this.notesTextBox.Location = new System.Drawing.Point(6, 19);
            this.notesTextBox.Multiline = true;
            this.notesTextBox.Name = "notesTextBox";
            this.notesTextBox.Size = new System.Drawing.Size(175, 122);
            this.notesTextBox.TabIndex = 1;
            // 
            // searchBox
            // 
            this.searchBox.Location = new System.Drawing.Point(12, 190);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(172, 20);
            this.searchBox.TabIndex = 16;
            // 
            // searchBtn
            // 
            this.searchBtn.Location = new System.Drawing.Point(12, 216);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(75, 23);
            this.searchBtn.TabIndex = 17;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(601, 347);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(75, 23);
            this.saveBtn.TabIndex = 18;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // newBtn
            // 
            this.newBtn.Location = new System.Drawing.Point(12, 347);
            this.newBtn.Name = "newBtn";
            this.newBtn.Size = new System.Drawing.Size(75, 23);
            this.newBtn.TabIndex = 19;
            this.newBtn.Text = "New";
            this.newBtn.UseVisualStyleBackColor = true;
            this.newBtn.Click += new System.EventHandler(this.newBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(93, 347);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(75, 23);
            this.deleteBtn.TabIndex = 20;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // viewOwnerBtn
            // 
            this.viewOwnerBtn.Location = new System.Drawing.Point(487, 347);
            this.viewOwnerBtn.Name = "viewOwnerBtn";
            this.viewOwnerBtn.Size = new System.Drawing.Size(75, 23);
            this.viewOwnerBtn.TabIndex = 21;
            this.viewOwnerBtn.Text = "View Owner";
            this.viewOwnerBtn.UseVisualStyleBackColor = true;
            this.viewOwnerBtn.Click += new System.EventHandler(this.viewOwnerBtn_Click);
            // 
            // Vehicles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 381);
            this.Controls.Add(this.viewOwnerBtn);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.newBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.nameGroupBox);
            this.Controls.Add(this.vehicleDataGridView);
            this.Controls.Add(date_returnedLabel);
            this.Controls.Add(this.date_returnedDateTimePicker);
            this.Controls.Add(date_recievedLabel);
            this.Controls.Add(this.date_recievedDateTimePicker);
            this.Controls.Add(yearLabel);
            this.Controls.Add(this.yearTextBox);
            this.Controls.Add(modelLabel);
            this.Controls.Add(this.modelTextBox);
            this.Controls.Add(makeLabel);
            this.Controls.Add(this.makeTextBox);
            this.Controls.Add(owner_numberLabel);
            this.Controls.Add(this.owner_numberTextBox);
            this.Controls.Add(owner_nameLabel);
            this.Controls.Add(this.owner_nameTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Vehicles";
            this.Text = "Vehicles";
            this.Load += new System.EventHandler(this.Vehicles_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cRM_DatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleDataGridView)).EndInit();
            this.nameGroupBox.ResumeLayout(false);
            this.nameGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CRM_DatabaseDataSet cRM_DatabaseDataSet;
        private System.Windows.Forms.BindingSource vehicleBindingSource;
        private CRM_DatabaseDataSetTableAdapters.VehicleTableAdapter vehicleTableAdapter;
        private CRM_DatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox owner_nameTextBox;
        private System.Windows.Forms.TextBox owner_numberTextBox;
        private System.Windows.Forms.TextBox makeTextBox;
        private System.Windows.Forms.TextBox modelTextBox;
        private System.Windows.Forms.TextBox yearTextBox;
        private System.Windows.Forms.DateTimePicker date_recievedDateTimePicker;
        private System.Windows.Forms.DateTimePicker date_returnedDateTimePicker;
        private System.Windows.Forms.DataGridView vehicleDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.GroupBox nameGroupBox;
        private System.Windows.Forms.TextBox notesTextBox;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button newBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button viewOwnerBtn;
    }
}