using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Warehouse_Management
{
    public partial class EditSupplier : Form
    {
        Supplier S { get; set; }
        Model WHM { get; set; }
        public EditSupplier(ref Supplier s, ref Model WHMM)
        {
            InitializeComponent();
            this.MinimumSize = new Size(this.Width, this.Height);
            this.MaximumSize = new Size(this.Width, this.Height);
            S = s;
            WHM = WHMM;
            Mainlabel.Text += S.Supplier_Name;
            textBox_Tele.Text = S.Supplier_tele;
            textBox_Fax.Text = S.Supplier_fax;
            textBox_Mobile.Text = S.Supplier_mob;
            textBox_Mail.Text = S.Supplier_email;
            textBox_Web.Text = S.Supplier_website;
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            S.Supplier_tele = textBox_Tele.Text;
            S.Supplier_fax = textBox_Fax.Text;
            S.Supplier_mob = textBox_Mobile.Text;
            S.Supplier_email = textBox_Mail.Text;
            S.Supplier_website = textBox_Web.Text;
            WHM.SaveChanges();
            this.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
