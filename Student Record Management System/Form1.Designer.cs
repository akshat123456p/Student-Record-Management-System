namespace StudentRecordSystem
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up resources.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lblID = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblAge = new System.Windows.Forms.Label();
            this.numericAge = new System.Windows.Forms.NumericUpDown();
            this.lblCourse = new System.Windows.Forms.Label();
            this.comboCourse = new System.Windows.Forms.ComboBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.numericAge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(30, 30);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(68, 16);
            this.lblID.TabIndex = 0;
            this.lblID.Text = "Student ID";
            // 
            // txtID
            // 
            this.txtID.BackColor = System.Drawing.Color.Snow;
            this.txtID.Location = new System.Drawing.Point(120, 27);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(150, 22);
            this.txtID.TabIndex = 1;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(30, 70);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(44, 16);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Name";
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.Snow;
            this.txtName.Location = new System.Drawing.Point(120, 67);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(200, 22);
            this.txtName.TabIndex = 3;
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(30, 110);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(32, 16);
            this.lblAge.TabIndex = 4;
            this.lblAge.Text = "Age";
            // 
            // numericAge
            // 
            this.numericAge.BackColor = System.Drawing.Color.Snow;
            this.numericAge.Location = new System.Drawing.Point(120, 108);
            this.numericAge.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericAge.Name = "numericAge";
            this.numericAge.Size = new System.Drawing.Size(80, 22);
            this.numericAge.TabIndex = 5;
            this.numericAge.Value = new decimal(new int[] {
            18,
            0,
            0,
            0});
            // 
            // lblCourse
            // 
            this.lblCourse.AutoSize = true;
            this.lblCourse.Location = new System.Drawing.Point(30, 150);
            this.lblCourse.Name = "lblCourse";
            this.lblCourse.Size = new System.Drawing.Size(50, 16);
            this.lblCourse.TabIndex = 6;
            this.lblCourse.Text = "Course";
            // 
            // comboCourse
            // 
            this.comboCourse.BackColor = System.Drawing.Color.Snow;
            this.comboCourse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboCourse.FormattingEnabled = true;
            this.comboCourse.Items.AddRange(new object[] {
            "B.Tech",
            "B.Sc",
            "M.Sc",
            "MBA"});
            this.comboCourse.Location = new System.Drawing.Point(120, 147);
            this.comboCourse.Name = "comboCourse";
            this.comboCourse.Size = new System.Drawing.Size(150, 24);
            this.comboCourse.TabIndex = 7;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(30, 190);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(102, 16);
            this.lblDate.TabIndex = 8;
            this.lblDate.Text = "Enrollment Date";
            // 
            // datePicker
            // 
            this.datePicker.Location = new System.Drawing.Point(150, 187);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(200, 22);
            this.datePicker.TabIndex = 9;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Bisque;
            this.btnAdd.Location = new System.Drawing.Point(400, 25);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 30);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Bisque;
            this.btnUpdate.Location = new System.Drawing.Point(400, 65);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(100, 30);
            this.btnUpdate.TabIndex = 11;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Bisque;
            this.btnDelete.Location = new System.Drawing.Point(400, 105);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 30);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.BackColor = System.Drawing.Color.Bisque;
            this.btnLoad.Location = new System.Drawing.Point(400, 145);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(100, 30);
            this.btnLoad.TabIndex = 13;
            this.btnLoad.Text = "Load Data";
            this.btnLoad.UseVisualStyleBackColor = false;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Snow;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(30, 250);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(820, 300);
            this.dataGridView1.TabIndex = 14;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.datePicker);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.comboCourse);
            this.Controls.Add(this.lblCourse);
            this.Controls.Add(this.numericAge);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lblID);
            this.Name = "Form1";
            this.Text = "Student Record Management System";
            ((System.ComponentModel.ISupportInitialize)(this.numericAge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.NumericUpDown numericAge;
        private System.Windows.Forms.Label lblCourse;
        private System.Windows.Forms.ComboBox comboCourse;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

