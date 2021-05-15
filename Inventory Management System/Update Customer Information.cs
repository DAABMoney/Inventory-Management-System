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
using System.Text.RegularExpressions;

namespace Inventory_Management_System
{
    public partial class Update_Customer_Information : Form
    {
        SqlConnection con = new SqlConnection("Data Source=.\\sqlexpress;Initial Catalog=RSnDAuto;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter adpt;
        DataTable dt;
        int ID;

        public Update_Customer_Information()
        {
            InitializeComponent();
            displayData();
        }

        private void Update_Customer_Information_Load(object sender, EventArgs e)
        {
            lbuserlog.Text = "You're login as : " + ((Form)this.MdiParent).Controls["lbstatus"].Text;

            if (((Form)this.MdiParent).Controls["lbstatus"].Text != "Admin")
            {
                btnDelete.Enabled = false;
            }
                       
            gvUpdatecustomer.Columns[0].Visible = false;

        }


        private void btnEditcustomer_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                cmd = new SqlCommand("update Customer_Info set AddressLine1 = '" + txtbxaddline1.Text + "',AddressLine2 = '" + txtbxaddline2.Text +
                    "',CityState = '" + txtbxcitystate.Text + "',Country = '" + combobxcountry.Text.ToString() + "',PostalZip = '" + txtbxpostzip.Text +
                    "',Email = '" + txtbxemail.Text + "',MobleNumber = '" + txtbxcellnum.Text + "' ,HomeNumber = '" + txtbxhomenum.Text +
                    "' ,WorkNumber = '" + txtbxworknum.Text + "',Company = '" + txtbxcompany.Text + "' Where Customer_ID='" + ID + "'", con);
                int i = cmd.ExecuteNonQuery();
                if (i != 0)
                {

                    MessageBox.Show("Customer Information Updated", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
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


        private void btnDelete_Click(object sender, EventArgs e)
        {

            try 
            {
                con.Open();
                cmd = new SqlCommand("delete from Customer_Info where Customer_ID='" + ID + "'", con);
                int i = cmd.ExecuteNonQuery();
                if (i != 0)
                {


                    MessageBox.Show("Customer Information Deleted", "Information Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        private void gvUpdatecustomer_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                ID = int.Parse(gvUpdatecustomer.Rows[e.RowIndex].Cells[0].Value.ToString());
                txtbxaddline1.Text = gvUpdatecustomer.Rows[e.RowIndex].Cells[5].Value.ToString();
                txtbxaddline2.Text = gvUpdatecustomer.Rows[e.RowIndex].Cells[6].Value.ToString();
                txtbxcitystate.Text = gvUpdatecustomer.Rows[e.RowIndex].Cells[7].Value.ToString();
                combobxcountry.Text = gvUpdatecustomer.Rows[e.RowIndex].Cells[8].Value.ToString();
                txtbxpostzip.Text = gvUpdatecustomer.Rows[e.RowIndex].Cells[9].Value.ToString();
                txtbxemail.Text = gvUpdatecustomer.Rows[e.RowIndex].Cells[10].Value.ToString();
                txtbxcellnum.Text = gvUpdatecustomer.Rows[e.RowIndex].Cells[11].Value.ToString();
                txtbxhomenum.Text = gvUpdatecustomer.Rows[e.RowIndex].Cells[12].Value.ToString();
                txtbxworknum.Text = gvUpdatecustomer.Rows[e.RowIndex].Cells[13].Value.ToString();
                txtbxcompany.Text = gvUpdatecustomer.Rows[e.RowIndex].Cells[14].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show( ex.Message);
            }
           

        }

        public void displayData()
        {

            dt = new DataTable();
            con.Open();
            adpt = new SqlDataAdapter("Select * from Customer_Info", con);
            adpt.Fill(dt);
            gvUpdatecustomer.DataSource = dt;
            con.Close();
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

        private void txtbxemail_Validating(object sender, CancelEventArgs e)
        {
            string pattern = @"^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$";
            if (Regex.IsMatch(txtbxemail.Text, pattern))
            {
                errorProvider.Clear();
            }
            else
            {

                errorProvider.SetError(this.txtbxemail, "Enter a valid email");
                return;
            }

        }

        private void txtbxcellnum_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtbxcellnum.Text))
            {
                e.Cancel = true;
                txtbxcellnum.Focus();
                errorProvider.SetError(txtbxcellnum, "Enter a valid phone number");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(txtbxcellnum, null);
            }

            double i = 0;
            if (double.TryParse(txtbxcellnum.Text, out i))
            {
                errorProvider.SetError(txtbxcellnum, "");
            }
            else
            {
                errorProvider.SetError(txtbxcellnum, "Enter a valid phone number");
            }

        }

        private void txtbxhomenum_Validating(object sender, CancelEventArgs e)
        {
            double i = 0;
            if (double.TryParse(txtbxhomenum.Text, out i))
            {
                errorProvider.SetError(txtbxhomenum, "");
            }
            else
            {
                errorProvider.SetError(txtbxhomenum, "Enter a valid phone number");
            }

        }

        private void txtbxworknum_Validating(object sender, CancelEventArgs e)
        {
            double i = 0;
            if (double.TryParse(txtbxhomenum.Text, out i))
            {
                errorProvider.SetError(txtbxhomenum, "");
            }
            else
            {
                errorProvider.SetError(txtbxhomenum, "Enter a valid phone number");
            }

        }

        private void combobxcountry_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(combobxcountry.Text))
            {
                e.Cancel = true;
                combobxcountry.Focus();
                errorProvider.SetError(combobxcountry, "Please select a conutry!");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(combobxcountry, null);
            }
        }
    }
}
