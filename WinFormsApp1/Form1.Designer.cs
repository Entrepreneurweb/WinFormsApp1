namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            flowLayoutPanel1 = new FlowLayoutPanel();
            pictureBox1 = new PictureBox();
            welcomeLabel = new Label();
            Home = new Button();
            Statistics = new Button();
            MyProfile = new Button();
            OtherUsers = new Button();
            About_Us = new Button();
            PanelDisplay = new Panel();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = SystemColors.ControlDark;
            flowLayoutPanel1.Controls.Add(pictureBox1);
            flowLayoutPanel1.Controls.Add(welcomeLabel);
            flowLayoutPanel1.Controls.Add(Home);
            flowLayoutPanel1.Controls.Add(Statistics);
            flowLayoutPanel1.Controls.Add(MyProfile);
            flowLayoutPanel1.Controls.Add(OtherUsers);
            flowLayoutPanel1.Controls.Add(About_Us);
            flowLayoutPanel1.Dock = DockStyle.Left;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(237, 753);
            flowLayoutPanel1.TabIndex = 18;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;  // Cette ligne permet de redimensionner l'image tout en la centrant
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(231, 224);  // Assurez-vous que la taille du PictureBox est bien définie
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // welcomeLabel
            // 
            welcomeLabel.AutoSize = true;
            welcomeLabel.Font = new Font("Segoe Print", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            welcomeLabel.Location = new Point(3, 230);
            welcomeLabel.Name = "welcomeLabel";
            welcomeLabel.Size = new Size(152, 31);
            welcomeLabel.TabIndex = 1;
            welcomeLabel.Text = "Welcome, User!";
            // 
            // Home
            // 
            Home.BackColor = SystemColors.ButtonHighlight;
            Home.BackgroundImageLayout = ImageLayout.Stretch;
            Home.Font = new Font("Segoe Print", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Home.Image = (Image)resources.GetObject("Home.Image");
            Home.ImageAlign = ContentAlignment.MiddleLeft;
            Home.Location = new Point(3, 264);
            Home.Name = "Home";
            Home.Size = new Size(231, 66);
            Home.TabIndex = 1;
            Home.Text = "HOME";
            Home.UseVisualStyleBackColor = false;
            Home.Click += Home_Click;
            // 
            // Statistics
            // 
            Statistics.BackColor = SystemColors.ButtonHighlight;
            Statistics.Font = new Font("Segoe Print", 10.8F, FontStyle.Bold);
            Statistics.Image = (Image)resources.GetObject("Statistics.Image");
            Statistics.ImageAlign = ContentAlignment.MiddleLeft;
            Statistics.Location = new Point(3, 336);
            Statistics.Name = "Statistics";
            Statistics.Size = new Size(231, 66);
            Statistics.TabIndex = 3;
            Statistics.Text = "STATISTICS";
            Statistics.UseVisualStyleBackColor = false;
            Statistics.Click += Statistics_Click;
            // 
            // MyProfile
            // 
            MyProfile.BackColor = SystemColors.ButtonHighlight;
            MyProfile.Font = new Font("Segoe Print", 10.8F, FontStyle.Bold);
            MyProfile.Image = (Image)resources.GetObject("MyProfile.Image");
            MyProfile.ImageAlign = ContentAlignment.MiddleLeft;
            MyProfile.Location = new Point(3, 408);
            MyProfile.Name = "MyProfile";
            MyProfile.Size = new Size(231, 66);
            MyProfile.TabIndex = 2;
            MyProfile.Text = "MY PROFILE";
            MyProfile.UseVisualStyleBackColor = false;
            MyProfile.Click += MyProfile_Click;
            // 
            // OtherUsers
            // 
            OtherUsers.BackColor = SystemColors.ButtonHighlight;
            OtherUsers.Font = new Font("Segoe Print", 10.8F, FontStyle.Bold);
            OtherUsers.Image = (Image)resources.GetObject("OtherUsers.Image");
            OtherUsers.ImageAlign = ContentAlignment.MiddleLeft;
            OtherUsers.Location = new Point(3, 480);
            OtherUsers.Name = "OtherUsers";
            OtherUsers.Size = new Size(231, 66);
            OtherUsers.TabIndex = 3;
            OtherUsers.Text = "OTHER USERS";
            OtherUsers.UseVisualStyleBackColor = false;
            OtherUsers.Click += OtherUsers_Click;
            // 
            // About_Us
            // 
            About_Us.BackColor = SystemColors.ButtonHighlight;
            About_Us.Font = new Font("Segoe Print", 10.8F, FontStyle.Bold);
            About_Us.Image = (Image)resources.GetObject("About_Us.Image");
            About_Us.ImageAlign = ContentAlignment.MiddleLeft;
            About_Us.Location = new Point(3, 552);
            About_Us.Name = "About_Us";
            About_Us.Size = new Size(231, 66);
            About_Us.TabIndex = 4;
            About_Us.Text = "ABOUT US...";
            About_Us.UseVisualStyleBackColor = false;
            About_Us.Click += About_Us_Click;
            // 
            // PanelDisplay
            // 
            PanelDisplay.Location = new Point(240, 12);
            PanelDisplay.Name = "PanelDisplay";
            PanelDisplay.Size = new Size(782, 741);
            PanelDisplay.TabIndex = 19;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.HighlightText;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1023, 753);
            Controls.Add(PanelDisplay);
            Controls.Add(flowLayoutPanel1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Form1";
            Opacity = 0.98D;
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LAST HOPE";
            Load += Form1_Load;
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private PictureBox pictureBox1;
        private Button Home;
        private Button MyProfile;
        private Button OtherUsers;
        private Button About_Us;
        private Panel PanelDisplay;
        private Button Statistics;
        private Label welcomeLabel; // Added label for the welcome message
    }
}
