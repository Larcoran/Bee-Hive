namespace Chapter_6_4_bee_hive
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.workerBeeJob = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.shiftsUpDown = new System.Windows.Forms.NumericUpDown();
            this.jobAssignButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.report = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.shiftsUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.jobAssignButton);
            this.groupBox1.Controls.Add(this.shiftsUpDown);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.workerBeeJob);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(284, 93);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Worker Bee Assignments";
            // 
            // workerBeeJob
            // 
            this.workerBeeJob.DisplayMember = "1";
            this.workerBeeJob.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.workerBeeJob.FormattingEnabled = true;
            this.workerBeeJob.Items.AddRange(new object[] {
            "Nectar collector",
            "Honey manufacturing",
            "Egg care",
            "Baby bee tutoring",
            "Hive maintenance",
            "Sting patrol"});
            this.workerBeeJob.Location = new System.Drawing.Point(6, 36);
            this.workerBeeJob.Name = "workerBeeJob";
            this.workerBeeJob.Size = new System.Drawing.Size(189, 21);
            this.workerBeeJob.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Job";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(198, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Shifts";
            // 
            // shiftsUpDown
            // 
            this.shiftsUpDown.Location = new System.Drawing.Point(201, 36);
            this.shiftsUpDown.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.shiftsUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.shiftsUpDown.Name = "shiftsUpDown";
            this.shiftsUpDown.Size = new System.Drawing.Size(77, 20);
            this.shiftsUpDown.TabIndex = 3;
            this.shiftsUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // jobAssignButton
            // 
            this.jobAssignButton.Location = new System.Drawing.Point(6, 64);
            this.jobAssignButton.Name = "jobAssignButton";
            this.jobAssignButton.Size = new System.Drawing.Size(272, 23);
            this.jobAssignButton.TabIndex = 4;
            this.jobAssignButton.Text = "Assign this job to a bee";
            this.jobAssignButton.UseVisualStyleBackColor = true;
            this.jobAssignButton.Click += new System.EventHandler(this.jobAssignButton_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(302, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(170, 93);
            this.button1.TabIndex = 1;
            this.button1.Text = "Work the next shift";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // report
            // 
            this.report.Location = new System.Drawing.Point(12, 111);
            this.report.Multiline = true;
            this.report.Name = "report";
            this.report.Size = new System.Drawing.Size(460, 266);
            this.report.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 389);
            this.Controls.Add(this.report);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Beehive Management System";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.shiftsUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button jobAssignButton;
        private System.Windows.Forms.NumericUpDown shiftsUpDown;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox workerBeeJob;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox report;
    }
}

