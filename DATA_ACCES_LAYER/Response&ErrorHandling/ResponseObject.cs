using DATA_ACCES_LAYER.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATA_ACCES_LAYER.Response_ErrorHandling
{
    public class ResponseObject<T>
    {
       public bool success {  get; set; }
       public String Message {  get; set; } = string.Empty;
        public List<T>? Object;
        
    }
}
