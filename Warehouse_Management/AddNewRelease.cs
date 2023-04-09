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
    public partial class AddNewRelease : Form
    {
        Model WHM;
        string WHName, Prod_Code, ClientName;

        public AddNewRelease()
        {
            InitializeComponent();
            WHM = new Model();
            this.MinimumSize = new Size(this.Width, this.Height);
            this.MaximumSize = new Size(this.Width, this.Height);
            var sup = from s in WHM.Clients select s.Client_Name;
            foreach (var ss in sup) { comboBox_client_name.Items.Add(ss); }
            sup = from p in WHM.Products select p.Product_Code;
            foreach (var ss in sup) { comboBox_product_code.Items.Add(ss); }
            sup = from p in WHM.Warehouses select p.WH_Name;
            foreach (var ss in sup) { comboBox_WH_name.Items.Add(ss); }
            textBox_permission_ID.Text = (WHM.Clients_Product.Count()+1).ToString();
            textBox_permission_ID.Enabled = false;

        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            WHName = comboBox_WH_name.SelectedItem.ToString();
            Prod_Code = comboBox_product_code.SelectedItem.ToString();
            ClientName = comboBox_client_name.SelectedItem.ToString();
            int quan = int.Parse(textBox_Quantity.Text);

            var qq = (from p in WHM.Suppliers_Product
                     where p.Product_Code_entry == Prod_Code && p.WH_Name == WHName && p.Quantity >= quan
                     select p).FirstOrDefault();
            

            var query = (from p in WHM.WH_ProductsList where p.WH_Name == WHName && p.Product_Code == Prod_Code select p).FirstOrDefault();
            if (query != null)
            {
                if (query.Quantity >= int.Parse(textBox_Quantity.Text))
                {
                    Clients_Product exit = new Clients_Product();


                    exit.Exit_Permit = textBox_permission_ID.Text;
                    exit.Product_Code_exit = Prod_Code;
                    exit.WH_Name = WHName;
                    exit.Client_Name = ClientName;
                    exit.Quantity = quan;
                    if (qq != null)
                    {
                        exit.prod_date = qq.prod_date;
                        exit.exp_date = qq.exp_date;
                    }
                    else { 
                        exit.prod_date = DateTime.ParseExact(textBox_Production_Date.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                        exit.exp_date = DateTime.ParseExact(textBox_Expire_Date.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                    }
                    
                    exit.issue_date = DateTime.Now;
                    WHM.Clients_Product.Add(exit);
                    query.Quantity -= int.Parse(textBox_Quantity.Text);
                    WHM.SaveChangesAsync();
                    this.Close();
                }
                else { 
                    MessageBox.Show("Insufficient quantity");
                }
                
            }
            else {
                MessageBox.Show("Product is not available from that specific warehouse at the moment");
            }
           
        }
    }
}
