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

namespace AstaneGhodsRazavi
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            label5.Text = DateTime.Now.ToString("dddd ,  dd MMM yyyy");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Astan;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("SELECT * FROM ACCOUNT WHERE UserName=@UserName AND Password=@Password", con);
            cmd.Parameters.AddWithValue("@UserName", txtUserName.Text);
            cmd.Parameters.AddWithValue("@Password", txtPassword.Text);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            sda.Fill(dt);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            if (dt.Rows.Count > 0)
            {
                this.Hide();
                MainForm mainform = new MainForm();
                mainform.Show();
            }
            else
            {
                MessageBox.Show("لطفا اطلاعات درست وارد نمایید");
            }
        }
    }
}
