using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATA_ACCES_LAYER.Model
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public string Adress { get; set; } = string.Empty;
         
        public string Role {  get; set; } = string.Empty;

        public string ProfilePicture {  get; set; } = string.Empty;

        public User(  string name, string role, string profilePicture)
        {
             
            Name = name;
            Role = role;
            ProfilePicture = profilePicture;
        }

    }

}
