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
            }
            catch (SqlException exept)
            {
                MessageBox.Show(exept.Message);
                myConnection.Close();
            }
            
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            Regex rx = new Regex("INSERT ");
            int index = richTextBox1.SelectionStart;

            foreach (Match item in rx.Matches(richTextBox1.Text))
            {
                richTextBox1.Select(item.Index, item.Value.Length);
                richTextBox1.SelectionColor = Color.Blue;
                richTextBox1.SelectionStart = index;
                richTextBox1.SelectionColor = Color.Black;
            }
        }
    }
}
