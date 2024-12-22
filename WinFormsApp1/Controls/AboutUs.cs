using System;
using System.Drawing;
using System.Windows.Forms;

namespace WinFormsApp1.Controls
{
    public partial class AboutUs : UserControl
    {
        public AboutUs()
        {
            InitializeComponent();
            InitializeAboutUsContent();
        }

        private void AboutUs_Load(object sender, EventArgs e)
        {
            // Actions à effectuer lors du chargement (optionnel)
        }

        private void InitializeAboutUsContent()
        {
            // Titre du panneau
            var titleLabel = new Label
            {
                Text = "About Us",
                Font = new Font("Segoe Print", 20, FontStyle.Bold), // Police et style du texte
                ForeColor = Color.DarkGreen,
                AutoSize = false, // Désactivation de la taille automatique pour contrôler la hauteur et la largeur
                Size = new Size(this.Width, 60), // Largeur et hauteur explicites
                TextAlign = ContentAlignment.MiddleCenter,
                Padding = new Padding(0), // Supprime les marges internes
                Margin = new Padding(0), // Supprime les marges externes
                Dock = DockStyle.Top // Positionnement automatique en haut du contrôle
            };

            // Contenu principal
            var contentLabel = new Label
            {
                Text = "Welcome to the Animal Shelter!\n\n" +
                       "Our mission is to provide a safe and loving environment for animals in need. " +
                       "We rescue, care for, and find forever homes for pets of all kinds.\n\n" +
                       "Thank you for supporting our efforts to create a better world for animals!",
                Font = new Font("Segoe Print", 10.8f, FontStyle.Bold), // Police spécifiée
                ForeColor = Color.Black,
                Dock = DockStyle.Fill, // Remplit le reste de l'espace disponible
                Padding = new Padding(20),
                TextAlign = ContentAlignment.TopLeft
            };

            // Ajouter les composants au contrôle
            this.Controls.Add(contentLabel);
            this.Controls.Add(titleLabel);

            // Configuration de l'arrière-plan
            this.BackColor = Color.WhiteSmoke;
        }
    }
}
