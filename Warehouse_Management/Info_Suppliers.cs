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
    public partial class Info_Suppliers : Form
    {
        public Info_Suppliers(Supplier x)
        {
            InitializeComponent();
            label_name.Text += x.Supplier_Name;
            label_tele.Text += x.Supplier_tele;
            label_fax.Text += x.Supplier_fax;
            label_mobile.Text += x.Supplier_mob;
            label_email.Text += x.Supplier_email;
            label_website.Text += x.Supplier_website;
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
