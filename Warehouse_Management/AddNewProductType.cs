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
    public partial class AddNewProductType : Form
    {
        Model WHM;
        public AddNewProductType()
        {
            InitializeComponent();
            WHM = new Model();
            this.MinimumSize = new Size(this.Width, this.Height);
            this.MaximumSize = new Size(this.Width, this.Height);
            textBox_Code.Text = (WHM.Products.Count() + 1).ToString();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (textBox_Code.Text != string.Empty | textBox_Name.Text != string.Empty)
            {

                if (WHM.Products.Find(textBox_Code.Text) == null)
                {
                    Product P = new Product();
                    P.Product_Code = textBox_Code.Text;
                    P.Product_Name = textBox_Name.Text;
                    P.Product_Units = textBox_Unit.Text;
                    WHM.Products.Add(P);
                    WHM.SaveChangesAsync();
                    this.Close();
                }
                else { MessageBox.Show("Code already exists"); }
            }
            else {
                MessageBox.Show("Please enter a code and a name for the product");
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
