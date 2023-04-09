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
    public partial class Info_Clients : Form
    {
        public Info_Clients(Client x)
        {
            InitializeComponent();
            label_name.Text += x.Client_Name;
            label_tele.Text += x.Client_tele;
            label_fax.Text += x.Client_fax;
            label_mobile.Text += x.Client_mob;
            label_email.Text += x.Client_email;
            label_website.Text += x.Client_website;
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
