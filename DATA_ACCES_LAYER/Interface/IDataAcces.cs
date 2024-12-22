using DATA_ACCES_LAYER.Model;
using DATA_ACCES_LAYER.Response_ErrorHandling;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATA_ACCES_LAYER.Interface
{
    public interface IDataAcces
    {

        public ResponseObject<Animal> AddAnimal(Animal animal);
        public ResponseObject<Animal> GetAnimalById(int id);
        public ResponseObject<Animal> UpdateAnimal(Animal animal);

        public ResponseObject<Animal> RemoveAnimal(int id);

        public ResponseObject<Animal> GetAllAnimal();

        public ResponseObject<Animal> GetAnimalBySpecie(string specie);
        public ResponseObject<Animal> GetAnimalByName(string name);
        public ResponseObject<User> AddUser(User user);
        public ResponseObject<User> UpdateUser(User user) ;

        public ResponseObject<User> GetUserById(int id);

        public ResponseObject<User> GetAllUsers();

        public ResponseObject<User> DeleteUser(int userId);
        public ResponseObject<User> AuthenticateUser(string username, string password);
    }
}
