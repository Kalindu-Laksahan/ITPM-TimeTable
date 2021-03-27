using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dashboard
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


            labelTitle.Text = "Student Groups";
            this.panelLoader.Controls.Clear();
            Form2 form2_vrb = new Form2() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            form2_vrb.FormBorderStyle = FormBorderStyle.None;
            this.panelLoader.Controls.Add(form2_vrb);
            form2_vrb.Show();
        }

      
        private void btnStudentGroups_Click(object sender, EventArgs e)
        {
           

            labelTitle.Text = "Student Groups";
            this.panelLoader.Controls.Clear();
            Form2 form2_vrb = new Form2() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            form2_vrb.FormBorderStyle = FormBorderStyle.None;
            this.panelLoader.Controls.Add(form2_vrb);
            form2_vrb.Show();

            
        }

        private void btnTags_Click(object sender, EventArgs e)
        {
           

            labelTitle.Text = "Tags";
            this.panelLoader.Controls.Clear();
            FormTag formTag_vrb = new FormTag() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            formTag_vrb.FormBorderStyle = FormBorderStyle.None;
            this.panelLoader.Controls.Add(formTag_vrb);
            formTag_vrb.Show();

           

        }

        private void labelTitle_Click(object sender, EventArgs e)
        {

        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            

        }

        private void btnHome_Leave(object sender, EventArgs e)
        {
           
        }

        private void btnStudentGroups_Leave(object sender, EventArgs e)
        {
        }

        private void btnTags_Leave(object sender, EventArgs e)
        {
            
        }

        private void btnSessions_Click(object sender, EventArgs e)
        {
            labelTitle.Text = "Session Types";
            this.panelLoader.Controls.Clear();
            Form4 form4_vrb = new Form4() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            form4_vrb.FormBorderStyle = FormBorderStyle.None;
            this.panelLoader.Controls.Add(form4_vrb);
            form4_vrb.Show();
        }
    }
}
