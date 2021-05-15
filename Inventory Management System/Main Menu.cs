using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Inventory_Management_System
{
    public partial class Main_Menu : Form
    {

        public Main_Menu(string role)
        {
            InitializeComponent();
            lbstatus.Text = role;
            
        }
       
        
        private void customerRegistrationToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
            var OpenFroms = Application.OpenForms.Cast<Form>();
            bool isOpen = OpenFroms.Any(q => q.Name == "newCustomerForm");
            if (!isOpen)
            {
                isOpen = true;
                newCustomerForm ncf = new newCustomerForm();
                ncf.MdiParent = this;
                //ncf.Dock = DockStyle.Fill;
                ncf.Show();
            }
            
            
        }
        private void btnlogout_Click(object sender, EventArgs e)
        {
            User_Login uL = new User_Login();
            uL.MdiParent = this;
            uL.Show();
            Application.Exit();
            
        }

        private void updateCustomerInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var OpenFroms = Application.OpenForms.Cast<Form>();
            bool isOpen = OpenFroms.Any(q => q.Name == "Update_Customer_Information");
            if (!isOpen)
            {
                Update_Customer_Information uci = new Update_Customer_Information();
                uci.MdiParent = this;
                uci.Dock = DockStyle.Fill;
                uci.Show();
            }
            
        }

        private void Main_Menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void menuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Main_Menu_Load(object sender, EventArgs e)
        {
           
            lbDate.Text = DateTime.Now.ToLongDateString();
            timer1.Start();
            lbTime.Text = DateTime.Now.ToLongTimeString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbTime.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }

        private void invoicesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var OpenFroms = Application.OpenForms.Cast<Form>();
            bool isOpen = OpenFroms.Any(q => q.Name == "Invoices");
            if (!isOpen)
            {
                Invoices inv = new Invoices();
                inv.MdiParent = this;
                inv.Dock = DockStyle.Fill;
                inv.Show();
            }

        }

        private void ProductsOrdersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var OpenFroms = Application.OpenForms.Cast<Form>();
            bool isOpen = OpenFroms.Any(q => q.Name == "Product");
            if (!isOpen)
            {
                Product p = new Product();
                p.MdiParent = this;
                p.Dock = DockStyle.Fill;
                p.Show();
            }
        }

        private void supplierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var OpenFroms = Application.OpenForms.Cast<Form>();
            bool isOpen = OpenFroms.Any(q => q.Name == "Supplier");
            if (!isOpen)
            {
                Supplier s = new Supplier();
                s.MdiParent = this;
                s.Dock = DockStyle.Fill;
                s.Show();
            }
        }

        private void btnAddDeleteUser_Click(object sender, EventArgs e)
        {
            
                var OpenFroms = Application.OpenForms.Cast<Form>();
            bool isOpen = OpenFroms.Any(q => q.Name == "Supplier");
            if (!isOpen)
            {
                Add_or_Delete_User adu = new Add_or_Delete_User();
                adu.MdiParent = this;
                adu.Dock = DockStyle.Fill;
                adu.Show();
            }
        }
    }
}
