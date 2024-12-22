using System;
using System.Windows.Forms;
using Microsoft.Extensions.DependencyInjection;
using DATA_ACCES_LAYER.Interface;
using DATA_ACCES_LAYER.Model;
using DATA_ACCES_LAYER.Response_ErrorHandling;

namespace WinFormsApp1
{
    public partial class Login : Form
    {
        private readonly IServiceProvider _serviceProvider;
        private readonly IDataAcces _dataAcces;

        // Constructor that accepts IServiceProvider and IDataAcces to resolve dependencies
        public Login(IServiceProvider serviceProvider, IDataAcces dataAcces)
        {
            InitializeComponent();
            _serviceProvider = serviceProvider;
            _dataAcces = dataAcces;  // Injected IDataAcces dependency
        }

        // Event handler for the Login button click
        private async void btnLogin_Click(object sender, EventArgs e)
        {
            // Retrieve the entered username and password
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            // Validate input
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both username and password.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Call AuthenticateUser to check credentials against the database
            ResponseObject<User> response =  _dataAcces.AuthenticateUser(username, password);

            // Check the response
            if (response.success && response.Object != null && response.Object.Count > 0)
            {
                // Successful login
              //  MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Hide the login form and show the main form
                this.Hide();
                User ConnectedUser = response.Object[0];

                var form1 = _serviceProvider.GetRequiredService<Form1>();
                form1.SetLoggedInUser(ConnectedUser);
                form1.Show();
            }
            else
            {
                // Failed login
                MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            // Optional: Logic for when the login form loads
        }
    }
}
