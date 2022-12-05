using Phonebook.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phonebook.Data
{
    public class Database
    {
        public void Start(List<Person> phonebook)
        {
            Person person1 = new Person();
            person1.Name = "Muhammed";
            person1.SurName = "Solmaz";
            person1.Number = "5349888808";
            phonebook.Add(person1);

            Person person2 = new Person();
            person2.Name = "Mert";
            person2.SurName = "Sezgin";
            person2.Number = "5356714133";
            phonebook.Add(person2);

            Person person3 = new Person();
            person3.Name = "Ansu";
            person3.SurName = "Bakar";
            person3.Number = "5393728432";
            phonebook.Add(person3);

            Person person4 = new Person();
            person4.Name = "Ethem";
            person4.SurName = "Sevcen";
            person4.Number = "5323329089";
            phonebook.Add(person4);

            Person person5 = new Person();
            person5.Name = "Ahmet";
            person5.SurName = "Ulus";
            person5.Number = "5387668143";
            phonebook.Add(person5);
        }
    }
}