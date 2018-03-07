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
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
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
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(128, 41);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(151, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Vehicles";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(128, 70);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(151, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Parts Inventory";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(128, 99);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(151, 23);
            this.button4.TabIndex = 3;
            this.button4.Text = "Invoices";
            this.button4.UseVisualStyleBackColor = true;
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
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.customerBtn);
            this.Name = "MainForm";
            this.Text = "Joe\'s Automotive";
            ((System.ComponentModel.ISupportInitialize)(this.joePictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button customerBtn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.PictureBox joePictureBox;
    }
}

