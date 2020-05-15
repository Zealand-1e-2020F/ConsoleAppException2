using ConsoleAppException2;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppException
{
    class Person
    {
        public string Navn { get; set; }

        public string Postnr { get; set; }

        public Person(string navn, string postnr)
        {

            if (navn != "Martin")
                throw new MartinException("Der skal stå Martin !");


            this.Navn = navn;

            if (postnr.Length != 4)
                throw new ArgumentOutOfRangeException("Postnr må kun være fire felter langt");

            this.Postnr = postnr;
        }


    }
}
