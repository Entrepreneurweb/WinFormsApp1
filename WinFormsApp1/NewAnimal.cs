using DATA_ACCES_LAYER.Interface;
using DATA_ACCES_LAYER.Model;
using DATA_ACCES_LAYER.Response_ErrorHandling;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WinFormsApp1
{
    public partial class NewAnimal : Form
    {
        private readonly IDataAcces _dataAcces;

        public NewAnimal(IDataAcces dataAcces)
        {
            _dataAcces = dataAcces;
            InitializeComponent();

            // Initialisation des éléments de l'interface
            SPECIES.Items.Clear();
            SPECIES.Items.Add("DOG");
            SPECIES.Items.Add("CAT");
            SPECIES.Items.Add("HORSE");
            SPECIES.Items.Add("CHICKEN");
            SPECIES.Items.Add("PIG");

            // Filtrer l'entrée de l'âge pour permettre uniquement les chiffres
            AGE.KeyPress += textBox3_KeyPress;
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Vérifie que l'entrée est un chiffre ou un point décimal
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) &&
                (e.KeyChar != '.' || AGE.Text.Contains(".")))
            {
                e.Handled = true;
            }
        }

        private void Add_Click(object sender, EventArgs e)
        {
            bool submit = true;
            List<string> FormError = new List<string>();
            string gender = string.Empty;

            // Détection du genre sélectionné
            if (FEMALE.Checked)
            {
                gender = "Female";
            }
            else if (MALE.Checked)
            {
                gender = "Male";
            }

            Animal animal = new Animal
            {
                Name = NameTextBox.Text,
                ArrivalDate = Date.Value,
                Gender = gender,
                Species = SPECIES.Text
            };

            // Vérification de l'âge
            if (double.TryParse(AGE.Text, out double age))
            {
                animal.Age = age;
            }
            else
            {
                submit = false;
                FormError.Add("Enter Age");
            }

            // Validation du nom
            if (string.IsNullOrWhiteSpace(animal.Name))
            {
                FormError.Add("Name can't be empty");
                submit = false;
            }

            // Validation du genre
            if (string.IsNullOrWhiteSpace(animal.Gender))
            {
                FormError.Add("Gender can't be empty");
                submit = false;
            }

            // Validation de l'espèce
            if (string.IsNullOrWhiteSpace(animal.Species))
            {
                FormError.Add("Specie can't be empty");
                submit = false;
            }

            // Si les validations sont réussies, ajouter l'animal
            if (submit)
            {
                var response = _dataAcces.AddAnimal(animal);
                MessageBox.Show("Added successfully");
            }
            else
            {
                // Affichage des erreurs
                string message = string.Join(Environment.NewLine, FormError);
                MessageBox.Show(message);
            }
        }
    }
}
