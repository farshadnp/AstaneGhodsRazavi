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
    public partial class Add_Household : Form
    {
        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Astan;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter adpt;
        DataTable dt;
        int PersonId;

        public Add_Household()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DisplayData();

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                cmd = new SqlCommand("UPDATE Person SET FName='" + txtName.Text + "',LName='" + txtFamily.Text + "',FatherName='" + txtFatherName.Text + "',NationCode= '" + txtNationID.Text + "',Gender='" + cBoxSex.Text + "',Phone='" + txtPhone.Text + "',Age='" + txtAge.Text + "',Address='" + txtAddress.Text + "',ChildeCount='" + cBoxChildeCount.Text + "',RentStatus='" + cBoxRentStatus.Text + "',ServiceNeeded='" + cBoxServiceType.Text + "' WHERE PID='" + PersonId + "' ", con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("اطلاعات با موفقیت بروزرسانی شد");
                con.Close();

                DisplayData();
                Clear();


            }
            catch (Exception)
            {

            }


        }


        private void btnInsert_Click(object sender, EventArgs e)
        {
            con.Open();
            cmd = new SqlCommand("insert into Person values('"+txtName.Text+"','"+txtFamily.Text+"','"+txtFatherName.Text+"','"+txtNationID.Text+"','"+cBoxSex.Text+"','"+txtPhone.Text+"','"+txtAge.Text+"','"+txtAddress.Text+"','"+cBoxChildeCount.Text+"','"+cBoxRentStatus.Text+"','"+cBoxServiceType.Text+"')",con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("اطلاعات با موفقیت ذخیره شد");
            con.Close();
            DisplayData();
            Clear();
        }

        public void DisplayData()
        {
            con.Open();
            adpt = new SqlDataAdapter("SELECT * FROM Person", con);
            dt = new DataTable();
            adpt.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
            ChangeHeader();

        }

        public void ChangeHeader()
        {
            dataGridView1.Columns[0].HeaderText = "ردیف";
            dataGridView1.Columns[0].Width = 35;

            dataGridView1.Columns[1].HeaderText = "نام";
            dataGridView1.Columns[1].Width = 70;

            dataGridView1.Columns[2].HeaderText = "نام خانوادگی";
            dataGridView1.Columns[2].Width = 70;

            dataGridView1.Columns[3].HeaderText = "نام پدر";
            dataGridView1.Columns[3].Width = 70;

            dataGridView1.Columns[4].HeaderText = "کدملی";
            dataGridView1.Columns[4].Width = 80;

            dataGridView1.Columns[5].HeaderText = "جنسیت";
            dataGridView1.Columns[5].Width = 50;

            dataGridView1.Columns[6].HeaderText = "شماره تلفن";
            dataGridView1.Columns[6].Width = 80;

            dataGridView1.Columns[7].HeaderText = "سن";
            dataGridView1.Columns[7].Width = 50;

            dataGridView1.Columns[8].HeaderText = "آدرس";
            dataGridView1.Columns[8].Width = 210;

            dataGridView1.Columns[9].HeaderText = "تعداد فرزندان";
            dataGridView1.Columns[9].Width = 60;

            dataGridView1.Columns[10].HeaderText = "وضعیت سکونت";
            dataGridView1.Columns[10].Width = 60;

            dataGridView1.Columns[11].HeaderText = "خدمات مورد نیاز";
            dataGridView1.Columns[11].Width = 65;

        }

        public void Clear()
        {
            txtName.Text = "";
            txtFamily.Text = "";
            txtFatherName.Text = "";
            txtNationID.Text = "";
            cBoxSex.Text = "";
            txtPhone.Text = "";
            txtAge.Text = "";
            txtAddress.Text = "";
            cBoxChildeCount.Text = "";
            cBoxRentStatus.Text = "";
            cBoxServiceType.Text = "";

        }




        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                PersonId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                txtName.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtFamily.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtFatherName.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtNationID.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                cBoxSex.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
                txtPhone.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
                txtAge.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
                txtAddress.Text = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
                cBoxChildeCount.Text = dataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString();
                cBoxRentStatus.Text = dataGridView1.Rows[e.RowIndex].Cells[10].Value.ToString();
                cBoxServiceType.Text = dataGridView1.Rows[e.RowIndex].Cells[11].Value.ToString();
            }
            catch
            {
                
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            cmd=new SqlCommand("DELETE from Person WHERE PID='" + PersonId + "'", con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("تمامی رکورد های شخص موردنظر پاک گردید");
            con.Close();
            DisplayData();
            Clear();

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            SearchData(txtSearch.Text);
        }


        public void SearchData(string search)
        {
            con.Open();
            string query = "SELECT * FROM Person WHERE NationCode LIKE '%" + search + "%' ";
            adpt = new SqlDataAdapter(query, con);
            dt = new DataTable();
            adpt.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            //dataGridView1.Columns[0].HeaderText = "MYID";
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_2(object sender, EventArgs e)
        {

        }
    }
}
