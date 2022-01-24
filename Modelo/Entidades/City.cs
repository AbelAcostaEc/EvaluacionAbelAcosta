using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Entidades
{
    public class City
    {
        public int CityId { get; set; }
        public string city { get; set; }
        public DateTime Last_update { get; set; }


        // relacion Country 
        public int CountryId { get; set; }
        public Country Country { get; set; }

        public List<Address> addresses { get; set; }

    }
}
