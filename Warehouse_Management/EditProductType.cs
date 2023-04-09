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
    public partial class EditProductType : Form
    {
        Product P;
        Model WHM;
        public EditProductType(ref Product Pr, ref Model WHMM)
        {
            InitializeComponent();
            this.MinimumSize = new Size(this.Width, this.Height);
            this.MaximumSize = new Size(this.Width, this.Height);
            P = Pr;
            WHM = WHMM;
            MainLabel.Text += P.Product_Code;
            textBox_Name.Text = P.Product_Name;
            textBox_Unit.Text = P.Product_Units;
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (textBox_Name.Text != string.Empty)
            {
                P.Product_Name = textBox_Name.Text;
                P.Product_Units = textBox_Unit.Text;
                WHM.SaveChanges();
                this.Close();
            }
            else {
                MessageBox.Show("Please enter a name for the product");
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
