using DATA_ACCES_LAYER.Interface;
using DATA_ACCES_LAYER.Model;
using DATA_ACCES_LAYER.Response_ErrorHandling;
using Microsoft.Extensions.DependencyInjection;
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
    public partial class HomeControl : UserControl
    {
        private readonly IDataAcces _dataAcces;
         private readonly IServiceProvider _serviceProvider;
        public HomeControl(IDataAcces dataAcces, IServiceProvider serviceProvider)
        {
            _dataAcces = dataAcces;
            InitializeComponent();
            _serviceProvider = serviceProvider;
            //  dataGridView1.ColumnHeaderMouseClick+=MessageBox.Show("")
             

            LoadData();
        }

        private void LoadData()
        {
            ResponseObject<Animal> response = _dataAcces.GetAllAnimal();
            dataGridView1.DataSource = response.Object;

        }
        private void HomeControl_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Vérifiez que l'index de la ligne est valide
            if (e.RowIndex >= 0)
            {
                // Récupérez la ligne sélectionnée
                var row = dataGridView1.Rows[e.RowIndex];

                // Créez un nouvel objet Animal et affectez les valeurs des cellules
                Animal animal = new Animal
                {
                    Id = Convert.ToInt32(row.Cells["Id"].Value), // Remplacez "Id" par le nom exact de la colonne
                    Name = row.Cells["Name"].Value?.ToString(),
                    Species = row.Cells["Species"].Value?.ToString(),
                    Gender = row.Cells["Gender"].Value?.ToString(),
                    Age = Convert.ToDouble(row.Cells["Age"].Value),
                    ArrivalDate = Convert.ToDateTime(row.Cells["ArrivalDate"].Value)
                };

                // Affichez les informations de l'objet pour vérification
                MessageBox.Show($"Id: {animal.Id}\nName: {animal.Name}\nSpecies: {animal.Species}\nGender: {animal.Gender}\nAge: {animal.Age}\nArrivalDate: {animal.ArrivalDate}");
            }
        }



        private void button1_Click(object sender, EventArgs e)
        {
            NewAnimal newAnimalForm =  _serviceProvider.GetRequiredService< NewAnimal>();
            newAnimalForm.Show();
            
        }

        
    }
}
