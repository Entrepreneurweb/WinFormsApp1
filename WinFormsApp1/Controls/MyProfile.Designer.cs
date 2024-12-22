namespace WinFormsApp1.Controls
{
    partial class MyProfile
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.Label roleLabel;
        private System.Windows.Forms.Label roleValueLabel;
        private System.Windows.Forms.PictureBox profilePictureBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox passwordTextBox;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            nameLabel = new Label();
            nameTextBox = new TextBox();
            addressLabel = new Label();
            addressTextBox = new TextBox();
            roleLabel = new Label();
            roleValueLabel = new Label();
            profilePictureBox = new PictureBox();
            saveButton = new Button();
            passwordLabel = new Label();
            passwordTextBox = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)profilePictureBox).BeginInit();
            SuspendLayout();
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new Font("Arial", 10F, FontStyle.Bold);
            nameLabel.ForeColor = Color.Black;
            nameLabel.Location = new Point(16, 86);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(59, 19);
            nameLabel.TabIndex = 0;
            nameLabel.Text = "Name:";
            // 
            // nameTextBox
            // 
            nameTextBox.BackColor = Color.White;
            nameTextBox.BorderStyle = BorderStyle.FixedSingle;
            nameTextBox.Location = new Point(138, 83);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.ReadOnly = true;
            nameTextBox.Size = new Size(250, 27);
            nameTextBox.TabIndex = 1;
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.Font = new Font("Arial", 10F, FontStyle.Bold);
            addressLabel.ForeColor = Color.Black;
            addressLabel.Location = new Point(16, 127);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new Size(80, 19);
            addressLabel.TabIndex = 2;
            addressLabel.Text = "Address:";
            addressLabel.Click += addressLabel_Click;
            // 
            // addressTextBox
            // 
            addressTextBox.BackColor = Color.White;
            addressTextBox.BorderStyle = BorderStyle.FixedSingle;
            addressTextBox.Location = new Point(138, 116);
            addressTextBox.Name = "addressTextBox";
            addressTextBox.ReadOnly = true;
            addressTextBox.Size = new Size(250, 27);
            addressTextBox.TabIndex = 3;
            // 
            // roleLabel
            // 
            roleLabel.AutoSize = true;
            roleLabel.Font = new Font("Arial", 10F, FontStyle.Bold);
            roleLabel.ForeColor = Color.Black;
            roleLabel.Location = new Point(16, 161);
            roleLabel.Name = "roleLabel";
            roleLabel.Size = new Size(50, 19);
            roleLabel.TabIndex = 4;
            roleLabel.Text = "Role:";
            // 
            // roleValueLabel
            // 
            roleValueLabel.AutoSize = true;
            roleValueLabel.Font = new Font("Arial", 10F);
            roleValueLabel.ForeColor = Color.DarkGray;
            roleValueLabel.Location = new Point(120, 96);
            roleValueLabel.Name = "roleValueLabel";
            roleValueLabel.Size = new Size(14, 19);
            roleValueLabel.TabIndex = 5;
            roleValueLabel.Text = " ";
            // 
            // profilePictureBox
            // 
            profilePictureBox.Location = new Point(138, 238);
            profilePictureBox.Name = "profilePictureBox";
            profilePictureBox.Size = new Size(232, 152);
            profilePictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            profilePictureBox.TabIndex = 6;
            profilePictureBox.TabStop = false;
            // 
            // saveButton
            // 
            saveButton.BackColor = Color.DarkGreen;
            saveButton.Enabled = false;
            saveButton.FlatStyle = FlatStyle.Flat;
            saveButton.ForeColor = Color.White;
            saveButton.Location = new Point(140, 441);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(182, 45);
            saveButton.TabIndex = 8;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = false;
            saveButton.Click += saveButton_Click_1;
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Font = new Font("Arial", 10F, FontStyle.Bold);
            passwordLabel.ForeColor = Color.Black;
            passwordLabel.Location = new Point(16, 204);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(93, 19);
            passwordLabel.TabIndex = 10;
            passwordLabel.Text = "Password:";
            // 
            // passwordTextBox
            // 
            passwordTextBox.BackColor = Color.White;
            passwordTextBox.BorderStyle = BorderStyle.FixedSingle;
            passwordTextBox.Location = new Point(140, 196);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.PasswordChar = '*';
            passwordTextBox.Size = new Size(250, 27);
            passwordTextBox.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe Print", 15.8F, FontStyle.Bold);
            label1.ForeColor = Color.DarkGreen;
            label1.Location = new Point(174, 15);
            label1.Name = "label1";
            label1.Size = new Size(196, 47);
            label1.TabIndex = 12;
            label1.Text = "MY PROFILE";
            // 
            // MyProfile
            // 
            BackColor = Color.White;
            Controls.Add(label1);
            Controls.Add(passwordTextBox);
            Controls.Add(passwordLabel);
            Controls.Add(saveButton);
            Controls.Add(profilePictureBox);
            Controls.Add(roleValueLabel);
            Controls.Add(roleLabel);
            Controls.Add(addressTextBox);
            Controls.Add(addressLabel);
            Controls.Add(nameTextBox);
            Controls.Add(nameLabel);
            Name = "MyProfile";
            Size = new Size(613, 521);
            ((System.ComponentModel.ISupportInitialize)profilePictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
    }
}
