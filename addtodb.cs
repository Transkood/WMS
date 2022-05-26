using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Entity.Framework.Core;

namespace WMS_i_guess
{
    public static class Program 
    {
        public static void Main(string[] args) 
        {
           Console.WriteLine("Введите элементы в следующем порядке: сначала наименование, далее вес, город отправления, город прибывания, контрактную компанию, количество. Если что-либо отсутствует,напишите тире");
           
           // разделение по запятым 
           string phrase = Console.ReadLine();
           string[] words = phrase.Split(', ');


           foreach (var word in words)
           {
               // пока что вывод в консоль, завтра подредактирую, а то сейчас лень
               Console.WriteLine($"<{word}>");
               // разделяем по индексу
           }
        }
    }

    public class ApplicationContext : DbContext
    {
        public DbSet<Cargo> cargos { get; set; } = null!;
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {
            Database.EnsureCreated();   // создаем базу данных при первом обращении
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(
                    add.Cargo(name, weight, cityout, cityin, company, howmany)
            );
        }
    }
}
