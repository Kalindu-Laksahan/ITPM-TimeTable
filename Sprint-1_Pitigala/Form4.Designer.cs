
namespace Sprint_1_Pitigala
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.labelTableC = new System.Windows.Forms.Label();
            this.labelC = new System.Windows.Forms.Label();
            this.dataGridViewConsecutive = new System.Windows.Forms.DataGridView();
            this.AddSessionC = new System.Windows.Forms.Button();
            this.ViewSessionC = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.labelP = new System.Windows.Forms.Label();
            this.labelTableP = new System.Windows.Forms.Label();
            this.ViewSessionP = new System.Windows.Forms.Button();
            this.AddSessionP = new System.Windows.Forms.Button();
            this.dataGridViewParallel = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.labelN = new System.Windows.Forms.Label();
            this.labelTableN = new System.Windows.Forms.Label();
            this.ViewSessionN = new System.Windows.Forms.Button();
            this.AddSessionN = new System.Windows.Forms.Button();
            this.dataGridViewNon = new System.Windows.Forms.DataGridView();
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
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(841, 421);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage1.BackgroundImage")));
            this.tabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage1.Controls.Add(this.labelTableC);
            this.tabPage1.Controls.Add(this.labelC);
            this.tabPage1.Controls.Add(this.dataGridViewConsecutive);
            this.tabPage1.Controls.Add(this.AddSessionC);
            this.tabPage1.Controls.Add(this.ViewSessionC);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Size = new System.Drawing.Size(833, 392);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Consecutive";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // labelTableC
            // 
            this.labelTableC.AutoSize = true;
            this.labelTableC.Location = new System.Drawing.Point(16, 6);
            this.labelTableC.Name = "labelTableC";
            this.labelTableC.Size = new System.Drawing.Size(0, 17);
            this.labelTableC.TabIndex = 20;
            // 
            // labelC
            // 
            this.labelC.AutoSize = true;
            this.labelC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelC.Location = new System.Drawing.Point(201, 160);
            this.labelC.Name = "labelC";
            this.labelC.Size = new System.Drawing.Size(0, 17);
            this.labelC.TabIndex = 19;
            // 
            // dataGridViewConsecutive
            // 
            this.dataGridViewConsecutive.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewConsecutive.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewConsecutive.Location = new System.Drawing.Point(19, 25);
            this.dataGridViewConsecutive.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewConsecutive.Name = "dataGridViewConsecutive";
            this.dataGridViewConsecutive.RowHeadersWidth = 51;
            this.dataGridViewConsecutive.RowTemplate.Height = 29;
            this.dataGridViewConsecutive.Size = new System.Drawing.Size(782, 193);
            this.dataGridViewConsecutive.TabIndex = 18;
            this.dataGridViewConsecutive.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewConsecutive_CellContentClick);
            // 
            // AddSessionC
            // 
            this.AddSessionC.BackColor = System.Drawing.Color.DodgerBlue;
            this.AddSessionC.FlatAppearance.BorderSize = 0;
            this.AddSessionC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddSessionC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddSessionC.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.AddSessionC.Location = new System.Drawing.Point(130, 268);
            this.AddSessionC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AddSessionC.Name = "AddSessionC";
            this.AddSessionC.Size = new System.Drawing.Size(119, 41);
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
            this.ViewSessionC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewSessionC.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.ViewSessionC.Location = new System.Drawing.Point(467, 268);
            this.ViewSessionC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ViewSessionC.Name = "ViewSessionC";
            this.ViewSessionC.Size = new System.Drawing.Size(190, 41);
            this.ViewSessionC.TabIndex = 16;
            this.ViewSessionC.Text = "View Consecutive Sessions";
            this.ViewSessionC.UseVisualStyleBackColor = false;
            this.ViewSessionC.Click += new System.EventHandler(this.ViewSessionC_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage2.BackgroundImage")));
            this.tabPage2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage2.Controls.Add(this.labelP);
            this.tabPage2.Controls.Add(this.labelTableP);
            this.tabPage2.Controls.Add(this.ViewSessionP);
            this.tabPage2.Controls.Add(this.AddSessionP);
            this.tabPage2.Controls.Add(this.dataGridViewParallel);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Size = new System.Drawing.Size(833, 392);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Parallel";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // labelP
            // 
            this.labelP.AutoSize = true;
            this.labelP.Location = new System.Drawing.Point(44, 181);
            this.labelP.Name = "labelP";
            this.labelP.Size = new System.Drawing.Size(0, 17);
            this.labelP.TabIndex = 18;
            // 
            // labelTableP
            // 
            this.labelTableP.AutoSize = true;
            this.labelTableP.Location = new System.Drawing.Point(29, 16);
            this.labelTableP.Name = "labelTableP";
            this.labelTableP.Size = new System.Drawing.Size(0, 17);
            this.labelTableP.TabIndex = 17;
            // 
            // ViewSessionP
            // 
            this.ViewSessionP.BackColor = System.Drawing.Color.DodgerBlue;
            this.ViewSessionP.FlatAppearance.BorderSize = 0;
            this.ViewSessionP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ViewSessionP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewSessionP.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.ViewSessionP.Location = new System.Drawing.Point(444, 234);
            this.ViewSessionP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ViewSessionP.Name = "ViewSessionP";
            this.ViewSessionP.Size = new System.Drawing.Size(157, 32);
            this.ViewSessionP.TabIndex = 16;
            this.ViewSessionP.Text = "View Parallel Sessions";
            this.ViewSessionP.UseVisualStyleBackColor = false;
            this.ViewSessionP.Click += new System.EventHandler(this.ViewSessionP_Click);
            // 
            // AddSessionP
            // 
            this.AddSessionP.BackColor = System.Drawing.Color.DodgerBlue;
            this.AddSessionP.FlatAppearance.BorderSize = 0;
            this.AddSessionP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddSessionP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddSessionP.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.AddSessionP.Location = new System.Drawing.Point(163, 234);
            this.AddSessionP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AddSessionP.Name = "AddSessionP";
            this.AddSessionP.Size = new System.Drawing.Size(114, 32);
            this.AddSessionP.TabIndex = 15;
            this.AddSessionP.Text = "Add Session";
            this.AddSessionP.UseVisualStyleBackColor = false;
            this.AddSessionP.Click += new System.EventHandler(this.AddSessionP_Click);
            // 
            // dataGridViewParallel
            // 
            this.dataGridViewParallel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewParallel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewParallel.Location = new System.Drawing.Point(13, 36);
            this.dataGridViewParallel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewParallel.Name = "dataGridViewParallel";
            this.dataGridViewParallel.RowHeadersWidth = 51;
            this.dataGridViewParallel.RowTemplate.Height = 29;
            this.dataGridViewParallel.Size = new System.Drawing.Size(790, 169);
            this.dataGridViewParallel.TabIndex = 1;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.AliceBlue;
            this.tabPage3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage3.BackgroundImage")));
            this.tabPage3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage3.Controls.Add(this.labelN);
            this.tabPage3.Controls.Add(this.labelTableN);
            this.tabPage3.Controls.Add(this.ViewSessionN);
            this.tabPage3.Controls.Add(this.AddSessionN);
            this.tabPage3.Controls.Add(this.dataGridViewNon);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage3.Size = new System.Drawing.Size(833, 392);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Non Overlapping";
            // 
            // labelN
            // 
            this.labelN.AutoSize = true;
            this.labelN.Location = new System.Drawing.Point(63, 163);
            this.labelN.Name = "labelN";
            this.labelN.Size = new System.Drawing.Size(0, 17);
            this.labelN.TabIndex = 17;
            // 
            // labelTableN
            // 
            this.labelTableN.AutoSize = true;
            this.labelTableN.Location = new System.Drawing.Point(14, 19);
            this.labelTableN.Name = "labelTableN";
            this.labelTableN.Size = new System.Drawing.Size(0, 17);
            this.labelTableN.TabIndex = 16;
            // 
            // ViewSessionN
            // 
            this.ViewSessionN.BackColor = System.Drawing.Color.DodgerBlue;
            this.ViewSessionN.FlatAppearance.BorderSize = 0;
            this.ViewSessionN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ViewSessionN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewSessionN.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.ViewSessionN.Location = new System.Drawing.Point(444, 291);
            this.ViewSessionN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ViewSessionN.Name = "ViewSessionN";
            this.ViewSessionN.Size = new System.Drawing.Size(222, 36);
            this.ViewSessionN.TabIndex = 15;
            this.ViewSessionN.Text = "View Non Overlapping Sessions";
            this.ViewSessionN.UseVisualStyleBackColor = false;
            this.ViewSessionN.Click += new System.EventHandler(this.ViewSessionN_Click);
            // 
            // AddSessionN
            // 
            this.AddSessionN.BackColor = System.Drawing.Color.DodgerBlue;
            this.AddSessionN.FlatAppearance.BorderSize = 0;
            this.AddSessionN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddSessionN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddSessionN.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.AddSessionN.Location = new System.Drawing.Point(214, 291);
            this.AddSessionN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AddSessionN.Name = "AddSessionN";
            this.AddSessionN.Size = new System.Drawing.Size(112, 36);
            this.AddSessionN.TabIndex = 14;
            this.AddSessionN.Text = "Add Session";
            this.AddSessionN.UseVisualStyleBackColor = false;
            this.AddSessionN.Click += new System.EventHandler(this.AddSessionN_Click);
            // 
            // dataGridViewNon
            // 
            this.dataGridViewNon.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewNon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewNon.Location = new System.Drawing.Point(17, 64);
            this.dataGridViewNon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewNon.Name = "dataGridViewNon";
            this.dataGridViewNon.RowHeadersWidth = 51;
            this.dataGridViewNon.RowTemplate.Height = 29;
            this.dataGridViewNon.Size = new System.Drawing.Size(780, 190);
            this.dataGridViewNon.TabIndex = 0;
            this.dataGridViewNon.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 421);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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