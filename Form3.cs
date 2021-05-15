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
    public partial class FormTag : Form
    {
        public FormTag()
        {
            InitializeComponent();
            BindData();
        }
        const string ConnectionString = "Data Source=KALIPC\\ASUSSQL;Initial Catalog=TimeTableDB;Persist Security Info=True;User ID=sa;Password=kalindu";
        SqlConnection con = new SqlConnection(ConnectionString);

        private void btnAddTag_Click(object sender, EventArgs e)
        {
            
            con.Open();
            SqlCommand command = new SqlCommand("insert into Tag(TagCode,TagName,RelatedTag) values ('" + textTagCode.Text + "','" + textTagName.Text + "','"+textRelatedTag.Text+"')", con);
            command.ExecuteNonQuery();
            MessageBox.Show("success");
            con.Close();
            BindData();
        }

        void BindData()
        {
            SqlCommand command = new SqlCommand(" select * from Tag", con);
            SqlDataAdapter sd = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            dataGridViewTag.DataSource = dt;

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand command = new SqlCommand("update Tag set TagCode ='"+textTagCodeUp.Text+"', TagName ='"+textTagNameUP.Text+"', RelatedTag ='"+textRelatedTagUP.Text+ "' where ColumnID = " + dataGridViewTag.SelectedCells[0].Value.ToString() + " ", con);
            command.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Successfully Updated");
            BindData();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
            BindData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
             if (textTagCodeUp.Text != "")
            {
                if (MessageBox.Show("Are you Sure To Delete", "Delete Record", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    con.Open();
                    SqlCommand command = new SqlCommand("Delete Tag  where ColumnID = " + dataGridViewTag.SelectedCells[0].Value.ToString() + " ", con);
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
          //  int rowindex = dataGridViewTag.CurrentCell.RowIndex;
           // dataGridViewTag.Rows.RemoveAt(rowindex);

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand command = new SqlCommand("select ColumnID,TagCode,TagName,RelatedTag from Tag  where ColumnID = "+ dataGridViewTag.SelectedCells[0].Value.ToString()+ " ", con);
            SqlDataReader srd = command.ExecuteReader();
            while (srd.Read())
            {
                textTagCodeUp.Text = srd.GetValue(1).ToString();
                textTagNameUP.Text = srd.GetValue(2).ToString();
                textRelatedTagUP.Text = srd.GetValue(3).ToString();
            }

            con.Close();
        }

        private void dataGridViewTag_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
           
            con.Open();
            SqlCommand command = new SqlCommand("select TagCode,TagName,RelatedTag from Tag  where TagCode = '" + textTagCodeUp.Text + "' ", con);
            SqlDataReader srd = command.ExecuteReader();
            while (srd.Read())
            {
                textTagCodeUp.Text = srd.GetValue(0).ToString();
                textTagNameUP.Text = srd.GetValue(1).ToString();
                textRelatedTagUP.Text = srd.GetValue(2).ToString();
            }


            con.Close();

        }

        private void dataGridViewTag_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
