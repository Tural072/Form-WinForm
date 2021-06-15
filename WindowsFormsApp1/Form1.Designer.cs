
namespace WindowsFormsApp1
{
    partial class Form
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
            this.addBtn = new System.Windows.Forms.Button();
            this.birthdayLbl = new System.Windows.Forms.Label();
            this.changeBtn = new System.Windows.Forms.Button();
            this.nameLbl = new System.Windows.Forms.Label();
            this.phoneLbl = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.emailLbl = new System.Windows.Forms.Label();
            this.phoneTxtbx = new System.Windows.Forms.TextBox();
            this.surenameLbl = new System.Windows.Forms.Label();
            this.nameTxtbx = new System.Windows.Forms.TextBox();
            this.emailTxtbx = new System.Windows.Forms.TextBox();
            this.surenameTxtbx = new System.Windows.Forms.TextBox();
            this.List = new System.Windows.Forms.ListBox();
            this.jsonTxtbx = new System.Windows.Forms.TextBox();
            this.loadBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.userGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // userGroup
            // 
            this.userGroup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(73)))), ((int)(((byte)(115)))));
            this.userGroup.Controls.Add(this.addBtn);
            this.userGroup.Controls.Add(this.birthdayLbl);
            this.userGroup.Controls.Add(this.changeBtn);
            this.userGroup.Controls.Add(this.nameLbl);
            this.userGroup.Controls.Add(this.phoneLbl);
            this.userGroup.Controls.Add(this.dateTimePicker1);
            this.userGroup.Controls.Add(this.emailLbl);
            this.userGroup.Controls.Add(this.phoneTxtbx);
            this.userGroup.Controls.Add(this.surenameLbl);
            this.userGroup.Controls.Add(this.nameTxtbx);
            this.userGroup.Controls.Add(this.emailTxtbx);
            this.userGroup.Controls.Add(this.surenameTxtbx);
            this.userGroup.Location = new System.Drawing.Point(16, 15);
            this.userGroup.Margin = new System.Windows.Forms.Padding(4);
            this.userGroup.Name = "userGroup";
            this.userGroup.Padding = new System.Windows.Forms.Padding(4);
            this.userGroup.Size = new System.Drawing.Size(682, 385);
            this.userGroup.TabIndex = 0;
            this.userGroup.TabStop = false;
            this.userGroup.Text = "Anket";
            // 
            // addBtn
            // 
            this.addBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(218)))), ((int)(((byte)(196)))));
            this.addBtn.Location = new System.Drawing.Point(351, 254);
            this.addBtn.Margin = new System.Windows.Forms.Padding(4);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(100, 28);
            this.addBtn.TabIndex = 2;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = false;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // birthdayLbl
            // 
            this.birthdayLbl.AutoSize = true;
            this.birthdayLbl.BackColor = System.Drawing.Color.Transparent;
            this.birthdayLbl.Location = new System.Drawing.Point(20, 177);
            this.birthdayLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.birthdayLbl.Name = "birthdayLbl";
            this.birthdayLbl.Size = new System.Drawing.Size(53, 17);
            this.birthdayLbl.TabIndex = 4;
            this.birthdayLbl.Text = "Dogum";
            // 
            // changeBtn
            // 
            this.changeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(218)))), ((int)(((byte)(196)))));
            this.changeBtn.Location = new System.Drawing.Point(351, 218);
            this.changeBtn.Margin = new System.Windows.Forms.Padding(4);
            this.changeBtn.Name = "changeBtn";
            this.changeBtn.Size = new System.Drawing.Size(100, 28);
            this.changeBtn.TabIndex = 1;
            this.changeBtn.Text = "Replace";
            this.changeBtn.UseVisualStyleBackColor = false;
            this.changeBtn.Click += new System.EventHandler(this.changeBtn_Click);
            // 
            // nameLbl
            // 
            this.nameLbl.AutoSize = true;
            this.nameLbl.BackColor = System.Drawing.Color.Transparent;
            this.nameLbl.Location = new System.Drawing.Point(20, 49);
            this.nameLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nameLbl.Name = "nameLbl";
            this.nameLbl.Size = new System.Drawing.Size(25, 17);
            this.nameLbl.TabIndex = 6;
            this.nameLbl.Text = "Ad";
            // 
            // phoneLbl
            // 
            this.phoneLbl.AutoSize = true;
            this.phoneLbl.BackColor = System.Drawing.Color.Transparent;
            this.phoneLbl.ForeColor = System.Drawing.SystemColors.Desktop;
            this.phoneLbl.Location = new System.Drawing.Point(20, 145);
            this.phoneLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.phoneLbl.Name = "phoneLbl";
            this.phoneLbl.Size = new System.Drawing.Size(28, 17);
            this.phoneLbl.TabIndex = 3;
            this.phoneLbl.Text = "Tel";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarMonthBackground = System.Drawing.SystemColors.ActiveCaption;
            this.dateTimePicker1.Location = new System.Drawing.Point(108, 169);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(343, 22);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // emailLbl
            // 
            this.emailLbl.AutoSize = true;
            this.emailLbl.BackColor = System.Drawing.Color.Transparent;
            this.emailLbl.Location = new System.Drawing.Point(20, 108);
            this.emailLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.emailLbl.Name = "emailLbl";
            this.emailLbl.Size = new System.Drawing.Size(42, 17);
            this.emailLbl.TabIndex = 2;
            this.emailLbl.Text = "Email";
            // 
            // phoneTxtbx
            // 
            this.phoneTxtbx.BackColor = System.Drawing.SystemColors.HighlightText;
            this.phoneTxtbx.Location = new System.Drawing.Point(108, 137);
            this.phoneTxtbx.Margin = new System.Windows.Forms.Padding(4);
            this.phoneTxtbx.Name = "phoneTxtbx";
            this.phoneTxtbx.Size = new System.Drawing.Size(343, 22);
            this.phoneTxtbx.TabIndex = 5;
            // 
            // surenameLbl
            // 
            this.surenameLbl.AutoSize = true;
            this.surenameLbl.BackColor = System.Drawing.Color.Transparent;
            this.surenameLbl.Location = new System.Drawing.Point(20, 81);
            this.surenameLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.surenameLbl.Name = "surenameLbl";
            this.surenameLbl.Size = new System.Drawing.Size(48, 17);
            this.surenameLbl.TabIndex = 1;
            this.surenameLbl.Text = "Soyad";
            // 
            // nameTxtbx
            // 
            this.nameTxtbx.BackColor = System.Drawing.SystemColors.HighlightText;
            this.nameTxtbx.Location = new System.Drawing.Point(108, 41);
            this.nameTxtbx.Margin = new System.Windows.Forms.Padding(4);
            this.nameTxtbx.Name = "nameTxtbx";
            this.nameTxtbx.Size = new System.Drawing.Size(343, 22);
            this.nameTxtbx.TabIndex = 3;
            // 
            // emailTxtbx
            // 
            this.emailTxtbx.BackColor = System.Drawing.SystemColors.HighlightText;
            this.emailTxtbx.Location = new System.Drawing.Point(108, 105);
            this.emailTxtbx.Margin = new System.Windows.Forms.Padding(4);
            this.emailTxtbx.Name = "emailTxtbx";
            this.emailTxtbx.Size = new System.Drawing.Size(343, 22);
            this.emailTxtbx.TabIndex = 4;
            // 
            // surenameTxtbx
            // 
            this.surenameTxtbx.BackColor = System.Drawing.SystemColors.HighlightText;
            this.surenameTxtbx.Location = new System.Drawing.Point(108, 73);
            this.surenameTxtbx.Margin = new System.Windows.Forms.Padding(4);
            this.surenameTxtbx.Name = "surenameTxtbx";
            this.surenameTxtbx.Size = new System.Drawing.Size(343, 22);
            this.surenameTxtbx.TabIndex = 2;
            // 
            // List
            // 
            this.List.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(73)))), ((int)(((byte)(115)))));
            this.List.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.List.FormattingEnabled = true;
            this.List.ItemHeight = 16;
            this.List.Location = new System.Drawing.Point(528, 15);
            this.List.Margin = new System.Windows.Forms.Padding(4);
            this.List.Name = "List";
            this.List.Size = new System.Drawing.Size(208, 208);
            this.List.TabIndex = 1;
            this.List.SelectedIndexChanged += new System.EventHandler(this.List_SelectedIndexChanged);
            // 
            // jsonTxtbx
            // 
            this.jsonTxtbx.BackColor = System.Drawing.SystemColors.HighlightText;
            this.jsonTxtbx.Location = new System.Drawing.Point(528, 236);
            this.jsonTxtbx.Margin = new System.Windows.Forms.Padding(4);
            this.jsonTxtbx.Name = "jsonTxtbx";
            this.jsonTxtbx.Size = new System.Drawing.Size(207, 22);
            this.jsonTxtbx.TabIndex = 2;
            // 
            // loadBtn
            // 
            this.loadBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(218)))), ((int)(((byte)(196)))));
            this.loadBtn.Location = new System.Drawing.Point(528, 268);
            this.loadBtn.Margin = new System.Windows.Forms.Padding(4);
            this.loadBtn.Name = "loadBtn";
            this.loadBtn.Size = new System.Drawing.Size(100, 28);
            this.loadBtn.TabIndex = 3;
            this.loadBtn.Text = "Load";
            this.loadBtn.UseVisualStyleBackColor = false;
            this.loadBtn.Click += new System.EventHandler(this.loadBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(218)))), ((int)(((byte)(196)))));
            this.saveBtn.Location = new System.Drawing.Point(636, 268);
            this.saveBtn.Margin = new System.Windows.Forms.Padding(4);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(100, 28);
            this.saveBtn.TabIndex = 4;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = false;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(27)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(798, 442);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.loadBtn);
            this.Controls.Add(this.jsonTxtbx);
            this.Controls.Add(this.List);
            this.Controls.Add(this.userGroup);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.userGroup.ResumeLayout(false);
            this.userGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox userGroup;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox phoneTxtbx;
        private System.Windows.Forms.TextBox nameTxtbx;
        private System.Windows.Forms.TextBox emailTxtbx;
        private System.Windows.Forms.TextBox surenameTxtbx;
        private System.Windows.Forms.Label nameLbl;
        private System.Windows.Forms.Label surenameLbl;
        private System.Windows.Forms.Label emailLbl;
        private System.Windows.Forms.Label phoneLbl;
        private System.Windows.Forms.Label birthdayLbl;
        private System.Windows.Forms.Button changeBtn;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.ListBox List;
        private System.Windows.Forms.TextBox jsonTxtbx;
        private System.Windows.Forms.Button loadBtn;
        private System.Windows.Forms.Button saveBtn;
    }
}

