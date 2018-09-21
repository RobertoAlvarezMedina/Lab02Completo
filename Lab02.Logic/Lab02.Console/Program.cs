using Lab02.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab02.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Person");

            ILogger logger = new Person();
            Person person = new Person();

            person.Id = 1;
            person.Name = "Juan";
            person.LastName = "Perez";



            string personString = string.Format("Id:{0},Name:{1},LastName:{2}", person.Id, person.Name, person.LastName);

            System.Console.WriteLine(personString);
            logger.Log("Hello world");
            System.Console.ReadKey();
        }
    }
}
