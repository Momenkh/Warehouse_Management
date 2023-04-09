using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Warehouse_Management
{
    public partial class Form1 : Form
    {
        Model WHM;
        public Form1()
        {
            InitializeComponent();
            Add_WH.Enabled = false;
            Edit_WH.Enabled = false;
            Add_Product_Type.Enabled = false;
            Edit_Product_Type.Enabled = false;
            Add_Client.Enabled = false;
            Edit_Client.Enabled = false;
            Add_Supplier.Enabled = false;
            Edit_Supplier.Enabled = false;
            Add_Product_toWH.Enabled = false;
            Edit_Product_inWH.Enabled = false;
            New_Entry_perm.Enabled = false;
            New_Release_perm.Enabled = false;
            Send_to_WH.Enabled = false;
            Edit_Entry_Permit.Enabled = false;
            label_products.Text = "You can double \nclick a product\nname to display\ninformation about\nits availability";
            label_Suppliers.Text = "You can double click \nthe supplier's name to \ndisplay all the information \nabout that supplier";
            label_Clients.Text = "You can double click \nthe client's name to \ndisplay all the information \nabout that client";

        }
        private void RefreshData() {
            WHM = new Model();
            var warehouses = from WH in WHM.Warehouses select WH;
            foreach (var w in warehouses)
            {
                comboBox_WH.Items.Add(w.WH_Name);
                comboBox_WH_reports.Items.Add(w.WH_Name);
                listBox_WH_Name.Items.Add(w.WH_Name);
                listBox_WH_Address.Items.Add(w.WH_Address);
                listBox_WH_Manager.Items.Add(w.WH_Manager);
            }
            var products = from PR in WHM.Products select PR;
            foreach (var p in products)
            {
                listBoxPCode.Items.Add(p.Product_Code);
                listBoxPName.Items.Add(p.Product_Name);
                listBoxPMUnit.Items.Add(p.Product_Units);
            }
            var prodL = (from p in WHM.WH_ProductsList where p.WH_Name == comboBox_WH.Text select p);

            if (prodL != null)
            {
                foreach (var w in prodL)
                {

                    var prods = (from p in WHM.Products where p.Product_Code == w.Product_Code select p);

                    if (prods != null)
                    {

                        foreach (var ppp in prods)
                        {
                            listBox_Products_Name.Items.Add(ppp.Product_Name);
                            listBox_Products_Code.Items.Add(ppp.Product_Code);
                            listBox_Products_Quantity.Items.Add(w.Quantity + " " + ppp.Product_Units);
                        }

                    }
                }
            }
            var suppliers = from S in WHM.Suppliers select S;
            foreach (var s in suppliers)
            {
                listBox_Suppliers.Items.Add(s.Supplier_Name);
            }
            var clients = from C in WHM.Clients select C;
            foreach (var s in clients)
            {
                listBox_Clients.Items.Add(s.Client_Name);
            }

        }
        private void EnableButtons() {
            Add_WH.Enabled = true;
            Edit_WH.Enabled = false;
            Add_Product_Type.Enabled = true;
            Edit_Product_Type.Enabled = false;
            Add_Client.Enabled = true;
            Edit_Client.Enabled = false;
            Add_Supplier.Enabled = true;
            Edit_Supplier.Enabled = false;
            Add_Product_toWH.Enabled = true;
            Edit_Product_inWH.Enabled = false;
            New_Entry_perm.Enabled = true;
            New_Release_perm.Enabled = true;
        }
        private void DisplayData_Click(object sender, EventArgs e)
        {
            ClearLists();
            EnableButtons();
            RefreshData();
            
        }
        private void comboBox_WH_SelectedIndexChanged(object sender, EventArgs e)
        {
            WHM = new Model();
            var prodL = (from p in WHM.WH_ProductsList where p.WH_Name == comboBox_WH.Text select p);

            if (prodL != null) {

                listBox_Products_Code.Items.Clear();
                listBox_Products_Name.Items.Clear();
                listBox_Products_Quantity.Items.Clear();
                foreach (var w in prodL)
                {
                    
                    var prods = (from p in WHM.Products where p.Product_Code == w.Product_Code select p);

                    if (prods != null) {

                        foreach (var ppp in prods) {
                            listBox_Products_Name.Items.Add(ppp.Product_Name);
                            listBox_Products_Code.Items.Add(ppp.Product_Code);
                            listBox_Products_Quantity.Items.Add(w.Quantity + " " + ppp.Product_Units);
                        }
                        
                    }
                }
            }

        }
        private void listBox_Products_Code_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox_Products_Name.SelectedIndex = listBox_Products_Code.SelectedIndex;
            listBox_Products_Quantity.SelectedIndex = listBox_Products_Code.SelectedIndex;
            Edit_Product_inWH.Enabled = true;
        }
        private void listBox_Products_Name_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox_Products_Code.SelectedIndex = listBox_Products_Name.SelectedIndex;
            listBox_Products_Quantity.SelectedIndex = listBox_Products_Name.SelectedIndex;
        }
        private void listBox_Products_Quantity_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox_Products_Code.SelectedIndex = listBox_Products_Quantity.SelectedIndex;
            listBox_Products_Name.SelectedIndex = listBox_Products_Quantity.SelectedIndex;
        }
        private void listBox_WH_Name_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox_WH_Manager.SelectedIndex = listBox_WH_Name.SelectedIndex;
            listBox_WH_Address.SelectedIndex = listBox_WH_Name.SelectedIndex;
            Edit_WH.Enabled = true;
        }
        private void listBox_WH_Address_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox_WH_Name.SelectedIndex = listBox_WH_Address.SelectedIndex;
            listBox_WH_Manager.SelectedIndex = listBox_WH_Address.SelectedIndex;
        }
        private void listBox_WH_Manager_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox_WH_Name.SelectedIndex = listBox_WH_Manager.SelectedIndex;
            listBox_WH_Address.SelectedIndex = listBox_WH_Manager.SelectedIndex;


        }
        private void listBoxPCode_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBoxPName.SelectedIndex = listBoxPCode.SelectedIndex;
            listBoxPMUnit.SelectedIndex = listBoxPCode.SelectedIndex;
            Edit_Product_Type.Enabled = true;
        }
        private void listBoxPName_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBoxPCode.SelectedIndex = listBoxPName.SelectedIndex;
            listBoxPMUnit.SelectedIndex = listBoxPName.SelectedIndex;
        }
        private void listBoxPMUnit_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBoxPName.SelectedIndex = listBoxPMUnit.SelectedIndex;
            listBoxPCode.SelectedIndex = listBoxPMUnit.SelectedIndex;
        }
        private void listBox_Suppliers_SelectedIndexChanged(object sender, EventArgs e)
        {
            Edit_Supplier.Enabled = true;
        }
        private void listBox_Clients_SelectedIndexChanged(object sender, EventArgs e)
        {
            Edit_Client.Enabled = true;
        }
        private void ClearLists() {
            comboBox_WH.Items.Clear();
            comboBox_WH_reports.Items.Clear();
            listBox_WH_Name.Items.Clear();
            listBox_WH_Address.Items.Clear();
            listBox_WH_Manager.Items.Clear();
            listBox_Products_Code.Items.Clear();
            listBox_Products_Name.Items.Clear();
            listBox_Products_Quantity.Items.Clear();
            listBoxPCode.Items.Clear();
            listBoxPName.Items.Clear();
            listBoxPMUnit.Items.Clear();
            listBox_Suppliers.Items.Clear();
            listBox_Clients.Items.Clear();

        }
        private void Add_WH_Click(object sender, EventArgs e)
        {
            AddWarehouse Add = new AddWarehouse();
            Add.Show();
        }
        private void Edit_WH_Click(object sender, EventArgs e)
        {
            Warehouse W = WHM.Warehouses.Find(listBox_WH_Name.SelectedItem.ToString());
            EditWarehouse Edit = new EditWarehouse(ref W,ref WHM);
            Edit.Show();
        }
        private void Add_Product_toWH_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ALERT!\nAdding a product to warehouse without its entry permit might make some trouble when creating its release permit");
            AddEditProductToWH Add = new AddEditProductToWH(comboBox_WH.Text,ref WHM);
            Add.Show();
        }
        private void Edit_Product_inWH_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ALERT!\nEditing a product in warehouse without its entry permit might make some trouble when creating its release permit");
            var WHP = (from w in WHM.WH_ProductsList where w.WH_Name == comboBox_WH.Text && w.Product_Code == listBox_Products_Code.SelectedItem.ToString() select w).FirstOrDefault();
            AddEditProductToWH Edit = new AddEditProductToWH(comboBox_WH.Text,ref WHM, ref WHP);
            Edit.Show();
        }
        private void Add_Product_Type_Click(object sender, EventArgs e)
        {
            AddNewProductType Add = new AddNewProductType();
            Add.Show();
        }
        private void Edit_Product_Type_Click(object sender, EventArgs e)
        {
            Product P = WHM.Products.Find(listBoxPCode.SelectedItem.ToString());
            EditProductType Edit = new EditProductType(ref P, ref WHM);
            Edit.Show();
        }
        private void Add_Supplier_Click(object sender, EventArgs e)
        {
            AddNewSupplier Add = new AddNewSupplier();
            Add.Show();
        }
        private void Edit_Supplier_Click(object sender, EventArgs e)
        {
            Supplier S = WHM.Suppliers.Find(listBox_Suppliers.SelectedItem.ToString());
            EditSupplier Edit = new EditSupplier(ref S, ref WHM);
            Edit.Show();
        }
        private void listBox_Suppliers_DoubleClick(object sender, EventArgs e)
        {
            Supplier x = WHM.Suppliers.Find(listBox_Suppliers.SelectedItem.ToString());
            Info_Suppliers info = new Info_Suppliers(x);
            info.Show();
        }
        private void Add_Client_Click(object sender, EventArgs e)
        {
            AddNewClient Add = new AddNewClient();
            Add.Show();
        }
        private void Edit_Client_Click(object sender, EventArgs e)
        {
            Client C = WHM.Clients.Find(listBox_Clients.SelectedItem.ToString());
            EditClient Edit = new EditClient(ref C, ref WHM);
            Edit.Show();
        }
        private void listBox_Clients_DoubleClick(object sender, EventArgs e)
        {
            Client x = WHM.Clients.Find(listBox_Clients.SelectedItem.ToString());
            Info_Clients info = new Info_Clients(x);
            info.Show();
        }
        private void New_Entry_perm_Click(object sender, EventArgs e)
        {
            AddNewEntry Add = new AddNewEntry();
            Add.Show();
        }
        private void New_Release_perm_Click(object sender, EventArgs e)
        {
            AddNewRelease Add = new AddNewRelease();
            Add.Show();
        }
        private void comboBox_WH_reports_SelectedIndexChanged(object sender, EventArgs e)
        {

            string warehouse_Name = comboBox_WH_reports.SelectedItem.ToString();

            var query1 = from p in WHM.Suppliers_Product where p.WH_Name == warehouse_Name select p;
            foreach (var item in query1)
            {
                ListViewItem lvItem = new ListViewItem(item.WH_Name);
                lvItem.SubItems.Add(item.Supplier_Name);
                lvItem.SubItems.Add(item.Entry_Permit);
                lvItem.SubItems.Add(item.Product_Code_entry);
                lvItem.SubItems.Add(item.Quantity.ToString());
                lvItem.SubItems.Add(item.prod_date.ToString("d"));
                lvItem.SubItems.Add(item.exp_date.ToString("d"));
                lvItem.SubItems.Add(item.issue_date.ToString("d"));

                listView1.Items.Add(lvItem);
            }

            listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);

            var query2 = from p in WHM.Clients_Product where p.WH_Name == warehouse_Name select p;
            foreach (var item in query2)
            {
                ListViewItem lvItem = new ListViewItem(item.WH_Name);
                lvItem.SubItems.Add(item.Client_Name);
                lvItem.SubItems.Add(item.Exit_Permit);
                lvItem.SubItems.Add(item.Product_Code_exit);
                lvItem.SubItems.Add(item.Quantity.ToString());
                lvItem.SubItems.Add(item.prod_date.ToString("d"));
                lvItem.SubItems.Add(item.exp_date.ToString("d"));
                lvItem.SubItems.Add(item.issue_date.ToString("d"));

                listView2.Items.Add(lvItem);
            }
            listView2.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);

        }
        private void button_clear_listview_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            listView2.Items.Clear();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            ClearLists();
            EnableButtons();
            RefreshData();
        }
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Edit_Entry_Permit.Enabled = true;
        }
        private void Edit_Entry_Permit_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem l = listView1.SelectedItems[0];
                string permID = l.SubItems[2].Text;
                Suppliers_Product s = WHM.Suppliers_Product.Find(permID);
                if (s != null)
                {
                    EditEntryPermit Edit = new EditEntryPermit(ref s,ref WHM);
                    Edit.Show();
                }
            }
        }
        private void Edit_Release_Permit_Click(object sender, EventArgs e)
        {
            if (listView2.SelectedItems.Count > 0)
            {
                ListViewItem l = listView2.SelectedItems[0];
                string permID = l.SubItems[2].Text;
                Clients_Product s = WHM.Clients_Product.Find(permID);
                if (s != null)
                {
                    EditReleasePermit Edit = new EditReleasePermit(ref s, ref WHM);
                    Edit.Show();
                }
            }
        }
        private void filterByDate_reports_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            listView2.Items.Clear();

            string warehouse_Name = comboBox_WH_reports.SelectedItem.ToString();

            var query1 = from p in WHM.Suppliers_Product where p.WH_Name == warehouse_Name && p.issue_date >= dateTimePicker_Reports1.Value && p.issue_date <= dateTimePicker_Reports2.Value select p;
            foreach (var item in query1)
            {
                ListViewItem lvItem = new ListViewItem(item.WH_Name);
                lvItem.SubItems.Add(item.Supplier_Name);
                lvItem.SubItems.Add(item.Entry_Permit);
                lvItem.SubItems.Add(item.Product_Code_entry);
                lvItem.SubItems.Add(item.Quantity.ToString());
                lvItem.SubItems.Add(item.prod_date.ToString("d"));
                lvItem.SubItems.Add(item.exp_date.ToString("d"));
                lvItem.SubItems.Add(item.issue_date.ToString("d"));

                listView1.Items.Add(lvItem);
            }

            listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);

            var query2 = from p in WHM.Clients_Product where p.WH_Name == warehouse_Name && p.issue_date >= dateTimePicker_Reports1.Value && p.issue_date <= dateTimePicker_Reports2.Value select p;
            foreach (var item in query2)
            {
                ListViewItem lvItem = new ListViewItem(item.WH_Name);
                lvItem.SubItems.Add(item.Client_Name);
                lvItem.SubItems.Add(item.Exit_Permit);
                lvItem.SubItems.Add(item.Product_Code_exit);
                lvItem.SubItems.Add(item.Quantity.ToString());
                lvItem.SubItems.Add(item.prod_date.ToString("d"));
                lvItem.SubItems.Add(item.exp_date.ToString("d"));
                lvItem.SubItems.Add(item.issue_date.ToString("d"));

                listView2.Items.Add(lvItem);
            }
            listView2.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);

        }

        private void listBoxPName_DoubleClick(object sender, EventArgs e)
        {
            Product p = WHM.Products.Find(listBoxPCode.Text);
            ProductWHInfo Info = new ProductWHInfo(ref p);
            Info.Show();
        }
    }
}
