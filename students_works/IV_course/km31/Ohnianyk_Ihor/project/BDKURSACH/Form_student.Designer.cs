namespace BDKURSACH
{
    partial class Form_student
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
            this.label_name_student = new System.Windows.Forms.Label();
            this.label_group = new System.Windows.Forms.Label();
            this.dataGridView_marks = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label_average = new System.Windows.Forms.Label();
            this.label_many = new System.Windows.Forms.Label();
            this.linkLabel_exit = new System.Windows.Forms.LinkLabel();
            this.label_faculty = new System.Windows.Forms.Label();
            this.label_vnz = new System.Windows.Forms.Label();
            this.button_abolition = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_marks)).BeginInit();
            this.SuspendLayout();
            // 
            // label_name_student
            // 
            this.label_name_student.AutoSize = true;
            this.label_name_student.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_name_student.Location = new System.Drawing.Point(120, 69);
            this.label_name_student.Name = "label_name_student";
            this.label_name_student.Size = new System.Drawing.Size(124, 22);
            this.label_name_student.TabIndex = 0;
            this.label_name_student.Text = "Ім\'я прізвище";
            this.label_name_student.Click += new System.EventHandler(this.label_name_student_Click);
            // 
            // label_group
            // 
            this.label_group.AutoSize = true;
            this.label_group.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_group.Location = new System.Drawing.Point(7, 43);
            this.label_group.Name = "label_group";
            this.label_group.Size = new System.Drawing.Size(83, 17);
            this.label_group.TabIndex = 1;
            this.label_group.Text = "Група ВП-3";
            // 
            // dataGridView_marks
            // 
            this.dataGridView_marks.AllowUserToAddRows = false;
            this.dataGridView_marks.AllowUserToDeleteRows = false;
            this.dataGridView_marks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_marks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_marks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dataGridView_marks.Location = new System.Drawing.Point(124, 106);
            this.dataGridView_marks.Name = "dataGridView_marks";
            this.dataGridView_marks.ReadOnly = true;
            this.dataGridView_marks.Size = new System.Drawing.Size(243, 213);
            this.dataGridView_marks.TabIndex = 2;
            this.dataGridView_marks.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_marks_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Предмет";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Оцінка";
            this.Column2.Name = "Column2";
            // 
            // label_average
            // 
            this.label_average.AutoSize = true;
            this.label_average.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_average.Location = new System.Drawing.Point(121, 334);
            this.label_average.Name = "label_average";
            this.label_average.Size = new System.Drawing.Size(96, 17);
            this.label_average.TabIndex = 3;
            this.label_average.Text = "Середній бал";
            this.label_average.Click += new System.EventHandler(this.label_average_Click);
            // 
            // label_many
            // 
            this.label_many.AutoSize = true;
            this.label_many.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_many.Location = new System.Drawing.Point(121, 360);
            this.label_many.Name = "label_many";
            this.label_many.Size = new System.Drawing.Size(158, 17);
            this.label_many.TabIndex = 4;
            this.label_many.Text = "Нарахування стипендії";
            this.label_many.Click += new System.EventHandler(this.label_many_Click);
            // 
            // linkLabel_exit
            // 
            this.linkLabel_exit.AutoSize = true;
            this.linkLabel_exit.Location = new System.Drawing.Point(451, 9);
            this.linkLabel_exit.Name = "linkLabel_exit";
            this.linkLabel_exit.Size = new System.Drawing.Size(33, 13);
            this.linkLabel_exit.TabIndex = 5;
            this.linkLabel_exit.TabStop = true;
            this.linkLabel_exit.Text = "Вихід";
            this.linkLabel_exit.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_exit_LinkClicked);
            // 
            // label_faculty
            // 
            this.label_faculty.AutoSize = true;
            this.label_faculty.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_faculty.Location = new System.Drawing.Point(7, 26);
            this.label_faculty.Name = "label_faculty";
            this.label_faculty.Size = new System.Drawing.Size(80, 17);
            this.label_faculty.TabIndex = 6;
            this.label_faculty.Text = "Факультет";
            this.label_faculty.Click += new System.EventHandler(this.label_faculty_Click);
            // 
            // label_vnz
            // 
            this.label_vnz.AutoSize = true;
            this.label_vnz.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_vnz.Location = new System.Drawing.Point(7, 9);
            this.label_vnz.Name = "label_vnz";
            this.label_vnz.Size = new System.Drawing.Size(36, 17);
            this.label_vnz.TabIndex = 7;
            this.label_vnz.Text = "ВНЗ";
            this.label_vnz.Click += new System.EventHandler(this.label_vnz_Click);
            // 
            // button_abolition
            // 
            this.button_abolition.Location = new System.Drawing.Point(12, 395);
            this.button_abolition.Name = "button_abolition";
            this.button_abolition.Size = new System.Drawing.Size(75, 23);
            this.button_abolition.TabIndex = 20;
            this.button_abolition.Text = "Відміна";
            this.button_abolition.UseVisualStyleBackColor = true;
            this.button_abolition.Click += new System.EventHandler(this.button_abolition_Click);
            // 
            // Form_student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 430);
            this.Controls.Add(this.button_abolition);
            this.Controls.Add(this.label_vnz);
            this.Controls.Add(this.label_faculty);
            this.Controls.Add(this.linkLabel_exit);
            this.Controls.Add(this.label_many);
            this.Controls.Add(this.label_average);
            this.Controls.Add(this.dataGridView_marks);
            this.Controls.Add(this.label_group);
            this.Controls.Add(this.label_name_student);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form_student";
            this.Text = "Form3";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_student_FormClosed_1);
            this.Load += new System.EventHandler(this.Form_student_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_marks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_name_student;
        private System.Windows.Forms.Label label_group;
        private System.Windows.Forms.DataGridView dataGridView_marks;
        private System.Windows.Forms.Label label_average;
        private System.Windows.Forms.Label label_many;
        protected System.Windows.Forms.LinkLabel linkLabel_exit;
        private System.Windows.Forms.Label label_faculty;
        private System.Windows.Forms.Label label_vnz;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.Button button_abolition;
    }
}