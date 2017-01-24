namespace BDKURSACH
{
    partial class Form_authorization
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_authorization));
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.textBox_surname = new System.Windows.Forms.TextBox();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.button_authorization = new System.Windows.Forms.Button();
            this.textBox_login = new System.Windows.Forms.TextBox();
            this.lable_authorization = new System.Windows.Forms.Label();
            this.label_surname = new System.Windows.Forms.Label();
            this.label_name = new System.Windows.Forms.Label();
            this.label_password = new System.Windows.Forms.Label();
            this.label_login = new System.Windows.Forms.Label();
            this.linkLabel_registration = new System.Windows.Forms.LinkLabel();
            this.buton_exit = new System.Windows.Forms.Button();
            this.radioButton_student = new System.Windows.Forms.RadioButton();
            this.radioButton_teacher = new System.Windows.Forms.RadioButton();
            this.label_function = new System.Windows.Forms.Label();
            this.label_vnz = new System.Windows.Forms.Label();
            this.label_faculty = new System.Windows.Forms.Label();
            this.label_group = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // textBox_password
            // 
            resources.ApplyResources(this.textBox_password, "textBox_password");
            this.textBox_password.Name = "textBox_password";
            // 
            // textBox_surname
            // 
            resources.ApplyResources(this.textBox_surname, "textBox_surname");
            this.textBox_surname.Name = "textBox_surname";
            // 
            // textBox_name
            // 
            resources.ApplyResources(this.textBox_name, "textBox_name");
            this.textBox_name.Name = "textBox_name";
            // 
            // button_authorization
            // 
            resources.ApplyResources(this.button_authorization, "button_authorization");
            this.button_authorization.Name = "button_authorization";
            this.button_authorization.UseVisualStyleBackColor = true;
            this.button_authorization.Click += new System.EventHandler(this.button_authorization_Click);
            // 
            // textBox_login
            // 
            resources.ApplyResources(this.textBox_login, "textBox_login");
            this.textBox_login.Name = "textBox_login";
            // 
            // lable_authorization
            // 
            resources.ApplyResources(this.lable_authorization, "lable_authorization");
            this.lable_authorization.Name = "lable_authorization";
            // 
            // label_surname
            // 
            resources.ApplyResources(this.label_surname, "label_surname");
            this.label_surname.Name = "label_surname";
            // 
            // label_name
            // 
            resources.ApplyResources(this.label_name, "label_name");
            this.label_name.Name = "label_name";
            // 
            // label_password
            // 
            resources.ApplyResources(this.label_password, "label_password");
            this.label_password.Name = "label_password";
            // 
            // label_login
            // 
            resources.ApplyResources(this.label_login, "label_login");
            this.label_login.Name = "label_login";
            // 
            // linkLabel_registration
            // 
            resources.ApplyResources(this.linkLabel_registration, "linkLabel_registration");
            this.linkLabel_registration.Name = "linkLabel_registration";
            this.linkLabel_registration.TabStop = true;
            this.linkLabel_registration.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_registration_LinkClicked);
            // 
            // buton_exit
            // 
            resources.ApplyResources(this.buton_exit, "buton_exit");
            this.buton_exit.Name = "buton_exit";
            this.buton_exit.UseVisualStyleBackColor = true;
            this.buton_exit.Click += new System.EventHandler(this.buton_exit_Click);
            // 
            // radioButton_student
            // 
            resources.ApplyResources(this.radioButton_student, "radioButton_student");
            this.radioButton_student.Name = "radioButton_student";
            this.radioButton_student.UseVisualStyleBackColor = true;
            this.radioButton_student.CheckedChanged += new System.EventHandler(this.radioButton_student_CheckedChanged);
            // 
            // radioButton_teacher
            // 
            resources.ApplyResources(this.radioButton_teacher, "radioButton_teacher");
            this.radioButton_teacher.Name = "radioButton_teacher";
            this.radioButton_teacher.UseVisualStyleBackColor = true;
            // 
            // label_function
            // 
            resources.ApplyResources(this.label_function, "label_function");
            this.label_function.Name = "label_function";
            // 
            // label_vnz
            // 
            resources.ApplyResources(this.label_vnz, "label_vnz");
            this.label_vnz.Name = "label_vnz";
            // 
            // label_faculty
            // 
            resources.ApplyResources(this.label_faculty, "label_faculty");
            this.label_faculty.Name = "label_faculty";
            // 
            // label_group
            // 
            resources.ApplyResources(this.label_group, "label_group");
            this.label_group.Name = "label_group";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            resources.ApplyResources(this.comboBox1, "comboBox1");
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            resources.ApplyResources(this.comboBox2, "comboBox2");
            this.comboBox2.Name = "comboBox2";
            // 
            // comboBox3
            // 
            this.comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox3.FormattingEnabled = true;
            resources.ApplyResources(this.comboBox3, "comboBox3");
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // Form_authorization
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label_group);
            this.Controls.Add(this.label_faculty);
            this.Controls.Add(this.label_vnz);
            this.Controls.Add(this.label_function);
            this.Controls.Add(this.radioButton_teacher);
            this.Controls.Add(this.radioButton_student);
            this.Controls.Add(this.buton_exit);
            this.Controls.Add(this.linkLabel_registration);
            this.Controls.Add(this.textBox_password);
            this.Controls.Add(this.textBox_surname);
            this.Controls.Add(this.textBox_name);
            this.Controls.Add(this.button_authorization);
            this.Controls.Add(this.textBox_login);
            this.Controls.Add(this.lable_authorization);
            this.Controls.Add(this.label_surname);
            this.Controls.Add(this.label_name);
            this.Controls.Add(this.label_password);
            this.Controls.Add(this.label_login);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form_authorization";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_authorization_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

       

        #endregion

        private System.Windows.Forms.TextBox textBox_password;
        private System.Windows.Forms.TextBox textBox_surname;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.Button button_authorization;
        private System.Windows.Forms.TextBox textBox_login;
        private System.Windows.Forms.Label lable_authorization;
        private System.Windows.Forms.Label label_surname;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.Label label_password;
        private System.Windows.Forms.Label label_login;
        private System.Windows.Forms.LinkLabel linkLabel_registration;
        private System.Windows.Forms.Button buton_exit;
        private System.Windows.Forms.RadioButton radioButton_student;
        private System.Windows.Forms.RadioButton radioButton_teacher;
        private System.Windows.Forms.Label label_function;
        private System.Windows.Forms.Label label_vnz;
        private System.Windows.Forms.Label label_faculty;
        private System.Windows.Forms.Label label_group;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;

    }
}

