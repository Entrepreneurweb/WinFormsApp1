using DATA_ACCES_LAYER.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATA_ACCES_LAYER.Model
{
    public class DATA_MODEL  
    {

        string ConnectionStr = "Data Source=EXOPC\\SQLEXPRESS;Initial Catalog=YourDatabase;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
        public IEnumerable<User> FetchCustomers()
        {

            List<User> ReturnList = new List<User>();
            ReturnList.Add(new User("test", "test", "test"));
            ReturnList.Add(new User("test", "test", "test"));
            ReturnList.Add(new User("test", "test", "test"));
            ReturnList.Add(new User("test", "test", "test"));


            return ReturnList;
        }
    }
}
