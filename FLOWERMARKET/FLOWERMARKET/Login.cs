using FLOWERMARKET.Properties;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace FLOWERMARKET
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        String connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=db_flowermarket;";

        public void login()
        {
            string query = "SELECT * FROM users WHERE username='" + textBoxUsername.Text + "' AND password='" + textBoxPassword.Text + "'";
            //prepare the connection
            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            MySqlDataReader reader;

            try
            {
                databaseConnection.Open();
                reader = commandDatabase.ExecuteReader();

                if(reader.HasRows)
                {
                    while(reader.Read())
                    {
                        MessageBox.Show("Login Berhasil");
                        Dashboard dashboard = new Dashboard();
                        dashboard.Show();
                        this.Hide();
                    }
                }
                else
                {
                    MessageBox.Show("Oops! Something went wrong. Please try again later.");
                }
                databaseConnection.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            login();
        }
    }
}
