using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Hasgtables_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Hashtable numberNames = new Hashtable();

            //numberNames.Add(1,"One");
            //numberNames.Add(2, "Two");
            //numberNames.Add(3, "Three");

            //foreach(DictionaryEntry ele in numberNames)
            //{
            //    Console.WriteLine("Key: {0}, Value: {1}",ele.Key, ele.Value);
            //}



            var cities = new Hashtable()
            {
                {"UK", "London, Manchester, Birmingham" },
                {"USA", "Chicago, New York, Washington" },
                {"RSA", "Cape Town, Port Elizabeth, Joburg" }
            };

            foreach(DictionaryEntry x in cities)
            {
                Console.WriteLine("Key: {0}, Value: {1}", x.Key, x.Value);
            }

            Console.WriteLine();
            string citiesOfUK = (string) cities["UK"];
            string citiesOfUSA = (string) cities["USA"];

            Console.WriteLine(citiesOfUK);
            Console.WriteLine(citiesOfUSA);

            Console.WriteLine();
            cities["UK"] = "Liverpool, Bristol";
            cities["USA"] = "Los Angeles, Boston";

            if(!cities.ContainsKey("France")) //if cities != " "
            {
                cities["France"] = "Paris";
            }         

           

            foreach (DictionaryEntry x in cities)
            {
                Console.WriteLine("Key: {0}, Value: {1}", x.Key, x.Value);
            }
            Console.WriteLine();

            cities.Remove("UK");
            cities.Remove("France");
            foreach (DictionaryEntry x in cities)
            {
                Console.WriteLine("Key: {0}, Value: {1}", x.Key, x.Value);
            }
        }
    }
}
