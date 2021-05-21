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
    public partial class Lecturers : Form
    {
        
        public Lecturers()
        {
            InitializeComponent();
            BindData();
        }

        const string ConnectionString1 = "Server=tcp:itpmtimetable.database.windows.net,1433;Initial Catalog=TimetableDB;Persist Security Info=False;User ID=manager;Password=Sliit.lk;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
        SqlConnection con = new SqlConnection(ConnectionString1);
        private void button3_Click(object sender, EventArgs e)
        {
            String Active_Days = "";
            if (checkBox1.CheckState == CheckState.Checked)
            {
                Active_Days += "Monday";
            }

            if (checkBox2.CheckState == CheckState.Checked)
            {
                Active_Days += "Tuesday";
            }

            if (checkBox3.CheckState == CheckState.Checked)
            {
                Active_Days += "wednsday";
            }

            if (checkBox4.CheckState == CheckState.Checked)
            {
                Active_Days += "Thursday";
            }

            if (checkBox5.CheckState == CheckState.Checked)
            {
                Active_Days += "Friday";
            }

            if (checkBox6.CheckState == CheckState.Checked)
            {
                Active_Days += "Saturday";
            }

            if (checkBox7.CheckState == CheckState.Checked)
            {
                Active_Days += "Sunday";
            }

            con.Open();
            SqlCommand command = new SqlCommand("insert into Lecturers values('"+int.Parse(textBox1.Text)+"' , '"+textBox2.Text+"' , " +
                "'"+comboBox1.Text+"' , '"+comboBox2.Text+"' , '"+comboBox3.Text+"' , '"+comboBox4.Text+"' , '"+int.Parse(comboBox5.Text)+"' , " +
                "'"+textBox3.Text+"', '"+ Active_Days + "', '"+comboBox11.Text+"')" , con);

            command.ExecuteNonQuery();
            MessageBox.Show("Successfully inserted Lecturer Details...");
            con.Close();
            BindData();
            Clearmethod();

        }

        void BindData() {

            SqlCommand command = new SqlCommand("select * from Lecturers", con);
            SqlDataAdapter sd = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
           
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button5_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Are you sure to delete these records??", "Delete Record", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {

                        con.Open();
                        SqlCommand command = new SqlCommand("Delete from Lecturers where Emp_ID = " + dataGridView1.SelectedCells[0].Value.ToString() + "", con);
                        command.ExecuteNonQuery();
                        dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
                        con.Close();

                        MessageBox.Show("Successfully Deleted Lecturer Details...");

                        BindData();
                    }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Clearmethod();
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

        //Combining Emp_ID and Level
        private void button1_Click(object sender, EventArgs e)
        {
          textBox3.Text = comboBox5.Text +'.'+ textBox1.Text;
        }


        //Add placeholders
        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "Enter 6 Digit Number")
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.Black;
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "Enter 6 Digit Number";
                textBox1.ForeColor = Color.Silver;
            }
        }



        private void textBox3_Enter(object sender, EventArgs e)
        {

            if (textBox3.Text == "Click Fill Rank Button")
            {
                textBox3.Text = "";
                textBox3.ForeColor = Color.Black;
            }
            
        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            textBox3.Text = "Click Fill Rank Button";
            textBox3.ForeColor = Color.Silver;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to Edit these records??", "Edit Records", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                con.Open();
                SqlCommand command = new SqlCommand("Select * from Lecturers where Emp_ID = " + dataGridView1.SelectedCells[0].Value.ToString() + "", con);
                command.ExecuteNonQuery();
                con.Close();

                SqlDataAdapter sd = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                sd.Fill(dt);

                textBox8.Text = dataGridView1.SelectedCells[0].Value.ToString();
                textBox7.Text = dataGridView1.SelectedCells[1].Value.ToString();
                comboBox10.Text = dataGridView1.SelectedCells[2].Value.ToString();
                comboBox9.Text = dataGridView1.SelectedCells[3].Value.ToString();
                comboBox8.Text = dataGridView1.SelectedCells[4].Value.ToString();
                comboBox7.Text = dataGridView1.SelectedCells[5].Value.ToString();
                comboBox6.Text = dataGridView1.SelectedCells[6].Value.ToString();
                textBox6.Text = dataGridView1.SelectedCells[7].Value.ToString();
                textBox5.Text = dataGridView1.SelectedCells[8].Value.ToString();
                textBox9.Text = dataGridView1.SelectedCells[9].Value.ToString();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand command = new SqlCommand("update Lecturers set Emp_ID = '"+textBox8.Text+"', Lec_Name = '"+textBox7.Text+ "', Faculty = '"+comboBox10.Text+ "', Department = '"+comboBox9.Text+"', Campus = '"+comboBox8.Text+"', Building = '"+comboBox7.Text+"', Level = '"+comboBox6.Text+"', Rank = '"+textBox6.Text+ "', Active_days = '"+textBox5.Text+ "', Active_Hours = '"+textBox9.Text+"' where Emp_ID = '" + int.Parse(textBox8.Text) + "' ", con);
            command.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Successfully Updated Lecturer Details...");

            BindData();
        }

        private void comboBox9_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void comboBox10_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
           