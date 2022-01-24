using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Entidades
{
    public class Country
    {
        public int CountryId { get; set; }
        public string country { get; set; }
        public DateTime Last_update { get; set; }

        // relacion City
        public List<City> Cities { get; set; }
    }
}
