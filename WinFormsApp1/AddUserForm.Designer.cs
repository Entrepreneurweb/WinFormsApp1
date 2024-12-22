namespace WinFormsApp1
{
    partial class AddUserForm
    {
        private System.ComponentModel.IContainer components = null;
        private TextBox nameTextBox;
        private ComboBox roleComboBox;
        private TextBox profilePictureTextBox;
        private TextBox adressTextBox;
        private TextBox passwordTextBox;
        private Button saveButton;
        private Button cancelButton;
        private Button browseButton;
        private Label nameLabel;
        private Label roleLabel;
        private Label profilePictureLabel;
        private Label adressLabel;
        private Label passwordLabel;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            nameTextBox = new TextBox();
            roleComboBox = new ComboBox();
            profilePictureTextBox = new TextBox();
            adressTextBox = new TextBox();
            passwordTextBox = new TextBox();
            saveButton = new Button();
            cancelButton = new Button();
            browseButton = new Button();
            nameLabel = new Label();
            roleLabel = new Label();
            profilePictureLabel = new Label();
            adressLabel = new Label();
            passwordLabel = new Label();

            SuspendLayout();

            // nameTextBox
            nameTextBox.Location = new Point(159, 23);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(250, 27);
            nameTextBox.TabIndex = 1;

            // roleComboBox
            roleComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            roleComboBox.FormattingEnabled = true;
            roleComboBox.Items.AddRange(new object[] { "admin", "User" });
            roleComboBox.Location = new Point(159, 66);
            roleComboBox.Name = "roleComboBox";
            roleComboBox.Size = new Size(250, 28);
            roleComboBox.TabIndex = 3;

            // profilePictureTextBox
            profilePictureTextBox.Location = new Point(159, 104);
            profilePictureTextBox.Name = "profilePictureTextBox";
            profilePictureTextBox.Size = new Size(200, 27);
            profilePictureTextBox.TabIndex = 5;

            // adressTextBox
            adressTextBox.Location = new Point(159, 137);
            adressTextBox.Name = "adressTextBox";
            adressTextBox.Size = new Size(250, 27);
            adressTextBox.TabIndex = 8;

            // passwordTextBox
            passwordTextBox.Location = new Point(159, 174);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(250, 27);
            passwordTextBox.TabIndex = 10;
            passwordTextBox.UseSystemPasswordChar = true;

            // saveButton
            saveButton.Font = new Font("Segoe Print", 10.8F, FontStyle.Bold);
            saveButton.ForeColor = Color.DarkGreen;
            saveButton.Location = new Point(120, 230);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(129, 40);
            saveButton.TabIndex = 11;
            saveButton.Text = "SAVE";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;

            // cancelButton
            cancelButton.Font = new Font("Segoe Print", 10.8F, FontStyle.Bold);
            cancelButton.ForeColor = Color.DarkGreen;
            cancelButton.Location = new Point(284, 230);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(125, 40);
            cancelButton.TabIndex = 12;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += cancelButton_Click;

            // browseButton
            browseButton.Location = new Point(369, 104);
            browseButton.Name = "browseButton";
            browseButton.Size = new Size(40, 27);
            browseButton.TabIndex = 6;
            browseButton.Text = "...";
            browseButton.UseVisualStyleBackColor = true;
            browseButton.Click += browseButton_Click;

            // nameLabel
            nameLabel.AutoSize = true;
            nameLabel.Font = new Font("Segoe Print", 10.8F, FontStyle.Bold);
            nameLabel.ForeColor = Color.DarkGreen;
            nameLabel.Location = new Point(20, 20);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(72, 31);
            nameLabel.TabIndex = 0;
            nameLabel.Text = "Name:";

            // roleLabel
            roleLabel.AutoSize = true;
            roleLabel.Font = new Font("Segoe Print", 10.8F, FontStyle.Bold);
            roleLabel.ForeColor = Color.DarkGreen;
            roleLabel.Location = new Point(20, 60);
            roleLabel.Name = "roleLabel";
            roleLabel.Size = new Size(56, 31);
            roleLabel.TabIndex = 2;
            roleLabel.Text = "Role:";

            // profilePictureLabel
            profilePictureLabel.AutoSize = true;
            profilePictureLabel.Font = new Font("Segoe Print", 10.8F, FontStyle.Bold);
            profilePictureLabel.ForeColor = Color.DarkGreen;
            profilePictureLabel.Location = new Point(20, 100);
            profilePictureLabel.Name = "profilePictureLabel";
            profilePictureLabel.Size = new Size(138, 31);
            profilePictureLabel.TabIndex = 4;
            profilePictureLabel.Text = "Profile Image:";

            // adressLabel
            adressLabel.AutoSize = true;
            adressLabel.Font = new Font("Segoe Print", 10.8F, FontStyle.Bold);
            adressLabel.ForeColor = Color.DarkGreen;
            adressLabel.Location = new Point(20, 140);
            adressLabel.Name = "adressLabel";
            adressLabel.Size = new Size(79, 31);
            adressLabel.TabIndex = 7;
            adressLabel.Text = "Adress:";

            // passwordLabel
            passwordLabel.AutoSize = true;
            passwordLabel.Font = new Font("Segoe Print", 10.8F, FontStyle.Bold);
            passwordLabel.ForeColor = Color.DarkGreen;
            passwordLabel.Location = new Point(20, 170);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(99, 31);
            passwordLabel.TabIndex = 9;
            passwordLabel.Text = "Password:";

            // AddUserForm
            ClientSize = new Size(578, 308);
            Controls.Add(cancelButton);
            Controls.Add(saveButton);
            Controls.Add(passwordTextBox);
            Controls.Add(passwordLabel);
            Controls.Add(adressTextBox);
            Controls.Add(adressLabel);
            Controls.Add(browseButton);
            Controls.Add(profilePictureTextBox);
            Controls.Add(profilePictureLabel);
            Controls.Add(roleComboBox);
            Controls.Add(roleLabel);
            Controls.Add(nameTextBox);
            Controls.Add(nameLabel);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "AddUserForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ADD NEW USER";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
