using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BackEnd_ejemplo1.Models
{
    public class Garaje:List<Coche>
    {
        public Garaje()
        {
            this.Add(new Coche("1", "Tesla", "Roadster", "Elon Musk"));
            this.Add(new Coche("2", "Toyota", "Yaris", "Domingo Garcia"));
            this.Add(new Coche("3", "Honda", "Civic", "Juan Antonio"));
            this.Add(new Coche("4", "Ferrari", "F40", "Roberto Cardiel"));
        }
    }
}