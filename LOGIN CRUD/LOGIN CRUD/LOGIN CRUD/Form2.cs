using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.Logging;

namespace LOGIN_CRUD
{
    public partial class Form2 : Form
    {
        private SqlConnection con;

        public Form2()
        {
            InitializeComponent();
            con = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Integrated Security=True");
            con.Open(); 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 registration = new Form1();
            registration.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.Text) && !string.IsNullOrEmpty(textBox2.Text))
            {
                string query = "SELECT * FROM [mydb].[dbo].[Table] WHERE username = @username AND password = @password";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@username", textBox1.Text);
                    cmd.Parameters.AddWithValue("@password", textBox2.Text);

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            this.Hide();
                            Form3 home = new Form3();
                            home.ShowDialog();
                        }
                        else
                        {
                            MessageBox.Show("No account available with this username and password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Please enter values in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
