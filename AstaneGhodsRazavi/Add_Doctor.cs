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
    public partial class Add_Doctor : Form
    {
        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Astan;Integrated Security=True");
        public int Doctor_ID = 0;
        public string Doctor_Name ;
        public string Doctor_LName ;

        public Add_Doctor()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Add_Doctor_Load(object sender, EventArgs e)
        {
            DisplayDoctorToGridView();
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtFamily_TextChanged(object sender, EventArgs e)
        {

        }

        private void cBoxServiceType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            InsertDoctor();
            MessageBox.Show("پزشک جدید با موفقیت در پایگاه داده ثبت گردید.");
            DisplayDoctorToGridView();
        }



        private void btnDelete_Click(object sender, EventArgs e)
        {

            DeleteSelectedDoctorRow();

            Doctor_Name = (string)DGVDoctor.CurrentRow.Cells["DoctorFName"].Value;
            Doctor_LName = (string)DGVDoctor.CurrentRow.Cells["DoctorLName"].Value;
            Doctor_ID = (int)DGVDoctor.CurrentRow.Cells["DoctorID"].Value;
            
            MessageBox.Show(Doctor_Name+" "+Doctor_LName+ "حذف گردید" );
            DisplayDoctorToGridView();
        }




        /// <summary>
        /// Public Functions For CRUD
        /// </summary>

        public void DisplayDoctorToGridView()
        {
            SqlDataAdapter sda = new SqlDataAdapter("SelectDoctorDetails", con);
            sda.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            sda.Fill(dt);
            DGVDoctor.DataSource = dt;
        }


        public void InsertDoctor()
        {
            SqlCommand cmd = new SqlCommand("AddDoctor", con);

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@DoctorFName", txtName.Text);
            cmd.Parameters.AddWithValue("@DoctorLName", txtFamily.Text);
            cmd.Parameters.AddWithValue("@DoctorNationCode", txtNationID.Text);
            cmd.Parameters.AddWithValue("@DoctorPhone", txtPhone.Text);
            ///cmd.Parameters.AddWithValue("@DoctorBirthDate", textBox1.Text+textBox2.Text+textBox3.Text);
            cmd.Parameters.AddWithValue("@DoctorSpecialty", txtSpecialty.Text);
            cmd.Parameters.AddWithValue("@DoctorTypeOfAssist", txtTypeOfAssist.Text);
            cmd.Parameters.AddWithValue("@DoctorOfficeAddress", txtAddressOfOffice.Text);
            cmd.Parameters.AddWithValue("@DoctorOfficeTelephone", txtTelOfOffice.Text);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }


        public void DeleteSelectedDoctorRow()
        {
            SqlCommand cmd = new SqlCommand("DeleteDoctor", con);
            cmd.CommandType = CommandType.StoredProcedure;
            Doctor_ID = (int)DGVDoctor.CurrentRow.Cells["DoctorID"].Value;
            cmd.Parameters.AddWithValue("@DoctorID", Doctor_ID);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            SearchData(txtSearch.Text);

        }


        public void SearchData(string search)
        {
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Astan;Integrated Security=True");
            SqlCommand cmd;
            SqlDataAdapter adpt;
            DataTable dt;

            con.Open();
            string query = "SELECT * FROM Doctor WHERE  DoctorLName LIKE '%" + search + "%' ";
            adpt = new SqlDataAdapter(query, con);
            dt = new DataTable();
            adpt.Fill(dt);
            DGVDoctor.DataSource = dt;
            con.Close();
        }
    }
}
