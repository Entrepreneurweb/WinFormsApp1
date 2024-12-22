using DATA_ACCES_LAYER.Interface;
using DATA_ACCES_LAYER.Model;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;
using System.Windows.Forms;

namespace WinFormsApp1
{
    internal static class Program
    {
        [STAThread]
        static void Main() 
        {
            var services = new ServiceCollection();
            ConfigureService(services);

            var serviceProvider = services.BuildServiceProvider();

            // V�rifier si un utilisateur admin existe et le cr�er si n�cessaire
            SeedDatabase(serviceProvider);

            var mainService = serviceProvider.GetRequiredService<Login>();

            Application.Run(mainService);
        }

        public static void ConfigureService(ServiceCollection services)
        {
            services.AddSingleton<IDataAcces, DataAcces>();
            services.AddTransient<Form1>();
            services.AddTransient<NewAnimal>();
            services.AddTransient<Login>();
        }

        // M�thode pour ajouter un utilisateur admin si non existant
        private static void SeedDatabase(IServiceProvider serviceProvider)
        {
            var dataAccess = serviceProvider.GetRequiredService<IDataAcces>();

            // V�rifier si un utilisateur admin existe
            var adminResponse = dataAccess.GetAllUsers();

            if (adminResponse.success && (adminResponse.Object == null || !adminResponse.Object.Any(user => user.Role == "admin")))
            {
                // Si aucun utilisateur admin n'existe, en cr�er un
                User adminUser = new User("admin", "admin", "admin.png");
                adminUser.Password = "admin";
                adminUser.Adress = "test";
                

                // Ajouter l'utilisateur admin dans la base de donn�es
                var addUserResponse = dataAccess.AddUser(adminUser);

                if (addUserResponse.success)
                {
                    Console.WriteLine("Admin user created successfully.");
                }
                else
                {
                    Console.WriteLine("Failed to create admin user. Error: " + addUserResponse.Message);
                }
            }
            else if (!adminResponse.success)
            {
                Console.WriteLine("Failed to retrieve users. Error: " + adminResponse.Message);
            }
        }
    }
}
