using DATA_ACCES_LAYER.Interface;
using DATA_ACCES_LAYER.Model;
using DATA_ACCES_LAYER.Response_ErrorHandling;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WinFormsApp1.Controls
{
    public partial class UsersControl : UserControl
    {
        private readonly IDataAcces _dataAcces;
        public User ConnectedUser;
        private List<User> users;
        private int IdTodelete=-1;
        public UsersControl(IDataAcces dataAcces)
        {
            _dataAcces = dataAcces;
            InitializeComponent();
            users = new List<User>(); // Initialisation de la liste des utilisateurs
            LoadUsers(); // Charger les utilisateurs au démarrage
            SetAddButtonVisibility(); // Vérifier le rôle de l'utilisateur connecté et ajuster la visibilité du bouton
            SetDeleteButtonVisibility(); // Vérifier la visibilité du bouton de suppression
        }

        public void LoadConnectedUser(User user)
        {
            this.ConnectedUser = user;
            SetAddButtonVisibility(); // Mettre à jour la visibilité du bouton d'ajout
            SetDeleteButtonVisibility(); // Mettre à jour la visibilité du bouton de suppression
        }

        // Méthode pour charger les utilisateurs dans le DataGridView
        private void LoadUsers()
        {
            ResponseObject<User> UserList = _dataAcces.GetAllUsers();

            // Configuration manuelle du DataGridView
            usersDataGridView.AutoGenerateColumns = false; // Désactiver la génération automatique des colonnes
            usersDataGridView.Columns.Clear(); // Supprimer toutes les colonnes existantes

            // Ajouter la colonne Id
            usersDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Id",
                DataPropertyName = "Id" // Correspond à la propriété dans la classe User
            });

            // Ajouter la colonne Name
            usersDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Name",
                DataPropertyName = "Name" // Correspond à la propriété dans la classe User
            });

            // Ajouter la colonne Role
            usersDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Role",
                DataPropertyName = "Role" // Correspond à la propriété dans la classe User
            });

            // Ajouter la colonne Address
            usersDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Address",
                DataPropertyName = "address" // Correspond à la propriété dans la classe User
            });

            // Lier la liste des utilisateurs au DataGridView
            usersDataGridView.DataSource = UserList.Object;
        }

        // Méthode pour récupérer les informations de l'utilisateur lors d'un clic sur une cellule
        private void usersDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Vérifiez que l'index de la ligne est valide
            if (e.RowIndex >= 0)
            {
                // Récupérez la ligne sélectionnée
                var row = usersDataGridView.Rows[e.RowIndex];

                // Créez un nouvel objet User et affectez les valeurs des cellules


                int Id = Convert.ToInt32(row.Cells[0].Value); // Remplacez "Id" par le nom exact de la colonne

                this.IdTodelete = Id;

                // Affichez les informations de l'objet pour vérification
                MessageBox.Show($"Id: {Id} seleted ");


            }
        }

        // Méthode pour ajouter un utilisateur
        private void AddUser()
        {
            var addUserForm = new AddUserForm(_dataAcces);
            if (addUserForm.ShowDialog() == DialogResult.OK)
            {
                var newUser = addUserForm.NewUser;
                users.Add(newUser);
                LoadUsers();
            }
        }

        // Méthode pour supprimer un utilisateur
       

        // Click sur le bouton "Ajouter un utilisateur"
        private void addButton_Click(object sender, EventArgs e)
        {
            AddUser();
        }

        // Click sur le bouton "Supprimer un utilisateur"
        private void deleteButton_Click(object sender, EventArgs e)
        {

            if( this.IdTodelete != -1 )
            {

                ResponseObject<User> response = _dataAcces.DeleteUser(this.IdTodelete);
                if (response.success == true)
                {
                    MessageBox.Show(" deleted succesfully");
                    ResponseObject<User> newresponse = _dataAcces.GetAllUsers();
                    usersDataGridView.DataSource = newresponse.Object;
                }
                else
                {
                    MessageBox.Show(" something wrong happened");
                }
                this.IdTodelete = -1;
            }
            else
            {
                MessageBox.Show("  NO user selected ");
            }

        }

        // Méthode pour définir la visibilité du bouton "Ajouter un utilisateur"
        private void SetAddButtonVisibility()
        {
            if (ConnectedUser == null || ConnectedUser.Role != "admin")
            {
                addButton.Visible = false;
            }
            else
            {
                addButton.Visible = true;
            }
        }

        // Méthode pour définir la visibilité du bouton "Supprimer un utilisateur"
        private void SetDeleteButtonVisibility()
        {
            if (ConnectedUser == null || ConnectedUser.Role != "admin")
            {
                deleteButton.Visible = false;
            }
            else
            {
                deleteButton.Visible = true;
            }
        }
    }
}
