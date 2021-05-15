using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Data.SqlClient;
using System.Configuration;

namespace Inventory_Management_System
{
    public partial class newCustomerForm : Form
    {
        
        public newCustomerForm()
        {
            InitializeComponent();
           
        }
      
        private void BtnCloseFrom_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btnsubmit_Click(object sender, EventArgs e)
        {
            
            string fname = txtbxfname.Text;
            string lname = txtbxfname.Text;
            var DOB = DTPdob.Value;
            string gen = combobxgen.SelectedText;
            string addressline1 = txtbxaddline1.Text;
            string addressline2 = txtbxaddline2.Text;
            string cityState = txtbxcitystate.Text;
            string country = combobxcountry.SelectedText;
            string zipcode = txtbxpostzip.Text;
            string email = txtbxemail.Text;
            string cellNum = txtbxcellnum.Text;
            string homeNum = txtbxhomenum.Text;
            string workNum = txtbxworknum.Text;
            string company = txtbxcompany.Text;
            var CRD = DTPcustomer.Value;
            string addComment = txtbxAddcom.Text;

            try
            {
                SqlConnection con = new SqlConnection("Data Source=.\\sqlexpress;Initial Catalog=RSnDAuto;Integrated Security=True");
                con.Open();
                SqlCommand cmd = new SqlCommand(@"INSERT INTO [dbo].[Customer_Info]
           ([FirstName]
           ,[LastName]
           ,[DateofBirth]
           ,[Gender]
           ,[AddressLine1]
           ,[AddressLine2]
           ,[CityState]
           ,[Country]
           ,[PostalZip]
           ,[Email]
           ,[MobleNumber]
           ,[HomeNumber]
           ,[WorkNumber]
           ,[Company]
           ,[CustomerRegistrationDate]
           ,[Comments]) VALUES ('" + txtbxfname.Text + "', '" + txtbxlname.Text + "','" + DTPdob.Value + "'," +
               "'" + combobxgen.Text.ToString() + "','" + txtbxaddline1.Text + "','" + txtbxaddline2.Text + "'," +
               "'" + txtbxcitystate.Text + "','" + combobxcountry.Text.ToString() + "','" + txtbxpostzip.Text + "','"
               + txtbxemail.Text + "','" + txtbxcellnum.Text + "','" + txtbxhomenum.Text + "','" + txtbxworknum.Text + "','"
               + txtbxcompany.Text + "','" + DTPcustomer.Value + "','" + txtbxAddcom.Text + "')", con);
                int i = cmd.ExecuteNonQuery();

                if (i != 0)
                {

                    MessageBox.Show("Form Submitted", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Btnreset_Click(sender, e);

                }
                else
                {
                    MessageBox.Show("Error", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);


                }

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void Btnreset_Click(object sender, EventArgs e)
        {
            ClearControls(this);
        }

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

        private void fname_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtbxfname.Text))
            {
                e.Cancel = true;
                txtbxfname.Focus();
                errorProvider.SetError(txtbxfname, "Please enter your first name!");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(txtbxfname, null);
            }
        }

        private void lname_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtbxlname.Text))
            {
                e.Cancel = true;
                txtbxlname.Focus();
                errorProvider.SetError(txtbxlname, "Please enter your last name!");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(txtbxlname, null);
            }
        }

        private void DTPdob_Validating(object sender, CancelEventArgs e)
        {
            if (DTPdob.Value >= DateTime.Now)
            {
                e.Cancel = true;
                DTPdob.Focus();
                errorProvider.SetError(DTPdob, "Invalid Date!");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(DTPdob, null);
            }
        }

        private void gender_Validating(object sender, CancelEventArgs e)
        {

            if (string.IsNullOrWhiteSpace(combobxgen.Text))
            {
                e.Cancel = true;
                combobxgen.Focus();
                errorProvider.SetError(combobxgen, "Please select a gender!");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(combobxgen, null);
            }
        }


        private void txtbxAddressline1_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtbxaddline1.Text))
            {
                e.Cancel = true;
                txtbxaddline1.Focus();
                errorProvider.SetError(txtbxaddline1, "Please enter valid address!");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(txtbxaddline1, null);
            }
        }

        private void citystate_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtbxcitystate.Text))
            {
                e.Cancel = true;
                txtbxcitystate.Focus();
                errorProvider.SetError(txtbxcitystate, "Please enter valid city or state!");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(txtbxcitystate, null);
            }
        }

        private void country_Validating(object sender, CancelEventArgs e)
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

        private void Email_Validating(object sender, CancelEventArgs e)
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

        private void mobileNumber_Validating(object sender, CancelEventArgs e)
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

        private void homeNumber_Validating(object sender, CancelEventArgs e)
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

        private void DTPcustomerReg_Validating(object sender, CancelEventArgs e)
        {
            if (DTPcustomer.Value >= DateTime.Now)
            {
                e.Cancel = true;
                DTPcustomer.Focus();
                errorProvider.SetError(DTPcustomer, "Invalid Date!");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(DTPcustomer, null);
            }
        }
        private void newCustomerForm_Load(object sender, EventArgs e)
        {
            lbuserlog.Text = "You're login as : " + ((Form)this.MdiParent).Controls["lbstatus"].Text;

        }


        private void lbuserlog_Click(object sender, EventArgs e)
        {

        }

      
    }
}
   

