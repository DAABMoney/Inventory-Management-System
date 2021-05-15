using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Inventory_Management_System
{
    public partial class Invoices : Form
    {
        SqlConnection con = new SqlConnection("Data Source=.\\sqlexpress;Initial Catalog=RSnDAuto;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter adpt;
        DataTable dt;
        int ID;


       // private readonly RSnDAutoEntities rsndAutoEntities;
        public Invoices()
        {
            InitializeComponent();
            //rsndAutoEntities = new RSnDAutoEntities();
            displayData();
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }
        private void Invoices_Load(object sender, EventArgs e)
        {

            lbuserlog.Text = "You're login as : " + ((Form)this.MdiParent).Controls["lbstatus"].Text;

            if (((Form)this.MdiParent).Controls["lbstatus"].Text != "Admin")
            {
                btnDelete.Enabled = false;
            }
            
            gvInvoices.Columns[1].Visible = false;
            
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtInvValue.Text=="")
            {
                MessageBox.Show("Enter a value!", "Field Empty", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {

              try
                {
                    con.Open();
                    cmd = new SqlCommand("INSERT INTO Invoice  (Invoice_Value, Invoice_Date ) VALUES ('" + txtInvValue.Text + "', '" + DTPInvDate.Value+ "')", con);
                    int i = cmd.ExecuteNonQuery();

                    if (i != 0)
                    {

                        MessageBox.Show("Information Added", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnReset_Click(sender, e);

                    }
                    else
                    {
                        MessageBox.Show("Error", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    con.Close();
                    displayData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            
        }
               
        private void btnDelete_Click(object sender, EventArgs e)
        {

            try
            {
                con.Open();
                cmd = new SqlCommand("delete from Invoice where Invoice_No='" + ID + "'", con);
                int i = cmd.ExecuteNonQuery();
                if (i != 0)
                {


                    MessageBox.Show("Information Deleted", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnReset_Click(sender, e);

                }
                else
                {
                    MessageBox.Show("Error. Check Information", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                con.Close();
                displayData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ClearControls(this);

            void ClearControls(Control control)
            {
                foreach (Control cntl in control.Controls)
                {
                    if (cntl is TextBox)
                        ((TextBox)cntl).Clear();
                    else if (cntl is DateTimePicker)
                        ((DateTimePicker)cntl).CustomFormat = "";
                    else if (cntl is ComboBox)
                        ((ComboBox)cntl).SelectedIndex = -1;

                    if (cntl.HasChildren)
                        ClearControls(cntl);
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
        public void displayData()
        {

            dt = new DataTable();
            con.Open();
            adpt = new SqlDataAdapter("Select * from Invoice", con);
            adpt.Fill(dt);
            gvInvoices.DataSource = dt;
            con.Close();
        }

        private void gvInvoices_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                ID = int.Parse(gvInvoices.Rows[e.RowIndex].Cells[0].Value.ToString());
                DTPInvDate.Text = gvInvoices.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtInvValue.Text = gvInvoices.Rows[e.RowIndex].Cells[3].Value.ToString();
               
               
            }
            catch 
            {
               MessageBox.Show("Check Information", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtInvValue_Validating(object sender, CancelEventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtInvValue.Text))
            {
                e.Cancel = true;
                txtInvValue.Focus();
                errorProvider.SetError(txtInvValue, "Numbers only");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(txtInvValue, null);
            }

            double i = 0;
            if (double.TryParse(txtInvValue.Text, out i))
            {
                errorProvider.SetError(txtInvValue, "");
            }
            else
            {
                errorProvider.SetError(txtInvValue, "Numbers only");
            }
        }
        private void Invoice_Value_Validating(object sender, CancelEventArgs e)
        {
        }

       
    }
}
