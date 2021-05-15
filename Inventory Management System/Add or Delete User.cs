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
    public partial class Add_or_Delete_User : Form
    {
        SqlConnection con = new SqlConnection("Data Source=.\\sqlexpress;Initial Catalog=RSnDAuto;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter adpt;
        DataTable dt;
        int ID;

        public Add_or_Delete_User()
        {
            InitializeComponent();
            displayData();
        }

        private void Add_or_Delete_User_Load(object sender, EventArgs e)
        {
            lbuserlog.Text = "You're login as : " + ((Form)this.MdiParent).Controls["lbstatus"].Text;

            if (((Form)this.MdiParent).Controls["lbstatus"].Text != "Admin")
            {
                btnAdd.Enabled = false;
                btnUpdate.Enabled = false;
                btnDelete.Enabled = false;
                btnReset.Enabled = false;
                gvadddeleteuser.Visible = false;
            }
            gvadddeleteuser.Columns[0].Visible = false;
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtFirstNm.Text == "" || txtLastNm.Text == "" || txtUserNm.Text == "" || txtPswrd.Text == ""|| txtCfmpswrd.Text=="" || combobxRole.Text.ToString()=="")
            {
                MessageBox.Show("All fields are required!", "Field Empty", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {

                try
                {
                    con.Open();
                    cmd = new SqlCommand("INSERT INTO Login (FirstName, LastName, Username, Password, Confirm_Password, Role) " +
                        "VALUES ('" + txtFirstNm.Text + "', '" + txtLastNm.Text + "', '" + txtUserNm.Text + "', '" + txtPswrd.Text + "', '" + txtCfmpswrd.Text + "', '" + combobxRole.Text.ToString() + "')", con);
                    int i = cmd.ExecuteNonQuery();

                    if (i != 0)
                    {

                        MessageBox.Show("User Added", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                cmd = new SqlCommand("update Login set FirstName = '" + txtFirstNm.Text + "',LastName = '" + txtLastNm.Text +
                    "',Username= '" + txtUserNm.Text + "',Password = '" + txtPswrd.Text + "',Confirm_Password= '" + txtCfmpswrd.Text + 
                    "',Role = '" + combobxRole.Text.ToString() + "' Where User_ID='" + ID + "'", con);
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
                cmd = new SqlCommand("delete from Login where User_ID ='" + ID + "'", con);
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

        private void gvadddeleteuser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                ID = int.Parse(gvadddeleteuser.Rows[e.RowIndex].Cells[0].Value.ToString());
                txtFirstNm.Text = gvadddeleteuser.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtLastNm.Text = gvadddeleteuser.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtUserNm.Text = gvadddeleteuser.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtPswrd.Text = gvadddeleteuser.Rows[e.RowIndex].Cells[4].Value.ToString();
                txtCfmpswrd.Text = gvadddeleteuser.Rows[e.RowIndex].Cells[5].Value.ToString();
                combobxRole.Text = gvadddeleteuser.Rows[e.RowIndex].Cells[6].Value.ToString();

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
            adpt = new SqlDataAdapter("Select * from Login", con);
            adpt.Fill(dt);
            gvadddeleteuser.DataSource = dt;
            con.Close();
        }

        private void txtCfmpswrd_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtPswrd.Text == txtCfmpswrd.Text)
            {

                lbmatch.ForeColor = System.Drawing.Color.Green;
                lbmatch.Text = "Password Match";
            }
            else
            {
                lbmatch.ForeColor = System.Drawing.Color.Red;
                lbmatch.Text = "Password Does not Match";

            }
        }
    }
}
