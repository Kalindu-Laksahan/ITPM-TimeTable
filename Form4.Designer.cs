
namespace Dashboard
{
    partial class Form4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.labelC = new System.Windows.Forms.Label();
            this.dataGridViewConsecutive = new System.Windows.Forms.DataGridView();
            this.AddSessionC = new System.Windows.Forms.Button();
            this.ViewSessionC = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.ViewSessionP = new System.Windows.Forms.Button();
            this.AddSessionP = new System.Windows.Forms.Button();
            this.dataGridViewParallel = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.labelTableN = new System.Windows.Forms.Label();
            this.ViewSessionN = new System.Windows.Forms.Button();
            this.AddSessionN = new System.Windows.Forms.Button();
            this.dataGridViewNon = new System.Windows.Forms.DataGridView();
            this.labelN = new System.Windows.Forms.Label();
            this.labelTableP = new System.Windows.Forms.Label();
            this.labelP = new System.Windows.Forms.Label();
            this.labelTableC = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewConsecutive)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewParallel)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNon)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(882, 503);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.labelTableC);
            this.tabPage1.Controls.Add(this.labelC);
            this.tabPage1.Controls.Add(this.dataGridViewConsecutive);
            this.tabPage1.Controls.Add(this.AddSessionC);
            this.tabPage1.Controls.Add(this.ViewSessionC);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(874, 470);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Consecutive";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // labelC
            // 
            this.labelC.AutoSize = true;
            this.labelC.Location = new System.Drawing.Point(158, 250);
            this.labelC.Name = "labelC";
            this.labelC.Size = new System.Drawing.Size(0, 20);
            this.labelC.TabIndex = 19;
            // 
            // dataGridViewConsecutive
            // 
            this.dataGridViewConsecutive.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewConsecutive.Location = new System.Drawing.Point(22, 40);
            this.dataGridViewConsecutive.Name = "dataGridViewConsecutive";
            this.dataGridViewConsecutive.RowHeadersWidth = 51;
            this.dataGridViewConsecutive.RowTemplate.Height = 29;
            this.dataGridViewConsecutive.Size = new System.Drawing.Size(834, 178);
            this.dataGridViewConsecutive.TabIndex = 18;
            // 
            // AddSessionC
            // 
            this.AddSessionC.BackColor = System.Drawing.Color.DodgerBlue;
            this.AddSessionC.FlatAppearance.BorderSize = 0;
            this.AddSessionC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddSessionC.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.AddSessionC.Location = new System.Drawing.Point(124, 333);
            this.AddSessionC.Name = "AddSessionC";
            this.AddSessionC.Size = new System.Drawing.Size(150, 35);
            this.AddSessionC.TabIndex = 17;
            this.AddSessionC.Text = "Add Session";
            this.AddSessionC.UseVisualStyleBackColor = false;
            this.AddSessionC.Click += new System.EventHandler(this.AddSessionC_Click);
            // 
            // ViewSessionC
            // 
            this.ViewSessionC.BackColor = System.Drawing.Color.DodgerBlue;
            this.ViewSessionC.FlatAppearance.BorderSize = 0;
            this.ViewSessionC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ViewSessionC.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.ViewSessionC.Location = new System.Drawing.Point(615, 333);
            this.ViewSessionC.Name = "ViewSessionC";
            this.ViewSessionC.Size = new System.Drawing.Size(150, 35);
            this.ViewSessionC.TabIndex = 16;
            this.ViewSessionC.Text = "View Sessions";
            this.ViewSessionC.UseVisualStyleBackColor = false;
            this.ViewSessionC.Click += new System.EventHandler(this.ViewSessionC_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.labelP);
            this.tabPage2.Controls.Add(this.labelTableP);
            this.tabPage2.Controls.Add(this.ViewSessionP);
            this.tabPage2.Controls.Add(this.AddSessionP);
            this.tabPage2.Controls.Add(this.dataGridViewParallel);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(874, 470);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Parallel";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // ViewSessionP
            // 
            this.ViewSessionP.BackColor = System.Drawing.Color.DodgerBlue;
            this.ViewSessionP.FlatAppearance.BorderSize = 0;
            this.ViewSessionP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ViewSessionP.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.ViewSessionP.Location = new System.Drawing.Point(527, 343);
            this.ViewSessionP.Name = "ViewSessionP";
            this.ViewSessionP.Size = new System.Drawing.Size(150, 35);
            this.ViewSessionP.TabIndex = 16;
            this.ViewSessionP.Text = "View Sessions";
            this.ViewSessionP.UseVisualStyleBackColor = false;
            this.ViewSessionP.Click += new System.EventHandler(this.ViewSessionP_Click);
            // 
            // AddSessionP
            // 
            this.AddSessionP.BackColor = System.Drawing.Color.DodgerBlue;
            this.AddSessionP.FlatAppearance.BorderSize = 0;
            this.AddSessionP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddSessionP.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.AddSessionP.Location = new System.Drawing.Point(152, 343);
            this.AddSessionP.Name = "AddSessionP";
            this.AddSessionP.Size = new System.Drawing.Size(150, 35);
            this.AddSessionP.TabIndex = 15;
            this.AddSessionP.Text = "Add Session";
            this.AddSessionP.UseVisualStyleBackColor = false;
            this.AddSessionP.Click += new System.EventHandler(this.AddSessionP_Click);
            // 
            // dataGridViewParallel
            // 
            this.dataGridViewParallel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewParallel.Location = new System.Drawing.Point(17, 55);
            this.dataGridViewParallel.Name = "dataGridViewParallel";
            this.dataGridViewParallel.RowHeadersWidth = 51;
            this.dataGridViewParallel.RowTemplate.Height = 29;
            this.dataGridViewParallel.Size = new System.Drawing.Size(834, 178);
            this.dataGridViewParallel.TabIndex = 1;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.AliceBlue;
            this.tabPage3.Controls.Add(this.labelN);
            this.tabPage3.Controls.Add(this.labelTableN);
            this.tabPage3.Controls.Add(this.ViewSessionN);
            this.tabPage3.Controls.Add(this.AddSessionN);
            this.tabPage3.Controls.Add(this.dataGridViewNon);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(874, 470);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Non Overlapping";
            // 
            // labelTableN
            // 
            this.labelTableN.AutoSize = true;
            this.labelTableN.Location = new System.Drawing.Point(18, 30);
            this.labelTableN.Name = "labelTableN";
            this.labelTableN.Size = new System.Drawing.Size(0, 20);
            this.labelTableN.TabIndex = 16;
            // 
            // ViewSessionN
            // 
            this.ViewSessionN.BackColor = System.Drawing.Color.DodgerBlue;
            this.ViewSessionN.FlatAppearance.BorderSize = 0;
            this.ViewSessionN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ViewSessionN.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.ViewSessionN.Location = new System.Drawing.Point(490, 348);
            this.ViewSessionN.Name = "ViewSessionN";
            this.ViewSessionN.Size = new System.Drawing.Size(150, 35);
            this.ViewSessionN.TabIndex = 15;
            this.ViewSessionN.Text = "View Sessions";
            this.ViewSessionN.UseVisualStyleBackColor = false;
            this.ViewSessionN.Click += new System.EventHandler(this.ViewSessionN_Click);
            // 
            // AddSessionN
            // 
            this.AddSessionN.BackColor = System.Drawing.Color.DodgerBlue;
            this.AddSessionN.FlatAppearance.BorderSize = 0;
            this.AddSessionN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddSessionN.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.AddSessionN.Location = new System.Drawing.Point(184, 348);
            this.AddSessionN.Name = "AddSessionN";
            this.AddSessionN.Size = new System.Drawing.Size(150, 35);
            this.AddSessionN.TabIndex = 14;
            this.AddSessionN.Text = "Add Session";
            this.AddSessionN.UseVisualStyleBackColor = false;
            this.AddSessionN.Click += new System.EventHandler(this.AddSessionN_Click);
            // 
            // dataGridViewNon
            // 
            this.dataGridViewNon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewNon.Location = new System.Drawing.Point(18, 53);
            this.dataGridViewNon.Name = "dataGridViewNon";
            this.dataGridViewNon.RowHeadersWidth = 51;
            this.dataGridViewNon.RowTemplate.Height = 29;
            this.dataGridViewNon.Size = new System.Drawing.Size(834, 178);
            this.dataGridViewNon.TabIndex = 0;
            this.dataGridViewNon.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // labelN
            // 
            this.labelN.AutoSize = true;
            this.labelN.Location = new System.Drawing.Point(84, 251);
            this.labelN.Name = "labelN";
            this.labelN.Size = new System.Drawing.Size(0, 20);
            this.labelN.TabIndex = 17;
            // 
            // labelTableP
            // 
            this.labelTableP.AutoSize = true;
            this.labelTableP.Location = new System.Drawing.Point(39, 24);
            this.labelTableP.Name = "labelTableP";
            this.labelTableP.Size = new System.Drawing.Size(0, 20);
            this.labelTableP.TabIndex = 17;
            // 
            // labelP
            // 
            this.labelP.AutoSize = true;
            this.labelP.Location = new System.Drawing.Point(58, 279);
            this.labelP.Name = "labelP";
            this.labelP.Size = new System.Drawing.Size(0, 20);
            this.labelP.TabIndex = 18;
            // 
            // labelTableC
            // 
            this.labelTableC.AutoSize = true;
            this.labelTableC.Location = new System.Drawing.Point(22, 9);
            this.labelTableC.Name = "labelTableC";
            this.labelTableC.Size = new System.Drawing.Size(0, 20);
            this.labelTableC.TabIndex = 20;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 503);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewConsecutive)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewParallel)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dataGridViewNon;
        private System.Windows.Forms.Label labelTableN;
        private System.Windows.Forms.Button ViewSessionN;
        private System.Windows.Forms.Button AddSessionN;
        private System.Windows.Forms.DataGridView dataGridViewConsecutive;
        private System.Windows.Forms.Button AddSessionC;
        private System.Windows.Forms.Button ViewSessionC;
        private System.Windows.Forms.Button ViewSessionP;
        private System.Windows.Forms.Button AddSessionP;
        private System.Windows.Forms.DataGridView dataGridViewParallel;
        private System.Windows.Forms.Label labelC;
        private System.Windows.Forms.Label labelN;
        private System.Windows.Forms.Label labelTableC;
        private System.Windows.Forms.Label labelP;
        private System.Windows.Forms.Label labelTableP;
    }
}