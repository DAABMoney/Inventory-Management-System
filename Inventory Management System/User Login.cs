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
using System.Data;

namespace Inventory_Management_System
{
    public partial class User_Login : Form
    {
        public User_Login()
        {
            InitializeComponent();
        }
        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=.\sqlexpress;Initial Catalog=RSnDAuto;Integrated Security=True");
            SqlDataAdapter sda = new SqlDataAdapter(@"Select Role from Login Where Username= '" + txtbxusername.Text + "'and Password='" + txtbxpassword.Text +"'   ", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count == 1)
            {
                this.Hide();
                Main_Menu mM = new Main_Menu(dt.Rows[0][0].ToString());
               mM.Show();
               
            }
            else
            {
                MessageBox.Show("Please check Username or Password", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
               
            }
        }

        private void Lbpassword_Click(object sender, EventArgs e)
        {

        }

        private void User_Login_Load(object sender, EventArgs e)
        {

        }
    }
}
