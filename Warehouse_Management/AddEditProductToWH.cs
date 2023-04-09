using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Warehouse_Management
{
    public partial class AddEditProductToWH : Form
    {
        Model WHM;
        string WarehouseName;
        public AddEditProductToWH(string W, ref Model WHMM)
        {
            InitializeComponent();

            this.MinimumSize = new Size(this.Width, this.Height);
            this.MaximumSize = new Size(this.Width, this.Height);
            WarehouseName = W;
            WHM = WHMM;

            var products = from p in WHM.Products select p;
            foreach (var product in products)
            {
                comboBox_Code.Items.Add(product.Product_Code);
                comboBox_Name.Items.Add(product.Product_Name);
            }
        }
        public AddEditProductToWH(string W, ref Model WHMM, ref WH_ProductsList WP)
        {
            InitializeComponent();

            this.MinimumSize = new Size(this.Width, this.Height);
            this.MaximumSize = new Size(this.Width, this.Height);
            WarehouseName = W;
            WHM = WHMM;

            var products = from p in WHM.Products select p;
            foreach (var product in products)
            {
                comboBox_Code.Items.Add(product.Product_Code);
                comboBox_Name.Items.Add(product.Product_Name);
            }

            comboBox_Code.SelectedIndex = comboBox_Code.FindStringExact(WP.Product_Code);
            comboBox_Name.SelectedItem = WP.WH_Name;
            textBox_Quantity.Text = WP.Quantity.ToString();
            WHM.WH_ProductsList.Remove(WP);
            WHM.SaveChangesAsync();

        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            WHM = new Model();
            WH_ProductsList Pr = new WH_ProductsList()
            {
                Product_Code = comboBox_Code.SelectedItem.ToString(),
                WH_Name = WarehouseName,
                Quantity = int.Parse(textBox_Quantity.Text),
            };

            var PL = (from p in WHM.WH_ProductsList where p.WH_Name == WarehouseName && p.Product_Code == Pr.Product_Code select p).FirstOrDefault();

            if (PL != null)
            {
                PL.Quantity += Pr.Quantity;
            }
            else {
                WHM.WH_ProductsList.Add(Pr);
            }
            WHM.SaveChangesAsync();
            this.Close();

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox_Code_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox_Name.SelectedIndex= comboBox_Code.SelectedIndex;
        }

        private void comboBox_Name_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox_Code.SelectedIndex = comboBox_Name.SelectedIndex;
        }
    }
}
