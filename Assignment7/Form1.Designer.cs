namespace Assignment7
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
            this.label_customerFilePath = new System.Windows.Forms.Label();
            this.textBox_customerFilePath = new System.Windows.Forms.TextBox();
            this.button_customerLoad = new System.Windows.Forms.Button();
            this.button_boatLoad = new System.Windows.Forms.Button();
            this.textBox_boatFilePath = new System.Windows.Forms.TextBox();
            this.label_boatFilePath = new System.Windows.Forms.Label();
            this.button_boatSave = new System.Windows.Forms.Button();
            this.label_customers = new System.Windows.Forms.Label();
            this.listBox_customers = new System.Windows.Forms.ListBox();
            this.label_customerName = new System.Windows.Forms.Label();
            this.label_customerAddress = new System.Windows.Forms.Label();
            this.label_customerPhone = new System.Windows.Forms.Label();
            this.label_boatLength = new System.Windows.Forms.Label();
            this.label_boatType = new System.Windows.Forms.Label();
            this.label_boatRegNum = new System.Windows.Forms.Label();
            this.listBox_boats = new System.Windows.Forms.ListBox();
            this.label_boats = new System.Windows.Forms.Label();
            this.label_boatManufacturer = new System.Windows.Forms.Label();
            this.label_boatYear = new System.Windows.Forms.Label();
            this.label_customerOwnedBoats = new System.Windows.Forms.Label();
            this.label_comment = new System.Windows.Forms.Label();
            this.groupBox_customerOwnedBoats = new System.Windows.Forms.GroupBox();
            this.listBox_ownedBoats = new System.Windows.Forms.ListBox();
            this.button_assignBoat = new System.Windows.Forms.Button();
            this.groupBox_customerOwnedBoats.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_customerFilePath
            // 
            this.label_customerFilePath.AutoSize = true;
            this.label_customerFilePath.Location = new System.Drawing.Point(13, 13);
            this.label_customerFilePath.Name = "label_customerFilePath";
            this.label_customerFilePath.Size = new System.Drawing.Size(94, 13);
            this.label_customerFilePath.TabIndex = 0;
            this.label_customerFilePath.Text = "Customer file path:";
            // 
            // textBox_customerFilePath
            // 
            this.textBox_customerFilePath.Location = new System.Drawing.Point(113, 6);
            this.textBox_customerFilePath.Name = "textBox_customerFilePath";
            this.textBox_customerFilePath.Size = new System.Drawing.Size(100, 20);
            this.textBox_customerFilePath.TabIndex = 1;
            // 
            // button_customerLoad
            // 
            this.button_customerLoad.Location = new System.Drawing.Point(16, 30);
            this.button_customerLoad.Name = "button_customerLoad";
            this.button_customerLoad.Size = new System.Drawing.Size(75, 23);
            this.button_customerLoad.TabIndex = 2;
            this.button_customerLoad.Text = "Load";
            this.button_customerLoad.UseVisualStyleBackColor = true;
            this.button_customerLoad.Click += new System.EventHandler(this.button_customerLoad_Click);
            // 
            // button_boatLoad
            // 
            this.button_boatLoad.Location = new System.Drawing.Point(403, 30);
            this.button_boatLoad.Name = "button_boatLoad";
            this.button_boatLoad.Size = new System.Drawing.Size(75, 23);
            this.button_boatLoad.TabIndex = 5;
            this.button_boatLoad.Text = "Load Boats";
            this.button_boatLoad.UseVisualStyleBackColor = true;
            this.button_boatLoad.Click += new System.EventHandler(this.button_boatLoad_Click);
            // 
            // textBox_boatFilePath
            // 
            this.textBox_boatFilePath.Location = new System.Drawing.Point(478, 6);
            this.textBox_boatFilePath.Name = "textBox_boatFilePath";
            this.textBox_boatFilePath.Size = new System.Drawing.Size(100, 20);
            this.textBox_boatFilePath.TabIndex = 4;
            // 
            // label_boatFilePath
            // 
            this.label_boatFilePath.AutoSize = true;
            this.label_boatFilePath.Location = new System.Drawing.Point(400, 13);
            this.label_boatFilePath.Name = "label_boatFilePath";
            this.label_boatFilePath.Size = new System.Drawing.Size(72, 13);
            this.label_boatFilePath.TabIndex = 3;
            this.label_boatFilePath.Text = "Boat file path:";
            // 
            // button_boatSave
            // 
            this.button_boatSave.Location = new System.Drawing.Point(485, 29);
            this.button_boatSave.Name = "button_boatSave";
            this.button_boatSave.Size = new System.Drawing.Size(75, 23);
            this.button_boatSave.TabIndex = 6;
            this.button_boatSave.Text = "Save Boats";
            this.button_boatSave.UseVisualStyleBackColor = true;
            this.button_boatSave.Click += new System.EventHandler(this.button_boatSave_Click);
            // 
            // label_customers
            // 
            this.label_customers.AutoSize = true;
            this.label_customers.Location = new System.Drawing.Point(16, 90);
            this.label_customers.Name = "label_customers";
            this.label_customers.Size = new System.Drawing.Size(56, 13);
            this.label_customers.TabIndex = 7;
            this.label_customers.Text = "Customers";
            // 
            // listBox_customers
            // 
            this.listBox_customers.FormattingEnabled = true;
            this.listBox_customers.Location = new System.Drawing.Point(19, 107);
            this.listBox_customers.Name = "listBox_customers";
            this.listBox_customers.Size = new System.Drawing.Size(180, 134);
            this.listBox_customers.TabIndex = 8;
            this.listBox_customers.SelectedIndexChanged += new System.EventHandler(this.listBox_customers_SelectedIndexChanged);
            // 
            // label_customerName
            // 
            this.label_customerName.AutoSize = true;
            this.label_customerName.Location = new System.Drawing.Point(16, 263);
            this.label_customerName.Name = "label_customerName";
            this.label_customerName.Size = new System.Drawing.Size(38, 13);
            this.label_customerName.TabIndex = 9;
            this.label_customerName.Text = "Name:";
            // 
            // label_customerAddress
            // 
            this.label_customerAddress.AutoSize = true;
            this.label_customerAddress.Location = new System.Drawing.Point(16, 280);
            this.label_customerAddress.Name = "label_customerAddress";
            this.label_customerAddress.Size = new System.Drawing.Size(48, 13);
            this.label_customerAddress.TabIndex = 10;
            this.label_customerAddress.Text = "Address:";
            // 
            // label_customerPhone
            // 
            this.label_customerPhone.AutoSize = true;
            this.label_customerPhone.Location = new System.Drawing.Point(16, 297);
            this.label_customerPhone.Name = "label_customerPhone";
            this.label_customerPhone.Size = new System.Drawing.Size(41, 13);
            this.label_customerPhone.TabIndex = 11;
            this.label_customerPhone.Text = "Phone:";
            // 
            // label_boatLength
            // 
            this.label_boatLength.AutoSize = true;
            this.label_boatLength.Location = new System.Drawing.Point(400, 297);
            this.label_boatLength.Name = "label_boatLength";
            this.label_boatLength.Size = new System.Drawing.Size(43, 13);
            this.label_boatLength.TabIndex = 16;
            this.label_boatLength.Text = "Length:";
            // 
            // label_boatType
            // 
            this.label_boatType.AutoSize = true;
            this.label_boatType.Location = new System.Drawing.Point(400, 280);
            this.label_boatType.Name = "label_boatType";
            this.label_boatType.Size = new System.Drawing.Size(34, 13);
            this.label_boatType.TabIndex = 15;
            this.label_boatType.Text = "Type:";
            // 
            // label_boatRegNum
            // 
            this.label_boatRegNum.AutoSize = true;
            this.label_boatRegNum.Location = new System.Drawing.Point(400, 263);
            this.label_boatRegNum.Name = "label_boatRegNum";
            this.label_boatRegNum.Size = new System.Drawing.Size(81, 13);
            this.label_boatRegNum.TabIndex = 14;
            this.label_boatRegNum.Text = "Registration no:";
            // 
            // listBox_boats
            // 
            this.listBox_boats.FormattingEnabled = true;
            this.listBox_boats.HorizontalScrollbar = true;
            this.listBox_boats.Location = new System.Drawing.Point(403, 107);
            this.listBox_boats.Name = "listBox_boats";
            this.listBox_boats.Size = new System.Drawing.Size(180, 134);
            this.listBox_boats.TabIndex = 13;
            this.listBox_boats.SelectedIndexChanged += new System.EventHandler(this.listBox_boats_SelectedIndexChanged);
            // 
            // label_boats
            // 
            this.label_boats.AutoSize = true;
            this.label_boats.Location = new System.Drawing.Point(400, 90);
            this.label_boats.Name = "label_boats";
            this.label_boats.Size = new System.Drawing.Size(34, 13);
            this.label_boats.TabIndex = 12;
            this.label_boats.Text = "Boats";
            // 
            // label_boatManufacturer
            // 
            this.label_boatManufacturer.AutoSize = true;
            this.label_boatManufacturer.Location = new System.Drawing.Point(400, 318);
            this.label_boatManufacturer.Name = "label_boatManufacturer";
            this.label_boatManufacturer.Size = new System.Drawing.Size(73, 13);
            this.label_boatManufacturer.TabIndex = 17;
            this.label_boatManufacturer.Text = "Manufacturer:";
            // 
            // label_boatYear
            // 
            this.label_boatYear.AutoSize = true;
            this.label_boatYear.Location = new System.Drawing.Point(400, 340);
            this.label_boatYear.Name = "label_boatYear";
            this.label_boatYear.Size = new System.Drawing.Size(32, 13);
            this.label_boatYear.TabIndex = 18;
            this.label_boatYear.Text = "Year:";
            // 
            // label_customerOwnedBoats
            // 
            this.label_customerOwnedBoats.AutoSize = true;
            this.label_customerOwnedBoats.Location = new System.Drawing.Point(19, 339);
            this.label_customerOwnedBoats.Name = "label_customerOwnedBoats";
            this.label_customerOwnedBoats.Size = new System.Drawing.Size(0, 13);
            this.label_customerOwnedBoats.TabIndex = 19;
            // 
            // label_comment
            // 
            this.label_comment.AutoSize = true;
            this.label_comment.Location = new System.Drawing.Point(12, 485);
            this.label_comment.Name = "label_comment";
            this.label_comment.Size = new System.Drawing.Size(99, 13);
            this.label_comment.TabIndex = 21;
            this.label_comment.Text = "Program Comment: ";
            // 
            // groupBox_customerOwnedBoats
            // 
            this.groupBox_customerOwnedBoats.Controls.Add(this.listBox_ownedBoats);
            this.groupBox_customerOwnedBoats.Location = new System.Drawing.Point(16, 339);
            this.groupBox_customerOwnedBoats.Name = "groupBox_customerOwnedBoats";
            this.groupBox_customerOwnedBoats.Size = new System.Drawing.Size(200, 100);
            this.groupBox_customerOwnedBoats.TabIndex = 22;
            this.groupBox_customerOwnedBoats.TabStop = false;
            this.groupBox_customerOwnedBoats.Text = "Boats Owned:";
            // 
            // listBox_ownedBoats
            // 
            this.listBox_ownedBoats.FormattingEnabled = true;
            this.listBox_ownedBoats.Location = new System.Drawing.Point(20, 19);
            this.listBox_ownedBoats.Name = "listBox_ownedBoats";
            this.listBox_ownedBoats.Size = new System.Drawing.Size(163, 69);
            this.listBox_ownedBoats.TabIndex = 0;
            // 
            // button_assignBoat
            // 
            this.button_assignBoat.Location = new System.Drawing.Point(274, 165);
            this.button_assignBoat.Name = "button_assignBoat";
            this.button_assignBoat.Size = new System.Drawing.Size(75, 23);
            this.button_assignBoat.TabIndex = 23;
            this.button_assignBoat.Text = "Assign boat";
            this.button_assignBoat.UseVisualStyleBackColor = true;
            this.button_assignBoat.Click += new System.EventHandler(this.button_assignBoat_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 507);
            this.Controls.Add(this.button_assignBoat);
            this.Controls.Add(this.groupBox_customerOwnedBoats);
            this.Controls.Add(this.label_comment);
            this.Controls.Add(this.label_customerOwnedBoats);
            this.Controls.Add(this.label_boatYear);
            this.Controls.Add(this.label_boatManufacturer);
            this.Controls.Add(this.label_boatLength);
            this.Controls.Add(this.label_boatType);
            this.Controls.Add(this.label_boatRegNum);
            this.Controls.Add(this.listBox_boats);
            this.Controls.Add(this.label_boats);
            this.Controls.Add(this.label_customerPhone);
            this.Controls.Add(this.label_customerAddress);
            this.Controls.Add(this.label_customerName);
            this.Controls.Add(this.listBox_customers);
            this.Controls.Add(this.label_customers);
            this.Controls.Add(this.button_boatSave);
            this.Controls.Add(this.button_boatLoad);
            this.Controls.Add(this.textBox_boatFilePath);
            this.Controls.Add(this.label_boatFilePath);
            this.Controls.Add(this.button_customerLoad);
            this.Controls.Add(this.textBox_customerFilePath);
            this.Controls.Add(this.label_customerFilePath);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox_customerOwnedBoats.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_customerFilePath;
        private System.Windows.Forms.TextBox textBox_customerFilePath;
        private System.Windows.Forms.Button button_customerLoad;
        private System.Windows.Forms.Button button_boatLoad;
        private System.Windows.Forms.TextBox textBox_boatFilePath;
        private System.Windows.Forms.Label label_boatFilePath;
        private System.Windows.Forms.Button button_boatSave;
        private System.Windows.Forms.Label label_customers;
        private System.Windows.Forms.ListBox listBox_customers;
        private System.Windows.Forms.Label label_customerName;
        private System.Windows.Forms.Label label_customerAddress;
        private System.Windows.Forms.Label label_customerPhone;
        private System.Windows.Forms.Label label_boatLength;
        private System.Windows.Forms.Label label_boatType;
        private System.Windows.Forms.Label label_boatRegNum;
        private System.Windows.Forms.ListBox listBox_boats;
        private System.Windows.Forms.Label label_boats;
        private System.Windows.Forms.Label label_boatManufacturer;
        private System.Windows.Forms.Label label_boatYear;
        private System.Windows.Forms.Label label_customerOwnedBoats;
        private System.Windows.Forms.Label label_comment;
        private System.Windows.Forms.GroupBox groupBox_customerOwnedBoats;
        private System.Windows.Forms.ListBox listBox_ownedBoats;
        private System.Windows.Forms.Button button_assignBoat;
    }
}

