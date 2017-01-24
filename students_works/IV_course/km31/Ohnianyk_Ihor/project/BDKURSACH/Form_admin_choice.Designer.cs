namespace BDKURSACH
{
    partial class Form_admin_choice
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
            this.label_vnz_name = new System.Windows.Forms.Label();
            this.label_faculty_name = new System.Windows.Forms.Label();
            this.label_group_name = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.button_admin_next = new System.Windows.Forms.Button();
            this.linkLabel_add_vnz = new System.Windows.Forms.LinkLabel();
            this.linkLabel_delete_vnz = new System.Windows.Forms.LinkLabel();
            this.linkLabel_add_faculty = new System.Windows.Forms.LinkLabel();
            this.linkLabel_delete_faculty = new System.Windows.Forms.LinkLabel();
            this.linkLabel_add_group = new System.Windows.Forms.LinkLabel();
            this.linkLabel_delete_group = new System.Windows.Forms.LinkLabel();
            this.linkLabel_exit = new System.Windows.Forms.LinkLabel();
            this.button_abolition = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_vnz_name
            // 
            this.label_vnz_name.AutoSize = true;
            this.label_vnz_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_vnz_name.Location = new System.Drawing.Point(74, 104);
            this.label_vnz_name.Name = "label_vnz_name";
            this.label_vnz_name.Size = new System.Drawing.Size(36, 17);
            this.label_vnz_name.TabIndex = 0;
            this.label_vnz_name.Text = "ВНЗ";
            this.label_vnz_name.Click += new System.EventHandler(this.label_vnz_name_Click);
            // 
            // label_faculty_name
            // 
            this.label_faculty_name.AutoSize = true;
            this.label_faculty_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_faculty_name.Location = new System.Drawing.Point(74, 186);
            this.label_faculty_name.Name = "label_faculty_name";
            this.label_faculty_name.Size = new System.Drawing.Size(80, 17);
            this.label_faculty_name.TabIndex = 1;
            this.label_faculty_name.Text = "Факультет";
            // 
            // label_group_name
            // 
            this.label_group_name.AutoSize = true;
            this.label_group_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_group_name.Location = new System.Drawing.Point(74, 286);
            this.label_group_name.Name = "label_group_name";
            this.label_group_name.Size = new System.Drawing.Size(47, 17);
            this.label_group_name.TabIndex = 2;
            this.label_group_name.Text = "Група";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(12, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Адмін";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(218, 100);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(218, 186);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 5;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // comboBox3
            // 
            this.comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(218, 282);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 21);
            this.comboBox3.TabIndex = 6;
            this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // button_admin_next
            // 
            this.button_admin_next.Location = new System.Drawing.Point(409, 395);
            this.button_admin_next.Name = "button_admin_next";
            this.button_admin_next.Size = new System.Drawing.Size(75, 23);
            this.button_admin_next.TabIndex = 7;
            this.button_admin_next.Text = "Далі";
            this.button_admin_next.UseVisualStyleBackColor = true;
            this.button_admin_next.Click += new System.EventHandler(this.button_admin_next_Click);
            // 
            // linkLabel_add_vnz
            // 
            this.linkLabel_add_vnz.AutoSize = true;
            this.linkLabel_add_vnz.Location = new System.Drawing.Point(215, 157);
            this.linkLabel_add_vnz.Name = "linkLabel_add_vnz";
            this.linkLabel_add_vnz.Size = new System.Drawing.Size(70, 13);
            this.linkLabel_add_vnz.TabIndex = 8;
            this.linkLabel_add_vnz.TabStop = true;
            this.linkLabel_add_vnz.Text = "Додати ВНЗ";
            this.linkLabel_add_vnz.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_add_vnz_LinkClicked);
            // 
            // linkLabel_delete_vnz
            // 
            this.linkLabel_delete_vnz.AutoSize = true;
            this.linkLabel_delete_vnz.Location = new System.Drawing.Point(215, 133);
            this.linkLabel_delete_vnz.Name = "linkLabel_delete_vnz";
            this.linkLabel_delete_vnz.Size = new System.Drawing.Size(80, 13);
            this.linkLabel_delete_vnz.TabIndex = 9;
            this.linkLabel_delete_vnz.TabStop = true;
            this.linkLabel_delete_vnz.Text = "Видалити ВНЗ";
            this.linkLabel_delete_vnz.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_delete_vnz_LinkClicked);
            // 
            // linkLabel_add_faculty
            // 
            this.linkLabel_add_faculty.AutoSize = true;
            this.linkLabel_add_faculty.Location = new System.Drawing.Point(215, 241);
            this.linkLabel_add_faculty.Name = "linkLabel_add_faculty";
            this.linkLabel_add_faculty.Size = new System.Drawing.Size(101, 13);
            this.linkLabel_add_faculty.TabIndex = 10;
            this.linkLabel_add_faculty.TabStop = true;
            this.linkLabel_add_faculty.Text = "Додати факультет";
            this.linkLabel_add_faculty.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_add_faculty_LinkClicked);
            // 
            // linkLabel_delete_faculty
            // 
            this.linkLabel_delete_faculty.AutoSize = true;
            this.linkLabel_delete_faculty.Location = new System.Drawing.Point(215, 219);
            this.linkLabel_delete_faculty.Name = "linkLabel_delete_faculty";
            this.linkLabel_delete_faculty.Size = new System.Drawing.Size(111, 13);
            this.linkLabel_delete_faculty.TabIndex = 11;
            this.linkLabel_delete_faculty.TabStop = true;
            this.linkLabel_delete_faculty.Text = "Видалити факультет";
            this.linkLabel_delete_faculty.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_delete_faculty_LinkClicked);
            // 
            // linkLabel_add_group
            // 
            this.linkLabel_add_group.AutoSize = true;
            this.linkLabel_add_group.Location = new System.Drawing.Point(215, 337);
            this.linkLabel_add_group.Name = "linkLabel_add_group";
            this.linkLabel_add_group.Size = new System.Drawing.Size(78, 13);
            this.linkLabel_add_group.TabIndex = 12;
            this.linkLabel_add_group.TabStop = true;
            this.linkLabel_add_group.Text = " Додати групу";
            this.linkLabel_add_group.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_add_group_LinkClicked);
            // 
            // linkLabel_delete_group
            // 
            this.linkLabel_delete_group.AutoSize = true;
            this.linkLabel_delete_group.Location = new System.Drawing.Point(215, 315);
            this.linkLabel_delete_group.Name = "linkLabel_delete_group";
            this.linkLabel_delete_group.Size = new System.Drawing.Size(85, 13);
            this.linkLabel_delete_group.TabIndex = 13;
            this.linkLabel_delete_group.TabStop = true;
            this.linkLabel_delete_group.Text = "Видалити групу";
            this.linkLabel_delete_group.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_delete_group_LinkClicked);
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
            this.button_abolition.TabIndex = 20;
            this.button_abolition.Text = "Відміна";
            this.button_abolition.UseVisualStyleBackColor = true;
            this.button_abolition.Click += new System.EventHandler(this.button_abolition_Click);
            // 
            // Form_admin_choice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 430);
            this.Controls.Add(this.button_abolition);
            this.Controls.Add(this.linkLabel_exit);
            this.Controls.Add(this.linkLabel_delete_group);
            this.Controls.Add(this.linkLabel_add_group);
            this.Controls.Add(this.linkLabel_delete_faculty);
            this.Controls.Add(this.linkLabel_add_faculty);
            this.Controls.Add(this.linkLabel_delete_vnz);
            this.Controls.Add(this.linkLabel_add_vnz);
            this.Controls.Add(this.button_admin_next);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label_group_name);
            this.Controls.Add(this.label_faculty_name);
            this.Controls.Add(this.label_vnz_name);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form_admin_choice";
            this.Text = "Form2";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_admin_choice_FormClosed);
            this.Load += new System.EventHandler(this.Form_admin_choice_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_vnz_name;
        private System.Windows.Forms.Label label_faculty_name;
        private System.Windows.Forms.Label label_group_name;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Button button_admin_next;
        private System.Windows.Forms.LinkLabel linkLabel_add_vnz;
        private System.Windows.Forms.LinkLabel linkLabel_delete_vnz;
        private System.Windows.Forms.LinkLabel linkLabel_add_faculty;
        private System.Windows.Forms.LinkLabel linkLabel_delete_faculty;
        private System.Windows.Forms.LinkLabel linkLabel_add_group;
        private System.Windows.Forms.LinkLabel linkLabel_delete_group;
        protected System.Windows.Forms.LinkLabel linkLabel_exit;
        private System.Windows.Forms.Button button_abolition;

    }
}