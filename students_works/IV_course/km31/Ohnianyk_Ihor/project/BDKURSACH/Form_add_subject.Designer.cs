namespace BDKURSACH
{
    partial class Form_add_subject
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
            this.linkLabel_exit = new System.Windows.Forms.LinkLabel();
            this.button_abolition = new System.Windows.Forms.Button();
            this.button_add = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label_group_name = new System.Windows.Forms.Label();
            this.label_faculty_name = new System.Windows.Forms.Label();
            this.label_vnz_name = new System.Windows.Forms.Label();
            this.label_subject = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label_name_student
            // 
            this.label_name_student.AutoSize = true;
            this.label_name_student.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_name_student.Location = new System.Drawing.Point(12, 9);
            this.label_name_student.Name = "label_name_student";
            this.label_name_student.Size = new System.Drawing.Size(189, 22);
            this.label_name_student.TabIndex = 9;
            this.label_name_student.Text = "Ім\'я прізвище виклад";
            this.label_name_student.Click += new System.EventHandler(this.label_name_student_Click);
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
            // button_abolition
            // 
            this.button_abolition.Location = new System.Drawing.Point(12, 395);
            this.button_abolition.Name = "button_abolition";
            this.button_abolition.Size = new System.Drawing.Size(75, 23);
            this.button_abolition.TabIndex = 27;
            this.button_abolition.Text = "Відміна";
            this.button_abolition.UseVisualStyleBackColor = true;
            this.button_abolition.Click += new System.EventHandler(this.button_abolition_Click);
            // 
            // button_add
            // 
            this.button_add.Location = new System.Drawing.Point(409, 395);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(75, 23);
            this.button_add.TabIndex = 26;
            this.button_add.Text = "Додати";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(129, 183);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 29;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // comboBox3
            // 
            this.comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(129, 280);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 21);
            this.comboBox3.TabIndex = 35;
            this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(129, 102);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 34;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label_group_name
            // 
            this.label_group_name.AutoSize = true;
            this.label_group_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_group_name.Location = new System.Drawing.Point(23, 284);
            this.label_group_name.Name = "label_group_name";
            this.label_group_name.Size = new System.Drawing.Size(47, 17);
            this.label_group_name.TabIndex = 32;
            this.label_group_name.Text = "Група";
            // 
            // label_faculty_name
            // 
            this.label_faculty_name.AutoSize = true;
            this.label_faculty_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_faculty_name.Location = new System.Drawing.Point(23, 184);
            this.label_faculty_name.Name = "label_faculty_name";
            this.label_faculty_name.Size = new System.Drawing.Size(80, 17);
            this.label_faculty_name.TabIndex = 31;
            this.label_faculty_name.Text = "Факультет";
            // 
            // label_vnz_name
            // 
            this.label_vnz_name.AutoSize = true;
            this.label_vnz_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_vnz_name.Location = new System.Drawing.Point(23, 102);
            this.label_vnz_name.Name = "label_vnz_name";
            this.label_vnz_name.Size = new System.Drawing.Size(36, 17);
            this.label_vnz_name.TabIndex = 30;
            this.label_vnz_name.Text = "ВНЗ";
            // 
            // label_subject
            // 
            this.label_subject.AutoSize = true;
            this.label_subject.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_subject.Location = new System.Drawing.Point(279, 184);
            this.label_subject.Name = "label_subject";
            this.label_subject.Size = new System.Drawing.Size(66, 17);
            this.label_subject.TabIndex = 36;
            this.label_subject.Text = "Предмет";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(351, 184);
            this.textBox1.MaxLength = 20;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 20);
            this.textBox1.TabIndex = 38;
            // 
            // Form_add_subject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 430);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label_subject);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label_group_name);
            this.Controls.Add(this.label_faculty_name);
            this.Controls.Add(this.label_vnz_name);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.button_abolition);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.linkLabel_exit);
            this.Controls.Add(this.label_name_student);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form_add_subject";
            this.Text = "Form_add_subject";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_add_subject_FormClosed);
            this.Load += new System.EventHandler(this.Form_add_subject_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_name_student;
        protected System.Windows.Forms.LinkLabel linkLabel_exit;
        private System.Windows.Forms.Button button_abolition;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label_group_name;
        private System.Windows.Forms.Label label_faculty_name;
        private System.Windows.Forms.Label label_vnz_name;
        private System.Windows.Forms.Label label_subject;
        private System.Windows.Forms.TextBox textBox1;
    }
}