namespace BDKURSACH
{
    partial class Form_teacher_mark
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
            this.label_vnz = new System.Windows.Forms.Label();
            this.label_faculty = new System.Windows.Forms.Label();
            this.label_group = new System.Windows.Forms.Label();
            this.label_name_student = new System.Windows.Forms.Label();
            this.dataGridView_marks = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button_mark = new System.Windows.Forms.Button();
            this.linkLabel_exit = new System.Windows.Forms.LinkLabel();
            this.button_abolition = new System.Windows.Forms.Button();
            this.lblSubj = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_marks)).BeginInit();
            this.SuspendLayout();
            // 
            // label_vnz
            // 
            this.label_vnz.AutoSize = true;
            this.label_vnz.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_vnz.Location = new System.Drawing.Point(7, 9);
            this.label_vnz.Name = "label_vnz";
            this.label_vnz.Size = new System.Drawing.Size(36, 17);
            this.label_vnz.TabIndex = 11;
            this.label_vnz.Text = "ВНЗ";
            // 
            // label_faculty
            // 
            this.label_faculty.AutoSize = true;
            this.label_faculty.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_faculty.Location = new System.Drawing.Point(7, 26);
            this.label_faculty.Name = "label_faculty";
            this.label_faculty.Size = new System.Drawing.Size(80, 17);
            this.label_faculty.TabIndex = 10;
            this.label_faculty.Text = "Факультет";
            // 
            // label_group
            // 
            this.label_group.AutoSize = true;
            this.label_group.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_group.Location = new System.Drawing.Point(7, 43);
            this.label_group.Name = "label_group";
            this.label_group.Size = new System.Drawing.Size(83, 17);
            this.label_group.TabIndex = 9;
            this.label_group.Text = "Група ВП-3";
            // 
            // label_name_student
            // 
            this.label_name_student.AutoSize = true;
            this.label_name_student.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_name_student.Location = new System.Drawing.Point(72, 85);
            this.label_name_student.Name = "label_name_student";
            this.label_name_student.Size = new System.Drawing.Size(145, 17);
            this.label_name_student.TabIndex = 8;
            this.label_name_student.Text = "Ім\'я прізвище виклад";
            // 
            // dataGridView_marks
            // 
            this.dataGridView_marks.AllowUserToAddRows = false;
            this.dataGridView_marks.AllowUserToDeleteRows = false;
            this.dataGridView_marks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_marks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_marks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dataGridView_marks.Location = new System.Drawing.Point(75, 122);
            this.dataGridView_marks.Name = "dataGridView_marks";
            this.dataGridView_marks.ReadOnly = true;
            this.dataGridView_marks.Size = new System.Drawing.Size(343, 213);
            this.dataGridView_marks.TabIndex = 12;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Ім\'я";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Прізвище";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Оцінка";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // button_mark
            // 
            this.button_mark.Location = new System.Drawing.Point(360, 395);
            this.button_mark.Name = "button_mark";
            this.button_mark.Size = new System.Drawing.Size(124, 23);
            this.button_mark.TabIndex = 13;
            this.button_mark.Text = "Поставити оцінку";
            this.button_mark.UseVisualStyleBackColor = true;
            this.button_mark.Click += new System.EventHandler(this.button_mark_Click);
            // 
            // linkLabel_exit
            // 
            this.linkLabel_exit.AutoSize = true;
            this.linkLabel_exit.Location = new System.Drawing.Point(451, 9);
            this.linkLabel_exit.Name = "linkLabel_exit";
            this.linkLabel_exit.Size = new System.Drawing.Size(33, 13);
            this.linkLabel_exit.TabIndex = 14;
            this.linkLabel_exit.TabStop = true;
            this.linkLabel_exit.Text = "Вихід";
            this.linkLabel_exit.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_exit_LinkClicked);
            // 
            // button_abolition
            // 
            this.button_abolition.Location = new System.Drawing.Point(12, 395);
            this.button_abolition.Name = "button_abolition";
            this.button_abolition.Size = new System.Drawing.Size(75, 23);
            this.button_abolition.TabIndex = 26;
            this.button_abolition.Text = "Назад";
            this.button_abolition.UseVisualStyleBackColor = true;
            this.button_abolition.Click += new System.EventHandler(this.button_abolition_Click);
            // 
            // lblSubj
            // 
            this.lblSubj.AutoSize = true;
            this.lblSubj.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSubj.Location = new System.Drawing.Point(72, 102);
            this.lblSubj.Name = "lblSubj";
            this.lblSubj.Size = new System.Drawing.Size(46, 17);
            this.lblSubj.TabIndex = 27;
            this.lblSubj.Text = "label1";
            // 
            // Form_teacher_mark
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 430);
            this.Controls.Add(this.lblSubj);
            this.Controls.Add(this.button_abolition);
            this.Controls.Add(this.linkLabel_exit);
            this.Controls.Add(this.button_mark);
            this.Controls.Add(this.dataGridView_marks);
            this.Controls.Add(this.label_vnz);
            this.Controls.Add(this.label_faculty);
            this.Controls.Add(this.label_group);
            this.Controls.Add(this.label_name_student);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form_teacher_mark";
            this.Text = "Form_teacher_mark";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_teacher_mark_FormClosed);
            this.Load += new System.EventHandler(this.Form_teacher_mark_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_marks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_vnz;
        private System.Windows.Forms.Label label_faculty;
        private System.Windows.Forms.Label label_group;
        private System.Windows.Forms.Label label_name_student;
        private System.Windows.Forms.DataGridView dataGridView_marks;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Button button_mark;
        protected System.Windows.Forms.LinkLabel linkLabel_exit;
        private System.Windows.Forms.Button button_abolition;
        private System.Windows.Forms.Label lblSubj;
    }
}