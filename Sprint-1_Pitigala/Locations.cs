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
    public partial class Locations : Form
    {
        public Locations()
        {
            InitializeComponent();
            BindData();
        }

        SqlConnection con = new SqlConnection("Data Source=U-PC\\SQLEXPRESS;Initial Catalog=TimetableManagement;Persist Security Info=True;User ID=sa;Password=uj");

        String room_type;

        private void label1_Click(object sender, EventArgs e)
        {
            //lable1
        }

        private void button1_Click(object sender, EventArgs e)
        {
                      Clearmethod();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand command = new SqlCommand("insert into Locations (Building_Name, Room_Name, Room_Type, Capacity) values('"+comboBox1.Text+"', '"+textBox1.Text+"', '"+room_type+"', '"+int.Parse(comboBox2.Text)+"')", con);
            command.ExecuteNonQuery();
            MessageBox.Show("Successfully inserted Location Details");
            con.Close();
            BindData();
            Clearmethod();
        }

        void BindData()
        {

            SqlCommand command = new SqlCommand("select * from Locations", con);
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
            room_type = "Lecture Hall";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            room_type = "Laboratory";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to Edit these records??", "Edit Records", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                con.Open();
                SqlCommand command = new SqlCommand("select * from Locations where Lock_ID = " + dataGridView1.SelectedCells[0].Value.ToString() + "", con);
                command.ExecuteNonQuery();
                con.Close();

                SqlDataAdapter sd = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                sd.Fill(dt);

                comboBox3.Text = dataGridView1.SelectedCells[1].Value.ToString();
                textBox2.Text = dataGridView1.SelectedCells[2].Value.ToString();
                comboBox5.Text = dataGridView1.SelectedCells[3].Value.ToString();
                comboBox4.Text = dataGridView1.SelectedCells[4].Value.ToString();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand command = new SqlCommand("update Locations set Building_Name = '" + comboBox3.Text + "', Room_Name = '" + textBox2.Text + "', Room_Type = '" + comboBox5.Text + "', Capacity = '" + comboBox4.Text + "' where Lock_ID = " + dataGridView1.SelectedCells[0].Value.ToString() + " ", con);
            command.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Successfully Updated Location Details");

            BindData();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to delete thease records??", "Delete Record", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                con.Open();
                SqlCommand command = new SqlCommand("Delete from Locations where Lock_ID = " + dataGridView1.SelectedCells[0].Value.ToString() + " ", con);
                command.ExecuteNonQuery();
                dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
                con.Close();

                MessageBox.Show("Successfully Deleted Room Details...");
                BindData();

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void textbox3_Enter(object sender, EventArgs e)
        {
            if (textBox3.Text == "Enter Building Name")
            {
                textBox3.Text = "";
                textBox3.ForeColor = Color.Black;
            }
        }

        private void textbox3_Leave(object sender, EventArgs e)
        {
            if (textBox3.Text == "")
            {
                textBox3.Text = "Enter Building Name";
                textBox3.ForeColor = Color.Silver;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand command = new SqlCommand(" Delete from Locations where Building_Name = '" + textBox3.Text+"' ", con);
            command.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Room Successfully Removed...");
            BindData();
            Clearmethod();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }
    }
}
