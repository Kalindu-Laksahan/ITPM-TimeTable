using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sprint_1_Pitigala
{
    public partial class Sessions : Form
    {
        public Sessions()
        {
            InitializeComponent();
            BindData();
        }

        const string ConnectionString = "Server=tcp:itpmtimetable.database.windows.net,1433;Initial Catalog=TimetableDB;Persist Security Info=False;User ID=manager;Password=Sliit.lk;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
        SqlConnection con = new SqlConnection(ConnectionString);

        //SqlConnection con = new SqlConnection("Data Source=U-PC\\SQLEXPRESS;Initial Catalog=TimetableManagement;Persist Security Info=True;User ID=sa;Password=uj");

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand command = new SqlCommand("update Sessions set Lec_Name = '" + comboBox11.Text + "', Sub_Name = '" + comboBox10.Text + "', Sub_Code = '" + comboBox9.Text + "', Tag = '" + comboBox8.Text + "', GroupID = '" + comboBox14.Text + "', SubGroupID = '" + comboBox15.Text + "', Student_Count = '" + textBox6.Text + "', Session_Duration = '" + textBox5.Text + "' where Session_ID = " + dataGridView1.SelectedCells[0].Value.ToString() + " ", con);
            command.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Successfully Updated Session Details...");

            BindData();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand command = new SqlCommand("insert into Sessions (Lec_Name, Sub_Name, Sub_Code, Tag, GroupID, SubGroupID, Student_Count, Session_Duration) " +
                "values('" + comboBox1.Text + "', '" + comboBox2.Text + "', '" + comboBox3.Text + "', '" + comboBox4.Text + "', '" + comboBox12.Text + "', '" + comboBox13.Text + "', '" + textBox3.Text + "', '" + textBox4.Text + "')", con);
            command.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Session Created Successfully...");
            BindData();
            Clearmethod();
        }

        private void Sessions_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'timetableManagementDataSet6.Sessions' table. You can move, or remove it, as needed.
            this.sessionsTableAdapter.Fill(this.timetableManagementDataSet6.Sessions);
            // TODO: This line of code loads data into the 'timetableManagementDataSet5.StudentGroup' table. You can move, or remove it, as needed.
            this.studentGroupTableAdapter1.Fill(this.timetableManagementDataSet5.StudentGroup);
            // TODO: This line of code loads data into the 'timetableManagementDataSet4.StudentGroup' table. You can move, or remove it, as needed.
            this.studentGroupTableAdapter.Fill(this.timetableManagementDataSet4.StudentGroup);
            // TODO: This line of code loads data into the 'timetableManagementDataSet3.Tag' table. You can move, or remove it, as needed.
            this.tagTableAdapter.Fill(this.timetableManagementDataSet3.Tag);
            // TODO: This line of code loads data into the 'timetableManagementDataSet2.Subjects' table. You can move, or remove it, as needed.
            this.subjectsTableAdapter1.Fill(this.timetableManagementDataSet2.Subjects);
            // TODO: This line of code loads data into the 'timetableManagementDataSet1.Subjects' table. You can move, or remove it, as needed.
            this.subjectsTableAdapter.Fill(this.timetableManagementDataSet1.Subjects);
            // TODO: This line of code loads data into the 'timetableManagementDataSet.Lecturers' table. You can move, or remove it, as needed.
            this.lecturersTableAdapter.Fill(this.timetableManagementDataSet.Lecturers);

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.lecturersTableAdapter.FillBy(this.timetableManagementDataSet.Lecturers);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        //Retrieve data
        void BindData()
        {

            SqlCommand command = new SqlCommand("select * from Sessions", con);
            SqlDataAdapter sd = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            dataGridView1.DataSource = dt;
        }


        //Clear inserted data
        void Clearmethod()
        {
            Action<Control.ControlCollection> func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                {
                    if (control is TextBox)
                    {
                        (control as TextBox).Clear();

                    }
                    else if (control is ComboBox)
                    {
                        (control as ComboBox).SelectedIndex = -1;
                    }
                    else
                    {
                        func(control.Controls);
                    }
                }
            };
            func(Controls);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Clearmethod();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to Edit these records??", "Edit Records", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                con.Open();
                SqlCommand command = new SqlCommand("select * from Sessions where Session_ID = " + dataGridView1.SelectedCells[0].Value.ToString() + "", con);
                command.ExecuteNonQuery();
                con.Close();

                SqlDataAdapter sd = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                sd.Fill(dt);

                comboBox11.Text = dataGridView1.SelectedCells[1].Value.ToString();
                comboBox10.Text = dataGridView1.SelectedCells[2].Value.ToString();
                comboBox9.Text = dataGridView1.SelectedCells[3].Value.ToString();
                comboBox8.Text = dataGridView1.SelectedCells[4].Value.ToString();
                comboBox14.Text = dataGridView1.SelectedCells[5].Value.ToString();
                comboBox15.Text = dataGridView1.SelectedCells[6].Value.ToString();
                textBox6.Text = dataGridView1.SelectedCells[7].Value.ToString();
                textBox5.Text = dataGridView1.SelectedCells[8].Value.ToString();

            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to delete thease records??", "Delete Record", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                con.Open();
                SqlCommand command = new SqlCommand("Delete from Sessions where Session_ID = " + dataGridView1.SelectedCells[0].Value.ToString() + " ", con); ;
                command.ExecuteNonQuery();
                dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
                con.Close();

                MessageBox.Show("Successfully Deleted Session Details...");
                BindData();

            }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
            
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
            
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Clearmethod();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("select * from Sessions where Lec_Name = '" + comboBox5.Text + "' ", con);
            SqlDataAdapter sd = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            BindData();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("select * from Subjects where Sub_Name = '" + comboBox7.Text + "' ", con);
            SqlDataAdapter sd = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void comboBox16_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void comboBox8_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
