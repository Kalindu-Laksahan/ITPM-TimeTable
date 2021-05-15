using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Configuration;

namespace Dashboard
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            BindDataC();
            BindDataP();
            BindDataN();

            labelTableC.Text = "Sessions Table";
            labelTableP.Text = "Sessions Table";
            labelTableN.Text = "Sessions Table";
        }

        const string ConnectionString = "Data Source=KALIPC\\ASUSSQL;Initial Catalog=TimeTableDB;Persist Security Info=True;User ID=sa;Password=kalindu";
        SqlConnection con = new SqlConnection(ConnectionString);

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            DataGridViewCheckBoxColumn chkbox1 = new DataGridViewCheckBoxColumn();
            DataGridViewCheckBoxColumn chkbox2 = new DataGridViewCheckBoxColumn();
            DataGridViewCheckBoxColumn chkbox3 = new DataGridViewCheckBoxColumn();

            chkbox1.HeaderText = "";
            chkbox1.Width = 30;
            chkbox1.Name = "checkBoxColumn";

            chkbox2.HeaderText = "";
            chkbox2.Width = 30;
            chkbox2.Name = "checkBoxColumn";

            chkbox3.HeaderText = "";
            chkbox3.Width = 30;
            chkbox3.Name = "checkBoxColumn";


            dataGridViewConsecutive.Columns.Insert(0, chkbox1);
            dataGridViewParallel.Columns.Insert(0, chkbox2);
            dataGridViewNon.Columns.Insert(0, chkbox3);
        }

        void BindDataC()
        {
            SqlCommand command = new SqlCommand(" select * from Session", con);
            SqlDataAdapter sd = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            dataGridViewConsecutive.DataSource = dt;
            

        }

        void BindDataP()
        {
            SqlCommand command = new SqlCommand(" select * from Session", con);
            SqlDataAdapter sd = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            dataGridViewParallel.DataSource = dt;


        }

        void BindDataN()
        {
            SqlCommand command = new SqlCommand(" select * from Session", con);
            SqlDataAdapter sd = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            dataGridViewNon.DataSource = dt;


        }

        private void AddSessionC_Click(object sender, EventArgs e)
        {
            
            foreach(DataGridViewRow row in dataGridViewConsecutive.Rows)
            {
                bool chkboxselected = Convert.ToBoolean(row.Cells["checkBoxColumn"].Value);
                if (chkboxselected)
                {
                    string squery = "insert into Consecutive values(@Lecturer,@SubjectCode,@Subject,@Tag,@GroupID,@StudenCount,@Duration,@StartingTime,@Date)";
                    SqlCommand command = new SqlCommand(squery, con);
                    command.Parameters.AddWithValue("@Lecturer",row.Cells[2].Value);
                    command.Parameters.AddWithValue("@SubjectCode", row.Cells[3].Value);
                    command.Parameters.AddWithValue("@Subject", row.Cells[4].Value);
                    command.Parameters.AddWithValue("@Tag", row.Cells[5].Value);
                    command.Parameters.AddWithValue("@GroupID", row.Cells[6].Value);
                    command.Parameters.AddWithValue("@StudenCount", row.Cells[7].Value);
                    command.Parameters.AddWithValue("@Duration", row.Cells[8].Value);
                    command.Parameters.AddWithValue("@StartingTime", row.Cells[9].Value);
                    command.Parameters.AddWithValue("@Date", row.Cells[10].Value);

                    con.Open();
                    command.ExecuteNonQuery();
                    con.Close();


                }


                labelC.Text = "Selected Records Successfully Inserted As Consecutive Sessions  ";
            }

        }

        private void ViewSessionC_Click(object sender, EventArgs e)
        {
            void BindDataConsecutive()
            {
                SqlCommand command = new SqlCommand(" select * from Consecutive", con);
                SqlDataAdapter sd = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                sd.Fill(dt);
                dataGridViewConsecutive.DataSource = dt;
            }
            BindDataConsecutive();
            AddSessionC.Enabled = false;
            labelTableC.Text = "Consecutive Sessions Table";
        }

        private void AddSessionP_Click(object sender, EventArgs e)
        {

            foreach (DataGridViewRow row in dataGridViewParallel.Rows)
            {
                bool chkboxselected = Convert.ToBoolean(row.Cells["checkBoxColumn"].Value);
                if (chkboxselected)
                {
                    string squery = "insert into Parallel values(@Lecturer,@SubjectCode,@Subject,@Tag,@GroupID,@StudenCount,@Duration,@StartingTime,@Date)";
                    SqlCommand command = new SqlCommand(squery, con);
                    command.Parameters.AddWithValue("@Lecturer", row.Cells[2].Value);
                    command.Parameters.AddWithValue("@SubjectCode", row.Cells[3].Value);
                    command.Parameters.AddWithValue("@Subject", row.Cells[4].Value);
                    command.Parameters.AddWithValue("@Tag", row.Cells[5].Value);
                    command.Parameters.AddWithValue("@GroupID", row.Cells[6].Value);
                    command.Parameters.AddWithValue("@StudenCount", row.Cells[7].Value);
                    command.Parameters.AddWithValue("@Duration", row.Cells[8].Value);
                    command.Parameters.AddWithValue("@StartingTime", row.Cells[9].Value);
                    command.Parameters.AddWithValue("@Date", row.Cells[10].Value);

                    con.Open();
                    command.ExecuteNonQuery();
                    con.Close();


                }


                labelP.Text = "Selected Records Successfully Inserted As Parallel Sessions  ";
            }
        }

        private void ViewSessionP_Click(object sender, EventArgs e)
        {
            void BindDataParallel()
            {
                SqlCommand command = new SqlCommand(" select * from Parallel", con);
                SqlDataAdapter sd = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                sd.Fill(dt);
                dataGridViewParallel.DataSource = dt;
            }
            BindDataParallel();
            AddSessionP.Enabled = false;

            labelTableP.Text = "Parallel Sessions Table";
        }

        private void ViewSessionN_Click(object sender, EventArgs e)
        {

            void BindDataNon()
            {
                SqlCommand command = new SqlCommand(" select * from NonOverlapping", con);
                SqlDataAdapter sd = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                sd.Fill(dt);
               dataGridViewNon.DataSource = dt;
            }
            BindDataNon();
            AddSessionN.Enabled = false;

            labelTableN.Text = "Non Overlapping Sessions Table";
        }

        private void AddSessionN_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridViewNon.Rows)
            {
                bool chkboxselected = Convert.ToBoolean(row.Cells["checkBoxColumn"].Value);
                if (chkboxselected)
                {
                    string squery = "insert into NonOverlapping values(@Lecturer,@SubjectCode,@Subject,@Tag,@GroupID,@StudenCount,@Duration,@StartingTime,@Date)";
                    SqlCommand command = new SqlCommand(squery, con);
                    command.Parameters.AddWithValue("@Lecturer", row.Cells[2].Value);
                    command.Parameters.AddWithValue("@SubjectCode", row.Cells[3].Value);
                    command.Parameters.AddWithValue("@Subject", row.Cells[4].Value);
                    command.Parameters.AddWithValue("@Tag", row.Cells[5].Value);
                    command.Parameters.AddWithValue("@GroupID", row.Cells[6].Value);
                    command.Parameters.AddWithValue("@StudenCount", row.Cells[7].Value);
                    command.Parameters.AddWithValue("@Duration", row.Cells[8].Value);
                    command.Parameters.AddWithValue("@StartingTime", row.Cells[9].Value);
                    command.Parameters.AddWithValue("@Date", row.Cells[10].Value);

                    con.Open();
                    command.ExecuteNonQuery();
                    con.Close();


                }


                labelN.Text = "Selected Records Successfully Inserted As NonOverlapping Sessions  ";
            }



        }
    }

        
    }

