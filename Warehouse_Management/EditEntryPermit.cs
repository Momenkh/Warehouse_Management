using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Warehouse_Management
{
    public partial class EditEntryPermit : Form
    {
        Suppliers_Product S;
        Model WHM;

        public EditEntryPermit(ref Suppliers_Product s, ref Model WHMM)
        {
            InitializeComponent();
            this.MinimumSize = new Size(this.Width, this.Height);
            this.MaximumSize = new Size(this.Width, this.Height);
            WHM = WHMM;
            S = s;
            Mainlabel.Text += s.Entry_Permit;
            var sup = from p in WHM.Suppliers select p.Supplier_Name;
            foreach (var ss in sup) { comboBox_supplier_name.Items.Add(ss); }
            sup = from p in WHM.Products select p.Product_Code;
            foreach (var ss in sup) { comboBox_product_code.Items.Add(ss); }
            sup = from p in WHM.Warehouses select p.WH_Name;
            foreach (var ss in sup) { comboBox_WH_name.Items.Add(ss); }
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (S != null)
            {
                var query = (from p in WHM.WH_ProductsList where p.WH_Name == S.WH_Name && p.Product_Code == S.Product_Code_entry select p).FirstOrDefault();
                if (query != null)
                {
                    query.Quantity -= S.Quantity;
                    if (query.Quantity == 0)
                    {
                        WHM.WH_ProductsList.Remove(query);
                        
                    }

                    var q = (from pr in WHM.WH_ProductsList where pr.WH_Name == comboBox_WH_name.Text && pr.Product_Code == comboBox_product_code.Text select pr).FirstOrDefault();
                    if (q != null)
                    {
                        q.Quantity += int.Parse(textBox_Quantity.Text);
                    }
                    else
                    {
                        WH_ProductsList p = new WH_ProductsList();
                        p.WH_Name = comboBox_WH_name.Text;
                        p.Product_Code = comboBox_product_code.Text;
                        p.Quantity = int.Parse(textBox_Quantity.Text);
                        WHM.WH_ProductsList.Add(q);
                    }
                }

                S.WH_Name = comboBox_WH_name.Text;
                S.Product_Code_entry = comboBox_product_code.Text;
                S.Supplier_Name = comboBox_supplier_name.Text;
                S.Quantity = int.Parse(textBox_Quantity.Text);
                try
                {
                    S.prod_date = DateTime.ParseExact(textBox_Production_Date.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                    S.exp_date = DateTime.ParseExact(textBox_Expire_Date.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                }
                catch
                {
                    MessageBox.Show("Date set to default, please re-check it and edit it if necessary\nNote that date should be set in the format (dd/MM/yyyy),\nFor example: 03/05/2010");
                    S.prod_date = DateTime.ParseExact("01/10/2000", "dd/MM/yyyy", CultureInfo.InvariantCulture);
                    S.exp_date = DateTime.ParseExact("01/10/2000", "dd/MM/yyyy", CultureInfo.InvariantCulture);
                }

                S.issue_date = DateTime.Now;
                WHM.SaveChangesAsync();
                this.Close();

            }
            else
            {

                MessageBox.Show("Something went wrong");
                this.Close();
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
