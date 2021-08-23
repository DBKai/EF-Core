using System;
using System.Linq;

namespace HelloApp
{
    class Program
    {
        static void Main(string[] args)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                User user1 = new User { Name = "Tom", Age = 33 };
                User user2 = new User { Name = "Alice", Age = 26 };

                db.Users.Add(user1);
                db.Users.Add(user2);
                db.SaveChanges();
                Console.WriteLine("Объекты успешно сохранены");

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
