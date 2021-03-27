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

            

            con.Open();
            SqlCommand command = new SqlCommand("insert into StudentGroup(Year,Sem,program,GroupNumber,SubGroupNumber,GroupID,SubGroupID) values ('"+comboYear.Text+"','"+comboSem.Text+"', '"+comboPrg.Text+"', '"+numericGroupNum.Value+"','"+numericSubGroupNum.Value+"','"+textGroupID.Text+"','"+textSubGroupID.Text+"' )",con );
            command.ExecuteNonQuery();
            MessageBox.Show("success");
            con.Close();
            BindData();
        }

        void BindData()
        {
            SqlCommand command = new SqlCommand(" select * from StudentGroup ", con);
            SqlDataAdapter sd = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            dataGridViewStudentGroup.DataSource = dt;

        }

        private void btnGenerateID_Click(object sender, EventArgs e)
        {
            textGroupID.Text = comboYear.Text + '.' + comboSem.Text + '.' + comboPrg.Text + '.' + numericGroupNum.Value;
            textSubGroupID.Text = comboYear.Text + '.' + comboSem.Text + '.' + comboPrg.Text + '.' + numericGroupNum.Value + '.' + numericSubGroupNum.Value;
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void btnEditUP_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand command = new SqlCommand("select ColumnID,Year,Sem,program,GroupNumber,SubGroupNumber,GroupID,SubGroupID from StudentGroup  where ColumnID = " + dataGridViewStudentGroup.SelectedCells[0].Value.ToString() + " ", con);
            SqlDataReader srd = command.ExecuteReader();
            while (srd.Read())
            {
                comboYearUP.Text = srd.GetValue(1).ToString();
                comboSemUP.Text = srd.GetValue(2).ToString();
                comboProgramUP.Text = srd.GetValue(3).ToString();
                numericGroupNumUP.Text = srd.GetValue(4).ToString();
                numericSubGroupNumUP.Text = srd.GetValue(5).ToString();
                textGroupIDup.Text = srd.GetValue(6).ToString();
                textSubGroupIDup.Text = srd.GetValue(7).ToString();
            }

            con.Close();
        }

        private void btnGenerateUP_Click(object sender, EventArgs e)
        {
            textGroupIDup.Text = comboYearUP.Text + '.' + comboSemUP.Text + '.' + comboProgramUP.Text + '.' + numericGroupNumUP.Value;
            textSubGroupIDup.Text =textGroupIDup.Text+ '.' + numericSubGroupNumUP.Value;

        }

        private void btnUpdateGroup_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand command = new SqlCommand("update StudentGroup set year ='" + comboYearUP.Text + "', Sem ='" + comboSemUP.Text + "', program ='" + comboProgramUP.Text + "',GroupNumber ='" + numericGroupNumUP.Value + "',SubGroupNumber ='" + numericSubGroupNumUP.Value + "',GroupID ='" + textGroupIDup.Text + "',SubGroupID ='" + textSubGroupIDup.Text + "'  where ColumnID = " + dataGridViewStudentGroup.SelectedCells[0].Value.ToString() + " ", con);
            command.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Successfully Updated");
            BindData();
        }

        private void btnDeleteUP_Click(object sender, EventArgs e)
        {
            if (textSubGroupIDup.Text != "")
            {
                if (MessageBox.Show("Are you Sure To Delete", "Delete Record", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    con.Open();
                    SqlCommand command = new SqlCommand("Delete StudentGroup  where ColumnID = " + dataGridViewStudentGroup.SelectedCells[0].Value.ToString() + " ", con);
                    command.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Successfully Deleted");
                    BindData();
                }
            }
            else
            {
                MessageBox.Show("Enter Tag Code");
            }
        }
    }
}
