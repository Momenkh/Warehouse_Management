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
    public partial class EditReleasePermit : Form
    {
        Clients_Product C;
        Model WHM;
        public EditReleasePermit(ref Clients_Product s, ref Model WHMM)
        {
            InitializeComponent();
            this.MinimumSize = new Size(this.Width, this.Height);
            this.MaximumSize = new Size(this.Width, this.Height);
            WHM = WHMM;
            C = s;
            Mainlabel.Text += s.Exit_Permit;
            var sup = from p in WHM.Clients select p.Client_Name;
            foreach (var ss in sup) { comboBox_client_name.Items.Add(ss); }
            sup = from p in WHM.Products select p.Product_Code;
            foreach (var ss in sup) { comboBox_product_code.Items.Add(ss); }
            sup = from p in WHM.Warehouses select p.WH_Name;
            foreach (var ss in sup) { comboBox_WH_name.Items.Add(ss); }
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (C != null)
            {
                var query = (from p in WHM.WH_ProductsList where p.WH_Name == C.WH_Name && p.Product_Code == C.Product_Code_exit select p).FirstOrDefault();
                if (query != null)
                {
                    query.Quantity += C.Quantity;
                }
                else { 
                    WH_ProductsList p = new WH_ProductsList();
                    p.WH_Name = C.WH_Name;
                    p.Product_Code = C.Product_Code_exit;
                    p.Quantity = C.Quantity;
                    WHM.WH_ProductsList.Add(p);
                }

                var q = (from p in WHM.WH_ProductsList where p.WH_Name == comboBox_WH_name.Text && p.Product_Code == comboBox_product_code.Text select p).FirstOrDefault();

                if (q != null)
                {
                    q.Quantity -= int.Parse(textBox_Quantity.Text);
                }
                else
                {
                    WH_ProductsList prod = new WH_ProductsList();
                    prod.Product_Code = comboBox_product_code.Text;
                    prod.WH_Name = comboBox_WH_name.Text;
                    prod.Quantity = int.Parse(textBox_Quantity.Text);
                    WHM.WH_ProductsList.Add(prod);
                }

                C.WH_Name = comboBox_WH_name.Text;
                C.Product_Code_exit = comboBox_product_code.Text;
                C.Client_Name = comboBox_client_name.Text;
                C.Quantity = int.Parse(textBox_Quantity.Text);
                try
                {
                    C.prod_date = DateTime.ParseExact(textBox_Production_Date.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                    C.exp_date = DateTime.ParseExact(textBox_Expire_Date.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                }
                catch
                {
                    MessageBox.Show("Date set to default, please re-check it and edit it if necessary\nNote that date should be set in the format (dd/MM/yyyy),\nFor example: 03/05/2010");
                    C.prod_date = DateTime.ParseExact("01/10/2000", "dd/MM/yyyy", CultureInfo.InvariantCulture);
                    C.exp_date = DateTime.ParseExact("01/10/2000", "dd/MM/yyyy", CultureInfo.InvariantCulture);
                }

                C.issue_date = DateTime.Now;
                WHM.SaveChangesAsync();
                this.Close();

            }
            else
            {

                MessageBox.Show("Something went wrong");
                this.Close();
            }
        }
    }
}
