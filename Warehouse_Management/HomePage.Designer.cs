namespace Warehouse_Management
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
            this.comboBox_WH = new System.Windows.Forms.ComboBox();
            this.Add_WH = new System.Windows.Forms.Button();
            this.Edit_WH = new System.Windows.Forms.Button();
            this.DisplayData = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox_WH_Name = new System.Windows.Forms.ListBox();
            this.listBox_Suppliers = new System.Windows.Forms.ListBox();
            this.listBox_Clients = new System.Windows.Forms.ListBox();
            this.listBox_Products_Code = new System.Windows.Forms.ListBox();
            this.Edit_Product_Type = new System.Windows.Forms.Button();
            this.Add_Product_Type = new System.Windows.Forms.Button();
            this.Edit_Supplier = new System.Windows.Forms.Button();
            this.Add_Supplier = new System.Windows.Forms.Button();
            this.Edit_Client = new System.Windows.Forms.Button();
            this.Add_Client = new System.Windows.Forms.Button();
            this.listBox_Products_Name = new System.Windows.Forms.ListBox();
            this.listBox_Products_Quantity = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.listBox_WH_Address = new System.Windows.Forms.ListBox();
            this.listBox_WH_Manager = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.listBoxPMUnit = new System.Windows.Forms.ListBox();
            this.listBoxPName = new System.Windows.Forms.ListBox();
            this.listBoxPCode = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.Edit_Product_inWH = new System.Windows.Forms.Button();
            this.Add_Product_toWH = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label_Suppliers = new System.Windows.Forms.Label();
            this.label_Clients = new System.Windows.Forms.Label();
            this.New_Entry_perm = new System.Windows.Forms.Button();
            this.New_Release_perm = new System.Windows.Forms.Button();
            this.Send_to_WH = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.comboBox_WH_reports = new System.Windows.Forms.ComboBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listView2 = new System.Windows.Forms.ListView();
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader14 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader15 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader16 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.button_clear_listview = new System.Windows.Forms.Button();
            this.Edit_Entry_Permit = new System.Windows.Forms.Button();
            this.Edit_Release_Permit = new System.Windows.Forms.Button();
            this.dateTimePicker_Reports1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_Reports2 = new System.Windows.Forms.DateTimePicker();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.filterByDate_reports = new System.Windows.Forms.Button();
            this.label_products = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBox_WH
            // 
            this.comboBox_WH.FormattingEnabled = true;
            this.comboBox_WH.Location = new System.Drawing.Point(733, 33);
            this.comboBox_WH.Name = "comboBox_WH";
            this.comboBox_WH.Size = new System.Drawing.Size(154, 21);
            this.comboBox_WH.TabIndex = 0;
            this.comboBox_WH.SelectedIndexChanged += new System.EventHandler(this.comboBox_WH_SelectedIndexChanged);
            // 
            // Add_WH
            // 
            this.Add_WH.Location = new System.Drawing.Point(344, 226);
            this.Add_WH.Name = "Add_WH";
            this.Add_WH.Size = new System.Drawing.Size(108, 23);
            this.Add_WH.TabIndex = 1;
            this.Add_WH.Text = "Add Warehouse";
            this.Add_WH.UseVisualStyleBackColor = true;
            this.Add_WH.Click += new System.EventHandler(this.Add_WH_Click);
            // 
            // Edit_WH
            // 
            this.Edit_WH.Location = new System.Drawing.Point(344, 259);
            this.Edit_WH.Name = "Edit_WH";
            this.Edit_WH.Size = new System.Drawing.Size(108, 23);
            this.Edit_WH.TabIndex = 2;
            this.Edit_WH.Text = "Edit Warehouse";
            this.Edit_WH.UseVisualStyleBackColor = true;
            this.Edit_WH.Click += new System.EventHandler(this.Edit_WH_Click);
            // 
            // DisplayData
            // 
            this.DisplayData.BackColor = System.Drawing.Color.PaleGreen;
            this.DisplayData.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.DisplayData.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(255)))), ((int)(((byte)(162)))));
            this.DisplayData.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(255)))), ((int)(((byte)(202)))));
            this.DisplayData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DisplayData.Location = new System.Drawing.Point(0, 0);
            this.DisplayData.Name = "DisplayData";
            this.DisplayData.Size = new System.Drawing.Size(103, 35);
            this.DisplayData.TabIndex = 3;
            this.DisplayData.Text = "Display/Refresh";
            this.DisplayData.UseVisualStyleBackColor = false;
            this.DisplayData.Click += new System.EventHandler(this.DisplayData_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(483, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "Products in warehouse name";
            // 
            // listBox_WH_Name
            // 
            this.listBox_WH_Name.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox_WH_Name.FormattingEnabled = true;
            this.listBox_WH_Name.ItemHeight = 16;
            this.listBox_WH_Name.Location = new System.Drawing.Point(12, 83);
            this.listBox_WH_Name.Name = "listBox_WH_Name";
            this.listBox_WH_Name.Size = new System.Drawing.Size(73, 356);
            this.listBox_WH_Name.TabIndex = 5;
            this.listBox_WH_Name.SelectedIndexChanged += new System.EventHandler(this.listBox_WH_Name_SelectedIndexChanged);
            // 
            // listBox_Suppliers
            // 
            this.listBox_Suppliers.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox_Suppliers.FormattingEnabled = true;
            this.listBox_Suppliers.ItemHeight = 16;
            this.listBox_Suppliers.Location = new System.Drawing.Point(1597, 70);
            this.listBox_Suppliers.Name = "listBox_Suppliers";
            this.listBox_Suppliers.Size = new System.Drawing.Size(138, 356);
            this.listBox_Suppliers.TabIndex = 6;
            this.listBox_Suppliers.SelectedIndexChanged += new System.EventHandler(this.listBox_Suppliers_SelectedIndexChanged);
            this.listBox_Suppliers.DoubleClick += new System.EventHandler(this.listBox_Suppliers_DoubleClick);
            // 
            // listBox_Clients
            // 
            this.listBox_Clients.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox_Clients.FormattingEnabled = true;
            this.listBox_Clients.ItemHeight = 16;
            this.listBox_Clients.Location = new System.Drawing.Point(1597, 518);
            this.listBox_Clients.Name = "listBox_Clients";
            this.listBox_Clients.Size = new System.Drawing.Size(138, 356);
            this.listBox_Clients.TabIndex = 7;
            this.listBox_Clients.SelectedIndexChanged += new System.EventHandler(this.listBox_Clients_SelectedIndexChanged);
            this.listBox_Clients.DoubleClick += new System.EventHandler(this.listBox_Clients_DoubleClick);
            // 
            // listBox_Products_Code
            // 
            this.listBox_Products_Code.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox_Products_Code.FormattingEnabled = true;
            this.listBox_Products_Code.ItemHeight = 16;
            this.listBox_Products_Code.Location = new System.Drawing.Point(499, 82);
            this.listBox_Products_Code.Name = "listBox_Products_Code";
            this.listBox_Products_Code.Size = new System.Drawing.Size(87, 884);
            this.listBox_Products_Code.TabIndex = 8;
            this.listBox_Products_Code.SelectedIndexChanged += new System.EventHandler(this.listBox_Products_Code_SelectedIndexChanged);
            // 
            // Edit_Product_Type
            // 
            this.Edit_Product_Type.Location = new System.Drawing.Point(350, 703);
            this.Edit_Product_Type.Name = "Edit_Product_Type";
            this.Edit_Product_Type.Size = new System.Drawing.Size(108, 23);
            this.Edit_Product_Type.TabIndex = 10;
            this.Edit_Product_Type.Text = "Edit Product type";
            this.Edit_Product_Type.UseVisualStyleBackColor = true;
            this.Edit_Product_Type.Click += new System.EventHandler(this.Edit_Product_Type_Click);
            // 
            // Add_Product_Type
            // 
            this.Add_Product_Type.Location = new System.Drawing.Point(350, 674);
            this.Add_Product_Type.Name = "Add_Product_Type";
            this.Add_Product_Type.Size = new System.Drawing.Size(108, 23);
            this.Add_Product_Type.TabIndex = 9;
            this.Add_Product_Type.Text = "Add Product type";
            this.Add_Product_Type.UseVisualStyleBackColor = true;
            this.Add_Product_Type.Click += new System.EventHandler(this.Add_Product_Type_Click);
            // 
            // Edit_Supplier
            // 
            this.Edit_Supplier.Location = new System.Drawing.Point(1777, 111);
            this.Edit_Supplier.Name = "Edit_Supplier";
            this.Edit_Supplier.Size = new System.Drawing.Size(108, 23);
            this.Edit_Supplier.TabIndex = 12;
            this.Edit_Supplier.Text = "Edit Supplier";
            this.Edit_Supplier.UseVisualStyleBackColor = true;
            this.Edit_Supplier.Click += new System.EventHandler(this.Edit_Supplier_Click);
            // 
            // Add_Supplier
            // 
            this.Add_Supplier.Location = new System.Drawing.Point(1777, 82);
            this.Add_Supplier.Name = "Add_Supplier";
            this.Add_Supplier.Size = new System.Drawing.Size(108, 23);
            this.Add_Supplier.TabIndex = 11;
            this.Add_Supplier.Text = "Add Supplier";
            this.Add_Supplier.UseVisualStyleBackColor = true;
            this.Add_Supplier.Click += new System.EventHandler(this.Add_Supplier_Click);
            // 
            // Edit_Client
            // 
            this.Edit_Client.Location = new System.Drawing.Point(1777, 580);
            this.Edit_Client.Name = "Edit_Client";
            this.Edit_Client.Size = new System.Drawing.Size(108, 23);
            this.Edit_Client.TabIndex = 14;
            this.Edit_Client.Text = "Edit Client";
            this.Edit_Client.UseVisualStyleBackColor = true;
            this.Edit_Client.Click += new System.EventHandler(this.Edit_Client_Click);
            // 
            // Add_Client
            // 
            this.Add_Client.Location = new System.Drawing.Point(1777, 551);
            this.Add_Client.Name = "Add_Client";
            this.Add_Client.Size = new System.Drawing.Size(108, 23);
            this.Add_Client.TabIndex = 13;
            this.Add_Client.Text = "Add Client";
            this.Add_Client.UseVisualStyleBackColor = true;
            this.Add_Client.Click += new System.EventHandler(this.Add_Client_Click);
            // 
            // listBox_Products_Name
            // 
            this.listBox_Products_Name.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox_Products_Name.FormattingEnabled = true;
            this.listBox_Products_Name.ItemHeight = 16;
            this.listBox_Products_Name.Location = new System.Drawing.Point(585, 82);
            this.listBox_Products_Name.Name = "listBox_Products_Name";
            this.listBox_Products_Name.Size = new System.Drawing.Size(183, 884);
            this.listBox_Products_Name.TabIndex = 15;
            this.listBox_Products_Name.SelectedIndexChanged += new System.EventHandler(this.listBox_Products_Name_SelectedIndexChanged);
            // 
            // listBox_Products_Quantity
            // 
            this.listBox_Products_Quantity.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox_Products_Quantity.FormattingEnabled = true;
            this.listBox_Products_Quantity.ItemHeight = 16;
            this.listBox_Products_Quantity.Location = new System.Drawing.Point(767, 82);
            this.listBox_Products_Quantity.Name = "listBox_Products_Quantity";
            this.listBox_Products_Quantity.Size = new System.Drawing.Size(95, 884);
            this.listBox_Products_Quantity.TabIndex = 16;
            this.listBox_Products_Quantity.SelectedIndexChanged += new System.EventHandler(this.listBox_Products_Quantity_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(642, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 16);
            this.label2.TabIndex = 17;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(519, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 16);
            this.label3.TabIndex = 18;
            this.label3.Text = "Code";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(794, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 16);
            this.label4.TabIndex = 19;
            this.label4.Text = "Quantity";
            // 
            // listBox_WH_Address
            // 
            this.listBox_WH_Address.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox_WH_Address.FormattingEnabled = true;
            this.listBox_WH_Address.ItemHeight = 16;
            this.listBox_WH_Address.Location = new System.Drawing.Point(84, 83);
            this.listBox_WH_Address.Name = "listBox_WH_Address";
            this.listBox_WH_Address.Size = new System.Drawing.Size(169, 356);
            this.listBox_WH_Address.TabIndex = 20;
            this.listBox_WH_Address.SelectedIndexChanged += new System.EventHandler(this.listBox_WH_Address_SelectedIndexChanged);
            // 
            // listBox_WH_Manager
            // 
            this.listBox_WH_Manager.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox_WH_Manager.FormattingEnabled = true;
            this.listBox_WH_Manager.ItemHeight = 16;
            this.listBox_WH_Manager.Location = new System.Drawing.Point(252, 83);
            this.listBox_WH_Manager.Name = "listBox_WH_Manager";
            this.listBox_WH_Manager.Size = new System.Drawing.Size(81, 356);
            this.listBox_WH_Manager.TabIndex = 21;
            this.listBox_WH_Manager.SelectedIndexChanged += new System.EventHandler(this.listBox_WH_Manager_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(122, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 19);
            this.label5.TabIndex = 22;
            this.label5.Text = "Warehouses";
            // 
            // listBoxPMUnit
            // 
            this.listBoxPMUnit.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxPMUnit.FormattingEnabled = true;
            this.listBoxPMUnit.ItemHeight = 16;
            this.listBoxPMUnit.Location = new System.Drawing.Point(252, 518);
            this.listBoxPMUnit.Name = "listBoxPMUnit";
            this.listBoxPMUnit.Size = new System.Drawing.Size(81, 436);
            this.listBoxPMUnit.TabIndex = 25;
            this.listBoxPMUnit.SelectedIndexChanged += new System.EventHandler(this.listBoxPMUnit_SelectedIndexChanged);
            // 
            // listBoxPName
            // 
            this.listBoxPName.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxPName.FormattingEnabled = true;
            this.listBoxPName.ItemHeight = 16;
            this.listBoxPName.Location = new System.Drawing.Point(84, 518);
            this.listBoxPName.Name = "listBoxPName";
            this.listBoxPName.Size = new System.Drawing.Size(169, 436);
            this.listBoxPName.TabIndex = 24;
            this.listBoxPName.SelectedIndexChanged += new System.EventHandler(this.listBoxPName_SelectedIndexChanged);
            this.listBoxPName.DoubleClick += new System.EventHandler(this.listBoxPName_DoubleClick);
            // 
            // listBoxPCode
            // 
            this.listBoxPCode.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxPCode.FormattingEnabled = true;
            this.listBoxPCode.ItemHeight = 16;
            this.listBoxPCode.Location = new System.Drawing.Point(12, 518);
            this.listBoxPCode.Name = "listBoxPCode";
            this.listBoxPCode.Size = new System.Drawing.Size(73, 436);
            this.listBoxPCode.TabIndex = 23;
            this.listBoxPCode.SelectedIndexChanged += new System.EventHandler(this.listBoxPCode_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(28, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 16);
            this.label6.TabIndex = 26;
            this.label6.Text = "Name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(141, 64);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 16);
            this.label7.TabIndex = 27;
            this.label7.Text = "Address";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(265, 64);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 16);
            this.label8.TabIndex = 28;
            this.label8.Text = "Manager";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(141, 464);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(121, 19);
            this.label9.TabIndex = 29;
            this.label9.Text = "Product types";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(278, 499);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 16);
            this.label10.TabIndex = 32;
            this.label10.Text = "Unit";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(31, 499);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(36, 16);
            this.label11.TabIndex = 31;
            this.label11.Text = "Code";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(151, 499);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(40, 16);
            this.label12.TabIndex = 30;
            this.label12.Text = "Name";
            // 
            // Edit_Product_inWH
            // 
            this.Edit_Product_inWH.Location = new System.Drawing.Point(874, 285);
            this.Edit_Product_inWH.Name = "Edit_Product_inWH";
            this.Edit_Product_inWH.Size = new System.Drawing.Size(108, 35);
            this.Edit_Product_inWH.TabIndex = 34;
            this.Edit_Product_inWH.Text = "Edit Product in warehouse";
            this.Edit_Product_inWH.UseVisualStyleBackColor = true;
            this.Edit_Product_inWH.Click += new System.EventHandler(this.Edit_Product_inWH_Click);
            // 
            // Add_Product_toWH
            // 
            this.Add_Product_toWH.Location = new System.Drawing.Point(874, 244);
            this.Add_Product_toWH.Name = "Add_Product_toWH";
            this.Add_Product_toWH.Size = new System.Drawing.Size(108, 35);
            this.Add_Product_toWH.TabIndex = 33;
            this.Add_Product_toWH.Text = "Add Product to warehouse";
            this.Add_Product_toWH.UseVisualStyleBackColor = true;
            this.Add_Product_toWH.Click += new System.EventHandler(this.Add_Product_toWH_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(1626, 25);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(84, 19);
            this.label13.TabIndex = 35;
            this.label13.Text = "Suppliers";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(1626, 474);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(65, 19);
            this.label14.TabIndex = 36;
            this.label14.Text = "Clients";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(1604, 51);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(91, 16);
            this.label15.TabIndex = 37;
            this.label15.Text = "Supplier Name";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(1604, 499);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(76, 16);
            this.label16.TabIndex = 38;
            this.label16.Text = "Client Name";
            // 
            // label_Suppliers
            // 
            this.label_Suppliers.AutoSize = true;
            this.label_Suppliers.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Suppliers.Location = new System.Drawing.Point(1748, 151);
            this.label_Suppliers.Name = "label_Suppliers";
            this.label_Suppliers.Size = new System.Drawing.Size(59, 21);
            this.label_Suppliers.TabIndex = 39;
            this.label_Suppliers.Text = "Suppliers";
            this.label_Suppliers.UseCompatibleTextRendering = true;
            // 
            // label_Clients
            // 
            this.label_Clients.AutoSize = true;
            this.label_Clients.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Clients.Location = new System.Drawing.Point(1748, 638);
            this.label_Clients.Name = "label_Clients";
            this.label_Clients.Size = new System.Drawing.Size(44, 21);
            this.label_Clients.TabIndex = 40;
            this.label_Clients.Text = "Clients";
            this.label_Clients.UseCompatibleTextRendering = true;
            // 
            // New_Entry_perm
            // 
            this.New_Entry_perm.Location = new System.Drawing.Point(874, 326);
            this.New_Entry_perm.Name = "New_Entry_perm";
            this.New_Entry_perm.Size = new System.Drawing.Size(108, 35);
            this.New_Entry_perm.TabIndex = 41;
            this.New_Entry_perm.Text = "New Entry Permission";
            this.New_Entry_perm.UseVisualStyleBackColor = true;
            this.New_Entry_perm.Click += new System.EventHandler(this.New_Entry_perm_Click);
            // 
            // New_Release_perm
            // 
            this.New_Release_perm.Location = new System.Drawing.Point(874, 367);
            this.New_Release_perm.Name = "New_Release_perm";
            this.New_Release_perm.Size = new System.Drawing.Size(108, 35);
            this.New_Release_perm.TabIndex = 42;
            this.New_Release_perm.Text = "New Release Permission";
            this.New_Release_perm.UseVisualStyleBackColor = true;
            this.New_Release_perm.Click += new System.EventHandler(this.New_Release_perm_Click);
            // 
            // Send_to_WH
            // 
            this.Send_to_WH.Location = new System.Drawing.Point(874, 408);
            this.Send_to_WH.Name = "Send_to_WH";
            this.Send_to_WH.Size = new System.Drawing.Size(108, 35);
            this.Send_to_WH.TabIndex = 43;
            this.Send_to_WH.Text = "Send to another warehouse";
            this.Send_to_WH.UseVisualStyleBackColor = true;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(1120, 18);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(221, 19);
            this.label17.TabIndex = 45;
            this.label17.Text = "Reports from warehouse: ";
            // 
            // comboBox_WH_reports
            // 
            this.comboBox_WH_reports.FormattingEnabled = true;
            this.comboBox_WH_reports.Location = new System.Drawing.Point(1352, 18);
            this.comboBox_WH_reports.Name = "comboBox_WH_reports";
            this.comboBox_WH_reports.Size = new System.Drawing.Size(154, 21);
            this.comboBox_WH_reports.TabIndex = 44;
            this.comboBox_WH_reports.SelectedIndexChanged += new System.EventHandler(this.comboBox_WH_reports_SelectedIndexChanged);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.listView1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(1036, 70);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(541, 356);
            this.listView1.TabIndex = 46;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "WH";
            this.columnHeader1.Width = 40;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Supplier";
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Permission";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Prod_Code";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Quantity";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "prod_date";
            this.columnHeader6.Width = 65;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "expire_date";
            this.columnHeader7.Width = 65;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "issue_date";
            this.columnHeader8.Width = 65;
            // 
            // listView2
            // 
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11,
            this.columnHeader12,
            this.columnHeader13,
            this.columnHeader14,
            this.columnHeader15,
            this.columnHeader16});
            this.listView2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView2.GridLines = true;
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(1036, 518);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(541, 356);
            this.listView2.TabIndex = 47;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "WH";
            this.columnHeader9.Width = 40;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Client";
            this.columnHeader10.Width = 100;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Permission";
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Prod_Code";
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "Quantity";
            // 
            // columnHeader14
            // 
            this.columnHeader14.Text = "prod_date";
            this.columnHeader14.Width = 65;
            // 
            // columnHeader15
            // 
            this.columnHeader15.Text = "expire_date";
            this.columnHeader15.Width = 65;
            // 
            // columnHeader16
            // 
            this.columnHeader16.Text = "issue_date";
            this.columnHeader16.Width = 65;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(1081, 49);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(133, 21);
            this.label18.TabIndex = 48;
            this.label18.Text = "Entries from suppliers";
            this.label18.UseCompatibleTextRendering = true;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(1081, 497);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(114, 21);
            this.label19.TabIndex = 49;
            this.label19.Text = "Releases to clients";
            this.label19.UseCompatibleTextRendering = true;
            // 
            // button_clear_listview
            // 
            this.button_clear_listview.Location = new System.Drawing.Point(1374, 41);
            this.button_clear_listview.Name = "button_clear_listview";
            this.button_clear_listview.Size = new System.Drawing.Size(108, 23);
            this.button_clear_listview.TabIndex = 50;
            this.button_clear_listview.Text = "Clear results";
            this.button_clear_listview.UseVisualStyleBackColor = true;
            this.button_clear_listview.Click += new System.EventHandler(this.button_clear_listview_Click);
            // 
            // Edit_Entry_Permit
            // 
            this.Edit_Entry_Permit.Location = new System.Drawing.Point(1469, 432);
            this.Edit_Entry_Permit.Name = "Edit_Entry_Permit";
            this.Edit_Entry_Permit.Size = new System.Drawing.Size(108, 35);
            this.Edit_Entry_Permit.TabIndex = 51;
            this.Edit_Entry_Permit.Text = "Edit entry permit";
            this.Edit_Entry_Permit.UseVisualStyleBackColor = true;
            this.Edit_Entry_Permit.Click += new System.EventHandler(this.Edit_Entry_Permit_Click);
            // 
            // Edit_Release_Permit
            // 
            this.Edit_Release_Permit.Location = new System.Drawing.Point(1469, 880);
            this.Edit_Release_Permit.Name = "Edit_Release_Permit";
            this.Edit_Release_Permit.Size = new System.Drawing.Size(108, 35);
            this.Edit_Release_Permit.TabIndex = 52;
            this.Edit_Release_Permit.Text = "Edit release permit";
            this.Edit_Release_Permit.UseVisualStyleBackColor = true;
            this.Edit_Release_Permit.Click += new System.EventHandler(this.Edit_Release_Permit_Click);
            // 
            // dateTimePicker_Reports1
            // 
            this.dateTimePicker_Reports1.Location = new System.Drawing.Point(1081, 895);
            this.dateTimePicker_Reports1.Name = "dateTimePicker_Reports1";
            this.dateTimePicker_Reports1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker_Reports1.TabIndex = 53;
            // 
            // dateTimePicker_Reports2
            // 
            this.dateTimePicker_Reports2.Location = new System.Drawing.Point(1081, 946);
            this.dateTimePicker_Reports2.Name = "dateTimePicker_Reports2";
            this.dateTimePicker_Reports2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker_Reports2.TabIndex = 54;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(1033, 895);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(37, 16);
            this.label20.TabIndex = 55;
            this.label20.Text = "From";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(1048, 946);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(22, 16);
            this.label21.TabIndex = 56;
            this.label21.Text = "To";
            // 
            // filterByDate_reports
            // 
            this.filterByDate_reports.Location = new System.Drawing.Point(1297, 931);
            this.filterByDate_reports.Name = "filterByDate_reports";
            this.filterByDate_reports.Size = new System.Drawing.Size(88, 35);
            this.filterByDate_reports.TabIndex = 57;
            this.filterByDate_reports.Text = "Filter";
            this.filterByDate_reports.UseVisualStyleBackColor = true;
            this.filterByDate_reports.Click += new System.EventHandler(this.filterByDate_reports_Click);
            // 
            // label_products
            // 
            this.label_products.AutoSize = true;
            this.label_products.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_products.Location = new System.Drawing.Point(350, 738);
            this.label_products.Name = "label_products";
            this.label_products.Size = new System.Drawing.Size(44, 21);
            this.label_products.TabIndex = 58;
            this.label_products.Text = "Clients";
            this.label_products.UseCompatibleTextRendering = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1888, 994);
            this.Controls.Add(this.label_products);
            this.Controls.Add(this.filterByDate_reports);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.dateTimePicker_Reports2);
            this.Controls.Add(this.dateTimePicker_Reports1);
            this.Controls.Add(this.Edit_Release_Permit);
            this.Controls.Add(this.Edit_Entry_Permit);
            this.Controls.Add(this.button_clear_listview);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.comboBox_WH_reports);
            this.Controls.Add(this.Send_to_WH);
            this.Controls.Add(this.New_Release_perm);
            this.Controls.Add(this.New_Entry_perm);
            this.Controls.Add(this.label_Clients);
            this.Controls.Add(this.label_Suppliers);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.Edit_Product_inWH);
            this.Controls.Add(this.Add_Product_toWH);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.listBoxPMUnit);
            this.Controls.Add(this.listBoxPName);
            this.Controls.Add(this.listBoxPCode);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.listBox_WH_Manager);
            this.Controls.Add(this.listBox_WH_Address);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBox_Products_Quantity);
            this.Controls.Add(this.listBox_Products_Name);
            this.Controls.Add(this.Edit_Client);
            this.Controls.Add(this.Add_Client);
            this.Controls.Add(this.Edit_Supplier);
            this.Controls.Add(this.Add_Supplier);
            this.Controls.Add(this.Edit_Product_Type);
            this.Controls.Add(this.Add_Product_Type);
            this.Controls.Add(this.listBox_Products_Code);
            this.Controls.Add(this.listBox_Clients);
            this.Controls.Add(this.listBox_Suppliers);
            this.Controls.Add(this.listBox_WH_Name);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DisplayData);
            this.Controls.Add(this.Edit_WH);
            this.Controls.Add(this.Add_WH);
            this.Controls.Add(this.comboBox_WH);
            this.Name = "Form1";
            this.Text = "Warehouse";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_WH;
        private System.Windows.Forms.Button Add_WH;
        private System.Windows.Forms.Button Edit_WH;
        private System.Windows.Forms.Button DisplayData;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox_WH_Name;
        private System.Windows.Forms.ListBox listBox_Suppliers;
        private System.Windows.Forms.ListBox listBox_Clients;
        private System.Windows.Forms.ListBox listBox_Products_Code;
        private System.Windows.Forms.Button Edit_Product_Type;
        private System.Windows.Forms.Button Add_Product_Type;
        private System.Windows.Forms.Button Edit_Supplier;
        private System.Windows.Forms.Button Add_Supplier;
        private System.Windows.Forms.Button Edit_Client;
        private System.Windows.Forms.Button Add_Client;
        private System.Windows.Forms.ListBox listBox_Products_Name;
        private System.Windows.Forms.ListBox listBox_Products_Quantity;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listBox_WH_Address;
        private System.Windows.Forms.ListBox listBox_WH_Manager;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox listBoxPMUnit;
        private System.Windows.Forms.ListBox listBoxPName;
        private System.Windows.Forms.ListBox listBoxPCode;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button Edit_Product_inWH;
        private System.Windows.Forms.Button Add_Product_toWH;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label_Suppliers;
        private System.Windows.Forms.Label label_Clients;
        private System.Windows.Forms.Button New_Entry_perm;
        private System.Windows.Forms.Button New_Release_perm;
        private System.Windows.Forms.Button Send_to_WH;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox comboBox_WH_reports;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.ColumnHeader columnHeader14;
        private System.Windows.Forms.ColumnHeader columnHeader15;
        private System.Windows.Forms.ColumnHeader columnHeader16;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button button_clear_listview;
        private System.Windows.Forms.Button Edit_Entry_Permit;
        private System.Windows.Forms.Button Edit_Release_Permit;
        private System.Windows.Forms.DateTimePicker dateTimePicker_Reports1;
        private System.Windows.Forms.DateTimePicker dateTimePicker_Reports2;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Button filterByDate_reports;
        private System.Windows.Forms.Label label_products;
    }
}

