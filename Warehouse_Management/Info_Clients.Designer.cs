namespace Warehouse_Management
{
    partial class Info_Clients
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
            this.buttonOK = new System.Windows.Forms.Button();
            this.label_name = new System.Windows.Forms.Label();
            this.label_website = new System.Windows.Forms.Label();
            this.label_email = new System.Windows.Forms.Label();
            this.label_mobile = new System.Windows.Forms.Label();
            this.label_fax = new System.Windows.Forms.Label();
            this.label_tele = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(169, 275);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 35;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_name.Location = new System.Drawing.Point(39, 25);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(137, 23);
            this.label_name.TabIndex = 34;
            this.label_name.Text = "Client name: ";
            // 
            // label_website
            // 
            this.label_website.AutoSize = true;
            this.label_website.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label_website.Location = new System.Drawing.Point(39, 216);
            this.label_website.Name = "label_website";
            this.label_website.Size = new System.Drawing.Size(105, 19);
            this.label_website.TabIndex = 33;
            this.label_website.Text = "Website    :   ";
            // 
            // label_email
            // 
            this.label_email.AutoSize = true;
            this.label_email.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label_email.Location = new System.Drawing.Point(41, 180);
            this.label_email.Name = "label_email";
            this.label_email.Size = new System.Drawing.Size(103, 19);
            this.label_email.TabIndex = 32;
            this.label_email.Text = "E-Mail      :   ";
            // 
            // label_mobile
            // 
            this.label_mobile.AutoSize = true;
            this.label_mobile.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label_mobile.Location = new System.Drawing.Point(38, 145);
            this.label_mobile.Name = "label_mobile";
            this.label_mobile.Size = new System.Drawing.Size(106, 19);
            this.label_mobile.TabIndex = 31;
            this.label_mobile.Text = "Mobile      :   ";
            // 
            // label_fax
            // 
            this.label_fax.AutoSize = true;
            this.label_fax.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label_fax.Location = new System.Drawing.Point(40, 112);
            this.label_fax.Name = "label_fax";
            this.label_fax.Size = new System.Drawing.Size(104, 19);
            this.label_fax.TabIndex = 30;
            this.label_fax.Text = "Fax          :   ";
            // 
            // label_tele
            // 
            this.label_tele.AutoSize = true;
            this.label_tele.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label_tele.Location = new System.Drawing.Point(40, 80);
            this.label_tele.Name = "label_tele";
            this.label_tele.Size = new System.Drawing.Size(104, 19);
            this.label_tele.TabIndex = 29;
            this.label_tele.Text = "Telephone:   ";
            // 
            // Info_Clients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 331);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.label_name);
            this.Controls.Add(this.label_website);
            this.Controls.Add(this.label_email);
            this.Controls.Add(this.label_mobile);
            this.Controls.Add(this.label_fax);
            this.Controls.Add(this.label_tele);
            this.Name = "Info_Clients";
            this.Text = "Info_Clients";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.Label label_website;
        private System.Windows.Forms.Label label_email;
        private System.Windows.Forms.Label label_mobile;
        private System.Windows.Forms.Label label_fax;
        private System.Windows.Forms.Label label_tele;
    }
}