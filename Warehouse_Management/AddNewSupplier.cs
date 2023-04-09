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
    public partial class AddNewSupplier : Form
    {
        public AddNewSupplier()
        {
            InitializeComponent();
            this.MinimumSize = new Size(this.Width, this.Height);
            this.MaximumSize = new Size(this.Width, this.Height);
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            Model WHM = new Model();

            if (WHM.Warehouses.Find(textBox_Name.Text) == null)
            {
                Supplier S = new Supplier();
                S.Supplier_Name = textBox_Name.Text;
                S.Supplier_tele = textBox_Tele.Text;
                S.Supplier_fax = textBox_Fax.Text;
                S.Supplier_mob = textBox_Mobile.Text;
                S.Supplier_email = textBox_Mail.Text;
                S.Supplier_website = textBox_Web.Text;
                WHM.Suppliers.Add(S);
                WHM.SaveChangesAsync();
                this.Close();

            }
            else
            {

                MessageBox.Show("Name already exists");
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
