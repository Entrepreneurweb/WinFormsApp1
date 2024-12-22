using DATA_ACCES_LAYER.Interface;
using DATA_ACCES_LAYER.Model;
using DATA_ACCES_LAYER.Response_ErrorHandling;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace WinFormsApp1.Controls
{
    public partial class MyProfile : UserControl
    {
        public User CurrentUser { get; set; }
        private readonly IDataAcces _dataAcces;

        // Constructeur
        public MyProfile(IDataAcces dataAcces)
        {
            _dataAcces = dataAcces;
            InitializeComponent();
        }

        // Chargement des informations de l'utilisateur
        public void LoadUser(User user)
        {
            if (user == null)
            {
                MessageBox.Show("User data is not available", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            CurrentUser = user;

            nameTextBox.Text = CurrentUser.Name ?? string.Empty;
            addressTextBox.Text = CurrentUser.Adress ?? string.Empty;
            passwordTextBox.Text = CurrentUser.Password ?? string.Empty;
            roleLabel.Text = $"Role:                    {CurrentUser.Role}";

            if (!string.IsNullOrWhiteSpace(CurrentUser.ProfilePicture) && File.Exists(CurrentUser.ProfilePicture))
            {
                try
                {
                    profilePictureBox.Image = Image.FromFile(CurrentUser.ProfilePicture);
                }
                catch (Exception)
                {
                    MessageBox.Show("Error loading profile picture.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    profilePictureBox.Image = null;
                }
            }
            else
            {
                profilePictureBox.Image = null;
            }

            nameTextBox.ReadOnly = false;
            addressTextBox.ReadOnly = false;
            saveButton.Enabled = true;
          //  browseButton.Enabled = true;
        }

        // Sauvegarde des modifications
        private void saveButton_Click(object sender, EventArgs e)
        {



            MessageBox.Show(" hello world");
            if (CurrentUser == null)
            {
                MessageBox.Show("No valid user data to save.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(nameTextBox.Text))
            {
                MessageBox.Show("Please enter a valid name.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            CurrentUser.Name = nameTextBox.Text.Trim();
            CurrentUser.Adress = addressTextBox.Text.Trim();

          /*  if (!string.IsNullOrWhiteSpace(profilePictureTextBox.Text) && File.Exists(profilePictureTextBox.Text))
            {
                CurrentUser.ProfilePicture = profilePictureTextBox.Text.Trim();
            }*/

            ResponseObject<User> response = _dataAcces.UpdateUser(CurrentUser);

            if (response.success)
            {
                MessageBox.Show("Profile updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                nameTextBox.ReadOnly = true;
                addressTextBox.ReadOnly = true;
                saveButton.Enabled = false;
               // browseButton.Enabled = false;
            }
            else
            {
                MessageBox.Show($"Error updating profile: {response.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Action pour choisir une nouvelle image de profil
        private void browseButton_Click(object sender, EventArgs e)
        {
            if (CurrentUser == null)
            {
                MessageBox.Show("No valid user data to change profile picture.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Images (*.png;*.jpg;*.jpeg)|*.png;*.jpg;*.jpeg|All files (*.*)|*.*";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                   // profilePictureTextBox.Text = openFileDialog.FileName;
                    try
                    {
                        profilePictureBox.Image = Image.FromFile(openFileDialog.FileName);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Error loading the selected image.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        profilePictureBox.Image = null;
                    }
                }
            }
        }

        private void saveButton_Click_1(object sender, EventArgs e)
        {

            if (CurrentUser == null)
            {
                MessageBox.Show("No valid user data to save.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(nameTextBox.Text))
            {
                MessageBox.Show("Please enter a valid name.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            CurrentUser.Name = nameTextBox.Text.Trim();
            CurrentUser.Adress = addressTextBox.Text.Trim();
            CurrentUser.Password = passwordTextBox.Text.Trim();

           /* if (!string.IsNullOrWhiteSpace(profilePictureTextBox.Text) && File.Exists(profilePictureTextBox.Text))
            {
                CurrentUser.ProfilePicture = profilePictureTextBox.Text.Trim();
            }*/

            ResponseObject<User> response = _dataAcces.UpdateUser(CurrentUser);

            if (response.success)
            {
                MessageBox.Show("Profile updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                nameTextBox.ReadOnly = true;
                addressTextBox.ReadOnly = true;
                saveButton.Enabled = false;
               // browseButton.Enabled = false;
            }
            else
            {
                MessageBox.Show($"Error updating profile: {response.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void addressLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
