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
    public partial class Product : Form
    {
        SqlConnection con = new SqlConnection("Data Source=.\\sqlexpress;Initial Catalog=RSnDAuto;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter adpt;
        DataTable dt;
        int ID;

        public Product()
        {
            InitializeComponent();
            displayData();
        }
        private void Product_Load(object sender, EventArgs e)
        {
            lbuserlog.Text = "You're login as : " + ((Form)this.MdiParent).Controls["lbstatus"].Text;

            if (((Form)this.MdiParent).Controls["lbstatus"].Text != "Admin")
            {
                btnDelete.Enabled = false;
            }
            gvProduct.Columns[0].Visible = false;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtVIN.Text =="" || combobxStatus.Text.ToString()=="" || txtModel.Text == "" || txtMake.Text =="" 
                || txtColour.Text=="" || txtCost.Text =="" || combobxTransmission.Text.ToString()=="" || combobxFuelTyp.Text.ToString()=="" 
                || txtCapacity.Text=="")
            {
                MessageBox.Show("All fields are required!", "Field Empty", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {

                try
                {
                    con.Open();
                    cmd = new SqlCommand("INSERT INTO Product  (VINnumber, Status, Model, Make, Colour, MFG_Date, Cost, Transmission_Type, Fuel_Type, Passanger_Capacity) " +
                        "VALUES ('" + txtVIN.Text + "', '" + combobxStatus.Text.ToString() + "', '" +  txtModel.Text+ "', '" +txtMake.Text + "', '" + txtColour.Text+ "', '" + DTPMfgDate.Value + "'," +
                        " '" + txtCost.Text+ "', '" + combobxTransmission.Text.ToString()+ "', '" + combobxFuelTyp.Text.ToString()+ "', '" +txtCapacity.Text +"')", con);
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
                cmd = new SqlCommand("update Product set VINnumber = '" + txtVIN.Text + "',Status = '" + combobxStatus.Text.ToString() +
                    "',Model = '" + txtModel.Text + "',Make = '" + txtMake.Text + "',Colour = '" + txtColour.Text +
                    "',MFG_Date = '" + DTPMfgDate.Value + "', Cost = '" + txtCost.Text + "' ,Transmission_Type = '" + combobxTransmission.Text.ToString() +
                    "' ,Fuel_Type = '" + combobxFuelTyp.Text.ToString() + "',Passanger_Capacity= '" + txtCapacity.Text + "' Where Product_ID='" + ID + "'", con);
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
                cmd = new SqlCommand("delete from Product where Product_ID ='" + ID + "'", con);
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

        private void gvProduct_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                ID = int.Parse(gvProduct.Rows[e.RowIndex].Cells[0].Value.ToString());
                txtVIN.Text = gvProduct.Rows[e.RowIndex].Cells[1].Value.ToString();
                combobxStatus.Text = gvProduct.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtModel.Text = gvProduct.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtMake.Text = gvProduct.Rows[e.RowIndex].Cells[4].Value.ToString();
                txtColour.Text = gvProduct.Rows[e.RowIndex].Cells[5].Value.ToString();
                DTPMfgDate.Text = gvProduct.Rows[e.RowIndex].Cells[6].Value.ToString();
                txtCost.Text = gvProduct.Rows[e.RowIndex].Cells[7].Value.ToString();
                combobxTransmission.Text = gvProduct.Rows[e.RowIndex].Cells[8].Value.ToString();
                combobxFuelTyp.Text = gvProduct.Rows[e.RowIndex].Cells[9].Value.ToString();
                txtCapacity.Text = gvProduct.Rows[e.RowIndex].Cells[10].Value.ToString();


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
            adpt = new SqlDataAdapter("Select * from Product", con);
            adpt.Fill(dt);
            gvProduct.DataSource = dt;
            con.Close();
        }

        private void txtCost_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCost.Text))
            {
                e.Cancel = true;
                txtCost.Focus();
                errorProvider.SetError(txtCost, "Numbers only");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(txtCost, null);
            }

            double i = 0;
            if (double.TryParse(txtCost.Text, out i))
            {
                errorProvider.SetError(txtCost, "");
            }
            else
            {
                errorProvider.SetError(txtCost, "Numbers only");
            }
        }
    }
}
