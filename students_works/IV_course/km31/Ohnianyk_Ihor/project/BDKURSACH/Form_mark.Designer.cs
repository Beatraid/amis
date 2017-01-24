namespace BDKURSACH
{
    partial class Form_mark
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
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label_mark = new System.Windows.Forms.Label();
            this.button_exit = new System.Windows.Forms.Button();
            this.button_next = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(87, 25);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 0;
            // 
            // label_mark
            // 
            this.label_mark.AutoSize = true;
            this.label_mark.Location = new System.Drawing.Point(22, 27);
            this.label_mark.Name = "label_mark";
            this.label_mark.Size = new System.Drawing.Size(41, 13);
            this.label_mark.TabIndex = 1;
            this.label_mark.Text = "Оцінка";
            // 
            // button_exit
            // 
            this.button_exit.Location = new System.Drawing.Point(12, 67);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(75, 23);
            this.button_exit.TabIndex = 2;
            this.button_exit.Text = "Назад";
            this.button_exit.UseVisualStyleBackColor = true;
            this.button_exit.Click += new System.EventHandler(this.button_exit_Click);
            // 
            // button_next
            // 
            this.button_next.Location = new System.Drawing.Point(151, 67);
            this.button_next.Name = "button_next";
            this.button_next.Size = new System.Drawing.Size(75, 23);
            this.button_next.TabIndex = 3;
            this.button_next.Text = "Зберегти";
            this.button_next.UseVisualStyleBackColor = true;
            this.button_next.Click += new System.EventHandler(this.button_next_Click);
            // 
            // Form_mark
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(238, 102);
            this.Controls.Add(this.button_next);
            this.Controls.Add(this.button_exit);
            this.Controls.Add(this.label_mark);
            this.Controls.Add(this.numericUpDown1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form_mark";
            this.Text = "Form_mark";
            this.Load += new System.EventHandler(this.Form_mark_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label_mark;
        private System.Windows.Forms.Button button_exit;
        private System.Windows.Forms.Button button_next;
    }
}