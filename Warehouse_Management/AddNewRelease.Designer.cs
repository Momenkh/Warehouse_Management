namespace Warehouse_Management
{
    partial class AddNewRelease
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
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonOK = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_Expire_Date = new System.Windows.Forms.TextBox();
            this.textBox_Production_Date = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_Quantity = new System.Windows.Forms.TextBox();
            this.textBox_permission_ID = new System.Windows.Forms.TextBox();
            this.comboBox_product_code = new System.Windows.Forms.ComboBox();
            this.comboBox_WH_name = new System.Windows.Forms.ComboBox();
            this.comboBox_client_name = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(198, 372);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 33;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(63, 372);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 32;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(28, 315);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 13);
            this.label8.TabIndex = 31;
            this.label8.Text = "Expiration Date";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(28, 275);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 13);
            this.label7.TabIndex = 30;
            this.label7.Text = "Production Date";
            // 
            // textBox_Expire_Date
            // 
            this.textBox_Expire_Date.Location = new System.Drawing.Point(128, 312);
            this.textBox_Expire_Date.Name = "textBox_Expire_Date";
            this.textBox_Expire_Date.Size = new System.Drawing.Size(172, 20);
            this.textBox_Expire_Date.TabIndex = 29;
            // 
            // textBox_Production_Date
            // 
            this.textBox_Production_Date.Location = new System.Drawing.Point(128, 272);
            this.textBox_Production_Date.Name = "textBox_Production_Date";
            this.textBox_Production_Date.Size = new System.Drawing.Size(172, 20);
            this.textBox_Production_Date.TabIndex = 28;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(56, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(233, 25);
            this.label6.TabIndex = 27;
            this.label6.Text = "New release permission";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 238);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "Quantity";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Product Code";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Warehouse Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Client\'s Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Permission ID";
            // 
            // textBox_Quantity
            // 
            this.textBox_Quantity.Location = new System.Drawing.Point(128, 235);
            this.textBox_Quantity.Name = "textBox_Quantity";
            this.textBox_Quantity.Size = new System.Drawing.Size(172, 20);
            this.textBox_Quantity.TabIndex = 21;
            // 
            // textBox_permission_ID
            // 
            this.textBox_permission_ID.Location = new System.Drawing.Point(128, 85);
            this.textBox_permission_ID.Name = "textBox_permission_ID";
            this.textBox_permission_ID.Size = new System.Drawing.Size(172, 20);
            this.textBox_permission_ID.TabIndex = 17;
            // 
            // comboBox_product_code
            // 
            this.comboBox_product_code.FormattingEnabled = true;
            this.comboBox_product_code.Location = new System.Drawing.Point(128, 197);
            this.comboBox_product_code.Name = "comboBox_product_code";
            this.comboBox_product_code.Size = new System.Drawing.Size(172, 21);
            this.comboBox_product_code.TabIndex = 36;
            // 
            // comboBox_WH_name
            // 
            this.comboBox_WH_name.FormattingEnabled = true;
            this.comboBox_WH_name.Location = new System.Drawing.Point(128, 159);
            this.comboBox_WH_name.Name = "comboBox_WH_name";
            this.comboBox_WH_name.Size = new System.Drawing.Size(172, 21);
            this.comboBox_WH_name.TabIndex = 35;
            // 
            // comboBox_client_name
            // 
            this.comboBox_client_name.FormattingEnabled = true;
            this.comboBox_client_name.Location = new System.Drawing.Point(128, 122);
            this.comboBox_client_name.Name = "comboBox_client_name";
            this.comboBox_client_name.Size = new System.Drawing.Size(172, 21);
            this.comboBox_client_name.TabIndex = 34;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(135, 296);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 13);
            this.label9.TabIndex = 37;
            this.label9.Text = "dd/MM/yyyy";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(135, 335);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 13);
            this.label10.TabIndex = 38;
            this.label10.Text = "dd/MM/yyyy";
            // 
            // AddNewRelease
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 431);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.comboBox_product_code);
            this.Controls.Add(this.comboBox_WH_name);
            this.Controls.Add(this.comboBox_client_name);
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
            this.Name = "AddNewRelease";
            this.Text = "AddNewRelease";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox_Expire_Date;
        private System.Windows.Forms.TextBox textBox_Production_Date;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_Quantity;
        private System.Windows.Forms.TextBox textBox_permission_ID;
        private System.Windows.Forms.ComboBox comboBox_product_code;
        private System.Windows.Forms.ComboBox comboBox_WH_name;
        private System.Windows.Forms.ComboBox comboBox_client_name;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}