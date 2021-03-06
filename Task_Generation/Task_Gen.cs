﻿using System;
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


namespace Task_Generation
{

    public partial class Task_Gen : Form
    {
        public Task_Gen()
        {
            InitializeComponent();
        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {
            string keywordsUp = @"\b(SELECT|FROM|WHERE|BETWEEN|LIKE|ORDER|BY|UPDATE|DELETE|INSERT|INTO|CREATE|TABLE|DROP|INDEX|DATABASE|ALTER|VALUES|NOT|NULL|CONSTRAINT|IDENTITY|USER|JOIN|GROUP)\b";
            MatchCollection keywordUpMatches = Regex.Matches(corrSqlBox.Text, keywordsUp);

            string keywordsDown = @"\b(select|from|where|between|like|order|by|update|delete|insert|into|create|table|drop|index|database|alter|values|not|null|constraint|identity|user|join|group)\b";
            MatchCollection keywordDownMatches = Regex.Matches(corrSqlBox.Text, keywordsDown);

            int originalIndex = corrSqlBox.SelectionStart;
            int originalLength = corrSqlBox.SelectionLength;
            Color originalColor = Color.Black;

            corrSqlBox.SelectionStart = 0;
            corrSqlBox.SelectionLength = descriptionBox.Text.Length;
            corrSqlBox.SelectionColor = originalColor;

            foreach (Match m in keywordUpMatches)
            {
                corrSqlBox.SelectionStart = m.Index;
                corrSqlBox.SelectionLength = m.Length;
                corrSqlBox.SelectionColor = Color.Blue;
            }

            foreach (Match m in keywordDownMatches)
            {
                corrSqlBox.SelectionStart = m.Index;
                corrSqlBox.SelectionLength = m.Length;
                corrSqlBox.SelectionColor = Color.Blue;
            }

            corrSqlBox.SelectionStart = originalIndex;
            corrSqlBox.SelectionLength = originalLength;
            corrSqlBox.SelectionColor = originalColor;

            corrSqlBox.Focus();
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                int lab2Y = this.Height / 2 + 19;
                label2.Location = new Point(12, lab2Y);

                int but1Y = this.Height / 2 - 28;
                Attach.Location = new Point(12, but1Y);

                int fileY = this.Height / 2 - 28;
                fileStatus.Location = new Point(148, fileY);

                int erdY = this.Height / 2 - 28;
                int erdX = this.Width - 200;
                ErdStatusLabel.Location = new Point(erdX, erdY);

                int sqlY = this.Height / 2 + 37;
                int sqlX = this.Width - 200;
                SqlStatusLabel.Location = new Point(sqlX, sqlY);

                int rch2Y = this.Height / 2 + 37;
                corrSqlBox.Location = new Point(12, rch2Y);

                descriptionBox.Size = new Size(1160, 300);
                corrSqlBox.Size = new Size(1160, 285);
            }
            else
            {
                fileStatus.Location = new Point(148, 184);
                Attach.Location = new Point(12, 184);
                label2.Location = new Point(12, 231);
                corrSqlBox.Location = new Point(12, 249);
                descriptionBox.Size = new Size(490, 125);
                corrSqlBox.Size = new Size(490, 125);
            }
        }

        private void Attach_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Image files | *.jpg";
            dialog.Multiselect = false;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                String path = dialog.FileName;
                using (StreamReader reader = new StreamReader(new FileStream(path, FileMode.Open), new UTF8Encoding()))
                {
                    fileStatus.Text = path;
                }
            }
        }

        private void Create_Click(object sender, EventArgs e)
        {
            DescStatusLabel.Text = "";
            ErdStatusLabel.Text = "";
            SqlStatusLabel.Text = "";
            List<TaskControl> task = new List<TaskControl>();
            TaskControl t = new TaskControl();
            DB db = new DB();
            try
            {
                if (String.IsNullOrWhiteSpace(descriptionBox.Text))
                {
                    DescStatusLabel.ForeColor = Color.Red;
                    DescStatusLabel.Text = "Description field is empty!";
                }
                else
                {
                    if (String.IsNullOrWhiteSpace(fileStatus.Text))
                    {
                        ErdStatusLabel.ForeColor = Color.Red;
                        ErdStatusLabel.Text = "ERD must be added!";
                    }
                    else
                    {
                        if (String.IsNullOrWhiteSpace(corrSqlBox.Text))
                        {
                            SqlStatusLabel.ForeColor = Color.Red;
                            SqlStatusLabel.Text = "SQL request field is empty!";
                        }
                        else
                        {
                            using (StreamReader sr = new StreamReader(ConfigurationManager.ConnectionStrings["DefaultTask"].ConnectionString))
                            {
                                String line = sr.ReadToEnd();
                                var listTC = JsonConvert.DeserializeObject<List<TaskControl>>(line);
                                foreach (var item in listTC)
                                {
                                    task.Add(item);
                                }

                            }
               
                            HashSum hash = new HashSum(db.Read(corrSqlBox.Text));
                            t.description = descriptionBox.Text;
                            t.imgPath = fileStatus.Text;
                            t.correctSQL = hash.GetHashString();

                            task.Add(t);
                            string jstr = JsonConvert.SerializeObject(task, Formatting.Indented);
                            System.IO.File.WriteAllText(ConfigurationManager.ConnectionStrings["DefaultTask"].ConnectionString, jstr);
                            SqlStatusLabel.ForeColor = Color.Green;
                            SqlStatusLabel.Text = "Success!";
                        }
                    }
                }
            }
            catch (SqlException exept)
            {
                SqlStatusLabel.ForeColor = Color.Red;
                SqlStatusLabel.Text = exept.Message;
            };
        }

        private void Task_Gen_Load(object sender, EventArgs e)
        {

        }

        private void Task_Gen_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }
    }


}
