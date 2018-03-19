namespace Automotive_CRM
{
    partial class MainForm
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
            this.customerBtn = new System.Windows.Forms.Button();
            this.vehicleBtn = new System.Windows.Forms.Button();
            this.inventoryBtn = new System.Windows.Forms.Button();
            this.invoicesBtn = new System.Windows.Forms.Button();
            this.joePictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.joePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // customerBtn
            // 
            this.customerBtn.Location = new System.Drawing.Point(128, 12);
            this.customerBtn.Name = "customerBtn";
            this.customerBtn.Size = new System.Drawing.Size(151, 23);
            this.customerBtn.TabIndex = 0;
            this.customerBtn.Text = "Customers";
            this.customerBtn.UseVisualStyleBackColor = true;
            this.customerBtn.Click += new System.EventHandler(this.customerBtn_Click);
            // 
            // vehicleBtn
            // 
            this.vehicleBtn.Location = new System.Drawing.Point(128, 41);
            this.vehicleBtn.Name = "vehicleBtn";
            this.vehicleBtn.Size = new System.Drawing.Size(151, 23);
            this.vehicleBtn.TabIndex = 1;
            this.vehicleBtn.Text = "Vehicles";
            this.vehicleBtn.UseVisualStyleBackColor = true;
            this.vehicleBtn.Click += new System.EventHandler(this.vehicleBtn_Click);
            // 
            // inventoryBtn
            // 
            this.inventoryBtn.Location = new System.Drawing.Point(128, 70);
            this.inventoryBtn.Name = "inventoryBtn";
            this.inventoryBtn.Size = new System.Drawing.Size(151, 23);
            this.inventoryBtn.TabIndex = 2;
            this.inventoryBtn.Text = "Parts Inventory";
            this.inventoryBtn.UseVisualStyleBackColor = true;
            this.inventoryBtn.Click += new System.EventHandler(this.inventoryBtn_Click);
            // 
            // invoicesBtn
            // 
            this.invoicesBtn.Location = new System.Drawing.Point(128, 99);
            this.invoicesBtn.Name = "invoicesBtn";
            this.invoicesBtn.Size = new System.Drawing.Size(151, 23);
            this.invoicesBtn.TabIndex = 3;
            this.invoicesBtn.Text = "Invoices";
            this.invoicesBtn.UseVisualStyleBackColor = true;
            this.invoicesBtn.Click += new System.EventHandler(this.invoicesBtn_Click);
            // 
            // joePictureBox
            // 
            this.joePictureBox.Image = global::Automotive_CRM.Properties.Resources.joeLogo;
            this.joePictureBox.Location = new System.Drawing.Point(12, 12);
            this.joePictureBox.Name = "joePictureBox";
            this.joePictureBox.Size = new System.Drawing.Size(110, 110);
            this.joePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.joePictureBox.TabIndex = 4;
            this.joePictureBox.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 134);
            this.Controls.Add(this.joePictureBox);
            this.Controls.Add(this.invoicesBtn);
            this.Controls.Add(this.inventoryBtn);
            this.Controls.Add(this.vehicleBtn);
            this.Controls.Add(this.customerBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.Text = "Joe\'s Automotive";
            ((System.ComponentModel.ISupportInitialize)(this.joePictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button customerBtn;
        private System.Windows.Forms.Button vehicleBtn;
        private System.Windows.Forms.Button inventoryBtn;
        private System.Windows.Forms.Button invoicesBtn;
        private System.Windows.Forms.PictureBox joePictureBox;
    }
}

