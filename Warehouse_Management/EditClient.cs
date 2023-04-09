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
    public partial class EditClient : Form
    {
        Client C { get; set; }
        Model WHM { get; set; }
        public EditClient(ref Client c, ref Model WHMM)
        {
            InitializeComponent();
            this.MinimumSize = new Size(this.Width, this.Height);
            this.MaximumSize = new Size(this.Width, this.Height);
            C = c;
            WHM = WHMM;
            Mainlabel.Text += C.Client_Name;
            textBox_Tele.Text = C.Client_tele;
            textBox_Fax.Text = C.Client_fax;
            textBox_Mobile.Text = C.Client_mob;
            textBox_Mail.Text = C.Client_email;
            textBox_Web.Text = C.Client_website;
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            C.Client_tele = textBox_Tele.Text;
            C.Client_fax = textBox_Fax.Text;
            C.Client_mob = textBox_Mobile.Text;
            C.Client_email = textBox_Mail.Text;
            C.Client_website = textBox_Web.Text;
            WHM.SaveChanges();
            this.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
