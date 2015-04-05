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
using DataLib;

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
    }
}
