
namespace WindowsFormsApp1
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
            this.userGroup = new System.Windows.Forms.GroupBox();
            this.birthdayLbl = new System.Windows.Forms.Label();
            this.nameLbl = new System.Windows.Forms.Label();
            this.phoneLbl = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.emailLbl = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.surenameLbl = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.changeLbl = new System.Windows.Forms.Button();
            this.addLbl = new System.Windows.Forms.Button();
            this.List = new System.Windows.Forms.ListBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.loadLbl = new System.Windows.Forms.Button();
            this.saveLbl = new System.Windows.Forms.Button();
            this.userGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // userGroup
            // 
            this.userGroup.BackColor = System.Drawing.Color.ForestGreen;
            this.userGroup.Controls.Add(this.addLbl);
            this.userGroup.Controls.Add(this.birthdayLbl);
            this.userGroup.Controls.Add(this.changeLbl);
            this.userGroup.Controls.Add(this.nameLbl);
            this.userGroup.Controls.Add(this.phoneLbl);
            this.userGroup.Controls.Add(this.dateTimePicker1);
            this.userGroup.Controls.Add(this.emailLbl);
            this.userGroup.Controls.Add(this.textBox4);
            this.userGroup.Controls.Add(this.surenameLbl);
            this.userGroup.Controls.Add(this.textBox2);
            this.userGroup.Controls.Add(this.textBox3);
            this.userGroup.Controls.Add(this.textBox1);
            this.userGroup.Location = new System.Drawing.Point(12, 12);
            this.userGroup.Name = "userGroup";
            this.userGroup.Size = new System.Drawing.Size(361, 241);
            this.userGroup.TabIndex = 0;
            this.userGroup.TabStop = false;
            this.userGroup.Text = "Anket";
            // 
            // birthdayLbl
            // 
            this.birthdayLbl.AutoSize = true;
            this.birthdayLbl.BackColor = System.Drawing.Color.Transparent;
            this.birthdayLbl.Location = new System.Drawing.Point(15, 144);
            this.birthdayLbl.Name = "birthdayLbl";
            this.birthdayLbl.Size = new System.Drawing.Size(41, 13);
            this.birthdayLbl.TabIndex = 4;
            this.birthdayLbl.Text = "Dogum";
            // 
            // nameLbl
            // 
            this.nameLbl.AutoSize = true;
            this.nameLbl.BackColor = System.Drawing.Color.Transparent;
            this.nameLbl.Location = new System.Drawing.Point(15, 40);
            this.nameLbl.Name = "nameLbl";
            this.nameLbl.Size = new System.Drawing.Size(20, 13);
            this.nameLbl.TabIndex = 6;
            this.nameLbl.Text = "Ad";
            // 
            // phoneLbl
            // 
            this.phoneLbl.AutoSize = true;
            this.phoneLbl.BackColor = System.Drawing.Color.Transparent;
            this.phoneLbl.ForeColor = System.Drawing.SystemColors.Desktop;
            this.phoneLbl.Location = new System.Drawing.Point(15, 118);
            this.phoneLbl.Name = "phoneLbl";
            this.phoneLbl.Size = new System.Drawing.Size(22, 13);
            this.phoneLbl.TabIndex = 3;
            this.phoneLbl.Text = "Tel";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarMonthBackground = System.Drawing.SystemColors.ActiveCaption;
            this.dateTimePicker1.Location = new System.Drawing.Point(81, 137);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(258, 20);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // emailLbl
            // 
            this.emailLbl.AutoSize = true;
            this.emailLbl.BackColor = System.Drawing.Color.Transparent;
            this.emailLbl.Location = new System.Drawing.Point(15, 88);
            this.emailLbl.Name = "emailLbl";
            this.emailLbl.Size = new System.Drawing.Size(32, 13);
            this.emailLbl.TabIndex = 2;
            this.emailLbl.Text = "Email";
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.SystemColors.HighlightText;
            this.textBox4.Location = new System.Drawing.Point(81, 111);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(258, 20);
            this.textBox4.TabIndex = 5;
            // 
            // surenameLbl
            // 
            this.surenameLbl.AutoSize = true;
            this.surenameLbl.BackColor = System.Drawing.Color.Transparent;
            this.surenameLbl.Location = new System.Drawing.Point(15, 66);
            this.surenameLbl.Name = "surenameLbl";
            this.surenameLbl.Size = new System.Drawing.Size(37, 13);
            this.surenameLbl.TabIndex = 1;
            this.surenameLbl.Text = "Soyad";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.HighlightText;
            this.textBox2.Location = new System.Drawing.Point(81, 33);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(258, 20);
            this.textBox2.TabIndex = 3;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.HighlightText;
            this.textBox3.Location = new System.Drawing.Point(81, 85);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(258, 20);
            this.textBox3.TabIndex = 4;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.textBox1.Location = new System.Drawing.Point(81, 59);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(258, 20);
            this.textBox1.TabIndex = 2;
            // 
            // changeLbl
            // 
            this.changeLbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.changeLbl.Location = new System.Drawing.Point(264, 180);
            this.changeLbl.Name = "changeLbl";
            this.changeLbl.Size = new System.Drawing.Size(75, 23);
            this.changeLbl.TabIndex = 1;
            this.changeLbl.Text = "Deyis";
            this.changeLbl.UseVisualStyleBackColor = false;
            // 
            // addLbl
            // 
            this.addLbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.addLbl.Location = new System.Drawing.Point(264, 209);
            this.addLbl.Name = "addLbl";
            this.addLbl.Size = new System.Drawing.Size(75, 23);
            this.addLbl.TabIndex = 2;
            this.addLbl.Text = "Elave et";
            this.addLbl.UseVisualStyleBackColor = false;
            // 
            // List
            // 
            this.List.BackColor = System.Drawing.Color.ForestGreen;
            this.List.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.List.FormattingEnabled = true;
            this.List.Location = new System.Drawing.Point(396, 12);
            this.List.Name = "List";
            this.List.Size = new System.Drawing.Size(156, 169);
            this.List.TabIndex = 1;
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.SystemColors.HighlightText;
            this.textBox5.Location = new System.Drawing.Point(396, 192);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(156, 20);
            this.textBox5.TabIndex = 2;
            // 
            // loadLbl
            // 
            this.loadLbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.loadLbl.Location = new System.Drawing.Point(396, 218);
            this.loadLbl.Name = "loadLbl";
            this.loadLbl.Size = new System.Drawing.Size(75, 23);
            this.loadLbl.TabIndex = 3;
            this.loadLbl.Text = "Load";
            this.loadLbl.UseVisualStyleBackColor = false;
            // 
            // saveLbl
            // 
            this.saveLbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.saveLbl.Location = new System.Drawing.Point(477, 218);
            this.saveLbl.Name = "saveLbl";
            this.saveLbl.Size = new System.Drawing.Size(75, 23);
            this.saveLbl.TabIndex = 4;
            this.saveLbl.Text = "Save";
            this.saveLbl.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGreen;
            this.ClientSize = new System.Drawing.Size(719, 422);
            this.Controls.Add(this.saveLbl);
            this.Controls.Add(this.loadLbl);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.List);
            this.Controls.Add(this.userGroup);
            this.Name = "Form1";
            this.Text = "Form1";
            this.userGroup.ResumeLayout(false);
            this.userGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox userGroup;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label nameLbl;
        private System.Windows.Forms.Label surenameLbl;
        private System.Windows.Forms.Label emailLbl;
        private System.Windows.Forms.Label phoneLbl;
        private System.Windows.Forms.Label birthdayLbl;
        private System.Windows.Forms.Button changeLbl;
        private System.Windows.Forms.Button addLbl;
        private System.Windows.Forms.ListBox List;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button loadLbl;
        private System.Windows.Forms.Button saveLbl;
    }
}

