using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATA_ACCES_LAYER.Model
{
    public class Animal
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Species { get; set; }
        public string ? Gender { get; set; }
        public double Age { get; set; }
        public DateTime ArrivalDate { get; set; }
    }
}
