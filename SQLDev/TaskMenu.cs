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
    public partial class TaskMenu : Form
    {
        public TaskMenu(string student)
        {
            InitializeComponent();
            StudLab.Text += student;
        }

        private void TaskMenu_Load(object sender, EventArgs e)
        {
            CreatingNewButtons(getTaskCount());
        }

        private void CreatingNewButtons(int taskCount)
        {
            int horizotal = 13;
            int vertical = 40;
            Button[] buttonArray = new Button[taskCount];

            for (int i = 0; i < buttonArray.Length; i++)
            {
                buttonArray[i] = new Button();
                buttonArray[i].Name = "taskBtn_" + i;
                buttonArray[i].Size = new Size(65, 65);
                buttonArray[i].Location = new Point(horizotal, vertical);
                buttonArray[i].Text = "Task " + (i+1).ToString();
                buttonArray[i].Click += TaskBtn_Click;
                if ((i+1)%5 == 0)
                {
                    horizotal = 13;
                    vertical = vertical + 70;
                }
                else
                {
                    horizotal = horizotal + 70;
                }
                this.Controls.Add(buttonArray[i]);
            }
        }

        private int getTaskCount()
        {
            try
            {
                using (StreamReader sr = new StreamReader(ConfigurationManager.ConnectionStrings["DefaultTask"].ConnectionString))
                {
                    String line = sr.ReadToEnd();
                    var taskList = JsonConvert.DeserializeObject<List<TaskControl>>(line);
                    return taskList.Count;
                }
            }
            catch (Exception exept)
            {
                MessageBox.Show(exept.Message);
                return 0;
            };
        }

        private void  TaskBtn_Click(object sender, EventArgs e)
        {
            string[] words = (((Button)sender).Name).Split('_');

            MainForm taskForm = new MainForm(Convert.ToInt32(words[1]));
            taskForm.Text += (Convert.ToInt32(words[1])+1).ToString(); 
            taskForm.ShowDialog();
        }

        private void LogOutBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure to log out?", "Log Out", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            if (result == DialogResult.Yes)
            {
                UserLogin loginForm = new UserLogin();
                loginForm.FormClosed += new FormClosedEventHandler(loginForm_FormClosed);
                loginForm.Show();
                this.Hide();
            }
        }

        private void loginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private void TaskMenu_SizeChanged(object sender, EventArgs e)
        {

        }
    }
}
