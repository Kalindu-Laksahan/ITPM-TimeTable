using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Dashboard
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            BindData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        const string ConnectionString = "Data Source=KALIPC\\ASUSSQL;Initial Catalog=TimeTableDB;Persist Security Info=True;User ID=sa;Password=kalindu";
        SqlConnection con = new SqlConnection(ConnectionString);

        private void btnGroupInsert_Click(object sender, EventArgs e)
        {

            

            String y = comboYear.Text;
            String s = comboSem.Text;
            decimal g = numericGroupNum.Value;
            decimal sg = numericSubGroupNum.Value;
            void gid()
            {

                Console.WriteLine("Y",y,"S",s,"G",g,".",sg);
            }

            con.Open();
            SqlCommand command = new SqlCommand("insert into StudentGroup values ('"+comboYear.Text+"','"+comboSem.Text+"', '"+comboPrg.Text+"', '"+numericGroupNum.Value+"','"+numericSubGroupNum.Value+"','"+comboYear.Text+ "','3' )",con );
            command.ExecuteNonQuery();
            MessageBox.Show("success");
            con.Close();
        }

        void BindData()
        {
            SqlCommand command = new SqlCommand(" select * from StudentGroup ", con);
            SqlDataAdapter sd = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            dataGridViewStudentGroup.DataSource = dt;

        }





    }
}
