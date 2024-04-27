using Microsoft.VisualBasic.Logging;
using System.Data.SqlClient;
using System.Drawing;

namespace LOGIN_CRUD
{
    public partial class Form1 : Form
    {
        private SqlConnection con;
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Integrated Security=True");
            con.Open();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        



        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form2 login = new Form2();
            login.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.Text) && !string.IsNullOrEmpty(textBox2.Text) && !string.IsNullOrEmpty(textBox3.Text))
            {
                if (textBox2.Text == textBox3.Text)
                {
                    using (SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM [mydb].[dbo].[Table] WHERE username = @username", con))
                    {
                        cmd.Parameters.AddWithValue("@username", textBox1.Text);
                        int count = (int)cmd.ExecuteScalar();
                        if (count > 0)
                        {
                            MessageBox.Show("Username already exists. Please try another.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            using (SqlCommand insertCmd = new SqlCommand("INSERT INTO [mydb].[dbo].[Table] (username, password) VALUES (@username, @password)", con))
                            {
                                insertCmd.Parameters.AddWithValue("@username", textBox1.Text);
                                insertCmd.Parameters.AddWithValue("@password", textBox2.Text);
                                insertCmd.ExecuteNonQuery();
                            }
                            MessageBox.Show("Your account has been created. Please login now.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Passwords do not match. Please enter the same password in both fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please enter a value in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
