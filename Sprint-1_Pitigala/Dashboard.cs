using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sprint_1_Pitigala
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();

            labName.Text = "Home";
            this.panel1.Controls.Clear();
            Home home = new Home() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            home.FormBorderStyle = FormBorderStyle.None;
            this.panel1.Controls.Add(home);
            home.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            labName.Text = "Home";
            this.panel1.Controls.Clear();
            Home home = new Home() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true};
            home.FormBorderStyle = FormBorderStyle.None;
            this.panel1.Controls.Add(home);
            home.Show();
        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            labName.Text = "Locations";
            this.panel1.Controls.Clear();
            Locations loc = new Locations() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            loc.FormBorderStyle = FormBorderStyle.None;
            this.panel1.Controls.Add(loc);
            loc.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            labName.Text = "Lecturers";
            this.panel1.Controls.Clear();
            Lecturers lec = new Lecturers() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            lec.FormBorderStyle = FormBorderStyle.None;
            this.panel1.Controls.Add(lec);
            lec.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            labName.Text = "Subjects";
            this.panel1.Controls.Clear();
            Subject sub = new Subject() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            sub.FormBorderStyle = FormBorderStyle.None;
            this.panel1.Controls.Add(sub);
            sub.Show();
        }

        private void labName_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            labName.Text = "Sessions";
            this.panel1.Controls.Clear();
            Sessions ses = new Sessions() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            ses.FormBorderStyle = FormBorderStyle.None;
            this.panel1.Controls.Add(ses);
            ses.Show();

            Clearmethod();
        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

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
    }
}
