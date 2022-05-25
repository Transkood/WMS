using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using System.Linq;

namespace WMS_i_guess
{
    public static class Program 
    {
        public static void Main(string[] args) 
        {
           Console.WriteLine("Введите элементы в следующем порядке: сначала наименование,далее вес, город отправления, город прибывания, контрактную компанию, количество. Если что-либо отсутствует,напишите тире");
           
           // разделение по запятым 
           string phrase = Console.ReadLine();
           string[] words = phrase.Split(', ');

           foreach (var word in words)
           {
               // пока что вывод в консоль, завтра подредактирую, а то сейчас лень
               Console.WriteLine($"<{word}>");
               // место для реализации добавления в бд по индексу слова в {words}
           }
        }
    }
}
