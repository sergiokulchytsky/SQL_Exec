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
    public partial class UserLogin : Form
    {
        public UserLogin()
        {
            InitializeComponent();
            try
            {
                using (StreamReader sr = new StreamReader(ConfigurationManager.ConnectionStrings["Users"].ConnectionString))
                {
                    String line = sr.ReadToEnd();
                    var listTC = JsonConvert.DeserializeObject<List<UsersControl>>(line);
                    foreach (var item in listTC)
                    {
                        StudCombo.Items.Add(item.name);
                    }

                }
            }
            catch (Exception exept)
            {
                MessageBox.Show(exept.Message);
            };
        }

        private void LogInBtn_Click(object sender, EventArgs e)
        {
            TaskMenu menuForm = new TaskMenu();
            menuForm.Show();
        }
    }
}
