using DataLib;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SQLDev
{
    public partial class UserLogin : Form
    {
        public UserLogin()
        {
            InitializeComponent();
            try
            {
                using (StreamReader sr = new StreamReader(ConfigurationManager.ConnectionStrings["Students"].ConnectionString))
                {
                    String line = sr.ReadToEnd();
                    var groupList = JsonConvert.DeserializeObject<List<GroupControl>>(line);
                    foreach (var group in groupList)
                    {
                        GroupCombo.Items.Add(group.groupName);
                    }

                }
            }
            catch (Exception exept)
            {
                MessageBox.Show(exept.Message);
            };
        }

        private void LogInBtn_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(GroupCombo.Text))
            {
                GroupStat.ForeColor = Color.Red;
                GroupStat.Text = "Choose group!";
            }
            else
            {
                if (String.IsNullOrWhiteSpace(StudCombo.Text))
                {
                    StudStat.ForeColor = Color.Red;
                    StudStat.Text = "Choose student!";
                }
                else
                {
                    TaskMenu menuForm = new TaskMenu();
                    menuForm.Show();
                }
            }
        }

        private void GroupCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            GroupStat.Text = "";
            if (GroupCombo.SelectedItem.ToString() == "ПЗС-31")
            {
                StudCombo.Items.Clear();
                try
                {
                    using (StreamReader sr = new StreamReader(ConfigurationManager.ConnectionStrings["Students"].ConnectionString))
                    {
                        String line = sr.ReadToEnd();
                        List<GroupControl> groupList = JsonConvert.DeserializeObject<List<GroupControl>>(line);
                        foreach (var stud in groupList[GroupCombo.SelectedIndex].students)
                        {
                            StudCombo.Items.Add(stud.name);
                        }

                    }
                }
                catch (Exception exept)
                {
                    MessageBox.Show(exept.Message);
                };
            }
            else if (GroupCombo.SelectedItem.ToString() == "ПЗС-32")
            {
                StudCombo.Items.Clear();
                try
                {
                    using (StreamReader sr = new StreamReader(ConfigurationManager.ConnectionStrings["Students"].ConnectionString))
                    {
                        String line = sr.ReadToEnd();
                        List<GroupControl> groupList = JsonConvert.DeserializeObject<List<GroupControl>>(line);
                        foreach (var stud in groupList[GroupCombo.SelectedIndex].students)
                        {
                            StudCombo.Items.Add(stud.name);
                        }

                    }
                }
                catch (Exception exept)
                {
                    MessageBox.Show(exept.Message);
                };
            }
        }

        private void StudCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            StudStat.Text = "";
        }
    }
}
