using System;
using System.Linq;

namespace CRUD
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Добавление
            using (ApplicationContext db = new ApplicationContext())
            {
                var user1 = new User { Name = "Tom", Age = 33 };
                var user2 = new User { Name = "Alice", Age = 26 };
                db.Users.Add(user1);
                db.Users.Add(user2);
                db.SaveChanges();
            }
            #endregion
            #region Получение
            using (ApplicationContext db = new ApplicationContext())
            {
                Console.WriteLine("Данные после добавления:");
                db.Users.ToList().ForEach(u => Console.WriteLine(u.ToString()));
            }
            #endregion
            #region Редактирование
            using (ApplicationContext db = new ApplicationContext())
            {
                var user = db.Users.FirstOrDefault();

                if (user != null)
                {
                    user.Name = "Bob";
                    user.Age = 44;
                    //db.Users.Update(user);
                    db.SaveChanges();
                }
                Console.WriteLine("\nДанные после редактирования:");
                db.Users.ToList().ForEach(u => Console.WriteLine(u.ToString()));
            }
            #endregion
            #region Удаление
            using (ApplicationContext db = new ApplicationContext())
            {
                var user = db.Users.FirstOrDefault();

                if (user != null)
                {
                    db.Users.Remove(user);
                    db.SaveChanges();
                }
                Console.WriteLine("\nДанные после удаления:");
                db.Users.ToList().ForEach(u => Console.WriteLine(u.ToString()));
            }
            #endregion
            Console.ReadKey();
        }
    }
}
