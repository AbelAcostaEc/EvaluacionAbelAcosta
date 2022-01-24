using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Entidades
{
    public class Address
    {
        public int AddressId { get; set; }
        public string address { get; set; }
        public string address2 { get; set; }
        public string district { get; set; }
        public string postal_code { get; set; }
        public string phone { get; set; }        
        public DateTime Last_update { get; set; }


        // relacion City 
        public int CityId { get; set; }
        public City City { get; set; }

    }
}
