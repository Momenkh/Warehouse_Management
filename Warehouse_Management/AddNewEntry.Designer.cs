namespace Warehouse_Management
{
    partial class AddNewEntry
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
            this.textBox_permission_ID = new System.Windows.Forms.TextBox();
            this.textBox_Quantity = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_Production_Date = new System.Windows.Forms.TextBox();
            this.textBox_Expire_Date = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.comboBox_supplier_name = new System.Windows.Forms.ComboBox();
            this.comboBox_WH_name = new System.Windows.Forms.ComboBox();
            this.comboBox_product_code = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox_permission_ID
            // 
            this.textBox_permission_ID.Location = new System.Drawing.Point(128, 85);
            this.textBox_permission_ID.Name = "textBox_permission_ID";
            this.textBox_permission_ID.Size = new System.Drawing.Size(172, 20);
            this.textBox_permission_ID.TabIndex = 0;
            // 
            // textBox_Quantity
            // 
            this.textBox_Quantity.Location = new System.Drawing.Point(128, 235);
            this.textBox_Quantity.Name = "textBox_Quantity";
            this.textBox_Quantity.Size = new System.Drawing.Size(172, 20);
            this.textBox_Quantity.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Permission ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Supplier\'s Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Warehouse Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Product Code";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 238);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Quantity";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(58, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(215, 25);
            this.label6.TabIndex = 10;
            this.label6.Text = "New entry permission";
            // 
            // textBox_Production_Date
            // 
            this.textBox_Production_Date.Location = new System.Drawing.Point(128, 272);
            this.textBox_Production_Date.Name = "textBox_Production_Date";
            this.textBox_Production_Date.Size = new System.Drawing.Size(172, 20);
            this.textBox_Production_Date.TabIndex = 11;
            // 
            // textBox_Expire_Date
            // 
            this.textBox_Expire_Date.Location = new System.Drawing.Point(128, 312);
            this.textBox_Expire_Date.Name = "textBox_Expire_Date";
            this.textBox_Expire_Date.Size = new System.Drawing.Size(172, 20);
            this.textBox_Expire_Date.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(28, 275);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Production Date";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(28, 315);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Expiration Date";
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(63, 372);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 15;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(198, 372);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 16;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // comboBox_supplier_name
            // 
            this.comboBox_supplier_name.FormattingEnabled = true;
            this.comboBox_supplier_name.Location = new System.Drawing.Point(128, 122);
            this.comboBox_supplier_name.Name = "comboBox_supplier_name";
            this.comboBox_supplier_name.Size = new System.Drawing.Size(172, 21);
            this.comboBox_supplier_name.TabIndex = 17;
            // 
            // comboBox_WH_name
            // 
            this.comboBox_WH_name.FormattingEnabled = true;
            this.comboBox_WH_name.Location = new System.Drawing.Point(128, 159);
            this.comboBox_WH_name.Name = "comboBox_WH_name";
            this.comboBox_WH_name.Size = new System.Drawing.Size(172, 21);
            this.comboBox_WH_name.TabIndex = 18;
            // 
            // comboBox_product_code
            // 
            this.comboBox_product_code.FormattingEnabled = true;
            this.comboBox_product_code.Location = new System.Drawing.Point(128, 197);
            this.comboBox_product_code.Name = "comboBox_product_code";
            this.comboBox_product_code.Size = new System.Drawing.Size(172, 21);
            this.comboBox_product_code.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(135, 335);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 13);
            this.label10.TabIndex = 40;
            this.label10.Text = "dd/MM/yyyy";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(135, 296);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 13);
            this.label9.TabIndex = 39;
            this.label9.Text = "dd/MM/yyyy";
            // 
            // AddNewEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 431);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.comboBox_product_code);
            this.Controls.Add(this.comboBox_WH_name);
            this.Controls.Add(this.comboBox_supplier_name);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox_Expire_Date);
            this.Controls.Add(this.textBox_Production_Date);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_Quantity);
            this.Controls.Add(this.textBox_permission_ID);
            this.Name = "AddNewEntry";
            this.Text = "AddNewEntry";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_permission_ID;
        private System.Windows.Forms.TextBox textBox_Quantity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_Production_Date;
        private System.Windows.Forms.TextBox textBox_Expire_Date;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.ComboBox comboBox_supplier_name;
        private System.Windows.Forms.ComboBox comboBox_WH_name;
        private System.Windows.Forms.ComboBox comboBox_product_code;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
    }
}