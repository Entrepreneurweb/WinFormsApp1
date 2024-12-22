using DATA_ACCES_LAYER.Interface;
using DATA_ACCES_LAYER.Model;
using DATA_ACCES_LAYER.Response_ErrorHandling;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;
using WinFormsApp1.Controls;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private readonly IDataAcces _dataAcces;
        private HomeControl MyHomeControl;
        private readonly IServiceProvider _serviceProvider;

         
        public User CurrentUser { get; set; }

        public Form1(IDataAcces dataAcces, IServiceProvider serviceProvider)
        {
            _dataAcces = dataAcces;
            InitializeComponent();
            _serviceProvider = serviceProvider;
            LoadView(new HomeControl(_dataAcces, _serviceProvider));
        }

        void LoadView(UserControl view)
        {
            PanelDisplay.Controls.Clear();
            view.Dock = DockStyle.Fill;
            PanelDisplay.Controls.Add(view);
        }

        // Méthode pour définir l'utilisateur connecté et mettre à jour l'interface
        public void SetLoggedInUser(User user)
        {
            this.CurrentUser = user;

            // Mise à jour du message de bienvenue
            welcomeLabel.Text = $"Welcome, {user.Name}!";  // Modifiez ici pour le format que vous souhaitez
            welcomeLabel.Visible = true;

            // Mise à jour de l'image de profil
            if (!string.IsNullOrEmpty(user.ProfilePicture))
            {
                try
                {
                    pictureBox1.ImageLocation = user.ProfilePicture;  // Charger l'image à partir du chemin spécifié
                    pictureBox1.Load();
                }
                catch (Exception)
                {
                    // Gestion d'erreur si l'image ne peut pas être chargée
                    pictureBox1.Image = null;
                }
            }
        }

        //

        private void About_Us_Click(object sender, EventArgs e)
        {
            LoadView(new AboutUs());
        }

        private void Home_Click(object sender, EventArgs e)
        {
            LoadView(new HomeControl(_dataAcces, _serviceProvider));
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Event handling logic on form load if any
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // PictureBox click event if needed
        }

        private void Statistics_Click(object sender, EventArgs e)
        {
            LoadView(new Statistics(_dataAcces));
        }

        private void OtherUsers_Click(object sender, EventArgs e)
        {
            UsersControl usersControl = new UsersControl(_dataAcces);
            usersControl.LoadConnectedUser( CurrentUser );
            LoadView(usersControl);
        }
         
        private void MyProfile_Click(object sender, EventArgs e)
        {
             

            // Créer le contrôle MyProfile et passer l'objet _dataAcces
            MyProfile myProfile = new MyProfile(_dataAcces);

            // Charger l'utilisateur dans le contrôle MyProfile
            myProfile.LoadUser(this.CurrentUser);

            // Charger la vue avec le contrôle MyProfile
            LoadView(myProfile);
        }

    }
}
