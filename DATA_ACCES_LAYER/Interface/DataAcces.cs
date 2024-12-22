using DATA_ACCES_LAYER.Model;
using DATA_ACCES_LAYER.Response_ErrorHandling;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Microsoft.Extensions.Logging;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace DATA_ACCES_LAYER.Interface
{
    public class DataAcces : IDataAcces
    {
       public string ConnectionStr = "Data Source=EXOPC\\SQLEXPRESS;Initial Catalog = ANIMALSHELTER; Integrated Security = True; Encrypt=True;TrustServerCertificate=True";

       
       
         

       public  ResponseObject<Animal>  AddAnimal(Animal animal)
        {
            ResponseObject<Animal> Response = new ResponseObject<Animal>();
            try
            {
                using (var con = new SqlConnection(ConnectionStr))
                {

                     
                        var cmd = new SqlCommand(" INSERT INTO Animals (Nom, Species, Age,gender,  ArrivalDate) VALUES (@Nom, @Species, @Age,@gender,  @ArrivalDate)", con);
                        cmd.Parameters.AddWithValue("@Nom", animal.Name);
                        cmd.Parameters.AddWithValue("@Species", animal.Species);
                        cmd.Parameters.AddWithValue("@Age", animal.Age);
                        cmd.Parameters.AddWithValue("@ArrivalDate", animal.ArrivalDate);
                        cmd.Parameters.AddWithValue("@gender", animal.Gender);

                        con.Open();
                        cmd.ExecuteNonQuery();
                    
                }

                Response.success= true;
                Response.Message = "Added with succees";
               
                return Response;
            }
            catch (Exception ex)
            {
                Response.success = false;
                Response.Message =  ex.Message  ;
                
                return Response;
                 
            }

           
            //throw new NotImplementedException();
        }




        public ResponseObject<Animal> GetAnimalById(int id)
        {
            ResponseObject<Animal> response = new ResponseObject<Animal>();
            try
            {
                using (var con = new SqlConnection(ConnectionStr))
                {
                    var cmd = new SqlCommand("SELECT Id, Nom, Species, Age,gender,  ArrivalDate FROM Animals WHERE Id = @Id", con);
                    cmd.Parameters.AddWithValue("@Id", id);
                    con.Open();

                    using (var reader = cmd.ExecuteReader())
                    {
                        List<Animal> animals = new List<Animal>();
                        while (reader.Read())
                        {
                            var animal = new Animal
                            {
                                Id = (int)reader["Id"],
                                Name = reader["Nom"] as string,
                                Species = reader["Species"] as string,
                                Age = (int)reader["Age"],
                                ArrivalDate = (DateTime)reader["ArrivalDate"]
                            };
                           animals.Add(animal);
                           
                        }
                        response.success = true;
                        response.Message = "Animal retrieved successfully";
                        response.Object = animals;

                    }
                }
            }
            catch (Exception ex)
            {
                response.success = false;
                response.Message = "Something went wrong";
 
            }

            return response;
        }

              
 

        public ResponseObject<Animal> UpdateAnimal(Animal animal)
        {
            ResponseObject<Animal> response = new ResponseObject<Animal>();
            try
            {
                using (var con = new SqlConnection(ConnectionStr))
                {
                    var cmd = new SqlCommand("UPDATE Animals SET Name = @Name, Species = @Species, Age = @Age, ArrivalDate = @ArrivalDate WHERE Id = @Id", con);
                    cmd.Parameters.AddWithValue("@Id", animal.Id);
                    cmd.Parameters.AddWithValue("@Name", animal.Name);
                    cmd.Parameters.AddWithValue("@Species", animal.Species);
                    cmd.Parameters.AddWithValue("@Age", animal.Age);
                    cmd.Parameters.AddWithValue("@ArrivalDate", animal.ArrivalDate);

                    con.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        response.success = true;
                        response.Message = "Animal updated successfully";
                    }
                    else
                    {
                        response.success = false;
                        response.Message = "Animal not found";
                    }
                }
            }
            catch (Exception ex)
            {
                response.success = false;
                response.Message = "Something went wrong";
             
            }

            return response;
        }



        public ResponseObject<Animal> RemoveAnimal(int id)
        {
            ResponseObject<Animal> response = new ResponseObject<Animal>();
            try
            {
                using (var con = new SqlConnection(ConnectionStr))
                {
                    var cmd = new SqlCommand("DELETE FROM Animals WHERE Id = @Id", con);
                    cmd.Parameters.AddWithValue("@Id", id);

                    con.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        response.success = true;
                        response.Message = "Animal deleted successfully";
                    }
                    else
                    {
                        response.success = false;
                        response.Message = "Animal not found";
                    }
                }
            }
            catch (Exception ex)
            {
                response.success = false;
                response.Message = "Something went wrong";
             
            }

            return response;
        }


        // GET ANIMAL 
        public ResponseObject<Animal> GetAllAnimal()
        {
            ResponseObject<Animal> response = new ResponseObject<Animal>();
            try
            {
                using (var con = new SqlConnection(ConnectionStr))
                {
                    var cmd = new SqlCommand("SELECT Id, Nom, Species, Age, gender, ArrivalDate FROM Animals", con);
                    con.Open();

                    using (var reader = cmd.ExecuteReader())
                    {
                        List<Animal> animals = new List<Animal>();

                        while (reader.Read())
                        {
                            var animal = new Animal
                            {
                                Id = (int)reader["Id"],
                                Name = reader["Nom"] as string,
                                Species = reader["Species"] as string,
                                Age = (int)reader["Age"],
                                Gender = reader["gender"] as string,
                                ArrivalDate = (DateTime)reader["ArrivalDate"]
                            };

                            animals.Add(animal);
                        }

                        response.success = true;
                        response.Message = "Animals retrieved successfully";
                        response.Object = animals;
                    }
                }
            }
            catch (Exception ex)
            {
                response.success = false;
                response.Message = "Something went wrong: " + ex.Message;
            }

            return response;
        }

       public  ResponseObject<Animal> GetAnimalBySpecie(string specie)
        {
            ResponseObject<Animal> response = new ResponseObject<Animal>();
            try
            {
                using (var con = new SqlConnection(ConnectionStr))
                {
                    var cmd = new SqlCommand("SELECT Id, Nom, Species, Age,gender,  ArrivalDate FROM Animals WHERE Species = @Species", con);
                    cmd.Parameters.AddWithValue("@Species", specie);
                    con.Open();

                    using (var reader = cmd.ExecuteReader())
                    {
                        List<Animal> animals = new List<Animal>();
                        while (reader.Read())
                        {
                            var animal = new Animal
                            {
                                Id = (int)reader["Id"],
                                Name = reader["Nom"] as string,
                                Species = reader["Species"] as string,
                                Age = (int)reader["Age"],
                                ArrivalDate = (DateTime)reader["ArrivalDate"]
                            };

                            animals.Add(animal);
                        }
                        response.success = true;
                        response.Message = "Animal retrieved successfully";
                       
                        response.Object = animals;

                    }
                }
            }
            catch (Exception ex)
            {
                response.success = false;
                response.Message =  ex.Message;

            }

            return response;
        }

       public  ResponseObject<Animal> GetAnimalByName(string name)
        {
            ResponseObject<Animal> response = new ResponseObject<Animal>();
            try
            {
                using (var con = new SqlConnection(ConnectionStr))
                {
                    var cmd = new SqlCommand("SELECT Id, Nom, Species, Age,gender,  ArrivalDate FROM Animals WHERE Nom = @Nom", con);
                    cmd.Parameters.AddWithValue("@Nom", name);
                    con.Open();

                    using (var reader = cmd.ExecuteReader())
                    {
                        List<Animal> animals = new List<Animal>();

                        while (reader.Read())
                        {
                            var animal = new Animal
                            {
                                Id = (int)reader["Id"],
                                Name = reader["Nom"] as string,
                                Species = reader["Species"] as string,
                                Age = (int)reader["Age"],
                                ArrivalDate = (DateTime)reader["ArrivalDate"]
                            };

                            animals.Add(animal);
                        }
                        response.success = true;
                        response.Message = "Animal retrieved successfully";
                        response.Object = animals ;

                    }
                }
            }
            catch (Exception ex)
            {
                response.success = false;
                response.Message = "Something went wrong";

            }

            return response;
        }

        // Ajouter un utilisateur à la table Users
        public ResponseObject<User> AddUser(User user)
        {
            ResponseObject<User> response = new ResponseObject<User>();
            try
            {
                using (var con = new SqlConnection(ConnectionStr))
                {
                    // Mise à jour de la requête SQL pour inclure l'adresse
                    var cmd = new SqlCommand("INSERT INTO Users (Name, Password, Role, ProfilePicture, Adress ) VALUES (@Username, @Password, @Role, @ProfilePicture, @Address)", con);

                    cmd.Parameters.AddWithValue("@Username", user.Name);  // Nom d'utilisateur
                    cmd.Parameters.AddWithValue("@Password", user.Password); // Mot de passe
                    cmd.Parameters.AddWithValue("@Role", user.Role); // Rôle (admin, user)
                    cmd.Parameters.AddWithValue("@ProfilePicture", user.ProfilePicture); // Chemin vers l'image de profil
                    cmd.Parameters.AddWithValue("@Address", user.Adress); // Adresse de l'utilisateur (nouveau paramètre)

                    con.Open();
                    cmd.ExecuteNonQuery();

                    response.success = true;
                    response.Message = "Utilisateur ajouté avec succès";
                }
            }
            catch (Exception ex)
            {
                response.success = false;
                response.Message = "Quelque chose s'est mal passé : " + ex.Message;
            }

            return response;
        }

        // delete user
        public ResponseObject<User> DeleteUser(int userId)
        {
            ResponseObject<User> response = new ResponseObject<User>();
            try
            {
                using (var con = new SqlConnection(ConnectionStr))
                {
                    // Requête SQL pour supprimer l'utilisateur par ID
                    var cmd = new SqlCommand("DELETE FROM Users WHERE Id = @UserId", con);
                    cmd.Parameters.AddWithValue("@UserId", userId); // ID de l'utilisateur

                    con.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        response.success = true;
                        response.Message = "Utilisateur supprimé avec succès";
                    }
                    else
                    {
                        response.success = false;
                        response.Message = "Utilisateur introuvable ou déjà supprimé";
                    }
                }
            }
            catch (Exception ex)
            {
                response.success = false;
                response.Message = "Quelque chose s'est mal passé : " + ex.Message;
            }

            return response;
        }


        // update use 
        public ResponseObject<User> UpdateUser(User user)
        {
            ResponseObject<User> response = new ResponseObject<User>();
            try
            {
                using (var con = new SqlConnection(ConnectionStr))
                {
                    var cmd = new SqlCommand(
                        @"UPDATE Users 
                  SET Name = @Name, 
                     
                      Adress = @Adress, 
                      Role = @Role, 
                      ProfilePicture = @ProfilePicture 
                  WHERE Id = @Id",
                        con);

                    // Ajouter les paramètres
                    cmd.Parameters.AddWithValue("@Id", user.Id); // Identifiant de l'utilisateur
                    cmd.Parameters.AddWithValue("@Name", user.Name); // Nom
                    
                    cmd.Parameters.AddWithValue("@Adress", user.Adress); // Adresse
                    cmd.Parameters.AddWithValue("@Role", user.Role); // Rôle (admin, utilisateur)
                    cmd.Parameters.AddWithValue("@ProfilePicture", user.ProfilePicture); // Chemin vers l'image de profil

                    // Ouvrir la connexion et exécuter la commande
                    con.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();

                    // Vérifier si la mise à jour a été effectuée
                    if (rowsAffected > 0)
                    {
                        response.success = true;
                        response.Message = "Utilisateur mis à jour avec succès.";
                    }
                    else
                    {
                        response.success = false;
                        response.Message = "Utilisateur non trouvé.";
                    }
                }
            }
            catch (Exception ex)
            {
                // Gestion des erreurs
                response.success = false;
                response.Message = "Une erreur est survenue : " + ex.Message;
            }

            return response;
        }

        // get user by Id
        // Récupérer un utilisateur par son identifiant
        public ResponseObject<User> GetUserById(int id)
        {
            ResponseObject<User> response = new ResponseObject<User>();
            try
            {
                using (var con = new SqlConnection(ConnectionStr))
                {
                    var cmd = new SqlCommand("SELECT Id, Name, Role, ProfilePicture FROM Users WHERE Id = @Id", con);
                    cmd.Parameters.AddWithValue("@Id", id);
                    con.Open();

                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            

                            int Id = (int)reader["Id"];
                            string Name = reader["Name"] as string;
                            string Role = reader["Role"] as string;
                            string ProfilePicture = reader["ProfilePicture"] as string;
                            User user = new User(Name, Role, ProfilePicture);

                            response.success = true;
                            response.Message = "Utilisateur récupéré avec succès";
                            response.Object = new List<User> { user };
                        }
                        else
                        {
                            response.success = false;
                            response.Message = "Utilisateur non trouvé";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                response.success = false;
                response.Message = "Quelque chose s'est mal passé : " + ex.Message;
            }

            return response;
        }
        // get all users

        // Récupérer tous les utilisateurs
        public ResponseObject<User> GetAllUsers()
        {
            ResponseObject<User> response = new ResponseObject<User>();
            try
            {
                using (var con = new SqlConnection(ConnectionStr))
                {
                    var cmd = new SqlCommand("SELECT Id, Name,Adress  , Role, ProfilePicture FROM Users", con);
                    con.Open();

                    using (var reader = cmd.ExecuteReader())
                    {
                        List<User> users = new List<User>();

                        while (reader.Read())
                        {
                            int Id = (int)reader["Id"];
                            string Name = (string)reader["Name"];
                            string Address =  (string)reader["Adress"]  ;  // Valeur par défaut si null
                            string Role = (string)reader["Role"];
                            string ProfilePicture = (string)reader["ProfilePicture"];

                            User user = new User(Name, Role, ProfilePicture)
                            {
                                Id = Id,
                                Adress = Address // Assigner l'adresse
                            };

                            users.Add(user);
                        }


                        response.success = true;
                        response.Message = "Utilisateurs récupérés avec succès";
                        response.Object = users;
                    }
                }
            }
            catch (Exception ex)
            {
                response.success = false;
                response.Message = "Quelque chose s'est mal passé : " + ex.Message;
            }

            return response;
        }


        // Authentifier un utilisateur en vérifiant le nom d'utilisateur et le mot de passe

         

        // new auth fonction 
        public ResponseObject<User> AuthenticateUser(string username, string password)
        {
            ResponseObject<User> response = new ResponseObject<User>();
            try
            {
                using (var con = new SqlConnection(ConnectionStr))
                {
                    var cmd = new SqlCommand("SELECT Id, Name, Password,Adress, Role, ProfilePicture FROM Users WHERE Name = @Username", con);
                    cmd.Parameters.AddWithValue("@Username", username);
                    con.Open();

                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Récupération des informations de l'utilisateur depuis la base de données
                            string storedPassword = reader["Password"] as string; // Mot de passe stocké dans la base de données
                            string enteredPassword = password?.Trim(); // Mot de passe entré par l'utilisateur

                            // Comparaison des mots de passe
                            if (storedPassword == enteredPassword)
                            {
                                int id = (int)reader["Id"];
                                string name = reader["Name"] as string;
                                string role = reader["Role"] as string;
                                
                                string Adress = reader["Adress"] as string;
                                string profilePicture = reader["ProfilePicture"] as string;

                                // Créer l'objet User à partir des données récupérées
                                User user = new User(name, role, profilePicture);
                                user.Adress = Adress;
                                user.Id = id;
                                user.Password = storedPassword;

                                // Préparer la réponse avec succès
                                response.success = true;
                                response.Message = "Utilisateur authentifié avec succès";
                                response.Object = new List<User> { user }; // Retourner l'utilisateur authentifié dans une liste
                            }
                            else
                            {
                                response.success = false;
                                response.Message = "Mot de passe invalide"; // Si le mot de passe ne correspond pas
                            }
                        }
                        else
                        {
                            response.success = false;
                            response.Message = "Utilisateur non trouvé"; // Si l'utilisateur n'existe pas
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                response.success = false;
                response.Message = "Quelque chose s'est mal passé : " + ex.Message; // Si une erreur se produit
            }

            return response;
        }





    }
}
