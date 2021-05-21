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
    public partial class Subject : Form
    {
        public Subject()
        {
            InitializeComponent();
            BindData();
        }

        const string ConnectionString1 = "Server=tcp:itpmtimetable.database.windows.net,1433;Initial Catalog=TimetableDB;Persist Security Info=False;User ID=manager;Password=Sliit.lk;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
        SqlConnection con = new SqlConnection(ConnectionString1);

        String Off_Sem;

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand command = new SqlCommand("insert into Subjects (Sub_Code, Sub_Name, Off_Year, Off_Sem, Nu_Of_Lec_Ho, Nu_Of_Tut_Ho, Nu_Of_Lab_Ho, Nu_Of_Eva_Ho) " +
                "values('" + textBox1.Text + "', '" + textBox2.Text + "', '" + int.Parse(textBox3.Text) + "', '" + Off_Sem + "', '" + int.Parse(comboBox1.Text) + "', '"+int.Parse(comboBox2.Text)+"', '"+int.Parse(comboBox3.Text)+"', '"+int.Parse(comboBox4.Text)+"')", con);
            command.ExecuteNonQuery();
            MessageBox.Show("Successfully inserted Subjects Details...");
            con.Close();
            BindData();
            Clearmethod();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        void BindData()
        {

            SqlCommand command = new SqlCommand("select * from Subjects", con);
            SqlDataAdapter sd = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            dataGridView1.DataSource = dt;
        }

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

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Off_Sem = "Semester 1";

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            Off_Sem = "Semester 2";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Clearmethod();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to Edit these records??", "Edit Records", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                con.Open();
                SqlCommand command = new SqlCommand("select * from Subjects where Row_ID = " + dataGridView1.SelectedCells[0].Value.ToString() + "", con);
                command.ExecuteNonQuery();
                con.Close();

                SqlDataAdapter sd = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                sd.Fill(dt);

                textBox6.Text = dataGridView1.SelectedCells[1].Value.ToString();
                textBox5.Text = dataGridView1.SelectedCells[2].Value.ToString();
                textBox4.Text = dataGridView1.SelectedCells[3].Value.ToString();
                comboBox9.Text = dataGridView1.SelectedCells[4].Value.ToString();
                comboBox8.Text = dataGridView1.SelectedCells[5].Value.ToString();
                comboBox7.Text = dataGridView1.SelectedCells[6].Value.ToString();
                comboBox6.Text = dataGridView1.SelectedCells[7].Value.ToString();
                comboBox5.Text = dataGridView1.SelectedCells[8].Value.ToString();

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to delete thease records??", "Delete Record", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                con.Open();
                SqlCommand command = new SqlCommand("Delete from Subjects where Row_ID = " + dataGridView1.SelectedCells[0].Value.ToString() + " ", con); ;
                command.ExecuteNonQuery();
                dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
                con.Close();

                MessageBox.Show("Successfully Deleted Subject Details...");
                BindData();

                }
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand command = new SqlCommand("update Subjects set Sub_Code = '" + textBox6.Text + "', Sub_Name = '" + textBox5.Text + "', Off_Year = '" + textBox4.Text + "', Off_Sem = '" + comboBox9.Text + "', Nu_Of_Lec_Ho = '" + comboBox8.Text + "', Nu_Of_Tut_Ho = '" + comboBox7.Text + "', Nu_Of_Lab_Ho = '" + comboBox6.Text + "', Nu_Of_Eva_Ho = '" + comboBox5.Text + "' where Row_ID = " + dataGridView1.SelectedCells[0].Value.ToString() + " ", con);
            command.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Successfully Updated Subject Details...");

            BindData();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("select * from Subjects where Off_Year = '" + comboBox10.Text + "' ", con);
            SqlDataAdapter sd = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            BindData();
        }
    }
}
