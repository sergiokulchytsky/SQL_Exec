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
            string keywordsUp = @"\b(SELECT|FROM|WHERE|BETWEEN|LIKE|ORDER|BY|UPDATE|DELETE|INSERT|INTO|CREATE|TABLE|DROP|INDEX|DATABASE|ALTER|VALUES|NOT|NULL|CONSTRAINT|IDENTITY|USER)\b";
            MatchCollection keywordUpMatches = Regex.Matches(richTextBox2.Text, keywordsUp);

            string keywordsDown = @"\b(select|from|where|between|like|order|by|update|delete|insert|into|create|table|drop|index|database|alter|values|not|null|constraint|identity|user)\b";
            MatchCollection keywordDownMatches = Regex.Matches(richTextBox2.Text, keywordsDown);

            int originalIndex = richTextBox2.SelectionStart;
            int originalLength = richTextBox2.SelectionLength;
            Color originalColor = Color.Black;

            richTextBox2.SelectionStart = 0;
            richTextBox2.SelectionLength = richTextBox1.Text.Length;
            richTextBox2.SelectionColor = originalColor;

            foreach (Match m in keywordUpMatches)
            {
                richTextBox2.SelectionStart = m.Index;
                richTextBox2.SelectionLength = m.Length;
                richTextBox2.SelectionColor = Color.Blue;
            }

            foreach (Match m in keywordDownMatches)
            {
                richTextBox2.SelectionStart = m.Index;
                richTextBox2.SelectionLength = m.Length;
                richTextBox2.SelectionColor = Color.Blue;
            }

            richTextBox2.SelectionStart = originalIndex;
            richTextBox2.SelectionLength = originalLength;
            richTextBox2.SelectionColor = originalColor;

            richTextBox2.Focus();
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized) 
            {
                int lab2Y = this.Height / 2 + 19;
                label2.Location = new Point(12, lab2Y);

                int but1Y = this.Height / 2 - 28;
                button1.Location = new Point(12, but1Y);

                int rch2Y = this.Height / 2 + 37;
                richTextBox2.Location = new Point(12, rch2Y);

                richTextBox1.Size = new Size(1150, 300);
                richTextBox2.Size = new Size(1150, 285);
            }
            else
            {
                button1.Location = new Point(12, 184);
                label2.Location = new Point(12, 231);
                richTextBox2.Location = new Point(12, 249);
                richTextBox1.Size = new Size(490, 125);
                richTextBox2.Size = new Size(490, 125);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Image files | *.jpg"; 
            dialog.Multiselect = false;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                String path = dialog.FileName;
                using (StreamReader reader = new StreamReader(new FileStream(path, FileMode.Open), new UTF8Encoding()))
                {
                    label3.Text = path;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            List<TaskControl> task = new List<TaskControl>();
            TaskControl t = new TaskControl();
            t.description = richTextBox1.Text;
            t.imgPath = label3.Text;
            DB db = new DB();
            HashSum hash = new HashSum(db.Read(richTextBox2.Text));

            t.correctSQL = hash.GetHashString();

            task.Add(t);
            string jstr = JsonConvert.SerializeObject(task, Formatting.Indented);
            System.IO.File.WriteAllText(@"D:\task.json", jstr);
        }

        private void Task_Gen_Load(object sender, EventArgs e)
        {

        }
    }

    
}
