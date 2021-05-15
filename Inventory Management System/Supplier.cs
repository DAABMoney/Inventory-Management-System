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
using System.Configuration;
using System.Text.RegularExpressions;

namespace Inventory_Management_System
{
    public partial class Supplier : Form
    {
        SqlConnection con = new SqlConnection("Data Source=.\\sqlexpress;Initial Catalog=RSnDAuto;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter adpt;
        DataTable dt;
        int ID;
        public Supplier()
        {
            InitializeComponent();
            displayData();
        }

        private void Supplier_Load(object sender, EventArgs e)
        {
            lbuserlog.Text = "You're login as : " + ((Form)this.MdiParent).Controls["lbstatus"].Text;

            if (((Form)this.MdiParent).Controls["lbstatus"].Text != "Admin")
            {
                btnDelete.Enabled = false;
            }
            gvSupplier.Columns[0].Visible = false;
            gvSupplier.Columns[2].Visible = false;
            gvSupplier.Columns[6].Visible = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtSupplierNm.Text == "" || txtAddress.Text == "" || txtContactNo.Text == "" || txtEmailAdrs.Text == "")
            {
                MessageBox.Show("All fields are required!", "Field Empty", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {

                try
                {
                    con.Open();
                    cmd = new SqlCommand("INSERT INTO Supplier (SupplierName, Address, Contact_No, Email_Address) " +
                        "VALUES ('" + txtSupplierNm.Text + "', '" + txtAddress.Text + "', '" + txtContactNo.Text + "', '" + txtEmailAdrs.Text + "')", con);
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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                cmd = new SqlCommand("update Supplier set SupplierName = '" + txtSupplierNm.Text + "',Address = '" + txtAddress.Text +
                    "',Contact_No = '" + txtContactNo.Text + "',Email_Address = '" + txtEmailAdrs.Text + "' Where Supplier_ID='" + ID + "'", con);
                int i = cmd.ExecuteNonQuery();
                if (i != 0)
                {

                    MessageBox.Show("Information Updated", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                cmd = new SqlCommand("delete from Supplier where Supplier_ID ='" + ID + "'", con);
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

        private void gvSupplier_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                ID = int.Parse(gvSupplier.Rows[e.RowIndex].Cells[0].Value.ToString());
                txtSupplierNm.Text = gvSupplier.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtAddress.Text = gvSupplier.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtContactNo.Text = gvSupplier.Rows[e.RowIndex].Cells[4].Value.ToString();
                txtEmailAdrs.Text = gvSupplier.Rows[e.RowIndex].Cells[5].Value.ToString();
                
            }
            catch
            {
                MessageBox.Show("Check Information", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void displayData()
        {

            dt = new DataTable();
            con.Open();
            adpt = new SqlDataAdapter("Select * from Supplier", con);
            adpt.Fill(dt);
            gvSupplier.DataSource = dt;
            con.Close();
        }

        private void txtEmailAdrs_Validating(object sender, CancelEventArgs e)
        {
            string pattern = @"^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$";
            if (Regex.IsMatch(txtEmailAdrs.Text, pattern))
            {
                errorProvider.Clear();
            }
            else
            {

                errorProvider.SetError(this.txtEmailAdrs, "Enter a valid email");
                return;
            }

        }

        private void txtContactNo_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtContactNo.Text))
            {
                e.Cancel = true;
                txtContactNo.Focus();
                errorProvider.SetError(txtContactNo, "Enter a valid phone number");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(txtContactNo, null);
            }

            double i = 0;
            if (double.TryParse(txtContactNo.Text, out i))
            {
                errorProvider.SetError(txtContactNo, "");
            }
            else
            {
                errorProvider.SetError(txtContactNo, "Enter a valid phone number");
            }

        }
    }
}
