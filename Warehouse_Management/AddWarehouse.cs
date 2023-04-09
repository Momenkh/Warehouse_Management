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
    public partial class AddWarehouse : Form
    {
        public AddWarehouse()
        {
            InitializeComponent();
            this.MinimumSize = new Size(this.Width, this.Height);
            this.MaximumSize = new Size(this.Width, this.Height);

        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            Model WHM = new Model();
            if (textBox_Name.Text != string.Empty | textBox_Address.Text != string.Empty)
            {
                if (WHM.Warehouses.Find(textBox_Name.Text) == null)
                {
                    Warehouse W = new Warehouse();
                    W.WH_Name = textBox_Name.Text;
                    W.WH_Address = textBox_Address.Text;
                    W.WH_Manager = textBox_Manager.Text;
                    WHM.Warehouses.Add(W);
                    WHM.SaveChangesAsync();
                    this.Close();

                }
                else
                {

                    MessageBox.Show("Name already exists");
                }
            }
            else {
                MessageBox.Show("Please enter a name for the warehouse and an address");
            }

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
