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
    public partial class AddNewClient : Form
    {
        public AddNewClient()
        {
            InitializeComponent();
            this.MinimumSize = new Size(this.Width, this.Height);
            this.MaximumSize = new Size(this.Width, this.Height);
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            Model WHM = new Model();

            if (WHM.Warehouses.Find(textBox_Name.Text) == null)
            {
                Client C = new Client();
                C.Client_Name = textBox_Name.Text;
                C.Client_tele = textBox_Tele.Text;
                C.Client_fax = textBox_Fax.Text;
                C.Client_mob = textBox_Mobile.Text;
                C.Client_email = textBox_Mail.Text;
                C.Client_website = textBox_Web.Text;
                WHM.Clients.Add(C);
                WHM.SaveChangesAsync();
                this.Close();

            }
            else
            {

                MessageBox.Show("Name already exists");
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
