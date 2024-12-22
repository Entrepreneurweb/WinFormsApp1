using DATA_ACCES_LAYER.Interface;
using DATA_ACCES_LAYER.Model;
using System;
using System.IO;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class AddUserForm : Form
    {
        private readonly IDataAcces _dataAcces;
        public User NewUser { get; private set; }

        public AddUserForm( IDataAcces dataAcces )
        {
            _dataAcces = dataAcces; 
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            // Validate fields
            if (string.IsNullOrWhiteSpace(nameTextBox.Text))
            {
                MessageBox.Show("Please enter a name.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (roleComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a role.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(profilePictureTextBox.Text) || !File.Exists(profilePictureTextBox.Text))
            {
                MessageBox.Show("Please select a valid profile image.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(passwordTextBox.Text) || passwordTextBox.Text.Length < 6)
            {
                MessageBox.Show("Please enter a password with at least 6 characters.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Create a new user with the entered information
            User NewUser = new User(
                nameTextBox.Text.Trim(),
                roleComboBox.SelectedItem.ToString(),
                profilePictureTextBox.Text.Trim()
            // Add password
            );
            NewUser.Password = passwordTextBox.Text.Trim();
            NewUser.Adress = adressTextBox.Text.Trim();
            
            _dataAcces.AddUser(NewUser );

            DialogResult = DialogResult.OK; // Indicate that the user confirmed the form
            Close();


        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel; // Cancel the operation
            Close();
        }

        private void browseButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Images (*.png;*.jpg;*.jpeg)|*.png;*.jpg;*.jpeg|All files (*.*)|*.*";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    profilePictureTextBox.Text = openFileDialog.FileName;
                }
            }
        }
    }
}
