
namespace ExcelSamarApp.Views
{
    partial class Universal
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.chklstServices = new System.Windows.Forms.CheckedListBox();
            this.chklstTrafficType = new System.Windows.Forms.CheckedListBox();
            this.chklstPopulation = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(573, 42);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(721, 477);
            this.dataGridView1.TabIndex = 10;
            // 
            // chklstServices
            // 
            this.chklstServices.CheckOnClick = true;
            this.chklstServices.ColumnWidth = 250;
            this.chklstServices.FormattingEnabled = true;
            this.chklstServices.Items.AddRange(new object[] {
            "Addiction Treatment/Services",
            "Case Management",
            "Child Care",
            "Crisis Services",
            "Direct Victim Outreach",
            "Education/Job Training",
            "Emergency Shelter",
            "Family Reunification",
            "Grantmaking",
            "Health Care",
            "Interpretation/Translation",
            "Legal Services - Civil",
            "Legal Services - Criminal",
            "Legal Services - Generic",
            "Legal Services - Immigration",
            "Long-term Housing",
            "Mental Health Services (Out-Patient)",
            "Outreach/Awareness",
            "Policy Advocacy",
            "Prevention/Advice/Safety Planning",
            "Psychological Support - Generic",
            "Repatriation",
            "Research",
            "Residential Mental Health Treatment (In-Patient)",
            "Shelter - Generic",
            "Supportive Counseling",
            "Survivor Leadership",
            "Training",
            "Transitional Housing",
            "Transportation Assistance",
            "Volunteer Opportunities"});
            this.chklstServices.Location = new System.Drawing.Point(36, 327);
            this.chklstServices.MultiColumn = true;
            this.chklstServices.Name = "chklstServices";
            this.chklstServices.Size = new System.Drawing.Size(531, 274);
            this.chklstServices.TabIndex = 11;
            // 
            // chklstTrafficType
            // 
            this.chklstTrafficType.ColumnWidth = 180;
            this.chklstTrafficType.FormattingEnabled = true;
            this.chklstTrafficType.Items.AddRange(new object[] {
            "Child Pornography",
            "Child Trafficking",
            "Early/Child Marriage",
            "Forced Marriage",
            "International Adoption",
            "International Marriage Brokering/\"Bride Trafficking\"",
            "Labor trafficking/Forced Labor/Debt Bondage",
            "Organ Trafficking",
            "Other",
            "Sex Trafficking",
            "Trafficking Type",
            "Use of Child",
            "Use of Children in",
            "Use of Children in Armed Conflict"});
            this.chklstTrafficType.Location = new System.Drawing.Point(36, 42);
            this.chklstTrafficType.Name = "chklstTrafficType";
            this.chklstTrafficType.Size = new System.Drawing.Size(287, 259);
            this.chklstTrafficType.TabIndex = 12;
            // 
            // chklstPopulation
            // 
            this.chklstPopulation.FormattingEnabled = true;
            this.chklstPopulation.Items.AddRange(new object[] {
            "Adult",
            "Citizens of the Country",
            "Ethnic Minorities",
            "Female",
            "Foreign Nationals",
            "Homeless Populations",
            "LGBTQI Individuals",
            "Male",
            "Migrant Workers",
            "Minor",
            "People with Disabilities",
            "People with HIV/AIDS",
            "Refugees/Asylum Seekers",
            "Religious/Social/Political Minority Groups",
            "Sex Workers",
            "Transgender Female-to-Male",
            "Transgender Male-to-Female"});
            this.chklstPopulation.Location = new System.Drawing.Point(329, 42);
            this.chklstPopulation.Name = "chklstPopulation";
            this.chklstPopulation.Size = new System.Drawing.Size(238, 259);
            this.chklstPopulation.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Traffic Types";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(326, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Population";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 311);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Services";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(573, 525);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(83, 50);
            this.btnSearch.TabIndex = 17;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(678, 525);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(89, 50);
            this.btnExport.TabIndex = 18;
            this.btnExport.Text = "Export To Excel";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(1211, 525);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(83, 50);
            this.btnClose.TabIndex = 19;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Universal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1306, 641);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chklstPopulation);
            this.Controls.Add(this.chklstTrafficType);
            this.Controls.Add(this.chklstServices);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Universal";
            this.Text = "Universal";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.CheckedListBox chklstServices;
        private System.Windows.Forms.CheckedListBox chklstTrafficType;
        private System.Windows.Forms.CheckedListBox chklstPopulation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}