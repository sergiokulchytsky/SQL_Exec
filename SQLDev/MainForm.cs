using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Configuration;
using System.IO;
using Newtonsoft.Json;
using DataLib;
using Hashing;

namespace SQLDev
{
    public partial class MainForm : Form
    {


        public MainForm()
        {
            InitializeComponent();
            querySqlBox.Select();
        }

        private void Execute_Click(object sender, EventArgs e)
        {
            try
            {
                if(String.IsNullOrWhiteSpace(querySqlBox.Text))
                {
                    StatusLabel.ForeColor = Color.Red;
                    StatusLabel.Text = "Field is empty!";
                }
                else
                {
                   
                            DB db = new DB();
                            dataGridView.DataSource = db.Read(querySqlBox.Text);
                 
                    
                    StatusLabel.ForeColor = Color.Green;
                    StatusLabel.Text = "Success!";
                }
            }
            catch (SqlException exept)
            {
                StatusLabel.ForeColor = Color.Red;
                StatusLabel.Text = exept.Message;
              
            }
            try
            {
                using (StreamReader sr = new StreamReader(@"D:\task.json"))
                {
                    String contents = sr.ReadToEnd();
                    var listTask = JsonConvert.DeserializeObject<List<TaskControl>>(contents);
                    var corrTask = listTask[0];
                    String correctHash = corrTask.correctSQL;
                    DB db = new DB();
                    HashSum currHS = new HashSum(db.Read(querySqlBox.Text));
                    String currentHash = currHS.GetHashString();

                    if (currentHash==correctHash)
                    {
                        ResultLabel.ForeColor = Color.Green;
                        ResultLabel.Text = "Test passed!";
                    }
                    else
                    {
                        ResultLabel.ForeColor = Color.Red;
                        ResultLabel.Text = "Test failed!";
                    }
                    
                };
            }
            catch (Exception exept)
            {
               ResultLabel.ForeColor = Color.Red;
               ResultLabel.Text = exept.Message;

            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

            string keywordsUp = @"\b(SELECT|FROM|WHERE|BETWEEN|LIKE|ORDER|BY|UPDATE|DELETE|INSERT|INTO|CREATE|TABLE|DROP|INDEX|DATABASE|ALTER|VALUES|NOT|NULL|CONSTRAINT|IDENTITY|USER)\b";
            MatchCollection keywordUpMatches = Regex.Matches(querySqlBox.Text, keywordsUp);

            string keywordsDown = @"\b(select|from|where|between|like|order|by|update|delete|insert|into|create|table|drop|index|database|alter|values|not|null|constraint|identity|user)\b";
            MatchCollection keywordDownMatches = Regex.Matches(querySqlBox.Text, keywordsDown);

            int originalIndex = querySqlBox.SelectionStart;
            int originalLength = querySqlBox.SelectionLength;
            Color originalColor = Color.Black;

            querySqlBox.SelectionStart = 0;
            querySqlBox.SelectionLength = querySqlBox.Text.Length;
            querySqlBox.SelectionColor = originalColor;

            foreach (Match m in keywordUpMatches)
            {
                querySqlBox.SelectionStart = m.Index;
                querySqlBox.SelectionLength = m.Length;
                querySqlBox.SelectionColor = Color.Blue;
            }

            foreach (Match m in keywordDownMatches)
            {
                querySqlBox.SelectionStart = m.Index;
                querySqlBox.SelectionLength = m.Length;
                querySqlBox.SelectionColor = Color.Blue;
            }

            querySqlBox.SelectionStart = originalIndex;
            querySqlBox.SelectionLength = originalLength;
            querySqlBox.SelectionColor = originalColor;

            querySqlBox.Focus();
        }

        private void richTextBox1_MouseClick(object sender, MouseEventArgs e)
        {
            StatusLabel.Text = "";
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void MainForm_SizeChanged(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                int lab2Y = this.Height / 2 - 50;
                label2.Location = new Point(12, lab2Y);

                int grY = this.Height / 2 - 32;
                dataGridView.Location = new Point(12, grY);

                dataGridView.Size = new Size(1340, 350);
                querySqlBox.Size = new Size(1120, 285);
            }
            else
            {
                label2.Location = new Point(12, 166);
                dataGridView.Location = new Point(12, 184);
                dataGridView.Size = new Size(730, 221);
                querySqlBox.Size = new Size(513, 125);
            }
        }

        private void TaskButton_Click(object sender, EventArgs e)
        {
            TaskView TaskForm = new TaskView();
            TaskForm.Show();
        }
    }
}
