using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace secondo_esercizio
{
    internal class Person
    {
        public string FirstName;
        public string SecondName;
        public string BirthCity;
        public DateTime DateBirth;
        public string Gender;
        public string FiscalCode;

        public Person(string firstName, string secondName, string birthCity, DateTime dateBirth, string gender)
        {
            FirstName = firstName;
            SecondName = secondName;
            BirthCity = birthCity;
            DateBirth = dateBirth;
            Gender = gender;
            CodiceFiscaleUtility.CodiceFiscale cf;
            cf = new CodiceFiscaleUtility.CodiceFiscale(secondName,firstName,gender,dateBirth,birthCity);
        }
        public void in_nome()
        {
            Console.WriteLine("Inserisci il nome: ");
            FirstName = Console.ReadLine();
        }
        private void in_cognome()
        {
            Console.WriteLine("Inserisci il cognome: ");
            SecondName = Console.ReadLine();
        }
        private void in_citta()
        {
            Console.WriteLine("Inserisci la città di nascita: ");
            BirthCity = Console.ReadLine();
        }
        private void in_data()
        {
            Console.WriteLine("Inserisci la data di nascita: ");
            //string.TryParse(Console.ReadLine(), out DateBirth);
        }
        private void genere()
        {
            Console.WriteLine("Inserisci il tuo genere: ");
            Gender = Console.ReadLine();
        }
    }
}
