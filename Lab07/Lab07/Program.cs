using System;
using System.Linq;
using System.Collections.Generic;

namespace Lab07
{
    class Program
    {
        static void Main(string[] args)
        {
            //LINQ
            //Language Integrated Query
            //Lambdas

            /*var nums = new List<int>()
            {
                21, 420, 27, 12, 24, 666, 29, 7, 11, 23, 24, 69, 29
            };

            //suma de lista con metodo de linq
            var sum = nums.Sum();
            Console.WriteLine(sum);
            
            //separando la lista en dos con numeros pares e impares
            var even = nums.Where(i => i % 2 == 0).ToList();
            var odd = nums.Where(i => i % 2 != 0).ToList();
            
            //ordenando ascendente y desendente  lista
            var ordered = nums.OrderBy(i => i);
            var orderedDesc = nums.OrderByDescending(i => i);
            
            //creando lista de personas */

            var people = new List<Person>()
            {
                new Person() { Name = "Kevin", Age = 19 },
                new Person() { Name = "Brandon", Age = 19 },
                new Person() { Name = "Alex", Age = 20 },
                new Person() { Name = "Ignacio", Age = 19 },
                new Person() { Name = "Mariana", Age = 19 },
                new Person() { Name = "Erika", Age = 19 },
                new Person() { Name = "Marcelo", Age = 19 },
                new Person() { Name = "Alejandra", Age = 19 },
                new Person() { Name = "Cristian", Age = 20 },
            };
            
            //Sintaxis integrada 
            var result = from person in people
                //otra opcion seria por edad
                //where person.Age == 19
                where StartsWithVowel(person.Name)
                //ordenar por edad
                // orderby person.Age
                //otra opcion
                // orderby person.Age descending 
                orderby person.Name
                select person;

            foreach (var p in result)
            {
                Console.WriteLine(p);
            }
        }

        public static bool StartsWithVowel(string str)
        {
            str = str.ToLower();

            switch (str[0])
            {
                case 'a':
                case 'e':
                case 'i':
                case 'o':
                case 'u':
                    return true;
                default:
                    return false;
                    
            }
        }
    }
} 