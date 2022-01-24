using Modelo.Entidades;
using ModeloDB;
using System;
using System.Collections.Generic;

namespace Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            // Paises
            Country Ecuador = new Country() { country = "Ecuador", Last_update = DateTime.Now };
            Country Peru = new Country() { country = "Peru", Last_update = DateTime.Now };
            Country Colombia = new Country() { country = "Colombia", Last_update = DateTime.Now };
            Country Alemania = new Country() { country = "Alemania", Last_update = DateTime.Now };

            //Ciudades
            City Quito = new City() { city = "Quito", Country = Ecuador, Last_update = DateTime.Now };
            City Lima = new City() { city = "Lima", Country = Peru, Last_update = DateTime.Now };
            City Bogota = new City() { city = "Bogota", Country = Colombia, Last_update = DateTime.Now };
            City Munich = new City() { city = "Munich", Country = Alemania, Last_update = DateTime.Now };
            City Guayaquil = new City() { city = "Guayaquil", Country = Ecuador, Last_update = DateTime.Now };

            //Direcciones
            Address address = new Address() {
                address = "Colon S8-376",
                address2 = "",
                district = "Mariscal",
                City = Quito,
                postal_code = "250635",
                phone = "0986539847",
                Last_update = DateTime.Now };

            Address address2 = new Address()
            {
                address = "Jorge Basadre 498",
                address2 = "",
                district = "Lima ",
                City = Lima,
                postal_code = "15076",
                phone = "073388351",
                Last_update = DateTime.Now
            };

            Address address3 = new Address()
            {
                address = "Calle 16 No. 23 - 57",
                address2 = "",
                district = "Nariño",
                City = Bogota,
                postal_code = "359861",
                phone = "27236158",
                Last_update = DateTime.Now
            };

            Address address4 = new Address()
            {
                address = "Puruhá OE528",
                address2 = "",
                district = "Magdalena",
                City = Quito,
                postal_code = "150825",
                phone = "0963458798",
                Last_update = DateTime.Now
            };

            Address address5 = new Address()
            {
                address = "Larizo Montero 569",
                address2 = "",
                district = "Lima",
                City = Lima,
                postal_code = "1545678",
                phone = "073388351",
                Last_update = DateTime.Now
            };

            Address address6 = new Address()
            {
                address = "Escobar 59863",
                address2 = "",
                district = "Nariño",
                City = Bogota,
                postal_code = "458612",
                phone = "27896422",
                Last_update = DateTime.Now
            };

            Address address7 = new Address()
            {
                address = "Oberföhringer Str. 45",
                address2 = "",
                district = "München",
                City = Munich,
                postal_code = "81925",
                phone = "49899984790",
                Last_update = DateTime.Now
            };
            Address address8 = new Address()
            {
                address = "Herzog-Heinrich-Straße 23",
                address2 = "",
                district = "München",
                City = Munich,
                postal_code = "80336 ",
                phone = "498913928880",
                Last_update = DateTime.Now
            };
            Address address9 = new Address()
            {
                address = "Portete y la 26",
                address2 = "",
                district = "Portete",
                City = Guayaquil,
                postal_code = "1706398",
                phone = "0912365234",
                Last_update = DateTime.Now
            };
            Address address10 = new Address()
            {
                address = "9 de Ocutbre 5639",
                address2 = "",
                district = "Malecón",
                City = Guayaquil,
                postal_code = "1706898",
                phone = "098452478",
                Last_update = DateTime.Now
            };


            List<Address> ListaDirecciones = new List<Address> { address, address2, address3,address4,address5,address6,address7,address8,address9,address10 };
            EvaluacionDB  repos = new EvaluacionDB();
            repos.Addresses.AddRange(ListaDirecciones);
            repos.SaveChanges();
        }
    }
}
