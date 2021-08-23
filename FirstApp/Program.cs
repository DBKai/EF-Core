using System;
using System.Linq;

namespace FirstApp
{
    class Program
    {
        static void Main(string[] args)
        {
            using (helloappdbContext db = new helloappdbContext())
            {
                var users = db.Users.ToList();
                Console.WriteLine("Список объектов");
                foreach (var user in users)
                {
                    Console.WriteLine($"{user.Id}.{user.Name} - {user.Age}");
                }
            }
            Console.ReadKey();
        }
    }
}
