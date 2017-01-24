namespace BDKURSACH
{
    partial class Form_admin_edit
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
            this.linkLabel_exit = new System.Windows.Forms.LinkLabel();
            this.dataGridView_student = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button_admin_back = new System.Windows.Forms.Button();
            this.linkLabel_delete_student = new System.Windows.Forms.LinkLabel();
            this.label_vnz = new System.Windows.Forms.Label();
            this.label_faculty = new System.Windows.Forms.Label();
            this.label_group = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_student)).BeginInit();
            this.SuspendLayout();
            // 
            // linkLabel_exit
            // 
            this.linkLabel_exit.AutoSize = true;
            this.linkLabel_exit.Location = new System.Drawing.Point(451, 9);
            this.linkLabel_exit.Name = "linkLabel_exit";
            this.linkLabel_exit.Size = new System.Drawing.Size(33, 13);
            this.linkLabel_exit.TabIndex = 15;
            this.linkLabel_exit.TabStop = true;
            this.linkLabel_exit.Text = "Вихід";
            this.linkLabel_exit.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_exit_LinkClicked);
            // 
            // dataGridView_student
            // 
            this.dataGridView_student.AllowUserToAddRows = false;
            this.dataGridView_student.AllowUserToDeleteRows = false;
            this.dataGridView_student.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_student.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dataGridView_student.Location = new System.Drawing.Point(79, 104);
            this.dataGridView_student.Name = "dataGridView_student";
            this.dataGridView_student.ReadOnly = true;
            this.dataGridView_student.Size = new System.Drawing.Size(342, 213);
            this.dataGridView_student.TabIndex = 16;
            this.dataGridView_student.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_student_CellContentClick);
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
            this.Column3.HeaderText = "Логін";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // button_admin_back
            // 
            this.button_admin_back.Location = new System.Drawing.Point(12, 395);
            this.button_admin_back.Name = "button_admin_back";
            this.button_admin_back.Size = new System.Drawing.Size(75, 23);
            this.button_admin_back.TabIndex = 17;
            this.button_admin_back.Text = "Назад";
            this.button_admin_back.UseVisualStyleBackColor = true;
            this.button_admin_back.Click += new System.EventHandler(this.button_admin_back_Click);
            // 
            // linkLabel_delete_student
            // 
            this.linkLabel_delete_student.AutoSize = true;
            this.linkLabel_delete_student.Location = new System.Drawing.Point(76, 329);
            this.linkLabel_delete_student.Name = "linkLabel_delete_student";
            this.linkLabel_delete_student.Size = new System.Drawing.Size(103, 13);
            this.linkLabel_delete_student.TabIndex = 19;
            this.linkLabel_delete_student.TabStop = true;
            this.linkLabel_delete_student.Text = "Видалити студента";
            this.linkLabel_delete_student.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_delete_student_LinkClicked);
            // 
            // label_vnz
            // 
            this.label_vnz.AutoSize = true;
            this.label_vnz.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_vnz.Location = new System.Drawing.Point(7, 9);
            this.label_vnz.Name = "label_vnz";
            this.label_vnz.Size = new System.Drawing.Size(36, 17);
            this.label_vnz.TabIndex = 24;
            this.label_vnz.Text = "ВНЗ";
            // 
            // label_faculty
            // 
            this.label_faculty.AutoSize = true;
            this.label_faculty.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_faculty.Location = new System.Drawing.Point(7, 26);
            this.label_faculty.Name = "label_faculty";
            this.label_faculty.Size = new System.Drawing.Size(80, 17);
            this.label_faculty.TabIndex = 23;
            this.label_faculty.Text = "Факультет";
            // 
            // label_group
            // 
            this.label_group.AutoSize = true;
            this.label_group.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_group.Location = new System.Drawing.Point(7, 43);
            this.label_group.Name = "label_group";
            this.label_group.Size = new System.Drawing.Size(83, 17);
            this.label_group.TabIndex = 22;
            this.label_group.Text = "Група ВП-3";
            // 
            // Form_admin_edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 430);
            this.Controls.Add(this.label_vnz);
            this.Controls.Add(this.label_faculty);
            this.Controls.Add(this.label_group);
            this.Controls.Add(this.linkLabel_delete_student);
            this.Controls.Add(this.button_admin_back);
            this.Controls.Add(this.dataGridView_student);
            this.Controls.Add(this.linkLabel_exit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form_admin_edit";
            this.Text = "Form_admin_edit";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_admin_edit_FormClosed);
            this.Load += new System.EventHandler(this.Form_admin_edit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_student)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.LinkLabel linkLabel_exit;
        private System.Windows.Forms.DataGridView dataGridView_student;
        private System.Windows.Forms.Button button_admin_back;
        private System.Windows.Forms.LinkLabel linkLabel_delete_student;
        private System.Windows.Forms.Label label_vnz;
        private System.Windows.Forms.Label label_faculty;
        private System.Windows.Forms.Label label_group;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}