using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Warehouse_Management
{
    public partial class AddNewEntry : Form
    {
        Model WHM;
        string WHName, Prod_Code, SupName;

        public AddNewEntry()
        {
            InitializeComponent();
            WHM = new Model();
            this.MinimumSize = new Size(this.Width, this.Height);
            this.MaximumSize = new Size(this.Width, this.Height);
            var sup = from s in WHM.Suppliers select s.Supplier_Name;
            foreach (var ss in sup) { comboBox_supplier_name.Items.Add(ss); }
            sup = from p in WHM.Products select p.Product_Code;
            foreach (var ss in sup) { comboBox_product_code.Items.Add(ss); }
            sup = from p in WHM.Warehouses select p.WH_Name;
            foreach (var ss in sup) { comboBox_WH_name.Items.Add(ss); }
            textBox_permission_ID.Text = (WHM.Suppliers_Product.Count() + 1).ToString();
            textBox_permission_ID.Enabled = false;


        }

        private void buttonOK_Click(object sender, EventArgs e)
        {

            if (WHM.Suppliers_Product.Find(textBox_permission_ID.Text) == null 
                && comboBox_supplier_name.Text != string.Empty 
                && comboBox_product_code.Text != string.Empty 
                && comboBox_WH_name.Text != string.Empty
                && textBox_Quantity.Text != string.Empty)
            {
                Suppliers_Product s = new Suppliers_Product();
                WHName = comboBox_WH_name.Text;
                Prod_Code = comboBox_product_code.Text;
                SupName = comboBox_supplier_name.Text;

                var query = (from p in WHM.WH_ProductsList where p.WH_Name == WHName && p.Product_Code == Prod_Code  select p).FirstOrDefault();
                if (query != null)
                {
                    query.Quantity += int.Parse(textBox_Quantity.Text);
                }
                else
                {
                    WH_ProductsList WHPL = new WH_ProductsList() { 
                        WH_Name = comboBox_WH_name.Text,
                        Product_Code = comboBox_product_code.Text,
                        Quantity = int.Parse(textBox_Quantity.Text)
                    };
                    WHM.WH_ProductsList.Add(WHPL);
                }
                
                s.Entry_Permit = textBox_permission_ID.Text;
                s.Product_Code_entry = Prod_Code;
                s.WH_Name = WHName;
                s.Supplier_Name = SupName;
                s.Quantity = int.Parse(textBox_Quantity.Text);
                try {
                    s.prod_date = DateTime.ParseExact(textBox_Production_Date.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                    s.exp_date = DateTime.ParseExact(textBox_Expire_Date.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                } 
                catch {
                    MessageBox.Show("Date set to default, please re-check it and edit it if necessary");
                    s.prod_date = DateTime.ParseExact("01/10/2000", "dd/MM/yyyy", CultureInfo.InvariantCulture);
                    s.exp_date = DateTime.ParseExact("01/10/2000", "dd/MM/yyyy", CultureInfo.InvariantCulture);
                }
                
                s.issue_date = DateTime.Now;
                WHM.Suppliers_Product.Add(s);
                WHM.SaveChangesAsync();
                this.Close();

            }
            else
            {

                MessageBox.Show("Permission ID already exists\nMake sure you entered all the correct info");
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
