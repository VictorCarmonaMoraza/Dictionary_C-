using System;
using System.Collections.Generic;
using System.Linq;

namespace Diccionarios
{
    class Program
    {
        static void Main(string[] args)
        {
            //Se Crea el diccionario
            Dictionary<string, int> users = new Dictionary<string, int>();

            //Se añaden elementos al diccionario
            users.Add("Victor", 42);
            users.Add("Ana", 38);
            users.Add("Pedro", 12);
            users.Add("Jorge", 12);

            Console.WriteLine("Forma 1");
            Console.WriteLine("Victor tiene " + users["Victor"] + " años");
            Console.WriteLine("--------");
            Console.WriteLine("");

            Console.WriteLine("Forma 2");
            string key = "Pedro";
            if (users.ContainsKey(key))
            {
                Console.WriteLine("Victor tiene " + users[key] + " años");
            }
            Console.WriteLine("--------");
            Console.WriteLine("");


            Console.WriteLine("Forma 3-->Recorrido de la coleccion");
            foreach (KeyValuePair<string, int> user in users)
            {
                Console.WriteLine(user.Key + " tiene " + user.Value + " años");
            }
            Console.WriteLine("--------");
            Console.WriteLine("");

            Console.WriteLine("Forma 3-->Agregando elemento de forma segura");
            if (!users.ContainsKey("Lucia"))
            {
                users.Add("Lucia", 109);
            }
            Console.WriteLine("--------");
            Console.WriteLine("");

            Console.WriteLine("Ordenamiento por valor");
            foreach (KeyValuePair<string, int> user in users.OrderBy(user => user.Value))
            {
                Console.WriteLine(user.Key + " is " + user.Value + " years old");
            }
        }
    }
}
