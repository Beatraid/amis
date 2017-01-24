namespace BDKURSACH
{
    partial class Form_teacher_subject
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
            this.label_name_teacher = new System.Windows.Forms.Label();
            this.linkLabel_exit = new System.Windows.Forms.LinkLabel();
            this.dataGridView_marks = new System.Windows.Forms.DataGridView();
            this.button_admin_next = new System.Windows.Forms.Button();
            this.button_abolition = new System.Windows.Forms.Button();
            this.button_add_sabject = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_marks)).BeginInit();
            this.SuspendLayout();
            // 
            // label_name_teacher
            // 
            this.label_name_teacher.AutoSize = true;
            this.label_name_teacher.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_name_teacher.Location = new System.Drawing.Point(25, 71);
            this.label_name_teacher.Name = "label_name_teacher";
            this.label_name_teacher.Size = new System.Drawing.Size(189, 22);
            this.label_name_teacher.TabIndex = 8;
            this.label_name_teacher.Text = "Ім\'я прізвище виклад";
            this.label_name_teacher.Click += new System.EventHandler(this.label_name_teacher_Click);
            // 
            // linkLabel_exit
            // 
            this.linkLabel_exit.AutoSize = true;
            this.linkLabel_exit.Location = new System.Drawing.Point(451, 9);
            this.linkLabel_exit.Name = "linkLabel_exit";
            this.linkLabel_exit.Size = new System.Drawing.Size(33, 13);
            this.linkLabel_exit.TabIndex = 19;
            this.linkLabel_exit.TabStop = true;
            this.linkLabel_exit.Text = "Вихід";
            this.linkLabel_exit.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_exit_LinkClicked);
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
            this.Column3,
            this.Column4});
            this.dataGridView_marks.Location = new System.Drawing.Point(29, 96);
            this.dataGridView_marks.Name = "dataGridView_marks";
            this.dataGridView_marks.ReadOnly = true;
            this.dataGridView_marks.Size = new System.Drawing.Size(442, 213);
            this.dataGridView_marks.TabIndex = 23;
            this.dataGridView_marks.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_marks_CellContentClick);
            // 
            // button_admin_next
            // 
            this.button_admin_next.Location = new System.Drawing.Point(409, 395);
            this.button_admin_next.Name = "button_admin_next";
            this.button_admin_next.Size = new System.Drawing.Size(75, 23);
            this.button_admin_next.TabIndex = 24;
            this.button_admin_next.Text = "Далі";
            this.button_admin_next.UseVisualStyleBackColor = true;
            this.button_admin_next.Click += new System.EventHandler(this.button_admin_next_Click);
            // 
            // button_abolition
            // 
            this.button_abolition.Location = new System.Drawing.Point(12, 395);
            this.button_abolition.Name = "button_abolition";
            this.button_abolition.Size = new System.Drawing.Size(75, 23);
            this.button_abolition.TabIndex = 25;
            this.button_abolition.Text = "Відміна";
            this.button_abolition.UseVisualStyleBackColor = true;
            this.button_abolition.Click += new System.EventHandler(this.button_abolition_Click);
            // 
            // button_add_sabject
            // 
            this.button_add_sabject.Location = new System.Drawing.Point(121, 327);
            this.button_add_sabject.Name = "button_add_sabject";
            this.button_add_sabject.Size = new System.Drawing.Size(103, 23);
            this.button_add_sabject.TabIndex = 27;
            this.button_add_sabject.Text = "Додати предмет";
            this.button_add_sabject.UseVisualStyleBackColor = true;
            this.button_add_sabject.Click += new System.EventHandler(this.button_add_sabject_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(291, 327);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 23);
            this.button1.TabIndex = 28;
            this.button1.Text = "Видалити предмет";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Предмет";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "ВНЗ";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Факультет";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Група";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Form_teacher_subject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 430);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button_add_sabject);
            this.Controls.Add(this.button_abolition);
            this.Controls.Add(this.button_admin_next);
            this.Controls.Add(this.dataGridView_marks);
            this.Controls.Add(this.linkLabel_exit);
            this.Controls.Add(this.label_name_teacher);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form_teacher_subject";
            this.ShowInTaskbar = false;
            this.Text = "Form_teacher_subject";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_teacher_subject_FormClosed);
            this.Load += new System.EventHandler(this.Form_teacher_subject_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_marks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_name_teacher;
        protected System.Windows.Forms.LinkLabel linkLabel_exit;
        private System.Windows.Forms.DataGridView dataGridView_marks;
        private System.Windows.Forms.Button button_admin_next;
        private System.Windows.Forms.Button button_abolition;
        private System.Windows.Forms.Button button_add_sabject;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}