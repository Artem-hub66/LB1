using Microsoft.EntityFrameworkCore;

namespace LB1
{
    //Контекст предназначен для подключения к базе данных
    //и работы с таблицами
    internal class ApplicationContext: DbContext
    {
        //Свойство Users позволяет контексту работать с таблицей Users
        public  DbSet<User> Users { get; set; } = null;
        public ApplicationContext()
        {
            //Создаём базу данных и таблицы в ней
            Database.EnsureCreated();
        }
        //OnConfiguring этот метод содержит настройки для подключения к БД
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=usersdb2;Username=postgres;Password=1111");
        }
    }
}
