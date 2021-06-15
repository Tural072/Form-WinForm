using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form : System.Windows.Forms.Form
    {
        public Form()
        {
            InitializeComponent();
        }
        bool IsClicked=false;
        private void Form1_Load(object sender, EventArgs e)
        {
            List.DisplayMember = "Name";
            List.Items.Add(new Human
            {
                Name = nameTxtbx.Text,
                Surname = surenameTxtbx.Text,
                Birthday = dateTimePicker1.Value,
                Email = emailTxtbx.Text,
                Phone = phoneTxtbx.Text
            });
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            if (!IsClicked)
            {
                addBtn.Location = new Point(351, 218);
                changeBtn.Location = new Point(351, 254);
                IsClicked = true;
            }
            else
            {
                changeBtn.Location = new Point(351, 218);
                addBtn.Location = new Point(351, 254);
                IsClicked = false;
            }
            List.DisplayMember = "Name";
            List.Items.Add(new Human
            {
                Name = nameTxtbx.Text,
                Surname = surenameTxtbx.Text,
                Birthday = dateTimePicker1.Value,
                Email = emailTxtbx.Text,
                Phone = phoneTxtbx.Text
            });
            nameTxtbx.Text = string.Empty;
            surenameTxtbx.Text = string.Empty;
            emailTxtbx.Text = string.Empty;
            phoneTxtbx.Text = string.Empty;
            dateTimePicker1.Value = DateTime.Now;
        }

        private void loadBtn_Click(object sender, EventArgs e)
        {
            foreach (var item in List.SelectedItems)
            {
                var human = item as Human;
                if (File.Exists(jsonTxtbx.Text))
                {
                    HelperJson.JSONDeSerialization(ref human, jsonTxtbx.Text);
                }
                nameTxtbx.Text = human.Name;
                surenameTxtbx.Text = human.Surname;
                emailTxtbx.Text = human.Email;
                phoneTxtbx.Text = human.Phone;
                dateTimePicker1.Value = human.Birthday;
            }
        }

        private void List_SelectedIndexChanged(object sender, EventArgs e)
        {
            StringBuilder stringBuilder = new StringBuilder();
            foreach (var item in List.SelectedItems)
            {
                var human = item as Human;
                stringBuilder.Append($"{human.Name}");
            }
            stringBuilder.Append(".json");
            jsonTxtbx.Text = stringBuilder.ToString();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            foreach (var item in List.SelectedItems)
            {
                var human = item as Human;
                HelperJson.JSONSerialization(human, jsonTxtbx.Text);
            }
        }

        private void changeBtn_Click(object sender, EventArgs e)
        {
            if (IsClicked)
            {
                changeBtn.Location = new Point(351, 218);
                addBtn.Location = new Point(351, 254);
                IsClicked = false;
            }
            else
            {
                addBtn.Location = new Point(351, 218);
                changeBtn.Location = new Point(351, 254);
                IsClicked = true;
            }
            foreach (var item in List.SelectedItems)
            {
                var human = item as Human;
                human.Name = nameTxtbx.Text;
                human.Surname = surenameTxtbx.Text;
                human.Birthday = dateTimePicker1.Value;
                human.Email = emailTxtbx.Text;
                human.Phone = phoneTxtbx.Text;
            }
        }
    }
}
