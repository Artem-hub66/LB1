namespace LB1
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                //объявлем и создаём объекты user1 и user2, иницилизируем в эти переменные данные
                User user1 = new User { Name = "Том", Age = 33 };
                User user2 = new User { Name = "Алиса", Age = 26 };
                //Обращаемся к таблице и сохраняем БД
                db.Users.AddRange(user1, user2);
                db.SaveChanges();
            }
            //инцилизируем конфигуратор приложений
            ApplicationConfiguration.Initialize();
            Application.Run(new FormMain());
        }
    }
}