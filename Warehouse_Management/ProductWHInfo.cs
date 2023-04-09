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
    public partial class ProductWHInfo : Form
    {
        Product P;
        Model WHM;
        public ProductWHInfo(ref Product p)
        {
            InitializeComponent();
            WHM = new Model();
            P = p;
            comboBox1.Text = P.Product_Name;
            var query = from q in WHM.WH_ProductsList where q.Product_Code == P.Product_Code select q;
            foreach (var i in query) {
                listBox_WH.Items.Add(i.WH_Name);
                listBox_Quantity.Items.Add(i.Quantity);
            }

            var queryy = from q in WHM.Products select q;

            foreach (var j in queryy)
            {
                comboBox1.Items.Add(j.Product_Name);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox_Quantity.Items.Clear();
            listBox_WH.Items.Clear();
            var queryy = (from q in WHM.Products where q.Product_Name == comboBox1.Text select q.Product_Code).FirstOrDefault();

            var query = from q in WHM.WH_ProductsList where q.Product_Code == queryy select q;

            foreach (var i in query)
            {
                listBox_WH.Items.Add(i.WH_Name);
                listBox_Quantity.Items.Add(i.Quantity);
            }

            if (textBox_Months_Exp.Text != "")
            {
                listBoxPCode.Items.Clear();
                listBoxPQ.Items.Clear();
                listBoxProd.Items.Clear();
                listBox_exp.Items.Clear();
                DateTime X = DateTime.Now.AddMonths(int.Parse(textBox_Months_Exp.Text));
                MessageBox.Show(X.ToString());
                var query2 = from p in WHM.Suppliers_Product where p.exp_date <= X && p.Product_Code_entry == queryy select p;

                foreach (var i in query2)
                {
                    listBoxPCode.Items.Add(i.Product_Code_entry);
                    listBoxPQ.Items.Add(i.Quantity);
                    listBoxProd.Items.Add(i.prod_date);
                    listBox_exp.Items.Add(i.exp_date);

                }
            }
            if (textBox_Months_Prod.Text != "")
            {
                listBoxPCode1.Items.Clear();
                listBoxPQ1.Items.Clear();
                listBoxProd1.Items.Clear();
                listBox_exp1.Items.Clear();
                DateTime X = DateTime.Now.AddMonths(-int.Parse(textBox_Months_Prod.Text));
                MessageBox.Show(X.ToString());
                var query2 = from p in WHM.Suppliers_Product where p.prod_date <= X && p.Product_Code_entry == queryy select p;

                foreach (var i in query2)
                {
                    listBoxPCode1.Items.Add(i.Product_Code_entry);
                    listBoxPQ1.Items.Add(i.Quantity);
                    listBoxProd1.Items.Add(i.prod_date);
                    listBox_exp1.Items.Add(i.exp_date);

                }
            }

        }
    }
}
