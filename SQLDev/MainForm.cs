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

namespace SQLDev
{
    public partial class MainForm : Form
    {

        SqlConnection myConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["ServerConnection"].ConnectionString);
        SqlCommand comm = new SqlCommand();

        public MainForm()
        {
            InitializeComponent();
            richTextBox1.Select();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                myConnection.Open();
                comm.Connection = myConnection;
                comm.CommandText = richTextBox1.Text.ToString();
                using (SqlDataReader reader = comm.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        dataGridView.Visible = true;
                        DataTable dt = new DataTable();
                        dt.Load(reader);
                        dataGridView.DataSource = dt;
                    }
                    else
                    {
                        dataGridView.Visible = false;
                    }
                }
                //comm.ExecuteNonQuery();
                //MessageBox.Show("Successful!");
                //richTextBox1.ResetText();
                myConnection.Close();
                StatusLabel.Text = "Success!";
            }
            catch (SqlException exept)
            {
                StatusLabel.ForeColor = Color.Red;
                StatusLabel.Text = exept.Message;
                myConnection.Close();
            }
            
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            string keywordsUp = @"\b(SELECT|FROM|WHERE|BETWEEN|LIKE|ORDER|BY|UPDATE|DELETE|INSERT|INTO|CREATE|TABLE|DROP|INDEX|DATABASE|ALTER)\b";
            MatchCollection keywordUpMatches = Regex.Matches(richTextBox1.Text, keywordsUp);

            string keywordsDown = @"\b(select|from|where|between|like|order|by|update|delete|insert|into|create|table|drop|index|database|alter)\b";
            MatchCollection keywordDownMatches = Regex.Matches(richTextBox1.Text, keywordsDown);

            int originalIndex = richTextBox1.SelectionStart;
            int originalLength = richTextBox1.SelectionLength;
            Color originalColor = Color.Black;

            richTextBox1.SelectionStart = 0;
            richTextBox1.SelectionLength = richTextBox1.Text.Length;
            richTextBox1.SelectionColor = originalColor;

            foreach (Match m in keywordUpMatches)
            {
                richTextBox1.SelectionStart = m.Index;
                richTextBox1.SelectionLength = m.Length;
                richTextBox1.SelectionColor = Color.Blue;
            }

            foreach (Match m in keywordDownMatches)
            {
                richTextBox1.SelectionStart = m.Index;
                richTextBox1.SelectionLength = m.Length;
                richTextBox1.SelectionColor = Color.Blue;
            }

            richTextBox1.SelectionStart = originalIndex;
            richTextBox1.SelectionLength = originalLength;
            richTextBox1.SelectionColor = originalColor;

            richTextBox1.Focus();
        }
    }
}
