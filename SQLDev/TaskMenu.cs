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
        private Boolean[] Marks;
        private Int32 TaskCount = 0;
        Button[] buttonArray;
        public TaskMenu(string student)
        {
            InitializeComponent();
            StudLab.Text += student;
        }

        private void TaskMenu_Load(object sender, EventArgs e)
        {
            this.TaskCount = getTaskCount();
            CreatingNewButtons(this.TaskCount);
            this.Marks = new Boolean[this.TaskCount];
            for (Int32 i = 0; i < Marks.Length; i++)
            {
                this.Marks[i] = false;
            }
        }

        private void CreatingNewButtons(int taskCount)
        {
            int horizotal = 13;
            int vertical = 40;
            buttonArray = new Button[taskCount];

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
            switch (taskForm.ShowDialog())
            {
                case DialogResult.Abort:
                    break;
                case DialogResult.Cancel:
                    break;
                case DialogResult.Ignore:
                    break;
                case DialogResult.No:
                    {
                        this.buttonArray[Convert.ToInt32(words[1])].BackColor = System.Drawing.Color.Salmon;
                    }
                    break;
                case DialogResult.None:
                    break;
                case DialogResult.OK:
                    {
                        this.Marks[Convert.ToInt32(words[1])] = true;
                        this.StudentMark.Text = "Mark: " + GetStudentMark().ToString();
                        this.buttonArray[Convert.ToInt32(words[1])].BackColor = System.Drawing.Color.LightGreen;
                    }
                    break;
                case DialogResult.Retry:
                    break;
                case DialogResult.Yes:
                    break;
                default:
                    break;
            }
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
        private Int32 CountCorrectTasks()
        {
            Int32 counter = 0;
            for (Int32 i = 0; i < this.Marks.Length; i++)
            {
                if (this.Marks[i])
                {
                    counter++;
                }
            }
            return counter;
        }
        private Int32 GetStudentMark()
        {
            Double correct = CountCorrectTasks();
            Double result = correct / this.TaskCount;
            result *= 100;
            return Convert.ToInt32(result);
        }
    }
}
