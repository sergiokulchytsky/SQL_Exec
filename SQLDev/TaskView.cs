using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Configuration;
using System.Data.SqlClient;
using System.IO;
using Newtonsoft.Json;
using Hashing;
using DataLib;

namespace SQLDev
{
    public partial class TaskView : Form
    {
        public TaskView()
        {
            InitializeComponent();
            try
            {
                using (StreamReader sr = new StreamReader(@"D:\task.json"))
                {
                    String line = sr.ReadToEnd();
                    var listTC = JsonConvert.DeserializeObject<List<TaskControl>>(line);
                    var currTask = listTC[0];
                    DescLabel.Text = currTask.description;
                    ERDpictureBox.ImageLocation = currTask.imgPath;

                }
            }
            catch (Exception exept)
            {
                MessageBox.Show(exept.Message);
            };
        }
    }
}
