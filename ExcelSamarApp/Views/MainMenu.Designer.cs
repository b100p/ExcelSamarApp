
namespace ExcelSamarApp
{
    partial class MainMenu
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
            this.btnOpen = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnClose = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnPopulations = new System.Windows.Forms.Button();
            this.btnTraffickingType = new System.Windows.Forms.Button();
            this.btnServices = new System.Windows.Forms.Button();
            this.btnAll = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(369, 27);
            this.btnOpen.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(74, 20);
            this.btnOpen.TabIndex = 18;
            this.btnOpen.Text = "Browse";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(388, 143);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 19;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(12, 27);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(351, 20);
            this.textBox1.TabIndex = 20;
            // 
            // btnPopulations
            // 
            this.btnPopulations.Location = new System.Drawing.Point(12, 53);
            this.btnPopulations.Name = "btnPopulations";
            this.btnPopulations.Size = new System.Drawing.Size(90, 23);
            this.btnPopulations.TabIndex = 21;
            this.btnPopulations.Text = "Populations";
            this.btnPopulations.UseVisualStyleBackColor = true;
            this.btnPopulations.Click += new System.EventHandler(this.btnPopulations_Click);
            // 
            // btnTraffickingType
            // 
            this.btnTraffickingType.Location = new System.Drawing.Point(108, 53);
            this.btnTraffickingType.Name = "btnTraffickingType";
            this.btnTraffickingType.Size = new System.Drawing.Size(117, 23);
            this.btnTraffickingType.TabIndex = 22;
            this.btnTraffickingType.Text = "Trafficking Type";
            this.btnTraffickingType.UseVisualStyleBackColor = true;
            this.btnTraffickingType.Click += new System.EventHandler(this.btnTraffickingType_Click);
            // 
            // btnServices
            // 
            this.btnServices.Location = new System.Drawing.Point(231, 53);
            this.btnServices.Name = "btnServices";
            this.btnServices.Size = new System.Drawing.Size(117, 23);
            this.btnServices.TabIndex = 23;
            this.btnServices.Text = "Services";
            this.btnServices.UseVisualStyleBackColor = true;
            this.btnServices.Click += new System.EventHandler(this.btnServices_Click);
            // 
            // btnAll
            // 
            this.btnAll.Location = new System.Drawing.Point(127, 82);
            this.btnAll.Name = "btnAll";
            this.btnAll.Size = new System.Drawing.Size(74, 37);
            this.btnAll.TabIndex = 24;
            this.btnAll.Text = "All";
            this.btnAll.UseVisualStyleBackColor = true;
            this.btnAll.Click += new System.EventHandler(this.btnAll_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 178);
            this.Controls.Add(this.btnAll);
            this.Controls.Add(this.btnServices);
            this.Controls.Add(this.btnTraffickingType);
            this.Controls.Add(this.btnPopulations);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnOpen);
            this.Name = "MainMenu";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnPopulations;
        private System.Windows.Forms.Button btnTraffickingType;
        private System.Windows.Forms.Button btnServices;
        private System.Windows.Forms.Button btnAll;
    }
}

