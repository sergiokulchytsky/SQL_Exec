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

namespace Task_Generation
{
    public partial class AdminMainForm : Form
    {
        public AdminMainForm()
        {
            InitializeComponent();
            try
            {
                using (StreamReader sr = new StreamReader(ConfigurationManager.ConnectionStrings["DefaultTask"].ConnectionString))
                {
                    String line = sr.ReadToEnd();
                    var listTC = JsonConvert.DeserializeObject<List<TaskControl>>(line);
                    foreach (var item in listTC)
                    {
                        TaskList.Items.Add(item.description);
                    }

                }
            }
            catch (Exception exept)
            {
                MessageBox.Show(exept.Message);
            };
        }

        private void AdminMainForm_Load(object sender, EventArgs e)
        {

        }

        private void AddTaskBtnClick(object sender, EventArgs e)
        {
            Task_Gen TaskForm = new Task_Gen();
            TaskForm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<TaskControl> task = new List<TaskControl>();
            using (StreamReader sr = new StreamReader(ConfigurationManager.ConnectionStrings["DefaultTask"].ConnectionString))
            {
                String line = sr.ReadToEnd();
                var listTC = JsonConvert.DeserializeObject<List<TaskControl>>(line);
                foreach (var item in listTC)
                {
                    task.Add(item);
                }
            }

            while (TaskList.SelectedItems.Count > 0)
            {
                int index = TaskList.SelectedIndex;
                TaskList.Items.Remove(TaskList.SelectedItems[0]);
                task.RemoveAt(index);
                string jstr = JsonConvert.SerializeObject(task, Formatting.Indented);
                System.IO.File.WriteAllText(@"D:\task.json", jstr);
            }
        }
    }
}
