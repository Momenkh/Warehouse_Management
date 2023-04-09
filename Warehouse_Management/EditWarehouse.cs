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
    public partial class EditWarehouse : Form
    {
        Warehouse W { get; set; }
        Model WHM { get; set; }
        public EditWarehouse(ref Warehouse WH, ref Model WHMM)
        {
            InitializeComponent();
            this.MinimumSize = new Size(this.Width, this.Height);
            this.MaximumSize = new Size(this.Width, this.Height);
            W = WH;
            WHM = WHMM;
            MainLabel.Text += W.WH_Name;
            textBox_Address.Text = W.WH_Address;
            textBox_Manager.Text = W.WH_Manager;
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {

            W.WH_Address = textBox_Address.Text;
            W.WH_Manager = textBox_Manager.Text;
            WHM.SaveChanges();
            this.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
